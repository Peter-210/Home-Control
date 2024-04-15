Imports System.Runtime.InteropServices

Public Class MainScreen
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ElevatorScreen As New Elevator()
        ElevatorScreen.Show()
    End Sub
End Class
