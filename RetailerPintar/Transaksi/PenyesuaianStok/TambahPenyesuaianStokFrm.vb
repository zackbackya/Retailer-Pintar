Imports MySqlConnector

Public Class TambahPenyesuaianStokFrm


    Private Sub tambahData()
        Call koneksi()
        Try

            Dim tanggal_buka_PenyesuaianStok As String

            tanggal_buka_PenyesuaianStok = Format(dtTanggal.Value, "yyyy-MM-dd")

            str = "insert into tx_penyesuaian_stok values ('" & txtFaktur.Text & "','" & txtIdToko.Text & "', '" & txtIdProduk.Text & "','" & txtBarcode.Text & "','" & txtNamaProduk.Text & "','" & Format(dtTanggal.Value, "yyyy-MM-dd") & "','" & txtQty.Text & "','" & txtAlasan.Text & "','" & txtKeterangan.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Ditambah", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call PenyesuaianStokFrm.tampilData()
            Call GenTempID()

            txtNamaProduk.Text = ""
            txtNamaToko.Text = ""
            txtBarcode.Text = ""
            txtQty.Text = ""
            txtAlasan.Text = ""
            txtKeterangan.Text = ""
            txtNamaProduk.Focus()

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub TambahPenyesuaianStokFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        Call AutoTextProduk()
        Call AutoTextToko()
        txtNamaToko.Focus()
        Me.KeyPreview = True

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub TambahPenyesuaianStokFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtFaktur.Text = "ST-" + idjam
    End Sub


    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()

        'MsgBox(Format(dtTanggal.Value, "yyyy-MM-dd"))
    End Sub

    Private Sub btnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        'Me.Dispose()
        Me.Dispose()
    End Sub
    Private Sub AutoTextProduk()

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

    Private Sub getIdProduk()
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

    Private Sub txtNamaProduk_TextChanged(sender As Object, e As EventArgs) Handles txtNamaProduk.TextChanged

        If txtNamaProduk.Text = "" Then
            txtIdProduk.Text = ""
        Else
            Call getIdProduk()
        End If
    End Sub

    Private Sub AutoTextToko()

        Call koneksi()

        str = "select id_Toko, nama_Toko from ms_Toko where nama_Toko like '%" & txtNamaToko.Text & "%'"
        cmd = New MySqlCommand(str, conn)
        da = New MySqlDataAdapter(cmd)
        dt = New DataTable()
        da.Fill(dt)

        Dim col As New AutoCompleteStringCollection


        For i As Integer = 0 To dt.Rows.Count - 1

            col.Add(dt.Rows(i)("nama_Toko"))

        Next

        txtNamaToko.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtNamaToko.AutoCompleteCustomSource = col
        txtNamaToko.AutoCompleteMode = AutoCompleteMode.SuggestAppend



    End Sub

    Private Sub getIdToko()
        Dim id_Toko As String
        Call koneksi()

        'If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

        str = "select id_Toko, nama_Toko from ms_Toko where nama_Toko like '%" & txtNamaToko.Text & "%'"
        cmd = New MySqlCommand(str, conn)
        rd_1 = cmd.ExecuteReader()

        While rd_1.Read

            txtIdToko.Text = rd_1("id_Toko").ToString

        End While
    End Sub

    Private Sub txtNamaToko_TextChanged(sender As Object, e As EventArgs) Handles txtNamaToko.TextChanged

        If txtNamaToko.Text = "" Then
            txtIdToko.Text = ""
        Else
            Call getIdToko()
        End If
    End Sub
End Class