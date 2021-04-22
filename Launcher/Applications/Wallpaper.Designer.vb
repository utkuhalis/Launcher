<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Wallpaper
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
        Me.List_Pic = New System.Windows.Forms.Timer(Me.components)
        Me.MiniTimer_ThemeContainer1 = New Launcher.MiniTimer_ThemeContainer()
        Me.user_info = New System.Windows.Forms.RichTextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.List = New System.Windows.Forms.FlowLayoutPanel()
        Me.MiniTimer_ControlBox1 = New Launcher.MiniTimer_ControlBox()
        Me.MiniTimer_ThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'List_Pic
        '
        Me.List_Pic.Interval = 1
        '
        'MiniTimer_ThemeContainer1
        '
        Me.MiniTimer_ThemeContainer1.BackColor = System.Drawing.Color.White
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.user_info)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.ListBox1)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.List)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.MiniTimer_ControlBox1)
        Me.MiniTimer_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MiniTimer_ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MiniTimer_ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.MiniTimer_ThemeContainer1.Name = "MiniTimer_ThemeContainer1"
        Me.MiniTimer_ThemeContainer1.Padding = New System.Windows.Forms.Padding(2, 45, 2, 2)
        Me.MiniTimer_ThemeContainer1.RoundCorners = False
        Me.MiniTimer_ThemeContainer1.Sizable = False
        Me.MiniTimer_ThemeContainer1.Size = New System.Drawing.Size(754, 470)
        Me.MiniTimer_ThemeContainer1.SmartBounds = True
        Me.MiniTimer_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MiniTimer_ThemeContainer1.TabIndex = 0
        Me.MiniTimer_ThemeContainer1.Text = "Duvar Kağıtları"
        '
        'user_info
        '
        Me.user_info.Location = New System.Drawing.Point(466, 116)
        Me.user_info.Name = "user_info"
        Me.user_info.Size = New System.Drawing.Size(10, 10)
        Me.user_info.TabIndex = 1
        Me.user_info.Text = ""
        Me.user_info.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(543, 116)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(10, 4)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.Visible = False
        '
        'List
        '
        Me.List.AutoScroll = True
        Me.List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.List.Location = New System.Drawing.Point(2, 45)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(750, 423)
        Me.List.TabIndex = 2
        '
        'MiniTimer_ControlBox1
        '
        Me.MiniTimer_ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.MiniTimer_ControlBox1.EnableMaximize = False
        Me.MiniTimer_ControlBox1.Font = New System.Drawing.Font("Marlett", 7.0!)
        Me.MiniTimer_ControlBox1.Location = New System.Drawing.Point(15, 13)
        Me.MiniTimer_ControlBox1.Name = "MiniTimer_ControlBox1"
        Me.MiniTimer_ControlBox1.Size = New System.Drawing.Size(40, 16)
        Me.MiniTimer_ControlBox1.TabIndex = 0
        Me.MiniTimer_ControlBox1.Text = "MiniTimer_ControlBox1"
        '
        'Wallpaper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 470)
        Me.Controls.Add(Me.MiniTimer_ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(261, 65)
        Me.Name = "Wallpaper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duvar Kağıtları"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MiniTimer_ThemeContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MiniTimer_ThemeContainer1 As MiniTimer_ThemeContainer
    Friend WithEvents MiniTimer_ControlBox1 As MiniTimer_ControlBox
    Friend WithEvents List_Pic As Timer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents user_info As RichTextBox
    Friend WithEvents List As System.Windows.Forms.FlowLayoutPanel
End Class
