Imports MySql.Data.MySqlClient
Imports System
Imports System.Collections.Generic

Public Class UserControlHomePage
    Dim con As New MySqlConnection("server=localhost;port=3307;username=root;password=;database=crud_test")
    Dim pageIndex As Integer = 0
    Dim pageSize As Integer = 8 ' 8 produits par page
    Dim cart As New List(Of Product) ' Collection pour stocker les produits sélectionnés

    Private Sub UserControlHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts("")
        PanelCartOrder.Controls.Clear()
    End Sub

    Private Sub LoadProducts(searchText As String)
        Try
            con.Open()
            Dim offset As Integer = pageIndex * pageSize
            Dim query As String = "SELECT * FROM tbl_crud WHERE PRODUCTNAME LIKE @searchText OR DESCRIPTION LIKE @searchText LIMIT @offset, @pageSize"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@offset", offset)
            cmd.Parameters.AddWithValue("@pageSize", pageSize)
            cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear previous controls
            For Each ctrl As Control In PanelListProduct.Controls
                If TypeOf ctrl Is Panel Then
                    ctrl.Visible = False
                End If
            Next

            Dim index As Integer = 1
            While reader.Read()
                Dim panel As Panel = CType(PanelListProduct.Controls.Find("PanelProduct" & index, True).FirstOrDefault(), Panel)
                If panel IsNot Nothing Then
                    Dim pictureBox As PictureBox = CType(panel.Controls.Find("PictureProduct" & index, True).FirstOrDefault(), PictureBox)
                    Dim labelName As Label = CType(panel.Controls.Find("LabelNameProduct" & index, True).FirstOrDefault(), Label)
                    Dim labelDesc As Label = CType(panel.Controls.Find("LabelShortDesc" & index, True).FirstOrDefault(), Label)
                    Dim labelPrice As Label = CType(panel.Controls.Find("LabelPrice" & index, True).FirstOrDefault(), Label)

                    ' Set data to controls
                    If pictureBox IsNot Nothing Then
                        pictureBox.BackgroundImage = Image.FromFile(reader("IMAGE_PATH").ToString())
                        pictureBox.BackgroundImageLayout = ImageLayout.Stretch
                    End If
                    If labelName IsNot Nothing Then labelName.Text = reader("PRODUCTNAME").ToString()
                    If labelDesc IsNot Nothing Then labelDesc.Text = reader("DESCRIPTION").ToString().Substring(0, Math.Min(25, reader("DESCRIPTION").ToString().Length)) & "..."
                    If labelPrice IsNot Nothing Then labelPrice.Text = reader("PRICE").ToString() & " $"

                    ' Store product information in the panel's Tag property
                    Dim product As New Product(reader("PRODUCTNO").ToString(), reader("PRODUCTNAME").ToString(), reader("PRICE").ToString(), reader("DESCRIPTION").ToString(), reader("IMAGE_PATH").ToString())
                    panel.Tag = product
                    pictureBox.Tag = product

                    ' Event handler for adding to cart
                    AddHandler panel.MouseClick, AddressOf PanelProduct_Click
                    AddHandler pictureBox.MouseClick, AddressOf PictureProduct_Click

                    panel.Visible = True
                End If
                index += 1
            End While

            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' Event handler for panel click
    Private Sub PanelProduct_Click(sender As Object, e As MouseEventArgs)
        Dim panel As Panel = CType(sender, Panel)
        Dim product As Product = CType(panel.Tag, Product)
        AddToCart(product)
    End Sub

    ' Event handler for picture click
    Private Sub PictureProduct_Click(sender As Object, e As MouseEventArgs)
        Dim pictureBox As PictureBox = CType(sender, PictureBox)
        Dim product As Product = CType(pictureBox.Tag, Product)
        AddToCart(product)
    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        pageIndex += 1
        LoadProducts(txt_search.Text)
    End Sub

    Private Sub btnPrevPage_Click(sender As Object, e As EventArgs) Handles btnPrevPage.Click
        If pageIndex > 0 Then
            pageIndex -= 1
            LoadProducts(txt_search.Text)
        End If
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        LoadProducts(txt_search.Text)
    End Sub

    ' Classe représentant un produit
    Public Class Product
        Public Property ProductNo As String
        Public Property ProductName As String
        Public Property Price As Decimal
        Public Property Description As String
        Public Property ImagePath As String

        Public Sub New(productNo As String, productName As String, price As Decimal, description As String, imagePath As String)
            Me.ProductNo = productNo
            Me.ProductName = productName
            Me.Price = price
            Me.Description = description
            Me.ImagePath = imagePath
        End Sub
    End Class

    ' Ajouter un produit au panier
    Private Sub AddToCart(product As Product)
        cart.Add(product)
        DisplayCart()
    End Sub

    ' Afficher le contenu du panier
    Private Sub DisplayCart()
        Try
            ' Clear previous controls
            For Each ctrl As Control In PanelCartOrder.Controls
                If TypeOf ctrl Is Panel Then
                    ctrl.Visible = False
                End If
            Next
            Dim index As Integer = 1
            For Each product In cart
                Dim panel As Panel = CType(PanelCartOrder.Controls.Find("PanelProductOrder" & index, True).FirstOrDefault(), Panel)
                If panel Is Nothing Then
                    ' Créer un nouveau panel si il n'existe pas
                    panel = New Panel With {
                        .Name = "PanelProductOrder" & index,
                        .Size = New Size(200, 100),
                        .BorderStyle = BorderStyle.FixedSingle,
                        .Location = New Point(0, (index - 1) * 110) ' Espacement de 10 pixels entre les panneaux
                    }
                    Dim pictureBox As New PictureBox With {
                        .Name = "ProductOrder" & index,
                        .Size = New Size(80, 80),
                        .Location = New Point(10, 10),
                        .BackgroundImageLayout = ImageLayout.Stretch
                    }
                    Dim labelName As New Label With {
                        .Name = "LabelOrder" & index,
                        .Location = New Point(100, 10)
                    }
                    Dim labelDesc As New Label With {
                        .Name = "LabelDescOrder" & index,
                        .Location = New Point(100, 40)
                    }
                    Dim labelPrice As New Label With {
                        .Name = "LabelPriceOrder" & index,
                        .Location = New Point(100, 70)
                    }
                    ' Ajouter des contrôles au panel
                    panel.Controls.Add(pictureBox)
                    panel.Controls.Add(labelName)
                    panel.Controls.Add(labelDesc)
                    panel.Controls.Add(labelPrice)
                    ' Ajouter le panel au PanelCartOrder
                    PanelCartOrder.Controls.Add(panel)
                End If
                ' Assigner les valeurs aux contrôles existants
                Dim pb As PictureBox = CType(panel.Controls("ProductOrder" & index), PictureBox)
                Dim lblName As Label = CType(panel.Controls("LabelOrder" & index), Label)
                Dim lblDesc As Label = CType(panel.Controls("LabelDescOrder" & index), Label)
                Dim lblPrice As Label = CType(panel.Controls("LabelPriceOrder" & index), Label)

                If pb IsNot Nothing Then
                    pb.BackgroundImage = Image.FromFile(product.ImagePath)
                End If
                If lblName IsNot Nothing Then
                    lblName.Text = product.ProductName
                End If
                If lblDesc IsNot Nothing Then
                    lblDesc.Text = product.Description.Substring(0, Math.Min(25, product.Description.Length)) & "..."
                End If
                If lblPrice IsNot Nothing Then
                    lblPrice.Text = " $" & product.Price.ToString()
                End If

                panel.Visible = True
                index += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
