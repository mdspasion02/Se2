Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tripticket
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
        save_tb = New FontAwesome.Sharp.IconButton()
        saveas_tb = New FontAwesome.Sharp.IconButton()
        print_tb = New FontAwesome.Sharp.IconButton()
        Label24 = New Label()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label9 = New Label()
        used_grease_issued_tb = New TextBox()
        oil_lubricant_tb = New TextBox()
        oilused_tb = New TextBox()
        distancetraveled_tb = New TextBox()
        drivername_tb = New TextBox()
        Driver_spare_tb = New TextBox()
        fuel_consuption_tb = New TextBox()
        purchased = New TextBox()
        tankbalance_tb = New TextBox()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        timearrival_tb = New TextBox()
        placearrival_tb = New TextBox()
        placedeparture_tb = New TextBox()
        timedeparture_tb = New TextBox()
        datetrip_tb = New TextBox()
        Label10 = New Label()
        designationtb = New TextBox()
        passenger4 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        purpose_tb = New TextBox()
        destination_tb = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        passenger6 = New TextBox()
        passenger5 = New TextBox()
        nametb = New TextBox()
        passenger3 = New TextBox()
        passenger2 = New TextBox()
        passenger1 = New TextBox()
        Label4 = New Label()
        DateTimePicker2 = New DateTimePicker()
        Label3 = New Label()
        driver_tb = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Panel2 = New Panel()
        van1 = New RadioButton()
        van2 = New RadioButton()
        bus = New RadioButton()
        groupbox = New GroupBox()
        driver4 = New RadioButton()
        driver3 = New RadioButton()
        driver2 = New RadioButton()
        driver1 = New RadioButton()
        PictureBox1 = New PictureBox()
        groupbox.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' save_tb
        ' 
        save_tb.BackColor = Color.Silver
        save_tb.FlatStyle = FlatStyle.Flat
        save_tb.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        save_tb.IconChar = FontAwesome.Sharp.IconChar.Save
        save_tb.IconColor = Color.Black
        save_tb.IconFont = FontAwesome.Sharp.IconFont.Auto
        save_tb.ImageAlign = ContentAlignment.MiddleLeft
        save_tb.Location = New Point(1242, 939)
        save_tb.Margin = New Padding(3, 4, 3, 4)
        save_tb.Name = "save_tb"
        save_tb.Size = New Size(145, 67)
        save_tb.TabIndex = 126
        save_tb.Text = "Save"
        save_tb.TextImageRelation = TextImageRelation.ImageBeforeText
        save_tb.UseVisualStyleBackColor = False
        ' 
        ' saveas_tb
        ' 
        saveas_tb.BackColor = Color.Silver
        saveas_tb.FlatStyle = FlatStyle.Flat
        saveas_tb.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        saveas_tb.IconChar = FontAwesome.Sharp.IconChar.None
        saveas_tb.IconColor = Color.Black
        saveas_tb.IconFont = FontAwesome.Sharp.IconFont.Auto
        saveas_tb.Location = New Point(1078, 939)
        saveas_tb.Margin = New Padding(3, 4, 3, 4)
        saveas_tb.Name = "saveas_tb"
        saveas_tb.Size = New Size(127, 67)
        saveas_tb.TabIndex = 125
        saveas_tb.Text = "Save As"
        saveas_tb.UseVisualStyleBackColor = False
        ' 
        ' print_tb
        ' 
        print_tb.BackColor = Color.Silver
        print_tb.FlatStyle = FlatStyle.Flat
        print_tb.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        print_tb.IconChar = FontAwesome.Sharp.IconChar.Print
        print_tb.IconColor = Color.Black
        print_tb.IconFont = FontAwesome.Sharp.IconFont.Auto
        print_tb.ImageAlign = ContentAlignment.MiddleLeft
        print_tb.Location = New Point(911, 939)
        print_tb.Margin = New Padding(3, 4, 3, 4)
        print_tb.Name = "print_tb"
        print_tb.Size = New Size(127, 67)
        print_tb.TabIndex = 124
        print_tb.Text = "Print"
        print_tb.TextImageRelation = TextImageRelation.ImageBeforeText
        print_tb.UseVisualStyleBackColor = False
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label24.Location = New Point(747, 697)
        Label24.Name = "Label24"
        Label24.Size = New Size(198, 28)
        Label24.TabIndex = 123
        Label24.Text = "Used Grease Issued:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label21.Location = New Point(751, 628)
        Label21.Name = "Label21"
        Label21.Size = New Size(134, 28)
        Label21.TabIndex = 122
        Label21.Text = "Lubricant Oil"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label22.Location = New Point(747, 581)
        Label22.Name = "Label22"
        Label22.Size = New Size(136, 28)
        Label22.TabIndex = 121
        Label22.Text = "Gear oil used"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label23.Location = New Point(747, 540)
        Label23.Name = "Label23"
        Label23.Size = New Size(180, 28)
        Label23.TabIndex = 120
        Label23.Text = "Distance Traveled"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label20.Location = New Point(304, 871)
        Label20.Name = "Label20"
        Label20.Size = New Size(162, 56)
        Label20.TabIndex = 119
        Label20.Text = "Spare of Driver:" & vbCrLf & "(If applicable)"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label19.Location = New Point(304, 811)
        Label19.Name = "Label19"
        Label19.Size = New Size(165, 28)
        Label19.TabIndex = 118
        Label19.Text = "Name of Driver:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label18.Location = New Point(304, 675)
        Label18.Name = "Label18"
        Label18.Size = New Size(182, 28)
        Label18.TabIndex = 117
        Label18.Text = "Fuel Consumption"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label17.Location = New Point(301, 628)
        Label17.Name = "Label17"
        Label17.Size = New Size(109, 28)
        Label17.TabIndex = 116
        Label17.Text = "Purchased"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label9.Location = New Point(685, 324)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 28)
        Label9.TabIndex = 115
        Label9.Text = "NAME:"
        ' 
        ' used_grease_issued_tb
        ' 
        used_grease_issued_tb.Location = New Point(934, 692)
        used_grease_issued_tb.Margin = New Padding(3, 4, 3, 4)
        used_grease_issued_tb.Name = "used_grease_issued_tb"
        used_grease_issued_tb.Size = New Size(235, 27)
        used_grease_issued_tb.TabIndex = 113
        ' 
        ' oil_lubricant_tb
        ' 
        oil_lubricant_tb.Location = New Point(934, 621)
        oil_lubricant_tb.Margin = New Padding(3, 4, 3, 4)
        oil_lubricant_tb.Name = "oil_lubricant_tb"
        oil_lubricant_tb.Size = New Size(235, 27)
        oil_lubricant_tb.TabIndex = 112
        ' 
        ' oilused_tb
        ' 
        oilused_tb.Location = New Point(934, 573)
        oilused_tb.Margin = New Padding(3, 4, 3, 4)
        oilused_tb.Name = "oilused_tb"
        oilused_tb.Size = New Size(235, 27)
        oilused_tb.TabIndex = 111
        ' 
        ' distancetraveled_tb
        ' 
        distancetraveled_tb.Location = New Point(934, 535)
        distancetraveled_tb.Margin = New Padding(3, 4, 3, 4)
        distancetraveled_tb.Name = "distancetraveled_tb"
        distancetraveled_tb.Size = New Size(235, 27)
        distancetraveled_tb.TabIndex = 110
        ' 
        ' drivername_tb
        ' 
        drivername_tb.Location = New Point(480, 805)
        drivername_tb.Margin = New Padding(3, 4, 3, 4)
        drivername_tb.Name = "drivername_tb"
        drivername_tb.Size = New Size(235, 27)
        drivername_tb.TabIndex = 109
        ' 
        ' Driver_spare_tb
        ' 
        Driver_spare_tb.Location = New Point(473, 872)
        Driver_spare_tb.Margin = New Padding(3, 4, 3, 4)
        Driver_spare_tb.Name = "Driver_spare_tb"
        Driver_spare_tb.Size = New Size(235, 27)
        Driver_spare_tb.TabIndex = 108
        ' 
        ' fuel_consuption_tb
        ' 
        fuel_consuption_tb.Location = New Point(480, 675)
        fuel_consuption_tb.Margin = New Padding(3, 4, 3, 4)
        fuel_consuption_tb.Name = "fuel_consuption_tb"
        fuel_consuption_tb.Size = New Size(235, 27)
        fuel_consuption_tb.TabIndex = 107
        ' 
        ' purchased
        ' 
        purchased.Location = New Point(480, 628)
        purchased.Margin = New Padding(3, 4, 3, 4)
        purchased.Name = "purchased"
        purchased.Size = New Size(235, 27)
        purchased.TabIndex = 106
        ' 
        ' tankbalance_tb
        ' 
        tankbalance_tb.Location = New Point(480, 589)
        tankbalance_tb.Margin = New Padding(3, 4, 3, 4)
        tankbalance_tb.Name = "tankbalance_tb"
        tankbalance_tb.Size = New Size(235, 27)
        tankbalance_tb.TabIndex = 105
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(21, 908)
        Label14.Name = "Label14"
        Label14.Size = New Size(145, 28)
        Label14.TabIndex = 104
        Label14.Text = "Place(Arrival):"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label15.Location = New Point(301, 587)
        Label15.Name = "Label15"
        Label15.Size = New Size(166, 28)
        Label15.TabIndex = 103
        Label15.Text = "Balance in Tank "
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label16.Location = New Point(325, 527)
        Label16.Name = "Label16"
        Label16.Size = New Size(150, 28)
        Label16.TabIndex = 102
        Label16.Text = "Gasoline Used:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(17, 627)
        Label11.Name = "Label11"
        Label11.Size = New Size(175, 28)
        Label11.TabIndex = 101
        Label11.Text = "Time(Departure):"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(14, 715)
        Label12.Name = "Label12"
        Label12.Size = New Size(173, 28)
        Label12.TabIndex = 100
        Label12.Text = "Place(Departure)"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(17, 803)
        Label13.Name = "Label13"
        Label13.Size = New Size(142, 28)
        Label13.TabIndex = 99
        Label13.Text = "Time(Arrival):"
        ' 
        ' timearrival_tb
        ' 
        timearrival_tb.Location = New Point(27, 853)
        timearrival_tb.Margin = New Padding(3, 4, 3, 4)
        timearrival_tb.Name = "timearrival_tb"
        timearrival_tb.Size = New Size(235, 27)
        timearrival_tb.TabIndex = 98
        ' 
        ' placearrival_tb
        ' 
        placearrival_tb.Location = New Point(17, 939)
        placearrival_tb.Margin = New Padding(3, 4, 3, 4)
        placearrival_tb.Name = "placearrival_tb"
        placearrival_tb.Size = New Size(235, 27)
        placearrival_tb.TabIndex = 97
        ' 
        ' placedeparture_tb
        ' 
        placedeparture_tb.Location = New Point(17, 747)
        placedeparture_tb.Margin = New Padding(3, 4, 3, 4)
        placedeparture_tb.Name = "placedeparture_tb"
        placedeparture_tb.Size = New Size(235, 27)
        placedeparture_tb.TabIndex = 96
        ' 
        ' timedeparture_tb
        ' 
        timedeparture_tb.Location = New Point(14, 657)
        timedeparture_tb.Margin = New Padding(3, 4, 3, 4)
        timedeparture_tb.Name = "timedeparture_tb"
        timedeparture_tb.Size = New Size(235, 27)
        timedeparture_tb.TabIndex = 95
        ' 
        ' datetrip_tb
        ' 
        datetrip_tb.Location = New Point(14, 567)
        datetrip_tb.Margin = New Padding(3, 4, 3, 4)
        datetrip_tb.Name = "datetrip_tb"
        datetrip_tb.Size = New Size(235, 27)
        datetrip_tb.TabIndex = 94
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(14, 523)
        Label10.Name = "Label10"
        Label10.Size = New Size(146, 28)
        Label10.TabIndex = 93
        Label10.Text = "Date(Trip No.)"
        ' 
        ' designationtb
        ' 
        designationtb.Location = New Point(847, 373)
        designationtb.Margin = New Padding(3, 4, 3, 4)
        designationtb.Name = "designationtb"
        designationtb.Size = New Size(235, 27)
        designationtb.TabIndex = 92
        ' 
        ' passenger4
        ' 
        passenger4.Location = New Point(304, 317)
        passenger4.Margin = New Padding(3, 4, 3, 4)
        passenger4.Name = "passenger4"
        passenger4.Size = New Size(235, 27)
        passenger4.TabIndex = 91
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label7.Location = New Point(685, 279)
        Label7.Name = "Label7"
        Label7.Size = New Size(138, 28)
        Label7.TabIndex = 90
        Label7.Text = "Approved by:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label8.Location = New Point(685, 379)
        Label8.Name = "Label8"
        Label8.Size = New Size(152, 28)
        Label8.TabIndex = 89
        Label8.Text = "DESIGNATION:"
        ' 
        ' purpose_tb
        ' 
        purpose_tb.Location = New Point(869, 149)
        purpose_tb.Margin = New Padding(3, 4, 3, 4)
        purpose_tb.Name = "purpose_tb"
        purpose_tb.Size = New Size(235, 27)
        purpose_tb.TabIndex = 88
        ' 
        ' destination_tb
        ' 
        destination_tb.Location = New Point(869, 96)
        destination_tb.Margin = New Padding(3, 4, 3, 4)
        destination_tb.Name = "destination_tb"
        destination_tb.Size = New Size(235, 27)
        destination_tb.TabIndex = 87
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label6.Location = New Point(722, 152)
        Label6.Name = "Label6"
        Label6.Size = New Size(105, 28)
        Label6.TabIndex = 86
        Label6.Text = "PURPOSE:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label5.Location = New Point(714, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 28)
        Label5.TabIndex = 85
        Label5.Text = "DESTINATION:"
        ' 
        ' passenger6
        ' 
        passenger6.Location = New Point(304, 455)
        passenger6.Margin = New Padding(3, 4, 3, 4)
        passenger6.Name = "passenger6"
        passenger6.Size = New Size(235, 27)
        passenger6.TabIndex = 84
        ' 
        ' passenger5
        ' 
        passenger5.Location = New Point(304, 389)
        passenger5.Margin = New Padding(3, 4, 3, 4)
        passenger5.Name = "passenger5"
        passenger5.Size = New Size(235, 27)
        passenger5.TabIndex = 83
        ' 
        ' nametb
        ' 
        nametb.Location = New Point(779, 321)
        nametb.Margin = New Padding(3, 4, 3, 4)
        nametb.Name = "nametb"
        nametb.Size = New Size(254, 27)
        nametb.TabIndex = 82
        ' 
        ' passenger3
        ' 
        passenger3.Location = New Point(14, 455)
        passenger3.Margin = New Padding(3, 4, 3, 4)
        passenger3.Name = "passenger3"
        passenger3.Size = New Size(235, 27)
        passenger3.TabIndex = 81
        ' 
        ' passenger2
        ' 
        passenger2.Location = New Point(14, 389)
        passenger2.Margin = New Padding(3, 4, 3, 4)
        passenger2.Name = "passenger2"
        passenger2.Size = New Size(235, 27)
        passenger2.TabIndex = 80
        ' 
        ' passenger1
        ' 
        passenger1.Location = New Point(14, 325)
        passenger1.Margin = New Padding(3, 4, 3, 4)
        passenger1.Name = "passenger1"
        passenger1.Size = New Size(235, 27)
        passenger1.TabIndex = 79
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label4.Location = New Point(14, 279)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 28)
        Label4.TabIndex = 78
        Label4.Text = "Authorized Passenger/s:"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI", 12.0F)
        DateTimePicker2.Location = New Point(151, 215)
        DateTimePicker2.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(315, 34)
        DateTimePicker2.TabIndex = 77
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label3.Location = New Point(13, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 28)
        Label3.TabIndex = 76
        Label3.Text = "TRAVEL DATE:"
        ' 
        ' driver_tb
        ' 
        driver_tb.Font = New Font("Segoe UI", 12.0F)
        driver_tb.Location = New Point(151, 152)
        driver_tb.Margin = New Padding(3, 4, 3, 4)
        driver_tb.Name = "driver_tb"
        driver_tb.Size = New Size(315, 34)
        driver_tb.TabIndex = 75
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label2.Location = New Point(21, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 28)
        Label2.TabIndex = 74
        Label2.Text = "DRIVER:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(27, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 28)
        Label1.TabIndex = 73
        Label1.Text = "DATE:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 12.0F)
        DateTimePicker1.Location = New Point(151, 95)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(315, 34)
        DateTimePicker1.TabIndex = 72
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1700, 71)
        Panel2.TabIndex = 127
        ' 
        ' van1
        ' 
        van1.AutoSize = True
        van1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        van1.Location = New Point(1156, 98)
        van1.Name = "van1"
        van1.Size = New Size(231, 29)
        van1.TabIndex = 128
        van1.TabStop = True
        van1.Text = "Van (1312-0000441415)"
        van1.UseVisualStyleBackColor = True
        ' 
        ' van2
        ' 
        van2.AutoSize = True
        van2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        van2.Location = New Point(1156, 133)
        van2.Name = "van2"
        van2.Size = New Size(231, 29)
        van2.TabIndex = 129
        van2.TabStop = True
        van2.Text = "Van (1312-0000441416)"
        van2.UseVisualStyleBackColor = True
        ' 
        ' bus
        ' 
        bus.AutoSize = True
        bus.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bus.Location = New Point(1156, 168)
        bus.Name = "bus"
        bus.Size = New Size(113, 29)
        bus.TabIndex = 130
        bus.TabStop = True
        bus.Text = "Bus (667)"
        bus.UseVisualStyleBackColor = True
        ' 
        ' groupbox
        ' 
        groupbox.Controls.Add(driver4)
        groupbox.Controls.Add(driver3)
        groupbox.Controls.Add(driver2)
        groupbox.Controls.Add(driver1)
        groupbox.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        groupbox.Location = New Point(1156, 246)
        groupbox.Name = "groupbox"
        groupbox.Size = New Size(231, 170)
        groupbox.TabIndex = 131
        groupbox.TabStop = False
        groupbox.Text = "Drivers_name"
        ' 
        ' driver4
        ' 
        driver4.AutoSize = True
        driver4.Location = New Point(27, 137)
        driver4.Name = "driver4"
        driver4.Size = New Size(132, 24)
        driver4.TabIndex = 3
        driver4.TabStop = True
        driver4.Text = "Jerson P. Ualat"
        driver4.UseVisualStyleBackColor = True
        ' 
        ' driver3
        ' 
        driver3.AutoSize = True
        driver3.Location = New Point(27, 97)
        driver3.Name = "driver3"
        driver3.Size = New Size(202, 24)
        driver3.TabIndex = 2
        driver3.TabStop = True
        driver3.Text = "Dominador L. Espiritu,Jr."
        driver3.UseVisualStyleBackColor = True
        ' 
        ' driver2
        ' 
        driver2.AutoSize = True
        driver2.Location = New Point(27, 67)
        driver2.Name = "driver2"
        driver2.Size = New Size(145, 24)
        driver2.TabIndex = 1
        driver2.TabStop = True
        driver2.Text = "Jerome C. Flores"
        driver2.UseVisualStyleBackColor = True
        ' 
        ' driver1
        ' 
        driver1.AutoSize = True
        driver1.Location = New Point(27, 37)
        driver1.Name = "driver1"
        driver1.Size = New Size(149, 24)
        driver1.TabIndex = 0
        driver1.TabStop = True
        driver1.Text = "Marlon B. Martin"
        driver1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources._435855055_799176175464134_3275853665321099150_n
        PictureBox1.Location = New Point(416, 168)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(806, 546)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 132
        PictureBox1.TabStop = False
        ' 
        ' Tripticket
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1700, 1102)
        Controls.Add(groupbox)
        Controls.Add(bus)
        Controls.Add(van2)
        Controls.Add(van1)
        Controls.Add(Panel2)
        Controls.Add(save_tb)
        Controls.Add(saveas_tb)
        Controls.Add(print_tb)
        Controls.Add(Label24)
        Controls.Add(Label21)
        Controls.Add(Label22)
        Controls.Add(Label23)
        Controls.Add(Label20)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label9)
        Controls.Add(used_grease_issued_tb)
        Controls.Add(oil_lubricant_tb)
        Controls.Add(oilused_tb)
        Controls.Add(distancetraveled_tb)
        Controls.Add(drivername_tb)
        Controls.Add(Driver_spare_tb)
        Controls.Add(fuel_consuption_tb)
        Controls.Add(purchased)
        Controls.Add(tankbalance_tb)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Label16)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(timearrival_tb)
        Controls.Add(placearrival_tb)
        Controls.Add(placedeparture_tb)
        Controls.Add(timedeparture_tb)
        Controls.Add(datetrip_tb)
        Controls.Add(Label10)
        Controls.Add(designationtb)
        Controls.Add(passenger4)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(purpose_tb)
        Controls.Add(destination_tb)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(passenger6)
        Controls.Add(passenger5)
        Controls.Add(nametb)
        Controls.Add(passenger3)
        Controls.Add(passenger2)
        Controls.Add(passenger1)
        Controls.Add(Label4)
        Controls.Add(DateTimePicker2)
        Controls.Add(Label3)
        Controls.Add(driver_tb)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Tripticket"
        Text = "Tripticket"
        groupbox.ResumeLayout(False)
        groupbox.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents save_tb As FontAwesome.Sharp.IconButton
    Friend WithEvents saveas_tb As FontAwesome.Sharp.IconButton
    Friend WithEvents print_tb As FontAwesome.Sharp.IconButton
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents used_grease_issued_tb As TextBox
    Friend WithEvents oil_lubricant_tb As TextBox
    Friend WithEvents oilused_tb As TextBox
    Friend WithEvents distancetraveled_tb As TextBox
    Friend WithEvents drivername_tb As TextBox
    Friend WithEvents Driver_spare_tb As TextBox
    Friend WithEvents fuel_consuption_tb As TextBox
    Friend WithEvents purchased As TextBox
    Friend WithEvents tankbalance_tb As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents timearrival_tb As TextBox
    Friend WithEvents placearrival_tb As TextBox
    Friend WithEvents placedeparture_tb As TextBox
    Friend WithEvents timedeparture_tb As TextBox
    Friend WithEvents datetrip_tb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents designationtb As TextBox
    Friend WithEvents passenger4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents purpose_tb As TextBox
    Friend WithEvents destination_tb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents passenger6 As TextBox
    Friend WithEvents passenger5 As TextBox
    Friend WithEvents nametb As TextBox
    Friend WithEvents passenger3 As TextBox
    Friend WithEvents passenger2 As TextBox
    Friend WithEvents passenger1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents driver_tb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents van1 As RadioButton
    Friend WithEvents van2 As RadioButton
    Friend WithEvents bus As RadioButton
    Friend WithEvents groupbox As GroupBox
    Friend WithEvents driver4 As RadioButton
    Friend WithEvents driver3 As RadioButton
    Friend WithEvents driver2 As RadioButton
    Friend WithEvents driver1 As RadioButton

    Private Sub saveas_tb_Click(sender As Object, e As EventArgs) Handles saveas_tb.Click
        Dim filePath As String = "DataGridView1"

        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(driver_tb.Text)
                writer.WriteLine(passenger1.Text)
                writer.WriteLine(passenger2.Text)
                writer.WriteLine(passenger3.Text)
                writer.WriteLine(passenger4.Text)
                writer.WriteLine(passenger5.Text)
                writer.WriteLine(passenger6.Text)
                writer.WriteLine(datetrip_tb.Text)
                writer.WriteLine(timedeparture_tb.Text)
                writer.WriteLine(placedeparture_tb.Text)
                writer.WriteLine(timearrival_tb.Text)
                writer.WriteLine(placearrival_tb.Text)
                writer.WriteLine(tankbalance_tb.Text)
                writer.WriteLine(purchased.Text)
                writer.WriteLine(fuel_consuption_tb.Text)
                writer.WriteLine(drivername_tb.Text)
                writer.WriteLine(Driver_spare_tb.Text)
                writer.WriteLine(destination_tb.Text)
                writer.WriteLine(purpose_tb.Text)
                writer.WriteLine(nametb.Text)
                writer.WriteLine(designationtb.Text)
                writer.WriteLine(distancetraveled_tb.Text)
                writer.WriteLine(oilused_tb.Text)
                writer.WriteLine(oil_lubricant_tb.Text)
                writer.WriteLine(used_grease_issued_tb.Text)

            End Using

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub save_tb_Click(sender As Object, e As EventArgs) Handles save_tb.Click
        Dim filePath As String = "DataGridView1"

        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(driver_tb.Text)
                writer.WriteLine(passenger1.Text)
                writer.WriteLine(passenger2.Text)
                writer.WriteLine(passenger3.Text)
                writer.WriteLine(passenger4.Text)
                writer.WriteLine(passenger5.Text)
                writer.WriteLine(passenger6.Text)
                writer.WriteLine(datetrip_tb.Text)
                writer.WriteLine(timedeparture_tb.Text)
                writer.WriteLine(placedeparture_tb.Text)
                writer.WriteLine(timearrival_tb.Text)
                writer.WriteLine(placearrival_tb.Text)
                writer.WriteLine(tankbalance_tb.Text)
                writer.WriteLine(purchased.Text)
                writer.WriteLine(fuel_consuption_tb.Text)
                writer.WriteLine(drivername_tb.Text)
                writer.WriteLine(Driver_spare_tb.Text)
                writer.WriteLine(destination_tb.Text)
                writer.WriteLine(purpose_tb.Text)
                writer.WriteLine(nametb.Text)
                writer.WriteLine(designationtb.Text)
                writer.WriteLine(distancetraveled_tb.Text)
                writer.WriteLine(oilused_tb.Text)
                writer.WriteLine(oil_lubricant_tb.Text)
                writer.WriteLine(used_grease_issued_tb.Text)

            End Using

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Friend WithEvents PictureBox1 As PictureBox

    Private Sub van1_CheckedChanged(sender As Object, e As EventArgs) Handles van1.CheckedChanged
        If van1.Checked Then
            MessageBox.Show("Option 1 is selected and available.")
        ElseIf van2.Checked Then
            MessageBox.Show("Option 2 is selected and available.")
        ElseIf bus.Checked Then
            MessageBox.Show("Option 3 is selected and available.")
        Else
            MessageBox.Show("Please select an option.")
        End If

    End Sub

    Private Sub groupbox_Enter(sender As Object, e As EventArgs) Handles groupbox.Enter
        If driver1.Checked Then
            MessageBox.Show("Option 1 is selected and available.")
        ElseIf driver2.Checked Then
            MessageBox.Show("Option 2 is selected and available.")
        ElseIf driver3.Checked Then
            MessageBox.Show("Option 3 is selected and available.")
        ElseIf driver4.Checked Then
            MessageBox.Show("Option 4 is selected and available.")
        Else
            MessageBox.Show("Please select an option.")
        End If
    End Sub
End Class
