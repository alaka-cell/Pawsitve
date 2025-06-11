Imports System.Data.SqlClient

Public Class Form7
    Private connectionString As String = "Server=ALAKA\SQLEXPRESS01;Database=Pawsitive;Trusted_Connection=True;"

    ' Form Load
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetNames()
        LoadDataGridView()        ' Load all pets' data
        UpdateLabels()            ' Load all pets' stats
    End Sub

    ' Load Pet Names into ComboBox
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

    ' Load DataGridView - Optional filtering by pet
    Private Sub LoadDataGridView(Optional petName As String = "")
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim query As String

            If petName = "" Then
                query = "SELECT 'Mood' AS Category, Mood AS Detail, Date_Logged AS Date FROM MoodTracker " &
                        "UNION ALL " &
                        "SELECT 'Habit', HabitName, DateTracked FROM Habits " &
                        "UNION ALL " &
                        "SELECT 'Diet', FoodItem, DateLogged FROM DietTracker"
            Else
                query = "SELECT 'Mood' AS Category, Mood AS Detail, Date_Logged AS Date FROM MoodTracker WHERE Pet_ID = @PetName " &
                        "UNION ALL " &
                        "SELECT 'Habit', HabitName, DateTracked FROM Habits WHERE PetName = @PetName " &
                        "UNION ALL " &
                        "SELECT 'Diet', FoodItem, DateLogged FROM DietTracker WHERE PetName = @PetName"
            End If

            Dim adapter As New SqlDataAdapter(query, con)
            If petName <> "" Then
                adapter.SelectCommand.Parameters.AddWithValue("@PetName", petName)
            End If

            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    ' Update Labels - Optional filtering by pet
    Private Sub UpdateLabels(Optional petName As String = "")
        Using con As New SqlConnection(connectionString)
            con.Open()

            Dim moodQuery As String = "SELECT TOP 1 Mood FROM MoodTracker"
            Dim moodGroup As String = " GROUP BY Mood ORDER BY COUNT(*) DESC"

            Dim habitCountQuery As String = "SELECT COUNT(*) FROM Habits"
            Dim dietCountQuery As String = "SELECT COUNT(*) FROM DietTracker"
            Dim commonHabitQuery As String = "SELECT TOP 1 HabitName FROM Habits"

            If petName <> "" Then
                moodQuery &= " WHERE Pet_ID = @PetName" & moodGroup
                habitCountQuery &= " WHERE PetName = @PetName"
                dietCountQuery &= " WHERE PetName = @PetName"
                commonHabitQuery &= " WHERE PetName = @PetName GROUP BY HabitName ORDER BY COUNT(*) DESC"
            Else
                moodQuery &= moodGroup
                commonHabitQuery &= " GROUP BY HabitName ORDER BY COUNT(*) DESC"
            End If

            ' Most Frequent Mood
            Dim cmd1 As New SqlCommand(moodQuery, con)
            If petName <> "" Then cmd1.Parameters.AddWithValue("@PetName", petName)
            Dim moodResult = cmd1.ExecuteScalar()
            Label1.Text = If(moodResult IsNot Nothing, moodResult.ToString(), "No Data")

            ' Total Habits Tracked
            Dim cmd2 As New SqlCommand(habitCountQuery, con)
            If petName <> "" Then cmd2.Parameters.AddWithValue("@PetName", petName)
            Label2.Text = cmd2.ExecuteScalar().ToString()

            ' Total Diet Records
            Dim cmd3 As New SqlCommand(dietCountQuery, con)
            If petName <> "" Then cmd3.Parameters.AddWithValue("@PetName", petName)
            Label3.Text = cmd3.ExecuteScalar().ToString()

            ' Most Common Habit
            Dim cmd4 As New SqlCommand(commonHabitQuery, con)
            If petName <> "" Then cmd4.Parameters.AddWithValue("@PetName", petName)
            Dim habitResult = cmd4.ExecuteScalar()
            Label4.Text = If(habitResult IsNot Nothing, habitResult.ToString(), "No Data")
        End Using
    End Sub

    ' Load Button Click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim selectedPet As String = ComboBox1.SelectedItem.ToString()
            LoadDataGridView(selectedPet)
            UpdateLabels(selectedPet)
        Else
            MessageBox.Show("Please select a pet to load its data.")
        End If
    End Sub

    ' Dashboard Navigation
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form8 As New Form8
        Form8.Show()
        Me.Hide()
    End Sub
End Class

