Imports System.Drawing.Printing
Imports DomainLayer
Imports InsfrastructureLayer
Imports MySql.Data.MySqlClient
Imports ServiceLayer

Public Class POS_Cashier

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TotalItems()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblDate.Text = Date.Now.ToString("dddd, MMMM dd, yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub POS_Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Timer2.Interval = 1000
            Timer2.Start()

            tbDiscount.Text = "0"
            dgvPOS.RowTemplate.Height = 30
            tbItemcode.Focus()
            TotalItems()
            'load_discount()
            Suggest()
            btnPay.Enabled = False
            tbSN.Text = Guid.NewGuid().ToString()


            AddHandler tbItemcode.KeyDown, AddressOf tbItemcode_KeyDown
            Connect()

            Me.KeyPreview = True
            lblPOSuser.Text = Login.Username
            lblPOSLogtime.Text = Date.Now.ToString("hh:mm:ss tt")

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical, "Load Error")
        End Try
    End Sub

    Public Sub Suggest()
        Connect()
        query = "SELECT `Item_code` FROM `tbl_product`"

        With command
            .Connection = conn
            .CommandText = query
            read = .ExecuteReader()
        End With

        tbItemcode.AutoCompleteCustomSource.Clear()

        While read.Read
            tbItemcode.AutoCompleteCustomSource.Add(read(0))
        End While
    End Sub

    Private Sub tbItemcode_KeyDown(sender As Object, e As KeyEventArgs)
        If tbItemcode.Text = Nothing Then
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                PurchasedList()

                tbItemcode.Clear()
                tbItemcode.Focus()

            End If
        End If
    End Sub

    Public Sub PurchasedList()
        Dim numx As Integer = 0, numy As Integer
        Dim checker As Boolean = False

        For Each item As DataGridViewRow In dgvPOS.Rows
            If item.Cells(0).Value IsNot Nothing Then
                If item.Cells(1).Value.ToString = tbItemcode.Text Then
                    checker = True
                    numx = item.Index
                    numy = CInt(item.Cells(7).Value)
                    Exit For
                End If
            End If
        Next
        If checker = False Then
            Try
                Connect()
                query = "SELECT * FROM tbl_product WHERE `Item_code`= '" & tbItemcode.Text & "'"

                With command
                    .Connection = conn
                    .CommandText = query
                    read = .ExecuteReader()
                End With

                While read.Read
                    If tbItemcode.Text = String.Empty Then
                        Return
                    Else

                        Dim Icode As String = read.Item("Item_code")
                        Dim description As String = read.Item("Description")
                        Dim category As String = read.Item("Category")
                        Dim price As Decimal = read.Item("Price")
                        Dim VAT As Decimal = read("VAT")
                        Dim extended As Decimal = read("Extended")

                        Dim tqp As Double
                        tqp = price * VAT / 100 + price

                        Dim formattedTQP As String = tqp.ToString("0.00")

                        dgvPOS.Rows.Add(dgvPOS.Rows.Count + 1, Icode, description, category,
                                        price, VAT, extended, 1, formattedTQP)

                    End If
                End While
            Catch ex As Exception

            Finally
                conn.Close()
            End Try
        Else
            Dim qty As Integer = CInt(dgvPOS.Rows(numx).Cells(7).Value) + 1
            dgvPOS.Rows(numx).Cells(7).Value = qty

            Dim price As Decimal = CDec(dgvPOS.Rows(numx).Cells(4).Value)
            Dim VAT As Decimal = CDec(dgvPOS.Rows(numx).Cells(5).Value)

            'Calculation for the total price on every qty purchased as well as for VAT+price
            Dim tqp As Decimal = Decimal.Round((qty * price) * (1 + (VAT / 100)), 2)

            'Convert totalqtyprice to 2 decimal places
            Dim formattedTQP As String = tqp.ToString("0.00")

            'Calculated total amount value of price and qty
            dgvPOS.Rows(numx).Cells(8).Value = formattedTQP

        End If
    End Sub

    Public Sub TotalItems()

        lblItems.Text = dgvPOS.Rows.Count - 1 + 1

        Dim total As Double = 0
        Dim subtotal As Double = 0
        Dim VAT As Double = 0

        For x As Integer = 0 To dgvPOS.Rows.Count() - 1 Step +1

            'total
            total = total + dgvPOS.Rows(x).Cells(8).Value

            'Price * VAT / 100 * qty
            VAT = VAT + dgvPOS.Rows(x).Cells(4).Value * dgvPOS.Rows(x).Cells(5).Value / 100 * dgvPOS.Rows(x).Cells(7).Value

            'price * qty  
            subtotal = subtotal + dgvPOS.Rows(x).Cells(4).Value * dgvPOS.Rows(x).Cells(7).Value
        Next
        Try

            lblSubTotal.Text = Format(CDec(subtotal), "#,##0.00")
            lblVatAmount.Text = Format(CDec(VAT), "#,##0.00")
            lblTotalPrice.Text = Format(CDec(subtotal + VAT), "#,##0.00")
            lblDiscount.Text = Format(CDec(tbDiscount.Text) * CDec(lblTotalPrice.Text) / 100, "#,##0.00")
            lblTotalAmount.Text = Format(CDec(lblTotalPrice.Text) - CDec(lblDiscount.Text), "#,##0.00")
            lblOverallAmount.Text = Format(CDec(lblTotalAmount.Text), "#,##0.00")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub load_discount()
        Try
            Connect()
            query = "Select * FROM `tbl_discount`"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()

                While read.Read()
                    tbDiscount.Text = read.Item("discount")
                End While
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub DiscountUpdate_DiscountUpdated(sender As Object, discount As String)
        tbDiscount.Text = discount
    End Sub

    Private Sub tbTenderedamount_TextChanged(sender As Object, e As EventArgs) Handles tbTenderedamount.TextChanged
        If Not String.IsNullOrWhiteSpace(tbTenderedamount.Text) AndAlso Not String.IsNullOrWhiteSpace(lblTotalAmount.Text) Then
            Dim tenderedAmount As Decimal
            Dim TotalAmount As Decimal
            'Dim totalAmountText As String = lblTotalAmount.Text.Replace("₱", "")

            If Decimal.TryParse(tbTenderedamount.Text, tenderedAmount) AndAlso Decimal.TryParse(lblTotalAmount.Text, TotalAmount) Then
                'lblChange.Text = Format(CDec(tenderedAmount - TotalAmount), "#,##0.00")
                lblChange.Text = Format(tenderedAmount - TotalAmount, "#,##0.00")
                btnPay.Enabled = True
            Else
                MsgBox("Invalid input fields!", MsgBoxStyle.Exclamation, "Invalid")
            End If
        Else
            btnPay.Enabled = True
        End If
    End Sub

    'SHORT-CUT Button Keydowns
    Private Sub POS_Cashier_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            btnPLogout_Click(sender, e)
        ElseIf (e.KeyCode = Keys.F1) Then
            btnNew_Click(sender, e)
        ElseIf (e.KeyCode = Keys.F2) Then
            btnDiscount_Click(sender, e)
        ElseIf (e.KeyCode = Keys.F3) Then
            btnItemVoid_Click(sender, e)
        End If
    End Sub

    'Buttons
    'ESC
    Private Sub btnPLogout_Click(sender As Object, e As EventArgs) Handles btnPLogout.Click
        Dim msgLog As Integer
        msgLog = MessageBox.Show("Are you sure you want to log out?", "Log out confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgLog = vbYes Then

            For Each form As Form In Application.OpenForms
                If TypeOf form Is Login Then
                    Continue For
                End If
                form.Hide()
            Next
            Dim login As New Login()
            login.Show()
        End If
    End Sub
    'F1
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearData()
        tbSN.Text = Guid.NewGuid().ToString()

    End Sub
    'F2
    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        Try
            Dim discountRepository As IDiscountRepository = New DiscountRepository()
            Dim DiscountUpdate As New DiscountUpdate(discountRepository)
            AddHandler DiscountUpdate.DiscountUpdated, AddressOf DiscountUpdate_DiscountUpdated
            DiscountUpdate.ShowDialog()
        Catch ex As Exception
            MsgBox("Error:" & ex.Message, MsgBoxStyle.Critical, "Set Discount")
        End Try
    End Sub
    'F3
    Private Sub btnItemVoid_Click(sender As Object, e As EventArgs) Handles btnItemVoid.Click
        If dgvPOS.SelectedRows.Count > 0 Then
            For i As Integer = dgvPOS.SelectedRows.Count - 1 To 0 Step -1
                If dgvPOS.Rows(dgvPOS.SelectedRows(i).Index).IsNewRow Then
                    ' Don't delete the new row
                    Continue For
                End If

                dgvPOS.Rows.Remove(dgvPOS.SelectedRows(i))
            Next
        Else
            'MsgBox("Please select a item row to remove.", vbInformation)
        End If

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Transact_SN()
        PPD.Document = PD
        PPD.WindowState = FormWindowState.Maximized
        PPD.ShowDialog()
        PD.Print()

        ClearData()
    End Sub

    Sub Transact_SN()
        If cmbPmode.Text = String.Empty Then
            MessageBox.Show("Please select payment mode", "Payment Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        ElseIf tbTenderedamount.Text = String.Empty Then
            MessageBox.Show("Please enter received amount", "Received Amount", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        ElseIf Not String.IsNullOrWhiteSpace(lblTotalAmount.Text) AndAlso Not String.IsNullOrWhiteSpace(tbTenderedamount.Text) AndAlso
                CDec(lblTotalAmount.Text) > CDec(tbTenderedamount.Text) Then
            MsgBox("Insufficient Balance!", MsgBoxStyle.Exclamation, "Received Amount")
            Return
        Else
            Try
                Connect()
                For c As Integer = 0 To dgvPOS.Rows.Count - 1
                    query = "INSERT INTO `tbl_pos`(SN, Billdate, Bmonth, BMyear, ItemCode, Description, Category,
                            Price, Quantity, VAT, Extended, Total, Subtotal, VatableAmount, Discount,
                            TotalAmount, Paymentmode, TenderedAmount, Balance) VALUES (@sn, @bdate, @bmonth, @bmyear, 
                            @itemcode, @description, @category, @price, @vat, @extended, @qty, @total, @subtotal, 
                            @vatableamount, @discount, @totalamount, @paymentmode, @tenderedamount, @balance)"

                    With command
                        .Connection = conn
                        .CommandText = query
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@sn", tbSN.Text)
                        .Parameters.AddWithValue("@bdate", DateTime.Now)
                        .Parameters.AddWithValue("@bmonth", Date.Now.ToString("MM"))
                        .Parameters.AddWithValue("@bmyear", Date.Now.ToString("MMMM-yyyy"))

                        .Parameters.AddWithValue("@itemcode", dgvPOS.Rows(c).Cells(1).Value)
                        .Parameters.AddWithValue("@description", dgvPOS.Rows(c).Cells(2).Value)
                        .Parameters.AddWithValue("@category", dgvPOS.Rows(c).Cells(3).Value)
                        .Parameters.AddWithValue("@price", dgvPOS.Rows(c).Cells(4).Value)
                        .Parameters.AddWithValue("@vat", dgvPOS.Rows(c).Cells(5).Value)
                        .Parameters.AddWithValue("@extended", dgvPOS.Rows(c).Cells(6).Value)
                        .Parameters.AddWithValue("@qty", dgvPOS.Rows(c).Cells(7).Value)
                        .Parameters.AddWithValue("@total", dgvPOS.Rows(c).Cells(8).Value)

                        .Parameters.AddWithValue("@subtotal", lblSubTotal.Text)
                        .Parameters.AddWithValue("@vatableamount", lblVatAmount.Text)
                        .Parameters.AddWithValue("@discount", lblDiscount.Text)
                        .Parameters.AddWithValue("@totalamount", lblTotalAmount.Text)
                        .Parameters.AddWithValue("@paymentmode", cmbPmode.Text)
                        .Parameters.AddWithValue("@tenderedamount", tbTenderedamount.Text)
                        .Parameters.AddWithValue("@balance", lblChange.Text)

                        i = .ExecuteNonQuery()

                    End With

                    'Update/deduct stocks after every purchased item
                    query = "UPDATE `tbl_product` SET Stocks = Stocks - @qty WHERE Item_code=@itemcode"

                    With command
                        .Connection = conn
                        .CommandText = query
                        .Parameters.Clear()
                        .Parameters.AddWithValue("@qty", dgvPOS.Rows(c).Cells(7).Value)
                        .Parameters.AddWithValue("@itemcode", dgvPOS.Rows(c).Cells(1).Value)
                        .ExecuteNonQuery()
                    End With

                    'Check if stocks are low
                    Dim cmdStocks As New MySqlCommand("SELECT `Stocks` FROM `tbl_product` WHERE `Item_code`=@itemcode", conn)
                    cmdStocks.Parameters.AddWithValue("@itemcode", dgvPOS.Rows(c).Cells(1).Value)
                    Dim checkstock As Integer = CInt(cmdStocks.ExecuteScalar())

                    If checkstock <= 3 Then
                        MsgBox("Warning: Item stock for '" & dgvPOS.Rows(c).Cells(2).Value & "' is low (" & checkstock & " stocks remaining).",
                               MsgBoxStyle.Exclamation, "STOCK")
                    End If
                Next

                If i > 0 Then
                    MsgBox("Transaction saved successfully!" & vbNewLine & "SN: " & tbSN.Text, vbInformation)
                    'BackgroundWorker1.RunWorkerAsync()

                Else
                    MsgBox("Transaction failed!", vbExclamation)
                End If

            Catch ex As Exception
                MsgBox("Error: " & ex.Message, vbExclamation, "Command Execution Error")
            Finally
                conn.Close()

            tbSN.Text = Guid.NewGuid().ToString()
            End Try
        End If
    End Sub

    Sub ClearData()
        BillDateTimePicker.Text = Now
        tbItemcode.Clear()
        dgvPOS.Rows.Clear()

        lblItems.Text = "0"
        lblSubTotal.Text = "0.00"
        lblTotalPrice.Text = "0.00"
        lblVatAmount.Text = "0.00"
        lblDiscount.Text = "0.00"
        lblTotalAmount.Text = "0.00"
        lblOverallAmount.Text = "0.00"
        lblChange.Text = "0.00"
        cmbPmode.SelectedIndex = -1
        tbTenderedamount.Clear()
    End Sub

    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs)
        Dim tb As TextBox = TryCast(sender, TextBox)
        If tb IsNot Nothing Then
            Dim row As Integer = dgvPOS.CurrentCell.RowIndex
            Dim qty As Integer
            If Integer.TryParse(tb.Text, qty) Then
                Dim price As Decimal = CDec(dgvPOS.Rows(row).Cells(4).Value)
                Dim vat As Decimal = CDec(dgvPOS.Rows(row).Cells(5).Value)
                Dim tqp As Decimal = Decimal.Round((qty * price) * (1 + (vat / 100)), 2)

                'tqp into 2 decimal points
                Dim formattedTQP As String = tqp.ToString("0.00")

                'Calculated price * qty into total amount value
                dgvPOS.Rows(row).Cells(9).Value = formattedTQP

                'Calculated total amount value for every qty
                TotalItems()

            End If
        End If
    End Sub

    Private Sub dgvPOS_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvPOS.EditingControlShowing
        'Add event to edit qty cell
        If dgvPOS.CurrentCell.ColumnIndex = 8 AndAlso TypeOf e.Control Is TextBox Then
            Dim tb As TextBox = TryCast(e.Control, TextBox)
            If tb IsNot Nothing Then
                RemoveHandler tb.TextChanged, AddressOf QuantityTextBox_TextChanged
                AddHandler tb.TextChanged, AddressOf QuantityTextBox_TextChanged
            End If
        End If
    End Sub

    'Print Receipt
    Dim longpaper As Integer

    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup

    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage

        Dim requiredHeight As Integer = 220
        requiredHeight += (dgvPOS.RowCount - 1) * 15
        requiredHeight += 70
        PD.DefaultPageSettings.PaperSize = New PaperSize("Custom", 250, requiredHeight)

        Dim f7 As New Font("Cambria", 7, FontStyle.Regular)
        Dim f7b As New Font("Cambria", 7, FontStyle.Bold)
        Dim f8 As New Font("Cambria", 8, FontStyle.Regular)
        Dim f8b As New Font("Cambria", 8, FontStyle.Bold)
        Dim f9b As New Font("Cambria", 9, FontStyle.Bold)
        Dim f10 As New Font("Cambria", 10, FontStyle.Regular)
        Dim f14 As New Font("Arial", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'Font alignment
        Dim right As New StringFormat()
        Dim center As New StringFormat()
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String = "-------------------------------------------------------------------------"

        'Draw store information and header
        e.Graphics.DrawString("VCJ", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("CONSUMER GOODS TRADING ", f9b, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("GENERAL MERCHANDISE", f9b, Brushes.Black, centermargin, 37, center)
        e.Graphics.DrawString("Poblacion District, Davao City", f7, Brushes.Black, centermargin, 52, center)

        e.Graphics.DrawString("Serial#: ", f7, Brushes.Black, 5, 85)
        e.Graphics.DrawString(tbSN.Text, f7, Brushes.Black, 44, 85)
        e.Graphics.DrawString("Cashier: ", f7, Brushes.Black, 5, 95)
        e.Graphics.DrawString(lblPOSuser.Text, f7, Brushes.Black, 44, 95)
        Dim currentDate As String = DateTime.Now.ToString("MM/dd/yyyy  hh:mm:ss tt")
        e.Graphics.DrawString("Date/Time: ", f7, Brushes.Black, 5, 105)
        e.Graphics.DrawString(currentDate, f7, Brushes.Black, 60, 105)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 115)

        'Draw column headers
        e.Graphics.DrawString("Item", f7, Brushes.Black, 5, 125)
        e.Graphics.DrawString("Qty", f7, Brushes.Black, 130, 125)
        e.Graphics.DrawString("Price", f7, Brushes.Black, 155, 125)
        e.Graphics.DrawString("Total", f7, Brushes.Black, 215, 125)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 135)

        'Draw DataGridView Columns
        Dim height As Integer = 0
        Dim VATABLE_AMOUNT As String = lblVatAmount.Text
        Dim totalAmount As String = lblTotalAmount.Text
        Dim tenderedAmount As String = tbTenderedamount.Text
        Dim change As String = lblChange.Text

        For Each dgvRow As DataGridViewRow In dgvPOS.Rows
            If dgvRow.Index <> dgvPOS.NewRowIndex Then
                Dim description As String = dgvRow.Cells(2).Value.ToString()
                Dim price As String = "₱" & dgvRow.Cells(4).Value.ToString()
                Dim qty As String = dgvRow.Cells(7).Value.ToString()
                Dim total As String = "₱" & dgvRow.Cells(8).Value.ToString()

                e.Graphics.DrawString(description, f7, Brushes.Black, 5, 145 + height)
                e.Graphics.DrawString(qty, f7, Brushes.Black, 135, 145 + height)
                e.Graphics.DrawString(price, f7, Brushes.Black, 155, 145 + height)
                e.Graphics.DrawString(total, f7, Brushes.Black, rightmargin, 145 + height, right)
                height += 15
            End If
        Next

        Dim lineY As Integer = 148 + height
        Dim totalVatY As Integer = lineY + 10
        Dim totalAmountY As Integer = totalVatY + 15
        Dim tenderedAmountY As Integer = totalAmountY + 15
        Dim changeY As Integer = tenderedAmountY + 15
        Dim heightt As String = changeY + 15

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, lineY)
        Dim fTotalVat As String = "₱" & lblVatAmount.Text
        Dim fTotalAmount As String = "₱" & lblTotalAmount.Text
        Dim fTenderedAmount As String = "₱" & Format(CDec(tbTenderedamount.Text), "0.00")
        Dim fChange As String = "₱" & lblChange.Text

        'AmountLabel Headers
        e.Graphics.DrawString("VAT (12%) ", f8, Brushes.Black, 5, totalVatY)
        e.Graphics.DrawString("Total Amount ", f8b, Brushes.Black, 5, totalAmountY)
        e.Graphics.DrawString("Tendered Amount ", f8, Brushes.Black, 5, tenderedAmountY)
        e.Graphics.DrawString("CHANGE ====> ", f8, Brushes.Black, 5, changeY)

        e.Graphics.DrawString(fTotalVat, f8, Brushes.Black, rightmargin, totalVatY, right)
        e.Graphics.DrawString(fTotalAmount, f8b, Brushes.Black, rightmargin, totalAmountY, right)
        e.Graphics.DrawString(fTenderedAmount, f8, Brushes.Black, rightmargin, tenderedAmountY, right)
        e.Graphics.DrawString(fChange, f8, Brushes.Black, rightmargin, changeY, right)

        e.Graphics.DrawString("--- THANK YOU FOR YOUR PURCHASED ---", f8, Brushes.Black, centermargin, 40 + heightt, center)
        e.Graphics.DrawString("COME AGAIN", f8, Brushes.Black, centermargin, 55 + heightt, center)
    End Sub


End Class