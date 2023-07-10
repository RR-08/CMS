Imports System.Data.SqlClient

Public Class Cylinder
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\CylinderDB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Cylinder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Con.Open()

        Dim Query As String
        Query = "insert into cylinderTable values('" & poNoTb.Text & "','" & VendorNameTb.Text & "','" & MaterialDesTb.Text & "','" & ReceiptDate.Value & "','" & cisfNoTb.Text & "','" & IssueDate.Value & "','" & DeptTb.Text & "','" & emptyDate.Value & "','" & returnSuppDate.Value & "','" & CylNoTb.Text & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Added")
        Con.Close()

    End Sub
End Class