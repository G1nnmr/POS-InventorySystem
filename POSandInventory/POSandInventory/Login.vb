Imports DomainLayer
Public Class Login
    Public Shared Property Username As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUsername.Focus()
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Username = tbUsername.Text
        Dim user As String = tbUsername.Text.Trim()
        Dim pass As String = tbPassword.Text.Trim()

        If String.IsNullOrEmpty(tbUsername.Text) Then
            MsgBox("Username is required.", MsgBoxStyle.Information)
            ErrorProvider1.SetError(tbUsername, "Please fill out this field")
            tbUsername.Focus()
        ElseIf String.IsNullOrEmpty(tbPassword.Text) Then
            MsgBox("Password is required.!", MsgBoxStyle.Information)
            ErrorProvider1.SetError(tbPassword, "Please fill out this field")
            tbPassword.Focus()
        Else
            ErrorProvider1.SetError(tbUsername, String.Empty)
            ErrorProvider1.SetError(tbPassword, String.Empty)
            Try
                Connect()
                query = "Select * FROM `tbl_profile` WHERE username=@username AND password=@password"

                With command
                    .Connection = conn
                    .CommandText = query
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@username", user)
                    .Parameters.AddWithValue("@password", pass)
                    read = .ExecuteReader()
                End With

                If read.HasRows Then
                    read.Read()
                    Dim accesstype As String = read.GetString("Access_type")

                    If accesstype = "Admin" Then
                        MsgBox("Login Successful as Admin!", vbInformation)
                        Dim inv As New Inventory()
                        inv.Show()
                        Me.Hide()

                    ElseIf accesstype = "Cashier" Then
                        MsgBox("Login Successful as Cashier!", vbInformation)
                        Dim pos As New POS_Cashier()
                        pos.Show()
                        Me.Hide()
                    Else
                    End If

                Else
                    MessageBox.Show("Login failed. Please check your username and password.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub eyeOpen_Click_1(sender As Object, e As EventArgs) Handles eyeOpen.Click
        eyeClose.Visible = True
        eyeOpen.Visible = False
        tbPassword.PasswordChar = "*"

    End Sub

    Private Sub eyeClose_Click_1(sender As Object, e As EventArgs) Handles eyeClose.Click
        eyeOpen.Visible = True
        eyeClose.Visible = False
        tbPassword.PasswordChar = ""
    End Sub


End Class


