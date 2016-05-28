Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f2 As New frmGhi
        f2.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f1 As New frmDoc
        f1.ShowDialog()
    End Sub
End Class
