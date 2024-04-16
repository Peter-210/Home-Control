<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Temperature
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Temperature))
        Me.TemperatureLabel = New System.Windows.Forms.Label()
        Me.SetLabel = New System.Windows.Forms.Label()
        Me.ActionLabel = New System.Windows.Forms.Label()
        Me.RoomLabel = New System.Windows.Forms.Label()
        Me.UpBtn = New System.Windows.Forms.Button()
        Me.DownBtn = New System.Windows.Forms.Button()
        Me.RoomBtn = New System.Windows.Forms.Button()
        Me.ProgBtn = New System.Windows.Forms.Button()
        Me.ProgLabel = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.CurrentLabel = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.CheckChange = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TemperatureLabel
        '
        Me.TemperatureLabel.AutoSize = True
        Me.TemperatureLabel.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TemperatureLabel.Location = New System.Drawing.Point(301, 151)
        Me.TemperatureLabel.Name = "TemperatureLabel"
        Me.TemperatureLabel.Size = New System.Drawing.Size(210, 46)
        Me.TemperatureLabel.TabIndex = 0
        Me.TemperatureLabel.Text = "Temperature"
        '
        'SetLabel
        '
        Me.SetLabel.AutoSize = True
        Me.SetLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SetLabel.Location = New System.Drawing.Point(622, 500)
        Me.SetLabel.Name = "SetLabel"
        Me.SetLabel.Size = New System.Drawing.Size(82, 37)
        Me.SetLabel.TabIndex = 1
        Me.SetLabel.Text = "Value"
        Me.SetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActionLabel
        '
        Me.ActionLabel.AutoSize = True
        Me.ActionLabel.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ActionLabel.Location = New System.Drawing.Point(611, 390)
        Me.ActionLabel.Name = "ActionLabel"
        Me.ActionLabel.Size = New System.Drawing.Size(93, 37)
        Me.ActionLabel.TabIndex = 2
        Me.ActionLabel.Text = "Action"
        '
        'RoomLabel
        '
        Me.RoomLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RoomLabel.Location = New System.Drawing.Point(140, 423)
        Me.RoomLabel.Name = "RoomLabel"
        Me.RoomLabel.Size = New System.Drawing.Size(297, 28)
        Me.RoomLabel.TabIndex = 3
        Me.RoomLabel.Text = "Room"
        Me.RoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpBtn
        '
        Me.UpBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.UpBtn.BackgroundImage = CType(resources.GetObject("UpBtn.BackgroundImage"), System.Drawing.Image)
        Me.UpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UpBtn.Location = New System.Drawing.Point(622, 430)
        Me.UpBtn.Name = "UpBtn"
        Me.UpBtn.Size = New System.Drawing.Size(75, 70)
        Me.UpBtn.TabIndex = 3
        Me.UpBtn.Tag = "1"
        Me.UpBtn.UseVisualStyleBackColor = False
        '
        'DownBtn
        '
        Me.DownBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.DownBtn.BackgroundImage = CType(resources.GetObject("DownBtn.BackgroundImage"), System.Drawing.Image)
        Me.DownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DownBtn.Location = New System.Drawing.Point(622, 543)
        Me.DownBtn.Name = "DownBtn"
        Me.DownBtn.Size = New System.Drawing.Size(75, 70)
        Me.DownBtn.TabIndex = 4
        Me.DownBtn.Tag = "-1"
        Me.DownBtn.UseVisualStyleBackColor = False
        '
        'RoomBtn
        '
        Me.RoomBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.RoomBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RoomBtn.ForeColor = System.Drawing.Color.White
        Me.RoomBtn.Location = New System.Drawing.Point(190, 327)
        Me.RoomBtn.Name = "RoomBtn"
        Me.RoomBtn.Size = New System.Drawing.Size(200, 76)
        Me.RoomBtn.TabIndex = 1
        Me.RoomBtn.Text = "Change Room"
        Me.RoomBtn.UseVisualStyleBackColor = False
        '
        'ProgBtn
        '
        Me.ProgBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ProgBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProgBtn.ForeColor = System.Drawing.Color.White
        Me.ProgBtn.Location = New System.Drawing.Point(190, 662)
        Me.ProgBtn.Name = "ProgBtn"
        Me.ProgBtn.Size = New System.Drawing.Size(200, 84)
        Me.ProgBtn.TabIndex = 2
        Me.ProgBtn.Text = "Select Program"
        Me.ProgBtn.UseVisualStyleBackColor = False
        '
        'ProgLabel
        '
        Me.ProgLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProgLabel.Location = New System.Drawing.Point(140, 604)
        Me.ProgLabel.Name = "ProgLabel"
        Me.ProgLabel.Size = New System.Drawing.Size(297, 28)
        Me.ProgLabel.TabIndex = 8
        Me.ProgLabel.Text = "Program"
        Me.ProgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.Location = New System.Drawing.Point(76, 80)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(100, 77)
        Me.BackBtn.TabIndex = 5
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'CurrentLabel
        '
        Me.CurrentLabel.Font = New System.Drawing.Font("Segoe UI", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CurrentLabel.Location = New System.Drawing.Point(173, 473)
        Me.CurrentLabel.Name = "CurrentLabel"
        Me.CurrentLabel.Size = New System.Drawing.Size(229, 105)
        Me.CurrentLabel.TabIndex = 10
        Me.CurrentLabel.Text = "CurrentValue"
        Me.CurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        Me.Timer.Interval = 5000
        '
        'CheckChange
        '
        Me.CheckChange.Enabled = True
        '
        'Temperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.CurrentLabel)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.ProgLabel)
        Me.Controls.Add(Me.ProgBtn)
        Me.Controls.Add(Me.RoomBtn)
        Me.Controls.Add(Me.DownBtn)
        Me.Controls.Add(Me.UpBtn)
        Me.Controls.Add(Me.RoomLabel)
        Me.Controls.Add(Me.ActionLabel)
        Me.Controls.Add(Me.SetLabel)
        Me.Controls.Add(Me.TemperatureLabel)
        Me.Name = "Temperature"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TemperatureLabel As Label
    Friend WithEvents SetLabel As Label
    Friend WithEvents ActionLabel As Label
    Friend WithEvents RoomLabel As Label
    Friend WithEvents UpBtn As Button
    Friend WithEvents DownBtn As Button
    Friend WithEvents RoomBtn As Button
    Friend WithEvents ProgBtn As Button
    Friend WithEvents ProgLabel As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents CurrentLabel As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents CheckChange As Timer
End Class
