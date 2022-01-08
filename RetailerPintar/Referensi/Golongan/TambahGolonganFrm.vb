Public Class TambahGolonganFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub tambahData()
        Call koneksi()
        Try

            str = "insert into ms_golongan values ('" & txtIdGolongan.Text & "','" & txtNamaGolongan.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil ditambah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call GolonganFrm.tampilData()
            Call GenTempID()
            txtNamaGolongan.Text = ""
            txtNamaGolongan.Focus()


        Catch ex As Exception

            MessageBox.Show("Tambah data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub TambahGolonganFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaGolongan.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub TambahGolonganFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdGolongan.Text = "GO-" + idjam
    End Sub

    Private Sub txtNamaGolongan_GotFocus(sender As Object, e As EventArgs) Handles txtNamaGolongan.GotFocus
        txtNamaGolongan.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaGolongan_LostFocus(sender As Object, e As EventArgs) Handles txtNamaGolongan.LostFocus
        txtNamaGolongan.BackColor = Color.White
    End Sub

End Class