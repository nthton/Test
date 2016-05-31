<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucTroGiup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucTroGiup))
        Me.btnTTPhanMem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTTPhanMem
        '
        Me.btnTTPhanMem.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnTTPhanMem.FlatAppearance.BorderSize = 0
        Me.btnTTPhanMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTTPhanMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTTPhanMem.ForeColor = System.Drawing.Color.Black
        Me.btnTTPhanMem.Image = CType(resources.GetObject("btnTTPhanMem.Image"), System.Drawing.Image)
        Me.btnTTPhanMem.Location = New System.Drawing.Point(0, 0)
        Me.btnTTPhanMem.Name = "btnTTPhanMem"
        Me.btnTTPhanMem.Size = New System.Drawing.Size(145, 70)
        Me.btnTTPhanMem.TabIndex = 13
        Me.btnTTPhanMem.Text = "Thông tin phần mềm"
        Me.btnTTPhanMem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTTPhanMem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTTPhanMem.UseVisualStyleBackColor = False
        '
        'ucTroGiup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnTTPhanMem)
        Me.Name = "ucTroGiup"
        Me.Size = New System.Drawing.Size(1024, 70)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTTPhanMem As Button
End Class
