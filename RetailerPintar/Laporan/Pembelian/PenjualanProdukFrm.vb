Imports System.IO
Imports MySqlConnector
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports ClosedXML.Excel

Public Class PenjualanProdukFrm
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

            If cbLaporan.SelectedItem = "Penjualan Produk" Then

                str = ""

            ElseIf cbLaporan.SelectedItem = "Penjualan Per Produk" Then

                str = ""
            ElseIf cbLaporan.SelectedItem = "Penjualan Per Golongan" Then

                str = ""
            ElseIf cbLaporan.SelectedItem = "Penjualan Per Kasir" Then

                str = ""

            ElseIf cbLaporan.SelectedItem = "Penjualan Produk Favorit" Then

                str = ""
            ElseIf cbLaporan.SelectedItem = "Customer Produk" Then

                str = ""
            ElseIf cbLaporan.SelectedItem = "Retur Penjualan Produk" Then

                str = ""
            ElseIf cbLaporan.SelectedItem = "Laba/ Rugi Penjualan" Then

                str = ""
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

        If cbLaporan.SelectedItem = "Penjualan Produk" Then

            fileName = "Laporan Data Penjualan Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "Penjualan Per Produk" Then
            fileName = "Laporan Data Penjualan Per Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "Penjualan Per Golongan" Then

            fileName = "Laporan Data Penjualan Per Golongan " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "Penjualan Per Kasir" Then

            fileName = "Laporan Data Penjualan Per Kasir " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "Penjualan Produk Favorit" Then

            fileName = "Laporan Data Penjualan Produk Favorit " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "Customer Produk" Then

            fileName = "Laporan Data Customer Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "Retur Penjualan Produk" Then

            fileName = "Laporan Data Retur Penjualan Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

        ElseIf cbLaporan.SelectedItem = "Laba/ Rugi Penjualan" Then

            fileName = "Laporan Data Laba/ Rugi Penjualan " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

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

    Private Sub PenjualanProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F9 Then
            Call tampilData()
        ElseIf e.KeyCode = Keys.F11 Then
            Call excel()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLaporan.SelectedIndexChanged

    End Sub

    Private Sub PenjualanProdukFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class