Imports DomainLayer

Public Class Transactions
    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbTSearch.Focus()
        load_Report()
        TotalSales()
    End Sub

    Sub load_Report()

        Try
            Connect()
            query = "SELECT `SN`, `Billdate`, `TotalAmount` FROM `tbl_pos` Group by SN"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()

                While read.Read()
                    dgvTransactions.Rows.Add(dgvTransactions.Rows.Count + 1, read.Item("SN"), read.Item("Billdate"),
                                         read.Item("TotalAmount"))
                End While

            End With

        Catch ex As Exception
            MsgBox("ERROR! Loading of data failed. " & ex.Message, MsgBoxStyle.Critical, "Load Sales Report")
        Finally
            conn.Close()
        End Try

    End Sub

    Sub TotalSales()
        Try
            Dim sum As Double = 0
            For y As Integer = 0 To dgvTransactions.Rows.Count() - 1 Step +1
                sum = sum + dgvTransactions.Rows(y).Cells(3).Value
            Next
            lblSales.Text = "₱" & Format(CDec(sum), "#,##0.00")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TotalSales()
    End Sub

    Private Sub tbTSearch_TextChanged(sender As Object, e As EventArgs) Handles tbTSearch.TextChanged
        dgvTransactions.Rows.Clear()
        Try
            Connect()
            query = "SELECT `SN`, `Billdate`, `TotalAmount` FROM `tbl_pos` 
                    WHERE SN like '%" & tbTSearch.Text & "%' Group by SN"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()

            End With
            While read.Read()
                dgvTransactions.Rows.Add(dgvTransactions.Rows.Count + 1, read.Item("SN"),
                                         read.Item("Billdate"), read.Item("TotalAmount"))
            End While
            TotalSales()


        Catch ex As Exception
            'MsgBox("ERROR! No transaction record found.  " & ex.Message, MsgBoxStyle.Critical, "Search Transaction")
        Finally
            conn.Close()
        End Try
        dgvTransactions.Refresh()
    End Sub

    Private Sub radiobtnToday_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtnToday.CheckedChanged
        dgvTransactions.Rows.Clear()
        Try
            Connect()
            query = "SELECT `SN`, `Billdate`, `TotalAmount` FROM `tbl_pos` 
                    WHERE Billdate like '%" & Date.Now.ToString("yyyy-MM-dd") & "%' Group by SN"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()

                While read.Read()
                    dgvTransactions.Rows.Add(dgvTransactions.Rows.Count + 1, read.Item("SN"),
                                             read.Item("Billdate"), read.Item("TotalAmount"))
                End While
            End With
            TotalSales()
        Catch ex As Exception
            MsgBox("ERROR:  " & ex.Message, MsgBoxStyle.Critical, "Today's Sale Data")
        Finally
            conn.Close()
        End Try
        dgvTransactions.Refresh()
    End Sub

    Private Sub radiobtnMonth_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtnMonth.CheckedChanged
        dgvTransactions.Rows.Clear()
        Try
            Connect()
            query = "SELECT `SN`, `Billdate`, `TotalAmount` FROM `tbl_pos` 
                    WHERE Bmonth like '%" & Date.Now.ToString("MM") & "%' Group by SN"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()

                While read.Read()
                    dgvTransactions.Rows.Add(dgvTransactions.Rows.Count + 1, read.Item("SN"),
                                             read.Item("Billdate"), read.Item("TotalAmount"))
                End While
                TotalSales()
            End With

        Catch ex As Exception
            MsgBox("ERROR:  " & ex.Message, MsgBoxStyle.Critical, "Month's Sale Data")
        Finally
            conn.Close()
        End Try
        dgvTransactions.Refresh()
    End Sub

    Private Sub btnPFilter_Click(sender As Object, e As EventArgs) Handles btnPFilter.Click
        Dim date1 As String = DateTimePicker1.Value.Date.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.Date.ToString("yyyy-MM-dd")

        dgvTransactions.Rows.Clear()
        Try
            Connect()
            query = "SELECT `SN`, `Billdate`, `TotalAmount` FROM `tbl_pos` 
                    WHERE Billdate between '" & date1 & "' and '" & date2 & "' Group by SN"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()

                While read.Read()
                    dgvTransactions.Rows.Add(dgvTransactions.Rows.Count + 1, read.Item("SN"),
                                             read.Item("Billdate"), read.Item("TotalAmount"))

                End While
                TotalSales()
            End With
        Catch ex As Exception
            MsgBox("ERROR! Filtering data failed.  " & ex.Message, MsgBoxStyle.Critical, "Filter Data")
        Finally
            conn.Close()
        End Try
        dgvTransactions.Refresh()
    End Sub

    Private Sub dgvTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellContentClick, dgvTransactions.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvTransactions.Rows(e.RowIndex)
            Dim selectedTransactionNumber As String = selectedRow.Cells(1).Value.ToString()
            Dim transactionDetailsForm As New TransDetails(selectedTransactionNumber)
            transactionDetailsForm.ShowDialog()
        End If
    End Sub


End Class