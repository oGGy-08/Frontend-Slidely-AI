<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmission
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.LinkBox = New System.Windows.Forms.TextBox()
        Me.PhoneBox = New System.Windows.Forms.TextBox()
        Me.eMailBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timekeep = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "e-Mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "GitHub Link for Task 2"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(309, 129)
        Me.NameBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(264, 26)
        Me.NameBox.TabIndex = 0
        '
        'LinkBox
        '
        Me.LinkBox.Location = New System.Drawing.Point(309, 306)
        Me.LinkBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LinkBox.Name = "LinkBox"
        Me.LinkBox.Size = New System.Drawing.Size(264, 26)
        Me.LinkBox.TabIndex = 3
        '
        'PhoneBox
        '
        Me.PhoneBox.Location = New System.Drawing.Point(309, 240)
        Me.PhoneBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(264, 26)
        Me.PhoneBox.TabIndex = 2
        '
        'eMailBox
        '
        Me.eMailBox.Location = New System.Drawing.Point(309, 184)
        Me.eMailBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.eMailBox.Name = "eMailBox"
        Me.eMailBox.Size = New System.Drawing.Size(264, 26)
        Me.eMailBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 381)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 49)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Toggle Stopwatch (CTRL+T)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(269, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(348, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Devansh Chauhan - Task 2 - Create Submission"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(351, 471)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 52)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Save (CTRL + S)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'timekeep
        '
        Me.timekeep.AutoSize = True
        Me.timekeep.Location = New System.Drawing.Point(443, 395)
        Me.timekeep.Name = "timekeep"
        Me.timekeep.Size = New System.Drawing.Size(71, 20)
        Me.timekeep.TabIndex = 10
        Me.timekeep.Text = "00:00:00"
        '
        'CreateSubmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.timekeep)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.eMailBox)
        Me.Controls.Add(Me.PhoneBox)
        Me.Controls.Add(Me.LinkBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CreateSubmission"
        Me.Text = "CreateSubmission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents LinkBox As TextBox
    Friend WithEvents PhoneBox As TextBox
    Friend WithEvents eMailBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timekeep As Label
End Class
