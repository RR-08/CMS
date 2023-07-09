<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.OrangeRed
        Label1.Location = New Point(147, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(521, 48)
        Label1.TabIndex = 1
        Label1.Text = "Cylinder Management System"
        ' 
        ' Guna2CircleProgressBar1
        ' 
        Guna2CircleProgressBar1.FillColor = Color.FromArgb(CByte(200), CByte(213), CByte(218), CByte(223))
        Guna2CircleProgressBar1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2CircleProgressBar1.ForeColor = Color.White
        Guna2CircleProgressBar1.Location = New Point(284, 137)
        Guna2CircleProgressBar1.Minimum = 0
        Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleProgressBar1.Size = New Size(195, 195)
        Guna2CircleProgressBar1.TabIndex = 2
        Guna2CircleProgressBar1.Text = "Guna2CircleProgressBar1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Guna2CircleProgressBar1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
End Class
