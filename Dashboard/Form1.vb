Public Class Dashboard

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Fullscreen_Click(sender As Object, e As EventArgs) Handles btn_Fullscreen.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btn_reduce_Click(sender As Object, e As EventArgs) Handles btn_reduce.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class
