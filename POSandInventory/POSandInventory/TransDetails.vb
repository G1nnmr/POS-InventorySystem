Imports MySql.Data.MySqlClient
Imports DomainLayer

Public Class TransDetails
    Public Property TransactionNumber As String

    Public Sub New(transactionNumber As String)
        InitializeComponent()
        Me.TransactionNumber = transactionNumber
        LoadTransactionDetails()
    End Sub

    Private Sub LoadTransactionDetails()

        Dim transactionDetails As DataTable = GetTransactionDetails(TransactionNumber)

        If transactionDetails IsNot Nothing AndAlso transactionDetails.Rows.Count > 0 Then
            DGVDetails.DataSource = transactionDetails
        Else
            MsgBox("No records found for this transaction.", MsgBoxStyle.Information, "No Records")
        End If
    End Sub

    Private Function GetTransactionDetails(transactionNumber As String) As DataTable

        Try
            Connect()
            Dim query As String = "SELECT `ItemCode`, `Description`, `Category`, `Price`,`Discount`, `Quantity`, `VAT`, `Extended`, `Total` FROM `tbl_pos` WHERE SN = @SN"

            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@SN", transactionNumber)

                Dim adapter As New MySqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Critical, "Error Loading Data")
        Finally
            conn.Close()

        End Try

        Return dt

    End Function



End Class