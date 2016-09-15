Public Class Form1

    Private Sub calcola()
        Dim curDate As Date

        curDate = Me.DateTimePicker1.Value


        Dim risultato As String = ""

        For i As Integer = 1 To 48
            risultato &= String.Format("{0:0#} - {1}", i, curDate.AddDays(i * 7).ToString("dddd dd-MM-yyyy")) & vbCrLf
        Next


        Me.TextBox1.Text = risultato




        If Me.DateTimePicker2.Checked Then

            risultato = "Differenza tra " & Me.DateTimePicker1.Value.ToShortDateString & " - " & Me.DateTimePicker2.Value.ToShortDateString & vbCrLf & vbCrLf
            risultato &= " Giorni :" & DateDiff(DateInterval.Day, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value) & vbCrLf
            risultato &= " Settimane :" & DateDiff(DateInterval.Weekday, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
            Me.TextBox2.Text = risultato
        End If









    End Sub



    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        calcola()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = My.Application.Info.ProductName & " - " & My.Application.Info.Version.ToString()

        Me.calcola()

    End Sub

    
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If Me.DateTimePicker2.Checked Then
            calcola()

        End If


    End Sub
End Class
