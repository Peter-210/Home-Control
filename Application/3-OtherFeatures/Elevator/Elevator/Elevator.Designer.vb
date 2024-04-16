<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Elevator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Elevator))
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.DefaultBtn = New System.Windows.Forms.Button()
        Me.OverrideBtn = New System.Windows.Forms.Button()
        Me.FloorLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.Location = New System.Drawing.Point(72, 74)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(123, 102)
        Me.BackBtn.TabIndex = 9
        Me.BackBtn.Text = "Back"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TitleLabel.Location = New System.Drawing.Point(331, 109)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(140, 46)
        Me.TitleLabel.TabIndex = 10
        Me.TitleLabel.Text = "Elevator"
        '
        'DefaultBtn
        '
        Me.DefaultBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.DefaultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DefaultBtn.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DefaultBtn.ForeColor = System.Drawing.Color.White
        Me.DefaultBtn.Location = New System.Drawing.Point(201, 320)
        Me.DefaultBtn.Name = "DefaultBtn"
        Me.DefaultBtn.Size = New System.Drawing.Size(435, 147)
        Me.DefaultBtn.TabIndex = 11
        Me.DefaultBtn.Text = "Default Floor"
        Me.DefaultBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DefaultBtn.UseVisualStyleBackColor = False
        '
        'OverrideBtn
        '
        Me.OverrideBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.OverrideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OverrideBtn.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OverrideBtn.ForeColor = System.Drawing.Color.White
        Me.OverrideBtn.Location = New System.Drawing.Point(201, 504)
        Me.OverrideBtn.Name = "OverrideBtn"
        Me.OverrideBtn.Size = New System.Drawing.Size(435, 155)
        Me.OverrideBtn.TabIndex = 12
        Me.OverrideBtn.Text = "Select A Floor"
        Me.OverrideBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OverrideBtn.UseVisualStyleBackColor = False
        '
        'FloorLabel
        '
        Me.FloorLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FloorLabel.Location = New System.Drawing.Point(68, 234)
        Me.FloorLabel.Name = "FloorLabel"
        Me.FloorLabel.Size = New System.Drawing.Size(676, 38)
        Me.FloorLabel.TabIndex = 14
        Me.FloorLabel.Text = "You are on the 1 Floor"
        Me.FloorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.home_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(492, 335)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 121)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.elevator_icon
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(492, 527)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 115)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.groundFloor
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(492, 335)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 121)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Elevator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FloorLabel)
        Me.Controls.Add(Me.OverrideBtn)
        Me.Controls.Add(Me.DefaultBtn)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.BackBtn)
        Me.Name = "Elevator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Control"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackBtn As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents TitleLabel As Label
    Friend WithEvents DefaultBtn As Button
    Friend WithEvents OverrideBtn As Button
    Friend WithEvents FloorLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
