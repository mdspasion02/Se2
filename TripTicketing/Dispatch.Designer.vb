<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dispatch
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
        Label9 = New Label()
        savetb = New FontAwesome.Sharp.IconButton()
        saveasbt = New FontAwesome.Sharp.IconButton()
        printtb = New FontAwesome.Sharp.IconButton()
        Label8 = New Label()
        drivertb = New TextBox()
        dispatchertb = New TextBox()
        Label7 = New Label()
        purposetb = New TextBox()
        officetb = New TextBox()
        placetraveltb = New TextBox()
        datetraveltb = New TextBox()
        daterequesttb = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        ListView1 = New ListView()
        Date_request = New ColumnHeader()
        Date_travel = New ColumnHeader()
        Place_Of_Travel = New ColumnHeader()
        Office_or_Purpose = New ColumnHeader()
        Plate_Number = New ColumnHeader()
        Driver = New ColumnHeader()
        Dispatcher = New ColumnHeader()
        Panel1 = New Panel()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(514, 76)
        Label9.Name = "Label9"
        Label9.Size = New Size(262, 37)
        Label9.TabIndex = 66
        Label9.Text = "LIST OF DISPATCH"
        ' 
        ' savetb
        ' 
        savetb.BackColor = Color.Silver
        savetb.FlatStyle = FlatStyle.Flat
        savetb.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        savetb.IconChar = FontAwesome.Sharp.IconChar.Save
        savetb.IconColor = Color.Black
        savetb.IconFont = FontAwesome.Sharp.IconFont.Auto
        savetb.ImageAlign = ContentAlignment.MiddleLeft
        savetb.Location = New Point(913, 884)
        savetb.Margin = New Padding(3, 4, 3, 4)
        savetb.Name = "savetb"
        savetb.Size = New Size(145, 67)
        savetb.TabIndex = 65
        savetb.Text = "Save"
        savetb.TextImageRelation = TextImageRelation.ImageBeforeText
        savetb.UseVisualStyleBackColor = False
        ' 
        ' saveasbt
        ' 
        saveasbt.BackColor = Color.Silver
        saveasbt.FlatStyle = FlatStyle.Flat
        saveasbt.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        saveasbt.IconChar = FontAwesome.Sharp.IconChar.None
        saveasbt.IconColor = Color.Black
        saveasbt.IconFont = FontAwesome.Sharp.IconFont.Auto
        saveasbt.Location = New Point(730, 884)
        saveasbt.Margin = New Padding(3, 4, 3, 4)
        saveasbt.Name = "saveasbt"
        saveasbt.Size = New Size(127, 67)
        saveasbt.TabIndex = 64
        saveasbt.Text = "Save As"
        saveasbt.UseVisualStyleBackColor = False
        ' 
        ' printtb
        ' 
        printtb.BackColor = Color.Silver
        printtb.FlatStyle = FlatStyle.Flat
        printtb.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        printtb.IconChar = FontAwesome.Sharp.IconChar.Print
        printtb.IconColor = Color.Black
        printtb.IconFont = FontAwesome.Sharp.IconFont.Auto
        printtb.ImageAlign = ContentAlignment.MiddleLeft
        printtb.Location = New Point(1114, 884)
        printtb.Margin = New Padding(3, 4, 3, 4)
        printtb.Name = "printtb"
        printtb.Size = New Size(127, 67)
        printtb.TabIndex = 63
        printtb.Text = "Print"
        printtb.TextImageRelation = TextImageRelation.ImageBeforeText
        printtb.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label8.Location = New Point(534, 735)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 28)
        Label8.TabIndex = 62
        Label8.Text = "Driver:"
        ' 
        ' drivertb
        ' 
        drivertb.BorderStyle = BorderStyle.FixedSingle
        drivertb.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        drivertb.Location = New Point(615, 727)
        drivertb.Margin = New Padding(3, 4, 3, 4)
        drivertb.Name = "drivertb"
        drivertb.Size = New Size(255, 32)
        drivertb.TabIndex = 61
        ' 
        ' dispatchertb
        ' 
        dispatchertb.BorderStyle = BorderStyle.FixedSingle
        dispatchertb.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dispatchertb.Location = New Point(615, 672)
        dispatchertb.Margin = New Padding(3, 4, 3, 4)
        dispatchertb.Name = "dispatchertb"
        dispatchertb.Size = New Size(255, 32)
        dispatchertb.TabIndex = 60
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label7.Location = New Point(499, 672)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 28)
        Label7.TabIndex = 59
        Label7.Text = "Dispatcher:"
        ' 
        ' purposetb
        ' 
        purposetb.BorderStyle = BorderStyle.FixedSingle
        purposetb.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        purposetb.Location = New Point(171, 884)
        purposetb.Margin = New Padding(3, 4, 3, 4)
        purposetb.Name = "purposetb"
        purposetb.Size = New Size(255, 32)
        purposetb.TabIndex = 57
        ' 
        ' officetb
        ' 
        officetb.BorderStyle = BorderStyle.FixedSingle
        officetb.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        officetb.Location = New Point(171, 840)
        officetb.Margin = New Padding(3, 4, 3, 4)
        officetb.Name = "officetb"
        officetb.Size = New Size(255, 32)
        officetb.TabIndex = 56
        ' 
        ' placetraveltb
        ' 
        placetraveltb.BorderStyle = BorderStyle.FixedSingle
        placetraveltb.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        placetraveltb.Location = New Point(171, 796)
        placetraveltb.Margin = New Padding(3, 4, 3, 4)
        placetraveltb.Name = "placetraveltb"
        placetraveltb.Size = New Size(255, 32)
        placetraveltb.TabIndex = 55
        ' 
        ' datetraveltb
        ' 
        datetraveltb.BorderStyle = BorderStyle.FixedSingle
        datetraveltb.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        datetraveltb.Location = New Point(171, 736)
        datetraveltb.Margin = New Padding(3, 4, 3, 4)
        datetraveltb.Name = "datetraveltb"
        datetraveltb.Size = New Size(255, 32)
        datetraveltb.TabIndex = 54
        ' 
        ' daterequesttb
        ' 
        daterequesttb.BorderStyle = BorderStyle.FixedSingle
        daterequesttb.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        daterequesttb.Location = New Point(171, 673)
        daterequesttb.Margin = New Padding(3, 4, 3, 4)
        daterequesttb.Name = "daterequesttb"
        daterequesttb.Size = New Size(255, 32)
        daterequesttb.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label5.Location = New Point(14, 884)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 28)
        Label5.TabIndex = 52
        Label5.Text = "Purpose"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label4.Location = New Point(14, 831)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 28)
        Label4.TabIndex = 51
        Label4.Text = "Office:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label3.Location = New Point(14, 780)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 28)
        Label3.TabIndex = 50
        Label3.Text = "Place of Travel:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label2.Location = New Point(14, 727)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 28)
        Label2.TabIndex = 49
        Label2.Text = "Date of Travel:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label1.Location = New Point(14, 684)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 28)
        Label1.TabIndex = 48
        Label1.Text = "Date of Request:"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackgroundImageLayout = ImageLayout.Center
        FlowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D
        FlowLayoutPanel1.Controls.Add(ListView1)
        FlowLayoutPanel1.Location = New Point(78, 117)
        FlowLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1187, 537)
        FlowLayoutPanel1.TabIndex = 47
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {Date_request, Date_travel, Place_Of_Travel, Office_or_Purpose, Plate_Number, Driver, Dispatcher})
        ListView1.Location = New Point(3, 3)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1182, 519)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Date_request
        ' 
        Date_request.Text = "Date_request"
        Date_request.Width = 100
        ' 
        ' Date_travel
        ' 
        Date_travel.Text = "Date_travel"
        Date_travel.Width = 100
        ' 
        ' Place_Of_Travel
        ' 
        Place_Of_Travel.Text = "Place_Of_Travel"
        Place_Of_Travel.Width = 120
        ' 
        ' Office_or_Purpose
        ' 
        Office_or_Purpose.Text = "Office_or_Purpose"
        Office_or_Purpose.Width = 140
        ' 
        ' Plate_Number
        ' 
        Plate_Number.Text = "Plate_Number"
        Plate_Number.Width = 120
        ' 
        ' Driver
        ' 
        Driver.Text = "Driver"
        ' 
        ' Dispatcher
        ' 
        Dispatcher.Text = "Dispatcher"
        Dispatcher.Width = 90
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1300, 71)
        Panel1.TabIndex = 128
        ' 
        ' Dispatch
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1300, 1102)
        Controls.Add(Panel1)
        Controls.Add(Label9)
        Controls.Add(savetb)
        Controls.Add(saveasbt)
        Controls.Add(printtb)
        Controls.Add(Label8)
        Controls.Add(drivertb)
        Controls.Add(dispatchertb)
        Controls.Add(Label7)
        Controls.Add(purposetb)
        Controls.Add(officetb)
        Controls.Add(placetraveltb)
        Controls.Add(datetraveltb)
        Controls.Add(daterequesttb)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(FlowLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "Dispatch"
        Text = "Dispatch"
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents savetb As FontAwesome.Sharp.IconButton
    Friend WithEvents saveasbt As FontAwesome.Sharp.IconButton
    Friend WithEvents printtb As FontAwesome.Sharp.IconButton
    Friend WithEvents Label8 As Label
    Friend WithEvents drivertb As TextBox
    Friend WithEvents dispatchertb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents purposetb As TextBox
    Friend WithEvents officetb As TextBox
    Friend WithEvents placetraveltb As TextBox
    Friend WithEvents datetraveltb As TextBox
    Friend WithEvents daterequesttb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Date_request As ColumnHeader
    Friend WithEvents Date_travel As ColumnHeader
    Friend WithEvents Place_Of_Travel As ColumnHeader
    Friend WithEvents Office_or_Purpose As ColumnHeader
    Friend WithEvents Plate_Number As ColumnHeader
    Friend WithEvents Driver As ColumnHeader
    Friend WithEvents Dispatcher As ColumnHeader
End Class
