<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthyConsumption
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label3 = New Label()
        savebt = New FontAwesome.Sharp.IconButton()
        saveasbt = New FontAwesome.Sharp.IconButton()
        printbt = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        Label2 = New Label()
        positionnotedtb = New TextBox()
        notedbametb = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        checkedpositiontb = New TextBox()
        checkednametb = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        positionpreparedtb = New TextBox()
        namepreparedtb = New TextBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewComboBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        Label5 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(549, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(523, 41)
        Label3.TabIndex = 145
        Label3.Text = "MONTHLY CONSUMPTION REPORT"
        ' 
        ' savebt
        ' 
        savebt.BackColor = Color.Silver
        savebt.FlatStyle = FlatStyle.Flat
        savebt.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        savebt.IconChar = FontAwesome.Sharp.IconChar.Save
        savebt.IconColor = Color.Black
        savebt.IconFont = FontAwesome.Sharp.IconFont.Auto
        savebt.ImageAlign = ContentAlignment.MiddleLeft
        savebt.Location = New Point(1400, 983)
        savebt.Margin = New Padding(3, 4, 3, 4)
        savebt.Name = "savebt"
        savebt.Size = New Size(145, 67)
        savebt.TabIndex = 143
        savebt.Text = "Save"
        savebt.TextImageRelation = TextImageRelation.ImageBeforeText
        savebt.UseVisualStyleBackColor = False
        ' 
        ' saveasbt
        ' 
        saveasbt.BackColor = Color.Silver
        saveasbt.FlatStyle = FlatStyle.Flat
        saveasbt.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        saveasbt.IconChar = FontAwesome.Sharp.IconChar.None
        saveasbt.IconColor = Color.Black
        saveasbt.IconFont = FontAwesome.Sharp.IconFont.Auto
        saveasbt.Location = New Point(1235, 983)
        saveasbt.Margin = New Padding(3, 4, 3, 4)
        saveasbt.Name = "saveasbt"
        saveasbt.Size = New Size(127, 67)
        saveasbt.TabIndex = 142
        saveasbt.Text = "Save As"
        saveasbt.UseVisualStyleBackColor = False
        ' 
        ' printbt
        ' 
        printbt.BackColor = Color.Silver
        printbt.FlatStyle = FlatStyle.Flat
        printbt.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        printbt.IconChar = FontAwesome.Sharp.IconChar.Print
        printbt.IconColor = Color.Black
        printbt.IconFont = FontAwesome.Sharp.IconFont.Auto
        printbt.ImageAlign = ContentAlignment.MiddleLeft
        printbt.Location = New Point(1069, 983)
        printbt.Margin = New Padding(3, 4, 3, 4)
        printbt.Name = "printbt"
        printbt.Size = New Size(127, 67)
        printbt.TabIndex = 141
        printbt.Text = "Print"
        printbt.TextImageRelation = TextImageRelation.ImageBeforeText
        printbt.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(845, 916)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 28)
        Label1.TabIndex = 140
        Label1.Text = "Position:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(845, 848)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 28)
        Label2.TabIndex = 139
        Label2.Text = "Name:"
        ' 
        ' positionnotedtb
        ' 
        positionnotedtb.BorderStyle = BorderStyle.FixedSingle
        positionnotedtb.Location = New Point(937, 911)
        positionnotedtb.Margin = New Padding(3, 4, 3, 4)
        positionnotedtb.Name = "positionnotedtb"
        positionnotedtb.Size = New Size(268, 27)
        positionnotedtb.TabIndex = 138
        ' 
        ' notedbametb
        ' 
        notedbametb.BorderStyle = BorderStyle.FixedSingle
        notedbametb.Location = New Point(937, 848)
        notedbametb.Margin = New Padding(3, 4, 3, 4)
        notedbametb.Name = "notedbametb"
        notedbametb.Size = New Size(268, 27)
        notedbametb.TabIndex = 137
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label8.Location = New Point(418, 913)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 28)
        Label8.TabIndex = 136
        Label8.Text = "Position:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label9.Location = New Point(418, 845)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 28)
        Label9.TabIndex = 135
        Label9.Text = "Name:"
        ' 
        ' checkedpositiontb
        ' 
        checkedpositiontb.BorderStyle = BorderStyle.FixedSingle
        checkedpositiontb.Location = New Point(511, 917)
        checkedpositiontb.Margin = New Padding(3, 4, 3, 4)
        checkedpositiontb.Name = "checkedpositiontb"
        checkedpositiontb.Size = New Size(268, 27)
        checkedpositiontb.TabIndex = 134
        ' 
        ' checkednametb
        ' 
        checkednametb.BorderStyle = BorderStyle.FixedSingle
        checkednametb.Location = New Point(511, 845)
        checkednametb.Margin = New Padding(3, 4, 3, 4)
        checkednametb.Name = "checkednametb"
        checkednametb.Size = New Size(268, 27)
        checkednametb.TabIndex = 133
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.Location = New Point(17, 903)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 28)
        Label7.TabIndex = 132
        Label7.Text = "Position:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.Location = New Point(17, 843)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 28)
        Label6.TabIndex = 131
        Label6.Text = "Name:"
        ' 
        ' positionpreparedtb
        ' 
        positionpreparedtb.BorderStyle = BorderStyle.FixedSingle
        positionpreparedtb.Location = New Point(111, 905)
        positionpreparedtb.Margin = New Padding(3, 4, 3, 4)
        positionpreparedtb.Name = "positionpreparedtb"
        positionpreparedtb.Size = New Size(268, 27)
        positionpreparedtb.TabIndex = 130
        ' 
        ' namepreparedtb
        ' 
        namepreparedtb.BorderStyle = BorderStyle.FixedSingle
        namepreparedtb.Location = New Point(111, 837)
        namepreparedtb.Margin = New Padding(3, 4, 3, 4)
        namepreparedtb.Name = "namepreparedtb"
        namepreparedtb.Size = New Size(268, 27)
        namepreparedtb.TabIndex = 129
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13})
        DataGridView1.Location = New Point(12, 148)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1422, 491)
        DataGridView1.TabIndex = 146
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Date of Request"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 133
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Date of Traveled"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 136
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Place of Travel"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 123
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Office"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 78
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Purpose"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 91
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Plate No."
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Resizable = DataGridViewTriState.True
        Column6.SortMode = DataGridViewColumnSortMode.Automatic
        Column6.Width = 91
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "Driver"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 78
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "Stock Balance in Tank"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 137
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column9.HeaderText = "Fuel Consumption"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 144
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column10.HeaderText = "Remaining Balance in Tank"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 155
        ' 
        ' Column11
        ' 
        Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column11.HeaderText = "Distance Traveled"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 142
        ' 
        ' Column12
        ' 
        Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column12.HeaderText = "No. of Liters Loaded"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 157
        ' 
        ' Column13
        ' 
        Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column13.HeaderText = "Amount of Diesel Purchased"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        Column13.Width = 205
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(1070, 712)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 34)
        Label4.TabIndex = 147
        Label4.Text = "Total"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(888, 709)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 34)
        Label5.TabIndex = 148
        Label5.Text = "Total"
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(960, 709)
        TextBox5.Margin = New Padding(3, 4, 3, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(83, 34)
        TextBox5.TabIndex = 149
        ' 
        ' TextBox6
        ' 
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(1362, 707)
        TextBox6.Margin = New Padding(3, 4, 3, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(132, 39)
        TextBox6.TabIndex = 150
        ' 
        ' TextBox7
        ' 
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(1142, 707)
        TextBox7.Margin = New Padding(3, 4, 3, 4)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(104, 39)
        TextBox7.TabIndex = 151
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label10.Location = New Point(17, 768)
        Label10.Name = "Label10"
        Label10.Size = New Size(132, 28)
        Label10.TabIndex = 152
        Label10.Text = "Prepared By:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label11.Location = New Point(418, 783)
        Label11.Name = "Label11"
        Label11.Size = New Size(126, 28)
        Label11.TabIndex = 153
        Label11.Text = "Checked By:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label12.Location = New Point(845, 783)
        Label12.Name = "Label12"
        Label12.Size = New Size(106, 28)
        Label12.TabIndex = 154
        Label12.Text = "Noted By:"
        ' 
        ' MonthyConsumption
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1813, 1088)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(savebt)
        Controls.Add(saveasbt)
        Controls.Add(printbt)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(positionnotedtb)
        Controls.Add(notedbametb)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(checkedpositiontb)
        Controls.Add(checkednametb)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(positionpreparedtb)
        Controls.Add(namepreparedtb)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "MonthyConsumption"
        Text = "MonthyConsumption"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents savebt As FontAwesome.Sharp.IconButton
    Friend WithEvents saveasbt As FontAwesome.Sharp.IconButton
    Friend WithEvents printbt As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents positionnotedtb As TextBox
    Friend WithEvents notedbametb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents checkedpositiontb As TextBox
    Friend WithEvents checkednametb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents positionpreparedtb As TextBox
    Friend WithEvents namepreparedtb As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewComboBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
