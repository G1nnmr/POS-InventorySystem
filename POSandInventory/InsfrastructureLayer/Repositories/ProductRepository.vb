Imports DomainLayer
Imports ServiceLayer

Public Class ProductRepository
    Implements IProductRepository

    Private ReadOnly ProductList As New List(Of ProductView)

    Public Function GetAllProducts() As List(Of ProductView) Implements IProductRepository.GetAllProducts

        Try
            Connect()
            query = "SELECT * FROM `tbl_product`"

            With command
                .Connection = conn
                .CommandText = query

                read = .ExecuteReader()

                While read.Read
                    Dim Products As New ProductView With {
                        .Id = read(0),
                        .Item_code = read(1),
                        .Description = read(2),
                        .Category = read(3),
                        .Price = read(4),
                        .VAT = read(5),
                        .Extended = read(6),
                        .Stocks = read(7)
                    }
                    ProductList.Add(Products)
                End While
            End With
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return ProductList
    End Function

    Public Function ItemcodeExist(Item_code As String) As Boolean Implements IProductRepository.ItemcodeExist
        Dim exist As Boolean = False

        Try
            Connect()
            query = "SELECT * FROM tbl_product where Item_code=@itemcode"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@itemcode", Item_code)

                read = .ExecuteReader()
            End With

            If read.Read() Then
                exist = True
            Else
                'MsgBox("Item # does not exist!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return exist
    End Function

    Public Function GetItemcode(Item_code As String) As Products Implements IProductRepository.GetItemcode
        Dim prod As New Products

        Try
            If ItemcodeExist(Item_code) Then
                'Read
                Connect()
                query = "SELECT * FROM tbl_product where Item_code=@itemcode"
                With command
                    .Connection = conn
                    .CommandText = query
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@itemcode", Item_code)
                    read = .ExecuteReader()
                End With

                If read.Read Then
                    With prod
                        .Id = read(0)
                        .Item_code = read(1)
                        .Description = read(2)
                        .Category = read(3)
                        .Price = read(4)
                        .VAT = read(5)
                        .Extended = read(6)
                        .Stocks = read(7)
                    End With
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return prod

    End Function

    Public Sub UpsertProduct(Request As Products) Implements IProductRepository.UpsertProduct
        Try
            If ItemcodeExist(Request.Item_code) Then
                'Update
                Connect()
                query = "UPDATE tbl_product SET Description=@description, Category=@category
                        Price=@price, VAT=@vat, Extended=@extended, Stocks=@stocks WHERE Item_code=@itemcode"

                With command
                    .Connection = conn
                    .CommandText = query
                    .Parameters.Clear()
                    '.Parameters.AddWithValue("@id", Request.Id)
                    .Parameters.AddWithValue("@itemcode", Request.Item_code)
                    .Parameters.AddWithValue("@description", Request.Description)
                    .Parameters.AddWithValue("@category", Request.Category)
                    .Parameters.AddWithValue("@price", Request.Price)
                    .Parameters.AddWithValue("@vat", Request.VAT)
                    .Parameters.AddWithValue("@extended", Request.Extended)
                    .Parameters.AddWithValue("@stocks", Request.Stocks)
                    .ExecuteNonQuery()
                End With
                MsgBox("Item successfully updated.", MsgBoxStyle.Information)

            Else
                'Insert/Create
                Connect()
                query = "INSERT INTO tbl_product (Item_code, Description, Category, Price, VAT, Extended, Stocks) " &
                        "VALUES (@itemcode, @description, @category, @price, @vat, @extended, @stocks)"

                With command
                    .Connection = conn
                    .CommandText = query
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@itemcode", Request.Item_code)
                    .Parameters.AddWithValue("@description", Request.Description)
                    .Parameters.AddWithValue("@category", Request.Category)
                    .Parameters.AddWithValue("@price", Request.Price)
                    .Parameters.AddWithValue("@vat", Request.VAT)
                    .Parameters.AddWithValue("@extended", Request.Extended)
                    .Parameters.AddWithValue("@stocks", Request.Stocks)
                    .ExecuteNonQuery()

                End With
                MsgBox("Item successfully added.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            conn.Close()
        End Try
    End Sub

    'Delete -> CRUD
    Public Sub DeleteProduct(Item_code As String) Implements IProductRepository.DeleteProduct

        Dim msgLog As Integer
        msgLog = MsgBox("Are you sure you want to delete this product?", vbExclamation + vbYesNo)
        If msgLog = vbYes Then

            Try
                Connect()
                query = "DELETE FROM tbl_product where Item_code=@itemcode"
                With command
                    .Connection = conn
                    .CommandText = query
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@itemcode", Item_code)

                    .ExecuteNonQuery()
                End With
                MsgBox("Product deleted successfully.", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.Message, vbExclamation)
            Finally
                conn.Close()
            End Try
        End If


    End Sub

End Class
