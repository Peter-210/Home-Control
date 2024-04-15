Public Class SpecificRoom
    Private Sub SpecificRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LightRowBedroom.LightRowTitle.Text = "Bedroom"
        LightRowBathroom.LightRowTitle.Text = "Bathroom"
        LightRowLivingRoom.LightRowTitle.Text = "Living Room"
        LightRowEntranceHallway.LightRowTitle.Text = "Entrance Hallway"
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub
End Class