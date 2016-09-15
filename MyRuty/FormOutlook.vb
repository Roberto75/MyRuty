#Const isActive = False

Public Class FormOutlook

    Private _manager As MyManager.OutlookManager

#If isActive Then
    Private _objOutlook As Microsoft.Office.Interop.Outlook.Application
#End If

    Private _desktop As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\"
    Private _logContattiConNoteDiverse As String
    Private _logContattiImportati As String
    Private _logContattiNonTrovati As String

    Private _sourceFile As String

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click




    End Sub


    Private Sub _openFileDialog(ByVal filter As String)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        'OpenFileDialog1.Filter = "Outlook (*.pst)|*.pst;"
        OpenFileDialog1.Filter = filter

        'OpenFileDialog1.InitialDirectory = Application.ExecutablePath
        OpenFileDialog1.Title = "Select File"
        'OpenFileDialog1.FileName = "source.xls"

        If (OpenFileDialog1.ShowDialog(tabPageMain) = Windows.Forms.DialogResult.OK) Then

            'If Windows.Forms.MessageBox.Show("Procedere con il caricamento del file?", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OKCancel, Windows.Forms.MessageBoxIcon.Question) <> Windows.Forms.DialogResult.OK Then
            '         Exit Sub
            '    End If
            _sourceFile = OpenFileDialog1.FileName
            Application.DoEvents()
        End If

    End Sub


    Private Sub MyButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton1.Click

        '*** IMPORT FROM FILE ****
        'Leggo il file di testo e lo importo in Outlook

        If _manager Is Nothing Then
            _manager = New MyManager.OutlookManager()
            _manager._setStatusBar(_statusBar)
        End If

        Dim datiDaImportare As String
        datiDaImportare = IO.File.ReadAllText(_desktop & "OutlookExportNotes.csv")

        _logContattiConNoteDiverse = ""
        _logContattiImportati = ""
        _logContattiNonTrovati = ""


        Dim nota As String
        Dim subject As String

        Dim valori() As String = System.Text.RegularExpressions.Regex.Split(datiDaImportare, ";@@;")
#If isActive Then
        Dim conta As Long = 1
        For i As Integer = 0 To valori.Length - 1 Step 5
            If i >= valori.Length - 1 Then
                Exit For
            End If
            subject = valori(i)
            nota = valori(i + 4)
            Debug.WriteLine(conta & ": " & subject & " - " & valori(i + 1) & " - " & valori(i + 2) & " - " & valori(i + 3) & "- " & nota)

            If _manager.searchContact(subject) Then
                ''Trovato!!!
                If _manager._contactItem.Body <> nota Then
                    _logContattiConNoteDiverse = _logContattiConNoteDiverse & _manager._contactItem.Subject & ";@@;" & _manager._contactItem.Body & ";@@;" & nota & ";@@;"

                    'Dim f As New FormMergeNote()
                    FormMergeNote._init(subject, _manager._contactItem.Body, nota)
                    If FormMergeNote.ShowDialog(Me.tabPageMain) = Windows.Forms.DialogResult.OK Then

                        'If Windows.Forms.MessageBox.Show(subject & vbCrLf & "Sostituire: " & vbCrLf & _contactItem.Body & vbCrLf & "CON: " & vbCrLf & nota, My.Application.Info.ProductName & " - CONFLITTO", Windows.Forms.MessageBoxButtons.OKCancel, Windows.Forms.MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                        'sostituisco 
                        _manager._contactItem.Body = FormMergeNote._merge
                        _manager._contactItem.Save()


                        _logContattiImportati = _logContattiImportati & _manager._contactItem.Subject & ";@@;" & _manager._contactItem.Body & ";@@;"
                    End If
                End If
            Else
                Windows.Forms.MessageBox.Show("Soggetto NON trovato " & subject & vbCrLf & nota, My.Application.Info.ProductName & "CONFLITTO", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                _logContattiNonTrovati = _logContattiNonTrovati & subject & ";@@;" & nota & ";@@;"
            End If


            Me._statusBarUpdate(String.Format("Import {0:N0}/{1:N0}", conta, valori.Length / 5))
            conta = conta + 1
        Next

        If Not String.IsNullOrEmpty(_logContattiConNoteDiverse) Then
            IO.File.WriteAllText(_desktop & "contattiConNoteDiverse.csv", _logContattiConNoteDiverse)
        End If

        If Not String.IsNullOrEmpty(_logContattiImportati) Then
            IO.File.WriteAllText(_desktop & "contattiImportati.csv", _logContattiImportati)
        End If

        If Not String.IsNullOrEmpty(_logContattiNonTrovati) Then
            IO.File.WriteAllText(_desktop & "contattiNonTrovati.csv", _logContattiNonTrovati)
        End If
#End If
        Windows.Forms.MessageBox.Show("Importazione conclusa con successo ", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)

    End Sub

    Private Sub MyButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton2.Click

        If _manager Is Nothing Then
            _manager = New MyManager.OutlookManager()
            _manager._setStatusBar(_statusBar)
        End If



        Dim risultato As String
#If isActive Then
        risultato = _manager.getAllContact()
#End If
        If String.IsNullOrEmpty(risultato) Then
            Windows.Forms.MessageBox.Show("Non è stato trovato alcun contatto da eseportare", My.Application.Info.ProductName & "CONFLITTO", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            Exit Sub
        End If


        IO.File.WriteAllText(_desktop & "OutlookExportNotes.csv", risultato)

        Windows.Forms.MessageBox.Show("Esportazione conclusa con successo ", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)

    End Sub


    Private Sub MyButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton3.Click
        'Check BODY SIZE
        If _manager Is Nothing Then
            _manager = New MyManager.OutlookManager()
            _manager._setStatusBar(_statusBar)
        End If
#If isActive Then
        If _manager.searchContactWithBodysize(150) Then
            Windows.Forms.MessageBox.Show(_manager._contactItem.Subject & vbCrLf & _manager._contactItem.Body, My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
        End If
#End If
    End Sub

    Private Sub MyButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton4.Click
        '*** IMPORT FROM CSV ***


        _openFileDialog("CSV (*.csv)|*.csv;")

        If String.IsNullOrEmpty(_sourceFile) Then
            Exit Sub
        End If


        If _manager Is Nothing Then
            _manager = New MyManager.OutlookManager()
            _manager._setStatusBar(_statusBar)
        End If



        Dim reader As FileIO.TextFieldParser
        ' reader = New FileIO.TextFieldParser(_desktop & "Contatti.csv", System.Text.Encoding.Default)
        reader = New FileIO.TextFieldParser(_sourceFile, System.Text.Encoding.Default)
        reader.TextFieldType = FileIO.FieldType.Delimited
        reader.Delimiters = New String() {","}
        reader.HasFieldsEnclosedInQuotes = True


        Dim currentRow As String()

        Dim subject As String
        Dim nome As String
        Dim cognome As String
        Dim societa As String
        Dim nota As String
        Dim mobile As String
        Dim telefonoPrincipale As String

        Dim conta As Long = 0

        Dim nota1, nota2 As String


        Try
            While Not reader.EndOfData
                currentRow = reader.ReadFields()

                nome = currentRow(1)
                cognome = currentRow(3)
                societa = currentRow(5)
                nota = currentRow(67)

                mobile = currentRow(40)
                telefonoPrincipale = currentRow(44)

                If conta = 0 Then
                    'TEST
                    If nome <> "Nome" Then
                        Windows.Forms.MessageBox.Show("Column Nome not match.  Skipping", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    If cognome <> "Cognome" Then
                        Windows.Forms.MessageBox.Show("Column Cognome not match.  Skipping", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    If societa <> "Società" Then
                        Windows.Forms.MessageBox.Show("Column societa not match.  Skipping", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    If nota <> "Notes" Then
                        Windows.Forms.MessageBox.Show("Column NOTE not match.  Skipping", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    If mobile <> "Cellulare" Then
                        Windows.Forms.MessageBox.Show("Column Mobile not match.  Skipping", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    If telefonoPrincipale <> "Telefono principale" Then
                        Windows.Forms.MessageBox.Show("Column Telefono principale not match.  Skipping", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If

#If isActive Then
                If conta <> 0 Then
                    subject = ""

                    If Not String.IsNullOrEmpty(nome) OrElse Not String.IsNullOrEmpty(cognome) Then
                        If _manager.searchContact(nome, cognome) Then
                            subject = nome & " " & cognome
                        End If
                    End If

                    If String.IsNullOrEmpty(subject) Then
                        If _manager.searchContactBySocieta(societa) Then
                            subject = societa
                        End If
                    End If

                    If String.IsNullOrEmpty(subject) Then
                        subject = nome & " - " & cognome & " - " & societa
                        Windows.Forms.MessageBox.Show("Soggetto NON trovato " & subject & vbCrLf & nota, My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
                        _logContattiNonTrovati = _logContattiNonTrovati & subject & ";@@;" & nota & ";@@;"
                    Else

                        '*** NOTA ***
                        If Not String.IsNullOrEmpty(nota) Then
                            nota1 = _manager._contactItem.Body.Replace(" ", "").Replace(vbCrLf, "")
                            nota2 = nota.Replace(" ", "").Replace(vbCrLf, "")


                            If nota1 <> nota2 Then
                                _logContattiConNoteDiverse = _logContattiConNoteDiverse & _manager._contactItem.Subject & ";@@;" & _manager._contactItem.Body & ";@@;" & nota & ";@@;"

                                'Dim f As New FormMergeNote()
                                FormMergeNote._init(subject, _manager._contactItem.Body, nota)
                                If FormMergeNote.ShowDialog(Me.Owner) = Windows.Forms.DialogResult.OK Then

                                    'If Windows.Forms.MessageBox.Show(subject & vbCrLf & "Sostituire: " & vbCrLf & _contactItem.Body & vbCrLf & "CON: " & vbCrLf & nota, My.Application.Info.ProductName & " - CONFLITTO", Windows.Forms.MessageBoxButtons.OKCancel, Windows.Forms.MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                                    'sostituisco 

                                    _manager._contactItem.Body = FormMergeNote._merge
                                    _manager._contactItem.Save()

                                    _logContattiImportati = _logContattiImportati & _manager._contactItem.Subject & ";@@;" & _manager._contactItem.Body & ";@@;"
                                End If
                            End If
                        End If

                        '*** CELLULARE ***
                        If Not String.IsNullOrEmpty(mobile) Then
                            If mobile <> _manager._contactItem.MobileTelephoneNumber Then
                                FormMergeNote._init(subject, _manager._contactItem.MobileTelephoneNumber, mobile)
                                If FormMergeNote.ShowDialog(Me.tabPageMain) = Windows.Forms.DialogResult.OK Then
                                    _manager._contactItem.MobileTelephoneNumber = FormMergeNote._merge
                                    _manager._contactItem.Save()

                                    '   _logContattiImportati = _logContattiImportati & _manager._contactItem.Subject & ";@@;" & _manager._contactItem.Body & ";@@;"
                                End If
                            End If
                        End If


                        '*** TELEFONO ***
                        If Not String.IsNullOrEmpty(telefonoPrincipale) Then
                            If telefonoPrincipale <> _manager._contactItem.PrimaryTelephoneNumber Then
                                FormMergeNote._init(subject, _manager._contactItem.PrimaryTelephoneNumber, telefonoPrincipale)
                                If FormMergeNote.ShowDialog(Me.tabPageMain) = Windows.Forms.DialogResult.OK Then
                                    _manager._contactItem.PrimaryTelephoneNumber = FormMergeNote._merge
                                    _manager._contactItem.Save()

                                    '   _logContattiImportati = _logContattiImportati & _manager._contactItem.Subject & ";@@;" & _manager._contactItem.Body & ";@@;"
                                End If
                            End If
                        End If


                    End If
                End If

#End If
                Me._statusBarUpdate(String.Format("Import {0:N0}", conta))
                conta = conta + 1
            End While

            If Not String.IsNullOrEmpty(_logContattiConNoteDiverse) Then
                IO.File.WriteAllText(_desktop & "contattiConNoteDiverse.csv", _logContattiConNoteDiverse)
            End If

            If Not String.IsNullOrEmpty(_logContattiImportati) Then
                IO.File.WriteAllText(_desktop & "contattiImportati.csv", _logContattiImportati)
            End If

            If Not String.IsNullOrEmpty(_logContattiNonTrovati) Then
                IO.File.WriteAllText(_desktop & "contattiNonTrovati.csv", _logContattiNonTrovati)
            End If

            Windows.Forms.MessageBox.Show("Importazione conclusa con successo ", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)



        Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
            Windows.Forms.MessageBox.Show("Line " & ex.Message & " is invalid.  Skipping", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
        Finally
            reader.Close()
            reader.Dispose()
        End Try



    End Sub

    Private Sub MyButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton5.Click
        If _manager Is Nothing Then
            _manager = New MyManager.OutlookManager()
            _manager._setStatusBar(_statusBar)
        End If

#If isActive Then
        If Not _manager.formatMobileNumber() Then

            FormMergeNote._init(_manager._contactItem.Subject, _manager._contactItem.MobileTelephoneNumber, _manager._contactItem.MobileTelephoneNumber.Replace(".", ""))
            If FormMergeNote.ShowDialog(Me.tabPageMain) = Windows.Forms.DialogResult.OK Then

                'If Windows.Forms.MessageBox.Show(subject & vbCrLf & "Sostituire: " & vbCrLf & _contactItem.Body & vbCrLf & "CON: " & vbCrLf & nota, My.Application.Info.ProductName & " - CONFLITTO", Windows.Forms.MessageBoxButtons.OKCancel, Windows.Forms.MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                'sostituisco 
                _manager._contactItem.MobileTelephoneNumber = FormMergeNote._merge.Trim
                _manager._contactItem.Save()


                _logContattiImportati = _logContattiImportati & _manager._contactItem.Subject & ";@@;" & _manager._contactItem.Body & ";@@;"
            End If
        End If
#End If
    End Sub
End Class