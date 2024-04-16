Public Class OverrideFloor
    Private defaultFloor As Integer
    Private defaultName As String
    Public Property getFloor() As Integer
        Get
            Return defaultFloor
        End Get
        Set(ByVal value As Integer)
            defaultFloor = value
        End Set
    End Property
    Public Property getFloorName() As String
        Get
            Return defaultName
        End Get
        Set(ByVal value As String)
            defaultName = value
        End Set
    End Property
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Select Case defaultFloor
            Case 1
                defaultName = "1st"
            Case 2
                defaultName = "2nd"
            Case 3
                defaultName = "3rd"
            Case 4
                defaultName = "4th"
            Case 5
                defaultName = "5th"
        End Select
        FloorLabel.Text = "You are on the " + defaultName + " Floor"
    End Sub
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles Floor1.GotFocus, Floor2.GotFocus, Floor3.GotFocus, Floor4.GotFocus, Floor5.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles Floor1.LostFocus, Floor2.LostFocus, Floor3.LostFocus, Floor4.LostFocus, Floor5.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub Floor_Click(sender As Object, e As EventArgs) Handles Floor1.Click, Floor2.Click, Floor3.Click, Floor4.Click, Floor5.Click
        defaultFloor = sender.Tag
        defaultName = sender.Text
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()

        'If sender.Equals(Floor3) Then
        'Dim doorbellOutgoing As New OutgoingDoorbell()
        'doorbellOutgoing.Show()
        'End If

        Me.Hide()
    End Sub
    Private Sub BackBtn_Click(sender As Object, e As EventArgs)
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Hide()
    End Sub
End Class