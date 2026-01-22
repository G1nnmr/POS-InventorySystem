Imports DomainLayer
Imports ServiceLayer

Public Class DiscountUpdate
    Public Event DiscountUpdated As EventHandler(Of String)
    Private discountList As IDiscountRepository

    Public Sub New(discountRepository As IDiscountRepository)
        InitializeComponent()

        Me.discountList = discountRepository
        If Me.discountList Is Nothing Then
            MessageBox.Show("Initialization of discount repository failed.")
        End If
    End Sub

    Private Sub DiscountUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DiscountCurrentLoad()
    End Sub

    Private Sub btnDUpdate_Click(sender As Object, e As EventArgs) Handles btnDUpdate.Click
        Try
            Dim discRate As Decimal
            If Not Decimal.TryParse(tbDiscount.Text, discRate) Then
                MsgBox("Please enter a valid discount rate.", MsgBoxStyle.Critical, "Discount")
                Return
            End If

            Dim disc As New Discount() With {
                .DiscountId = "1002",
                .DiscountRate = discRate
                }
            If discountList.UpdateDiscount(disc) Then
                MessageBox.Show("Discount updated successfully!", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RaiseEvent DiscountUpdated(Me, tbDiscount.Text)
            Else
                MessageBox.Show("Discount update failed!", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MsgBox("An error occured in update: " & ex.Message, MsgBoxStyle.Critical, "Discount")
        End Try

    End Sub

    Private Sub DiscountCurrentLoad()
        Try
            If discountList Is Nothing Then
                Throw New Exception("Initialization of Discount Repository failed.")
            End If
            Dim discount = discountList.GetDiscount()

            For Each discountItem As DiscountView In discount
                tbDiscount.Text &= discountItem.DiscountRate.ToString() & Environment.NewLine
            Next

        Catch ex As Exception
            MsgBox("An error occured in current discount load: " & ex.Message, MsgBoxStyle.Critical, "Discount")
        End Try
    End Sub

End Class