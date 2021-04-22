Imports System.IO
Public Class Wallpaper
    Dim Count As Integer = 0

    Private Sub Picture(ByVal Control As Control)
        AddHandler Control.Click, Sub(sender As Object, e As MouseEventArgs) Active(Control)
    End Sub

    Private Sub Active(ByVal Control As Control)
        Dim test As New Bitmap(Control.BackgroundImage, New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height))
        'test.Save(My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & Control.Name & ".jpg", Imaging.ImageFormat.Jpeg)
        Desktop.BackgroundImage = test
        user_info.LoadFile(Application.StartupPath & "/System/user.sys", RichTextBoxStreamType.PlainText)
        user_info.Text = user_info.Text.Replace(user_info.Lines(6).Split("=")(1), Control.Name)
        user_info.SaveFile(Application.StartupPath & "/System/user.sys", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub Wallpaper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        List.Visible = True
        List.Enabled = False
        For Each folder As String In Directory.GetFiles(Application.StartupPath & "/System/Media/Wallpaper/")
            ListBox1.Items.Add(Path.GetFileName(folder))
            ListBox1.SelectedIndex = 0
        Next
        List_Pic.Start()
    End Sub

    Private Sub List_Pic_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles List_Pic.Tick
        Dim Limit As Integer = ListBox1.Items.Count

        If Count = Limit Or Limit = 0 Then
            Count = 0
            List_Pic.Stop()
            List.Enabled = True
        Else
            ListBox1.SelectedIndex = Count
            Dim Pic As New PictureBox
            Dim test As New Bitmap(Image.FromFile(Application.StartupPath & "/System/Media/Wallpaper/" & ListBox1.Text), New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height))
            Pic.BackgroundImage = test
            Pic.Name = ListBox1.Text
            Pic.BackgroundImageLayout = ImageLayout.Stretch
            Pic.Size = New Size(170, 150)

            Picture(Pic)

            Count += 1
            List.Controls.Add(Pic)
        End If
    End Sub
End Class