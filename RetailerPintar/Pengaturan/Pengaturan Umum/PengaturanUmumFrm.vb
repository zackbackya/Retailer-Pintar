Imports System.Drawing.Printing
Imports MySqlConnector

Public Class PengaturanUmumFrm

    Dim path_logo As String
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
            txtPath.Text = rd_1.Item(6)

            'PictureBox1.ImageLocation(Application.StartupPath() & "\logo.jpg")

            PictureBox1.ImageLocation = rd_1.Item(6) 'untuk mencari lokasi gambar pada direktori
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            If txtPath.Text = "" Then
                Label7.Visible = True
                TextBox1.Visible = True
            End If


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

            cmd = New MySqlConnector.MySqlCommand("update ms_nota set header_1 = '" & txtHeader1.Text & "', header_2 = '" & txtHeader2.Text & "', header_3 = '" & txtHeader3.Text & "', footer_1 = '" & txtFooter1.Text & "',footer_2 = '" & txtFooter2.Text & "', path_logo = '" & path_logo & "' ", conn)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btGambar.Click
        Call gambar()
    End Sub

    Private Sub gambar()
        On Error Resume Next
        Dim sfd As OpenFileDialog = New OpenFileDialog()
        sfd.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff"
        sfd.FileName = ""
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Image = New Bitmap(sfd.FileName)
            btGambar.Enabled = True
            path_logo = sfd.FileName
            'txt_nmgambar.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            txtPath.Text = sfd.FileName
            PictureBox1.Image = Image.FromFile(txtPath.Text)
        End If
    End Sub


    Private Sub tampilGambar()
        Call koneksi()
        Dim sql As String = ("select*from ms_nota where kd_gambar")
        Dim cmd = New MySqlCommand(sql, conn)
        Dim rd As MySqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            ' txt_nmgambar.Text = rd.Item("nama")
            ' lbl_alamat.Text = rd.Item("alamat")
            ' pct_gambar.ImageLocation = rd.Item("alamat") 'untuk mencari lokasi gambar pada direktori
            ' pct_gambar.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

End Class



