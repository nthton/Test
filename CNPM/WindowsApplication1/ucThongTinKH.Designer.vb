<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucThongTinKH
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.dgvKhachHang = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHoTenKhachHang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaKhachHang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSoTienNo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSoDienThoai = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btnTim = New System.Windows.Forms.Button()
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvKhachHang
        '
        Me.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKhachHang.EnableHeadersVisualStyles = False
        Me.dgvKhachHang.Location = New System.Drawing.Point(62, 232)
        Me.dgvKhachHang.Name = "dgvKhachHang"
        Me.dgvKhachHang.RowHeadersVisible = False
        Me.dgvKhachHang.Size = New System.Drawing.Size(1045, 426)
        Me.dgvKhachHang.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã Khách hàng"
        '
        'txtHoTenKhachHang
        '
        Me.txtHoTenKhachHang.Location = New System.Drawing.Point(133, 60)
        Me.txtHoTenKhachHang.Name = "txtHoTenKhachHang"
        Me.txtHoTenKhachHang.ReadOnly = True
        Me.txtHoTenKhachHang.Size = New System.Drawing.Size(367, 26)
        Me.txtHoTenKhachHang.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Họ tên"
        '
        'txtMaKhachHang
        '
        Me.txtMaKhachHang.Location = New System.Drawing.Point(133, 26)
        Me.txtMaKhachHang.Name = "txtMaKhachHang"
        Me.txtMaKhachHang.ReadOnly = True
        Me.txtMaKhachHang.Size = New System.Drawing.Size(367, 26)
        Me.txtMaKhachHang.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Địa chỉ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(551, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Số điện thoại"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(551, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(133, 92)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ReadOnly = True
        Me.txtDiaChi.Size = New System.Drawing.Size(367, 26)
        Me.txtDiaChi.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(551, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tiền nợ"
        '
        'txtSoTienNo
        '
        Me.txtSoTienNo.Location = New System.Drawing.Point(659, 95)
        Me.txtSoTienNo.Name = "txtSoTienNo"
        Me.txtSoTienNo.ReadOnly = True
        Me.txtSoTienNo.Size = New System.Drawing.Size(303, 26)
        Me.txtSoTienNo.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(659, 63)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(303, 26)
        Me.txtEmail.TabIndex = 17
        '
        'txtSoDienThoai
        '
        Me.txtSoDienThoai.Location = New System.Drawing.Point(659, 26)
        Me.txtSoDienThoai.Name = "txtSoDienThoai"
        Me.txtSoDienThoai.ReadOnly = True
        Me.txtSoDienThoai.Size = New System.Drawing.Size(303, 26)
        Me.txtSoDienThoai.TabIndex = 21
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtSoDienThoai)
        Me.GroupBox4.Controls.Add(Me.txtEmail)
        Me.GroupBox4.Controls.Add(Me.txtSoTienNo)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtDiaChi)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtMaKhachHang)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtHoTenKhachHang)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(62, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1045, 138)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông tin khách hàng"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCapNhat.Location = New System.Drawing.Point(836, 181)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(113, 29)
        Me.btnCapNhat.TabIndex = 25
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnThem.Location = New System.Drawing.Point(679, 182)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(113, 29)
        Me.btnThem.TabIndex = 27
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXoa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnXoa.Location = New System.Drawing.Point(994, 181)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(113, 29)
        Me.btnXoa.TabIndex = 26
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'txtTimKiem
        '
        Me.txtTimKiem.ForeColor = System.Drawing.Color.Black
        Me.txtTimKiem.Location = New System.Drawing.Point(62, 182)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(350, 26)
        Me.txtTimKiem.TabIndex = 28
        Me.txtTimKiem.Text = "Tìm kiếm theo tên hoặc mã sách"
        '
        'btnTim
        '
        Me.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnTim.Location = New System.Drawing.Point(449, 182)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(113, 29)
        Me.btnTim.TabIndex = 29
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'ucThongTinKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnTim)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dgvKhachHang)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucThongTinKH"
        Me.Size = New System.Drawing.Size(1180, 680)
        CType(Me.dgvKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvKhachHang As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHoTenKhachHang As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaKhachHang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSoTienNo As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSoDienThoai As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents btnTim As Button
End Class
