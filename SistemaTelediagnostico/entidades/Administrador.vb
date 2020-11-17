Public Class Administrador
    Inherits Usuario

    Public Property id As String   ' contraseña del administrador

    Public Sub New()
        ' constructor vacío
    End Sub

    Public Sub New(id As String)
        Me.id = id

    End Sub

    ' método toString()
    Public Overrides Function ToString() As String
        Return "nombreUsuario: " & Me.nombreUsuario & ", ID: " & Me.id.ToString
    End Function

End Class
