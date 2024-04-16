Public Class Urgency
    Private Sub Minor_Click(sender As Object, e As EventArgs) Handles Minor.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim NewWindow As New Alert
        NewWindow.Show()
    End Sub

    Private Sub Necessary_Click(sender As Object, e As EventArgs) Handles Necessary.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Dim NewWindow As New Alert
        NewWindow.Show()
    End Sub

    Private Sub Urgent_Click(sender As Object, e As EventArgs) Handles Urgent.Click
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

    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles Back.GotFocus, Minor.GotFocus, Necessary.GotFocus, Urgent.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub
    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles Back.LostFocus, Minor.LostFocus, Necessary.LostFocus, Urgent.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub

End Class