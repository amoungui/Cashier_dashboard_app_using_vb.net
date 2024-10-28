<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        btnCart = New Button()
        btnInvoice = New Button()
        btnCharts = New Button()
        btnManager = New Button()
        btnHome = New Button()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        UserControlCharts1 = New UserControlCharts()
        btn_close = New Button()
        btn_reduce = New Button()
        btn_Fullscreen = New Button()
        Container = New Panel()
        UserControlCart1 = New UserControlCart()
        UserControlCharts2 = New UserControlCharts()
        UserControlInvoice1 = New UserControlInvoice()
        UserControlManager1 = New UserControlManager()
        UserControlHomePage1 = New UserControlHomePage()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Container.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnCart)
        Panel1.Controls.Add(btnInvoice)
        Panel1.Controls.Add(btnCharts)
        Panel1.Controls.Add(btnManager)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(167, 954)
        Panel1.TabIndex = 0
        ' 
        ' btnCart
        ' 
        btnCart.Cursor = Cursors.Hand
        btnCart.FlatAppearance.BorderSize = 0
        btnCart.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnCart.FlatStyle = FlatStyle.Flat
        btnCart.Image = CType(resources.GetObject("btnCart.Image"), Image)
        btnCart.Location = New Point(2, 745)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(164, 60)
        btnCart.TabIndex = 7
        btnCart.UseVisualStyleBackColor = True
        ' 
        ' btnInvoice
        ' 
        btnInvoice.Cursor = Cursors.Hand
        btnInvoice.FlatAppearance.BorderSize = 0
        btnInvoice.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnInvoice.FlatStyle = FlatStyle.Flat
        btnInvoice.Image = CType(resources.GetObject("btnInvoice.Image"), Image)
        btnInvoice.Location = New Point(2, 609)
        btnInvoice.Name = "btnInvoice"
        btnInvoice.Size = New Size(164, 75)
        btnInvoice.TabIndex = 6
        btnInvoice.UseVisualStyleBackColor = True
        ' 
        ' btnCharts
        ' 
        btnCharts.Cursor = Cursors.Hand
        btnCharts.FlatAppearance.BorderSize = 0
        btnCharts.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnCharts.FlatStyle = FlatStyle.Flat
        btnCharts.Image = CType(resources.GetObject("btnCharts.Image"), Image)
        btnCharts.Location = New Point(0, 486)
        btnCharts.Name = "btnCharts"
        btnCharts.Size = New Size(164, 71)
        btnCharts.TabIndex = 5
        btnCharts.UseVisualStyleBackColor = True
        ' 
        ' btnManager
        ' 
        btnManager.Cursor = Cursors.Hand
        btnManager.FlatAppearance.BorderSize = 0
        btnManager.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnManager.FlatStyle = FlatStyle.Flat
        btnManager.Image = CType(resources.GetObject("btnManager.Image"), Image)
        btnManager.Location = New Point(1, 365)
        btnManager.Name = "btnManager"
        btnManager.Size = New Size(164, 60)
        btnManager.TabIndex = 4
        btnManager.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Cursor = Cursors.Hand
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Image = CType(resources.GetObject("btnHome.Image"), Image)
        btnHome.Location = New Point(1, 250)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(164, 60)
        btnHome.TabIndex = 3
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(39, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 86)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(UserControlCharts1)
        Panel3.Controls.Add(btn_close)
        Panel3.Controls.Add(btn_reduce)
        Panel3.Controls.Add(btn_Fullscreen)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(167, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1721, 54)
        Panel3.TabIndex = 2
        ' 
        ' UserControlCharts1
        ' 
        UserControlCharts1.Location = New Point(1178, 210)
        UserControlCharts1.Name = "UserControlCharts1"
        UserControlCharts1.Size = New Size(2476, 1187)
        UserControlCharts1.TabIndex = 8
        ' 
        ' btn_close
        ' 
        btn_close.BackColor = Color.Transparent
        btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), Image)
        btn_close.BackgroundImageLayout = ImageLayout.Center
        btn_close.Cursor = Cursors.Hand
        btn_close.FlatAppearance.BorderSize = 0
        btn_close.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_close.FlatStyle = FlatStyle.Flat
        btn_close.Location = New Point(1649, 12)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(60, 30)
        btn_close.TabIndex = 5
        btn_close.UseVisualStyleBackColor = False
        ' 
        ' btn_reduce
        ' 
        btn_reduce.BackColor = Color.Transparent
        btn_reduce.BackgroundImage = CType(resources.GetObject("btn_reduce.BackgroundImage"), Image)
        btn_reduce.BackgroundImageLayout = ImageLayout.Center
        btn_reduce.Cursor = Cursors.Hand
        btn_reduce.FlatAppearance.BorderSize = 0
        btn_reduce.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_reduce.FlatStyle = FlatStyle.Flat
        btn_reduce.ForeColor = Color.Black
        btn_reduce.Location = New Point(1517, 12)
        btn_reduce.Name = "btn_reduce"
        btn_reduce.Size = New Size(60, 30)
        btn_reduce.TabIndex = 7
        btn_reduce.UseVisualStyleBackColor = False
        ' 
        ' btn_Fullscreen
        ' 
        btn_Fullscreen.BackColor = Color.Transparent
        btn_Fullscreen.BackgroundImage = CType(resources.GetObject("btn_Fullscreen.BackgroundImage"), Image)
        btn_Fullscreen.BackgroundImageLayout = ImageLayout.Center
        btn_Fullscreen.Cursor = Cursors.Hand
        btn_Fullscreen.FlatAppearance.BorderSize = 0
        btn_Fullscreen.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_Fullscreen.FlatStyle = FlatStyle.Flat
        btn_Fullscreen.Location = New Point(1583, 12)
        btn_Fullscreen.Name = "btn_Fullscreen"
        btn_Fullscreen.Size = New Size(60, 30)
        btn_Fullscreen.TabIndex = 6
        btn_Fullscreen.UseVisualStyleBackColor = False
        ' 
        ' Container
        ' 
        Container.Controls.Add(UserControlCart1)
        Container.Controls.Add(UserControlCharts2)
        Container.Controls.Add(UserControlInvoice1)
        Container.Controls.Add(UserControlManager1)
        Container.Controls.Add(UserControlHomePage1)
        Container.Dock = DockStyle.Fill
        Container.Location = New Point(167, 54)
        Container.Name = "Container"
        Container.Size = New Size(1721, 900)
        Container.TabIndex = 3
        ' 
        ' UserControlCart1
        ' 
        UserControlCart1.Location = New Point(0, 0)
        UserControlCart1.Name = "UserControlCart1"
        UserControlCart1.Size = New Size(1721, 900)
        UserControlCart1.TabIndex = 9
        ' 
        ' UserControlCharts2
        ' 
        UserControlCharts2.Location = New Point(3, 0)
        UserControlCharts2.Name = "UserControlCharts2"
        UserControlCharts2.Size = New Size(1718, 900)
        UserControlCharts2.TabIndex = 9
        ' 
        ' UserControlInvoice1
        ' 
        UserControlInvoice1.Location = New Point(0, 0)
        UserControlInvoice1.Name = "UserControlInvoice1"
        UserControlInvoice1.Size = New Size(1721, 900)
        UserControlInvoice1.TabIndex = 8
        ' 
        ' UserControlManager1
        ' 
        UserControlManager1.Location = New Point(0, 0)
        UserControlManager1.Name = "UserControlManager1"
        UserControlManager1.Size = New Size(1718, 900)
        UserControlManager1.TabIndex = 8
        ' 
        ' UserControlHomePage1
        ' 
        UserControlHomePage1.Location = New Point(-5, 0)
        UserControlHomePage1.Name = "UserControlHomePage1"
        UserControlHomePage1.Size = New Size(1723, 1012)
        UserControlHomePage1.TabIndex = 0
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1888, 954)
        Controls.Add(Container)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Dashboard"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Container.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents btnInvoice As Button
    Friend WithEvents btnCharts As Button
    Friend WithEvents btnManager As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_reduce As Button
    Friend WithEvents btn_Fullscreen As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Container As Panel
    Friend WithEvents UserControlHomePage1 As UserControlHomePage
    Friend WithEvents UserControlManager1 As UserControlManager
    Friend WithEvents UserControlInvoice1 As UserControlInvoice
    Friend WithEvents UserControlCharts2 As UserControlCharts
    Friend WithEvents UserControlCharts1 As UserControlCharts
    Friend WithEvents UserControlCart1 As UserControlCart

End Class
