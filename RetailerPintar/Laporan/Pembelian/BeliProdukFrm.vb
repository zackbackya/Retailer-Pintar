Imports System.IO
Imports MySqlConnector
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports ClosedXML.Excel

Public Class BeliProdukFrm
    Dim Proses As New Process
    Private Sub btTampil_Click(sender As Object, e As EventArgs) Handles btTampil.Click

        If cbLaporan.SelectedItem = "" Then

            MessageBox.Show("Mophon Pilih Jenis Laporan Dahulu", "Reatiler Pintar", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            Call tampilData()

        End If


        Me.KeyPreview = True
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()

            Dim str As String



            If cbLaporan.SelectedItem = "Pembelian Produk" Then

                str = "SELECT nota, (select nama_toko from ms_toko where id_toko = a.id_toko) nama_toko, tanggal, jatuh_tempo, status_bayar, id_supplier id_produk, (select nama_supplier from ms_supplier where id_supplier = a.id_supplier) nama_supplier ,qty,harga,total_harga,keterangan FROM tx_pembelian_produk a where tanggal between '" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "' and '" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "' "

            ElseIf cbLaporan.SelectedItem = "Hutang Pembelian Produk" Then

                str = "SELECT nota, (select nama_toko from ms_toko where id_toko = a.id_toko) nama_toko, tanggal, jatuh_tempo, status_bayar, id_supplier id_produk, (select nama_supplier from ms_supplier where id_supplier = a.id_supplier) nama_supplier ,qty,harga,total_harga,keterangan FROM tx_pembelian_produk a where tanggal between '" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "' and '" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "' and status_bayar = 'Kredit'"

            ElseIf cbLaporan.SelectedItem = "Pembayaran Hutang Pembelian Produk" Then

                str = "SELECT * FROM tx_pembayaran_pembelian_produk"

            ElseIf cbLaporan.SelectedItem = "Kartu Hutang Pembelian Produk" Then

                str = ""

            ElseIf cbLaporan.SelectedItem = "Retur Pembelian Produk" Then

                str = "Select nota, (Select nama_toko from ms_toko where id_toko = a.id_toko) nama_toko, tanggal, id_supplier, id_produk, (Select nama_supplier from ms_supplier where id_supplier = a.id_supplier) nama_supplier, nama_produk ,qty,harga,total_harga,keterangan FROM tx_retur_pembelian a  where tanggal between '" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "' and '" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "' "

            End If

            da = New MySqlDataAdapter(str, conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()
            btnPrint.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call excel()
    End Sub

    Private Sub excel()

        Dim fileName As String


        If cbLaporan.SelectedItem = "Pembelian Produk" Then

            fileName = "Laporan Data Pembelian Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "Hutang Pembelian Produk" Then

            fileName = "Laporan Data Hutang Pembelian Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "Pembayaran Hutang Pembelian Produk" Then

            fileName = "Laporan Data Pembayaran Hutang Pembelian Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "Kartu Hutang Pembelian Produk" Then

            fileName = "Laporan Data Kartu Hutang Pembelian Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "retur Pembelian Produk" Then

            fileName = "Laporan Data Retur Pembelian Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        End If


        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            sfd.FileName = fileName
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook()
                        workbook.Worksheets.Add(ds.Tables(0), "laporan")
                        workbook.SaveAs(sfd.FileName)

                    End Using
                    Dim quit As String = MessageBox.Show("Laporan berhasil dicetak, Apakah ingin membuka file tsb ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If quit = DialogResult.Yes Then
                        Proses.StartInfo.FileName = sfd.FileName
                        Proses.Start()
                    ElseIf quit = DialogResult.No Then

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            End If

        End Using

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub BeliProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.f9 Then
            Call tampilData()
        ElseIf e.KeyCode = Keys.F11 Then
            Call excel()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLaporan.SelectedIndexChanged

    End Sub
End Class