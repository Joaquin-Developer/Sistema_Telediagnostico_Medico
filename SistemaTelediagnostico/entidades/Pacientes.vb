Public Class Pacientes
    Inherits Usuario

    Public Property pin As Integer   ' contraseña de Paciente
    Public Property peso As Double
    Public Property sexo As String
    Public Property altura As Double

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(pin As Integer, peso As Double, sexo As String, altura As Double)
        MyBase.New()
        Me.pin = pin
        Me.peso = peso
        Me.sexo = sexo
        Me.altura = altura
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString
        'Return "Nombre Usuario: " & Me.nombreUsuario & ", peso: " & Me.peso.ToString &   ", sexo: " & Me.sexo.ToString & ", altura: " & Me.altura.ToString
    End Function

End Class
