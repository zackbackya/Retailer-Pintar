Imports System.Data.SqlClient
Imports MySqlConnector

Public Class AmbilItemLaporan
    Public flag_form As String

    Private Sub AmbilItemLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If flag_form = "Kartu" Then
            lblHeader.Text = "Ambil Data Produk"
            tampilDataProduk()
        End If
    End Sub

    Private Sub tampilDataProduk()


        Try

            Call koneksi()
            cmd = New MySqlCommand("select id_produk, nama_produk from ms_produk", conn)
            rd_1 = cmd.ExecuteReader
            Dim source As New BindingSource
            source.DataSource = rd_1
            ckItem.DataSource = source
            ckItem.ValueMember = "id_produk"
            ckItem.DisplayMember = "nama_produk"
            conn.Close()
            conn.Dispose()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        'MsgBox(ckItem.Item("nama_produk").ToString)
    End Sub
End Class