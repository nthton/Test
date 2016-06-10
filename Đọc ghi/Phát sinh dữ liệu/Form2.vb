Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Kiểm tra dữ liệu nhập
        'phatsinhkhachhang()
        If ComboBox1.Text = "Sách" Then
            phatsinhsach()
        End If
        If ComboBox1.Text = "Khách hàng" Then
            phatsinhkhachhang()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub phatsinhkhachhang()
        Dim Bang_KH As DataTable
        Bang_KH = LT_BANG.DOC("Select * from KHACHHANG")
        For Each row As DataRow In Bang_KH.Rows
            row.Delete()
        Next
        Dim rd As New Random
        For i As Integer = 1 To Int16.Parse(TextBox1.Text)
            Dim kh As DataRow = Bang_KH.NewRow
            Bang_KH.Rows.Add(kh)
            Dim Ho As String() = New String() {"Nguyễn", "Trần", "Lý", "Lê", "Huỳnh", "Hoàng", "Hồ", "Đặng", "Bùi", "Võ", "Âu Dương", "Phạm", "Vũ", "Dương", "Phan"}
            Dim Lot As String() = New String() {"Thị", "Huy", "Bội", "Hoàng", "Tiến", "Bảo", "Văn", "Phú", "Duy", "Đức", "Thành", "Chí", "Hoài", "Thu", "Thụy", "Thùy", "Thanh", "Bích", "Hồng"}
            Dim Ten As String() = New String() {"Hùng", "Cường", "Nam", "Châu", "Thảo", "Ngọc", "Tuấn", "Phát", "Hân", "Diễm", "Phong", "Dũng", "Kiệt", "Nguyên", "Tùng", "Hiệp"}
            Dim Ho_ten As String = Ho(rd.Next(0, Ho.Length)) & " "
            Ho_ten &= Lot(rd.Next(0, Lot.Length)) & " "
            Ho_ten &= Ten(rd.Next(0, Ten.Length))
            kh("HoTenKhachHang") = Ho_ten
            Dim email As String() = New String() {"nntt", "tyedasd", "hugo", "luffy", "zoro", "nami", "chopper", "tintin", "sanni", "sam", "piglet", "faker", "azir", "nunu", "amumu", "gon", "nin", "poke", "hide", "maru", "toto", "mtk", "dragon", "panda", "lion"}
            Dim email2 As String() = New String() {"@yahoo.com", "@gmail.com", "@outlook.com", "@hotmail.com", "@rocketmail.com", "@facebook.com"}
            kh("Email") = email(rd.Next(0, email.Length)) & email(rd.Next(0, email.Length)) & rd.Next(0, 10000).ToString() & email2(rd.Next(0, email2.Length))
            Dim so As String() = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
            Dim sdt As String = "0"
            For j As Integer = 0 To 9
                sdt &= so(rd.Next(0, 10))
            Next
            kh("DienThoai") = sdt
            kh("SoTienNo") = (rd.Next(0, 201) * 100).ToString
            kh("DiaChi") = "Số " & rd.Next(1, 1100).ToString() & " Đường " & Ho(rd.Next(0, Ho.Length)) & " " & Lot(rd.Next(0, Lot.Length)) & " " & Ten(rd.Next(0, Ten.Length)) & " quận " & rd.Next(1, 12).ToString() & " TP. Hồ Chí Minh"
            LT_BANG.GHI(Bang_KH, "KHACHHANG")
            dgv1.DataSource = Bang_KH
        Next
    End Sub
    Sub phatsinhsach()
        Dim Bang As DataTable
        Bang = LT_BANG.DOC("select * from SACH")
        Dim rd As New Random
        For i As Integer = 1 To Int16.Parse(TextBox1.Text)
            Dim sach As DataRow = Bang.NewRow
            Bang.Rows.Add(sach)
            Dim Ho As String() = New String() {"Nguyễn", "Trần", "Lý", "Lê", "Huỳnh", "Hoàng", "Hồ", "Đặng", "Bùi", "Võ", "Âu Dương", "Phạm", "Vũ", "Dương", "Phan"}
            Dim Lot As String() = New String() {"Thị", "Huy", "Bội", "Hoàng", "Tiến", "Bảo", "Văn", "Phú", "Duy", "Đức", "Thành", "Chí", "Hoài", "Thu", "Thụy", "Thùy", "Thanh", "Bích", "Hồng"}
            Dim Ten As String() = New String() {"Hùng", "Cường", "Nam", "Châu", "Thảo", "Ngọc", "Tuấn", "Phát", "Hân", "Diễm", "Phong", "Dũng", "Kiệt", "Nguyên", "Tùng", "Hiệp"}
            Dim Ho_ten As String = Ho(rd.Next(0, Ho.Length)) & " "
            Ho_ten &= Lot(rd.Next(0, Lot.Length)) & " "
            Ho_ten &= Ten(rd.Next(0, Ten.Length))
            Dim s1 As String() = New String() {"Con sói", "Chiến binh", "Phù thủy", "Alice", "Hary", "Con bò", "Con cò", "Hoa hồng", "Cơn gió", "Soái ca", "Đại bàng", "Gấu mẹ", "Chiến tranh", "Đại thắng", "Con chó", "Con mèo", "Doraemon", "Conan", "One piece", "Ngày xưa", "Ngọn lửa", "Ngọn núi", "Chiếc lá", ""}
            Dim s2 As String() = New String() {"dũng cảm", "vĩ đại", "tài ba", "nhút nhát", "thông minh", "yếu đuối", "tinh quái", "thần kì", "cuối cùng", "đầu tiên", "nhanh nhẹn", "lơ ngơ", "hung dữ", "bí ẩn"}
            sach("TenSach") = s1(rd.Next(0, s1.Length)) & " " & s2(rd.Next(0, s2.Length)) & " " & "tập " + rd.Next(0, 1000).ToString
            sach("TacGia") = Ho_ten
            Dim tl As String() = New String() {"Truyện ngắn", "Truyện dài", "Tiểu thuyết", "Truyện ngụ ngôn", "Tạp chí", "Truyện tranh"}
            sach("TheLoai") = tl(rd.Next(0, tl.Length))
            sach("DonGiaBanDuKien") = 100 * rd.Next(0, 1000)
            sach("SoLuongTon") = rd.Next(0, 301)
            LT_BANG.GHI(Bang, "SACH")
            dgv1.DataSource = Bang
        Next
    End Sub
End Class
