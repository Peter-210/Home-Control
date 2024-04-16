<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WindowBlindForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WindowBlindForm))
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LivingBtn = New System.Windows.Forms.Button()
        Me.BedBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.Location = New System.Drawing.Point(59, 75)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(102, 77)
        Me.BackBtn.TabIndex = 3
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.bedcontrols
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(506, 526)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(139, 136)
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.living
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(506, 358)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(139, 125)
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'LivingBtn
        '
        Me.LivingBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.LivingBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LivingBtn.ForeColor = System.Drawing.Color.White
        Me.LivingBtn.Location = New System.Drawing.Point(136, 341)
        Me.LivingBtn.Name = "LivingBtn"
        Me.LivingBtn.Size = New System.Drawing.Size(559, 156)
        Me.LivingBtn.TabIndex = 1
        Me.LivingBtn.Tag = ""
        Me.LivingBtn.Text = "Living Room"
        Me.LivingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LivingBtn.UseVisualStyleBackColor = False
        '
        'BedBtn
        '
        Me.BedBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BedBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BedBtn.ForeColor = System.Drawing.Color.White
        Me.BedBtn.Location = New System.Drawing.Point(136, 509)
        Me.BedBtn.Name = "BedBtn"
        Me.BedBtn.Size = New System.Drawing.Size(559, 167)
        Me.BedBtn.TabIndex = 2
        Me.BedBtn.Tag = ""
        Me.BedBtn.Text = "Bedroom"
        Me.BedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BedBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(293, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 37)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Windows and Blinds"
        '
        'WindowBlindForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.ipad_white
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LivingBtn)
        Me.Controls.Add(Me.BedBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBtn)
        Me.Name = "WindowBlindForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChooseRoom"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LivingBtn As Button
    Friend WithEvents BedBtn As Button
    Friend WithEvents Label1 As Label
End Class
