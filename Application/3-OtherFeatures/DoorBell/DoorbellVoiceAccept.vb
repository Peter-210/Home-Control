Public Class DoorbellVoiceAccept
    Private Sub DoorbellVoiceAccept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btn_1(sender As Object, e As EventArgs) Handles btn1.Click
        Unlock_LockDoor.Show()
        Me.Close()
    End Sub

    Private Sub btn_2(sender As Object, e As EventArgs) Handles btn2.Click
        Unlock_LockDoor.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class