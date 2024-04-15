Public Class ChooseIssue
    Private Sub RegularAssistance_Click(sender As Object, e As EventArgs) Handles RegularAssistance.Click, Button4.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim NewWindow As New Urgency
        NewWindow.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim NewWindow As New Alert
        NewWindow.Show()
    End Sub
    Private Sub MedicalEmergency_Click(sender As Object, e As EventArgs) Handles MedicalEmergency.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim NewWindow As New Alert2
        NewWindow.Show()
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles Back.GotFocus, MedicalEmergency.GotFocus, RegularAssistance.GotFocus, Button1.GotFocus, Button2.GotFocus, Button4.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub
    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles Back.LostFocus, MedicalEmergency.LostFocus, RegularAssistance.LostFocus, Button1.LostFocus, Button2.LostFocus, Button4.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
End Class