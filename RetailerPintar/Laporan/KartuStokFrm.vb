Imports System.IO
Imports MySqlConnector
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports ClosedXML.Excel

Public Class KartuStokFrm
    Dim Proses As New Process
    Public ListItems As New List(Of String)
    Private Sub btTampil_Click(sender As Object, e As EventArgs) Handles btTampil.Click

        Call tampilData()

        Me.KeyPreview = True
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()

            If ckbItem.Checked = True Then
                str = "select * from tx_Stok where tanggal between '" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "' and '" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "'"
            ElseIf ckbItem.Checked = False Then

                Dim idprod As String
                idprod = String.Join(",", ListItems)

                str = "select * from tx_Stok where id_produk in (" & idprod & ") and tanggal between '" & Format(dtTanggalAwal.Value, "yyyy-MM-dd") & "' and '" & Format(dtTanggalAkhir.Value, "yyyy-MM-dd") & "'"
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



        fileName = "Laporan Data Kartu Stok " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".xlsx"

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

    Private Sub KartuStokFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F9 Then
            Call tampilData()
        ElseIf e.KeyCode = Keys.F11 Then
            Call excel()
        End If
    End Sub


    Private Sub KartuStokFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ckbItem.Checked = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckbItem.CheckedChanged
        If ckbItem.Checked = True Then
            btItem.Enabled = False
        ElseIf ckbItem.Checked = False Then
            btItem.Enabled = True
        End If
    End Sub

    Private Sub btItem_Click(sender As Object, e As EventArgs) Handles btItem.Click
        AmbilItemLaporan.flag_form = "Kartu"
        AmbilItemLaporan.Show()

    End Sub
End Class