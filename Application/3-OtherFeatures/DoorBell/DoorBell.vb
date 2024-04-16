Public Class DoorBell

    Private Sub VoiceAccept_Click(sender As Object, e As EventArgs) Handles VoiceAccept.Click
        DoorbellVoiceAccept.Show()
    End Sub

    Private Sub VoiceReject_Click(sender As Object, e As EventArgs) Handles VoiceReject.Click
        DoorbellVoiceReject.Show()
    End Sub

    Private Sub MessageAccept_Click(sender As Object, e As EventArgs) Handles MessageAccept.Click
        DoorbellMessageAccept.Show()
    End Sub

    Private Sub MessageReject_Click(sender As Object, e As EventArgs) Handles MessageReject.Click
        DoorbellMessageReject.Show()
    End Sub

    Private Sub DoorBell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim mySound As Media.SoundPlayer
        mySound = New Media.SoundPlayer(My.Resources.Door_Bell_Sound_Effect__128_kbps_)
        mySound.Play()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class