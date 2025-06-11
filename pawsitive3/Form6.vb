Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form6
    ' SQL Server connection string
    Private connectionString As String = "Server=ALAKA\SQLEXPRESS01;Database=Pawsitive;Trusted_Connection=True;"

    ' Load pet names and meal types when form opens
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetNames()
        LoadMealTypes()
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

    ' Load meal types into ComboBox2
    Private Sub LoadMealTypes()
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("Breakfast")
        ComboBox2.Items.Add("Lunch")
        ComboBox2.Items.Add("Dinner")
        ComboBox2.Items.Add("Snack")
    End Sub

    ' Save diet record to database and open Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate form inputs
        If ComboBox1.SelectedIndex = -1 OrElse TextBox1.Text = "" OrElse NumericUpDown1.Value = 0 OrElse ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String = "INSERT INTO DietTracker (PetName, FoodItem, Quantity, MealType, DateLogged, Notes) VALUES (@pet, @food, @quantity, @meal, @date, @notes)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@pet", ComboBox1.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@food", TextBox1.Text)
                cmd.Parameters.AddWithValue("@quantity", CInt(NumericUpDown1.Value))
                cmd.Parameters.AddWithValue("@meal", ComboBox2.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@notes", RichTextBox1.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Diet entry saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' ✅ Open Form7 after saving
        Dim form7 As New Form7
        Form8.Show()

        ' Reset the form
        ResetForm()
    End Sub

    ' Reset form fields
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        NumericUpDown1.Value = 0
        ComboBox2.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Now
        RichTextBox1.Clear()
    End Sub
End Class

