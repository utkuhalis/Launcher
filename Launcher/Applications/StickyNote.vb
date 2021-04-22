Public Class StickyNote
    Friend WithEvents NTitle As String
    Friend WithEvents NText As String
    Friend WithEvents NDate As String
    Friend WithEvents NBackground As String
    Friend WithEvents EditText As New TextBox
    Dim Save As New RichTextBox
    Dim RandomNumber As New Random
    Const i As Integer = &HA1
    Const j As Integer = 2

    Private Sub StickyNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Title.Text = NTitle
        Textt.Text = NText
        If NBackground = "Blue" Then
            Me.BackColor = Color.LightSteelBlue
        ElseIf NBackground = "Yellow" Then
            Me.BackColor = Color.LemonChiffon
        ElseIf NBackground = "Green" Then
            Me.BackColor = Color.LightGreen
        Else
            Dim SelectColor As Integer
            Dim RandomSelc As New Random()
            SelectColor = RandomSelc.Next(1, 4)
            Select Case SelectColor
                Case 1 : Me.BackColor = Color.LightSteelBlue
                Case 2 : Me.BackColor = Color.LemonChiffon
                Case 3 : Me.BackColor = Color.LightGreen
            End Select
            If SelectColor = 1 Then
                NBackground = "Blue"
            ElseIf SelectColor = 2 Then
                NBackground = "Yellow"
            ElseIf SelectColor = 3 Then
                NBackground = "Green"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Delete Note ?", MsgBoxStyle.YesNo, "StickyNote") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Title_MouseDown(sender As Object, e As MouseEventArgs) Handles Title.MouseDown
        Title.Capture = False
        Dim msg As Message = Message.Create(Me.Handle, i, New IntPtr(j), IntPtr.Zero)
        Me.DefWndProc(msg)
    End Sub

    Private Sub Textt_DoubleClick(sender As Object, e As EventArgs) Handles Textt.DoubleClick
        EditText.Text = Textt.Text
        EditText.Font = New Font("Bodoni MT", 9.0!)
        EditText.Multiline = True
        EditText.ForeColor = Color.Black
        EditText.BorderStyle = BorderStyle.None
        EditText.Size = Textt.Size
        EditText.Location = Textt.Location
        Textt.Visible = False
        Me.Controls.Add(EditText)
        Button3.Visible = True
    End Sub
    Dim durum As Integer = 1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If durum = 0 Then
            Save.Text = "[StickyNote]" & vbNewLine & "Title=" & NTitle & vbNewLine & "Text=" & NText & vbNewLine & "Date=" & Now.Date & vbNewLine & "Background=" & NBackground & vbNewLine & "Location=50,50"
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "/System/Storage/Notes/" & NTitle & ".note") = True Then
                MsgBox("Bu başlığa sahip not bulunmaktadır, lütfen başka bir başlık kullanınız.", MsgBoxStyle.Information, "Uyarı")
            Else
                Save.SaveFile(Application.StartupPath & "/System/Storage/Notes/" & NTitle & ".note", RichTextBoxStreamType.PlainText)
                durum = 1
            End If
        Else
            Textt.Text = EditText.Text
            Me.Controls.Remove(EditText)
            Textt.Visible = True
            Button3.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Settings.Visible = True Then
            Settings.Visible = False
            Title.Text = TextBox1.Text
            If ComboBox1.SelectedIndex = 0 Then
                Me.BackColor = Color.LightSteelBlue
            ElseIf ComboBox1.SelectedIndex = 1 Then
                Me.BackColor = Color.LemonChiffon
            ElseIf ComboBox1.SelectedIndex = 2 Then
                Me.BackColor = Color.LightGreen
            End If
        Else
            Settings.Visible = True
            TextBox1.Text = Title.Text
            If NBackground = "Blue" Then
                ComboBox1.SelectedIndex = 0
            ElseIf NBackground = "Yellow" Then
                ComboBox1.SelectedIndex = 1
            ElseIf NBackground = "Green" Then
                ComboBox1.SelectedIndex = 2
            End If
        End If
    End Sub
End Class