<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RawMaterial
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RawMaterial))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnGotoSeller = New Button()
        btnAddEmp = New Button()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Panel5 = New Panel()
        btn_logout_admin = New Button()
        Panel4 = New Panel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label1 = New Label()
        Panel2 = New Panel()
        txtPrice = New TextBox()
        Label4 = New Label()
        txtUnit = New TextBox()
        Label2 = New Label()
        btnRemove = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        txtQuantity = New TextBox()
        txtName = New TextBox()
        Label3 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        Tprice = New Label()
        Button1 = New Button()
        Button2 = New Button()
        ItemDGV = New DataGridView()
        BilDGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        txt_quantity_sell = New TextBox()
        Label5 = New Label()
        PictureBox4 = New PictureBox()
        Panel6 = New Panel()
        Button3 = New Button()
        PictureBox5 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(BilDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' btnAddEmp
        ' 
        btnAddEmp.BackColor = Color.Snow
        btnAddEmp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddEmp.Location = New Point(46, 3)
        btnAddEmp.Name = "btnAddEmp"
        btnAddEmp.Size = New Size(161, 44)
        btnAddEmp.TabIndex = 23
        btnAddEmp.Text = "Home"
        btnAddEmp.UseVisualStyleBackColor = False
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
        Panel3.Location = New Point(46, 596)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(207, 49)
        Panel3.TabIndex = 35
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
        ' Panel5
        ' 
        Panel5.BackColor = Color.Snow
        Panel5.Controls.Add(btn_logout_admin)
        Panel5.Controls.Add(PictureBox3)
        Panel5.Location = New Point(43, 880)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(207, 49)
        Panel5.TabIndex = 37
        ' 
        ' btn_logout_admin
        ' 
        btn_logout_admin.BackColor = Color.Snow
        btn_logout_admin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_logout_admin.Location = New Point(43, 2)
        btn_logout_admin.Name = "btn_logout_admin"
        btn_logout_admin.Size = New Size(161, 44)
        btn_logout_admin.TabIndex = 20
        btn_logout_admin.Text = "Back"
        btn_logout_admin.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Snow
        Panel4.Controls.Add(btnGotoSeller)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Location = New Point(46, 792)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(207, 49)
        Panel4.TabIndex = 36
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(580, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(335, 40)
        Label1.TabIndex = 0
        Label1.Text = "  Manage Raw Materails"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(txtPrice)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtUnit)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(btnRemove)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(txtQuantity)
        Panel2.Controls.Add(txtName)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(17, 80)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(785, 263)
        Panel2.TabIndex = 4
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtPrice.Location = New Point(604, 78)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(130, 34)
        txtPrice.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Snow
        Label4.Location = New Point(604, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 31)
        Label4.TabIndex = 17
        Label4.Text = "Price"
        ' 
        ' txtUnit
        ' 
        txtUnit.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtUnit.Location = New Point(445, 78)
        txtUnit.Name = "txtUnit"
        txtUnit.Size = New Size(130, 34)
        txtUnit.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(445, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 31)
        Label2.TabIndex = 15
        Label2.Text = "Unit"
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.Snow
        btnRemove.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRemove.Location = New Point(495, 162)
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
        btnEdit.Location = New Point(234, 162)
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
        btnAdd.Location = New Point(25, 162)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(185, 55)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtQuantity.Location = New Point(288, 78)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(130, 34)
        txtQuantity.TabIndex = 9
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(14, 88)
        txtName.Name = "txtName"
        txtName.Size = New Size(232, 34)
        txtName.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Snow
        Label3.Location = New Point(288, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 31)
        Label3.TabIndex = 4
        Label3.Text = "Quantity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Snow
        Label6.Location = New Point(82, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 31)
        Label6.TabIndex = 7
        Label6.Text = "Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label7.ForeColor = Color.Snow
        Label7.Location = New Point(462, 455)
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
        Panel1.Controls.Add(Tprice)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(ItemDGV)
        Panel1.Controls.Add(BilDGV)
        Panel1.Controls.Add(txt_quantity_sell)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(305, -17)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1586, 1066)
        Panel1.TabIndex = 30
        ' 
        ' Tprice
        ' 
        Tprice.AutoSize = True
        Tprice.BackColor = Color.Transparent
        Tprice.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Tprice.ForeColor = Color.Snow
        Tprice.Location = New Point(1268, 707)
        Tprice.Name = "Tprice"
        Tprice.Size = New Size(162, 40)
        Tprice.TabIndex = 36
        Tprice.Text = "Total Price"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Snow
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(1240, 858)
        Button1.Name = "Button1"
        Button1.Size = New Size(206, 53)
        Button1.TabIndex = 19
        Button1.Text = "Dispatch"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Snow
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(1268, 455)
        Button2.Name = "Button2"
        Button2.Size = New Size(206, 53)
        Button2.TabIndex = 20
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ItemDGV
        ' 
        ItemDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ItemDGV.BackgroundColor = Color.Snow
        ItemDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemDGV.Cursor = Cursors.Hand
        ItemDGV.EnableHeadersVisualStyles = False
        ItemDGV.Location = New Point(818, 91)
        ItemDGV.Name = "ItemDGV"
        ItemDGV.RowHeadersWidth = 51
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ItemDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        ItemDGV.RowTemplate.Height = 29
        ItemDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ItemDGV.Size = New Size(725, 320)
        ItemDGV.TabIndex = 35
        ' 
        ' BilDGV
        ' 
        BilDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BilDGV.BackgroundColor = SystemColors.ControlLightLight
        BilDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BilDGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        BilDGV.GridColor = SystemColors.ActiveBorder
        BilDGV.Location = New Point(76, 547)
        BilDGV.Name = "BilDGV"
        BilDGV.RowHeadersWidth = 51
        BilDGV.RowTemplate.Height = 29
        BilDGV.Size = New Size(1072, 364)
        BilDGV.TabIndex = 34
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Product Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Quantity"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Price"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Total"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' txt_quantity_sell
        ' 
        txt_quantity_sell.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txt_quantity_sell.Location = New Point(1025, 456)
        txt_quantity_sell.Name = "txt_quantity_sell"
        txt_quantity_sell.Size = New Size(165, 34)
        txt_quantity_sell.TabIndex = 33
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Snow
        Label5.Location = New Point(872, 444)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 31)
        Label5.TabIndex = 32
        Label5.Text = "Quantity"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(12, 46)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(287, 280)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 38
        PictureBox4.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Snow
        Panel6.Controls.Add(Button3)
        Panel6.Controls.Add(PictureBox5)
        Panel6.Location = New Point(46, 690)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(207, 49)
        Panel6.TabIndex = 36
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Snow
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(46, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(161, 44)
        Button3.TabIndex = 23
        Button3.Text = "History"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(6, 3)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(47, 44)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 24
        PictureBox5.TabStop = False
        ' 
        ' RawMaterial
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel6)
        Controls.Add(PictureBox4)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Name = "RawMaterial"
        Text = "RawMaterial"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(BilDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGotoSeller As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_logout_admin As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents BilDGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txt_quantity_sell As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Tprice As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class
