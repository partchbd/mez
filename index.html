<!doctype html>
<html lang="es">
<head>
  <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width,initial-scale=1" />
  <title>Contador de Palabras — Descripciones</title>
  <style>
    :root{
      --bg:#f6f7f9;
      --card:#ffffff;
      --muted:#6b7280;
      --accent:#2563eb;
      --accent-2:#0ea5a3;
      --border:#e5e7eb;
      font-family: Inter, system-ui, -apple-system, "Segoe UI", Roboto, "Helvetica Neue", Arial;
    }
    body{
      margin:0;
      min-height:100vh;
      background:linear-gradient(180deg,var(--bg),#fff 60%);
      padding:28px;
      color:#111827;
    }
    .container{
      max-width:980px;
      margin:0 auto;
    }
    header{
      display:flex;
      align-items:center;
      gap:16px;
      margin-bottom:18px;
    }
    h1{ margin:0; font-size:20px; letter-spacing:-0.2px; }
    p.lead{ margin:0; color:var(--muted); font-size:13px; }

    .card{
      background:var(--card);
      border:1px solid var(--border);
      border-radius:10px;
      padding:16px;
      box-shadow: 0 6px 18px rgba(12, 15, 20, 0.03);
    }

    .row{
      display:flex;
      gap:12px;
      align-items:flex-start;
      margin-bottom:12px;
      flex-wrap:wrap;
    }

    label{ display:block; font-size:13px; color:var(--muted); margin-bottom:6px; }

    textarea{
      width:100%;
      resize:vertical;
      min-height:72px;
      padding:10px 12px;
      border-radius:8px;
      border:1px solid var(--border);
      font-size:14px;
      box-sizing:border-box;
    }

    input[type="date"]{
      padding:8px 10px;
      border-radius:8px;
      border:1px solid var(--border);
    }

    .controls{
      display:flex;
      gap:8px;
      align-items:center;
      margin-bottom:10px;
      flex-wrap:wrap;
    }

    button{
      background:var(--accent);
      color:#fff;
      border:none;
      padding:10px 14px;
      border-radius:8px;
      font-weight:600;
      cursor:pointer;
    }
    button.ghost{
      background:transparent;
      border:1px solid var(--border);
      color:var(--muted);
    }
    .small{
      font-size:13px;
      padding:8px 10px;
    }

    .meta{
      display:flex;
      gap:8px;
      align-items:center;
      margin-left:auto;
    }

    table{
      width:100%;
      border-collapse:collapse;
      margin-top:12px;
      font-size:14px;
    }
    th, td{
      text-align:left;
      padding:10px 12px;
      border-bottom:1px solid #f1f1f3;
    }
    th{
      background:linear-gradient(180deg, #f9fafb, #fff);
      font-weight:700;
      font-size:13px;
      color:var(--muted);
      cursor:pointer;
      user-select:none;
    }
    tr:hover td{ background:#fbfdff; }
    .freq{ width:90px; text-align:center; }

    .dates{
      color:var(--muted);
      font-size:13px;
      word-break:break-word;
      max-width:420px;
    }

    .actions{
      display:flex;
      gap:8px;
      align-items:center;
      margin-top:10px;
    }

    .footer-note{ margin-top:10px; color:var(--muted); font-size:13px; }

    @media (max-width:700px){
      .meta{ margin-left:0; width:100%; justify-content:space-between; }
      .row{ flex-direction:column; align-items:stretch; }
    }
  </style>
</head>
<body>
  <div class="container">
    <header>
      <div>
        <h1>Contador de palabras</h1>
        <p class="lead">Escribe una descripción, elige la fecha y guarda. Se acumulan palabras y fechas.</p>
      </div>
    </header>

    <div class="card" id="app">
      <div class="row">
        <div style="flex:1">
          <label for="txtDesc">Descripción</label>
          <textarea id="txtDesc" placeholder="Escribe aquí la descripción..."></textarea>
        </div>

        <div style="width:220px">
          <label for="dateInp">Fecha</label>
          <input id="dateInp" type="date" />
          <div style="height:4px"></div>
          <div class="controls">
            <button id="btnSave">Guardar</button>
            <button id="btnClear" class="ghost small">Borrar todo</button>
          </div>
        </div>
      </div>

      <div style="display:flex;align-items:center;gap:10px;flex-wrap:wrap;margin-top:6px">
        <div>
          <label for="sortBy">Ordenar por</label><br/>
          <select id="sortBy" class="small">
            <option value="alpha">Palabra (A→Z)</option>
            <option value="freq_desc">Frecuencia (mayor→menor)</option>
            <option value="freq_asc">Frecuencia (menor→mayor)</option>
          </select>
        </div>

        <div>
          <label for="filterTxt">Filtrar palabra</label><br/>
          <input id="filterTxt" placeholder="buscar..." style="padding:8px;border-radius:8px;border:1px solid var(--border)" />
        </div>

        <div class="meta">
          <div style="font-size:13px;color:var(--muted)">Entradas: <span id="entryCount">0</span></div>
          <div style="font-size:13px;color:var(--muted)">Palabras distintas: <span id="wordCount">0</span></div>
        </div>
      </div>

      <table id="tbl">
        <thead>
          <tr>
            <th data-key="word">Palabra</th>
            <th class="freq" data-key="freq">Frecuencia</th>
            <th>Fechas</th>
          </tr>
        </thead>
        <tbody id="tbody">
          <!-- filas -->
        </tbody>
      </table>

      <div class="actions">
        <button id="btnExport" class="ghost small">Exportar JSON</button>
        <button id="btnImport" class="ghost small">Importar JSON</button>
        <input id="fileImport" type="file" accept=".json" style="display:none" />
      </div>

      <div class="footer-note">Sugerencia: puedes clicar en una fila para copiar las fechas al portapapeles.</div>
    </div>
  </div>

  <script>
    // Estructura en localStorage: { registro: { palabra: [ "2025-10-30", ... ] }, meta: { entries: N } }
    const LS_KEY = "contador_palabras_v1";

    const txtDesc = document.getElementById("txtDesc");
    const dateInp = document.getElementById("dateInp");
    const btnSave = document.getElementById("btnSave");
    const btnClear = document.getElementById("btnClear");
    const tbody = document.getElementById("tbody");
    const sortBy = document.getElementById("sortBy");
    const filterTxt = document.getElementById("filterTxt");
    const entryCountEl = document.getElementById("entryCount");
    const wordCountEl = document.getElementById("wordCount");
    const btnExport = document.getElementById("btnExport");
    const btnImport = document.getElementById("btnImport");
    const fileImport = document.getElementById("fileImport");

    // Datos en memoria
    let store = { registro: {}, entries: 0 };

    // init date default = hoy
    (function init(){
      const today = new Date();
      const iso = today.toISOString().slice(0,10);
      dateInp.value = iso;
      loadFromStorage();
      renderTable();
    })();

    // utilidad: extrae palabras (soporta letras unicode)
    function extractWords(text){
      // Intenta usar \p{L} (Unicode letters); si no disponible, cae al fallback
      try {
        const re = text.toLowerCase().match(/\p{L}[\p{L}\p{N}'-]*/gu);
        return re ? re : [];
      } catch(err){
        // fallback: \w pero quitando _
        const re2 = text.toLowerCase().match(/[A-Za-zÁÉÍÓÚáéíóúÑñ0-9'’-]+/g);
        return re2 ? re2 : [];
      }
    }

    function saveEntry(){
      const text = txtDesc.value.trim();
      const date = dateInp.value; // YYYY-MM-DD
      if(!text){
        alert("Escribe una descripción primero.");
        txtDesc.focus();
        return;
      }
      if(!date){
        alert("Selecciona una fecha.");
        dateInp.focus();
        return;
      }

      const words = extractWords(text);
      if(words.length === 0){
        alert("No se detectaron palabras en la descripción.");
        return;
      }

      words.forEach(w => {
        const key = w;
        if(!store.registro[key]) store.registro[key] = [];
        store.registro[key].push(date);
      });

      store.entries += 1;
      persist();
      txtDesc.value = "";
      // deja la fecha como estaba para entradas rápidas
      renderTable();
    }

    function persist(){
      try {
        localStorage.setItem(LS_KEY, JSON.stringify(store));
      } catch(e){
        console.error("No se pudo guardar en localStorage", e);
      }
    }

    function loadFromStorage(){
      try {
        const raw = localStorage.getItem(LS_KEY);
        if(raw){
          store = JSON.parse(raw);
          // small validation
          if(!store.registro) store.registro = {};
          if(!store.entries) store.entries = 0;
        }
      } catch(e){
        console.error("Error cargando store", e);
      }
    }

    function clearAll(){
      if(!confirm("¿Borrar todos los datos? Esta acción es irreversible.")) return;
      store = { registro: {}, entries: 0 };
      persist();
      renderTable();
    }

    function renderTable(){
      tbody.innerHTML = "";
      const rows = [];
      const filter = filterTxt.value.trim().toLowerCase();

      for(const [word, dates] of Object.entries(store.registro)){
        if(filter && !word.includes(filter)) continue;
        rows.push({ word, freq: dates.length, dates });
      }

      const mode = sortBy.value;
      if(mode === "alpha"){
        rows.sort((a,b) => a.word.localeCompare(b.word, 'es'));
      } else if(mode === "freq_desc"){
        rows.sort((a,b) => b.freq - a.freq || a.word.localeCompare(b.word, 'es'));
      } else if(mode === "freq_asc"){
        rows.sort((a,b) => a.freq - b.freq || a.word.localeCompare(b.word, 'es'));
      }

      rows.forEach(r => {
        const tr = document.createElement("tr");
        const tdWord = document.createElement("td");
        tdWord.textContent = r.word;
        tdWord.style.fontWeight = "600";

        const tdFreq = document.createElement("td");
        tdFreq.className = "freq";
        tdFreq.textContent = r.freq;

        const tdDates = document.createElement("td");
        tdDates.className = "dates";
        tdDates.textContent = Array.from(new Set(r.dates)).join(", ");

        tr.appendChild(tdWord);
        tr.appendChild(tdFreq);
        tr.appendChild(tdDates);

        // click en fila copia fechas
        tr.addEventListener("click", () => {
          const datesText = tdDates.textContent;
          navigator.clipboard?.writeText(datesText).then(()=> {
            // feedback rápido
            tdDates.style.background = "#eefaf9";
            setTimeout(()=> tdDates.style.background = "", 400);
          }).catch(()=> {
            alert("No se pudo copiar al portapapeles.");
          });
        });

        tbody.appendChild(tr);
      });

      // actualiza contadores
      entryCountEl.textContent = store.entries;
      wordCountEl.textContent = Object.keys(store.registro).length;
    }

    // exportar JSON
    function exportJSON(){
      const blob = new Blob([JSON.stringify(store, null, 2)], {type:'application/json'});
      const url = URL.createObjectURL(blob);
      const a = document.createElement("a");
      a.href = url;
      a.download = "contador_palabras_export.json";
      a.click();
      URL.revokeObjectURL(url);
    }

    // importar JSON (simple)
    function importJSON(file){
      const reader = new FileReader();
      reader.onload = e => {
        try {
          const obj = JSON.parse(e.target.result);
          if(obj && obj.registro){
            // fusionar: sumar listas
            for(const [k,v] of Object.entries(obj.registro)){
              if(!store.registro[k]) store.registro[k] = [];
              store.registro[k] = store.registro[k].concat(v);
            }
            if(obj.entries) store.entries = (store.entries || 0) + obj.entries;
            persist();
            renderTable();
            alert("Importación completada.");
          } else {
            alert("Archivo JSON inválido.");
          }
        } catch(err){
          alert("Error leyendo el archivo JSON.");
          console.error(err);
        }
      };
      reader.readAsText(file);
    }

    // eventos
    btnSave.addEventListener("click", saveEntry);
    btnClear.addEventListener("click", clearAll);
    sortBy.addEventListener("change", renderTable);
    filterTxt.addEventListener("input", renderTable);

    btnExport.addEventListener("click", exportJSON);
    btnImport.addEventListener("click", ()=> fileImport.click());
    fileImport.addEventListener("change", (ev) => {
      const f = ev.target.files[0];
      if(f) importJSON(f);
      fileImport.value = "";
    });

    // permitir Enter+Ctrl en textarea para guardar rápido
    txtDesc.addEventListener("keydown", (e) => {
      if(e.key === "Enter" && (e.ctrlKey || e.metaKey)){
        e.preventDefault();
        saveEntry();
      }
    });

    // Exponer render para debug
    window.renderTable = renderTable;
  </script>
</body>
</html>
