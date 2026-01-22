Imports DomainLayer
Imports MySql.Data.MySqlClient
Imports ServiceLayer

Public Class Cashier_POSRepository
    Implements ICashier_POSRepository

    Public Function GetItemCode(itemcode As String) As Cashier Implements ICashier_POSRepository.GetItemCode
        Dim itm As Cashier = Nothing
        Try
            If conn Is Nothing OrElse conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd As New MySqlCommand("SELECT * FROM `tbl_product` WHERE Item_code=@itemcode", conn)
            cmd.Parameters.AddWithValue("@itemcode", itemcode)
            read = cmd.ExecuteReader()

            If read.Read() Then
                itm = New Cashier() With {
                    .Item_code = read(1).ToString(),
                    .Description = read(2).ToString(),
                    .Category = read(3).ToString(),
                    .Price = Convert.ToDecimal(read(4)),
                    .VAT = Convert.ToDecimal(read(5)),
                    .Extended = Convert.ToDecimal(read(6))
                }
            End If
            read.Close()

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        Finally
            If conn Is Nothing OrElse conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
        Return itm
    End Function

End Class
