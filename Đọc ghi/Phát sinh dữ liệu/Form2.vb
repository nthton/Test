Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Kiểm tra dữ liệu nhập
        Dim Bang As DataTable = LT_BANG.DOC("Select * From Don_vi")
        Dim So_don_vi = TextBox1.Text
        For i As Integer = 1 To So_don_vi
            Dim Dong As DataRow = Bang.NewRow
            Dong("Ten") = "Don vi" & i
            Bang.Rows.Add(Dong)
        Next
        LT_BANG.GHI(Bang, "Don_vi")
        DataGridView1.DataSource = Bang
        Bo_phat_sinh
    End Sub
End Class