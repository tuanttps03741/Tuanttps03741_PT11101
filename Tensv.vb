Public Class frmTensv
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim f As New frmLogin()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        DialogResult = New DialogResult()
        DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (DialogResult = DialogResult.Yes) Then
            Close()
        End If
    End Sub
End Class