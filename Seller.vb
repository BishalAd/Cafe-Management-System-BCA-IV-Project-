Imports System.Data.SqlClient
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
        CatCb.DataSource = Tbl
        CatCb.DisplayMember = "CatName"
        CatCb.ValueMember = "CatName"
        Con.Close()
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
    Private Sub FilterByCategory()
        Con.Open()
        Dim query = "Select * from item where Item_Cat= '" & CatCb.SelectedValue.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub ItemDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        DisplayItem()
        FillCategory()
    End Sub

    Private Sub CatCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CatCb.SelectionChangeCommitted
        FilterByCategory()
    End Sub
End Class