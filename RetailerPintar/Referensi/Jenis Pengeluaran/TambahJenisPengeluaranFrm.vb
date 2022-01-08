Public Class TambahJenisPengeluaranFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub tambahData()
        Call koneksi()
        Try

            str = "insert into ms_Jenis_Pengeluaran values ('" & txtIdJenisPengeluaran.Text & "','" & txtNamaJenisPengeluaran.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil ditambah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call JenisPengeluaranFrm.tampilData()
            Call GenTempID()
            txtNamaJenisPengeluaran.Text = ""
            txtNamaJenisPengeluaran.Focus()


        Catch ex As Exception

            MessageBox.Show("Tambah data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub TambahJenisPengeluaranFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaJenisPengeluaran.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub TambahJenisPengeluaranFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdJenisPengeluaran.Text = "O-" + idjam
    End Sub

    Private Sub txtNamaGolongan_GotFocus(sender As Object, e As EventArgs) Handles txtNamaJenisPengeluaran.GotFocus
        txtNamaJenisPengeluaran.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaGolongan_LostFocus(sender As Object, e As EventArgs) Handles txtNamaJenisPengeluaran.LostFocus
        txtNamaJenisPengeluaran.BackColor = Color.White
    End Sub
End Class