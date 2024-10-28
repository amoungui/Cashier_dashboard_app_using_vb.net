Imports MySql.Data.MySqlClient
Public Class Dashboard

    Private Sub LoadUserControl(Optional userControl As UserControl = Nothing)
        ' Clear the MainPanel
        Container.Controls.Clear()

        If userControl Is Nothing Then
            ' Add the default UserControl (HomePage) to the MainPanel
            userControl = New UserControlHomePage()
        End If

        ' Add the UserControl to the MainPanel
        userControl.Dock = DockStyle.Fill
        Container.Controls.Add(userControl)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the default UserControl (HomePage) when the form loads
        LoadUserControl(New UserControlHomePage())
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Fullscreen_Click(sender As Object, e As EventArgs) Handles btn_Fullscreen.Click
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btn_reduce_Click(sender As Object, e As EventArgs) Handles btn_reduce.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Container_Paint(sender As Object, e As PaintEventArgs) Handles Container.Paint
        ' LoadUserControl(New UserControlHomePage())
    End Sub

    Private Sub UserControlHomePage1_Load(sender As Object, e As EventArgs) Handles UserControlHomePage1.Load

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        LoadUserControl(New UserControlHomePage())
    End Sub

    Private Sub btnManager_Click(sender As Object, e As EventArgs) Handles btnManager.Click
        LoadUserControl(New UserControlManager())
    End Sub

    Private Sub btnCharts_Click(sender As Object, e As EventArgs) Handles btnCharts.Click
        LoadUserControl(New UserControlCharts())
    End Sub

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        LoadUserControl(New UserControlInvoice())
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        LoadUserControl(New UserControlCart())
    End Sub
End Class
