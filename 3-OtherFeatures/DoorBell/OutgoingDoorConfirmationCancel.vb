﻿Public Class OutgoingDoorConfirmationCancel
    Private Sub OutgoingDoorConfirmationCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub closeWindow_Tick(sender As Object, e As EventArgs) Handles closeWindow.Tick
        Me.Close()
    End Sub
End Class