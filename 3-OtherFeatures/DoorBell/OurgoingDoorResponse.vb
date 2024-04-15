Imports System.Threading

Public Class OurgoingDoorResponse

    Private Sub OurgoingDoorResponse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        PictureBox3.Visible = False
        PictureBox4.Visible = False
    End Sub

    Private Sub statusTimer_Tick(sender As Object, e As EventArgs) Handles statusTimer.Tick
        Dim randNum As Integer
        randNum = rand()
        'btnStatusResponse.Text = CType(randNum, String)


        countdownLabel.Text -= 1
        If (0 Mod 2 > 0) Then
            If (countdownLabel.Text = 0) Then
                PictureBox4.Visible = True
                btnStatusResponse.Text = "Cancelled"
                btnStatusResponse.AutoSize = False
                btnStatusResponse.TextAlign = ContentAlignment.MiddleCenter
                statusTimer.Stop()
                cancelTimer.Start()
            End If

        Else
            If (countdownLabel.Text = 0) Then
                PictureBox3.Visible = True
                btnStatusResponse.Text = "Accepted"
                btnStatusResponse.AutoSize = False
                btnStatusResponse.TextAlign = ContentAlignment.MiddleCenter
                statusTimer.Stop()
                confirmTimer.Start()
            End If
        End If
    End Sub

    Private Sub responseTimer_Tick(sender As Object, e As EventArgs) Handles responseTimer.Tick
        responseTimer.Stop()
    End Sub

    Private Sub confirmTimer_Tick(sender As Object, e As EventArgs) Handles confirmTimer.Tick
        Dim confirm As New OutGoingDoorbellConfirmation
        confirm.Show()
        confirmTimer.Stop()
        Me.Close()
    End Sub

    Private Sub cancelTimer_Tick(sender As Object, e As EventArgs) Handles cancelTimer.Tick
        Dim cancel As New OutgoingDoorConfirmationCancel
        cancel.Show()
        cancelTimer.Stop()
        Me.Close()
    End Sub


    Private Sub btnCancelRequest_Click(sender As Object, e As EventArgs) Handles btnCancelRequest.Click
        responseTimer.Stop()
        statusTimer.Stop()
        confirmTimer.Stop()
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        btnStatusResponse.Text = "Cancelled Request"
        ' btnStatusResponse.Location = New Point(250, 153)

        estimatedTimeLabel.Visible = False
        countdownLabel.Visible = False
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        PictureBox4.Visible = True
        Me.Close()
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatusResponse.Click

    End Sub



    Private Function rand() As Integer
        Dim randnum As New Random
        Dim x As Integer = randnum.Next(1, 3)
        Return x
    End Function
End Class