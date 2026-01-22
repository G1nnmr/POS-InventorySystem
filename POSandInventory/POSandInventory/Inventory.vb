
Imports DomainLayer
Imports InsfrastructureLayer
Imports ServiceLayer

Public Class Inventory

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelAccount.Visible = False
        PanelProduct.Visible = False
        Guna2ShadowForm1.SetShadowForm(Me)
        lblAdmin.Text = Login.Username
    End Sub
    Sub childform(ByVal panel As Form)
        PanelTop.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        PanelTop.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        PanelAccount.Visible = Not PanelAccount.Visible
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        PanelProduct.Visible = Not PanelProduct.Visible
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim msgLog As Integer
        msgLog = MessageBox.Show("Are you sure you want to log out?", "Log out confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgLog = vbYes Then

            For Each form As Form In Application.OpenForms
                If TypeOf form Is Login Then
                    Continue For
                End If
                form.Hide()
            Next
            Dim login As New Login()
            login.Show()
        End If

    End Sub

    Private Sub addUserControl(UserControl)
        UserControl.Dock = DockStyle.Fill
        PanelMain.Controls.Clear()
        PanelMain.Controls.Add(UserControl)
        UserControl.BringToFront()
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnOverview.Click
        Dim ov As New Overview()
        addUserControl(ov)
    End Sub
    Private Sub btnManageAcc_Click(sender As Object, e As EventArgs) Handles btnManageAcc.Click
        Dim mngAcc As New Acc_Manage()
        addUserControl(mngAcc)
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim privacy As New Profile()
        addUserControl(privacy)
    End Sub

    Private Sub btnMngProduct_Click(sender As Object, e As EventArgs) Handles btnMngProduct.Click
        Dim mngProd As New Prod_Manage()
        addUserControl(mngProd)
    End Sub

    Private Sub btnListofItems_Click(sender As Object, e As EventArgs) Handles btnListofItems.Click
        Dim ListView As New Prod_ListofItems()
        addUserControl(ListView)
    End Sub

    Private Sub btnTransact_Click(sender As Object, e As EventArgs) Handles btnTransact.Click
        Dim transact As New Transactions()
        addUserControl(transact)
    End Sub
End Class