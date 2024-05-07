<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestforVehicle
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
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        pnl = New Panel()
        DRIVERS = New GroupBox()
        Driver3 = New RadioButton()
        Driver2 = New RadioButton()
        Driver4 = New RadioButton()
        Driver1 = New RadioButton()
        Bus = New RadioButton()
        van2 = New RadioButton()
        van1 = New RadioButton()
        Label13 = New Label()
        Saveib = New FontAwesome.Sharp.IconButton()
        Saveasib = New FontAwesome.Sharp.IconButton()
        Printib = New FontAwesome.Sharp.IconButton()
        Durationtraveltb = New TextBox()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label12 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Requestformpositiontb = New TextBox()
        Requestformnametb = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Approvalpositiontb = New TextBox()
        Approvalnametb = New TextBox()
        TextBox10 = New TextBox()
        Designationtb = New TextBox()
        Requesttb = New TextBox()
        Purposetraveltb = New TextBox()
        Placetraveltb = New TextBox()
        PrintDialog1 = New PrintDialog()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnl.SuspendLayout()
        DRIVERS.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1494, 54)
        Panel2.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources._435855055_799176175464134_3275853665321099150_n
        PictureBox1.Location = New Point(385, 90)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(569, 473)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' pnl
        ' 
        pnl.Controls.Add(DRIVERS)
        pnl.Controls.Add(Bus)
        pnl.Controls.Add(van2)
        pnl.Controls.Add(van1)
        pnl.Controls.Add(Label13)
        pnl.Controls.Add(Saveib)
        pnl.Controls.Add(Saveasib)
        pnl.Controls.Add(Printib)
        pnl.Controls.Add(Durationtraveltb)
        pnl.Controls.Add(DateTimePicker2)
        pnl.Controls.Add(DateTimePicker1)
        pnl.Controls.Add(Label12)
        pnl.Controls.Add(Label10)
        pnl.Controls.Add(Label11)
        pnl.Controls.Add(Label8)
        pnl.Controls.Add(Label9)
        pnl.Controls.Add(Requestformpositiontb)
        pnl.Controls.Add(Requestformnametb)
        pnl.Controls.Add(Label7)
        pnl.Controls.Add(Label6)
        pnl.Controls.Add(Label5)
        pnl.Controls.Add(Label4)
        pnl.Controls.Add(Label3)
        pnl.Controls.Add(Label2)
        pnl.Controls.Add(Label1)
        pnl.Controls.Add(Approvalpositiontb)
        pnl.Controls.Add(Approvalnametb)
        pnl.Controls.Add(TextBox10)
        pnl.Controls.Add(Designationtb)
        pnl.Controls.Add(Requesttb)
        pnl.Controls.Add(Purposetraveltb)
        pnl.Controls.Add(Placetraveltb)
        pnl.Controls.Add(PictureBox1)
        pnl.Location = New Point(0, 60)
        pnl.Name = "pnl"
        pnl.Size = New Size(1506, 720)
        pnl.TabIndex = 4
        ' 
        ' DRIVERS
        ' 
        DRIVERS.Controls.Add(Driver3)
        DRIVERS.Controls.Add(Driver2)
        DRIVERS.Controls.Add(Driver4)
        DRIVERS.Controls.Add(Driver1)
        DRIVERS.Location = New Point(988, 28)
        DRIVERS.Name = "DRIVERS"
        DRIVERS.Size = New Size(294, 162)
        DRIVERS.TabIndex = 137
        DRIVERS.TabStop = False
        DRIVERS.Text = "DRIVERS"
        ' 
        ' Driver3
        ' 
        Driver3.AutoSize = True
        Driver3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Driver3.Location = New Point(18, 26)
        Driver3.Name = "Driver3"
        Driver3.Size = New Size(240, 29)
        Driver3.TabIndex = 135
        Driver3.TabStop = True
        Driver3.Text = "Dominador L. Espiritu,Jr."
        Driver3.UseVisualStyleBackColor = True
        ' 
        ' Driver2
        ' 
        Driver2.AutoSize = True
        Driver2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Driver2.Location = New Point(18, 114)
        Driver2.Name = "Driver2"
        Driver2.Size = New Size(171, 29)
        Driver2.TabIndex = 134
        Driver2.TabStop = True
        Driver2.Text = "Jerome C. Flores"
        Driver2.UseVisualStyleBackColor = True
        ' 
        ' Driver4
        ' 
        Driver4.AutoSize = True
        Driver4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Driver4.Location = New Point(18, 55)
        Driver4.Name = "Driver4"
        Driver4.Size = New Size(156, 29)
        Driver4.TabIndex = 136
        Driver4.TabStop = True
        Driver4.Text = "Jerson P. Ualat"
        Driver4.UseVisualStyleBackColor = True
        ' 
        ' Driver1
        ' 
        Driver1.AutoSize = True
        Driver1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Driver1.Location = New Point(18, 90)
        Driver1.Name = "Driver1"
        Driver1.Size = New Size(179, 29)
        Driver1.TabIndex = 133
        Driver1.TabStop = True
        Driver1.Text = "Marlon B. Martin"
        Driver1.UseVisualStyleBackColor = True
        ' 
        ' Bus
        ' 
        Bus.AutoSize = True
        Bus.Font = New Font("Segoe UI", 10.25F, FontStyle.Bold)
        Bus.Location = New Point(14, 112)
        Bus.Name = "Bus"
        Bus.Size = New Size(152, 29)
        Bus.TabIndex = 132
        Bus.TabStop = True
        Bus.Text = "Bus (SKV 667)"
        Bus.UseVisualStyleBackColor = True
        ' 
        ' van2
        ' 
        van2.AutoSize = True
        van2.Font = New Font("Segoe UI", 10.25F, FontStyle.Bold)
        van2.Location = New Point(14, 70)
        van2.Name = "van2"
        van2.Size = New Size(231, 29)
        van2.TabIndex = 131
        van2.TabStop = True
        van2.Text = "Van (1312-0000441416)"
        van2.UseVisualStyleBackColor = True
        ' 
        ' van1
        ' 
        van1.AutoSize = True
        van1.Font = New Font("Segoe UI", 10.25F, FontStyle.Bold)
        van1.Location = New Point(14, 28)
        van1.Name = "van1"
        van1.Size = New Size(231, 29)
        van1.TabIndex = 130
        van1.TabStop = True
        van1.Text = "Van (1312-0000441415)"
        van1.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(506, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(419, 37)
        Label13.TabIndex = 129
        Label13.Text = "REQUEST FORM FOR VEHICLE"
        ' 
        ' Saveib
        ' 
        Saveib.BackColor = Color.Silver
        Saveib.FlatStyle = FlatStyle.Flat
        Saveib.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Saveib.IconChar = FontAwesome.Sharp.IconChar.Save
        Saveib.IconColor = Color.Black
        Saveib.IconFont = FontAwesome.Sharp.IconFont.Auto
        Saveib.ImageAlign = ContentAlignment.MiddleLeft
        Saveib.Location = New Point(1218, 628)
        Saveib.Name = "Saveib"
        Saveib.Size = New Size(127, 50)
        Saveib.TabIndex = 127
        Saveib.Text = "Save"
        Saveib.TextImageRelation = TextImageRelation.ImageBeforeText
        Saveib.UseVisualStyleBackColor = False
        ' 
        ' Saveasib
        ' 
        Saveasib.BackColor = Color.Silver
        Saveasib.FlatStyle = FlatStyle.Flat
        Saveasib.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Saveasib.IconChar = FontAwesome.Sharp.IconChar.None
        Saveasib.IconColor = Color.Black
        Saveasib.IconFont = FontAwesome.Sharp.IconFont.Auto
        Saveasib.Location = New Point(1060, 628)
        Saveasib.Name = "Saveasib"
        Saveasib.Size = New Size(111, 50)
        Saveasib.TabIndex = 126
        Saveasib.Text = "Save As"
        Saveasib.UseVisualStyleBackColor = False
        ' 
        ' Printib
        ' 
        Printib.BackColor = Color.Silver
        Printib.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Printib.FlatStyle = FlatStyle.Flat
        Printib.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Printib.IconChar = FontAwesome.Sharp.IconChar.Print
        Printib.IconColor = Color.Black
        Printib.IconFont = FontAwesome.Sharp.IconFont.Auto
        Printib.ImageAlign = ContentAlignment.MiddleLeft
        Printib.Location = New Point(879, 628)
        Printib.Name = "Printib"
        Printib.Size = New Size(127, 50)
        Printib.TabIndex = 125
        Printib.Text = "Print"
        Printib.TextImageRelation = TextImageRelation.ImageBeforeText
        Printib.UseVisualStyleBackColor = False
        ' 
        ' Durationtraveltb
        ' 
        Durationtraveltb.BorderStyle = BorderStyle.FixedSingle
        Durationtraveltb.Location = New Point(960, 359)
        Durationtraveltb.Name = "Durationtraveltb"
        Durationtraveltb.Size = New Size(285, 39)
        Durationtraveltb.TabIndex = 124
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DateTimePicker2.Location = New Point(958, 275)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(354, 34)
        DateTimePicker2.TabIndex = 123
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(958, 215)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(354, 34)
        DateTimePicker1.TabIndex = 122
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label12.Location = New Point(762, 359)
        Label12.Name = "Label12"
        Label12.Size = New Size(190, 28)
        Label12.TabIndex = 121
        Label12.Text = "Duration of Travel:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label10.Location = New Point(801, 281)
        Label10.Name = "Label10"
        Label10.Size = New Size(151, 28)
        Label10.TabIndex = 120
        Label10.Text = "Date of Travel:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label11.Location = New Point(782, 215)
        Label11.Name = "Label11"
        Label11.Size = New Size(170, 28)
        Label11.TabIndex = 119
        Label11.Text = "Date of Request:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label8.Location = New Point(861, 474)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 28)
        Label8.TabIndex = 118
        Label8.Text = "Position:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label9.Location = New Point(879, 420)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 28)
        Label9.TabIndex = 117
        Label9.Text = "Name:"
        ' 
        ' Requestformpositiontb
        ' 
        Requestformpositiontb.BorderStyle = BorderStyle.FixedSingle
        Requestformpositiontb.Location = New Point(958, 474)
        Requestformpositiontb.Name = "Requestformpositiontb"
        Requestformpositiontb.Size = New Size(235, 39)
        Requestformpositiontb.TabIndex = 116
        ' 
        ' Requestformnametb
        ' 
        Requestformnametb.BorderStyle = BorderStyle.FixedSingle
        Requestformnametb.Location = New Point(960, 420)
        Requestformnametb.Name = "Requestformnametb"
        Requestformnametb.Size = New Size(235, 39)
        Requestformnametb.TabIndex = 115
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.Location = New Point(25, 549)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 28)
        Label7.TabIndex = 114
        Label7.Text = "Position:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.Location = New Point(25, 499)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 28)
        Label6.TabIndex = 113
        Label6.Text = "Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label5.Location = New Point(25, 396)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 28)
        Label5.TabIndex = 112
        Label5.Text = "Designation:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(25, 340)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 28)
        Label4.TabIndex = 111
        Label4.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(25, 301)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 28)
        Label3.TabIndex = 110
        Label3.Text = "Requested By"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(25, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 28)
        Label2.TabIndex = 109
        Label2.Text = "Purpose of Travel:" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(25, 201)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 28)
        Label1.TabIndex = 108
        Label1.Text = "Place of Travel:"
        ' 
        ' Approvalpositiontb
        ' 
        Approvalpositiontb.BorderStyle = BorderStyle.FixedSingle
        Approvalpositiontb.Location = New Point(202, 549)
        Approvalpositiontb.Name = "Approvalpositiontb"
        Approvalpositiontb.Size = New Size(226, 39)
        Approvalpositiontb.TabIndex = 107
        ' 
        ' Approvalnametb
        ' 
        Approvalnametb.BorderStyle = BorderStyle.FixedSingle
        Approvalnametb.Location = New Point(202, 488)
        Approvalnametb.Name = "Approvalnametb"
        Approvalnametb.Size = New Size(226, 39)
        Approvalnametb.TabIndex = 106
        ' 
        ' TextBox10
        ' 
        TextBox10.BorderStyle = BorderStyle.None
        TextBox10.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        TextBox10.Location = New Point(25, 455)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(243, 27)
        TextBox10.TabIndex = 105
        TextBox10.Text = "Recommending Approval:"
        ' 
        ' Designationtb
        ' 
        Designationtb.BorderStyle = BorderStyle.FixedSingle
        Designationtb.Location = New Point(202, 385)
        Designationtb.Name = "Designationtb"
        Designationtb.Size = New Size(226, 39)
        Designationtb.TabIndex = 104
        ' 
        ' Requesttb
        ' 
        Requesttb.BorderStyle = BorderStyle.FixedSingle
        Requesttb.Location = New Point(202, 329)
        Requesttb.Name = "Requesttb"
        Requesttb.Size = New Size(226, 39)
        Requesttb.TabIndex = 103
        ' 
        ' Purposetraveltb
        ' 
        Purposetraveltb.BorderStyle = BorderStyle.FixedSingle
        Purposetraveltb.Location = New Point(205, 243)
        Purposetraveltb.Name = "Purposetraveltb"
        Purposetraveltb.Size = New Size(223, 39)
        Purposetraveltb.TabIndex = 102
        ' 
        ' Placetraveltb
        ' 
        Placetraveltb.BorderStyle = BorderStyle.FixedSingle
        Placetraveltb.Font = New Font("Segoe UI", 9F)
        Placetraveltb.Location = New Point(205, 202)
        Placetraveltb.Name = "Placetraveltb"
        Placetraveltb.Size = New Size(223, 27)
        Placetraveltb.TabIndex = 101
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' RequestforVehicle
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1494, 766)
        Controls.Add(pnl)
        Controls.Add(Panel2)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5)
        Name = "RequestforVehicle"
        Text = "RequestforVehicle"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnl.ResumeLayout(False)
        pnl.PerformLayout()
        DRIVERS.ResumeLayout(False)
        DRIVERS.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnl As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Saveib As FontAwesome.Sharp.IconButton
    Friend WithEvents Saveasib As FontAwesome.Sharp.IconButton
    Friend WithEvents Printib As FontAwesome.Sharp.IconButton
    Friend WithEvents Durationtraveltb As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Requestformpositiontb As TextBox
    Friend WithEvents Requestformnametb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Approvalpositiontb As TextBox
    Friend WithEvents Approvalnametb As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Designationtb As TextBox
    Friend WithEvents Requesttb As TextBox
    Friend WithEvents Purposetraveltb As TextBox
    Friend WithEvents Placetraveltb As TextBox
    Friend WithEvents Bus As RadioButton
    Friend WithEvents van2 As RadioButton
    Friend WithEvents van1 As RadioButton
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Driver4 As RadioButton
    Friend WithEvents Driver3 As RadioButton
    Friend WithEvents Driver2 As RadioButton
    Friend WithEvents Driver1 As RadioButton
    Friend WithEvents DRIVERS As GroupBox
End Class
