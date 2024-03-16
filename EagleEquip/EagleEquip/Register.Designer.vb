<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        txtName = New TextBox()
        txtPosition = New TextBox()
        txtClub = New TextBox()
        txtEmail = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnRegister = New Button()
        PictureBox1 = New PictureBox()
        Label9 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.BorderStyle = BorderStyle.None
        txtName.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(151, 151)
        txtName.Name = "txtName"
        txtName.Size = New Size(225, 32)
        txtName.TabIndex = 0
        ' 
        ' txtPosition
        ' 
        txtPosition.BackColor = Color.White
        txtPosition.BorderStyle = BorderStyle.None
        txtPosition.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPosition.Location = New Point(151, 262)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(225, 32)
        txtPosition.TabIndex = 1
        ' 
        ' txtClub
        ' 
        txtClub.BackColor = Color.White
        txtClub.BorderStyle = BorderStyle.None
        txtClub.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtClub.Location = New Point(151, 371)
        txtClub.Name = "txtClub"
        txtClub.Size = New Size(225, 32)
        txtClub.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.BorderStyle = BorderStyle.None
        txtEmail.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(151, 482)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(225, 32)
        txtEmail.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(490, 191)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(225, 32)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(490, 287)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(225, 32)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BackColor = Color.White
        txtConfirmPassword.BorderStyle = BorderStyle.None
        txtConfirmPassword.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtConfirmPassword.Location = New Point(490, 404)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(225, 32)
        txtConfirmPassword.TabIndex = 6
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label1.Location = New Point(140, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 30)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label2.Location = New Point(140, 212)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 30)
        Label2.TabIndex = 8
        Label2.Text = "Position"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label3.Location = New Point(140, 324)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 30)
        Label3.TabIndex = 9
        Label3.Text = "Club"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label4.Location = New Point(140, 434)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 30)
        Label4.TabIndex = 10
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label5.Location = New Point(478, 142)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 30)
        Label5.TabIndex = 11
        Label5.Text = "Username"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label6.Location = New Point(478, 243)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 30)
        Label6.TabIndex = 12
        Label6.Text = "Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label7.Location = New Point(478, 357)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 30)
        Label7.TabIndex = 13
        Label7.Text = "Confirm Password"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(620, 474)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(108, 32)
        btnRegister.TabIndex = 14
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(668, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(165, 138)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label9.Location = New Point(567, 82)
        Label9.Name = "Label9"
        Label9.Size = New Size(138, 45)
        Label9.TabIndex = 17
        Label9.Text = "Sign Up"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(889, 632)
        Controls.Add(Label9)
        Controls.Add(PictureBox1)
        Controls.Add(btnRegister)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtEmail)
        Controls.Add(txtClub)
        Controls.Add(txtPosition)
        Controls.Add(txtName)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtClub As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
End Class
