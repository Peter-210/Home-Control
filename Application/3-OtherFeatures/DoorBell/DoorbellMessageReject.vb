Public Class DoorbellMessageReject
    Private Sub DoorbellMessageReject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btn_1(sender As Object, e As EventArgs) Handles btn1.Click
        LockDoorS.Show()
        Me.Close()
    End Sub

    Private Sub btn_2(sender As Object, e As EventArgs) Handles btn2.Click
        LockDoorS.Show()
        Me.Close()
    End Sub

    Private Sub btn_3(sender As Object, e As EventArgs) Handles btn3.Click
        LockDoorS.Show()
        Me.Close()
    End Sub

    Private Sub btn_4(sender As Object, e As EventArgs) Handles btn4.Click
        LockDoorS.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class