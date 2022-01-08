Public Class EditTokoFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Call editToko()

    End Sub

    Private Sub editToko()
        Call koneksi()
        Try

            cmd = New MySqlConnector.MySqlCommand("update ms_Toko set nama_toko = '" & txtNamaToko.Text & "', alamat = '" & txtAlamatToko.Text & "', kota = '" & txtKotaToko.Text & "', tgl_buka = '" & Format(dtTanggalBuka.Value, "yyyy-MM-dd") & "', telepon = '" & txtTeleponToko.Text & "' where id_toko  = '" & txtIdToko.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TokoFrm.tampilData()

        Catch ex As Exception

            MessageBox.Show("Update data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub EditTokoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        txtIdToko.Text = TokoFrm.id_Toko
        txtNamaToko.Text = TokoFrm.nama_Toko
        txtAlamatToko.Text = TokoFrm.alamat_Toko
        txtKotaToko.Text = TokoFrm.kota_toko
        dtTanggalBuka.Value = TokoFrm.tanggal_buka_toko
        txtTeleponToko.Text = TokoFrm.telepon_Toko

        txtNamaToko.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub EditTokoFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call editToko()
        End If

    End Sub

    Private Sub txtAlamatToko_GotFocus(sender As Object, e As EventArgs) Handles txtAlamatToko.GotFocus
        txtAlamatToko.BackColor = Color.LightYellow
    End Sub

    Private Sub txtAlamatToko_LostFocus(sender As Object, e As EventArgs) Handles txtAlamatToko.LostFocus
        txtAlamatToko.BackColor = Color.White
    End Sub

    Private Sub txtKotaToko_GotFocus(sender As Object, e As EventArgs) Handles txtKotaToko.GotFocus
        txtKotaToko.BackColor = Color.LightYellow
    End Sub

    Private Sub txtKotaToko_LostFocus(sender As Object, e As EventArgs) Handles txtKotaToko.LostFocus
        txtKotaToko.BackColor = Color.White
    End Sub

    Private Sub txtNamaToko_GotFocus(sender As Object, e As EventArgs) Handles txtNamaToko.GotFocus
        txtNamaToko.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaToko_LostFocus(sender As Object, e As EventArgs) Handles txtNamaToko.LostFocus
        txtNamaToko.BackColor = Color.White
    End Sub

    Private Sub txtTeleponToko_GotFocus(sender As Object, e As EventArgs) Handles txtTeleponToko.GotFocus
        txtTeleponToko.BackColor = Color.LightYellow
    End Sub

    Private Sub txtTeleponToko_LostFocus(sender As Object, e As EventArgs) Handles txtTeleponToko.LostFocus
        txtTeleponToko.BackColor = Color.White
    End Sub
End Class