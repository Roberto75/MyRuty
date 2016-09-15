Public Class FormM3U

    Private _folderToCopy As String

    Public Overrides Function _init(ByRef connection As System.Data.Common.DbConnection, ByRef statusBar As System.Windows.Forms.ToolStripStatusLabel, ByRef progressBar As System.Windows.Forms.ToolStripProgressBar) As Boolean
        MyBase._init(connection, statusBar, progressBar)
    End Function

    Private Sub btnOpenM3U_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenM3U.Click
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog

        OpenFileDialog1.Filter = "File M3U |*.m3u"

        OpenFileDialog1.InitialDirectory = Application.ExecutablePath
        OpenFileDialog1.Title = "Open File M3U"


        If (OpenFileDialog1.ShowDialog(Me) <> Windows.Forms.DialogResult.OK) Then
            Exit Sub
        End If


        Me.CheckedListBox1.Items.Add(OpenFileDialog1.FileName, True)


        'Copia il contenuto i file elencati nella playlist .m3u in una directoty aggionando il path!

        'Me.processFileM3U(New IO.FileInfo(OpenFileDialog1.FileName))

        '    Application.DoEvents()
    End Sub



    Private Sub btnFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFolder.Click
        Dim dialog As New Windows.Forms.FolderBrowserDialog
        dialog.ShowNewFolderButton = True

        If IO.Directory.Exists("M:\Mp3\") Then
            dialog.SelectedPath = "M:\Mp3\"
        End If

        If dialog.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If


        Dim d As New IO.DirectoryInfo(dialog.SelectedPath)

        For Each f As IO.FileInfo In d.GetFiles("*.m3u")
            Me.CheckedListBox1.Items.Add(f.FullName, True)
        Next

    End Sub



    Private Function processFileM3U(ByVal m3uFile As IO.FileInfo) As Boolean
        Dim mp3Files As New List(Of String)
        Dim directory As String
        directory = m3uFile.DirectoryName & "\"


        ' Me._progressBar.Style = ProgressBarStyle.Marquee
        Dim oRead As IO.StreamReader = Nothing
        Dim line As String = ""
        Dim conta As Long = 0

        Try
            oRead = System.IO.File.OpenText(m3uFile.FullName)

            oRead = New IO.StreamReader(m3uFile.FullName, System.Text.Encoding.Default)
            ' Dim conten As sts
            'content = IO.File.ReadAllText(fileEML.FullName, System.Text.Encoding.UTF8)
            While Not oRead.EndOfStream
                line = oRead.ReadLine()
                line = line.Trim()

                If Not String.IsNullOrEmpty(line) AndAlso Not line.StartsWith("#") Then
                    conta = conta + 1
                    mp3Files.Add(directory & line)
                End If

                Me._statusBarUpdate(String.Format("Found: {0} mp3", conta))
            End While
        Finally
            oRead.Close()
        End Try



        'If Windows.Forms.MessageBox.Show(String.Format("Found {0} files mp3 continue to copy in a folder?", mp3Files.Count), My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OKCancel, Windows.Forms.MessageBoxIcon.Question) <> Windows.Forms.DialogResult.OK Then
        'Return False
        'End If


        If String.IsNullOrEmpty(_folderToCopy) Then
            Dim dialog As New System.Windows.Forms.FolderBrowserDialog
            dialog.ShowNewFolderButton = True
            dialog.SelectedPath = My.Settings.openFolder
            If dialog.ShowDialog(Me) <> System.Windows.Forms.DialogResult.OK Then
                Return False
            End If

            My.Settings.openFolder = dialog.SelectedPath
            My.Settings.Save()

            _folderToCopy = dialog.SelectedPath
        End If





        '*** verifica ***
        Dim f As IO.FileInfo
        Dim removed As New Collections.Generic.List(Of IO.FileInfo)

        For Each s As String In mp3Files
            Try
                f = New IO.FileInfo(s)

                If Not f.Exists Then
                    removed.Add(f)
                End If

            Catch ex As IO.FileNotFoundException
                removed.Add(f)
                '        Windows.Forms.MessageBox.Show(String.Format("Removed file not found {0}", s), My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
            End Try
        Next


        For Each f In removed
            mp3Files.Remove(f.FullName)
        Next

        removed.Clear()





        MyManager.FileSystemManager._setProgressBar(Me._progressBar)
        MyManager.FileSystemManager._setStatusBar(Me._statusBar)


        directory = _folderToCopy & "\" & m3uFile.Name.ToLower.Replace(".m3u", "")

        If IO.Directory.Exists(directory) Then
            IO.Directory.Delete(directory, True)
        End If

        IO.Directory.CreateDirectory(directory)

        MyManager.FileSystemManager.copyFiles(mp3Files.ToArray, directory)

        mp3Files.Clear()

        Me._progressBar.Style = ProgressBarStyle.Blocks
        Return True
    End Function

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CheckedListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        _folderToCopy = ""

        For Each f As String In CheckedListBox1.CheckedItems
            If Not processFileM3U(New IO.FileInfo(f)) Then
                Exit For
            End If
        Next

        Windows.Forms.MessageBox.Show("Completed", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)


    End Sub
End Class