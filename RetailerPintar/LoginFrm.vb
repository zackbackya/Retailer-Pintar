Public Class LoginFrm

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsername.Select()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        MainFrm.Show()
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        txtUsername.BackColor = Color.LightYellow
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        txtUsername.BackColor = Color.White
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.BackColor = Color.LightYellow
    End Sub

    Private Sub txtPassword_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        txtPassword.BackColor = Color.White
    End Sub

    Private Sub txtServer_GotFocus(sender As Object, e As EventArgs) Handles txtServer.GotFocus
        txtServer.BackColor = Color.LightYellow
    End Sub

    Private Sub txtServer_LostFocus(sender As Object, e As EventArgs) Handles txtServer.LostFocus
        txtServer.BackColor = Color.White
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class
