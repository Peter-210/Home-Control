Public Class Activities
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub

    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles BackButton.GotFocus, Button1.GotFocus, Button2.GotFocus, Button3.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles BackButton.LostFocus, Button1.LostFocus, Button2.LostFocus, Button3.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
End Class