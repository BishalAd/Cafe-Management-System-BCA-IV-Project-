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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Seller))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Panel5 = New Panel()
        PictureBox3 = New PictureBox()
        btn_logout_seller = New Button()
        Panel4 = New Panel()
        PictureBox2 = New PictureBox()
        btnGotoAdmin = New Button()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        btnHome = New Button()
        Panel2 = New Panel()
        slbl = New Label()
        ItemDGV = New DataGridView()
        TotalBill = New Label()
        btn_print = New Button()
        btn_view_orders = New Button()
        BilDGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        btnAddBill = New Button()
        txt_quantity_sell = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        btnRefresh_sell = New Button()
        Label1 = New Label()
        combo = New ComboBox()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(BilDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Chocolate
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1924, 1061)
        Panel1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Snow
        Panel5.Controls.Add(PictureBox3)
        Panel5.Controls.Add(btn_logout_seller)
        Panel5.Location = New Point(21, 885)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(207, 49)
        Panel5.TabIndex = 29
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(6, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(47, 44)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' btn_logout_seller
        ' 
        btn_logout_seller.BackColor = Color.Snow
        btn_logout_seller.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_logout_seller.Location = New Point(50, 3)
        btn_logout_seller.Name = "btn_logout_seller"
        btn_logout_seller.Size = New Size(157, 44)
        btn_logout_seller.TabIndex = 16
        btn_logout_seller.Text = "Logout"
        btn_logout_seller.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Snow
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(btnGotoAdmin)
        Panel4.Location = New Point(21, 742)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(207, 49)
        Panel4.TabIndex = 29
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(6, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 44)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' btnGotoAdmin
        ' 
        btnGotoAdmin.BackColor = Color.Snow
        btnGotoAdmin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnGotoAdmin.Location = New Point(46, 4)
        btnGotoAdmin.Name = "btnGotoAdmin"
        btnGotoAdmin.Size = New Size(161, 44)
        btnGotoAdmin.TabIndex = 24
        btnGotoAdmin.Text = "Admin"
        btnGotoAdmin.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Snow
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(btnHome)
        Panel3.Location = New Point(21, 600)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(207, 49)
        Panel3.TabIndex = 28
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
        ' btnHome
        ' 
        btnHome.BackColor = Color.Snow
        btnHome.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnHome.Location = New Point(46, 2)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(161, 44)
        btnHome.TabIndex = 25
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Snow
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(slbl)
        Panel2.Controls.Add(ItemDGV)
        Panel2.Controls.Add(TotalBill)
        Panel2.Controls.Add(btn_print)
        Panel2.Controls.Add(btn_view_orders)
        Panel2.Controls.Add(BilDGV)
        Panel2.Controls.Add(btnAddBill)
        Panel2.Controls.Add(txt_quantity_sell)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btnRefresh_sell)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(combo)
        Panel2.Location = New Point(258, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1632, 1009)
        Panel2.TabIndex = 0
        ' 
        ' slbl
        ' 
        slbl.AutoSize = True
        slbl.Location = New Point(110, 19)
        slbl.Name = "slbl"
        slbl.Size = New Size(52, 20)
        slbl.TabIndex = 31
        slbl.Text = "sname"
        ' 
        ' ItemDGV
        ' 
        ItemDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ItemDGV.BackgroundColor = Color.Snow
        ItemDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        ItemDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemDGV.Cursor = Cursors.Hand
        ItemDGV.EnableHeadersVisualStyles = False
        ItemDGV.Location = New Point(709, 147)
        ItemDGV.Name = "ItemDGV"
        ItemDGV.RowHeadersWidth = 51
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ItemDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        ItemDGV.RowTemplate.Height = 29
        ItemDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ItemDGV.Size = New Size(890, 332)
        ItemDGV.TabIndex = 30
        ' 
        ' TotalBill
        ' 
        TotalBill.AutoSize = True
        TotalBill.BackColor = Color.Transparent
        TotalBill.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        TotalBill.ForeColor = Color.Chocolate
        TotalBill.Location = New Point(1434, 760)
        TotalBill.Name = "TotalBill"
        TotalBill.Size = New Size(67, 31)
        TotalBill.TabIndex = 28
        TotalBill.Text = "Total"
        ' 
        ' btn_print
        ' 
        btn_print.BackColor = Color.Chocolate
        btn_print.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_print.ForeColor = Color.Snow
        btn_print.Location = New Point(1380, 675)
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
        btn_view_orders.Location = New Point(1380, 844)
        btn_view_orders.Name = "btn_view_orders"
        btn_view_orders.Size = New Size(186, 53)
        btn_view_orders.TabIndex = 26
        btn_view_orders.Text = "View Orders"
        btn_view_orders.UseVisualStyleBackColor = False
        ' 
        ' BilDGV
        ' 
        BilDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BilDGV.BackgroundColor = SystemColors.ControlLightLight
        BilDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BilDGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        BilDGV.GridColor = SystemColors.ActiveBorder
        BilDGV.Location = New Point(110, 619)
        BilDGV.Name = "BilDGV"
        BilDGV.RowHeadersWidth = 51
        BilDGV.RowTemplate.Height = 29
        BilDGV.Size = New Size(1156, 364)
        BilDGV.TabIndex = 25
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
        ' btnAddBill
        ' 
        btnAddBill.BackColor = Color.Chocolate
        btnAddBill.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddBill.ForeColor = Color.Snow
        btnAddBill.Location = New Point(1220, 500)
        btnAddBill.Name = "btnAddBill"
        btnAddBill.Size = New Size(175, 44)
        btnAddBill.TabIndex = 24
        btnAddBill.Text = "Add To Bill"
        btnAddBill.UseVisualStyleBackColor = False
        ' 
        ' txt_quantity_sell
        ' 
        txt_quantity_sell.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txt_quantity_sell.Location = New Point(1010, 507)
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
        Label5.Location = New Point(860, 510)
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
        Label4.Location = New Point(636, 567)
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
        Label3.Location = New Point(1073, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 40)
        Label3.TabIndex = 20
        Label3.Text = "Items List"
        ' 
        ' btnRefresh_sell
        ' 
        btnRefresh_sell.BackColor = Color.Chocolate
        btnRefresh_sell.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefresh_sell.ForeColor = Color.Snow
        btnRefresh_sell.Location = New Point(355, 337)
        btnRefresh_sell.Name = "btnRefresh_sell"
        btnRefresh_sell.Size = New Size(188, 51)
        btnRefresh_sell.TabIndex = 18
        btnRefresh_sell.Text = "Refresh"
        btnRefresh_sell.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Chocolate
        Label1.Location = New Point(709, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 40)
        Label1.TabIndex = 14
        Label1.Text = "  Manage Items  "
        ' 
        ' combo
        ' 
        combo.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        combo.FormattingEnabled = True
        combo.Location = New Point(57, 344)
        combo.Name = "combo"
        combo.Size = New Size(240, 35)
        combo.TabIndex = 13
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 20)
        Label6.TabIndex = 32
        Label6.Text = "sname"
        ' 
        ' Seller
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel1)
        Name = "Seller"
        Text = "Seller"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ItemDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(BilDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents combo As ComboBox
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
    Friend WithEvents TotalBill As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_view_orders As Button
    Friend WithEvents BilDGV As DataGridView
    Friend WithEvents btn_logout_seller As Button
    Friend WithEvents ItemDGV As DataGridView
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnHome As Button
    Friend WithEvents btnGotoAdmin As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents slbl As Label
    Friend WithEvents Label6 As Label
End Class
