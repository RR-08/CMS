<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cylinder
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Cylinder))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        poNoTb = New TextBox()
        VendorNameTb = New TextBox()
        Label2 = New Label()
        MaterialDesTb = New TextBox()
        Label3 = New Label()
        CylNoTb = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        cisfNoTb = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        ReceiptDate = New DateTimePicker()
        IssueDate = New DateTimePicker()
        DeptTb = New TextBox()
        Label8 = New Label()
        emptyDate = New DateTimePicker()
        Label9 = New Label()
        returnSuppDate = New DateTimePicker()
        Label10 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(187, 59)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(15, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 32)
        Label1.TabIndex = 1
        Label1.Text = "PO Number"
        ' 
        ' poNoTb
        ' 
        poNoTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        poNoTb.Location = New Point(15, 143)
        poNoTb.Name = "poNoTb"
        poNoTb.Size = New Size(169, 40)
        poNoTb.TabIndex = 2
        ' 
        ' VendorNameTb
        ' 
        VendorNameTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        VendorNameTb.Location = New Point(282, 143)
        VendorNameTb.Name = "VendorNameTb"
        VendorNameTb.Size = New Size(169, 40)
        VendorNameTb.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(268, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 32)
        Label2.TabIndex = 3
        Label2.Text = "Vendor's Name"
        ' 
        ' MaterialDesTb
        ' 
        MaterialDesTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        MaterialDesTb.Location = New Point(15, 243)
        MaterialDesTb.Name = "MaterialDesTb"
        MaterialDesTb.Size = New Size(169, 40)
        MaterialDesTb.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(15, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(243, 32)
        Label3.TabIndex = 5
        Label3.Text = "Matrial Description"
        ' 
        ' CylNoTb
        ' 
        CylNoTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CylNoTb.Location = New Point(282, 243)
        CylNoTb.Name = "CylNoTb"
        CylNoTb.Size = New Size(169, 40)
        CylNoTb.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(268, 198)
        Label4.Name = "Label4"
        Label4.Size = New Size(240, 32)
        Label4.TabIndex = 7
        Label4.Text = "Filled Cylinder No."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 305)
        Label5.Name = "Label5"
        Label5.Size = New Size(300, 32)
        Label5.TabIndex = 9
        Label5.Text = "Receipt Date / LR Date"
        ' 
        ' cisfNoTb
        ' 
        cisfNoTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        cisfNoTb.Location = New Point(352, 350)
        cisfNoTb.Name = "cisfNoTb"
        cisfNoTb.Size = New Size(169, 40)
        cisfNoTb.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(339, 305)
        Label6.Name = "Label6"
        Label6.Size = New Size(259, 32)
        Label6.TabIndex = 11
        Label6.Text = "CISF Entry Number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(15, 423)
        Label7.Name = "Label7"
        Label7.Size = New Size(163, 32)
        Label7.TabIndex = 13
        Label7.Text = "Issued Date"
        ' 
        ' ReceiptDate
        ' 
        ReceiptDate.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ReceiptDate.Location = New Point(15, 350)
        ReceiptDate.Name = "ReceiptDate"
        ReceiptDate.Size = New Size(300, 40)
        ReceiptDate.TabIndex = 14
        ' 
        ' IssueDate
        ' 
        IssueDate.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        IssueDate.Location = New Point(221, 417)
        IssueDate.Name = "IssueDate"
        IssueDate.Size = New Size(300, 40)
        IssueDate.TabIndex = 15
        ' 
        ' DeptTb
        ' 
        DeptTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        DeptTb.Location = New Point(352, 474)
        DeptTb.Name = "DeptTb"
        DeptTb.Size = New Size(169, 40)
        DeptTb.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(15, 482)
        Label8.Name = "Label8"
        Label8.Size = New Size(226, 32)
        Label8.TabIndex = 16
        Label8.Text = "User Department"
        ' 
        ' emptyDate
        ' 
        emptyDate.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        emptyDate.Location = New Point(24, 586)
        emptyDate.Name = "emptyDate"
        emptyDate.Size = New Size(300, 40)
        emptyDate.TabIndex = 19
        emptyDate.Value = New Date(2023, 7, 10, 21, 49, 39, 0)
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(24, 536)
        Label9.Name = "Label9"
        Label9.Size = New Size(391, 32)
        Label9.TabIndex = 18
        Label9.Text = "Empty Cylinder Received Date"
        ' 
        ' returnSuppDate
        ' 
        returnSuppDate.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        returnSuppDate.Location = New Point(24, 678)
        returnSuppDate.Name = "returnSuppDate"
        returnSuppDate.Size = New Size(300, 40)
        returnSuppDate.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(24, 643)
        Label10.Name = "Label10"
        Label10.Size = New Size(306, 32)
        Label10.TabIndex = 20
        Label10.Text = "Return to Supplier Date"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(15, 739)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 22
        Button1.Text = "Insert"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1036, 27)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 23
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1186, 27)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 24
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(1335, 27)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 25
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlDarkDark
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(558, 123)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(993, 650)
        DataGridView1.TabIndex = 26
        ' 
        ' Cylinder
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1924, 844)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(returnSuppDate)
        Controls.Add(Label10)
        Controls.Add(emptyDate)
        Controls.Add(Label9)
        Controls.Add(DeptTb)
        Controls.Add(Label8)
        Controls.Add(IssueDate)
        Controls.Add(ReceiptDate)
        Controls.Add(Label7)
        Controls.Add(cisfNoTb)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(CylNoTb)
        Controls.Add(Label4)
        Controls.Add(MaterialDesTb)
        Controls.Add(Label3)
        Controls.Add(VendorNameTb)
        Controls.Add(Label2)
        Controls.Add(poNoTb)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        ForeColor = SystemColors.ControlText
        Name = "Cylinder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cylinder"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents poNoTb As TextBox
    Friend WithEvents VendorNameTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialDesTb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CylNoTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cisfNoTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ReceiptDate As DateTimePicker
    Friend WithEvents IssueDate As DateTimePicker
    Friend WithEvents DeptTb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents emptyDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents returnSuppDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
