<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtDiemHoa = New System.Windows.Forms.TextBox()
        Me.txtDiemLy = New System.Windows.Forms.TextBox()
        Me.txtDiemToan = New System.Windows.Forms.TextBox()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtTenSV = New System.Windows.Forms.TextBox()
        Me.txtMSSV = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvDSSV = New System.Windows.Forms.DataGridView()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.dgvDSSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.btnSua)
        Me.groupBox1.Controls.Add(Me.btnXoa)
        Me.groupBox1.Controls.Add(Me.btnThem)
        Me.groupBox1.Controls.Add(Me.txtDiemHoa)
        Me.groupBox1.Controls.Add(Me.txtDiemLy)
        Me.groupBox1.Controls.Add(Me.txtDiemToan)
        Me.groupBox1.Controls.Add(Me.txtNgaySinh)
        Me.groupBox1.Controls.Add(Me.txtTenSV)
        Me.groupBox1.Controls.Add(Me.txtMSSV)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.Black
        Me.groupBox1.Location = New System.Drawing.Point(3, 1)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(828, 184)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Thông tin sinh viên"
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(709, 140)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(83, 32)
        Me.btnSua.TabIndex = 14
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(580, 140)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(83, 32)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(444, 140)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(83, 32)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtDiemHoa
        '
        Me.txtDiemHoa.Location = New System.Drawing.Point(549, 99)
        Me.txtDiemHoa.Name = "txtDiemHoa"
        Me.txtDiemHoa.Size = New System.Drawing.Size(243, 26)
        Me.txtDiemHoa.TabIndex = 11
        '
        'txtDiemLy
        '
        Me.txtDiemLy.Location = New System.Drawing.Point(549, 66)
        Me.txtDiemLy.Name = "txtDiemLy"
        Me.txtDiemLy.Size = New System.Drawing.Size(243, 26)
        Me.txtDiemLy.TabIndex = 10
        '
        'txtDiemToan
        '
        Me.txtDiemToan.Location = New System.Drawing.Point(549, 34)
        Me.txtDiemToan.Name = "txtDiemToan"
        Me.txtDiemToan.Size = New System.Drawing.Size(243, 26)
        Me.txtDiemToan.TabIndex = 9
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.Location = New System.Drawing.Point(154, 99)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(243, 26)
        Me.txtNgaySinh.TabIndex = 8
        '
        'txtTenSV
        '
        Me.txtTenSV.Location = New System.Drawing.Point(154, 66)
        Me.txtTenSV.Name = "txtTenSV"
        Me.txtTenSV.Size = New System.Drawing.Size(243, 26)
        Me.txtTenSV.TabIndex = 7
        '
        'txtMSSV
        '
        Me.txtMSSV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMSSV.Location = New System.Drawing.Point(154, 34)
        Me.txtMSSV.Name = "txtMSSV"
        Me.txtMSSV.Size = New System.Drawing.Size(243, 26)
        Me.txtMSSV.TabIndex = 6
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(426, 105)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(80, 20)
        Me.label6.TabIndex = 5
        Me.label6.Text = "Điểm Hóa"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(426, 72)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(66, 20)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Điểm Lý"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(426, 34)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(86, 20)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Điểm Toán"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(34, 105)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(78, 20)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Ngày sinh"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(34, 72)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(101, 20)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Tên sinh viên"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(34, 34)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 20)
        Me.label1.TabIndex = 0
        Me.label1.Text = "MSSV"
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.Controls.Add(Me.dgvDSSV)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(3, 191)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(828, 269)
        Me.groupBox2.TabIndex = 3
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Danh sách sinh viên"
        '
        'dgvDSSV
        '
        Me.dgvDSSV.AllowUserToAddRows = False
        Me.dgvDSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSSV.Location = New System.Drawing.Point(9, 25)
        Me.dgvDSSV.Name = "dgvDSSV"
        Me.dgvDSSV.Size = New System.Drawing.Size(810, 238)
        Me.dgvDSSV.TabIndex = 0
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimKiem.Location = New System.Drawing.Point(12, 469)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(243, 26)
        Me.txtTimKiem.TabIndex = 16
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(281, 469)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(83, 32)
        Me.btnTimKiem.TabIndex = 17
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(712, 467)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(83, 32)
        Me.btnThoat.TabIndex = 18
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 507)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Form1"
        Me.Text = "Quản lý sinh viên"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        CType(Me.dgvDSSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnSua As Button
    Private WithEvents btnXoa As Button
    Private WithEvents txtDiemHoa As TextBox
    Private WithEvents txtDiemLy As TextBox
    Private WithEvents txtDiemToan As TextBox
    Private WithEvents txtNgaySinh As TextBox
    Private WithEvents txtTenSV As TextBox
    Private WithEvents txtMSSV As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents groupBox2 As GroupBox
    Friend WithEvents dgvDSSV As DataGridView
    Private WithEvents txtTimKiem As TextBox
    Private WithEvents btnTimKiem As Button
    Private WithEvents btnThoat As Button
    Private WithEvents btnThem As Button
End Class
