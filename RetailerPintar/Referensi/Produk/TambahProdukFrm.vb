Public Class TambahProdukFrm
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


End Class