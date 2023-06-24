<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seller_login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Seller_login))
        CheckBox1 = New CheckBox()
        txt_SellerPassword = New TextBox()
        txt_SellerUsername = New TextBox()
        lbl_password = New Label()
        lbl_UserName = New Label()
        lbl_PName = New Label()
        btn_SellerLogin = New Button()
        Btn_back = New Button()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.ForeColor = Color.Chocolate
        CheckBox1.Location = New Point(336, 769)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(158, 28)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' txt_SellerPassword
        ' 
        txt_SellerPassword.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        txt_SellerPassword.ForeColor = Color.Chocolate
        txt_SellerPassword.Location = New Point(326, 712)
        txt_SellerPassword.Name = "txt_SellerPassword"
        txt_SellerPassword.PasswordChar = "*"c
        txt_SellerPassword.Size = New Size(257, 41)
        txt_SellerPassword.TabIndex = 12
        ' 
        ' txt_SellerUsername
        ' 
        txt_SellerUsername.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        txt_SellerUsername.ForeColor = Color.Chocolate
        txt_SellerUsername.HideSelection = False
        txt_SellerUsername.Location = New Point(340, 583)
        txt_SellerUsername.Name = "txt_SellerUsername"
        txt_SellerUsername.Size = New Size(243, 41)
        txt_SellerUsername.TabIndex = 11
        ' 
        ' lbl_password
        ' 
        lbl_password.AutoSize = True
        lbl_password.BackColor = Color.Transparent
        lbl_password.Font = New Font("Viner Hand ITC", 22F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_password.ForeColor = Color.Chocolate
        lbl_password.Location = New Point(134, 706)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(186, 60)
        lbl_password.TabIndex = 10
        lbl_password.Text = "Password"
        ' 
        ' lbl_UserName
        ' 
        lbl_UserName.AutoSize = True
        lbl_UserName.BackColor = Color.Transparent
        lbl_UserName.Font = New Font("Viner Hand ITC", 22F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_UserName.ForeColor = Color.Chocolate
        lbl_UserName.Location = New Point(109, 577)
        lbl_UserName.Name = "lbl_UserName"
        lbl_UserName.Size = New Size(225, 60)
        lbl_UserName.TabIndex = 9
        lbl_UserName.Text = "User Name "
        ' 
        ' lbl_PName
        ' 
        lbl_PName.AutoSize = True
        lbl_PName.BackColor = Color.Transparent
        lbl_PName.Font = New Font("Viner Hand ITC", 40F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_PName.ForeColor = Color.Chocolate
        lbl_PName.Location = New Point(44, 104)
        lbl_PName.Name = "lbl_PName"
        lbl_PName.Size = New Size(635, 216)
        lbl_PName.TabIndex = 8
        lbl_PName.Text = "Cafe Management" & vbCrLf & "          System"
        ' 
        ' btn_SellerLogin
        ' 
        btn_SellerLogin.BackColor = Color.Chocolate
        btn_SellerLogin.Font = New Font("Viner Hand ITC", 20F, FontStyle.Bold, GraphicsUnit.Point)
        btn_SellerLogin.ForeColor = Color.Snow
        btn_SellerLogin.Location = New Point(296, 882)
        btn_SellerLogin.Name = "btn_SellerLogin"
        btn_SellerLogin.Size = New Size(184, 66)
        btn_SellerLogin.TabIndex = 14
        btn_SellerLogin.Text = "Login"
        btn_SellerLogin.UseVisualStyleBackColor = False
        ' 
        ' Btn_back
        ' 
        Btn_back.BackColor = Color.Snow
        Btn_back.Font = New Font("Viner Hand ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_back.ForeColor = Color.Chocolate
        Btn_back.Location = New Point(52, 907)
        Btn_back.Name = "Btn_back"
        Btn_back.Size = New Size(152, 52)
        Btn_back.TabIndex = 15
        Btn_back.Text = " Back"
        Btn_back.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SeaShell
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btn_SellerLogin)
        Panel1.Controls.Add(lbl_PName)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(lbl_UserName)
        Panel1.Controls.Add(txt_SellerPassword)
        Panel1.Controls.Add(lbl_password)
        Panel1.Controls.Add(txt_SellerUsername)
        Panel1.Location = New Point(650, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(734, 1041)
        Panel1.TabIndex = 16
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(579, 702)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(89, 64)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(579, 560)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(89, 64)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Viner Hand ITC", 22.2F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Chocolate
        Label1.Location = New Point(219, 438)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 60)
        Label1.TabIndex = 15
        Label1.Text = "Seller Login"
        ' 
        ' Seller_login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1902, 1033)
        Controls.Add(Panel1)
        Controls.Add(Btn_back)
        DoubleBuffered = True
        Name = "Seller_login"
        Text = "Seller_login"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txt_SellerPassword As TextBox
    Friend WithEvents txt_SellerUsername As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_UserName As Label
    Friend WithEvents lbl_PName As Label
    Friend WithEvents btn_SellerLogin As Button
    Friend WithEvents Btn_back As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
