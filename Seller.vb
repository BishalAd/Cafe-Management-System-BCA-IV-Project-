Public Class Seller
    Private Sub btn_logout_seller_Click(sender As Object, e As EventArgs) Handles btn_logout_seller.Click
        Dim obj = New Welcome
        obj.Show()
        Me.Hide()
    End Sub
End Class