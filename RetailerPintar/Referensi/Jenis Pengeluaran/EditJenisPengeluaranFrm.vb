Public Class EditJenisPengeluaranFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Call editJenisPengeluaran()

    End Sub

    Private Sub editJenisPengeluaran()
        Call koneksi()
        Try

            cmd = New MySqlConnector.MySqlCommand("update ms_Jenis_Pengeluaran set Jenis_Pengeluaran = '" & txtNamaJenisPengeluaran.Text & "' where id_Jenis_Pengeluaran = '" & txtIdJenisPengeluaran.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Diupdate", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call JenisPengeluaranFrm.tampilData()

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub EditJenisPengeluaranFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdJenisPengeluaran.Text = JenisPengeluaranFrm.id_Jenis_Pengeluaran
        txtNamaJenisPengeluaran.Text = JenisPengeluaranFrm.nama_Jenis_Pengeluaran
        txtNamaJenisPengeluaran.Focus()
        Me.KeyPreview = True

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub EditJenisPengeluaranFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call editJenisPengeluaran()

        End If




    End Sub
End Class