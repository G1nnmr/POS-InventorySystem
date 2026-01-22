Imports DomainLayer
Imports InsfrastructureLayer
Imports MySql.Data.MySqlClient
Imports ServiceLayer

Public Class Overview
    Dim dr As MySqlDataReader
    Private Sub Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        Timer1.Start()
        TodaySales()
        MonthlySales()
        No_Items()
        No_Users()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldDate.Text = Date.Now.ToString("dddd, MMMM dd, yyyy")
        lbldTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint
        Timer1.Enabled = True
    End Sub

    Sub TodaySales()
        DataGridView1.Rows.Clear()
        Dim sum As Double = 0
        Dim count As Integer = 0
        Try
            Connect()
            query = "SELECT Sum(TotalAmount), COUNT(SN) FROM tbl_pos WHERE DATE(billdate)= '" & Date.Now.ToString("yyyy-MM-dd") & "'"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()

                If read.Read() Then
                    sum = read(0)
                    count = read(1)

                End If
            End With

            lblTodaySales.Text = "₱" & Format(CDec(sum), "#,##0.00")
            lblNoOfTodaySales.Text = count

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Sub MonthlySales()
        DataGridView1.Rows.Clear()

        Try
            Connect()
            query = "SELECT * FROM tbl_pos WHERE Bmonth= '" & Date.Now.ToString("MM") & "' group by SN"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()

                While read.Read()
                    DataGridView1.Rows.Add(read.Item("SN"),
                                    read.Item("Billdate"),
                                    read.Item("Bmonth"),
                                    read.Item("TotalAmount"))
                End While
            End With
            Dim sum As Double = 0
            For i = 0 To DataGridView1.Rows.Count - 1 Step +1
                sum += DataGridView1.Rows(i).Cells(3).Value
            Next
            lblMonthlySales.Text = "₱" & CDec(sum).ToString("#,##0.00")
            lblNoOfMonthlySales.Text = DataGridView1.Rows.Count.ToString()


        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub No_Items()
        Try
            Connect()
            query = "SELECT COUNT(`Id`) FROM `tbl_product`"

            With command
                .Connection = conn
                .CommandText = query

                lblNoOfItems.Text = .ExecuteScalar.ToString

            End With

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Sub No_Users()
        Try
            Connect()
            query = "SELECT COUNT(`Id`) FROM `tbl_account`"

            With command
                .Connection = conn
                .CommandText = query

                lblNoOfUsers.Text = .ExecuteScalar.ToString

            End With

        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub


End Class
