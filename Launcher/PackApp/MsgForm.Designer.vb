<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgForm
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
        Me.MsgBox = New Launcher.MiniTimer_ThemeContainer()
        Me.MsgText = New Launcher.MiniTimer_Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MsgBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MsgBox
        '
        Me.MsgBox.BackColor = System.Drawing.Color.White
        Me.MsgBox.Controls.Add(Me.MsgText)
        Me.MsgBox.Controls.Add(Me.Button2)
        Me.MsgBox.Controls.Add(Me.Button1)
        Me.MsgBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MsgBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MsgBox.Location = New System.Drawing.Point(0, 0)
        Me.MsgBox.Name = "MsgBox"
        Me.MsgBox.Padding = New System.Windows.Forms.Padding(20, 56, 20, 16)
        Me.MsgBox.RoundCorners = False
        Me.MsgBox.Sizable = False
        Me.MsgBox.Size = New System.Drawing.Size(415, 150)
        Me.MsgBox.SmartBounds = True
        Me.MsgBox.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MsgBox.TabIndex = 0
        Me.MsgBox.Text = "MessageBox"
        '
        'MsgText
        '
        Me.MsgText.AutoSize = True
        Me.MsgText.BackColor = System.Drawing.Color.Transparent
        Me.MsgText.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.MsgText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.MsgText.Location = New System.Drawing.Point(12, 56)
        Me.MsgText.Name = "MsgText"
        Me.MsgText.Size = New System.Drawing.Size(83, 16)
        Me.MsgText.TabIndex = 9
        Me.MsgText.Text = "MessageText"
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
        Me.Button1.Location = New System.Drawing.Point(328, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Tamam"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MsgForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 150)
        Me.Controls.Add(Me.MsgBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(261, 65)
        Me.Name = "MsgForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessageBox"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MsgBox.ResumeLayout(False)
        Me.MsgBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MsgBox As MiniTimer_ThemeContainer
    Friend WithEvents MsgText As MiniTimer_Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
