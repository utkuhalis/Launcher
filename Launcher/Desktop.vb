Imports System.IO
Public Class Desktop
    Dim get_info As New RichTextBox
    Dim note_info As New RichTextBox
    Dim i As Integer = 0
    Dim dirloc As New RichTextBox
    Dim StandartDirLocation As String = Application.StartupPath & "\System\Storage\"
    Dim proc As Process
    Dim noconsole As Integer = 0

    Private WithEvents CloseItem As New ToolStripMenuItem("Close")
    Private WithEvents RestoreItem As New ToolStripMenuItem("Restore")

    Private Declare Function ShowWindow Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal nCmdShow As SHOW_WINDOW) As Boolean

    Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Private Const WM_SYSCOMMAND As Integer = 274
    Private Const SC_MAXIMIZE As Integer = 61488
    Const HWND_NOTOPMOST = -2
    Const HWND_TOPMOST = -1
    Const SWP_NOMOVE = &H2
    Const SWP_NOSIZE = &H1

    <Flags()>
    Private Enum SHOW_WINDOW As Integer
        SW_HIDE = 0
        SW_SHOWNORMAL = 1
        SW_NORMAL = 1
        SW_SHOWMINIMIZED = 2
        SW_SHOWMAXIMIZED = 3
        SW_MAXIMIZE = 3
        SW_SHOWNOACTIVATE = 4
        SW_SHOW = 5
        SW_MINIMIZE = 6
        SW_SHOWMINNOACTIVE = 7
        SW_SHOWNA = 8
        SW_RESTORE = 9
        SW_SHOWDEFAULT = 10
        SW_FORCEMINIMIZE = 11
        SW_MAX = 11
    End Enum

    Private Sub Restore(ByVal processname As String)
        For Each p As Process In Process.GetProcessesByName(processname)
            ShowWindow(p.MainWindowHandle, SHOW_WINDOW.SW_RESTORE)
        Next p
    End Sub

    Public Class DragInfo
        Public Property Farenin_ilk_Konumu As Point
        Public Property Baslama_Yeri As Point

        Public Sub New(ByVal MouseCoords As Point, ByVal Location As Point)
            Farenin_ilk_Konumu = MouseCoords
            Baslama_Yeri = Location
        End Sub

        Public Function NewLocation(ByVal MouseCoords As Point) As Point
            Dim yer As New Point(Baslama_Yeri.X + (MouseCoords.X - Farenin_ilk_Konumu.X), Baslama_Yeri.Y + (MouseCoords.Y - Farenin_ilk_Konumu.Y))
            Return yer
        End Function
    End Class

    Private Sub Moving(ByVal Control As Control)
        AddHandler Control.MouseDown, Sub(sender As Object, e As MouseEventArgs) StartDrag(Control)
        AddHandler Control.MouseMove, Sub(sender As Object, e As MouseEventArgs) Drag(Control)
        AddHandler Control.MouseUp, Sub(sender As Object, e As MouseEventArgs) StopDrag(Control)
        Control.BackColor = Color.Transparent
    End Sub

    Private Sub StartDrag(ByVal Control As Control)
        Control.Tag = New DragInfo(Form.MousePosition, Control.Location)
    End Sub

    Private Sub Drag(ByVal Control As Control)
        If Control.Tag IsNot Nothing AndAlso TypeOf Control.Tag Is DragInfo Then
            Dim Bilgi As DragInfo = CType(Control.Tag, DragInfo)
            Dim Yeni_Yer As Point = Bilgi.NewLocation(Form.MousePosition)
            If Me.ClientRectangle.Contains(New Rectangle(Yeni_Yer, Control.Size)) Then Control.Location = Yeni_Yer
        End If
    End Sub

    Private Sub StopDrag(ByVal Control As Control)
        Control.Tag = Nothing
        Control.BackColor = Color.Transparent
        dirloc.Text = Control.Location.X & "," & Control.Location.Y
        dirloc.SaveFile(Application.StartupPath & "/System/Storage/Root/" & Control.AccessibleName & ".txt", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub ActiveRMenu(ByVal Control As Control)
        AddHandler Control.Click, Sub(sender As Object, e As MouseEventArgs) If e.Button = MouseButtons.Right Then OpenRMenu(Control)
    End Sub

    Private Sub OpenRMenu(ByVal Control As Control)
        AppRMenu.Location = New Point(MousePosition.X, MousePosition.Y)
        AppRMenu.Visible = True
        TARM.Visible = False
        RightMenu.Visible = False
        NewMenu.Visible = False
        SRMI.Text = Control.AccessibleName
    End Sub

    Private Sub Desktop_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        'Add Desktop Items
        For Each folder As String In Directory.GetDirectories(Application.StartupPath & "\System\Storage\[Disk1]\Desktop\")
            Dim dir As New Panel
            Dim name As String
            dir.Size = New Size(64, 64)
            If Path.GetFileName(folder) = "Documents" Then
                dir.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/DirDocument.png")
            ElseIf Path.GetFileName(folder) = "Computer" Then
                dir.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/Computer.png")
            Else
                dir.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/Dir.png")
            End If
            dir.BackgroundImageLayout = ImageLayout.Stretch
            name = Path.GetFileName(folder)
            dir.AccessibleName = name
            dirloc.LoadFile(Application.StartupPath & "/System/Storage/Root/" & name & ".txt", RichTextBoxStreamType.PlainText)
            dir.Location = New Point(dirloc.Text.Split(", ")(0), dirloc.Text.Split(", ")(1))
            DFN(dir)
            Moving(dir)
            ActiveRMenu(dir)
            Me.Controls.Add(dir)
        Next

        'List Notes
        'ListBox2.Items.AddRange(Directory.GetFiles(Application.StartupPath & " / System / Storage / [Disk1] / Notes / ", " * .note", SearchOption.TopDirectoryOnly))
        'ListBox2.SelectedIndex = 0
        'NoteList.Start()

        AppList(False, "")

        'Get User Info
        get_info.LoadFile(Application.StartupPath & "/System/user.sys", RichTextBoxStreamType.PlainText)
        Console.Text = "$" & get_info.Lines(3).Split("=")(1) & ":"

        'Desktop Settings
        StartMenu.Image = Image.FromFile(Application.StartupPath & "/System/Media/StartMenu.gif")
        StartMenu.SizeMode = PictureBoxSizeMode.Zoom
        Dim test As New Bitmap(Image.FromFile(Application.StartupPath & "/System/Media/Wallpaper/" & get_info.Lines(6).Split("=")(1)), New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height))
        Me.BackgroundImage = test
        Me.BackgroundImageLayout = ImageLayout.Stretch
        StartMOp.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/BOB.png")
        StartMOp.BackgroundImageLayout = ImageLayout.Stretch

        'Exstra Settings
        ControlMenu.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/BOB.png")
        Network.Image = Image.FromFile(Application.StartupPath & "/System/Media/icon/Network.png")
        DirFileName.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/BOB.png")
        shutdown.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/icon/shutdown.png")
        lock.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/icon/lock.png")
        settings.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/icon/settings.png")
        ControlMenu.BackgroundImageLayout = ImageLayout.Stretch
        DirFileName.BackgroundImageLayout = ImageLayout.Stretch
        Network.SizeMode = PictureBoxSizeMode.Zoom
        shutdown.BackgroundImageLayout = ImageLayout.Zoom
        lock.BackgroundImageLayout = ImageLayout.Zoom
        settings.BackgroundImageLayout = ImageLayout.Zoom
        ControlSystem()
    End Sub

    Sub AppList(ByVal search As Boolean, ByVal stext As String)
        Start_items.Controls.Clear()
        If search = True Then
            Dim applist As New RichTextBox
            applist.LoadFile(Application.StartupPath & "\System\app.sys", RichTextBoxStreamType.PlainText)
            For Each apps As String In applist.Lines
                Dim name() As String = apps.Split("!")

                Dim AppName As New Label
                Dim AppImg As New PictureBox
                Dim AppPanel As New Panel

                AppPanel.Size = New Size(100, 90)
                AppPanel.BackColor = Color.Transparent

                AppName.BackColor = Color.Transparent
                AppName.Text = name(0)
                AppName.Font = New Font("Roboto", 9.0!)
                AppName.ForeColor = Color.White
                AppName.TextAlign = ContentAlignment.MiddleCenter
                AppName.Size = New Size(100, 30)
                AppName.Dock = DockStyle.Bottom
                AppImg.Name = name(1)
                Try
                    AppImg.Image = Icon.ExtractAssociatedIcon(name(1)).ToBitmap
                Catch
                    AppImg.Image = Image.FromFile(Application.StartupPath & "/System/Media/App.png")
                End Try
                AppImg.SizeMode = PictureBoxSizeMode.CenterImage
                AppImg.BackColor = Color.Transparent
                AppImg.BorderStyle = BorderStyle.None
                AppImg.Size = New Size(100, 60)
                App(AppImg)
                App(AppName)
                AppPanel.Controls.Add(AppImg)
                AppPanel.Controls.Add(AppName)
                If name(0) = stext Or name(0).Contains(stext) Then
                    Start_items.Controls.Add(AppPanel)
                End If
            Next
        Else
            Dim applist As New RichTextBox
            applist.LoadFile(Application.StartupPath & "\System\app.sys", RichTextBoxStreamType.PlainText)
            For Each apps As String In applist.Lines
                Dim name() As String = apps.Split("!")

                Dim AppName As New Label
                Dim AppImg As New PictureBox
                Dim AppPanel As New Panel

                AppPanel.Size = New Size(100, 90)
                AppPanel.BackColor = Color.Transparent

                AppName.BackColor = Color.Transparent
                AppName.Text = name(0)
                AppName.Name = name(1)
                AppName.Font = New Font("Roboto", 9.0!)
                AppName.ForeColor = Color.White
                AppName.TextAlign = ContentAlignment.MiddleCenter
                AppName.Size = New Size(100, 30)
                AppName.Dock = DockStyle.Bottom
                AppImg.Name = name(1)
                Try
                    AppImg.Image = Icon.ExtractAssociatedIcon(name(1)).ToBitmap
                Catch
                    AppImg.Image = Image.FromFile(Application.StartupPath & "/System/Media/App.png")
                End Try
                AppImg.SizeMode = PictureBoxSizeMode.CenterImage
                AppImg.BackColor = Color.Transparent
                AppImg.BorderStyle = BorderStyle.None
                AppImg.Size = New Size(100, 60)
                App(AppImg)
                App(AppName)
                AppPanel.Controls.Add(AppImg)
                AppPanel.Controls.Add(AppName)
                Start_items.Controls.Add(AppPanel)
            Next

            Dim AppAdd As New Panel
            Dim AppAddImg As New PictureBox

            AppAddImg.Image = Image.FromFile(Application.StartupPath & "/System/Media/icon/AddA.png")
            AppAddImg.SizeMode = PictureBoxSizeMode.StretchImage
            AppAddImg.Size = New Size(48, 48)
            AppAddImg.Location = New Point(21, 21)
            AppAddImg.BackColor = Color.Transparent
            AppAdd.Size = New Size(100, 90)
            AppAdd.BackColor = Color.Transparent
            AppAdd.Controls.Add(AppAddImg)
            AppA(AppAdd)
            AppA(AppAddImg)
            Start_items.Controls.Add(AppAdd)
        End If
    End Sub

    Sub ShowNot(ByVal type As String, ByVal title As String, ByVal text As String)
        If type = "info" Then
            NotificationImg.Image = Image.FromFile(Application.StartupPath & "/System/Media/icon/NiconsI.png")
        ElseIf type = "danger" Then
            NotificationImg.Image = Image.FromFile(Application.StartupPath & "/System/Media/icon/NiconsD.png")
        ElseIf type = "error" Then
            NotificationImg.Image = Image.FromFile(Application.StartupPath & "/System/Media/icon/NiconsE.png")
        ElseIf type = "success" Then
            NotificationImg.Image = Image.FromFile(Application.StartupPath & "/System/Media/icon/NiconsS.png")
        End If
        NotificationTitle.Text = title
        NotificationText.Text = text
        Notification.Visible = True
    End Sub

    Private Sub AppA(ByVal Control As Control)
        AddHandler Control.Click, Sub(sender As Object, e As MouseEventArgs) AppARun(Control)
    End Sub

    Private Sub AppARun(ByVal Control As Control)
        Try
            Dim selectnewapp As New OpenFileDialog
            Dim newsysfile As New RichTextBox
            newsysfile.LoadFile(Application.StartupPath & "/System/app.sys", RichTextBoxStreamType.PlainText)

            If selectnewapp.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim nanhesapla As Integer = selectnewapp.FileName.Split("\").Count
                Dim newappname As String = selectnewapp.FileName.Split("\")(nanhesapla - 1)
                newsysfile.Text = newsysfile.Text & vbNewLine & newappname.Split(".")(0) & "!" & selectnewapp.FileName
                newsysfile.SaveFile(Application.StartupPath & "/System/app.sys", RichTextBoxStreamType.PlainText)
            End If

            AppList(False, "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ControlSystem()
        If My.Computer.Network.IsAvailable = True Then
            Network.Image = Image.FromFile(Application.StartupPath & "/System/Media/icon/NetworkS.png")
        Else
            Network.Image = Image.FromFile(Application.StartupPath & "/System/Media/icon/NetworkN.png")
        End If
    End Sub

    Private Sub Desktop_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseClick
        If e.Button = MouseButtons.Right Then
            RightMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            RightMenu.Visible = True
            StartMOp.Visible = False
            NewMenu.Visible = False
            AppRMenu.Visible = False
        Else
            StartMOp.Visible = False
            RightMenu.Visible = False
            NewMenu.Visible = False
            AppRMenu.Visible = False
            TARM.Visible = False
        End If
        noconsole = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        RightMenu.Visible = False
        NewMenu.Visible = True
        NewMenu.Location = New Point(RightMenu.Location.X, RightMenu.Location.Y)
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        NewMenu.Visible = False
        RightMenu.Visible = False
        AppRMenu.Visible = False
        TARM.Visible = False
        Refresh()
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Console.Visible = True
        NewMenu.Visible = False
        RightMenu.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
        RightMenu.Visible = False
        Wallpaper.MiniTimer_ThemeContainer1.Text = "Duvar Kağıtları"
        Wallpaper.Show()
    End Sub

    Private Sub Desktop_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        If noconsole = 0 Then
            If Asc(e.KeyChar) = Keys.Back Then
                Dim test As String = Console.Text.Count - 1
                If Not Console.Text.Chars(test) = ":" Then
                    Console.Text = Console.Text.Remove(test)
                End If
            ElseIf Asc(e.KeyChar) = Keys.Escape Then
                Console.Text = "$" & get_info.Lines(3).Split("=")(1) & ":"
                Console.Visible = False
                ConHelp.Visible = False
                ConHelp.Items.Clear()
            ElseIf Asc(e.KeyChar) = Keys.Enter Then
                codingwork(Console.Text)
                ConHelp.Visible = False
                Console.Text = "$" & get_info.Lines(3).Split("=")(1) & ":"
            Else
                If Not e.KeyChar = ":" Then
                    Console.Text &= e.KeyChar
                    Console.Visible = True
                    Dim consoletext As String = LCase(Console.Text.Split(":")(1))
                    If consoletext.Contains("open") Then
                        ConHelp.Items.Clear()
                        ConHelp.Items.Add("Wallpaper")
                        ConHelp.Items.Add("Settings")
                        ConHelp.Visible = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Desktop_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.F10 Then
            Console.Visible = True
        End If

        If e.KeyCode = Keys.Enter Then
            codingwork(Console.Text)
            ConHelp.Visible = False
            Console.Text = "$" & get_info.Lines(3).Split("=")(1) & ":-)"
        End If
    End Sub

    Sub codingwork(ByVal code As String)
        Dim coding As String = code
        Dim code2() As String
        code2 = code.Split(":")
        code = code2(1)
        code = LCase(code)
        If code = "open" Then
            Dim code_arg As String = coding.Split(" ")(1)
            If code_arg = "wallpaper" Then
                Wallpaper.MiniTimer_ThemeContainer1.Text = "Duvar Kağıtları"
                Wallpaper.Show()
            End If
        ElseIf code = "date" Or code = "time" Then
            Dim time As New MsgForm
            time.MsgBox.Text = "Time"
            time.MsgText.Text = Now.ToLocalTime
            time.ShowDialog()
        ElseIf code.Contains("echo") And Not code = "echo" Then
            code = code.Replace("echo ", "echo")
            code = code.Replace("echo", "echo ")
            Dim echotext As String = code.Split(" ")(1)
            Dim echo As New MsgForm
            echo.MsgBox.Text = "Echo Result"
            echo.MsgText.Text = echotext
            echo.ShowDialog()
        ElseIf code = "kernel" Then
            Dim kernel As New MsgForm
            kernel.MsgBox.Text = "Launcher Kernel"
            kernel.MsgText.Text = "Kernel: v1.0.0(Win_86x).Net"
            kernel.ShowDialog()
        ElseIf code = "about" Then
            Dim about As New MsgForm
            about.MsgBox.Text = "About"
            about.MsgText.Text = "Windows Launcher v1.0.0" & vbNewLine & "Coding: Utku Halis"
            about.ShowDialog()
        End If
    End Sub

    Private Sub ConHelp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ConHelp.Click
        If Console.Text.Contains(">") Then
            Console.Text &= ConHelp.Text
        Else
            Console.Text &= ">" & ConHelp.Text
        End If
        ConHelp.Items.Clear()
        ConHelp.Visible = False
    End Sub

    Private Sub DCT_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles DCT.Tick
        DTT.Text = Now.Hour & ":" & Now.Minute
        '& vbNewLine & Now.Date
    End Sub

    Private Sub StartMenu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StartMenu.Click
        If StartMOp.Visible = True Then
            StartMOp.Visible = False
            RightMenu.Visible = False
            NewMenu.Visible = False
            AppRMenu.Visible = False
            TARM.Visible = False
        Else
            StartMOp.Visible = True
            RightMenu.Visible = False
            NewMenu.Visible = False
            AppRMenu.Visible = False
            TARM.Visible = False
        End If
    End Sub

    Private Sub App(ByVal Control As Control)
        AddHandler Control.Click, Sub(sender As Object, e As MouseEventArgs) AppRun(Control)
    End Sub

    Private Sub AppRun(ByVal Control As Control)
        Dim hesapla As String = Control.Name.Split("/").Count - 1
        Dim hesaplanokta As String = Control.Name.Split(".").Count - 2
        Dim appname As String = "null"
        Try
            Dim proc As Process
            proc = Process.Start(Control.Name)
            proc.WaitForInputIdle()
            SetParent(proc.MainWindowHandle, Me.Handle)
            SendMessage(proc.MainWindowHandle, WM_SYSCOMMAND, HWND_TOPMOST, 0)
            appname = proc.ProcessName
6:
            Dim taskapp As New PictureBox
            taskapp.Image = Icon.ExtractAssociatedIcon(Control.Name).ToBitmap()
            taskapp.BackColor = Color.Transparent
            taskapp.Name = proc.ProcessName
            taskapp.SizeMode = PictureBoxSizeMode.CenterImage
            taskapp.Dock = DockStyle.Left
            taskapp.Size = New Size(30, 0)
            TBPList.Items.Add(taskapp.Name)
            ControlTask.Controls.Add(taskapp)
        Catch ex As Exception
            ShowNot("info", appname, ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        RightMenu.Visible = False
        MsgBox("Kodlanmadı")
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        RightMenu.Visible = False
        Dim SNote As New StickyNote
        SNote.Name = "Note"
        SNote.NTitle = "New Note Title"
        SNote.NText = "New Note Text"
        SNote.Show()
    End Sub


    Private Sub Desktop_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub DFN(ByVal Control As Control)
        AddHandler Control.MouseMove, Sub(sender As Object, e As MouseEventArgs) ODFN(Control)
        AddHandler Control.MouseLeave, Sub() CDFN()
        AddHandler Control.MouseDoubleClick, Sub() SRMI.Text = Control.AccessibleName
        AddHandler Control.MouseDoubleClick, Sub() OpenFMPer()
    End Sub

    Sub OpenFMPer()
        Dim curItem As String = SRMI.Text
        For Each panel As Control In Me.Controls
            If panel.AccessibleName = curItem Then
                If panel.AccessibleName = "Computer" Then
                    Process.Start(Application.StartupPath & "\System\SystemApp\FileExplorer.exe", "/dir=Computer")
                ElseIf panel.AccessibleName = "Documents" Then
                    Process.Start(Application.StartupPath & "\System\SystemApp\FileExplorer.exe", "/dir=Documents")
                Else
                    Process.Start(Application.StartupPath & "\System\SystemApp\FileExplorer.exe", "/dir=" & SRMI.Text)
                End If
            End If
        Next
    End Sub

    Private Sub ODFN(ByVal Control As Control)
        DFNText.Text = Control.AccessibleName
        DirFileName.Location = New Point(MousePosition.X + 20, MousePosition.Y + 20)
        DirFileName.Visible = True
    End Sub

    Private Sub CDFN()
        DirFileName.Visible = False
    End Sub

    Private Sub PCSListT_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles PCSListT.Tick
        For Each p As Process In Process.GetProcesses
            PCSList.Items.Add(p.ProcessName.ToString)
        Next

        For Each searchstring As String In TBPList.Items
            Dim sactive As Integer = PCSList.FindString(searchstring)
            If Not sactive > -1 Then
                For Each panel As Control In ControlTask.Controls
                    If panel.Name = searchstring Then
                        ControlTask.Controls.Remove(panel)
                    End If
                Next
            End If
        Next

        PCSList.Items.Clear()
    End Sub

    Private Sub Button20_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button20.Click
        NewMenu.Visible = False
        Dim x As New Rename
        Dim dir As New Panel
        dir.Size = New Size(64, 64)
        dir.Location = New Point(MousePosition.X, MousePosition.Y)
        dir.BackgroundImage = Image.FromFile(Application.StartupPath & "/System/Media/Dir.png")
        dir.BackgroundImageLayout = ImageLayout.Stretch

        x.MiniTimer_ThemeContainer1.Text = "Klasör Oluştur"
        x.Button1.Text = "Oluştur"
        x.TopMost = True
        If x.ShowDialog() = DialogResult.OK Then
            If Not x.TxtBox1.Text.Contains("\") Or x.TxtBox1.Text.Contains("/") Or x.TxtBox1.Text.Contains(":") Or x.TxtBox1.Text.Contains("*") Or x.TxtBox1.Text.Contains("?") Or x.TxtBox1.Text.Contains("""") Or x.TxtBox1.Text.Contains("<") Or x.TxtBox1.Text.Contains(">") Or x.TxtBox1.Text.Contains("|") Then
                If Not My.Computer.FileSystem.DirectoryExists(StandartDirLocation & "[Disk1]\Desktop\" & x.TxtBox1.Text) = True Then
                    My.Computer.FileSystem.CreateDirectory(StandartDirLocation & "[Disk1]\Desktop\" & x.TxtBox1.Text)
                    dir.AccessibleName = x.TxtBox1.Text
                    Me.Controls.Add(dir)
                    DFN(dir)
                    Moving(dir)
                    ActiveRMenu(dir)
                    Dim saveposition As New RichTextBox
                    saveposition.BorderStyle = BorderStyle.None
                    Me.Controls.Add(saveposition)
                    saveposition.Text = dir.Location.X & "," & dir.Location.Y
                    saveposition.SaveFile(StandartDirLocation & "Root\" & x.TxtBox1.Text & ".txt", RichTextBoxStreamType.PlainText)
                    Me.Controls.Remove(saveposition)
                Else
                    Dim z As New MsgForm
                    z.MsgBox.Text = "Hata"
                    z.MsgText.Text = "Oluşturmak istediğiniz klasör ismine sahip başka bir klasör var"
                    z.TopMost = True
                    z.ShowDialog()
                End If
            Else
                Dim z As New MsgForm
                z.MsgBox.Text = "Hata"
                z.MsgText.Text = "Geçersiz Karakter Kullanımı"
                z.TopMost = True
                z.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        For Each deneme As Form In Application.OpenForms
            If deneme.Name = "Note" Then
                deneme.TopMost = False
            End If
        Next
        NewMenu.Visible = False
        RightMenu.Visible = False
        LockScreen.BackgroundImage = Me.BackgroundImage
        LockScreen.BackgroundImageLayout = ImageLayout.Stretch
        LockScreen.ShowDialog()
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
        AppRMenu.Visible = False
        Dim curItem As String = SRMI.Text
        For Each panel As Control In Me.Controls
            If panel.AccessibleName = curItem Then
                SRMI.Text = panel.AccessibleName
                OpenFMPer()
                Exit For
            End If
        Next
    End Sub

    Private Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.Click
        AppRMenu.Visible = False
        Dim curItem As String = SRMI.Text
        For Each panel As Control In Me.Controls
            If panel.AccessibleName = curItem Then
                Dim lastname As String = panel.AccessibleName
                panel.AccessibleName = InputBox("Directory Name", "Directory Name", panel.AccessibleName)
                My.Computer.FileSystem.RenameDirectory(Application.StartupPath & "/System/Storage/[Disk1]/Desktop/" & lastname & "/", panel.AccessibleName)
                My.Computer.FileSystem.RenameFile(Application.StartupPath & "/System/Storage/Root/" & lastname & ".txt", panel.AccessibleName & ".txt")
                Exit For
            End If
        Next
    End Sub

    Private Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.Click
        AppRMenu.Visible = False
        If MsgBox("Delete Dir ?", MsgBoxStyle.YesNo, "Kaptan") = MsgBoxResult.Yes Then
            Dim curItem As String = SRMI.Text
            For Each panel As Control In Me.Controls
                If panel.AccessibleName = curItem Then
                    If Not panel.AccessibleName = "Documents" Or Not panel.AccessibleName = "Documents" Then
                        Me.Controls.Remove(panel)
                        My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "/System/Storage/[Disk1]/Desktop/" & panel.AccessibleName & "/", FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/System/Storage/Root/" & panel.AccessibleName & ".txt")
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button21.Click
        AppRMenu.Visible = False
        Dim curItem As String = SRMI.Text
        For Each panel As Control In Me.Controls
            If panel.AccessibleName = curItem Then
                MsgBox(
                    "Dir Name: " & My.Computer.FileSystem.GetDirectoryInfo(Application.StartupPath & "/System/Storage/[Disk1]/Desktop/" & panel.AccessibleName & "/").Name & vbNewLine &
                    "Created Time: " & My.Computer.FileSystem.GetDirectoryInfo(Application.StartupPath & "/System/Storage/[Disk1]/Desktop/" & panel.AccessibleName & "/").CreationTime,
                MsgBoxStyle.Information, "Kaptan")
                Exit For
            End If
        Next
    End Sub

    Private Sub shutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shutdown.Click
        End
    End Sub

    Private Sub lock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lock.Click
        For Each deneme As Form In Application.OpenForms
            If deneme.Name = "Note" Then
                deneme.TopMost = False
            End If
        Next
        StartMOp.Visible = False
        NewMenu.Visible = False
        RightMenu.Visible = False
        LockScreen.BackgroundImage = Me.BackgroundImage
        LockScreen.BackgroundImageLayout = ImageLayout.Stretch
        LockScreen.ShowDialog()
    End Sub

    Private Sub settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings.Click
        Process.Start(Application.StartupPath & "/System/SystemApp/Görev Yöneticisi.exe")
    End Sub

    Private Sub Button13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseEnter
        MsgBox("test")
    End Sub

    Function disk_hesapla(ByVal veri As String)
        Dim disksize As String = Math.Round((veri / 1024), 2)
        Dim disksizetx As String

        If (disksize.Split(",")(0) > 1023) Then
            disksize = Math.Round((disksize / 1024), 2)
            disksizetx = " MB"
            If (disksize.Split(",")(0) > 1023) Then
                disksize = Math.Round((disksize / 1024), 2)
                disksizetx = " GB"
            End If
        Else
            disksizetx = " KB"
        End If

        Return disksize & disksizetx
    End Function

    Private Sub TxtBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBox1.TextChanged
        If TxtBox1.Text = "" Then
            AppList(True, TxtBox1.Text)
            noconsole = 0
        Else
            AppList(True, TxtBox1.Text)
            noconsole = 1
        End If
    End Sub
End Class