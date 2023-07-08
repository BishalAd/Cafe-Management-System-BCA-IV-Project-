Imports System.Data.SqlClient
Public Class Add_Employee
    Dim Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True")
    Private Sub DisplayItem()
        Try
            Con.Open()
            Dim query = "SELECT * FROM EmployeeTbl"
            Dim cmd = New SqlCommand(query, Con)
            Dim adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            EmployeeDGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            ' Handle the exception, display or log the error message.
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Private Sub Reset()
        txtName.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
        txtRole.Text = ""
        key = 0
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or txtPassword.Text = "" Or txtRole.Text = "" Or txtPhone.Text = "" Then
            MsgBox("Missing Data")
        Else
            Try
                Con.Open()
                Dim query = "insert into EmployeeTbl (EmpName, EmpPhone, EmpRole, EmpPassword) values('" & txtName.Text & "', '" & txtPhone.Text & "', '" & txtRole.Text & "', '" & txtPassword.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Successfully Saved")
                Con.Close()
                DisplayItem()
                Reset()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        DisplayItem()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Reset()
    End Sub
    Dim key = 0
    Private Sub EmployeeDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeDGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeeDGV.Rows(e.RowIndex)
        txtName.Text = row.Cells(1).Value.ToString
        txtPhone.Text = row.Cells(2).Value.ToString
        txtRole.Text = row.Cells(3).Value.ToString
        txtPassword.Text = row.Cells(4).Value.ToString
        If txtName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If key = 0 Then
            MsgBox("Select The Employee To Delete.")
        Else
            Con.Open()
            Dim query = "Delete from EmployeeTbl where EmpId = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Employee Info. Deleted")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtName.Text = "" Or txtPhone.Text = "" Or txtRole.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "UPDATE EmployeeTbl SET EmpName = '" & txtName.Text & "', EmpPhone = '" & txtPhone.Text & "', EmpRole = '" & txtRole.Text & "', EmpPassword = '" & txtPassword.Text & "' WHERE EmpId = " & key & ""
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Edited")
                Con.Close()
                Reset()
                DisplayItem()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim obj = New Welcome
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddEmpBack_Click(sender As Object, e As EventArgs) Handles btnAddEmpBack.Click
        Dim obj = New Add_New_Cagegory
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnGotoSeller_Click(sender As Object, e As EventArgs) Handles btnGotoSeller.Click
        Dim obj = New Seller_login
        obj.Show()
        Me.Hide()
    End Sub
End Class