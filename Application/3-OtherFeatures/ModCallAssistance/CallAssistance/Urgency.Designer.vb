<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Urgency
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
        Me.Minor = New System.Windows.Forms.Button()
        Me.Necessary = New System.Windows.Forms.Button()
        Me.Urgent = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Minor
        '
        Me.Minor.BackColor = System.Drawing.Color.Green
        Me.Minor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Minor.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Minor.ForeColor = System.Drawing.Color.White
        Me.Minor.Location = New System.Drawing.Point(292, 630)
        Me.Minor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Minor.Name = "Minor"
        Me.Minor.Size = New System.Drawing.Size(228, 168)
        Me.Minor.TabIndex = 3
        Me.Minor.Text = "Minor"
        Me.Minor.UseVisualStyleBackColor = False
        '
        'Necessary
        '
        Me.Necessary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Necessary.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Necessary.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Necessary.ForeColor = System.Drawing.Color.White
        Me.Necessary.Location = New System.Drawing.Point(292, 450)
        Me.Necessary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Necessary.Name = "Necessary"
        Me.Necessary.Size = New System.Drawing.Size(228, 166)
        Me.Necessary.TabIndex = 2
        Me.Necessary.Text = "Necessary"
        Me.Necessary.UseVisualStyleBackColor = False
        '
        'Urgent
        '
        Me.Urgent.BackColor = System.Drawing.Color.Red
        Me.Urgent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Urgent.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Urgent.ForeColor = System.Drawing.Color.White
        Me.Urgent.Location = New System.Drawing.Point(292, 247)
        Me.Urgent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Urgent.Name = "Urgent"
        Me.Urgent.Size = New System.Drawing.Size(228, 189)
        Me.Urgent.TabIndex = 1
        Me.Urgent.Text = "Urgent"
        Me.Urgent.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(181, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please Select the Urgency of Request"
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Back.BackgroundImage = Global.CallAssistance.My.Resources.Resources.back
        Me.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Back.Location = New System.Drawing.Point(69, 69)
        Me.Back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(82, 56)
        Me.Back.TabIndex = 4
        Me.Back.UseVisualStyleBackColor = False
        '
        'Urgency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CallAssistance.My.Resources.Resources.ipad_white
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Urgent)
        Me.Controls.Add(Me.Necessary)
        Me.Controls.Add(Me.Minor)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Urgency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Urgency"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minor As Button
    Friend WithEvents Necessary As Button
    Friend WithEvents Urgent As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Back As Button
End Class
