Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() ' Stop the timer to prevent it from triggering again

        Me.Hide() ' Hide the current form

        Dim log = New Login
        log.Show()
        Timer1.Enabled = False


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class
