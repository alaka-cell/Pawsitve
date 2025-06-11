Imports System.Data.SqlClient

Public Class Form4
    ' SQL Server connection string
    Private connectionString As String = "Server=ALAKA\SQLEXPRESS01;Database=Pawsitive;Trusted_Connection=True;"

    ' Load pet names and frequency options when form opens
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetNames()
        LoadFrequencyOptions()
    End Sub

    ' Fetch pet names from the database
    Private Sub LoadPetNames()
        ComboBox1.Items.Clear()
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("SELECT Name FROM Pet3", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                ComboBox1.Items.Add(reader("Name").ToString())
            End While
        End Using
    End Sub

    ' Load predefined frequency options
    Private Sub LoadFrequencyOptions()
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Daily")
        ComboBox2.Items.Add("Weekly")
        ComboBox2.Items.Add("Monthly")
    End Sub

    ' Save habit to database
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate form inputs
        If ComboBox1.SelectedIndex = -1 OrElse TextBox1.Text = "" OrElse ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "INSERT INTO Habits (PetName, HabitName, Frequency, DateTracked, Completed, Notes) VALUES (@pet, @habit, @freq, @date, @completed, @notes)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@pet", ComboBox1.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@habit", TextBox1.Text)
                cmd.Parameters.AddWithValue("@freq", ComboBox2.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@completed", CheckBox1.Checked)
                cmd.Parameters.AddWithValue("@notes", RichTextBox1.Text) ' RichTextBox instead of TextBox
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Habit saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ResetForm() ' Clear form after saving

        ' Open Form6 when Button1 is clicked
        Dim form6 As New Form6()
        Form8.Show()
        Me.Hide() ' Hide Form4 (optional)
    End Sub

    ' Reset form fields
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        ComboBox2.SelectedIndex = -1
        CheckBox1.Checked = False
        DateTimePicker1.Value = DateTime.Now
        RichTextBox1.Clear() ' Clear RichTextBox instead of TextBox
    End Sub
End Class
