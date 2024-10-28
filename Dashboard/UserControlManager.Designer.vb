<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlManager
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        text_prono = New TextBox()
        text_pro_name = New TextBox()
        combo_pro_group = New ComboBox()
        exp_date = New DateTimePicker()
        status_checbox = New CheckBox()
        btnSave = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        Label1 = New Label()
        Label2 = New Label()
        text_price = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        text_search = New TextBox()
        Label3 = New Label()
        Label7 = New Label()
        text_image_path = New TextBox()
        btn_browse_image = New Button()
        Label8 = New Label()
        text_description = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewCheckBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' text_prono
        ' 
        text_prono.Location = New Point(43, 72)
        text_prono.Name = "text_prono"
        text_prono.Size = New Size(433, 31)
        text_prono.TabIndex = 1
        ' 
        ' text_pro_name
        ' 
        text_pro_name.Location = New Point(43, 151)
        text_pro_name.Name = "text_pro_name"
        text_pro_name.Size = New Size(433, 31)
        text_pro_name.TabIndex = 2
        ' 
        ' combo_pro_group
        ' 
        combo_pro_group.FormattingEnabled = True
        combo_pro_group.Items.AddRange(New Object() {"Plantes d'intérieur", "Plantes succulentes", "Plantes fleuries", "Plantes aromatiques"})
        combo_pro_group.Location = New Point(43, 516)
        combo_pro_group.Name = "combo_pro_group"
        combo_pro_group.Size = New Size(433, 33)
        combo_pro_group.TabIndex = 4
        ' 
        ' exp_date
        ' 
        exp_date.Location = New Point(43, 606)
        exp_date.Name = "exp_date"
        exp_date.Size = New Size(433, 31)
        exp_date.TabIndex = 5
        ' 
        ' status_checbox
        ' 
        status_checbox.AutoSize = True
        status_checbox.Location = New Point(43, 660)
        status_checbox.Name = "status_checbox"
        status_checbox.Size = New Size(109, 29)
        status_checbox.TabIndex = 6
        status_checbox.Text = "Available"
        status_checbox.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.ForestGreen
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Location = New Point(43, 709)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(200, 48)
        btnSave.TabIndex = 7
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.DarkSeaGreen
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Location = New Point(276, 709)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(200, 48)
        btnEdit.TabIndex = 8
        btnEdit.Text = "Update"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Firebrick
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Location = New Point(43, 795)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(200, 48)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGray
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Location = New Point(276, 795)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(200, 48)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(43, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 21)
        Label1.TabIndex = 11
        Label1.Text = "Product No"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 21)
        Label2.TabIndex = 12
        Label2.Text = "Product Name"
        ' 
        ' text_price
        ' 
        text_price.Location = New Point(43, 243)
        text_price.Name = "text_price"
        text_price.Size = New Size(433, 31)
        text_price.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(43, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 21)
        Label4.TabIndex = 15
        Label4.Text = "Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(43, 480)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 21)
        Label5.TabIndex = 16
        Label5.Text = "Catégory"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(43, 569)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 21)
        Label6.TabIndex = 17
        Label6.Text = "Date Entry"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        DataGridView1.Location = New Point(515, 117)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1183, 546)
        DataGridView1.TabIndex = 18
        ' 
        ' text_search
        ' 
        text_search.Location = New Point(515, 62)
        text_search.Name = "text_search"
        text_search.Size = New Size(433, 31)
        text_search.TabIndex = 19
        text_search.Text = "Search..."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(515, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 21)
        Label3.TabIndex = 20
        Label3.Text = "Search"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(43, 392)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 21)
        Label7.TabIndex = 22
        Label7.Text = "Image"
        ' 
        ' text_image_path
        ' 
        text_image_path.Location = New Point(43, 429)
        text_image_path.Name = "text_image_path"
        text_image_path.Size = New Size(294, 31)
        text_image_path.TabIndex = 21
        ' 
        ' btn_browse_image
        ' 
        btn_browse_image.BackColor = Color.LightGray
        btn_browse_image.FlatAppearance.BorderSize = 0
        btn_browse_image.FlatStyle = FlatStyle.Flat
        btn_browse_image.Location = New Point(360, 429)
        btn_browse_image.Name = "btn_browse_image"
        btn_browse_image.Size = New Size(116, 31)
        btn_browse_image.TabIndex = 23
        btn_browse_image.Text = "Browser"
        btn_browse_image.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(43, 300)
        Label8.Name = "Label8"
        Label8.Size = New Size(156, 21)
        Label8.TabIndex = 25
        Label8.Text = "Short Description"
        ' 
        ' text_description
        ' 
        text_description.Location = New Point(43, 334)
        text_description.Name = "text_description"
        text_description.Size = New Size(433, 31)
        text_description.TabIndex = 24
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product No"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 139
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Product Name"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Price"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 85
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Category"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 120
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Date Entry"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 130
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Status"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 66
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Image"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 150
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Description"
        Column8.MinimumWidth = 8
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 150
        ' 
        ' UserControlManager
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label8)
        Controls.Add(text_description)
        Controls.Add(btn_browse_image)
        Controls.Add(Label7)
        Controls.Add(text_image_path)
        Controls.Add(Label3)
        Controls.Add(text_search)
        Controls.Add(DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(text_price)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnSave)
        Controls.Add(status_checbox)
        Controls.Add(exp_date)
        Controls.Add(combo_pro_group)
        Controls.Add(text_pro_name)
        Controls.Add(text_prono)
        Name = "UserControlManager"
        Size = New Size(1721, 900)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents text_prono As TextBox
    Friend WithEvents text_pro_name As TextBox
    Friend WithEvents combo_pro_group As ComboBox
    Friend WithEvents exp_date As DateTimePicker
    Friend WithEvents status_checbox As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents text_price As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents text_search As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents text_image_path As TextBox
    Friend WithEvents btn_browse_image As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents text_description As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn

End Class
