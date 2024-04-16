<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecificRoomWindows
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpecificRoomWindows))
        Me.WindowRowBedroom = New B1_HOME_CONTROL.WindowRow()
        Me.WindowRowBathroom = New B1_HOME_CONTROL.WindowRow()
        Me.WindowRowLivingRoom = New B1_HOME_CONTROL.WindowRow()
        Me.WindowRowEntranceHallway = New B1_HOME_CONTROL.WindowRow()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WindowRowBedroom
        '
        Me.WindowRowBedroom.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.WindowRowBedroom.Location = New System.Drawing.Point(62, 152)
        Me.WindowRowBedroom.Name = "WindowRowBedroom"
        Me.WindowRowBedroom.Size = New System.Drawing.Size(689, 178)
        Me.WindowRowBedroom.TabIndex = 0
        '
        'WindowRowBathroom
        '
        Me.WindowRowBathroom.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.WindowRowBathroom.Location = New System.Drawing.Point(62, 354)
        Me.WindowRowBathroom.Name = "WindowRowBathroom"
        Me.WindowRowBathroom.Size = New System.Drawing.Size(689, 178)
        Me.WindowRowBathroom.TabIndex = 1
        '
        'WindowRowLivingRoom
        '
        Me.WindowRowLivingRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.WindowRowLivingRoom.Location = New System.Drawing.Point(62, 554)
        Me.WindowRowLivingRoom.Name = "WindowRowLivingRoom"
        Me.WindowRowLivingRoom.Size = New System.Drawing.Size(689, 178)
        Me.WindowRowLivingRoom.TabIndex = 2
        '
        'WindowRowEntranceHallway
        '
        Me.WindowRowEntranceHallway.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.WindowRowEntranceHallway.Location = New System.Drawing.Point(62, 756)
        Me.WindowRowEntranceHallway.Name = "WindowRowEntranceHallway"
        Me.WindowRowEntranceHallway.Size = New System.Drawing.Size(689, 178)
        Me.WindowRowEntranceHallway.TabIndex = 3
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.Location = New System.Drawing.Point(72, 60)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(72, 48)
        Me.BackButton.TabIndex = 8
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'SpecificRoomWindows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.WindowRowEntranceHallway)
        Me.Controls.Add(Me.WindowRowLivingRoom)
        Me.Controls.Add(Me.WindowRowBathroom)
        Me.Controls.Add(Me.WindowRowBedroom)
        Me.Name = "SpecificRoomWindows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpecificRoomWindows"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WindowRowBedroom As WindowRow
    Friend WithEvents WindowRowBathroom As WindowRow
    Friend WithEvents WindowRowLivingRoom As WindowRow
    Friend WithEvents WindowRowEntranceHallway As WindowRow
    Friend WithEvents BackButton As Button
End Class
