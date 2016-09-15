Public Class AgendaExcelManager
    Inherits MyManager.ExcelManager


    Public _lunediM As String
    Public _martediM As String
    Public _mercolediM As String
    Public _giovediM As String
    Public _venerdiM As String
    Public _sabatoM As String
    Public _domenicaM As String


    Public _lunediP As String
    Public _martediP As String
    Public _mercolediP As String
    Public _giovediP As String
    Public _venerdiP As String
    Public _sabatoP As String
    Public _domenicaP As String


    Sub New(ByRef objExcel As Microsoft.Office.Interop.Excel.Application)
        Me._objExcel = objExcel
    End Sub


    Public Function getAgenda(ByVal dataInizio As Date, ByVal dataFine As Date) As Boolean
        _workSheet = _objExcel.Worksheets(1)
        '_workSheet = _workBooks.Worksheets.Add()
        '_workSheet.Name = "data1"


        Dim dataCorrente As Date = dataInizio
        Dim conta As Long = 2
        Dim nomeStrutturatoM As String = ""
        Dim nomeStrutturatoP As String = ""
        Dim w As Microsoft.Office.Interop.Excel.Worksheet

        w = _objExcel.Worksheets(1)

        While dataCorrente <= dataFine

            Select Case dataCorrente.DayOfWeek
                Case DayOfWeek.Monday
                    nomeStrutturatoM = _lunediM
                    nomeStrutturatoP = _lunediP
                Case DayOfWeek.Tuesday
                    nomeStrutturatoM = _martediM
                    nomeStrutturatoP = _martediP
                Case DayOfWeek.Wednesday
                    nomeStrutturatoM = _mercolediM
                    nomeStrutturatoP = _mercolediP
                Case DayOfWeek.Thursday
                    nomeStrutturatoM = _giovediM
                    nomeStrutturatoP = _giovediP
                Case DayOfWeek.Friday
                    nomeStrutturatoM = _venerdiM
                    nomeStrutturatoP = _venerdiP
                Case DayOfWeek.Saturday
                    nomeStrutturatoM = _sabatoM
                    nomeStrutturatoP = _sabatoP
                Case DayOfWeek.Sunday
                    nomeStrutturatoM = _domenicaM
                    nomeStrutturatoP = _domenicaP
            End Select

            If Not String.IsNullOrEmpty(nomeStrutturatoM) OrElse Not (String.IsNullOrEmpty(nomeStrutturatoP)) Then

                w.Copy(_workSheet)

                _workSheet = _objExcel.Worksheets(conta)
                _workSheet.Name = dataCorrente.ToShortDateString.Replace("/", "_")

                _cell = _workSheet.Cells(1, 1)
                _cell.Value = dataCorrente.ToString("dd dddd")

                _cell = _workSheet.Cells(1, 4)
                _cell.Value = dataCorrente.ToString("MMMM yyyy")

                _cell = _workSheet.Cells(4, 1)
                _cell.Value = "Medico Referente: " & nomeStrutturatoM

                _cell = _workSheet.Cells(17, 1)
                _cell.Value = "Medico Referente: " & nomeStrutturatoP
            End If


            dataCorrente = dataCorrente.AddDays(1)
        End While

        Return True
    End Function



End Class
