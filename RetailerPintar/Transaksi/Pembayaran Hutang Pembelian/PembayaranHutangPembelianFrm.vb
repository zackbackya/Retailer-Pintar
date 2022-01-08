Imports MySqlConnector
Public Class PembayaranHutangPembelianFrm
    Private Sub PembayaranHutangPembelianFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call tampilData()
        Call CheckRole()
        Me.KeyPreview = True
    End Sub

    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub PembayaranHutangPembelianFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            Call tambah()
        ElseIf e.KeyCode = Keys.F10 Then
            If LoginFrm.RoleName = "ADMIN" Then
                ''
            End If
        Else
            Call hapus()
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call tambah()
    End Sub

    Private Sub tambah()
        Try
            TambahPembayaranHutangPembelianFrm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub hapus()
        Try

            Dim x As Object = MessageBox.Show("Apakah Anda ingin menghapus nota " & DataGridView1.CurrentRow.Cells(3).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If x = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim nota As String = DataGridView1.CurrentRow.Cells(3).Value.ToString
                str = "delete from tx_pembayaran_pembelian_produk where nota = '" & nota & "'"
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
                da = New MySqlDataAdapter("select tanggal,nota,nota_beli,rupiah_bayar,keterangan from tx_pembayaran_pembelian_produk", conn)
                ds = New DataSet
                da.Fill(ds)
                DataGridView1.DataSource = ds.Tables(0)
                DataGridView1.ReadOnly = True
                conn.Close()
            Else
                Call koneksi()
                da = New MySqlDataAdapter("select tanggal,nota,nota_beli,rupiah_bayar,keterangan from tx_pembayaran_pembelian_produk where date(tanggal) between '" & awal & "' and '" & akhir & "'", conn)
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


    Private Sub CheckRole()

        If LoginFrm.RoleName = "ADMIN" Then
            'admin role
            btnHapus.Enabled = False
        End If

    End Sub

End Class