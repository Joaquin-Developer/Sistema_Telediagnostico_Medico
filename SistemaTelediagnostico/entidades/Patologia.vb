Public Class Patologia

    Public Property nombre As String
    Public Property descripcion As String
    Public Property recomendaciones As String
    Public Property esMortal As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, descripcion As String, recomendaciones As String, esMortal As Boolean)
        Me.nombre = nombre
        Me.descripcion = descripcion
        Me.recomendaciones = recomendaciones
        Me.esMortal = esMortal
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

End Class
