Imports System.Data.SqlClient

Public Class viewOrder
    Dim Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=Cafe;Integrated Security=True")
    Private Sub DisplayBill()
        Con.Open()
        Dim query = "Select * from Tblorder"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        OrderDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub viewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBill()

    End Sub

    Private Sub btn_back_order_Click(sender As Object, e As EventArgs) Handles btn_back_order.Click
        Dim obj = New Seller
        obj.Show()
        Me.Hide()
    End Sub
End Class