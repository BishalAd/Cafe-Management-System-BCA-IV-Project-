Imports System.Data.SqlClient

Public Class Add_New_Cagegory
    Dim Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True")
    Dim key As Integer = 0

    Private Sub btnAddCat_Click(sender As Object, e As EventArgs) Handles btnAddCat.Click
        If cattb.Text = "" Then
            MsgBox("Enter The Category")
        Else
            ' Check if the category already exists
            If CategoryExists(cattb.Text) Then
                MsgBox("Category already exists.")
            Else
                Con.Open()
                Dim query = "INSERT INTO CategoryTbl(CatName) VALUES (@CatName)"
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@CatName", cattb.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Category Added")
                Con.Close()
                cattb.Text = ""
                FillCategory()
            End If
        End If
    End Sub

    Private Function CategoryExists(category As String) As Boolean
        Dim exists As Boolean = False

        Try
            Con.Open()
            Dim query = "SELECT COUNT(*) FROM CategoryTbl WHERE CatName = @CatName"
            Dim cmd As SqlCommand = New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@CatName", category)
            exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Catch ex As Exception
            ' Handle the exception, display or log the error message.
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        Finally
            Con.Close()
        End Try

        Return exists
    End Function


    Private Sub Reset()
        txtName.Text = ""
        combo.SelectedIndex = 0
        txtQuantity.Text = ""
        txtPrice.Text = ""
        txtCostPrice.Text = ""
    End Sub

    Private Sub FillCategory()
        Try
            Con.Open()
            Dim cmd = New SqlCommand("SELECT * FROM CategoryTbl", Con)
            Dim adapter = New SqlDataAdapter(cmd)
            Dim Tbl = New DataTable()
            adapter.Fill(Tbl)
            combo.DataSource = Tbl
            combo.DisplayMember = "CatName"
            combo.ValueMember = "CatName"
        Catch ex As Exception
            ' Handle the exception, display or log the error message.
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Reset()
    End Sub

    Private Sub Add_New_Cagegory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()
    End Sub

    Private Sub DisplayItem()
        Try
            Con.Open()
            Dim query = "SELECT item.item_id, item.name, item.Item_Cat, item.Item_Qty, item.Cost_Price, item.Item_Price FROM item INNER JOIN CategoryTbl ON item.Item_Cat = CategoryTbl.CatName"
            Dim cmd = New SqlCommand(query, Con)
            Dim adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            ItemDGV.DataSource = ds.Tables(0)

            ' Configure the DataGridView columns
            ItemDGV.Columns("item_id").HeaderText = "Item ID"
            ItemDGV.Columns("name").HeaderText = "Item Name"
            ItemDGV.Columns("Item_Cat").HeaderText = "Category"
            ItemDGV.Columns("Item_Qty").HeaderText = "Quantity"
            ItemDGV.Columns("Cost_Price").HeaderText = "Cost Price"
            ItemDGV.Columns("Item_Price").HeaderText = "Item Price"

            ' Hide the unnecessary columns
            '  ItemDGV.Columns("CatName").Visible = False
        Catch ex As Exception
            ' Handle the exception, display or log the error message.
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If combo.SelectedIndex = -1 Or txtName.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
            MsgBox("Missing Information")
        Else
            ' Check if the food item name already exists
            If FoodItemExists(txtName.Text) Then
                MsgBox("Food item already exists.")
            Else
                Con.Open()
                Dim query = "INSERT INTO item  VALUES (@Name, @Item_Cat , @Item_Qty, @Item_Price , @Cost_Price)"
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@Name", txtName.Text)
                cmd.Parameters.AddWithValue("@Item_Cat", combo.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@Item_Price", txtPrice.Text)
                cmd.Parameters.AddWithValue("@Item_Qty", txtQuantity.Text)
                cmd.Parameters.AddWithValue("@Cost_Price", txtCostPrice.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Item Added")
                Con.Close()
                Reset()
                DisplayItem()
            End If
        End If
    End Sub

    Private Function FoodItemExists(foodItemName As String) As Boolean
        Dim exists As Boolean = False

        Try
            Con.Open()
            Dim query = "SELECT COUNT(*) FROM item WHERE name = @Name"
            Dim cmd As SqlCommand = New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@Name", foodItemName)
            exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
        Catch ex As Exception
            ' Handle the exception, display or log the error message.
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        Finally
            Con.Close()
        End Try

        Return exists
    End Function


    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        txtName.Text = row.Cells(1).Value.ToString
        combo.SelectedValue = row.Cells(2).Value.ToString
        txtQuantity.Text = row.Cells(3).Value.ToString
        txtCostPrice.Text = row.Cells(4).Value.ToString
        txtPrice.Text = row.Cells(5).Value.ToString
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
            Dim query = "DELETE FROM item WHERE item_id = " & key & ""
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
                Dim query = "UPDATE item SET name = '" & txtName.Text & "', Item_Cat = '" & combo.SelectedValue & "', Item_Price = " & txtPrice.Text & ", Item_Qty = " & txtQuantity.Text & ", Cost_Price = " & txtCostPrice.Text & " WHERE item_id = " & key & ""
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

    Private Sub btnGotoSeller_Click(sender As Object, e As EventArgs) Handles btnGotoSeller.Click
        Dim obj = New Seller_login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Dim obj = New Add_Employee
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnDeleteCat_Click(sender As Object, e As EventArgs) Handles btnDeleteCat.Click
        Dim selectedCategory As String = combo.SelectedValue.ToString()

        ' Check if the selected category contains any food items
        If CheckCategoryContainsItems(selectedCategory) Then
            ' Show a confirmation message box
            Dim result As DialogResult = MessageBox.Show("This category contains food items. Do you want to delete the category and its associated food items?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Delete the category and its associated food items
                DeleteCategoryWithItems(selectedCategory)
                MsgBox("Category and associated food items deleted.")
            End If
        Else
            ' Delete the category as it does not contain any food items
            DeleteCategory(selectedCategory)
            MsgBox("Category deleted.")
        End If

        ' Refresh the category combo box and update the item list
        FillCategory()
        DisplayItem()
    End Sub

    Private Function CheckCategoryContainsItems(category As String) As Boolean
        Dim count As Integer = 0

        Try
            Con.Open()
            Dim query = "SELECT COUNT(*) FROM item WHERE Item_Cat = '" & category & "'"
            Dim cmd As SqlCommand = New SqlCommand(query, Con)
            count = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            ' Handle the exception, display or log the error message.
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        Finally
            Con.Close()
        End Try

        Return count > 0
    End Function

    Private Sub DeleteCategory(category As String)
        Try
            Con.Open()
            Dim query = "DELETE FROM CategoryTbl WHERE CatName = '" & category & "'"
            Dim cmd As SqlCommand = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' Handle the exception, display or log the error message.
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

    Private Sub DeleteCategoryWithItems(category As String)
        Try
            Con.Open()
            Dim query = "DELETE FROM item WHERE Item_Cat = '" & category & "'"
            Dim cmd As SqlCommand = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            query = "DELETE FROM CategoryTbl WHERE CatName = '" & category & "'"
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' Handle the exception, display or log the error message.
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub

End Class
