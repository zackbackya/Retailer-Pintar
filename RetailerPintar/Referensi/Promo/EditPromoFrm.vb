Imports MySqlConnector

Public Class EditPromoFrm
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Call editPromo()


    End Sub

    Private Sub editPromo()
        Call koneksi()
        Try
            Dim aktif As String
            If cbAktifPromo.Checked = True Then
                aktif = "T"
            Else
                aktif = "F"
            End If

            cmd = New MySqlConnector.MySqlCommand("update ms_Promo set nama_Promo = '" & txtNamaPromo.Text & "', id_produk = '" & txtIdProduk.Text & "', tgl_awal = '" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "', tgl_akhir = '" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "', status = '" & aktif & "' where id_Promo  = '" & txtIdPromo.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Diupdate", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call PromoFrm.tampilData()

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub EditPromoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call AutoText()
        txtIdPromo.Text = PromoFrm.id_Promo
        txtNamaPromo.Text = PromoFrm.nama_Promo
        txtIdProduk.Text = PromoFrm.id_produk
        dtTanggalAwal.Value = PromoFrm.tanggal_awal
        dtTanggalAkhir.Value = PromoFrm.tanggal_akhir

        Call koneksi()
        str = "select id_produk, nama_produk from ms_produk where id_produk like '%" & PromoFrm.id_produk & "%'"
        cmd = New MySqlCommand(str, conn)
        rd_1 = cmd.ExecuteReader()

        While rd_1.Read

            txtNamaProduk.Text = rd_1("nama_produk").ToString

        End While

        If PromoFrm.aktif = "T" Then
            cbAktifPromo.Checked = True
        Else
            cbAktifPromo.Checked = False
        End If

        txtNamaPromo.Focus()
        Me.KeyPreview = True



    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub EditPromoFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call editPromo()
        End If

    End Sub
    Private Sub AutoID()
        Dim id_produk As String
        Call koneksi()

        'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

        str = "select id_produk, nama_produk from ms_produk where nama_produk like '%" & txtNamaProduk.Text & "%'"
        cmd = New MySqlCommand(str, conn)
        rd_1 = cmd.ExecuteReader()

        While rd_1.Read

            txtIdProduk.Text = rd_1("id_produk").ToString

        End While
    End Sub
    Private Sub AutoText()

        Call koneksi()

        str = "select id_produk, nama_produk from ms_produk where nama_produk like '%" & txtNamaProduk.Text & "%'"
        cmd = New MySqlCommand(str, conn)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable()
        da.Fill(dt)

        Dim col As New AutoCompleteStringCollection


        For i As Integer = 0 To dt.Rows.Count - 1

            col.Add(dt.Rows(i)("nama_produk"))

        Next

        txtNamaProduk.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtNamaProduk.AutoCompleteCustomSource = col
        txtNamaProduk.AutoCompleteMode = AutoCompleteMode.SuggestAppend



    End Sub

    Private Sub txtNamaProduk_TextChanged(sender As Object, e As EventArgs) Handles txtNamaProduk.TextChanged
        If txtNamaProduk.Text = "" Then
            txtIdProduk.Text = ""
        Else
            Call AutoID()

        End If


    End Sub
End Class