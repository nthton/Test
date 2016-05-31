Imports System.Data.OleDb
Public Class frmDoc

    Private Sub frmDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Khai báo bảng
        'Dim Bang As New DataTable
        ''Đọc dữ liệu vào bảng

        ''Tạo chuỗi lệnh và chuối kết nôi
        'Dim Chuoi_lenh As String = "select * From tbSANPHAM"
        'Dim Chuoi_ket_noi As String = "Provider=Microsoft.Jet.OLEDB.4.0 ; Data Source = dbSanPham.mdb"
        ''Khai báo bộ thích ứng
        'Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi)
        ''Dùng bộ thích ứng đọc
        'Bo_thich_ung.Fill(Bang)
        ''Kết xuất bảng
        'Luoi.DataSource = Bang
        'Luoi.Columns("MASP").Visible = False



        Luoi.DataSource = DOC("select tbSANPHAM.* From tbSANPHAM")
    End Sub

    Private Sub Luoi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Luoi.CellContentClick

    End Sub
End Class