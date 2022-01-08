Imports MySqlConnector

Public Class TambahPromoFrm
    Dim aktif As String
    Private Sub tambahData()
        Try
            Call koneksi()
            For i As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1
                cmd = New MySqlCommand("insert into ms_promo (id_promo,nama_promo,id_produk,nama_produk,tgl_awal,tgl_akhir,harga_promo) VALUES ('" & txtIdPromo.Text & "','" & txtNamaPromo.Text & "',@idproduk,@namaproduk,'" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "','" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "',@promo)", conn)
                cmd.Parameters.Add("@idproduk", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                cmd.Parameters.Add("@namaproduk", MySqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(1).Value.ToString()
                cmd.Parameters.Add("@promo", MySqlDbType.Int32).Value = Replace(DataGridView1.Rows(i).Cells(2).Value.ToString(), ",", "")
                cmd.ExecuteNonQuery()
            Next
            MessageBox.Show("Data Anda berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call PromoFrm.tampilData()
            Call GenTempID()

            txtNamaPromo.Text = ""
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add()
            txtNamaPromo.Focus()

        Catch ex As Exception
            MessageBox.Show("Simpan data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TambahPromoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaPromo.Focus()
        Me.KeyPreview = True
        DataGridView1.Rows.Add()
    End Sub

    Private Sub TambahPromoFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call tambahData()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdPromo.Text = "PR-" + idjam
    End Sub

    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub btnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            If e.ColumnIndex = 0 Then
                Call koneksi()
                cmd = New MySqlCommand("select count(*) from ms_produk where (id_produk like '%" & DataGridView1.CurrentRow.Cells(0).Value & "%' or nama_produk like '%" & DataGridView1.CurrentRow.Cells(0).Value & "%')", conn)
                rd_1 = cmd.ExecuteReader
                rd_1.Read()
                If 1 < rd_1.Item(0) Then
                    AmbilProdukProdukFrm.ShowDialog()
                Else
                    Call koneksi()
                    cmd = New MySqlCommand("select id_produk,nama_produk from ms_produk where (id_produk like '%" & DataGridView1.CurrentRow.Cells(0).Value & "%' or nama_produk like '%" & DataGridView1.CurrentRow.Cells(0).Value & "%')", conn)
                    rd_1 = cmd.ExecuteReader
                    rd_1.Read()
                    DataGridView1.CurrentRow.Cells(0).Value = rd_1.Item(0)
                    DataGridView1.CurrentRow.Cells(1).Value = rd_1.Item(1)
                End If
            ElseIf e.ColumnIndex = 2 Then
                If DataGridView1.CurrentRow.Cells(0).Value <> "" Then
                    DataGridView1.CurrentRow.Cells(2).Value = FormatNumber(CDbl(DataGridView1.CurrentRow.Cells(2).Value), 0)
                    DataGridView1.Rows.Add()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Data produk tidak ditemukan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DataGridView1.CurrentRow.Cells(0).Value = ""
        End Try
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.ColumnIndex = 3 Then
                Dim hapus As String
                Dim baris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                hapus = MessageBox.Show("Apakah Anda ingin menghapus produk " & DataGridView1.CurrentRow.Cells(1).Value & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If hapus = DialogResult.Yes Then
                    If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
                        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
                        MessageBox.Show("Data Anda berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If DataGridView1.Rows.Count < 1 Then
                            DataGridView1.Rows.Add()
                        End If
                    End If
                ElseIf hapus = DialogResult.No Then

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Hapus data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNamaPromo_GotFocus(sender As Object, e As EventArgs) Handles txtNamaPromo.GotFocus
        txtNamaPromo.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaPromo_LostFocus(sender As Object, e As EventArgs) Handles txtNamaPromo.LostFocus
        txtNamaPromo.BackColor = Color.White
    End Sub
End Class