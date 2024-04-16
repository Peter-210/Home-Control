Public Class LightRow
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LightRowTitle.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOFF.CheckedChanged

    End Sub

    Private Sub LightRow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub RemoveRadioButtons()
        Me.RadioButtonON.Dispose()
        Me.RadioButtonOFF.Dispose()
        Me.RadioButtonINTERMEDIATE.Dispose()

        Me.LabelON.Dispose()
        Me.LabelOFF.Dispose()
        Me.Labelmiddle.Dispose()
    End Sub

    Public Sub ExpandLightRowTitle()
        Me.LightRowTitle.AutoSize = True
    End Sub

    Public Sub LightRowWithoutRadioButtons()
        RemoveRadioButtons()
        ExpandLightRowTitle()
    End Sub
End Class
