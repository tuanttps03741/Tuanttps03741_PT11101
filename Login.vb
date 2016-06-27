Imports System.Data
Imports System.Data.SqlClient


Public Class frmLogin

    'buttuns thoát'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        DialogResult = New DialogResult()
        DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (DialogResult = DialogResult.Yes) Then
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim conn As New SqlConnection("workstation id=AssignmentINF205Tuanttps03741.mssql.somee.com;packet size=4096;user id=tuanttps03741_SQLLogin_1;pwd=8x1i2i9ap2;data source=AssignmentINF205Tuanttps03741.mssql.somee.com;persist security info=False;initial catalog=AssignmentINF205Tuanttps03741")
        Dim query = "select * from Taikhoandangnhap where MaKH='" + txtUser.Text + "' and MatKhau='" + txtPass.Text + "'"
        Dim sqladap = New SqlDataAdapter(query, conn)
        Dim tb As New DataTable()
        Try
            conn.Open()
            sqladap.Fill(tb)
            conn.Close()
        Catch ex As Exception

        End Try
        If (tb.Rows.Count > 0) Then
            Dim f As New frmQuanly()
            f.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usernam hoặc password của bạn chưa nhập", "Không Thành công", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class