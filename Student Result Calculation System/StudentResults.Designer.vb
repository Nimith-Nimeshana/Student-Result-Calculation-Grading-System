<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentResults))
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SearchStudentIdTB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ExitBTN = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel18 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel17 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel16 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel14 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel19 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.StdIdLBL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FirstNameLBL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.YearLBL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LastNameLBL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Sub1LBL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Sub2LBL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Sub3LBL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Sub4LBL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.StatusLBL = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ResetBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SearchBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(55, 104)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(160, 22)
        Me.Guna2HtmlLabel1.TabIndex = 110
        Me.Guna2HtmlLabel1.Text = "Insert Your Student ID"
        '
        'SearchStudentIdTB
        '
        Me.SearchStudentIdTB.Animated = True
        Me.SearchStudentIdTB.AutoCompleteCustomSource.AddRange(New String() {"Admin"})
        Me.SearchStudentIdTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SearchStudentIdTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.SearchStudentIdTB.BackColor = System.Drawing.Color.Black
        Me.SearchStudentIdTB.BorderColor = System.Drawing.Color.Black
        Me.SearchStudentIdTB.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.SearchStudentIdTB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.SearchStudentIdTB, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SearchStudentIdTB.DefaultText = ""
        Me.SearchStudentIdTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchStudentIdTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchStudentIdTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchStudentIdTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchStudentIdTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchStudentIdTB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SearchStudentIdTB.ForeColor = System.Drawing.Color.Black
        Me.SearchStudentIdTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchStudentIdTB.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.SearchStudentIdTB.Location = New System.Drawing.Point(233, 104)
        Me.SearchStudentIdTB.Name = "SearchStudentIdTB"
        Me.SearchStudentIdTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchStudentIdTB.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SearchStudentIdTB.PlaceholderText = ""
        Me.SearchStudentIdTB.SelectedText = ""
        Me.SearchStudentIdTB.Size = New System.Drawing.Size(213, 25)
        Me.SearchStudentIdTB.TabIndex = 109
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GradientPanel1.Controls.Add(Me.ExitBTN)
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Black
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(-1, -4)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1004, 62)
        Me.Guna2GradientPanel1.TabIndex = 112
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(234, 16)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(196, 33)
        Me.Guna2HtmlLabel6.TabIndex = 67
        Me.Guna2HtmlLabel6.Text = "Student Results"
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
        Me.ExitBTN.Location = New System.Drawing.Point(628, 16)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.Size = New System.Drawing.Size(30, 27)
        Me.ExitBTN.TabIndex = 9
        Me.ExitBTN.Text = "X"
        Me.ExitBTN.UseTransparentBackground = True
        '
        'Guna2HtmlLabel18
        '
        Me.Guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel18, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel18.Location = New System.Drawing.Point(275, 176)
        Me.Guna2HtmlLabel18.Name = "Guna2HtmlLabel18"
        Me.Guna2HtmlLabel18.Size = New System.Drawing.Size(101, 19)
        Me.Guna2HtmlLabel18.TabIndex = 119
        Me.Guna2HtmlLabel18.Text = "Academic Year : "
        '
        'Guna2HtmlLabel17
        '
        Me.Guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel17, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel17.Location = New System.Drawing.Point(60, 223)
        Me.Guna2HtmlLabel17.Name = "Guna2HtmlLabel17"
        Me.Guna2HtmlLabel17.Size = New System.Drawing.Size(78, 19)
        Me.Guna2HtmlLabel17.TabIndex = 118
        Me.Guna2HtmlLabel17.Text = "First Name :"
        '
        'Guna2HtmlLabel16
        '
        Me.Guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel16, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel16.Location = New System.Drawing.Point(60, 179)
        Me.Guna2HtmlLabel16.Name = "Guna2HtmlLabel16"
        Me.Guna2HtmlLabel16.Size = New System.Drawing.Size(77, 19)
        Me.Guna2HtmlLabel16.TabIndex = 117
        Me.Guna2HtmlLabel16.Text = "Student ID :"
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel11, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(60, 320)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(67, 19)
        Me.Guna2HtmlLabel11.TabIndex = 126
        Me.Guna2HtmlLabel11.Text = "Subject 2 :"
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel12, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(60, 390)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(67, 19)
        Me.Guna2HtmlLabel12.TabIndex = 125
        Me.Guna2HtmlLabel12.Text = "Subject 4 :"
        '
        'Guna2HtmlLabel13
        '
        Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel13, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(61, 356)
        Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
        Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(67, 19)
        Me.Guna2HtmlLabel13.TabIndex = 124
        Me.Guna2HtmlLabel13.Text = "Subject 3 :"
        '
        'Guna2HtmlLabel14
        '
        Me.Guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel14, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel14.Location = New System.Drawing.Point(60, 286)
        Me.Guna2HtmlLabel14.Name = "Guna2HtmlLabel14"
        Me.Guna2HtmlLabel14.Size = New System.Drawing.Size(67, 19)
        Me.Guna2HtmlLabel14.TabIndex = 123
        Me.Guna2HtmlLabel14.Text = "Subject 1 :"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(60, 424)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(95, 19)
        Me.Guna2HtmlLabel2.TabIndex = 127
        Me.Guna2HtmlLabel2.Text = "Course Status :"
        '
        'Guna2HtmlLabel19
        '
        Me.Guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2HtmlLabel19, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2HtmlLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel19.Location = New System.Drawing.Point(275, 220)
        Me.Guna2HtmlLabel19.Name = "Guna2HtmlLabel19"
        Me.Guna2HtmlLabel19.Size = New System.Drawing.Size(76, 19)
        Me.Guna2HtmlLabel19.TabIndex = 120
        Me.Guna2HtmlLabel19.Text = "Last Name :"
        '
        'StdIdLBL
        '
        Me.StdIdLBL.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.StdIdLBL, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.StdIdLBL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.StdIdLBL.Location = New System.Drawing.Point(157, 179)
        Me.StdIdLBL.Name = "StdIdLBL"
        Me.StdIdLBL.Size = New System.Drawing.Size(3, 2)
        Me.StdIdLBL.TabIndex = 128
        Me.StdIdLBL.Text = Nothing
        '
        'FirstNameLBL
        '
        Me.FirstNameLBL.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.FirstNameLBL, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FirstNameLBL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FirstNameLBL.Location = New System.Drawing.Point(157, 223)
        Me.FirstNameLBL.Name = "FirstNameLBL"
        Me.FirstNameLBL.Size = New System.Drawing.Size(3, 2)
        Me.FirstNameLBL.TabIndex = 129
        Me.FirstNameLBL.Text = Nothing
        '
        'YearLBL
        '
        Me.YearLBL.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.YearLBL, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.YearLBL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.YearLBL.Location = New System.Drawing.Point(392, 176)
        Me.YearLBL.Name = "YearLBL"
        Me.YearLBL.Size = New System.Drawing.Size(3, 2)
        Me.YearLBL.TabIndex = 130
        Me.YearLBL.Text = Nothing
        '
        'LastNameLBL
        '
        Me.LastNameLBL.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.LastNameLBL, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.LastNameLBL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LastNameLBL.Location = New System.Drawing.Point(392, 220)
        Me.LastNameLBL.Name = "LastNameLBL"
        Me.LastNameLBL.Size = New System.Drawing.Size(3, 2)
        Me.LastNameLBL.TabIndex = 131
        Me.LastNameLBL.Text = Nothing
        '
        'Sub1LBL
        '
        Me.Sub1LBL.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Sub1LBL, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Sub1LBL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Sub1LBL.Location = New System.Drawing.Point(209, 286)
        Me.Sub1LBL.Name = "Sub1LBL"
        Me.Sub1LBL.Size = New System.Drawing.Size(3, 2)
        Me.Sub1LBL.TabIndex = 132
        Me.Sub1LBL.Text = Nothing
        '
        'Sub2LBL
        '
        Me.Sub2LBL.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Sub2LBL, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Sub2LBL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Sub2LBL.Location = New System.Drawing.Point(209, 320)
        Me.Sub2LBL.Name = "Sub2LBL"
        Me.Sub2LBL.Size = New System.Drawing.Size(3, 2)
        Me.Sub2LBL.TabIndex = 133
        Me.Sub2LBL.Text = Nothing
        '
        'Sub3LBL
        '
        Me.Sub3LBL.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Sub3LBL, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Sub3LBL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Sub3LBL.Location = New System.Drawing.Point(209, 356)
        Me.Sub3LBL.Name = "Sub3LBL"
        Me.Sub3LBL.Size = New System.Drawing.Size(3, 2)
        Me.Sub3LBL.TabIndex = 134
        Me.Sub3LBL.Text = Nothing
        '
        'Sub4LBL
        '
        Me.Sub4LBL.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Sub4LBL, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Sub4LBL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Sub4LBL.Location = New System.Drawing.Point(209, 390)
        Me.Sub4LBL.Name = "Sub4LBL"
        Me.Sub4LBL.Size = New System.Drawing.Size(3, 2)
        Me.Sub4LBL.TabIndex = 135
        Me.Sub4LBL.Text = Nothing
        '
        'StatusLBL
        '
        Me.StatusLBL.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.StatusLBL, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.StatusLBL.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.StatusLBL.Location = New System.Drawing.Point(209, 424)
        Me.StatusLBL.Name = "StatusLBL"
        Me.StatusLBL.Size = New System.Drawing.Size(3, 2)
        Me.StatusLBL.TabIndex = 136
        Me.StatusLBL.Text = Nothing
        '
        'ResetBtn
        '
        Me.ResetBtn.Animated = True
        Me.ResetBtn.AutoRoundedCorners = True
        Me.ResetBtn.BackColor = System.Drawing.Color.Transparent
        Me.ResetBtn.BorderRadius = 17
        Me.ResetBtn.BorderThickness = -1
        Me.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.ResetBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ResetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ResetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ResetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ResetBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ResetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ResetBtn.FillColor = System.Drawing.Color.DarkRed
        Me.ResetBtn.FillColor2 = System.Drawing.Color.Red
        Me.ResetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Location = New System.Drawing.Point(541, 97)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(69, 37)
        Me.ResetBtn.TabIndex = 137
        Me.ResetBtn.Text = "Clear"
        Me.ResetBtn.UseTransparentBackground = True
        '
        'SearchBtn
        '
        Me.SearchBtn.Animated = True
        Me.SearchBtn.AutoRoundedCorners = True
        Me.SearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.SearchBtn.BorderRadius = 17
        Me.SearchBtn.BorderThickness = -1
        Me.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.SearchBtn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SearchBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SearchBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchBtn.FillColor2 = System.Drawing.Color.Yellow
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(452, 97)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(83, 37)
        Me.SearchBtn.TabIndex = 138
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseTransparentBackground = True
        '
        'StudentResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 472)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.StatusLBL)
        Me.Controls.Add(Me.Sub4LBL)
        Me.Controls.Add(Me.Sub3LBL)
        Me.Controls.Add(Me.Sub2LBL)
        Me.Controls.Add(Me.Sub1LBL)
        Me.Controls.Add(Me.LastNameLBL)
        Me.Controls.Add(Me.YearLBL)
        Me.Controls.Add(Me.FirstNameLBL)
        Me.Controls.Add(Me.StdIdLBL)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Controls.Add(Me.Guna2HtmlLabel12)
        Me.Controls.Add(Me.Guna2HtmlLabel13)
        Me.Controls.Add(Me.Guna2HtmlLabel14)
        Me.Controls.Add(Me.Guna2HtmlLabel19)
        Me.Controls.Add(Me.Guna2HtmlLabel18)
        Me.Controls.Add(Me.Guna2HtmlLabel17)
        Me.Controls.Add(Me.Guna2HtmlLabel16)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.SearchStudentIdTB)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentResults"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents SearchStudentIdTB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ExitBTN As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel18 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel17 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel16 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel14 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents StatusLBL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Sub4LBL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Sub3LBL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Sub2LBL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Sub1LBL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LastNameLBL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents YearLBL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FirstNameLBL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents StdIdLBL As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel19 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ResetBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents SearchBtn As Guna.UI2.WinForms.Guna2GradientButton
End Class
