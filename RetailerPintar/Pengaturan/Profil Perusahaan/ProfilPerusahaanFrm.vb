Imports MySqlConnector

Public Class ProfilPerusahaanFrm
    Private Sub ProfilPerusahaanFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call toko()
        Call tampilData()

        Me.KeyPreview = True
    End Sub

    Sub toko()
        Try
            Dim filecontents As String = System.IO.File.ReadAllText(Application.StartupPath.ToString & "\Store.ini")
            Dim lines() As String
            Dim itung As Integer
            filecontents = filecontents.Replace(ControlChars.CrLf, ControlChars.Lf)
            lines = filecontents.Split(New Char() {ControlChars.Lf, ControlChars.Cr})
            itung = 1
            Dim isi As String = lines(itung)

            txtIdToko.Text = isi
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub tampilData()
        Try

            Call koneksi()
            Dim str As String
            str = "select * from ms_Toko where id_toko = '" & txtIdToko.Text & "'"
            cmd = New MySqlCommand(str, conn)
            rd_1 = cmd.ExecuteReader
            rd_1.Read()
            txtNamaToko.Text = rd_1.Item(1)
            txtAlamatToko.Text = rd_1.Item(2)
            txtKotaToko.Text = rd_1.Item(3)
            txtTanggalBuka.Text = rd_1.Item(4)
            txtTeleponToko.Text = rd_1.Item(5)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ProfilPerusahaanFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub


    Private Sub btnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
    End Sub
End Class