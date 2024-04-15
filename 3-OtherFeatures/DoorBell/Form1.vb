Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub EnterHomeControlApp(sender As Object, e As EventArgs) Handles HomeControlAppIcon.Click
        DummyDockBar.Dispose()
        DummyIconText.Dispose()
        DummyIconSafari.Dispose()
        DummyIconSettings.Dispose()

        HomeControlAppIcon.Dispose()

        'BackgroundImage = Image.FromFile("C:\Users\tomto\source\repos\CPS613-HCI\project-1\B1-HOME-CONTROL\assets\ipad-white.jpg")

        ' 1) Make a new user control form (Project > Add New Item... > User Control (Windows Forms))
        ' 2) Add the Dim myvariable as New controlformname
        ' 3) Controls.Add(myvariable)
        Dim mainscreen As New MainScreen
        Controls.Add(mainscreen)


        'DoorBell.Show()
        OutgoingDoorbell.Show()
    End Sub


End Class
