<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecificRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpecificRoom))
        Me.LightRowBedroom = New B1_HOME_CONTROL.LightRow()
        Me.LightRowBathroom = New B1_HOME_CONTROL.LightRow()
        Me.LightRowLivingRoom = New B1_HOME_CONTROL.LightRow()
        Me.LightRowEntranceHallway = New B1_HOME_CONTROL.LightRow()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LightRowBedroom
        '
        Me.LightRowBedroom.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LightRowBedroom.Location = New System.Drawing.Point(193, 123)
        Me.LightRowBedroom.Name = "LightRowBedroom"
        Me.LightRowBedroom.Size = New System.Drawing.Size(426, 178)
        Me.LightRowBedroom.TabIndex = 0
        '
        'LightRowBathroom
        '
        Me.LightRowBathroom.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.LightRowBathroom.Location = New System.Drawing.Point(193, 330)
        Me.LightRowBathroom.Name = "LightRowBathroom"
        Me.LightRowBathroom.Size = New System.Drawing.Size(426, 178)
        Me.LightRowBathroom.TabIndex = 1
        '
        'LightRowLivingRoom
        '
        Me.LightRowLivingRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LightRowLivingRoom.Location = New System.Drawing.Point(193, 537)
        Me.LightRowLivingRoom.Name = "LightRowLivingRoom"
        Me.LightRowLivingRoom.Size = New System.Drawing.Size(426, 178)
        Me.LightRowLivingRoom.TabIndex = 2
        '
        'LightRowEntranceHallway
        '
        Me.LightRowEntranceHallway.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.LightRowEntranceHallway.Location = New System.Drawing.Point(193, 744)
        Me.LightRowEntranceHallway.Name = "LightRowEntranceHallway"
        Me.LightRowEntranceHallway.Size = New System.Drawing.Size(426, 178)
        Me.LightRowEntranceHallway.TabIndex = 3
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
        'SpecificRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.LightRowEntranceHallway)
        Me.Controls.Add(Me.LightRowLivingRoom)
        Me.Controls.Add(Me.LightRowBathroom)
        Me.Controls.Add(Me.LightRowBedroom)
        Me.Name = "SpecificRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Specific Room"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LightRowBedroom As LightRow
    Friend WithEvents LightRowBathroom As LightRow
    Friend WithEvents LightRowLivingRoom As LightRow
    Friend WithEvents LightRowEntranceHallway As LightRow
    Friend WithEvents BackButton As Button
End Class
