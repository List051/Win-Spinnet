

<p align="center">
  <img src="Logo.png" alt="Ital Pascal Logo" width="220">
</p>

<h1 align="center">WinItalPascal</h1>
<p align="center">
  Libreria di utilità per applicazioni VB.NET WinForms
</p>

<p align="center">

  <!-- NuGet -->
  <a href="https://www.nuget.org/packages/WinItalPascal">
    <img src="https://img.shields.io/nuget/v/WinItalPascal?style=for-the-badge" alt="NuGet Version">
  </a>
  <a href="https://www.nuget.org/packages/WinItalPascal">
    <img src="https://img.shields.io/nuget/dt/WinItalPascal?style=for-the-badge" alt="NuGet Downloads">
  </a>

  <!-- GitHub -->
  <img src="https://img.shields.io/github/stars/List051?style=for-the-badge" alt="Stars">
  <img src="https://img.shields.io/github/forks/List051/WinItalPascal_Lib?style=for-the-badge" alt="Forks">
  <img src="https://img.shields.io/github/issues/List051/WinItalPascal_Lib?style=for-the-badge" alt="Issues">
  <img src="https://img.shields.io/github/last-commit/List051/WinItalPascal_Lib?style=for-the-badge" alt="Last Commit">

  <!-- License -->
  <a href="https://github.com/List051/WinItalPascal_Lib/blob/main/License.txt">
    <img src="https://img.shields.io/github/license/List051/WinItalPascal_Lib?style=for-the-badge" alt="License">
  </a>

</p>




# Gestionale WinForms VB.NET – WinItalPascal

Progetto di esempio realizzato in **VB.NET Windows Forms** utilizzando la libreria **WinItalPascal**.

Il progetto mostra un approccio pratico alla gestione di:

* SQL Server
* DataGridView
* DataTable e DataView
* Query SQL
* Salvataggio dei dati tramite `SqlDataAdapter`
* Filtri tra DataGridView
* Calcoli automatici
* Formattazione dei DataGridView
* Popup informativi
* Logging
* Gestione della connessione al database

> **Il progetto continua a funzionare perfettamente.**

---

## ▶️ Avvio del progetto

Per il primo avvio utilizzare il database di test `GdRTest`.

Nel file di configurazione impostare:

```xml
<connectionStrings>
    <add name="MiaConnessione"
         connectionString="Data Source=AGO\SQLEXPRESS;Initial Catalog=GdRTest;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

### Database di test

```text
Server         : AGO\SQLEXPRESS
Database       : GdRTest
Autenticazione : Windows / Integrated Security
```

La connessione viene recuperata tramite il nome:

```text
MiaConnessione
```

> **Nota:** `AGO\SQLEXPRESS` è l'istanza SQL Server utilizzata nell'ambiente di sviluppo originale. Su un altro computer dovrà essere sostituita con la propria istanza SQL Server.

---

## 🔄 Passaggio al database definitivo

Dopo aver inserito e verificato tutte le procedure, è possibile passare al database definitivo.

È sufficiente modificare:

```xml
Initial Catalog=GdRTest
```

in:

```xml
Initial Catalog=GdR
```

La configurazione definitiva sarà:

```vb
<connectionStrings>
    <add name="MiaConnessione"
         connectionString="Data Source=AGO\SQLEXPRESS;Initial Catalog=GdR;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

Il codice dell'applicazione può rimanere invariato.

---

## 📦 Libreria WinItalPascal

Il progetto utilizza **WinItalPascal**, libreria sviluppata da ItalPascal e distribuita tramite NuGet.

La libreria viene utilizzata per semplificare lo sviluppo di applicazioni **Windows Forms in VB.NET**, fornendo funzionalità per:

* DataGridView
* DataTable e DataView
* connessioni SQL Server
* query
* filtri
* salvataggio dati
* popup e messaggi
* formattazione
* logging
* utility per le Form

### NuGet

[WinItalPascal – NuGet](https://www.nuget.org/packages/WinItalPascal?utm_source=chatgpt.com)

Versione utilizzata:

```text
WinItalPascal 2.0.6
```

Installazione tramite Package Manager Console:

```powershell
Install-Package WinItalPascal -Version 2.0.6
```

Il progetto utilizza la libreria come dipendenza esterna e non include il codice sorgente di `WinItalPascal`.

---

## 🔗 Progetto precedente

Questo progetto rappresenta la **continuazione del lavoro iniziato con `WinTest-SenzaVINCOLI`**.

Nel progetto precedente è stato verificato il comportamento della libreria `WinItalPascal` e la sua indipendenza dai nomi generati automaticamente dal Designer di Visual Studio.

👉 **Progetto precedente:**

[WinTest-SenzaVINCOLI – GitHub](https://github.com/List051/WinTest-SenzaVINCOLI?utm_source=chatgpt.com)

Il percorso del progetto è quindi:

```text
WinTest-SenzaVINCOLI
        │
        ▼
   WinItalPascal
        │
        ▼
   Nuovo Gestionale
```

---

## 🧩 Snippet Visual Studio

Nel progetto sono disponibili gli snippet utilizzati durante lo sviluppo.

Gli snippet sono contenuti nella cartella:

```text
Snippets/
```

### Snippet disponibili

| Snippet       | Descrizione                                                                      |
| ------------- | -------------------------------------------------------------------------------- |
| `WinA`        | Intestazione della Form                                                          |
| `WinCod`      | Imposta variabili iniziali                                                       |
| `WinPopup`    | Popup e avvisi sui pulsanti                                                      |
| `WinImpCodB`  | Impostazione colonne DataGridView                                                |
| `WinCerca`    | Ricerca nel DataGridView                                                         |
| `WinQry`      | Query generica                                                                   |
| `WinQryO`     | Query con più tabelle                                                            |
| `WinBtnSalva` | Salvataggio modifiche                                                            |
| `WinCalcTot`  | Calcoli automatici                                                               |
| `WinFiltra`   | Filtro DataGridView collegati                                                    |
| `WinLog`      | Durante le operazioni principali vengono registrate informazioni nel file di log |

Gli snippet possono essere riutilizzati per velocizzare lo sviluppo di applicazioni Windows Forms in VB.NET.

---

## 🗂️ Struttura del progetto

La Form di esempio utilizza principalmente:

```text
Clienti
Ordini
Fatture
```

I dati vengono caricati tramite `WinItalPascal`, ad esempio:

```vb
dtClienti = DB.FillDataTable("SELECT * FROM Clienti")
CDataGrid.DataSource = dtClienti

dtOrdini = DB.FillDataTable("SELECT * FROM Ordini")
ODataGrid.DataSource = dtOrdini
```

I due DataGridView principali sono:

```text
CDataGrid → Clienti
ODataGrid → Ordini
```

Il progetto permette inoltre di:

* ricercare i dati
* filtrare gli ordini selezionando un cliente
* modificare e salvare i dati
* eseguire query con più tabelle
* effettuare calcoli automatici
* registrare le operazioni nel file di log
* personalizzare le colonne dei DataGridView

---

## 🔍 Esempio di query

Il progetto utilizza anche query SQL con `JOIN`.

Ad esempio, per individuare gli ordini che non hanno ancora una fattura:

```sql
SELECT
    Ordini.IDOrd,
    c.Citta,
    c.Cliente,
    c.Tel,
    c.P_IVA,
    Ordini.Categoria,
    Ordini.Mat,
    Ordini.QtaOrd,
    Ordini.PrezzoOrd,
    Ordini.ImportoOrd,
    Ordini.IDCliOrd,
    c.IdClienti
FROM Ordini
LEFT OUTER JOIN Fattura
    ON Ordini.IDOrd = Fattura.IDOrd
LEFT JOIN dbo.Clienti AS c
    ON Ordini.IDCliOrd = c.IdClienti
WHERE Fattura.IDOrd IS NULL
```

---

## 🛠️ Tecnologie

```text
VB.NET
Windows Forms
Visual Studio
SQL Server
SQL Server Express
System.Data.SqlClient
DataGridView
DataTable
DataView
BindingSource
WinItalPascal
```

---

## 🚀 Flusso consigliato

```text
1. Creazione database di test
        ↓
2. Configurazione GdRTest
        ↓
3. Creazione delle Form
        ↓
4. Inserimento degli snippet
        ↓
5. Creazione delle query
        ↓
6. Configurazione dei DataGridView
        ↓
7. Verifica dei filtri
        ↓
8. Verifica dei salvataggi
        ↓
9. Verifica dei calcoli automatici
        ↓
10. Test completo dell'applicazione
        ↓
11. Passaggio da GdRTest a GdR
```

# 🔗 Link utili

## 📚 Documentazione della libreria WinItalPascal

- [📘 Documentazione Tecnica (*.md)](https://github.com/List051/WinItalPascal_Lib/tree/main/Documentation)
- [📄 Manuali PDF della libreria](https://github.com/List051/WinItalPascal_Lib/tree/main/Help/pdf)

---

## 🎬 Video dimostrativi

- [🎥 Video Esempi – WinVideoShowcase](https://list051.github.io/WinVideoShowcase/)
- [📺 Canale YouTube](https://www.youtube.com/@iaoraGo)
- [🎞️ Playlist completa WinItalPascal](https://www.youtube.com/watch?v=UboNebA_Irs&list=PLqYE2xAtyfEAiNY4qC2LeJJuCJPyUScXL)

---


## 📌 Stato del progetto

Il progetto è operativo e continua a funzionare correttamente.

L'obiettivo è mostrare un metodo pratico e riutilizzabile per realizzare applicazioni gestionali in:

**VB.NET + Windows Forms + SQL Server**

utilizzando `WinItalPascal` e una serie di snippet riutilizzabili per velocizzare lo sviluppo.

---

## 👨‍💻 Autore

**ItalPascal**

YouTube: **iaoraGo**

[Canale YouTube iaoraGo](https://www.youtube.com/@iaoraGo?utm_source=chatgpt.com)

### Video del progetto

▶️ [Guarda il video su YouTube](https://youtu.be/UboNebA_Irs)

---

## 📄 Licenza

Questo progetto è distribuito secondo i termini della **MIT License**.

Copyright (c) 2026 ItalPascal

Per i termini completi consultare il file [`LICENSE`](LICENSE) presente nel repository.

<div align="center">
  <h2>⭐ Come supportare il progetto</h2>
  <p>Se questo progetto ti è utile, puoi supportarlo con un semplice gesto:</p>

  <!-- Pulsante Star -->
  <a href="https://github.com/List051/Win-Spinnet">
    <img src="https://img.shields.io/github/stars/List051/Win-Spinnet?style=social" alt="Star this repo">
  </a>

  <!-- Pulsante Fork -->
  <a href="https://github.com/List051/Win-Spinnet/fork">
    <img src="https://img.shields.io/github/forks/List051/Win-Spinnet?label=fork&style=social" alt="Fork this repo">
  </a>

  <p>Mettere una ⭐ o fare un Fork aiuta il progetto a crescere e permette ad altri sviluppatori di scoprirlo.</p>

  <br>

  <!-- Pulsante Follow autore -->
  <p>Vuoi restare aggiornato sui nuovi progetti?</p>

  <a href="https://github.com/List051">
    <img src="https://img.shields.io/github/followers/List051?label=Follow%20%40List051&style=social" alt="Follow @List051">
  </a>

  <p>Grazie per il tuo supporto!</p>
</div>
