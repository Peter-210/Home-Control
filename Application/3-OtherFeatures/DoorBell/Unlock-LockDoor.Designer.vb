<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unlock_LockDoor
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
        Me.components = New System.ComponentModel.Container()
        Me.doorStatusBox = New System.Windows.Forms.PictureBox()
        Me.doorStatusBox2 = New System.Windows.Forms.PictureBox()
        Me.doorStatusLabel = New System.Windows.Forms.Label()
        Me.pendingBox = New System.Windows.Forms.PictureBox()
        Me.guestStatusLabel = New System.Windows.Forms.Label()
        Me.doorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.doorStatusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.guestStatusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pendingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.closeWindowTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.doorStatusBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doorStatusBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pendingBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'doorStatusBox
        '
        Me.doorStatusBox.BackColor = System.Drawing.Color.White
        Me.doorStatusBox.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.outgoing_door_confirm_icon
        Me.doorStatusBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.doorStatusBox.Location = New System.Drawing.Point(258, 267)
        Me.doorStatusBox.Name = "doorStatusBox"
        Me.doorStatusBox.Size = New System.Drawing.Size(296, 299)
        Me.doorStatusBox.TabIndex = 0
        Me.doorStatusBox.TabStop = False
        '
        'doorStatusBox2
        '
        Me.doorStatusBox2.BackColor = System.Drawing.Color.White
        Me.doorStatusBox2.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.unlock_icon
        Me.doorStatusBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.doorStatusBox2.Location = New System.Drawing.Point(358, 552)
        Me.doorStatusBox2.Name = "doorStatusBox2"
        Me.doorStatusBox2.Size = New System.Drawing.Size(100, 50)
        Me.doorStatusBox2.TabIndex = 1
        Me.doorStatusBox2.TabStop = False
        '
        'doorStatusLabel
        '
        Me.doorStatusLabel.AutoSize = True
        Me.doorStatusLabel.BackColor = System.Drawing.Color.White
        Me.doorStatusLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.doorStatusLabel.Location = New System.Drawing.Point(326, 616)
        Me.doorStatusLabel.Name = "doorStatusLabel"
        Me.doorStatusLabel.Size = New System.Drawing.Size(166, 28)
        Me.doorStatusLabel.TabIndex = 4
        Me.doorStatusLabel.Text = "Door is unlocked!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pendingBox
        '
        Me.pendingBox.BackColor = System.Drawing.Color.White
        Me.pendingBox.Image = Global.B1_HOME_CONTROL.My.Resources.Resources.outgoing_doorbell_cancel1
        Me.pendingBox.Location = New System.Drawing.Point(349, 650)
        Me.pendingBox.Name = "pendingBox"
        Me.pendingBox.Size = New System.Drawing.Size(119, 106)
        Me.pendingBox.TabIndex = 5
        Me.pendingBox.TabStop = False
        '
        'guestStatusLabel
        '
        Me.guestStatusLabel.AutoSize = True
        Me.guestStatusLabel.BackColor = System.Drawing.Color.White
        Me.guestStatusLabel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.guestStatusLabel.Location = New System.Drawing.Point(298, 653)
        Me.guestStatusLabel.Name = "guestStatusLabel"
        Me.guestStatusLabel.Size = New System.Drawing.Size(235, 25)
        Me.guestStatusLabel.TabIndex = 6
        Me.guestStatusLabel.Text = "Waiting For Guest To Enter"
        '
        'doorTimer
        '
        Me.doorTimer.Enabled = True
        Me.doorTimer.Interval = 5000
        '
        'lockTimer
        '
        Me.lockTimer.Enabled = True
        Me.lockTimer.Interval = 5000
        '
        'doorStatusTimer
        '
        Me.doorStatusTimer.Enabled = True
        Me.doorStatusTimer.Interval = 5000
        '
        'guestStatusTimer
        '
        Me.guestStatusTimer.Enabled = True
        Me.guestStatusTimer.Interval = 3000
        '
        'pendingTimer
        '
        Me.pendingTimer.Enabled = True
        Me.pendingTimer.Interval = 3000
        '
        'closeWindowTimer
        '
        Me.closeWindowTimer.Interval = 2000
        '
        'Unlock_LockDoor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.ipad_white
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.doorStatusBox2)
        Me.Controls.Add(Me.guestStatusLabel)
        Me.Controls.Add(Me.pendingBox)
        Me.Controls.Add(Me.doorStatusLabel)
        Me.Controls.Add(Me.doorStatusBox)
        Me.Name = "Unlock_LockDoor"
        Me.Text = "Unlock_LockDoor"
        CType(Me.doorStatusBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doorStatusBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pendingBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents doorStatusBox As PictureBox
    Friend WithEvents doorStatusBox2 As PictureBox
    Friend WithEvents doorStatusLabel As Label
    Friend WithEvents pendingBox As PictureBox
    Friend WithEvents guestStatusLabel As Label
    Friend WithEvents doorTimer As Timer
    Friend WithEvents lockTimer As Timer
    Friend WithEvents doorStatusTimer As Timer
    Friend WithEvents guestStatusTimer As Timer
    Friend WithEvents pendingTimer As Timer
    Friend WithEvents closeWindowTimer As Timer
End Class
