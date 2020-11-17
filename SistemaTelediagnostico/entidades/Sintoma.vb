Public Class Sintoma

    Public Property nombre As String
    Public Property descripcion As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, descripcion As String)
        Me.nombre = nombre
        Me.descripcion = descripcion
    End Sub

    Public Overrides Function ToString() As String
        Return "Nombre sintoma: " & nombre & ", descripcion: " & descripcion
    End Function

End Class
