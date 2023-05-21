Public Class Admin_login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "" Or txt_password.Text = "" Then
            MsgBox("Enter UserName and Password")
        ElseIf txt_username.Text = "Admin" And txt_password.Text = "Password" Then
            Dim obj = New Add_category
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong UserName Or Password. Try Again...")
            txt_username.Text = ""
            txt_password.Text = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            txt_password.PasswordChar = "*"
        Else
            txt_password.PasswordChar = ""
        End If
    End Sub
    Private Sub Btn_back_Click(sender As Object, e As EventArgs)
        Dim obj = New Welcome
        obj.Show()
        Me.Hide()
    End Sub
End Class
