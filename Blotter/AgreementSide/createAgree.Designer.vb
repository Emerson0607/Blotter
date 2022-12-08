<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class createAgree
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(createAgree))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.tbWname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbSname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbVname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbCname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbOffice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.tbAgreement = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbLocation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.id = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.AnimationInterval = 250
        Me.Guna2BorderlessForm1.BorderRadius = 60
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(45, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(355, 39)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "Add New Agreement"
        '
        'btnBack
        '
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.White
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(20, 11)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.PressedColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBack.Size = New System.Drawing.Size(44, 45)
        Me.btnBack.TabIndex = 74
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BorderRadius = 5
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Image = CType(resources.GetObject("btnSubmit.Image"), System.Drawing.Image)
        Me.btnSubmit.Location = New System.Drawing.Point(1075, 730)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubmit.ShadowDecoration.Depth = 10
        Me.btnSubmit.ShadowDecoration.Enabled = True
        Me.btnSubmit.Size = New System.Drawing.Size(114, 51)
        Me.btnSubmit.TabIndex = 77
        Me.btnSubmit.Text = "Submit"
        '
        'tbWname
        '
        Me.tbWname.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.tbWname.BackColor = System.Drawing.Color.Transparent
        Me.tbWname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbWname.BorderRadius = 5
        Me.tbWname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbWname.DefaultText = ""
        Me.tbWname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbWname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbWname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbWname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbWname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbWname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbWname.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbWname.Location = New System.Drawing.Point(1010, 237)
        Me.tbWname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbWname.Name = "tbWname"
        Me.tbWname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbWname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tbWname.PlaceholderText = ""
        Me.tbWname.SelectedText = ""
        Me.tbWname.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbWname.ShadowDecoration.Depth = 3
        Me.tbWname.ShadowDecoration.Enabled = True
        Me.tbWname.Size = New System.Drawing.Size(179, 36)
        Me.tbWname.TabIndex = 105
        Me.tbWname.WordWrap = False
        '
        'tbSname
        '
        Me.tbSname.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.tbSname.BackColor = System.Drawing.Color.Transparent
        Me.tbSname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbSname.BorderRadius = 5
        Me.tbSname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSname.DefaultText = ""
        Me.tbSname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbSname.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbSname.Location = New System.Drawing.Point(780, 237)
        Me.tbSname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSname.Name = "tbSname"
        Me.tbSname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tbSname.PlaceholderText = ""
        Me.tbSname.SelectedText = ""
        Me.tbSname.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbSname.ShadowDecoration.Depth = 3
        Me.tbSname.ShadowDecoration.Enabled = True
        Me.tbSname.Size = New System.Drawing.Size(179, 36)
        Me.tbSname.TabIndex = 104
        Me.tbSname.WordWrap = False
        '
        'tbVname
        '
        Me.tbVname.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.tbVname.BackColor = System.Drawing.Color.Transparent
        Me.tbVname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbVname.BorderRadius = 5
        Me.tbVname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbVname.DefaultText = ""
        Me.tbVname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbVname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbVname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbVname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbVname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbVname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbVname.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbVname.Location = New System.Drawing.Point(535, 237)
        Me.tbVname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbVname.Name = "tbVname"
        Me.tbVname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbVname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tbVname.PlaceholderText = ""
        Me.tbVname.SelectedText = ""
        Me.tbVname.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbVname.ShadowDecoration.Depth = 3
        Me.tbVname.ShadowDecoration.Enabled = True
        Me.tbVname.Size = New System.Drawing.Size(179, 36)
        Me.tbVname.TabIndex = 103
        Me.tbVname.WordWrap = False
        '
        'tbCname
        '
        Me.tbCname.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.tbCname.BackColor = System.Drawing.Color.Transparent
        Me.tbCname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbCname.BorderRadius = 5
        Me.tbCname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCname.DefaultText = ""
        Me.tbCname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbCname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbCname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbCname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbCname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbCname.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbCname.Location = New System.Drawing.Point(293, 237)
        Me.tbCname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbCname.Name = "tbCname"
        Me.tbCname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tbCname.PlaceholderText = ""
        Me.tbCname.SelectedText = ""
        Me.tbCname.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbCname.ShadowDecoration.Depth = 3
        Me.tbCname.ShadowDecoration.Enabled = True
        Me.tbCname.Size = New System.Drawing.Size(179, 36)
        Me.tbCname.TabIndex = 102
        Me.tbCname.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(292, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 23)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Office Name"
        '
        'tbOffice
        '
        Me.tbOffice.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.tbOffice.BackColor = System.Drawing.Color.Transparent
        Me.tbOffice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbOffice.BorderRadius = 5
        Me.tbOffice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbOffice.DefaultText = ""
        Me.tbOffice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbOffice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbOffice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbOffice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbOffice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbOffice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbOffice.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbOffice.Location = New System.Drawing.Point(293, 329)
        Me.tbOffice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbOffice.Name = "tbOffice"
        Me.tbOffice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbOffice.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tbOffice.PlaceholderText = ""
        Me.tbOffice.SelectedText = ""
        Me.tbOffice.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbOffice.ShadowDecoration.Depth = 3
        Me.tbOffice.ShadowDecoration.Enabled = True
        Me.tbOffice.Size = New System.Drawing.Size(179, 36)
        Me.tbOffice.TabIndex = 100
        Me.tbOffice.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(48, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Incident Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(52, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 23)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Agreement"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(536, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 23)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Agreement Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(52, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 23)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Agreement Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 23)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Blotter Entry ID"
        '
        'tbDate
        '
        Me.tbDate.BackColor = System.Drawing.Color.Transparent
        Me.tbDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbDate.BorderRadius = 5
        Me.tbDate.Checked = True
        Me.tbDate.CustomFormat = "yyyy/MM/dd"
        Me.tbDate.FillColor = System.Drawing.Color.White
        Me.tbDate.FocusedColor = System.Drawing.Color.White
        Me.tbDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbDate.Location = New System.Drawing.Point(51, 329)
        Me.tbDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tbDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.ShadowDecoration.BorderRadius = 5
        Me.tbDate.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbDate.ShadowDecoration.Depth = 3
        Me.tbDate.ShadowDecoration.Enabled = True
        Me.tbDate.Size = New System.Drawing.Size(179, 36)
        Me.tbDate.TabIndex = 93
        Me.tbDate.Value = New Date(2022, 12, 2, 21, 15, 11, 160)
        '
        'tbAgreement
        '
        Me.tbAgreement.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.tbAgreement.BackColor = System.Drawing.Color.Transparent
        Me.tbAgreement.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbAgreement.BorderRadius = 5
        Me.tbAgreement.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbAgreement.DefaultText = ""
        Me.tbAgreement.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbAgreement.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbAgreement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAgreement.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAgreement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAgreement.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbAgreement.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbAgreement.Location = New System.Drawing.Point(53, 408)
        Me.tbAgreement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbAgreement.Multiline = True
        Me.tbAgreement.Name = "tbAgreement"
        Me.tbAgreement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAgreement.PlaceholderText = ""
        Me.tbAgreement.SelectedText = ""
        Me.tbAgreement.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbAgreement.ShadowDecoration.Depth = 3
        Me.tbAgreement.ShadowDecoration.Enabled = True
        Me.tbAgreement.Size = New System.Drawing.Size(1136, 292)
        Me.tbAgreement.TabIndex = 92
        '
        'tbLocation
        '
        Me.tbLocation.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.tbLocation.BackColor = System.Drawing.Color.Transparent
        Me.tbLocation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbLocation.BorderRadius = 5
        Me.tbLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbLocation.DefaultText = ""
        Me.tbLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbLocation.Location = New System.Drawing.Point(535, 329)
        Me.tbLocation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLocation.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tbLocation.PlaceholderText = ""
        Me.tbLocation.SelectedText = ""
        Me.tbLocation.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbLocation.ShadowDecoration.Depth = 3
        Me.tbLocation.ShadowDecoration.Enabled = True
        Me.tbLocation.Size = New System.Drawing.Size(654, 36)
        Me.tbLocation.TabIndex = 91
        Me.tbLocation.WordWrap = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(292, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 23)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Complainant Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(534, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 23)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Victim Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(778, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 23)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Suspect"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(1009, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 23)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Witness Name"
        '
        'id
        '
        Me.id.BackColor = System.Drawing.Color.Transparent
        Me.id.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.id.BorderRadius = 5
        Me.id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.id.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.id.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.id.ItemHeight = 30
        Me.id.Items.AddRange(New Object() {"Alarm and Scandal", "Fatalities", "Minor Injuries", "Near Misses", "Slander", "Theft", "Unsafe Acts"})
        Me.id.ItemsAppearance.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.id.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.id.ItemsAppearance.SelectedBackColor = System.Drawing.Color.SkyBlue
        Me.id.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.id.Location = New System.Drawing.Point(51, 238)
        Me.id.MaxDropDownItems = 100
        Me.id.Name = "id"
        Me.id.ShadowDecoration.BorderRadius = 5
        Me.id.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.id.ShadowDecoration.Depth = 3
        Me.id.ShadowDecoration.Enabled = True
        Me.id.Size = New System.Drawing.Size(179, 36)
        Me.id.Sorted = True
        Me.id.TabIndex = 110
        '
        'createAgree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1250, 805)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbWname)
        Me.Controls.Add(Me.tbSname)
        Me.Controls.Add(Me.tbVname)
        Me.Controls.Add(Me.tbCname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbOffice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbDate)
        Me.Controls.Add(Me.tbAgreement)
        Me.Controls.Add(Me.tbLocation)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "createAgree"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "createAgree"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label15 As Label
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbWname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbSname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbVname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbCname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbOffice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents tbAgreement As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbLocation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents id As Guna.UI2.WinForms.Guna2ComboBox
End Class
