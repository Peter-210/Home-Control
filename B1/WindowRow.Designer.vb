<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowRow
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WindowRowTitle = New System.Windows.Forms.Label()
        Me.WindowSubMenuBlinds = New B1_HOME_CONTROL.WindowSubMenu()
        Me.WindowSubMenuWindows = New B1_HOME_CONTROL.WindowSubMenu()
        Me.SuspendLayout()
        '
        'WindowRowTitle
        '
        Me.WindowRowTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WindowRowTitle.ForeColor = System.Drawing.Color.White
        Me.WindowRowTitle.Location = New System.Drawing.Point(12, 51)
        Me.WindowRowTitle.Name = "WindowRowTitle"
        Me.WindowRowTitle.Size = New System.Drawing.Size(148, 93)
        Me.WindowRowTitle.TabIndex = 0
        Me.WindowRowTitle.Text = "Label1"
        '
        'WindowSubMenuBlinds
        '
        Me.WindowSubMenuBlinds.BackColor = System.Drawing.SystemColors.Control
        Me.WindowSubMenuBlinds.Location = New System.Drawing.Point(410, 3)
        Me.WindowSubMenuBlinds.Name = "WindowSubMenuBlinds"
        Me.WindowSubMenuBlinds.Size = New System.Drawing.Size(234, 169)
        Me.WindowSubMenuBlinds.TabIndex = 17
        '
        'WindowSubMenuWindows
        '
        Me.WindowSubMenuWindows.BackColor = System.Drawing.SystemColors.Control
        Me.WindowSubMenuWindows.Location = New System.Drawing.Point(144, 3)
        Me.WindowSubMenuWindows.Name = "WindowSubMenuWindows"
        Me.WindowSubMenuWindows.Size = New System.Drawing.Size(234, 169)
        Me.WindowSubMenuWindows.TabIndex = 18
        '
        'WindowRow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WindowSubMenuWindows)
        Me.Controls.Add(Me.WindowSubMenuBlinds)
        Me.Controls.Add(Me.WindowRowTitle)
        Me.Name = "WindowRow"
        Me.Size = New System.Drawing.Size(689, 178)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WindowRowTitle As Label
    Friend WithEvents WindowSubMenuBlinds As WindowSubMenu
    Friend WithEvents WindowSubMenuWindows As WindowSubMenu
End Class
