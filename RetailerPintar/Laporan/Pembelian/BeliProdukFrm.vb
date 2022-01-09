Imports System.IO
Imports MySqlConnector
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports ClosedXML.Excel

Public Class BeliProdukFrm
    Dim Proses As New Process
    Private Sub btTampil_Click(sender As Object, e As EventArgs) Handles btTampil.Click
        Call tampilData()
        Me.KeyPreview = True
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()

            da = New MySqlDataAdapter("SELECT nota, (select nama_toko from ms_toko where id_toko = a.id_toko) nama_toko, tanggal, jatuh_tempo, status_bayar, id_supplier id_produk, (select nama_supplier from ms_supplier where id_supplier = a.id_supplier) nama_supplier ,qty,harga,total_harga,keterangan FROM tx_pembelian_produk a where tanggal between '" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "' and '" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "' ", conn)
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

    Sub cetakMasEdo()

        SaveFileDialog1.Filter = "Excel 97-2003 Workbook (*.xls)|*xls|All files(*.*)|*.*"
        SaveFileDialog1.FileName = "Laporan Data Pembelian Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xls"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim objStreamWriter As StreamWriter
            'Pass the file path and the file name to the StreamWriter constructor.
            objStreamWriter = New StreamWriter(SaveFileDialog1.FileName)
            'Write a line of text.
            objStreamWriter.WriteLine("<HTML>")
            objStreamWriter.WriteLine("<HEAD>")
            objStreamWriter.WriteLine("<b>Laporan : " & Label6.Text & "</b>")
            objStreamWriter.WriteLine("<br>")
            objStreamWriter.WriteLine("<b>Periode : " & Format(dtTanggalAwal.Value, "dd, MMMM yyyy") & " s.d " & Format(dtTanggalAkhir.Value, "dd, MMMM yyyy") & "</b>")
            objStreamWriter.WriteLine("<br>")
            objStreamWriter.WriteLine("<table border=1>")
            objStreamWriter.WriteLine("<tbody>")
            objStreamWriter.WriteLine("<tr bgcolor='#ADFF2F'>")

            objStreamWriter.WriteLine("<tr>")

            Call koneksi()
            cmd = New MySqlCommand("select * from tx_pembelian_produk where tanggal between '" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "' and '" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "' ", conn)
            rd_1 = cmd.ExecuteReader
            While rd_1.Read
                objStreamWriter.WriteLine("<tr>")

                objStreamWriter.WriteLine("<td align='left' valign='middle'>" & rd_1.NextResult.ToString & "</td>")

            End While
            conn.Close()
            objStreamWriter.Close()

            Dim quit As String = MessageBox.Show("Laporan berhasil dicetak, Apakah ingin membuka file tsb ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If quit = DialogResult.Yes Then
                Proses.StartInfo.FileName = SaveFileDialog1.FileName
                Proses.Start()
            ElseIf quit = DialogResult.No Then

            End If
        End If

    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call excel()
    End Sub

    Private Sub excel()

        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            sfd.FileName = "Laporan Data Pembelian Produk " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"
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
End Class