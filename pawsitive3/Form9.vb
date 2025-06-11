Imports System.Data.SqlClient

Public Class Form9 ' Change this if your form name is different

    ' SQL Server connection string
    Private connectionString As String = "Server=ALAKA\SQLEXPRESS01;Database=Pawsitive;Trusted_Connection=True;"

    ' Load gender and animal options when the form loads
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Gender options
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(New String() {
            "Female", "Male", "Does not wish to specify"
        })

        ' Favorite animal options with emojis
        ComboBox2.Items.Clear()
        ComboBox2.Items.AddRange(New String() {
            "Dog 🐶", "Cat 🐱", "Bird 🐦", "Rabbit 🐰",
            "Hamster 🐹", "Reptile 🦎", "Fish 🐠", "Horse 🐴"
        })
    End Sub

    ' Save Button Click - Button1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Basic validation
        If TextBox1.Text = "" OrElse TextBox2.Text = "" OrElse TextBox5.Text = "" OrElse
           RichTextBox1.Text = "" OrElse ComboBox1.SelectedIndex = -1 OrElse
           ComboBox2.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Phone number validation (must be 10 digits)
        If Not IsNumeric(TextBox2.Text) OrElse TextBox2.Text.Length <> 10 Then
            MessageBox.Show("Phone number must be exactly 10 digits.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert data into PetOwner table
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "INSERT INTO PetOwner (OwnerName, Email, PhoneNumber, Address, DateRegistered, Gender, FavoriteAnimal) " &
                                  "VALUES (@name, @email, @phone, @address, @date, @gender, @animal)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@name", TextBox1.Text)
                cmd.Parameters.AddWithValue("@email", TextBox5.Text)
                cmd.Parameters.AddWithValue("@phone", TextBox2.Text)
                cmd.Parameters.AddWithValue("@address", RichTextBox1.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@gender", ComboBox1.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@animal", ComboBox2.SelectedItem.ToString())
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Pet owner details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Navigate to dashboard (Form8)
        Form8.Show()
        Me.Hide()
    End Sub

    ' Clear Button Click - Button2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox5.Clear()
        RichTextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now
    End Sub
End Class
