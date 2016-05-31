<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucHeThong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucHeThong))
        Me.btnThayDoiQuyDinh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnThayDoiQuyDinh
        '
        Me.btnThayDoiQuyDinh.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnThayDoiQuyDinh.FlatAppearance.BorderSize = 0
        Me.btnThayDoiQuyDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThayDoiQuyDinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThayDoiQuyDinh.ForeColor = System.Drawing.Color.Black
        Me.btnThayDoiQuyDinh.Image = CType(resources.GetObject("btnThayDoiQuyDinh.Image"), System.Drawing.Image)
        Me.btnThayDoiQuyDinh.Location = New System.Drawing.Point(0, 0)
        Me.btnThayDoiQuyDinh.Name = "btnThayDoiQuyDinh"
        Me.btnThayDoiQuyDinh.Size = New System.Drawing.Size(145, 70)
        Me.btnThayDoiQuyDinh.TabIndex = 3
        Me.btnThayDoiQuyDinh.Text = "Thay đổi quy định"
        Me.btnThayDoiQuyDinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnThayDoiQuyDinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnThayDoiQuyDinh.UseVisualStyleBackColor = False
        '
        'ucHeThong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnThayDoiQuyDinh)
        Me.Name = "ucHeThong"
        Me.Size = New System.Drawing.Size(1024, 70)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnThayDoiQuyDinh As Button
End Class
