Public Class TambahTokoFrm


    Private Sub tambahData()
        Call koneksi()
        Try

            Dim tanggal_buka_toko As String

            tanggal_buka_toko = Format(dtTanggalBuka.Value, "yyyy-MM-dd")

            str = "insert into ms_Toko values ('" & txtIdToko.Text & "','" & txtNamaToko.Text & "','" & txtAlamatToko.Text & "','" & txtKotaToko.Text & "','" & Format(dtTanggalBuka.Value, "yyyy-MM-dd") & "','" & txtTeleponToko.Text & "')"
            cmd = New MySqlConnector.MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil Ditambah", "Retail Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Call TokoFrm.tampilData()
            Call GenTempID()

            txtNamaToko.Text = ""
            txtAlamatToko.Text = ""
            txtTeleponToko.Text = ""
            txtNamaToko.Focus()

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub TambahTokoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GenTempID()
        txtNamaToko.Focus()
        Me.KeyPreview = True
    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub TambahTokoFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Public Sub GenTempID()
        Dim idjam As String = Format(Now(), "HHmmss")
        txtIdToko.Text = "K" + idjam
    End Sub


    Private Sub btnSimpan_Click_1(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call tambahData()

        'MsgBox(Format(dtTanggalBuka.Value, "yyyy-MM-dd"))
    End Sub

    Private Sub btnSelesai_Click_1(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub
End Class