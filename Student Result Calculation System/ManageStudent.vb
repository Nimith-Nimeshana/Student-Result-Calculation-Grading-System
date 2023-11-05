Imports System.Data.SqlClient
Public Class ManageStudent
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\NIMITH\DOCUMENTS\DBRESULTS.MDF;Integrated Security=True;Connect Timeout=30")
    'Logout Button code to Going Back Login Form

    'close button
    Private Sub BackBTN_Click(sender As Object, e As EventArgs) Handles BackBTN.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub DashGOBTN_Click(sender As Object, e As EventArgs) Handles DashGOBTN.Click
        Dim Obj = New Dashboard
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    'Reset Button Code
    Private Sub Reset()
        FirstNameTB.Text = ""
        LastNameTB.Text = ""
        TelTB.Text = ""
        YearCB.SelectedIndex = 0
        SexCB.SelectedIndex = 0
    End Sub
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Reset()
    End Sub
    'DB connections to Category Table & Code for Category Combo Box 
    Private Sub FillYear()
        YearCB.Text = ""
        YearCB.Items.Add("2018")
        YearCB.Items.Add("2019")
        YearCB.Items.Add("2020")
        YearCB.Items.Add("2021")
        YearCB.Items.Add("2022")
        YearCB.Items.Add("2023")

    End Sub
    Private Sub FillSex()
        SexCB.Text = ""
        SexCB.Items.Add("Male")
        SexCB.Items.Add("Female")
    End Sub
    'When load Manage Items Show Category
    Private Sub Manage_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillYear()
        DisplayDetails()
        FillSex()
    End Sub
    'Code for adding a item and validation for add button
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If YearCB.SelectedIndex = -1 Or SexCB.SelectedIndex = -1 Or FirstNameTB.Text = "" Or LastNameTB.Text = "" Or TelTB.Text = "" Then
            MsgBox("Fill in all the details")
        Else
            Try
                Con.Open()
                Dim query = "INSERT INTO StudentTbl (StudentFirstName, Year, StudentLastName, Tel, Sex) VALUES (@FirstName, @Year, @LastName, @Tel, @Sex)"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@FirstName", FirstNameTB.Text)
                cmd.Parameters.AddWithValue("@Year", YearCB.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@LastName", LastNameTB.Text)
                cmd.Parameters.AddWithValue("@Tel", TelTB.Text)
                cmd.Parameters.AddWithValue("@Sex", SexCB.SelectedItem.ToString())
                cmd.ExecuteNonQuery()
                MsgBox("Student added successfully")
                Con.Close()
                Reset() ' Clear all text boxes after adding
                DisplayDetails() 'isplay the added students in the table
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Con.Close()
            End Try
        End If
    End Sub
    'Code for display student details on the Table
    Private Sub DisplayDetails()
        Con.Open()
        Dim query = "select * from StudentTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemGridView.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    'Code for when select a row, then it will fill the textboxes and combobox
    Dim key = 0
    Private Sub ItemGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemGridView.CellMouseClick
        Dim row As DataGridViewRow = ItemGridView.Rows(e.RowIndex)
        YearCB.SelectedItem = row.Cells(1).Value.ToString
        FirstNameTB.Text = row.Cells(2).Value.ToString
        LastNameTB.Text = row.Cells(3).Value.ToString
        SexCB.SelectedItem = row.Cells(4).Value.ToString
        TelTB.Text = row.Cells(5).Value.ToString
        If FirstNameTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    'code for the delete button
    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        If key = 0 Then
            MsgBox("Select an Item for Delete")
        Else
            Con.Open()
            Dim query = "delete from StudentTbl where StudentId=" & key & "" 'delete command
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully")
            Con.Close()
            Reset()
            DisplayDetails()
        End If
    End Sub
    'code for edit button
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If YearCB.SelectedIndex = -1 Or SexCB.SelectedIndex = -1 Or FirstNameTB.Text = "" Or LastNameTB.Text = "" Or TelTB.Text = "" Then
            MsgBox("Fill the Details")
        Else
            Try
                Con.Open()
                Dim query As String = "UPDATE StudentTbl SET StudentFirstName=@FirstName, Year=@Year, StudentLastName=@LastName, Tel=@Tel WHERE StudentId=@StudentId"
                Dim cmd As New SqlCommand(query, Con)
                cmd.Parameters.AddWithValue("@FirstName", FirstNameTB.Text)
                cmd.Parameters.AddWithValue("@Year", YearCB.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@LastName", LastNameTB.Text)
                cmd.Parameters.AddWithValue("@Tel", TelTB.Text)
                cmd.Parameters.AddWithValue("@StudentId", key)
                cmd.ExecuteNonQuery()
                MsgBox("Successfully Updated the Item")
                Con.Close()
                Reset()
                DisplayDetails()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

End Class
