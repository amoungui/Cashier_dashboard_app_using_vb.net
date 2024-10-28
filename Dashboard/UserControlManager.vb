Imports System.IO
Imports MySql.Data.MySqlClient
Public Class UserControlManager
    Dim con As New MySqlConnection("server=localhost;port=3307;username=root;password=;database=crud_test")
    Dim i As Integer
    Dim DataReader As MySqlDataReader

    Public Sub data_load()
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_crud", con)
            DataReader = cmd.ExecuteReader
            While DataReader.Read
                DataGridView1.Rows.Add(
                    DataReader.Item("PRODUCTNO"),
                    DataReader.Item("PRODUCTNAME"),
                    DataReader.Item("PRICE"),
                    DataReader.Item("CATEGORY"),
                    DataReader.Item("EXPDATE"),
                    Format(CBool(DataReader.Item("STATUS"))),
                    DataReader.Item("IMAGE_PATH"),
                    DataReader.Item("DESCRIPTION")
                )
            End While
            DataReader.Dispose() ' DataReader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub clear()
        text_prono.Clear()
        text_pro_name.Clear()
        text_price.Clear()
        combo_pro_group.Text = " "
        exp_date.Value = Now
        status_checbox.Checked = False
    End Sub

    Private Sub UserControlManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_load()
    End Sub

    ' Ensuite, ajoute l'événement clic pour le bouton de navigation d'image
    Private Sub btn_browse_image_Click(sender As Object, e As EventArgs) Handles btn_browse_image.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                text_image_path.Text = ofd.FileName
            End If
        End Using
    End Sub

    Public Sub save()
        Try
            con.Open()

            ' Obtenir le nom de l'image
            Dim imageName As String = Path.GetFileName(text_image_path.Text)

            ' Chemin complet où l'image sera stockée
            Dim imagePath As String = Path.Combine(Application.StartupPath, "images", imageName)

            ' Vérifier si le répertoire "images" existe, sinon le créer
            Dim imageDir As String = Path.Combine(Application.StartupPath, "images")
            If Not Directory.Exists(imageDir) Then
                Directory.CreateDirectory(imageDir)
            End If

            ' Sauvegarde l'image dans le répertoire 'images'
            File.Copy(text_image_path.Text, imagePath, True)

            Dim cmd As New MySqlCommand(
            "INSERT INTO `tbl_crud`(`PRODUCTNO`, `PRODUCTNAME`, `PRICE`, `CATEGORY`, `EXPDATE`, `STATUS`, `IMAGE_PATH`, `DESCRIPTION`) VALUES (@PRODUCTNO, @PRODUCTNAME, @PRICE, @CATEGORY, @EXPDATE, @STATUS, @IMAGE_PATH, @DESCRIPTION)",
            con
        )
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNO", text_prono.Text)
            cmd.Parameters.AddWithValue("@PRODUCTNAME", text_pro_name.Text)
            cmd.Parameters.AddWithValue("@PRICE", text_price.Text)
            cmd.Parameters.AddWithValue("@CATEGORY", combo_pro_group.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(exp_date.Value))
            cmd.Parameters.AddWithValue("@STATUS", status_checbox.Checked.ToString)
            cmd.Parameters.AddWithValue("@IMAGE_PATH", imagePath)
            cmd.Parameters.AddWithValue("@DESCRIPTION", text_description.Text)

            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show(
                "Record saved successfully!",
                "CRUD",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Else
                MessageBox.Show(
                "Record save failed!",
                "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk
            )
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
        data_load()
    End Sub

    Public Sub edit()
        Try
            con.Open()
            Dim cmd As New MySqlCommand(
                "UPDATE `tbl_crud` SET `PRODUCTNAME`=@PRODUCTNAME,`PRICE`=@PRICE,`CATEGORY`=@CATEGORY,`EXPDATE`=@EXPDATE,`STATUS`=@STATUS, `IMAGE_PATH`=@IMAGE_PATH, `DESCRIPTION`=@DESCRIPTION WHERE `PRODUCTNO`=@PRODUCTNO",
                con
            )
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNO", text_prono.Text)
            cmd.Parameters.AddWithValue("@PRODUCTNAME", text_pro_name.Text)
            cmd.Parameters.AddWithValue("@PRICE", text_price.Text)
            cmd.Parameters.AddWithValue("@CATEGORY", combo_pro_group.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(exp_date.Value))
            cmd.Parameters.AddWithValue("@STATUS", status_checbox.Checked.ToString)
            cmd.Parameters.AddWithValue("@IMAGE_PATH", text_image_path.Text)
            cmd.Parameters.AddWithValue("@DESCRIPTION", text_description.Text)

            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show(
                    "Record update successfully !",
                    "CRUD",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
            Else
                MessageBox.Show(
                    "Record update failled !",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                )
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        clear()
        data_load()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit()
    End Sub

    Public Sub delete()
        If MsgBox("Are you sure delete this entry ?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                con.Open()
                Dim cmd As New MySqlCommand(
                "DELETE FROM `tbl_crud` WHERE `PRODUCTNO`=@PRODUCTNO",
                con
            )
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@PRODUCTNO", text_prono.Text)

                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show(
                    "Record delete successfully !",
                    "CRUD",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
                Else
                    MessageBox.Show(
                    "Record delete failled !",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                )
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
            clear()
            data_load()
        Else
            Return
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        delete()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        text_prono.Text = DataGridView1.CurrentRow.Cells(0).Value
        text_pro_name.Text = DataGridView1.CurrentRow.Cells(1).Value
        text_price.Text = DataGridView1.CurrentRow.Cells(2).Value
        combo_pro_group.Text = DataGridView1.CurrentRow.Cells(3).Value
        exp_date.Text = DataGridView1.CurrentRow.Cells(4).Value
        status_checbox.Checked = DataGridView1.CurrentRow.Cells(5).Value
        text_description.Text = DataGridView1.CurrentRow.Cells(6).Value
        text_image_path.Text = DataGridView1.CurrentRow.Cells(7).Value

        text_prono.ReadOnly = True
        btnSave.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles text_search.TextChanged
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_crud WHERE PRODUCTNO LIKE '%" & text_search.Text & "%' OR PRODUCTNAME LIKE '%" & text_pro_name.Text & "%'", con)
            DataReader = cmd.ExecuteReader
            While DataReader.Read
                DataGridView1.Rows.Add(
                    DataReader.Item("PRODUCTNO"),
                    DataReader.Item("PRODUCTNAME"),
                    DataReader.Item("PRICE"),
                    DataReader.Item("CATEGORY"),
                    DataReader.Item("EXPDATE"),
                    Format(CBool(DataReader.Item("STATUS")))
                )
            End While
            DataReader.Dispose() ' DataReader.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class
