Public Class LightForm
    Dim AllRoomToggle As Boolean = False
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles BackBtn.GotFocus, AllRoomBtn.GotFocus, EntanceBtn.GotFocus, BathBtn.GotFocus, KitchenBtn.GotFocus, LivingBtn.GotFocus, BedBtn.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles BackBtn.LostFocus, AllRoomBtn.LostFocus, EntanceBtn.LostFocus, BathBtn.LostFocus, KitchenBtn.LostFocus, LivingBtn.LostFocus, BedBtn.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub RoomBtn_Click(sender As Object, e As EventArgs) Handles AllRoomBtn.Click, EntanceBtn.Click, BathBtn.Click, KitchenBtn.Click, LivingBtn.Click, BedBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()

        Select Case sender.Text
            Case "Entrance Hallway"
                If PictureBox16.Visible Then
                    PictureBox16.Visible = False
                Else
                    PictureBox16.Visible = True
                End If
            Case "Bathroom"
                If PictureBox15.Visible Then
                    PictureBox15.Visible = False
                Else
                    PictureBox15.Visible = True
                End If
            Case "Kitchen"
                If PictureBox14.Visible Then
                    PictureBox14.Visible = False
                Else
                    PictureBox14.Visible = True
                End If
            Case "Living Room"
                If PictureBox13.Visible Then
                    PictureBox13.Visible = False
                Else
                    PictureBox13.Visible = True
                End If
            Case "Bedroom"
                If PictureBox12.Visible Then
                    PictureBox12.Visible = False
                Else
                    PictureBox12.Visible = True
                End If
            Case Else
                If AllRoomToggle Then
                    PictureBox12.Visible = False
                    PictureBox13.Visible = False
                    PictureBox14.Visible = False
                    PictureBox15.Visible = False
                    PictureBox16.Visible = False
                    AllRoomToggle = False
                Else
                    PictureBox12.Visible = True
                    PictureBox13.Visible = True
                    PictureBox14.Visible = True
                    PictureBox15.Visible = True
                    PictureBox16.Visible = True
                    AllRoomToggle = True
                End If
        End Select
    End Sub
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Close()
    End Sub
End Class