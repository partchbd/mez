
<!DOCTYPE html>
<html lang="es">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Analizador y Diario</title>
<style>
  body {
    background-color: #1e1e1e;
    color: #e0e0e0;
    font-family: 'Segoe UI', sans-serif;
    margin: 0;
    padding: 20px;
  }

  h2 {
    color: #ffd369;
  }

  textarea {
    width: 100%;
    height: 80px;
    background: #2c2c2c;
    color: #fff;
    border: 1px solid #444;
    border-radius: 8px;
    padding: 8px;
    resize: none;
  }

  input, select, button {
    background: #2c2c2c;
    color: #fff;
    border: 1px solid #444;
    border-radius: 6px;
    padding: 6px 10px;
    margin-top: 6px;
  }

  button:hover {
    background: #3c3c3c;
    cursor: pointer;
  }

  section {
    margin-bottom: 40px;
    border: 1px solid #333;
    padding: 20px;
    border-radius: 10px;
    background-color: #252525;
  }

  table {
    width: 100%;
    border-collapse: collapse;
    margin-top: 10px;
  }

  th, td {
    border: 1px solid #444;
    padding: 6px;
    text-align: left;
  }

  th {
    background-color: #333;
  }
</style>
</head>
<body>

<h1>🧩 Analizador de Palabras + Diario Personal</h1>

<!-- SECCIÓN 1: POR LUGAR -->
<section>
  <h2>🗂️ Analizador por Lugar</h2>
  <label>Descripción:</label><br>
  <textarea id="descripcion"></textarea><br>
  <label>Fecha:</label>
  <input type="date" id="fecha"><br>
  <label>Lugar:</label>
  <select id="lugar">
    <option value="Redes Sociales">Redes Sociales</option>
    <option value="Escuela">Escuela</option>
    <option value="Casa">Casa</option>
    <option value="Trabajo">Trabajo</option>
  </select><br>
  <button onclick="guardarLugar()">Guardar</button>

  <h3>📊 Resultados por Lugar</h3>
  <div id="tablaLugares"></div>
</section>

<!-- SECCIÓN 2: DIARIO PERSONAL -->
<section>
  <h2>📔 Diario Personal</h2>
  <label>Entrada:</label><br>
  <textarea id="entradaDiario"></textarea><br>
  <button onclick="guardarDiario()">Guardar Entrada</button>
  <button onclick="analizarDiario()">Analizar Semana</button>
  <button onclick="analizarGeneral()">Analizar General</button>

  <div id="resultadoDiario"></div>
</section>

<script>
  const conectores = ["y","e","de","la","el","los","las","que","a","en","un","una","por","para","con","se","del","al","lo","su","sus","es","no","sí","si","me","te","mi","tu","ya","muy","más","pero","o","u","como"];

  // --- SECCIÓN 1: POR LUGAR ---
  let registros = JSON.parse(localStorage.getItem("registrosLugares") || "{}");

  function guardarLugar() {
    const desc = document.getElementById("descripcion").value.trim().toLowerCase();
    const fecha = document.getElementById("fecha").value;
    const lugar = document.getElementById("lugar").value;

    if (!desc || !fecha) {
      alert("Por favor completa la descripción y la fecha.");
      return;
    }

    if (!registros[lugar]) registros[lugar] = {};

    const palabras = desc.split(/[\s,.\n\r!?;:()]+/).filter(p => p);
    for (let p of palabras) {
      if (!registros[lugar][p]) registros[lugar][p] = [];
      registros[lugar][p].push(fecha);
    }

    localStorage.setItem("registrosLugares", JSON.stringify(registros));
    mostrarLugares();
    document.getElementById("descripcion").value = "";
  }

  function mostrarLugares() {
    let html = "";
    for (let lugar in registros) {
      html += `<h4>${lugar}</h4><table><tr><th>Palabra</th><th>Frecuencia</th><th>Fechas</th></tr>`;
      for (let palabra in registros[lugar]) {
        const fechas = registros[lugar][palabra];
        html += `<tr><td>${palabra}</td><td>${fechas.length}</td><td>${fechas.join(", ")}</td></tr>`;
      }
      html += "</table>";
    }
    document.getElementById("tablaLugares").innerHTML = html;
  }

  mostrarLugares();

  // --- SECCIÓN 2: DIARIO PERSONAL ---
  let diario = JSON.parse(localStorage.getItem("diario") || "[]");

  function guardarDiario() {
    const texto = document.getElementById("entradaDiario").value.trim();
    if (!texto) {
      alert("Escribe algo en tu entrada del diario.");
      return;
    }

    const entrada = {
      texto: texto.toLowerCase(),
      fecha: new Date().toISOString()
    };

    diario.push(entrada);
    localStorage.setItem("diario", JSON.stringify(diario));
    document.getElementById("entradaDiario").value = "";
    alert("Entrada guardada.");
  }

  function analizarDiario() {
    const hoy = new Date();
    const haceUnaSemana = new Date(hoy);
    haceUnaSemana.setDate(hoy.getDate() - 7);

    const recientes = diario.filter(e => new Date(e.fecha) >= haceUnaSemana);
    mostrarAnalisis(recientes, "📆 Análisis de la Semana");
  }

  function analizarGeneral() {
    mostrarAnalisis(diario, "🌍 Análisis General del Diario");
  }

  function mostrarAnalisis(lista, titulo) {
    if (lista.length === 0) {
      document.getElementById("resultadoDiario").innerHTML = "<p>No hay suficientes entradas para analizar.</p>";
      return;
    }

    const contador = {};
    lista.forEach(e => {
      e.texto.split(/[\s,.\n\r!?;:()]+/)
        .filter(p => p && !conectores.includes(p))
        .forEach(p => {
          contador[p] = (contador[p] || 0) + 1;
        });
    });

    const top = Object.entries(contador)
      .sort((a,b) => b[1]-a[1])
      .slice(0,10)
      .map(([palabra, freq]) => `<tr><td>${palabra}</td><td>${freq}</td></tr>`)
      .join("");

    document.getElementById("resultadoDiario").innerHTML = `
      <h3>${titulo}</h3>
      <table>
        <tr><th>Palabra</th><th>Frecuencia</th></tr>
        ${top}
      </table>
    `;
  }
</script>
</body>
</html>