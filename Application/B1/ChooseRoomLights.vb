Public Class ChooseRoomLights
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs)
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs)
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub Btn_Click(sender As Object, e As EventArgs)
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
    End Sub
    Private Sub RoomButton_Click(sender As Object, e As EventArgs)
        'Dim lightSetting As New ChooseRoomWindows()
        'lightSetting.Show()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class