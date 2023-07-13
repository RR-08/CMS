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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Label1 = New Label()
        Label2 = New Label()
        userNameTB = New TextBox()
        Label3 = New Label()
        pwdTb = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(236), CByte(108), CByte(33))
        Label1.Location = New Point(293, 262)
        Label1.Name = "Label1"
        Label1.Size = New Size(484, 46)
        Label1.TabIndex = 2
        Label1.Text = "Cylinder Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label2.Location = New Point(304, 367)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 32)
        Label2.TabIndex = 3
        Label2.Text = "Login"
        ' 
        ' userNameTB
        ' 
        userNameTB.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        userNameTB.Location = New Point(616, 364)
        userNameTB.Name = "userNameTB"
        userNameTB.Size = New Size(150, 40)
        userNameTB.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label3.Location = New Point(304, 441)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 32)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        ' 
        ' pwdTb
        ' 
        pwdTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        pwdTb.Location = New Point(616, 438)
        pwdTb.Name = "pwdTb"
        pwdTb.PasswordChar = "*"c
        pwdTb.Size = New Size(150, 40)
        pwdTb.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Button1.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(538, 541)
        Button1.Name = "Button1"
        Button1.Size = New Size(228, 69)
        Button1.TabIndex = 7
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(236), CByte(108), CByte(33))
        Button2.Location = New Point(304, 541)
        Button2.Name = "Button2"
        Button2.Size = New Size(228, 69)
        Button2.TabIndex = 8
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label4.Location = New Point(1037, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 48)
        Label4.TabIndex = 9
        Label4.Text = "X"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(425, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(219, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label5.Location = New Point(450, 655)
        Label5.Name = "Label5"
        Label5.Size = New Size(194, 29)
        Label5.TabIndex = 11
        Label5.Text = "New User ? Register"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1110, 768)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(pwdTb)
        Controls.Add(Label3)
        Controls.Add(userNameTB)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents userNameTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pwdTb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
