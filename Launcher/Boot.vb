Public Class Boot
    Dim tc As Integer = 0
    Dim read_text As New RichTextBox
    Dim lcount As Integer = 0
    Dim lfinish As Integer = 0
    Dim wstep As Integer = 0
    Dim fstatus As Boolean

    Private Sub BootStart_Tick(sender As Object, e As EventArgs) Handles BootStart.Tick
        tc += 1
        If tc = 2 Then
            text1.Visible = True
        ElseIf tc = 3 Then
            text2.Visible = True
        ElseIf tc = 4 Then
            BootStart.Stop()
            text3.Visible = True
            text4.Visible = True
            status1.Visible = True
            status2.Visible = True
            read_text.LoadFile(Application.StartupPath & "\System\systemfd.sys", RichTextBoxStreamType.PlainText)
            SystemControl.Start()
        ElseIf tc = 6 Then
            text5.Visible = True
        ElseIf tc = 7 Then
            text6.Visible = True
        ElseIf tc = 9 Then
            Me.Close()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\System\user.sys") = True Then
                Kernel.WorkID.Text = 2
                Kernel.Work.Start()
            Else
                Kernel.WorkID.Text = 1
                Kernel.Work.Start()
            End If
        End If
    End Sub

    Private Sub SystemControl_Tick(sender As Object, e As EventArgs) Handles SystemControl.Tick
        lfinish = read_text.Lines.Count
        If lcount = lfinish Or lcount > lfinish Then
            SystemControl.Stop()
            If SystemFile.Text.Contains("False") Then
                status1.ForeColor = Color.Red
                status1.Text = "Error"
            Else
                status1.ForeColor = Color.Lime
                status1.Text = "OK"
                If SystemDir.Text.Contains("False") Then
                    status2.ForeColor = Color.Red
                    status2.Text = "Error"
                Else
                    status2.ForeColor = Color.Lime
                    status2.Text = "OK"
                    tc += 1
                    BootStart.Start()
                End If
            End If
        Else
            If read_text.Lines(lcount) = "[DIR]" Then
                lcount += 1
                wstep = 1
            End If
            If wstep = 1 Then
                fstatus = My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "/System/" & read_text.Lines(lcount))
                SystemDir.Text &= read_text.Lines(lcount) & ": " & fstatus & vbNewLine
                lcount += 1
                If read_text.Lines(lcount) = "[FILE]" Then
                    lcount += 1
                    wstep = 2
                End If
            End If
            If wstep = 2 Then
                fstatus = My.Computer.FileSystem.FileExists(Application.StartupPath & "/System/" & read_text.Lines(lcount))
                SystemFile.Text &= read_text.Lines(lcount) & ": " & fstatus & vbNewLine
                lcount += 1
            End If
        End If
    End Sub

    Private Sub Boot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class