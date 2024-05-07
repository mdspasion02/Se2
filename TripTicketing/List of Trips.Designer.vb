<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_of_Trips
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
        ListView1 = New ListView()
        Date_Of_Request = New ColumnHeader()
        Date_Of_Travel = New ColumnHeader()
        Place_Of_Travel = New ColumnHeader()
        Time = New ColumnHeader()
        Office = New ColumnHeader()
        Purpose_Of_Travel = New ColumnHeader()
        Plate_Number = New ColumnHeader()
        Driver = New ColumnHeader()
        Dispatcher = New ColumnHeader()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {Date_Of_Request, Date_Of_Travel, Place_Of_Travel, Time, Office, Purpose_Of_Travel, Plate_Number, Driver, Dispatcher})
        ListView1.Location = New Point(102, 93)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1166, 476)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Date_Of_Request
        ' 
        Date_Of_Request.Text = "Date_Of_Request"
        Date_Of_Request.Width = 150
        ' 
        ' Date_Of_Travel
        ' 
        Date_Of_Travel.Text = "Date_Of_Travel"
        Date_Of_Travel.Width = 140
        ' 
        ' Place_Of_Travel
        ' 
        Place_Of_Travel.Text = "Place_Of_Travel"
        Place_Of_Travel.Width = 150
        ' 
        ' Time
        ' 
        Time.Text = "Time"
        ' 
        ' Office
        ' 
        Office.Text = "Office"
        ' 
        ' Purpose_Of_Travel
        ' 
        Purpose_Of_Travel.Text = "Purpose_Of_Travel"
        Purpose_Of_Travel.Width = 150
        ' 
        ' Plate_Number
        ' 
        Plate_Number.Text = "Plate_Nmuber"
        Plate_Number.Width = 120
        ' 
        ' Driver
        ' 
        Driver.Text = "Driver"
        ' 
        ' Dispatcher
        ' 
        Dispatcher.Text = "Dispatcher"
        Dispatcher.Width = 100
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(556, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 38)
        Label1.TabIndex = 1
        Label1.Text = "LIST OF TRIPS"
        ' 
        ' List_of_Trips
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1456, 742)
        Controls.Add(Label1)
        Controls.Add(ListView1)
        Name = "List_of_Trips"
        Text = "List_of_Trips"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Date_Of_Request As ColumnHeader
    Friend WithEvents Date_Of_Travel As ColumnHeader
    Friend WithEvents Place_Of_Travel As ColumnHeader
    Friend WithEvents Time As ColumnHeader
    Friend WithEvents Office As ColumnHeader
    Friend WithEvents Purpose_Of_Travel As ColumnHeader
    Friend WithEvents Plate_Number As ColumnHeader
    Friend WithEvents Driver As ColumnHeader
    Friend WithEvents Dispatcher As ColumnHeader
    Friend WithEvents Label1 As Label
End Class
