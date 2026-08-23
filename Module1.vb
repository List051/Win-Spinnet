
' Utilizza WinHelp → TAB per questo file


'===========================================================
'                 WINITALPASCAL – RIEPILOGO SNIPPET
'===========================================================
'===========================================================
' 00. WinA – Intestazione avanzata WinItalPascal
' Shortcut: winA
'-----------------------------------------------------------
' Inserisce un header professionale con metadata automatici:
' - Nome file
' - Cartella
' - Nome soluzione
' - Data creazione
' - Data modifica
' - Riferimenti YouTube / NuGet / GitHub
'
' Esempio utilizzo:
' winA → TAB
'
' Contenuto snippet:
' Autore        : Iaora
' File          : 
' Cartella      : 
' Soluzione     : 
' Creato il     : 
' Modificato il : 
' YouTube       : iaoraGo
' NuGet         : ItalPascal
' GitHub        : List051
'===========================================================

'===========================================================
' 1. WinCod – Codice Base Form
' Shortcut: WinCod
'-----------------------------------------------------------
' Inserisce:
' - Campi DataTable / DataView
' - BindingSource
' - Codice da mettere nel Load
' - Caricamento Clienti / Ordini
' - Collegamento ai DataGrid
' - Chiamate pronte per WinImpColB / WinImpColC
' - FullScreen + Titolo
' - ColoraDgv
'
' Esempio utilizzo:
' WinCod → TAB
'
' Nel Load:
' dtClienti = DB.FillDataTable("SELECT * FROM Clienti")
' CDataGrid.DataSource = dtClienti
' dtOrdini = DB.FillDataTable("SELECT * FROM Ordini")
' ODataGrid.DataSource = dtOrdini
' ImpColC(CDataGrid, dtClienti)
' ImpColC(ODataGrid, dtOrdini)
' ColoraDgv(CDataGrid, ODataGrid)
'===========================================================


'===========================================================
' 2. WinCodB – Codice Base Form Avanzato
' Shortcut: WinCodB
'-----------------------------------------------------------
' Inserisce:
' - Logger interno
' - Funzioni di supporto
' - Eventi DataGridView (DoubleClick, Formatting)
' - Pulsanti standard (Salva, Chiudi, Reset)
' - Gestione errori
' - Codice Load avanzato
'
' Esempio utilizzo:
' WinCodB → TAB
'
' Nel Load:
' dtClienti = DB.FillDataTable("SELECT * FROM Clienti")
' ClientiDataGrid.DataSource = dtClienti
' ImpColC(ClientiDataGrid, dtClienti)
'===========================================================


'===========================================================
' 3. WinImpCol – Imposta Colonne Base (manuale)
' Shortcut: WinImpCol
'-----------------------------------------------------------
' Imposta manualmente 11 colonne con HeaderText = "da inserire".
'
' Esempio utilizzo:
' ImpCol(CDataGrid)
'===========================================================


'===========================================================
' 4. WinImpColB – Imposta Colonne Avanzato (dinamico)
' Shortcut: WinImpColB
'-----------------------------------------------------------
' Imposta colonne dinamicamente (quante ne trova).
'
' Esempio utilizzo:
' ImpColB(CDataGrid)
' ImpColB(ODataGrid)
'===========================================================


'===========================================================
' 5. WinImpColC – Imposta Colonne Estrema (auto-detect tipi)
' Shortcut: WinImpColC
'-----------------------------------------------------------
' Formattazione automatica basata sul tipo:
' - Date → dd/MM/yyyy
' - Numeri → N2
' - Boolean → centrato
' - Stringhe → larghezza grande
'
' Richiede anche il DataTable.
'
' Esempio utilizzo:
' dtClienti = DB.FillDataTable("SELECT * FROM Clienti")
' CDataGrid.DataSource = dtClienti
' ImpColC(CDataGrid, dtClienti)
'===========================================================


'===========================================================
' 6. WinImpColMix – Imposta Colonne Mix (auto-detect + override)
' Shortcut: WinImpColMix
'-----------------------------------------------------------
' Combina:
' - Auto-detect tipi (WinImpColC)
' - Override manuale per colonne specifiche (WinImpColB)
'
' Perfetto per viste SQL, query dinamiche, tabelle complesse.
'
' Esempio utilizzo:
' dtClienti = DB.FillDataTable("SELECT * FROM Clienti")
' CDataGrid.DataSource = dtClienti
' ImpColMix(CDataGrid, dtClienti)
'===========================================================


'===========================================================
' 7. WinLog – Routine Log Avanzata
' Shortcut: WinLog
'-----------------------------------------------------------
' Inserisce:
' - Scrittura log
' - Conferma cancellazione vecchi record
' - Lettura log
' - Gestione errori
'
' Esempio utilizzo:
' Try
'     ' ... salvataggio ...
'     WinLog
' Catch ex As Exception
'     ' gestione errori
' End Try
'===========================================================
'===========================================================
' 8. WinFiltra – Evento filtro Clienti → Ordini
' Shortcut: WinFiltra
'-----------------------------------------------------------
' Inserisce:
' - Evento CellClick del DataGrid Clienti
' - Lettura IdClienti
' - Reset filtro ordini
' - Filtraggio OrdiniDataGrid
' - Colorazione griglie
'
' Esempio utilizzo:
' WinFiltra → TAB
'===========================================================
'===========================================================
' 9. WinPopUp – Popup per pulsanti
' Shortcut: WinPopUp
'-----------------------------------------------------------
' Inserisce:
' - Immagini da My.Resources
' - PopupHelper.AttachPopup per 3 pulsanti
' - Testo multilinea
' - Colori personalizzati
'
' Esempio utilizzo:
' WinPopUp → TAB
'===========================================================

'===========================================================
' 10. WinCalcTot – Calcoli automatici nel DataGrid
' Shortcut: WinCalcTot
'-----------------------------------------------------------
' Inserisce:
' - Evento CellEndEdit
' - Calcolo Qta * Prezzo → Totale
' - Scrittura automatica nella colonna 9
'
' Esempio utilizzo:
' WinCalcTot → TAB
'===========================================================
'===========================================================
' 12. WinBtnSalva – Salvataggio generico (senza Tag)
' Shortcut: WinBtnSalva
'-----------------------------------------------------------
' Versione a prova di errore:
' - Non usa Tag del pulsante
' - Non usa Tag del DataGridView
' - Funziona sempre
'
' Esempio utilizzo:
' BtnSalvaClienti_Click → SalvaDgv(CDataGrid, "Clienti")
' BtnSalvaOrdini_Click  → SalvaDgv(ODataGrid, "Ordini")
'
' Inserisce:
' - Routine SalvaDgv(dgv, tableName)
' - SqlDataAdapter + SqlCommandBuilder
' - Log automatico
' - Messaggi WinItalPascal
'===========================================================
'===========================================================
' 13. WinSalvaTag – Salvataggio generico (con Tag)
' Shortcut: WinSalvaTag
'-----------------------------------------------------------
' Versione con Tag:
' - BtnSalva.Tag = DataGridView
' - DataGridView.Tag = "NomeTabella"
'
' Esempio utilizzo:
' BtnSalva.Tag = CDataGrid
' CDataGrid.Tag = "Clienti"
'
' Inserisce:
' - Recupero DataGridView dal Tag del pulsante
' - Recupero DataTable dal DataGridView
' - Recupero nome tabella dal Tag del DataGridView
' - SqlDataAdapter + SqlCommandBuilder
' - Log automatico
' - Messaggi WinItalPascal
'===========================================================

'===========================================================
' 14. WinCerca – Cerca Avanzato (dinamico)
' Shortcut: WinCerca
'-----------------------------------------------------------
' Imposta colonne dinamicamente (quante ne trova).
'
' Esempio utilizzo:

'' *** Verifica DataGrid e dtTabella ***
'' la TextBox la chimao sempre TxtCerca.text
'' FDataGrid,dtFattura,TxtCerca.Text

'Private Sub TxtCerca_TextChanged(sender As Object, e As EventArgs) Handles TxtCerca.TextChanged

'    GridUtility.FiltraTutti(DataGrid, dtnome, TxtCerca.Text)
'    GridUtility.EvidenziaTesto(DataGrid, TxtCerca.Text)

'    If TxtCerca.Text = "" Then
'        ColoraDgv(DataGrid)
'    End If

'End Sub
'
'===========================================================

'===========================================================
' Fine riepilogo WinItalPascal
'===========================================================




