Imports MySqlConnector
Public Class PembelianProdukFrm
    Private Sub PembelianProdukFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call tampilData()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub PembelianProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambah()
        ElseIf e.KeyCode = Keys.F10 Then
            Call hapus()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call tambah()
    End Sub

    Private Sub tambah()
        Try
            TambahPembelianProdukFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub hapus()
        Try

            Dim x As Object = MessageBox.Show("Apakah Anda ingin menghapus nota " & DataGridView1.CurrentRow.Cells(3).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = Windows.Forms.DialogResult.Yes Then
                Call kembalikan()
                Call koneksi()
                Dim nota As String = DataGridView1.CurrentRow.Cells(3).Value.ToString
                str = "delete from tx_pembelian_produk where nota = '" & nota & "'"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Data Anda berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call tampilData()
                Call receipt_all()

            ElseIf x = Windows.Forms.DialogResult.No Then
                Call tampilData()
            End If
        Catch ex As Exception
            MessageBox.Show("Hapus data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub tampilData()
        Try
            Dim awal As String = dtTanggalAwal.Value.ToString("yyyy-MM-dd")
            Dim akhir As String = dtTanggalAkhir.Value.ToString("yyyy-MM-dd")
            If CheckBox1.Checked = True Then
                Call koneksi()
                da = New MySqlDataAdapter("select tanggal,jatuh_tempo,status_bayar,nota,(select nama_supplier from ms_supplier where id_supplier = a.id_supplier)nama_supplier, keterangan, CASE status_bayar when 'Tunai' then '0' when 'Kredit' then ifnull(sum(total_harga),0) end as jml_hutang, (select ifnull(sum(rupiah_bayar),0) from tx_pembayaran_pembelian_produk where nota_beli = a.nota)jml_bayar from tx_pembelian_produk a group by tanggal,jatuh_tempo,status_bayar,nota,keterangan", conn)
                ds = New DataSet
                da.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.ReadOnly = True
                conn.Close()
            Else
                Call koneksi()
                da = New MySqlDataAdapter("select tanggal,jatuh_tempo,status_bayar,nota,(select nama_supplier from ms_supplier where id_supplier = a.id_supplier)nama_supplier, keterangan, CASE status_bayar when 'Tunai' then '0' when 'Kredit' then ifnull(sum(total_harga),0) end as jml_hutang, (select ifnull(sum(rupiah_bayar),0) from tx_pembayaran_pembelian_produk where nota_beli = a.nota)jml_bayar from tx_pembelian_produk a where date(tanggal) between '" & awal & "' and '" & akhir & "' group by tanggal,jatuh_tempo,status_bayar,nota,keterangan", conn)
                ds = New DataSet
                da.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.ReadOnly = True
                conn.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapus()
    End Sub

    Sub kembalikan()
        Try
            Call koneksi()
            cmd = New MySqlCommand("select id_produk,qty,tanggal from tx_pembelian_produk where nota = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read()
                Call koneksi()
                cmd = New MySqlCommand("update tx_stok set receipt = receipt - '" & rd_1.Item(1) & "' where date(tanggal) = '" & Format(rd_1.Item(2), "yyyy-MM-dd") & "'  and id_produk = '" & rd_1.Item(0) & "'", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Hapus data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtTanggalAwal_TextChanged(sender As Object, e As EventArgs) Handles dtTanggalAwal.TextChanged
        Call tampilData()
    End Sub

    Private Sub dtTanggalAkhir_TextChanged(sender As Object, e As EventArgs) Handles dtTanggalAkhir.TextChanged
        Call tampilData()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Call tampilData()
            dtTanggalAwal.Enabled = False
            dtTanggalAkhir.Enabled = False
        Else
            Call tampilData()
            dtTanggalAwal.Enabled = True
            dtTanggalAkhir.Enabled = True
        End If
    End Sub

    Private Sub btnPerbaiki_Click(sender As Object, e As EventArgs) Handles btnPerbaiki.Click

    End Sub
End Class