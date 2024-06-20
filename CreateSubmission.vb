Imports System.Xml
Imports System.IO
Imports System.Text.Json

Public Class CreateSubmission
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 1. Capture user input from form fields
        Dim name As String = NameBox.Text
        Dim email As String = eMailBox.Text
        Dim phoneNumber As String = PhoneBox.Text
        Dim gitHubLink As String = LinkBox.Text
        Dim timetrack As String = timekeep.Text

        ' 3. Create a data object to structure the data
        Dim userData As New With {
            .Name = name,
            .Email = email,
            .PhoneNumber = phoneNumber,
            .GitHubLink = gitHubLink,
            .Timetrack = timetrack
        }

        ' 4. Convert data object to JSON string
        Dim jsonString As String = Convert.ToString(userData)
        MessageBox.Show(jsonString)

        ' 5. Choose a suitable file path for saving
        Dim filePath As String = Path.Combine(My.Computer.FileSystem.CurrentDirectory, "user_data.json")  ' Save in application directory

        MessageBox.Show("Data has been saved!")
    End Sub

    ' Keyboard Shortcuts for Save and Toggling Stopwatch
    Private Sub NameBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NameBox.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.S Then
            MessageBox.Show("Data has been saved!")
        End If
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.T Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
                Timer1.Stop()
                Me.StopWatch.Stop()
            Else
                Timer1.Enabled = True
                Me.StopWatch.Start()
                Timer1.Start()
            End If
        End If
    End Sub
    Private Sub eMailBox_KeyDown(sender As Object, e As KeyEventArgs) Handles eMailBox.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.S Then
            MessageBox.Show("Data has been saved!")
        End If
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.T Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
                Timer1.Stop()
                Me.StopWatch.Stop()
            Else
                Timer1.Enabled = True
                Me.StopWatch.Start()
                Timer1.Start()
            End If
        End If
    End Sub
    Private Sub PhoneBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PhoneBox.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.S Then
            MessageBox.Show("Data has been saved!")
        End If
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.T Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
                Timer1.Stop()
                Me.StopWatch.Stop()
            Else
                Timer1.Enabled = True
                Me.StopWatch.Start()
                Timer1.Start()
            End If
        End If
    End Sub
    Private Sub LinkBox_KeyDown(sender As Object, e As KeyEventArgs) Handles LinkBox.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.S Then
            MessageBox.Show("Data has been saved!")
        End If
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.T Then
            If Timer1.Enabled = True Then
                Timer1.Enabled = False
                Timer1.Stop()
                Me.StopWatch.Stop()
            Else
                Timer1.Enabled = True
                Me.StopWatch.Start()
                Timer1.Start()
            End If
        End If
    End Sub

    ' Stopwatch
    Dim StopWatch As New Diagnostics.Stopwatch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
            Timer1.Stop()
            Me.StopWatch.Stop()
        Else
            Timer1.Enabled = True
            Me.StopWatch.Start()
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.StopWatch.Elapsed
        timekeep.Text = String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds)
    End Sub
End Class