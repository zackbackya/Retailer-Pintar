Imports MySqlConnector

Public Class TambahPenyesuaianStokFrm

    Private Sub toko()
        Try
            Call koneksi()
            cmd = New MySqlCommand("select id_toko,nama_toko from ms_toko where id_toko = '" & MainFrm.ToolStripStatusLabel1.Text & "'", conn)
            rd_1 = cmd.ExecuteReader
            rd_1.Read()
            txtIdToko.Text = rd_1.Item(0)
            txtNamaToko.Text = rd_1.Item(1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tambahData()
        Try
            'Dim tanggal_buka_PenyesuaianStok As String = Format(dtTanggal.Value, "yyyy-MM-dd")
            Call koneksi()
            str = "insert into tx_penyesuaian_stok values ('" & txtFaktur.Text & "','" & txtIdToko.Text & "', '" & txtIdProduk.Text & "','" & txtNamaProduk.Text & "','" & Format(dtTanggal.Value, "yyyy-MM-dd") & "','" & txtQty.Text & "','" & txtAlasan.Text & "','" & txtKeterangan.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Ditambah", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call PenyesuaianStokFrm.tampilData()
            Call GenTempID()

            txtNamaProduk.Text = ""
            txtIdProduk.Text = ""
            txtStokSkg.Text = ""
            txtQty.Text = ""
            txtAlasan.Text = ""
            txtKeterangan.Text = ""
            txtNamaProduk.Focus()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TambahPenyesuaianStokFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call toko()
        Call GenTempID()
        txtNamaProduk.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub TambahPenyesuaianStokFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtFaktur.Text = "ST-" + idjam
    End Sub

    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub btnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub txtNamaProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaProduk.KeyPress
        Try
            If (e.KeyChar = Chr(13)) Then
                Call koneksi()
                cmd = New MySqlCommand("select count(*) from ms_produk where (id_produk like '%" & txtNamaProduk.Text & "%' or nama_produk like '%" & txtNamaProduk.Text & "%')", conn)
                rd_1 = cmd.ExecuteReader
                rd_1.Read()
                If 1 < rd_1.Item(0) Then
                    AmbilProdukPenyesuaianStokFrm.ShowDialog()
                Else
                    Call koneksi()
                    cmd = New MySqlCommand("select id_produk,nama_produk,stok from ms_produk where (id_produk like '%" & txtNamaProduk.Text & "%' or nama_produk like '%" & txtNamaProduk.Text & "%')", conn)
                    rd_1 = cmd.ExecuteReader
                    rd_1.Read()
                    txtNamaProduk.Text = rd_1.Item(1)
                    txtIdProduk.Text = rd_1.Item(0)
                    txtStokSkg.Text = rd_1.Item(2)
                    txtNamaProduk.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Data produk tidak ditemukan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaProduk.Text = ""
            txtNamaProduk.Select()
        End Try
    End Sub

    Private Sub txtAlasan_GotFocus(sender As Object, e As EventArgs) Handles txtAlasan.GotFocus
        txtAlasan.BackColor = Color.LightYellow
    End Sub

    Private Sub txtAlasan_LostFocus(sender As Object, e As EventArgs) Handles txtAlasan.LostFocus
        txtAlasan.BackColor = Color.White
    End Sub

    Private Sub txtFaktur_GotFocus(sender As Object, e As EventArgs) Handles txtFaktur.GotFocus
        txtFaktur.BackColor = Color.LightYellow
    End Sub

    Private Sub txtFaktur_LostFocus(sender As Object, e As EventArgs) Handles txtFaktur.LostFocus
        txtFaktur.BackColor = Color.White
    End Sub

    Private Sub txtKeterangan_GotFocus(sender As Object, e As EventArgs) Handles txtKeterangan.GotFocus
        txtKeterangan.BackColor = Color.LightYellow
    End Sub

    Private Sub txtKeterangan_LostFocus(sender As Object, e As EventArgs) Handles txtKeterangan.LostFocus
        txtKeterangan.BackColor = Color.White
    End Sub

    Private Sub txtNamaProduk_GotFocus(sender As Object, e As EventArgs) Handles txtNamaProduk.GotFocus
        txtNamaProduk.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaProduk_LostFocus(sender As Object, e As EventArgs) Handles txtNamaProduk.LostFocus
        txtNamaProduk.BackColor = Color.White
    End Sub

    Private Sub txtQty_GotFocus(sender As Object, e As EventArgs) Handles txtQty.GotFocus
        txtQty.BackColor = Color.LightYellow
    End Sub

    Private Sub txtQty_LostFocus(sender As Object, e As EventArgs) Handles txtQty.LostFocus
        txtQty.BackColor = Color.White
    End Sub

    Private Sub txtStokSkg_GotFocus(sender As Object, e As EventArgs) Handles txtStokSkg.GotFocus
        txtStokSkg.BackColor = Color.LightYellow
    End Sub

    Private Sub txtStokSkg_LostFocus(sender As Object, e As EventArgs) Handles txtStokSkg.LostFocus
        txtStokSkg.BackColor = Color.White
    End Sub

End Class