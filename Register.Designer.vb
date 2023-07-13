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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Register))
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        pwdTb = New TextBox()
        Label3 = New Label()
        userNameTB = New TextBox()
        Label2 = New Label()
        repwdTb = New TextBox()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Label4.TabIndex = 10
        Label4.Text = "X"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(438, 89)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(219, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(236), CByte(108), CByte(33))
        Label1.Location = New Point(170, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(762, 46)
        Label1.TabIndex = 11
        Label1.Text = "Gas Cylinder Tracking and  Compliance System"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(236), CByte(108), CByte(33))
        Button2.Location = New Point(316, 553)
        Button2.Name = "Button2"
        Button2.Size = New Size(228, 69)
        Button2.TabIndex = 18
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Button1.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(550, 553)
        Button1.Name = "Button1"
        Button1.Size = New Size(228, 69)
        Button1.TabIndex = 17
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' pwdTb
        ' 
        pwdTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        pwdTb.Location = New Point(606, 378)
        pwdTb.Name = "pwdTb"
        pwdTb.Size = New Size(150, 40)
        pwdTb.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label3.Location = New Point(333, 386)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 32)
        Label3.TabIndex = 15
        Label3.Text = "Enter Password"
        ' 
        ' userNameTB
        ' 
        userNameTB.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        userNameTB.Location = New Point(606, 304)
        userNameTB.Name = "userNameTB"
        userNameTB.Size = New Size(150, 40)
        userNameTB.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label2.Location = New Point(333, 312)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 32)
        Label2.TabIndex = 13
        Label2.Text = "User Name"
        ' 
        ' repwdTb
        ' 
        repwdTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        repwdTb.Location = New Point(606, 452)
        repwdTb.Name = "repwdTb"
        repwdTb.PasswordChar = "*"c
        repwdTb.Size = New Size(150, 40)
        repwdTb.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label5.Location = New Point(333, 460)
        Label5.Name = "Label5"
        Label5.Size = New Size(245, 32)
        Label5.TabIndex = 19
        Label5.Text = "ReEnter Password"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1110, 768)
        Controls.Add(repwdTb)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(pwdTb)
        Controls.Add(Label3)
        Controls.Add(userNameTB)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Label4)
        FormBorderStyle = FormBorderStyle.None
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Back"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pwdTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents userNameTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents repwdTb As TextBox
    Friend WithEvents Label5 As Label
End Class
