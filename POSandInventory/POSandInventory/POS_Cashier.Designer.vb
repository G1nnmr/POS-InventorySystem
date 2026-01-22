<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POS_Cashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POS_Cashier))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BillDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbSN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tbItemcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvPOS = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.extended = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalqtyprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelSide = New System.Windows.Forms.Panel()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel16 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblChange = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDiscount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblVatAmount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTotalPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSubTotal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblItems = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblnumberofItems = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbPmode = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblPaymentmode = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbDiscount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbTenderedamount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblOverallAmount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.PanelLog = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblPOSLogtime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPOSuser = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnPLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNew = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDiscount = New Guna.UI2.WinForms.Guna2Button()
        Me.btnItemVoid = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPay = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PD = New System.Drawing.Printing.PrintDocument()
        Me.PPD = New System.Windows.Forms.PrintPreviewDialog()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.dgvPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSide.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.PanelLog.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2Separator1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SplitContainer1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Guna2Separator2)
        Me.FlowLayoutPanel1.Controls.Add(Me.PanelLog)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPLogout)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNew)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDiscount)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnItemVoid)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPay)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1350, 700)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1331, 30)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1226, 0)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(36, 30)
        Me.Guna2ControlBox3.TabIndex = 7
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Silver
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1262, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(36, 30)
        Me.Guna2ControlBox1.TabIndex = 6
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Firebrick
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1298, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(33, 30)
        Me.Guna2ControlBox2.TabIndex = 5
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(32, 6)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(25, 17)
        Me.Guna2HtmlLabel1.TabIndex = 4
        Me.Guna2HtmlLabel1.Text = "POS"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.POSandInventory.My.Resources.Resources.finaleLOGO
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(23, 21)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.lblDate)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel2.Controls.Add(Me.BillDateTimePicker)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel2.Controls.Add(Me.tbSN)
        Me.Guna2Panel2.Controls.Add(Me.lblTime)
        Me.Guna2Panel2.Controls.Add(Me.tbItemcode)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Location = New System.Drawing.Point(3, 39)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1331, 87)
        Me.Guna2Panel2.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Square721 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1098, 46)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 20)
        Me.lblDate.TabIndex = 24
        Me.lblDate.Text = "date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Location = New System.Drawing.Point(-134, 561)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(210, 40)
        Me.Guna2Panel5.TabIndex = 25
        '
        'BillDateTimePicker
        '
        Me.BillDateTimePicker.Location = New System.Drawing.Point(458, 12)
        Me.BillDateTimePicker.Name = "BillDateTimePicker"
        Me.BillDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BillDateTimePicker.TabIndex = 18
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(390, 12)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(55, 19)
        Me.Guna2HtmlLabel8.TabIndex = 17
        Me.Guna2HtmlLabel8.Text = "Bill Date:"
        Me.Guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbSN
        '
        Me.tbSN.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbSN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSN.DefaultText = ""
        Me.tbSN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbSN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbSN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSN.Location = New System.Drawing.Point(107, 12)
        Me.tbSN.Name = "tbSN"
        Me.tbSN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSN.PlaceholderText = ""
        Me.tbSN.SelectedText = ""
        Me.tbSN.Size = New System.Drawing.Size(252, 28)
        Me.tbSN.TabIndex = 16
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Square721 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblTime.Location = New System.Drawing.Point(1156, 13)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(59, 25)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbItemcode
        '
        Me.tbItemcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbItemcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbItemcode.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbItemcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbItemcode.DefaultText = ""
        Me.tbItemcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbItemcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbItemcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbItemcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbItemcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbItemcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbItemcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbItemcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbItemcode.Location = New System.Drawing.Point(107, 46)
        Me.tbItemcode.Name = "tbItemcode"
        Me.tbItemcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbItemcode.PlaceholderText = ""
        Me.tbItemcode.SelectedText = ""
        Me.tbItemcode.Size = New System.Drawing.Size(551, 28)
        Me.tbItemcode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Serial No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Item #"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.Black
        Me.Guna2Separator1.Location = New System.Drawing.Point(3, 132)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1332, 10)
        Me.Guna2Separator1.TabIndex = 6
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 148)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Guna2Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.panelSide)
        Me.SplitContainer1.Size = New System.Drawing.Size(1329, 475)
        Me.SplitContainer1.SplitterDistance = 995
        Me.SplitContainer1.TabIndex = 7
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.dgvPOS)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel3.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(995, 475)
        Me.Guna2Panel3.TabIndex = 0
        '
        'dgvPOS
        '
        Me.dgvPOS.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvPOS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPOS.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvPOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvPOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPOS.ColumnHeadersHeight = 30
        Me.dgvPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvPOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.itemcode, Me.description, Me.category, Me.price, Me.vat, Me.extended, Me.qty, Me.totalqtyprice})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPOS.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPOS.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvPOS.Location = New System.Drawing.Point(0, 0)
        Me.dgvPOS.Name = "dgvPOS"
        Me.dgvPOS.ReadOnly = True
        Me.dgvPOS.RowHeadersVisible = False
        Me.dgvPOS.Size = New System.Drawing.Size(995, 475)
        Me.dgvPOS.TabIndex = 1
        Me.dgvPOS.TabStop = False
        Me.dgvPOS.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.dgvPOS.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPOS.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPOS.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPOS.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPOS.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPOS.ThemeStyle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvPOS.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvPOS.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvPOS.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgvPOS.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPOS.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPOS.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvPOS.ThemeStyle.HeaderStyle.Height = 30
        Me.dgvPOS.ThemeStyle.ReadOnly = True
        Me.dgvPOS.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPOS.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPOS.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPOS.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPOS.ThemeStyle.RowsStyle.Height = 22
        Me.dgvPOS.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvPOS.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Id
        '
        Me.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Id.HeaderText = "#"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 39
        '
        'itemcode
        '
        Me.itemcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemcode.HeaderText = "Item #"
        Me.itemcode.MinimumWidth = 10
        Me.itemcode.Name = "itemcode"
        Me.itemcode.ReadOnly = True
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        '
        'category
        '
        Me.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 56
        '
        'vat
        '
        Me.vat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.vat.HeaderText = "VAT"
        Me.vat.Name = "vat"
        Me.vat.ReadOnly = True
        Me.vat.Width = 53
        '
        'extended
        '
        Me.extended.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.extended.HeaderText = "Extended"
        Me.extended.Name = "extended"
        Me.extended.ReadOnly = True
        Me.extended.Width = 77
        '
        'qty
        '
        Me.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 48
        '
        'totalqtyprice
        '
        Me.totalqtyprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.totalqtyprice.HeaderText = "Total"
        Me.totalqtyprice.Name = "totalqtyprice"
        Me.totalqtyprice.ReadOnly = True
        Me.totalqtyprice.Width = 56
        '
        'panelSide
        '
        Me.panelSide.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelSide.Controls.Add(Me.lblTotalAmount)
        Me.panelSide.Controls.Add(Me.Guna2HtmlLabel16)
        Me.panelSide.Controls.Add(Me.lblChange)
        Me.panelSide.Controls.Add(Me.lblDiscount)
        Me.panelSide.Controls.Add(Me.lblVatAmount)
        Me.panelSide.Controls.Add(Me.Guna2HtmlLabel12)
        Me.panelSide.Controls.Add(Me.lblTotalPrice)
        Me.panelSide.Controls.Add(Me.lblSubTotal)
        Me.panelSide.Controls.Add(Me.Guna2HtmlLabel9)
        Me.panelSide.Controls.Add(Me.lblItems)
        Me.panelSide.Controls.Add(Me.lblnumberofItems)
        Me.panelSide.Controls.Add(Me.cmbPmode)
        Me.panelSide.Controls.Add(Me.lblPaymentmode)
        Me.panelSide.Controls.Add(Me.tbDiscount)
        Me.panelSide.Controls.Add(Me.Guna2HtmlLabel6)
        Me.panelSide.Controls.Add(Me.tbTenderedamount)
        Me.panelSide.Controls.Add(Me.Guna2HtmlLabel5)
        Me.panelSide.Controls.Add(Me.Guna2HtmlLabel4)
        Me.panelSide.Controls.Add(Me.Guna2HtmlLabel3)
        Me.panelSide.Controls.Add(Me.Guna2Panel4)
        Me.panelSide.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelSide.Location = New System.Drawing.Point(0, 0)
        Me.panelSide.Name = "panelSide"
        Me.panelSide.Size = New System.Drawing.Size(330, 475)
        Me.panelSide.TabIndex = 0
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(251, 275)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(50, 25)
        Me.lblTotalAmount.TabIndex = 27
        Me.lblTotalAmount.Text = "0.00"
        '
        'Guna2HtmlLabel16
        '
        Me.Guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel16.Location = New System.Drawing.Point(17, 275)
        Me.Guna2HtmlLabel16.Name = "Guna2HtmlLabel16"
        Me.Guna2HtmlLabel16.Size = New System.Drawing.Size(87, 19)
        Me.Guna2HtmlLabel16.TabIndex = 26
        Me.Guna2HtmlLabel16.Text = "Total Amount"
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.Transparent
        Me.lblChange.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(258, 430)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(41, 27)
        Me.lblChange.TabIndex = 25
        Me.lblChange.Text = "0.00"
        Me.lblChange.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(268, 236)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(33, 23)
        Me.lblDiscount.TabIndex = 24
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVatAmount
        '
        Me.lblVatAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblVatAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatAmount.Location = New System.Drawing.Point(268, 191)
        Me.lblVatAmount.Name = "lblVatAmount"
        Me.lblVatAmount.Size = New System.Drawing.Size(33, 23)
        Me.lblVatAmount.TabIndex = 23
        Me.lblVatAmount.Text = "0.00"
        Me.lblVatAmount.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(17, 197)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(111, 19)
        Me.Guna2HtmlLabel12.TabIndex = 22
        Me.Guna2HtmlLabel12.Text = "VATABLE Amount"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(268, 162)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(33, 23)
        Me.lblTotalPrice.TabIndex = 21
        Me.lblTotalPrice.Text = "0.00"
        Me.lblTotalPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(268, 131)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(33, 23)
        Me.lblSubTotal.TabIndex = 20
        Me.lblSubTotal.Text = "0.00"
        Me.lblSubTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(17, 135)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(60, 19)
        Me.Guna2HtmlLabel9.TabIndex = 19
        Me.Guna2HtmlLabel9.Text = "Sub Total"
        '
        'lblItems
        '
        Me.lblItems.BackColor = System.Drawing.Color.Transparent
        Me.lblItems.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(287, 104)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(12, 23)
        Me.lblItems.TabIndex = 17
        Me.lblItems.Text = "0"
        Me.lblItems.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblnumberofItems
        '
        Me.lblnumberofItems.BackColor = System.Drawing.Color.Transparent
        Me.lblnumberofItems.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumberofItems.Location = New System.Drawing.Point(17, 104)
        Me.lblnumberofItems.Name = "lblnumberofItems"
        Me.lblnumberofItems.Size = New System.Drawing.Size(78, 19)
        Me.lblnumberofItems.TabIndex = 16
        Me.lblnumberofItems.Text = "No. of Items"
        '
        'cmbPmode
        '
        Me.cmbPmode.BackColor = System.Drawing.Color.Transparent
        Me.cmbPmode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPmode.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbPmode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbPmode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPmode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbPmode.ItemHeight = 30
        Me.cmbPmode.Items.AddRange(New Object() {"Cash", "Credit Card", "Debit Card", "GCash"})
        Me.cmbPmode.Location = New System.Drawing.Point(141, 318)
        Me.cmbPmode.Name = "cmbPmode"
        Me.cmbPmode.Size = New System.Drawing.Size(176, 36)
        Me.cmbPmode.TabIndex = 15
        '
        'lblPaymentmode
        '
        Me.lblPaymentmode.BackColor = System.Drawing.Color.Transparent
        Me.lblPaymentmode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentmode.Location = New System.Drawing.Point(17, 327)
        Me.lblPaymentmode.Name = "lblPaymentmode"
        Me.lblPaymentmode.Size = New System.Drawing.Size(96, 19)
        Me.lblPaymentmode.TabIndex = 14
        Me.lblPaymentmode.Text = "Payment Mode"
        '
        'tbDiscount
        '
        Me.tbDiscount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDiscount.BorderColor = System.Drawing.Color.Silver
        Me.tbDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDiscount.DefaultText = ""
        Me.tbDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDiscount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDiscount.Location = New System.Drawing.Point(141, 236)
        Me.tbDiscount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbDiscount.Name = "tbDiscount"
        Me.tbDiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDiscount.PlaceholderText = ""
        Me.tbDiscount.SelectedText = ""
        Me.tbDiscount.Size = New System.Drawing.Size(37, 33)
        Me.tbDiscount.TabIndex = 13
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(19, 236)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(79, 19)
        Me.Guna2HtmlLabel6.TabIndex = 12
        Me.Guna2HtmlLabel6.Text = "Discount (%)"
        '
        'tbTenderedamount
        '
        Me.tbTenderedamount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTenderedamount.BorderColor = System.Drawing.Color.Silver
        Me.tbTenderedamount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTenderedamount.DefaultText = ""
        Me.tbTenderedamount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbTenderedamount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbTenderedamount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTenderedamount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbTenderedamount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTenderedamount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTenderedamount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbTenderedamount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbTenderedamount.Location = New System.Drawing.Point(141, 375)
        Me.tbTenderedamount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbTenderedamount.Name = "tbTenderedamount"
        Me.tbTenderedamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTenderedamount.PlaceholderText = ""
        Me.tbTenderedamount.SelectedText = ""
        Me.tbTenderedamount.Size = New System.Drawing.Size(176, 36)
        Me.tbTenderedamount.TabIndex = 10
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(17, 430)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(49, 19)
        Me.Guna2HtmlLabel5.TabIndex = 8
        Me.Guna2HtmlLabel5.Text = "Change"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(17, 375)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(114, 19)
        Me.Guna2HtmlLabel4.TabIndex = 7
        Me.Guna2HtmlLabel4.Text = "Tendered Amount"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(17, 166)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(66, 19)
        Me.Guna2HtmlLabel3.TabIndex = 5
        Me.Guna2HtmlLabel3.Text = "Total Price"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Guna2Panel4.Controls.Add(Me.lblOverallAmount)
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(330, 84)
        Me.Guna2Panel4.TabIndex = 0
        '
        'lblOverallAmount
        '
        Me.lblOverallAmount.AutoSize = False
        Me.lblOverallAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblOverallAmount.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverallAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.lblOverallAmount.Location = New System.Drawing.Point(80, 15)
        Me.lblOverallAmount.Name = "lblOverallAmount"
        Me.lblOverallAmount.Size = New System.Drawing.Size(219, 55)
        Me.lblOverallAmount.TabIndex = 1
        Me.lblOverallAmount.Text = "0.00"
        Me.lblOverallAmount.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Separator2.FillColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2Separator2.Location = New System.Drawing.Point(3, 629)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(1327, 10)
        Me.Guna2Separator2.TabIndex = 8
        '
        'PanelLog
        '
        Me.PanelLog.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.PanelLog.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.PanelLog.Controls.Add(Me.lblPOSLogtime)
        Me.PanelLog.Controls.Add(Me.Label4)
        Me.PanelLog.Controls.Add(Me.lblPOSuser)
        Me.PanelLog.Controls.Add(Me.Label3)
        Me.PanelLog.Controls.Add(Me.Guna2PictureBox2)
        Me.PanelLog.Location = New System.Drawing.Point(3, 645)
        Me.PanelLog.Name = "PanelLog"
        Me.PanelLog.Size = New System.Drawing.Size(249, 43)
        Me.PanelLog.TabIndex = 25
        '
        'lblPOSLogtime
        '
        Me.lblPOSLogtime.AutoSize = True
        Me.lblPOSLogtime.BackColor = System.Drawing.Color.Transparent
        Me.lblPOSLogtime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOSLogtime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPOSLogtime.Location = New System.Drawing.Point(146, 24)
        Me.lblPOSLogtime.Name = "lblPOSLogtime"
        Me.lblPOSLogtime.Size = New System.Drawing.Size(50, 13)
        Me.lblPOSLogtime.TabIndex = 25
        Me.lblPOSLogtime.Text = "LogTime"
        Me.lblPOSLogtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(70, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Time in:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPOSuser
        '
        Me.lblPOSuser.AutoSize = True
        Me.lblPOSuser.BackColor = System.Drawing.Color.Transparent
        Me.lblPOSuser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOSuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPOSuser.Location = New System.Drawing.Point(146, 7)
        Me.lblPOSuser.Name = "lblPOSuser"
        Me.lblPOSuser.Size = New System.Drawing.Size(58, 13)
        Me.lblPOSuser.TabIndex = 23
        Me.lblPOSuser.Text = "Username"
        Me.lblPOSuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(69, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cashier:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.IndianRed
        Me.Guna2PictureBox2.Image = Global.POSandInventory.My.Resources.Resources.finaleLOGO
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(8, 3)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 26
        Me.Guna2PictureBox2.TabStop = False
        '
        'btnPLogout
        '
        Me.btnPLogout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnPLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPLogout.ForeColor = System.Drawing.Color.White
        Me.btnPLogout.HoverState.FillColor = System.Drawing.Color.Firebrick
        Me.btnPLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnPLogout.Location = New System.Drawing.Point(258, 645)
        Me.btnPLogout.Name = "btnPLogout"
        Me.btnPLogout.Size = New System.Drawing.Size(180, 43)
        Me.btnPLogout.TabIndex = 0
        Me.btnPLogout.Text = "[ESC] Logout"
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNew.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnNew.Location = New System.Drawing.Point(444, 645)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(180, 43)
        Me.btnNew.TabIndex = 19
        Me.btnNew.Text = "[F1] New"
        '
        'btnDiscount
        '
        Me.btnDiscount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDiscount.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDiscount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscount.ForeColor = System.Drawing.Color.White
        Me.btnDiscount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnDiscount.Location = New System.Drawing.Point(630, 645)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(180, 43)
        Me.btnDiscount.TabIndex = 20
        Me.btnDiscount.Text = "[F2] Discount"
        '
        'btnItemVoid
        '
        Me.btnItemVoid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnItemVoid.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnItemVoid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnItemVoid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnItemVoid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnItemVoid.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnItemVoid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemVoid.ForeColor = System.Drawing.Color.White
        Me.btnItemVoid.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnItemVoid.Location = New System.Drawing.Point(816, 645)
        Me.btnItemVoid.Name = "btnItemVoid"
        Me.btnItemVoid.Size = New System.Drawing.Size(180, 43)
        Me.btnItemVoid.TabIndex = 22
        Me.btnItemVoid.Text = "[F3] Item Void"
        '
        'btnPay
        '
        Me.btnPay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPay.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPay.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPay.Font = New System.Drawing.Font("Swis721 BT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.HoverState.FillColor = System.Drawing.Color.ForestGreen
        Me.btnPay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnPay.Location = New System.Drawing.Point(1002, 645)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(327, 43)
        Me.btnPay.TabIndex = 24
        Me.btnPay.Text = "PAY"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'PD
        '
        '
        'PPD
        '
        Me.PPD.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PPD.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PPD.ClientSize = New System.Drawing.Size(400, 300)
        Me.PPD.Enabled = True
        Me.PPD.Icon = CType(resources.GetObject("PPD.Icon"), System.Drawing.Icon)
        Me.PPD.Name = "PPD"
        Me.PPD.Visible = False
        '
        'POS_Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 700)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "POS_Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.dgvPOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSide.ResumeLayout(False)
        Me.panelSide.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.PanelLog.ResumeLayout(False)
        Me.PanelLog.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbItemcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents panelSide As Panel
    Friend WithEvents dgvPOS As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnPLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbTenderedamount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDiscount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbDiscount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnItemVoid As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblOverallAmount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbPmode As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblPaymentmode As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblItems As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblnumberofItems As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbSN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BillDateTimePicker As DateTimePicker
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDate As Label
    Friend WithEvents lblSubTotal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel16 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblChange As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDiscount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblVatAmount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTotalPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelLog As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPOSLogtime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPOSuser As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents PrntDoc As Printing.PrintDocument
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents itemcode As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents vat As DataGridViewTextBoxColumn
    Friend WithEvents extended As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents totalqtyprice As DataGridViewTextBoxColumn
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PD As Printing.PrintDocument
    Friend WithEvents PPD As PrintPreviewDialog
End Class
