Public Class frmWelcome
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pgbLoad.Increment(1)
        If pgbLoad.Value = pgbLoad.Maximum Then
            Me.Close()
        End If
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class