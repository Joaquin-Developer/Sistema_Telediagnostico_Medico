Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports entidades
Imports logica
Imports persistencia

<TestClass()> Public Class TestPersistencia

    Private controlador As New ControladorBD()

    '<TestMethod()> Public Sub TestMethod1()
    'End Sub

    ''' <summary>
    ''' NOTA: PROBAR ESTA FUNCION CONTRA LA BASE DE DATOS
    ''' PARA VERIFICAR QUE LOS UPDATE ESTEN FUNCIONANDO CORRECTAMENTE
    ''' </summary>
    '<TestMethod()> Public Sub PruebaUpdateMedico()

    '    Dim hayExepciones As Boolean = False
    '    Dim medico, nuevoMedico As New Medicos
    '    Try

    '        medico.nombreUsuario = "pepe123"    ' cambiar por un dato real de la Bd

    '        controlador.ModificarMedico(medico)
    '        nuevoMedico = controlador.obtenerMedicoPorNombreUsuario("pepe123")

    '        If IsNothing(nuevoMedico) Then Throw New Exception("Objeto nulo")

    '    Catch ex As Exception
    '        hayExepciones = True
    '    End Try

    '    Assert.AreEqual(True, hayExepciones)
    '    Assert.AreEqual(medico.nombreUsuario, nuevoMedico.nombreUsuario)

    'End Sub

    '<TestMethod()> Public Sub PruebaSelectPacientes()
    '    Dim hayErrores As Boolean = False
    '    Try
    '        Dim paciente As New Pacientes
    '        paciente = controlador.obtenerPacientePorNombreUsuario("ferpais")
    '        Dim datos As String

    '        datos = "nombre: " & paciente.nombreUsuario & vbCrLf &
    '            "n1: " & paciente.nombre1 & vbCrLf &
    '            "n2: " & paciente.nombre2 & vbCrLf &
    '            "a1: " & paciente.apellido1 & vbCrLf &
    '            "a2: " & paciente.apellido2 & vbCrLf &
    '            "cedula: " & paciente.cedula & vbCrLf &
    '            "correo: " & paciente.correo & vbCrLf &
    '            "fecha nac.: " & paciente.fechaNacimiento & vbCrLf &
    '            "calle:" & paciente.calle & vbCrLf &
    '            "nro: " & paciente.numeroPuerta & vbCrLf &
    '            "pin: " & paciente.pin & vbCrLf &
    '            "peso: " & paciente.peso & vbCrLf &
    '            "sexo: " & paciente.sexo & vbCrLf &
    '            "altura: " & paciente.altura

    '        MsgBox(datos)
    '        Assert.AreEqual(False, hayErrores)

    '    Catch ex As Exception
    '        hayErrores = True
    '        MsgBox("Error: " & ex.Message & vbCrLf & ex.StackTrace)
    '    End Try

    'End Sub



End Class