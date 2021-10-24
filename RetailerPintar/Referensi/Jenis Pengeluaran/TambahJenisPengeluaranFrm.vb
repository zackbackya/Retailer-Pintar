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

            MessageBox.Show("Data Berhasil Ditambah", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call JenisPengeluaranFrm.tampilData()
            Call GenTempID()
            txtNamaJenisPengeluaran.Text = ""
            txtNamaJenisPengeluaran.Focus()


        Catch ex As Exception

            MsgBox(ex.ToString)

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


End Class