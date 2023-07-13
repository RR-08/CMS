Imports System.Data.SqlClient

Public Class Prints
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\CylinderDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchCylinder()
        If poNoTb.Text = "" Then
            MsgBox("Enter PO Number")
        Else
            Con.Open()
            Dim query As String
            query = " select * from  cylinderTable where PoNo ='" & poNoTb.Text & "'"
            Dim cmde As SqlCommand
            cmde = New SqlCommand(query, Con)
            Dim dt As DataTable
            dt = New DataTable
            Dim sda As SqlDataAdapter
            sda = New SqlDataAdapter(cmde)
            sda.Fill(dt)

            For Each dr As DataRow In dt.Rows
                poNoTb.Text = dr(1).ToString()
                VendorNameTb.Text = dr(2).ToString()
                cisfnoTb.Text = dr(5).ToString()
                MaterialDesTb.Text = dr(3).ToString()
                CylNoTb.Text = dr(10).ToString()


            Next

            Con.Close()
        End If
    End Sub
    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    'Me.Hide()
    'Dim main = New MainForm
    '   main.Show()
    'End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FetchCylinder()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If poNoTb.Text = "" Then
            MsgBox("select an employee")
        End If
        slipTb.Text = "Cylinder Number : " + CylNoTb.Text + vbCrLf + "PO Number : " + poNoTb.Text + vbCrLf + "Vendor Name : " + VendorNameTb.Text + vbCrLf + "Material Description : " + MaterialDesTb.Text + vbCrLf
    End Sub



    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        e.Graphics.DrawString("Cylinder Management System ", New Font("Century Gothic", 25), Brushes.DarkGreen, 180, 40)
        e.Graphics.DrawString("**Cylinder Detail Slip***", New Font("Arial ", 20), Brushes.Crimson, 330, 100)
        e.Graphics.DrawString(slipTb.Text, New Font("Century Gothic", 20), Brushes.Black, 150, 190)

        e.Graphics.DrawString("========Thank You. Copy Right Indian Oil 2023====== ", New Font("Century Gothic", 15), Brushes.DarkGreen, 150, 500)



    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If poNoTb.Text = "" Then
            MsgBox("select an employee")
        End If
        slipTb.Text = "Cylinder Number : " + CylNoTb.Text + vbCrLf + "PO Number : " + poNoTb.Text + vbCrLf + "Vendor Name : " + VendorNameTb.Text + vbCrLf + "Material Description : " + MaterialDesTb.Text + vbCrLf
        PrintPreviewDialog1.Document = PrintDocument1

        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        Me.Hide()
        Dim main = New Cylinder
        main.Show()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        Me.Hide()
        Dim main = New Login
        main.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Dim main = New MainForm
        main.Show()
    End Sub
End Class