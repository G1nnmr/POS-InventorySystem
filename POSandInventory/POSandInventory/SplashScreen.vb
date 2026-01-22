Public Class SplashScreen

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblReportProgress.Text = pbLoading.Value & "%"

        pbLoading.Value += 2

        If pbLoading.Value > 30 Then
            LblStatusText.Text = "Loading.... Please wait"

        End If

        If pbLoading.Value > 50 Then
            LblStatusText.Text = "Loading resources...."

        End If
        If pbLoading.Value > 70 Then
            LblStatusText.Text = "Fetching databases...."

        End If
        If pbLoading.Value > 97 Then
            LblReportProgress.Text = "100%"
        End If
        If pbLoading.Value = 100 Then

            Timer1.Stop()
            Dim login As New Login
            login.Show()
            Me.Hide()
        End If
        If pbLoading.Value = 105 Then

        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Timer1.Start()
        Me.CenterToScreen()

    End Sub

End Class