<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDB
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
        Me.Btn1_Salva = New RJCodeAdvance.RJControls.RJButton()
        Me.Btn2_Salva = New RJCodeAdvance.RJControls.RJButton()
        Me.BtnConn = New RJCodeAdvance.RJControls.RJButton()
        Me.TxtCerca = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PrimoDataGrid = New System.Windows.Forms.DataGridView()
        Me.SecondoDataGrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCirc = New RJCodeAdvance.RJControls.RJCircularPictureBox()
        Me.ToggleBtn = New RJCodeAdvance.RJControls.RJToggleButton()
        CType(Me.PrimoDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecondoDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCirc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn1_Salva
        '
        Me.Btn1_Salva.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Btn1_Salva.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.Btn1_Salva.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.Btn1_Salva.BorderRadius = 0
        Me.Btn1_Salva.BorderSize = 0
        Me.Btn1_Salva.FlatAppearance.BorderSize = 0
        Me.Btn1_Salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1_Salva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1_Salva.ForeColor = System.Drawing.Color.White
        Me.Btn1_Salva.Location = New System.Drawing.Point(67, 90)
        Me.Btn1_Salva.Name = "Btn1_Salva"
        Me.Btn1_Salva.Size = New System.Drawing.Size(150, 40)
        Me.Btn1_Salva.TabIndex = 0
        Me.Btn1_Salva.Text = "RjButton1"
        Me.Btn1_Salva.TextColor = System.Drawing.Color.White
        Me.Btn1_Salva.UseVisualStyleBackColor = False
        '
        'Btn2_Salva
        '
        Me.Btn2_Salva.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn2_Salva.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn2_Salva.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.Btn2_Salva.BorderRadius = 0
        Me.Btn2_Salva.BorderSize = 0
        Me.Btn2_Salva.FlatAppearance.BorderSize = 0
        Me.Btn2_Salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2_Salva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2_Salva.ForeColor = System.Drawing.Color.Navy
        Me.Btn2_Salva.Location = New System.Drawing.Point(271, 90)
        Me.Btn2_Salva.Name = "Btn2_Salva"
        Me.Btn2_Salva.Size = New System.Drawing.Size(150, 40)
        Me.Btn2_Salva.TabIndex = 1
        Me.Btn2_Salva.Text = "RjButton2"
        Me.Btn2_Salva.TextColor = System.Drawing.Color.Navy
        Me.Btn2_Salva.UseVisualStyleBackColor = False
        '
        'BtnConn
        '
        Me.BtnConn.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.BtnConn.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.BtnConn.BorderColor = System.Drawing.Color.Lime
        Me.BtnConn.BorderRadius = 20
        Me.BtnConn.BorderSize = 5
        Me.BtnConn.FlatAppearance.BorderSize = 0
        Me.BtnConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConn.ForeColor = System.Drawing.Color.White
        Me.BtnConn.Location = New System.Drawing.Point(1052, 60)
        Me.BtnConn.Name = "BtnConn"
        Me.BtnConn.Size = New System.Drawing.Size(181, 85)
        Me.BtnConn.TabIndex = 2
        Me.BtnConn.Text = "Connessione"
        Me.BtnConn.TextColor = System.Drawing.Color.White
        Me.BtnConn.UseVisualStyleBackColor = False
        '
        'TxtCerca
        '
        Me.TxtCerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCerca.Location = New System.Drawing.Point(587, 95)
        Me.TxtCerca.Name = "TxtCerca"
        Me.TxtCerca.Size = New System.Drawing.Size(138, 27)
        Me.TxtCerca.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Gold
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(927, 467)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 27)
        Me.TextBox2.TabIndex = 5
        '
        'PrimoDataGrid
        '
        Me.PrimoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PrimoDataGrid.Location = New System.Drawing.Point(55, 201)
        Me.PrimoDataGrid.Name = "PrimoDataGrid"
        Me.PrimoDataGrid.RowHeadersWidth = 51
        Me.PrimoDataGrid.RowTemplate.Height = 24
        Me.PrimoDataGrid.Size = New System.Drawing.Size(1840, 214)
        Me.PrimoDataGrid.TabIndex = 6
        '
        'SecondoDataGrid
        '
        Me.SecondoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SecondoDataGrid.Location = New System.Drawing.Point(55, 515)
        Me.SecondoDataGrid.Name = "SecondoDataGrid"
        Me.SecondoDataGrid.RowHeadersWidth = 51
        Me.SecondoDataGrid.RowTemplate.Height = 24
        Me.SecondoDataGrid.Size = New System.Drawing.Size(1840, 214)
        Me.SecondoDataGrid.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(745, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1132, 465)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Label3"
        '
        'BtnCirc
        '
        Me.BtnCirc.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat
        Me.BtnCirc.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnCirc.BorderColor2 = System.Drawing.Color.HotPink
        Me.BtnCirc.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid
        Me.BtnCirc.BorderSize = 2
        Me.BtnCirc.GradientAngle = 50.0!
        Me.BtnCirc.Image = Global.WinTest.My.Resources.Resources.cost_book
        Me.BtnCirc.Location = New System.Drawing.Point(178, 428)
        Me.BtnCirc.Name = "BtnCirc"
        Me.BtnCirc.Size = New System.Drawing.Size(66, 66)
        Me.BtnCirc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCirc.TabIndex = 10
        Me.BtnCirc.TabStop = False
        '
        'ToggleBtn
        '
        Me.ToggleBtn.AutoSize = True
        Me.ToggleBtn.Location = New System.Drawing.Point(515, 470)
        Me.ToggleBtn.MinimumSize = New System.Drawing.Size(45, 22)
        Me.ToggleBtn.Name = "ToggleBtn"
        Me.ToggleBtn.OffBackColor = System.Drawing.Color.Gray
        Me.ToggleBtn.OffToggleColor = System.Drawing.Color.Gainsboro
        Me.ToggleBtn.OnBackColor = System.Drawing.Color.MediumSlateBlue
        Me.ToggleBtn.OnToggleColor = System.Drawing.Color.WhiteSmoke
        Me.ToggleBtn.Size = New System.Drawing.Size(45, 22)
        Me.ToggleBtn.TabIndex = 11
        Me.ToggleBtn.UseVisualStyleBackColor = True
        '
        'FrmDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1800, 1055)
        Me.Controls.Add(Me.ToggleBtn)
        Me.Controls.Add(Me.BtnCirc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SecondoDataGrid)
        Me.Controls.Add(Me.PrimoDataGrid)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TxtCerca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConn)
        Me.Controls.Add(Me.Btn2_Salva)
        Me.Controls.Add(Me.Btn1_Salva)
        Me.Name = "FrmDB"
        Me.Text = "FrmDB"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PrimoDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecondoDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCirc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1_Salva As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents Btn2_Salva As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents BtnConn As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents TxtCerca As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PrimoDataGrid As DataGridView
    Friend WithEvents SecondoDataGrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCirc As RJCodeAdvance.RJControls.RJCircularPictureBox
    Friend WithEvents ToggleBtn As RJCodeAdvance.RJControls.RJToggleButton
End Class
