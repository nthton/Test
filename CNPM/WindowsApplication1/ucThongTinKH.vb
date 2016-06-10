Public Class ucThongTinKH
    Private Sub ucThongTinKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvKhachHang.DataSource = LT_BANG.DOC("Select * From KHACHHANG")
        dgvKhachHang.Columns("MaKhachHang").HeaderText = "Mã khách hàng"
        dgvKhachHang.Columns("HoTenKhachHang").HeaderText = "Họ tên"
        dgvKhachHang.Columns("SoTienNo").HeaderText = "Số tiền nợ"
        dgvKhachHang.Columns("DiaChi").HeaderText = "Địa chỉ"
        dgvKhachHang.Columns("DienThoai").HeaderText = "Điện thoại"

        dgvKhachHang.Columns("MaKhachHang").Width = 150
        dgvKhachHang.Columns("HoTenKhachHang").Width = 200
        dgvKhachHang.Columns("SoTienNo").Width = 125
        dgvKhachHang.Columns("DiaChi").Width = 225
        dgvKhachHang.Columns("DienThoai").Width = 125
        dgvKhachHang.Columns("Email").Width = 200

        dgvKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94)
        dgvKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub
End Class
