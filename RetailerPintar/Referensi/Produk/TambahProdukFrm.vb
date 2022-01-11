Imports MySqlConnector

Public Class TambahProdukFrm
    Dim id_supplier, id_golongan As Integer
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub tambahData()
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

            str = "insert into ms_Produk values ('" & txtIdProduk.Text & "','" & txtBarcode.Text & "','" & txtNamaProduk.Text & "',
                                                    '" & txtNamaPendekProduk.Text & "','" & aktif & "','" & txtIdSupplier.Text & "',
                                                    '" & txtIdGolongan.Text & "','" & txtLokasiProduk.Text & "','" & txtHargaBeliProduk.Text & "',
                                                    '" & txtHargaJualProduk1.Text & "','" & txtHargaJualProduk2.Text & "','" & txtJmlMin2.Text & "','" & harga2 & "','" & txtHargaJualProduk3.Text & "','" & txtJmlMin3.Text & "','" & harga3 & "','" & txtStokProduk.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil ditambah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call ProdukFrm.tampilData()
            Call GenTempID()
            txtBarcode.Text = ""
            txtNamaProduk.Text = ""
            txtNamaPendekProduk.Text = ""
            txtIdSupplier.Text = ""
            txtIdGolongan.Text = ""
            txtLokasiProduk.Text = ""
            txtHargaBeliProduk.Text = ""
            txtHargaJualProduk1.Text = ""
            txtStokProduk.Text = ""
            cbAktifProduk.Checked = False

            txtNamaProduk.Focus()


        Catch ex As Exception

            MessageBox.Show("Tambah data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub TambahProdukFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdSupplier.Text = ""
        txtIdGolongan.Text = ""
        Call GenTempID()

        txtNamaProduk.Focus()
        Me.KeyPreview = True

        txtHargaJualProduk2.Enabled = False
        txtJmlMin2.Enabled = False
        txtHargaJualProduk3.Enabled = False
        txtJmlMin3.Enabled = False
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub TambahProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdProduk.Text = idjam
    End Sub

    Private Sub loadSupplier()
        Try
            Call koneksi()

            da = New MySqlDataAdapter("select * from ms_supplier", conn)
            ds = New DataSet
            da.Fill(ds)
            cbSupplier.DataSource = ds.Tables(0)
            cbSupplier.ValueMember = "id_supplier"
            cbSupplier.DisplayMember = "nama_supplier"
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub loadGolongan()
        Try
            Call koneksi()

            da = New MySqlDataAdapter("select * from ms_golongan", conn)
            ds = New DataSet
            da.Fill(ds)
            cbGolongan.DataSource = ds.Tables(0)
            cbGolongan.ValueMember = "id_golongan"
            cbGolongan.DisplayMember = "nama_golongan"
            conn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbGolongan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGolongan.SelectedIndexChanged
        txtIdGolongan.Text = cbGolongan.SelectedValue.ToString
    End Sub

    Private Sub CbSupplier_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbSupplier.SelectedIndexChanged

        txtIdSupplier.Text = cbSupplier.SelectedValue.ToString

    End Sub

    Private Sub cbSupplier_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cbGolongan_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private Sub cbSupplier_Click(sender As Object, e As EventArgs) Handles cbSupplier.Click
        Call loadSupplier()
    End Sub
    Private Sub cbGolongan_Click(sender As Object, e As EventArgs) Handles cbGolongan.Click
        Call loadGolongan()
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

    Private Sub txtStokProduk_GotFocus(sender As Object, e As EventArgs)
        txtStokProduk.BackColor = Color.LightYellow
    End Sub

    Private Sub txtStokProduk_LostFocus(sender As Object, e As EventArgs)
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

    Private Sub cbAktif2_CheckedChanged(sender As Object, e As EventArgs) Handles cbAktif2.CheckedChanged
        Try
            If cbAktif2.Checked = True Then
                txtHargaJualProduk2.Enabled = True
                txtJmlMin2.Enabled = True
            Else
                txtHargaJualProduk2.Enabled = False
                txtJmlMin2.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbAktif3_CheckedChanged(sender As Object, e As EventArgs) Handles cbAktif3.CheckedChanged
        Try
            If cbAktif3.Checked = True Then
                txtHargaJualProduk3.Enabled = True
                txtJmlMin3.Enabled = True
            Else
                txtHargaJualProduk3.Enabled = False
                txtJmlMin3.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class