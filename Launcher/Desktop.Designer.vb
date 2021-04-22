<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ControlMenu = New System.Windows.Forms.Panel()
        Me.ControlTask = New System.Windows.Forms.Panel()
        Me.Network = New System.Windows.Forms.PictureBox()
        Me.DTT = New System.Windows.Forms.Label()
        Me.StartMenu = New System.Windows.Forms.PictureBox()
        Me.Console = New System.Windows.Forms.Label()
        Me.DCT = New System.Windows.Forms.Timer(Me.components)
        Me.StartMOp = New System.Windows.Forms.Panel()
        Me.Start_items = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtBox1 = New Launcher.TxtBox()
        Me.lock = New System.Windows.Forms.PictureBox()
        Me.settings = New System.Windows.Forms.PictureBox()
        Me.shutdown = New System.Windows.Forms.PictureBox()
        Me.NoteList = New System.Windows.Forms.Timer(Me.components)
        Me.ConHelp = New System.Windows.Forms.ListBox()
        Me.SRMI = New System.Windows.Forms.TextBox()
        Me.PCSList = New System.Windows.Forms.ListBox()
        Me.PCSListT = New System.Windows.Forms.Timer(Me.components)
        Me.TBPList = New System.Windows.Forms.ListBox()
        Me.DirFileName = New System.Windows.Forms.Panel()
        Me.DFNText = New System.Windows.Forms.Label()
        Me.TARM = New Launcher.PanelBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.AppRMenu = New Launcher.PanelBox()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.NewMenu = New Launcher.PanelBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.RightMenu = New Launcher.PanelBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Notification = New System.Windows.Forms.Panel()
        Me.NotificationTitle = New System.Windows.Forms.Label()
        Me.NotificationText = New System.Windows.Forms.Label()
        Me.NotificationImg = New System.Windows.Forms.PictureBox()
        Me.ControlMenu.SuspendLayout()
        CType(Me.Network, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StartMOp.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.lock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shutdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DirFileName.SuspendLayout()
        Me.TARM.SuspendLayout()
        Me.AppRMenu.SuspendLayout()
        Me.NewMenu.SuspendLayout()
        Me.RightMenu.SuspendLayout()
        Me.Notification.SuspendLayout()
        CType(Me.NotificationImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlMenu
        '
        Me.ControlMenu.BackColor = System.Drawing.Color.Transparent
        Me.ControlMenu.Controls.Add(Me.ControlTask)
        Me.ControlMenu.Controls.Add(Me.Network)
        Me.ControlMenu.Controls.Add(Me.DTT)
        Me.ControlMenu.Controls.Add(Me.StartMenu)
        Me.ControlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlMenu.Location = New System.Drawing.Point(0, 0)
        Me.ControlMenu.Name = "ControlMenu"
        Me.ControlMenu.Size = New System.Drawing.Size(990, 30)
        Me.ControlMenu.TabIndex = 2
        '
        'ControlTask
        '
        Me.ControlTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlTask.Location = New System.Drawing.Point(35, 0)
        Me.ControlTask.Name = "ControlTask"
        Me.ControlTask.Size = New System.Drawing.Size(846, 30)
        Me.ControlTask.TabIndex = 5
        '
        'Network
        '
        Me.Network.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Network.Dock = System.Windows.Forms.DockStyle.Right
        Me.Network.Location = New System.Drawing.Point(881, 0)
        Me.Network.Name = "Network"
        Me.Network.Size = New System.Drawing.Size(29, 30)
        Me.Network.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Network.TabIndex = 4
        Me.Network.TabStop = False
        '
        'DTT
        '
        Me.DTT.Dock = System.Windows.Forms.DockStyle.Right
        Me.DTT.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DTT.Location = New System.Drawing.Point(910, 0)
        Me.DTT.Name = "DTT"
        Me.DTT.Size = New System.Drawing.Size(80, 30)
        Me.DTT.TabIndex = 3
        Me.DTT.Text = "00:00"
        Me.DTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartMenu
        '
        Me.StartMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.StartMenu.Location = New System.Drawing.Point(0, 0)
        Me.StartMenu.Name = "StartMenu"
        Me.StartMenu.Size = New System.Drawing.Size(35, 30)
        Me.StartMenu.TabIndex = 2
        Me.StartMenu.TabStop = False
        '
        'Console
        '
        Me.Console.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Console.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Console.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Console.Location = New System.Drawing.Point(0, 745)
        Me.Console.Name = "Console"
        Me.Console.Size = New System.Drawing.Size(990, 20)
        Me.Console.TabIndex = 6
        Me.Console.Text = "User>"
        Me.Console.Visible = False
        '
        'DCT
        '
        Me.DCT.Enabled = True
        '
        'StartMOp
        '
        Me.StartMOp.BackColor = System.Drawing.Color.Transparent
        Me.StartMOp.Controls.Add(Me.Start_items)
        Me.StartMOp.Controls.Add(Me.Panel1)
        Me.StartMOp.Location = New System.Drawing.Point(0, 30)
        Me.StartMOp.Name = "StartMOp"
        Me.StartMOp.Size = New System.Drawing.Size(600, 400)
        Me.StartMOp.TabIndex = 9
        Me.StartMOp.Visible = False
        '
        'Start_items
        '
        Me.Start_items.AutoScroll = True
        Me.Start_items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Start_items.Location = New System.Drawing.Point(0, 36)
        Me.Start_items.Name = "Start_items"
        Me.Start_items.Size = New System.Drawing.Size(600, 364)
        Me.Start_items.TabIndex = 29
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtBox1)
        Me.Panel1.Controls.Add(Me.lock)
        Me.Panel1.Controls.Add(Me.settings)
        Me.Panel1.Controls.Add(Me.shutdown)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 36)
        Me.Panel1.TabIndex = 28
        '
        'TxtBox1
        '
        Me.TxtBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBox1.BackColor = System.Drawing.Color.White
        Me.TxtBox1.Image = Nothing
        Me.TxtBox1.Location = New System.Drawing.Point(3, 2)
        Me.TxtBox1.MaxLength = 32767
        Me.TxtBox1.Name = "TxtBox1"
        Me.TxtBox1.NoRounding = False
        Me.TxtBox1.Size = New System.Drawing.Size(351, 31)
        Me.TxtBox1.TabIndex = 28
        Me.TxtBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtBox1.UseSystemPasswordChar = False
        '
        'lock
        '
        Me.lock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lock.Location = New System.Drawing.Point(530, 5)
        Me.lock.Name = "lock"
        Me.lock.Size = New System.Drawing.Size(30, 25)
        Me.lock.TabIndex = 31
        Me.lock.TabStop = False
        '
        'settings
        '
        Me.settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settings.Location = New System.Drawing.Point(495, 5)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(30, 25)
        Me.settings.TabIndex = 32
        Me.settings.TabStop = False
        '
        'shutdown
        '
        Me.shutdown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shutdown.Location = New System.Drawing.Point(565, 5)
        Me.shutdown.Name = "shutdown"
        Me.shutdown.Size = New System.Drawing.Size(30, 25)
        Me.shutdown.TabIndex = 30
        Me.shutdown.TabStop = False
        '
        'NoteList
        '
        Me.NoteList.Interval = 1
        '
        'ConHelp
        '
        Me.ConHelp.AccessibleName = ""
        Me.ConHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConHelp.BackColor = System.Drawing.Color.Black
        Me.ConHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConHelp.ForeColor = System.Drawing.Color.White
        Me.ConHelp.FormattingEnabled = True
        Me.ConHelp.ItemHeight = 15
        Me.ConHelp.Location = New System.Drawing.Point(0, 581)
        Me.ConHelp.Name = "ConHelp"
        Me.ConHelp.Size = New System.Drawing.Size(168, 152)
        Me.ConHelp.TabIndex = 15
        Me.ConHelp.Visible = False
        '
        'SRMI
        '
        Me.SRMI.Location = New System.Drawing.Point(236, 638)
        Me.SRMI.Name = "SRMI"
        Me.SRMI.Size = New System.Drawing.Size(10, 21)
        Me.SRMI.TabIndex = 18
        Me.SRMI.Visible = False
        '
        'PCSList
        '
        Me.PCSList.FormattingEnabled = True
        Me.PCSList.ItemHeight = 15
        Me.PCSList.Location = New System.Drawing.Point(220, 638)
        Me.PCSList.Name = "PCSList"
        Me.PCSList.Size = New System.Drawing.Size(10, 15)
        Me.PCSList.TabIndex = 19
        Me.PCSList.Visible = False
        '
        'PCSListT
        '
        Me.PCSListT.Enabled = True
        Me.PCSListT.Interval = 10
        '
        'TBPList
        '
        Me.TBPList.FormattingEnabled = True
        Me.TBPList.ItemHeight = 15
        Me.TBPList.Location = New System.Drawing.Point(204, 638)
        Me.TBPList.Name = "TBPList"
        Me.TBPList.Size = New System.Drawing.Size(10, 15)
        Me.TBPList.TabIndex = 21
        Me.TBPList.Visible = False
        '
        'DirFileName
        '
        Me.DirFileName.BackColor = System.Drawing.Color.Transparent
        Me.DirFileName.Controls.Add(Me.DFNText)
        Me.DirFileName.Location = New System.Drawing.Point(781, 725)
        Me.DirFileName.Name = "DirFileName"
        Me.DirFileName.Size = New System.Drawing.Size(200, 25)
        Me.DirFileName.TabIndex = 27
        Me.DirFileName.Visible = False
        '
        'DFNText
        '
        Me.DFNText.BackColor = System.Drawing.Color.Transparent
        Me.DFNText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DFNText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DFNText.Location = New System.Drawing.Point(0, 0)
        Me.DFNText.Name = "DFNText"
        Me.DFNText.Size = New System.Drawing.Size(200, 25)
        Me.DFNText.TabIndex = 28
        Me.DFNText.Text = "Label1"
        Me.DFNText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TARM
        '
        Me.TARM.Controls.Add(Me.Button13)
        Me.TARM.Controls.Add(Me.Button15)
        Me.TARM.Controls.Add(Me.Button16)
        Me.TARM.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TARM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TARM.Location = New System.Drawing.Point(778, 594)
        Me.TARM.Name = "TARM"
        Me.TARM.NoRounding = False
        Me.TARM.Size = New System.Drawing.Size(200, 90)
        Me.TARM.TabIndex = 25
        Me.TARM.Text = "PanelBox1"
        Me.TARM.Visible = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Location = New System.Drawing.Point(0, 60)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(200, 30)
        Me.Button13.TabIndex = 14
        Me.Button13.Text = "Özellikler"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Location = New System.Drawing.Point(0, 30)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(200, 30)
        Me.Button15.TabIndex = 12
        Me.Button15.Text = "Kapat"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button16.ForeColor = System.Drawing.Color.Black
        Me.Button16.Location = New System.Drawing.Point(0, 0)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(200, 30)
        Me.Button16.TabIndex = 11
        Me.Button16.Text = "Aç"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.UseVisualStyleBackColor = False
        '
        'AppRMenu
        '
        Me.AppRMenu.Controls.Add(Me.Button21)
        Me.AppRMenu.Controls.Add(Me.Button10)
        Me.AppRMenu.Controls.Add(Me.Button9)
        Me.AppRMenu.Controls.Add(Me.Button8)
        Me.AppRMenu.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.AppRMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AppRMenu.Location = New System.Drawing.Point(778, 468)
        Me.AppRMenu.Name = "AppRMenu"
        Me.AppRMenu.NoRounding = False
        Me.AppRMenu.Size = New System.Drawing.Size(200, 120)
        Me.AppRMenu.TabIndex = 24
        Me.AppRMenu.Text = "PanelBox1"
        Me.AppRMenu.Visible = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.Transparent
        Me.Button21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button21.FlatAppearance.BorderSize = 0
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button21.ForeColor = System.Drawing.Color.Black
        Me.Button21.Location = New System.Drawing.Point(0, 90)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(200, 30)
        Me.Button21.TabIndex = 14
        Me.Button21.Text = "Özellikler"
        Me.Button21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(0, 60)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(200, 30)
        Me.Button10.TabIndex = 13
        Me.Button10.Text = "Sil"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(0, 30)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(200, 30)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "İsmini Değiştir"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(0, 0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(200, 30)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Aç"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = False
        '
        'NewMenu
        '
        Me.NewMenu.Controls.Add(Me.Button11)
        Me.NewMenu.Controls.Add(Me.Button12)
        Me.NewMenu.Controls.Add(Me.Button17)
        Me.NewMenu.Controls.Add(Me.Button18)
        Me.NewMenu.Controls.Add(Me.Button19)
        Me.NewMenu.Controls.Add(Me.Button20)
        Me.NewMenu.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.NewMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NewMenu.Location = New System.Drawing.Point(778, 56)
        Me.NewMenu.Name = "NewMenu"
        Me.NewMenu.NoRounding = False
        Me.NewMenu.Size = New System.Drawing.Size(200, 180)
        Me.NewMenu.TabIndex = 23
        Me.NewMenu.Text = "PanelBox1"
        Me.NewMenu.Visible = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button11.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(0, 150)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(200, 30)
        Me.Button11.TabIndex = 12
        Me.Button11.Text = "Terminal File(*.Ter)"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Location = New System.Drawing.Point(0, 120)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(200, 30)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "LanLang File(*.ll)"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Transparent
        Me.Button17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button17.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button17.FlatAppearance.BorderSize = 0
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button17.ForeColor = System.Drawing.Color.Black
        Me.Button17.Location = New System.Drawing.Point(0, 90)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(200, 30)
        Me.Button17.TabIndex = 10
        Me.Button17.Text = "TXT File(*.txt)"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Transparent
        Me.Button18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button18.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button18.ForeColor = System.Drawing.Color.Black
        Me.Button18.Location = New System.Drawing.Point(0, 60)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(200, 30)
        Me.Button18.TabIndex = 9
        Me.Button18.Text = "PHP File(*.php)"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Transparent
        Me.Button19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button19.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button19.FlatAppearance.BorderSize = 0
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button19.ForeColor = System.Drawing.Color.Black
        Me.Button19.Location = New System.Drawing.Point(0, 30)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(200, 30)
        Me.Button19.TabIndex = 8
        Me.Button19.Text = "HTML File(*.html)"
        Me.Button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Transparent
        Me.Button20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button20.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.Button20.FlatAppearance.BorderSize = 0
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button20.ForeColor = System.Drawing.Color.Black
        Me.Button20.Location = New System.Drawing.Point(0, 0)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(200, 30)
        Me.Button20.TabIndex = 7
        Me.Button20.Text = "Klasör"
        Me.Button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button20.UseVisualStyleBackColor = False
        '
        'RightMenu
        '
        Me.RightMenu.Controls.Add(Me.Button6)
        Me.RightMenu.Controls.Add(Me.Button7)
        Me.RightMenu.Controls.Add(Me.Button5)
        Me.RightMenu.Controls.Add(Me.Button4)
        Me.RightMenu.Controls.Add(Me.Button3)
        Me.RightMenu.Controls.Add(Me.Button2)
        Me.RightMenu.Controls.Add(Me.Button1)
        Me.RightMenu.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.RightMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RightMenu.Location = New System.Drawing.Point(778, 252)
        Me.RightMenu.Name = "RightMenu"
        Me.RightMenu.NoRounding = False
        Me.RightMenu.Size = New System.Drawing.Size(200, 210)
        Me.RightMenu.TabIndex = 22
        Me.RightMenu.Text = "PanelBox1"
        Me.RightMenu.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(0, 180)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 30)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Kilitle"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(0, 150)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(200, 30)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Duvar Kağıdı"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(0, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(200, 30)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Terminal"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(0, 90)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 30)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Ayarlar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(0, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 30)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Not Ekle"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(0, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 30)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Yenile"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Yeni"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Notification
        '
        Me.Notification.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Notification.BackColor = System.Drawing.Color.Transparent
        Me.Notification.Controls.Add(Me.NotificationTitle)
        Me.Notification.Controls.Add(Me.NotificationText)
        Me.Notification.Controls.Add(Me.NotificationImg)
        Me.Notification.Location = New System.Drawing.Point(581, 572)
        Me.Notification.Name = "Notification"
        Me.Notification.Size = New System.Drawing.Size(400, 150)
        Me.Notification.TabIndex = 28
        Me.Notification.Visible = False
        '
        'NotificationTitle
        '
        Me.NotificationTitle.Location = New System.Drawing.Point(157, 9)
        Me.NotificationTitle.Name = "NotificationTitle"
        Me.NotificationTitle.Size = New System.Drawing.Size(237, 35)
        Me.NotificationTitle.TabIndex = 2
        Me.NotificationTitle.Text = "Label2"
        '
        'NotificationText
        '
        Me.NotificationText.Location = New System.Drawing.Point(157, 44)
        Me.NotificationText.Name = "NotificationText"
        Me.NotificationText.Size = New System.Drawing.Size(237, 103)
        Me.NotificationText.TabIndex = 1
        Me.NotificationText.Text = "Label1"
        '
        'NotificationImg
        '
        Me.NotificationImg.Location = New System.Drawing.Point(3, 9)
        Me.NotificationImg.Name = "NotificationImg"
        Me.NotificationImg.Size = New System.Drawing.Size(148, 138)
        Me.NotificationImg.TabIndex = 0
        Me.NotificationImg.TabStop = False
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(990, 765)
        Me.ControlBox = False
        Me.Controls.Add(Me.Notification)
        Me.Controls.Add(Me.DirFileName)
        Me.Controls.Add(Me.TARM)
        Me.Controls.Add(Me.AppRMenu)
        Me.Controls.Add(Me.NewMenu)
        Me.Controls.Add(Me.StartMOp)
        Me.Controls.Add(Me.RightMenu)
        Me.Controls.Add(Me.TBPList)
        Me.Controls.Add(Me.PCSList)
        Me.Controls.Add(Me.SRMI)
        Me.Controls.Add(Me.ConHelp)
        Me.Controls.Add(Me.Console)
        Me.Controls.Add(Me.ControlMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Desktop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ControlMenu.ResumeLayout(False)
        CType(Me.Network, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StartMOp.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.lock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shutdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DirFileName.ResumeLayout(False)
        Me.TARM.ResumeLayout(False)
        Me.AppRMenu.ResumeLayout(False)
        Me.NewMenu.ResumeLayout(False)
        Me.RightMenu.ResumeLayout(False)
        Me.Notification.ResumeLayout(False)
        CType(Me.NotificationImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ControlMenu As Panel
    Friend WithEvents StartMenu As PictureBox
    Friend WithEvents Console As Label
    Friend WithEvents DTT As Label
    Friend WithEvents DCT As Timer
    Friend WithEvents StartMOp As Panel
    Friend WithEvents NoteList As Timer
    Friend WithEvents ConHelp As ListBox
    Friend WithEvents Network As PictureBox
    Friend WithEvents SRMI As TextBox
    Friend WithEvents PCSList As ListBox
    Friend WithEvents PCSListT As Timer
    Friend WithEvents TBPList As ListBox
    Friend WithEvents RightMenu As PanelBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents NewMenu As PanelBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents ControlTask As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents AppRMenu As PanelBox
    Friend WithEvents Button21 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents TARM As PanelBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents DirFileName As Panel
    Friend WithEvents DFNText As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents shutdown As PictureBox
    Friend WithEvents lock As System.Windows.Forms.PictureBox
    Friend WithEvents settings As System.Windows.Forms.PictureBox
    Friend WithEvents TxtBox1 As Launcher.TxtBox
    Friend WithEvents Start_items As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Notification As System.Windows.Forms.Panel
    Friend WithEvents NotificationTitle As System.Windows.Forms.Label
    Friend WithEvents NotificationText As System.Windows.Forms.Label
    Friend WithEvents NotificationImg As System.Windows.Forms.PictureBox
End Class
