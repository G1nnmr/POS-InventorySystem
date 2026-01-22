Imports System.Diagnostics.Eventing
Imports DomainLayer
Imports MySql.Data.MySqlClient

Public Class ManageProfile

    Private Sub GetData()
        Try
            Connect()
            query = "SELECT * FROM `tbl_profile`"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()
            End With

            While read.Read()
                Dim id As Integer = read("Id")
                Dim accessType As String = read("Access_type").ToString()
                Dim username As String = read("Username").ToString()
                Dim password As String = read("Password").ToString()
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If read IsNot Nothing Then read.Close()
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub SearchEmployee(searchId As String)
        Try
            Connect()
            query = "SELECT * FROM `tbl_profile` WHERE `Id` = @Id"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@Id", searchId)
                read = .ExecuteReader()
            End With

            If read.Read() Then
                tbMUsername.Text = read("Username").ToString()
                tbMPassword.Text = read("Password").ToString()
                cbMAccessType.Text = read("Access_type").ToString()
            Else
                MsgBox("No records found.")
                tbMConfirmPassword.Clear()
                tbMPassword.Clear()
                tbMUsername.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If read IsNot Nothing Then read.Close()
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnMSave.Click
        Try

            If String.IsNullOrEmpty(tbMUsername.Text.Trim()) Then
                MsgBox("Username cannot be empty.", MsgBoxStyle.Information)
                tbMUsername.Focus()
                Return
            End If

            If String.IsNullOrEmpty(tbMPassword.Text.Trim()) Then
                MsgBox("Please put a password!", MsgBoxStyle.Information)
                tbMPassword.Focus()
                Return
            End If

            If String.IsNullOrEmpty(tbMConfirmPassword.Text.Trim()) Then
                MsgBox("Please confirm your password!", MsgBoxStyle.Information)
                tbMConfirmPassword.Focus()
                Return
            End If

            If tbMPassword.Text.Trim() <> tbMConfirmPassword.Text.Trim() Then
                MsgBox("Passwords do not match.", MsgBoxStyle.Information)
                Return
            End If

            Connect()
            query = "INSERT INTO `tbl_profile`(`Access_type`, `Username`, `Password`) VALUES (@AccessType, @Username, @Password)"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@AccessType", cbMAccessType.Text.Trim())
                .Parameters.AddWithValue("@Username", tbMUsername.Text.Trim())
                .Parameters.AddWithValue("@Password", tbMPassword.Text.Trim())

                .ExecuteNonQuery()
            End With

            MsgBox("Data created successfully!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
            GetData()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnMDelete.Click
        Try

            If String.IsNullOrEmpty(tbMSearch.Text.Trim()) Then
                MsgBox("Please enter a valid Id to delete.")
                Exit Sub
            End If

            Connect()

            'This part of the program is to check if the data exists in the database
            query = "SELECT COUNT(*) FROM `tbl_profile` WHERE Id=@Id"

            Dim recordCount As Integer
            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@Id", tbMSearch.Text.Trim())
                recordCount = Convert.ToInt32(command.ExecuteScalar())
            End With

            If recordCount = 0 Then
                MsgBox("No records found with the specified Id.")
                Exit Sub
            End If

            'If it does exist, then proceed with deleting it
            query = "DELETE FROM `tbl_profile` WHERE Id=@Id"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@Id", tbMSearch.Text.Trim())

                .ExecuteNonQuery()
            End With

            MsgBox("Employee deleted successfully.")
            tbMUsername.Clear()
            tbMPassword.Clear()
            tbMConfirmPassword.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
            GetData()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnMUpdate.Click
        Try
            If String.IsNullOrEmpty(tbMUsername.Text.Trim()) Then
                MsgBox("Username cannot be empty.", MsgBoxStyle.Information)
                tbMUsername.Focus()
                Return
            End If

            If String.IsNullOrEmpty(tbMPassword.Text.Trim()) Then
                MsgBox("Please put a password!", MsgBoxStyle.Information)
                tbMPassword.Focus()
                Return
            End If

            If String.IsNullOrEmpty(tbMConfirmPassword.Text.Trim()) Then
                MsgBox("Please confirm your password!", MsgBoxStyle.Information)
                tbMConfirmPassword.Focus()
                Return
            End If

            If tbMPassword.Text.Trim() <> tbMConfirmPassword.Text.Trim() Then
                MsgBox("Passwords do not match.", MsgBoxStyle.Information)
                Return
            End If

            Connect()

            If String.IsNullOrEmpty(tbMSearch.Text.Trim()) Then
                MsgBox("Please select an employee to update.")
                Exit Sub
            End If

            'This is to check if the data exists in the database
            Dim checkQuery As String = "SELECT COUNT(*) FROM `tbl_profile` WHERE Id = @Id"
            Dim checkCommand As New MySqlCommand(checkQuery, conn)
            checkCommand.Parameters.AddWithValue("@Id", tbMSearch.Text.Trim())

            Dim recordCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

            If recordCount = 0 Then
                MsgBox("No record available.")
                Exit Sub
            End If

            Dim updates As New List(Of String)
            Dim parameters As New List(Of MySqlParameter)

            If Not String.IsNullOrEmpty(tbMUsername.Text.Trim()) Then
                updates.Add("Username = @Username")
                parameters.Add(New MySqlParameter("@Username", tbMUsername.Text.Trim()))
            End If
            If Not String.IsNullOrEmpty(tbMPassword.Text.Trim()) Then
                updates.Add("Password = @Password")
                parameters.Add(New MySqlParameter("@Password", tbMPassword.Text.Trim()))
            End If
            If Not String.IsNullOrEmpty(cbMAccessType.Text.Trim()) Then
                updates.Add("Access_type = @AccessType")
                parameters.Add(New MySqlParameter("@AccessType", cbMAccessType.Text.Trim()))
            End If

            If updates.Count = 0 Then
                MsgBox("No changes detected.")
                Exit Sub
            End If

            query = "UPDATE `tbl_profile` SET " & String.Join(", ", updates) & " WHERE Id = @Id"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddRange(parameters.ToArray())
                .Parameters.AddWithValue("@Id", tbMSearch.Text.Trim())

                .ExecuteNonQuery()
            End With
            MsgBox("Employee updated successfully.")

        Catch ex As MySqlException
            MsgBox("Database error in btnUpdate: " & ex.Message)

        Finally
            conn.Close()
            GetData()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchId As String = tbMSearch.Text.Trim()
        SearchEmployee(searchId)
    End Sub
    Private Function GetSelectedAccess_type() As String
        Return cbMAccessType.Text
    End Function

    Private Sub eyeOpen_Click(sender As Object, e As EventArgs) Handles eyeOpen.Click
        eyeClose.Visible = True
        eyeOpen.Visible = False
        tbMPassword.PasswordChar = "*"

    End Sub

    Private Sub eyeClose_Click(sender As Object, e As EventArgs) Handles eyeClose.Click
        eyeOpen.Visible = True
        eyeClose.Visible = False
        tbMPassword.PasswordChar = ""

    End Sub

    Private Sub eyeOpen1_Click(sender As Object, e As EventArgs) Handles eyeOpen1.Click
        eyeClose1.Visible = True
        eyeOpen1.Visible = False
        tbMConfirmPassword.PasswordChar = "*"
    End Sub
    Private Sub eyeClose1_Click(sender As Object, e As EventArgs) Handles eyeClose1.Click
        eyeOpen1.Visible = True
        eyeClose1.Visible = False
        tbMConfirmPassword.PasswordChar = ""
    End Sub

    Private Sub llblBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblBack.LinkClicked
        Me.Close()
    End Sub

End Class