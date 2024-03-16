<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        DateTimePicker2 = New DateTimePicker()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Location = New Point(528, 110)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(227, 228)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(610, 377)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 32)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.Location = New Point(137, 300)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(245, 29)
        DateTimePicker2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(137, 454)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(245, 39)
        TextBox1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(742, 536)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 33)
        Button1.TabIndex = 5
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label4.Location = New Point(137, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 30)
        Label4.TabIndex = 8
        Label4.Text = "Return Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label5.Location = New Point(137, 377)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 30)
        Label5.TabIndex = 9
        Label5.Text = "Purpose"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(26, 28)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(165, 138)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label3.Location = New Point(133, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 30)
        Label3.TabIndex = 19
        Label3.Text = "Borrow Date"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(133, 178)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(245, 29)
        DateTimePicker1.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(70), CByte(196), CByte(255))
        Label2.Location = New Point(163, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 47)
        Label2.TabIndex = 20
        Label2.Text = "Reserve"
        ' 
        ' Info
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(889, 632)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(PictureBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(DateTimePicker2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Info"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Info"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
