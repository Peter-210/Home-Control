Public Class WindowBlindForm
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles BackBtn.GotFocus, BedBtn.GotFocus, LivingBtn.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles BackBtn.LostFocus, BedBtn.LostFocus, LivingBtn.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click, BedBtn.Click, LivingBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
    End Sub
    Private Sub RoomButton_Click(sender As Object, e As EventArgs) Handles BedBtn.Click, LivingBtn.Click
        Dim roomSetting As New WindowBlindMode()
        roomSetting.Show()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
    End Sub
End Class