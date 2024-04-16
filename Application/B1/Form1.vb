Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each b As Button In Me.Controls.OfType(Of Button)
            AddHandler b.GotFocus, AddressOf HandleButtonGotFocus
            AddHandler b.LostFocus, AddressOf HandleButtonLostFocus

        Next
    End Sub





    Private Sub HandleButtonGotFocus(sender As Object, e As EventArgs)
        '''Selected Button Design
        sender.FlatStyle = FlatStyle.Flat
        'sender.ForeColor = Color.LemonChiffon
    End Sub
    Private Sub HandleButtonLostFocus(sender As Object, e As EventArgs)
        '''Deselected Button Design
        sender.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub TabCycle_Tick(sender As Object, e As EventArgs) Handles TabCycle.Tick
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()

        Dim mainscreen As New MainScreen()
        mainscreen.Show()
    End Sub
End Class
