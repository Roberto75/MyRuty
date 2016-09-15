Public Class FormRename

    Public Overrides Function _init(ByRef connection As System.Data.Common.DbConnection, ByRef statusBar As System.Windows.Forms.ToolStripStatusLabel, ByRef progressBar As System.Windows.Forms.ToolStripProgressBar) As Boolean
        MyBase._init(connection, statusBar, progressBar)
        'For Each t As Danielyan.Exif.ExifTag In tags.Values
        ' Console.WriteLine(t.ToString & vbCrLf)
        ' Next
        'Console.WriteLine("Date: " & tags.Item("DateTimeOriginal").Value)

        UcBrowseFileSystem1._init()

        Dim index As Integer
        index = DataGridView1.Columns.Add("fileName", "Name")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        index = DataGridView1.Columns.Add("fileReName", "Rename")


        btnNuovoDetail.Visible = False
        btnSalvaDetail.Text = "Rename"

        If Not IO.File.Exists(Application.StartupPath & "\exiftool.exe") Then
            IO.File.WriteAllBytes(Application.StartupPath & "\exiftool.exe", My.Resources.exiftool)
        End If

        Return True
    End Function

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim files As List(Of IO.FileInfo)


        Dim myFilter As String = ""

        If chkJPG.Checked Then
            myFilter &= ".jpg|"
        End If

        If chkCR2.Checked Then
            myFilter &= ".cr2|"
        End If

        If chkNEF.Checked Then
            myFilter &= ".nef|"
        End If

        If chkMOV.Checked Then
            myFilter &= ".mov|"
        End If

        If chkAVI.Checked Then
            myFilter &= ".avi|"
        End If

        If chkMTS.Checked Then
            myFilter &= ".mts|"
        End If

        If chkMP4.Checked Then
            myFilter &= ".mp4|"
        End If

        If String.IsNullOrEmpty(myFilter) Then
            System.Windows.Forms.MessageBox.Show("Selezionare almeno un tipo di file da processare", My.Application.Info.ProductName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
            Exit Sub
        End If


        myFilter = myFilter.Substring(0, myFilter.Length - 1)

        files = UcBrowseFileSystem1._getListFiles(myFilter)

        Dim row As System.Windows.Forms.DataGridViewRow

        Dim newRowIndex As Long
        Dim newFileName As String
        Dim temp As String
        ' Dim tags As Danielyan.Exif.ExifTags

        'Dim readerBitampStream As IO.FileStream
        '  Dim decoder As System.Windows.Media.Imaging.BitmapDecoder
        ' Dim frame As System.Windows.Media.Imaging.BitmapFrame


        Dim MyDateTimeFormat As String = "yyyy-MM-dd HH_mm_ss"

        Dim commandExiff As String

        Dim dateTime As Date
        Dim culture As System.Globalization.CultureInfo = New Globalization.CultureInfo("en-GB")

        Dim imageFileInfo As System.IO.FileInfo
        ' Dim imageCreationDate As Date

        Dim conta As Long = 1
        Me.DataGridView1.Rows.Clear()
        For Each f As IO.FileInfo In files

            newRowIndex = DataGridView1.Rows.Add()

            newFileName = ""

            row = DataGridView1.Rows(newRowIndex)
            row.Cells(0).Value = f.Name

            row.Tag = f

            Try
                'tags = New Danielyan.Exif.ExifTags(f.FullName)
                ' temp = tags.Item("DateTimeOriginal").Value
                'newFileName = temp.Substring(0, 10).Replace(":", "-") & " " & temp.Substring(11, 8).Replace(":", "_") & ".jpg"


                '2012
                'http://stackoverflow.com/questions/58649/how-to-get-the-exif-data-from-a-file-using-c-sharp
                'http://blogs.ugidotnet.org/PietroLibroBlog/archive/2010/08/13/wpf-bitmapmetadata.-read-and-write-again.aspx

                imageFileInfo = New System.IO.FileInfo(f.FullName)
                'Console.WriteLine(" ImageFileInfo.CreationTime: " & imageFileInfo.CreationTime)


                'imageCreationDate = imageFileInfo.CreationTime
                'newFileName = imageCreationDate.ToString("yyyy-MM-dd HH_mm_ss") & imageFileInfo.Extension


                
                If (f.Extension.ToUpper = ".MOV" OrElse f.Extension.ToUpper = ".MP4") Then
                    commandExiff = String.Format("""exiftool.exe"" -createdate -fast -G -t -m -q ""{0}""", f.FullName)
                Else
                    commandExiff = String.Format("""exiftool.exe"" -DateTimeOriginal -fast -G -t -m -q ""{0}""", f.FullName)
                End If


                temp = processCommand(commandExiff)

                If Not String.IsNullOrEmpty(temp) Then

                    temp = temp.Trim()
                    temp = temp.Replace(vbTab, "")


                    If f.Extension.ToUpper = ".MOV" OrElse f.Extension.ToUpper = ".AVI" OrElse f.Extension.ToUpper = ".MTS" OrElse f.Extension.ToUpper = ".MP4" Then
                        temp = temp.Replace("MakerNotesCreate Date", "")
                        temp = temp.Replace("QuickTimeCreate Date", "")
                        temp = temp.Replace("H264Date/Time Original", "")
                    Else
                        'temp = temp.Replace("EXIF	Create Date	", "")
                        temp = temp.Replace("EXIFDate/Time Original", "")
                    End If



                    If temp = "0000:00:00 00:00:00" Then
                        ' newFileName = "ERROR: " & temp
                        newFileName = imageFileInfo.CreationTime.ToString(MyDateTimeFormat) & imageFileInfo.Extension
                    Else
                        'newFileName = temp.Substring(0, 10).Replace(":", "-") & " " & temp.Substring(11, 8).Replace(":", "_") & imageFileInfo.Extension

                        '*** ESEMPI ***
                        'Date.TryParseExact("2014:03:13", "yyyy:MM:dd", Nothing, Globalization.DateTimeStyles.None, dateTime)
                        'Date.TryParseExact("2014:03:13 11:52:37", "yyyy:MM:dd HH:mm:ss", Nothing, Globalization.DateTimeStyles.None, dateTime)
                        'Date.TryParseExact("2014:03:13 11:52:37+01:00", "yyyy:MM:dd HH:mm:ssK", Nothing, Globalization.DateTimeStyles.None, dateTime)
                        'Date.TryParseExact("2014:03:13 11:52:37+02:00", "yyyy:MM:dd HH:mm:ssK", Nothing, Globalization.DateTimeStyles.None, dateTime)

                        If (temp.IndexOf("+") > 0) Then
                            'K per il fuso orario
                            Date.TryParseExact(temp, "yyyy:MM:dd HH:mm:ssK", Nothing, Globalization.DateTimeStyles.None, dateTime)
                        Else
                            Date.TryParseExact(temp, "yyyy:MM:dd HH:mm:ss", Nothing, Globalization.DateTimeStyles.None, dateTime)
                        End If

                        

                        newFileName = dateTime.ToString(MyDateTimeFormat) & imageFileInfo.Extension

                    End If

                End If


                'readerBitampStream = New System.IO.FileStream(f.FullName, IO.FileMode.Open, IO.FileAccess.Read)
                'decoder = System.Windows.Media.Imaging.BitmapDecoder.Create(readerBitampStream, System.Windows.Media.Imaging.BitmapCreateOptions.PreservePixelFormat & System.Windows.Media.Imaging.BitmapCreateOptions.IgnoreColorProfile, System.Windows.Media.Imaging.BitmapCacheOption.OnLoad)
                'frame = decoder.Frames(0)



                'Dim theImage As System.Drawing.Imaging.Metafile = New System.Drawing.Imaging.Metafile(f.FullName)
                'Dim theImage As System.Drawing.Bitmap = New System.Drawing.Bitmap(f.FullName)
                'Dim propItems As System.Drawing.Imaging.PropertyItem() = theImage.PropertyItems


                'Dim count As Integer = 0
                'Dim propItem As System.Drawing.Imaging.PropertyItem
                'For Each propItem As System.Drawing.Imaging.PropertyItem In propItems

                'Console.WriteLine("Property Item " & count.ToString())
                'Console.WriteLine("   iD: 0x" & propItem.Id.ToString("x"))

                'Console.WriteLine("   type: " & propItem.Type.ToString())

                'Console.WriteLine("   length: " & propItem.Len.ToString())

                'count += 1
                'Next



            Catch ex As Exception
                ' non sono riuscito ad individuare i tag per rinominare il file
                newFileName = "ERROR: " & ex.Message
            End Try


            If newFileName <> f.Name Then
                row.Cells(0).Style.ForeColor = Color.Red
                row.Cells(1).Value = newFileName
            Else
                row.Cells(0).Style.ForeColor = Color.Green
            End If

            Me._statusBarUpdate(String.Format("File {0:N0}/{1:N0}", conta, files.Count))
            conta = conta + 1
        Next
        Me._statusBarUpdate("Preview completed")
    End Sub

    Public Overrides Function _checkFieldBeforeSaveDetailOnClick(ByVal tab As System.Windows.Forms.TabPage) As Boolean
        Return True
    End Function

    Protected Overrides Function _btnSaveDetailOnClick(ByVal tab As System.Windows.Forms.TabPage) As Boolean
        Dim myFolder As String
        myFolder = UcBrowseFileSystem1._getFolder()

        Dim includePicasaIni As Boolean = False
        Dim picasaIni As String = ""

        If IO.File.Exists(myFolder & ".picasa.ini") Then
            If System.Windows.Forms.MessageBox.Show("La cartella è utilizzata anche da Picasa. Aggiornare anche il file .picasa.ini?", My.Application.Info.ProductName, System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                includePicasaIni = True
            End If
        End If

        If includePicasaIni Then
            picasaIni = IO.File.ReadAllText(myFolder & ".picasa.ini")
            IO.File.Copy(myFolder & ".picasa.ini", myFolder & ".picasa.ini.bck", True)
        End If


        Dim newFileName As String
        Dim fileName As String
        Dim conta As Long = 1

        Dim flag As Boolean

        Dim f As IO.FileInfo

        For Each row As System.Windows.Forms.DataGridViewRow In DataGridView1.Rows

            flag = False

            fileName = row.Cells(0).Value
            If row.Cells(1).Value Is Nothing Then
                newFileName = ""
            Else
                newFileName = row.Cells(1).Value
            End If


            If newFileName.StartsWith("ERROR:") Then
                newFileName = ""
            End If

            If Not String.IsNullOrEmpty(newFileName) AndAlso newFileName <> fileName Then
                f = row.Tag
                Try
STEP1:

                    IO.File.Move(f.FullName, f.DirectoryName & "\" & newFileName)
                    If includePicasaIni Then
                        picasaIni = picasaIni.Replace("[" & fileName & "]", "[" & newFileName & "]")
                    End If

                    If flag Then
                        row.Cells(1).Value = row.Cells(1).Value & " -> " & newFileName
                    End If

                    row.Cells(0).Style.ForeColor = Color.Blue


                Catch ex As Exception
                    'mentre rinomino il file potrei trovare nella stessa directory, un file con lo stesso nome!!
                    'row.Cells(1).Value = row.Cells(1).Value & " " & ex.Message

                    '2011-10-15 20_51_01.
                    Dim idx As Int16
                    idx = newFileName.Substring(17, 2)

                    newFileName = newFileName.Replace(String.Format("_{0:00}.", idx), String.Format("_{0:00}.", idx + 1))
                    flag = True

                    GoTo STEP1
                End Try




            End If
            Me._statusBarUpdate(String.Format("Rename {0:N0}/{1:N0}", conta, DataGridView1.Rows.Count))
            conta = conta + 1
        Next

        If includePicasaIni Then
            IO.File.SetAttributes(myFolder & ".picasa.ini", IO.FileAttributes.Normal)
            IO.File.WriteAllText(myFolder & ".picasa.ini", picasaIni)
            IO.File.SetAttributes(myFolder & ".picasa.ini", IO.FileAttributes.Hidden)
        End If

        Me._statusBarUpdate("Rename completed")
        Return True
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