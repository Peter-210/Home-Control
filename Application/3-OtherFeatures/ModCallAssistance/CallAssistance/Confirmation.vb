Public Class Confirmation
    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub
End Class