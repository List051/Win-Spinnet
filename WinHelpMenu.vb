
'=================================
' *** WinItalPascal ***
' Autore        : Iaora
' File          : WinTest
' Cartella      : 
' Soluzione     : 
' Creato il     : 18/08/2026
' Modificato il : 
' YouTube       : iaoraGo
' NuGet         : ItalPascal
' GitHub        : List051
'=================================
' Utilizzo Inserito in Frm
'Dim menu As New WinHelpMenu
'menu.Show()
'================================

Imports WinItalPascal

Public Class WinHelpMenu

    Private Sub WinHelpMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmTitolo.CTitolo(Me, "WinItalPascal - Help Menu")

        Me.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    '===========================================================
    ' 1. Apri Riepilogo Snippet (WinHelp)
    '===========================================================
    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        Dim helpText As String =
"WINITALPASCAL – RIEPILOGO SNIPPET" & vbCrLf &
vbCrLf &
"WinCod – Codice Base Form" & vbCrLf &
"WinCodB – Codice Base Avanzato" & vbCrLf &
"WinImpCol – Colonne manuali" & vbCrLf &
"WinImpColB – Colonne dinamiche" & vbCrLf &
"WinImpColC – Colonne auto-detect tipi" & vbCrLf &
"WinImpColMix – Colonne mix (auto-detect + override)" & vbCrLf &
"WinLog – Routine log avanzata"

        IPMessageBox.Show(helpText, "Riepilogo Snippet")
    End Sub

    '===========================================================
    ' 2. Apri Log
    '===========================================================
    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click

        Try


            If IPMessageBox.Show("Vuoi cancellare record vecchi nel file di log?",
                                 "Conferma",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question) = DialogResult.Yes Then

                LogLeggiScrivi.ClearLog()   ' il numero è opzionale, default elimina fino a vedere 5 gruppi
            End If

            ' Per leggere Avviso corto va bene
            Dim leggiLog = IPMessageBox.Show(LogReader.ReadLog(), "Apro il file di log")

        Catch ex As Exception
            LogLeggiScrivi.ScriviLog("File Log", ex)   ' con nuovo file di Log

            IPMessageBox.Show("ERRORE SALVATAGGIO: " & ex.Message,
                              "Errore",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error)
        End Try

    End Sub

    '===========================================================
    ' 3. Apri Form di esempio (Clienti/Ordini)
    '===========================================================
    Private Sub BtnFormEsempio_Click(sender As Object, e As EventArgs) Handles BtnFormEsempio.Click
        Dim frm As New FrmCliOrd
        frm.Show()
    End Sub

    '===========================================================
    ' 4. Apri cartella Snippet
    '===========================================================
    Private Sub BtnApriSnippet_Click(sender As Object, e As EventArgs) Handles BtnApriSnippet.Click
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) &
                             "\Visual Studio 2022\Code Snippets\Visual Basic\My Code Snippets\"
        Process.Start("explorer.exe", path)
    End Sub

    '===========================================================
    ' 5. Chiudi Menu
    '===========================================================
    Private Sub BtnChiudi_Click(sender As Object, e As EventArgs) Handles BtnChiudi.Click
        Me.Close()
    End Sub

End Class
