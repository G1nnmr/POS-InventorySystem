<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelProfile = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGVPrivacy = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelProfile.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DGVPrivacy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelProfile
        '
        Me.panelProfile.Controls.Add(Me.Guna2Separator1)
        Me.panelProfile.Controls.Add(Me.Guna2Panel3)
        Me.panelProfile.Controls.Add(Me.Guna2Panel2)
        Me.panelProfile.Controls.Add(Me.Guna2Panel1)
        Me.panelProfile.Controls.Add(Me.Guna2GradientPanel1)
        Me.panelProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelProfile.Location = New System.Drawing.Point(0, 0)
        Me.panelProfile.Name = "panelProfile"
        Me.panelProfile.Size = New System.Drawing.Size(1150, 620)
        Me.panelProfile.TabIndex = 26
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 80)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(944, 13)
        Me.Guna2Separator1.TabIndex = 95
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackgroundImage = Global.POSandInventory.My.Resources.Resources.green_background_for_powerpoint_6
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel3.Location = New System.Drawing.Point(950, 80)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(200, 540)
        Me.Guna2Panel3.TabIndex = 94
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.POSandInventory.My.Resources.Resources.Fill_out_amico
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 179)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(194, 210)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.btnEdit)
        Me.Guna2Panel2.Controls.Add(Me.btnRefresh)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1150, 40)
        Me.Guna2Panel2.TabIndex = 93
        '
        'btnEdit
        '
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEdit.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnEdit.Location = New System.Drawing.Point(714, 7)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(112, 27)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Profiles"
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRefresh.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRefresh.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnRefresh.Location = New System.Drawing.Point(832, 7)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(112, 27)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Reload"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.DGVPrivacy)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 99)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(944, 518)
        Me.Guna2Panel1.TabIndex = 92
        '
        'DGVPrivacy
        '
        Me.DGVPrivacy.AllowUserToAddRows = False
        Me.DGVPrivacy.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGVPrivacy.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPrivacy.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPrivacy.ColumnHeadersHeight = 25
        Me.DGVPrivacy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVPrivacy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column2, Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPrivacy.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVPrivacy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPrivacy.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DGVPrivacy.Location = New System.Drawing.Point(0, 0)
        Me.DGVPrivacy.Name = "DGVPrivacy"
        Me.DGVPrivacy.ReadOnly = True
        Me.DGVPrivacy.RowHeadersVisible = False
        Me.DGVPrivacy.Size = New System.Drawing.Size(944, 518)
        Me.DGVPrivacy.TabIndex = 0
        Me.DGVPrivacy.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.DGVPrivacy.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVPrivacy.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVPrivacy.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVPrivacy.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVPrivacy.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVPrivacy.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVPrivacy.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DGVPrivacy.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.DGVPrivacy.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVPrivacy.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPrivacy.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVPrivacy.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVPrivacy.ThemeStyle.HeaderStyle.Height = 25
        Me.DGVPrivacy.ThemeStyle.ReadOnly = True
        Me.DGVPrivacy.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVPrivacy.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVPrivacy.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPrivacy.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVPrivacy.ThemeStyle.RowsStyle.Height = 22
        Me.DGVPrivacy.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DGVPrivacy.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2GradientPanel1.BackgroundImage = Global.POSandInventory.My.Resources.Resources.green_background_for_powerpoint_6
        Me.Guna2GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1150, 40)
        Me.Guna2GradientPanel1.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(25, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Accounts > Manage Profile"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Id"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 39
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Username"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Password"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Access Type"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panelProfile)
        Me.Name = "Profile"
        Me.Size = New System.Drawing.Size(1150, 620)
        Me.panelProfile.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.DGVPrivacy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelProfile As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGVPrivacy As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
