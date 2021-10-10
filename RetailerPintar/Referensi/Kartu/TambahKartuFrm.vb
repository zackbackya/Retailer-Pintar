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

            MessageBox.Show("Data Berhasil Ditambah", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call KartuFrm.tampilData()
            Call GenTempID()
            txtNamaKartu.Text = ""
            txtNamaKartu.Focus()


        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub TambahKartuFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaKartu.Focus()
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
    End Sub

    Private Sub TambahKartuFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdKartu.Text = idjam
    End Sub


End Class