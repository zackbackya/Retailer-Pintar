Public Class TambahKartuFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub tambahData()
        Call koneksi()
        Try
            Dim jns_kartu As String
            If rdKartuDebit.Checked = True Then
                jns_kartu = "Debit"
            ElseIf rdKartuKredit.Checked = True Then
                jns_kartu = "Kredit"
            End If

            str = "insert into ms_Kartu values ('" & txtIdKartu.Text & "','" & txtNamaKartu.Text & "','" & jns_kartu & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil ditambah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call KartuFrm.tampilData()
            Call GenTempID()
            txtNamaKartu.Text = ""
            txtNamaKartu.Focus()

        Catch ex As Exception

            MessageBox.Show("Tambah data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub TambahKartuFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaKartu.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub TambahKartuFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdKartu.Text = "CA-" + idjam
    End Sub

    Private Sub txtNamaGolongan_GotFocus(sender As Object, e As EventArgs) Handles txtNamaKartu.GotFocus
        txtNamaKartu.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaGolongan_LostFocus(sender As Object, e As EventArgs) Handles txtNamaKartu.LostFocus
        txtNamaKartu.BackColor = Color.White
    End Sub
End Class