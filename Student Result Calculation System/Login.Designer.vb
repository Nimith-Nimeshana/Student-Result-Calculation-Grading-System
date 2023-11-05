<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.UsernameTB = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.ExitBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BackBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.DashGOBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.LoginBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(110, 83)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(158, 27)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Welcome Back"
        '
        'UsernameTB
        '
        Me.Guna2Transition1.SetDecoration(Me.UsernameTB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UsernameTB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.UsernameTB.Location = New System.Drawing.Point(155, 166)
        Me.UsernameTB.Name = "UsernameTB"
        Me.UsernameTB.Size = New System.Drawing.Size(126, 23)
        Me.UsernameTB.TabIndex = 1
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(76, 171)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(60, 17)
        Me.Guna2HtmlLabel3.TabIndex = 4
        Me.Guna2HtmlLabel3.Text = "Username"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(76, 219)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(55, 17)
        Me.Guna2HtmlLabel4.TabIndex = 5
        Me.Guna2HtmlLabel4.Text = "Password"
        '
        'PasswordTB
        '
        Me.Guna2Transition1.SetDecoration(Me.PasswordTB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PasswordTB.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PasswordTB.Location = New System.Drawing.Point(155, 214)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.Size = New System.Drawing.Size(126, 23)
        Me.PasswordTB.TabIndex = 6
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.ExitBTN)
        Me.Guna2GradientPanel1.Controls.Add(Me.BackBTN)
        Me.Guna2GradientPanel1.Controls.Add(Me.DashGOBTN)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-7, -11)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(398, 62)
        Me.Guna2GradientPanel1.TabIndex = 67
        '
        'ExitBTN
        '
        Me.ExitBTN.Animated = True
        Me.ExitBTN.AutoRoundedCorners = True
        Me.ExitBTN.BackColor = System.Drawing.Color.Transparent
        Me.ExitBTN.BorderRadius = 12
        Me.ExitBTN.BorderThickness = -1
        Me.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.ExitBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ExitBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ExitBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ExitBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ExitBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ExitBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ExitBTN.FillColor = System.Drawing.Color.Firebrick
        Me.ExitBTN.FillColor2 = System.Drawing.Color.Crimson
        Me.ExitBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ExitBTN.ForeColor = System.Drawing.Color.White
        Me.ExitBTN.Location = New System.Drawing.Point(350, 20)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.Size = New System.Drawing.Size(30, 27)
        Me.ExitBTN.TabIndex = 15
        Me.ExitBTN.Text = "X"
        Me.ExitBTN.UseTransparentBackground = True
        '
        'BackBTN
        '
        Me.BackBTN.Animated = True
        Me.BackBTN.AutoRoundedCorners = True
        Me.BackBTN.BackColor = System.Drawing.Color.Transparent
        Me.BackBTN.BorderRadius = 12
        Me.BackBTN.BorderThickness = -1
        Me.BackBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.BackBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BackBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BackBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BackBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BackBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BackBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BackBTN.FillColor = System.Drawing.Color.Firebrick
        Me.BackBTN.FillColor2 = System.Drawing.Color.Crimson
        Me.BackBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BackBTN.ForeColor = System.Drawing.Color.White
        Me.BackBTN.Location = New System.Drawing.Point(962, 17)
        Me.BackBTN.Name = "BackBTN"
        Me.BackBTN.Size = New System.Drawing.Size(30, 27)
        Me.BackBTN.TabIndex = 9
        Me.BackBTN.Text = "LOGOUT"
        Me.BackBTN.UseTransparentBackground = True
        '
        'DashGOBTN
        '
        Me.DashGOBTN.Animated = True
        Me.DashGOBTN.AutoRoundedCorners = True
        Me.DashGOBTN.BackColor = System.Drawing.Color.Transparent
        Me.DashGOBTN.BorderRadius = 13
        Me.DashGOBTN.BorderThickness = -1
        Me.DashGOBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.DashGOBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DashGOBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.DashGOBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.DashGOBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DashGOBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.DashGOBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DashGOBTN.FillColor = System.Drawing.Color.Turquoise
        Me.DashGOBTN.FillColor2 = System.Drawing.Color.CornflowerBlue
        Me.DashGOBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DashGOBTN.ForeColor = System.Drawing.Color.White
        Me.DashGOBTN.Location = New System.Drawing.Point(928, 15)
        Me.DashGOBTN.Name = "DashGOBTN"
        Me.DashGOBTN.Size = New System.Drawing.Size(28, 30)
        Me.DashGOBTN.TabIndex = 14
        Me.DashGOBTN.Text = "DASHBOARD"
        Me.DashGOBTN.UseTransparentBackground = True
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(96, 25)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(213, 22)
        Me.Guna2HtmlLabel2.TabIndex = 3
        Me.Guna2HtmlLabel2.Text = "Result Calculation System"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 7
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'LoginBTN
        '
        Me.LoginBTN.Animated = True
        Me.LoginBTN.AutoRoundedCorners = True
        Me.LoginBTN.BackColor = System.Drawing.Color.Transparent
        Me.LoginBTN.BorderRadius = 20
        Me.LoginBTN.BorderThickness = -1
        Me.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.LoginBTN, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LoginBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginBTN.FillColor = System.Drawing.Color.GreenYellow
        Me.LoginBTN.FillColor2 = System.Drawing.Color.ForestGreen
        Me.LoginBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LoginBTN.ForeColor = System.Drawing.Color.White
        Me.LoginBTN.Location = New System.Drawing.Point(110, 281)
        Me.LoginBTN.Name = "LoginBTN"
        Me.LoginBTN.Size = New System.Drawing.Size(81, 43)
        Me.LoginBTN.TabIndex = 68
        Me.LoginBTN.Text = "LOGIN"
        Me.LoginBTN.UseTransparentBackground = True
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.BorderRadius = 20
        Me.Guna2GradientButton1.BorderThickness = -1
        Me.Guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.SystemColors.MenuHighlight
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.CadetBlue
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(206, 281)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(96, 43)
        Me.Guna2GradientButton1.TabIndex = 69
        Me.Guna2GradientButton1.Text = "STUDENT"
        Me.Guna2GradientButton1.UseTransparentBackground = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 373)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.LoginBTN)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.UsernameTB)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UsernameTB As TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents BackBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DashGOBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LoginBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ExitBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
End Class
