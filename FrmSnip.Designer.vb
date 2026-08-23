<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSnip
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
        Me.CDataGrid = New System.Windows.Forms.DataGridView()
        Me.ODataGrid = New System.Windows.Forms.DataGridView()
        Me.BtnSalvaClienti = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnVerConn = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnSalvaOrdini = New RJCodeAdvance.RJControls.RJButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RjCircOrdini = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.TxtCerca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.CDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ODataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CDataGrid
        '
        Me.CDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CDataGrid.Location = New System.Drawing.Point(45, 165)
        Me.CDataGrid.Name = "CDataGrid"
        Me.CDataGrid.RowHeadersWidth = 51
        Me.CDataGrid.RowTemplate.Height = 24
        Me.CDataGrid.Size = New System.Drawing.Size(1730, 339)
        Me.CDataGrid.TabIndex = 0
        Me.CDataGrid.Tag = "Clienti"
        '
        'ODataGrid
        '
        Me.ODataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ODataGrid.Location = New System.Drawing.Point(45, 570)
        Me.ODataGrid.Name = "ODataGrid"
        Me.ODataGrid.RowHeadersWidth = 51
        Me.ODataGrid.RowTemplate.Height = 24
        Me.ODataGrid.Size = New System.Drawing.Size(1730, 285)
        Me.ODataGrid.TabIndex = 1
        '
        'BtnSalvaClienti
        '
        Me.BtnSalvaClienti.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.BtnSalvaClienti.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.BtnSalvaClienti.BorderColor = System.Drawing.Color.Lime
        Me.BtnSalvaClienti.BorderRadius = 20
        Me.BtnSalvaClienti.BorderSize = 5
        Me.BtnSalvaClienti.FlatAppearance.BorderSize = 0
        Me.BtnSalvaClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvaClienti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvaClienti.ForeColor = System.Drawing.Color.White
        Me.BtnSalvaClienti.Location = New System.Drawing.Point(86, 74)
        Me.BtnSalvaClienti.Name = "BtnSalvaClienti"
        Me.BtnSalvaClienti.Size = New System.Drawing.Size(200, 76)
        Me.BtnSalvaClienti.TabIndex = 2
        Me.BtnSalvaClienti.Tag = "CDataGrid"
        Me.BtnSalvaClienti.Text = "Salva Clienti"
        Me.BtnSalvaClienti.TextColor = System.Drawing.Color.White
        Me.BtnSalvaClienti.UseVisualStyleBackColor = False
        '
        'RjBtnVerConn
        '
        Me.RjBtnVerConn.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnVerConn.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnVerConn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RjBtnVerConn.BorderRadius = 15
        Me.RjBtnVerConn.BorderSize = 8
        Me.RjBtnVerConn.FlatAppearance.BorderSize = 0
        Me.RjBtnVerConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnVerConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnVerConn.ForeColor = System.Drawing.Color.White
        Me.RjBtnVerConn.Location = New System.Drawing.Point(1173, 53)
        Me.RjBtnVerConn.Name = "RjBtnVerConn"
        Me.RjBtnVerConn.Size = New System.Drawing.Size(167, 79)
        Me.RjBtnVerConn.TabIndex = 4
        Me.RjBtnVerConn.Tag = ""
        Me.RjBtnVerConn.Text = "Verifica  Connessione"
        Me.RjBtnVerConn.TextColor = System.Drawing.Color.White
        Me.RjBtnVerConn.UseVisualStyleBackColor = False
        '
        'RjBtnSalvaOrdini
        '
        Me.RjBtnSalvaOrdini.BackColor = System.Drawing.Color.Lime
        Me.RjBtnSalvaOrdini.BackgroundColor = System.Drawing.Color.Lime
        Me.RjBtnSalvaOrdini.BorderColor = System.Drawing.Color.Navy
        Me.RjBtnSalvaOrdini.BorderRadius = 20
        Me.RjBtnSalvaOrdini.BorderSize = 2
        Me.RjBtnSalvaOrdini.FlatAppearance.BorderSize = 0
        Me.RjBtnSalvaOrdini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnSalvaOrdini.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjBtnSalvaOrdini.ForeColor = System.Drawing.Color.Navy
        Me.RjBtnSalvaOrdini.Location = New System.Drawing.Point(318, 78)
        Me.RjBtnSalvaOrdini.Name = "RjBtnSalvaOrdini"
        Me.RjBtnSalvaOrdini.Size = New System.Drawing.Size(200, 67)
        Me.RjBtnSalvaOrdini.TabIndex = 5
        Me.RjBtnSalvaOrdini.Tag = "ODataGrid"
        Me.RjBtnSalvaOrdini.Text = "Salva Ordini"
        Me.RjBtnSalvaOrdini.TextColor = System.Drawing.Color.Navy
        Me.RjBtnSalvaOrdini.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 528)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "La colonna con sfondo   "
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gold
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(726, 528)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(851, 528)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "è calcolata automaticamente"
        '
        'RjCircOrdini
        '
        Me.RjCircOrdini.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircOrdini.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircOrdini.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircOrdini.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircOrdini.BorderSize = 2
        Me.RjCircOrdini.GradientAngle = 50.0!
        Me.RjCircOrdini.Image = Global.WinTest.My.Resources.Resources.browsing
        Me.RjCircOrdini.Location = New System.Drawing.Point(214, 510)
        Me.RjCircOrdini.Name = "RjCircOrdini"
        Me.RjCircOrdini.Size = New System.Drawing.Size(58, 58)
        Me.RjCircOrdini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircOrdini.TabIndex = 9
        Me.RjCircOrdini.TabStop = False
        '
        'TxtCerca
        '
        Me.TxtCerca.BackColor = System.Drawing.Color.Yellow
        Me.TxtCerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCerca.Location = New System.Drawing.Point(841, 103)
        Me.TxtCerca.Name = "TxtCerca"
        Me.TxtCerca.Size = New System.Drawing.Size(152, 30)
        Me.TxtCerca.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(630, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cerca - Evidenzia  "
        '
        'FrmSnip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1835, 890)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCerca)
        Me.Controls.Add(Me.RjCircOrdini)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RjBtnSalvaOrdini)
        Me.Controls.Add(Me.RjBtnVerConn)
        Me.Controls.Add(Me.BtnSalvaClienti)
        Me.Controls.Add(Me.ODataGrid)
        Me.Controls.Add(Me.CDataGrid)
        Me.Name = "FrmSnip"
        Me.Text = "FrmSnip"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ODataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircOrdini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CDataGrid As DataGridView
    Friend WithEvents ODataGrid As DataGridView
    Friend WithEvents BtnSalvaClienti As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnVerConn As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnSalvaOrdini As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RjCircOrdini As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents TxtCerca As TextBox
    Friend WithEvents Label3 As Label
End Class
