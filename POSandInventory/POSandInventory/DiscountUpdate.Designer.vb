<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountUpdate
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.tbDiscount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnDUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(240, 25)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Firebrick
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(211, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 25)
        Me.Guna2ControlBox1.TabIndex = 2
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(3, 5)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(50, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Discount"
        '
        'tbDiscount
        '
        Me.tbDiscount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDiscount.DefaultText = ""
        Me.tbDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDiscount.FocusedState.PlaceholderForeColor = System.Drawing.Color.White
        Me.tbDiscount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbDiscount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tbDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDiscount.Location = New System.Drawing.Point(44, 57)
        Me.tbDiscount.Name = "tbDiscount"
        Me.tbDiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDiscount.PlaceholderText = "Enter Discount %"
        Me.tbDiscount.SelectedText = ""
        Me.tbDiscount.Size = New System.Drawing.Size(152, 36)
        Me.tbDiscount.TabIndex = 1
        '
        'btnDUpdate
        '
        Me.btnDUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnDUpdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDUpdate.ForeColor = System.Drawing.Color.White
        Me.btnDUpdate.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnDUpdate.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnDUpdate.Location = New System.Drawing.Point(44, 121)
        Me.btnDUpdate.Name = "btnDUpdate"
        Me.btnDUpdate.Size = New System.Drawing.Size(152, 31)
        Me.btnDUpdate.TabIndex = 2
        Me.btnDUpdate.Text = "Update Discount"
        '
        'DiscountUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(240, 180)
        Me.Controls.Add(Me.btnDUpdate)
        Me.Controls.Add(Me.tbDiscount)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DiscountUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tbDiscount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDUpdate As Guna.UI2.WinForms.Guna2Button
End Class
