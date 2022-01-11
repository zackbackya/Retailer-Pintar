Imports ClosedXML.Excel
Imports System.IO
Imports ExcelDataReader
Imports System.Data.OleDb
Imports System.Data.Odbc

Public Class UploadProdukFrm

    Dim Proses As Process
    Dim tables As DataTableCollection
    Dim fileName As String
    Dim conexcel As OleDbConnection
    Dim daexcel As OleDbDataAdapter
    Dim dsexcel As DataSet
    Dim cmdexcel As OleDbCommand
    Dim drexcel As OleDbDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btContoh.Click

        Dim quit As String = MessageBox.Show("Apakah ingin membuka file Contoh ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quit = DialogResult.Yes Then
            Dim filename As String
            filename = Application.StartupPath & "\contoh_upload_produk.xls"

            Proses.Start(filename)

        ElseIf quit = DialogResult.No Then

        End If




    End Sub

    Private Sub btBrowse_Click(sender As Object, e As EventArgs) Handles btBrowse.Click
        Call toGrid()

    End Sub

    Private Sub toGrid()

        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel Workbook|*.xls"}
            ofd.FileName = fileName
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    txtFilename.Text = ofd.FileName

                    '
                    'conexcel = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source = " & txtFilename.Text & ";Extended Properties=Excel 8.0;")

                    conexcel = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & txtFilename.Text & ";Extended Properties=Excel 8.0;")

                    daexcel = New OleDbDataAdapter("select * from [Sheet1$]", conexcel)
                    dsexcel = New DataSet
                    daexcel.Fill(dsexcel, "[Sheet1$]")
                    DGV.DataSource = dsexcel
                    DGV.DataMember = "[Sheet1$]"
                    conexcel.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            End If

        End Using


    End Sub



    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click


        Call Upload()


    End Sub

    Private Sub Upload()

        If txtFilename.Text <> "" Then


            daexcel = New OleDbDataAdapter("select * from [Sheet1$]", conexcel)
            dsexcel = New DataSet
            daexcel.Fill(dsexcel)
            DGV.DataSource = dsexcel.Tables(0)
            DGV.ReadOnly = True

            Dim str As String

            Try

                For baris As Integer = 0 To DGV.RowCount - 2
                    Call koneksi()




                    str = " insert into ms_produk (id_produk,barcode,nama_produk,nama_pendek,aktif,id_supplier,id_golongan,lokasi,harga_beli,harga_jual_1,stok)" +
              "Values ('" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(1).Value & "','" & DGV.Rows(baris).Cells(2).Value & "'," +
                     "'" & DGV.Rows(baris).Cells(3).Value & "','F','" & DGV.Rows(baris).Cells(4).Value & "','" & DGV.Rows(baris).Cells(5).Value & "'," +
                    "'" & DGV.Rows(baris).Cells(6).Value & "','" & DGV.Rows(baris).Cells(7).Value & "','" & DGV.Rows(baris).Cells(8).Value & "','" & DGV.Rows(baris).Cells(9).Value & "')"

                    'str = " insert 'id_produk','barcode','nama_produk','nama_pendek','aktif','id_supplier','id_golongan','lokasi','harga_beli','stok' into ms_produk Values ('" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(1).Value & "','" & DGV.Rows(baris).Cells(2).Value & "', '" & DGV.Rows(baris).Cells(3).Value & "','F','" & DGV.Rows(baris).Cells(4).Value & "','" & DGV.Rows(baris).Cells(5).Value & "','" & DGV.Rows(baris).Cells(6).Value & "','" & DGV.Rows(baris).Cells(7).Value & "','" & DGV.Rows(baris).Cells(8).Value & "', '" & DGV.Rows(baris).Cells(9).Value & "')"

                    cmd = New MySqlConnector.MySqlCommand(str, conn)
                    cmd.ExecuteNonQuery()

                Next

                MessageBox.Show("Data Anda berhasil ditambah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Gagal Tambah Data, Pastikan ID Produk belum terdaftar pada database Aplikasi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try



            Call ProdukFrm.tampilData()

        Else
            MessageBox.Show("Silahkan Pilih File Terlebih Dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub

    Private Sub UploadProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F11 Then
            Call Upload()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub UploadProdukFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class