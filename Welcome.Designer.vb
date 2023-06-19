<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Welcome))
        welcome_intro = New Label()
        BtnAdmin = New Button()
        BtnSeller = New Button()
        SuspendLayout()
        ' 
        ' welcome_intro
        ' 
        welcome_intro.AutoSize = True
        welcome_intro.BackColor = Color.Transparent
        welcome_intro.FlatStyle = FlatStyle.Popup
        welcome_intro.Font = New Font("Viner Hand ITC", 72F, FontStyle.Bold, GraphicsUnit.Point)
        welcome_intro.ForeColor = SystemColors.Control
        welcome_intro.Location = New Point(1013, 65)
        welcome_intro.Name = "welcome_intro"
        welcome_intro.Size = New Size(765, 388)
        welcome_intro.TabIndex = 0
        welcome_intro.Text = "Welcome To " & vbCrLf & "Himal Cafe"
        ' 
        ' BtnAdmin
        ' 
        BtnAdmin.AutoSize = True
        BtnAdmin.BackColor = Color.Snow
        BtnAdmin.Font = New Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAdmin.Location = New Point(882, 589)
        BtnAdmin.Name = "BtnAdmin"
        BtnAdmin.Size = New Size(297, 84)
        BtnAdmin.TabIndex = 1
        BtnAdmin.Text = "Admin"
        BtnAdmin.UseVisualStyleBackColor = False
        ' 
        ' BtnSeller
        ' 
        BtnSeller.AutoSize = True
        BtnSeller.BackColor = Color.Snow
        BtnSeller.Font = New Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSeller.Location = New Point(882, 782)
        BtnSeller.Name = "BtnSeller"
        BtnSeller.Size = New Size(297, 75)
        BtnSeller.TabIndex = 2
        BtnSeller.Text = "Seller"
        BtnSeller.UseVisualStyleBackColor = False
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Black
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 1055)
        Controls.Add(BtnSeller)
        Controls.Add(BtnAdmin)
        Controls.Add(welcome_intro)
        DoubleBuffered = True
        Name = "Welcome"
        Text = "Welcome"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents welcome_intro As Label
    Friend WithEvents BtnAdmin As Button
    Friend WithEvents BtnSeller As Button
End Class
