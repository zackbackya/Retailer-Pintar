Public Class EditGolonganFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Call editGolongan()

    End Sub

    Private Sub editGolongan()
        Call koneksi()
        Try

            cmd = New MySqlConnector.MySqlCommand("update ms_golongan set nama_golongan = '" & txtNamaGolongan.Text & "' where id_golongan = '" & txtIdGolongan.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Diupdate", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call GolonganFrm.tampilData()

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub EditGolonganFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdGolongan.Text = GolonganFrm.id_golongan
        txtNamaGolongan.Text = GolonganFrm.nama_golongan
        txtNamaGolongan.Focus()
        Me.KeyPreview = True

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub EditGolonganFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call editGolongan()

        End If




    End Sub
End Class