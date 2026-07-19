const table = document.querySelector('#measurement-table');
const statusText = document.querySelector('#status');
const refreshButton = document.querySelector('#refresh');

function displayValue(id, value, digits = 2) {
  const element = document.querySelector(id);
  element.textContent = value === null || value === undefined || value === ''
    ? '--'
    : Number(value).toFixed(digits);
}

async function loadMeasurements() {
  statusText.textContent = 'Chargement des données…';
  refreshButton.disabled = true;

  try {
    const response = await fetch('readings.php?limit=50', { cache: 'no-store' });
    const result = await response.json();
    if (!response.ok || result.status !== 'success') throw new Error(result.message || 'Erreur API');

    const measurements = result.measurements;
    table.replaceChildren();

    for (const measurement of measurements) {
      const current = measurement.current_ma === null ? '--' : `${Number(measurement.current_ma).toFixed(3)} mA`;
      const row = document.createElement('tr');
      row.innerHTML = `
        <td>${measurement.created_at}</td>
        <td>${Number(measurement.temperature).toFixed(2)} °C</td>
        <td>${Number(measurement.humidity).toFixed(2)} %</td>
        <td>${Number(measurement.resistance).toFixed(6)} Ω</td>
        <td>${current}</td>`;
      table.appendChild(row);
    }

    if (measurements.length > 0) {
      displayValue('#temperature', measurements[0].temperature);
      displayValue('#humidity', measurements[0].humidity);
      displayValue('#resistance', measurements[0].resistance, 6);
      displayValue('#current', measurements[0].current_ma, 3);
    }

    statusText.textContent = `${measurements.length} mesure(s) affichée(s)`;
  } catch (error) {
    statusText.textContent = `Erreur : ${error.message}`;
  } finally {
    refreshButton.disabled = false;
  }
}

refreshButton.addEventListener('click', loadMeasurements);
loadMeasurements();
setInterval(loadMeasurements, 10000);
