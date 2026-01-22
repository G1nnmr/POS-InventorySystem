Public Class Cashier
    Public Property Id As Integer                'read(0)
    Public Property Item_code As String          'read(1) 
    Public Property Description As String        'read(2)
    Public Property Category As String           'read(3)
    Public Property Price As Decimal             'read(4)
    Public Property VAT As Decimal               'read(5)
    Public Property Extended As Decimal          'read(6)       Price * VAT

End Class
