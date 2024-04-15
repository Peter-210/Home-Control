Public Class OutgoingDoorbell
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OurgoingDoorResponse.Show()
        Dim mySound As Media.SoundPlayer
        mySound = New Media.SoundPlayer(My.Resources.Door_Bell_Sound_Effect__128_kbps_)
        mySound.Play()
    End Sub

    Private Sub OutgoingDoorbell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()
    End Sub
End Class