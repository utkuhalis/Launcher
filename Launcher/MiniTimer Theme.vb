#Region " Imports "

Imports System.Drawing.Drawing2D
Imports System.ComponentModel

#End Region

'|------DO-NOT-REMOVE------|
'
' Creator: HazelDev
' Site   : HazelDev.com
' Created: 13.Oct.2014
' Changed: 15.Oct.2014
' Version: 1.0.0
'
'|------DO-NOT-REMOVE------|

#Region " ThemeContainer "

Class MiniTimer_ThemeContainer
    Inherits ContainerControl

#Region " Enums "

    Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
        Block = 3
    End Enum

#End Region
#Region " Variables "

    Private HeaderRect As Rectangle
    Protected State As MouseState
    Private MoveHeight As Integer
    Private MouseP As Point = New Point(0, 0)
    Private Cap As Boolean = False
    Private HasShown As Boolean

#End Region
#Region " Properties "

    Private _Sizable As Boolean = True
    Property Sizable() As Boolean
        Get
            Return _Sizable
        End Get
        Set(ByVal value As Boolean)
            _Sizable = value
        End Set
    End Property

    Private _SmartBounds As Boolean = True
    Property SmartBounds() As Boolean
        Get
            Return _SmartBounds
        End Get
        Set(ByVal value As Boolean)
            _SmartBounds = value
        End Set
    End Property

    Private _RoundCorners As Boolean = True
    Property RoundCorners() As Boolean
        Get
            Return _RoundCorners
        End Get
        Set(ByVal value As Boolean)
            _RoundCorners = value
            Invalidate()
        End Set
    End Property

    Private _IsParentForm As Boolean
    Protected ReadOnly Property IsParentForm As Boolean
        Get
            Return _IsParentForm
        End Get
    End Property

    Protected ReadOnly Property IsParentMdi As Boolean
        Get
            If Parent Is Nothing Then Return False
            Return Parent.Parent IsNot Nothing
        End Get
    End Property

    Private _ControlMode As Boolean
    Protected Property ControlMode() As Boolean
        Get
            Return _ControlMode
        End Get
        Set(ByVal v As Boolean)
            _ControlMode = v
            Invalidate()
        End Set
    End Property

    Private _StartPosition As FormStartPosition
    Property StartPosition As FormStartPosition
        Get
            If _IsParentForm AndAlso Not _ControlMode Then Return ParentForm.StartPosition Else Return _StartPosition
        End Get
        Set(ByVal value As FormStartPosition)
            _StartPosition = value

            If _IsParentForm AndAlso Not _ControlMode Then
                ParentForm.StartPosition = value
            End If
        End Set
    End Property

#End Region
#Region " EventArgs "

    Protected NotOverridable Overrides Sub OnParentChanged(ByVal e As EventArgs)
        MyBase.OnParentChanged(e)

        If Parent Is Nothing Then Return
        _IsParentForm = TypeOf Parent Is Form

        If Not _ControlMode Then
            InitializeMessages()

            If _IsParentForm Then
                Me.ParentForm.FormBorderStyle = FormBorderStyle.None
                Me.ParentForm.TransparencyKey = Color.Fuchsia

                If Not DesignMode Then
                    AddHandler ParentForm.Shown, AddressOf FormShown
                End If
            End If
            Parent.BackColor = BackColor
            Parent.MinimumSize = New Size(261, 65)
        End If
    End Sub

    Protected NotOverridable Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        If Not _ControlMode Then HeaderRect = New Rectangle(0, 0, Width - 14, MoveHeight - 7)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = Windows.Forms.MouseButtons.Left Then SetState(MouseState.Down)
        If Not (_IsParentForm AndAlso ParentForm.WindowState = FormWindowState.Maximized OrElse _ControlMode) Then
            If HeaderRect.Contains(e.Location) Then
                Capture = False
                WM_LMBUTTONDOWN = True
                DefWndProc(Messages(0))
            ElseIf _Sizable AndAlso Not Previous = 0 Then
                Capture = False
                WM_LMBUTTONDOWN = True
                DefWndProc(Messages(Previous))
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        Cap = False
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        If Not (_IsParentForm AndAlso ParentForm.WindowState = FormWindowState.Maximized) Then
            If _Sizable AndAlso Not _ControlMode Then InvalidateMouse()
        End If
        If Cap Then
            Parent.Location = MousePosition - MouseP
        End If
    End Sub

    Protected Overrides Sub OnInvalidated(ByVal e As System.Windows.Forms.InvalidateEventArgs)
        MyBase.OnInvalidated(e)
        ParentForm.Text = Text
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        MyBase.OnPaintBackground(e)
    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub

    Private Sub FormShown(ByVal sender As Object, ByVal e As EventArgs)
        If _ControlMode OrElse HasShown Then Return

        If _StartPosition = FormStartPosition.CenterParent OrElse _StartPosition = FormStartPosition.CenterScreen Then
            Dim SB As Rectangle = Screen.PrimaryScreen.Bounds
            Dim CB As Rectangle = ParentForm.Bounds
            ParentForm.Location = New Point(SB.Width \ 2 - CB.Width \ 2, SB.Height \ 2 - CB.Width \ 2)
        End If
        HasShown = True
    End Sub

#End Region
#Region " Mouse & Size "

    Private Sub SetState(ByVal current As MouseState)
        State = current
        Invalidate()
    End Sub

    Private GetIndexPoint As Point
    Private B1x, B2x, B3, B4 As Boolean
    Private Function GetIndex() As Integer
        GetIndexPoint = PointToClient(MousePosition)
        B1x = GetIndexPoint.X < 7
        B2x = GetIndexPoint.X > Width - 7
        B3 = GetIndexPoint.Y < 7
        B4 = GetIndexPoint.Y > Height - 7

        If B1x AndAlso B3 Then Return 4
        If B1x AndAlso B4 Then Return 7
        If B2x AndAlso B3 Then Return 5
        If B2x AndAlso B4 Then Return 8
        If B1x Then Return 1
        If B2x Then Return 2
        If B3 Then Return 3
        If B4 Then Return 6
        Return 0
    End Function

    Private Current, Previous As Integer
    Private Sub InvalidateMouse()
        Current = GetIndex()
        If Current = Previous Then Return

        Previous = Current
        Select Case Previous
            Case 0
                Cursor = Cursors.Default
            Case 6
                Cursor = Cursors.SizeNS
            Case 8
                Cursor = Cursors.SizeNWSE
            Case 7
                Cursor = Cursors.SizeNESW
        End Select
    End Sub

    Private Messages(8) As Message
    Private Sub InitializeMessages()
        Messages(0) = Message.Create(Parent.Handle, 161, New IntPtr(2), IntPtr.Zero)
        For I As Integer = 1 To 8
            Messages(I) = Message.Create(Parent.Handle, 161, New IntPtr(I + 9), IntPtr.Zero)
        Next
    End Sub

    Private Sub CorrectBounds(ByVal bounds As Rectangle)
        If Parent.Width > bounds.Width Then Parent.Width = bounds.Width
        If Parent.Height > bounds.Height Then Parent.Height = bounds.Height

        Dim X As Integer = Parent.Location.X
        Dim Y As Integer = Parent.Location.Y

        If X < bounds.X Then X = bounds.X
        If Y < bounds.Y Then Y = bounds.Y

        Dim Width As Integer = bounds.X + bounds.Width
        Dim Height As Integer = bounds.Y + bounds.Height

        If X + Parent.Width > Width Then X = Width - Parent.Width
        If Y + Parent.Height > Height Then Y = Height - Parent.Height

        Parent.Location = New Point(X, Y)
    End Sub

    Private WM_LMBUTTONDOWN As Boolean
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If WM_LMBUTTONDOWN AndAlso m.Msg = 513 Then
            WM_LMBUTTONDOWN = False

            SetState(MouseState.Over)
            If Not _SmartBounds Then Return

            If IsParentMdi Then
                CorrectBounds(New Rectangle(Point.Empty, Parent.Parent.Size))
            Else
                CorrectBounds(Screen.FromControl(Parent).WorkingArea)
            End If
        End If
    End Sub

#End Region

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
    End Sub

    Sub New()
        SetStyle(DirectCast(139270, ControlStyles), True)
        BackColor = Color.White
        Padding = New Padding(20, 56, 20, 16)
        DoubleBuffered = True
        Dock = DockStyle.Fill
        MoveHeight = 48
        Font = New Font("Segoe UI", 9)
        _RoundCorners = False
        _Sizable = False
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim G As Graphics = e.Graphics
        G.Clear(Color.FromArgb(255, 255, 255))

        G.DrawRectangle(New Pen(Color.FromArgb(221, 221, 221)), New Rectangle(0, 0, Width - 1, Height - 1))

        G.FillRectangle(New LinearGradientBrush(New Point(0, 0), New Point(0, 39), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255)), New Rectangle(1, 1, Width - 2, 39))
        G.DrawLine(New Pen(Color.FromArgb(221, 221, 221)), 1, 41, Width - 2, 41)
        G.FillRectangle(New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(238, 238, 238), Color.FromArgb(238, 238, 238)), New Rectangle(1, Height - 42, Width - 2, 41))
        G.DrawLine(New Pen(Color.FromArgb(222, 222, 222)), 1, Height - 44, Width - 2, Height - 44)
        G.DrawLine(New Pen(Color.FromArgb(251, 251, 251)), 1, Height - 43, Width - 2, Height - 43)

        If _RoundCorners = True Then

            ' Draw Left upper corner
            G.FillRectangle(Brushes.Fuchsia, 0, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 1, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 2, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 3, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, 2, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, 3, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 1, 1, 1, 1)

            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), 1, 3, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), 1, 2, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), 2, 1, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), 3, 1, 1, 1)

            ' Draw right upper corner
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 2, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 3, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 4, 0, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 2, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 3, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 2, 1, 1, 1)

            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), Width - 2, 3, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), Width - 2, 2, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), Width - 3, 1, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), Width - 4, 1, 1, 1)

            ' Draw Left bottom corner
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 2, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 3, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 4, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 2, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 3, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 2, 1, 1)

            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), 1, Height - 3, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), 1, Height - 4, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), 3, Height - 2, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), 2, Height - 2, 1, 1)

            ' Draw right bottom corner
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 3, Height, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 4, Height, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 2, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 3, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 3, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 4, Height - 1, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 4, 1, 1)
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 2, 1, 1)

            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), Width - 2, Height - 3, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), Width - 2, Height - 4, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), Width - 4, Height - 2, 1, 1)
            G.FillRectangle(New SolidBrush(Color.FromArgb(221, 221, 221)), Width - 3, Height - 2, 1, 1)
        End If

        G.DrawString(Text, New Font("Tahoma", 10.5, FontStyle.Bold), New SolidBrush(Color.FromArgb(129, 151, 172)), New Rectangle(0, 12, Width - 12, Height), New StringFormat() With {.Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Near})
    End Sub
End Class

#End Region
#Region " ControlBox "

Public Class MiniTimer_ControlBox
    Inherits Control

#Region " Enums "

    Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
    End Enum

#End Region
#Region " MouseStates "
    Dim State As MouseState = MouseState.None
    Dim X As Integer
    Dim CloseBtn As New Rectangle(3, 2, 11, 11)
    Dim MinBtn As New Rectangle(23, 2, 11, 11)
    Dim MaxBtn As New Rectangle(43, 2, 11, 11)

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)

        State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        If X > 3 AndAlso X < 20 Then
            FindForm.Close()
            'FrmMain.Opacity2.Enabled = True
            'FrmMain.Opacity1.Enabled = False
        ElseIf X > 23 AndAlso X < 40 Then
            FindForm.WindowState = FormWindowState.Minimized
        ElseIf X > 43 AndAlso X < 60 Then
            If _EnableMaximize = True Then
                If FindForm.WindowState = FormWindowState.Maximized Then
                    FindForm.WindowState = FormWindowState.Minimized
                    FindForm.WindowState = FormWindowState.Normal
                Else
                    FindForm.WindowState = FormWindowState.Minimized
                    FindForm.WindowState = FormWindowState.Maximized
                End If
            End If
        End If
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        X = e.Location.X
        Invalidate()
    End Sub
#End Region
#Region " Properties "

    Dim _EnableMaximize As Boolean = True
    Property EnableMaximize() As Boolean
        Get
            Return _EnableMaximize
        End Get
        Set(ByVal value As Boolean)
            _EnableMaximize = value
            If _EnableMaximize = True Then
                Me.Size = New Size(64, 22)
            Else
                Me.Size = New Size(40, 16)
            End If
            Invalidate()
        End Set
    End Property

#End Region

    Sub New()
        SetStyle(ControlStyles.UserPaint Or _
          ControlStyles.SupportsTransparentBackColor Or _
          ControlStyles.ResizeRedraw Or _
          ControlStyles.DoubleBuffer, True)
        DoubleBuffered = True
        _EnableMaximize = False
        BackColor = Color.Transparent
        Font = New Font("Marlett", 7)
        Anchor = AnchorStyles.Top Or AnchorStyles.Left
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If _EnableMaximize = True Then
            Me.Size = New Size(58, 16)
        Else
            Me.Size = New Size(40, 16)
        End If
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        ' Auto-decide control location on the theme container
        Location = New Point(15, 13)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(B)

        MyBase.OnPaint(e)
        G.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim LGBClose As New LinearGradientBrush(CloseBtn, Color.FromArgb(219, 223, 226), Color.FromArgb(213, 217, 218), 90S)
        G.FillEllipse(LGBClose, CloseBtn)
        G.DrawEllipse(New Pen(Color.FromArgb(196, 200, 203)), CloseBtn)

        Dim LGBMinimize As New LinearGradientBrush(MinBtn, Color.FromArgb(219, 223, 226), Color.FromArgb(213, 217, 218), 90S)
        G.FillEllipse(LGBMinimize, MinBtn)
        G.DrawEllipse(New Pen(Color.FromArgb(196, 200, 203)), MinBtn)

        If _EnableMaximize = True Then
            Dim LGBMaximize As New LinearGradientBrush(MaxBtn, Color.FromArgb(219, 223, 226), Color.FromArgb(213, 217, 218), 90S)
            G.FillEllipse(LGBMaximize, MaxBtn)
            G.DrawEllipse(New Pen(Color.FromArgb(196, 200, 203)), MaxBtn)
        End If

        Select Case State
            Case MouseState.None
                Dim xLGBClose As New LinearGradientBrush(CloseBtn, Color.FromArgb(219, 223, 226), Color.FromArgb(213, 217, 218), 90S)
                G.FillEllipse(xLGBClose, CloseBtn)
                G.DrawEllipse(New Pen(Color.FromArgb(196, 200, 203)), CloseBtn)

                Dim xLGBMinimize As New LinearGradientBrush(MinBtn, Color.FromArgb(219, 223, 226), Color.FromArgb(213, 217, 218), 90S)
                G.FillEllipse(xLGBMinimize, MinBtn)
                G.DrawEllipse(New Pen(Color.FromArgb(196, 200, 203)), MinBtn)

                If _EnableMaximize = True Then
                    Dim xLGBMaximize As New LinearGradientBrush(MaxBtn, Color.FromArgb(219, 223, 226), Color.FromArgb(213, 217, 218), 90S)
                    G.FillEllipse(xLGBMaximize, MaxBtn)
                    G.DrawEllipse(New Pen(Color.FromArgb(196, 200, 203)), MaxBtn)
                End If
            Case MouseState.Over
                If X > 3 AndAlso X < 20 Then
                    Dim xLGBClose As New LinearGradientBrush(CloseBtn, Color.FromArgb(210, 101, 104), Color.FromArgb(210, 101, 104), 90S)
                    G.FillEllipse(xLGBClose, CloseBtn)
                    G.DrawEllipse(New Pen(Color.FromArgb(210, 101, 104)), CloseBtn)
                ElseIf X > 23 AndAlso X < 40 Then
                    Dim xLGBMinimize As New LinearGradientBrush(MinBtn, Color.FromArgb(129, 151, 172), Color.FromArgb(129, 151, 172), 90S)
                    G.FillEllipse(xLGBMinimize, MinBtn)
                    G.DrawEllipse(New Pen(Color.FromArgb(129, 151, 172)), MinBtn)
                ElseIf X > 43 AndAlso X < 60 Then
                    If _EnableMaximize = True Then
                        Dim xLGBMaximize As New LinearGradientBrush(MaxBtn, Color.FromArgb(173, 173, 173), Color.FromArgb(173, 173, 173), 90S)
                        G.FillEllipse(xLGBMaximize, MaxBtn)
                        G.DrawEllipse(New Pen(Color.FromArgb(173, 173, 173)), MaxBtn)
                    End If
                End If
        End Select

        e.Graphics.DrawImage(B.Clone(), 0, 0)
        G.Dispose()
        B.Dispose()
    End Sub
End Class

#End Region
#Region " Label "

Class MiniTimer_Label
    Inherits Label

    Sub New()
        Font = New Font("Tahoma", 9.75, FontStyle.Regular)
        ForeColor = Color.FromArgb(136, 136, 136)
        BackColor = Color.Transparent
    End Sub
End Class

#End Region
#Region " Link Label "
Class MiniTimer_LinkLabel
    Inherits LinkLabel

    Sub New()
        Font = New Font("Tahoma", 9.75, FontStyle.Regular)
        BackColor = Color.Transparent
        LinkColor = Color.FromArgb(129, 151, 172)
        ActiveLinkColor = Color.FromArgb(109, 134, 158)
        VisitedLinkColor = Color.FromArgb(129, 151, 172)
        LinkBehavior = Windows.Forms.LinkBehavior.NeverUnderline
    End Sub
End Class

#End Region
#Region " Header Label "

Class MiniTimer_HeaderLabel
    Inherits Label

    Sub New()
        Font = New Font("Segoe UI", 20.25, FontStyle.Bold)
        ForeColor = Color.FromArgb(103, 103, 103)
        BackColor = Color.Transparent
    End Sub
End Class

#End Region
#Region " Button Base "

Class MiniTimer_ButtonBase
    Inherits ContainerControl

    Sub New()
        DoubleBuffered = True
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Size = New Size(116, 46)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        Dim G As Graphics = e.Graphics
        G.Clear(Color.FromArgb(255, 255, 255))

        G.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim LGB1 As New LinearGradientBrush(New Rectangle(0, 0, Width, Height), _
                                            Color.FromArgb(230, 230, 230), _
                                            Color.FromArgb(240, 240, 240), 90.0F)

        G.FillEllipse(LGB1, New Rectangle(0, 0, 44, 44))
        G.FillEllipse(LGB1, New Rectangle(35, 0, 44, 44))
        G.FillEllipse(LGB1, New Rectangle(70, 0, 44, 44))

        LGB1.Dispose()
    End Sub
End Class

#End Region
#Region " Button "

Class MiniTimer_Button_1
    Inherits Control

#Region " Variables "

    Private MouseState As Integer
    Private InactiveGB, PressedGB, PressedContourGB As LinearGradientBrush
    Private R1 As Rectangle
    Private P1, P3 As Pen
    Private _Image As Image
    Private _ImageSize As Size
    Private _ImageAlign As ContentAlignment = ContentAlignment.MiddleCenter

#End Region
#Region " Image Designer "

    Private Shared Function ImageLocation(ByVal SF As StringFormat, ByVal Area As SizeF, ByVal ImageArea As SizeF) As PointF
        Dim MyPoint As PointF
        Select Case SF.Alignment
            Case StringAlignment.Center
                MyPoint.X = CSng((Area.Width - ImageArea.Width) / 2)
            Case StringAlignment.Near
                MyPoint.X = 2
            Case StringAlignment.Far
                MyPoint.X = Area.Width - ImageArea.Width - 2

        End Select

        Select Case SF.LineAlignment
            Case StringAlignment.Center
                MyPoint.Y = CSng((Area.Height - ImageArea.Height) / 2)
            Case StringAlignment.Near
                MyPoint.Y = 2
            Case StringAlignment.Far
                MyPoint.Y = Area.Height - ImageArea.Height - 2
        End Select
        Return MyPoint
    End Function

    Private Function GetStringFormat(ByVal _ContentAlignment As ContentAlignment) As StringFormat
        Dim SF As StringFormat = New StringFormat()
        Select Case _ContentAlignment
            Case ContentAlignment.MiddleCenter
                SF.LineAlignment = StringAlignment.Center
                SF.Alignment = StringAlignment.Center
            Case ContentAlignment.MiddleLeft
                SF.LineAlignment = StringAlignment.Center
                SF.Alignment = StringAlignment.Near
            Case ContentAlignment.MiddleRight
                SF.LineAlignment = StringAlignment.Center
                SF.Alignment = StringAlignment.Far
            Case ContentAlignment.TopCenter
                SF.LineAlignment = StringAlignment.Near
                SF.Alignment = StringAlignment.Center
            Case ContentAlignment.TopLeft
                SF.LineAlignment = StringAlignment.Near
                SF.Alignment = StringAlignment.Near
            Case ContentAlignment.TopRight
                SF.LineAlignment = StringAlignment.Near
                SF.Alignment = StringAlignment.Far
            Case ContentAlignment.BottomCenter
                SF.LineAlignment = StringAlignment.Far
                SF.Alignment = StringAlignment.Center
            Case ContentAlignment.BottomLeft
                SF.LineAlignment = StringAlignment.Far
                SF.Alignment = StringAlignment.Near
            Case ContentAlignment.BottomRight
                SF.LineAlignment = StringAlignment.Far
                SF.Alignment = StringAlignment.Far
        End Select
        Return SF
    End Function

#End Region
#Region " Properties "

    Property Image() As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            If value Is Nothing Then
                _ImageSize = Size.Empty
            Else
                _ImageSize = value.Size
            End If

            _Image = value
            Invalidate()
        End Set
    End Property

    Protected ReadOnly Property ImageSize() As Size
        Get
            Return _ImageSize
        End Get
    End Property

    Public Property ImageAlign() As ContentAlignment
        Get
            Return _ImageAlign
        End Get
        Set(ByVal Value As ContentAlignment)
            _ImageAlign = Value
            Invalidate()
        End Set
    End Property

#End Region
#Region " EventArgs "

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        MouseState = 0
        Invalidate()
        MyBase.OnMouseUp(e)
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MouseState = 1
        Invalidate()
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MouseState = 0
        Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        Invalidate()
        MyBase.OnTextChanged(e)
    End Sub

#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or _
                 ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.ResizeRedraw Or _
                 ControlStyles.SupportsTransparentBackColor Or _
                 ControlStyles.UserPaint, True)

        BackColor = Color.Transparent
        DoubleBuffered = True
        Size = New Size(27, 27)
        P1 = New Pen(Color.FromArgb(190, 190, 190)) ' P1 = Border color
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Me.Size = New Size(27, 27)
        R1 = New Rectangle(0, 0, Width, Height)

        InactiveGB = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(255, 255, 255), Color.FromArgb(240, 240, 240), 90.0F)
        PressedGB = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(245, 245, 245), Color.FromArgb(240, 240, 240), 90.0F)
        PressedContourGB = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), Color.FromArgb(167, 167, 167), Color.FromArgb(167, 167, 167), 90.0F)
        P3 = New Pen(PressedContourGB)

        Invalidate()
        MyBase.OnResize(e)
    End Sub
    Private Sub FinishDrawing(ByRef g As Graphics, ByRef center As Point, ByVal radius As Integer)
        Dim MyCircle As New Rectangle(center.X / 2, center.Y / 2, radius * 2, radius * 2)
        Dim ImagePoint As PointF = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize)

        Select Case MouseState
            Case 0 'Inactive
                g.FillEllipse(InactiveGB, MyCircle)
                g.DrawEllipse(P1, MyCircle)

                If IsNothing(Image) Then
                Else
                    g.DrawImage(_Image, 5, 5, 16, 16)
                End If

            Case 1 'Pressed
                g.FillEllipse(PressedGB, MyCircle)
                g.DrawEllipse(P1, MyCircle)

                If IsNothing(Image) Then
                Else
                    g.DrawImage(_Image, 5, 5, 16, 16)
                End If
        End Select
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        With e.Graphics
            .SmoothingMode = SmoothingMode.HighQuality
            FinishDrawing(e.Graphics, New Point(0, 0), 13)
        End With
    End Sub
End Class

#End Region
#Region " NumericUpDown "

Class MiniTimer_NumericUpDown
    Inherits Control

#Region " Enums "

    Enum MouseState As Byte
        None = 0
        Over = 1
        Down = 2
    End Enum

#End Region
#Region " Variables "

    Friend G As Graphics, B As Bitmap
    Private Xval, Yval As Integer
    Private _Value, _Minimum, _Maximum As Long
    Private Flag As Boolean

#End Region
#Region " Properties "

    Public Property Value As Long
        Get
            Return _Value
        End Get
        Set(value As Long)
            If value <= _Maximum And value >= _Minimum Then _Value = value
            Invalidate()
        End Set
    End Property

    Public Property Minimum As Long
        Get
            Return _Minimum
        End Get
        Set(value As Long)
            If value < _Maximum Then _Minimum = value
            If _Value < _Minimum Then _Value = Minimum
            Invalidate()
        End Set
    End Property

    Public Property Maximum As Long
        Get
            Return _Maximum
        End Get
        Set(value As Long)
            If value > _Minimum Then _Maximum = value
            If _Value > _Maximum Then _Value = _Maximum
            Invalidate()
        End Set
    End Property

#End Region
#Region " EventArgs "

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        Xval = e.Location.X
        Yval = e.Location.Y
        Invalidate()
        If e.X < Width - 23 Then Cursor = Cursors.IBeam Else Cursor = Cursors.Hand
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If Xval > Width - 21 AndAlso Xval < Width - 3 Then
            If Yval < 15 Then
                If (Value + 1) <= _Maximum Then _Value += 1
            Else
                If (Value - 1) >= _Minimum Then _Value -= 1
            End If
        Else
            Flag = Not Flag
            Focus()
        End If
        Invalidate()
    End Sub
    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)
        Try
            If Flag Then _Value = CStr(CStr(_Value) & e.KeyChar.ToString())
            If _Value > _Maximum Then _Value = _Maximum
            Invalidate()
        Catch
        End Try
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Back Then
            Value = 0
        End If
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 27
    End Sub

#End Region

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
        ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
        ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 10)
        _Minimum = 0
        _Maximum = 100
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        B = New Bitmap(Width, Height)
        G = Graphics.FromImage(B)

        Dim CurrentRect As New Rectangle(0, 0, Width, Height)

        With G
            .SmoothingMode = 2
            .PixelOffsetMode = 2
            .TextRenderingHint = 5
            .Clear(BackColor)

            .FillRectangle(New SolidBrush(Color.White), CurrentRect)

            .DrawString("+", New Font("Tahoma", 9, FontStyle.Bold), New SolidBrush(Color.FromArgb(136, 136, 136)), New Point(Width - 11, 10), New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})
            .DrawString("-", New Font("Tahoma", 9, FontStyle.Bold), New SolidBrush(Color.FromArgb(136, 136, 136)), New Point(Width - 11, 20), New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})

            .DrawString(Value, Font, New SolidBrush(Color.FromArgb(136, 136, 136)), New Rectangle(5, 1, Width, Height), New StringFormat() With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})

        End With

        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub

End Class

#End Region