<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUno
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCerca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RjBtnSalvaOrdini = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnVerConn = New RJCodeAdvance.RJControls.RJButton()
        Me.BtnSalvaClienti = New RJCodeAdvance.RJControls.RJButton()
        Me.ODataGrid = New System.Windows.Forms.DataGridView()
        Me.CDataGrid = New System.Windows.Forms.DataGridView()
        Me.RjCircTutti = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.RjCircOrdini = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        CType(Me.ODataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircTutti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RjCircOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(620, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cerca - Evidenzia  "
        '
        'TxtCerca
        '
        Me.TxtCerca.BackColor = System.Drawing.Color.Yellow
        Me.TxtCerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCerca.Location = New System.Drawing.Point(831, 176)
        Me.TxtCerca.Name = "TxtCerca"
        Me.TxtCerca.Size = New System.Drawing.Size(152, 30)
        Me.TxtCerca.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(841, 601)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "è calcolata automaticamente"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gold
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(716, 601)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(453, 601)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "La colonna con sfondo   "
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
        Me.RjBtnSalvaOrdini.Location = New System.Drawing.Point(308, 151)
        Me.RjBtnSalvaOrdini.Name = "RjBtnSalvaOrdini"
        Me.RjBtnSalvaOrdini.Size = New System.Drawing.Size(200, 67)
        Me.RjBtnSalvaOrdini.TabIndex = 16
        Me.RjBtnSalvaOrdini.Tag = "ODataGrid"
        Me.RjBtnSalvaOrdini.Text = "Salva Ordini"
        Me.RjBtnSalvaOrdini.TextColor = System.Drawing.Color.Navy
        Me.RjBtnSalvaOrdini.UseVisualStyleBackColor = False
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
        Me.RjBtnVerConn.Location = New System.Drawing.Point(1139, 126)
        Me.RjBtnVerConn.Name = "RjBtnVerConn"
        Me.RjBtnVerConn.Size = New System.Drawing.Size(191, 92)
        Me.RjBtnVerConn.TabIndex = 15
        Me.RjBtnVerConn.Tag = ""
        Me.RjBtnVerConn.Text = "Verifica  Connessione"
        Me.RjBtnVerConn.TextColor = System.Drawing.Color.White
        Me.RjBtnVerConn.UseVisualStyleBackColor = False
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
        Me.BtnSalvaClienti.Location = New System.Drawing.Point(76, 147)
        Me.BtnSalvaClienti.Name = "BtnSalvaClienti"
        Me.BtnSalvaClienti.Size = New System.Drawing.Size(200, 76)
        Me.BtnSalvaClienti.TabIndex = 14
        Me.BtnSalvaClienti.Tag = "CDataGrid"
        Me.BtnSalvaClienti.Text = "Salva Clienti"
        Me.BtnSalvaClienti.TextColor = System.Drawing.Color.White
        Me.BtnSalvaClienti.UseVisualStyleBackColor = False
        '
        'ODataGrid
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ODataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ODataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ODataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.ODataGrid.Location = New System.Drawing.Point(35, 643)
        Me.ODataGrid.Name = "ODataGrid"
        Me.ODataGrid.RowHeadersWidth = 51
        Me.ODataGrid.RowTemplate.Height = 24
        Me.ODataGrid.Size = New System.Drawing.Size(1730, 285)
        Me.ODataGrid.TabIndex = 13
        '
        'CDataGrid
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.CDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CDataGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.CDataGrid.Location = New System.Drawing.Point(35, 238)
        Me.CDataGrid.Name = "CDataGrid"
        Me.CDataGrid.RowHeadersWidth = 51
        Me.CDataGrid.RowTemplate.Height = 24
        Me.CDataGrid.Size = New System.Drawing.Size(1730, 339)
        Me.CDataGrid.TabIndex = 12
        Me.CDataGrid.Tag = "Clienti"
        '
        'RjCircTutti
        '
        Me.RjCircTutti.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.RjCircTutti.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RjCircTutti.BorderColor2 = System.Drawing.Color.HotPink
        Me.RjCircTutti.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.RjCircTutti.BorderSize = 2
        Me.RjCircTutti.GradientAngle = 50.0!
        Me.RjCircTutti.Image = Global.WinTest.My.Resources.Resources.computer
        Me.RjCircTutti.Location = New System.Drawing.Point(323, 583)
        Me.RjCircTutti.Name = "RjCircTutti"
        Me.RjCircTutti.Size = New System.Drawing.Size(58, 58)
        Me.RjCircTutti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircTutti.TabIndex = 23
        Me.RjCircTutti.TabStop = False
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
        Me.RjCircOrdini.Location = New System.Drawing.Point(204, 583)
        Me.RjCircOrdini.Name = "RjCircOrdini"
        Me.RjCircOrdini.Size = New System.Drawing.Size(58, 58)
        Me.RjCircOrdini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RjCircOrdini.TabIndex = 20
        Me.RjCircOrdini.TabStop = False
        '
        'FrmUno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1800, 1055)
        Me.Controls.Add(Me.RjCircTutti)
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
        Me.Name = "FrmUno"
        Me.Text = "FrmUno"
        CType(Me.ODataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircTutti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RjCircOrdini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCerca As TextBox
    Friend WithEvents RjCircOrdini As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RjBtnSalvaOrdini As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnVerConn As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents BtnSalvaClienti As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents ODataGrid As DataGridView
    Friend WithEvents CDataGrid As DataGridView
    Friend WithEvents RjCircTutti As RJCodeAdvance.RJControls.RJCircularPictureBox
End Class
