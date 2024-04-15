<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LightsAndWindowsBlinds
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LightsAndWindowsBlinds))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LightButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WindowBlindButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.Location = New System.Drawing.Point(87, 91)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(98, 75)
        Me.BackButton.TabIndex = 8
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.light
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(500, 365)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 85)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'LightButton
        '
        Me.LightButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.LightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LightButton.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LightButton.ForeColor = System.Drawing.Color.White
        Me.LightButton.Location = New System.Drawing.Point(180, 346)
        Me.LightButton.Name = "LightButton"
        Me.LightButton.Size = New System.Drawing.Size(455, 115)
        Me.LightButton.TabIndex = 12
        Me.LightButton.Text = "Light Controls"
        Me.LightButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LightButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.m3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(477, 530)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 85)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'WindowBlindButton
        '
        Me.WindowBlindButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.WindowBlindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.WindowBlindButton.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WindowBlindButton.ForeColor = System.Drawing.Color.White
        Me.WindowBlindButton.Location = New System.Drawing.Point(180, 511)
        Me.WindowBlindButton.Name = "WindowBlindButton"
        Me.WindowBlindButton.Size = New System.Drawing.Size(455, 115)
        Me.WindowBlindButton.TabIndex = 14
        Me.WindowBlindButton.Text = "Window/Blind Controls"
        Me.WindowBlindButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WindowBlindButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(180, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 37)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Lights, Windows and Blinds Control"
        '
        'LightsAndWindowsBlinds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WindowBlindButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LightButton)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "LightsAndWindowsBlinds"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LightsAndWindowsBlinds"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LightButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WindowBlindButton As Button
    Friend WithEvents Label1 As Label
End Class
