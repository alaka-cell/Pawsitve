Public Class Form8
    ' Button1 takes the user to Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New Form2()
        form.Show()
        Me.Hide()
    End Sub

    ' Button2 takes the user to Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New Form3()
        form.Show()
        Me.Hide()
    End Sub

    ' Button3 takes the user to Form6
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As New Form6()
        form.Show()
        Me.Hide()
    End Sub

    ' Button4 takes the user to Form4
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form As New Form4()
        form.Show()
        Me.Hide()
    End Sub

    ' Button5 takes the user to Form7
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form As New Form7()
        form.Show()
        Me.Hide()
    End Sub

    ' Button6 takes the user to Form9
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim form As New Form9()
        form.Show()
        Me.Hide()
    End Sub
End Class


