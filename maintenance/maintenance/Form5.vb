
Imports System.Data.SqlClient

Public Class Form5

    Dim connection As New SqlConnection("Server= SONY-PC\SQLEXPRESS1 ; Database = MAINTENANCE; Integrated Security = true")



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"


        Dim sql As String = "SELECT * FROM [MAINTENANCE].[dbo].maintenance1 where  date = '" & DateTimePicker1.Text & "' "
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "maintenance1")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "maintenance1"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "SELECT * FROM [MAINTENANCE].[dbo].maintenance1"
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "maintenance1")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "maintenance1"
    End Sub
End Class