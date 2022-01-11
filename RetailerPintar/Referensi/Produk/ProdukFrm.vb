Imports MySqlConnector

Public Class ProdukFrm
    Public id_produk, barcode, nama_produk, nama_pendek, aktif, id_supplier, id_golongan_terpilih, lokasi, id_golongan, flag_min2, flag_min3 As String
    Public harga_beli, harga_jual1, harga_jual2, min_jual2, harga_jual3, min_jual3, stok As Integer

    Private Sub btnPerbaiki_Click_1(sender As Object, e As EventArgs) Handles btnPerbaiki.Click
        Call editProduk()
    End Sub

    Private Sub btnTambah_Click_1(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahProdukFrm.ShowDialog()
    End Sub

    Private Sub btnHapus_Click_1(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapusProduk()
    End Sub

    Private Sub btnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub btUpload_Click(sender As Object, e As EventArgs) Handles btUpload.Click
        UploadProdukFrm.Show()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub ProdukFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilGolongan()
        Call tampilData()
        Me.KeyPreview = True

    End Sub

    Private Sub ProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
            e.Handled = True

        ElseIf e.KeyCode = Keys.F8 Then
            Call tambahProduk()
            e.Handled = True
        ElseIf e.KeyCode = Keys.F9 Then
            Call editProduk()
        ElseIf e.KeyCode = Keys.F10 Then
            Call hapusProduk()
        End If
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub tambahProduk()
        Try
            TambahProdukFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub editProduk()
        Try

            id_produk = DataGridView1.CurrentRow.Cells(0).Value.ToString
            barcode = DataGridView1.CurrentRow.Cells(1).Value.ToString
            nama_produk = DataGridView1.CurrentRow.Cells(2).Value.ToString
            nama_pendek = DataGridView1.CurrentRow.Cells(3).Value.ToString
            aktif = DataGridView1.CurrentRow.Cells(4).Value.ToString
            id_supplier = DataGridView1.CurrentRow.Cells(5).Value.ToString
            id_golongan = DataGridView1.CurrentRow.Cells(6).Value.ToString
            lokasi = DataGridView1.CurrentRow.Cells(7).Value.ToString
            harga_beli = DataGridView1.CurrentRow.Cells(8).Value.ToString
            harga_jual1 = DataGridView1.CurrentRow.Cells(9).Value.ToString
            harga_jual2 = DataGridView1.CurrentRow.Cells(10).Value.ToString
            min_jual2 = DataGridView1.CurrentRow.Cells(11).Value.ToString
            flag_min2 = DataGridView1.CurrentRow.Cells(12).Value.ToString
            harga_jual3 = DataGridView1.CurrentRow.Cells(13).Value.ToString
            min_jual3 = DataGridView1.CurrentRow.Cells(14).Value.ToString
            flag_min3 = DataGridView1.CurrentRow.Cells(15).Value.ToString
            stok = DataGridView1.CurrentRow.Cells(16).Value.ToString

            EditProdukFrm.ShowDialog()



        Catch ex As Exception

            'MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub hapusProduk()
        Try

            Dim x As Object = MessageBox.Show("Apakah Anda ingin menghapus id " & DataGridView1.CurrentRow.Cells(0).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()

                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from ms_Produk where id_Produk = '" & id & "'"
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

    Private Sub btnPerbaiki_Click(sender As Object, e As EventArgs)
        Call editProduk()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs)
        Call hapusProduk()
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()

            da = New MySqlDataAdapter("select * from ms_Produk", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub tampilGolongan()
        Try
            Call koneksi()

            'cmd = New MySqlCommand("select * from ms_golongan", conn)

            da = New MySqlDataAdapter("select * from ms_golongan", conn)
            ds = New DataSet
            da.Fill(ds)
            cbGolongan.DataSource = ds.Tables(0)
            cbGolongan.ValueMember = "id_golongan"
            cbGolongan.DisplayMember = "nama_golongan"
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub



    Private Sub cbGolongan_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Try
            Call koneksi()
            da = New MySqlDataAdapter("Select * From ms_produk Where id_golongan In (Select id_golongan from ms_golongan where nama_golongan = '" & cbGolongan.Text & "')", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCari_GotFocus(sender As Object, e As EventArgs)
        txtCari.BackColor = Color.LightYellow
    End Sub

    Private Sub txtCari_LostFocus(sender As Object, e As EventArgs)
        txtCari.BackColor = Color.White
    End Sub
End Class