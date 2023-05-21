<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewOrder
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
        Label1 = New Label()
        Panel1 = New Panel()
        btn_back_order = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(284, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 40)
        Label1.TabIndex = 1
        Label1.Text = "Order List"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Snow
        Panel1.Location = New Point(45, 63)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(676, 504)
        Panel1.TabIndex = 2
        ' 
        ' btn_back_order
        ' 
        btn_back_order.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_back_order.Location = New Point(304, 587)
        btn_back_order.Name = "btn_back_order"
        btn_back_order.Size = New Size(146, 44)
        btn_back_order.TabIndex = 5
        btn_back_order.Text = "Back"
        btn_back_order.UseVisualStyleBackColor = True
        ' 
        ' viewOrder
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        ClientSize = New Size(767, 643)
        Controls.Add(btn_back_order)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "viewOrder"
        Text = "viewOrder"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_back_order As Button
End Class
