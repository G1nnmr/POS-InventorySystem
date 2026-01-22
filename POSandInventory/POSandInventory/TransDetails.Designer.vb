<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TransDetails
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.DGVDetails = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DGVDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(915, 31)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 6)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(109, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Transaction  Records"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Firebrick
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(886, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(29, 31)
        Me.Guna2ControlBox1.TabIndex = 2
        '
        'DGVDetails
        '
        Me.DGVDetails.AllowUserToAddRows = False
        Me.DGVDetails.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGVDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVDetails.ColumnHeadersHeight = 15
        Me.DGVDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVDetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVDetails.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DGVDetails.Location = New System.Drawing.Point(0, 62)
        Me.DGVDetails.Name = "DGVDetails"
        Me.DGVDetails.ReadOnly = True
        Me.DGVDetails.RowHeadersVisible = False
        Me.DGVDetails.Size = New System.Drawing.Size(915, 296)
        Me.DGVDetails.TabIndex = 2
        Me.DGVDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid
        Me.DGVDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVDetails.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGVDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGVDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGVDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGVDetails.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGVDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DGVDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.DGVDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVDetails.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVDetails.ThemeStyle.HeaderStyle.Height = 15
        Me.DGVDetails.ThemeStyle.ReadOnly = True
        Me.DGVDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGVDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVDetails.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVDetails.ThemeStyle.RowsStyle.Height = 22
        Me.DGVDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DGVDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Guna2GradientPanel1.BackgroundImage = Global.POSandInventory.My.Resources.Resources.green_background_for_powerpoint_6
        Me.Guna2GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 31)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(915, 33)
        Me.Guna2GradientPanel1.TabIndex = 26
        '
        'TransDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 355)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.DGVDetails)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TransDetails"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.DGVDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DGVDetails As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
