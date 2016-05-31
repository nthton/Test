Imports System.Data.OleDb
Public Class frmGhi
    Private Sub btn_Dongy_Click(sender As Object, e As EventArgs) Handles btn_Dongy.Click
        'Kiểm tra dữ liệu nhập
        Dim Chuoi_loi As String = Kiem_tra()

        'nếu hợp lệ
        'khai báo 
        'nhap lieu
        'Ghi Don vi'

        If Chuoi_loi = "" Then
            Dim Bang As DataTable = Doc_cau_truc("tbSANPHAM")
            Dim San_pham As DataRow = Bang.NewRow
            San_pham("MASP") = txt1.Text
            Bang.Rows.Add(San_pham)

            If LT_BANG.GHI(Bang, "tbSANPHAM") > 0 Then
                MessageBox.Show("Đã ghi")
            Else
                MessageBox.Show("Lỗi khi ghi CSDL ")
            End If

        Else
                Dim Thong_bao As String = "Lỗi nhập liệu"
            Thong_bao &= Chuoi_loi
            MessageBox.Show(Thong_bao)
        End If

    End Sub
    Private Function Kiem_tra() As String
        Dim kq As String = ""
        If txt1.Text.Trim = "" Then
            kq &= "Chưa nhập tên san pham" & vbCrLf
        End If
        Return kq
    End Function

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub
End Class