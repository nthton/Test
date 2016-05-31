Public Class frmLogin
    Dim count As Integer = 0
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frmMain As New frmMain
        If txtUser.Text = "hoangton" And txtPassword.Text = "14521187" Then
            frmMain.Show()
            Me.Close()
        Else
            count += 1
            If count = 3 Then
                MsgBox("Đã nhập sai mật khẩu 3 lần, chương trình sẽ tắt.", MsgBoxStyle.Exclamation, "Thông báo")
                Me.Close()
            End If
            MsgBox("Đã nhập sai mật khẩu", MsgBoxStyle.Exclamation, "Thông báo")
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = "hoangton"
        txtPassword.Text = "14521187"
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class