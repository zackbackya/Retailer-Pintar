Imports System.Drawing.Printing
Imports MySqlConnector

Public Class PengaturanUmumFrm


    Private Sub PengaturanUmumFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Call Printer()
    End Sub

    Public Sub tampilData()
        Try
            Call koneksi()
            Dim str As String
            str = "select * from ms_nota"
            cmd = New MySqlCommand(str, conn)
            rd_1 = cmd.ExecuteReader
            rd_1.Read()
            txtHeader1.Text = rd_1.Item(1)
            txtHeader2.Text = rd_1.Item(2)
            txtHeader3.Text = rd_1.Item(3)
            txtFooter1.Text = rd_1.Item(4)
            txtFooter2.Text = rd_1.Item(5)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If tabSetting.SelectedTab.Name = "tabNota" Then
            Call editToko()
        Else

            If SetDefaulPrinter(ComboBox1.Text) = True Then
                MessageBox.Show("Printer default menjadi " & ComboBox1.Text, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Printer " & ComboBox1.Text & " Error ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If
    End Sub

    Private Sub editToko()

        Call koneksi()
        Try

            cmd = New MySqlConnector.MySqlCommand("update ms_nota set header_1 = '" & txtHeader1.Text & "', header_2 = '" & txtHeader2.Text & "', header_3 = '" & txtHeader3.Text & "', footer_1 = '" & txtFooter1.Text & "',footer_2 = '" & txtFooter2.Text & "' ", conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Anda berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TokoFrm.tampilData()

        Catch ex As Exception

            MessageBox.Show("Update data gagal, Silahkan cek kembali data Anda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub


    Private Sub Printer()

        Dim strInstalledPrinters As String
        Dim prntDoc As New PrintDocument

        'check if there is installed printer
        If PrinterSettings.InstalledPrinters.Count = 0 Then
            MsgBox("No printer installed")
            Exit Sub
        End If

        'display installed printer into combobox list item
        For Each strInstalledPrinters In PrinterSettings.InstalledPrinters
            ComboBox1.Items.Add(strInstalledPrinters)
        Next strInstalledPrinters

        'Display current default printer on combobox texts
        ComboBox1.Text = prntDoc.PrinterSettings.PrinterName



    End Sub

    Function SetDefaulPrinter(ByVal strPrinterName As String) As Boolean
        Dim strCurrPrinter As String
        Dim WsNetwork As Object
        Dim prntDoc As New PrintDocument

        strCurrPrinter = prntDoc.PrinterSettings.PrinterName
        WsNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")

        Try
            WsNetwork.SetDefaultPrinter(strPrinterName)
            prntDoc.PrinterSettings.PrinterName = strPrinterName

            'set default if selected printer name is a valid installed printer
            If prntDoc.PrinterSettings.IsValid Then
                Return True
            Else
                WsNetwork.SetDefaultPrinter(strCurrPrinter)
                Return False
            End If
        Catch ex As Exception
            WsNetwork.SetDefaultPrinter(strCurrPrinter)
            Return False
        Finally
            WsNetwork = Nothing
            prntDoc = Nothing
        End Try
    End Function
End Class



