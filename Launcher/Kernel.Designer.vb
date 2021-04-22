<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kernel
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
        Me.WorkID = New System.Windows.Forms.Label()
        Me.Work = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'WorkID
        '
        Me.WorkID.AutoSize = True
        Me.WorkID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkID.ForeColor = System.Drawing.Color.White
        Me.WorkID.Location = New System.Drawing.Point(12, 9)
        Me.WorkID.Name = "WorkID"
        Me.WorkID.Size = New System.Drawing.Size(14, 15)
        Me.WorkID.TabIndex = 0
        Me.WorkID.Text = "0"
        Me.WorkID.Visible = False
        '
        'Work
        '
        Me.Work.Enabled = True
        Me.Work.Interval = 1
        '
        'Kernel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(233, 140)
        Me.ControlBox = False
        Me.Controls.Add(Me.WorkID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Kernel"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WorkID As Label
    Friend WithEvents Work As Timer
End Class
