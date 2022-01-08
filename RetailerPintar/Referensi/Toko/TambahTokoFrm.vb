Public Class TambahTokoFrm


    Private Sub tambahData()
        Call koneksi()
        Try

            Dim tanggal_buka_toko As String

            tanggal_buka_toko = Format(dtTanggalBuka.Value, "yyyy-MM-dd")

            str = "insert into ms_Toko values ('" & txtIdToko.Text & "','" & txtNamaToko.Text & "','" & txtAlamatToko.Text & "','" & txtKotaToko.Text & "','" & Format(dtTanggalBuka.Value, "yyyy-MM-dd") & "','" & txtTeleponToko.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil ditambah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call TokoFrm.tampilData()
            Call GenTempID()

            txtNamaToko.Text = ""
            txtAlamatToko.Text = ""
            txtTeleponToko.Text = ""
            txtNamaToko.Focus()

        Catch ex As Exception

            MessageBox.Show("Tambah data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub TambahTokoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaToko.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub TambahTokoFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdToko.Text = "K" + idjam
    End Sub


    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()

        'MsgBox(Format(dtTanggalBuka.Value, "yyyy-MM-dd"))
    End Sub

    Private Sub btnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
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