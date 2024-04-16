<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyHome))
        Me.BackButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HomeControlButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Activities = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackButton.Location = New System.Drawing.Point(72, 60)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(120, 84)
        Me.BackButton.TabIndex = 9
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.home_icon1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(495, 400)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 87)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'HomeControlButton
        '
        Me.HomeControlButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.HomeControlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HomeControlButton.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HomeControlButton.ForeColor = System.Drawing.Color.White
        Me.HomeControlButton.Location = New System.Drawing.Point(177, 387)
        Me.HomeControlButton.Name = "HomeControlButton"
        Me.HomeControlButton.Size = New System.Drawing.Size(455, 115)
        Me.HomeControlButton.TabIndex = 10
        Me.HomeControlButton.Text = "Home Control"
        Me.HomeControlButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeControlButton.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.activities_other
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(495, 539)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(91, 87)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Activities
        '
        Me.Activities.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Activities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Activities.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Activities.ForeColor = System.Drawing.Color.White
        Me.Activities.Location = New System.Drawing.Point(177, 526)
        Me.Activities.Name = "Activities"
        Me.Activities.Size = New System.Drawing.Size(455, 115)
        Me.Activities.TabIndex = 12
        Me.Activities.Text = "Activities"
        Me.Activities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Activities.UseVisualStyleBackColor = False
        '
        'MyHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Activities)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HomeControlButton)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "MyHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HomeControlButton As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Activities As Button
End Class
