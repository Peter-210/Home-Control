Public Class HomeControl
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles BackButton.GotFocus, HVACButton.GotFocus, LightWindowBlindButton.GotFocus, VacuumButton.GotFocus, ScheduleControlsButton.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles BackButton.LostFocus, HVACButton.LostFocus, LightWindowBlindButton.LostFocus, VacuumButton.LostFocus, ScheduleControlsButton.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub

    Private Sub HVACButton_Click(sender As Object, e As EventArgs) Handles HVACButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim temperature As New Temperature()
        temperature.Show()
    End Sub

    Private Sub LightWindowBlindButton_Click(sender As Object, e As EventArgs) Handles LightWindowBlindButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim lightsAndWindowsBlinds As New LightsAndWindowsBlinds()
        lightsAndWindowsBlinds.Show()
    End Sub
End Class