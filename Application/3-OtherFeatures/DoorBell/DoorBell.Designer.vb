<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoorBell
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.VoiceAccept = New System.Windows.Forms.Button()
        Me.VoiceReject = New System.Windows.Forms.Button()
        Me.MessageAccept = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.doorbellNotification = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MessageReject = New System.Windows.Forms.Button()
        Me.voiceAcceptLabel = New System.Windows.Forms.Label()
        Me.voiceRejectLabel = New System.Windows.Forms.Label()
        Me.messageAcceptLabel = New System.Windows.Forms.Label()
        Me.messageRejectLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doorbellNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VoiceAccept
        '
        Me.VoiceAccept.BackColor = System.Drawing.Color.White
        Me.VoiceAccept.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.voice_accept_doorbell_icon
        Me.VoiceAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VoiceAccept.Location = New System.Drawing.Point(183, 572)
        Me.VoiceAccept.Name = "VoiceAccept"
        Me.VoiceAccept.Size = New System.Drawing.Size(189, 94)
        Me.VoiceAccept.TabIndex = 0
        Me.VoiceAccept.UseVisualStyleBackColor = False
        '
        'VoiceReject
        '
        Me.VoiceReject.BackColor = System.Drawing.Color.White
        Me.VoiceReject.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.voice_accept_doorbell_icon
        Me.VoiceReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VoiceReject.Location = New System.Drawing.Point(479, 572)
        Me.VoiceReject.Name = "VoiceReject"
        Me.VoiceReject.Size = New System.Drawing.Size(189, 94)
        Me.VoiceReject.TabIndex = 1
        Me.VoiceReject.UseVisualStyleBackColor = False
        '
        'MessageAccept
        '
        Me.MessageAccept.BackColor = System.Drawing.Color.White
        Me.MessageAccept.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.text_message_doorbell_icon
        Me.MessageAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MessageAccept.Location = New System.Drawing.Point(183, 740)
        Me.MessageAccept.Name = "MessageAccept"
        Me.MessageAccept.Size = New System.Drawing.Size(189, 94)
        Me.MessageAccept.TabIndex = 2
        Me.MessageAccept.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.caller_id_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(321, 357)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 151)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'doorbellNotification
        '
        Me.doorbellNotification.BackColor = System.Drawing.Color.White
        Me.doorbellNotification.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.doorbell_icon
        Me.doorbellNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.doorbellNotification.Location = New System.Drawing.Point(372, 501)
        Me.doorbellNotification.Name = "doorbellNotification"
        Me.doorbellNotification.Size = New System.Drawing.Size(55, 29)
        Me.doorbellNotification.TabIndex = 5
        Me.doorbellNotification.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(238, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 41)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Your DoorBell is Ringing"
        '
        'MessageReject
        '
        Me.MessageReject.BackColor = System.Drawing.Color.White
        Me.MessageReject.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.text_message_doorbell_cancel_icon
        Me.MessageReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MessageReject.Location = New System.Drawing.Point(479, 740)
        Me.MessageReject.Name = "MessageReject"
        Me.MessageReject.Size = New System.Drawing.Size(189, 94)
        Me.MessageReject.TabIndex = 3
        Me.MessageReject.UseVisualStyleBackColor = False
        '
        'voiceAcceptLabel
        '
        Me.voiceAcceptLabel.AutoSize = True
        Me.voiceAcceptLabel.BackColor = System.Drawing.Color.White
        Me.voiceAcceptLabel.Location = New System.Drawing.Point(227, 669)
        Me.voiceAcceptLabel.Name = "voiceAcceptLabel"
        Me.voiceAcceptLabel.Size = New System.Drawing.Size(107, 15)
        Me.voiceAcceptLabel.TabIndex = 9
        Me.voiceAcceptLabel.Text = "Voice Reply Accept"
        '
        'voiceRejectLabel
        '
        Me.voiceRejectLabel.AutoSize = True
        Me.voiceRejectLabel.BackColor = System.Drawing.Color.White
        Me.voiceRejectLabel.Location = New System.Drawing.Point(522, 669)
        Me.voiceRejectLabel.Name = "voiceRejectLabel"
        Me.voiceRejectLabel.Size = New System.Drawing.Size(102, 15)
        Me.voiceRejectLabel.TabIndex = 10
        Me.voiceRejectLabel.Text = "Voice Reply Reject"
        '
        'messageAcceptLabel
        '
        Me.messageAcceptLabel.AutoSize = True
        Me.messageAcceptLabel.BackColor = System.Drawing.Color.White
        Me.messageAcceptLabel.Location = New System.Drawing.Point(218, 837)
        Me.messageAcceptLabel.Name = "messageAcceptLabel"
        Me.messageAcceptLabel.Size = New System.Drawing.Size(125, 15)
        Me.messageAcceptLabel.TabIndex = 11
        Me.messageAcceptLabel.Text = "Message Reply Accept"
        '
        'messageRejectLabel
        '
        Me.messageRejectLabel.AutoSize = True
        Me.messageRejectLabel.BackColor = System.Drawing.Color.White
        Me.messageRejectLabel.Location = New System.Drawing.Point(522, 837)
        Me.messageRejectLabel.Name = "messageRejectLabel"
        Me.messageRejectLabel.Size = New System.Drawing.Size(120, 15)
        Me.messageRejectLabel.TabIndex = 12
        Me.messageRejectLabel.Text = "Message Reply Reject"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(85, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DoorBell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.ipad_white
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.messageRejectLabel)
        Me.Controls.Add(Me.messageAcceptLabel)
        Me.Controls.Add(Me.voiceRejectLabel)
        Me.Controls.Add(Me.voiceAcceptLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.doorbellNotification)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MessageReject)
        Me.Controls.Add(Me.MessageAccept)
        Me.Controls.Add(Me.VoiceReject)
        Me.Controls.Add(Me.VoiceAccept)
        Me.Name = "DoorBell"
        Me.Text = "s"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doorbellNotification, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VoiceAccept As Button
    Friend WithEvents VoiceReject As Button
    Friend WithEvents MessageAccept As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents doorbellNotification As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents MessageReject As Button
    Friend WithEvents voiceAcceptLabel As Label
    Friend WithEvents voiceRejectLabel As Label
    Friend WithEvents messageAcceptLabel As Label
    Friend WithEvents messageRejectLabel As Label
    Friend WithEvents Button1 As Button
End Class
