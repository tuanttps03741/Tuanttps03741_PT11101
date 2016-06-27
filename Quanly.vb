Public Class frmQuanly
    Private Sub btnxem_Click(sender As Object, e As EventArgs) Handles btnxem.Click
        Dim f As New frmXem()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        DialogResult = New DialogResult()
        DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (DialogResult = DialogResult.Yes) Then
            Close()
        End If
    End Sub

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        Dim f As New frmnhap()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim f As New frmLogin()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnsanpham_Click(sender As Object, e As EventArgs) Handles btnsanpham.Click
        Dim f As New frmSanpham
        f.Show()
        Me.Hide()
    End Sub
End Class