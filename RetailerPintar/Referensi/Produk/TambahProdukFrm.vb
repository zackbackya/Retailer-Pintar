Imports MySqlConnector

Public Class TambahProdukFrm
    Dim id_supplier, id_golongan As Integer
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()
    End Sub

    Private Sub tambahData()
        Call koneksi()
        Try

            Dim aktif As String

            If cbAktifProduk.Checked = True Then
                aktif = "T"
            Else
                aktif = "F"
            End If

            str = "insert into ms_Produk values ('" & txtIdProduk.Text & "','" & txtBarcode.Text & "','" & txtNamaProduk.Text & "',
                                                    '" & txtNamaPendekProduk.Text & "','" & aktif & "','" & txtIdSupplier.Text & "',
                                                    '" & txtIdGolongan.Text & "','" & txtLokasiProduk.Text & "','" & txtHargaBeliProduk.Text & "',
                                                    '" & txtHargaJualProduk.Text & "','" & txtStokProduk.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Ditambah", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call ProdukFrm.tampilData()
            Call GenTempID()
            txtBarcode.Text = ""
            txtNamaProduk.Text = ""
            txtNamaPendekProduk.Text = ""
            txtIdSupplier.Text = ""
            txtIdGolongan.Text = ""
            txtLokasiProduk.Text = ""
            txtHargaBeliProduk.Text = ""
            txtHargaJualProduk.Text = ""
            txtStokProduk.Text = ""
            cbAktifProduk.Checked = False

            txtNamaProduk.Focus()


        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub TambahProdukFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdSupplier.Text = ""
        txtIdGolongan.Text = ""
        Call GenTempID()

        txtNamaProduk.Focus()

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Close()
    End Sub

    Private Sub TambahProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
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
End Class