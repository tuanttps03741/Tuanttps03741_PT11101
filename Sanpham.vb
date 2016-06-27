Imports System.Data
Imports System.Data.SqlClient

Public Class frmSanpham

    Dim con As New SqlConnection("workstation id=AssignmentINF205Tuanttps03741.mssql.somee.com;packet size=4096;user id=tuanttps03741_SQLLogin_1;pwd=8x1i2i9ap2;data source=AssignmentINF205Tuanttps03741.mssql.somee.com;persist security info=False;initial catalog=AssignmentINF205Tuanttps03741")
    Private Sub btnThem_Click(sender As Object, e As EventArgs) 
        Try
            con.Open()
            MessageBox.Show("Bạn đã kết nối thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối chưa thành công", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnThem_Click_1(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            con.Open()
            Dim com As New SqlCommand("insert into HOADON (MAHD,MAKH,TENKH,SOLUONG,THANHTIEN,NGAYTAOHOADON) values ('" + txtMahd.Text + "',N'" + txtMakh.Text + "','" + txtTenkh.Text + "',N'" + txtSoluong.Text + "','" + txtThanhtien.Text + "','" + dttime.Text + "')", con)
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Bạn đã nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Loaddata()
        Catch ex As Exception
            MessageBox.Show("Truy cập dữ liệu lỗi, kiểm tra lại", "Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Try
            con.Open()
            Dim com As New SqlCommand("update HOADON set MAKH='" + txtMakh.Text + "',TENKH=N'" + txtTenkh.Text + "',SOLUONG ='" + txtSoluong.Text + "',THANHTIEN= '" + txtThanhtien.Text + "',NGAYTAOHOADON='" + dttime.Text + "' where MAHD= '" + txtMahd.Text + "'", con)
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Cập nhập dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Loaddata()
        Catch ex As Exception
            MessageBox.Show("Truy cập dữ liệu lỗi, kiểm tra lại", "Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try
            con.Open()
            Dim com As New SqlCommand("delete from KHACHHANG where MAKH= '" + txtMakh.Text + "'", con)
            com.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Xóa dữ liệu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Loaddata()
        Catch ex As Exception
            MessageBox.Show("Truy cập dữ liệu lỗi, kiểm tra lại", "Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim f As New frmQuanly()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Sanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddata()
    End Sub
    Private Sub Loaddata()
        con.Open()
        Dim com As New SqlCommand("Select * From HOADON", con)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        con.Close()
        lsvXem.Items.Clear()
        Dim i As Integer
        For Each row As DataRow In dt.Rows
            lsvXem.Items.Add(row("MAHD").ToString())
            lsvXem.Items(i).SubItems.Add(row("MAKH").ToString())
            lsvXem.Items(i).SubItems.Add(row("TENKH").ToString())
            lsvXem.Items(i).SubItems.Add(row("SOLUONG").ToString())
            lsvXem.Items(i).SubItems.Add(row("THANHTIEN").ToString())
            lsvXem.Items(i).SubItems.Add(row("NGAYTAOHOADON").ToString())

            i += 1
        Next
    End Sub

    Private Sub lsvXem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvXem.SelectedIndexChanged
        If lsvXem.SelectedItems.Count = 1 Then
            For Each list As ListViewItem In lsvXem.SelectedItems
                txtMahd.Text = list.SubItems(0).Text
                txtMakh.Text = list.SubItems(1).Text
                txtTenkh.Text = list.SubItems(2).Text
                txtSoluong.Text = list.SubItems(3).Text
                txtThanhtien.Text = list.SubItems(4).Text

            Next
        End If
    End Sub
End Class