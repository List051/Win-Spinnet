
'Imports System.Windows.Forms
'Imports System.Drawing

Imports WinItalPascal
Public Class FrmMenu


    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ScreenUtility.FullScreen(Me)
        FrmTitolo.CTitolo(Me, "Gestione DB con WinItalPascal")
        Apripop()
    End Sub
    Private Sub CloseOpenForm()
        ' Crea una lista dei form aperti (senza modificare Application.OpenForms durante il ciclo)
        Dim openFormsList As New List(Of Form)

        ' Aggiungi i form aperti alla lista
        For Each f As Form In Application.OpenForms
            ' Escludi FrmMenu dalla chiusura
            If f.Name <> "Form1" Then
                openFormsList.Add(f)
            End If
        Next

        ' Chiudi ogni form nella lista, tranne FrmMenu
        For Each f As Form In openFormsList
            If f.Name = "FrmClienti" AndAlso f.Visible Then   ' Gestione Clienti
                f.Close()
                'ElseIf f.Name = "FrmB" AndAlso f.Visible Then ' Stampa Report Clienti
                '    f.Close()
                'ElseIf f.Name = "FrmC" AndAlso f.Visible Then ' Gestione Clienti
                '    f.Close()
                'ElseIf f.Name = "FrmD" AndAlso f.Visible Then ' Gestione Ordini
                '    f.Close()
                'ElseIf f.Name = "FrmM" AndAlso f.Visible Then ' Gestione Materiale
                '    f.Close()
                'ElseIf f.Name = "FrmFattura" AndAlso f.Visible Then ' Gestione Fattura
                '    f.Close()
                'ElseIf f.Name = "FrmReport" AndAlso f.Visible Then ' Gestione Report
                '    f.Close()
            End If
        Next

    End Sub
    Private Sub BtnEsciChiudi_Click(sender As Object, e As EventArgs) Handles BtnEsciChiudi.Click
        Dim result As DialogResult = IPMessageBox.Show("Sei sicuro di voler uscire?", "Uscita",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Sub Apripop()


        '===========================================================
        ' Popup per pulsanti principali
        '===========================================================

        Dim imgAggiorna As Image = My.Resources.add
        Dim imgAggClienti As Image = My.Resources.confTel
        Dim imgAggElenco As Image = My.Resources.cheque
        Dim imgConn As Image = My.Resources.warning

        PopupHelper.AttachPopup(Button3,
                                vbCrLf & "Aggiorna dati" & vbCrLf &
                                "Apre stesso tipo di form MA con altro DB",
                                imgAggiorna,
                                Color.Aquamarine,
                                Color.Blue)

        'PopupHelper.AttachPopup(BtnSalva,
        '                        vbCrLf & "Aggiorna cliente" & vbCrLf &
        '                        "Salva i dati modificati del cliente",
        '                        imgAggClienti,
        '                        Color.Aquamarine,
        '                        Color.Blue)

        'PopupHelper.AttachPopup(RjCirc,
        '                  vbCrLf & "Elenco Completo" & vbCrLf &
        '                  "Ripopola il DataGrid degli Ordini' ",
        '                  imgAggElenco,
        '                  Color.Aquamarine,
        '                  Color.Blue)

        'PopupHelper.AttachPopup(RjBtnVerConn,
        '                vbCrLf & "Verifica Connessione" & vbCrLf &
        '                "Salva la tua connessione in 'MiaConnessione' ",
        '                imgConn,
        '                Color.Aquamarine,
        '                Color.Blue)



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmDB.Show()  ' Creo un altro Form per Cambio DataBase
    End Sub

    Private Sub BtnApriClienti_Click(sender As Object, e As EventArgs) Handles BtnApriClienti.Click

        ' FrmClienti.Show()

        'CloseOpenForm()
        'With FrmClienti   ' da fare
        '    .TopLevel = False
        '    PanelBody.Controls.Add(FrmClienti)
        '    .BringToFront()
        '    .Show()
        'End With
    End Sub

    Private Sub BtnFrmAprire_Click(sender As Object, e As EventArgs) Handles BtnFrmAprire.Click
        FrmAprire.Show()
    End Sub

    Private Sub BtnApriOrdini_Click(sender As Object, e As EventArgs) Handles BtnApriOrdini.Click
        ' apri Ordini da fare
    End Sub

    Private Sub BtnCliOrd_Click(sender As Object, e As EventArgs) Handles BtnCliOrd.Click
        FrmCliOrd.Show()
    End Sub

    Private Sub BtnInsClientiSenzaBS_Click(sender As Object, e As EventArgs) Handles BtnInsClientiSenzaBS.Click
        FemInsClienti.Show()
    End Sub

    Private Sub BtnApriFatture_Click(sender As Object, e As EventArgs) Handles BtnApriFatture.Click
        FrmFattura.Show()
    End Sub


    Private Sub RjBtnInfo_Click(sender As Object, e As EventArgs) Handles RjBtnInfo.Click
        IPMessageBox.Show("Info per cambio DataSet")
        Info.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WinHelpMenu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmUno.Show()
    End Sub

    Private Sub PictIaora_Click(sender As Object, e As EventArgs) Handles PictIaora.Click
        Dim icona As Image = My.Resources.browsing

        Dim frm As New AgoMsgBox(
            "Apri YouTube di IAORA  ?",
            "Hai già un browser aperto ? " & vbCrLf & vbCrLf &
            "Sì per procedere, No per annullare.",
            icona
        )

        frm.ShowDialog()

        If frm.Risultato = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim psi As New ProcessStartInfo With {
                .FileName = "https://www.youtube.com/@iaoraGo/playlists",
                .UseShellExecute = True
            }
            Process.Start(psi)

        Catch ex As Exception
            IPMessageBox.Show(
                "Errore durante l'apertura del browser:" & vbCrLf &
                ex.Message,
                "Errore",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub
End Class
