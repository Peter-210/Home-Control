<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OverrideFloor
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
        Dim BackBtn As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OverrideFloor))
        Me.Floor5 = New System.Windows.Forms.Button()
        Me.Floor4 = New System.Windows.Forms.Button()
        Me.Floor3 = New System.Windows.Forms.Button()
        Me.Floor2 = New System.Windows.Forms.Button()
        Me.Floor1 = New System.Windows.Forms.Button()
        Me.TitleName = New System.Windows.Forms.Label()
        Me.FloorLabel = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        BackBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        BackBtn.ForeColor = System.Drawing.Color.Chocolate
        BackBtn.Location = New System.Drawing.Point(72, 74)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New System.Drawing.Size(104, 82)
        BackBtn.TabIndex = 9
        BackBtn.UseVisualStyleBackColor = False
        AddHandler BackBtn.Click, AddressOf Me.BackBtn_Click
        AddHandler BackBtn.GotFocus, AddressOf Me.HandleButton_GotFocus
        AddHandler BackBtn.LostFocus, AddressOf Me.HandleButton_LostFocus
        '
        'Floor5
        '
        Me.Floor5.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Floor5.Font = New System.Drawing.Font("Segoe UI", 80.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Floor5.ForeColor = System.Drawing.Color.White
        Me.Floor5.Location = New System.Drawing.Point(424, 264)
        Me.Floor5.Name = "Floor5"
        Me.Floor5.Size = New System.Drawing.Size(192, 181)
        Me.Floor5.TabIndex = 10
        Me.Floor5.Tag = "5"
        Me.Floor5.Text = "5"
        Me.Floor5.UseVisualStyleBackColor = False
        '
        'Floor4
        '
        Me.Floor4.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Floor4.Font = New System.Drawing.Font("Segoe UI", 80.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Floor4.ForeColor = System.Drawing.Color.White
        Me.Floor4.Location = New System.Drawing.Point(196, 264)
        Me.Floor4.Name = "Floor4"
        Me.Floor4.Size = New System.Drawing.Size(192, 181)
        Me.Floor4.TabIndex = 11
        Me.Floor4.Tag = "4"
        Me.Floor4.Text = "4"
        Me.Floor4.UseVisualStyleBackColor = False
        '
        'Floor3
        '
        Me.Floor3.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Floor3.Font = New System.Drawing.Font("Segoe UI", 80.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Floor3.ForeColor = System.Drawing.Color.White
        Me.Floor3.Location = New System.Drawing.Point(424, 483)
        Me.Floor3.Name = "Floor3"
        Me.Floor3.Size = New System.Drawing.Size(192, 181)
        Me.Floor3.TabIndex = 12
        Me.Floor3.Tag = "3"
        Me.Floor3.Text = "3"
        Me.Floor3.UseVisualStyleBackColor = False
        '
        'Floor2
        '
        Me.Floor2.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Floor2.Font = New System.Drawing.Font("Segoe UI", 80.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Floor2.ForeColor = System.Drawing.Color.White
        Me.Floor2.Location = New System.Drawing.Point(196, 483)
        Me.Floor2.Name = "Floor2"
        Me.Floor2.Size = New System.Drawing.Size(192, 181)
        Me.Floor2.TabIndex = 13
        Me.Floor2.Tag = "2"
        Me.Floor2.Text = "2"
        Me.Floor2.UseVisualStyleBackColor = False
        '
        'Floor1
        '
        Me.Floor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Floor1.Font = New System.Drawing.Font("Segoe UI", 80.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Floor1.ForeColor = System.Drawing.Color.White
        Me.Floor1.Location = New System.Drawing.Point(311, 690)
        Me.Floor1.Name = "Floor1"
        Me.Floor1.Size = New System.Drawing.Size(192, 181)
        Me.Floor1.TabIndex = 14
        Me.Floor1.Tag = "1"
        Me.Floor1.Text = "1"
        Me.Floor1.UseVisualStyleBackColor = False
        '
        'TitleName
        '
        Me.TitleName.AutoSize = True
        Me.TitleName.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TitleName.Location = New System.Drawing.Point(230, 110)
        Me.TitleName.Name = "TitleName"
        Me.TitleName.Size = New System.Drawing.Size(352, 46)
        Me.TitleName.TabIndex = 16
        Me.TitleName.Text = "Please Choose A Floor"
        '
        'FloorLabel
        '
        Me.FloorLabel.AutoSize = True
        Me.FloorLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FloorLabel.Location = New System.Drawing.Point(290, 156)
        Me.FloorLabel.Name = "FloorLabel"
        Me.FloorLabel.Size = New System.Drawing.Size(83, 28)
        Me.FloorLabel.TabIndex = 17
        Me.FloorLabel.Text = "Elevator"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'OverrideFloor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.FloorLabel)
        Me.Controls.Add(Me.TitleName)
        Me.Controls.Add(Me.Floor1)
        Me.Controls.Add(Me.Floor2)
        Me.Controls.Add(Me.Floor3)
        Me.Controls.Add(Me.Floor4)
        Me.Controls.Add(Me.Floor5)
        Me.Controls.Add(BackBtn)
        Me.Name = "OverrideFloor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackBtn As Button
    Friend WithEvents Floor5 As Button
    Friend WithEvents Floor4 As Button
    Friend WithEvents Floor3 As Button
    Friend WithEvents Floor2 As Button
    Friend WithEvents Floor1 As Button
    Friend WithEvents TitleName As Label
    Friend WithEvents FloorLabel As Label
    Friend WithEvents Timer As Timer
End Class
