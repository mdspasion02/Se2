Imports System.Drawing.Printing
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class RequestforVehicle
    Private Sub Saveasib_Click(sender As Object, e As EventArgs) Handles Saveasib.Click
        Dim filePath As String = "ListView1"

        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(Placetraveltb.Text)
                writer.WriteLine(Purposetraveltb.Text)
                writer.WriteLine(Requesttb.Text)
                writer.WriteLine(Designationtb.Text)
                writer.WriteLine(Approvalnametb.Text)
                writer.WriteLine(Approvalpositiontb.Text)
                writer.WriteLine(Durationtraveltb.Text)
                writer.WriteLine(Requestformnametb.Text)
                writer.WriteLine(Requestformpositiontb.Text)
            End Using

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Saveib_Click(sender As Object, e As EventArgs) Handles Saveib.Click
        Dim filePath As String = "ListView1"

        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(Placetraveltb.Text)
                writer.WriteLine(Purposetraveltb.Text)
                writer.WriteLine(Requesttb.Text)
                writer.WriteLine(Designationtb.Text)
                writer.WriteLine(Approvalnametb.Text)
                writer.WriteLine(Approvalpositiontb.Text)
                writer.WriteLine(Durationtraveltb.Text)
                writer.WriteLine(Requestformnametb.Text)
                writer.WriteLine(Requestformpositiontb.Text)
            End Using

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub van1_CheckedChanged(sender As Object, e As EventArgs) Handles van1.CheckedChanged
        If van1.Checked Then
            MessageBox.Show("Option 1 is selected and available.")
        ElseIf van2.Checked Then
            MessageBox.Show("Option 2 is selected and available.")
        ElseIf Bus.Checked Then
            MessageBox.Show("Option 3 is selected and available.")
        Else
            MessageBox.Show("Please select an option.")
        End If

    End Sub

    Private Sub DRIVERS_Enter(sender As Object, e As EventArgs) Handles DRIVERS.Enter
        If Driver1.Checked Then
            MessageBox.Show("Option 1 is selected and available.")
        ElseIf Driver2.Checked Then
            MessageBox.Show("Option 2 is selected and available.")
        ElseIf Driver3.Checked Then
            MessageBox.Show("Option 3 is selected and available.")
        ElseIf Driver4.Checked Then
            MessageBox.Show("Option 4 is selected and available.")
        Else
            MessageBox.Show("Please select an option.")
        End If
    End Sub
End Class