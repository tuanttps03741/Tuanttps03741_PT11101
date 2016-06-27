<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanpham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lsvXem = New System.Windows.Forms.ListView()
        Me.MaHD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaKH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TenKH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Soluong = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Thanhtien = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NgayHD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtThanhtien = New System.Windows.Forms.TextBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTenkh = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMakh = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMahd = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dttime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox5.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvXem
        '
        Me.lsvXem.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lsvXem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MaHD, Me.MaKH, Me.TenKH, Me.Soluong, Me.Thanhtien, Me.NgayHD})
        Me.lsvXem.Location = New System.Drawing.Point(74, 216)
        Me.lsvXem.Name = "lsvXem"
        Me.lsvXem.Size = New System.Drawing.Size(688, 180)
        Me.lsvXem.TabIndex = 27
        Me.lsvXem.UseCompatibleStateImageBehavior = False
        Me.lsvXem.View = System.Windows.Forms.View.Details
        '
        'MaHD
        '
        Me.MaHD.Text = "Mã Hóa Đơn"
        Me.MaHD.Width = 92
        '
        'MaKH
        '
        Me.MaKH.Text = "Mã Khách Hàng"
        Me.MaKH.Width = 105
        '
        'TenKH
        '
        Me.TenKH.Text = "Tên Khách Hàng"
        Me.TenKH.Width = 120
        '
        'Soluong
        '
        Me.Soluong.Text = "Số Lượng"
        Me.Soluong.Width = 97
        '
        'Thanhtien
        '
        Me.Thanhtien.Text = "Thành Tiền"
        Me.Thanhtien.Width = 112
        '
        'NgayHD
        '
        Me.NgayHD.Text = "Ngày Tạo Hóa Đơn"
        Me.NgayHD.Width = 138
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.txtThanhtien)
        Me.groupBox5.Location = New System.Drawing.Point(564, 73)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(122, 52)
        Me.groupBox5.TabIndex = 22
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Thành Tiền"
        '
        'txtThanhtien
        '
        Me.txtThanhtien.Location = New System.Drawing.Point(6, 19)
        Me.txtThanhtien.Name = "txtThanhtien"
        Me.txtThanhtien.Size = New System.Drawing.Size(100, 20)
        Me.txtThanhtien.TabIndex = 2
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.txtSoluong)
        Me.groupBox4.Location = New System.Drawing.Point(436, 73)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(122, 52)
        Me.groupBox4.TabIndex = 23
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Số Lượng"
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(6, 19)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(100, 20)
        Me.txtSoluong.TabIndex = 2
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtTenkh)
        Me.groupBox3.Location = New System.Drawing.Point(305, 73)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(125, 52)
        Me.groupBox3.TabIndex = 24
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Tên Khách Hàng"
        '
        'txtTenkh
        '
        Me.txtTenkh.Location = New System.Drawing.Point(6, 19)
        Me.txtTenkh.Name = "txtTenkh"
        Me.txtTenkh.Size = New System.Drawing.Size(100, 20)
        Me.txtTenkh.TabIndex = 2
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txtMakh)
        Me.groupBox2.Location = New System.Drawing.Point(174, 73)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(125, 52)
        Me.groupBox2.TabIndex = 25
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Mã Khách Hàng"
        '
        'txtMakh
        '
        Me.txtMakh.Location = New System.Drawing.Point(7, 18)
        Me.txtMakh.Name = "txtMakh"
        Me.txtMakh.Size = New System.Drawing.Size(100, 20)
        Me.txtMakh.TabIndex = 0
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtMahd)
        Me.groupBox1.Location = New System.Drawing.Point(43, 73)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(125, 52)
        Me.groupBox1.TabIndex = 26
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Mã Hóa Đơn"
        '
        'txtMahd
        '
        Me.txtMahd.Location = New System.Drawing.Point(6, 18)
        Me.txtMahd.Name = "txtMahd"
        Me.txtMahd.Size = New System.Drawing.Size(100, 20)
        Me.txtMahd.TabIndex = 2
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(588, 153)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(122, 36)
        Me.btnexit.TabIndex = 21
        Me.btnexit.Text = "Back"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(442, 153)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(122, 39)
        Me.btnxoa.TabIndex = 17
        Me.btnxoa.Text = "Xóa:"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.Location = New System.Drawing.Point(290, 153)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(122, 39)
        Me.btnsua.TabIndex = 18
        Me.btnsua.Text = "Sữa:"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(159, 153)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(122, 39)
        Me.btnThem.TabIndex = 19
        Me.btnThem.Text = "Thêm:"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dttime)
        Me.GroupBox6.Location = New System.Drawing.Point(692, 73)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(122, 52)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Ngày Tạo Hóa Đơn"
        '
        'dttime
        '
        Me.dttime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dttime.Location = New System.Drawing.Point(7, 20)
        Me.dttime.Name = "dttime"
        Me.dttime.Size = New System.Drawing.Size(109, 20)
        Me.dttime.TabIndex = 0
        Me.dttime.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(257, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "CẬP NHẬP SẢN PHẨM"
        '
        'frmSanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tuanttps03741_PT11101.My.Resources.Resources.B5u0Gkp
        Me.ClientSize = New System.Drawing.Size(834, 408)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsvXem)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnThem)
        Me.Name = "frmSanpham"
        Me.Text = "Sanpham"
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvXem As ListView
    Friend WithEvents MaHD As ColumnHeader
    Friend WithEvents MaKH As ColumnHeader
    Friend WithEvents TenKH As ColumnHeader
    Friend WithEvents Soluong As ColumnHeader
    Friend WithEvents Thanhtien As ColumnHeader
    Friend WithEvents NgayHD As ColumnHeader
    Private WithEvents groupBox5 As GroupBox
    Private WithEvents txtThanhtien As TextBox
    Private WithEvents groupBox4 As GroupBox
    Private WithEvents txtSoluong As TextBox
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents txtTenkh As TextBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents txtMakh As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txtMahd As TextBox
    Private WithEvents btnexit As Button
    Private WithEvents btnxoa As Button
    Private WithEvents btnsua As Button
    Private WithEvents btnThem As Button
    Private WithEvents GroupBox6 As GroupBox
    Friend WithEvents dttime As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
