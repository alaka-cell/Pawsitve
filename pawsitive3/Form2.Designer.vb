<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        Button1 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        DateTimePicker1 = New DateTimePicker()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(638, 146)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(322, 302)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 23)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(34, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 25)
        Label2.TabIndex = 2
        Label2.Text = "Breed"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(42, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 23)
        Label3.TabIndex = 3
        Label3.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(34, 315)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 23)
        Label4.TabIndex = 4
        Label4.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(34, 408)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 23)
        Label5.TabIndex = 5
        Label5.Text = "Birthday"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(336, 71)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 23)
        Label6.TabIndex = 6
        Label6.Text = "Weight"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(302, 152)
        Label7.Name = "Label7"
        Label7.Size = New Size(147, 23)
        Label7.TabIndex = 7
        Label7.Text = "Medical condition"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(336, 233)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 23)
        Label8.TabIndex = 8
        Label8.Text = "Allergies"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(324, 315)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 23)
        Label9.TabIndex = 9
        Label9.Text = "Vet Name"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(314, 410)
        Label10.Name = "Label10"
        Label10.Size = New Size(121, 23)
        Label10.TabIndex = 10
        Label10.Text = "Vet Phone No."
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(759, 71)
        Label11.Name = "Label11"
        Label11.Size = New Size(106, 31)
        Label11.TabIndex = 11
        Label11.Text = "PET BIO"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(694, 104)
        Label12.Name = "Label12"
        Label12.Size = New Size(236, 23)
        Label12.TabIndex = 12
        Label12.Text = "Know your fur baby better !"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(124, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(151, 27)
        TextBox1.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(124, 146)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 27)
        TextBox2.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(124, 229)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(151, 27)
        TextBox3.TabIndex = 15
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(124, 315)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(151, 27)
        TextBox4.TabIndex = 16
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(455, 71)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(146, 27)
        TextBox6.TabIndex = 18
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(455, 150)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(146, 27)
        TextBox7.TabIndex = 19
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(455, 234)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(146, 27)
        TextBox8.TabIndex = 20
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(455, 314)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(146, 27)
        TextBox9.TabIndex = 21
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(455, 407)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(146, 27)
        TextBox10.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(260, 465)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 42)
        Button1.TabIndex = 23
        Button1.Text = "Okie <3"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarForeColor = Color.RosyBrown
        DateTimePicker1.CalendarMonthBackground = SystemColors.HotTrack
        DateTimePicker1.CalendarTitleBackColor = Color.White
        DateTimePicker1.CalendarTitleForeColor = SystemColors.AppWorkspace
        DateTimePicker1.CalendarTrailingForeColor = Color.Lavender
        DateTimePicker1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(124, 410)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(151, 27)
        DateTimePicker1.TabIndex = 24
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(982, 530)
        Controls.Add(DateTimePicker1)
        Controls.Add(Button1)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
