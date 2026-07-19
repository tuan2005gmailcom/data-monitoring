namespace Esp32Supervisor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topLayout = new System.Windows.Forms.TableLayoutPanel();
            this.comGroup = new System.Windows.Forms.GroupBox();
            this.comLayout = new System.Windows.Forms.TableLayoutPanel();
            this.scanBtn = new System.Windows.Forms.Button();
            this.comboPortCom = new System.Windows.Forms.ComboBox();
            this.baudLabel = new System.Windows.Forms.Label();
            this.comboBaud = new System.Windows.Forms.ComboBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureStatus = new System.Windows.Forms.PictureBox();
            this.statusValueLabel = new System.Windows.Forms.Label();
            this.timeGroup = new System.Windows.Forms.GroupBox();
            this.timeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.frequencyBtn = new System.Windows.Forms.Button();
            this.hourUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourLabel = new System.Windows.Forms.Label();
            this.minuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.labelCalendar = new System.Windows.Forms.Label();
            this.middleLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loraGroup = new System.Windows.Forms.GroupBox();
            this.loraLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sourceAddressLabel = new System.Windows.Forms.Label();
            this.sourceAddressUpDown = new System.Windows.Forms.NumericUpDown();
            this.relayAddressLabel = new System.Windows.Forms.Label();
            this.relayAddressUpDown = new System.Windows.Forms.NumericUpDown();
            this.enableBtn = new System.Windows.Forms.Button();
            this.measureGroup = new System.Windows.Forms.GroupBox();
            this.measureLayout = new System.Windows.Forms.TableLayoutPanel();
            this.measureBtn = new System.Windows.Forms.Button();
            this.temperatureTitleLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.humidityTitleLabel = new System.Windows.Forms.Label();
            this.humLabel = new System.Windows.Forms.Label();
            this.resistanceTitleLabel = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.currentTitleLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.archiveGroup = new System.Windows.Forms.GroupBox();
            this.archiveLayout = new System.Windows.Forms.TableLayoutPanel();
            this.archiveControlsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.dataEepromCheck = new System.Windows.Forms.CheckBox();
            this.historicBtn = new System.Windows.Forms.Button();
            this.eraseBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.databaseLayout = new System.Windows.Forms.TableLayoutPanel();
            this.hostLabel = new System.Windows.Forms.Label();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.databaseBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.pswLabel = new System.Windows.Forms.Label();
            this.pswBox = new System.Windows.Forms.TextBox();
            this.downloadLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.histDataGridView = new System.Windows.Forms.DataGridView();
            this.mainLayout.SuspendLayout();
            this.topLayout.SuspendLayout();
            this.comGroup.SuspendLayout();
            this.comLayout.SuspendLayout();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatus)).BeginInit();
            this.timeGroup.SuspendLayout();
            this.timeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).BeginInit();
            this.middleLayout.SuspendLayout();
            this.loraGroup.SuspendLayout();
            this.loraLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceAddressUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relayAddressUpDown)).BeginInit();
            this.measureGroup.SuspendLayout();
            this.measureLayout.SuspendLayout();
            this.archiveGroup.SuspendLayout();
            this.archiveLayout.SuspendLayout();
            this.archiveControlsLayout.SuspendLayout();
            this.databaseLayout.SuspendLayout();
            this.downloadLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.topLayout, 0, 0);
            this.mainLayout.Controls.Add(this.middleLayout, 0, 1);
            this.mainLayout.Controls.Add(this.archiveGroup, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(12, 12);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1152, 716);
            this.mainLayout.TabIndex = 0;
            // 
            // topLayout
            // 
            this.topLayout.ColumnCount = 2;
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.topLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.topLayout.Controls.Add(this.comGroup, 0, 0);
            this.topLayout.Controls.Add(this.timeGroup, 1, 0);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLayout.Location = new System.Drawing.Point(3, 3);
            this.topLayout.Name = "topLayout";
            this.topLayout.RowCount = 1;
            this.topLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayout.Size = new System.Drawing.Size(1146, 204);
            this.topLayout.TabIndex = 0;
            // 
            // comGroup
            // 
            this.comGroup.Controls.Add(this.comLayout);
            this.comGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.comGroup.Location = new System.Drawing.Point(3, 3);
            this.comGroup.Name = "comGroup";
            this.comGroup.Padding = new System.Windows.Forms.Padding(10);
            this.comGroup.Size = new System.Drawing.Size(429, 198);
            this.comGroup.TabIndex = 0;
            this.comGroup.TabStop = false;
            this.comGroup.Text = "SETTING COM";
            // 
            // comLayout
            // 
            this.comLayout.ColumnCount = 2;
            this.comLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.comLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.comLayout.Controls.Add(this.scanBtn, 0, 0);
            this.comLayout.Controls.Add(this.comboPortCom, 1, 0);
            this.comLayout.Controls.Add(this.baudLabel, 0, 1);
            this.comLayout.Controls.Add(this.comboBaud, 1, 1);
            this.comLayout.Controls.Add(this.connectBtn, 0, 2);
            this.comLayout.Controls.Add(this.disconnectBtn, 1, 2);
            this.comLayout.Controls.Add(this.statusLabel, 0, 3);
            this.comLayout.Controls.Add(this.statusPanel, 1, 3);
            this.comLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comLayout.Location = new System.Drawing.Point(10, 28);
            this.comLayout.Name = "comLayout";
            this.comLayout.RowCount = 4;
            this.comLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.comLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.comLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.comLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.comLayout.Size = new System.Drawing.Size(409, 160);
            this.comLayout.TabIndex = 0;
            // 
            // scanBtn
            // 
            this.scanBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scanBtn.Location = new System.Drawing.Point(3, 3);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(165, 34);
            this.scanBtn.TabIndex = 0;
            this.scanBtn.Text = "SCAN PORT";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
            // 
            // comboPortCom
            // 
            this.comboPortCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboPortCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPortCom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboPortCom.FormattingEnabled = true;
            this.comboPortCom.Location = new System.Drawing.Point(174, 6);
            this.comboPortCom.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.comboPortCom.Name = "comboPortCom";
            this.comboPortCom.Size = new System.Drawing.Size(232, 23);
            this.comboPortCom.TabIndex = 1;
            // 
            // baudLabel
            // 
            this.baudLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baudLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baudLabel.Location = new System.Drawing.Point(3, 40);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(165, 40);
            this.baudLabel.TabIndex = 2;
            this.baudLabel.Text = "BAUD";
            this.baudLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBaud
            // 
            this.comboBaud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBaud.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBaud.FormattingEnabled = true;
            this.comboBaud.Location = new System.Drawing.Point(174, 46);
            this.comboBaud.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(232, 23);
            this.comboBaud.TabIndex = 3;
            // 
            // connectBtn
            // 
            this.connectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.connectBtn.Location = new System.Drawing.Point(3, 83);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(165, 34);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disconnectBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.disconnectBtn.Location = new System.Drawing.Point(174, 83);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(232, 34);
            this.disconnectBtn.TabIndex = 5;
            this.disconnectBtn.Text = "DISCONNECT";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusLabel.Location = new System.Drawing.Point(3, 120);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(165, 40);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "STATUS";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.pictureStatus);
            this.statusPanel.Controls.Add(this.statusValueLabel);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusPanel.Location = new System.Drawing.Point(174, 123);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.statusPanel.Size = new System.Drawing.Size(232, 34);
            this.statusPanel.TabIndex = 7;
            // 
            // pictureStatus
            // 
            this.pictureStatus.BackColor = System.Drawing.Color.Firebrick;
            this.pictureStatus.Location = new System.Drawing.Point(3, 8);
            this.pictureStatus.Name = "pictureStatus";
            this.pictureStatus.Size = new System.Drawing.Size(34, 18);
            this.pictureStatus.TabIndex = 0;
            this.pictureStatus.TabStop = false;
            // 
            // statusValueLabel
            // 
            this.statusValueLabel.AutoSize = true;
            this.statusValueLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.statusValueLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.statusValueLabel.Location = new System.Drawing.Point(45, 8);
            this.statusValueLabel.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.statusValueLabel.Name = "statusValueLabel";
            this.statusValueLabel.Size = new System.Drawing.Size(82, 15);
            this.statusValueLabel.TabIndex = 1;
            this.statusValueLabel.Text = "DÉCONNECTÉ";
            // 
            // timeGroup
            // 
            this.timeGroup.Controls.Add(this.timeLayout);
            this.timeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.timeGroup.Location = new System.Drawing.Point(438, 3);
            this.timeGroup.Name = "timeGroup";
            this.timeGroup.Padding = new System.Windows.Forms.Padding(10);
            this.timeGroup.Size = new System.Drawing.Size(705, 198);
            this.timeGroup.TabIndex = 1;
            this.timeGroup.TabStop = false;
            this.timeGroup.Text = "SETTING TIME";
            // 
            // timeLayout
            // 
            this.timeLayout.ColumnCount = 6;
            this.timeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.timeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.timeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.timeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.timeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.timeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.timeLayout.Controls.Add(this.calendarBtn, 0, 0);
            this.timeLayout.Controls.Add(this.frequencyBtn, 1, 0);
            this.timeLayout.Controls.Add(this.hourUpDown, 2, 0);
            this.timeLayout.Controls.Add(this.hourLabel, 3, 0);
            this.timeLayout.Controls.Add(this.minuteUpDown, 4, 0);
            this.timeLayout.Controls.Add(this.minuteLabel, 5, 0);
            this.timeLayout.Controls.Add(this.labelCalendar, 0, 1);
            this.timeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLayout.Location = new System.Drawing.Point(10, 28);
            this.timeLayout.Name = "timeLayout";
            this.timeLayout.RowCount = 2;
            this.timeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.timeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timeLayout.Size = new System.Drawing.Size(685, 160);
            this.timeLayout.TabIndex = 0;
            // 
            // calendarBtn
            // 
            this.calendarBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calendarBtn.Location = new System.Drawing.Point(3, 8);
            this.calendarBtn.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(138, 42);
            this.calendarBtn.TabIndex = 0;
            this.calendarBtn.Text = "CALENDAR";
            this.calendarBtn.UseVisualStyleBackColor = true;
            this.calendarBtn.Click += new System.EventHandler(this.CalendarBtn_Click);
            // 
            // frequencyBtn
            // 
            this.frequencyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frequencyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.frequencyBtn.Location = new System.Drawing.Point(147, 8);
            this.frequencyBtn.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.frequencyBtn.Name = "frequencyBtn";
            this.frequencyBtn.Size = new System.Drawing.Size(138, 42);
            this.frequencyBtn.TabIndex = 1;
            this.frequencyBtn.Text = "FREQUENCY";
            this.frequencyBtn.UseVisualStyleBackColor = true;
            this.frequencyBtn.Click += new System.EventHandler(this.FrequencyBtn_Click);
            // 
            // hourUpDown
            // 
            this.hourUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hourUpDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hourUpDown.Location = new System.Drawing.Point(299, 16);
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Size = new System.Drawing.Size(115, 25);
            this.hourUpDown.TabIndex = 2;
            // 
            // hourLabel
            // 
            this.hourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hourLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hourLabel.Location = new System.Drawing.Point(428, 0);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(54, 58);
            this.hourLabel.TabIndex = 3;
            this.hourLabel.Text = "H";
            this.hourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minuteUpDown
            // 
            this.minuteUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minuteUpDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.minuteUpDown.Location = new System.Drawing.Point(496, 16);
            this.minuteUpDown.Name = "minuteUpDown";
            this.minuteUpDown.Size = new System.Drawing.Size(115, 25);
            this.minuteUpDown.TabIndex = 4;
            // 
            // minuteLabel
            // 
            this.minuteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minuteLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.minuteLabel.Location = new System.Drawing.Point(625, 0);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(57, 58);
            this.minuteLabel.TabIndex = 5;
            this.minuteLabel.Text = "MIN";
            this.minuteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCalendar
            // 
            this.labelCalendar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLayout.SetColumnSpan(this.labelCalendar, 6);
            this.labelCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCalendar.Font = new System.Drawing.Font("Consolas", 9F);
            this.labelCalendar.Location = new System.Drawing.Point(8, 66);
            this.labelCalendar.Margin = new System.Windows.Forms.Padding(8);
            this.labelCalendar.Name = "labelCalendar";
            this.labelCalendar.Padding = new System.Windows.Forms.Padding(8);
            this.labelCalendar.Size = new System.Drawing.Size(669, 86);
            this.labelCalendar.TabIndex = 6;
            this.labelCalendar.Text = "Prêt.";
            this.labelCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // middleLayout
            // 
            this.middleLayout.ColumnCount = 2;
            this.middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.middleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.middleLayout.Controls.Add(this.loraGroup, 0, 0);
            this.middleLayout.Controls.Add(this.measureGroup, 1, 0);
            this.middleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middleLayout.Location = new System.Drawing.Point(3, 213);
            this.middleLayout.Name = "middleLayout";
            this.middleLayout.RowCount = 1;
            this.middleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.middleLayout.Size = new System.Drawing.Size(1146, 184);
            this.middleLayout.TabIndex = 1;
            // 
            // loraGroup
            // 
            this.loraGroup.Controls.Add(this.loraLayout);
            this.loraGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loraGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.loraGroup.Location = new System.Drawing.Point(3, 3);
            this.loraGroup.Name = "loraGroup";
            this.loraGroup.Padding = new System.Windows.Forms.Padding(10);
            this.loraGroup.Size = new System.Drawing.Size(429, 178);
            this.loraGroup.TabIndex = 0;
            this.loraGroup.TabStop = false;
            this.loraGroup.Text = "SETTING LORA";
            // 
            // loraLayout
            // 
            this.loraLayout.ColumnCount = 2;
            this.loraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.loraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.loraLayout.Controls.Add(this.sourceAddressLabel, 0, 0);
            this.loraLayout.Controls.Add(this.sourceAddressUpDown, 1, 0);
            this.loraLayout.Controls.Add(this.relayAddressLabel, 0, 1);
            this.loraLayout.Controls.Add(this.relayAddressUpDown, 1, 1);
            this.loraLayout.Controls.Add(this.enableBtn, 0, 2);
            this.loraLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loraLayout.Location = new System.Drawing.Point(10, 28);
            this.loraLayout.Name = "loraLayout";
            this.loraLayout.RowCount = 3;
            this.loraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.loraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.loraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.loraLayout.Size = new System.Drawing.Size(409, 140);
            this.loraLayout.TabIndex = 0;
            // 
            // sourceAddressLabel
            // 
            this.sourceAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceAddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sourceAddressLabel.Location = new System.Drawing.Point(3, 0);
            this.sourceAddressLabel.Name = "sourceAddressLabel";
            this.sourceAddressLabel.Size = new System.Drawing.Size(218, 46);
            this.sourceAddressLabel.TabIndex = 0;
            this.sourceAddressLabel.Text = "SOURCE ADDRESS (1-99)";
            this.sourceAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sourceAddressUpDown
            // 
            this.sourceAddressUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sourceAddressUpDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sourceAddressUpDown.Location = new System.Drawing.Point(257, 10);
            this.sourceAddressUpDown.Name = "sourceAddressUpDown";
            this.sourceAddressUpDown.Size = new System.Drawing.Size(118, 25);
            this.sourceAddressUpDown.TabIndex = 1;
            // 
            // relayAddressLabel
            // 
            this.relayAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relayAddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.relayAddressLabel.Location = new System.Drawing.Point(3, 46);
            this.relayAddressLabel.Name = "relayAddressLabel";
            this.relayAddressLabel.Size = new System.Drawing.Size(218, 46);
            this.relayAddressLabel.TabIndex = 2;
            this.relayAddressLabel.Text = "RELAY ADDRESS (100-199)";
            this.relayAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // relayAddressUpDown
            // 
            this.relayAddressUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.relayAddressUpDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.relayAddressUpDown.Location = new System.Drawing.Point(257, 56);
            this.relayAddressUpDown.Name = "relayAddressUpDown";
            this.relayAddressUpDown.Size = new System.Drawing.Size(118, 25);
            this.relayAddressUpDown.TabIndex = 3;
            // 
            // enableBtn
            // 
            this.loraLayout.SetColumnSpan(this.enableBtn, 2);
            this.enableBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enableBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enableBtn.Location = new System.Drawing.Point(3, 98);
            this.enableBtn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.enableBtn.Name = "enableBtn";
            this.enableBtn.Size = new System.Drawing.Size(403, 36);
            this.enableBtn.TabIndex = 4;
            this.enableBtn.Text = "ENABLE";
            this.enableBtn.UseVisualStyleBackColor = true;
            this.enableBtn.Click += new System.EventHandler(this.EnableBtn_Click);
            // 
            // measureGroup
            // 
            this.measureGroup.Controls.Add(this.measureLayout);
            this.measureGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.measureGroup.Location = new System.Drawing.Point(438, 3);
            this.measureGroup.Name = "measureGroup";
            this.measureGroup.Padding = new System.Windows.Forms.Padding(10);
            this.measureGroup.Size = new System.Drawing.Size(705, 178);
            this.measureGroup.TabIndex = 1;
            this.measureGroup.TabStop = false;
            this.measureGroup.Text = "MEASURE";
            // 
            // measureLayout
            // 
            this.measureLayout.ColumnCount = 4;
            this.measureLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.measureLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.measureLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.measureLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.measureLayout.Controls.Add(this.measureBtn, 0, 0);
            this.measureLayout.Controls.Add(this.temperatureTitleLabel, 0, 1);
            this.measureLayout.Controls.Add(this.tempLabel, 0, 2);
            this.measureLayout.Controls.Add(this.humidityTitleLabel, 1, 1);
            this.measureLayout.Controls.Add(this.humLabel, 1, 2);
            this.measureLayout.Controls.Add(this.resistanceTitleLabel, 2, 1);
            this.measureLayout.Controls.Add(this.resLabel, 2, 2);
            this.measureLayout.Controls.Add(this.currentTitleLabel, 3, 1);
            this.measureLayout.Controls.Add(this.currentLabel, 3, 2);
            this.measureLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureLayout.Location = new System.Drawing.Point(10, 28);
            this.measureLayout.Name = "measureLayout";
            this.measureLayout.RowCount = 3;
            this.measureLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.measureLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.measureLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.measureLayout.Size = new System.Drawing.Size(685, 140);
            this.measureLayout.TabIndex = 0;
            // 
            // measureBtn
            // 
            this.measureLayout.SetColumnSpan(this.measureBtn, 4);
            this.measureBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.measureBtn.Location = new System.Drawing.Point(3, 5);
            this.measureBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.measureBtn.Name = "measureBtn";
            this.measureBtn.Size = new System.Drawing.Size(679, 38);
            this.measureBtn.TabIndex = 0;
            this.measureBtn.Text = "MEASURE";
            this.measureBtn.UseVisualStyleBackColor = true;
            this.measureBtn.Click += new System.EventHandler(this.MeasureBtn_Click);
            // 
            // temperatureTitleLabel
            // 
            this.temperatureTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureTitleLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.temperatureTitleLabel.Location = new System.Drawing.Point(3, 48);
            this.temperatureTitleLabel.Name = "temperatureTitleLabel";
            this.temperatureTitleLabel.Size = new System.Drawing.Size(165, 38);
            this.temperatureTitleLabel.TabIndex = 1;
            this.temperatureTitleLabel.Text = "TEMPÉRATURE °C";
            this.temperatureTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel
            // 
            this.tempLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.tempLabel.Location = new System.Drawing.Point(3, 86);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(165, 54);
            this.tempLabel.TabIndex = 2;
            this.tempLabel.Text = "--";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidityTitleLabel
            // 
            this.humidityTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.humidityTitleLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.humidityTitleLabel.Location = new System.Drawing.Point(174, 48);
            this.humidityTitleLabel.Name = "humidityTitleLabel";
            this.humidityTitleLabel.Size = new System.Drawing.Size(165, 38);
            this.humidityTitleLabel.TabIndex = 3;
            this.humidityTitleLabel.Text = "HUMIDITÉ %";
            this.humidityTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humLabel
            // 
            this.humLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.humLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.humLabel.Location = new System.Drawing.Point(174, 86);
            this.humLabel.Name = "humLabel";
            this.humLabel.Size = new System.Drawing.Size(165, 54);
            this.humLabel.TabIndex = 4;
            this.humLabel.Text = "--";
            this.humLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resistanceTitleLabel
            // 
            this.resistanceTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resistanceTitleLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.resistanceTitleLabel.Location = new System.Drawing.Point(345, 48);
            this.resistanceTitleLabel.Name = "resistanceTitleLabel";
            this.resistanceTitleLabel.Size = new System.Drawing.Size(165, 38);
            this.resistanceTitleLabel.TabIndex = 5;
            this.resistanceTitleLabel.Text = "RÉSISTIVITÉ Ω";
            this.resistanceTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resLabel
            // 
            this.resLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.resLabel.Location = new System.Drawing.Point(345, 86);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(165, 54);
            this.resLabel.TabIndex = 6;
            this.resLabel.Text = "--";
            this.resLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTitleLabel
            // 
            this.currentTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTitleLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.currentTitleLabel.Location = new System.Drawing.Point(516, 48);
            this.currentTitleLabel.Name = "currentTitleLabel";
            this.currentTitleLabel.Size = new System.Drawing.Size(166, 38);
            this.currentTitleLabel.TabIndex = 7;
            this.currentTitleLabel.Text = "COURANT mA";
            this.currentTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentLabel
            // 
            this.currentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.currentLabel.Location = new System.Drawing.Point(516, 86);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(166, 54);
            this.currentLabel.TabIndex = 8;
            this.currentLabel.Text = "--";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // archiveGroup
            // 
            this.archiveGroup.Controls.Add(this.archiveLayout);
            this.archiveGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archiveGroup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.archiveGroup.Location = new System.Drawing.Point(3, 403);
            this.archiveGroup.Name = "archiveGroup";
            this.archiveGroup.Padding = new System.Windows.Forms.Padding(10);
            this.archiveGroup.Size = new System.Drawing.Size(1146, 310);
            this.archiveGroup.TabIndex = 2;
            this.archiveGroup.TabStop = false;
            this.archiveGroup.Text = "ARCHIVE";
            // 
            // archiveLayout
            // 
            this.archiveLayout.ColumnCount = 1;
            this.archiveLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.archiveLayout.Controls.Add(this.archiveControlsLayout, 0, 0);
            this.archiveLayout.Controls.Add(this.databaseLayout, 0, 1);
            this.archiveLayout.Controls.Add(this.downloadLayout, 0, 2);
            this.archiveLayout.Controls.Add(this.histDataGridView, 0, 3);
            this.archiveLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archiveLayout.Location = new System.Drawing.Point(10, 28);
            this.archiveLayout.Name = "archiveLayout";
            this.archiveLayout.RowCount = 4;
            this.archiveLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.archiveLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.archiveLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.archiveLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.archiveLayout.Size = new System.Drawing.Size(1126, 272);
            this.archiveLayout.TabIndex = 0;
            // 
            // archiveControlsLayout
            // 
            this.archiveControlsLayout.Controls.Add(this.dataEepromCheck);
            this.archiveControlsLayout.Controls.Add(this.historicBtn);
            this.archiveControlsLayout.Controls.Add(this.eraseBtn);
            this.archiveControlsLayout.Controls.Add(this.exportBtn);
            this.archiveControlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archiveControlsLayout.Location = new System.Drawing.Point(3, 3);
            this.archiveControlsLayout.Name = "archiveControlsLayout";
            this.archiveControlsLayout.Padding = new System.Windows.Forms.Padding(3);
            this.archiveControlsLayout.Size = new System.Drawing.Size(1120, 38);
            this.archiveControlsLayout.TabIndex = 0;
            // 
            // dataEepromCheck
            // 
            this.dataEepromCheck.AutoSize = true;
            this.dataEepromCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataEepromCheck.Location = new System.Drawing.Point(8, 10);
            this.dataEepromCheck.Margin = new System.Windows.Forms.Padding(5, 7, 20, 3);
            this.dataEepromCheck.Name = "dataEepromCheck";
            this.dataEepromCheck.Size = new System.Drawing.Size(138, 19);
            this.dataEepromCheck.TabIndex = 0;
            this.dataEepromCheck.Text = "DATABASE / EEPROM";
            this.dataEepromCheck.UseVisualStyleBackColor = true;
            this.dataEepromCheck.CheckedChanged += new System.EventHandler(this.DataEepromCheck_CheckedChanged);
            // 
            // historicBtn
            // 
            this.historicBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.historicBtn.Location = new System.Drawing.Point(169, 6);
            this.historicBtn.Name = "historicBtn";
            this.historicBtn.Size = new System.Drawing.Size(130, 28);
            this.historicBtn.TabIndex = 1;
            this.historicBtn.Text = "HISTORIC";
            this.historicBtn.UseVisualStyleBackColor = true;
            this.historicBtn.Click += new System.EventHandler(this.HistoricBtn_Click);
            // 
            // eraseBtn
            // 
            this.eraseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eraseBtn.Location = new System.Drawing.Point(305, 6);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(130, 28);
            this.eraseBtn.TabIndex = 2;
            this.eraseBtn.Text = "ERASE";
            this.eraseBtn.UseVisualStyleBackColor = true;
            this.eraseBtn.Click += new System.EventHandler(this.EraseBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exportBtn.Location = new System.Drawing.Point(441, 6);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(130, 28);
            this.exportBtn.TabIndex = 3;
            this.exportBtn.Text = "EXPORT";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // databaseLayout
            // 
            this.databaseLayout.ColumnCount = 8;
            this.databaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.databaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.databaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.databaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.databaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.databaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.databaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.databaseLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.databaseLayout.Controls.Add(this.hostLabel, 0, 0);
            this.databaseLayout.Controls.Add(this.hostBox, 1, 0);
            this.databaseLayout.Controls.Add(this.databaseLabel, 2, 0);
            this.databaseLayout.Controls.Add(this.databaseBox, 3, 0);
            this.databaseLayout.Controls.Add(this.userLabel, 4, 0);
            this.databaseLayout.Controls.Add(this.userBox, 5, 0);
            this.databaseLayout.Controls.Add(this.pswLabel, 6, 0);
            this.databaseLayout.Controls.Add(this.pswBox, 7, 0);
            this.databaseLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseLayout.Location = new System.Drawing.Point(3, 47);
            this.databaseLayout.Name = "databaseLayout";
            this.databaseLayout.RowCount = 1;
            this.databaseLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.databaseLayout.Size = new System.Drawing.Size(1120, 38);
            this.databaseLayout.TabIndex = 1;
            // 
            // hostLabel
            // 
            this.hostLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.hostLabel.Location = new System.Drawing.Point(3, 0);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(49, 38);
            this.hostLabel.TabIndex = 0;
            this.hostLabel.Text = "HOST";
            this.hostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hostBox
            // 
            this.hostBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hostBox.Location = new System.Drawing.Point(58, 7);
            this.hostBox.Margin = new System.Windows.Forms.Padding(3, 7, 8, 3);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(209, 23);
            this.hostBox.TabIndex = 1;
            // 
            // databaseLabel
            // 
            this.databaseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.databaseLabel.Location = new System.Drawing.Point(278, 0);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(69, 38);
            this.databaseLabel.TabIndex = 2;
            this.databaseLabel.Text = "DATABASE";
            this.databaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // databaseBox
            // 
            this.databaseBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.databaseBox.Location = new System.Drawing.Point(353, 7);
            this.databaseBox.Margin = new System.Windows.Forms.Padding(3, 7, 8, 3);
            this.databaseBox.Name = "databaseBox";
            this.databaseBox.Size = new System.Drawing.Size(209, 23);
            this.databaseBox.TabIndex = 3;
            // 
            // userLabel
            // 
            this.userLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.userLabel.Location = new System.Drawing.Point(573, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(49, 38);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "USER";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userBox
            // 
            this.userBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userBox.Location = new System.Drawing.Point(628, 7);
            this.userBox.Margin = new System.Windows.Forms.Padding(3, 7, 8, 3);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(209, 23);
            this.userBox.TabIndex = 5;
            // 
            // pswLabel
            // 
            this.pswLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pswLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.pswLabel.Location = new System.Drawing.Point(848, 0);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(49, 38);
            this.pswLabel.TabIndex = 6;
            this.pswLabel.Text = "PSW";
            this.pswLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pswBox
            // 
            this.pswBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pswBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pswBox.Location = new System.Drawing.Point(903, 7);
            this.pswBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.pswBox.Name = "pswBox";
            this.pswBox.Size = new System.Drawing.Size(214, 23);
            this.pswBox.TabIndex = 7;
            this.pswBox.UseSystemPasswordChar = true;
            // 
            // downloadLayout
            // 
            this.downloadLayout.Controls.Add(this.downloadLabel);
            this.downloadLayout.Controls.Add(this.progressBar);
            this.downloadLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadLayout.Location = new System.Drawing.Point(3, 91);
            this.downloadLayout.Name = "downloadLayout";
            this.downloadLayout.Padding = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.downloadLayout.Size = new System.Drawing.Size(1120, 29);
            this.downloadLayout.TabIndex = 2;
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.downloadLabel.Location = new System.Drawing.Point(7, 8);
            this.downloadLabel.Margin = new System.Windows.Forms.Padding(3, 4, 10, 0);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(95, 15);
            this.downloadLabel.TabIndex = 0;
            this.downloadLabel.Text = "DOWNLOADING";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(115, 7);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 18);
            this.progressBar.TabIndex = 1;
            // 
            // histDataGridView
            // 
            this.histDataGridView.AllowUserToAddRows = false;
            this.histDataGridView.AllowUserToDeleteRows = false;
            this.histDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.histDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.histDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.histDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histDataGridView.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.histDataGridView.Location = new System.Drawing.Point(3, 126);
            this.histDataGridView.Name = "histDataGridView";
            this.histDataGridView.ReadOnly = true;
            this.histDataGridView.RowHeadersVisible = false;
            this.histDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.histDataGridView.Size = new System.Drawing.Size(1120, 143);
            this.histDataGridView.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1176, 740);
            this.Controls.Add(this.mainLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESP32-C6 - Interface de supervision";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainLayout.ResumeLayout(false);
            this.topLayout.ResumeLayout(false);
            this.comGroup.ResumeLayout(false);
            this.comLayout.ResumeLayout(false);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStatus)).EndInit();
            this.timeGroup.ResumeLayout(false);
            this.timeLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).EndInit();
            this.middleLayout.ResumeLayout(false);
            this.loraGroup.ResumeLayout(false);
            this.loraLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceAddressUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relayAddressUpDown)).EndInit();
            this.measureGroup.ResumeLayout(false);
            this.measureLayout.ResumeLayout(false);
            this.archiveGroup.ResumeLayout(false);
            this.archiveLayout.ResumeLayout(false);
            this.archiveControlsLayout.ResumeLayout(false);
            this.archiveControlsLayout.PerformLayout();
            this.databaseLayout.ResumeLayout(false);
            this.databaseLayout.PerformLayout();
            this.downloadLayout.ResumeLayout(false);
            this.downloadLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel topLayout;
        private System.Windows.Forms.GroupBox comGroup;
        private System.Windows.Forms.TableLayoutPanel comLayout;
        private System.Windows.Forms.Button scanBtn;
        private System.Windows.Forms.ComboBox comboPortCom;
        private System.Windows.Forms.Label baudLabel;
        private System.Windows.Forms.ComboBox comboBaud;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.FlowLayoutPanel statusPanel;
        private System.Windows.Forms.PictureBox pictureStatus;
        private System.Windows.Forms.Label statusValueLabel;
        private System.Windows.Forms.GroupBox timeGroup;
        private System.Windows.Forms.TableLayoutPanel timeLayout;
        private System.Windows.Forms.Button calendarBtn;
        private System.Windows.Forms.Button frequencyBtn;
        private System.Windows.Forms.NumericUpDown hourUpDown;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.NumericUpDown minuteUpDown;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label labelCalendar;
        private System.Windows.Forms.TableLayoutPanel middleLayout;
        private System.Windows.Forms.GroupBox loraGroup;
        private System.Windows.Forms.TableLayoutPanel loraLayout;
        private System.Windows.Forms.Label sourceAddressLabel;
        private System.Windows.Forms.NumericUpDown sourceAddressUpDown;
        private System.Windows.Forms.Label relayAddressLabel;
        private System.Windows.Forms.NumericUpDown relayAddressUpDown;
        private System.Windows.Forms.Button enableBtn;
        private System.Windows.Forms.GroupBox measureGroup;
        private System.Windows.Forms.TableLayoutPanel measureLayout;
        private System.Windows.Forms.Button measureBtn;
        private System.Windows.Forms.Label temperatureTitleLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label humidityTitleLabel;
        private System.Windows.Forms.Label humLabel;
        private System.Windows.Forms.Label resistanceTitleLabel;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label currentTitleLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.GroupBox archiveGroup;
        private System.Windows.Forms.TableLayoutPanel archiveLayout;
        private System.Windows.Forms.FlowLayoutPanel archiveControlsLayout;
        private System.Windows.Forms.CheckBox dataEepromCheck;
        private System.Windows.Forms.Button historicBtn;
        private System.Windows.Forms.Button eraseBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.TableLayoutPanel databaseLayout;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.TextBox databaseBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.TextBox pswBox;
        private System.Windows.Forms.FlowLayoutPanel downloadLayout;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView histDataGridView;
    }
}
