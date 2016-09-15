Public Class FormRenameByMD5


    Private Shared _dataDaCercare As DateTime

    Public Overrides Function _checkFieldBeforeSaveDetailOnClick(tab As System.Windows.Forms.TabPage) As Boolean
        Return True
    End Function

    Protected Overrides Function _btnSaveDetailOnClick(tab As System.Windows.Forms.TabPage) As Boolean
        Dim sourceFolderJPG As System.IO.DirectoryInfo
        sourceFolderJPG = New System.IO.DirectoryInfo("I:\temp\Matrimonio parenti\")

        Dim originalFolder As System.IO.DirectoryInfo
        originalFolder = New System.IO.DirectoryInfo("S:\Matrimonio Originali\")

        renameByMD5(sourceFolderJPG, originalFolder)

        Return True
    End Function


    Private Function renameByMD5(sourceFolder As System.IO.DirectoryInfo, originalFolder As System.IO.DirectoryInfo) As Boolean

        Dim foundFile As String
        Dim foundFileInfo As System.IO.FileInfo
        Dim fileCR2 As System.IO.FileInfo

        For Each fileJPG As System.IO.FileInfo In sourceFolder.GetFiles("*.jpg")
            Console.WriteLine(fileJPG.Name)

            fileCR2 = New System.IO.FileInfo("I:\Photo\2011_10_15 Matrimonio\Fotografo\" & fileJPG.Name.Replace(".jpg", ".cr2"))

            If (fileCR2.Exists And fileCR2.Name.StartsWith("201")) Then
                foundFile = searchFileByMD5(fileCR2, originalFolder)
                If Not String.IsNullOrEmpty(foundFile) Then
                    'rename del file
                    foundFileInfo = New System.IO.FileInfo(foundFile)

                    fileJPG.MoveTo(fileJPG.DirectoryName & "\" & foundFileInfo.Name.ToUpper.Replace(".CR2", ".JPG"))
                    Continue For
                End If


            End If
        Next

        Return True
    End Function


    Private Function searchFileByMD5(sourceFileCR2 As System.IO.FileInfo, originalFolder As System.IO.DirectoryInfo) As String

        Dim commandExiff As String
        Dim temp As String
        commandExiff = String.Format("""exiftool.exe"" -createdate -fast -G -t -m -q -q  ""{0}""", sourceFileCR2.FullName)
        temp = processCommand(commandExiff)

        If String.IsNullOrEmpty(temp) Then
            Return False
        End If

        temp = temp.Replace("EXIF	Create Date	", "")

        'converto la stringa in data
        If (temp.Length <> 19) Then
            Throw New ApplicationException("EXIF fomato data errato")
        End If
        temp = temp.Substring(0, 10).Replace(":", "/") & " " & temp.Substring(11)

        _dataDaCercare = DateTime.Parse(temp)


        Dim files() As System.IO.FileInfo
        files = originalFolder.GetFiles("*.CR2")

        Dim filesConGliStessiMinuti() As System.IO.FileInfo

        filesConGliStessiMinuti = Array.FindAll(files, AddressOf FindFilesByDate)

        Dim md5Source As String
        md5Source = MyManager.SecurityManager.getMD5HashFile(sourceFileCR2.FullName)

        Dim md5Destinazione As String

        For Each file As System.IO.FileInfo In filesConGliStessiMinuti
            'Trovati i files scattati nello stesso minuto! 
            'Escludo i secondi!!
            Console.WriteLine(file.Name)
            md5Destinazione = MyManager.SecurityManager.getMD5HashFile(file.FullName)

            If (md5Source = md5Destinazione) Then
                'TROVATO
                Console.WriteLine("TROVATO: " & file.Name)
                Return file.FullName
            End If
        Next

        Return ""
    End Function


    Public Shared Function FindFilesByDate(ByVal f1 As System.IO.FileInfo) As Boolean
        'ESCLUDO i SECONDI!!!
        'Console.WriteLine(_patternData.ToString("yyyy_MM_dd_HH_mm") & " = " & f1.CreationTime.ToString("yyyy_MM_dd_HH_mm"))

        If _dataDaCercare.ToString("yyyy_MM_dd_HH_mm") = f1.CreationTime.ToString("yyyy_MM_dd_HH_mm") Then
            Return True
        Else
            Return False
        End If
    End Function



    Function processCommand(strCommand As String) As String

        Dim myProcess As System.Diagnostics.Process


        myProcess = New System.Diagnostics.Process()

        myProcess.StartInfo.FileName = strCommand
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.RedirectStandardOutput = True

        myProcess.Start()

        ' myProcess.BeginOutputReadLine()

        Dim output As String
        output = myProcess.StandardOutput.ReadToEnd()
        myProcess.WaitForExit()

        Return output.Trim
    End Function

End Class