Imports System.IO

Public Class Dispatch
    Private Sub saveasbt_Click(sender As Object, e As EventArgs) Handles saveasbt.Click
        Dim filePath As String = "Listview1"

        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(daterequesttb.Text)
                writer.WriteLine(datetraveltb.Text)
                writer.WriteLine(placetraveltb.Text)
                writer.WriteLine(officetb.Text)
                writer.WriteLine(purposetb.Text)
                writer.WriteLine(dispatchertb.Text)
                writer.WriteLine(drivertb.Text)

            End Using

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub savetb_Click(sender As Object, e As EventArgs) Handles savetb.Click
        Dim filePath As String = "Listview1"

        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(daterequesttb.Text)
                writer.WriteLine(datetraveltb.Text)
                writer.WriteLine(placetraveltb.Text)
                writer.WriteLine(officetb.Text)
                writer.WriteLine(purposetb.Text)
                writer.WriteLine(dispatchertb.Text)
                writer.WriteLine(drivertb.Text)

            End Using

            MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class