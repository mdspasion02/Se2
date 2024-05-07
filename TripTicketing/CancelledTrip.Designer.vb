Imports Microsoft
Imports System.IO
Imports System.Windows.Threading

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CancelledTrip
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
        saveasbt = New FontAwesome.Sharp.IconButton()
        savebt = New FontAwesome.Sharp.IconButton()
        printbt = New FontAwesome.Sharp.IconButton()
        Label4 = New Label()
        Label5 = New Label()
        canceltripposition3 = New TextBox()
        canceltripname3 = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        canceltripname2 = New TextBox()
        canceltripname1 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        canceltripposition2 = New TextBox()
        canceltripposition1 = New TextBox()
        Label1 = New Label()
        ListView1 = New ListView()
        DATE_OF_REQUEST = New ColumnHeader()
        PLACE_OF_TRAVEL = New ColumnHeader()
        DATE_OF_TRAVEL = New ColumnHeader()
        TIME = New ColumnHeader()
        OFFICE = New ColumnHeader()
        PURPOSE_OF_TRAVEL = New ColumnHeader()
        PLATE_NUMBER = New ColumnHeader()
        DRIVER = New ColumnHeader()
        DISPATCHER = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1370, 71)
        Panel2.TabIndex = 4
        ' 
        ' saveasbt
        ' 
        saveasbt.BackColor = Color.Silver
        saveasbt.FlatStyle = FlatStyle.Flat
        saveasbt.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        saveasbt.IconChar = FontAwesome.Sharp.IconChar.None
        saveasbt.IconColor = Color.Black
        saveasbt.IconFont = FontAwesome.Sharp.IconFont.Auto
        saveasbt.Location = New Point(991, 898)
        saveasbt.Margin = New Padding(3, 4, 3, 4)
        saveasbt.Name = "saveasbt"
        saveasbt.Size = New Size(153, 67)
        saveasbt.TabIndex = 64
        saveasbt.Text = "Save As"
        saveasbt.UseVisualStyleBackColor = False
        ' 
        ' savebt
        ' 
        savebt.BackColor = Color.Silver
        savebt.FlatStyle = FlatStyle.Flat
        savebt.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        savebt.IconChar = FontAwesome.Sharp.IconChar.Save
        savebt.IconColor = Color.Black
        savebt.IconFont = FontAwesome.Sharp.IconFont.Auto
        savebt.ImageAlign = ContentAlignment.MiddleLeft
        savebt.Location = New Point(1197, 898)
        savebt.Margin = New Padding(3, 4, 3, 4)
        savebt.Name = "savebt"
        savebt.Size = New Size(139, 67)
        savebt.TabIndex = 63
        savebt.Text = "Save"
        savebt.TextImageRelation = TextImageRelation.ImageBeforeText
        savebt.UseVisualStyleBackColor = False
        ' 
        ' printbt
        ' 
        printbt.BackColor = Color.Silver
        printbt.FlatStyle = FlatStyle.Flat
        printbt.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        printbt.IconChar = FontAwesome.Sharp.IconChar.Print
        printbt.IconColor = Color.Black
        printbt.IconFont = FontAwesome.Sharp.IconFont.Auto
        printbt.ImageAlign = ContentAlignment.MiddleLeft
        printbt.Location = New Point(792, 898)
        printbt.Margin = New Padding(3, 4, 3, 4)
        printbt.Name = "printbt"
        printbt.Size = New Size(145, 67)
        printbt.TabIndex = 62
        printbt.Text = "Print"
        printbt.TextImageRelation = TextImageRelation.ImageBeforeText
        printbt.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label4.Location = New Point(15, 765)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 28)
        Label4.TabIndex = 61
        Label4.Text = "Position:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label5.Location = New Point(15, 707)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 28)
        Label5.TabIndex = 60
        Label5.Text = "Name:"
        ' 
        ' canceltripposition3
        ' 
        canceltripposition3.BorderStyle = BorderStyle.FixedSingle
        canceltripposition3.Location = New Point(879, 755)
        canceltripposition3.Margin = New Padding(3, 4, 3, 4)
        canceltripposition3.Name = "canceltripposition3"
        canceltripposition3.Size = New Size(265, 27)
        canceltripposition3.TabIndex = 59
        ' 
        ' canceltripname3
        ' 
        canceltripname3.BorderStyle = BorderStyle.FixedSingle
        canceltripname3.Location = New Point(879, 704)
        canceltripname3.Margin = New Padding(3, 4, 3, 4)
        canceltripname3.Name = "canceltripname3"
        canceltripname3.Size = New Size(265, 27)
        canceltripname3.TabIndex = 58
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label8.Location = New Point(777, 760)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 28)
        Label8.TabIndex = 57
        Label8.Text = "Position:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label9.Location = New Point(777, 709)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 28)
        Label9.TabIndex = 56
        Label9.Text = "Name:"
        ' 
        ' canceltripname2
        ' 
        canceltripname2.BorderStyle = BorderStyle.FixedSingle
        canceltripname2.Location = New Point(464, 701)
        canceltripname2.Margin = New Padding(3, 4, 3, 4)
        canceltripname2.Name = "canceltripname2"
        canceltripname2.Size = New Size(236, 27)
        canceltripname2.TabIndex = 55
        ' 
        ' canceltripname1
        ' 
        canceltripname1.BorderStyle = BorderStyle.FixedSingle
        canceltripname1.Location = New Point(102, 701)
        canceltripname1.Margin = New Padding(3, 4, 3, 4)
        canceltripname1.Name = "canceltripname1"
        canceltripname1.Size = New Size(249, 27)
        canceltripname1.TabIndex = 54
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label7.Location = New Point(373, 765)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 28)
        Label7.TabIndex = 53
        Label7.Text = "Position:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Label6.Location = New Point(373, 707)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 28)
        Label6.TabIndex = 52
        Label6.Text = "Name:"
        ' 
        ' canceltripposition2
        ' 
        canceltripposition2.BorderStyle = BorderStyle.FixedSingle
        canceltripposition2.Location = New Point(459, 760)
        canceltripposition2.Margin = New Padding(3, 4, 3, 4)
        canceltripposition2.Name = "canceltripposition2"
        canceltripposition2.Size = New Size(241, 27)
        canceltripposition2.TabIndex = 51
        ' 
        ' canceltripposition1
        ' 
        canceltripposition1.BorderStyle = BorderStyle.FixedSingle
        canceltripposition1.Location = New Point(102, 760)
        canceltripposition1.Margin = New Padding(3, 4, 3, 4)
        canceltripposition1.Name = "canceltripposition1"
        canceltripposition1.Size = New Size(249, 27)
        canceltripposition1.TabIndex = 50
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(519, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 37)
        Label1.TabIndex = 49
        Label1.Text = "CANCELLED TRIP"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {DATE_OF_REQUEST, PLACE_OF_TRAVEL, DATE_OF_TRAVEL, TIME, OFFICE, PURPOSE_OF_TRAVEL, PLATE_NUMBER, DRIVER, DISPATCHER})
        ListView1.Location = New Point(128, 152)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1063, 508)
        ListView1.TabIndex = 65
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' DATE_OF_REQUEST
        ' 
        DATE_OF_REQUEST.Text = "DATE OF REQUEST"
        DATE_OF_REQUEST.Width = 150
        ' 
        ' PLACE_OF_TRAVEL
        ' 
        PLACE_OF_TRAVEL.Text = "PLACE OF TRAVEL"
        PLACE_OF_TRAVEL.Width = 150
        ' 
        ' DATE_OF_TRAVEL
        ' 
        DATE_OF_TRAVEL.Text = "DATE OF TRAVEL"
        DATE_OF_TRAVEL.Width = 150
        ' 
        ' TIME
        ' 
        TIME.Text = "TIME"
        ' 
        ' OFFICE
        ' 
        OFFICE.Text = "OFFICE"
        ' 
        ' PURPOSE_OF_TRAVEL
        ' 
        PURPOSE_OF_TRAVEL.Text = "PURPOSE OF TRAVEL"
        PURPOSE_OF_TRAVEL.Width = 160
        ' 
        ' PLATE_NUMBER
        ' 
        PLATE_NUMBER.Text = "PLATE NUMBER"
        PLATE_NUMBER.Width = 150
        ' 
        ' DRIVER
        ' 
        DRIVER.Text = "DRIVER"
        DRIVER.Width = 80
        ' 
        ' DISPATCHER
        ' 
        DISPATCHER.Text = "DISPATCHER"
        DISPATCHER.Width = 100
        ' 
        ' CancelledTrip
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 1007)
        Controls.Add(ListView1)
        Controls.Add(saveasbt)
        Controls.Add(savebt)
        Controls.Add(printbt)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(canceltripposition3)
        Controls.Add(canceltripname3)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(canceltripname2)
        Controls.Add(canceltripname1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(canceltripposition2)
        Controls.Add(canceltripposition1)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "CancelledTrip"
        Text = "CancelledTrip"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents saveasbt As FontAwesome.Sharp.IconButton
    Friend WithEvents savebt As FontAwesome.Sharp.IconButton
    Friend WithEvents printbt As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents canceltripposition3 As TextBox
    Friend WithEvents canceltripname3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents canceltripname2 As TextBox
    Friend WithEvents canceltripname1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents canceltripposition2 As TextBox
    Friend WithEvents canceltripposition1 As TextBox
    Friend WithEvents Label1 As Label

    Private Sub saveasbt_Click(sender As Object, e As EventArgs) Handles saveasbt.Click
        Dim filePath As String = "Listview1"

        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(canceltripname1.Text)
                writer.WriteLine(canceltripname2.Text)
                writer.WriteLine(canceltripname3.Text)
                writer.WriteLine(canceltripposition1.Text)
                writer.WriteLine(canceltripposition2.Text)
                writer.WriteLine(canceltripposition3.Text)

            End Using

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub savebt_Click(sender As Object, e As EventArgs) Handles savebt.Click
        Dim filePath As String = "Listview1"

        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(canceltripname1.Text)
                writer.WriteLine(canceltripname2.Text)
                writer.WriteLine(canceltripname3.Text)
                writer.WriteLine(canceltripposition1.Text)
                writer.WriteLine(canceltripposition2.Text)
                writer.WriteLine(canceltripposition3.Text)

            End Using

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents DATE_OF_REQUEST As ColumnHeader
    Friend WithEvents PLACE_OF_TRAVEL As ColumnHeader
    Friend WithEvents DATE_OF_TRAVEL As ColumnHeader
    Friend WithEvents TIME As ColumnHeader
    Friend WithEvents OFFICE As ColumnHeader
    Friend WithEvents PURPOSE_OF_TRAVEL As ColumnHeader
    Friend WithEvents PLATE_NUMBER As ColumnHeader
    Friend WithEvents DRIVER As ColumnHeader
    Friend WithEvents DISPATCHER As ColumnHeader
End Class
