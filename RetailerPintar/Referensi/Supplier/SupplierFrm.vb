Imports MySqlConnector

Public Class SupplierFrm

    Public id_Supplier, nama_Supplier, alamat_Supplier, telepon_Supplier As String

    Private Sub SupplierFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click

        Me.Dispose()


    End Sub

    Private Sub SupplierFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambahSupplier()
        ElseIf e.KeyCode = Keys.F9 Then
            Call editSupplier()
        ElseIf e.KeyCode = Keys.F10 Then
            Call hapusSupplier()
        End If



    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Call tambahSupplier()

    End Sub

    Private Sub tambahSupplier()
        Try
            TambahSupplierFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editSupplier()
        Try
            id_Supplier = DataGridView1.CurrentRow.Cells(0).Value.ToString
            nama_Supplier = DataGridView1.CurrentRow.Cells(1).Value.ToString
            alamat_Supplier = DataGridView1.CurrentRow.Cells(2).Value.ToString
            telepon_Supplier = DataGridView1.CurrentRow.Cells(3).Value.ToString
            EditSupplierFrm.ShowDialog()



        Catch ex As Exception

            'MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub hapusSupplier()
        Try

            Dim x As Object = MessageBox.Show("Apakah Anda ingin menghapus id " & DataGridView1.CurrentRow.Cells(0).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()

                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from ms_Supplier where id_Supplier = '" & id & "'"
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

    Public Sub tampilData()
        Try
            Call koneksi()

            da = New MySqlDataAdapter("select * from ms_Supplier", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapusSupplier()
    End Sub

    Private Sub btnPerbaiki_Click(sender As Object, e As EventArgs) Handles btnPerbaiki.Click
        Call editSupplier()
    End Sub

    Private Sub txtCari_GotFocus(sender As Object, e As EventArgs) Handles txtCari.GotFocus
        txtCari.BackColor = Color.LightYellow
    End Sub

    Private Sub txtCari_LostFocus(sender As Object, e As EventArgs) Handles txtCari.LostFocus
        txtCari.BackColor = Color.White
    End Sub
End Class