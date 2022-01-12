Imports System.Data.SqlClient
Imports MySqlConnector

Public Class AmbilItemLaporan
    Public flag_form As String
    Dim id_produk As String


    Private Sub AmbilItemLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If flag_form = "Produk" Then
            lblHeader.Text = "Ambil Data Produk"
            tampilDataProduk()
        ElseIf flag_form = "Penjualan Produk" Then
            lblHeader.Text = "Ambil Data Produk"
            tampilDataMember()
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


    Private Sub tampilDataMember()

        Try
            Call koneksi()
            cmd = New MySqlCommand("select distinct member member from tx_penjualan_det where member <> '' ", conn)
            rd_1 = cmd.ExecuteReader
            Dim source As New BindingSource
            source.DataSource = rd_1
            ckItem.DataSource = source
            ckItem.ValueMember = "member"
            ckItem.DisplayMember = "member"
            conn.Close()
            conn.Dispose()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub



    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        'MsgBox(ckItem.Item("nama_produk").ToString)

        If flag_form = "Produk" Then

            KartuStokFrm.ListItems.Clear()

            For i = 0 To (ckItem.Items.Count - 1)
                If ckItem.GetItemChecked(i) = True Then
                    KartuStokFrm.ListItems.Add(ckItem.Items(i)("id_produk").ToString)
                End If
            Next

        ElseIf flag_form = "Penjualan Produk" Then

            KartuStokFrm.ListItems.Clear()

            For i = 0 To (ckItem.Items.Count - 1)
                If ckItem.GetItemChecked(i) = True Then
                    PenjualanProdukFrm.ListMembers.Add(ckItem.Items(i)("member").ToString)
                End If
            Next

        End If

        Me.Dispose()

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub AmbilItemLaporan_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F11 Then
            Call tampilDataProduk()
        End If
    End Sub
End Class