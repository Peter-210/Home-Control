Public Class MainForm


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TopMenu.Initialize(SubMenu1, SubMenu2, SubMenu3)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        TopMenu.StartScanning()
    End Sub


    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click
        TopMenu.StopScanning()
        Dim b As Button = sender
        MsgBox(b.ToString() & " was selected")
        TopMenu.ResumeScanning()
    End Sub

End Class