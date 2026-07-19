<!doctype html>
<html lang="fr">
<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Supervision ESP32-C6</title>
  <link rel="stylesheet" href="style.css">
</head>
<body>
  <main class="container">
    <header>
      <p class="eyebrow">ESP32-C6 · MySQL · PHP</p>
      <h1>Supervision des mesures</h1>
      <p>Acquisition, stockage et consultation des données du système connecté.</p>
    </header>

    <section class="cards" aria-label="Dernières mesures">
      <article class="card"><span>Température</span><strong id="temperature">--</strong><small>°C</small></article>
      <article class="card"><span>Humidité</span><strong id="humidity">--</strong><small>%</small></article>
      <article class="card"><span>Résistance</span><strong id="resistance">--</strong><small>Ω</small></article>
      <article class="card"><span>Courant</span><strong id="current">--</strong><small>mA</small></article>
    </section>

    <section class="panel">
      <div class="panel-heading">
        <div>
          <h2>Historique</h2>
          <p id="status">Chargement des données…</p>
        </div>
        <button id="refresh" type="button">Actualiser</button>
      </div>

      <div class="table-wrapper">
        <table>
          <thead>
            <tr><th>Date</th><th>Température</th><th>Humidité</th><th>Résistance</th><th>Courant</th></tr>
          </thead>
          <tbody id="measurement-table"></tbody>
        </table>
      </div>
    </section>
  </main>
  <script src="app.js"></script>
</body>
</html>
