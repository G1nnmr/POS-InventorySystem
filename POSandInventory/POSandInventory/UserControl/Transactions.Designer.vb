<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSales = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbTSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnPFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.radiobtnToday = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.radiobtnMonth = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvTransactions = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(22, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Transactions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1150, 73)
        Me.Guna2Panel1.TabIndex = 26
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.93333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.06667!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblSales, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(14, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1121, 67)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lblSales
        '
        Me.lblSales.BackColor = System.Drawing.Color.Transparent
        Me.lblSales.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSales.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.ForeColor = System.Drawing.Color.White
        Me.lblSales.Location = New System.Drawing.Point(1042, 3)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(76, 61)
        Me.lblSales.TabIndex = 7
        Me.lblSales.Text = "0.00"
        Me.lblSales.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sales Report"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel2.Controls.Add(Me.Guna2Separator2)
        Me.Guna2Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2Panel2.Controls.Add(Me.dgvTransactions)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 113)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1150, 557)
        Me.Guna2Panel2.TabIndex = 27
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator2.FillColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Separator2.Location = New System.Drawing.Point(11, 66)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(1128, 10)
        Me.Guna2Separator2.TabIndex = 32
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.96732!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.03268!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbTSearch, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPFilter, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker2, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.radiobtnToday, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker1, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.radiobtnMonth, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 22)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1127, 38)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'tbTSearch
        '
        Me.tbTSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbTSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbTSearch.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbTSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTSearch.DefaultText = ""
        Me.tbTSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tbTSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbTSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTSearch.Location = New System.Drawing.Point(3, 3)
        Me.tbTSearch.Name = "tbTSearch"
        Me.tbTSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTSearch.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.tbTSearch.PlaceholderText = "Search Transaction No"
        Me.tbTSearch.SelectedText = ""
        Me.tbTSearch.Size = New System.Drawing.Size(350, 32)
        Me.tbTSearch.TabIndex = 21
        '
        'btnPFilter
        '
        Me.btnPFilter.Animated = True
        Me.btnPFilter.AutoRoundedCorners = True
        Me.btnPFilter.BackColor = System.Drawing.Color.Transparent
        Me.btnPFilter.BorderRadius = 15
        Me.btnPFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPFilter.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPFilter.ForeColor = System.Drawing.Color.White
        Me.btnPFilter.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPFilter.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnPFilter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnPFilter.Location = New System.Drawing.Point(976, 3)
        Me.btnPFilter.Name = "btnPFilter"
        Me.btnPFilter.Size = New System.Drawing.Size(148, 32)
        Me.btnPFilter.TabIndex = 22
        Me.btnPFilter.Text = "Filter"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker2.Location = New System.Drawing.Point(755, 10)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(215, 20)
        Me.DateTimePicker2.TabIndex = 26
        '
        'radiobtnToday
        '
        Me.radiobtnToday.AutoSize = True
        Me.radiobtnToday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radiobtnToday.CheckedState.BorderThickness = 0
        Me.radiobtnToday.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radiobtnToday.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radiobtnToday.CheckedState.InnerOffset = -4
        Me.radiobtnToday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radiobtnToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.radiobtnToday.Location = New System.Drawing.Point(359, 3)
        Me.radiobtnToday.Name = "radiobtnToday"
        Me.radiobtnToday.Size = New System.Drawing.Size(56, 32)
        Me.radiobtnToday.TabIndex = 23
        Me.radiobtnToday.Text = "Today"
        Me.radiobtnToday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radiobtnToday.UncheckedState.BorderThickness = 2
        Me.radiobtnToday.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radiobtnToday.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePicker1.Location = New System.Drawing.Point(526, 10)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'radiobtnMonth
        '
        Me.radiobtnMonth.AutoSize = True
        Me.radiobtnMonth.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radiobtnMonth.CheckedState.BorderThickness = 0
        Me.radiobtnMonth.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radiobtnMonth.CheckedState.InnerColor = System.Drawing.Color.White
        Me.radiobtnMonth.CheckedState.InnerOffset = -4
        Me.radiobtnMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radiobtnMonth.Location = New System.Drawing.Point(421, 3)
        Me.radiobtnMonth.Name = "radiobtnMonth"
        Me.radiobtnMonth.Size = New System.Drawing.Size(99, 32)
        Me.radiobtnMonth.TabIndex = 24
        Me.radiobtnMonth.Text = "Current Month"
        Me.radiobtnMonth.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.radiobtnMonth.UncheckedState.BorderThickness = 2
        Me.radiobtnMonth.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.radiobtnMonth.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(724, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 28)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "to"
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AllowUserToAddRows = False
        Me.dgvTransactions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvTransactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransactions.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransactions.ColumnHeadersHeight = 30
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvTransactions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransactions.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTransactions.EnableHeadersVisualStyles = True
        Me.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvTransactions.Location = New System.Drawing.Point(11, 82)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.ReadOnly = True
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect
        Me.dgvTransactions.Size = New System.Drawing.Size(1128, 475)
        Me.dgvTransactions.TabIndex = 29
        Me.dgvTransactions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvTransactions.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgvTransactions.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvTransactions.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvTransactions.ThemeStyle.ReadOnly = True
        Me.dgvTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTransactions.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvTransactions.ThemeStyle.RowsStyle.Height = 22
        Me.dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 41
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Transaction No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Format = "F"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Total Amount"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 95
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Separator1.Location = New System.Drawing.Point(11, 6)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1128, 10)
        Me.Guna2Separator1.TabIndex = 28
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "Transactions"
        Me.Size = New System.Drawing.Size(1150, 670)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvTransactions As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblSales As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tbTSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnPFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents radiobtnToday As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents radiobtnMonth As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
