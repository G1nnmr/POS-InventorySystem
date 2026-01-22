Imports DomainLayer
Imports Mysqlx.XDevAPI.Common
Imports ServiceLayer

Public Class DiscountRepository
    Implements IDiscountRepository

    Private ReadOnly DiscountList As New List(Of DiscountView)

    Public Function GetDiscount() As List(Of DiscountView) Implements IDiscountRepository.GetDiscount
        Try
            Connect()
            query = "SELECT * FROM `tbl_discount` WHERE discount = '0'"

            With command
                .Connection = conn
                .CommandText = query

                read = .ExecuteReader()

                While read.Read
                    Dim discount As New DiscountView With {
                        .DiscountId = read(0).ToString(),
                        .DiscountRate = Convert.ToDecimal(read(2))
                    }
                    DiscountList.Add(discount)
                End While
            End With
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return DiscountList
    End Function

    Public Function UpdateDiscount(Request As Discount) As Boolean Implements IDiscountRepository.UpdateDiscount
        Dim res As Boolean = False
        Try
            Connect()
            query = "UPDATE tbl_discount SET discount=@discount WHERE dis_id=@disId"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@disId", Request.DiscountId)
                .Parameters.AddWithValue("@discount", Request.DiscountRate)

                i = .ExecuteNonQuery()
                res = (i > 0)
            End With
        Catch ex As Exception
            Throw New Exception("ERROR:" & ex.Message)
        Finally
            conn.Close()
        End Try
        Return res
    End Function
End Class

