
Public Class frmLogin

   
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim Id As String
        Dim Pw As String

        Id = txtuser.Text
        Pw = txtpw.Text

        If Id = "admin" Then
            If Pw = "admin" Then
                MessageBox.Show("Đăng Nhập Thành Công")
                Me.Close()
            Else
                MessageBox.Show("Sai Mật Khẩu")
            End If
        Else
            MessageBox.Show("Sai Tên Đăng Nhập")
        End If

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub
End Class