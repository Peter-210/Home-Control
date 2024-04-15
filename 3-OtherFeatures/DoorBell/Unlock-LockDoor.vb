Public Class Unlock_LockDoor
    Private Sub Unlock_LockDoor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub doorTimer_Tick(sender As Object, e As EventArgs) Handles doorTimer.Tick
        doorStatusBox.BackgroundImage = My.Resources.outgoing_door_closed_icon
        closeWindowTimer.Start()
    End Sub

    Private Sub lockTimer_Tick(sender As Object, e As EventArgs) Handles lockTimer.Tick
        doorStatusBox2.BackgroundImage = My.Resources.locked_icon
    End Sub

    Private Sub doorStatusTimer_Tick(sender As Object, e As EventArgs) Handles doorStatusTimer.Tick
        doorStatusLabel.Text = "Door is now Locked!"
    End Sub

    Private Sub guestStatusTimer_Tick(sender As Object, e As EventArgs) Handles guestStatusTimer.Tick
        guestStatusLabel.Text = "Guest has entered!"
        guestStatusLabel.AutoSize = False
        guestStatusLabel.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub pendingTimer_Tick(sender As Object, e As EventArgs) Handles pendingTimer.Tick
        pendingBox.Image = My.Resources.outgoing_doorbell_accept
        pendingBox.Location = New Point(380, 672)
    End Sub

    Private Sub closeWindowTimer_Tick(sender As Object, e As EventArgs) Handles closeWindowTimer.Tick
        Me.Close()
    End Sub
End Class