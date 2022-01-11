Imports MySqlConnector

Public Class EditProdukFrm

    Private Sub editProduk()
        Call koneksi()
        Try
            Dim aktif, harga2, harga3 As String

            If cbAktifProduk.Checked = True Then
                aktif = "T"
            Else
                aktif = "F"
            End If

            If cbAktif2.Checked = True Then
                harga2 = "T"
            Else
                harga2 = "F"
            End If

            If cbAktif3.Checked = True Then
                harga3 = "T"
            Else
                harga3 = "F"
            End If

            cmd = New MySqlConnector.MySqlCommand("update ms_Produk set barcode = '" & txtBarcode.Text & "', nama_produk = '" & txtNamaProduk.Text & "',
                                                    nama_pendek = '" & txtNamaPendekProduk.Text & "', aktif = '" & aktif & "', 
                                                    id_supplier = '" & txtIdSupplier.Text & "', id_golongan = '" & txtIdGolongan.Text & "',
                                                    lokasi = '" & txtLokasiProduk.Text & "',harga_beli = '" & txtHargaBeliProduk.Text & "',
                                                    harga_jual_1 = '" & txtHargaJualProduk1.Text & "',stok = '" & txtStokProduk.Text & "',
                                                    harga_jual_2 = '" & txtHargaJualProduk2.Text & "', min_jual_2 = '" & txtJmlMin2.Text & "', flag_harga_2 = '" & harga2 & "',
                                                    harga_jual_3 = '" & txtHargaJualProduk3.Text & "', min_jual_3 = '" & txtJmlMin3.Text & "', flag_harga_3 = '" & harga3 & "',
                                                    where id_produk  = '" & txtIdProduk.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call ProdukFrm.tampilData()
            Me.Close()

        Catch ex As Exception

            MessageBox.Show("Update data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub EditProdukFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdProduk.Text = ProdukFrm.id_produk
        txtBarcode.Text = ProdukFrm.barcode
        txtNamaProduk.Text = ProdukFrm.nama_produk
        txtNamaPendekProduk.Text = ProdukFrm.nama_pendek
        txtIdSupplier.Text = ProdukFrm.id_supplier
        txtIdGolongan.Text = ProdukFrm.id_golongan
        txtLokasiProduk.Text = ProdukFrm.lokasi
        txtHargaBeliProduk.Text = ProdukFrm.harga_beli
        txtHargaJualProduk1.Text = ProdukFrm.harga_jual1
        txtStokProduk.Text = ProdukFrm.stok.ToString
        txtHargaJualProduk2.Text = ProdukFrm.harga_jual2
        txtHargaJualProduk3.Text = ProdukFrm.harga_jual3
        txtJmlMin2.Text = ProdukFrm.min_jual2
        txtJmlMin3.Text = ProdukFrm.min_jual3
        Call loadSupplierName()
        Call loadAllSupplierName()
        Call loadGolonganName()
        Call loadAllGolonganName()



        If ProdukFrm.aktif = "T" Then
            cbAktifProduk.Checked = True
        Else
            cbAktifProduk.Checked = False
        End If

        If ProdukFrm.flag_min2 = "T" Then
            cbAktif2.Checked = True
        Else
            cbAktif2.Checked = False
        End If

        If ProdukFrm.flag_min3 = "T" Then
            cbAktif3.Checked = True
        Else
            cbAktif3.Checked = False
        End If
        txtNamaProduk.Focus()
        Me.KeyPreview = True

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub EditProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call editProduk()
        End If
    End Sub


    Private Sub loadSupplierName()

        Call koneksi()
        Try

            Dim id As String

            id = ProdukFrm.id_supplier

            da = New MySqlDataAdapter("select * from ms_supplier where id_supplier = '" & id & "'", conn)
            ds = New DataSet
            da.Fill(ds)
            cbSupplier.DataSource = ds.Tables(0)
            cbSupplier.ValueMember = "id_supplier"
            cbSupplier.DisplayMember = "nama_supplier"
            cbSupplier.SelectedItem = "nama_supplier"

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub loadAllSupplierName()

        Call koneksi()
        Try

            da = New MySqlDataAdapter("select * from ms_supplier", conn)
            ds = New DataSet
            da.Fill(ds)
            cbSupplier.DataSource = ds.Tables(0)
            cbSupplier.ValueMember = "id_supplier"
            cbSupplier.DisplayMember = "nama_supplier"

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub cbSupplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbSupplier.SelectionChangeCommitted
        txtIdSupplier.Text = cbSupplier.SelectedValue.ToString
    End Sub

    Private Sub loadGolonganName()

        Call koneksi()
        Try

            Dim id As String

            id = ProdukFrm.id_golongan

            da = New MySqlDataAdapter("select * from ms_Golongan where id_Golongan = '" & id & "'", conn)
            ds = New DataSet
            da.Fill(ds)
            cbGolongan.DataSource = ds.Tables(0)
            cbGolongan.ValueMember = "id_Golongan"
            cbGolongan.DisplayMember = "nama_Golongan"
            cbGolongan.SelectedItem = "nama_Golongan"

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub loadAllGolonganName()

        Call koneksi()
        Try

            da = New MySqlDataAdapter("select * from ms_Golongan", conn)
            ds = New DataSet
            da.Fill(ds)
            cbGolongan.DataSource = ds.Tables(0)
            cbGolongan.ValueMember = "id_Golongan"
            cbGolongan.DisplayMember = "nama_Golongan"

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub cbGolongan_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbGolongan.SelectionChangeCommitted
        txtIdGolongan.Text = cbGolongan.SelectedValue.ToString
    End Sub



    Private Sub cbSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSupplier.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbGolongan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbGolongan.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSupplier.SelectedIndexChanged

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call editProduk()
    End Sub

    Private Sub btnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub txtBarcode_GotFocus(sender As Object, e As EventArgs) Handles txtBarcode.GotFocus
        txtBarcode.BackColor = Color.LightYellow
    End Sub

    Private Sub txtBarcode_LostFocus(sender As Object, e As EventArgs) Handles txtBarcode.LostFocus
        txtBarcode.BackColor = Color.White
    End Sub

    Private Sub txtHargaBeliProduk_GotFocus(sender As Object, e As EventArgs) Handles txtHargaBeliProduk.GotFocus
        txtHargaBeliProduk.BackColor = Color.LightYellow
    End Sub

    Private Sub txtHargaBeliProduk_LostFocus(sender As Object, e As EventArgs) Handles txtHargaBeliProduk.LostFocus
        txtHargaBeliProduk.BackColor = Color.White
    End Sub

    Private Sub txtHargaJualProduk1_GotFocus(sender As Object, e As EventArgs) Handles txtHargaJualProduk1.GotFocus
        txtHargaJualProduk1.BackColor = Color.LightYellow
    End Sub

    Private Sub txtHargaJualProduk1_LostFocus(sender As Object, e As EventArgs) Handles txtHargaJualProduk1.LostFocus
        txtHargaJualProduk1.BackColor = Color.White
    End Sub

    Private Sub txtHargaJualProduk2_GotFocus(sender As Object, e As EventArgs) Handles txtHargaJualProduk2.GotFocus
        txtHargaJualProduk2.BackColor = Color.LightYellow
    End Sub

    Private Sub txtHargaJualProduk2_LostFocus(sender As Object, e As EventArgs) Handles txtHargaJualProduk2.LostFocus
        txtHargaJualProduk2.BackColor = Color.White
    End Sub

    Private Sub txtHargaJualProduk3_GotFocus(sender As Object, e As EventArgs) Handles txtHargaJualProduk3.GotFocus
        txtHargaJualProduk3.BackColor = Color.LightYellow
    End Sub

    Private Sub txtHargaJualProduk3_LostFocus(sender As Object, e As EventArgs) Handles txtHargaJualProduk3.LostFocus
        txtHargaJualProduk3.BackColor = Color.White
    End Sub

    Private Sub txtJmlMin2_GotFocus(sender As Object, e As EventArgs) Handles txtJmlMin2.GotFocus
        txtJmlMin2.BackColor = Color.LightYellow
    End Sub

    Private Sub txtJmlMin2_LostFocus(sender As Object, e As EventArgs) Handles txtJmlMin2.LostFocus
        txtJmlMin2.BackColor = Color.White
    End Sub

    Private Sub txtJmlMin3_GotFocus(sender As Object, e As EventArgs) Handles txtJmlMin3.GotFocus
        txtJmlMin3.BackColor = Color.LightYellow
    End Sub

    Private Sub txtJmlMin3_LostFocus(sender As Object, e As EventArgs) Handles txtJmlMin3.LostFocus
        txtJmlMin3.BackColor = Color.White
    End Sub

    Private Sub txtLokasiProduk_GotFocus(sender As Object, e As EventArgs) Handles txtLokasiProduk.GotFocus
        txtLokasiProduk.BackColor = Color.LightYellow
    End Sub

    Private Sub txtLokasiProduk_LostFocus(sender As Object, e As EventArgs) Handles txtLokasiProduk.LostFocus
        txtLokasiProduk.BackColor = Color.White
    End Sub

    Private Sub txtNamaPendekProduk_GotFocus(sender As Object, e As EventArgs) Handles txtNamaPendekProduk.GotFocus
        txtNamaPendekProduk.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaPendekProduk_LostFocus(sender As Object, e As EventArgs) Handles txtNamaPendekProduk.LostFocus
        txtNamaPendekProduk.BackColor = Color.White
    End Sub

    Private Sub txtNamaProduk_GotFocus(sender As Object, e As EventArgs) Handles txtNamaProduk.GotFocus
        txtNamaProduk.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNamaProduk_LostFocus(sender As Object, e As EventArgs) Handles txtNamaProduk.LostFocus
        txtNamaProduk.BackColor = Color.White
    End Sub

    Private Sub txtStokProduk_GotFocus(sender As Object, e As EventArgs) Handles txtStokProduk.GotFocus
        txtStokProduk.BackColor = Color.LightYellow
    End Sub

    Private Sub txtStokProduk_LostFocus(sender As Object, e As EventArgs) Handles txtStokProduk.LostFocus
        txtStokProduk.BackColor = Color.White
    End Sub

    Private Sub cbGolongan_GotFocus(sender As Object, e As EventArgs) Handles cbGolongan.GotFocus
        cbGolongan.BackColor = Color.LightYellow
    End Sub

    Private Sub cbGolongan_LostFocus(sender As Object, e As EventArgs) Handles cbGolongan.LostFocus
        cbGolongan.BackColor = Color.White
    End Sub

    Private Sub cbSupplier_GotFocus(sender As Object, e As EventArgs) Handles cbSupplier.GotFocus
        cbSupplier.BackColor = Color.LightYellow
    End Sub

    Private Sub cbSupplier_LostFocus(sender As Object, e As EventArgs) Handles cbSupplier.LostFocus
        cbSupplier.BackColor = Color.White
    End Sub
End Class