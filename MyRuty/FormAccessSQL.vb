'
' Created by SharpDevelop.
' User: Roberto
' Date: 22/10/2009
' Time: 17.52
'
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Public Class FormAccessSQL
    Inherits MyFormsLibrary.FormBaseDetail_3

    Private _fileSQL As String = ""
    Private _fileAccess As String = ""
    Private _manager As MyManager.Manager


    Public Sub New()
        Me.InitializeComponent()
    End Sub

    Public Overrides Function _init(ByRef connection As System.Data.Common.DbConnection, ByRef statusBar As System.Windows.Forms.ToolStripStatusLabel, ByRef progressBar As System.Windows.Forms.ToolStripProgressBar) As Boolean
        MyBase._init(connection, statusBar, progressBar)


        _removeAllTabPages()
        _manager = New MyManager.Manager()

        Me.txtSQL.Text = ""
        Return True
    End Function


    Private Sub MyButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton2.Click


        If String.IsNullOrEmpty(Me._fileAccess) Then
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.txtSQL.Text) Then
            Exit Sub
        End If

        _removeAllTabPages()
        executeCommandOnDBAccess()

        Me._statusBarUpdate("")
    End Sub

    Public Overrides Function _TabDetailOnClick(ByVal isLoad As Boolean, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) As Boolean
        Return True
    End Function


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Me.txtSQL.Text = ""
        Me.txtFileAccess.Text = ""
        Me._fileAccess = ""
        Me._fileSQL = ""
        _removeAllTabPages()
    End Sub

    Private Sub MyButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton1.Click
        Dim myOpenFileDialog As New System.Windows.Forms.OpenFileDialog
        myOpenFileDialog.Filter = "SQL files (*.sql)|*.sql"
        'setting filters so that Text files and All Files choice appears in the Files of Type box
        'in the dialog
        If myOpenFileDialog.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If
        'showDialog method makes the dialog box visible at run time
        Me._fileSQL = myOpenFileDialog.FileName
        Me.txtSQL.Text = IO.File.ReadAllText(_fileSQL)
    End Sub



    Private Function executeCommandOnDBAccess() As Boolean
        Dim commandSQL As New List(Of String)
        commandSQL.AddRange(Me.txtSQL.Text.Split(New String() {";"}, StringSplitOptions.RemoveEmptyEntries))


        If System.Windows.Forms.MessageBox.Show(String.Format("Confermare l'esecuzione di  {0:N0} comandi  sul file ACCESS: {1}", commandSQL.Count, New IO.FileInfo(_fileAccess).Name), My.Application.Info.ProductName, System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question) <> Windows.Forms.DialogResult.OK Then
            Exit Function
        End If

        Dim temp As String
        Dim esito As String
        Dim withErrors As Boolean = False
        Dim message As String = ""
        Dim contaComandi As Long = 1
        Dim contaFailed As Long = 0
        Dim contaSuccess As Long = 0
        Dim comandiSuccess As String = ""

        _manager._openFileAccess(New System.IO.FileInfo(Me._fileAccess))
        _manager.openConnection()

        Try
            For Each strSQL As String In commandSQL

                If Not String.IsNullOrEmpty(strSQL.Trim) Then
                    Try
                        esito = _manager.mExecuteNoQuery(strSQL).ToString

                        contaSuccess = contaSuccess + 1
                        comandiSuccess = strSQL & vbCrLf & comandiSuccess

                    Catch ex As MyManager.ManagerException
                        temp = vbTab & ex.Message & vbCrLf
                        temp = temp & vbTab & strSQL & vbCrLf

                        message = message & String.Format("command #{0:N0}:{1}", contaComandi, temp) & vbCrLf

                        withErrors = True
                        contaFailed = contaFailed + 1
                    End Try
                    Me._statusBarUpdate(String.Format("Command #{0:N0}", contaComandi))
                    contaComandi = contaComandi + 1
                End If
            Next
        Finally
            _manager.closeConnection()
        End Try

        If withErrors Then

            message = String.Format("Su #{0:N0} comandi #{1:N0} sono andati in errore ", contaComandi, contaFailed) & message

            message = message & "*** Comandi eseguiti conn successo ***" & vbCrLf & comandiSuccess


            _addTabPageWithTextArea("Access *", message)
            Me._statusBarUpdate("Esecuzione termianta con errori")
            System.Windows.Forms.MessageBox.Show("Esecuzione termianta con errori", My.Application.Info.ProductName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)

        Else
            _addTabPageWithTextArea("Access", "OK")
            Me._statusBarUpdate("Esecuzione conclusa con successo")
            System.Windows.Forms.MessageBox.Show("Esecuzione conclusa con successo", My.Application.Info.ProductName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)

        End If
        Return withErrors
    End Function



    Private Sub btnOpenAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenAccess.Click
        Dim myOpenFileDialog As New System.Windows.Forms.OpenFileDialog
        myOpenFileDialog.Filter = "Access 2003 e 2007 (*.mdb;*.accdb)|*.mdb;*.accdb"
        'setting filters so that Text files and All Files choice appears in the Files of Type box
        'in the dialog
        If myOpenFileDialog.ShowDialog() <> DialogResult.OK Then
            Exit Sub
        End If
        'showDialog method makes the dialog box visible at run time
        Me._fileAccess = myOpenFileDialog.FileName
        Me.txtFileAccess.Text = myOpenFileDialog.FileName

    End Sub
End Class
