<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StickyNote
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.Textt = New System.Windows.Forms.Label()
        Me.Settings = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 28)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button3.Location = New System.Drawing.Point(3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "☺"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(196, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "☼"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(224, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(249, 28)
        Me.Title.TabIndex = 2
        Me.Title.Text = "StickyNote Title"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Textt
        '
        Me.Textt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Textt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Textt.Location = New System.Drawing.Point(0, 28)
        Me.Textt.Name = "Textt"
        Me.Textt.Size = New System.Drawing.Size(249, 168)
        Me.Textt.TabIndex = 1
        Me.Textt.Text = "Label2"
        '
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.Color.White
        Me.Settings.Controls.Add(Me.ComboBox1)
        Me.Settings.Controls.Add(Me.Label2)
        Me.Settings.Controls.Add(Me.TextBox1)
        Me.Settings.Controls.Add(Me.Label1)
        Me.Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Settings.Location = New System.Drawing.Point(0, 28)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(249, 168)
        Me.Settings.TabIndex = 2
        Me.Settings.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blue", "Yellow", "Green"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(211, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Note Background Color"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Note Title"
        '
        'StickyNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(249, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.Textt)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StickyNote"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Textt As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Settings As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
