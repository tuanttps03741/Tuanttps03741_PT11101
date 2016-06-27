Imports System.Data
Imports System.Data.SqlClient

Public Class frmXem
    Dim con As New SqlConnection("workstation id=AssignmentINF205Tuanttps03741.mssql.somee.com;packet size=4096;user id=tuanttps03741_SQLLogin_1;pwd=8x1i2i9ap2;data source=AssignmentINF205Tuanttps03741.mssql.somee.com;persist security info=False;initial catalog=AssignmentINF205Tuanttps03741")
    Private Sub btnKetnoi_Click(sender As Object, e As EventArgs)
        Try
            con.Open()
            MessageBox.Show("Bạn đã kết nối thành công", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối chưa thành công", "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Try
            con.Open()
            Dim com As New SqlCommand("select * from KHACHHANG where TENKH=N'" + txtTenKH.Text + "' and MAKH='" + txtMakh.Text + "'", con)
            com.ExecuteNonQuery()
            con.Close()
            Loaddata()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loaddata()
    End Sub
    Private Sub Loaddata()
        con.Open()
        Dim com As New SqlCommand("select * from KHACHHANG where TENKH=N'" + txtTenKH.Text + "' and MAKH='" + txtMakh.Text + "'", con)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable
        da.Fill(dt)
        con.Close()
        lsvXem.Items.Clear()
        Dim i As Integer
        For Each row As DataRow In dt.Rows
            lsvXem.Items.Add(row("MAKH").ToString())
            lsvXem.Items(i).SubItems.Add(row("TENKH").ToString())
            lsvXem.Items(i).SubItems.Add(row("DIACHI").ToString())
            lsvXem.Items(i).SubItems.Add(row("SDT").ToString())
            lsvXem.Items(i).SubItems.Add(row("EMAIL").ToString())
            i += 1
        Next
    End Sub


    Private Sub lsvXem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvXem.SelectedIndexChanged
        If lsvXem.SelectedItems.Count = 1 Then
            For Each list As ListViewItem In lsvXem.SelectedItems
                txtMakh.Text = list.SubItems(0).Text
                txtTenKH.Text = list.SubItems(1).Text

            Next
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim f As New frmQuanly()
        f.Show()
        Me.Hide()
    End Sub

    Public Sub Export_to_Excel(ByVal _DataSet As DataTable, ByVal _List_Col As String, ByVal Path As String)
        '- _Dataset: lưu dữu liệu cần Export
        '- _List_Col: Danh sách tên cột hiển thị. Tên cột cách nhau dấu ','
        '- Path: Đường dẫn lưu file excel

        Dim col, row As Integer
        Dim arrListcol() As String
        arrListcol = _List_Col.Split(",")

        If _DataSet.Rows.Count <= 0 Then
            Exit Sub
        End If

        Dim Excel As Object = CreateObject("Excel.Application")
        If Excel Is Nothing Then
            MessageBox.Show("Để xuất ra Excel, máy bạn phải cài đặt bộ phần mềm Microsoft Office.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'Export to Excel process
        Try
            With Excel
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()

                Dim i As Integer = 2
                .cells(1, 3).value = "Date:" + Format(Now, "MMM-dd-yyyy")
                ' .cells(1, 4).value = Format(Now, "MMM-dd-yyyy")
                .cells(2, i).value = "No"
                .cells(2, i).EntireRow.Font.Bold = True
                For col = 0 To arrListcol.Length - 1
                    i += 1
                    .cells(2, i).value = arrListcol(col).ToUpper()
                    .cells(2, i).EntireRow.Font.Name = "Times New Roman"
                    .cells(2, i).EntireRow.Font.Size = 10
                    .cells(2, i).EntireRow.Font.Bold = True
                Next
                i = 3
                Dim k As Integer = 3

                For col = 0 To _DataSet.Columns.Count - 1
                    i = 3

                    For row = 0 To _DataSet.Rows.Count - 1
                        .Cells(i, 2).Value = i - 2
                        .Cells(i, k).Value = _DataSet.Rows(row).ItemArray(col)
                        i += 1
                    Next
                    k += 1
                Next
                .Columns.AutoFit()
                .ActiveCell.Worksheet.SaveAs(Path)
            End With
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
            Excel = Nothing
            MessageBox.Show("Xuất dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim proc As System.Diagnostics.Process
            For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                proc.Kill()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        Try
            con.Open()
            Dim com As New SqlCommand("select * from KHACHHANG where TENKH=N'" + txtTenKH.Text + "' and MAKH='" + txtMakh.Text + "'", con)
            Dim da As New SqlDataAdapter(com)
            Dim dt As New DataTable
            da.Fill(dt)
            con.Close()
            SaveFileDialog1.Filter = "Excel (*.xls)|*.xls"
            SaveFileDialog1.ShowDialog()
            Dim File_name = SaveFileDialog1.FileName
            Export_to_Excel(dt, "Work oder,Squence,Process,Quantity", File_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

End Class