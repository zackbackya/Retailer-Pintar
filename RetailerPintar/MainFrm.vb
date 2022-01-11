Public Class MainFrm
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    Sub toko()
        Try
            Dim filecontents As String = System.IO.File.ReadAllText(Application.StartupPath.ToString & "\Store.ini")
            Dim lines() As String
            Dim itung As Integer
            filecontents = filecontents.Replace(ControlChars.CrLf, ControlChars.Lf)
            lines = filecontents.Split(New Char() {ControlChars.Lf, ControlChars.Cr})
            itung = 1
            Dim isi As String = lines(itung)

            ToolStripStatusLabel1.Text = isi
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            HomeFrm.MdiParent = Me
            HomeFrm.Dock = DockStyle.Fill
            HomeFrm.Show()
            HomeFrm.Focus()
            toko()
            sbOperator.Text = LoginFrm.txtUsername.Text
            Timer1.Start()

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
        Me.WindowState = FormWindowState.Maximized
        PembelianProdukFrm.MdiParent = Me
        PembelianProdukFrm.Dock = DockStyle.Fill
        PembelianProdukFrm.Show()
        PembelianProdukFrm.Focus()
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

    Private Sub MnuPembelianProduk_Click(sender As Object, e As EventArgs) Handles mnuPembelianProduk.Click
        Me.WindowState = FormWindowState.Maximized
        PembelianProdukFrm.MdiParent = Me
        PembelianProdukFrm.Dock = DockStyle.Fill
        PembelianProdukFrm.Show()
        PembelianProdukFrm.Focus()
    End Sub

    Private Sub MnuPembayaranHutangPembelianProduk_Click(sender As Object, e As EventArgs) Handles mnuPembayaranHutangPembelianProduk.Click
        Me.WindowState = FormWindowState.Maximized
        PembayaranHutangPembelianFrm.MdiParent = Me
        PembayaranHutangPembelianFrm.Dock = DockStyle.Fill
        PembayaranHutangPembelianFrm.Show()
        PembayaranHutangPembelianFrm.Focus()
    End Sub

    Private Sub MnuReturPembelianProduk_Click(sender As Object, e As EventArgs) Handles mnuReturPembelianProduk.Click
        Me.WindowState = FormWindowState.Maximized
        ReturPembelianProdukFrm.MdiParent = Me
        ReturPembelianProdukFrm.Dock = DockStyle.Fill
        ReturPembelianProdukFrm.Show()
        ReturPembelianProdukFrm.Focus()
    End Sub

    Private Sub MnuPengeluaranBiaya_Click(sender As Object, e As EventArgs) Handles mnuPengeluaranBiaya.Click
        Me.WindowState = FormWindowState.Maximized
        PengeluaranBiayaFrm.MdiParent = Me
        PengeluaranBiayaFrm.Dock = DockStyle.Fill
        PengeluaranBiayaFrm.Show()
        PengeluaranBiayaFrm.Focus()
    End Sub

    Private Sub CheckRole()

        If LoginFrm.RoleName = "ADMIN" Then
            'admin role

        ElseIf LoginFrm.RoleName = "SUPERUSER" Then

        End If

    End Sub

    Private Sub tbPenyesuaianStok_Click(sender As Object, e As EventArgs) Handles tbPenyesuaianStok.Click
        Me.WindowState = FormWindowState.Maximized
        PenyesuaianStokFrm.MdiParent = Me
        PenyesuaianStokFrm.Dock = DockStyle.Fill
        PenyesuaianStokFrm.Show()
        PenyesuaianStokFrm.Focus()
    End Sub

    Private Sub PenyesuaianStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenyesuaianStokToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Maximized
        PenyesuaianStokFrm.MdiParent = Me
        PenyesuaianStokFrm.Dock = DockStyle.Fill
        PenyesuaianStokFrm.Show()
        PenyesuaianStokFrm.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sbJam.Text = DateTime.Now.ToString("hh:mm:ss tt")
        sbTanggal.Text = DateString

    End Sub

    Private Sub mnuManajemenOperator_Click(sender As Object, e As EventArgs) Handles mnuManajemenOperator.Click
        Me.WindowState = FormWindowState.Maximized
        ManajemenUserFrm.MdiParent = Me
        ManajemenUserFrm.Dock = DockStyle.Fill
        ManajemenUserFrm.Show()
        ManajemenUserFrm.Focus()
    End Sub

    Private Sub mnuProfilPerusahaan_Click(sender As Object, e As EventArgs) Handles mnuProfilPerusahaan.Click
        ProfilPerusahaanFrm.Show()
    End Sub

    Private Sub mnuPengaturanUmum_Click(sender As Object, e As EventArgs) Handles mnuPengaturanUmum.Click
        PengaturanUmumFrm.Show()

    End Sub

    Private Sub mnuLapPembelian_Click(sender As Object, e As EventArgs) Handles mnuLapPembelian.Click
        BeliProdukFrm.Show()
    End Sub

    Private Sub mnuLapPenjualan_Click(sender As Object, e As EventArgs) Handles mnuLapPenjualan.Click
        PenjualanProdukFrm.Show()
    End Sub

    Private Sub mnuLapStokProduk_Click(sender As Object, e As EventArgs) Handles mnuLapStokProduk.Click
        StokProdukFrm.Show()
    End Sub

    Private Sub mnuLapPenyesuaianStok_Click(sender As Object, e As EventArgs) Handles mnuLapPenyesuaianStok.Click
        SesuaianStokFrm.Show()
    End Sub

    Private Sub mnuLapKartuStokProduk_Click(sender As Object, e As EventArgs) Handles mnuLapKartuStokProduk.Click
        KartuStokFrm.Show()
    End Sub

    Private Sub mnuLapPengeluaranBiaya_Click(sender As Object, e As EventArgs) Handles mnuLapPengeluaranBiaya.Click
        KeluarBiayaFrm.Show()
    End Sub

    Private Sub mnuLapPemasukanPengeluaran_Click(sender As Object, e As EventArgs) Handles mnuLapPemasukanPengeluaran.Click
        MasukKeluarFrm.Show()
    End Sub

    Private Sub TbPromoProduk_Click(sender As Object, e As EventArgs) Handles tbPromoProduk.Click
        Me.WindowState = FormWindowState.Maximized
        PromoFrm.MdiParent = Me
        PromoFrm.Dock = DockStyle.Fill
        PromoFrm.Show()
        PromoFrm.Focus()
    End Sub

    Private Sub TbSupplier_Click(sender As Object, e As EventArgs) Handles tbSupplier.Click
        Me.WindowState = FormWindowState.Maximized
        SupplierFrm.MdiParent = Me
        SupplierFrm.Dock = DockStyle.Fill
        SupplierFrm.Show()
        SupplierFrm.Focus()
    End Sub

    Private Sub TbCustomer_Click(sender As Object, e As EventArgs) Handles tbCustomer.Click
        Me.WindowState = FormWindowState.Maximized
        CustomerFrm.MdiParent = Me
        CustomerFrm.Dock = DockStyle.Fill
        CustomerFrm.Show()
        CustomerFrm.Focus()
    End Sub

    Private Sub TbPengeluaranBiaya_Click(sender As Object, e As EventArgs) Handles tbPengeluaranBiaya.Click
        Me.WindowState = FormWindowState.Maximized
        PengeluaranBiayaFrm.MdiParent = Me
        PengeluaranBiayaFrm.Dock = DockStyle.Fill
        PengeluaranBiayaFrm.Show()
        PengeluaranBiayaFrm.Focus()
    End Sub

    Private Sub TbLapPembelianProduk_Click(sender As Object, e As EventArgs) Handles tbLapPembelianProduk.Click
        BeliProdukFrm.Show()
    End Sub

    Private Sub TbLapPenjualanProduk_Click(sender As Object, e As EventArgs) Handles tbLapPenjualanProduk.Click
        PenjualanProdukFrm.Show()
    End Sub
End Class
