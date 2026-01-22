<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prod_ListofItems
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
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvListofProd = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbstockSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgvListofProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Guna2GradientPanel1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Items > List of Items"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2Panel1.Controls.Add(Me.dgvListofProd)
        Me.Guna2Panel1.Location = New System.Drawing.Point(14, 130)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1121, 521)
        Me.Guna2Panel1.TabIndex = 26
        '
        'dgvListofProd
        '
        Me.dgvListofProd.AllowUserToAddRows = False
        Me.dgvListofProd.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvListofProd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListofProd.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvListofProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListofProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListofProd.ColumnHeadersHeight = 25
        Me.dgvListofProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvListofProd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListofProd.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListofProd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListofProd.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvListofProd.Location = New System.Drawing.Point(0, 0)
        Me.dgvListofProd.Name = "dgvListofProd"
        Me.dgvListofProd.ReadOnly = True
        Me.dgvListofProd.RowHeadersVisible = False
        Me.dgvListofProd.Size = New System.Drawing.Size(1121, 521)
        Me.dgvListofProd.TabIndex = 2
        Me.dgvListofProd.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.dgvListofProd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvListofProd.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvListofProd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvListofProd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvListofProd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvListofProd.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlDark
        Me.dgvListofProd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvListofProd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvListofProd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListofProd.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvListofProd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListofProd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvListofProd.ThemeStyle.HeaderStyle.Height = 25
        Me.dgvListofProd.ThemeStyle.ReadOnly = True
        Me.dgvListofProd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvListofProd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvListofProd.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvListofProd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListofProd.ThemeStyle.RowsStyle.Height = 22
        Me.dgvListofProd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvListofProd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.tbstockSearch)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(14, 61)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1121, 63)
        Me.Guna2Panel2.TabIndex = 85
        '
        'tbstockSearch
        '
        Me.tbstockSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbstockSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbstockSearch.BackColor = System.Drawing.Color.White
        Me.tbstockSearch.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbstockSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbstockSearch.DefaultText = ""
        Me.tbstockSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbstockSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbstockSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbstockSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbstockSearch.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbstockSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbstockSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tbstockSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbstockSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbstockSearch.Location = New System.Drawing.Point(12, 14)
        Me.tbstockSearch.Name = "tbstockSearch"
        Me.tbstockSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbstockSearch.PlaceholderText = "Search Item code"
        Me.tbstockSearch.SelectedText = ""
        Me.tbstockSearch.Size = New System.Drawing.Size(516, 35)
        Me.tbstockSearch.TabIndex = 82
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "Item_code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 85
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column4.HeaderText = "Category"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 78
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 56
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column6.HeaderText = "VAT"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 49
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column7.HeaderText = "Extended"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 79
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column8.HeaderText = "Stocks"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 64
        '
        'Prod_ListofItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "Prod_ListofItems"
        Me.Size = New System.Drawing.Size(1150, 670)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.dgvListofProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvListofProd As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbstockSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
