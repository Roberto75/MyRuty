Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Public Class FormSteganografiaV2
    Private _factory As New Steganografia.PicFactory()

    Private _password As String = ""
    Private _pathFile As String

    Property ListaPasswordItem As New List(Of PasswordItem)

    Public Overrides Function _init(ByRef connection As System.Data.Common.DbConnection, ByRef statusBar As System.Windows.Forms.ToolStripStatusLabel, ByRef progressBar As System.Windows.Forms.ToolStripProgressBar) As Boolean
        MyBase._init(connection, statusBar, progressBar)

        Trace.WriteLine("_init")
        Me.InitDataGrid()
        Me.InitDataSource()

        '_removeAllTabPages()
        Return True
    End Function




    Private Function InitDataGrid() As Boolean

        Trace.WriteLine("InitDataGrid")


        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.AllowUserToDeleteRows = True


        Me.DataGridView1.DataSource = Me.BindingSource1


        Return True

    End Function

    Private Function InitDataSource() As Boolean
        Trace.WriteLine("InitDataSource")

        'ListaPasswordItem.Add(New PasswordItem("titolo", "roberto", "rutigliano", "email", "url", "nota"))
        'ListaPasswordItem.Add(New PasswordItem("", "angela", "salso", "", "", ""))


        BindingSource1.DataSource = ListaPasswordItem

        SerializeList()

        Return True
    End Function

    Private Function SerializeList() As String
        Trace.WriteLine("SerializeList")

        Dim serializer As New XmlSerializer(GetType(List(Of PasswordItem)))
        Dim sw1 = New StringWriter()

        Dim xw As New XmlTextWriter(sw1)
        xw.Formatting = Formatting.Indented
        xw.Indentation = 4

        serializer.Serialize(xw, ListaPasswordItem)

        Console.WriteLine(sw1.ToString())

        Return sw1.ToString()

    End Function



    Private Function DeserializeList() As Boolean
        Trace.WriteLine("DeserializeList" & txtMessaggio.Text)

        Dim serializer As New XmlSerializer(GetType(List(Of PasswordItem)))
        Using reader As TextReader = New StringReader(txtMessaggio.Text)
            ListaPasswordItem = serializer.Deserialize(reader)
        End Using


        BindingSource1.DataSource = ListaPasswordItem


        Return True

    End Function


    Private Function _openFileDialog(ByVal filter As String) As Boolean
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Select image"
        OpenFileDialog1.Filter = filter
        OpenFileDialog1.Multiselect = False
        'OpenFileDialog1.InitialDirectory = Application.ExecutablePath
        'OpenFileDialog1.FileName = "source.xls"

        If (OpenFileDialog1.ShowDialog(tabPageMain) = Windows.Forms.DialogResult.OK) Then
            _pathFile = OpenFileDialog1.FileName
            _addTitleToHeader("File:", _pathFile)
            Application.DoEvents()
            Return True
        End If

        Return False
    End Function


    Private Function decode() As Boolean

        Me._ErrorProvider.SetError(btnDecode, "")
        If String.IsNullOrEmpty(_pathFile) Then
            Me._ErrorProvider.SetError(btnDecode, "Selezionare un file")
            Return False
        End If

        _password = Me.txtPassword.Text

        _statusBarUpdate("Decoding ...")

        Dim decoder As Steganografia.IDecoder
        decoder = _factory.MakeDecoder()

        Dim stego As Steganografia.Stego
        stego = New Steganografia.Stego(decoder)

        Try
            stego.Decode(_pathFile, _password)
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message, My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            Return False
        End Try

        Dim message As System.IO.Stream
        message = stego.DecodedFile

        Dim length As Integer
        length = message.Length

        Dim sr As System.IO.StreamReader
        sr = New System.IO.StreamReader(message, System.Text.UnicodeEncoding.UTF32)



        Dim r As Integer

        Dim output As System.Text.StringBuilder

        Try
            output = New System.Text.StringBuilder(length, length)

            r = sr.Read()

            While (r <> -1)
                output.Append(Chr(r))
                r = sr.Read()
            End While


            txtMessaggio.Text = output.ToString()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message, My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            Return False
        Finally
            sr.Close()
            stego.Dispose()
        End Try


        DeserializeList()

        _statusBarUpdate("")
    End Function



    Private Sub btnDecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecode.Click
        If Not _openFileDialog("Immagine (*.bmp;*.tif;*.tiff;*.png)|*.bmp;*.tif;*.tiff;*.png;") Then
            Exit Sub
        End If
        decode()
    End Sub




    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If String.IsNullOrEmpty(txtMessaggio.Text.Trim) Then
            Windows.Forms.MessageBox.Show("Il messaggio da codificare è vuoto", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            Exit Sub
        End If

        If String.IsNullOrEmpty(_pathFile) Then
            If Not _openFileDialog("Immagine (*.bmp;*.tif;*.tiff;*.png)|*.bmp;*.tif;*.tiff;*.png;") Then
                Exit Sub
            End If
        End If

        If Windows.Forms.MessageBox.Show("Attenzione le informazioni contenute nell file verranno sostituite." & vbCrLf & "Il messaggio verrà codificato tramite la password" & vbCrLf & _pathFile, My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OKCancel, Windows.Forms.MessageBoxIcon.Question) <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim messaggio As String
        'messaggio = txtMessaggio.Text.Trim
        messaggio = SerializeList()
        txtMessaggio.Text = messaggio



        If encode(messaggio) Then
            Windows.Forms.MessageBox.Show("Salvataggio concluso con successo", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
            DeserializeList()
        End If
    End Sub




    Private Function encode(testo As String) As Boolean

        If _password <> Me.txtPassword.Text Then
            If Windows.Forms.MessageBox.Show("Attenzione la password è stata cambiata. Proseguire con la codifica?", My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OKCancel, Windows.Forms.MessageBoxIcon.Question) <> Windows.Forms.DialogResult.OK Then
                Return False
            End If
        End If

        _statusBarUpdate("Decoding ...")

        _password = Me.txtPassword.Text.Trim


        'Dim testo As String
        'testo = txtMessaggio.Text.Trim

        'leggo la prima riga del messsaggio e la sostituisco con una riga nuova con la data aggiornata!!
        'Dim indice As Integer
        'indice = testo.IndexOf(vbCrLf)
        'testo = testo.Substring(indice + 2)
        'testo = "Data ultima modifica: " & DateTime.Now & vbCrLf & testo
        'txtMessaggio.Text = testo
        'txtMessaggio.Refresh()


        Dim messageUnicode() As Byte
        messageUnicode = System.Text.UnicodeEncoding.UTF32.GetBytes(testo)

        Dim stream As System.IO.MemoryStream
        stream = New System.IO.MemoryStream(messageUnicode)


        Dim encoder As Steganografia.IEncoder
        encoder = _factory.MakeEncoder()

        Dim stego As Steganografia.Stego
        stego = New Steganografia.Stego(encoder)

        Try
            stego.Encode(_pathFile, stream, _password)
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(ex.Message, My.Application.Info.ProductName, Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Error)
            Return False
        Finally
            stream.Close()
        End Try

        'creo una copia di backup
        If (IO.File.Exists(_pathFile)) Then
            IO.File.Copy(_pathFile, _pathFile & ".backup", True)
        End If

        'lo copio in un file temp
        stego.SaveEncoded(_pathFile & ".temp")
        stego.Dispose()

        IO.File.Delete(_pathFile)
        IO.File.Move(_pathFile & ".temp", _pathFile)



        _statusBarUpdate("")
        Return True
    End Function

    Public Overrides Function _TabDetailOnClick(ByVal isLoad As Boolean, ByVal e As TabControlCancelEventArgs) As Boolean
        Return True

    End Function

End Class