Imports DomainLayer

Public Interface IProductRepository
    Function GetAllProducts() As List(Of ProductView)
    Sub UpsertProduct(Request As Products)
    Function ItemcodeExist(Item_code As String) As Boolean
    Function GetItemcode(Item_code As String) As Products
    Sub DeleteProduct(Item_code As String)


End Interface
