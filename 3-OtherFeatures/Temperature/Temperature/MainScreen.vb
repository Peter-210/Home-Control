Imports System.Runtime.InteropServices

Public Class MainScreen
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim TempScreen As New Temperature()
        TempScreen.Show()
    End Sub
End Class
