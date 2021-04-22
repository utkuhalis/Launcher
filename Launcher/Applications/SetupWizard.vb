Public Class SetupWizard
    Dim lang As String
    Dim type As String
    Dim uname As String
    Dim tpass As String
    Dim upass As String
    Dim saveuser As New RichTextBox
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Exit Launcher Setup ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        Else

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Finish Setup(Exit)" Then
            Me.Close()
            Setup.Close()
            Kernel.WorkID.Text = 2
            Kernel.Work.Start()
        Else
            If ComboBox1.Text = "" Or ComboBox2.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Empty Area, Please Check Your Info", MsgBoxStyle.Information, "Launcher Setup")
            Else
                Button1.Enabled = False
                Button2.Enabled = False
                lang = ComboBox1.Text
                type = ComboBox2.Text
                uname = TextBox1.Text
                tpass = CheckBox3.CheckState
                upass = TextBox2.Text
                SetupLauncher.Start()
            End If
        End If
    End Sub

    Private Sub SetupLauncher_Tick(sender As Object, e As EventArgs) Handles SetupLauncher.Tick
        saveuser.Text = "[USER]" & vbNewLine & "language=" & lang & vbNewLine & "type=" & type & vbNewLine & "uname=" & uname & vbNewLine & "tpass=" & tpass & vbNewLine & "upass=" & upass & vbNewLine & vbNewLine & "wallpaper=" & "background1" & vbNewLine & "wallpaper_lock=" & "background2" & vbNewLine & "wallpaper_login=" & "background3"
        saveuser.SaveFile(Application.StartupPath & "/System/user.sys", RichTextBoxStreamType.PlainText)
        ProgressBar1.Value = 100
        Label7.Text = "Launcher Install (" & ProgressBar1.Value & "%)"
        Button1.Text = "Finish Setup(Exit)"
        Button1.Enabled = True
    End Sub
End Class