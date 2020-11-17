Public Class SalaChat

    Public Property idSala As Integer
    Public Property prioridad As String
    Public Property pacienteSala As Pacientes
    Public Property medicoSala As Medicos

    Public Sub New()
    End Sub

    Public Sub New(idSala As Integer, prioridad As String, pacienteSala As Pacientes, medicoSala As Medicos)
        Me.idSala = idSala
        Me.prioridad = prioridad
        Me.pacienteSala = pacienteSala
        Me.medicoSala = medicoSala
    End Sub

    Public Overrides Function ToString() As String
        Return "Id = " & Me.idSala & ", prioridad: " & Me.prioridad & ", paciente: " & Me.pacienteSala.nombreUsuario &
            ", medico: " & Me.medicoSala.nombreUsuario
    End Function

End Class
