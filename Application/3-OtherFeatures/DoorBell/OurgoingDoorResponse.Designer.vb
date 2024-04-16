<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OurgoingDoorResponse
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
        Me.backBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCancelRequest = New System.Windows.Forms.Button()
        Me.statusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnStatusResponse = New System.Windows.Forms.Label()
        Me.confirmTimer = New System.Windows.Forms.Timer(Me.components)
        Me.responseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.estimatedTimeLabel = New System.Windows.Forms.Label()
        Me.countdownLabel = New System.Windows.Forms.Label()
        Me.cancelTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backBtn
        '
        Me.backBtn.Location = New System.Drawing.Point(93, 80)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(75, 23)
        Me.backBtn.TabIndex = 0
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.outgoing_door_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(277, 348)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 235)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.outgoing_doorbell_cancel
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(342, 622)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(123, 55)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.outgoing_doorbell_accept
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(342, 622)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(123, 55)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = Global.B1_HOME_CONTROL.My.Resources.Resources.outgoing_doorbell_cancel1
        Me.PictureBox2.Location = New System.Drawing.Point(342, 589)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 119)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btnCancelRequest
        '
        Me.btnCancelRequest.Location = New System.Drawing.Point(303, 727)
        Me.btnCancelRequest.Name = "btnCancelRequest"
        Me.btnCancelRequest.Size = New System.Drawing.Size(200, 36)
        Me.btnCancelRequest.TabIndex = 6
        Me.btnCancelRequest.Text = "Cancel Request"
        Me.btnCancelRequest.UseVisualStyleBackColor = True
        '
        'statusTimer
        '
        Me.statusTimer.Enabled = True
        Me.statusTimer.Interval = 1000
        '
        'btnStatusResponse
        '
        Me.btnStatusResponse.AutoSize = True
        Me.btnStatusResponse.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStatusResponse.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnStatusResponse.Location = New System.Drawing.Point(263, 282)
        Me.btnStatusResponse.Name = "btnStatusResponse"
        Me.btnStatusResponse.Size = New System.Drawing.Size(286, 46)
        Me.btnStatusResponse.TabIndex = 7
        Me.btnStatusResponse.Text = "Waiting Response"
        Me.btnStatusResponse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'confirmTimer
        '
        Me.confirmTimer.Interval = 2000
        '
        'responseTimer
        '
        Me.responseTimer.Enabled = True
        Me.responseTimer.Interval = 1000
        '
        'estimatedTimeLabel
        '
        Me.estimatedTimeLabel.AutoSize = True
        Me.estimatedTimeLabel.Location = New System.Drawing.Point(352, 711)
        Me.estimatedTimeLabel.Name = "estimatedTimeLabel"
        Me.estimatedTimeLabel.Size = New System.Drawing.Size(91, 15)
        Me.estimatedTimeLabel.TabIndex = 8
        Me.estimatedTimeLabel.Text = "Estimated Time:"
        '
        'countdownLabel
        '
        Me.countdownLabel.AutoSize = True
        Me.countdownLabel.Location = New System.Drawing.Point(439, 711)
        Me.countdownLabel.Name = "countdownLabel"
        Me.countdownLabel.Size = New System.Drawing.Size(13, 15)
        Me.countdownLabel.TabIndex = 9
        Me.countdownLabel.Text = "6"
        '
        'cancelTimer
        '
        Me.cancelTimer.Interval = 2000
        '
        'OurgoingDoorResponse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.countdownLabel)
        Me.Controls.Add(Me.estimatedTimeLabel)
        Me.Controls.Add(Me.btnStatusResponse)
        Me.Controls.Add(Me.btnCancelRequest)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "OurgoingDoorResponse"
        Me.Text = "OurgoingDoorResponse"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCancelRequest As Button
    Friend WithEvents statusTimer As Timer
    Friend WithEvents btnStatusResponse As Label
    Friend WithEvents confirmTimer As Timer
    Friend WithEvents responseTimer As Timer
    Friend WithEvents estimatedTimeLabel As Label
    Friend WithEvents countdownLabel As Label
    Friend WithEvents cancelTimer As Timer
End Class
