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

```xml
<connectionStrings>
    <add name="MiaConnessione"
         connectionString="Data Source=AGO\SQLEXPRESS;Initial Catalog=GdR;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

Il codice dell'applicazione può rimanere invariato.

---

## 📦 Libreria WinItalPascal

Il progetto utilizza **WinItalPascal**, libreria sviluppata da Iaora e distribuita tramite NuGet.

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
WinItalPascal 2.0.5
```

Installazione tramite Package Manager Console:

```powershell
Install-Package WinItalPascal -Version 2.0.5
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

---

## 📺 Video e Playlist

Per esempi pratici relativi allo sviluppo in **Visual Studio / VB.NET**:

[YouTube – iaoraGo – Playlist](https://www.youtube.com/@iaoraGo/playlists?utm_source=chatgpt.com)

---

## 📌 Stato del progetto

Il progetto è operativo e continua a funzionare correttamente.

L'obiettivo è mostrare un metodo pratico e riutilizzabile per realizzare applicazioni gestionali in:

**VB.NET + Windows Forms + SQL Server**

utilizzando `WinItalPascal` e una serie di snippet riutilizzabili per velocizzare lo sviluppo.

---

## 👨‍💻 Autore

**Iaora**

YouTube: **iaoraGo**

[Canale YouTube iaoraGo](https://www.youtube.com/@iaoraGo?utm_source=chatgpt.com)

### Video del progetto

▶️ [Guarda il video su YouTube](https://youtu.be/UboNebA_Irs)

---

## 📄 Licenza

Questo progetto è distribuito secondo i termini della **MIT License**.

Copyright (c) 2026 Iaora

Per i termini completi consultare il file [`LICENSE`](LICENSE) presente nel repository.
