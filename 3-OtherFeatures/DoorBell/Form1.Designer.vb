<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DummyDockBar = New System.Windows.Forms.PictureBox()
        Me.DummyIconText = New System.Windows.Forms.PictureBox()
        Me.DummyIconSafari = New System.Windows.Forms.PictureBox()
        Me.DummyIconSettings = New System.Windows.Forms.PictureBox()
        Me.HomeControlAppIcon = New System.Windows.Forms.PictureBox()
        CType(Me.DummyDockBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DummyIconText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DummyIconSafari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DummyIconSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeControlAppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DummyDockBar
        '
        Me.DummyDockBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DummyDockBar.Location = New System.Drawing.Point(219, 900)
        Me.DummyDockBar.Name = "DummyDockBar"
        Me.DummyDockBar.Size = New System.Drawing.Size(388, 106)
        Me.DummyDockBar.TabIndex = 0
        Me.DummyDockBar.TabStop = False
        '
        'DummyIconText
        '
        Me.DummyIconText.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DummyIconText.Image = CType(resources.GetObject("DummyIconText.Image"), System.Drawing.Image)
        Me.DummyIconText.Location = New System.Drawing.Point(325, 916)
        Me.DummyIconText.Name = "DummyIconText"
        Me.DummyIconText.Size = New System.Drawing.Size(77, 74)
        Me.DummyIconText.TabIndex = 1
        Me.DummyIconText.TabStop = False
        '
        'DummyIconSafari
        '
        Me.DummyIconSafari.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DummyIconSafari.Image = CType(resources.GetObject("DummyIconSafari.Image"), System.Drawing.Image)
        Me.DummyIconSafari.Location = New System.Drawing.Point(419, 916)
        Me.DummyIconSafari.Name = "DummyIconSafari"
        Me.DummyIconSafari.Size = New System.Drawing.Size(77, 74)
        Me.DummyIconSafari.TabIndex = 2
        Me.DummyIconSafari.TabStop = False
        '
        'DummyIconSettings
        '
        Me.DummyIconSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DummyIconSettings.Image = CType(resources.GetObject("DummyIconSettings.Image"), System.Drawing.Image)
        Me.DummyIconSettings.Location = New System.Drawing.Point(515, 916)
        Me.DummyIconSettings.Name = "DummyIconSettings"
        Me.DummyIconSettings.Size = New System.Drawing.Size(77, 74)
        Me.DummyIconSettings.TabIndex = 3
        Me.DummyIconSettings.TabStop = False
        '
        'HomeControlAppIcon
        '
        Me.HomeControlAppIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.HomeControlAppIcon.Image = CType(resources.GetObject("HomeControlAppIcon.Image"), System.Drawing.Image)
        Me.HomeControlAppIcon.Location = New System.Drawing.Point(233, 916)
        Me.HomeControlAppIcon.Name = "HomeControlAppIcon"
        Me.HomeControlAppIcon.Size = New System.Drawing.Size(77, 74)
        Me.HomeControlAppIcon.TabIndex = 4
        Me.HomeControlAppIcon.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.HomeControlAppIcon)
        Me.Controls.Add(Me.DummyIconSettings)
        Me.Controls.Add(Me.DummyIconSafari)
        Me.Controls.Add(Me.DummyIconText)
        Me.Controls.Add(Me.DummyDockBar)
        Me.Name = "Form1"
        Me.Text = "Home Control"
        CType(Me.DummyDockBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DummyIconText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DummyIconSafari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DummyIconSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeControlAppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DummyDockBar As PictureBox
    Friend WithEvents DummyIconText As PictureBox
    Friend WithEvents DummyIconSafari As PictureBox
    Friend WithEvents DummyIconSettings As PictureBox
    Friend WithEvents HomeControlAppIcon As PictureBox
End Class
