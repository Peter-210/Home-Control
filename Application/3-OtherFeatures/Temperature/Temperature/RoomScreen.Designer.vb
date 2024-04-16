<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoomScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomScreen))
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AllRoomBtn = New System.Windows.Forms.Button()
        Me.BedBtn = New System.Windows.Forms.Button()
        Me.BathBtn = New System.Windows.Forms.Button()
        Me.KitchenBtn = New System.Windows.Forms.Button()
        Me.LivingBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.BackBtn.BackgroundImage = CType(resources.GetObject("BackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BackBtn.Location = New System.Drawing.Point(58, 56)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(102, 77)
        Me.BackBtn.TabIndex = 5
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(125, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 54)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Room Selection: Temperature"
        '
        'AllRoomBtn
        '
        Me.AllRoomBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.AllRoomBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AllRoomBtn.ForeColor = System.Drawing.Color.White
        Me.AllRoomBtn.Location = New System.Drawing.Point(221, 238)
        Me.AllRoomBtn.Name = "AllRoomBtn"
        Me.AllRoomBtn.Size = New System.Drawing.Size(379, 99)
        Me.AllRoomBtn.TabIndex = 0
        Me.AllRoomBtn.Tag = ""
        Me.AllRoomBtn.Text = "All Rooms"
        Me.AllRoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AllRoomBtn.UseVisualStyleBackColor = False
        '
        'BedBtn
        '
        Me.BedBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BedBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BedBtn.ForeColor = System.Drawing.Color.White
        Me.BedBtn.Location = New System.Drawing.Point(221, 504)
        Me.BedBtn.Name = "BedBtn"
        Me.BedBtn.Size = New System.Drawing.Size(379, 99)
        Me.BedBtn.TabIndex = 2
        Me.BedBtn.Tag = ""
        Me.BedBtn.Text = "Bedroom"
        Me.BedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BedBtn.UseVisualStyleBackColor = False
        '
        'BathBtn
        '
        Me.BathBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.BathBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BathBtn.ForeColor = System.Drawing.Color.White
        Me.BathBtn.Location = New System.Drawing.Point(221, 775)
        Me.BathBtn.Name = "BathBtn"
        Me.BathBtn.Size = New System.Drawing.Size(379, 99)
        Me.BathBtn.TabIndex = 4
        Me.BathBtn.Text = "Bathroom"
        Me.BathBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BathBtn.UseVisualStyleBackColor = False
        '
        'KitchenBtn
        '
        Me.KitchenBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.KitchenBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.KitchenBtn.ForeColor = System.Drawing.Color.White
        Me.KitchenBtn.Location = New System.Drawing.Point(221, 642)
        Me.KitchenBtn.Name = "KitchenBtn"
        Me.KitchenBtn.Size = New System.Drawing.Size(379, 99)
        Me.KitchenBtn.TabIndex = 3
        Me.KitchenBtn.Text = "Kitchen"
        Me.KitchenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.KitchenBtn.UseVisualStyleBackColor = False
        '
        'LivingBtn
        '
        Me.LivingBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.LivingBtn.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LivingBtn.ForeColor = System.Drawing.Color.White
        Me.LivingBtn.Location = New System.Drawing.Point(221, 374)
        Me.LivingBtn.Name = "LivingBtn"
        Me.LivingBtn.Size = New System.Drawing.Size(379, 99)
        Me.LivingBtn.TabIndex = 1
        Me.LivingBtn.Tag = ""
        Me.LivingBtn.Text = "Living Room"
        Me.LivingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LivingBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.home_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(504, 246)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 82)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.living
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(504, 382)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(79, 82)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.bedcontrols
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(504, 512)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(79, 82)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.kitchen
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(504, 650)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(79, 82)
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.B1_HOME_CONTROL.My.Resources.Resources.washroom
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(504, 783)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(79, 82)
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'RoomScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LivingBtn)
        Me.Controls.Add(Me.KitchenBtn)
        Me.Controls.Add(Me.BathBtn)
        Me.Controls.Add(Me.BedBtn)
        Me.Controls.Add(Me.AllRoomBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBtn)
        Me.Name = "RoomScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Control"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AllRoomBtn As Button
    Friend WithEvents BedBtn As Button
    Friend WithEvents BathBtn As Button
    Friend WithEvents KitchenBtn As Button
    Friend WithEvents LivingBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
