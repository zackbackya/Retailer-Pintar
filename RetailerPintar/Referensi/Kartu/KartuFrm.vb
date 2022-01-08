Imports MySqlConnector

Public Class KartuFrm
    Public id_Kartu, nama_Kartu, jns_kartu As String
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahKartuFrm.ShowDialog()

    End Sub


    Private Sub KartuFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call tampilData()
        Me.KeyPreview = True

    End Sub

    Private Sub KartuFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambahKartu()
        ElseIf e.KeyCode = Keys.F9 Then
            Call editKartu()
        ElseIf e.KeyCode = Keys.F10 Then
            Call hapusKartu()
        End If
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub tambahKartu()
        Try
            TambahKartuFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editKartu()
        Try
            id_Kartu = DataGridView1.CurrentRow.Cells(0).Value.ToString
            nama_Kartu = DataGridView1.CurrentRow.Cells(1).Value.ToString
            jns_kartu = DataGridView1.CurrentRow.Cells(2).Value.ToString

            EditKartuFrm.ShowDialog()


        Catch ex As Exception

            'MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub hapusKartu()
        Try

            Dim x As Object = MessageBox.Show("Apakah Anda ingin menghapus id " & DataGridView1.CurrentRow.Cells(0).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()
                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from ms_Kartu where id_kartu = '" & id & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Anda berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call tampilData()

            ElseIf x = Windows.Forms.DialogResult.No Then
                Call tampilData()
            End If

        Catch ex As Exception
            MessageBox.Show("Hapus data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPerbaiki_Click(sender As Object, e As EventArgs) Handles btnPerbaiki.Click
        Call editKartu()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapusKartu()
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()

            da = New MySqlDataAdapter("select * from ms_Kartu", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCari_GotFocus(sender As Object, e As EventArgs) Handles txtCari.GotFocus
        txtCari.BackColor = Color.LightYellow
    End Sub

    Private Sub txtCari_LostFocus(sender As Object, e As EventArgs) Handles txtCari.LostFocus
        txtCari.BackColor = Color.White
    End Sub
End Class