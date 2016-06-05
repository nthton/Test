Imports System.Text.RegularExpressions

Public Class Form1
    'khai báo biến toàn cục sv, là thể hiện cho một sinh viên
    Dim sv As DataRow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load dữ liệu lên dgv
        Dim table As New DataTable
        table = LT_BANG.DOC("select * from SinhVien")
        dgvDSSV.DataSource = table
        dgvDSSV.Columns("Ho_ten").HeaderText = "Họ tên"
        dgvDSSV.Columns("Ngay_sinh").HeaderText = "Ngày sinh"
        dgvDSSV.Columns("Diem_toan").HeaderText = "Điểm Toán"
        dgvDSSV.Columns("Diem_ly").HeaderText = "Điểm lý"
        dgvDSSV.Columns("Diem_hoa").HeaderText = "Điểm hóa"
        dgvDSSV.Columns("Diem_tb").HeaderText = "Điểm trung bình"
        'Không cho người dùng sửa các cột trong dgv
        dgvDSSV.ReadOnly() = True
        'Enable các text box
        Textbox_Enable(False)
        'tắt row header
        dgvDSSV.RowHeadersVisible = False
    End Sub
    Function KiemTraNgay(ByVal str As String) As Boolean 'Kiem tra tinh hop le cua ngay

        'Chuyen ngay thang nam thanh kieu so nguyen
        Dim Ngay As Integer = Int32.Parse(str(0) + str(1))
        Dim Thang As Integer = Int32.Parse(str(3) + str(4))
        Dim Nam As Integer = Int32.Parse(str.Substring(6, 4))
        Dim a() As Integer
        a = New Integer() {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31} 'so ngay trong cac thang vd: a(3)=31 thang 3 co 31 ngay

        If (((Nam Mod 4 = 0 And Nam Mod 100 <> 0) Or (Nam Mod 400 = 0))) Then
            a(2) = 29 'neu la nam nhuan thang 2 co 29 ngay
        End If

        If (Nam < 1 Or Thang < 1 Or Thang > 12 Or Ngay < 1 Or Ngay > 31) Then
            Return False
        ElseIf Ngay > a(Thang) Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub Textbox_Enable(ByVal e As Boolean)
        txtDiemToan.Enabled = e
        txtDiemLy.Enabled = e
        txtDiemHoa.Enabled = e
        txtMSSV.Enabled = e
        txtNgaySinh.Enabled = e
        txtTenSV.Enabled = e
    End Sub

    Public Sub Textbox_clear()
        txtMSSV.Text = ""
        txtTenSV.Text = ""
        txtNgaySinh.Text = ""
        txtDiemToan.Text = ""
        txtDiemLy.Text = ""
        txtDiemHoa.Text = ""
    End Sub


    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub dgvDSSV_Click(sender As Object, e As EventArgs) Handles dgvDSSV.Click

        ''code theo cách cũ nếu cách kia sai thì dùng lại cách này
        '' lấy dữ liệu của dòng đang chọn lên Datarow
        'Dim table As DataTable = dgvDSSV.DataSource
        'Dim row As DataRow = table.Rows(dgvDSSV.CurrentRow.Index)
        '' gán dữ liệu cho các textbox
        'txtMSSV.Text = row("MSSV")
        'txtTenSV.Text = row("Ho_ten")
        'txtNgaySinh.Text = row("Ngay_sinh")
        'txtDiemToan.Text = row("Diem_toan")
        'txtDiemLy.Text = row("Diem_ly")
        'txtDiemHoa.Text = row("Diem_hoa")


        Dim TH_Sinhvien As DataRowView = dgvDSSV.CurrentRow.DataBoundItem
        sv = TH_Sinhvien.Row
        txtMSSV.Text = sv("MSSV")
        txtTenSV.Text = sv("Ho_ten")
        txtNgaySinh.Text = sv("Ngay_sinh")
        txtDiemToan.Text = sv("Diem_toan")
        txtDiemLy.Text = sv("Diem_ly")
        txtDiemHoa.Text = sv("Diem_hoa")

    End Sub
    Private Function Kiem_tra_them() As String
        Dim table As DataTable = LT_BANG.DOC("select * from SinhVien")
        Dim Chuoi_loi As String = ""
        'Các textbox không được để trống
        If txtMSSV.Text = "" Or txtTenSV.Text = "" Or txtNgaySinh.Text = "" Or txtDiemToan.Text = "" Or txtDiemLy.Text = "" Or txtDiemHoa.Text = "" Then
            Chuoi_loi &= "Bạn chưa nhập đầy đủ thông tin " & vbCrLf
            Return Chuoi_loi
        End If
        'Mssv không được trùng
        For Each row As DataRow In table.Rows
            If txtMSSV.Text = row("MSSV") Then
                Chuoi_loi &= "MSSV " & txtMSSV.Text & " đã tồn tại." & vbCrLf
                Exit For
            End If
        Next
        'điểm thuộc khoảng [0-10]
        If Double.Parse(txtDiemToan.Text) < 0 Or Double.Parse(txtDiemToan.Text) > 10 Or Double.Parse(txtDiemLy.Text) < 0 Or Double.Parse(txtDiemLy.Text) > 10 Or Double.Parse(txtDiemHoa.Text) < 0 Or Double.Parse(txtDiemHoa.Text) > 10 Then
            Chuoi_loi &= "Giá trị của điểm phải thuộc đoạn [0,10]." & vbCrLf
        End If
        'ngày sinh phải hợp lệ
        Dim re As Regex = New Regex("^\d{2}/\d{2}/\d{4}$")
        If Not re.Match(txtNgaySinh.Text.Trim()).Success Then
            Chuoi_loi &= "Ngày sinh không hợp lệ" & vbCrLf
            Return Chuoi_loi
        ElseIf KiemTraNgay(txtNgaySinh.Text) = False Then
            Chuoi_loi &= "Ngày sinh không hợp lệ" & vbCrLf
        End If
        Return Chuoi_loi
    End Function


    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        If btnThem.Text = "Thêm" Then
            Textbox_clear()
            btnThem.Text = "Lưu"
            Textbox_Enable(True)
            btnSua.Enabled = False
            btnXoa.Enabled = False
            btnTimKiem.Enabled = False
        Else
            Dim Chuoi_loi = Kiem_tra_them()
            If Chuoi_loi = "" Then
                Dim table As DataTable = LT_BANG.DOC("select * from SinhVien")
                Dim row As DataRow = table.NewRow
                row("Ho_ten") = txtTenSV.Text
                row("Ngay_sinh") = txtNgaySinh.Text
                row("MSSV") = txtMSSV.Text
                row("Diem_toan") = txtDiemToan.Text
                row("Diem_ly") = txtDiemLy.Text
                row("Diem_hoa") = txtDiemHoa.Text
                'Tính điểm trung bình
                Dim t, l, h As Integer
                t = Double.Parse(txtDiemToan.Text)
                l = Double.Parse(txtDiemLy.Text)
                h = Double.Parse(txtDiemHoa.Text)
                row("Diem_tb") = Math.Round((t + l + h) / 3, 1).ToString
                table.Rows.Add(row)
                LT_BANG.GHI(table, "SinhVien")
                MsgBox("Thêm thành công!", MsgBoxStyle.Exclamation, "Thông báo")
                Textbox_clear()
                Textbox_Enable(False)
                btnThem.Text = "Thêm"
                btnSua.Enabled = True
                btnXoa.Enabled = True
                btnTimKiem.Enabled = True
                'Cập nhật hiển thị dgv
                dgvDSSV.DataSource = table
            Else
                Dim Thong_bao As String = "Lỗi nhập liệu" & vbCrLf
                Thong_bao &= Chuoi_loi
                MsgBox(Thong_bao, MsgBoxStyle.Exclamation, "Thông báo")
            End If
        End If

    End Sub

    Private Function Kiem_tra_sua() As String
        Dim Chuoi_loi As String = ""
        'Kiểm tra xem đã chọn sinh viên nào chưa
        If sv Is Nothing Then
            Chuoi_loi &= "Chưa chọn sinh viên nào"
            Return Chuoi_loi
        End If
        'Các textbox không được để trống
        If txtMSSV.Text = "" Or txtTenSV.Text = "" Or txtNgaySinh.Text = "" Or txtDiemToan.Text = "" Or txtDiemLy.Text = "" Or txtDiemHoa.Text = "" Then
            Chuoi_loi &= "Bạn chưa nhập đầy đủ thông tin " & vbCrLf
            Return Chuoi_loi
        End If
        'Mssv không được trùng
        'row lần lược là từng sinh viên trong bảng, sv là sinh viên đang được chọn
        For Each row As DataRow In sv.Table.Rows
            If txtMSSV.Text = row("MSSV") And txtMSSV.Text <> sv("MSSV") Then
                Chuoi_loi &= "MSSV " & txtMSSV.Text & " đã tồn tại." & vbCrLf
                Exit For
            End If
        Next
        'điểm thuộc đoạn [0-10]
        If Double.Parse(txtDiemToan.Text) < 0 Or Double.Parse(txtDiemToan.Text) > 10 Or Double.Parse(txtDiemLy.Text) < 0 Or Double.Parse(txtDiemLy.Text) > 10 Or Double.Parse(txtDiemHoa.Text) < 0 Or Double.Parse(txtDiemHoa.Text) > 10 Then
            Chuoi_loi &= "Giá trị của điểm phải thuộc đoạn [0,10]." & vbCrLf
        End If
        'ngày sinh phải hợp lệ
        Dim re As Regex = New Regex("^\d{2}/\d{2}/\d{4}$")
        If Not re.Match(txtNgaySinh.Text.Trim()).Success Then
            Chuoi_loi &= "Ngày sinh không hợp lệ" & vbCrLf
            Return Chuoi_loi
        ElseIf KiemTraNgay(txtNgaySinh.Text) = False Then
            Chuoi_loi &= "Ngày sinh không hợp lệ" & vbCrLf
        End If
        Return Chuoi_loi
    End Function
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Chuoi_loi As String = Kiem_tra_sua()

        If btnSua.Text = "Sửa" Then
            If Chuoi_loi = "" Then
                btnSua.Text = "Lưu"
                Textbox_Enable(True)
                btnThem.Enabled = False
                btnXoa.Enabled = False
                btnTimKiem.Enabled = False
            Else
                MsgBox(Chuoi_loi, MsgBoxStyle.Exclamation, "Thông báo")
            End If
        Else
            If Chuoi_loi = "" Then

                'Dim table As DataTable = dgvDSSV.DataSource
                'Dim row As DataRow = table.NewRow
                sv("Ho_ten") = txtTenSV.Text
                sv("Ngay_sinh") = txtNgaySinh.Text
                sv("MSSV") = txtMSSV.Text
                sv("Diem_toan") = txtDiemToan.Text
                sv("Diem_ly") = txtDiemLy.Text
                sv("Diem_hoa") = txtDiemHoa.Text
                'Tính điểm trung bình
                Dim t, l, h As Integer
                t = Double.Parse(txtDiemToan.Text)
                l = Double.Parse(txtDiemLy.Text)
                h = Double.Parse(txtDiemHoa.Text)
                sv("Diem_tb") = Math.Round((t + l + h) / 3, 1).ToString


                Dim table As DataTable = sv.Table
                If LT_BANG.GHI(table, "SinhVien") > 0 Then
                    MsgBox("Cập nhật thành công!", MsgBoxStyle.Exclamation, "Thông báo")
                End If
                Textbox_Enable(False)
                btnSua.Text = "Sửa"
                btnThem.Enabled = True
                btnXoa.Enabled = True
                btnTimKiem.Enabled = True
                'Cập nhật hiển thị dgv
                dgvDSSV.DataSource = table
            Else
                MsgBox(Chuoi_loi, MsgBoxStyle.Exclamation, "Thông báo")
            End If
        End If
    End Sub

    Private Function Kiem_tra_xoa() As String
        Dim kq As String = ""
        If sv Is Nothing Then
            kq &= "Chưa chọn sinh viên nào"
        End If
        Return kq
    End Function

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Chuoi_loi As String = Kiem_tra_xoa()
        If Chuoi_loi = "" Then
            Dim tam As Integer = MsgBox("Bạn có muốn xóa " & sv("Ho_ten") & " không?", vbYesNo + MsgBoxStyle.Question, "Question")
            If tam = 6 Then
                sv.Delete()
                Dim table As DataTable = sv.Table
                If LT_BANG.GHI(table, "SinhVien") > 0 Then
                    Textbox_clear()
                    MsgBox("Xóa thành công!!!", MsgBoxStyle.Exclamation, "Thông báo")
                End If
                'Cập nhật hiển thị dgv
                dgvDSSV.DataSource = table
            End If
        Else
            MsgBox(Chuoi_loi, MsgBoxStyle.Exclamation, "Thông báo")
        End If
    End Sub

    'cập nhật lại hiển thị trên các textbox sau khi sort
    Private Sub dgvDSSV_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDSSV.ColumnHeaderMouseClick
        Dim TH_Sinhvien As DataRowView = dgvDSSV.CurrentRow.DataBoundItem
        sv = TH_Sinhvien.Row
        txtMSSV.Text = sv("MSSV")
        txtTenSV.Text = sv("Ho_ten")
        txtNgaySinh.Text = sv("Ngay_sinh")
        txtDiemToan.Text = sv("Diem_toan")
        txtDiemLy.Text = sv("Diem_ly")
        txtDiemHoa.Text = sv("Diem_hoa")
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        If txtTimKiem.Text = "" Then
            MsgBox("Chưa nhập thông tin tìm kiếm", MsgBoxStyle.Exclamation, "Thông báo")
        Else
            Dim table As New DataTable
            table = LT_BANG.DOC("select * from SinhVien where Instr(Ho_ten,'" & txtTimKiem.Text & "') > 0 or Instr(MSSV,'" & txtTimKiem.Text & "')>0")
            dgvDSSV.DataSource = table
        End If
    End Sub
End Class
