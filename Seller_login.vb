﻿Imports System.Data.SqlClient

Public Class Seller_login
    Dim Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True")
    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        Dim obj = New Welcome
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btn_SellerLogin_Click(sender As Object, e As EventArgs) Handles btn_SellerLogin.Click
        If txt_SellerUsername.Text = "" Or txt_SellerPassword.Text = "" Then
            MsgBox("Enter UserName or Password.")
        Else
            Con.Open()
            Dim query = "select * from EmployeeTbl where EmpName = '" & txt_SellerUsername.Text & "' and EmpPassword ='" & txt_SellerPassword.Text & "'"
            'Dim query As String = "SELECT COUNT(*) FROM EmployeeTbl WHERE EmpName = '" & txt_SellerUsername.Text & "' AND EmpPassword = '" & txt_SellerUsername.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong UserName Or Password")
            Else
                Dim obj = New Seller
                obj.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            txt_SellerPassword.PasswordChar = "*"
        Else
            txt_SellerPassword.PasswordChar = ""
        End If
    End Sub
End Class