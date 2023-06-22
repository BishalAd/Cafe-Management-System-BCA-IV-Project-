Public Class Welcome
    Private Sub BtnAdmin_Click(sender As Object, e As EventArgs) Handles BtnAdmin.Click
        Dim obj = New Admin_login()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSeller_Click(sender As Object, e As EventArgs) Handles BtnSeller.Click
        Dim obj = New Seller_login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class