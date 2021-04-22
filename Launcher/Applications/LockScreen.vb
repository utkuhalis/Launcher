Public Class LockScreen
    Dim LocX As Integer
    Dim LocY As Integer

    Private Sub LockScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OLS.Start()
        LocX = Me.Size.Width
        LocX = LocX - 380
        LocX = LocX / 2
        LocY = Me.Size.Height
        LocY = LocY - 100
        LocY = LocY / 2
        LocY = LocY - 50
        TimeText.Location = New Point(LocX, LocY)
        LocX = Me.Size.Width
        LocX = LocX - 380
        LocX = LocX / 2
        LocY = Me.Size.Height
        LocY = LocY - 35
        LocY = LocY / 2
        DateText.Location = New Point(LocX, LocY)
        Panel1.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/BOB.png")
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        alarm_notf.Image = Image.FromFile(Application.StartupPath & "/System/Media/icon/time.png")
        alarm_notf.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub OLS_Tick(sender As Object, e As EventArgs) Handles OLS.Tick
        If Me.Opacity = 1 Then
            OLS.Stop()
        Else
            Me.Opacity += 0.01
        End If
    End Sub

    Private Sub TADT_Tick(sender As Object, e As EventArgs) Handles TADT.Tick
        TimeText.Text = Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second
        DateText.Text = Date.Now.Date
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        OLS.Stop()
        CLS.Start()
    End Sub

    Private Sub CLS_Tick(sender As Object, e As EventArgs) Handles CLS.Tick
        If Me.Opacity = 0 Then
            CLS.Stop()
            Me.Close()
            For Each deneme As Form In Application.OpenForms
                If deneme.Name = "Note" Then
                    deneme.TopMost = True
                End If
            Next
        Else
            Me.Opacity -= 0.03
        End If
    End Sub

    Private Sub TimeText_Click(sender As Object, e As EventArgs) Handles TimeText.Click
        OLS.Stop()
        CLS.Start()
    End Sub

    Private Sub DateText_Click(sender As Object, e As EventArgs) Handles DateText.Click
        OLS.Stop()
        CLS.Start()
    End Sub

End Class