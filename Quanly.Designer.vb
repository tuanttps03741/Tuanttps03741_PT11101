<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanly
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnxem = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnsanpham = New System.Windows.Forms.Button()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUAN LÝ KHO "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnxem)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 153)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Xem dữ liệu"
        '
        'btnxem
        '
        Me.btnxem.BackgroundImage = Global.Tuanttps03741_PT11101.My.Resources.Resources.close_off_128
        Me.btnxem.Location = New System.Drawing.Point(0, 52)
        Me.btnxem.Name = "btnxem"
        Me.btnxem.Size = New System.Drawing.Size(104, 43)
        Me.btnxem.TabIndex = 0
        Me.btnxem.Text = "Xem:"
        Me.btnxem.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnsanpham)
        Me.GroupBox2.Controls.Add(Me.btnNhap)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(292, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 153)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nhập Kho"
        '
        'btnsanpham
        '
        Me.btnsanpham.Location = New System.Drawing.Point(6, 91)
        Me.btnsanpham.Name = "btnsanpham"
        Me.btnsanpham.Size = New System.Drawing.Size(165, 33)
        Me.btnsanpham.TabIndex = 0
        Me.btnsanpham.Text = "Sản Phẩm"
        Me.btnsanpham.UseVisualStyleBackColor = True
        '
        'btnNhap
        '
        Me.btnNhap.BackgroundImage = Global.Tuanttps03741_PT11101.My.Resources.Resources.Kính_lúp_icon
        Me.btnNhap.Location = New System.Drawing.Point(6, 37)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(131, 33)
        Me.btnNhap.TabIndex = 0
        Me.btnNhap.Text = "Nhập:"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(298, 204)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(93, 23)
        Me.btnexit.TabIndex = 0
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(12, 204)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 2
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'frmQuanly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tuanttps03741_PT11101.My.Resources.Resources.B5u0Gkp
        Me.ClientSize = New System.Drawing.Size(541, 242)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuanly"
        Me.Text = "Quanly"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnxem As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnsanpham As Button
    Friend WithEvents btnNhap As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btnback As Button
End Class
