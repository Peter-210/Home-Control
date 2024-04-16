<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindowSubMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButtonFullyOpen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHalfOpen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSlightlyOpen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFullyClosed = New System.Windows.Forms.RadioButton()
        Me.WindowSubMenuTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fully Open"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(137, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Half Open"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Slightly Open"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(137, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fully Closed"
        '
        'RadioButtonFullyOpen
        '
        Me.RadioButtonFullyOpen.AutoSize = True
        Me.RadioButtonFullyOpen.Location = New System.Drawing.Point(43, 73)
        Me.RadioButtonFullyOpen.Name = "RadioButtonFullyOpen"
        Me.RadioButtonFullyOpen.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonFullyOpen.TabIndex = 4
        Me.RadioButtonFullyOpen.UseVisualStyleBackColor = True
        '
        'RadioButtonHalfOpen
        '
        Me.RadioButtonHalfOpen.AutoSize = True
        Me.RadioButtonHalfOpen.Location = New System.Drawing.Point(160, 73)
        Me.RadioButtonHalfOpen.Name = "RadioButtonHalfOpen"
        Me.RadioButtonHalfOpen.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonHalfOpen.TabIndex = 5
        Me.RadioButtonHalfOpen.UseVisualStyleBackColor = True
        '
        'RadioButtonSlightlyOpen
        '
        Me.RadioButtonSlightlyOpen.AutoSize = True
        Me.RadioButtonSlightlyOpen.Location = New System.Drawing.Point(43, 142)
        Me.RadioButtonSlightlyOpen.Name = "RadioButtonSlightlyOpen"
        Me.RadioButtonSlightlyOpen.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonSlightlyOpen.TabIndex = 6
        Me.RadioButtonSlightlyOpen.UseVisualStyleBackColor = True
        '
        'RadioButtonFullyClosed
        '
        Me.RadioButtonFullyClosed.AutoSize = True
        Me.RadioButtonFullyClosed.Checked = True
        Me.RadioButtonFullyClosed.Location = New System.Drawing.Point(160, 142)
        Me.RadioButtonFullyClosed.Name = "RadioButtonFullyClosed"
        Me.RadioButtonFullyClosed.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonFullyClosed.TabIndex = 7
        Me.RadioButtonFullyClosed.TabStop = True
        Me.RadioButtonFullyClosed.UseVisualStyleBackColor = True
        '
        'WindowSubMenuTitle
        '
        Me.WindowSubMenuTitle.AutoSize = True
        Me.WindowSubMenuTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WindowSubMenuTitle.ForeColor = System.Drawing.Color.White
        Me.WindowSubMenuTitle.Location = New System.Drawing.Point(85, 15)
        Me.WindowSubMenuTitle.Name = "WindowSubMenuTitle"
        Me.WindowSubMenuTitle.Size = New System.Drawing.Size(56, 21)
        Me.WindowSubMenuTitle.TabIndex = 8
        Me.WindowSubMenuTitle.Text = "Label5"
        '
        'WindowSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WindowSubMenuTitle)
        Me.Controls.Add(Me.RadioButtonFullyClosed)
        Me.Controls.Add(Me.RadioButtonSlightlyOpen)
        Me.Controls.Add(Me.RadioButtonHalfOpen)
        Me.Controls.Add(Me.RadioButtonFullyOpen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WindowSubMenu"
        Me.Size = New System.Drawing.Size(230, 173)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButtonFullyOpen As RadioButton
    Friend WithEvents RadioButtonHalfOpen As RadioButton
    Friend WithEvents RadioButtonSlightlyOpen As RadioButton
    Friend WithEvents RadioButtonFullyClosed As RadioButton
    Friend WithEvents WindowSubMenuTitle As Label
End Class
