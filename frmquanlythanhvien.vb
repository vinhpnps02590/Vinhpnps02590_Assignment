Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmquanlythanhvien
    Dim database As New DataTable
    Dim chuoiconnect As String = "workstation id=Vinhpnps02590.mssql.somee.com;packet size=4096;user id=Vinhpnps02590_SQLLogin_1;pwd=6hiav28kuu;data source=Vinhpnps02590.mssql.somee.com;persist security info=False;initial catalog=Vinhpnps02590
    Private Sub frmquanlythanhvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        'Kết nối mở ra
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        dgvkhachhang.DataSource = database.DefaultView
    End Sub

    Private Sub dgvkhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkhachhang.CellContentClick
        Dim index As Integer = dgvkhachhang.CurrentCell.RowIndex
        txtmakh.Text = dgvkhachhang.Item(0, index).Value
        txttenkh.Text = dgvkhachhang.Item(1, index).Value
        txtsodt.Text = dgvkhachhang.Item(2, index).Value
        txtdiachi.Text = dgvkhachhang.Item(3, index).Value
    End Sub


    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into KhachHang values (@MaKhachHang,@TenKhachHang,@SoDT,@DiaChi)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@MaKhachHang", txtmakh.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenKhachHang", txttenkh.Text)
            ExecuteQuery1.Parameters.AddWithValue("@SoDT", txtsodt.Text)
            ExecuteQuery1.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)

            'Exucute là ghi dữ liệu vào Database
            MessageBox.Show("Thêm thành công")
            ExecuteQuery1.ExecuteNonQuery()
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)
        database.Clear()

        Query3.Fill(database)
        dgvkhachhang.DataSource = database.DefaultView
    End Sub

    Private Sub Loaddata()
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from KhachHang", connect)

        connect.Open()
        Query1.Fill(database)
        dgvkhachhang.DataSource = database.DefaultView
    End Sub






    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim Ketnoi1 As New SqlConnection(chuoiconnect)
        Ketnoi1.Open()
        Dim Stradd1 As String = "Update KhachHang set MaKhachHang=@MaKhachHang,TenKhachHang=@TenKhachHang,SoDT=@SoDT,DiaChi=@DiaChi where MaKhachHang=@MaKhachHang"
        Dim com As New SqlCommand(Stradd1, Ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaKhachHang", txtmakh.Text)
            com.Parameters.AddWithValue("@TenKhachHang", txttenkh.Text)
            com.Parameters.AddWithValue("@SoDT", txtsodt.Text)
            com.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
            com.ExecuteNonQuery()
            Ketnoi1.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        database.Clear()
        dgvkhachhang.DataSource = database
        dgvkhachhang.DataSource = Nothing
        Loaddata()
    End Sub


    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim lienket As New SqlConnection(chuoiconnect)
        lienket.Open()
        Dim xoadl As String = "Delete from KhachHang where MaKhachHang=@MaKhachHang"
        Dim lenh As New SqlCommand(xoadl, lienket)
        Try
            lenh.Parameters.AddWithValue("@MaKhachHang", txtmakh.Text)
            lenh.ExecuteNonQuery()
            lienket.Close()
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        dgvkhachhang.DataSource = database
        dgvkhachhang.DataSource = Nothing
        Loaddata()
    End Sub



    
End Class