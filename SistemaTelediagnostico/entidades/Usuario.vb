Public Class Usuario

    'nombre de usuario identificatorio de la cuenta
    Public Property nombreUsuario As String
    Public Shared nombreus As String
    ' datos personales:
    Public Property cedula As String
    Public Property nombre1 As String
    Public Property nombre2 As String
    Public Property apellido1 As String
    Public Property apellido2 As String
    Public Property fechaNacimiento As Date
    'datos de contacto y dirección:
    Public Property correo As String
    Public Property calle As String
    Public Property numeroPuerta As Integer
    Public Property ciudad As String    ' se obtiene haciendo consulta a la tabla ciudad, con el idCiudad.

    Public Sub New()
    End Sub

    Public Sub New(nombreUsuario As String, cedula As String, nombre1 As String, nombre2 As String, apellido1 As String,
                   apellido2 As String, fechaNacimiento As Date, correo As String, calle As String, numeroPuerta As Integer,
                   ciudad As String)
        Me.nombreUsuario = nombreUsuario
        Me.cedula = cedula
        Me.nombre1 = nombre1
        Me.nombre2 = nombre2
        Me.apellido1 = apellido1
        Me.apellido2 = apellido2
        Me.fechaNacimiento = fechaNacimiento
        Me.correo = correo
        Me.calle = calle
        Me.numeroPuerta = numeroPuerta
        Me.ciudad = ciudad
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

End Class
