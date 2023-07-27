Imports System.Data.SqlClient

Public Class MaterialUsed
    Dim Con As SqlConnection = New SqlConnection("Data Source=DELL\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True")

    Private Sub DisplayBill(ByVal selectedDate As Date)
        Con.Open()
        Dim query As String = "SELECT RawId, orddate, ordamt FROM TblRawUsed WHERE orddate = @SelectedDate"
        Dim cmd As SqlCommand = New SqlCommand(query, Con)
        cmd.Parameters.AddWithValue("@SelectedDate", selectedDate)
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet = New DataSet()
        adapter.Fill(ds)
        OrderDGV.DataSource = ds.Tables(0)

        ' Calculate and display the total sales amount
        Dim totalAmount As Decimal = 0
        For Each row As DataRow In ds.Tables(0).Rows
            totalAmount += Convert.ToDecimal(row("ordamt"))
        Next

        TotalSum.Text = totalAmount.ToString("N2") ' Format the total amount with two decimal places
        Con.Close()
    End Sub


    Private Sub viewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBill(Now.Date)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DisplayBill(DateTimePicker1.Value.Date)
    End Sub

    Private Sub btn_back_order_Click(sender As Object, e As EventArgs) Handles btn_back_order.Click
        Dim obj = New RawMaterial()
        obj.Show()
        Me.Hide()
    End Sub
End Class