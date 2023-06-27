Imports System.Data.SqlClient
Imports System.Xml.Schema
Imports System.Graphic

Public Class Seller
    Dim Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True")
    Private Sub btn_logout_seller_Click(sender As Object, e As EventArgs) Handles btn_logout_seller.Click
        Dim obj = New Seller_login
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
        Try
            Con.Open()
            Dim query = "SELECT item.item_id, item.name, item.Item_Cat, item.Item_Qty, item.Item_Price FROM item INNER JOIN CategoryTbl ON item.Item_Cat = CategoryTbl.CatName"
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
            'ItemDGV.Columns("Cost_Price").HeaderText = "Cost Price"
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
            BilDGV.Rows.Item(rnum).Cells("Column3").Value = txt_quantity_sell.Text
            BilDGV.Rows.Item(rnum).Cells("Column4").Value = price
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
        price = row.Cells(4).Value.ToString
        If ProdName = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(3).Value.ToString)
            price = Convert.ToInt32(row.Cells(4).Value.ToString)
        End If
    End Sub
    Public Property SellerName As String
    Private Sub AddBill()
        Using Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True")
            Try
                Con.Open()
                Dim query As String = "INSERT INTO Tblorder (orddate, ordamt, SellerName) VALUES (@OrderDate, @OrderAmount, @SellerName)"
                Dim cmd As SqlCommand = New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@SellerName", Seller_login.SellerName) ' Access the SellerName property directly from the Seller_login class
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Today.Date)
                cmd.Parameters.AddWithValue("@OrderAmount", GrTotal)
                cmd.ExecuteNonQuery()
                MsgBox("Bill Added")
                BilDGV.Rows.Clear()
            Catch ex As Exception
                MessageBox.Show("An error occurred while adding the bill: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        AddBill()
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titleFont As New Font("Arial", 22, FontStyle.Bold)
        Dim headingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim contentFont As New Font("Arial", 12)
        ' Title
        e.Graphics.DrawString("Cafe Shop", titleFont, Brushes.Chocolate, 335, 35)

        ' Bill heading
        e.Graphics.DrawString("******* Your Bill *************", headingFont, Brushes.BlueViolet, 350, 60)

        ' Table header
        Dim tableHeaderFont As New Font("Arial", 12, FontStyle.Bold)
        Dim columnHeaderBrush As New SolidBrush(Color.Black)
        Dim columnBackColor As New SolidBrush(Color.LightGray)
        Dim columnBorderColor As New Pen(Color.Black)
        Dim columnWidths() As Integer = {50, 200, 100, 100, 150} ' Adjust the widths as needed

        Dim column1Rect As New Rectangle(0, 90, columnWidths(0), 30)
        Dim column2Rect As New Rectangle(column1Rect.Right, column1Rect.Top, columnWidths(1), column1Rect.Height)
        Dim column3Rect As New Rectangle(column2Rect.Right, column1Rect.Top, columnWidths(2), column1Rect.Height)
        Dim column4Rect As New Rectangle(column3Rect.Right, column1Rect.Top, columnWidths(3), column1Rect.Height)
        Dim column5Rect As New Rectangle(column4Rect.Right, column1Rect.Top, columnWidths(4), column1Rect.Height)

        e.Graphics.FillRectangle(columnBackColor, column1Rect)
        e.Graphics.FillRectangle(columnBackColor, column2Rect)
        e.Graphics.FillRectangle(columnBackColor, column3Rect)
        e.Graphics.FillRectangle(columnBackColor, column4Rect)
        e.Graphics.FillRectangle(columnBackColor, column5Rect)

        e.Graphics.DrawRectangle(columnBorderColor, column1Rect)
        e.Graphics.DrawRectangle(columnBorderColor, column2Rect)
        e.Graphics.DrawRectangle(columnBorderColor, column3Rect)
        e.Graphics.DrawRectangle(columnBorderColor, column4Rect)
        e.Graphics.DrawRectangle(columnBorderColor, column5Rect)

        e.Graphics.DrawString("No.", tableHeaderFont, columnHeaderBrush, column1Rect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        e.Graphics.DrawString("Product", tableHeaderFont, columnHeaderBrush, column2Rect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        e.Graphics.DrawString("Price", tableHeaderFont, columnHeaderBrush, column3Rect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        e.Graphics.DrawString("Quantity", tableHeaderFont, columnHeaderBrush, column4Rect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
        e.Graphics.DrawString("Total", tableHeaderFont, columnHeaderBrush, column5Rect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})

        ' Table content
        Dim rowHeight As Integer = 25
        Dim tableContentFont As New Font("Arial", 12)
        Dim contentBrush As New SolidBrush(Color.Black)
        Dim startY As Integer = column1Rect.Bottom

        For rowIndex As Integer = 0 To BilDGV.Rows.Count - 1
            Dim rowRect As New Rectangle(0, startY + rowIndex * rowHeight, column1Rect.Width, rowHeight)
            Dim prodRect As New Rectangle(column1Rect.Right, rowRect.Top, column2Rect.Width, rowRect.Height)
            Dim priceRect As New Rectangle(column2Rect.Right, rowRect.Top, column3Rect.Width, rowRect.Height)
            Dim qtyRect As New Rectangle(column3Rect.Right, rowRect.Top, column4Rect.Width, rowRect.Height)
            Dim totalRect As New Rectangle(column4Rect.Right, rowRect.Top, column5Rect.Width, rowRect.Height)

            e.Graphics.DrawRectangle(columnBorderColor, rowRect)
            e.Graphics.DrawRectangle(columnBorderColor, prodRect)
            e.Graphics.DrawRectangle(columnBorderColor, priceRect)
            e.Graphics.DrawRectangle(columnBorderColor, qtyRect)
            e.Graphics.DrawRectangle(columnBorderColor, totalRect)

            e.Graphics.DrawString((rowIndex + 1).ToString(), tableContentFont, contentBrush, rowRect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            'e.Graphics.DrawString(BilDGV.Rows(rowIndex).Cells("Column2").Value.ToString(), tableContentFont, contentBrush, prodRect, New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
            Dim productName As String = If(BilDGV.Rows(rowIndex).Cells("Column2").Value IsNot Nothing, BilDGV.Rows(rowIndex).Cells("Column2").Value.ToString(), "")
            Dim quantity As String = If(BilDGV.Rows(rowIndex).Cells("Column3").Value IsNot Nothing, BilDGV.Rows(rowIndex).Cells("Column3").Value.ToString(), "")
            Dim price As String = If(BilDGV.Rows(rowIndex).Cells("Column4").Value IsNot Nothing, BilDGV.Rows(rowIndex).Cells("Column4").Value.ToString(), "")
            Dim total As String = If(BilDGV.Rows(rowIndex).Cells("Column5").Value IsNot Nothing, BilDGV.Rows(rowIndex).Cells("Column5").Value.ToString(), "")

            e.Graphics.DrawString(productName, tableContentFont, contentBrush, prodRect, New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
            e.Graphics.DrawString(quantity, tableContentFont, contentBrush, qtyRect, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            e.Graphics.DrawString(price, tableContentFont, contentBrush, priceRect, New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
            e.Graphics.DrawString(total, tableContentFont, contentBrush, totalRect, New StringFormat With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center})
        Next rowIndex
        Dim sellerName As String = CType(Application.OpenForms("Seller_login"), Seller_login).SellerName
        e.Graphics.DrawString("Seller: " & sellerName, contentFont, Brushes.BlueViolet, 700, 40)
        ' Total Amount
        Dim totalAmountY As Integer = startY + BilDGV.Rows.Count * rowHeight + 20
        e.Graphics.DrawString("Total Amount: " & GrTotal.ToString(), contentFont, Brushes.Crimson, 325, totalAmountY)

        ' Footer
        Dim footerY As Integer = totalAmountY + 30
        e.Graphics.DrawString("******************** Thanks For Visiting our Cafe *************************", contentFont, Brushes.Crimson, 130, footerY)
        e.Graphics.DrawString("      ************************ Visit Again ***************************", contentFont, Brushes.Crimson, 130, footerY + 25)
    End Sub


    Private Sub btn_view_orders_Click(sender As Object, e As EventArgs) Handles btn_view_orders.Click
        Dim obj = New viewOrder
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnGotoAdmin_Click(sender As Object, e As EventArgs) Handles btnGotoAdmin.Click
        Dim obj = New Admin_login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim obj = New Welcome
        obj.Show()
        Me.Hide()
    End Sub
End Class