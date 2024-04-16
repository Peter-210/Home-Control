Imports System.IO
Imports System.Windows.Forms.LinkLabel

Public Class Temperature
    Private room As String
    Private value As Integer
    Private changeValue As Integer
    Private prog As String

    Dim progscreen As New ProgScreen()
    Dim roomscreen As New RoomScreen()

    Private Sub Temperature_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim path As String = My.Application.Info.DirectoryPath
        Dim path1 As String = path.Replace("\B1\bin\Debug\net6.0-windows", "\3-OtherFeatures\Temperature\Temperature\temperature-cache.txt")

        'value = File.ReadAllLines(path1).ElementAt(4).ToString
        'changeValue = value
        'CurrentLabel.Text = CStr(value)
        'SetLabel.Text = CStr(changeValue)
    End Sub
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles UpBtn.GotFocus, DownBtn.GotFocus, RoomBtn.GotFocus, ProgBtn.GotFocus, BackBtn.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles UpBtn.LostFocus, DownBtn.LostFocus, RoomBtn.LostFocus, ProgBtn.LostFocus, BackBtn.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If changeValue > value Then
            value += 1
            CurrentLabel.Text = CStr(value)
        ElseIf changeValue < value Then
            value -= 1
            CurrentLabel.Text = CStr(value)
        End If
    End Sub
    Private Sub ValueChangeBtn_Click(sender As Object, e As EventArgs) Handles UpBtn.Click, DownBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        changeValue += sender.Tag
        SetLabel.Text = CStr(changeValue)
        progscreen.getProg = "Current Program: No Program"
        prog = progscreen.getProg
    End Sub
    Private Sub ValueLabel_TextChanged(sender As Object, e As EventArgs) Handles SetLabel.TextChanged
        If changeValue > value Then
            Timer.Enabled = True
            ActionLabel.Text = "Heating"
        ElseIf changeValue < value Then
            Timer.Enabled = True
            ActionLabel.Text = "Cooling"
        End If
    End Sub
    Private Sub CurrentLabel_TextChanged(sender As Object, e As EventArgs) Handles CurrentLabel.TextChanged
        If changeValue = value Then
            Timer.Enabled = False
            ActionLabel.Text = ""
        End If
    End Sub
    Private Sub CheckChange_Tick(sender As Object, e As EventArgs) Handles CheckChange.Tick
        room = roomscreen.getRoom
        prog = progscreen.getProg
        If room IsNot RoomLabel.Text Then RoomLabel.Text = room
        If prog IsNot ProgLabel.Text Then ProgLabel.Text = prog
    End Sub

    Private Sub ChangeCacheValues(criteria As String)
        Dim path As String = My.Application.Info.DirectoryPath
        Dim path1 As String = path.Replace("\B1\bin\Debug\net6.0-windows", "\3-OtherFeatures\Temperature\Temperature\temperature-cache.txt")
        Dim lines() As String = File.ReadAllLines(path1)

        Select Case criteria
            Case "Living Room"
                lines(0) = changeValue
                File.WriteAllLines(path1, lines)
            Case "Bedroom"
                lines(1) = changeValue
                File.WriteAllLines(path1, lines)
            Case "Kitchen"
                lines(2) = changeValue
                File.WriteAllLines(path1, lines)
            Case "Bathroom"
                lines(3) = changeValue
                File.WriteAllLines(path1, lines)
            Case Else
                lines(0) = changeValue
                File.WriteAllLines(path1, lines)
                lines(1) = changeValue
                File.WriteAllLines(path1, lines)
                lines(2) = changeValue
                File.WriteAllLines(path1, lines)
                lines(3) = changeValue
                File.WriteAllLines(path1, lines)
                lines(4) = changeValue
                File.WriteAllLines(path1, lines)
        End Select
    End Sub

    Private Sub RoomBtn_Click(sender As Object, e As EventArgs) Handles RoomBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        roomscreen.Show()

        ChangeCacheValues(room)
    End Sub
    Private Sub RoomLabel_TextChanged(sender As Object, e As EventArgs) Handles RoomLabel.TextChanged
        prog = "Current Program: No Program"
        Dim path As String = My.Application.Info.DirectoryPath
        Dim path1 As String = path.Replace("\B1\bin\Debug\net6.0-windows", "\3-OtherFeatures\Temperature\Temperature\temperature-cache.txt")
        Select Case room
            Case "Living Room"
                changeValue = File.ReadAllLines(path1).ElementAt(0).ToString
            Case "Bedroom"
                changeValue = File.ReadAllLines(path1).ElementAt(1).ToString
            Case "Kitchen"
                changeValue = File.ReadAllLines(path1).ElementAt(2).ToString
            Case "Bathroom"
                changeValue = File.ReadAllLines(path1).ElementAt(3).ToString
            Case Else
                changeValue = File.ReadAllLines(path1).ElementAt(4).ToString
        End Select
        value = changeValue
        SetLabel.Text = CStr(changeValue)
        CurrentLabel.Text = CStr(value)
        prog = "Current Program: No Program"
        ProgLabel.Text = prog
    End Sub
    Private Sub ProgBtn_Click(sender As Object, e As EventArgs) Handles ProgBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        progscreen.Show()
    End Sub

    Private Sub ProgLabel_TextChanged(sender As Object, e As EventArgs) Handles ProgLabel.TextChanged
        Select Case prog
            Case "Current Program: Sleep Mode"
                changeValue = 22
                SetLabel.Text = CStr(changeValue)
            Case "Current Program: Eco Mode"
                changeValue = value
                SetLabel.Text = CStr(changeValue)
            Case "Current Program: Away From Home"
                changeValue = value
                SetLabel.Text = CStr(changeValue)
            Case Else
        End Select
    End Sub
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ChangeCacheValues(RoomLabel.Text)

        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        progscreen.Close()
        roomscreen.Close()
        Me.Close()
    End Sub

End Class
