<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lbl_PName = New Label()
        lbl_login = New Label()
        lbl_UserName = New Label()
        lbl_password = New Label()
        btn_login = New Button()
        txt_username = New TextBox()
        txt_password = New TextBox()
        SuspendLayout()
        ' 
        ' lbl_PName
        ' 
        lbl_PName.AutoSize = True
        lbl_PName.Font = New Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_PName.ForeColor = Color.Chocolate
        lbl_PName.Location = New Point(208, 82)
        lbl_PName.Name = "lbl_PName"
        lbl_PName.Size = New Size(630, 56)
        lbl_PName.TabIndex = 0
        lbl_PName.Text = "Cafe Management System"
        ' 
        ' lbl_login
        ' 
        lbl_login.AutoSize = True
        lbl_login.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        lbl_login.ForeColor = Color.Chocolate
        lbl_login.Location = New Point(443, 186)
        lbl_login.Name = "lbl_login"
        lbl_login.Size = New Size(114, 44)
        lbl_login.TabIndex = 1
        lbl_login.Text = "Login"
        ' 
        ' lbl_UserName
        ' 
        lbl_UserName.AutoSize = True
        lbl_UserName.BackColor = Color.Snow
        lbl_UserName.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_UserName.ForeColor = Color.Chocolate
        lbl_UserName.Location = New Point(283, 269)
        lbl_UserName.Name = "lbl_UserName"
        lbl_UserName.Size = New Size(169, 34)
        lbl_UserName.TabIndex = 2
        lbl_UserName.Text = "User Name "
        ' 
        ' lbl_password
        ' 
        lbl_password.AutoSize = True
        lbl_password.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_password.ForeColor = Color.Chocolate
        lbl_password.Location = New Point(283, 347)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(142, 34)
        lbl_password.TabIndex = 3
        lbl_password.Text = "Password"
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.Chocolate
        btn_login.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        btn_login.ForeColor = Color.Snow
        btn_login.Location = New Point(443, 420)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(184, 66)
        btn_login.TabIndex = 4
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' txt_username
        ' 
        txt_username.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        txt_username.ForeColor = Color.Chocolate
        txt_username.Location = New Point(458, 266)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(224, 41)
        txt_username.TabIndex = 5
        ' 
        ' txt_password
        ' 
        txt_password.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.ForeColor = Color.Chocolate
        txt_password.Location = New Point(458, 344)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(224, 41)
        txt_password.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(1009, 557)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(btn_login)
        Controls.Add(lbl_password)
        Controls.Add(lbl_UserName)
        Controls.Add(lbl_login)
        Controls.Add(lbl_PName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_PName As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_UserName As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
End Class
