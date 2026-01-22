<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prod_Manage
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
        Me.tbPSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnPClear = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPSave = New Guna.UI2.WinForms.Guna2Button()
        Me.tbNewCategory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAddCategory = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbItemcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbStocks = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbVAT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbExtended = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCategoryName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnDeleteCategory = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPSearch
        '
        Me.tbPSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbPSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbPSearch.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbPSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPSearch.DefaultText = ""
        Me.tbPSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tbPSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPSearch.Location = New System.Drawing.Point(321, 86)
        Me.tbPSearch.Name = "tbPSearch"
        Me.tbPSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPSearch.PlaceholderText = "Item code"
        Me.tbPSearch.SelectedText = ""
        Me.tbPSearch.Size = New System.Drawing.Size(628, 31)
        Me.tbPSearch.TabIndex = 2
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Separator1.FillColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Separator1.Location = New System.Drawing.Point(204, 166)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(741, 20)
        Me.Guna2Separator1.TabIndex = 27
        '
        'btnPClear
        '
        Me.btnPClear.Animated = True
        Me.btnPClear.BorderColor = System.Drawing.Color.Transparent
        Me.btnPClear.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnPClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPClear.FocusedColor = System.Drawing.Color.White
        Me.btnPClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPClear.ForeColor = System.Drawing.Color.White
        Me.btnPClear.HoverState.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPClear.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPClear.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPClear.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnPClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnPClear.Location = New System.Drawing.Point(204, 574)
        Me.btnPClear.Name = "btnPClear"
        Me.btnPClear.Size = New System.Drawing.Size(180, 40)
        Me.btnPClear.TabIndex = 12
        Me.btnPClear.Text = "Clear"
        '
        'btnPDelete
        '
        Me.btnPDelete.BorderColor = System.Drawing.Color.Transparent
        Me.btnPDelete.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnPDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPDelete.FocusedColor = System.Drawing.Color.White
        Me.btnPDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPDelete.ForeColor = System.Drawing.Color.White
        Me.btnPDelete.HoverState.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPDelete.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPDelete.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnPDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnPDelete.Location = New System.Drawing.Point(393, 574)
        Me.btnPDelete.Name = "btnPDelete"
        Me.btnPDelete.PressedColor = System.Drawing.Color.DarkRed
        Me.btnPDelete.Size = New System.Drawing.Size(180, 40)
        Me.btnPDelete.TabIndex = 11
        Me.btnPDelete.Text = "Delete"
        '
        'btnPSearch
        '
        Me.btnPSearch.Animated = True
        Me.btnPSearch.AutoRoundedCorners = True
        Me.btnPSearch.BorderRadius = 14
        Me.btnPSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPSearch.ForeColor = System.Drawing.Color.White
        Me.btnPSearch.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPSearch.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnPSearch.Image = Global.POSandInventory.My.Resources.Resources.search1
        Me.btnPSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnPSearch.Location = New System.Drawing.Point(204, 86)
        Me.btnPSearch.Name = "btnPSearch"
        Me.btnPSearch.Size = New System.Drawing.Size(111, 31)
        Me.btnPSearch.TabIndex = 20
        Me.btnPSearch.Text = "Search"
        Me.btnPSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Guna2GradientPanel1.TabIndex = 24
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
        Me.Label1.Size = New System.Drawing.Size(174, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Items > Manage Items"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPSave
        '
        Me.btnPSave.BorderColor = System.Drawing.Color.Transparent
        Me.btnPSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPSave.FocusedColor = System.Drawing.Color.White
        Me.btnPSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPSave.ForeColor = System.Drawing.Color.White
        Me.btnPSave.HoverState.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPSave.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPSave.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnPSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnPSave.Location = New System.Drawing.Point(765, 574)
        Me.btnPSave.Name = "btnPSave"
        Me.btnPSave.Size = New System.Drawing.Size(180, 40)
        Me.btnPSave.TabIndex = 9
        Me.btnPSave.Text = "Add"
        '
        'tbNewCategory
        '
        Me.tbNewCategory.BackColor = System.Drawing.Color.Transparent
        Me.tbNewCategory.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbNewCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbNewCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbNewCategory.DefaultText = ""
        Me.tbNewCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbNewCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbNewCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNewCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbNewCategory.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbNewCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNewCategory.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewCategory.ForeColor = System.Drawing.SystemColors.InfoText
        Me.tbNewCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbNewCategory.Location = New System.Drawing.Point(204, 373)
        Me.tbNewCategory.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbNewCategory.Name = "tbNewCategory"
        Me.tbNewCategory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNewCategory.PlaceholderText = "Add new category"
        Me.tbNewCategory.SelectedText = ""
        Me.tbNewCategory.Size = New System.Drawing.Size(307, 38)
        Me.tbNewCategory.TabIndex = 61
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Animated = True
        Me.btnAddCategory.BorderColor = System.Drawing.Color.Transparent
        Me.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddCategory.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnAddCategory.FocusedColor = System.Drawing.Color.White
        Me.btnAddCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCategory.ForeColor = System.Drawing.Color.White
        Me.btnAddCategory.HoverState.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAddCategory.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAddCategory.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnAddCategory.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnAddCategory.Location = New System.Drawing.Point(518, 373)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(36, 38)
        Me.btnAddCategory.TabIndex = 60
        Me.btnAddCategory.Text = "+"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Transparent
        Me.cmbCategory.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbCategory.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Location = New System.Drawing.Point(204, 455)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(308, 36)
        Me.cmbCategory.TabIndex = 59
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(204, 430)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(58, 19)
        Me.Guna2HtmlLabel4.TabIndex = 58
        Me.Guna2HtmlLabel4.Text = "Category"
        '
        'tbDescription
        '
        Me.tbDescription.BackColor = System.Drawing.Color.Transparent
        Me.tbDescription.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDescription.DefaultText = ""
        Me.tbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDescription.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDescription.ForeColor = System.Drawing.SystemColors.InfoText
        Me.tbDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDescription.Location = New System.Drawing.Point(204, 297)
        Me.tbDescription.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDescription.PlaceholderText = ""
        Me.tbDescription.SelectedText = ""
        Me.tbDescription.Size = New System.Drawing.Size(350, 38)
        Me.tbDescription.TabIndex = 57
        '
        'tbPrice
        '
        Me.tbPrice.BackColor = System.Drawing.Color.Transparent
        Me.tbPrice.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPrice.DefaultText = ""
        Me.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPrice.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPrice.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrice.ForeColor = System.Drawing.SystemColors.InfoText
        Me.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPrice.Location = New System.Drawing.Point(602, 217)
        Me.tbPrice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPrice.PlaceholderText = ""
        Me.tbPrice.SelectedText = ""
        Me.tbPrice.Size = New System.Drawing.Size(343, 38)
        Me.tbPrice.TabIndex = 50
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(601, 192)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(32, 19)
        Me.Guna2HtmlLabel5.TabIndex = 53
        Me.Guna2HtmlLabel5.Text = "Price"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(204, 272)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(71, 19)
        Me.Guna2HtmlLabel1.TabIndex = 56
        Me.Guna2HtmlLabel1.Text = "Description"
        '
        'tbItemcode
        '
        Me.tbItemcode.BackColor = System.Drawing.Color.Transparent
        Me.tbItemcode.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbItemcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbItemcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbItemcode.DefaultText = ""
        Me.tbItemcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbItemcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbItemcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbItemcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbItemcode.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbItemcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbItemcode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbItemcode.ForeColor = System.Drawing.SystemColors.InfoText
        Me.tbItemcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbItemcode.Location = New System.Drawing.Point(204, 217)
        Me.tbItemcode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbItemcode.Name = "tbItemcode"
        Me.tbItemcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbItemcode.PlaceholderText = ""
        Me.tbItemcode.SelectedText = ""
        Me.tbItemcode.Size = New System.Drawing.Size(350, 38)
        Me.tbItemcode.TabIndex = 48
        '
        'tbStocks
        '
        Me.tbStocks.BackColor = System.Drawing.Color.Transparent
        Me.tbStocks.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbStocks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbStocks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbStocks.DefaultText = ""
        Me.tbStocks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbStocks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbStocks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbStocks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbStocks.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbStocks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbStocks.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStocks.ForeColor = System.Drawing.SystemColors.InfoText
        Me.tbStocks.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbStocks.Location = New System.Drawing.Point(602, 455)
        Me.tbStocks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbStocks.Name = "tbStocks"
        Me.tbStocks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbStocks.PlaceholderText = ""
        Me.tbStocks.SelectedText = ""
        Me.tbStocks.Size = New System.Drawing.Size(343, 38)
        Me.tbStocks.TabIndex = 55
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(204, 192)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(43, 19)
        Me.Guna2HtmlLabel2.TabIndex = 51
        Me.Guna2HtmlLabel2.Text = "Item #"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(602, 430)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(42, 19)
        Me.Guna2HtmlLabel6.TabIndex = 54
        Me.Guna2HtmlLabel6.Text = "Stocks"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(601, 348)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(91, 19)
        Me.Guna2HtmlLabel8.TabIndex = 64
        Me.Guna2HtmlLabel8.Text = "Purchase Price"
        '
        'tbVAT
        '
        Me.tbVAT.BackColor = System.Drawing.Color.Transparent
        Me.tbVAT.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbVAT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbVAT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbVAT.DefaultText = ""
        Me.tbVAT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbVAT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbVAT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbVAT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbVAT.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbVAT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbVAT.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbVAT.ForeColor = System.Drawing.SystemColors.InfoText
        Me.tbVAT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbVAT.Location = New System.Drawing.Point(602, 297)
        Me.tbVAT.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbVAT.Name = "tbVAT"
        Me.tbVAT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbVAT.PlaceholderText = ""
        Me.tbVAT.SelectedText = ""
        Me.tbVAT.Size = New System.Drawing.Size(343, 38)
        Me.tbVAT.TabIndex = 65
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(602, 272)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(62, 19)
        Me.Guna2HtmlLabel9.TabIndex = 66
        Me.Guna2HtmlLabel9.Text = "VAT (12%)"
        '
        'tbExtended
        '
        Me.tbExtended.BackColor = System.Drawing.Color.Transparent
        Me.tbExtended.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.tbExtended.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbExtended.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbExtended.DefaultText = ""
        Me.tbExtended.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbExtended.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbExtended.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbExtended.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbExtended.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbExtended.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbExtended.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbExtended.ForeColor = System.Drawing.SystemColors.InfoText
        Me.tbExtended.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbExtended.Location = New System.Drawing.Point(602, 373)
        Me.tbExtended.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbExtended.Name = "tbExtended"
        Me.tbExtended.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbExtended.PlaceholderText = ""
        Me.tbExtended.SelectedText = ""
        Me.tbExtended.Size = New System.Drawing.Size(343, 38)
        Me.tbExtended.TabIndex = 67
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnUpdate
        '
        Me.btnUpdate.Animated = True
        Me.btnUpdate.BorderColor = System.Drawing.Color.Transparent
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnUpdate.FocusedColor = System.Drawing.Color.White
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.btnUpdate.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnUpdate.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnUpdate.Location = New System.Drawing.Point(579, 574)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(180, 40)
        Me.btnUpdate.TabIndex = 88
        Me.btnUpdate.Text = "Update"
        '
        'lblCategoryName
        '
        Me.lblCategoryName.BackColor = System.Drawing.Color.Transparent
        Me.lblCategoryName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoryName.ForeColor = System.Drawing.Color.Black
        Me.lblCategoryName.Location = New System.Drawing.Point(204, 348)
        Me.lblCategoryName.Name = "lblCategoryName"
        Me.lblCategoryName.Size = New System.Drawing.Size(98, 19)
        Me.lblCategoryName.TabIndex = 62
        Me.lblCategoryName.Text = "Category Name"
        '
        'btnDeleteCategory
        '
        Me.btnDeleteCategory.Animated = True
        Me.btnDeleteCategory.BorderColor = System.Drawing.Color.Transparent
        Me.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteCategory.FillColor = System.Drawing.Color.Gray
        Me.btnDeleteCategory.FocusedColor = System.Drawing.Color.White
        Me.btnDeleteCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteCategory.ForeColor = System.Drawing.Color.White
        Me.btnDeleteCategory.HoverState.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.btnDeleteCategory.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnDeleteCategory.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteCategory.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnDeleteCategory.Location = New System.Drawing.Point(518, 455)
        Me.btnDeleteCategory.Name = "btnDeleteCategory"
        Me.btnDeleteCategory.Size = New System.Drawing.Size(36, 38)
        Me.btnDeleteCategory.TabIndex = 89
        Me.btnDeleteCategory.Text = "-"
        '
        'Prod_Manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.btnDeleteCategory)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.tbExtended)
        Me.Controls.Add(Me.tbVAT)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.lblCategoryName)
        Me.Controls.Add(Me.tbNewCategory)
        Me.Controls.Add(Me.btnAddCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.tbItemcode)
        Me.Controls.Add(Me.tbStocks)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.btnPClear)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.btnPDelete)
        Me.Controls.Add(Me.tbPSearch)
        Me.Controls.Add(Me.btnPSearch)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.btnPSave)
        Me.Name = "Prod_Manage"
        Me.Size = New System.Drawing.Size(1150, 670)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbPSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnPSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents tbNewCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddCategory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbItemcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbStocks As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbVAT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbExtended As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCategoryName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDeleteCategory As Guna.UI2.WinForms.Guna2Button
End Class
