Public Class frmMain
    Dim isDragged As Boolean = False
    Dim ptOffset As Point


    Public Sub Button_Visible()
        btnThayDoiQuyDinh.Visible = False

        btnBaoCaoTon.Visible = False
        btnBaoCaoNo.Visible = False

        btnTTSach.Visible = False
        btnTTKhachHang.Visible = False
        btnPhieuNhapSach.Visible = False
        btnHoaDonBanSach.Visible = False
        btnPhieuThuTien.Visible = False

        btnSach.Visible = False
        btnKhachHang.Visible = False

        btnTTPhanMem.Visible = False
        btnFeedback.Visible = False
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_Visible()
    End Sub


    'Code để kéo thả panel => di chuyển form
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If (e.Button = MouseButtons.Left) Then
            isDragged = True
            Dim ptStartPosition As Point = Panel1.PointToScreen(New Point(e.X, e.Y))
            ptOffset = New Point()
            ptOffset.X = Panel1.Location.X - ptStartPosition.X
            ptOffset.Y = Panel1.Location.Y - ptStartPosition.Y
        Else
            isDragged = False
        End If
    End Sub
    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If isDragged = True Then
            Dim newPoint As Point = Panel1.PointToScreen(New Point(e.X, e.Y))
            newPoint.Offset(ptOffset)
            MyBase.Location = newPoint
        End If
    End Sub
    Private Sub Panel_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        isDragged = False
    End Sub
    '-----------------------------------------------------------------------------------------
    Private Sub btnHeThong_Click(sender As Object, e As EventArgs) Handles btnHeThong.Click
        'Đặt màu nút hiện tại
        btnHeThong.BackColor = Color.FromArgb(241, 241, 241)
        btnHeThong.ForeColor = Color.FromArgb(42, 87, 154)
        'Đặt màu các nút khác về mặc định
        btnLuuTru.BackColor = Color.FromArgb(42, 87, 154)
        btnLuuTru.ForeColor = Color.FromArgb(241, 241, 241)
        btnBaoCao.BackColor = Color.FromArgb(42, 87, 154)
        btnBaoCao.ForeColor = Color.FromArgb(241, 241, 241)
        btnTraCuu.BackColor = Color.FromArgb(42, 87, 154)
        btnTraCuu.ForeColor = Color.FromArgb(241, 241, 241)
        btnTroGiup.BackColor = Color.FromArgb(42, 87, 154)
        btnTroGiup.ForeColor = Color.FromArgb(241, 241, 241)
        'Cập nhật lại phần hiển thị trên panel2
        Button_Visible()
        btnThayDoiQuyDinh.Visible = True

    End Sub

    Private Sub btnLuuTru_Click(sender As Object, e As EventArgs) Handles btnLuuTru.Click
        'Đặt màu nút hiện tại
        btnLuuTru.BackColor = Color.FromArgb(241, 241, 241)
        btnLuuTru.ForeColor = Color.FromArgb(42, 87, 154)
        'Đặt màu các nút khác về mặt định
        btnHeThong.BackColor = Color.FromArgb(42, 87, 154)
        btnHeThong.ForeColor = Color.FromArgb(241, 241, 241)
        btnBaoCao.BackColor = Color.FromArgb(42, 87, 154)
        btnBaoCao.ForeColor = Color.FromArgb(241, 241, 241)
        btnTraCuu.BackColor = Color.FromArgb(42, 87, 154)
        btnTraCuu.ForeColor = Color.FromArgb(241, 241, 241)
        btnTroGiup.BackColor = Color.FromArgb(42, 87, 154)
        btnTroGiup.ForeColor = Color.FromArgb(241, 241, 241)
        'Cập nhật lại phần hiển thị trên panel2
        Button_Visible()
        btnTTSach.Visible = True
        btnTTKhachHang.Visible = True
        btnPhieuNhapSach.Visible = True
        btnHoaDonBanSach.Visible = True
        btnPhieuThuTien.Visible = True
    End Sub

    Private Sub btnTraCuu_Click(sender As Object, e As EventArgs) Handles btnTraCuu.Click
        'Đặt màu nút hiện tại
        btnTraCuu.BackColor = Color.FromArgb(241, 241, 241)
        btnTraCuu.ForeColor = Color.FromArgb(42, 87, 154)
        'Đặt màu các nút khác về mặt định
        btnHeThong.BackColor = Color.FromArgb(42, 87, 154)
        btnHeThong.ForeColor = Color.FromArgb(241, 241, 241)
        btnBaoCao.BackColor = Color.FromArgb(42, 87, 154)
        btnBaoCao.ForeColor = Color.FromArgb(241, 241, 241)
        btnLuuTru.BackColor = Color.FromArgb(42, 87, 154)
        btnLuuTru.ForeColor = Color.FromArgb(241, 241, 241)
        btnTroGiup.BackColor = Color.FromArgb(42, 87, 154)
        btnTroGiup.ForeColor = Color.FromArgb(241, 241, 241)
        'Cập nhật lại phần hiển thị trên panel2
        Button_Visible()
        btnSach.Visible = True
        btnKhachHang.Visible = True
    End Sub

    Private Sub btnBaoCao_Click(sender As Object, e As EventArgs) Handles btnBaoCao.Click
        'Đặt màu nút hiện tại
        btnBaoCao.BackColor = Color.FromArgb(241, 241, 241)
        btnBaoCao.ForeColor = Color.FromArgb(42, 87, 154)
        'Đặt màu các nút khác về mặt định
        btnLuuTru.BackColor = Color.FromArgb(42, 87, 154)
        btnLuuTru.ForeColor = Color.FromArgb(241, 241, 241)
        btnHeThong.BackColor = Color.FromArgb(42, 87, 154)
        btnHeThong.ForeColor = Color.FromArgb(241, 241, 241)
        btnTraCuu.BackColor = Color.FromArgb(42, 87, 154)
        btnTraCuu.ForeColor = Color.FromArgb(241, 241, 241)
        btnTroGiup.BackColor = Color.FromArgb(42, 87, 154)
        btnTroGiup.ForeColor = Color.FromArgb(241, 241, 241)
        'Cập nhật lại phần hiển thị trên panel2
        Button_Visible()
        btnBaoCaoTon.Visible = True
        btnBaoCaoNo.Visible = True
    End Sub

    Private Sub btnTroGiup_Click(sender As Object, e As EventArgs) Handles btnTroGiup.Click
        'Đặt màu nút hiện tại
        btnTroGiup.BackColor = Color.FromArgb(241, 241, 241)
        btnTroGiup.ForeColor = Color.FromArgb(42, 87, 154)
        'Đặt màu các nút khác về mặt định
        btnLuuTru.BackColor = Color.FromArgb(42, 87, 154)
        btnLuuTru.ForeColor = Color.FromArgb(241, 241, 241)
        btnBaoCao.BackColor = Color.FromArgb(42, 87, 154)
        btnBaoCao.ForeColor = Color.FromArgb(241, 241, 241)
        btnTraCuu.BackColor = Color.FromArgb(42, 87, 154)
        btnTraCuu.ForeColor = Color.FromArgb(241, 241, 241)
        btnHeThong.BackColor = Color.FromArgb(42, 87, 154)
        btnHeThong.ForeColor = Color.FromArgb(241, 241, 241)
        'Cập nhật lại phần hiển thị trên panel2
        Button_Visible()
        btnTTPhanMem.Visible = True
        btnFeedback.Visible = True
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnDangXuat_Click(sender As Object, e As EventArgs) Handles btnDangXuat.Click
        Dim frmLogin As New frmLogin
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        txtSearch.Text = "Tìm kiếm chức năng..."
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        txtSearch.Text = ""
    End Sub

    Private Sub txtSearch_MouseLeave(sender As Object, e As EventArgs) Handles txtSearch.MouseLeave
        txtSearch.Text = "Tìm kiếm chức năng..."
    End Sub


    Private Sub btnBaoCaoTon_Click(sender As Object, e As EventArgs) Handles btnBaoCaoTon.Click
        Panel4.Controls.Clear()
        Panel4.Controls.Add(New ucBaoCaoTon)
    End Sub
    Private Sub btnBaoCaoNo_Click(sender As Object, e As EventArgs) Handles btnBaoCaoNo.Click
        Panel4.Controls.Clear()
        Panel4.Controls.Add(New ucBaoCaoNo)
    End Sub

    Private Sub btnThayDoiQuyDinh_Click(sender As Object, e As EventArgs) Handles btnThayDoiQuyDinh.Click
        Panel4.Controls.Clear()
        Panel4.Controls.Add(New ucQuyDinh)
    End Sub

    Private Sub btnTTSach_Click(sender As Object, e As EventArgs) Handles btnTTSach.Click
        Panel4.Controls.Clear()
        Panel4.Controls.Add(New ucThongTinSach)
    End Sub

    Private Sub btnTTKhachHang_Click(sender As Object, e As EventArgs) Handles btnTTKhachHang.Click
        Panel4.Controls.Clear()
        Panel4.Controls.Add(New ucThongTinKhachHang)
    End Sub

    Private Sub btnHoaDonBanSach_Click(sender As Object, e As EventArgs) Handles btnHoaDonBanSach.Click
        Panel4.Controls.Clear()
        Panel4.Controls.Add(New ucHoaDon)
    End Sub

    Private Sub btnPhieuNhapSach_Click(sender As Object, e As EventArgs) Handles btnPhieuNhapSach.Click
        Panel4.Controls.Clear()
        Panel4.Controls.Add(New ucPhieuNhapSach)
    End Sub
End Class
