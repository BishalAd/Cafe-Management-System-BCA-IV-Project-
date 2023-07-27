<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_New_Cagegory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Add_New_Cagegory))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnAddCat = New Button()
        cattb = New TextBox()
        Label2 = New Label()
        Button5 = New Button()
        btnRemove = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        combo = New ComboBox()
        txtPrice = New TextBox()
        Label1 = New Label()
        txtQuantity = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btn_logout_admin = New Button()
        ItemDGV = New DataGridView()
        Label7 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        txtName = New TextBox()
        btnGotoSeller = New Button()
        btnDeleteCat = New Button()
        btnAddEmp = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        btnRawMaterial = New Button()
        PictureBox4 = New PictureBox()
        CType(ItemDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAddCat
        ' 
        btnAddCat.BackColor = Color.Snow
        btnAddCat.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddCat.Location = New Point(27, 226)
        btnAddCat.Name = "btnAddCat"
        btnAddCat.Size = New Size(188, 53)
        btnAddCat.TabIndex = 19
        btnAddCat.Text = "Add Category"
        btnAddCat.UseVisualStyleBackColor = False
        ' 
        ' cattb
        ' 
        cattb.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cattb.Location = New Point(27, 155)
        cattb.Name = "cattb"
        cattb.Size = New Size(188, 34)
        cattb.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(37, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 62)
        Label2.TabIndex = 17
        Label2.Text = "New Category " & vbCrLf & "     Name"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Snow
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(1230, 189)
        Button5.Name = "Button5"
        Button5.Size = New Size(201, 55)
        Button5.TabIndex = 14
        Button5.Text = "Reset"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.Snow
        btnRemove.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRemove.Location = New Point(872, 194)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(206, 53)
        btnRemove.TabIndex = 13
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Snow
        btnEdit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.Location = New Point(397, 192)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(224, 55)
        btnEdit.TabIndex = 12
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Snow
        btnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Location = New Point(15, 189)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(185, 55)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' combo
        ' 
        combo.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        combo.FormattingEnabled = True
        combo.Items.AddRange(New Object() {"bishwax", "ass", "daSD", "FAS", "ASDSW", "SA", "ASAsd", "vc", "ASD", "ZADE", "safcxv", "f", "cvf", "dfvc", "f"})
        combo.Location = New Point(515, 87)
        combo.Name = "combo"
        combo.Size = New Size(215, 35)
        combo.TabIndex = 11
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtPrice.Location = New Point(1252, 88)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(130, 34)
        txtPrice.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(608, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 40)
        Label1.TabIndex = 0
        Label1.Text = "  Manage Items  "
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtQuantity.Location = New Point(891, 88)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(130, 34)
        txtQuantity.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Snow
        Label3.Location = New Point(891, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 31)
        Label3.TabIndex = 4
        Label3.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Snow
        Label4.Location = New Point(1252, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 31)
        Label4.TabIndex = 5
        Label4.Text = "Selling Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Snow
        Label5.Location = New Point(542, 31)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 31)
        Label5.TabIndex = 6
        Label5.Text = "Categories"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Snow
        Label6.Location = New Point(167, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 31)
        Label6.TabIndex = 7
        Label6.Text = "Name"
        ' 
        ' btn_logout_admin
        ' 
        btn_logout_admin.BackColor = Color.Snow
        btn_logout_admin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_logout_admin.Location = New Point(43, 2)
        btn_logout_admin.Name = "btn_logout_admin"
        btn_logout_admin.Size = New Size(161, 44)
        btn_logout_admin.TabIndex = 20
        btn_logout_admin.Text = "Logout"
        btn_logout_admin.UseVisualStyleBackColor = False
        ' 
        ' ItemDGV
        ' 
        ItemDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ItemDGV.BackgroundColor = SystemColors.ControlLightLight
        ItemDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemDGV.Cursor = Cursors.Hand
        ItemDGV.EnableHeadersVisualStyles = False
        ItemDGV.Location = New Point(173, 469)
        ItemDGV.Name = "ItemDGV"
        ItemDGV.RowHeadersWidth = 51
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ItemDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        ItemDGV.RowTemplate.Height = 29
        ItemDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ItemDGV.Size = New Size(1378, 485)
        ItemDGV.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label7.ForeColor = Color.Snow
        Label7.Location = New Point(851, 400)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 40)
        Label7.TabIndex = 6
        Label7.Text = "Items List"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(ItemDGV)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(244, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1659, 1066)
        Panel1.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(btnRemove)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(combo)
        Panel2.Controls.Add(txtPrice)
        Panel2.Controls.Add(txtQuantity)
        Panel2.Controls.Add(txtName)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(17, 80)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1534, 247)
        Panel2.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(99, 88)
        txtName.Name = "txtName"
        txtName.Size = New Size(232, 34)
        txtName.TabIndex = 8
        ' 
        ' btnGotoSeller
        ' 
        btnGotoSeller.BackColor = Color.Snow
        btnGotoSeller.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnGotoSeller.Location = New Point(43, 2)
        btnGotoSeller.Name = "btnGotoSeller"
        btnGotoSeller.Size = New Size(161, 44)
        btnGotoSeller.TabIndex = 21
        btnGotoSeller.Text = "Seller"
        btnGotoSeller.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCat
        ' 
        btnDeleteCat.BackColor = Color.Snow
        btnDeleteCat.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeleteCat.Location = New Point(27, 304)
        btnDeleteCat.Name = "btnDeleteCat"
        btnDeleteCat.Size = New Size(188, 53)
        btnDeleteCat.TabIndex = 22
        btnDeleteCat.Text = "Delete Category"
        btnDeleteCat.UseVisualStyleBackColor = False
        ' 
        ' btnAddEmp
        ' 
        btnAddEmp.BackColor = Color.Snow
        btnAddEmp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddEmp.Location = New Point(46, 3)
        btnAddEmp.Name = "btnAddEmp"
        btnAddEmp.Size = New Size(161, 44)
        btnAddEmp.TabIndex = 23
        btnAddEmp.Text = "Add Employee"
        btnAddEmp.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(47, 44)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 44)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 25
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(47, 44)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 26
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Snow
        Panel3.Controls.Add(btnAddEmp)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(24, 677)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(207, 49)
        Panel3.TabIndex = 27
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Snow
        Panel4.Controls.Add(btnGotoSeller)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Location = New Point(24, 784)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(207, 49)
        Panel4.TabIndex = 28
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Snow
        Panel5.Controls.Add(btn_logout_admin)
        Panel5.Controls.Add(PictureBox3)
        Panel5.Location = New Point(24, 891)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(207, 49)
        Panel5.TabIndex = 29
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Snow
        Panel6.Controls.Add(btnRawMaterial)
        Panel6.Controls.Add(PictureBox4)
        Panel6.Location = New Point(27, 587)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(207, 49)
        Panel6.TabIndex = 28
        ' 
        ' btnRawMaterial
        ' 
        btnRawMaterial.BackColor = Color.Snow
        btnRawMaterial.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRawMaterial.Location = New Point(46, 3)
        btnRawMaterial.Name = "btnRawMaterial"
        btnRawMaterial.Size = New Size(161, 44)
        btnRawMaterial.TabIndex = 23
        btnRawMaterial.Text = "Add Employee"
        btnRawMaterial.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(6, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(47, 44)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 24
        PictureBox4.TabStop = False
        ' 
        ' Add_New_Cagegory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(btnDeleteCat)
        Controls.Add(btnAddCat)
        Controls.Add(cattb)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "Add_New_Cagegory"
        Text = "Add_New_Cagegory"
        WindowState = FormWindowState.Maximized
        CType(ItemDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnAddCat As Button
    Friend WithEvents cattb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents combo As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_logout_admin As Button
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnGotoSeller As Button
    Friend WithEvents btnDeleteCat As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnRawMaterial As Button
    Friend WithEvents PictureBox4 As PictureBox
End Class
