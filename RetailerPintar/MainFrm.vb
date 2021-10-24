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
            Me.Dispose()
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
            Me.Dispose()
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
        Me.WindowState = FormWindowState.Maximized
        SupplierFrm.MdiParent = Me
        SupplierFrm.Dock = DockStyle.Fill
        SupplierFrm.Show()
        SupplierFrm.Focus()
    End Sub

    Private Sub mnuCustomer_Click(sender As Object, e As EventArgs) Handles mnuCustomer.Click
        Me.WindowState = FormWindowState.Maximized
        CustomerFrm.MdiParent = Me
        CustomerFrm.Dock = DockStyle.Fill
        CustomerFrm.Show()
        CustomerFrm.Focus()
    End Sub

    Private Sub mnuJenisPengeluaran_Click(sender As Object, e As EventArgs) Handles mnuJenisPengeluaran.Click
        Me.WindowState = FormWindowState.Maximized
        JenisPengeluaranFrm.MdiParent = Me
        JenisPengeluaranFrm.Dock = DockStyle.Fill
        JenisPengeluaranFrm.Show()
        JenisPengeluaranFrm.Focus()
    End Sub

    Private Sub tbPembelianProduk_Click(sender As Object, e As EventArgs) Handles tbPembelianProduk.Click

    End Sub

    Private Sub mnuPromoProduk_Click(sender As Object, e As EventArgs) Handles mnuPromoProduk.Click
        Me.WindowState = FormWindowState.Maximized
        PromoFrm.MdiParent = Me
        PromoFrm.Dock = DockStyle.Fill
        PromoFrm.Show()
        PromoFrm.Focus()
    End Sub

    Private Sub TokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TokoToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
        TokoFrm.MdiParent = Me
        TokoFrm.Dock = DockStyle.Fill
        TokoFrm.Show()
        TokoFrm.Focus()
    End Sub

    Private Sub mnuPenyesuaianStok_Click(sender As Object, e As EventArgs) Handles mnuPenyesuaianStok.Click
        Me.WindowState = FormWindowState.Maximized
        PenyesuaianStokFrm.MdiParent = Me
        PenyesuaianStokFrm.Dock = DockStyle.Fill
        PenyesuaianStokFrm.Show()
        PenyesuaianStokFrm.Focus()
    End Sub
End Class
