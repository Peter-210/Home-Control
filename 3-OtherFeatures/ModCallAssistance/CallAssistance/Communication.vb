Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Public Class Communication

    Private Sub CallAssistance_Click(sender As Object, e As EventArgs) Handles CallAssistance.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim NewWindow As New ChooseIssue
        NewWindow.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Communication.StartScanning()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub

    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles Back.GotFocus, CallAssistance.GotFocus, Button2.GotFocus, Button3.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles Back.LostFocus, CallAssistance.LostFocus, Button2.LostFocus, Button3.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub

    'Private scanninglevel As Integer
    'Private focusIsOn As Integer

    ' Start scanning on the first submenu
    ' Public Sub StartScanning()
    '     scanninglevel = 0
    '     focusIsOn = 0
    '     ScanningTimer.Start()
    'End Sub
End Class

