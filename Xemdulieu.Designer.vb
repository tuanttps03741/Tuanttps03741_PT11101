<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXem
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
        Me.makh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tenkh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sdt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Diachi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMakh = New System.Windows.Forms.TextBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnexport = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvXem
        '
        Me.lsvXem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsvXem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.makh, Me.Tenkh, Me.Sdt, Me.Diachi, Me.Email})
        Me.lsvXem.Location = New System.Drawing.Point(30, 221)
        Me.lsvXem.Name = "lsvXem"
        Me.lsvXem.Size = New System.Drawing.Size(691, 145)
        Me.lsvXem.TabIndex = 27
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
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txtMakh)
        Me.groupBox2.Location = New System.Drawing.Point(185, 62)
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
        Me.groupBox1.Controls.Add(Me.txtTenKH)
        Me.groupBox1.Location = New System.Drawing.Point(54, 62)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(125, 52)
        Me.groupBox1.TabIndex = 26
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
        'btnback
        '
        Me.btnback.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(737, 317)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(119, 33)
        Me.btnback.TabIndex = 21
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnXem
        '
        Me.btnXem.BackgroundImage = Global.Tuanttps03741_PT11101.My.Resources.Resources.Kính_lúp_icon
        Me.btnXem.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXem.Location = New System.Drawing.Point(44, 130)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(116, 85)
        Me.btnXem.TabIndex = 19
        Me.btnXem.Text = "Xem:"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 31)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "KIỂM TRA THÔNG TIN"
        '
        'btnexport
        '
        Me.btnexport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexport.Location = New System.Drawing.Point(166, 155)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.Size = New System.Drawing.Size(195, 39)
        Me.btnexport.TabIndex = 29
        Me.btnexport.Text = "Export to Excel:"
        Me.btnexport.UseVisualStyleBackColor = True
        '
        'frmXem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Tuanttps03741_PT11101.My.Resources.Resources.B5u0Gkp
        Me.ClientSize = New System.Drawing.Size(877, 362)
        Me.Controls.Add(Me.btnexport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsvXem)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnXem)
        Me.Name = "frmXem"
        Me.Text = "Form2"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvXem As ListView
    Friend WithEvents makh As ColumnHeader
    Friend WithEvents Tenkh As ColumnHeader
    Friend WithEvents Sdt As ColumnHeader
    Friend WithEvents Diachi As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents txtMakh As TextBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents txtTenKH As TextBox
    Private WithEvents btnback As Button
    Private WithEvents btnXem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnexport As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
