Public Class Setup
    Private Sub Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/background1.jpg")
        Me.BackgroundImageLayout = ImageLayout.Stretch
        SetupWizard.Show()
    End Sub
End Class