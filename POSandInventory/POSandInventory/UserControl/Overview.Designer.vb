<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Overview
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.lbldTime = New System.Windows.Forms.Label()
        Me.dashPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbldDate = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblNoOfTodaySales = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblTodaySales = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowPanel6 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblNoOfUsers = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowPanel5 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblNoOfMonthlySales = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowPanel4 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblMonthlySales = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ShadowPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblNoOfItems = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Shapes4 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.dashPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel2.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Guna2ShadowPanel6.SuspendLayout()
        Me.Guna2ShadowPanel5.SuspendLayout()
        Me.Guna2ShadowPanel4.SuspendLayout()
        Me.Guna2ShadowPanel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lbldTime
        '
        Me.lbldTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldTime.AutoSize = True
        Me.lbldTime.BackColor = System.Drawing.Color.Transparent
        Me.lbldTime.Font = New System.Drawing.Font("Square721 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lbldTime.Location = New System.Drawing.Point(895, 90)
        Me.lbldTime.Name = "lbldTime"
        Me.lbldTime.Size = New System.Drawing.Size(47, 20)
        Me.lbldTime.TabIndex = 41
        Me.lbldTime.Text = "Date"
        '
        'dashPanel
        '
        Me.dashPanel.Controls.Add(Me.Guna2Separator1)
        Me.dashPanel.Controls.Add(Me.DataGridView1)
        Me.dashPanel.Controls.Add(Me.lbldDate)
        Me.dashPanel.Controls.Add(Me.lbldTime)
        Me.dashPanel.Controls.Add(Me.Guna2ShadowPanel2)
        Me.dashPanel.Controls.Add(Me.Guna2ShadowPanel1)
        Me.dashPanel.Controls.Add(Me.Guna2ShadowPanel6)
        Me.dashPanel.Controls.Add(Me.Guna2ShadowPanel5)
        Me.dashPanel.Controls.Add(Me.Guna2ShadowPanel4)
        Me.dashPanel.Controls.Add(Me.Guna2ShadowPanel3)
        Me.dashPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashPanel.FillColor = System.Drawing.Color.WhiteSmoke
        Me.dashPanel.Location = New System.Drawing.Point(0, 44)
        Me.dashPanel.Name = "dashPanel"
        Me.dashPanel.Size = New System.Drawing.Size(1150, 626)
        Me.dashPanel.TabIndex = 77
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Separator1.Location = New System.Drawing.Point(119, 146)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(913, 10)
        Me.Guna2Separator1.TabIndex = 46
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column4})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 510)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1150, 116)
        Me.DataGridView1.TabIndex = 45
        Me.DataGridView1.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "SN"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bill Date"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bill Month"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total Amount"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'lbldDate
        '
        Me.lbldDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldDate.AutoSize = True
        Me.lbldDate.BackColor = System.Drawing.Color.Transparent
        Me.lbldDate.Font = New System.Drawing.Font("Square721 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldDate.ForeColor = System.Drawing.Color.Black
        Me.lbldDate.Location = New System.Drawing.Point(880, 110)
        Me.lbldDate.Name = "lbldDate"
        Me.lbldDate.Size = New System.Drawing.Size(36, 15)
        Me.lbldDate.TabIndex = 42
        Me.lbldDate.Text = "Date"
        '
        'Guna2ShadowPanel2
        '
        Me.Guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel2.Controls.Add(Me.lblNoOfTodaySales)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2ShadowPanel2.FillColor = System.Drawing.Color.LightGray
        Me.Guna2ShadowPanel2.Location = New System.Drawing.Point(119, 395)
        Me.Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Me.Guna2ShadowPanel2.Radius = 10
        Me.Guna2ShadowPanel2.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel2.ShadowDepth = 20
        Me.Guna2ShadowPanel2.Size = New System.Drawing.Size(226, 141)
        Me.Guna2ShadowPanel2.TabIndex = 27
        '
        'lblNoOfTodaySales
        '
        Me.lblNoOfTodaySales.AutoSize = True
        Me.lblNoOfTodaySales.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfTodaySales.Font = New System.Drawing.Font("Segoe UI Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfTodaySales.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoOfTodaySales.Location = New System.Drawing.Point(70, 39)
        Me.lblNoOfTodaySales.Name = "lblNoOfTodaySales"
        Me.lblNoOfTodaySales.Size = New System.Drawing.Size(75, 86)
        Me.lblNoOfTodaySales.TabIndex = 2
        Me.lblNoOfTodaySales.Text = "0"
        Me.lblNoOfTodaySales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(21, 17)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(124, 19)
        Me.Guna2HtmlLabel3.TabIndex = 3
        Me.Guna2HtmlLabel3.Text = "No. of Today's Sales"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblTodaySales)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(119, 171)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.ShadowDepth = 20
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(459, 210)
        Me.Guna2ShadowPanel1.TabIndex = 26
        '
        'lblTodaySales
        '
        Me.lblTodaySales.AutoSize = True
        Me.lblTodaySales.BackColor = System.Drawing.Color.Transparent
        Me.lblTodaySales.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodaySales.ForeColor = System.Drawing.Color.White
        Me.lblTodaySales.Location = New System.Drawing.Point(92, 73)
        Me.lblTodaySales.Name = "lblTodaySales"
        Me.lblTodaySales.Size = New System.Drawing.Size(165, 86)
        Me.lblTodaySales.TabIndex = 2
        Me.lblTodaySales.Text = "0.00"
        Me.lblTodaySales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(21, 17)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(77, 19)
        Me.Guna2HtmlLabel2.TabIndex = 3
        Me.Guna2HtmlLabel2.Text = "Today's Sale"
        '
        'Guna2ShadowPanel6
        '
        Me.Guna2ShadowPanel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel6.Controls.Add(Me.lblNoOfUsers)
        Me.Guna2ShadowPanel6.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2ShadowPanel6.FillColor = System.Drawing.Color.LightGray
        Me.Guna2ShadowPanel6.Location = New System.Drawing.Point(584, 395)
        Me.Guna2ShadowPanel6.Name = "Guna2ShadowPanel6"
        Me.Guna2ShadowPanel6.Radius = 10
        Me.Guna2ShadowPanel6.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel6.ShadowDepth = 20
        Me.Guna2ShadowPanel6.Size = New System.Drawing.Size(208, 141)
        Me.Guna2ShadowPanel6.TabIndex = 31
        '
        'lblNoOfUsers
        '
        Me.lblNoOfUsers.AutoSize = True
        Me.lblNoOfUsers.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfUsers.Font = New System.Drawing.Font("Segoe UI Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfUsers.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoOfUsers.Location = New System.Drawing.Point(64, 38)
        Me.lblNoOfUsers.Name = "lblNoOfUsers"
        Me.lblNoOfUsers.Size = New System.Drawing.Size(75, 86)
        Me.lblNoOfUsers.TabIndex = 2
        Me.lblNoOfUsers.Text = "0"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(21, 17)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(77, 19)
        Me.Guna2HtmlLabel7.TabIndex = 3
        Me.Guna2HtmlLabel7.Text = "No. of Users"
        '
        'Guna2ShadowPanel5
        '
        Me.Guna2ShadowPanel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel5.Controls.Add(Me.lblNoOfMonthlySales)
        Me.Guna2ShadowPanel5.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2ShadowPanel5.FillColor = System.Drawing.Color.LightGray
        Me.Guna2ShadowPanel5.Location = New System.Drawing.Point(351, 395)
        Me.Guna2ShadowPanel5.Name = "Guna2ShadowPanel5"
        Me.Guna2ShadowPanel5.Radius = 10
        Me.Guna2ShadowPanel5.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel5.ShadowDepth = 20
        Me.Guna2ShadowPanel5.Size = New System.Drawing.Size(227, 141)
        Me.Guna2ShadowPanel5.TabIndex = 30
        '
        'lblNoOfMonthlySales
        '
        Me.lblNoOfMonthlySales.AutoSize = True
        Me.lblNoOfMonthlySales.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfMonthlySales.Font = New System.Drawing.Font("Segoe UI Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfMonthlySales.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoOfMonthlySales.Location = New System.Drawing.Point(65, 39)
        Me.lblNoOfMonthlySales.Name = "lblNoOfMonthlySales"
        Me.lblNoOfMonthlySales.Size = New System.Drawing.Size(75, 86)
        Me.lblNoOfMonthlySales.TabIndex = 2
        Me.lblNoOfMonthlySales.Text = "0"
        Me.lblNoOfMonthlySales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(21, 17)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(129, 19)
        Me.Guna2HtmlLabel6.TabIndex = 3
        Me.Guna2HtmlLabel6.Text = "No. of Monthly Sales"
        '
        'Guna2ShadowPanel4
        '
        Me.Guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel4.Controls.Add(Me.lblMonthlySales)
        Me.Guna2ShadowPanel4.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2ShadowPanel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2ShadowPanel4.Location = New System.Drawing.Point(584, 171)
        Me.Guna2ShadowPanel4.Name = "Guna2ShadowPanel4"
        Me.Guna2ShadowPanel4.Radius = 10
        Me.Guna2ShadowPanel4.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel4.ShadowDepth = 20
        Me.Guna2ShadowPanel4.Size = New System.Drawing.Size(446, 210)
        Me.Guna2ShadowPanel4.TabIndex = 29
        '
        'lblMonthlySales
        '
        Me.lblMonthlySales.AutoSize = True
        Me.lblMonthlySales.BackColor = System.Drawing.Color.Transparent
        Me.lblMonthlySales.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlySales.ForeColor = System.Drawing.Color.White
        Me.lblMonthlySales.Location = New System.Drawing.Point(64, 73)
        Me.lblMonthlySales.Name = "lblMonthlySales"
        Me.lblMonthlySales.Size = New System.Drawing.Size(165, 86)
        Me.lblMonthlySales.TabIndex = 2
        Me.lblMonthlySales.Text = "0.00"
        Me.lblMonthlySales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(21, 17)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(88, 19)
        Me.Guna2HtmlLabel5.TabIndex = 3
        Me.Guna2HtmlLabel5.Text = "Monthly Sales"
        '
        'Guna2ShadowPanel3
        '
        Me.Guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel3.Controls.Add(Me.lblNoOfItems)
        Me.Guna2ShadowPanel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2ShadowPanel3.FillColor = System.Drawing.Color.LightGray
        Me.Guna2ShadowPanel3.Location = New System.Drawing.Point(798, 395)
        Me.Guna2ShadowPanel3.Name = "Guna2ShadowPanel3"
        Me.Guna2ShadowPanel3.Radius = 10
        Me.Guna2ShadowPanel3.ShadowColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel3.ShadowDepth = 20
        Me.Guna2ShadowPanel3.Size = New System.Drawing.Size(232, 141)
        Me.Guna2ShadowPanel3.TabIndex = 28
        '
        'lblNoOfItems
        '
        Me.lblNoOfItems.AutoSize = True
        Me.lblNoOfItems.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfItems.Font = New System.Drawing.Font("Segoe UI Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfItems.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoOfItems.Location = New System.Drawing.Point(68, 38)
        Me.lblNoOfItems.Name = "lblNoOfItems"
        Me.lblNoOfItems.Size = New System.Drawing.Size(75, 86)
        Me.lblNoOfItems.TabIndex = 2
        Me.lblNoOfItems.Text = "0"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(21, 17)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(78, 19)
        Me.Guna2HtmlLabel4.TabIndex = 3
        Me.Guna2HtmlLabel4.Text = "No. of Items"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImage = Global.POSandInventory.My.Resources.Resources.green_background_for_powerpoint_6
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Shapes4)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1150, 44)
        Me.Guna2Panel1.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(75, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 32)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Dashboard"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.POSandInventory.My.Resources.Resources.finaleLOGO
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, -2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(47, 42)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 45
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2Shapes4
        '
        Me.Guna2Shapes4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes4.BorderColor = System.Drawing.Color.White
        Me.Guna2Shapes4.BorderThickness = 1
        Me.Guna2Shapes4.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Shapes4.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.Guna2Shapes4.LineThickness = 3
        Me.Guna2Shapes4.Location = New System.Drawing.Point(65, -1)
        Me.Guna2Shapes4.Name = "Guna2Shapes4"
        Me.Guna2Shapes4.PolygonSkip = 1
        Me.Guna2Shapes4.Rotate = 0!
        Me.Guna2Shapes4.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.Guna2Shapes4.Size = New System.Drawing.Size(10, 40)
        Me.Guna2Shapes4.TabIndex = 44
        Me.Guna2Shapes4.Text = "Guna2Shapes4"
        Me.Guna2Shapes4.UseTransparentBackground = True
        Me.Guna2Shapes4.Zoom = 80
        '
        'Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dashPanel)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Overview"
        Me.Size = New System.Drawing.Size(1150, 670)
        Me.dashPanel.ResumeLayout(False)
        Me.dashPanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel2.ResumeLayout(False)
        Me.Guna2ShadowPanel2.PerformLayout()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.Guna2ShadowPanel6.ResumeLayout(False)
        Me.Guna2ShadowPanel6.PerformLayout()
        Me.Guna2ShadowPanel5.ResumeLayout(False)
        Me.Guna2ShadowPanel5.PerformLayout()
        Me.Guna2ShadowPanel4.ResumeLayout(False)
        Me.Guna2ShadowPanel4.PerformLayout()
        Me.Guna2ShadowPanel3.ResumeLayout(False)
        Me.Guna2ShadowPanel3.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbldTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Shapes4 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Label2 As Label
    Friend WithEvents dashPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents lblNoOfTodaySales As Label
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents lblTodaySales As Label
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowPanel6 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents lblNoOfUsers As Label
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowPanel5 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents lblNoOfMonthlySales As Label
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowPanel4 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents lblMonthlySales As Label
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ShadowPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents lblNoOfItems As Label
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbldDate As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
End Class
