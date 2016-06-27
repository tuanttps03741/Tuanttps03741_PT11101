<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmnhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMakh = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.lsvXem = New System.Windows.Forms.ListView()
        Me.makh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tenkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sdt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Diachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox5.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(603, 144)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(122, 36)
        Me.btnexit.TabIndex = 10
        Me.btnexit.Text = "Back"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(457, 144)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(122, 39)
        Me.btnxoa.TabIndex = 6
        Me.btnxoa.Text = "Xóa:"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.Location = New System.Drawing.Point(305, 144)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(122, 39)
        Me.btnsua.TabIndex = 7
        Me.btnsua.Text = "Sữa:"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.txtEmail)
        Me.groupBox5.Location = New System.Drawing.Point(579, 64)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(122, 52)
        Me.groupBox5.TabIndex = 11
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(6, 19)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 2
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.txtDiachi)
        Me.groupBox4.Location = New System.Drawing.Point(451, 64)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(122, 52)
        Me.groupBox4.TabIndex = 12
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Địa Chỉ"
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(6, 19)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(100, 20)
        Me.txtDiachi.TabIndex = 2
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtSDT)
        Me.groupBox3.Location = New System.Drawing.Point(320, 64)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(125, 52)
        Me.groupBox3.TabIndex = 13
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Số Điện Thoại"
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(6, 19)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(100, 20)
        Me.txtSDT.TabIndex = 2
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txtMakh)
        Me.groupBox2.Location = New System.Drawing.Point(189, 64)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(125, 52)
        Me.groupBox2.TabIndex = 14
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
        Me.groupBox1.Controls.Add(Me.txtTenKH)
        Me.groupBox1.Location = New System.Drawing.Point(58, 64)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(125, 52)
        Me.groupBox1.TabIndex = 15
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Tên Khách Hàng"
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(6, 18)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(100, 20)
        Me.txtTenKH.TabIndex = 2
        '
        'lsvXem
        '
        Me.lsvXem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvXem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.makh, Me.Tenkh, Me.Sdt, Me.Diachi, Me.Email})
        Me.lsvXem.Location = New System.Drawing.Point(34, 195)
        Me.lsvXem.Name = "lsvXem"
        Me.lsvXem.Size = New System.Drawing.Size(688, 178)
        Me.lsvXem.TabIndex = 16
        Me.lsvXem.UseCompatibleStateImageBehavior = False
        Me.lsvXem.View = System.Windows.Forms.View.Details
        '
        'makh
        '
        Me.makh.Text = "Mã Khách Hàng"
        Me.makh.Width = 121
        '
        'Tenkh
        '
        Me.Tenkh.Text = "Tên Khách Hàng"
        Me.Tenkh.Width = 159
        '
        'Sdt
        '
        Me.Sdt.Text = "SDT"
        Me.Sdt.Width = 94
        '
        'Diachi
        '
        Me.Diachi.Text = "Địa Chỉ"
        Me.Diachi.Width = 118
        '
        'Email
        '
        Me.Email.Text = "Email"
        Me.Email.Width = 136
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(174, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Thêm:"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(483, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NHẬP DỮ LIỆU TÊN KHÁCH HÀNG"
        '
        'frmnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tuanttps03741_PT11101.My.Resources.Resources.B5u0Gkp
        Me.ClientSize = New System.Drawing.Size(756, 385)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsvXem)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmnhap"
        Me.Text = "Form1"
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnexit As Button
    Private WithEvents btnxoa As Button
    Private WithEvents btnsua As Button
    Private WithEvents groupBox5 As GroupBox
    Private WithEvents txtEmail As TextBox
    Private WithEvents groupBox4 As GroupBox
    Private WithEvents txtDiachi As TextBox
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents txtSDT As TextBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents txtMakh As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txtTenKH As TextBox
    Friend WithEvents lsvXem As ListView
    Friend WithEvents makh As ColumnHeader
    Friend WithEvents Tenkh As ColumnHeader
    Friend WithEvents Sdt As ColumnHeader
    Friend WithEvents Diachi As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Private WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
