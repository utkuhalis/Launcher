<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rename
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
        Me.MiniTimer_ThemeContainer1 = New Launcher.MiniTimer_ThemeContainer()
        Me.TxtBox1 = New Launcher.TxtBox()
        Me.MiniTimer_Label1 = New Launcher.MiniTimer_Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MiniTimer_ThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MiniTimer_ThemeContainer1
        '
        Me.MiniTimer_ThemeContainer1.BackColor = System.Drawing.Color.White
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.TxtBox1)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.MiniTimer_Label1)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.Button2)
        Me.MiniTimer_ThemeContainer1.Controls.Add(Me.Button1)
        Me.MiniTimer_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MiniTimer_ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MiniTimer_ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.MiniTimer_ThemeContainer1.Name = "MiniTimer_ThemeContainer1"
        Me.MiniTimer_ThemeContainer1.Padding = New System.Windows.Forms.Padding(20, 56, 20, 16)
        Me.MiniTimer_ThemeContainer1.RoundCorners = False
        Me.MiniTimer_ThemeContainer1.Sizable = False
        Me.MiniTimer_ThemeContainer1.Size = New System.Drawing.Size(415, 150)
        Me.MiniTimer_ThemeContainer1.SmartBounds = True
        Me.MiniTimer_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MiniTimer_ThemeContainer1.TabIndex = 0
        Me.MiniTimer_ThemeContainer1.Text = "Yeniden Adlandır"
        '
        'TxtBox1
        '
        Me.TxtBox1.BackColor = System.Drawing.Color.White
        Me.TxtBox1.Image = Nothing
        Me.TxtBox1.Location = New System.Drawing.Point(12, 66)
        Me.TxtBox1.MaxLength = 32767
        Me.TxtBox1.Name = "TxtBox1"
        Me.TxtBox1.NoRounding = False
        Me.TxtBox1.Size = New System.Drawing.Size(392, 31)
        Me.TxtBox1.TabIndex = 10
        Me.TxtBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtBox1.UseSystemPasswordChar = False
        '
        'MiniTimer_Label1
        '
        Me.MiniTimer_Label1.AutoSize = True
        Me.MiniTimer_Label1.BackColor = System.Drawing.Color.Transparent
        Me.MiniTimer_Label1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.MiniTimer_Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.MiniTimer_Label1.Location = New System.Drawing.Point(9, 47)
        Me.MiniTimer_Label1.Name = "MiniTimer_Label1"
        Me.MiniTimer_Label1.Size = New System.Drawing.Size(60, 16)
        Me.MiniTimer_Label1.TabIndex = 9
        Me.MiniTimer_Label1.Text = "Yeni İsim"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "İptal"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(329, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Tamam"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Rename
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 150)
        Me.Controls.Add(Me.MiniTimer_ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(261, 65)
        Me.Name = "Rename"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yeniden Adlandır"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MiniTimer_ThemeContainer1.ResumeLayout(False)
        Me.MiniTimer_ThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MiniTimer_ThemeContainer1 As MiniTimer_ThemeContainer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtBox1 As TxtBox
    Friend WithEvents MiniTimer_Label1 As MiniTimer_Label
End Class
