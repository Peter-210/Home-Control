Public Class WindowBlindMode
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles BackBtn.GotFocus, Button1.GotFocus, Button2.GotFocus, Button3.GotFocus, Button4.GotFocus, Button5.GotFocus, Button6.GotFocus, Button7.GotFocus, Button8.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub
    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles BackBtn.LostFocus, Button1.LostFocus, Button2.LostFocus, Button3.LostFocus, Button4.LostFocus, Button5.LostFocus, Button6.LostFocus, Button7.LostFocus, Button8.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
    End Sub
    Private Sub ModeBtn_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click

    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
    End Sub
End Class