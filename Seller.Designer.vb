<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seller
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
        Panel1 = New Panel()
        btn_logout_seller = New Button()
        Panel2 = New Panel()
        Label6 = New Label()
        btn_print = New Button()
        btn_view_orders = New Button()
        view_yourOrder = New DataGridView()
        btnAddBill = New Button()
        txt_quantity_sell = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Item_list = New DataGridView()
        btnRefresh_sell = New Button()
        txtCategoryName_sell = New TextBox()
        Label2 = New Label()
        btmAddCategory_sell = New Button()
        Label1 = New Label()
        Combo_addCategory_sell = New ComboBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(view_yourOrder, ComponentModel.ISupportInitialize).BeginInit()
        CType(Item_list, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Chocolate
        Panel1.Controls.Add(btn_logout_seller)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1924, 1061)
        Panel1.TabIndex = 0
        ' 
        ' btn_logout_seller
        ' 
        btn_logout_seller.BackColor = Color.Snow
        btn_logout_seller.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_logout_seller.Location = New Point(44, 929)
        btn_logout_seller.Name = "btn_logout_seller"
        btn_logout_seller.Size = New Size(107, 44)
        btn_logout_seller.TabIndex = 16
        btn_logout_seller.Text = "Logout"
        btn_logout_seller.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Snow
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(btn_print)
        Panel2.Controls.Add(btn_view_orders)
        Panel2.Controls.Add(view_yourOrder)
        Panel2.Controls.Add(btnAddBill)
        Panel2.Controls.Add(txt_quantity_sell)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Item_list)
        Panel2.Controls.Add(btnRefresh_sell)
        Panel2.Controls.Add(txtCategoryName_sell)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(btmAddCategory_sell)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Combo_addCategory_sell)
        Panel2.Location = New Point(203, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1718, 1017)
        Panel2.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Chocolate
        Label6.Location = New Point(1456, 816)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 31)
        Label6.TabIndex = 28
        Label6.Text = "Total"
        ' 
        ' btn_print
        ' 
        btn_print.BackColor = Color.Chocolate
        btn_print.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_print.ForeColor = Color.Snow
        btn_print.Location = New Point(1402, 731)
        btn_print.Name = "btn_print"
        btn_print.Size = New Size(175, 44)
        btn_print.TabIndex = 27
        btn_print.Text = "Print"
        btn_print.UseVisualStyleBackColor = False
        ' 
        ' btn_view_orders
        ' 
        btn_view_orders.BackColor = Color.Chocolate
        btn_view_orders.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_view_orders.ForeColor = Color.Snow
        btn_view_orders.Location = New Point(1402, 900)
        btn_view_orders.Name = "btn_view_orders"
        btn_view_orders.Size = New Size(175, 44)
        btn_view_orders.TabIndex = 26
        btn_view_orders.Text = "View Orders"
        btn_view_orders.UseVisualStyleBackColor = False
        ' 
        ' view_yourOrder
        ' 
        view_yourOrder.BackgroundColor = SystemColors.ControlLightLight
        view_yourOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        view_yourOrder.Location = New Point(93, 597)
        view_yourOrder.Name = "view_yourOrder"
        view_yourOrder.RowHeadersWidth = 51
        view_yourOrder.RowTemplate.Height = 29
        view_yourOrder.Size = New Size(1156, 364)
        view_yourOrder.TabIndex = 25
        ' 
        ' btnAddBill
        ' 
        btnAddBill.BackColor = Color.Chocolate
        btnAddBill.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddBill.ForeColor = Color.Snow
        btnAddBill.Location = New Point(1316, 451)
        btnAddBill.Name = "btnAddBill"
        btnAddBill.Size = New Size(175, 44)
        btnAddBill.TabIndex = 24
        btnAddBill.Text = "Add To Bill"
        btnAddBill.UseVisualStyleBackColor = False
        ' 
        ' txt_quantity_sell
        ' 
        txt_quantity_sell.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txt_quantity_sell.Location = New Point(1106, 458)
        txt_quantity_sell.Name = "txt_quantity_sell"
        txt_quantity_sell.Size = New Size(165, 34)
        txt_quantity_sell.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Chocolate
        Label5.Location = New Point(956, 461)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 31)
        Label5.TabIndex = 22
        Label5.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.ForeColor = Color.Chocolate
        Label4.Location = New Point(542, 517)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 31)
        Label4.TabIndex = 21
        Label4.Text = "Your Order"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ForeColor = Color.Chocolate
        Label3.Location = New Point(1055, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 40)
        Label3.TabIndex = 20
        Label3.Text = "Items List"
        ' 
        ' Item_list
        ' 
        Item_list.BackgroundColor = SystemColors.ControlLightLight
        Item_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Item_list.Location = New Point(684, 148)
        Item_list.Name = "Item_list"
        Item_list.RowHeadersWidth = 51
        Item_list.RowTemplate.Height = 29
        Item_list.Size = New Size(946, 290)
        Item_list.TabIndex = 19
        ' 
        ' btnRefresh_sell
        ' 
        btnRefresh_sell.BackColor = Color.Chocolate
        btnRefresh_sell.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefresh_sell.ForeColor = Color.Snow
        btnRefresh_sell.Location = New Point(329, 193)
        btnRefresh_sell.Name = "btnRefresh_sell"
        btnRefresh_sell.Size = New Size(175, 44)
        btnRefresh_sell.TabIndex = 18
        btnRefresh_sell.Text = "Refresh"
        btnRefresh_sell.UseVisualStyleBackColor = False
        ' 
        ' txtCategoryName_sell
        ' 
        txtCategoryName_sell.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtCategoryName_sell.Location = New Point(108, 353)
        txtCategoryName_sell.Name = "txtCategoryName_sell"
        txtCategoryName_sell.Size = New Size(240, 34)
        txtCategoryName_sell.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Chocolate
        Label2.Location = New Point(124, 301)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 31)
        Label2.TabIndex = 16
        Label2.Text = "Categories Name"
        ' 
        ' btmAddCategory_sell
        ' 
        btmAddCategory_sell.BackColor = Color.Chocolate
        btmAddCategory_sell.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btmAddCategory_sell.ForeColor = Color.Snow
        btmAddCategory_sell.Location = New Point(139, 413)
        btmAddCategory_sell.Name = "btmAddCategory_sell"
        btmAddCategory_sell.Size = New Size(175, 44)
        btmAddCategory_sell.TabIndex = 15
        btmAddCategory_sell.Text = "Add Category"
        btmAddCategory_sell.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Chocolate
        Label1.Location = New Point(800, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 40)
        Label1.TabIndex = 14
        Label1.Text = "  Manage Items  "
        ' 
        ' Combo_addCategory_sell
        ' 
        Combo_addCategory_sell.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Combo_addCategory_sell.FormattingEnabled = True
        Combo_addCategory_sell.Location = New Point(39, 193)
        Combo_addCategory_sell.Name = "Combo_addCategory_sell"
        Combo_addCategory_sell.Size = New Size(240, 35)
        Combo_addCategory_sell.TabIndex = 13
        ' 
        ' Seller
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1055)
        Controls.Add(Panel1)
        Name = "Seller"
        Text = "Seller"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(view_yourOrder, ComponentModel.ISupportInitialize).EndInit()
        CType(Item_list, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Combo_addCategory_sell As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btmAddCategory_sell As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh_sell As Button
    Friend WithEvents txtCategoryName_sell As TextBox
    Friend WithEvents btnAddBill As Button
    Friend WithEvents txt_quantity_sell As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Item_list As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_view_orders As Button
    Friend WithEvents view_yourOrder As DataGridView
    Friend WithEvents btn_logout_seller As Button
End Class
