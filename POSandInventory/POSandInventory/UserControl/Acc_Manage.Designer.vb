<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Acc_Manage
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
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
        Me.tbEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpBirthdate = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.cbGender = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.tbAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.tbName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbSalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.rbCashier = New Guna.UI.WinForms.GunaRadioButton()
        Me.rbAdmin = New Guna.UI.WinForms.GunaRadioButton()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearTB = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeleteAcc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateAcc = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddAcc = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Panelborder = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DGVPersonalInfo = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Birthdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Access_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Panelborder.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DGVPersonalInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSearch
        '
        Me.tbSearch.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearch.DefaultText = ""
        Me.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tbSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearch.Location = New System.Drawing.Point(63, 73)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearch.PlaceholderText = "Search name"
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.Size = New System.Drawing.Size(419, 31)
        Me.tbSearch.TabIndex = 86
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mtbPhone)
        Me.GroupBox3.Controls.Add(Me.tbEmail)
        Me.GroupBox3.Controls.Add(Me.GunaLabel13)
        Me.GroupBox3.Controls.Add(Me.GunaLabel16)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Location = New System.Drawing.Point(499, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 178)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact Details:"
        '
        'mtbPhone
        '
        Me.mtbPhone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbPhone.Location = New System.Drawing.Point(150, 57)
        Me.mtbPhone.Mask = "(+63)999-999-9999"
        Me.mtbPhone.Name = "mtbPhone"
        Me.mtbPhone.Size = New System.Drawing.Size(245, 25)
        Me.mtbPhone.TabIndex = 90
        '
        'tbEmail
        '
        Me.tbEmail.BorderColor = System.Drawing.SystemColors.ControlText
        Me.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEmail.DefaultText = ""
        Me.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmail.Location = New System.Drawing.Point(150, 97)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbEmail.PlaceholderText = ""
        Me.tbEmail.SelectedText = ""
        Me.tbEmail.Size = New System.Drawing.Size(245, 28)
        Me.tbEmail.TabIndex = 34
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel13.Location = New System.Drawing.Point(31, 97)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(42, 17)
        Me.GunaLabel13.TabIndex = 32
        Me.GunaLabel13.Text = "Email:"
        '
        'GunaLabel16
        '
        Me.GunaLabel16.AutoSize = True
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel16.Location = New System.Drawing.Point(31, 60)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(96, 17)
        Me.GunaLabel16.TabIndex = 0
        Me.GunaLabel16.Text = "Phone number:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dtpBirthdate)
        Me.GroupBox1.Controls.Add(Me.cbGender)
        Me.GroupBox1.Controls.Add(Me.GunaLabel6)
        Me.GroupBox1.Controls.Add(Me.tbAge)
        Me.GroupBox1.Controls.Add(Me.GunaLabel5)
        Me.GroupBox1.Controls.Add(Me.GunaLabel2)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.tbSalary)
        Me.GroupBox1.Controls.Add(Me.GunaLabel20)
        Me.GroupBox1.Controls.Add(Me.GunaLabel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(29, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 178)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.BaseColor = System.Drawing.Color.White
        Me.dtpBirthdate.BorderColor = System.Drawing.SystemColors.ControlText
        Me.dtpBirthdate.BorderSize = 1
        Me.dtpBirthdate.CustomFormat = Nothing
        Me.dtpBirthdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpBirthdate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpBirthdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtpBirthdate.Location = New System.Drawing.Point(129, 94)
        Me.dtpBirthdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpBirthdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpBirthdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpBirthdate.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpBirthdate.OnPressedColor = System.Drawing.Color.Black
        Me.dtpBirthdate.Size = New System.Drawing.Size(294, 30)
        Me.dtpBirthdate.TabIndex = 43
        Me.dtpBirthdate.Text = "Thursday, May 16, 2024"
        Me.dtpBirthdate.Value = New Date(2024, 5, 16, 12, 4, 9, 776)
        '
        'cbGender
        '
        Me.cbGender.BackColor = System.Drawing.Color.Transparent
        Me.cbGender.BaseColor = System.Drawing.Color.White
        Me.cbGender.BorderColor = System.Drawing.SystemColors.ControlText
        Me.cbGender.BorderSize = 1
        Me.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cbGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(330, 62)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbGender.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbGender.Size = New System.Drawing.Size(93, 26)
        Me.cbGender.TabIndex = 35
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel6.Location = New System.Drawing.Point(270, 60)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(54, 17)
        Me.GunaLabel6.TabIndex = 34
        Me.GunaLabel6.Text = "Gender:"
        '
        'tbAge
        '
        Me.tbAge.BorderColor = System.Drawing.SystemColors.ControlText
        Me.tbAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbAge.DefaultText = ""
        Me.tbAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAge.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAge.Location = New System.Drawing.Point(129, 60)
        Me.tbAge.Name = "tbAge"
        Me.tbAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAge.PlaceholderText = ""
        Me.tbAge.SelectedText = ""
        Me.tbAge.Size = New System.Drawing.Size(125, 28)
        Me.tbAge.TabIndex = 33
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel5.Location = New System.Drawing.Point(10, 62)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(34, 17)
        Me.GunaLabel5.TabIndex = 32
        Me.GunaLabel5.Text = "Age:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel2.Location = New System.Drawing.Point(10, 95)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(84, 17)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Date of Birth:"
        '
        'tbName
        '
        Me.tbName.BorderColor = System.Drawing.SystemColors.ControlText
        Me.tbName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbName.DefaultText = ""
        Me.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbName.Location = New System.Drawing.Point(129, 27)
        Me.tbName.Name = "tbName"
        Me.tbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbName.PlaceholderText = ""
        Me.tbName.SelectedText = ""
        Me.tbName.Size = New System.Drawing.Size(294, 28)
        Me.tbName.TabIndex = 1
        '
        'tbSalary
        '
        Me.tbSalary.BorderColor = System.Drawing.SystemColors.ControlText
        Me.tbSalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSalary.DefaultText = ""
        Me.tbSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSalary.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSalary.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSalary.Location = New System.Drawing.Point(129, 130)
        Me.tbSalary.Name = "tbSalary"
        Me.tbSalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSalary.PlaceholderText = ""
        Me.tbSalary.SelectedText = ""
        Me.tbSalary.Size = New System.Drawing.Size(125, 28)
        Me.tbSalary.TabIndex = 42
        '
        'GunaLabel20
        '
        Me.GunaLabel20.AutoSize = True
        Me.GunaLabel20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel20.Location = New System.Drawing.Point(10, 131)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(46, 17)
        Me.GunaLabel20.TabIndex = 41
        Me.GunaLabel20.Text = "Salary:"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaLabel1.Location = New System.Drawing.Point(10, 28)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(46, 17)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Name:"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.BorderSize = 2
        Me.GunaGroupBox1.Controls.Add(Me.rbCashier)
        Me.GunaGroupBox1.Controls.Add(Me.rbAdmin)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(962, 216)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(160, 95)
        Me.GunaGroupBox1.TabIndex = 79
        Me.GunaGroupBox1.Text = "Access Type:"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'rbCashier
        '
        Me.rbCashier.BaseColor = System.Drawing.SystemColors.Control
        Me.rbCashier.CheckedOffColor = System.Drawing.Color.Gray
        Me.rbCashier.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbCashier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbCashier.FillColor = System.Drawing.Color.White
        Me.rbCashier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCashier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbCashier.Location = New System.Drawing.Point(49, 66)
        Me.rbCashier.Name = "rbCashier"
        Me.rbCashier.Size = New System.Drawing.Size(74, 21)
        Me.rbCashier.TabIndex = 2
        Me.rbCashier.Text = "Cashier"
        '
        'rbAdmin
        '
        Me.rbAdmin.BaseColor = System.Drawing.SystemColors.Control
        Me.rbAdmin.Checked = True
        Me.rbAdmin.CheckedOffColor = System.Drawing.Color.Gray
        Me.rbAdmin.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbAdmin.FillColor = System.Drawing.Color.White
        Me.rbAdmin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbAdmin.Location = New System.Drawing.Point(49, 39)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(69, 21)
        Me.rbAdmin.TabIndex = 0
        Me.rbAdmin.Text = "Admin"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Separator1.Location = New System.Drawing.Point(30, 317)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1092, 10)
        Me.Guna2Separator1.TabIndex = 89
        '
        'btnSearch
        '
        Me.btnSearch.Animated = True
        Me.btnSearch.AutoRoundedCorners = True
        Me.btnSearch.BorderRadius = 13
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.Silver
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSearch.Image = Global.POSandInventory.My.Resources.Resources.search1
        Me.btnSearch.Location = New System.Drawing.Point(29, 73)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(28, 30)
        Me.btnSearch.TabIndex = 87
        Me.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnClearTB
        '
        Me.btnClearTB.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearTB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClearTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClearTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClearTB.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnClearTB.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTB.ForeColor = System.Drawing.Color.White
        Me.btnClearTB.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnClearTB.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnClearTB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnClearTB.Location = New System.Drawing.Point(844, 74)
        Me.btnClearTB.Name = "btnClearTB"
        Me.btnClearTB.Size = New System.Drawing.Size(95, 31)
        Me.btnClearTB.TabIndex = 85
        Me.btnClearTB.Text = "Clear"
        '
        'btnDeleteAcc
        '
        Me.btnDeleteAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteAcc.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDeleteAcc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAcc.ForeColor = System.Drawing.Color.White
        Me.btnDeleteAcc.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnDeleteAcc.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteAcc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnDeleteAcc.Location = New System.Drawing.Point(743, 74)
        Me.btnDeleteAcc.Name = "btnDeleteAcc"
        Me.btnDeleteAcc.Size = New System.Drawing.Size(95, 31)
        Me.btnDeleteAcc.TabIndex = 84
        Me.btnDeleteAcc.Text = "Delete"
        '
        'btnUpdateAcc
        '
        Me.btnUpdateAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateAcc.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUpdateAcc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAcc.ForeColor = System.Drawing.Color.White
        Me.btnUpdateAcc.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnUpdateAcc.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateAcc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnUpdateAcc.Location = New System.Drawing.Point(642, 74)
        Me.btnUpdateAcc.Name = "btnUpdateAcc"
        Me.btnUpdateAcc.Size = New System.Drawing.Size(95, 31)
        Me.btnUpdateAcc.TabIndex = 83
        Me.btnUpdateAcc.Text = "Update"
        '
        'btnAddAcc
        '
        Me.btnAddAcc.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddAcc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddAcc.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAddAcc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAcc.ForeColor = System.Drawing.Color.White
        Me.btnAddAcc.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAddAcc.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnAddAcc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAddAcc.Location = New System.Drawing.Point(541, 74)
        Me.btnAddAcc.Name = "btnAddAcc"
        Me.btnAddAcc.Size = New System.Drawing.Size(95, 30)
        Me.btnAddAcc.TabIndex = 82
        Me.btnAddAcc.Text = "Save"
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
        Me.Guna2GradientPanel1.TabIndex = 90
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
        Me.Label1.Size = New System.Drawing.Size(193, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Accounts > Manage User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.FillColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Separator2.Location = New System.Drawing.Point(29, 116)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(910, 19)
        Me.Guna2Separator2.TabIndex = 91
        '
        'Panelborder
        '
        Me.Panelborder.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panelborder.Controls.Add(Me.Label3)
        Me.Panelborder.Location = New System.Drawing.Point(29, 333)
        Me.Panelborder.Name = "Panelborder"
        Me.Panelborder.Size = New System.Drawing.Size(1093, 46)
        Me.Panelborder.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "List of Users"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.DGVPersonalInfo)
        Me.Guna2Panel1.Location = New System.Drawing.Point(30, 385)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1092, 271)
        Me.Guna2Panel1.TabIndex = 93
        '
        'DGVPersonalInfo
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGVPersonalInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPersonalInfo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPersonalInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPersonalInfo.ColumnHeadersHeight = 4
        Me.DGVPersonalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVPersonalInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Employee_Name, Me.Age, Me.Birthdate, Me.Gender, Me.Email, Me.Phone, Me.Access_type, Me.Salary})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPersonalInfo.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVPersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPersonalInfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DGVPersonalInfo.Location = New System.Drawing.Point(0, 0)
        Me.DGVPersonalInfo.Name = "DGVPersonalInfo"
        Me.DGVPersonalInfo.RowHeadersVisible = False
        Me.DGVPersonalInfo.Size = New System.Drawing.Size(1092, 271)
        Me.DGVPersonalInfo.TabIndex = 89
        Me.DGVPersonalInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.DGVPersonalInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVPersonalInfo.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVPersonalInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVPersonalInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVPersonalInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVPersonalInfo.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.DGVPersonalInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DGVPersonalInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.DGVPersonalInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVPersonalInfo.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPersonalInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVPersonalInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVPersonalInfo.ThemeStyle.HeaderStyle.Height = 4
        Me.DGVPersonalInfo.ThemeStyle.ReadOnly = False
        Me.DGVPersonalInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVPersonalInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVPersonalInfo.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVPersonalInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVPersonalInfo.ThemeStyle.RowsStyle.Height = 22
        Me.DGVPersonalInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DGVPersonalInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Width = 20
        '
        'Employee_Name
        '
        Me.Employee_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Employee_Name.HeaderText = "Name"
        Me.Employee_Name.Name = "Employee_Name"
        '
        'Age
        '
        Me.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.Width = 30
        '
        'Birthdate
        '
        Me.Birthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Birthdate.HeaderText = "Birthdate"
        Me.Birthdate.Name = "Birthdate"
        Me.Birthdate.Width = 53
        '
        'Gender
        '
        Me.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.Width = 46
        '
        'Email
        '
        Me.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'Phone
        '
        Me.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Phone.HeaderText = "Phone"
        Me.Phone.Name = "Phone"
        '
        'Access_type
        '
        Me.Access_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Access_type.HeaderText = "Access_type"
        Me.Access_type.Name = "Access_type"
        Me.Access_type.Width = 72
        '
        'Salary
        '
        Me.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Salary.HeaderText = "Salary"
        Me.Salary.Name = "Salary"
        Me.Salary.Width = 40
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(962, 74)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(160, 134)
        Me.Guna2Panel2.TabIndex = 78
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.POSandInventory.My.Resources.Resources.finaleLOGO
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(160, 134)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Acc_Manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panelborder)
        Me.Controls.Add(Me.Guna2Separator2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.btnClearTB)
        Me.Controls.Add(Me.btnDeleteAcc)
        Me.Controls.Add(Me.btnUpdateAcc)
        Me.Controls.Add(Me.btnAddAcc)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Name = "Acc_Manage"
        Me.Size = New System.Drawing.Size(1150, 670)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Panelborder.ResumeLayout(False)
        Me.Panelborder.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.DGVPersonalInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnClearTB As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDeleteAcc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdateAcc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddAcc As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpBirthdate As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents cbGender As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tbAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents tbName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbSalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents rbCashier As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents rbAdmin As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents tbEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents mtbPhone As MaskedTextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Panelborder As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGVPersonalInfo As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Employee_Name As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Birthdate As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents Access_type As DataGridViewTextBoxColumn
    Friend WithEvents Salary As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
