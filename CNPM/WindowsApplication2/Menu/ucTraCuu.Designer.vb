<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTraCuu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTraCuu))
        Me.btnSach = New System.Windows.Forms.Button()
        Me.btnKhachHang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSach
        '
        Me.btnSach.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSach.FlatAppearance.BorderSize = 0
        Me.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSach.ForeColor = System.Drawing.Color.Black
        Me.btnSach.Image = CType(resources.GetObject("btnSach.Image"), System.Drawing.Image)
        Me.btnSach.Location = New System.Drawing.Point(0, 0)
        Me.btnSach.Name = "btnSach"
        Me.btnSach.Size = New System.Drawing.Size(145, 70)
        Me.btnSach.TabIndex = 11
        Me.btnSach.Text = "Sách"
        Me.btnSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSach.UseVisualStyleBackColor = False
        '
        'btnKhachHang
        '
        Me.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnKhachHang.FlatAppearance.BorderSize = 0
        Me.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKhachHang.ForeColor = System.Drawing.Color.Black
        Me.btnKhachHang.Image = CType(resources.GetObject("btnKhachHang.Image"), System.Drawing.Image)
        Me.btnKhachHang.Location = New System.Drawing.Point(145, 0)
        Me.btnKhachHang.Name = "btnKhachHang"
        Me.btnKhachHang.Size = New System.Drawing.Size(145, 70)
        Me.btnKhachHang.TabIndex = 12
        Me.btnKhachHang.Text = "Khách hàng"
        Me.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnKhachHang.UseVisualStyleBackColor = False
        '
        'ucTraCuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnKhachHang)
        Me.Controls.Add(Me.btnSach)
        Me.Name = "ucTraCuu"
        Me.Size = New System.Drawing.Size(1024, 70)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSach As Button
    Friend WithEvents btnKhachHang As Button
End Class
