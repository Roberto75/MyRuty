Public Class FormM3UtoNAS
   

    Public Overrides Function _init(ByRef connection As System.Data.Common.DbConnection, ByRef statusBar As System.Windows.Forms.ToolStripStatusLabel, ByRef progressBar As System.Windows.Forms.ToolStripProgressBar) As Boolean
        MyBase._init(connection, statusBar, progressBar)
    End Function

    Private Sub btnFolder_Click(sender As Object, e As EventArgs) Handles btnFolder.Click
        Dim dialog As New Windows.Forms.FolderBrowserDialog
        dialog.ShowNewFolderButton = True

        'If IO.Directory.Exists("M:\Mp3\") Then
        '    dialog.SelectedPath = "M:\Mp3\"
        'End If

        If IO.Directory.Exists("\\MYCLOUD\MyMusic") Then
            dialog.SelectedPath = "\\MYCLOUD\MyMusic"
        End If


        If dialog.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If


        Dim d As New IO.DirectoryInfo(dialog.SelectedPath)

        For Each f As IO.FileInfo In d.GetFiles("*.m3u")
            Me.CheckedListBox1.Items.Add(f.FullName, True)
        Next
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim conta As Integer = 0

        For Each f As String In CheckedListBox1.CheckedItems
            If Not processFileM3U(New IO.FileInfo(f)) Then
                'Exit For
            End If

            conta = conta + 1
            Me._statusBarUpdate(String.Format("M3U {0:N0}/{1:N0}", conta, CheckedListBox1.CheckedItems.Count))
        Next

        Windows.Forms.MessageBox.Show("Completed", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)

    End Sub


    Private Function processFileM3U(ByVal m3uFile As IO.FileInfo) As Boolean

        Dim content As String


        content = System.IO.File.ReadAllText(m3uFile.FullName)

        content = content.Replace("M:\Mp3", "")

        System.IO.File.WriteAllText(m3uFile.FullName, content)

        Return True

    End Function


End Class