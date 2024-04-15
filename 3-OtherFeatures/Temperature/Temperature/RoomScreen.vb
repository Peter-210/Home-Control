Public Class RoomScreen
    Private room As String = "All Rooms"
    Private statusSave As New Dictionary(Of String, Integer) From {{"All Rooms", 25}, {"Living Room", 25}, {"Bedroom", 25}, {"Kitchen", 25}, {"Bathroom", 25}}
    Public Property getRoom As String
        Get
            Return room
        End Get
        Set(ByVal value As String)
            room = value
        End Set
    End Property
    Public Property getAll As Integer
        Get
            Return statusSave.Item("All Rooms")
        End Get
        Set(ByVal value As Integer)
            statusSave.Item("All Rooms") = value
        End Set
    End Property
    Public Property getLiving As Integer
        Get
            Return statusSave.Item("Living Room")
        End Get
        Set(ByVal value As Integer)
            statusSave.Item("Living Room") = value
        End Set
    End Property
    Public Property getBed As Integer
        Get
            Return statusSave.Item("Bedroom")
        End Get
        Set(ByVal value As Integer)
            statusSave.Item("Bedroom") = value
        End Set
    End Property
    Public Property getKitchen As Integer
        Get
            Return statusSave.Item("Kitchen")
        End Get
        Set(ByVal value As Integer)
            statusSave.Item("Kitchen") = value
        End Set
    End Property
    Public Property getBath As Integer
        Get
            Return statusSave.Item("Bathroom")
        End Get
        Set(ByVal value As Integer)
            statusSave.Item("Bathroom") = value
        End Set
    End Property
    Private Sub HandleButton_GotFocus(sender As Object, e As EventArgs) Handles BackBtn.GotFocus, AllRoomBtn.GotFocus, BedBtn.GotFocus, BathBtn.GotFocus, KitchenBtn.GotFocus, LivingBtn.GotFocus
        sender.FlatStyle = FlatStyle.Flat
        sender.FlatAppearance.BorderColor = Color.Blue
        sender.FlatAppearance.BorderSize = 10
    End Sub

    Private Sub HandleButton_LostFocus(sender As Object, e As EventArgs) Handles BackBtn.LostFocus, AllRoomBtn.LostFocus, BedBtn.LostFocus, BathBtn.LostFocus, KitchenBtn.LostFocus, LivingBtn.LostFocus
        sender.FlatStyle = FlatStyle.Standard
    End Sub
    Private Sub RoomBtn_Click(sender As Object, e As EventArgs) Handles AllRoomBtn.Click, BedBtn.Click, BathBtn.Click, KitchenBtn.Click, LivingBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        room = sender.Text
        Me.Hide()
    End Sub
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim mysound As Media.SoundPlayer
        mysound = New Media.SoundPlayer(My.Resources.mixkit_hard_pop_click_2364)
        mysound.Play()
        Me.Hide()
    End Sub
End Class
