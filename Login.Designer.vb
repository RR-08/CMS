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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(128, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(521, 48)
        Label1.TabIndex = 2
        Label1.Text = "Cylinder Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.ForeColor = Color.IndianRed
        Label2.Location = New Point(238, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 25)
        Label2.TabIndex = 3
        Label2.Text = "Login"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(458, 115)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.ForeColor = Color.IndianRed
        Label3.Location = New Point(238, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 25)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(458, 189)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(238, 272)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 7
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(458, 272)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 8
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
