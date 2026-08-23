
'=================================
' *** WinItalPascal ***
' Autore        : Iaora
' File          : AgoMsgBox
' Cartella      : 
' Soluzione     : MsgBox Personalizzato
' Creato il     : 
' Modificato il : 
' YouTube       : iaoraGo
' NuGet         : ItalPascal
' GitHub        : List051
'=================================

Imports WinItalPascal

Public Class AgoMsgBox

    Public Sub AgoMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Bordo arrotondato stile Windows 11
        ' Angoli arrotondati evidenti inseriti 
        ' in una sub ArrotondaAngoli

        ArrotondaAngoli(Me, 30)
        ArrotondaAngoli(PnlContainer, 25)

    End Sub

    Public Property Risultato As DialogResult = DialogResult.None

        Public Sub New(titolo As String, messaggio As String, icona As Image)
            InitializeComponent()

            ' Titolo e testo
            LblTitolo.Text = titolo
            LblMessaggio.Text = messaggio

            ' Icona
            PicIcona.Image = icona

            ' Effetto Windows 11 (ombra)
            Me.FormBorderStyle = FormBorderStyle.None
        'Me.BackColor = Color.White
        Me.Padding = New Padding(1)
        End Sub

#Region "Arrotonda gli angoli"
    Private Sub ArrotondaAngoli(ctrl As Control, raggio As Integer)

        Dim r As New Drawing2D.GraphicsPath()

        r.AddArc(0, 0, raggio, raggio, 180, 90)
        r.AddArc(ctrl.Width - raggio, 0, raggio, raggio, 270, 90)
        r.AddArc(ctrl.Width - raggio, ctrl.Height - raggio, raggio, raggio, 0, 90)
        r.AddArc(0, ctrl.Height - raggio, raggio, raggio, 90, 90)
        r.CloseAllFigures()

        ctrl.Region = New Region(r)

    End Sub

    ' per sicurezza se ridimensiono il panel
    Private Sub PnlContainer_Resize(sender As Object, e As EventArgs) Handles PnlContainer.Resize
        ArrotondaAngoli(PnlContainer, 25)
    End Sub

#End Region

    ' Colori Fluent
    Private ColoreBaseSi As Color = Color.FromArgb(0, 120, 215)
    Private ColoreHoverSi As Color = Color.FromArgb(0, 140, 235)

    Private ColoreBaseNo As Color = Color.FromArgb(240, 240, 240)
    Private ColoreHoverNo As Color = Color.FromArgb(220, 220, 220)

    Private Sub BtnSi_MouseEnter(sender As Object, e As EventArgs) Handles BtnSi.MouseEnter
        TimerHoverSi.Tag = "hover"
        TimerHoverSi.Start()
    End Sub

    Private Sub BtnSi_MouseLeave(sender As Object, e As EventArgs) Handles BtnSi.MouseLeave
        TimerHoverSi.Tag = "leave"
        TimerHoverSi.Start()
    End Sub


    Private Sub BtnNo_MouseEnter(sender As Object, e As EventArgs) Handles BtnNo.MouseEnter
        TimerHoverNo.Tag = "hover"
        TimerHoverNo.Start()
    End Sub

    Private Sub BtnNo_MouseLeave(sender As Object, e As EventArgs) Handles BtnNo.MouseLeave
        TimerHoverNo.Tag = "leave"
        TimerHoverNo.Start()
    End Sub


    Private Sub BtnSi_Click(sender As Object, e As EventArgs) Handles BtnSi.Click
        Risultato = DialogResult.Yes
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

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Risultato = DialogResult.No
        Me.Close()
    End Sub

    ' ***********

    'Private Function AnimateColor(current As Color, target As Color) As Color
    '    Dim stepValue As Integer = 15

    '    Dim r As Integer = current.R + Math.Sign(target.R - current.R) * stepValue
    '    Dim g As Integer = current.G + Math.Sign(target.G - current.G) * stepValue
    '    Dim b As Integer = current.B + Math.Sign(target.B - current.B) * stepValue

    '    If Math.Abs(target.R - r) < stepValue Then r = target.R
    '    If Math.Abs(target.G - g) < stepValue Then g = target.G
    '    If Math.Abs(target.B - b) < stepValue Then b = target.B

    '    Return Color.FromArgb(r, g, b)
    'End Function

End Class