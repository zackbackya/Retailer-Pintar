Public Class MainFrm
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            HomeFrm.MdiParent = Me
            HomeFrm.Dock = DockStyle.Fill
            HomeFrm.Show()
            HomeFrm.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MnuGantiUser_Click(sender As Object, e As EventArgs) Handles mnuGantiUser.Click
        Dim quit As String = MessageBox.Show("Apakah proses ingin dilanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quit = DialogResult.Yes Then
            Me.Close()
            LoginFrm.Show()
            LoginFrm.txtUsername.Text = ""
            LoginFrm.txtPassword.Text = ""
            LoginFrm.txtServer.Text = ""
            LoginFrm.txtUsername.Select()
        ElseIf quit = DialogResult.No Then

        End If
    End Sub

    Private Sub MnuKeluarDariProgram_Click(sender As Object, e As EventArgs) Handles mnuKeluarDariProgram.Click
        Dim quit As String = MessageBox.Show("Apakah proses ingin dilanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quit = DialogResult.Yes Then
            Me.Close()
            LoginFrm.Close()
        ElseIf quit = DialogResult.No Then

        End If
    End Sub
End Class
