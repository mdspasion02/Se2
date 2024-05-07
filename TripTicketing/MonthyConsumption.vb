Imports System.IO

Public Class MonthyConsumption
    Private Sub saveasbt_Click(sender As Object, e As EventArgs) Handles saveasbt.Click
        Dim filePath As String = "TableLayoutPanel1"

        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(namepreparedtb.Text)
                writer.WriteLine(positionpreparedtb.Text)
                writer.WriteLine(checkednametb.Text)
                writer.WriteLine(checkedpositiontb.Text)
                writer.WriteLine(notedbametb.Text)
                writer.WriteLine(positionnotedtb.Text)

            End Using

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub savebt_Click(sender As Object, e As EventArgs) Handles savebt.Click
        Dim filePath As String = "TableLayoutPanel1"

        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(namepreparedtb.Text)
                writer.WriteLine(positionpreparedtb.Text)
                writer.WriteLine(checkednametb.Text)
                writer.WriteLine(checkedpositiontb.Text)
                writer.WriteLine(notedbametb.Text)
                writer.WriteLine(positionnotedtb.Text)

            End Using

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class