Public Class FormAgenda

#If isActive Then
    Private _objExcel As Microsoft.Office.Interop.Excel.Application
    Private _agendaXLS As AgendaExcelManager
#End If

    Public Overrides Function _init(ByRef connection As System.Data.Common.DbConnection, ByRef statusBar As System.Windows.Forms.ToolStripStatusLabel, ByRef progressBar As System.Windows.Forms.ToolStripProgressBar) As Boolean
        MyBase._init(connection, statusBar, progressBar)
        Me.btnSalvaDetail.Visible = False
        Me.btnNuovoDetail.Visible = False

        Me.UcDataInizioDataFine1._init()

        Return True
    End Function



    Private Sub MyButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton1.Click

        _ErrorProvider.SetError(Me.GroupBox1, "")
        If chkAmbulatorio.Checked = False AndAlso chkEcografia.Checked = False Then
            _ErrorProvider.SetError(Me.GroupBox1, "Selezionare un tipo di agenda")
            Exit Sub
        End If

#If isActive Then
        If _objExcel Is Nothing Then
            _objExcel = New Microsoft.Office.Interop.Excel.Application
            _objExcel.Visible = False

            _agendaXLS = New AgendaExcelManager(_objExcel)
        End If


        Dim tempFile As String = CType(Me.Owner, FormMain)._folderTemp & "temp.xlsx"

        If chkAmbulatorio.Checked = True Then
            IO.File.WriteAllBytes(tempFile, My.Resources.AgendaAmbulatorio)
        End If

        If chkEcografia.Checked = True Then
            IO.File.WriteAllBytes(tempFile, My.Resources.AgendaEcografia)
        End If



        _agendaXLS._openFileExcel(tempFile)

        With _agendaXLS
            ._lunediM = Me.txtLunediM.Text
            ._martediM = Me.txtMartediM.Text
            ._mercolediM = Me.txtMercolediM.Text
            ._giovediM = Me.txtGiovediM.Text
            ._venerdiM = Me.txtVenerdiM.Text
            ._sabatoM = Me.txtSabatoM.Text
            ._domenicaM = Me.txtDomenicaM.Text


            ._lunediP = txtLunediP.Text
            ._martediP = txtMartediP.Text
            ._mercolediP = txtMercolediP.Text
            ._giovediP = txtGiovediP.Text
            ._venerdiP = txtVenerdiP.Text
            ._sabatoP = txtSabatoP.Text
            ._domenicaP = txtDomenicaP.Text

        End With

        If _agendaXLS.getAgenda(UcDataInizioDataFine1._getDataDa, UcDataInizioDataFine1._getDataA) Then
            _agendaXLS._showExcel()
        End If
#End If
    End Sub

    Public Overrides Function _OnTabClosing() As Boolean
#If isActive Then
        If Not Me._objExcel Is Nothing Then
            _objExcel.Quit()
        End If
#End If
        Return MyBase._OnTabClosing()
    End Function


End Class