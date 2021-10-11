Imports MySqlConnector

Public Class ProdukFrm
    Public id_produk, barcode, nama_produk, nama_pendek, aktif, id_supplier, id_golongan_terpilih, lokasi As String
    Public harga_beli, harga_jual, stok, id_golongan As Integer
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        TambahProdukFrm.ShowDialog()

    End Sub
    Private Sub ProdukFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilGolongan()
        Call tampilData()

    End Sub
    Private Sub ProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambahProduk()
        ElseIf e.KeyCode = Keys.F9 Then
            Call editProduk()
        ElseIf e.KeyCode = Keys.F10 Then
            Call hapusProduk()
        End If
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
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
            harga_jual = DataGridView1.CurrentRow.Cells(9).Value.ToString
            stok = DataGridView1.CurrentRow.Cells(10).Value.ToString

            EditProdukFrm.ShowDialog()



        Catch ex As Exception

            'MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub hapusProduk()
        Try

            Dim x As Object = MessageBox.Show("Apakah Yakin Data Akan dihapus ?", "Retail Pintar",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question)

            If x = Windows.Forms.DialogResult.Yes Then

                Call koneksi()

                Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
                str = "delete from ms_Produk where id_Produk = '" & id & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()

                MessageBox.Show("Data Terhapus", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call tampilData()

            ElseIf x = Windows.Forms.DialogResult.No Then
                Call tampilData()
            End If

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnPerbaiki_Click(sender As Object, e As EventArgs) Handles btnPerbaiki.Click
        Call editProduk()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
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



    Private Sub cbGolongan_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbGolongan.SelectionChangeCommitted
        id_golongan = cbGolongan.SelectedValue

        Try
            Call koneksi()


            da = New MySqlDataAdapter("select * from ms_Produk where id_golongan = '" & id_golongan & "'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class