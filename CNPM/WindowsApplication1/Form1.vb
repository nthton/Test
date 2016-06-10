Public Class Form1


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Panel3.Controls.Add(New ucThongTinKH)
    End Sub

    Private Sub btnTTSach_Click(sender As Object, e As EventArgs) Handles btnTTSach.Click
        Panel3.Controls.Clear()
        Panel3.Controls.Add(New ucThongTinSach)
    End Sub

    Private Sub btnTTKH_Click(sender As Object, e As EventArgs) Handles btnTTKH.Click
        Panel3.Controls.Clear()
        Panel3.Controls.Add(New ucThongTinKH)
    End Sub

    Private Sub btnThayDoiQuyDinh_Click(sender As Object, e As EventArgs) Handles btnThayDoiQuyDinh.Click
        Panel3.Controls.Clear()
        Panel3.Controls.Add(New ucThayDoiQuyDinh)
    End Sub
End Class
