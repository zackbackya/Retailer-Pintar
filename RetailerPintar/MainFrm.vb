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

    Private Sub mnuKartu_Click(sender As Object, e As EventArgs) Handles mnuKartu.Click
        Me.WindowState = FormWindowState.Maximized
        KartuFrm.MdiParent = Me
        KartuFrm.Dock = DockStyle.Fill
        KartuFrm.Show()
        KartuFrm.Focus()
    End Sub

    Private Sub mnuGolongan_Click(sender As Object, e As EventArgs) Handles mnuGolongan.Click
        Me.WindowState = FormWindowState.Maximized
        GolonganFrm.MdiParent = Me
        GolonganFrm.Dock = DockStyle.Fill
        GolonganFrm.Show()
        GolonganFrm.Focus()
    End Sub

    Private Sub mnuProduk_Click(sender As Object, e As EventArgs) Handles mnuProduk.Click
        Me.WindowState = FormWindowState.Maximized
        ProdukFrm.MdiParent = Me
        ProdukFrm.Dock = DockStyle.Fill
        ProdukFrm.Show()
        ProdukFrm.Focus()
    End Sub

    Private Sub tbProduk_Click(sender As Object, e As EventArgs) Handles tbProduk.Click
        Me.WindowState = FormWindowState.Maximized
        ProdukFrm.MdiParent = Me
        ProdukFrm.Dock = DockStyle.Fill
        ProdukFrm.Show()
        ProdukFrm.Focus()
    End Sub

    Private Sub tbGolongan_Click(sender As Object, e As EventArgs) Handles tbGolongan.Click
        Me.WindowState = FormWindowState.Maximized
        GolonganFrm.MdiParent = Me
        GolonganFrm.Dock = DockStyle.Fill
        GolonganFrm.Show()
        GolonganFrm.Focus()
    End Sub

    Private Sub mnuSupplier_Click(sender As Object, e As EventArgs) Handles mnuSupplier.Click

    End Sub
End Class
