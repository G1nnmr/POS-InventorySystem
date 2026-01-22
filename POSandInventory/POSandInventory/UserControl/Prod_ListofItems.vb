Imports DomainLayer

Public Class Prod_ListofItems

    Private Sub Prod_ListofItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        load_Items()
    End Sub

    Sub load_Items()
        dgvListofProd.Rows.Clear()
        Try
            Connect()
            query = "SELECT `Item_code`, `Description`, `Category`, `Price`, `VAT`, `Extended`, `Stocks` 
                    FROM `tbl_product` 
                    Group by Item_code"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()

                While read.Read()
                    dgvListofProd.Rows.Add(dgvListofProd.Rows.Count + 1, read.Item("Item_code"),
                                             read.Item("Description"), read.Item("Category"), read.Item("Price"),
                                             read.Item("VAT"), read.Item("Extended"), read.Item("Stocks"))
                End While
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub tbstockSearch_TextChanged(sender As Object, e As EventArgs) Handles tbstockSearch.TextChanged
        dgvListofProd.Rows.Clear()
        Try
            Connect()
            query = "SELECT `Item_code`, `Description`, `Category`, `Price`, `VAT`, `Extended`, `Stocks` 
                    FROM `tbl_product` 
                    WHERE Item_code LIKE '%" & tbstockSearch.Text & "%' 
                    GROUP BY Item_code"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()

                While read.Read()
                    dgvListofProd.Rows.Add(dgvListofProd.Rows.Count + 1, read.Item("Item_code"),
                                             read.Item("Description"), read.Item("Category"), read.Item("Price"),
                                             read.Item("VAT"), read.Item("Extended"), read.Item("Stocks"))
                End While

            End With
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        dgvListofProd.Refresh()
    End Sub

End Class