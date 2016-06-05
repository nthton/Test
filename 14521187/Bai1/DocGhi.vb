﻿Imports System.Data.OleDb
Module LT_BANG
    'Đoạn này em làm theo hướng dẫn trong bộ video LTUDQL của thầy Khang.
    Public Chuoi_ket_noi As String = "Provider=Microsoft.Jet.OLEDB.4.0 ; Data Source = QLSV.mdb"
    Public Function DOC(ByVal Chuoi_lenh As String) As DataTable
        Dim kq As New DataTable
        Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi)
        Bo_thich_ung.FillSchema(kq, SchemaType.Source)
        Bo_thich_ung.Fill(kq)
        Return kq
    End Function

    Public Function GHI(ByVal Bang As DataTable, Ten_bang As String) As Integer
        Dim kq As Integer = 0
        Dim Chuoi_lenh As String = "Select * From " & Ten_bang
        Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi)
        Dim Bo_phat_sinh_lenh As New OleDbCommandBuilder(Bo_thich_ung)
        kq = Bo_thich_ung.Update(Bang)
        Return kq
    End Function

    Public Function Doc_cau_truc(ByVal Ten_bang As String) As DataTable
        Dim kq As New DataTable
        Dim Chuoi_lenh As String = "Select * From " & Ten_bang
        Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi)
        Bo_thich_ung.FillSchema(kq, SchemaType.Source)
        Return kq
    End Function

    Public Function Cap_nhat(ByVal Chuoi_lenh As String) As Integer
        Dim kq As Integer
        Dim Ket_noi As New OleDbConnection(Chuoi_ket_noi)
        Ket_noi.Open()
        Dim Bo_thuc_hien_lenh As New OleDbCommand(Chuoi_lenh, Ket_noi)
        kq = Bo_thuc_hien_lenh.ExecuteNonQuery
        Ket_noi.Close()
        Return kq
    End Function

End Module


