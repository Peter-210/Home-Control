Public Class ProgScreen
    Private prog As String = "Current Program: No Program"
    Public Property getProg As String
        Get
            Return prog
        End Get
        Set(ByVal value As String)
            prog = value
        End Set
    End Property
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles BackBtn.GotFocus, NoneBtn.GotFocus, EcoBtn.GotFocus, SleepBtn.GotFocus, HomeBtn.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles BackBtn.LostFocus, NoneBtn.LostFocus, EcoBtn.LostFocus, SleepBtn.LostFocus, HomeBtn.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub ProgBtn_Click(sender As Object, e As EventArgs) Handles NoneBtn.Click, EcoBtn.Click, SleepBtn.Click, HomeBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        prog = "Current Program: " + sender.Text
        If sender.Equals(HomeBtn) Then
            Dim randomDoorBell As New DoorBell
            randomDoorBell.Show()
        End If

        Me.Hide()
    End Sub
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Hide()
    End Sub

    Private Sub ProgScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
