<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_category
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Add_category))
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        Panel2 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        btn_logout_seller = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(195, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(990, 626)
        Panel1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(17, 296)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(946, 303)
        DataGridView1.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label7.ForeColor = Color.Snow
        Label7.Location = New Point(404, 253)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 40)
        Label7.TabIndex = 6
        Label7.Text = "Items List"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(17, 80)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(958, 158)
        Panel2.TabIndex = 4
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Snow
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(620, 99)
        Button5.Name = "Button5"
        Button5.Size = New Size(146, 44)
        Button5.TabIndex = 14
        Button5.Text = "Add Category"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Snow
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(442, 99)
        Button4.Name = "Button4"
        Button4.Size = New Size(146, 44)
        Button4.TabIndex = 13
        Button4.Text = "Remove"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Snow
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(262, 99)
        Button3.Name = "Button3"
        Button3.Size = New Size(146, 44)
        Button3.TabIndex = 12
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Snow
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(78, 99)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 44)
        Button2.TabIndex = 4
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(283, 49)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(215, 35)
        ComboBox1.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(548, 49)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(130, 34)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(714, 49)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(130, 34)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(28, 49)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(196, 34)
        TextBox2.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Snow
        Label3.Location = New Point(723, 9)
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
        Label4.Location = New Point(565, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 31)
        Label4.TabIndex = 5
        Label4.Text = "Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Snow
        Label5.Location = New Point(308, 9)
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
        Label6.Location = New Point(28, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 31)
        Label6.TabIndex = 7
        Label6.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(374, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 40)
        Label1.TabIndex = 0
        Label1.Text = "  Manage Items  "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(18, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 62)
        Label2.TabIndex = 1
        Label2.Text = "New Category " & vbCrLf & "     Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(8, 141)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(181, 34)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Snow
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(8, 212)
        Button1.Name = "Button1"
        Button1.Size = New Size(175, 44)
        Button1.TabIndex = 3
        Button1.Text = "Add Category"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btn_logout_seller
        ' 
        btn_logout_seller.BackColor = Color.Snow
        btn_logout_seller.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_logout_seller.Location = New Point(32, 572)
        btn_logout_seller.Name = "btn_logout_seller"
        btn_logout_seller.Size = New Size(107, 44)
        btn_logout_seller.TabIndex = 15
        btn_logout_seller.Text = "Logout"
        btn_logout_seller.UseVisualStyleBackColor = False
        ' 
        ' Add_category
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1182, 628)
        Controls.Add(btn_logout_seller)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Name = "Add_category"
        Text = "Add_category"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_logout_seller As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
