Public Class Form1

    Dim a As String

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = Nothing Then
            MsgBox("Please Select Image File")
        Else
            Label1.Text = OpenFileDialog1.FileName
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If

    End Sub
End Class
