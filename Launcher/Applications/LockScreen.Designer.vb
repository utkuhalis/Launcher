<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LockScreen
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.alarm_notf = New System.Windows.Forms.PictureBox()
        Me.DateText = New System.Windows.Forms.Label()
        Me.TimeText = New System.Windows.Forms.Label()
        Me.OLS = New System.Windows.Forms.Timer(Me.components)
        Me.TADT = New System.Windows.Forms.Timer(Me.components)
        Me.CLS = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.alarm_notf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DateText)
        Me.Panel1.Controls.Add(Me.TimeText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 714)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.alarm_notf)
        Me.Panel2.Location = New System.Drawing.Point(3, 664)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(47, 38)
        Me.Panel2.TabIndex = 3
        Me.Panel2.Visible = False
        '
        'alarm_notf
        '
        Me.alarm_notf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.alarm_notf.Location = New System.Drawing.Point(3, 5)
        Me.alarm_notf.Name = "alarm_notf"
        Me.alarm_notf.Size = New System.Drawing.Size(40, 30)
        Me.alarm_notf.TabIndex = 2
        Me.alarm_notf.TabStop = False
        '
        'DateText
        '
        Me.DateText.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!)
        Me.DateText.ForeColor = System.Drawing.Color.White
        Me.DateText.Location = New System.Drawing.Point(160, 265)
        Me.DateText.Name = "DateText"
        Me.DateText.Size = New System.Drawing.Size(380, 50)
        Me.DateText.TabIndex = 1
        Me.DateText.Text = "00.00.0000"
        Me.DateText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeText
        '
        Me.TimeText.Font = New System.Drawing.Font("Microsoft Sans Serif", 64.0!)
        Me.TimeText.ForeColor = System.Drawing.Color.White
        Me.TimeText.Location = New System.Drawing.Point(160, 165)
        Me.TimeText.Name = "TimeText"
        Me.TimeText.Size = New System.Drawing.Size(380, 100)
        Me.TimeText.TabIndex = 0
        Me.TimeText.Text = "00:00:00"
        Me.TimeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OLS
        '
        Me.OLS.Enabled = True
        Me.OLS.Interval = 1
        '
        'TADT
        '
        Me.TADT.Enabled = True
        '
        'CLS
        '
        Me.CLS.Interval = 1
        '
        'LockScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(990, 714)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LockScreen"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.alarm_notf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TimeText As Label
    Friend WithEvents DateText As Label
    Friend WithEvents OLS As Timer
    Friend WithEvents TADT As Timer
    Friend WithEvents CLS As Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents alarm_notf As System.Windows.Forms.PictureBox
End Class
