' New class for ViewSubmissionsForm
Public Class ViewSubmissionsForm
    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        MessageBox.Show("Previous")
    End Sub
    Private Sub PreviousButton_KeyDown(sender As Object, e As KeyEventArgs) Handles PreviousButton.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.P Then
            MessageBox.Show("Previous")
        End If
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.N Then
            MessageBox.Show("Next")
        End If
    End Sub
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        MessageBox.Show("Next")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class