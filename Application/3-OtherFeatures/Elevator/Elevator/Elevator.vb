Imports System.IO

Public Class Elevator
    Private defaultFloor As Integer
    Private defaultName As String = "Go To Home Floor"

    Private path As String = My.Application.Info.DirectoryPath
    Private path1 As String = path.Replace("\B1\bin\Debug\net6.0-windows", "\3-OtherFeatures\Elevator\Elevator\elevator-cache.txt")
    Private lines() As String = File.ReadAllLines(path1)

    Dim OverrideScreen As New OverrideFloor()

    Private Sub Elevator_Load(sender As Object, e As EventArgs) Handles Me.Load
        defaultFloor = 1
        OverrideScreen.getFloor = defaultFloor
        OverrideScreen.getFloorName = "1st"
        FloorLabel.Text = $"You are on the {File.ReadAllLines(path1).ElementAt(0).ToString} Floor"
        DefaultBtn.Text = defaultName
    End Sub
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles BackBtn.GotFocus, OverrideBtn.GotFocus, DefaultBtn.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles BackBtn.LostFocus, OverrideBtn.LostFocus, DefaultBtn.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub DefaultBtn_Click(sender As Object, e As EventArgs) Handles DefaultBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        If defaultFloor = 5 Then
            FloorLabel.Text = $"You are on the Ground (1st) Floor"
            defaultFloor = 1
            PictureBox3.Visible = False
        Else
            FloorLabel.Text = $"You are on the Home (5th) Floor"
            defaultFloor = 5
            PictureBox3.Visible = True
        End If
        OverrideScreen.getFloor = defaultFloor
    End Sub
    Private Sub OverrideBtn_Click(sender As Object, e As EventArgs) Handles OverrideBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        OverrideScreen.getFloor = defaultFloor
        OverrideScreen.Show()
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If defaultFloor = 5 Then
            defaultName = "Go To Ground Floor"
            PictureBox3.Visible = True
        Else
            defaultName = "Go To Home Floor"
            PictureBox3.Visible = False
        End If
        DefaultBtn.Text = defaultName

        If defaultFloor = OverrideScreen.getFloor Then Return
        defaultFloor = OverrideScreen.getFloor
        FloorLabel.Text = "You are on the " + CStr(OverrideScreen.getFloorName) + " Floor"
    End Sub
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        lines(0) = defaultFloor
        File.WriteAllLines(path1, lines)
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        OverrideScreen.Close()
        Me.Close()
    End Sub
End Class