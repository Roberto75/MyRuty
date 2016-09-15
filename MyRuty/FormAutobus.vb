Public Class FormAutobus

    


    Public Overrides Sub _executeTask()
        Dim myRequest As System.Net.WebRequest
        Dim myResponse As System.Net.WebResponse = Nothing


STEP1:
        myRequest = System.Net.WebRequest.Create("http://trovalinea.atac.roma.it/zoom_in.asp?VediFermate=off&VediLinee=off&VediRivendite=off&xmax=2313179&ymax=4635208&xmin=2311779&ymin=4633808&idmtram=50237&percorso=767R&tipologia=URB&linea=767&impianto=78738&circo=NO")
        myRequest.Timeout = 90000

        Try
            myResponse = myRequest.GetResponse()
        Catch ex As System.Net.WebException
            If ex.Message = "The operation has timed out" Then
                'aspetto 5 secondi prima di riprovare
                System.Threading.Thread.Sleep(5000)
                GoTo STEP1
            End If
            _consoleWriteLine(ex.Message)
        End Try


        If myResponse Is Nothing Then
            GoTo STEP1
        End If

        Dim reader As New System.IO.StreamReader(myResponse.GetResponseStream, System.Text.Encoding.UTF8)
        Dim esito As String
        Dim html As String
        html = reader.ReadToEnd

        If html.IndexOf("In Arrivo") <> -1 Then
            CType(Me.Owner, MyFormsLibrary.FormMaster)._notifyIcon("767 in arrivo")
            _consoleWriteLine(vbTab & "767 in arrivo")
        End If

    End Sub




End Class