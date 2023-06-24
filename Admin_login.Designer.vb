<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Admin_login))
        lbl_PName = New Label()
        lbl_password = New Label()
        btn_login = New Button()
        txt_password = New TextBox()
        CheckBox1 = New CheckBox()
        Btn_back = New Button()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        lbl_UserName = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_PName
        ' 
        lbl_PName.AutoSize = True
        lbl_PName.BackColor = Color.Transparent
        lbl_PName.Font = New Font("Viner Hand ITC", 40F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_PName.ForeColor = Color.Chocolate
        lbl_PName.Location = New Point(14, 138)
        lbl_PName.Name = "lbl_PName"
        lbl_PName.Size = New Size(635, 216)
        lbl_PName.TabIndex = 0
        lbl_PName.Text = "Cafe Management" & vbCrLf & "          System"
        ' 
        ' lbl_password
        ' 
        lbl_password.AutoSize = True
        lbl_password.BackColor = Color.Transparent
        lbl_password.Font = New Font("Viner Hand ITC", 22F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_password.ForeColor = Color.Chocolate
        lbl_password.Location = New Point(122, 615)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(186, 60)
        lbl_password.TabIndex = 3
        lbl_password.Text = "Password"
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.Chocolate
        btn_login.Font = New Font("Viner Hand ITC", 20F, FontStyle.Bold, GraphicsUnit.Point)
        btn_login.ForeColor = Color.Snow
        btn_login.Location = New Point(128, 845)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(429, 66)
        btn_login.TabIndex = 4
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' txt_password
        ' 
        txt_password.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.ForeColor = Color.Chocolate
        txt_password.Location = New Point(323, 620)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(257, 41)
        txt_password.TabIndex = 6
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.ForeColor = Color.Chocolate
        CheckBox1.Location = New Point(333, 677)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(158, 28)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Btn_back
        ' 
        Btn_back.BackColor = Color.Snow
        Btn_back.Font = New Font("Viner Hand ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_back.ForeColor = Color.Black
        Btn_back.Location = New Point(58, 861)
        Btn_back.Name = "Btn_back"
        Btn_back.Size = New Size(152, 52)
        Btn_back.TabIndex = 8
        Btn_back.Text = " Back"
        Btn_back.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaShell
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(lbl_PName)
        Panel1.Controls.Add(lbl_UserName)
        Panel1.Controls.Add(btn_login)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(lbl_password)
        Panel1.Controls.Add(txt_password)
        Panel1.Location = New Point(586, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(664, 1019)
        Panel1.TabIndex = 9
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(575, 611)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(89, 64)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' lbl_UserName
        ' 
        lbl_UserName.AutoSize = True
        lbl_UserName.BackColor = Color.Transparent
        lbl_UserName.Font = New Font("Viner Hand ITC", 22.2F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        lbl_UserName.ForeColor = Color.Chocolate
        lbl_UserName.Location = New Point(232, 479)
        lbl_UserName.Name = "lbl_UserName"
        lbl_UserName.Size = New Size(259, 60)
        lbl_UserName.TabIndex = 2
        lbl_UserName.Text = "Admin Login"
        ' 
        ' Admin_login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel1)
        Controls.Add(Btn_back)
        DoubleBuffered = True
        Name = "Admin_login"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "Admin_login"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbl_PName As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Btn_back As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_UserName As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
