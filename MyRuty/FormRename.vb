Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Runtime.InteropServices.WindowsRuntime

Public Class FormRename

    Public Overrides Function _init(ByRef connection As System.Data.Common.DbConnection, ByRef statusBar As System.Windows.Forms.ToolStripStatusLabel, ByRef progressBar As System.Windows.Forms.ToolStripProgressBar) As Boolean
        MyBase._init(connection, statusBar, progressBar)
        'For Each t As Danielyan.Exif.ExifTag In tags.Values
        ' Console.WriteLine(t.ToString & vbCrLf)
        ' Next
        'Console.WriteLine("Date: " & tags.Item("DateTimeOriginal").Value)

        UcBrowseFileSystem1._init()

        'Dim index As Integer
        'index = DataGridView1.Columns.Add("fileName", "Name")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        btnNuovoDetail.Visible = False
        btnNuovoDetail.MyType = MyControlsLibrary.MyButton.ButtonType.btnDelete
        btnNuovoDetail.Text = "Delete JPG"

        btnSalvaDetail.Visible = False
        btnSalvaDetail.Text = "Rename"

        If Not IO.File.Exists(Application.StartupPath & "\exiftool.exe") Then
            IO.File.WriteAllBytes(Application.StartupPath & "\exiftool.exe", My.Resources.exiftool)
        End If

        Return True
    End Function



    Private Function getFiles() As List(Of IO.FileInfo)
        Dim files As List(Of IO.FileInfo)

        Dim myFilter As String = ""

        If chkJPG.Checked Then
            myFilter &= ".jpg|.jpeg|"
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

        'rel 2.0.1.2   01/07/2018  GoPro
        If chkGPR.Checked Then
            myFilter &= ".GPR|"
        End If

        'rel 2.1.0.2  25/05/2020   Sony di Simone
        If chkMPG.Checked Then
            myFilter &= ".MPG|"
        End If

        'rel 2.2.0  29/12/2023   GoPro Hero 12
        If chkDNG.Checked Then
            myFilter &= ".DNG|"
        End If

        'rel 2.2.1  06/09/2025   IPhone HEIC
        If chkHEIC.Checked Then
            myFilter &= ".HEIC|"
        End If


        If String.IsNullOrEmpty(myFilter) Then
            System.Windows.Forms.MessageBox.Show("Selezionare almeno un tipo di file da processare", My.Application.Info.ProductName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning)
            Return Nothing
        End If


        myFilter = myFilter.Substring(0, myFilter.Length - 1)

        files = UcBrowseFileSystem1._getListFiles(myFilter)

        Return files

    End Function


    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click

        Dim index As Integer
        DataGridView1.Columns.Clear()
        btnNuovoDetail.Visible = False
        btnSalvaDetail.Visible = False
        index = DataGridView1.Columns.Add("fileName", "Name")
        index = DataGridView1.Columns.Add("fileReName", "Rename")


        Dim files As List(Of IO.FileInfo)

        files = getFiles()

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

                '*** PER VEDEE I NOMI dEI TAG usarte il paremetro -v***
                'exiftool.exe -v c:\Users\Roberto\Desktop\MOV01117.MPG




                If (f.Extension.ToUpper = ".MOV" OrElse f.Extension.ToUpper = ".MP4") Then
                    commandExiff = String.Format("""exiftool.exe"" -createdate -fast -G -t -m -q ""{0}""", f.FullName)
                ElseIf (f.Extension.ToUpper = ".MPG") Then
                    commandExiff = String.Format("""exiftool.exe"" -FileCreateDate -fast -G -t -m -q ""{0}""", f.FullName)
                Else
                    commandExiff = String.Format("""exiftool.exe"" -DateTimeOriginal -fast -G -t -m -q ""{0}""", f.FullName)
                End If


                temp = processCommand(commandExiff)

                If Not String.IsNullOrEmpty(temp) Then

                    temp = temp.Trim()
                    temp = temp.Replace(vbTab, "")


                    If f.Extension.ToUpper = ".MOV" OrElse f.Extension.ToUpper = ".AVI" OrElse f.Extension.ToUpper = ".MTS" OrElse f.Extension.ToUpper = ".MP4" OrElse f.Extension.ToUpper = ".MPG" Then
                        temp = temp.Replace("MakerNotesCreate Date", "")
                        temp = temp.Replace("QuickTimeCreate Date", "")
                        temp = temp.Replace("H264Date/Time Original", "")
                        temp = temp.Replace("FileFile Creation Date/Time", "")
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
        btnNuovoDetail.Visible = False
        btnSalvaDetail.Visible = True
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



    Private Sub cleanDNGvsJPG()
        ' cerco i file JPG e DNG con lo stesso nome.
        ' rinomino i JPG per poi eventualmente cancellarli

        Dim folder As String = UcBrowseFileSystem1._getFolder()
        If (folder Is Nothing) Then
            Return
        End If

        Dim fileNames() As String
        fileNames = Directory.GetFiles(folder)


        Dim fileGroups = fileNames.GroupBy(Function(x) Path.GetFileNameWithoutExtension(x))

        btnNuovoDetail.Visible = False
        btnSalvaDetail.Visible = False
        Dim conta As Long = 1
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("fileNameDNG", "File DNG")
        DataGridView1.Columns.Add("fileNameJPG", "File JPG (TO BE DELETED)")

        Me.DataGridView1.Rows.Clear()
        Dim row As System.Windows.Forms.DataGridViewRow

        Dim newRowIndex As Long


        For Each f In fileGroups
            If (f.Count = 2) Then
                Console.WriteLine(f.Key & " --> COUNT =" & f.Count)
                Dim fileNameDNG As String = f.Key & ".dng"
                Dim fileNameJPG As String = f.Key & ".jpg"

                If (IO.File.Exists(folder & fileNameDNG)) Then
                    'se esiste anche lo stesso file nel formato jpg allora lo cancello
                    If (IO.File.Exists(folder & fileNameJPG)) Then
                        Console.WriteLine("DELETED -->" & fileNameJPG)


                        newRowIndex = DataGridView1.Rows.Add()


                        row = DataGridView1.Rows(newRowIndex)
                        row.Cells(0).Value = fileNameDNG
                        row.Cells(0).Style.ForeColor = Color.Green

                        row.Cells(1).Value = fileNameJPG
                        row.Cells(1).Style.ForeColor = Color.Red



                        Me._statusBarUpdate(String.Format("Files to be deleted {0:N0}", conta))
                        conta += 1
                    End If
                End If
            End If

        Next
        Me._statusBarUpdate(String.Format("Files to be deleted {0:N0} completed", conta - 1))
        btnSalvaDetail.Visible = False
        btnNuovoDetail.Visible = True

    End Sub

    Private Sub btnDNGvsJPG_Click(sender As Object, e As EventArgs) Handles btnDNGvsJPG.Click
        cleanDNGvsJPG()
    End Sub


    Protected Overrides Function _btnNuovoDetailOnClick(tab As TabPage) As Boolean

        If System.Windows.Forms.MessageBox.Show(String.Format("Confermare la cancellazione di {0:N0} files JPG?", DataGridView1.RowCount - 1), My.Application.Info.ProductName, System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question) <> Windows.Forms.DialogResult.OK Then
            Return False
        End If

        If DataGridView1.RowCount = 1 Then
            Return False
        End If

        Dim folder As String = UcBrowseFileSystem1._getFolder()
        Dim fileNameDNG As String
        Dim fileNameJPG As String
        Dim conta As Long = 1
        For Each row As System.Windows.Forms.DataGridViewRow In DataGridView1.Rows
            fileNameDNG = row.Cells(0).Value
            fileNameJPG = row.Cells(1).Value

            If (IO.File.Exists(folder & fileNameDNG)) Then
                'se esiste anche lo stesso file nel formato jpg allora lo cancello
                If (IO.File.Exists(folder & fileNameJPG)) Then
                    Console.WriteLine("DELETED -->" & fileNameJPG)
                    My.Computer.FileSystem.RenameFile(folder & fileNameJPG, "DELETED_" & fileNameJPG)


                    Me._statusBarUpdate(String.Format("File deleted {0:N0}/{1:N0}", conta, DataGridView1.RowCount - 1))
                    conta += 1
                End If
            End If

        Next

    End Function

End Class