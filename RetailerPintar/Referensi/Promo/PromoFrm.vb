Imports MySqlConnector

Public Class PromoFrm
    Public id_Promo, nama_Promo, aktif, id_produk, nama_produk, tanggal_awal, tanggal_akhir As String

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahPromoFrm.ShowDialog()

    End Sub
    Private Sub PromoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call tampilData()
        Me.KeyPreview = True

    End Sub
    Private Sub PromoFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambahPromo()
        ElseIf e.KeyCode = Keys.F9 Then

        ElseIf e.KeyCode = Keys.F10 Then
            Call hapusPromo()
        End If
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub tambahPromo()
        Try
            TambahPromoFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub hapusPromo()
        Try

            Dim x As Object = MessageBox.Show("Apakah Anda ingin menghapus id " & DataGridView1.CurrentRow.Cells(0).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()

                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from ms_Promo where id_Promo = '" & id & "'"
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

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapusPromo()
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()

            da = New MySqlDataAdapter("select * from ms_Promo", conn)
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