
Imports DomainLayer

Public Class Profile

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            Connect()
            query = "SELECT * FROM `tbl_profile`"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                read = .ExecuteReader()
            End With

            DGVPrivacy.Rows.Clear()

            While read.Read()
                DGVPrivacy.Rows.Add(
                    read("Id"),
                    read("Username"),
                    read("Password"),
                    read("Access_type"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If read IsNot Nothing Then read.Close()
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ManageProfile.Show()
    End Sub
End Class
