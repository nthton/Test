<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThongTinSach
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Luoi_sach = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbTheLoai = New System.Windows.Forms.ComboBox()
        Me.txtSoLuongTon = New System.Windows.Forms.TextBox()
        Me.txtDonGiaDK = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenSach = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Luoi_sach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Luoi_sach
        '
        Me.Luoi_sach.AllowUserToAddRows = False
        Me.Luoi_sach.AllowUserToDeleteRows = False
        Me.Luoi_sach.AllowUserToResizeRows = False
        Me.Luoi_sach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Luoi_sach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Luoi_sach.ColumnHeadersHeight = 25
        Me.Luoi_sach.EnableHeadersVisualStyles = False
        Me.Luoi_sach.Location = New System.Drawing.Point(62, 232)
        Me.Luoi_sach.Name = "Luoi_sach"
        Me.Luoi_sach.ReadOnly = True
        Me.Luoi_sach.RowHeadersVisible = False
        Me.Luoi_sach.Size = New System.Drawing.Size(1045, 426)
        Me.Luoi_sach.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbTheLoai)
        Me.GroupBox4.Controls.Add(Me.txtSoLuongTon)
        Me.GroupBox4.Controls.Add(Me.txtDonGiaDK)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtTacGia)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtMaSach)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtTenSach)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(62, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1045, 138)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thông tin sách"
        '
        'cbTheLoai
        '
        Me.cbTheLoai.Enabled = False
        Me.cbTheLoai.FormattingEnabled = True
        Me.cbTheLoai.Location = New System.Drawing.Point(745, 27)
        Me.cbTheLoai.Name = "cbTheLoai"
        Me.cbTheLoai.Size = New System.Drawing.Size(205, 28)
        Me.cbTheLoai.TabIndex = 18
        '
        'txtSoLuongTon
        '
        Me.txtSoLuongTon.Location = New System.Drawing.Point(745, 61)
        Me.txtSoLuongTon.Name = "txtSoLuongTon"
        Me.txtSoLuongTon.ReadOnly = True
        Me.txtSoLuongTon.Size = New System.Drawing.Size(205, 26)
        Me.txtSoLuongTon.TabIndex = 17
        '
        'txtDonGiaDK
        '
        Me.txtDonGiaDK.Location = New System.Drawing.Point(745, 93)
        Me.txtDonGiaDK.Name = "txtDonGiaDK"
        Me.txtDonGiaDK.ReadOnly = True
        Me.txtDonGiaDK.Size = New System.Drawing.Size(205, 26)
        Me.txtDonGiaDK.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(571, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Đơn giá bán dự kiến"
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(90, 90)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.ReadOnly = True
        Me.txtTacGia.Size = New System.Drawing.Size(407, 26)
        Me.txtTacGia.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(571, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Số lượng tồn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(571, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Thể loại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tác giả"
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(90, 24)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.ReadOnly = True
        Me.txtMaSach.Size = New System.Drawing.Size(407, 26)
        Me.txtMaSach.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tên sách"
        '
        'txtTenSach
        '
        Me.txtTenSach.Location = New System.Drawing.Point(90, 58)
        Me.txtTenSach.Name = "txtTenSach"
        Me.txtTenSach.ReadOnly = True
        Me.txtTenSach.Size = New System.Drawing.Size(407, 26)
        Me.txtTenSach.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã sách"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(994, 181)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 29)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Xóa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapNhat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCapNhat.Location = New System.Drawing.Point(832, 181)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(113, 29)
        Me.btnCapNhat.TabIndex = 19
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnThem.Location = New System.Drawing.Point(670, 181)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(113, 29)
        Me.btnThem.TabIndex = 21
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtTimKiem
        '
        Me.txtTimKiem.ForeColor = System.Drawing.Color.Black
        Me.txtTimKiem.Location = New System.Drawing.Point(62, 182)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(350, 26)
        Me.txtTimKiem.TabIndex = 22
        Me.txtTimKiem.Text = "Tìm kiếm theo tên hoặc mã sách"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(446, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 29)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Tìm"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ucThongTinSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Luoi_sach)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucThongTinSach"
        Me.Size = New System.Drawing.Size(1160, 680)
        CType(Me.Luoi_sach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Luoi_sach As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents cbTheLoai As ComboBox
    Friend WithEvents txtSoLuongTon As TextBox
    Friend WithEvents txtDonGiaDK As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTacGia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaSach As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTenSach As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents Button2 As Button
End Class
