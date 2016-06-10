Public Class ucThongTinSach
    Dim Bang_sach As DataTable
    Dim Sach As DataRow
    Private Sub ucThongTinSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Luoi_sach.DataSource = LT_BANG.DOC("select * From SACH")
        Luoi_sach.Columns("MaSach").HeaderText = "Mã sách"
        Luoi_sach.Columns("TenSach").HeaderText = "Tên sách"
        Luoi_sach.Columns("TheLoai").HeaderText = "Thể loại"
        Luoi_sach.Columns("TacGia").HeaderText = "Tác giả"
        Luoi_sach.Columns("SoLuongTon").HeaderText = "Số lượng tồn"
        Luoi_sach.Columns("DonGiaBanDuKien").HeaderText = "Giá bán dự kiến"

        Luoi_sach.Columns("MaSach").Width = 100
        Luoi_sach.Columns("TenSach").Width = 300
        Luoi_sach.Columns("TheLoai").Width = 150
        Luoi_sach.Columns("TacGia").Width = 200
        Luoi_sach.Columns("SoLuongTon").Width = 125
        Luoi_sach.Columns("DonGiaBanDuKien").Width = 150
        Luoi_sach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94)
        Luoi_sach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White



        Dim row_sach As DataRowView = Luoi_sach.CurrentRow.DataBoundItem
        Sach = row_sach.Row
        txtDonGiaDK.Text = Sach("DonGiaBanDuKien")
        txtMaSach.Text = Sach("MaSach")
        txtSoLuongTon.Text = Sach("SoLuongTon")
        txtTacGia.Text = Sach("TacGia")
        txtTenSach.Text = Sach("TenSach")
        cbTheLoai.Text = Sach("TheLoai")
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim fThemSach As New frmThemSach
        fThemSach.ShowDialog()
    End Sub
End Class
