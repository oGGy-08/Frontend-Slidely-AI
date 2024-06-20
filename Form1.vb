Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set button text
        Button1.Text = "View Submissions (CTRL+V)"
        Button2.Text = "Create New Submission (CTRL+N)"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Code to handle "View Submissions" button click
        ViewSubmissionsForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Code to handle "Create New Submission" button click
        ' (e.g., Open a new form to create a submission)
        CreateSubmission.Show()
    End Sub
    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            ViewSubmissionsForm.Show()
        End If
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.N Then
            CreateSubmission.Show()
        End If
    End Sub

End Class


