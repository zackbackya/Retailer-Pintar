Imports MySqlConnector
Public Class AmbilProdukPembelianFrm
    Private Sub AmbilProdukFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        tampilData()
        Me.KeyPreview = True
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("select id_produk,nama_produk,harga_beli,stok from ms_produk", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ambil()
    End Sub

    Sub ambil()
        Try
            For barisatas As Integer = 0 To TambahPembelianProdukFrm.dgPembelian.RowCount - 1
                For barisbawah As Integer = barisatas + 1 To TambahPembelianProdukFrm.dgPembelian.RowCount - 1
                    If TambahPembelianProdukFrm.dgPembelian.Rows(barisbawah).Cells(0).Value = TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(0).Value Then
                        TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(1).Value = TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(1).Value
                        'asumsi penjualan minimal jumlah barang 1 (satu)
                        'jadi ketika ngetik nama barang di kolom nama barang
                        TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(2).Value = TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(2).Value + 1
                        TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(4).Value = (TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(2).Value * TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(3).Value)
                        TambahPembelianProdukFrm.dgPembelian.Rows.RemoveAt(barisbawah)
                    Else
                        TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(0).Value = DataGridView1.CurrentRow.Cells(0).Value
                        TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(1).Value = DataGridView1.CurrentRow.Cells(1).Value
                        TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(3).Value = DataGridView1.CurrentRow.Cells(2).Value
                        'asumsi penjualan minimal jumlah barang 1 (satu)
                        'jadi ketika ngetik nama barang di kolom nama barang
                        TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(2).Value = 1
                        TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(4).Value = (TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(2).Value * TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(3).Value)
                    End If
                Next
            Next
            'TambahPembelianProdukFrm.DataGridView1.CurrentRow.Cells(0).Value = DataGridView1.CurrentRow.Cells(0).Value
            'TambahPembelianProdukFrm.DataGridView1.CurrentRow.Cells(1).Value = DataGridView1.CurrentRow.Cells(1).Value
            'TambahPembelianProdukFrm.DataGridView1.CurrentRow.Cells(3).Value = FormatNumber(CDbl(DataGridView1.CurrentRow.Cells(2).Value), 0)
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            For barisatas As Integer = 0 To TambahPembelianProdukFrm.dgPembelian.RowCount - 1
                For barisbawah As Integer = barisatas + 1 To TambahPembelianProdukFrm.dgPembelian.RowCount - 1
                    If TambahPembelianProdukFrm.dgPembelian.Rows(barisbawah).Cells(0).Value = TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(0).Value Then
                        TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(1).Value = TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(1).Value
                        'asumsi penjualan minimal jumlah barang 1 (satu)
                        'jadi ketika ngetik nama barang di kolom nama barang
                        TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(2).Value = TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(2).Value + 1
                        TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(4).Value = (TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(2).Value * TambahPembelianProdukFrm.dgPembelian.Rows(barisatas).Cells(3).Value)
                        TambahPembelianProdukFrm.dgPembelian.Rows.RemoveAt(barisbawah)
                    Else
                        TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(0).Value = DataGridView1.CurrentRow.Cells(0).Value
                        TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(1).Value = DataGridView1.CurrentRow.Cells(1).Value
                        TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(3).Value = DataGridView1.CurrentRow.Cells(2).Value
                        'asumsi penjualan minimal jumlah barang 1 (satu)
                        'jadi ketika ngetik nama barang di kolom nama barang
                        DataGridView1.CurrentRow.Cells(2).Value = 1
                        DataGridView1.CurrentRow.Cells(4).Value = (TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(2).Value * TambahPembelianProdukFrm.dgPembelian.CurrentRow.Cells(3).Value)
                    End If
                Next
            Next
            'TambahPembelianProdukFrm.DataGridView1.CurrentRow.Cells(0).Value = DataGridView1.CurrentRow.Cells(0).Value
            'TambahPembelianProdukFrm.DataGridView1.CurrentRow.Cells(1).Value = DataGridView1.CurrentRow.Cells(1).Value
            'TambahPembelianProdukFrm.DataGridView1.CurrentRow.Cells(3).Value = FormatNumber(CDbl(DataGridView1.CurrentRow.Cells(2).Value), 0)
            Me.Close()
        End If
    End Sub

    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub TambahPenyesuaianStokFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            ambil()
        End If
    End Sub
End Class