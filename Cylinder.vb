Imports System.Data.SqlClient
Imports System.Linq.Expressions

Public Class Cylinder
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\CylinderDB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Cylinder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()

    End Sub
    Private Sub Populate()
        Con.Open()
        Dim sql = "Select * from cylinderTable"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        Con.Close()
        CylinderDb.DataSource = ds.Tables(0)
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
        Populate()

    End Sub

    Dim key = 0
    Private Sub clear()
        poNoTb.Text = ""
        VendorNameTb.Text = ""
        MaterialDesTb.Text = ""

        cisfNoTb.Text = ""

        DeptTb.Text = ""

        CylNoTb.Text = ""
        key = 0


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If key = 0 Then
            MsgBox("Please select a row")
        End If
        Try
            Con.Open()
            Dim query As String
            query = "Delete from CylinderTable where sno = " & key & ""
            Dim cmde As SqlCommand
            cmde = New SqlCommand(query, Con)
            cmde.ExecuteNonQuery()
            MsgBox("Deleted")
            Con.Close()
            Populate()
            clear()


        Catch ex As Exception
            MsgBox("ex.message")
        End Try

    End Sub


    Private Sub CylinderDB_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CylinderDB.CellMouseClick
        Dim row As DataGridViewRow = CylinderDB.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        poNoTb.Text = row.Cells(1).Value.ToString()
        VendorNameTb.Text = row.Cells(2).Value.ToString()
        MaterialDesTb.Text = row.Cells(3).Value.ToString()
        ReceiptDate.Value = row.Cells(4).Value.ToString()
        cisfNoTb.Text = row.Cells(5).Value.ToString()
        IssueDate.Value = row.Cells(6).Value.ToString()
        DeptTb.Text = row.Cells(7).Value.ToString()
        emptyDate.Value = row.Cells(8).Value.ToString()
        returnSuppDate.Value = row.Cells(9).Value.ToString()
        CylNoTb.Text = row.Cells(10).Value.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If poNoTb.Text = " " Then
            MsgBox(" Missing information ")
        Else
            Con.Open()
            Dim query As String
            query = " Update cylinderTable set pono ='" & poNoTb.Text & "',vendorName ='" & VendorNameTb.Text & "',MaterialDes ='" & MaterialDesTb.Text & "',CISFno ='" & cisfNoTb.Text & "',cylinderno ='" & CylNoTb.Text & "',deptt ='" & DeptTb.Text & "',receiptdate ='" & ReceiptDate.Value & "',emptyreceiveddate ='" & emptyDate.Value & "',sendtosupplierdate ='" & returnSuppDate.Value & "' where sno='" & key & "'"
            Dim cmde As SqlCommand
            cmde = New SqlCommand(query, Con)
            cmde.ExecuteNonQuery()
            MsgBox("Updated ")
            Con.Close()
            Populate()
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim Det = New MainForm
        Det.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Application.Exit()

    End Sub


    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        Me.Hide()
        Dim Det = New Login
        Det.Show()

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        Me.Hide()
        Dim Det = New Prints
        Det.Show()
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Me.Hide()
        Dim Det = New MainForm
        Det.Show()
    End Sub
End Class