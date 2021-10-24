Imports MySqlConnector

Public Class EditProdukFrm

    Private Sub editProduk()
        Call koneksi()
        Try
            Dim aktif As String

            If cbAktifProduk.Checked = True Then
                aktif = "T"
            Else
                aktif = "F"
            End If


            cmd = New MySqlConnector.MySqlCommand("update ms_Produk set barcode = '" & txtBarcode.Text & "', nama_produk = '" & txtNamaProduk.Text & "',
                                                    nama_pendek = '" & txtNamaPendekProduk.Text & "', aktif = '" & aktif & "', 
                                                    id_supplier = '" & txtIdSupplier.Text & "', id_golongan = '" & txtIdGolongan.Text & "',
                                                    lokasi = '" & txtLokasiProduk.Text & "',harga_beli = '" & txtHargaBeliProduk.Text & "',
                                                    harga_jual = '" & txtHargaJualProduk.Text & "',stok = '" & txtStokProduk.Text & "'
                                                    where id_produk  = '" & txtIdProduk.Text & "'", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Diupdate", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call ProdukFrm.tampilData()

        Catch ex As Exception

            MsgBox(ex.ToString)

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
        txtHargaJualProduk.Text = ProdukFrm.harga_jual
        txtStokProduk.Text = ProdukFrm.stok.ToString
        Call loadSupplierName()
        Call loadAllSupplierName()
        Call loadGolonganName()
        Call loadAllGolonganName()



        If ProdukFrm.aktif = "T" Then
            cbAktifProduk.Checked = True
        Else
            cbAktifProduk.Checked = False
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

    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs)

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
End Class