using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esp32Supervisor
{
    public partial class Form1 : Form
    {
        private readonly SerialPort _serialPort = new SerialPort();
        private readonly object _serialLock = new object();
        private readonly StringBuilder _receiveBuffer = new StringBuilder();
        private bool _historyDownloadInProgress;
        private int _historyIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _serialPort.DataReceived += DataReceivedHandler;
            _serialPort.NewLine = "\n";
            _serialPort.ReadTimeout = 1000;
            _serialPort.WriteTimeout = 1000;

            comboBaud.Items.AddRange(new object[]
            {
                "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"
            });
            comboBaud.SelectedItem = "19200";

            sourceAddressUpDown.Minimum = 1;
            sourceAddressUpDown.Maximum = 99;
            sourceAddressUpDown.Value = 1;

            relayAddressUpDown.Minimum = 100;
            relayAddressUpDown.Maximum = 199;
            relayAddressUpDown.Value = 100;

            hourUpDown.Minimum = 0;
            hourUpDown.Maximum = 23;
            minuteUpDown.Minimum = 0;
            minuteUpDown.Maximum = 59;

            hostBox.Text = "localhost";
            databaseBox.Text = "esp32_supervision";
            userBox.Text = "root";

            SetConnectionState(false);
            SetDatabaseFieldsVisible(false);
            exportBtn.Enabled = false;
            downloadLabel.Visible = false;
            progressBar.Visible = false;
            ConfigureHistoryGrid();
            ScanPorts();
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            ScanPorts();
        }

        private void ScanPorts()
        {
            string previousSelection = comboPortCom.SelectedItem as string;
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports, StringComparer.OrdinalIgnoreCase);

            comboPortCom.Items.Clear();
            foreach (string port in ports)
            {
                comboPortCom.Items.Add(port);
            }

            if (ports.Length == 0)
            {
                comboPortCom.Items.Add("None");
                comboPortCom.SelectedIndex = 0;
                labelCalendar.Text = "Aucun port COM détecté.";
                return;
            }

            if (!string.IsNullOrWhiteSpace(previousSelection) && comboPortCom.Items.Contains(previousSelection))
            {
                comboPortCom.SelectedItem = previousSelection;
            }
            else
            {
                comboPortCom.SelectedIndex = 0;
            }

            labelCalendar.Text = ports.Length + " port(s) COM détecté(s).";
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            string portName = comboPortCom.SelectedItem as string;
            string baudText = comboBaud.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(portName) || portName == "None")
            {
                MessageBox.Show("Sélectionnez un port COM valide.", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(baudText, out int baudRate))
            {
                MessageBox.Show("Sélectionnez un débit valide.", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }

                _serialPort.PortName = portName;
                _serialPort.BaudRate = baudRate;
                _serialPort.Parity = Parity.None;
                _serialPort.DataBits = 8;
                _serialPort.StopBits = StopBits.One;
                _serialPort.Handshake = Handshake.None;
                _serialPort.DtrEnable = true;
                _serialPort.RtsEnable = false;
                _serialPort.Open();

                SetConnectionState(true);
                labelCalendar.Text = "Connexion série établie sur " + portName + " à " + baudRate + " bauds.";
            }
            catch (Exception exception)
            {
                SetConnectionState(false);
                MessageBox.Show(exception.Message, "Erreur COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            DisconnectSerialPort();
        }

        private void DisconnectSerialPort()
        {
            try
            {
                _historyDownloadInProgress = false;
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetConnectionState(false);
                labelCalendar.Text = "Port série déconnecté.";
            }
        }

        private void SetConnectionState(bool connected)
        {
            pictureStatus.BackColor = connected ? Color.RoyalBlue : Color.Firebrick;
            statusValueLabel.Text = connected ? "CONNECTÉ" : "DÉCONNECTÉ";
            statusValueLabel.ForeColor = connected ? Color.RoyalBlue : Color.Firebrick;

            connectBtn.Visible = !connected;
            disconnectBtn.Visible = connected;
            comboPortCom.Enabled = !connected;
            comboBaud.Enabled = !connected;
            scanBtn.Enabled = !connected;

            calendarBtn.Enabled = connected;
            frequencyBtn.Enabled = connected;
            enableBtn.Enabled = connected;
            measureBtn.Enabled = connected;

            UpdateArchiveButtonStates();
        }

        private void CalendarBtn_Click(object sender, EventArgs e)
        {
            string calendar = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            SendSerialCommand("AT+T=" + calendar);
        }

        private void FrequencyBtn_Click(object sender, EventArgs e)
        {
            int hours = Decimal.ToInt32(hourUpDown.Value);
            int minutes = Decimal.ToInt32(minuteUpDown.Value);

            if (hours == 0 && minutes == 0)
            {
                MessageBox.Show("La fréquence 00 h 00 est interdite.", "Fréquence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SendSerialCommand("AT+F=" + hours + "H" + minutes);
        }

        private void EnableBtn_Click(object sender, EventArgs e)
        {
            string address = sourceAddressUpDown.Value.ToString(CultureInfo.InvariantCulture)
                + ","
                + relayAddressUpDown.Value.ToString(CultureInfo.InvariantCulture);
            SendSerialCommand("AT+A=" + address);
        }

        private void MeasureBtn_Click(object sender, EventArgs e)
        {
            SendSerialCommand("AT+M?");
        }

        private void SendSerialCommand(string command)
        {
            if (!_serialPort.IsOpen)
            {
                MessageBox.Show("Le port COM n'est pas connecté.", "Communication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                lock (_serialLock)
                {
                    _serialPort.WriteLine(command);
                }
                labelCalendar.Text = "Commande envoyée : " + command;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur d'envoi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(25);
                string incoming = _serialPort.ReadExisting();
                if (string.IsNullOrEmpty(incoming))
                {
                    return;
                }

                lock (_receiveBuffer)
                {
                    _receiveBuffer.Append(incoming.Replace("\r", string.Empty));
                    ExtractMessagesFromBuffer();
                }
            }
            catch (Exception exception)
            {
                BeginInvoke(new Action(() =>
                    MessageBox.Show(exception.Message, "Erreur de réception", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }

        private void ExtractMessagesFromBuffer()
        {
            while (true)
            {
                string buffer = _receiveBuffer.ToString();
                int newlineIndex = buffer.IndexOf('\n');

                if (newlineIndex >= 0)
                {
                    string line = buffer.Substring(0, newlineIndex).Trim();
                    _receiveBuffer.Remove(0, newlineIndex + 1);
                    if (line.Length > 0)
                    {
                        BeginInvoke(new Action<string>(ProcessIncomingMessage), line);
                    }
                    continue;
                }

                if (LooksLikeCompleteMessage(buffer))
                {
                    _receiveBuffer.Clear();
                    BeginInvoke(new Action<string>(ProcessIncomingMessage), buffer.Trim());
                }
                break;
            }
        }

        private static bool LooksLikeCompleteMessage(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            string trimmed = value.Trim();
            if (trimmed.StartsWith("AT+M=", StringComparison.Ordinal) && trimmed.Split(',').Length >= 4)
            {
                return true;
            }
            if (trimmed.StartsWith("AT+H=", StringComparison.Ordinal) && trimmed.Split(',').Length >= 4)
            {
                return true;
            }
            return trimmed.StartsWith("AT+OK", StringComparison.Ordinal)
                || trimmed.StartsWith("DELETE SUCCESS", StringComparison.Ordinal)
                || trimmed.StartsWith("AT+T=", StringComparison.Ordinal)
                || trimmed.StartsWith("AT+F=", StringComparison.Ordinal)
                || trimmed.StartsWith("AT+A=", StringComparison.Ordinal);
        }

        private void ProcessIncomingMessage(string message)
        {
            if (message.StartsWith("AT+M=", StringComparison.Ordinal))
            {
                DisplayLiveMeasurement(message);
                return;
            }

            if (message.StartsWith("AT+H=", StringComparison.Ordinal))
            {
                DisplayHistoryMeasurement(message);
                return;
            }

            if (message.StartsWith("AT+OK", StringComparison.Ordinal))
            {
                FinishHistoryDownload("Toutes les données EEPROM ont été téléchargées.");
                return;
            }

            if (message.StartsWith("DELETE SUCCESS", StringComparison.Ordinal))
            {
                labelCalendar.Text = "Suppression EEPROM réussie.";
                histDataGridView.Rows.Clear();
                exportBtn.Enabled = false;
                eraseBtn.Enabled = true;
                return;
            }

            labelCalendar.Text = message;
        }

        private void DisplayLiveMeasurement(string message)
        {
            string[] elements = message.Substring(5).Split(',');
            if (elements.Length < 4)
            {
                labelCalendar.Text = "Trame de mesure incomplète : " + message;
                return;
            }

            tempLabel.Text = elements[0].Trim();
            humLabel.Text = elements[1].Trim();
            resLabel.Text = elements[2].Trim();
            currentLabel.Text = elements[3].Trim();
            labelCalendar.Text = "Mesure reçue à " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void DisplayHistoryMeasurement(string message)
        {
            string[] elements = message.Substring(5).Split(',');
            if (elements.Length < 4)
            {
                labelCalendar.Text = "Trame historique incomplète : " + message;
                return;
            }

            histDataGridView.Rows.Add(
                _historyIndex + 1,
                elements[0].Trim(),
                elements[1].Trim(),
                elements[2].Trim(),
                string.Empty,
                elements[3].Trim());

            _historyIndex++;
            labelCalendar.Text = _historyIndex + " mesure(s) téléchargée(s).";
            exportBtn.Enabled = histDataGridView.Rows.Count > 0;

            if (_historyDownloadInProgress && _serialPort.IsOpen)
            {
                SendSerialCommand("AT+H?");
            }
        }

        private void DataEepromCheck_CheckedChanged(object sender, EventArgs e)
        {
            SetDatabaseFieldsVisible(dataEepromCheck.Checked);
            UpdateArchiveButtonStates();
            labelCalendar.Text = dataEepromCheck.Checked
                ? "Mode archive : base de données MySQL."
                : "Mode archive : mémoire EEPROM de la carte.";
        }

        private void SetDatabaseFieldsVisible(bool visible)
        {
            hostLabel.Visible = visible;
            hostBox.Visible = visible;
            databaseLabel.Visible = visible;
            databaseBox.Visible = visible;
            userLabel.Visible = visible;
            userBox.Visible = visible;
            pswLabel.Visible = visible;
            pswBox.Visible = visible;
        }

        private void UpdateArchiveButtonStates()
        {
            bool databaseMode = dataEepromCheck.Checked;
            bool serialModeAvailable = _serialPort.IsOpen;
            historicBtn.Enabled = databaseMode || serialModeAvailable;
            eraseBtn.Enabled = databaseMode || serialModeAvailable;
        }

        private async void HistoricBtn_Click(object sender, EventArgs e)
        {
            exportBtn.Enabled = false;
            eraseBtn.Enabled = false;
            historicBtn.Enabled = false;
            histDataGridView.DataSource = null;
            histDataGridView.Rows.Clear();

            if (dataEepromCheck.Checked)
            {
                await LoadHistoryFromDatabaseAsync();
            }
            else
            {
                StartEepromHistoryDownload();
            }
        }

        private async Task LoadHistoryFromDatabaseAsync()
        {
            if (!TryGetDatabaseConfiguration(out string connectionString))
            {
                UpdateArchiveButtonStates();
                return;
            }

            SetDownloadState(true, "Téléchargement depuis MySQL...");
            try
            {
                DataTable table = new DataTable();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(
                    "SELECT id AS ID, resistance AS RESISTANCE, humidity AS HUMIDITE, " +
                    "temperature AS TEMPERATURE, current_ma AS COURANT_MA, created_at AS DATE_HEURE " +
                    "FROM measurements ORDER BY created_at DESC, id DESC", connection))
                {
                    await connection.OpenAsync();
                    adapter.Fill(table);
                }

                histDataGridView.Columns.Clear();
                histDataGridView.AutoGenerateColumns = true;
                histDataGridView.DataSource = table;

                labelCalendar.Text = table.Rows.Count + " mesure(s) chargée(s) depuis MySQL.";
                exportBtn.Enabled = table.Rows.Count > 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetDownloadState(false, string.Empty);
                UpdateArchiveButtonStates();
            }
        }

        private void StartEepromHistoryDownload()
        {
            if (!_serialPort.IsOpen)
            {
                MessageBox.Show("Connectez d'abord le port COM.", "Historique EEPROM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UpdateArchiveButtonStates();
                return;
            }

            ConfigureHistoryGrid();
            _historyIndex = 0;
            _historyDownloadInProgress = true;
            SetDownloadState(true, "Téléchargement depuis l'EEPROM...");
            SendSerialCommand("AT+H?");
        }

        private void ConfigureHistoryGrid()
        {
            histDataGridView.DataSource = null;
            histDataGridView.AutoGenerateColumns = false;
            histDataGridView.Columns.Clear();
            histDataGridView.Columns.Add("idColumn", "ID");
            histDataGridView.Columns.Add("resistanceColumn", "RÉSISTANCE");
            histDataGridView.Columns.Add("humidityColumn", "HUMIDITÉ");
            histDataGridView.Columns.Add("temperatureColumn", "TEMPÉRATURE");
            histDataGridView.Columns.Add("currentColumn", "COURANT mA");
            histDataGridView.Columns.Add("timeColumn", "DATE / HEURE");
        }

        private void FinishHistoryDownload(string message)
        {
            _historyDownloadInProgress = false;
            SetDownloadState(false, string.Empty);
            labelCalendar.Text = message;
            exportBtn.Enabled = histDataGridView.Rows.Count > 0;
            UpdateArchiveButtonStates();
        }

        private void SetDownloadState(bool active, string message)
        {
            progressBar.Visible = active;
            downloadLabel.Visible = active;
            downloadLabel.Text = message;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = active ? 25 : 0;
        }

        private async void EraseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer toutes les mesures ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            if (dataEepromCheck.Checked)
            {
                await EraseDatabaseAsync();
            }
            else
            {
                SendSerialCommand("AT+E?");
            }
        }

        private async Task EraseDatabaseAsync()
        {
            if (!TryGetDatabaseConfiguration(out string connectionString))
            {
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand("DELETE FROM measurements", connection))
                {
                    await connection.OpenAsync();
                    int deletedRows = await command.ExecuteNonQueryAsync();
                    histDataGridView.DataSource = null;
                    ConfigureHistoryGrid();
                    exportBtn.Enabled = false;
                    labelCalendar.Text = deletedRows + " ligne(s) supprimée(s) de MySQL.";
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryGetDatabaseConfiguration(out string connectionString)
        {
            connectionString = string.Empty;
            string host = hostBox.Text.Trim();
            string database = databaseBox.Text.Trim();
            string user = userBox.Text.Trim();
            string password = pswBox.Text;

            if (string.IsNullOrWhiteSpace(host)
                || string.IsNullOrWhiteSpace(database)
                || string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Renseignez l'hôte, la base et l'utilisateur MySQL.", "Configuration MySQL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = host,
                Database = database,
                UserID = user,
                Password = password,
                SslMode = MySqlSslMode.Preferred,
                ConnectionTimeout = 10,
                DefaultCommandTimeout = 20,
                CharacterSet = "utf8mb4"
            };
            connectionString = builder.ConnectionString;
            return true;
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            if (histDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée à exporter.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Fichier texte (*.txt)|*.txt|Fichier CSV (*.csv)|*.csv";
                dialog.DefaultExt = "txt";
                dialog.FileName = "mesures-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".txt";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SaveDataGridViewToText(dialog.FileName);
                }
            }
        }

        private void SaveDataGridViewToText(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false, new UTF8Encoding(true)))
                {
                    for (int columnIndex = 0; columnIndex < histDataGridView.Columns.Count; columnIndex++)
                    {
                        if (columnIndex > 0)
                        {
                            writer.Write('\t');
                        }
                        writer.Write(histDataGridView.Columns[columnIndex].HeaderText);
                    }
                    writer.WriteLine();

                    foreach (DataGridViewRow row in histDataGridView.Rows)
                    {
                        if (row.IsNewRow)
                        {
                            continue;
                        }

                        for (int columnIndex = 0; columnIndex < histDataGridView.Columns.Count; columnIndex++)
                        {
                            if (columnIndex > 0)
                            {
                                writer.Write('\t');
                            }
                            string value = Convert.ToString(row.Cells[columnIndex].Value, CultureInfo.InvariantCulture) ?? string.Empty;
                            writer.Write(value.Replace("\t", " ").Replace("\r", " ").Replace("\n", " "));
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Données exportées avec succès.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erreur d'export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                _serialPort.DataReceived -= DataReceivedHandler;
                if (_serialPort.IsOpen)
                {
                    _serialPort.Close();
                }
                _serialPort.Dispose();
            }
            catch
            {
                // The program is closing; no further user action is required.
            }
        }
    }
}
