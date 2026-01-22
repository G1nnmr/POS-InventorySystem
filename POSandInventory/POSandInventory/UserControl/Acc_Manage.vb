Imports MySql.Data.MySqlClient
Imports DomainLayer
Imports Mysqlx

Public Class Acc_Manage

    Private selectedEmployeeId As Integer
    Private queryemployee As String

    Private Sub GetAllEmployee()
        Try
            Connect()
            query = "SELECT * FROM `tbl_account`"

            With command
                .Connection = conn
                .CommandText = query
                read = .ExecuteReader()
                DGVPersonalInfo.Rows.Clear()
            End With

            If DGVPersonalInfo.Columns.Contains("Birthdate") Then
                DGVPersonalInfo.Columns("Birthdate").DefaultCellStyle.Format = "yyyy-MM-dd"
            End If
            While read.Read()
                DGVPersonalInfo.Rows.Add(
                    read("Id"),
                    read("Name"),
                    read("Age"),
                    read("Birthdate"),
                    read("Gender"),
                    read("Email"),
                    read("Phone"),
                    read("Access_type"),
                    read("Salary"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If read IsNot Nothing Then read.Close()
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Private Sub SearchEmployee(searchQuery As String)
        Try
            Connect()
            queryemployee = "SELECT * FROM `tbl_account` WHERE `Name` LIKE @Search OR `Email` LIKE @Search"

            command = New MySqlCommand(queryemployee, conn)
            command.Parameters.AddWithValue("@Search", "%" & searchQuery & "%")
            read = command.ExecuteReader()

            DGVPersonalInfo.Rows.Clear()
            If DGVPersonalInfo.Columns.Contains("Birthdate") Then
                DGVPersonalInfo.Columns("Birthdate").DefaultCellStyle.Format = "yyyy-MM-dd"
            End If
            While read.Read()
                DGVPersonalInfo.Rows.Add(
                    read("Id"),
                    read("Name"),
                    read("Age"),
                    read("Birthdate"),
                    read("Gender"),
                    read("Email"),
                    read("Phone"),
                    read("Access_type"),
                    read("Salary"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If read IsNot Nothing Then read.Close()
            If conn IsNot Nothing Then conn.Close()
        End Try
    End Sub

    Private Sub btnClearTB_Click(sender As Object, e As EventArgs) Handles btnClearTB.Click
        tbName.Clear()
        tbAge.Clear()
        mtbPhone.Clear()
        tbEmail.Clear()
        tbSalary.Clear()
        rbAdmin.Checked = False

        rbCashier.Checked = False
        dtpBirthdate.Value = DateTime.Now
        selectedEmployeeId = 0
    End Sub

    Private Sub InitializeDataGridView()
        ' Set DataGridView properties for better layout and appearance
        DGVPersonalInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVPersonalInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGVPersonalInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVPersonalInfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DGVPersonalInfo.AllowUserToAddRows = False
        DGVPersonalInfo.AllowUserToDeleteRows = False
        DGVPersonalInfo.ReadOnly = True
        DGVPersonalInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGVPersonalInfo.MultiSelect = False
    End Sub
    Private Sub Acc_Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbName.Focus()
        Me.Dock = DockStyle.Fill

        dtpBirthdate.Format = DateTimePickerFormat.Custom
        dtpBirthdate.CustomFormat = "yyyy-MM-dd"

        InitializeDataGridView()

        Me.mtbPhone.MaxLength = 10
        AddHandler DGVPersonalInfo.CellClick, AddressOf DGVPersonalInfo_CellClick

        If Not DGVPersonalInfo.Columns.Contains("Id") Then
            DGVPersonalInfo.Columns.Add("Id", "Id")
            DGVPersonalInfo.Columns("Id").Visible = False
        End If
        GetAllEmployee()
    End Sub

    Private Sub DGVPersonalInfo_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGVPersonalInfo.Rows(e.RowIndex)

            selectedEmployeeId = Convert.ToInt32(row.Cells("Id").Value)

            tbName.Text = If(row.Cells("Employee_Name").Value IsNot Nothing, row.Cells("Employee_Name").Value.ToString(), "")
            tbAge.Text = If(row.Cells("Age").Value IsNot Nothing, row.Cells("Age").Value.ToString(), "")
            tbEmail.Text = If(row.Cells("Email").Value IsNot Nothing, row.Cells("Email").Value.ToString(), "")
            tbSalary.Text = If(row.Cells("Salary").Value IsNot Nothing, row.Cells("Salary").Value.ToString(), "")
            cbGender.SelectedItem = If(row.Cells("Gender").Value IsNot Nothing, row.Cells("Gender").Value.ToString(), Nothing)

            Dim Access_type As String = If(row.Cells("Access_type").Value IsNot Nothing, row.Cells("Access_type").Value.ToString(), "")
            Select Case Access_type
                Case "Admin"
                    rbAdmin.Checked = True
                Case "Cashier"
                    rbCashier.Checked = True
                Case Else
                    rbAdmin.Checked = False
                    rbCashier.Checked = False
            End Select

            ' Handle the Phone Number MaskedTextBox
            If row.Cells("Phone").Value IsNot Nothing Then
                mtbPhone.Text = row.Cells("Phone").Value.ToString()
            Else
                mtbPhone.Clear()
            End If

            ' Handle the DateTimePicker
            If row.Cells("Birthdate").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("Birthdate").Value) Then
                Dim dateValue As DateTime
                If DateTime.TryParse(row.Cells("Birthdate").Value.ToString(), dateValue) Then
                    dtpBirthdate.Value = dateValue
                    dtpBirthdate.Text = dtpBirthdate.Value.ToShortDateString()
                Else
                    MessageBox.Show("Failed to parse date value: " & row.Cells("Birthdate").Value.ToString())
                    dtpBirthdate.Value = DateTime.Now
                    dtpBirthdate.Text = dtpBirthdate.Value.ToShortDateString()
                End If
            Else
                dtpBirthdate.Value = DateTime.Now
                dtpBirthdate.Text = dtpBirthdate.Value.ToShortDateString()
            End If
        End If
    End Sub

    Private Sub btnAddAcc_Click(sender As Object, e As EventArgs) Handles btnAddAcc.Click
        Try
            Connect()
            query = "INSERT INTO tbl_account (Name, Age, Phone, Email, Salary, Gender, Access_type, Birthdate) 
                    VALUES (@Name, @Age, @Phone, @Email, @Salary, @Gender, @Access_type, @Birthdate)"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@Name", tbName.Text.Trim)
                .Parameters.AddWithValue("@Age", tbAge.Text.Trim)
                .Parameters.AddWithValue("@Phone", mtbPhone.Text.Trim)
                .Parameters.AddWithValue("@Email", tbEmail.Text.Trim)
                .Parameters.AddWithValue("@Salary", tbSalary.Text.Trim)

                If cbGender.SelectedItem IsNot Nothing Then
                    .Parameters.AddWithValue("@Gender", cbGender.SelectedItem.ToString())
                Else
                    MsgBox("Please select a Gender.")
                    Exit Sub
                End If
                .Parameters.AddWithValue("@Access_type", GetSelectedAccess_type())
                .Parameters.AddWithValue("@Birthdate", dtpBirthdate.Value.ToString("yyyy-MM-dd"))
                command.ExecuteNonQuery()
            End With

            MsgBox("User created successfully.")

        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message)
        Catch ex As Exception
            MsgBox("General error: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
            GetAllEmployee()
        End Try
    End Sub

    Private Sub btnDeleteAcc_Click(sender As Object, e As EventArgs) Handles btnDeleteAcc.Click
        Try
            Connect()
            query = "DELETE FROM `tbl_account` WHERE Id=@Id"

            With command
                .Connection = conn
                .CommandText = query
                .Parameters.Clear()
                .Parameters.AddWithValue("@Id", selectedEmployeeId)
                .ExecuteNonQuery()
            End With

            Dim msgLog As Integer
            msgLog = MessageBox.Show("Are you sure you want to delete this user?", "Manage User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msgLog = vbYes Then
                MsgBox("Employee deleted successfully.")
            End If

        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message)
        Catch ex As Exception
            MsgBox("General error: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
            GetAllEmployee()
        End Try
    End Sub

    Private Sub btnUpdateAcc_Click(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        Try
            Connect()

            If selectedEmployeeId <= 0 Then
                MsgBox("Please select a user to update.")
                Exit Sub
            End If

            Dim updates As New List(Of String)
            Dim parameters As New List(Of MySqlParameter)

            If Not String.IsNullOrEmpty(tbName.Text.Trim) Then
                updates.Add("Name = @Name")
                parameters.Add(New MySqlParameter("@Name", tbName.Text.Trim))
            End If
            If Not String.IsNullOrEmpty(tbAge.Text.Trim) Then
                updates.Add("Age = @Age")
                parameters.Add(New MySqlParameter("@Age", tbAge.Text.Trim))
            End If
            If cbGender.SelectedItem IsNot Nothing Then
                updates.Add("Gender = @Gender")
                parameters.Add(New MySqlParameter("@Gender", cbGender.SelectedItem.ToString()))
            End If
            If Not String.IsNullOrEmpty(mtbPhone.Text.Trim) Then
                updates.Add("Phone = @Phone")
                parameters.Add(New MySqlParameter("@Phone", mtbPhone.Text.Trim))
            End If
            If Not String.IsNullOrEmpty(tbEmail.Text.Trim) Then
                updates.Add("Email = @Email")
                parameters.Add(New MySqlParameter("@Email", tbEmail.Text.Trim))
            End If
            If Not String.IsNullOrEmpty(tbSalary.Text.Trim) Then
                updates.Add("Salary = @Salary")
                parameters.Add(New MySqlParameter("@Salary", tbSalary.Text.Trim))
            End If

            ' Update the Access_type based on selected radio button
            updates.Add("Access_type = @Access_type")
            parameters.Add(New MySqlParameter("@Access_type", GetSelectedAccess_type()))

            ' Update the Birthdate
            updates.Add("Birthdate = @birthdate")
            parameters.Add(New MySqlParameter("@birthdate", dtpBirthdate.Value.ToString("yyyy-MM-dd")))

            If updates.Count = 0 Then
                MsgBox("No changes detected.")
                Exit Sub
            End If

            Dim queryemployee As String = $"UPDATE `tbl_account` SET {String.Join(", ", updates)} WHERE `Id`=@Id"
            parameters.Add(New MySqlParameter("@Id", selectedEmployeeId))

            command = New MySqlCommand(queryemployee, conn)
            command.Parameters.AddRange(parameters.ToArray())
            command.ExecuteNonQuery()

            MsgBox("User updated successfully.")

        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message)
        Catch ex As Exception
            MsgBox("General error: " & ex.Message)
        Finally
            If conn IsNot Nothing Then conn.Close()
            GetAllEmployee()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchQuery As String = tbSearch.Text.Trim()
        SearchEmployee(searchQuery)
    End Sub

    Private Function GetSelectedAccess_type() As String
        If rbAdmin.Checked Then
            Return "Admin"
        ElseIf rbCashier.Checked Then
            Return "Cashier"
        Else
            Return String.Empty
        End If
    End Function

End Class