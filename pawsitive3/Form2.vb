Imports System.Data.SqlClient

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear previous errors
        ErrorProvider1.Clear()

        ' Flag to track validation success
        Dim isValid As Boolean = True

        ' Dictionary to store required numeric fields and their error messages
        Dim numericFields As New Dictionary(Of TextBox, String) From {
            {TextBox3, "Enter a valid Age (numbers only)."},
            {TextBox6, "Enter a valid Weight (e.g., 5.2)."}
        }

        ' Validate numeric inputs
        For Each pair In numericFields
            Dim value As Double
            If Not Double.TryParse(pair.Key.Text, value) Then
                ErrorProvider1.SetError(pair.Key, pair.Value)
                isValid = False
            End If
        Next

        ' ✅ **Phone number validation (must be exactly 10 digits)**
        If Not IsNumeric(TextBox10.Text) OrElse TextBox10.Text.Length <> 10 Then
            ErrorProvider1.SetError(TextBox10, "Phone number must be exactly 10 digits.")
            isValid = False
        End If

        ' Validate required text fields (not empty)
        Dim requiredFields As New Dictionary(Of TextBox, String) From {
            {TextBox1, "Name is required."},
            {TextBox2, "Species is required."},
            {TextBox4, "Gender is required."},
            {TextBox7, "Medical conditions field is required."},
            {TextBox8, "Allergies field is required."},
            {TextBox9, "Vet Name is required."}
        }

        For Each pair In requiredFields
            If String.IsNullOrWhiteSpace(pair.Key.Text) Then
                ErrorProvider1.SetError(pair.Key, pair.Value)
                isValid = False
            End If
        Next

        ' If validation fails, stop execution
        If Not isValid Then Exit Sub

        ' ✅ If all inputs are valid, insert into SQL database

        ' Define connection string
        Dim connectionString As String = "Server=ALAKA\SQLEXPRESS01;Database=Pawsitive;Trusted_Connection=True;"

        ' Generate unique pet ID
        Dim petID As String = "PET-" & Guid.NewGuid().ToString("N").Substring(0, 8)

        ' 🔥 FIXED: Use `DateTimePicker1.Value` instead of `TextBox5.Text`
        Dim petBirthday As Date = DateTimePicker1.Value

        ' SQL query with pet_id included
        Dim query As String = "INSERT INTO Pet3 ( Name, Species, Age, Gender, Birthday, Weight, Medical_conditions, Allergies, Vetname, Vet_phno) 
                               VALUES ( @Name, @Species, @Age, @Gender, @Birthday, @Weight, @Medical_conditions, @Allergies, @Vetname, @Vet_phno)"

        ' Execute SQL command
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' Add parameters
                cmd.Parameters.AddWithValue("@Name", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Species", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(TextBox3.Text))
                cmd.Parameters.AddWithValue("@Gender", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Birthday", petBirthday) ' 🟢 FIXED: Use DateTimePicker1.Value
                cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(TextBox6.Text))
                cmd.Parameters.AddWithValue("@Medical_conditions", TextBox7.Text)
                cmd.Parameters.AddWithValue("@Allergies", TextBox8.Text)
                cmd.Parameters.AddWithValue("@Vetname", TextBox9.Text)
                cmd.Parameters.AddWithValue("@Vet_phno", TextBox10.Text) ' ✅ No need to convert to Int64

                Try
                    ' Open connection and execute query
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if insert was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Pet added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Open Form3 and hide Form2
                        Form8.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Failed to add pet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
