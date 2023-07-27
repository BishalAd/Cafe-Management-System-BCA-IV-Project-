Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class RawMaterial
    Dim Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True")
    Private Sub DisplayItem()
        Try
            Con.Open()
            Dim query = "SELECT * FROM RawMaterial"
            Dim cmd = New SqlCommand(query, Con)
            Dim adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            ItemDGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            ' Handle the exception, display or log the error message.
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Private Sub Reset()
        txtName.Text = ""
        txtPrice.Text = ""
        txtQuantity.Text = ""
        txtUnit.Text = ""
        key = 0
    End Sub
    Dim key = 0
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Or txtUnit.Text = "" Then
            MsgBox("Missing Data")
        Else
            Try
                Con.Open()
                Dim query = "insert into RawMaterial (Material_Name, Quantity, Unit, Price) values('" & txtName.Text & "', '" & txtQuantity.Text & "', '" & txtUnit.Text & "', '" & txtPrice.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Raw Material Added Successfully")
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

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If key = 0 Then
            MsgBox("Select The Material To Delete.")
        Else
            Con.Open()
            Dim query = "Delete from RawMaterial where RawMaterial_ID = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Raw Material Deleted")
            Con.Close()
            Reset()
            DisplayItem()
        End If

    End Sub
    Dim stock
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        txtName.Text = row.Cells(1).Value.ToString
        txtQuantity.Text = row.Cells(2).Value.ToString
        txtUnit.Text = row.Cells(3).Value.ToString
        txtPrice.Text = row.Cells(4).Value.ToString
        If txtName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

        ' Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ProdName = row.Cells(1).Value.ToString
        price = row.Cells(4).Value.ToString
        If ProdName = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(2).Value.ToString)
            price = Convert.ToInt32(row.Cells(4).Value.ToString)
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtName.Text = "" Or txtQuantity.Text = "" Or txtUnit.Text = "" Or txtPrice.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "UPDATE RawMaterial SET Material_Name = '" & txtName.Text & "', Quantity = '" & txtQuantity.Text & "', Unit = '" & txtUnit.Text & "', Price = '" & txtPrice.Text & "' WHERE RawMaterial_ID = " & key & ""
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Raw Material Edited")
                Con.Close()
                Reset()
                DisplayItem()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        Dim obj = New Welcome
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnGotoSeller_Click(sender As Object, e As EventArgs) Handles btnGotoSeller.Click
        Dim obj = New Seller_login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btn_logout_admin_Click(sender As Object, e As EventArgs) Handles btn_logout_admin.Click
        Dim obj = New Add_New_Cagegory
        obj.Show()
        Me.Hide()
    End Sub

    Dim ProdName
    Dim i = 0, GrTotal = 0, price

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If key = 0 Or txt_quantity_sell.Text = "" Then
            MsgBox("Select a Item")
        ElseIf Convert.ToInt32(txt_quantity_sell.Text) > stock Then
            MsgBox("No Enough Stock")
        Else
            Dim rnum As Integer = BilDGV.Rows.Add()
            Dim total = Convert.ToInt32(txt_quantity_sell.Text) * price
            'Dim profit = Convert.ToInt32(txt_quantity_sell.Text) * cp
            i = i + 1
            BilDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BilDGV.Rows.Item(rnum).Cells("Column2").Value = ProdName
            BilDGV.Rows.Item(rnum).Cells("Column3").Value = txt_quantity_sell.Text
            BilDGV.Rows.Item(rnum).Cells("Column4").Value = price
            BilDGV.Rows.Item(rnum).Cells("Column5").Value = total
            GrTotal = GrTotal + total
            UpdateItem()
            txt_quantity_sell.Text = ""
            key = 0
            Tprice.Text = "Rs " + Convert.ToString(GrTotal)
        End If
    End Sub
    Private Sub UpdateItem()
        Try
            Dim newQty = stock - Convert.ToInt32(txt_quantity_sell.Text)
            Con.Open()
            Dim query = "UPDATE RawMaterial set Quantity = " & newQty & " WHERE RawMaterial_ID = " & key & ""
            Dim cmd As SqlCommand = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Edited")
            Con.Close()
            DisplayItem()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub AddRecord()
        Try
            Con.Open()
            Dim query As String = "INSERT INTO TblRawUsed (Date, Amount) VALUES (@Date, @Amount)"
            Dim cmd As SqlCommand = New SqlCommand(query, Con)

            cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date)
            cmd.Parameters.AddWithValue("@Amount", GrTotal)
            cmd.ExecuteNonQuery()
            MsgBox("Added")
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the bill: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddRecord()
        Dim obj = New RawMaterial
        Me.Hide()
        obj.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim obj = New MaterialUsed
        obj.Show()
        Me.Hide()
    End Sub
End Class