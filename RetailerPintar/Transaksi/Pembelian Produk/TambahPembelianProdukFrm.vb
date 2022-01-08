Imports MySqlConnector
Public Class TambahPembelianProdukFrm

    Private Sub nota()
        Try
            Call koneksi()
            Dim tgl As String = Format(Now, "yyyyMMdd")
            cmd = New MySqlCommand("select nota from tx_pembelian_produk where tanggal = SUBDATE(CURDATE(),0) order by nota desc", conn)
            rd_1 = cmd.ExecuteReader
            If rd_1.Read Then
                Dim Isi As String = Val(rd_1.Item(0)) + 1
                TxtNota.Text = Isi
            Else
                TxtNota.Text = tgl & "100"
            End If
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNamaSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeSupplier.KeyPress
        Try
            If (e.KeyChar = Chr(13)) Then
                Call koneksi()
                cmd = New MySqlCommand("select count(*) from ms_supplier where (id_supplier like '%" & txtKodeSupplier.Text & "%' or nama_supplier like '%" & txtKodeSupplier.Text & "%')", conn)
                rd_1 = cmd.ExecuteReader
                rd_1.Read()
                If 1 < rd_1.Item(0) Then
                    AmbilSupplierFrm.ShowDialog()
                Else
                    Call koneksi()
                    cmd = New MySqlCommand("select id_supplier, nama_supplier from ms_supplier where (id_supplier like '%" & txtKodeSupplier.Text & "%' or nama_supplier like '%" & txtKodeSupplier.Text & "%')", conn)
                    rd_1 = cmd.ExecuteReader
                    rd_1.Read()
                    txtKodeSupplier.Text = rd_1.Item(0)
                    txtNamaSupplier.Text = rd_1.Item(1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Data supplier tidak ditemukan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeSupplier.Text = ""
            txtKodeSupplier.Select()
        End Try
    End Sub

    Private Sub TambahPembelianProdukFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call nota()
        Call tampilProduk()
        txtKodeSupplier.Focus()
        Me.KeyPreview = True
        dtJatuhTempo.Enabled = False
        rbTunai.Checked = True
    End Sub

    Private Sub tambahData()
        Try
            If txtNamaSupplier.Text <> "" Then
                Dim status As String = ""
                Dim tgl As String = dtTanggal.Value.ToString("yyyy-MM-dd")
                Dim tgl_jatuh_tempo As String = dtJatuhTempo.Value.ToString("yyyy-MM-dd")

                If rbKredit.Checked = True Then
                    status = "Kredit"
                    tgl_jatuh_tempo = dtJatuhTempo.Value.ToString("yyyy-MM-dd")
                ElseIf rbTunai.Checked = True Then
                    status = "Tunai"
                    tgl_jatuh_tempo = dtTanggal.Value.ToString("yyyy-MM-dd")
                End If

                Call koneksi()
                For i As Integer = 0 To dgPembelian.Rows.Count - 2 Step +1
                    cmd = New MySqlCommand("insert into tx_pembelian_produk(nota,id_toko,tanggal,jatuh_tempo,status_bayar,id_supplier,id_produk,nama_produk,qty,harga,total_harga,keterangan) VALUES ('" & txtNota.Text & "','" & MainFrm.ToolStripStatusLabel1.Text & "','" & tgl & "','" & tgl_jatuh_tempo & "','" & status & "','" & txtKodeSupplier.Text & "',@id_produk,@nama_produk,@qty,@harga,@total_harga,'" & txtKeterangan.Text & "')", conn)
                    cmd.Parameters.Add("@id_produk", MySqlDbType.VarChar).Value = dgPembelian.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@nama_produk", MySqlDbType.VarChar).Value = dgPembelian.Rows(i).Cells(1).Value.ToString()
                    cmd.Parameters.Add("@qty", MySqlDbType.Int64).Value = dgPembelian.Rows(i).Cells(2).Value.ToString()
                    cmd.Parameters.Add("@harga", MySqlDbType.Int64).Value = dgPembelian.Rows(i).Cells(3).Value.ToString()
                    cmd.Parameters.Add("@total_harga", MySqlDbType.Int64).Value = dgPembelian.Rows(i).Cells(4).Value.ToString()
                    cmd.ExecuteNonQuery()
                Next
                MessageBox.Show("Data Anda berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call PembelianProdukFrm.tampilData()
                Call nota()
                Call receipt()

                txtKodeSupplier.Text = ""
                lblTotal.Text = ""
                rbKredit.Checked = False
                rbTunai.Checked = False
                dgPembelian.Rows.Clear()
                txtKodeSupplier.Focus()
            Else
                MessageBox.Show("Nama Supplier tidak boleh Kosong !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtKodeSupplier.Text = ""
                txtKodeSupplier.Select()
            End If
        Catch ex As Exception
            MessageBox.Show("Tambah data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub TambahPembelianProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call tambahData()
        End If
    End Sub

    Private Sub dgPembelian_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgPembelian.CellEndEdit
        Try
            If e.ColumnIndex = 0 Then
                Call koneksi()
                cmd = New MySqlCommand("select id_produk,barcode,nama_produk,harga_beli from ms_produk where (id_produk = '" & dgPembelian.CurrentRow.Cells(0).Value & "' or barcode = '" & dgPembelian.CurrentRow.Cells(0).Value & "')", conn)
                rd_1 = cmd.ExecuteReader
                rd_1.Read()
                If rd_1.HasRows Then
                    For barisatas As Integer = 0 To dgPembelian.RowCount - 1
                        For barisbawah As Integer = barisatas + 1 To dgPembelian.RowCount - 1
                            If dgPembelian.Rows(barisbawah).Cells(0).Value = dgPembelian.Rows(barisatas).Cells(0).Value Then
                                dgPembelian.Rows(barisatas).Cells(1).Value = dgPembelian.Rows(barisatas).Cells(1).Value
                                dgPembelian.Rows(barisatas).Cells(3).Value = dgPembelian.Rows(barisatas).Cells(3).Value
                                'asumsi penjualan minimal jumlah barang 1 (satu)
                                'jadi ketika ngetik nama barang di kolom nama barang
                                dgPembelian.Rows(barisatas).Cells(2).Value = dgPembelian.Rows(barisatas).Cells(2).Value + 1
                                dgPembelian.Rows(barisatas).Cells(4).Value = (dgPembelian.Rows(barisatas).Cells(2).Value * dgPembelian.Rows(barisatas).Cells(3).Value)
                                dgPembelian.Rows.RemoveAt(barisbawah)
                                dgPembelian.CurrentCell = dgPembelian.Rows(barisbawah).Cells(0)
                                Call subtotal()
                                Exit Sub
                            Else
                                If dgPembelian.Rows(barisbawah).Cells(0).Value = rd_1.Item(1) Then
                                    dgPembelian.Rows(barisatas).Cells(1).Value = dgPembelian.Rows(barisatas).Cells(1).Value
                                    dgPembelian.Rows(barisatas).Cells(3).Value = dgPembelian.Rows(barisatas).Cells(3).Value
                                    'asumsi penjualan minimal jumlah barang 1 (satu)
                                    'jadi ketika ngetik nama barang di kolom nama barang
                                    dgPembelian.Rows(barisatas).Cells(2).Value = dgPembelian.Rows(barisatas).Cells(2).Value + 1
                                    dgPembelian.Rows(barisatas).Cells(4).Value = (dgPembelian.Rows(barisatas).Cells(2).Value * dgPembelian.Rows(barisatas).Cells(3).Value)
                                    dgPembelian.Rows.RemoveAt(barisbawah)
                                    dgPembelian.CurrentCell = dgPembelian.Rows(barisbawah).Cells(0)
                                    Call subtotal()
                                    Exit Sub
                                Else
                                    dgPembelian.Rows(e.RowIndex).Cells(0).Value = rd_1.Item("id_produk")
                                    dgPembelian.Rows(e.RowIndex).Cells(1).Value = rd_1.Item("nama_produk")
                                    dgPembelian.Rows(e.RowIndex).Cells(3).Value = rd_1.Item("harga_beli")
                                    'asumsi penjualan minimal jumlah barang 1 (satu)
                                    'jadi ketika ngetik nama barang di kolom nama barang
                                    dgPembelian.Rows(e.RowIndex).Cells(2).Value = 1
                                    dgPembelian.Rows(e.RowIndex).Cells(4).Value = (dgPembelian.Rows(e.RowIndex).Cells(2).Value * dgPembelian.Rows(e.RowIndex).Cells(3).Value)
                                    Call subtotal()
                                End If
                            End If
                        Next
                    Next
                Else
                    MessageBox.Show("Barcode " & dgPembelian.CurrentRow.Cells(0).Value & " tidak ditemukan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    dgPembelian.Rows.Remove(dgPembelian.CurrentRow)
                End If
            ElseIf e.ColumnIndex = 2 Then
                dgPembelian.Rows(e.RowIndex).Cells(4).Value = (dgPembelian.Rows(e.RowIndex).Cells(2).Value * dgPembelian.Rows(e.RowIndex).Cells(3).Value)
                Call subtotal()
            End If
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles dgPembelian.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub dgPembelian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPembelian.CellContentClick
        Try
            If e.ColumnIndex = 5 Then
                Dim hapus As String
                Dim baris As DataGridViewRow = dgPembelian.Rows(e.RowIndex)
                hapus = MessageBox.Show("Apakah Anda ingin menghapus produk " & dgPembelian.CurrentRow.Cells(1).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If hapus = DialogResult.Yes Then
                    If dgPembelian.CurrentRow.Index <> dgPembelian.NewRowIndex Then
                        dgPembelian.Rows.RemoveAt(dgPembelian.CurrentRow.Index)
                        MessageBox.Show("Data Anda berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                ElseIf hapus = DialogResult.No Then

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Hapus data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub subtotal()
        Try
            If dgPembelian.RowCount > 1 Then
                lblTotal.Text = "0"
                Dim totalharga As Integer = 0
                Dim totalqty As Integer = 0
                Dim totaldiskon As Integer = 0
                For index As Integer = 0 To dgPembelian.RowCount - 1
                    totalharga += Convert.ToInt32(dgPembelian.Rows(index).Cells(4).Value)
                    lblTotal.Text = FormatNumber(CDbl(totalharga), 0)
                Next
            Else
                lblTotal.Text = "0"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub tampilProduk()
        Try
            Call koneksi()
            da = New MySqlDataAdapter("select id_produk,nama_produk from ms_produk", conn)
            ds = New DataSet
            da.Fill(ds)
            dgProduk.DataSource = ds.Tables(0)
            dgProduk.ReadOnly = True
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
    End Sub

    Private Sub rbKredit_CheckedChanged(sender As Object, e As EventArgs) Handles rbKredit.CheckedChanged
        If rbKredit.Checked = True Then
            dtJatuhTempo.Enabled = True
        Else
            dtJatuhTempo.Enabled = False
        End If
    End Sub

    Private Sub txtKodeSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtKodeSupplier.TextChanged
        txtNamaSupplier.Text = ""
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        Try
            If (e.KeyChar = Chr(13)) Then
                Call koneksi()
                da = New MySqlDataAdapter("select id_produk,nama_produk from ms_produk where (id_produk like '%" & txtCari.Text & "%' or nama_produk like '%" & txtCari.Text & "%')", conn)
                ds = New DataSet
                da.Fill(ds)
                dgProduk.DataSource = ds.Tables(0)
                dgProduk.ReadOnly = True
                conn.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class