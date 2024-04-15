Public Class WindowRow
    Private Sub WindowRow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowSubMenuWindows.WindowSubMenuTitle.Text = "Windows"

        WindowSubMenuBlinds.WindowSubMenuTitle.Text = "Blinds"
        WindowSubMenuBlinds.Label4.AutoSize = False
        WindowSubMenuBlinds.Label4.Text = "Fully Closed with Open Slats"
        WindowSubMenuBlinds.Label4.Location = New Point(124, 108)
        WindowSubMenuBlinds.Label4.Size = New Size(90, 37)

    End Sub

    Public Sub RemoveWindowSubMenus()
        WindowSubMenuWindows.Dispose()
        WindowSubMenuBlinds.Dispose()
    End Sub

End Class
