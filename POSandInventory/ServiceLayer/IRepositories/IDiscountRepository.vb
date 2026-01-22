Imports DomainLayer

Public Interface IDiscountRepository
    Function GetDiscount() As List(Of DiscountView)
    Function UpdateDiscount(Request As Discount) As Boolean
End Interface
