Public Class Login
    Private Sub LoginBTN_Click_1(sender As Object, e As EventArgs) Handles LoginBTN.Click

        Dim username As String
        Dim password As String

        username = UsernameTB.Text
        password = PasswordTB.Text

        If UsernameTB.Text = "" Or PasswordTB.Text = "" Then
            MsgBox("Enter Username & Password")
        ElseIf UsernameTB.Text = "user" And PasswordTB.Text = "user" Then
            Dim Obj = New Dashboard
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect UserName or Password")
            UsernameTB.Text = ""
            PasswordTB.Text = ""
        End If
    End Sub
    'show password text as password
    Private Sub PasswordTB_TextChanged(sender As Object, e As EventArgs) Handles PasswordTB.TextChanged
        PasswordTB.UseSystemPasswordChar = True
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        Application.Exit()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Obj = New StudentResults
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class