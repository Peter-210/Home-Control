Public Class TopMenu

#Region "Register SubMenus"

    Private totalmenus As Integer
    Private Submenus As SubMenu()

    Public Sub Initialize(menu1 As SubMenu)
        totalmenus = 1
        ReDim Submenus(totalmenus)
        Submenus(0) = menu1
        InitializeSubMenus()
    End Sub

    Public Sub Initialize(menu1 As SubMenu, menu2 As SubMenu)
        totalmenus = 2
        ReDim Submenus(totalmenus)
        Submenus(0) = menu1
        Submenus(1) = menu2
        InitializeSubMenus()
    End Sub

    Public Sub Initialize(menu1 As SubMenu, menu2 As SubMenu, menu3 As SubMenu)
        totalmenus = 3
        ReDim Submenus(totalmenus)
        Submenus(0) = menu1
        Submenus(1) = menu2
        Submenus(2) = menu3
        InitializeSubMenus()
    End Sub

    Public Sub Initialize(menu1 As SubMenu, menu2 As SubMenu, menu3 As SubMenu, menu4 As SubMenu)
        totalmenus = 4
        ReDim Submenus(totalmenus)
        Submenus(0) = menu1
        Submenus(1) = menu2
        Submenus(2) = menu3
        Submenus(3) = menu4
        InitializeSubMenus()
    End Sub

    Public Sub Initialize(menu1 As SubMenu, menu2 As SubMenu, menu3 As SubMenu, menu4 As SubMenu, menu5 As SubMenu)
        totalmenus = 5
        ReDim Submenus(totalmenus)
        Submenus(0) = menu1
        Submenus(1) = menu2
        Submenus(2) = menu3
        Submenus(3) = menu4
        Submenus(4) = menu5
        InitializeSubMenus()
    End Sub

    Private Sub InitializeSubMenus()
        For i = 0 To totalmenus - 1
            Submenus(i).Initialize()
        Next
    End Sub

#End Region

#Region "Timer Properties and methods"

    ' Make the Scanningtimer interval accessible 
    Public Property ScanningInterval As Integer
        Get
            Return ScanningTimer.Interval
        End Get
        Set(value As Integer)
            ScanningTimer.Interval = value
        End Set
    End Property
#End Region

#Region "Scanning functionality"

    Private scanninglevel As Integer
    Private focusIsOn As Integer

    ' Start scanning on the first submenu
    Public Sub StartScanning()
        scanninglevel = 0
        focusIsOn = 0
        Submenus(focusIsOn).ReceiveFocus()
        ScanningTimer.Start()
    End Sub

    ' Stop scanning
    Public Sub StopScanning()
        ScanningTimer.Stop()
        Submenus(focusIsOn).LoseFocus()
        Me.Focus()
    End Sub

    ' Resume scanning on the same submenu where you stopped
    ' to restrat scanning at the beginning, use StartScanning
    Public Sub ResumeScanning()
        scanninglevel = 0
        Submenus(focusIsOn).ReceiveFocus()
        ScanningTimer.Start()
    End Sub

    ' When the timer goes off, scan to next submenu
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles ScanningTimer.Tick
        If scanninglevel = 0 Then
            Submenus(focusIsOn).LoseFocus()
            focusIsOn = (focusIsOn + 1) Mod totalmenus
            Submenus(focusIsOn).ReceiveFocus()
        Else
            Submenus(focusIsOn).InnerScanningNext()
        End If
    End Sub

    ' When the user selects a submenu, start scanning within that submenu
    Private Sub TopMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        scanninglevel = 1
        Submenus(focusIsOn).StartInnerScanning()
    End Sub

#End Region

End Class
