
'=================================
' *** WinItalPascal ***
' Autore        : Iaora
' File          : 
' Cartella      : 
' Soluzione     : 
' Creato il     : 
' Modificato il : 
' YouTube       : iaoraGo
' NuGet         : ItalPascal
' GitHub        : List051
'=================================

Imports System.Data.SqlClient
Imports WinItalPascal

Public Class FrmSnip


    '=================================
    ' *** WinItalPascal - Codice Base Form ***
    '=================================
#Region "Imposta campi privati"

    ' Campi privati per gestire Clienti, Ordini e Fatture
    Private dtOrdini As DataTable
    Private dvOrdini As DataView

    Private dtClienti As DataTable
    Private dvClienti As DataView

    Private dtView As DataView
    Private bsFatture As New BindingSource
    Private bsOrdini As New BindingSource
    Private bsClienti As New BindingSource

#End Region

#Region "Carica tabelle per datagrid"

    Private Sub FrmSnip_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        FrmTitolo.CTitolo(Me, "Gestionale creato con mie Snippet")

        ' questo è per winimpcolc
        'ImpColC(CDataGrid, dtClienti)
        'ImpColC(ODataGrid, dtOrdini)

        ' winimpcolb
        ImpColB_C(CDataGrid)    ' Rinominato ImpCol se ho 2 DataGrid da caricare
        ImpColB_O(ODataGrid)

        ColoraDgv(CDataGrid, ODataGrid)
        ' ⭐⭐⭐ ASSEGNAZIONE CORRETTA usando SALVATAGGIO QUALSIASI DATAGRID ⭐⭐⭐
        BtnSalvaClienti.Tag = CDataGrid
        CDataGrid.Tag = "Clienti"

        RjBtnSalvaOrdini.Tag = ODataGrid
        ODataGrid.Tag = "Ordini"


        '===========================================================
        ' Popup per pulsanti principali
        '===========================================================

        Dim imgAggiorna As Image = My.Resources.add
        Dim imgAggClienti As Image = My.Resources.confTel
        Dim imgAggElenco As Image = My.Resources.cheque
        Dim imgConn As Image = My.Resources.warning

        PopupHelper.AttachPopup(RjBtnSalvaOrdini,
                                vbCrLf & "Aggiorna dati" & vbCrLf &
                                "Salva i dati modificati nella cella",
                                imgAggiorna,
                                Color.Aquamarine,
                                Color.Blue)

        PopupHelper.AttachPopup(BtnSalvaClienti,
                                vbCrLf & "Aggiorna cliente" & vbCrLf &
                                "Salva i dati modificati del cliente",
                                imgAggClienti,
                                Color.Aquamarine,
                                Color.Blue)
        PopupHelper.AttachPopup(RjBtnVerConn,
                        vbCrLf & "Verifica Connessione" & vbCrLf &
                        "Salva la tua connessione in 'MiaConnessione' ",
                        imgConn,
                        Color.Aquamarine,
                        Color.Blue)
        PopupHelper.AttachPopup(RjCircOrdini,
                      vbCrLf & "Elenco Completo" & vbCrLf &
                      "Ripopola il DataGrid degli Ordini' ",
                      imgAggElenco,
                      Color.Aquamarine,
                      Color.Blue)

    End Sub

#End Region

#Region "Verifica Connessione"

    Private Sub RjBtnVerConn_Click(sender As Object, e As EventArgs) Handles RjBtnVerConn.Click
        Dim cs = ConfigHelper.GetConnectionString()

        IPMessageBox.Show(
            cs,
            "Connection String --> MiaConnessione"
        )
    End Sub

#End Region

#Region "Colora DataGrid Ordini"
    Private Sub ODataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ODataGrid.CellContentClick
        ColoraDgv(ODataGrid)
    End Sub

    ' Tutti gli ordini
    Private Sub RjCircOrdini_Click(sender As Object, e As EventArgs) Handles RjCircOrdini.Click
        dtOrdini = DB.FillDataTable("SELECT * FROM Ordini")
        ODataGrid.DataSource = dtOrdini
    End Sub
#End Region

#Region "Cerca Evidenzia Clienti"

    '=================================
    ' *** WinItalPascal ***

    Private Sub TxtCerca_TextChanged(sender As Object, e As EventArgs) Handles TxtCerca.TextChanged

        GridUtility.FiltraTutti(CDataGrid, dtClienti, TxtCerca.Text)
        GridUtility.EvidenziaTesto(CDataGrid, TxtCerca.Text)

        If TxtCerca.Text = "" Then
            ColoraDgv(CDataGrid)
        End If

    End Sub
    '=================================

#End Region

#Region "Imposta colonne del DataGrid - Avanzato Clienti"

    '' Imposta colonne con gestione errori, logger e formattazione avanzata

    ' fuori dalla sub
    ' ImpColB(ClientiDataGrid)


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
                    Case 1 : dgv.Columns(i).Width = 250
                    Case 2 : dgv.Columns(i).Width = 250
                    Case 3 : dgv.Columns(i).Width = 220
                    Case 4 : dgv.Columns(i).Width = 60
                    Case 5 : dgv.Columns(i).Width = 70
                        'Case 6 : dgv.Columns(i).Width = 150
                        'Case 7 : dgv.Columns(i).Width = 150
                        ' Case 8 : dgv.Columns(i).Width = 80
                        '  Case 9 : dgv.Columns(i).Width = 80 : dgv.Columns(i).Tag = "N2"
                    Case Else : dgv.Columns(i).Width = 150
                End Select

                'dgv.Columns(i).HeaderText = "da inserire"
            Next

            '' Formattazione automatica tramite libreria WinItalPascal
            GridUtility.AutoFormat(Me)
            ColoraDgv(CDataGrid)
        Catch ex As Exception
            IPMessageBox.Show(ex.Message, "Errore ImpColB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region


#Region "Imposta colonne del DataGrid - Avanzato  Ordini"

    '' Imposta colonne con gestione errori, logger e formattazione avanzata

    ' fuori dalla sub
    ' ImpColB_(DataGrid)


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
                    Case 0 : dgv.Columns(i).Width = 50 : dgv.Columns(i).HeaderText = "Id Ord"
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case 1 : dgv.Columns(i).Width = 60 : dgv.Columns(i).HeaderText = "Id Clienti Ordine"
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case 2 : dgv.Columns(i).Width = 110
                    Case 3 : dgv.Columns(i).Width = 220
                    Case 4 : dgv.Columns(i).Width = 220
                    Case 5 : dgv.Columns(i).Width = 280
                    Case 6 : dgv.Columns(i).Width = 60 : dgv.Columns(i).HeaderText = "Q.tà"
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    Case 7 : dgv.Columns(i).Width = 110 : dgv.Columns(i).Tag = "N2" : dgv.Columns(i).HeaderText = "Importo Unitario"
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Case 8 : dgv.Columns(i).Width = 110 : dgv.Columns(i).Tag = "N2"
                        dgv.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgv.Columns(i).HeaderText = "Importo Totale"
                        dgv.Columns(i).DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                        ' dgv.Columns(i).DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                    Case Else : dgv.Columns(i).Width = 100
                End Select

                '  dgv.Columns(i).HeaderText = "da inserire"
            Next

            '' Formattazione automatica tramite libreria WinItalPascal
            '  GridUtility.AutoFormat(Me) 

            ColoraColonneSpec(ODataGrid, {8}, Color.Gold, Color.Blue)
            ColoraColonneSpec(ODataGrid, {0, 1})
        Catch ex As Exception
            IPMessageBox.Show(ex.Message, "Errore ImpColB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

#Region " EVENTI FILTRO CLIENTI → ORDINI "
    Private Sub CDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CDataGrid.CellContentClick

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
        ColoraDgv(CDataGrid)

    End Sub

#End Region


#Region "Filtra clienti - Ordini"


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


#Region " CALCOLI AUTOMATICI NEL DATAGRID "

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
        End If

        ' Totale (colonna 8 o 9)
        Totale = Qta * Prezzo
        row.Cells(8).Value = Totale   ' oppure 9 se la tua colonna totale è la 9

    End Sub

#End Region
#Region "Salva datagrid Clienti"

    '===========================================================
    ' SALVATAGGIO GENERICO PER QUALSIASI DATAGRID
    '===========================================================
    ' Ora sono inseriti i Tag 
    ' BtnSalvaClienti.Tag = CDataGrid
    ' CDataGrid.Tag = "Clienti"
    Private Sub BtnSalvaClienti_Click(sender As Object, e As EventArgs) Handles BtnSalvaClienti.Click
        ' MsgBox("TAG BtnSalva = " & BtnSalvaClienti.Tag.GetType.ToString())

        Try
            ' 1. Recupera DataGridView dal Tag del pulsante
            Dim dgv As DataGridView = TryCast(BtnSalvaClienti.Tag, DataGridView)

            If dgv Is Nothing Then
                IPMessageBox.Show("Il pulsante non ha un DataGridView associato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' 2. Recupera DataTable dal DataGridView
            Dim dt As DataTable = TryCast(dgv.DataSource, DataTable)
            If dt Is Nothing Then
                IPMessageBox.Show("Il DataGridView non contiene un DataTable valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' 3. Recupera nome tabella dal Tag del DataGridView
            Dim tableName As String = TryCast(dgv.Tag, String)
            If String.IsNullOrEmpty(tableName) Then
                IPMessageBox.Show("Nome tabella non trovato nel Tag del DataGridView.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' 4. Salvataggio
            GridUtility.ConvertiMaiuscolo(CDataGrid)
            Using cn As SqlConnection = DB.GetConnection("MiaConnessione")
                cn.Open()

                Dim sql As String = "SELECT * FROM " & tableName
                Dim da As New SqlDataAdapter(sql, cn)
                Dim cb As New SqlCommandBuilder(da)

                da.Update(dt)
            End Using

            ' 5. Log
            LogLeggiScrivi.ScriviLogMsg("Salvata tabella " & tableName)

            IPMessageBox.Show("Salvataggio completato in tabella  " & tableName, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            LogLeggiScrivi.ScriviLog("Errore Salvataggio", ex)
            IPMessageBox.Show("Errore durante il salvataggio: " & ex.Message,
                          "Errore",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

#Region "Salva qualsiasi DataGrid"

    '===========================================================
    ' ESEMPI DI UTILIZZO
    '===========================================================

    'Private Sub BtnSalvaClienti_Click(sender As Object, e As EventArgs) Handles BtnSalvaClienti.Click
    '    SalvaDgv(CDataGrid, "Clienti")
    'End Sub

    'Private Sub BtnSalvaOrdini_Click(sender As Object, e As EventArgs) Handles BtnSalvaOrdini.Click
    '    SalvaDgv(ODataGrid, "Ordini")
    'End Sub

    Private Sub SalvaDgv(dgv As DataGridView, tableName As String)

        Try
            Dim dt As DataTable = TryCast(dgv.DataSource, DataTable)
            If dt Is Nothing Then
                IPMessageBox.Show("Il DataGridView non contiene un DataTable valido.", "Errore")
                Exit Sub
            End If

            Using cn As SqlConnection = DB.GetConnection("MiaConnessione")
                cn.Open()

                Dim sql As String = "SELECT * FROM " & tableName
                Dim da As New SqlDataAdapter(sql, cn)
                Dim cb As New SqlCommandBuilder(da)

                da.Update(dt)
            End Using

            LogLeggiScrivi.ScriviLogMsg("Salvata tabella " & tableName)
            IPMessageBox.Show("Salvataggio completato in tabella  " & tableName, "OK")

        Catch ex As Exception
            LogLeggiScrivi.ScriviLog("Errore Salvataggio", ex)
            IPMessageBox.Show("Errore durante il salvataggio: " & ex.Message, "Errore")
        End Try

    End Sub

#End Region

#Region "Salva Ordini"


    Private Sub RjBtnSalvaOrdini_Click(sender As Object, e As EventArgs) Handles RjBtnSalvaOrdini.Click
        '===========================================================
        ' SALVATAGGIO GENERICO PER QUALSIASI DATAGRID
        '===========================================================

        ' Esempio utilizzo:
        ' BtnSalvaClienti_Click → SalvaDgv(CDataGrid, "Clienti")
        ' BtnSalvaOrdini_Click  → SalvaDgv(ODataGrid, "Ordini")

        Try
            GridUtility.ConvertiMaiuscolo(ODataGrid)
            SalvaDgv(ODataGrid, "Ordini")

            ' Log automatico
            '   LogLeggiScrivi.ScriviLogMsg("Salvata tabella " & tableName)

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


End Class