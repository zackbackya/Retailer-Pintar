Public Class EditKartuFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Call editKartu()

    End Sub

    Private Sub editKartu()
        Call koneksi()
        Try

            Dim jns_kartu As String

            If rdKartuDebit.Checked = True Then
                jns_kartu = "Debit"
            ElseIf rdKartuKredit.Checked = True Then
                jns_kartu = "Kredit"
            End If

            cmd = New MySqlConnector.MySqlCommand("update ms_Kartu set nama_Kartu = '" & txtNamaKartu.Text & "', jenis_kartu = '" & jns_kartu & "' where id_Kartu = '" & txtIdKartu.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call KartuFrm.tampilData()
            Me.Close()

        Catch ex As Exception

            MessageBox.Show("Update data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub EditKartuFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdKartu.Text = KartuFrm.id_Kartu
        txtNamaKartu.Text = KartuFrm.nama_Kartu

        If KartuFrm.jns_kartu = "Debit" Then
            rdKartuDebit.Checked = True
        Else
            rdKartuKredit.Checked = True
        End If

        txtNamaKartu.Focus()
        Me.KeyPreview = True

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub EditKartuFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call editKartu()

        End If

    End Sub

    Private Sub txtNamaGolongan_GotFocus(sender As Object, e As EventArgs) Handles txtNamaKartu.GotFocus
        txtNamaKartu.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaGolongan_LostFocus(sender As Object, e As EventArgs) Handles txtNamaKartu.LostFocus
        txtNamaKartu.BackColor = Color.White
    End Sub
End Class