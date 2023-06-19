Imports System.Data.SqlClient
Imports System.Xml.Schema

Public Class Seller
    Dim Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True")
    Private Sub btn_logout_seller_Click(sender As Object, e As EventArgs) Handles btn_logout_seller.Click
        Dim obj = New Welcome
        obj.Show()
        Me.Hide()
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
    Private Sub DisplayItem()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If

        Dim query = "SELECT * FROM item"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub FilterByCategory()
        Con.Open()
        Dim query = "Select * from item where Item_Cat= '" & combo.SelectedValue.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub CatCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combo.SelectionChangeCommitted
        FilterByCategory()
    End Sub

    Private Sub btnRefresh_sell_Click(sender As Object, e As EventArgs) Handles btnRefresh_sell.Click
        DisplayItem()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        DisplayItem()
        FillCategory()

    End Sub
    Dim ProdName
    Dim i = 0, GrTotal = 0, price, qty
    Private Sub UpdateItem()
        Try
            Dim newQty = stock - Convert.ToInt32(txt_quantity_sell.Text)
            Con.Open()
            Dim query = "UPDATE item set Item_Qty = " & newQty & " WHERE item_id = " & key & ""
            Dim cmd As SqlCommand = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Edited")
            Con.Close()
            DisplayItem()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnAddBill_Click(sender As Object, e As EventArgs) Handles btnAddBill.Click
        If key = 0 Or txt_quantity_sell.Text = "" Then
            MsgBox("Select a Item")
        ElseIf Convert.ToInt32(txt_quantity_sell.Text) > stock Then
            MsgBox("No Enough Stock")
        Else
            Dim rnum As Integer = BilDGV.Rows.Add()
            Dim total = Convert.ToInt32(txt_quantity_sell.Text) * price
            i = i + 1
            BilDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BilDGV.Rows.Item(rnum).Cells("Column2").Value = ProdName
            BilDGV.Rows.Item(rnum).Cells("Column3").Value = price
            BilDGV.Rows.Item(rnum).Cells("Column4").Value = txt_quantity_sell.Text
            BilDGV.Rows.Item(rnum).Cells("Column5").Value = total
            GrTotal = GrTotal + total
            TotalBill.Text = "Rs " + Convert.ToString(GrTotal)
            UpdateItem()
            txt_quantity_sell.Text = ""
            key = 0
        End If
    End Sub

    Dim key = 0, stock
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ProdName = row.Cells(1).Value.ToString
        price = row.Cells(3).Value.ToString
        If ProdName = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            price = Convert.ToInt32(row.Cells(3).Value.ToString)
        End If
    End Sub
    Private Sub AddBill()
        Con.Open()
        Dim query = "Insert into Tblorder values('" & DateTime.Today.Date & "', " & GrTotal & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Bill Added")
        Con.Close()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        AddBill()
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Cafe Shop", New Font("Arial", 22), Brushes.Chocolate, 335, 35)
        e.Graphics.DrawString("******* Your Bill *************", New Font("Arial", 14), Brushes.BlueViolet, 350, 60)
        'e.Graphics.DrawString("Seller:" + Userlabel.Text, New Font("Arial", 12), Brushes.BlueViolet, 700, 40)
        Dim bm As New Bitmap(Me.BilDGV.Width, Me.BilDGV.Height)
        BilDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BilDGV.Width, Me.BilDGV.Height))
        e.Graphics.DrawImage(bm, 0, 90)
        e.Graphics.DrawString("Total Amount " + GrTotal.ToString(), New Font("Arial", 15), Brushes.Crimson, 325, 500)
        e.Graphics.DrawString("************ Thanks For Visiting our Cafe *************************", New Font("Arial", 15), Brushes.Crimson, 130, 600)
        e.Graphics.DrawString("************ Visit Again *************************", New Font("Arial", 15), Brushes.Crimson, 130, 600)

    End Sub

    Private Sub btn_view_orders_Click(sender As Object, e As EventArgs) Handles btn_view_orders.Click
        Dim obj = New viewOrder
        obj.Show()
        Me.Hide()
    End Sub
End Class