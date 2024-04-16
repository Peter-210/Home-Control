Public Class MyHome
    Private Sub Activities_Click(sender As Object, e As EventArgs) Handles Activities.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim activities As New Activities()
        activities.Show()
    End Sub

    Private Sub HomeControlButton_Click(sender As Object, e As EventArgs) Handles HomeControlButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim homeControl As New HomeControl()
        homeControl.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles BackButton.GotFocus, HomeControlButton.GotFocus, Activities.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles BackButton.LostFocus, HomeControlButton.LostFocus, Activities.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
End Class