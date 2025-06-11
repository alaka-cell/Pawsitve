Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Redirect to Form1
        Dim form1 As New Form1()
        form1.Show()

        ' Close Form5
        Me.Close()
    End Sub
End Class
