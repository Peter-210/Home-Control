<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoorbellMessageReject
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(59, 42)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(296, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 46)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Quick Replies"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(318, 280)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(185, 90)
        Me.btn1.TabIndex = 20
        Me.btn1.Text = "Sorry, I'm Not Available"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(318, 645)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(185, 90)
        Me.btn4.TabIndex = 19
        Me.btn4.Text = "Busy"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(318, 525)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(185, 90)
        Me.btn3.TabIndex = 18
        Me.btn3.Text = "I'm not here"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(318, 399)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(185, 90)
        Me.btn2.TabIndex = 17
        Me.btn2.Text = "Come Another Time"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'DoorbellMessageReject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnBack)
        Me.Location = New System.Drawing.Point(285, 87)
        Me.Name = "DoorbellMessageReject"
        Me.Text = "DoorbellMessageReject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
End Class
