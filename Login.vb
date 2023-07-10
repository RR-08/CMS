Public Class Login


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        userNameTB.Clear()
        pwdTb.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim Det = New Cylinder
        Det.Show()
    End Sub
End Class