Public Class FormMergeNote

    Public _merge As String



    Public Function _init(ByVal subject As String, ByVal testo1 As String, ByVal testo2 As String) As Boolean

        Me.Text = "Subject: " & subject

        Me.txtOutlook.Text = testo1
        Me.txtFile.Text = testo2

        Me.txtMerge.Text = ""

    End Function

    Private Sub MyButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton2.Click
        Me.ErrorProvider1.SetError(Me.MyButton2, "")

        If String.IsNullOrEmpty(txtMerge.Text) Then
            Me.ErrorProvider1.SetError(Me.MyButton2, "Il testo è vuoto")
            Exit Sub
        End If

        Me._merge = txtMerge.Text
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub MyButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class