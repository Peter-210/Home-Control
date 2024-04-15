Public Class Alert2
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles Back.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub
    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles Back.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text -= 1
        If (Label2.Text = 0) Then
            Me.Close()
            Dim NewWindow As New Confirmation
            Dim mysound As Media.SoundPlayer
            mysound = New Media.SoundPlayer(My.Resources.mixkit_cartoon_door_melodic_bell_110)
            mysound.Play()
            NewWindow.Show()
        End If
    End Sub
End Class