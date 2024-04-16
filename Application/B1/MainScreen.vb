Imports System.Threading

Public Class MainScreen
    Private TargetDT As DateTime
    Private CountDownFrom As TimeSpan = TimeSpan.FromMinutes(0.1)

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = 500
        TargetDT = DateTime.Now.Add(CountDownFrom)
        Timer2.Start()
    End Sub

    Private Sub tmrCountdown_Tick(sender As Object, e As System.EventArgs) Handles Timer2.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If Not ts.TotalMilliseconds > 0 Then
            Timer2.Stop()
            'Dim randomDoorBell As New DoorBell
            'randomDoorBell.Show()
        End If
    End Sub

    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles HomeButton.GotFocus, ElevatorButton.GotFocus, WheelchairButton.GotFocus, CommunicationButton.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles HomeButton.LostFocus, ElevatorButton.LostFocus, WheelchairButton.LostFocus, CommunicationButton.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim myHome As New MyHome()
        myHome.Show()
    End Sub

    Private Sub ElevatorButton_Click(sender As Object, e As EventArgs) Handles ElevatorButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim elevator As New Elevator()
        elevator.Show()
    End Sub

    Private Sub CommunicationButton_Click(sender As Object, e As EventArgs) Handles CommunicationButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim communication As New CallAssistance.Communication()
        communication.Show()
    End Sub
End Class