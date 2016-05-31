<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBaoCao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucBaoCao))
        Me.btnBaoCaoTon = New System.Windows.Forms.Button()
        Me.btnBaoCaoNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBaoCaoTon
        '
        Me.btnBaoCaoTon.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnBaoCaoTon.FlatAppearance.BorderSize = 0
        Me.btnBaoCaoTon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaoCaoTon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaoCaoTon.ForeColor = System.Drawing.Color.Black
        Me.btnBaoCaoTon.Image = CType(resources.GetObject("btnBaoCaoTon.Image"), System.Drawing.Image)
        Me.btnBaoCaoTon.Location = New System.Drawing.Point(0, 0)
        Me.btnBaoCaoTon.Name = "btnBaoCaoTon"
        Me.btnBaoCaoTon.Size = New System.Drawing.Size(145, 70)
        Me.btnBaoCaoTon.TabIndex = 9
        Me.btnBaoCaoTon.Text = "Báo cáo tồn"
        Me.btnBaoCaoTon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBaoCaoTon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBaoCaoTon.UseVisualStyleBackColor = False
        '
        'btnBaoCaoNo
        '
        Me.btnBaoCaoNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnBaoCaoNo.FlatAppearance.BorderSize = 0
        Me.btnBaoCaoNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaoCaoNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBaoCaoNo.ForeColor = System.Drawing.Color.Black
        Me.btnBaoCaoNo.Image = CType(resources.GetObject("btnBaoCaoNo.Image"), System.Drawing.Image)
        Me.btnBaoCaoNo.Location = New System.Drawing.Point(141, 0)
        Me.btnBaoCaoNo.Name = "btnBaoCaoNo"
        Me.btnBaoCaoNo.Size = New System.Drawing.Size(145, 70)
        Me.btnBaoCaoNo.TabIndex = 10
        Me.btnBaoCaoNo.Text = "Báo cáo nợ"
        Me.btnBaoCaoNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBaoCaoNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBaoCaoNo.UseVisualStyleBackColor = False
        '
        'ucBaoCao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnBaoCaoNo)
        Me.Controls.Add(Me.btnBaoCaoTon)
        Me.Name = "ucBaoCao"
        Me.Size = New System.Drawing.Size(1024, 70)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBaoCaoTon As Button
    Friend WithEvents btnBaoCaoNo As Button
End Class
