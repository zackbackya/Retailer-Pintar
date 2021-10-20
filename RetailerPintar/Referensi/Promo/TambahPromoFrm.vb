Imports MySqlConnector

Public Class TambahPromoFrm


    Private Sub tambahData()
        Call koneksi()
        Try

            Dim tanggal_awal, tanggal_akhir, aktif As String

            If cbAktifPromo.Checked = True Then
                aktif = "T"
            Else
                aktif = "F"
            End If

            str = "insert into ms_Promo values ('" & txtIdPromo.Text & "','" & txtNamaPromo.Text & "','" & txtIdProduk.Text & "','" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "','" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "','" & aktif & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Ditambah", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call PromoFrm.tampilData()
            Call GenTempID()

            txtNamaPromo.Text = ""
            txtIdProduk.Text = ""
            txtNamaProduk.Text = ""
            cbAktifPromo.Checked = False
            txtNamaPromo.Focus()

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub TambahPromoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        Call AutoText()
        txtNamaPromo.Focus()
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TambahPromoFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdPromo.Text = idjam
    End Sub


    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()

        'MsgBox(Format(dtTanggalBuka.Value, "yyyy-MM-dd"))
    End Sub

    Private Sub btnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
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

    Private Sub txtNamaProduk_LostFocus(sender As Object, e As EventArgs) Handles txtNamaProduk.LostFocus
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
End Class