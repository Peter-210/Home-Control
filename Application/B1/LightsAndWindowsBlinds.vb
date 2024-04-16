Public Class LightsAndWindowsBlinds
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles BackButton.GotFocus, LightButton.GotFocus, WindowBlindButton.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles BackButton.LostFocus, LightButton.LostFocus, WindowBlindButton.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub LightButton_Click(sender As Object, e As EventArgs) Handles LightButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim RoomLights As New LightForm()
        RoomLights.Show()
    End Sub
    Private Sub WindowsBlindsButton_Click(sender As Object, e As EventArgs) Handles WindowBlindButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim RoomWindows As New WindowBlindForm()
        RoomWindows.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub
End Class