Public Class Loading
    Dim tcount As Integer = 0

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        PictureBox1.Image = Image.FromFile(Application.StartupPath & "/System/Media/loading.gif")
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub OAni_Tick(sender As Object, e As EventArgs) Handles OAni.Tick
        If Me.Opacity = 1 Then
            OAni.Stop()
        Else
            Me.Opacity += 0.01
        End If
    End Sub

    Private Sub CAni_Tick(sender As Object, e As EventArgs) Handles CAni.Tick
        If Me.Opacity = 0 Then
            CAni.Stop()
            Me.Close()
            Kernel.WorkID.Text = 4
            Kernel.Work.Start()
        Else
            Me.Opacity -= 0.01
        End If
    End Sub

    Private Sub LoadingDesktop_Tick(sender As Object, e As EventArgs) Handles LoadingDesktop.Tick
        tcount += 1
        If tcount = 5 Then
            LoadingDesktop.Stop()
            CAni.Start()
        End If
    End Sub
End Class