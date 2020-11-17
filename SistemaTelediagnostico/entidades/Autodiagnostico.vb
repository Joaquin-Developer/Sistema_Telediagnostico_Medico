Public Class Autodiagnostico

    Public Property id As Integer
    Public Property paciente As Pacientes
    Public Property esUrgente As Boolean
    Public Property fecha As Date
    Public Property listaPatologias As List(Of Patologia)    ' -- modificar por Map(x,y)
    Public Property listaSintomas As List(Of Sintoma)

    Public Sub New()    ' const. vacio
    End Sub

    Public Sub New(id As Integer, paciente As Pacientes, esUrgente As Boolean, fecha As Date,
                   listaSintomas As List(Of Sintoma), listaPatologias As List(Of Patologia))
        Me.id = id
        Me.paciente = paciente
        Me.esUrgente = esUrgente
        Me.fecha = fecha
        Me.listaPatologias = listaPatologias
        Me.listaSintomas = listaSintomas
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

End Class
