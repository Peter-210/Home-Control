Public Class SpecificRoomWindows
    Private Sub SpecificRoomWindows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowRowBedroom.WindowRowTitle.Text = "Bedroom"
        WindowRowBedroom.WindowSubMenuBlinds.BackColor = Color.FromArgb(134, 143, 68)
        WindowRowBedroom.WindowSubMenuWindows.BackColor = Color.FromArgb(134, 143, 68)

        WindowRowBathroom.WindowRowTitle.Text = "Bathroom"
        WindowRowBathroom.WindowSubMenuBlinds.BackColor = Color.FromArgb(178, 204, 207)
        WindowRowBathroom.WindowSubMenuWindows.Visible = False


        WindowRowLivingRoom.WindowRowTitle.Text = "Living Room"
        WindowRowLivingRoom.WindowSubMenuBlinds.BackColor = Color.FromArgb(54, 80, 96)
        WindowRowLivingRoom.WindowSubMenuWindows.BackColor = Color.FromArgb(54, 80, 96)

        WindowRowEntranceHallway.WindowRowTitle.Text = "Entrance Hallway"
        WindowRowEntranceHallway.WindowSubMenuBlinds.BackColor = Color.FromArgb(80, 88, 93)
        WindowRowEntranceHallway.WindowSubMenuWindows.BackColor = Color.FromArgb(80, 88, 93)
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub
End Class