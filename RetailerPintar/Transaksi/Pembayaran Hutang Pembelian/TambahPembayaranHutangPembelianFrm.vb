Imports MySqlConnector
Public Class TambahPembayaranHutangPembelianFrm
    Private Sub nota()
        Try
            Call koneksi()
            Dim tgl As String = Format(Now, "yyyyMMdd")
            cmd = New MySqlCommand("select nota from tx_pembayaran_pembelian_produk where tanggal = SUBDATE(CURDATE(),0) order by nota desc", conn)
            rd_1 = cmd.ExecuteReader
            If rd_1.Read Then
                Dim Isi As String = Val(rd_1.Item(0)) + 1
                txtNota.Text = Isi
            Else
                txtNota.Text = tgl & "100"
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

    Private Sub TambahPembayaranHutangPembelianFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call nota()
        txtKodeSupplier.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub tambahData()
        Try
            If txtNamaSupplier.Text <> "" Then
                Dim tgl As String = dtTanggal.Value.ToString("yyyy-MM-dd")

                Call koneksi()
                For i As Integer = 0 To dgPembelian.Rows.Count - 2 Step +1
                    cmd = New MySqlCommand("insert into tx_pembayaran_pembelian_produk(nota,id_toko,tanggal,id_supplier,nota_beli,rupiah_bayar,keterangan) VALUES ('" & txtNota.Text & "','" & MainFrm.ToolStripStatusLabel1.Text & "','" & tgl & "','" & txtKodeSupplier.Text & "',@nota_beli,@total,'" & txtKeterangan.Text & "')", conn)
                    cmd.Parameters.Add("@nota_beli", MySqlDbType.VarChar).Value = dgPembelian.Rows(i).Cells(0).Value.ToString()
                    cmd.Parameters.Add("@total", MySqlDbType.Int64).Value = dgPembelian.Rows(i).Cells(1).Value.ToString()
                    cmd.ExecuteNonQuery()
                Next
                MessageBox.Show("Data Anda berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call PembelianProdukFrm.tampilData()
                Call nota()
                Call receipt()

                txtKodeSupplier.Text = ""
                lblTotal.Text = ""
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

    Private Sub TambahPembayaranHutangPembelianFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call tambahData()
        End If
    End Sub

    Private Sub dgPembelian_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgPembelian.CellEndEdit
        Try
            If e.ColumnIndex = 0 Then
                If txtNamaSupplier.Text <> "" Then
                    Call koneksi()
                    cmd = New MySqlCommand("select tanggal,jatuh_tempo,nota,(select nama_supplier from ms_supplier where id_supplier = a.id_supplier)nama_supplier, sum(total_harga)total,sum((total_harga) - (select ifnull(sum(rupiah_bayar),0) from tx_pembayaran_pembelian_produk where nota_beli = a.nota))sisa_hutang from tx_pembelian_produk a where nota like '%" & dgPembelian.CurrentRow.Cells(0).Value & "%' group by tanggal,jatuh_tempo,nota", conn)
                    rd_1 = cmd.ExecuteReader
                    rd_1.Read()
                    If rd_1.HasRows Then
                        dgPembelian.Rows(e.RowIndex).Cells(0).Value = rd_1.Item(2)
                        dgPembelian.Rows(e.RowIndex).Cells(1).Value = rd_1.Item(4)
                        dgPembelian.Rows(e.RowIndex).Cells(2).Value = rd_1.Item(5)
                    Else
                        MessageBox.Show("Nota " & dgPembelian.CurrentRow.Cells(0).Value & " tidak ditemukan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        dgPembelian.Rows.Remove(dgPembelian.CurrentRow)
                    End If
                Else
                    MessageBox.Show("Nama Supplier tidak boleh Kosong !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtKodeSupplier.Text = ""
                    txtKodeSupplier.Select()
                    dgPembelian.Rows.Remove(dgPembelian.CurrentRow)
                End If
            ElseIf e.ColumnIndex = 3 Then
                Call koneksi()
                cmd = New MySqlCommand("select tanggal,jatuh_tempo,nota,(select nama_supplier from ms_supplier where id_supplier = a.id_supplier)nama_supplier, sum(total_harga)total,sum((total_harga) - (select ifnull(sum(rupiah_bayar),0) from tx_pembayaran_pembelian_produk where nota_beli = a.nota))sisa_hutang from tx_pembelian_produk a where nota like '%" & dgPembelian.CurrentRow.Cells(0).Value & "%' group by tanggal,jatuh_tempo,nota", conn)
                rd_1 = cmd.ExecuteReader
                rd_1.Read()

                dgPembelian.Rows(e.RowIndex).Cells(2).Value = rd_1.Item(5) - dgPembelian.Rows(e.RowIndex).Cells(3).Value

                If dgPembelian.Rows(e.RowIndex).Cells(2).Value < -1 Then
                    MessageBox.Show("Maaf, Jumlah pembayaran melebihi sisa hutang !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    dgPembelian.Rows(e.RowIndex).Cells(3).Value = ""
                    dgPembelian.Rows(e.RowIndex).Cells(2).Value = rd_1.Item(5)
                Else
                    Call subtotal()
                End If
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
            If e.ColumnIndex = 4 Then
                Dim hapus As String
                Dim baris As DataGridViewRow = dgPembelian.Rows(e.RowIndex)
                hapus = MessageBox.Show("Apakah Anda ingin menghapus nota beli " & dgPembelian.CurrentRow.Cells(0).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
                    totalharga += Convert.ToInt32(dgPembelian.Rows(index).Cells(3).Value)
                    lblTotal.Text = FormatNumber(CDbl(totalharga), 0)
                Next
            Else
                lblTotal.Text = "0"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
    End Sub

    Private Sub txtKodeSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtKodeSupplier.TextChanged
        txtNamaSupplier.Text = ""
    End Sub

End Class