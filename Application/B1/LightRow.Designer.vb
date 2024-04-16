<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LightRow
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
        Me.LightRowTitle = New System.Windows.Forms.Label()
        Me.RadioButtonON = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOFF = New System.Windows.Forms.RadioButton()
        Me.RadioButtonINTERMEDIATE = New System.Windows.Forms.RadioButton()
        Me.LabelON = New System.Windows.Forms.Label()
        Me.LabelOFF = New System.Windows.Forms.Label()
        Me.Labelmiddle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LightRowTitle
        '
        Me.LightRowTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LightRowTitle.ForeColor = System.Drawing.Color.White
        Me.LightRowTitle.Location = New System.Drawing.Point(21, 59)
        Me.LightRowTitle.Name = "LightRowTitle"
        Me.LightRowTitle.Size = New System.Drawing.Size(172, 98)
        Me.LightRowTitle.TabIndex = 0
        Me.LightRowTitle.Text = "Label1"
        '
        'RadioButtonON
        '
        Me.RadioButtonON.AutoSize = True
        Me.RadioButtonON.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButtonON.Location = New System.Drawing.Point(231, 82)
        Me.RadioButtonON.Name = "RadioButtonON"
        Me.RadioButtonON.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonON.TabIndex = 1
        Me.RadioButtonON.UseVisualStyleBackColor = True
        '
        'RadioButtonOFF
        '
        Me.RadioButtonOFF.AutoSize = True
        Me.RadioButtonOFF.Checked = True
        Me.RadioButtonOFF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButtonOFF.Location = New System.Drawing.Point(286, 82)
        Me.RadioButtonOFF.Name = "RadioButtonOFF"
        Me.RadioButtonOFF.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonOFF.TabIndex = 2
        Me.RadioButtonOFF.TabStop = True
        Me.RadioButtonOFF.UseVisualStyleBackColor = True
        '
        'RadioButtonINTERMEDIATE
        '
        Me.RadioButtonINTERMEDIATE.AutoSize = True
        Me.RadioButtonINTERMEDIATE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButtonINTERMEDIATE.Location = New System.Drawing.Point(351, 82)
        Me.RadioButtonINTERMEDIATE.Name = "RadioButtonINTERMEDIATE"
        Me.RadioButtonINTERMEDIATE.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonINTERMEDIATE.TabIndex = 3
        Me.RadioButtonINTERMEDIATE.UseVisualStyleBackColor = True
        '
        'LabelON
        '
        Me.LabelON.AutoSize = True
        Me.LabelON.ForeColor = System.Drawing.Color.White
        Me.LabelON.Location = New System.Drawing.Point(227, 59)
        Me.LabelON.Name = "LabelON"
        Me.LabelON.Size = New System.Drawing.Size(23, 15)
        Me.LabelON.TabIndex = 4
        Me.LabelON.Text = "On"
        '
        'LabelOFF
        '
        Me.LabelOFF.AutoSize = True
        Me.LabelOFF.ForeColor = System.Drawing.Color.White
        Me.LabelOFF.Location = New System.Drawing.Point(282, 59)
        Me.LabelOFF.Name = "LabelOFF"
        Me.LabelOFF.Size = New System.Drawing.Size(24, 15)
        Me.LabelOFF.TabIndex = 5
        Me.LabelOFF.Text = "Off"
        '
        'Labelmiddle
        '
        Me.Labelmiddle.AutoSize = True
        Me.Labelmiddle.ForeColor = System.Drawing.Color.White
        Me.Labelmiddle.Location = New System.Drawing.Point(322, 59)
        Me.Labelmiddle.Name = "Labelmiddle"
        Me.Labelmiddle.Size = New System.Drawing.Size(74, 15)
        Me.Labelmiddle.TabIndex = 6
        Me.Labelmiddle.Text = "Intermediate"
        '
        'LightRow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Labelmiddle)
        Me.Controls.Add(Me.LabelOFF)
        Me.Controls.Add(Me.LabelON)
        Me.Controls.Add(Me.RadioButtonINTERMEDIATE)
        Me.Controls.Add(Me.RadioButtonOFF)
        Me.Controls.Add(Me.RadioButtonON)
        Me.Controls.Add(Me.LightRowTitle)
        Me.Name = "LightRow"
        Me.Size = New System.Drawing.Size(426, 178)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LightRowTitle As Label
    Friend WithEvents RadioButtonON As RadioButton
    Friend WithEvents RadioButtonOFF As RadioButton
    Friend WithEvents RadioButtonINTERMEDIATE As RadioButton
    Friend WithEvents LabelON As Label
    Friend WithEvents LabelOFF As Label
    Friend WithEvents Labelmiddle As Label
End Class
