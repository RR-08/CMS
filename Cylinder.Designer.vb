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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Cylinder))
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
        CylinderDB = New Guna.UI2.WinForms.Guna2DataGridView()
        PictureBox1 = New PictureBox()
        Label11 = New Label()
        Label12 = New Label()
        Panel1 = New Panel()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        Button4 = New Button()
        CType(CylinderDB, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label1.Location = New Point(93, 239)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 32)
        Label1.TabIndex = 1
        Label1.Text = "PO Number"
        ' 
        ' poNoTb
        ' 
        poNoTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        poNoTb.Location = New Point(93, 289)
        poNoTb.Name = "poNoTb"
        poNoTb.Size = New Size(230, 40)
        poNoTb.TabIndex = 2
        ' 
        ' VendorNameTb
        ' 
        VendorNameTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        VendorNameTb.Location = New Point(405, 287)
        VendorNameTb.Name = "VendorNameTb"
        VendorNameTb.Size = New Size(230, 40)
        VendorNameTb.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label2.Location = New Point(405, 239)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 32)
        Label2.TabIndex = 3
        Label2.Text = "Vendor's Name"
        ' 
        ' MaterialDesTb
        ' 
        MaterialDesTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        MaterialDesTb.Location = New Point(93, 397)
        MaterialDesTb.Name = "MaterialDesTb"
        MaterialDesTb.Size = New Size(230, 40)
        MaterialDesTb.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label3.Location = New Point(93, 347)
        Label3.Name = "Label3"
        Label3.Size = New Size(243, 32)
        Label3.TabIndex = 5
        Label3.Text = "Matrial Description"
        ' 
        ' CylNoTb
        ' 
        CylNoTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        CylNoTb.Location = New Point(405, 391)
        CylNoTb.Name = "CylNoTb"
        CylNoTb.Size = New Size(230, 40)
        CylNoTb.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label4.Location = New Point(405, 343)
        Label4.Name = "Label4"
        Label4.Size = New Size(240, 32)
        Label4.TabIndex = 7
        Label4.Text = "Filled Cylinder No."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label5.Location = New Point(93, 455)
        Label5.Name = "Label5"
        Label5.Size = New Size(234, 32)
        Label5.TabIndex = 9
        Label5.Text = "Receipt / LR Date"
        ' 
        ' cisfNoTb
        ' 
        cisfNoTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        cisfNoTb.Location = New Point(405, 495)
        cisfNoTb.Name = "cisfNoTb"
        cisfNoTb.Size = New Size(230, 40)
        cisfNoTb.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label6.Location = New Point(405, 447)
        Label6.Name = "Label6"
        Label6.Size = New Size(194, 32)
        Label6.TabIndex = 11
        Label6.Text = "CISF Entry No"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label7.Location = New Point(93, 563)
        Label7.Name = "Label7"
        Label7.Size = New Size(163, 32)
        Label7.TabIndex = 13
        Label7.Text = "Issued Date"
        ' 
        ' ReceiptDate
        ' 
        ReceiptDate.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        ReceiptDate.Location = New Point(93, 505)
        ReceiptDate.Name = "ReceiptDate"
        ReceiptDate.Size = New Size(230, 40)
        ReceiptDate.TabIndex = 14
        ' 
        ' IssueDate
        ' 
        IssueDate.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        IssueDate.Location = New Point(405, 551)
        IssueDate.Name = "IssueDate"
        IssueDate.Size = New Size(231, 40)
        IssueDate.TabIndex = 15
        ' 
        ' DeptTb
        ' 
        DeptTb.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        DeptTb.Location = New Point(405, 607)
        DeptTb.Name = "DeptTb"
        DeptTb.Size = New Size(230, 40)
        DeptTb.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label8.Location = New Point(93, 613)
        Label8.Name = "Label8"
        Label8.Size = New Size(226, 32)
        Label8.TabIndex = 16
        Label8.Text = "User Department"
        ' 
        ' emptyDate
        ' 
        emptyDate.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        emptyDate.Location = New Point(93, 713)
        emptyDate.Name = "emptyDate"
        emptyDate.Size = New Size(230, 40)
        emptyDate.TabIndex = 19
        emptyDate.Value = New Date(2023, 7, 10, 21, 49, 39, 0)
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label9.Location = New Point(93, 663)
        Label9.Name = "Label9"
        Label9.Size = New Size(216, 32)
        Label9.TabIndex = 18
        Label9.Text = "Empty Received"
        ' 
        ' returnSuppDate
        ' 
        returnSuppDate.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        returnSuppDate.Location = New Point(405, 711)
        returnSuppDate.Name = "returnSuppDate"
        returnSuppDate.Size = New Size(258, 40)
        returnSuppDate.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Label10.Location = New Point(405, 663)
        Label10.Name = "Label10"
        Label10.Size = New Size(248, 32)
        Label10.TabIndex = 20
        Label10.Text = "Return to Supplier "
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Button1.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(82, 803)
        Button1.Name = "Button1"
        Button1.Size = New Size(185, 62)
        Button1.TabIndex = 22
        Button1.Text = "Insert"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Button2.Location = New Point(279, 803)
        Button2.Name = "Button2"
        Button2.Size = New Size(185, 62)
        Button2.TabIndex = 23
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Button3.Location = New Point(476, 803)
        Button3.Name = "Button3"
        Button3.Size = New Size(185, 62)
        Button3.TabIndex = 24
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' CylinderDB
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(247), CByte(216), CByte(189))
        CylinderDB.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        CylinderDB.BackgroundColor = Color.Gainsboro
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        CylinderDB.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        CylinderDB.ColumnHeadersHeight = 4
        CylinderDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(249), CByte(229), CByte(211))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(238), CByte(169), CByte(107))
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        CylinderDB.DefaultCellStyle = DataGridViewCellStyle6
        CylinderDB.GridColor = Color.FromArgb(CByte(245), CByte(209), CByte(177))
        CylinderDB.Location = New Point(705, 226)
        CylinderDB.Name = "CylinderDB"
        CylinderDB.RowHeadersVisible = False
        CylinderDB.RowHeadersWidth = 62
        CylinderDB.RowTemplate.Height = 33
        CylinderDB.Size = New Size(923, 525)
        CylinderDB.TabIndex = 27
        CylinderDB.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot
        CylinderDB.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(CByte(247), CByte(216), CByte(189))
        CylinderDB.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        CylinderDB.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        CylinderDB.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        CylinderDB.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        CylinderDB.ThemeStyle.BackColor = Color.Gainsboro
        CylinderDB.ThemeStyle.GridColor = Color.FromArgb(CByte(245), CByte(209), CByte(177))
        CylinderDB.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(230), CByte(126), CByte(34))
        CylinderDB.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        CylinderDB.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CylinderDB.ThemeStyle.HeaderStyle.ForeColor = Color.White
        CylinderDB.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        CylinderDB.ThemeStyle.HeaderStyle.Height = 4
        CylinderDB.ThemeStyle.ReadOnly = False
        CylinderDB.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(CByte(249), CByte(229), CByte(211))
        CylinderDB.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        CylinderDB.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CylinderDB.ThemeStyle.RowsStyle.ForeColor = Color.Black
        CylinderDB.ThemeStyle.RowsStyle.Height = 33
        CylinderDB.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(238), CByte(169), CByte(107))
        CylinderDB.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(219, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.Navy
        Label11.Location = New Point(1584, 80)
        Label11.Name = "Label11"
        Label11.Size = New Size(44, 48)
        Label11.TabIndex = 30
        Label11.Text = "X"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(236), CByte(108), CByte(33))
        Label12.Location = New Point(250, 82)
        Label12.Name = "Label12"
        Label12.Size = New Size(93, 46)
        Label12.TabIndex = 31
        Label12.Text = "CMS"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(718, 891)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 105)
        Panel1.TabIndex = 32
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.ForeColor = Color.White
        Label13.Location = New Point(1653, 603)
        Label13.Name = "Label13"
        Label13.Size = New Size(73, 25)
        Label13.TabIndex = 33
        Label13.Text = "Label13"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(705, 196)
        Label14.Name = "Label14"
        Label14.Size = New Size(43, 18)
        Label14.TabIndex = 34
        Label14.Text = "S.No"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(764, 196)
        Label15.Name = "Label15"
        Label15.Size = New Size(67, 18)
        Label15.TabIndex = 35
        Label15.Text = "PO Num"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(847, 196)
        Label16.Name = "Label16"
        Label16.Size = New Size(58, 18)
        Label16.TabIndex = 36
        Label16.Text = "Vendor"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label17.Location = New Point(921, 196)
        Label17.Name = "Label17"
        Label17.Size = New Size(64, 18)
        Label17.TabIndex = 37
        Label17.Text = "Material"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(1001, 196)
        Label18.Name = "Label18"
        Label18.Size = New Size(100, 18)
        Label18.TabIndex = 38
        Label18.Text = "Receipt Date"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label19.Location = New Point(1117, 196)
        Label19.Name = "Label19"
        Label19.Size = New Size(44, 18)
        Label19.TabIndex = 39
        Label19.Text = "CISF"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label20.Location = New Point(1177, 196)
        Label20.Name = "Label20"
        Label20.Size = New Size(77, 18)
        Label20.TabIndex = 40
        Label20.Text = "Issued On"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label21.Location = New Point(1332, 196)
        Label21.Name = "Label21"
        Label21.Size = New Size(67, 18)
        Label21.TabIndex = 41
        Label21.Text = "Emptied"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label22.Location = New Point(1415, 196)
        Label22.Name = "Label22"
        Label22.Size = New Size(95, 18)
        Label22.TabIndex = 42
        Label22.Text = "Returned On"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(1270, 196)
        Label23.Name = "Label23"
        Label23.Size = New Size(46, 18)
        Label23.TabIndex = 43
        Label23.Text = "Deptt"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.Location = New Point(1526, 196)
        Label24.Name = "Label24"
        Label24.Size = New Size(85, 18)
        Label24.TabIndex = 44
        Label24.Text = "CylinderNo"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Cursor = Cursors.Hand
        Label25.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label25.Location = New Point(1435, 99)
        Label25.Name = "Label25"
        Label25.Size = New Size(53, 25)
        Label25.TabIndex = 45
        Label25.Text = "Print "
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Cursor = Cursors.Hand
        Label26.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label26.Location = New Point(1496, 99)
        Label26.Name = "Label26"
        Label26.Size = New Size(69, 25)
        Label26.TabIndex = 46
        Label26.Text = "Logout"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Cursor = Cursors.Hand
        Label27.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label27.Location = New Point(1366, 99)
        Label27.Name = "Label27"
        Label27.Size = New Size(61, 25)
        Label27.TabIndex = 47
        Label27.Text = "Home"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.FromArgb(CByte(2), CByte(21), CByte(78))
        Button4.Location = New Point(1443, 803)
        Button4.Name = "Button4"
        Button4.Size = New Size(185, 62)
        Button4.TabIndex = 25
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Cylinder
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(1708, 1008)
        Controls.Add(Label27)
        Controls.Add(Label26)
        Controls.Add(Label25)
        Controls.Add(Label24)
        Controls.Add(Label23)
        Controls.Add(Label22)
        Controls.Add(Label21)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Panel1)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(PictureBox1)
        Controls.Add(CylinderDB)
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
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "Cylinder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cylinder"
        CType(CylinderDB, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
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
    'Friend WithEvents CylinderDb As DataGridView
    Friend WithEvents CylinderDB As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Button4 As Button
End Class
