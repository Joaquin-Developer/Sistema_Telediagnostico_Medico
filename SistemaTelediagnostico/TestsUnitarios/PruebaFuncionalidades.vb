Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports entidades
Imports logica
Imports persistencia

<TestClass()>
Public Class PruebaFuncionalidades
    Private controlador As New ControladorBD()

    '<TestMethod()>
    'Public Sub TestMethod1()
    'End Sub

    '<TestMethod()>
    'Public Sub PruebaStringFechas()
    '    Dim fecha As Date = Date.Now()
    '    MsgBox(fecha.Day & "/" & fecha.Month & "/" & fecha.Year)    ' salida de ej: 30/10/2020
    '    MsgBox(fecha.ToShortTimeString)     ' salida de ej: 10:30
    'End Sub

    <TestMethod()>
    Public Sub Test_ControladorAdministrador_CargarPatologiasDesdeCsv()
        Try
            Dim lista As New List(Of Patologia)
            lista = ControladorAdministrador.instancia.CargarPatologiasDesdeCsv("C:\Users\alumno\Desktop\Nuevo documento de texto.txt")

            Dim lineas As String = ""
            For Each patologia As Patologia In lista
                lineas += (patologia.nombre & ":" & patologia.descripcion & ":" & patologia.recomendaciones & ":" & patologia.esMortal.ToString & vbCrLf)
                ' lineas += (patologia.ToString & vbCrLf)
            Next

            If lineas.Length > 0 Then
                MsgBox(lineas, vbEmpty, "Se leyeron las siguientes patologìas")

                If MsgBox("¿Desea ingresarlas al sistema?", vbQuestion + vbYesNo, "Confirmar ingreso") = MsgBoxResult.Yes Then
                    MsgBox("llamar a la funcion de controladorBD")
                End If

            Else
                Throw New NullReferenceException("No se pudo obtener ningun dato del archivo CSV")
            End If

        Catch ex As NullReferenceException
            MsgBox(ex.Message, vbExclamation, "Sin datos para cargar")
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try

    End Sub

    <TestMethod()> Public Sub Test_ControladorPaciente_VerificarChatAceptado()
        Try
            ' probamos con el idSala = 1

            'Dim medico As Medicos = controlador.verificarChatAceptado(1)
            ControladorPaciente.instancia.salaChat_SesionPaciente.idSala = 1
            Dim chatAceptado As Boolean = ControladorPaciente.instancia.verificacionChatAceptado

            If ControladorPaciente.instancia.verificacionChatAceptado() Then
                MsgBox("chat aceptado")
            Else
                MsgBox("CHAT No aceptado")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    <TestMethod()> Public Sub Test_ControladorBD_ObtenerUltimoIdMensajeDeChat()
        Try
            Dim ultId As Integer = controlador.ObtenerUltimoIdMensajeDeChat(59)
            If ultId <> Nothing Then
                MsgBox(ultId)
            Else
                MsgBox("dato nulo")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString & vbCrLf & ex.StackTrace, vbCritical, ex.Message)
        End Try
    End Sub

    <TestMethod()> Public Sub Test_PruebaDate()

        'Dim hora As String() = ("16:30:00").Split(":")
        'Dim fecha As String() = ("2020-10-10").Split("-")

        'Dim datetime As New Date(fecha(0), fecha(1), fecha(2), hora(0), hora(1), hora(2))

        'MsgBox(datetime.ToShortTimeString & " - " & datetime.ToShortDateString)
        Try
            Dim lista As New List(Of Mensaje)
            lista = controlador.obtenerMensajes(0, 1)
            MsgBox(lista.Count)
            MsgBox(lista.Item(0).fecha_Hora_mensaje.ToShortDateString & " - " & lista.Item(0).fecha_Hora_mensaje.ToShortTimeString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub



End Class
