Public Class ReturPembelianProdukFrm
    Private Sub BtnSelesai_Click(sender As Object, e As EventArgs) Handles btnSelesai.Click
        Me.Dispose()
        Me.KeyPreview = True
        Call CheckRole()
    End Sub
    Private Sub CheckRole()

        If LoginFrm.RoleName = "ADMIN" Then
            'admin role
            btnHapus.Enabled = False
        End If

    End Sub

    Private Sub ReturPembelianProdukFrm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.F8 Then
            'Call tambahPenyesuaianStok()
        ElseIf e.KeyCode = Keys.F10 Then
            If LoginFrm.RoleName = "ADMIN" Then
                ''
            End If
        Else
            'Call hapusPenyesuaianStok()
        End If
    End Sub


End Class