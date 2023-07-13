<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prints
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Prints))
        CylNoTb = New TextBox()
        cyLb = New Label()
        MaterialDesTb = New TextBox()
        desLb = New Label()
        VendorNameTb = New TextBox()
        poLb = New Label()
        poNoTb = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        slipTb = New TextBox()
        Button3 = New Button()
        Label1 = New Label()
        cisfnoTb = New TextBox()
        cisfLb = New Label()
        Label12 = New Label()
        PictureBox1 = New PictureBox()
        venLb = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Label26 = New Label()
        Label25 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CylNoTb
        ' 
        CylNoTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CylNoTb.Location = New Point(373, 505)
        CylNoTb.Name = "CylNoTb"
        CylNoTb.Size = New Size(169, 40)
        CylNoTb.TabIndex = 16
        ' 
        ' cyLb
        ' 
        cyLb.AutoSize = True
        cyLb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        cyLb.Location = New Point(362, 460)
        cyLb.Name = "cyLb"
        cyLb.Size = New Size(240, 32)
        cyLb.TabIndex = 15
        cyLb.Text = "Filled Cylinder No."
        ' 
        ' MaterialDesTb
        ' 
        MaterialDesTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        MaterialDesTb.Location = New Point(83, 505)
        MaterialDesTb.Name = "MaterialDesTb"
        MaterialDesTb.Size = New Size(169, 40)
        MaterialDesTb.TabIndex = 14
        ' 
        ' desLb
        ' 
        desLb.AutoSize = True
        desLb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        desLb.Location = New Point(83, 460)
        desLb.Name = "desLb"
        desLb.Size = New Size(243, 32)
        desLb.TabIndex = 13
        desLb.Text = "Matrial Description"
        ' 
        ' VendorNameTb
        ' 
        VendorNameTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        VendorNameTb.Location = New Point(83, 405)
        VendorNameTb.Name = "VendorNameTb"
        VendorNameTb.Size = New Size(169, 40)
        VendorNameTb.TabIndex = 12
        ' 
        ' poLb
        ' 
        poLb.AutoSize = True
        poLb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        poLb.Location = New Point(83, 231)
        poLb.Name = "poLb"
        poLb.Size = New Size(98, 32)
        poLb.TabIndex = 11
        poLb.Text = "PO No"
        ' 
        ' poNoTb
        ' 
        poNoTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        poNoTb.Location = New Point(336, 223)
        poNoTb.Name = "poNoTb"
        poNoTb.Size = New Size(220, 40)
        poNoTb.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Button1.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(83, 563)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 66)
        Button1.TabIndex = 17
        Button1.Text = "View"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Button2.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(984, 563)
        Button2.Name = "Button2"
        Button2.RightToLeft = RightToLeft.No
        Button2.Size = New Size(131, 66)
        Button2.TabIndex = 18
        Button2.Text = "Print"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' slipTb
        ' 
        slipTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        slipTb.Location = New Point(684, 138)
        slipTb.Multiline = True
        slipTb.Name = "slipTb"
        slipTb.Size = New Size(638, 407)
        slipTb.TabIndex = 19
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Button3.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(250, 275)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.Size = New Size(126, 59)
        Button3.TabIndex = 20
        Button3.Text = "Search"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label1.Location = New Point(1278, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 48)
        Label1.TabIndex = 23
        Label1.Text = "X"
        ' 
        ' cisfnoTb
        ' 
        cisfnoTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        cisfnoTb.Location = New Point(373, 405)
        cisfnoTb.Name = "cisfnoTb"
        cisfnoTb.Size = New Size(169, 40)
        cisfnoTb.TabIndex = 25
        ' 
        ' cisfLb
        ' 
        cisfLb.AutoSize = True
        cisfLb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        cisfLb.Location = New Point(362, 360)
        cisfLb.Name = "cisfLb"
        cisfLb.Size = New Size(194, 32)
        cisfLb.TabIndex = 24
        cisfLb.Text = "CISF Entry No"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(236), CByte(108), CByte(33))
        Label12.Location = New Point(250, 63)
        Label12.Name = "Label12"
        Label12.Size = New Size(93, 46)
        Label12.TabIndex = 33
        Label12.Text = "CMS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(219, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' venLb
        ' 
        venLb.AutoSize = True
        venLb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        venLb.Location = New Point(83, 360)
        venLb.Name = "venLb"
        venLb.Size = New Size(184, 32)
        venLb.TabIndex = 34
        venLb.Text = "Vendor Name"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Cursor = Cursors.Hand
        Label26.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label26.Location = New Point(1168, 47)
        Label26.Name = "Label26"
        Label26.Size = New Size(69, 25)
        Label26.TabIndex = 48
        Label26.Text = "Logout"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Cursor = Cursors.Hand
        Label25.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label25.Location = New Point(1057, 47)
        Label25.Name = "Label25"
        Label25.Size = New Size(87, 25)
        Label25.TabIndex = 47
        Label25.Text = "Inventory"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Location = New Point(972, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 25)
        Label2.TabIndex = 49
        Label2.Text = "Home"
        ' 
        ' Prints
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(1356, 684)
        Controls.Add(Label2)
        Controls.Add(Label26)
        Controls.Add(Label25)
        Controls.Add(venLb)
        Controls.Add(Label12)
        Controls.Add(PictureBox1)
        Controls.Add(cisfnoTb)
        Controls.Add(cisfLb)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(slipTb)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(CylNoTb)
        Controls.Add(cyLb)
        Controls.Add(MaterialDesTb)
        Controls.Add(desLb)
        Controls.Add(VendorNameTb)
        Controls.Add(poLb)
        Controls.Add(poNoTb)
        FormBorderStyle = FormBorderStyle.None
        Name = "Prints"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Prints"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CylNoTb As TextBox
    Friend WithEvents cyLb As Label
    Friend WithEvents MaterialDesTb As TextBox
    Friend WithEvents desLb As Label
    Friend WithEvents VendorNameTb As TextBox
    Friend WithEvents poLb As Label
    Friend WithEvents poNoTb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents slipTb As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cisfnoTb As TextBox
    Friend WithEvents cisfLb As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents venLb As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label2 As Label
End Class
