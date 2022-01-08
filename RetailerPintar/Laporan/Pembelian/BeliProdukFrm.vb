Imports System.IO
Imports MySqlConnector

Public Class BeliProdukFrm
    Dim Proses As New Process
    Private Sub btTampil_Click(sender As Object, e As EventArgs) Handles btTampil.Click
        Call tampilData()

    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()

            da = New MySqlDataAdapter("select * from tx_pembelian_produk where tanggal between '" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "' and '" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "' ", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.ReadOnly = True
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub cetak()

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
        Call cetak()
    End Sub
End Class