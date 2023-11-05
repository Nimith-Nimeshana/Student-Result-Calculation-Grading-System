Imports System.Data.SqlClient
Public Class StudentResults

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\NIMITH\DOCUMENTS\DBRESULTS.MDF;Integrated Security=True;Connect Timeout=30")
    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Application.Exit()
    End Sub
    Public Sub ResetAll(Optional ByVal txtcol As Control.ControlCollection = Nothing)
        Sub1LBL.Text = ""
        Sub2LBL.Text = ""
        Sub3LBL.Text = ""
        Sub4LBL.Text = ""
        StatusLBL.Text = ""
        SearchStudentIdTB.Text = ""
        FirstNameLBL.Text = ""
        LastNameLBL.Text = ""
        StdIdLBL.Text = ""
        YearLBL.Text = ""
    End Sub

    Private Sub ResetBTN_Click_1(sender As Object, e As EventArgs) Handles ResetBtn.Click
        ResetAll()
    End Sub
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim searchId As Integer
        If Integer.TryParse(SearchStudentIdTB.Text, searchId) Then
            Try
                Con.Open()
                Dim query As String = "SELECT StudentId, StudentFirstName, StudentLastName, Year, Sub1, Sub2, Sub3, Sub4, Status FROM ResultTbl WHERE StudentId = @StudentId"
                Dim cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@StudentId", searchId)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    StdIdLBL.Text = "" & reader("StudentId").ToString()
                    FirstNameLBL.Text = "" & reader("StudentFirstName").ToString()
                    LastNameLBL.Text = "" & reader("StudentLastName").ToString()
                    YearLBL.Text = "" & reader("Year").ToString()
                    Sub1LBL.Text = "" & reader("Sub1").ToString()
                    Sub2LBL.Text = "" & reader("Sub2").ToString()
                    Sub3LBL.Text = "" & reader("Sub3").ToString()
                    Sub4LBL.Text = "" & reader("Sub4").ToString()
                    StatusLBL.Text = "" & reader("Status").ToString()

                Else
                    MsgBox("Student not found with the given ID")
                End If

                Con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please enter a valid Student ID")
        End If
    End Sub

    Private Sub StudentResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class