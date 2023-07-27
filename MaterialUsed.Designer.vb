<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaterialUsed
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
        Label2 = New Label()
        TotalSum = New Label()
        DateTimePicker1 = New DateTimePicker()
        OrderDGV = New DataGridView()
        btn_back_order = New Button()
        Label1 = New Label()
        CType(OrderDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Centaur", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(1547, 575)
        Label2.Name = "Label2"
        Label2.Size = New Size(298, 82)
        Label2.TabIndex = 40
        Label2.Text = "Today Total Used " & vbCrLf & "   Raw Material"
        ' 
        ' TotalSum
        ' 
        TotalSum.AutoSize = True
        TotalSum.Font = New Font("Centaur", 24F, FontStyle.Bold, GraphicsUnit.Point)
        TotalSum.ForeColor = Color.Snow
        TotalSum.Location = New Point(1626, 703)
        TotalSum.Name = "TotalSum"
        TotalSum.Size = New Size(108, 45)
        TotalSum.TabIndex = 39
        TotalSum.Text = "Total"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(1493, 152)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(397, 38)
        DateTimePicker1.TabIndex = 38
        ' 
        ' OrderDGV
        ' 
        OrderDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        OrderDGV.BackgroundColor = Color.Snow
        OrderDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        OrderDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        OrderDGV.Cursor = Cursors.Hand
        OrderDGV.EnableHeadersVisualStyles = False
        OrderDGV.Location = New Point(88, 105)
        OrderDGV.Name = "OrderDGV"
        OrderDGV.RowHeadersWidth = 51
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        OrderDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        OrderDGV.RowTemplate.Height = 29
        OrderDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        OrderDGV.Size = New Size(1357, 781)
        OrderDGV.TabIndex = 37
        ' 
        ' btn_back_order
        ' 
        btn_back_order.BackColor = Color.Snow
        btn_back_order.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btn_back_order.ForeColor = Color.Chocolate
        btn_back_order.Location = New Point(791, 909)
        btn_back_order.Name = "btn_back_order"
        btn_back_order.Size = New Size(174, 56)
        btn_back_order.TabIndex = 36
        btn_back_order.Text = "Back"
        btn_back_order.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(902, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 40)
        Label1.TabIndex = 35
        Label1.Text = "Raw Material"
        ' 
        ' MaterialUsed
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chocolate
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label2)
        Controls.Add(TotalSum)
        Controls.Add(DateTimePicker1)
        Controls.Add(OrderDGV)
        Controls.Add(btn_back_order)
        Controls.Add(Label1)
        Name = "MaterialUsed"
        Text = "MaterialUsed"
        WindowState = FormWindowState.Maximized
        CType(OrderDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TotalSum As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents OrderDGV As DataGridView
    Friend WithEvents btn_back_order As Button
    Friend WithEvents Label1 As Label
End Class
