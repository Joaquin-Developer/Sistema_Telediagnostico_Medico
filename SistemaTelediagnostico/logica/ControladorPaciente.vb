Imports entidades
Imports persistencia
Imports System.Net.Mail
Public Class ControladorPaciente

    Public Shared Property instancia As New ControladorPaciente     ' variable estática (patron de diseño singleton) <>
    Public Property listaMensajes_Paciente As New List(Of Mensaje)
    Public Property usuario_SesionPaciente As New Pacientes
    Public Property salaChat_SesionPaciente As New SalaChat
    Private controladorBD As New ControladorBD()         ' instancia de controladorBD
    Public resultado As Integer

    Private Sub New() ' unicamente accedido por esta clase, para inicializar el objeto "instancia"
    End Sub
    Public Function Diag(sintomas, patologias) As List(Of String)
        Dim s As List(Of String)
        s = controladorBD.Diag(sintomas, patologias)
        Return s
    End Function
    Public Function listaPat(sint) As List(Of Patologia)
        Dim list As List(Of Patologia)
        list = controladorBD.listaPat(sint)
        Return list
    End Function
    Public Function cargarSintomas() As List(Of Sintoma)
        Dim lista As New List(Of Sintoma)
        lista = controladorBD.cargarSintoma()

        Return lista
    End Function

    Public Sub LoginPaciente(nombreUsuario As String, pin As String)
        Dim errores As String = ""

        If nombreUsuario.Length = 0 Or pin.Length = 0 Or nombreUsuario.Equals("USUARIO") Or pin.Equals("CONTRASEÑA") Then
            If nombreUsuario.Length = 0 Or nombreUsuario.Equals("USUARIO") Then errores += ("Debe ingresar un nombre de usuario" & vbCrLf)
            If pin.Length = 0 Or pin.Equals("CONTRASEÑA") Then errores += ("Debe ingresar una contraseña" & vbCrLf)
        End If
        If errores.Length <> 0 Then Throw New Exception(errores)

        Dim pinUsuario As Integer
        If Not Integer.TryParse(pin, pinUsuario) Then
            errores += ("La contraseña debe contener unicamente numeros" & vbCrLf)
        Else
            pinUsuario = CInt(pin)
        End If
        If errores.Length <> 0 Then Throw New Exception(errores)

        Dim pacienteEncontrado As Pacientes = controladorBD.obtenerPacientePorNombreUsuario(nombreUsuario)

        If pacienteEncontrado.nombreUsuario <> nombreUsuario Or pacienteEncontrado.pin <> pinUsuario Then
            ' si no se enuentra usuario, hubo error de login
            Throw New Exception("Usuarios y/o claves incorrectas ")
        End If

        ' si la cadena errores tiene texto, entonces genero una exepcion
        If errores.Length <> 0 Then Throw New Exception(errores)

        'esto se ejecutara si no hubiueron errores:
        Me.usuario_SesionPaciente = pacienteEncontrado

    End Sub

    Public Sub enviarMensaje(textoMensaje As String)
        Try
            Dim mensaje As New Mensaje()
            mensaje.textoMensaje = textoMensaje
            mensaje.usuarioEmisor = usuario_SesionPaciente
            Dim fecha As Date = Date.Now()
            mensaje.fecha_Hora_mensaje = fecha

            mensaje.idMensaje = controladorBD.ObtenerUltimoIdMensajeGeneral + 1

            controladorBD.guardarMensaje(mensaje, Me.salaChat_SesionPaciente.idSala)
            listaMensajes_Paciente.Add(mensaje)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        End Try
    End Sub

    Public Function obtenerNuevosMensajes(ultimoId As Integer, salaChat As SalaChat) As List(Of Mensaje)
        If IsNothing(ultimoId) Or IsNothing(salaChat) Then Throw New Exception("Datos incompletos.")

        Return controladorBD.obtenerMensajes(ultimoId, salaChat.idSala)
    End Function

    Public Function hayNuevosMensajes() As Boolean
        ' funcion que retorna true en caso de haber nuevos mensajes en la BD
        ' recibe una lista con los nuevos mensajes de la persistencia
        ' y agrega cada objeto a la listaMensajes de ControladorPaciente
        ' esta funcion se deberà llamar desde la capa presenacion
        Dim mensajesNuevos As Boolean = False
        Try
            Dim ultimoIndex As Integer = controladorBD.ObtenerUltimoIdMensajeDeChat(Me.salaChat_SesionPaciente.idSala)

            ' si el index es nothing significa que no hay mensajes en esta salaChat :
            If ultimoIndex <> Nothing Then
                ' si no es nulo, pero la listaMesajes de mensajes es vacia, cargamos todos los mensajes
                mensajesNuevos = True

                If Me.listaMensajes_Paciente.Count = 0 Then
                    Me.listaMensajes_Paciente = controladorBD.obtenerMensajes(-1, Me.salaChat_SesionPaciente.idSala)
                Else
                    ' si la lista no es vacia, solo cargamos los nuevos mensajes
                    Dim nuevosMensajes As New List(Of Mensaje)
                    nuevosMensajes = controladorBD.obtenerMensajes(Me.listaMensajes_Paciente.Last.idMensaje, Me.salaChat_SesionPaciente.idSala)

                    For Each mensaje As Mensaje In nuevosMensajes
                        mensaje.usuarioEmisor = controladorBD.obtenerUsuarioPorNombreUsuarios(mensaje.usuarioEmisor.nombreUsuario)
                        Me.listaMensajes_Paciente.Add(mensaje)
                    Next

                End If
            End If

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try

        Return mensajesNuevos

    End Function

    Public Sub solicitarChat()
        Try
            salaChat_SesionPaciente = controladorBD.solicitarChat(usuario_SesionPaciente.nombreUsuario, "Alta")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw ex
        End Try
    End Sub

    Public Function verificacionChatAceptado() As Boolean
        Dim chatAceptado As Boolean = False
        Try
            Dim medico As New List(Of Medicos)
            medico = controladorBD.verificarChatAceptado(Me.salaChat_SesionPaciente.idSala)

            For Each med As Medicos In medico
                If med.nombreUsuario.Length > 0 Then
                    chatAceptado = True
                    Dim usuario As Medicos = controladorBD.obtenerMedicoPorNombreUsuario(med.nombreUsuario)
                    salaChat_SesionPaciente.medicoSala = usuario
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw ex
        End Try

        Return chatAceptado
    End Function
    Public Sub enviarDiagnostico(pat, list)
        Dim bd As New ControladorBD
        Dim listita As New List(Of Patologia)
        Try
            Dim s As String
            Dim n As String
            s = bd.buscarmail
            listita = bd.buscarRecomendacion(list)
            Dim a As String
            For Each r As String In pat
                a += r + "<br>"
            Next
            For Each w As Patologia In listita
                n += w.nombre + ":" + w.recomendaciones + "<br>"
            Next
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("techvibe25@gmail.com", "holabrothers")
            Smtp_Server.Port = 25
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"


            e_mail = New MailMessage
            e_mail.From = New MailAddress("techvibe25@gmail.com")
            e_mail.To.Add(s) 'correo destino
            e_mail.Subject = "Diagnostico"
            e_mail.IsBodyHtml = True
            e_mail.Body = a + "<br>" + "Recomendaciones:" + "<br>" + n
            Smtp_Server.Timeout = 999999999
            Smtp_Server.Send(e_mail)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error al enviar Diagnostico")
        End Try


    End Sub
    Public Sub enviarChat(chat As String)
        Dim bd As New ControladorBD
        Dim s As String
        s = bd.buscarmail
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage
        Try
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("techvibe25@gmail.com", "holabrothers")
            Smtp_Server.Port = 25
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"


            e_mail = New MailMessage
            e_mail.From = New MailAddress("techvibe25@gmail.com")
            e_mail.To.Add(s) 'correo destino
            e_mail.Subject = "Chat"
            e_mail.IsBodyHtml = True
            e_mail.Body = chat
            Smtp_Server.Timeout = 999999999
            Smtp_Server.Send(e_mail)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error al enviar Chat")
        End Try

    End Sub
    Public Sub GuardarAutoDiagnostico(list, lista)
        controladorBD.GuardarAutoDiagnostico(list, lista)
    End Sub

End Class
