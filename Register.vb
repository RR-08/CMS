Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Register
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\CylinderDB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String


        If pwdTb.Text <> repwdTb.Text Then
            MsgBox("The password didn't match. Reenter Correctly")
            repwdTb.Text = " "
            Return
        End If
        Con.Open()
        query = "insert into LoginTable values('" & userNameTB.Text & "','" & pwdTb.Text & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("UserName exists")
        Con.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim home = New Login
        home.Show()
    End Sub
End Class