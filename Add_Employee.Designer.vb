<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Employee
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
        Panel1 = New Panel()
        Label5 = New Label()
        EmployeeDGV = New DataGridView()
        Label7 = New Label()
        Panel2 = New Panel()
        txtPassword = New TextBox()
        Label2 = New Label()
        Button5 = New Button()
        btnRemove = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        txtRole = New TextBox()
        txtPhone = New TextBox()
        txtName = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        btnHome = New Button()
        btnGotoSeller = New Button()
        btnAddEmpBack = New Button()
        Panel1.SuspendLayout()
        CType(EmployeeDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Snow
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(EmployeeDGV)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(271, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1632, 1036)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label5.ForeColor = Color.Chocolate
        Label5.Location = New Point(744, 436)
        Label5.Name = "Label5"
        Label5.Size = New Size(225, 40)
        Label5.TabIndex = 12
        Label5.Text = "Employees List"
        ' 
        ' EmployeeDGV
        ' 
        EmployeeDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        EmployeeDGV.BackgroundColor = SystemColors.ControlLightLight
        EmployeeDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        EmployeeDGV.Cursor = Cursors.Hand
        EmployeeDGV.EnableHeadersVisualStyles = False
        EmployeeDGV.Location = New Point(205, 496)
        EmployeeDGV.Name = "EmployeeDGV"
        EmployeeDGV.RowHeadersWidth = 51
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EmployeeDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        EmployeeDGV.RowTemplate.Height = 29
        EmployeeDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        EmployeeDGV.Size = New Size(1378, 485)
        EmployeeDGV.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label7.ForeColor = Color.Snow
        Label7.Location = New Point(883, 427)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 40)
        Label7.TabIndex = 10
        Label7.Text = "Items List"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(btnRemove)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(btnAdd)
        Panel2.Controls.Add(txtRole)
        Panel2.Controls.Add(txtPhone)
        Panel2.Controls.Add(txtName)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(49, 107)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1492, 247)
        Panel2.TabIndex = 9
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(1185, 73)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(275, 34)
        txtPassword.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Chocolate
        Label2.Location = New Point(1244, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 31)
        Label2.TabIndex = 15
        Label2.Text = "Password"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Chocolate
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.Snow
        Button5.Location = New Point(1103, 158)
        Button5.Name = "Button5"
        Button5.Size = New Size(201, 55)
        Button5.TabIndex = 14
        Button5.Text = "Reset"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.Chocolate
        btnRemove.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnRemove.ForeColor = Color.Snow
        btnRemove.Location = New Point(777, 160)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(206, 53)
        btnRemove.TabIndex = 13
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Chocolate
        btnEdit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.Snow
        btnEdit.Location = New Point(442, 160)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(224, 55)
        btnEdit.TabIndex = 12
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Chocolate
        btnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.Snow
        btnAdd.Location = New Point(177, 160)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(185, 55)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' txtRole
        ' 
        txtRole.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtRole.Location = New Point(810, 73)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(275, 34)
        txtRole.TabIndex = 10
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhone.Location = New Point(446, 79)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(274, 34)
        txtPhone.TabIndex = 9
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(102, 79)
        txtName.Name = "txtName"
        txtName.Size = New Size(267, 34)
        txtName.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Chocolate
        Label3.Location = New Point(501, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 31)
        Label3.TabIndex = 4
        Label3.Text = "Phone No."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Chocolate
        Label4.Location = New Point(869, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 31)
        Label4.TabIndex = 5
        Label4.Text = "Role"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Chocolate
        Label6.Location = New Point(132, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(187, 31)
        Label6.TabIndex = 7
        Label6.Text = "Employee Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Chocolate
        Label1.Location = New Point(781, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 40)
        Label1.TabIndex = 8
        Label1.Text = "Employees"
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.Snow
        btnHome.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnHome.Location = New Point(65, 729)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(161, 44)
        btnHome.TabIndex = 26
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnGotoSeller
        ' 
        btnGotoSeller.BackColor = Color.Snow
        btnGotoSeller.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnGotoSeller.Location = New Point(65, 817)
        btnGotoSeller.Name = "btnGotoSeller"
        btnGotoSeller.Size = New Size(161, 44)
        btnGotoSeller.TabIndex = 25
        btnGotoSeller.Text = "Seller"
        btnGotoSeller.UseVisualStyleBackColor = False
        ' 
        ' btnAddEmpBack
        ' 
        btnAddEmpBack.BackColor = Color.Snow
        btnAddEmpBack.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddEmpBack.Location = New Point(65, 910)
        btnAddEmpBack.Name = "btnAddEmpBack"
        btnAddEmpBack.Size = New Size(161, 44)
        btnAddEmpBack.TabIndex = 24
        btnAddEmpBack.Text = "Back"
        btnAddEmpBack.UseVisualStyleBackColor = False
        ' 
        ' Add_Employee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        ClientSize = New Size(1902, 1033)
        Controls.Add(btnHome)
        Controls.Add(btnGotoSeller)
        Controls.Add(btnAddEmpBack)
        Controls.Add(Panel1)
        Name = "Add_Employee"
        Text = "Add_Employee"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(EmployeeDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnGotoSeller As Button
    Friend WithEvents btnAddEmpBack As Button
    Friend WithEvents EmployeeDGV As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtRole As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
End Class
