Imports System.Data.SqlClient
Public Class Dashboard

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\NIMITH\DOCUMENTS\DBRESULTS.MDF;Integrated Security=True;Connect Timeout=30")
    Private Sub RegGOBTN_Click(sender As Object, e As EventArgs) Handles RegGOBTN.Click
        Dim Obj = New ManageStudent
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub BackBTN_Click(sender As Object, e As EventArgs) Handles BackBTN.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDetails()
        ResetAll()
    End Sub
    Public Sub ResetAll(Optional ByVal txtcol As Control.ControlCollection = Nothing)
        Sub1LBL.Text = ""
        Sub2LBL.Text = ""
        Sub3LBL.Text = ""
        Sub4LBL.Text = ""
        AvarageTB.Text = ""
        MarksTB.Text = ""
        StatusTB.Text = ""
        SearchStudentIdTB.Text = ""
        StdFirstNameLBL.Text = ""
        StdLastNameLBL.Text = ""
        StdIdLBL.Text = ""
        YearLBL.Text = ""
        GrammerTB.Text = ""
        HistoryTB.Text = ""
        CultureTB.Text = ""
        LitTB.Text = ""
    End Sub

    Private Sub ResetBTN_Click_1(sender As Object, e As EventArgs) Handles ResetBTN.Click, Guna2GradientButton3.Click
        ResetAll()
    End Sub

    Private Sub Validate_Numbers_Only(sender As Object, e As KeyPressEventArgs) Handles LitTB.KeyPress, GrammerTB.KeyPress, HistoryTB.KeyPress, CultureTB.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GradeBTN_Click_1(sender As Object, e As EventArgs) Handles GradeBTN.Click, Guna2GradientButton1.Click
        ' Get the numeric values from textboxes
        Dim GrammerScore As Double = Val(GrammerTB.Text)
        Dim HistoryScore As Double = Val(HistoryTB.Text)
        Dim CultureScore As Double = Val(CultureTB.Text)
        Dim LitScore As Double = Val(LitTB.Text)

        ' Calculate the average
        Dim AverageScore As Double = (GrammerScore + HistoryScore + CultureScore + LitScore) / 4

        ' Calculate the total marks
        Dim TotalMarks As Double = GrammerScore + HistoryScore + CultureScore + LitScore

        ' Assign letter grades
        Dim GrammerGrade As String = GetLetterGrade(GrammerScore)
        Dim HistoryGrade As String = GetLetterGrade(HistoryScore)
        Dim CultureGrade As String = GetLetterGrade(CultureScore)
        Dim LitGrade As String = GetLetterGrade(LitScore)

        ' Display the results in labels
        AvarageTB.Text = AverageScore.ToString()
        MarksTB.Text = TotalMarks.ToString()
        Sub1LBL.Text = GrammerGrade
        Sub2LBL.Text = HistoryGrade
        Sub3LBL.Text = CultureGrade
        Sub4LBL.Text = LitGrade

        ' Determine the overall course status
        DetermineCourseStatus(AverageScore)
    End Sub

    Private Function GetLetterGrade(score As Double) As String
        ' Define your grading criteria here
        If score >= 90 Then
            Return "A"
        ElseIf score >= 80 Then
            Return "B"
        ElseIf score >= 70 Then
            Return "C"
        ElseIf score >= 60 Then
            Return "D"
        Else
            Return "F"
        End If
    End Function

    Private Sub DetermineCourseStatus(averageScore As Double)
        ' Determine and display the course status based on the average score
        If averageScore >= 60 Then
            StatusTB.Text = "Course Complete"
        Else
            StatusTB.Text = "Course Incomplete"
        End If
    End Sub
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim searchId As Integer
        If Integer.TryParse(SearchStudentIdTB.Text, searchId) Then
            Try
                Con.Open()
                Dim query As String = "SELECT StudentId, StudentFirstName, StudentLastName, Year FROM StudentTbl WHERE StudentId = @StudentId"
                Dim cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@StudentId", searchId)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    StdIdLBL.Text = "" & reader("StudentId").ToString()
                    StdFirstNameLBL.Text = "" & reader("StudentFirstName").ToString()
                    StdLastNameLBL.Text = "" & reader("StudentLastName").ToString()
                    YearLBL.Text = "" & reader("Year").ToString()
                Else
                    MsgBox("Student not found with the given ID")
                    StdIdLBL.Text = ""
                    StdFirstNameLBL.Text = ""
                    StdLastNameLBL.Text = ""
                    YearLBL.Text = ""
                End If

                Con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please enter a valid Student ID")
        End If
    End Sub
    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click, Guna2GradientButton2.Click

        If StdIdLBL.Text = "" Or
            YearLBL.Text = "" Or
            StdFirstNameLBL.Text = "" Or
            StdLastNameLBL.Text = "" Or
            MarksTB.Text = "" Or
            AvarageTB.Text = "" Or
            StatusTB.Text = "" Or
            Sub1LBL.Text = "" Or
            Sub2LBL.Text = "" Or
            Sub3LBL.Text = "" Or
            Sub4LBL.Text = "" Then
            MsgBox("Fill in all the details")
        Else
            Try
                Con.Open()
                Dim query = "INSERT INTO ResultTbl (StudentId, StudentFirstName, Year, StudentLastName, Sub1, Sub2, Sub3, Sub4, Total, Avg, Status) VALUES (@StudentId, @FirstName, @Year, @LastName, @Sub1, @Sub2, @Sub3, @Sub4, @Total, @Avg, @Status)"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@StudentId", StdIdLBL.Text)
                cmd.Parameters.AddWithValue("@FirstName", StdFirstNameLBL.Text)
                cmd.Parameters.AddWithValue("@Year", YearLBL.Text)
                cmd.Parameters.AddWithValue("@LastName", StdLastNameLBL.Text)
                cmd.Parameters.AddWithValue("@Sub1", Sub1LBL.Text)
                cmd.Parameters.AddWithValue("@Sub2", Sub2LBL.Text)
                cmd.Parameters.AddWithValue("@Sub3", Sub3LBL.Text)
                cmd.Parameters.AddWithValue("@Sub4", Sub4LBL.Text)
                cmd.Parameters.AddWithValue("@Total", MarksTB.Text)
                cmd.Parameters.AddWithValue("@Avg", AvarageTB.Text)
                cmd.Parameters.AddWithValue("@Status", StatusTB.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Results added successfully")
                Con.Close()
                Reset() ' Clear all text boxes after adding
                DisplayDetails() ' Instantly display the added student in the table
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End If
    End Sub
    'Code for Item View on Table
    Private Sub DisplayDetails()
        Con.Open()
        Dim query = "select * from ResultTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ResultDataGridView.DataSource = ds.Tables(0)
        Con.Close()
        ResetAll()

    End Sub
    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        ' Check if a row is selected in the DataGridView
        If ResultDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = ResultDataGridView.SelectedRows(0).Index
            Dim studentIdToDelete As Integer = Convert.ToInt32(ResultDataGridView.Rows(selectedRowIndex).Cells("StudentId").Value)

            ' Confirmation dialog to confirm the delete operation
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this student's record?", "Confirm Delete", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ' Delete the record from the database
                Try
                    Con.Open()
                    Dim query As String = "DELETE FROM ResultTbl WHERE StudentId = @StudentId"
                    Dim cmd As New SqlCommand(query, Con)
                    cmd.Parameters.AddWithValue("@StudentId", studentIdToDelete)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Student record deleted successfully.")
                    Con.Close()

                    ' Refresh the DataGridView to reflect the changes
                    DisplayDetails()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Con.Close()
                End Try
            End If
        Else
            MessageBox.Show("Please select a student record to delete.")
        End If
    End Sub
End Class
