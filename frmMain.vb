Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmWelcome.ShowDialog()
        frmLogin.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmquanlythanhvien.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frmquanlythanhvien.ShowDialog()
    End Sub
End Class
