Public Class SubMenu
    Inherits Panel

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

#Region "Prepare for Scanning"

    Private totalbuttons As Integer
    Private Buttons As Button()

    Public Sub Initialize()
        totalbuttons = Me.Controls.Count
        ReDim Buttons(totalbuttons)
        Dim index As Integer
        For Each b As Control In Me.Controls
            index = CInt(b.TabIndex)
            If index >= totalbuttons Then
                MsgBox("The button labelled " & b.Text & " was not added to scanning menu because its tabindex is greater or equal to " & totalbuttons)
            ElseIf Buttons(index) Is Nothing Then
                Buttons(index) = b
            Else
                MsgBox("The button labelled " & b.Text & " was not added to scanning menu because it has the same tabindex as the button labelled " & Buttons(index).Text)
            End If
        Next
    End Sub

#End Region

#Region "Scanning"

    Private activebutton As Integer

    Public Shared InnerScanning As Boolean

    Public Sub ReceiveFocus()
        BackColor = Color.LightBlue
    End Sub

    Public Sub LoseFocus()
        BackColor = DefaultBackColor
    End Sub

    Public Sub StartInnerScanning()
        activebutton = 0
        Buttons(activebutton).Focus()
    End Sub

    Public Sub InnerScanningNext()
        activebutton = (activebutton + 1) Mod totalbuttons
        Buttons(activebutton).Focus()
    End Sub

#End Region



End Class
