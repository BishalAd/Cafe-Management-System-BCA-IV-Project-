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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Add_New_Cagegory))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        TextBox4 = New TextBox()
        Label1 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btn_logout_admin = New Button()
        Add_category_itemList = New DataGridView()
        Label7 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        TextBox2 = New TextBox()
        CType(Add_category_itemList, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Snow
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(27, 295)
        Button1.Name = "Button1"
        Button1.Size = New Size(175, 44)
        Button1.TabIndex = 19
        Button1.Text = "Add Category"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(27, 224)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(181, 34)
        TextBox1.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(37, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 62)
        Label2.TabIndex = 17
        Label2.Text = "New Category " & vbCrLf & "     Name"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Snow
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(1149, 154)
        Button5.Name = "Button5"
        Button5.Size = New Size(201, 55)
        Button5.TabIndex = 14
        Button5.Text = "Add Category"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Snow
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(834, 152)
        Button4.Name = "Button4"
        Button4.Size = New Size(206, 53)
        Button4.TabIndex = 13
        Button4.Text = "Remove"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Snow
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(466, 154)
        Button3.Name = "Button3"
        Button3.Size = New Size(224, 55)
        Button3.TabIndex = 12
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Snow
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(167, 154)
        Button2.Name = "Button2"
        Button2.Size = New Size(185, 55)
        Button2.TabIndex = 4
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(538, 83)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(215, 35)
        ComboBox1.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(932, 83)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(130, 34)
        TextBox4.TabIndex = 10
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
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(1264, 103)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(130, 34)
        TextBox3.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Snow
        Label3.Location = New Point(1264, 43)
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
        Label4.Location = New Point(949, 43)
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
        Label5.Location = New Point(563, 43)
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
        Label6.Location = New Point(226, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 31)
        Label6.TabIndex = 7
        Label6.Text = "Name"
        ' 
        ' btn_logout_admin
        ' 
        btn_logout_admin.BackColor = Color.Snow
        btn_logout_admin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_logout_admin.Location = New Point(37, 867)
        btn_logout_admin.Name = "btn_logout_admin"
        btn_logout_admin.Size = New Size(107, 44)
        btn_logout_admin.TabIndex = 20
        btn_logout_admin.Text = "Logout"
        btn_logout_admin.UseVisualStyleBackColor = False
        ' 
        ' Add_category_itemList
        ' 
        Add_category_itemList.BackgroundColor = SystemColors.ControlLightLight
        Add_category_itemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Add_category_itemList.Location = New Point(80, 469)
        Add_category_itemList.Name = "Add_category_itemList"
        Add_category_itemList.RowHeadersWidth = 51
        Add_category_itemList.RowTemplate.Height = 29
        Add_category_itemList.Size = New Size(1547, 485)
        Add_category_itemList.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label7.ForeColor = Color.Snow
        Label7.Location = New Point(644, 391)
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
        Panel1.Controls.Add(Add_category_itemList)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(214, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1709, 1052)
        Panel1.TabIndex = 16
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
        Panel2.Size = New Size(1449, 247)
        Panel2.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(156, 88)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(232, 34)
        TextBox2.TabIndex = 8
        ' 
        ' Add_New_Cagegory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        ClientSize = New Size(1924, 1055)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(btn_logout_admin)
        Controls.Add(Panel1)
        Name = "Add_New_Cagegory"
        Text = "Add_New_Cagegory"
        CType(Add_category_itemList, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_logout_admin As Button
    Friend WithEvents Add_category_itemList As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
End Class
