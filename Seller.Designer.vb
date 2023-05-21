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
        Label7 = New Label()
        btn_refresh = New Button()
        btn_add_to_bill = New Button()
        btn_print = New Button()
        btn_view_order = New Button()
        combo_category = New ComboBox()
        txt_quantity_seller = New TextBox()
        txt_category_name = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel3 = New Panel()
        btn_add_category = New Button()
        Label1 = New Label()
        btn_Back_seller = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(412, 319)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 31)
        Label7.TabIndex = 6
        Label7.Text = "Your Order"
        ' 
        ' btn_refresh
        ' 
        btn_refresh.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_refresh.Location = New Point(245, 81)
        btn_refresh.Name = "btn_refresh"
        btn_refresh.Size = New Size(146, 44)
        btn_refresh.TabIndex = 14
        btn_refresh.Text = "Refresh"
        btn_refresh.UseVisualStyleBackColor = True
        ' 
        ' btn_add_to_bill
        ' 
        btn_add_to_bill.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_add_to_bill.Location = New Point(864, 275)
        btn_add_to_bill.Name = "btn_add_to_bill"
        btn_add_to_bill.Size = New Size(146, 44)
        btn_add_to_bill.TabIndex = 13
        btn_add_to_bill.Text = "Add To Bill"
        btn_add_to_bill.UseVisualStyleBackColor = True
        ' 
        ' btn_print
        ' 
        btn_print.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_print.Location = New Point(271, 571)
        btn_print.Name = "btn_print"
        btn_print.Size = New Size(146, 44)
        btn_print.TabIndex = 12
        btn_print.Text = "Print"
        btn_print.UseVisualStyleBackColor = True
        ' 
        ' btn_view_order
        ' 
        btn_view_order.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_view_order.Location = New Point(580, 571)
        btn_view_order.Name = "btn_view_order"
        btn_view_order.Size = New Size(146, 44)
        btn_view_order.TabIndex = 4
        btn_view_order.Text = "View Orders"
        btn_view_order.UseVisualStyleBackColor = True
        ' 
        ' combo_category
        ' 
        combo_category.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        combo_category.FormattingEnabled = True
        combo_category.Location = New Point(16, 86)
        combo_category.Name = "combo_category"
        combo_category.Size = New Size(200, 36)
        combo_category.TabIndex = 11
        ' 
        ' txt_quantity_seller
        ' 
        txt_quantity_seller.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_quantity_seller.Location = New Point(689, 280)
        txt_quantity_seller.Name = "txt_quantity_seller"
        txt_quantity_seller.Size = New Size(130, 34)
        txt_quantity_seller.TabIndex = 9
        ' 
        ' txt_category_name
        ' 
        txt_category_name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_category_name.Location = New Point(16, 177)
        txt_category_name.Name = "txt_category_name"
        txt_category_name.Size = New Size(196, 34)
        txt_category_name.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(572, 280)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 28)
        Label3.TabIndex = 4
        Label3.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(476, 579)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 28)
        Label4.TabIndex = 5
        Label4.Text = "Total"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(717, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 28)
        Label5.TabIndex = 6
        Label5.Text = "Items List"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(75, 136)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 28)
        Label6.TabIndex = 7
        Label6.Text = "Name"
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(500, 81)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(545, 179)
        Panel3.TabIndex = 5
        ' 
        ' btn_add_category
        ' 
        btn_add_category.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_add_category.Location = New Point(32, 231)
        btn_add_category.Name = "btn_add_category"
        btn_add_category.Size = New Size(159, 44)
        btn_add_category.TabIndex = 19
        btn_add_category.Text = "Add Categories"
        btn_add_category.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(374, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(204, 40)
        Label1.TabIndex = 0
        Label1.Text = "Manage Items"
        ' 
        ' btn_Back_seller
        ' 
        btn_Back_seller.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_Back_seller.Location = New Point(12, 572)
        btn_Back_seller.Name = "btn_Back_seller"
        btn_Back_seller.Size = New Size(107, 44)
        btn_Back_seller.TabIndex = 20
        btn_Back_seller.Text = "Back"
        btn_Back_seller.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Snow
        Panel1.Controls.Add(btn_view_order)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btn_print)
        Panel1.Controls.Add(btn_add_to_bill)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btn_add_category)
        Panel1.Controls.Add(btn_refresh)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(txt_quantity_seller)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txt_category_name)
        Panel1.Controls.Add(combo_category)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(125, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1055, 626)
        Panel1.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(88, 365)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(865, 200)
        Panel2.TabIndex = 4
        ' 
        ' Seller
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1182, 628)
        Controls.Add(btn_Back_seller)
        Controls.Add(Panel1)
        Name = "Seller"
        Text = "Seller"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_add_to_bill As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_view_order As Button
    Friend WithEvents combo_category As ComboBox
    Friend WithEvents txt_quantity_seller As TextBox
    Friend WithEvents txt_category_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_add_category As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Back_seller As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
