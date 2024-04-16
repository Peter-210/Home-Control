<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeControl))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HVACButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LightWindowBlindButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.VacuumButton = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ScheduleControlsButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.Location = New System.Drawing.Point(72, 74)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(102, 69)
        Me.BackButton.TabIndex = 5
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.HVAC_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(495, 216)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 87)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'HVACButton
        '
        Me.HVACButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.HVACButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HVACButton.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HVACButton.ForeColor = System.Drawing.Color.White
        Me.HVACButton.Location = New System.Drawing.Point(177, 203)
        Me.HVACButton.Name = "HVACButton"
        Me.HVACButton.Size = New System.Drawing.Size(455, 115)
        Me.HVACButton.TabIndex = 1
        Me.HVACButton.Text = "Temperature Controls"
        Me.HVACButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HVACButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.merge2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(474, 353)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(137, 85)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'LightWindowBlindButton
        '
        Me.LightWindowBlindButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.LightWindowBlindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LightWindowBlindButton.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LightWindowBlindButton.ForeColor = System.Drawing.Color.White
        Me.LightWindowBlindButton.Location = New System.Drawing.Point(177, 334)
        Me.LightWindowBlindButton.Name = "LightWindowBlindButton"
        Me.LightWindowBlindButton.Size = New System.Drawing.Size(455, 115)
        Me.LightWindowBlindButton.TabIndex = 2
        Me.LightWindowBlindButton.Text = "Light/Window/Blind"
        Me.LightWindowBlindButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LightWindowBlindButton.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.vacuum_icon
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(497, 478)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(91, 87)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'VacuumButton
        '
        Me.VacuumButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.VacuumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VacuumButton.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VacuumButton.ForeColor = System.Drawing.Color.White
        Me.VacuumButton.Location = New System.Drawing.Point(179, 465)
        Me.VacuumButton.Name = "VacuumButton"
        Me.VacuumButton.Size = New System.Drawing.Size(455, 115)
        Me.VacuumButton.TabIndex = 3
        Me.VacuumButton.Text = "Vacuum Controls"
        Me.VacuumButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VacuumButton.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.schedulecontrols_icon
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(497, 610)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(91, 87)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'ScheduleControlsButton
        '
        Me.ScheduleControlsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ScheduleControlsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ScheduleControlsButton.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScheduleControlsButton.ForeColor = System.Drawing.Color.White
        Me.ScheduleControlsButton.Location = New System.Drawing.Point(179, 597)
        Me.ScheduleControlsButton.Name = "ScheduleControlsButton"
        Me.ScheduleControlsButton.Size = New System.Drawing.Size(455, 115)
        Me.ScheduleControlsButton.TabIndex = 4
        Me.ScheduleControlsButton.Text = "Task Scheduling"
        Me.ScheduleControlsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ScheduleControlsButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(303, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Home Control"
        '
        'HomeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.ScheduleControlsButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.VacuumButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LightWindowBlindButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HVACButton)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "HomeControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomeControl"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HVACButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LightWindowBlindButton As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents VacuumButton As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ScheduleControlsButton As Button
    Friend WithEvents Label1 As Label
End Class
