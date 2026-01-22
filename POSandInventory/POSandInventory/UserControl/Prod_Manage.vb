Imports DomainLayer
Imports InsfrastructureLayer
Imports ServiceLayer

Public Class Prod_Manage
    Private ProductRepository As IProductRepository = New ProductRepository
    Public Event AddCategory As EventHandler(Of String)

    Private Sub Prod_Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbItemcode.Focus()
        GetAllProducts()
    End Sub

    Private Sub GetAllProducts()    'Retrieving Products From ProductRepository
        ProductRepository.GetAllProducts()
    End Sub

    Private Sub btnAddCategory_Click_1(sender As Object, e As EventArgs) Handles btnAddCategory.Click

        If String.IsNullOrWhiteSpace(tbNewCategory.Text) Then
            MsgBox("Please enter a category name.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Connect()
            query = "INSERT INTO tbl_category (CategoryName) VALUES (@categoryname)"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@categoryname", tbNewCategory.Text.Trim())
                i = .ExecuteNonQuery()
            End With

            MsgBox(tbNewCategory.Text + " has been successfully added.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            End Try

    End Sub

    Private Sub cmbCategory_DropDown(sender As Object, e As EventArgs) Handles cmbCategory.DropDown

        cmbCategory.Items.Clear()
        Try
            Connect()
            query = "SELECT * FROM `tbl_category`"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                read = .ExecuteReader()
            End With

            While read.Read()
                cmbCategory.Items.Add(read(1))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnPClear.Click
        tbNewCategory.Clear()
        tbItemcode.Clear()
        tbDescription.Clear()
        tbPrice.Clear()
        tbVAT.Clear()
        tbExtended.Clear()
        tbStocks.Clear()
        cmbCategory.SelectedIndex = -1

    End Sub

    Private Sub btnPSave_Click(sender As Object, e As EventArgs) Handles btnPSave.Click

        If String.IsNullOrEmpty(tbItemcode.Text.Trim()) Then
            MsgBox("Item code is required", MsgBoxStyle.Exclamation)
            ErrorProvider1.SetError(tbItemcode, "Please fill out this field")
            tbItemcode.Focus()
        ElseIf String.IsNullOrEmpty(tbDescription.Text.Trim()) Then
            MsgBox("Description is required", MsgBoxStyle.Exclamation)
            ErrorProvider1.SetError(tbDescription, "Please fill out this field")
            tbDescription.Focus()
        ElseIf String.IsNullOrEmpty(tbPrice.Text.Trim()) Then
            MsgBox("Price is required.", MsgBoxStyle.Exclamation)
            ErrorProvider1.SetError(tbPrice, "Please fill out this field")
            tbPrice.Focus()
            Return
        ElseIf String.IsNullOrEmpty(tbVAT.Text.Trim()) Then
            MsgBox("VAT is required.", MsgBoxStyle.Exclamation)
            ErrorProvider1.SetError(tbVAT, "Please fill out this field")
            tbVAT.Focus()
        ElseIf String.IsNullOrEmpty(tbExtended.Text.Trim()) Then
            MsgBox("Purchase Price is required.", MsgBoxStyle.Exclamation)
            ErrorProvider1.SetError(tbExtended, "Please fill out this field")
            tbExtended.Focus()
        ElseIf String.IsNullOrEmpty(tbStocks.Text.Trim()) Then
            MsgBox("Stocks is required.", MsgBoxStyle.Exclamation)
            ErrorProvider1.SetError(tbStocks, "Please fill out this field")
            tbStocks.Focus()
        ElseIf String.IsNullOrEmpty(cmbCategory.SelectedItem.ToString()) Then
            'cmbCategory.SelectedItem IsNot Nothing Then
            MsgBox("Category is required.", MsgBoxStyle.Exclamation)
            cmbCategory.Focus()
        Else
            ErrorProvider1.SetError(tbItemcode, String.Empty)
            ErrorProvider1.SetError(tbDescription, String.Empty)
            ErrorProvider1.SetError(cmbCategory, String.Empty)
            ErrorProvider1.SetError(tbPrice, String.Empty)
            ErrorProvider1.SetError(tbVAT, String.Empty)
            ErrorProvider1.SetError(tbExtended, String.Empty)
            ErrorProvider1.SetError(tbStocks, String.Empty)

            Dim saveItems As New Products With {
            .Item_code = tbItemcode.Text.Trim,
            .Description = tbDescription.Text.Trim,
            .Category = cmbCategory.SelectedItem.ToString(),
            .Price = tbPrice.Text.Trim,
            .VAT = tbVAT.Text.Trim,
            .Extended = tbExtended.Text.Trim,
            .Stocks = tbStocks.Text.Trim
            }
            ProductRepository.UpsertProduct(saveItems)
            GetAllProducts()

        End If
    End Sub

    'Search if Itemcode Exist
    Private Sub tbSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim prodExist = ProductRepository.ItemcodeExist(tbPSearch.Text.Trim)

            If prodExist Then
                Dim productDetails = ProductRepository.GetItemcode(tbPSearch.Text.Trim)
                cmbCategory.Text = cmbCategory.GetItemText(productDetails.Category)
                tbPSearch.Text = productDetails.Item_code
                tbItemcode.Text = productDetails.Item_code
                tbDescription.Text = productDetails.Description
                tbPrice.Text = productDetails.Price
                tbVAT.Text = productDetails.VAT
                tbExtended.Text = productDetails.Price
                tbStocks.Text = productDetails.Stocks

            Else
                MsgBox("Item code not found.", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnPDelete_Click(sender As Object, e As EventArgs) Handles btnPDelete.Click
        Dim searchItemcode = ProductRepository.ItemcodeExist(tbPSearch.Text.Trim)
        If searchItemcode Then
            ProductRepository.DeleteProduct(tbPSearch.Text.Trim)
        End If
        GetAllProducts()
    End Sub

    Private Sub btnPSearch_Click(sender As Object, e As EventArgs) Handles btnPSearch.Click

        Dim prodExist = ProductRepository.ItemcodeExist(tbPSearch.Text.Trim)

            If prodExist Then
                Dim productDetails = ProductRepository.GetItemcode(tbPSearch.Text.Trim)
                cmbCategory.Text = cmbCategory.GetItemText(productDetails.Category)
                tbPSearch.Text = productDetails.Item_code
                tbItemcode.Text = productDetails.Item_code
                tbDescription.Text = productDetails.Description
                tbPrice.Text = productDetails.Price
                tbVAT.Text = productDetails.VAT
                tbExtended.Text = productDetails.Price
                tbStocks.Text = productDetails.Stocks

            Else
            MsgBox("Item code not found.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Connect()
            query = "UPDATE `tbl_product` SET `Description`=@description,`Category`=@category,`Price`=@price,
                    `VAT`=@vat,`Extended`=@extended,`Stocks`=@stocks WHERE Item_code=@itemcode"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@itemcode", tbItemcode.Text.Trim())
                .Parameters.AddWithValue("@description", tbDescription.Text.Trim())
                .Parameters.AddWithValue("@category", cmbCategory.Text.Trim())
                .Parameters.AddWithValue("@price", tbPrice.Text.Trim())
                .Parameters.AddWithValue("@vat", tbVAT.Text.Trim())
                .Parameters.AddWithValue("@extended", tbExtended.Text.Trim())
                .Parameters.AddWithValue("@stocks", tbStocks.Text.Trim())
                .ExecuteNonQuery()

            End With
            MsgBox("Item successfully updated.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub btnDeleteCategory_Click(sender As Object, e As EventArgs) Handles btnDeleteCategory.Click
        If String.IsNullOrEmpty(cmbCategory.SelectedItem.ToString()) Then
            MsgBox("Please select a category to delete.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Confirm deletion
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete the category " & cmbCategory.SelectedItem.ToString() & "'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Connect()
                query = "DELETE FROM tbl_category WHERE CategoryName = @categoryname"

                With command
                    .Connection = conn
                    .CommandText = query
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@categoryname", cmbCategory.SelectedItem.ToString())
                    i = .ExecuteNonQuery()
                End With

                If i > 0 Then
                    MsgBox(cmbCategory.SelectedItem.ToString() + " has been successfully deleted.", MsgBoxStyle.Information)
                Else
                    MsgBox("Category not found.", MsgBoxStyle.Exclamation)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Class
