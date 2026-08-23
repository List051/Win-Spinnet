

'=================================
' *** WinItalPascal ***
' Autore        : Iaora
' File          : FrmUNO
' Cartella      : WinTest
' Soluzione     : Gestionale ...
' Creato il     : 19/08/2026
' Modificato il : 
' YouTube       : iaoraGo
' NuGet         : ItalPascal
' GitHub        : List051
'=================================
Imports System.Data.SqlClient
Imports WinItalPascal


Public Class FrmUno

    '=================================
    ' *** WinItalPascal - Codice Base Form ***
    '=================================

    ' Campi privati per gestire Clienti, Ordini e Fatture
    Private dtOrdini As DataTable
    Private dvOrdini As DataView

    Private dtClienti As DataTable
    Private dvClienti As DataView

    Private dtView As DataView
    Private bsFatture As New BindingSource
    Private bsOrdini As New BindingSource
    Private bsClienti As New BindingSource


    Private Sub FrmUno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '===========================================================
        ' INSERIRE NEL LOAD DELLA FORM
        '===========================================================
        'TODO: questa riga di codice carica i dati nelle tabelle
        dvOrdini = New DataView(dtOrdini)
        dvClienti = New DataView(dtClienti)

        dtClienti = DB.FillDataTable("SELECT * FROM Clienti")
        CDataGrid.DataSource = dtClienti

        dtOrdini = DB.FillDataTable("SELECT * FROM Ordini")
        ODataGrid.DataSource = dtOrdini

        ScreenUtility.FullScreen(Me)
        FrmTitolo.CTitolo(Me, "Gestionale ....")

        ' questo è per winimpcolMix
        'ImpColC(CDataGrid, dtClienti)
        'ImpColC(ODataGrid, dtOrdini)

        ' winimpcolB
        ImpColB_C(CDataGrid)
        ImpColB_O(ODataGrid)

        ColoraDgv(CDataGrid, ODataGrid)

        '===========================================================
        ' Popup per pulsanti principali
        '===========================================================

        Dim imgAggOrdini As Image = My.Resources.order
        Dim imgAggClienti As Image = My.Resources.edit
        Dim imgSFat As Image = My.Resources.search_engine
        Dim imgConn As Image = My.Resources.login
        Dim imgTutti As Image = My.Resources.popEdit

        PopupHelper.AttachPopup(RjBtnSalvaOrdini,
                        vbCrLf & "Aggiorna dati" & vbCrLf &
                        "Salva i dati modificati dell'Ordine",
                        imgAggOrdini,
                        Color.Aquamarine,
                        Color.Blue)

        PopupHelper.AttachPopup(BtnSalvaClienti,
                        vbCrLf & "Aggiorna cliente" & vbCrLf &
                        "Salva i dati modificati del cliente",
                        imgAggClienti,
                        Color.Aquamarine,
                        Color.Blue)

        PopupHelper.AttachPopup(RjCircOrdini,
                  vbCrLf & "Elenco Completo" & vbCrLf &
                  "Ripopola il DataGrid degli Ordini SENZA Fattura' ",
                  imgSFat,
                  Color.Aquamarine,
                  Color.Blue)

        PopupHelper.AttachPopup(RjCircTutti,
                  vbCrLf & "Elenco Completo" & vbCrLf &
                  "Ripopola il DataGrid degli Ordini completo' ",
                  imgTutti,
                  Color.Aquamarine,
                  Color.Blue)

        PopupHelper.AttachPopup(RjBtnVerConn,
                vbCrLf & "Verifica Connessione" & vbCrLf &
                "Salva la tua connessione in 'MiaConnessione' ",
                imgConn,
                Color.Aquamarine,
                Color.Blue)

    End Sub

#Region "Pulsanti per DataGrid - Clienti - Ordini "

    Private Sub RjCircTutti_Click(sender As Object, e As EventArgs) Handles RjCircTutti.Click
        Dim qryOrd As String = "Select * from Ordini"  ' 'Verifica nome Tabella 
        DataGVLoad.ApriDGV(ODataGrid, qryOrd)  'Verifica nome DataGrid 
        ColoraDgv(ODataGrid)
        ImpColB_O(ODataGrid)
    End Sub

    Private Sub BtnSalvaClienti_Click(sender As Object, e As EventArgs) Handles BtnSalvaClienti.Click
        SalvaDgv_C(CDataGrid, "Clienti")
    End Sub

    Private Sub RjBtnSalvaOrdini_Click(sender As Object, e As EventArgs) Handles RjBtnSalvaOrdini.Click
        SalvaDgV_O(ODataGrid, "Ordini")
    End Sub

    Private Sub RjBtnVerConn_Click(sender As Object, e As EventArgs) Handles RjBtnVerConn.Click
#Region "Verifica Connessione"

        Dim cs = ConfigHelper.GetConnectionString()

        IPMessageBox.Show(
            cs,
            "Connection String --> MiaConnessione"
        )
    End Sub

    '=================================
    ' *** Verifica DataGrid e dtTabella ***
    ' la TextBox la chimo sempre TxtCerca.text
    ' FDataGrid,dtFattura,TxtCerca.Text

    Private Sub TxtCerca_TextChanged(sender As Object, e As EventArgs) Handles TxtCerca.TextChanged

        GridUtility.FiltraTutti(CDataGrid, dtClienti, TxtCerca.Text)
        GridUtility.EvidenziaTesto(CDataGrid, TxtCerca.Text)

        If TxtCerca.Text = "" Then
            ColoraDgv(CDataGrid)
        End If

    End Sub

#End Region

#Region "Salva DataGrid Clienti - Ordini"

    '===========================================================
    ' SALVATAGGIO GENERICO PER QUALSIASI DATAGRID
    '===========================================================

    ' Esempio utilizzo:
    ' BtnSalvaClienti_Click → SalvaDgv(CDataGrid, "Clienti")
    ' BtnSalvaOrdini_Click  → SalvaDgv(ODataGrid, "Ordini")

    Private Sub SalvaDgv_C(dgv As DataGridView, tableName As String)

        Try
            ' Recupera DataTable dal DataGridView
            Dim dt As DataTable = TryCast(dgv.DataSource, DataTable)
            If dt Is Nothing Then
                IPMessageBox.Show("Il DataGridView non contiene un DataTable valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Salvataggio tramite SqlDataAdapter
            GridUtility.ConvertiMaiuscolo(CDataGrid) ' Assegnare il DataGrid
            Using cn As SqlConnection = DB.GetConnection("MiaConnessione")
                cn.Open()

                Dim sql As String = "SELECT * FROM " & tableName
                Dim da As New SqlDataAdapter(sql, cn)
                Dim cb As New SqlCommandBuilder(da)

                da.Update(dt)
            End Using

            ' Log automatico
            LogLeggiScrivi.ScriviLogMsg("Salvata tabella " & tableName)

            IPMessageBox.Show("Salvataggio completato!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            LogLeggiScrivi.ScriviLog("Errore Salvataggio", ex)
            IPMessageBox.Show("Errore durante il salvataggio: " & ex.Message,
                              "Errore",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error)
        End Try

    End Sub


    '===========================================================
    ' SALVATAGGIO GENERICO PER QUALSIASI DATAGRID
    '===========================================================

    ' Esempio utilizzo:
    ' BtnSalvaClienti_Click → SalvaDgv(CDataGrid, "Clienti")
    ' BtnSalvaOrdini_Click  → SalvaDgv(ODataGrid, "Ordini")

    Private Sub SalvaDgv_O(dgv As DataGridView, tableName As String)

        Try
            ' Recupera DataTable dal DataGridView
            Dim dt As DataTable = TryCast(dgv.DataSource, DataTable)
            If dt Is Nothing Then
                IPMessageBox.Show("Il DataGridView non contiene un DataTable valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Salvataggio tramite SqlDataAdapter
            GridUtility.ConvertiMaiuscolo(ODataGrid) ' Assegnare il DataGrid
            Using cn As SqlConnection = DB.GetConnection("MiaConnessione")
                cn.Open()

                Dim sql As String = "SELECT * FROM " & tableName
                Dim da As New SqlDataAdapter(sql, cn)
                Dim cb As New SqlCommandBuilder(da)

                da.Update(dt)
            End Using

            ' Log automatico
            LogLeggiScrivi.ScriviLogMsg("Salvata tabella " & tableName)

            IPMessageBox.Show("Salvataggio completato!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            LogLeggiScrivi.ScriviLog("Errore Salvataggio", ex)
            IPMessageBox.Show("Errore durante il salvataggio: " & ex.Message,
                              "Errore",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Visualizza DataGrid - Ordini senza Fattura"
    Private Sub RjCircOrdini_Click(sender As Object, e As EventArgs) Handles RjCircOrdini.Click
        Dim qryOrd As String = "Select * from Ordini"  ' 'Verifica nome Tabella 
        DataGVLoad.ApriDGV(ODataGrid, qryOrd)  'Verifica nome DataGrid 

        Dim qry As String = "SELECT Ordini.IDOrd, c.Citta, c.Cliente, c.Tel, c.P_IVA, " &
                    "Ordini.Categoria, Ordini.Mat, Ordini.QtaOrd, " &
                    "Ordini.PrezzoOrd, Ordini.ImportoOrd, " &
                    "Ordini.IDCliOrd, c.IdClienti " &
                    "FROM Ordini " &
                    "LEFT OUTER JOIN Fattura ON Ordini.IDOrd = Fattura.IDOrd " &
                    "LEFT JOIN dbo.Clienti AS c " &
                    "ON Ordini.IDCliOrd = c.IdClienti " &
                    "WHERE Fattura.IDOrd IS NULL"

        '  Query Seleziona Ordini Senza Fattura

        DataGVLoad.ApriDGV(ODataGrid, qry)  'Verifica nome DataGrid 

        ImpColB_KO(ODataGrid)

        If IPMessageBox.Show("Vuoi cancellare record vecchi nel file di log?",
                     "Conferma",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) = DialogResult.Yes Then

            LogLeggiScrivi.ClearLog()   ' il numero è opzionale, default elimina 5 gruppi
        End If
        '  DataGVLoad.ApriDGV(DataGrid, qry) ' Verifica nome DataGrid decisamente più xsemplice
        LogLeggiScrivi.ScriviLogMsg("La Query è stata eseguita correttamente")

        ' Per leggere Avviso corto va bene
        Dim leggiLog = IPMessageBox.Show(LogReader.ReadLog(), "Apro il file di log")
        ColoraDgv(ODataGrid) 'Verifica nome DataGrid 
    End Sub
#End Region

#End Region

#Region "Imposta colonne del DataGrid - Clienti"

    '' Imposta colonne con gestione errori, logger e formattazione avanzata

    ' Ripetere 2 volte winimpcolb
    ' fuori dalla sub
    ' ImpColB(ClientiDataGrid)
    ' Rinominare Sub ImpColB(ByRef dgv As DataGridView)
    ' in Sub ImpColB_X(ByRef dgv As DataGridView) per secondo DataGrid

    Sub ImpColB_C(ByRef dgv As DataGridView)

        Try
            '' Font generale
            dgv.Font = New Font("Segoe UI", 10, FontStyle.Regular)

            '' Header colonne: font + colori
            With dgv.ColumnHeadersDefaultCellStyle
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.LightBlue
                .ForeColor = Color.DarkBlue
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            dgv.EnableHeadersVisualStyles = False
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            '' Imposta colonne dinamicamente
            For i As Integer = 0 To dgv.Columns.Count - 1

                Select Case i
                    Case 0 : dgv.Columns(i).Width = 60
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        ColoraColonneSpec(CDataGrid, {0}) ' Colonne Id
                    Case 1 : dgv.Columns(i).Width = 260
                    Case 2 : dgv.Columns(i).Width = 260
                    Case 3 : dgv.Columns(i).Width = 220
                    Case 4 : dgv.Columns(i).Width = 60
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case 5 : dgv.Columns(i).Width = 80
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        'Case 6 : dgv.Columns(i).Width = 80
                        'Case 7 : dgv.Columns(i).Width = 80
                        '  Case 8 : dgv.Columns(i).Width = 80

                    Case Else : dgv.Columns(i).Width = 170
                End Select

                '  dgv.Columns(i).HeaderText = "da inserire"
                '  Case 7 : dgv.Columns(i).Width = 100 : dgv.Columns(i).Tag = "N2" : dgv.Columns(i).HeaderText = "Importo Unitario"
                '  Case 8 : dgv.Columns(i).Width = 100 : dgv.Columns(i).Tag = "N2" : dgv.Columns(i).HeaderText = "Importo Totale"
                '  dgv.Columns(i).DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            Next

            '' Formattazione automatica tramite libreria WinItalPascal
            ' ***  Assegnare il nome del DataGrid ****
            ' ColoraColonneSpec(DataGrid, {8}, Color.Gold, Color.Blue) ' Colonna con Calcolo Automatico
            ' ColoraColonneSpec(DataGrid, {0, 1}) ' Colonne Id

        Catch ex As Exception
            IPMessageBox.Show(ex.Message, "Errore ImpColB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Imposta colonne Ordini"

    '' Imposta colonne con gestione errori, logger e formattazione avanzata

    ' Ripetere 2 volte winimpcolb
    ' fuori dalla sub
    ' ImpColB_O(ODataGrid)
    ' Rinominare Sub ImpColB(ByRef dgv As DataGridView)
    ' in Sub ImpColB_X(ByRef dgv As DataGridView) per secondo DataGrid

    Sub ImpColB_O(ByRef dgv As DataGridView)

        Try
            '' Font generale
            dgv.Font = New Font("Segoe UI", 10, FontStyle.Regular)

            '' Header colonne: font + colori
            With dgv.ColumnHeadersDefaultCellStyle
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.LightBlue
                .ForeColor = Color.DarkBlue
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            dgv.EnableHeadersVisualStyles = False
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            '' Imposta colonne dinamicamente
            For i As Integer = 0 To dgv.Columns.Count - 1

                Select Case i
                    Case 0 : dgv.Columns(i).Width = 60
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    Case 1 : dgv.Columns(i).Width = 60
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgv.Columns(i).HeaderText = "Id Cliente Ordine"
                    Case 2 : dgv.Columns(i).Width = 100
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                  '  Case 3, 4 : dgv.Columns(i).Width = 250
                 '   Case 4 : dgv.Columns(i).Width = 120
                    Case 5 : dgv.Columns(i).Width = 250
                    Case 6 : dgv.Columns(i).Width = 80
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case 7 : dgv.Columns(i).Width = 80 : dgv.Columns(i).Tag = "N2"
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgv.Columns(i).HeaderText = "Importo Unitario"
                    Case 8 : dgv.Columns(i).Width = 100 : dgv.Columns(i).Tag = "N2"
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgv.Columns(i).Tag = "N2" : dgv.Columns(i).HeaderText = "Importo Totale"
                        'Case 9 : dgv.Columns(i).Width = 80 : dgv.Columns(i).Tag = "N2"
                    Case Else : dgv.Columns(i).Width = 250
                End Select

                '  dgv.Columns(i).HeaderText = "da inserire"
                '  Case 7 : dgv.Columns(i).Width = 100 : dgv.Columns(i).Tag = "N2" : dgv.Columns(i).HeaderText = "Importo Unitario"
                '  Case 8 : dgv.Columns(i).Width = 100 : dgv.Columns(i).Tag = "N2" : dgv.Columns(i).HeaderText = "Importo Totale"
                '  dgv.Columns(i).DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            Next

            '' Formattazione automatica tramite libreria WinItalPascal
            ' ***  Assegnare il nome del DataGrid ****
            ColoraColonneSpec(ODataGrid, {8}, Color.Gold, Color.Blue) ' Colonna con Calcolo Automatico
            ColoraColonneSpec(ODataGrid, {0, 1}) ' Colonne Id

        Catch ex As Exception
            IPMessageBox.Show(ex.Message, "Errore ImpColB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Imposta colonne del DataGrid - Ordini senza Fattura"
    Sub ImpColB_KO(ByRef dgv As DataGridView)

        Try
            '' Font generale
            dgv.Font = New Font("Segoe UI", 10, FontStyle.Regular)

            '' Header colonne: font + colori
            With dgv.ColumnHeadersDefaultCellStyle
                .Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .BackColor = Color.LightBlue
                .ForeColor = Color.DarkBlue
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            dgv.EnableHeadersVisualStyles = False
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            '' Imposta colonne dinamicamente
            For i As Integer = 0 To dgv.Columns.Count - 1

                Select Case i
                    Case 0 : dgv.Columns(i).Width = 60
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    Case 1 : dgv.Columns(i).Width = 110
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                     '   dgv.Columns(i).HeaderText = "Id Cliente Ordine"
                    Case 2 : dgv.Columns(i).Width = 100
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case 3 : dgv.Columns(i).Width = 150
                 '   Case 4 : dgv.Columns(i).Width = 120
                    Case 5 : dgv.Columns(i).Width = 250
                    Case 6 : dgv.Columns(i).Width = 80
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case 7 : dgv.Columns(i).Width = 80 : dgv.Columns(i).Tag = "N2"
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgv.Columns(i).HeaderText = "Importo Unitario"
                    Case 8 : dgv.Columns(i).Width = 100 : dgv.Columns(i).Tag = "N2"
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgv.Columns(i).Tag = "N2" : dgv.Columns(i).HeaderText = "Importo Totale"
                    Case 9 : dgv.Columns(i).Width = 120
                    Case 10, 11 : dgv.Columns(i).Width = 0
                    Case Else : dgv.Columns(i).Width = 250
                End Select

                '  dgv.Columns(i).HeaderText = "da inserire"
                '  Case 7 : dgv.Columns(i).Width = 100 : dgv.Columns(i).Tag = "N2" : dgv.Columns(i).HeaderText = "Importo Unitario"
                '  Case 8 : dgv.Columns(i).Width = 100 : dgv.Columns(i).Tag = "N2" : dgv.Columns(i).HeaderText = "Importo Totale"
                '  dgv.Columns(i).DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            Next

            '' Formattazione automatica tramite libreria WinItalPascal
            ' ***  Assegnare il nome del DataGrid ****
            ColoraColonneSpec(ODataGrid, {9}, Color.Gold, Color.Blue) ' Colonna con Calcolo Automatico
            ColoraColonneSpec(ODataGrid, {0}) ' Colonne Id

        Catch ex As Exception
            IPMessageBox.Show(ex.Message, "Errore ImpColB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region " CALCOLI AUTOMATICI NEL DATAGRID "

    ' Verificare il nome del DataGrid e il Numero delle Colonne
    Private Sub ODataGrid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ODataGrid.CellEndEdit

        Try
            If ODataGrid.Rows(e.RowIndex).IsNewRow Then Exit Sub

            If e.ColumnIndex = 6 OrElse e.ColumnIndex = 7 Then
                CalcolaRiga(e.RowIndex)
            End If

        Catch ex As Exception
            IPMessageBox.Show("Errore durante il calcolo: " & ex.Message,
                              "Errore",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CalcolaRiga(rowIndex As Integer)

        Dim row As DataGridViewRow = ODataGrid.Rows(rowIndex)

        Dim Qta As Integer = 0
        Dim Prezzo As Decimal = 0D
        Dim Totale As Decimal = 0D

        ' Qta (colonna 6)
        If Not IsDBNull(row.Cells(6).Value) AndAlso IsNumeric(row.Cells(6).Value) Then
            Qta = Convert.ToInt32(row.Cells(6).Value)
        End If

        ' Prezzo (colonna 7)
        If Not IsDBNull(row.Cells(7).Value) AndAlso IsNumeric(row.Cells(7).Value) Then
            Prezzo = Convert.ToDecimal(row.Cells(7).Value)
            ' Prezzo = Convert.ToInt32(row.Cells(7).Value)  ' Se Integer
        End If

        ' Totale (colonna 8 o 9)
        Totale = Qta * Prezzo
        row.Cells(8).Value = Totale   ' oppure 9 se la tua colonna totale è la 9

    End Sub

#End Region

#Region " EVENTI FILTRO CLIENTI → ORDINI "

    Private Sub CDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CDataGrid.CellClick

        Try
            If e.RowIndex < 0 Then Exit Sub

            Dim idCliX As Integer = CInt(CDataGrid.Rows(e.RowIndex).Cells("IdClienti").Value)

            ResetFiltro(ODataGrid)
            GridFilter.FiltraDgv(ODataGrid, "IDCliOrd = " & idCliX)

            ColoraDgv(CDataGrid, ODataGrid)

        Catch ex As Exception
            FrameworkLogger.LogError(ex, "File Log Errori")
            IPMessageBox.Show("Errore durante il filtraggio: " & ex.Message,
                              "Errore",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Reset Filtra clienti - Ordini"
    Private Sub ResetFiltro(dgv As DataGridView)
        Dim dv As DataView = Nothing

        If TypeOf dgv.DataSource Is BindingSource Then
            Dim bs = DirectCast(dgv.DataSource, BindingSource)
            If bs.List IsNot Nothing AndAlso TypeOf bs.List Is DataView Then
                dv = DirectCast(bs.List, DataView)
            ElseIf TypeOf bs.DataSource Is DataTable Then
                dv = DirectCast(DirectCast(bs.DataSource, DataTable).DefaultView, DataView)
            End If

        ElseIf TypeOf dgv.DataSource Is DataView Then
            dv = DirectCast(dgv.DataSource, DataView)

        ElseIf TypeOf dgv.DataSource Is DataTable Then
            dv = DirectCast(DirectCast(dgv.DataSource, DataTable).DefaultView, DataView)
        End If

        If dv IsNot Nothing Then dv.RowFilter = String.Empty
    End Sub

#End Region

End Class