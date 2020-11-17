Public Class Medicos
    Inherits Usuario

    Public Property especialidad As String
    Public Property contraseña As String
    Public Property sexo As Char

    Public Sub New()    ' constructor vacío
    End Sub

    Public Sub New(especialidad As String, contraseña As String)    ' constructor 
        Me.especialidad = especialidad
        Me.contraseña = contraseña
    End Sub

    Public Overrides Function ToString() As String
        'Return "NombreUsuario: " & nombreUsuario & ", especialidad: " & especialidad
        Return Nothing
    End Function

End Class
