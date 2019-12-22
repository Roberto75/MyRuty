Public Class PasswordItem

    Property Titolo As String

    Property Username As String

    Property Password As String

    Property Email As String

    Property Url As String

    Property Nota As String

    Public Sub New()

    End Sub

    Public Sub New(titolo As String, usernane As String, password As String, email As String, url As String, nota As String)
        Me.Titolo = titolo

        Me.Username = usernane

        Me.Password = password

        Me.Email = email

        Me.Url = url


        Me.Nota = nota


    End Sub

End Class
