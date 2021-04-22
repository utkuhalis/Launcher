Public Class Kernel
    Private Sub Work_Tick(sender As Object, e As EventArgs) Handles Work.Tick
        Work.Stop()
        If WorkID.Text = 0 Then
            Boot.ShowDialog()
        ElseIf WorkID.Text = 1 Then
            Setup.ShowDialog()
        ElseIf WorkID.Text = 2 Then
            Loading.ShowDialog()
        ElseIf WorkID.Text = 3 Then
            'Login.ShowDialog()
        ElseIf WorkID.Text = 4 Then
            Desktop.ShowDialog()
        End If
    End Sub

    Private Sub Kernel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class