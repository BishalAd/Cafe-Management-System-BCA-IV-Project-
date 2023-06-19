Imports System.Data.SqlClient

Public Class Add_New_Cagegory
    Dim Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True")
    Dim key As Integer = 0
    Private Sub btnAddCat_Click(sender As Object, e As EventArgs) Handles btnAddCat.Click
        If CatTb.Text = "" Then
            MsgBox("Enter The Category")
        Else
            Con.Open()
            Dim query = "insert into CategoryTbl(CatName) values('" & cattb.Text & "')"
            Dim cmd As SqlCommand = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Category Added")
            Con.Close()
            cattb.Text = ""
            FillCategory()
        End If

    End Sub
    Private Sub Reset()
        txtName.Text = ""
        combo.SelectedIndex = 0
        txtQuantity.Text = ""
        txtPrice.Text = ""
    End Sub
    Private Sub FillCategory()
        Con.Open()
        Dim cmd = New SqlCommand("SELECT * FROM CategoryTbl", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        combo.DataSource = Tbl
        combo.DisplayMember = "CatName"
        combo.ValueMember = "CatName"
        Con.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Reset()
    End Sub

    Private Sub Add_New_Cagegory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()
    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "Select * from item"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If combo.SelectedIndex = -1 Or txtName.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "INSERT INTO Item (name, Item_Cat, Item_Price, Item_Qty) VALUES ('" & txtName.Text & "', '" & combo.SelectedValue.ToString() & "', '" & txtPrice.Text & "', '" & txtQuantity.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Added")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub
    'Dim key As Integer = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        txtName.Text = row.Cells(1).Value.ToString
        combo.SelectedValue = row.Cells(2).Value.ToString
        txtPrice.Text = row.Cells(3).Value.ToString
        txtQuantity.Text = row.Cells(4).Value.ToString
        If txtName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If key = 0 Then
            MsgBox("Select The Item To Delete.")
        Else
            Con.Open()
            Dim query = "Delete from item where item_id = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Deleted")
            Con.Close()
            Reset()
            DisplayItem()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If combo.SelectedIndex = -1 Or txtName.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "UPDATE item SET name = '" & txtName.Text & "', Item_Cat = '" & combo.SelectedValue & "', Item_Price = " & txtPrice.Text & ", Item_Qty = " & txtQuantity.Text & " WHERE item_id = " & key & ""
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

    Private Sub btn_logout_admin_Click(sender As Object, e As EventArgs) Handles btn_logout_admin.Click
        Dim obj = New Admin_login
        obj.Show()
        Me.Hide()
    End Sub

End Class