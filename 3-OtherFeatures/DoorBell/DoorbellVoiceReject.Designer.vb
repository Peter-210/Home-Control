﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoorbellVoiceReject
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(318, 280)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(185, 90)
        Me.btn1.TabIndex = 19
        Me.btn1.Text = "If you'd like to leave a message. Please do it now"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(318, 645)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(185, 90)
        Me.btn4.TabIndex = 18
        Me.btn4.Text = "I cannot answer the door right now."
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(318, 525)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(185, 90)
        Me.btn3.TabIndex = 17
        Me.btn3.Text = "Thanks for stopping by."
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(318, 399)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(185, 90)
        Me.btn2.TabIndex = 16
        Me.btn2.Text = "Sorry, we're not interested"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(296, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 46)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Quick Replies"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(59, 42)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DoorbellVoiceReject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 1045)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Name = "DoorbellVoiceReject"
        Me.Text = "DoorbellVoiceReject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
