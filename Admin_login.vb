Imports System.Data.SqlClient
Public Class Admin_login
    Dim Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True")
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_password.Text = "" Then
            MsgBox("Enter UserName and Password")
        Else
            Con.Open()
            Dim query = "select * from Admin_pass where Admin_Password = '" & txt_password.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                txt_password.Text = ""
                MsgBox("Wrong UserName Or Password")
            Else
                Dim obj = New Add_New_Cagegory
                obj.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            txt_password.PasswordChar = "*"
        Else
            txt_password.PasswordChar = ""
        End If
    End Sub
    Private Sub Btn_back_Click_1(sender As Object, e As EventArgs) Handles Btn_back.Click
        Dim obj = New Welcome
        obj.Show()
        Me.Hide()
    End Sub
End Class
