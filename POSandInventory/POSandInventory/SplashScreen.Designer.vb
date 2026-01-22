<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pbLoading = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblStatusText = New System.Windows.Forms.Label()
        Me.LblReportProgress = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLoading
        '
        Me.pbLoading.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbLoading.Location = New System.Drawing.Point(0, 309)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.ProgressColor = System.Drawing.Color.MediumSpringGreen
        Me.pbLoading.ProgressColor2 = System.Drawing.Color.Lime
        Me.pbLoading.Size = New System.Drawing.Size(584, 12)
        Me.pbLoading.TabIndex = 0
        Me.pbLoading.Text = "Guna2ProgressBar1"
        Me.pbLoading.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.POSandInventory.My.Resources.Resources.finaleLOGO
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(242, 5)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(238, 225)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Timer1
        '
        '
        'LblStatusText
        '
        Me.LblStatusText.AutoSize = True
        Me.LblStatusText.BackColor = System.Drawing.Color.Transparent
        Me.LblStatusText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.LblStatusText.Location = New System.Drawing.Point(237, 260)
        Me.LblStatusText.Name = "LblStatusText"
        Me.LblStatusText.Size = New System.Drawing.Size(0, 16)
        Me.LblStatusText.TabIndex = 2
        Me.LblStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblReportProgress
        '
        Me.LblReportProgress.AutoSize = True
        Me.LblReportProgress.BackColor = System.Drawing.Color.Transparent
        Me.LblReportProgress.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReportProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.LblReportProgress.Location = New System.Drawing.Point(283, 290)
        Me.LblReportProgress.Name = "LblReportProgress"
        Me.LblReportProgress.Size = New System.Drawing.Size(0, 16)
        Me.LblReportProgress.TabIndex = 3
        Me.LblReportProgress.Tag = ""
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Square721 BT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(138, 100)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(142, 79)
        Me.Guna2HtmlLabel1.TabIndex = 4
        Me.Guna2HtmlLabel1.Text = "VAS"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Swis721 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(131, 220)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(325, 24)
        Me.Guna2HtmlLabel3.TabIndex = 6
        Me.Guna2HtmlLabel3.Text = "POS &" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Inventory Management System"
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = Global.POSandInventory.My.Resources.Resources.green_background_for_powerpoint_6
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 321)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.LblReportProgress)
        Me.Controls.Add(Me.LblStatusText)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.pbLoading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLoading As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblStatusText As Label
    Friend WithEvents LblReportProgress As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
