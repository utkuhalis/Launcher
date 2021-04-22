<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.text1 = New System.Windows.Forms.Label()
        Me.text2 = New System.Windows.Forms.Label()
        Me.text3 = New System.Windows.Forms.Label()
        Me.text5 = New System.Windows.Forms.Label()
        Me.text6 = New System.Windows.Forms.Label()
        Me.text4 = New System.Windows.Forms.Label()
        Me.status1 = New System.Windows.Forms.Label()
        Me.status2 = New System.Windows.Forms.Label()
        Me.BootStart = New System.Windows.Forms.Timer(Me.components)
        Me.SystemControl = New System.Windows.Forms.Timer(Me.components)
        Me.SystemDir = New System.Windows.Forms.TextBox()
        Me.SystemFile = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'text1
        '
        Me.text1.AutoSize = True
        Me.text1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.text1.ForeColor = System.Drawing.Color.White
        Me.text1.Location = New System.Drawing.Point(12, 9)
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(100, 15)
        Me.text1.TabIndex = 0
        Me.text1.Text = "Loading Kernel..."
        Me.text1.Visible = False
        '
        'text2
        '
        Me.text2.AutoSize = True
        Me.text2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.text2.ForeColor = System.Drawing.Color.White
        Me.text2.Location = New System.Drawing.Point(12, 25)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(86, 15)
        Me.text2.TabIndex = 1
        Me.text2.Text = "Starting Boot..."
        Me.text2.Visible = False
        '
        'text3
        '
        Me.text3.AutoSize = True
        Me.text3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.text3.ForeColor = System.Drawing.Color.White
        Me.text3.Location = New System.Drawing.Point(12, 41)
        Me.text3.Name = "text3"
        Me.text3.Size = New System.Drawing.Size(130, 15)
        Me.text3.TabIndex = 2
        Me.text3.Text = "System File...................."
        Me.text3.Visible = False
        '
        'text5
        '
        Me.text5.AutoSize = True
        Me.text5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.text5.ForeColor = System.Drawing.Color.White
        Me.text5.Location = New System.Drawing.Point(12, 73)
        Me.text5.Name = "text5"
        Me.text5.Size = New System.Drawing.Size(97, 15)
        Me.text5.TabIndex = 4
        Me.text5.Text = "Boot Complete..."
        Me.text5.Visible = False
        '
        'text6
        '
        Me.text6.AutoSize = True
        Me.text6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.text6.ForeColor = System.Drawing.Color.White
        Me.text6.Location = New System.Drawing.Point(12, 89)
        Me.text6.Name = "text6"
        Me.text6.Size = New System.Drawing.Size(113, 15)
        Me.text6.TabIndex = 5
        Me.text6.Text = "Starting Launcher..."
        Me.text6.Visible = False
        '
        'text4
        '
        Me.text4.AutoSize = True
        Me.text4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.text4.ForeColor = System.Drawing.Color.White
        Me.text4.Location = New System.Drawing.Point(12, 57)
        Me.text4.Name = "text4"
        Me.text4.Size = New System.Drawing.Size(129, 15)
        Me.text4.TabIndex = 7
        Me.text4.Text = "System Dir....................."
        Me.text4.Visible = False
        '
        'status1
        '
        Me.status1.AutoSize = True
        Me.status1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.status1.ForeColor = System.Drawing.Color.Yellow
        Me.status1.Location = New System.Drawing.Point(136, 41)
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(41, 15)
        Me.status1.TabIndex = 8
        Me.status1.Text = "Check"
        Me.status1.Visible = False
        '
        'status2
        '
        Me.status2.AutoSize = True
        Me.status2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.status2.ForeColor = System.Drawing.Color.Yellow
        Me.status2.Location = New System.Drawing.Point(136, 57)
        Me.status2.Name = "status2"
        Me.status2.Size = New System.Drawing.Size(41, 15)
        Me.status2.TabIndex = 9
        Me.status2.Text = "Check"
        Me.status2.Visible = False
        '
        'BootStart
        '
        Me.BootStart.Enabled = True
        Me.BootStart.Interval = 1000
        '
        'SystemControl
        '
        Me.SystemControl.Interval = 50
        '
        'SystemDir
        '
        Me.SystemDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SystemDir.BackColor = System.Drawing.Color.Black
        Me.SystemDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SystemDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.SystemDir.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.SystemDir.Location = New System.Drawing.Point(509, 12)
        Me.SystemDir.Multiline = True
        Me.SystemDir.Name = "SystemDir"
        Me.SystemDir.Size = New System.Drawing.Size(176, 98)
        Me.SystemDir.TabIndex = 14
        '
        'SystemFile
        '
        Me.SystemFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SystemFile.BackColor = System.Drawing.Color.Black
        Me.SystemFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SystemFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.SystemFile.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.SystemFile.Location = New System.Drawing.Point(509, 116)
        Me.SystemFile.Multiline = True
        Me.SystemFile.Name = "SystemFile"
        Me.SystemFile.Size = New System.Drawing.Size(176, 98)
        Me.SystemFile.TabIndex = 15
        '
        'Boot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(697, 536)
        Me.ControlBox = False
        Me.Controls.Add(Me.SystemFile)
        Me.Controls.Add(Me.SystemDir)
        Me.Controls.Add(Me.status2)
        Me.Controls.Add(Me.status1)
        Me.Controls.Add(Me.text4)
        Me.Controls.Add(Me.text6)
        Me.Controls.Add(Me.text5)
        Me.Controls.Add(Me.text3)
        Me.Controls.Add(Me.text2)
        Me.Controls.Add(Me.text1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Boot"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents text1 As Label
    Friend WithEvents text2 As Label
    Friend WithEvents text3 As Label
    Friend WithEvents text5 As Label
    Friend WithEvents text6 As Label
    Friend WithEvents text4 As Label
    Friend WithEvents status1 As Label
    Friend WithEvents status2 As Label
    Friend WithEvents BootStart As Timer
    Friend WithEvents SystemControl As Timer
    Friend WithEvents SystemDir As TextBox
    Friend WithEvents SystemFile As TextBox
End Class
