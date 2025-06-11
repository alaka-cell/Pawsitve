Imports System.Data.SqlClient

Public Class Form3
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            ' Define the database connection string
            Dim connectionString As String = "Server=ALAKA\SQLEXPRESS01;Database=Pawsitive;Trusted_Connection=True;"

            ' Generate a unique Mood_ID
            Dim moodID As String = "MOOD-" & Guid.NewGuid().ToString("N").Substring(0, 8)

            ' Replace this with how you retrieve the active pet's ID
            Dim petID As String = GetCurrentPetID()

            ' Get the selected mood
            Dim selectedMood As String = GetSelectedMood()

            ' If no mood is selected, show an error and exit
            If selectedMood = "" Then
                MessageBox.Show("Please select a mood before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Define SQL query to insert mood data
            Dim query As String = "INSERT INTO MoodTracker (Mood_ID, Pet_ID, Date_Logged, Mood) 
                               VALUES (@MoodID, @PetID, GETDATE(), @Mood)"

            ' Use SqlConnection and SqlCommand with 'Using' statement
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@MoodID", moodID)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    cmd.Parameters.AddWithValue("@Mood", selectedMood)

                    Try
                        ' Open connection and execute the query
                        conn.Open()
                        cmd.ExecuteNonQuery()

                        ' Show success message
                        MessageBox.Show("Mood logged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Open Form4 and hide Form3
                        Dim form4 As New Form4()
                    Form8.Show()
                    Me.Hide()

                    Catch ex As Exception
                        ' Show error message
                        MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End Sub

        ' Function to get selected mood
        Private Function GetSelectedMood() As String
            If RadioButton1.Checked Then Return "Happy"
            If RadioButton2.Checked Then Return "Silly"
            If RadioButton3.Checked Then Return "Relaxed"
            If RadioButton4.Checked Then Return "Hyper active"
            If RadioButton5.Checked Then Return "Tired"
            If RadioButton6.Checked Then Return "Sad"
            Return ""
        End Function

        ' Function to get the current pet's ID (Modify this as needed)
        Private Function GetCurrentPetID() As String
            ' Retrieve from a global variable, database, or session tracking
            Return "PET-12345678" ' Placeholder, update with actual logic
        End Function
    End Class
