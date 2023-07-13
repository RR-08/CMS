Public Class Login


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        userNameTB.Clear()
        pwdTb.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If userNameTB.Text = "admin" And pwdTb.Text = "admin" Then
            Me.Hide()
            Dim Det = New MainForm
            Det.Show()
        Else
            MsgBox("Incorrect Credentials")

        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Dim Det = New Register
        Det.Show()

    End Sub
End Class