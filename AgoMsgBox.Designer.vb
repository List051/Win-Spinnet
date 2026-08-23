<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgoMsgBox
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnSi = New System.Windows.Forms.Button()
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.TimerHoverSi = New System.Windows.Forms.Timer(Me.components)
        Me.TimerHoverNo = New System.Windows.Forms.Timer(Me.components)
        Me.PnlContainer = New System.Windows.Forms.Panel()
        Me.LblMessaggio = New System.Windows.Forms.Label()
        Me.LblTitolo = New System.Windows.Forms.Label()
        Me.PicIcona = New System.Windows.Forms.PictureBox()
        Me.TimerClickSi = New System.Windows.Forms.Timer(Me.components)
        Me.TimerClickNo = New System.Windows.Forms.Timer(Me.components)
        Me.PnlContainer.SuspendLayout()
        CType(Me.PicIcona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSi
        '
        Me.BtnSi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.BtnSi.FlatAppearance.BorderSize = 0
        Me.BtnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSi.ForeColor = System.Drawing.Color.White
        Me.BtnSi.Location = New System.Drawing.Point(91, 216)
        Me.BtnSi.Name = "BtnSi"
        Me.BtnSi.Size = New System.Drawing.Size(114, 39)
        Me.BtnSi.TabIndex = 0
        Me.BtnSi.Text = "SI"
        Me.BtnSi.UseVisualStyleBackColor = False
        '
        'BtnNo
        '
        Me.BtnNo.BackColor = System.Drawing.Color.Red
        Me.BtnNo.FlatAppearance.BorderSize = 0
        Me.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNo.ForeColor = System.Drawing.Color.White
        Me.BtnNo.Location = New System.Drawing.Point(311, 216)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(114, 39)
        Me.BtnNo.TabIndex = 1
        Me.BtnNo.Text = "NO"
        Me.BtnNo.UseVisualStyleBackColor = False
        '
        'TimerHoverSi
        '
        Me.TimerHoverSi.Interval = 30
        '
        'TimerHoverNo
        '
        Me.TimerHoverNo.Interval = 30
        '
        'PnlContainer
        '
        Me.PnlContainer.BackColor = System.Drawing.Color.GreenYellow
        Me.PnlContainer.Controls.Add(Me.LblMessaggio)
        Me.PnlContainer.Controls.Add(Me.LblTitolo)
        Me.PnlContainer.Controls.Add(Me.PicIcona)
        Me.PnlContainer.Controls.Add(Me.BtnNo)
        Me.PnlContainer.Controls.Add(Me.BtnSi)
        Me.PnlContainer.Location = New System.Drawing.Point(21, 12)
        Me.PnlContainer.Name = "PnlContainer"
        Me.PnlContainer.Size = New System.Drawing.Size(493, 273)
        Me.PnlContainer.TabIndex = 3
        '
        'LblMessaggio
        '
        Me.LblMessaggio.AutoSize = True
        Me.LblMessaggio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessaggio.Location = New System.Drawing.Point(75, 110)
        Me.LblMessaggio.Name = "LblMessaggio"
        Me.LblMessaggio.Size = New System.Drawing.Size(299, 20)
        Me.LblMessaggio.TabIndex = 4
        Me.LblMessaggio.Text = "Vuoi aprire la pagina di Youtube  ?"
        '
        'LblTitolo
        '
        Me.LblTitolo.AutoSize = True
        Me.LblTitolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitolo.Location = New System.Drawing.Point(122, 59)
        Me.LblTitolo.Name = "LblTitolo"
        Me.LblTitolo.Size = New System.Drawing.Size(185, 25)
        Me.LblTitolo.TabIndex = 3
        Me.LblTitolo.Text = "Titolo del MsgBox"
        '
        'PicIcona
        '
        Me.PicIcona.Image = Global.WinTest.My.Resources.Resources.social_page
        Me.PicIcona.Location = New System.Drawing.Point(20, 15)
        Me.PicIcona.Name = "PicIcona"
        Me.PicIcona.Size = New System.Drawing.Size(96, 81)
        Me.PicIcona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicIcona.TabIndex = 2
        Me.PicIcona.TabStop = False
        '
        'TimerClickSi
        '
        Me.TimerClickSi.Interval = 20
        '
        'TimerClickNo
        '
        Me.TimerClickNo.Interval = 20
        '
        'AgoMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(538, 297)
        Me.ControlBox = False
        Me.Controls.Add(Me.PnlContainer)
        Me.Name = "AgoMsgBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgoMsgBox"
        Me.PnlContainer.ResumeLayout(False)
        Me.PnlContainer.PerformLayout()
        CType(Me.PicIcona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSi As Button
    Friend WithEvents BtnNo As Button
    Friend WithEvents TimerHoverSi As Timer
    Friend WithEvents TimerHoverNo As Timer
    Friend WithEvents PicIcona As PictureBox
    Friend WithEvents PnlContainer As Panel
    Friend WithEvents LblMessaggio As Label
    Friend WithEvents LblTitolo As Label
    Friend WithEvents TimerClickSi As Timer
    Friend WithEvents TimerClickNo As Timer
End Class
