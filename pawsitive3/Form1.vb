Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enteredUsername As String = TextBox1.Text
        Dim enteredPassword As String = TextBox2.Text

        If enteredUsername = "catchan" AndAlso enteredPassword = "catchan11" Then
            ' ✅ Normal login (go to Form2)
            ProgressBar1.Value = 0
            Timer1.Enabled = True
        Else
            ' ❌ Wrong password (go to Form5)
            MessageBox.Show("Incorrect password >:(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim form5 As New Form5()
            form5.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' 🔗 Clicking the LinkLabel redirects to Form5
        MessageBox.Show("Very forgetful :(", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim form5 As New Form5()
        form5.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 10
        Else
            Timer1.Enabled = False
            MessageBox.Show("Logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open Form2 (normal login) and hide Form1
            Dim form2 As New Form2()
            Form8.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Timer1.Interval = 100
        Timer1.Enabled = False
    End Sub
End Class


