Imports entidades
Imports persistencia

Public Class ControladorMedico

    Public Shared Property instancia As New ControladorMedico     ' variable estática (patron de diseño singleton)
    Public Property listaMensajes_Sesion As New List(Of Mensaje)
    Public Property usuario_Sesion As New Medicos
    Public Property salaChat_Sesion As New SalaChat
    Private controladorBD As New ControladorBD()         ' instancia de controladorBD
    Public resultados As Integer

    Private Sub New()   ' unicamente accedido por esta clase, para inicializar el objeto "instancia"
    End Sub

    Public Sub LoginMedico(nombreUsuario As String, passw As String)

        Dim errores As String = ""

        If nombreUsuario.Length = 0 Or passw.Length = 0 Or nombreUsuario.Equals("USUARIO") Or passw.Equals("CONTRASEÑA") Or nombreUsuario.Equals("USER") Or passw.Equals("PASSWORD") Then
            If nombreUsuario.Length = 0 Then errores += ("Debe ingresar un nombre de usuario" & vbCrLf)
            If passw.Length = 0 Then errores += ("Debe ingresar una contraseña" & vbCrLf)
        End If

        Dim medicoEncontrado As New List(Of Medicos)
        medicoEncontrado = controladorBD.obtenerMedicoPorNombreUsuarios(nombreUsuario)

        Dim medico As New Medicos

        For Each med As Medicos In medicoEncontrado
            If med.nombreUsuario = nombreUsuario Or med.contraseña = passw Then
                medico = med
                Exit For
            End If

        Next


        If medico.nombreUsuario = Nothing Then
            Throw New Exception("Usuarios y/o claves incorrectas ")
        End If

        ' si la cadena errores tiene texto, entonces genero una exepcion
        If errores.Length > 0 Then Throw New Exception(errores)

        Me.usuario_Sesion = medico


    End Sub

    ' ############################ Funciones de Chat #######################################

    Public Sub enviarMensaje(textoMensaje As String)
        Try
            Dim mensaje As New Mensaje()
            mensaje.textoMensaje = textoMensaje
            mensaje.usuarioEmisor = usuario_Sesion
            Dim fecha As Date = Date.Now
            mensaje.fecha_Hora_mensaje = fecha

            mensaje.idMensaje = controladorBD.ObtenerUltimoIdMensajeGeneral + 1

            controladorBD.guardarMensaje(mensaje, Me.salaChat_Sesion.idSala)
            listaMensajes_Sesion.Add(mensaje)

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
            ' en la capa presentacion se muestra el msgBox
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
            Dim ultimoIndex As Integer = controladorBD.ObtenerUltimoIdMensajeDeChat(Me.salaChat_Sesion.idSala)

            ' si el index es nothing significa que no hay mensajes en esta salaChat:  (no hacemos nada y retornamos false)
            If ultimoIndex <> Nothing Then
                ' si no es nulo, pero la listaMensajes de mensajes es vacia, cargamos todos los mensajes
                mensajesNuevos = True

                If Me.listaMensajes_Sesion.Count = 0 Then
                    Me.listaMensajes_Sesion = controladorBD.obtenerMensajes(-1, Me.salaChat_Sesion.idSala)
                Else
                    ' si la lista no es vacia, solo cargamos los nuevos mensajes:
                    Dim nuevosMensajes As New List(Of Mensaje)
                    Console.WriteLine(Me.listaMensajes_Sesion.Last.idMensaje)
                    nuevosMensajes = controladorBD.obtenerMensajes(Me.listaMensajes_Sesion.Last.idMensaje, Me.salaChat_Sesion.idSala)

                    For Each mensaje As Mensaje In nuevosMensajes
                        mensaje.usuarioEmisor = controladorBD.obtenerUsuarioPorNombreUsuarios(mensaje.usuarioEmisor.nombreUsuario)
                        Me.listaMensajes_Sesion.Add(mensaje)
                    Next

                End If

            End If

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try

        Return mensajesNuevos

    End Function

    ' ######################### fin de funciones de Chat ###################################

    Public Sub aceptarSolicitudChat(idSalaChat As String)
        If idSalaChat.Length = 0 Then Throw New Exception("Debe seleccionar un Id de Chat.")

        If Me.usuario_Sesion.nombreUsuario.Length = 0 Then
            Throw New Exception("Error Fatal: No se pudo obtener los datos del usuario actual")
        End If
        Dim sala As New SalaChat
        sala = controladorBD.aceptarSolicitudChat(idSalaChat, usuario_Sesion.nombreUsuario)

        Me.salaChat_Sesion.idSala = sala.idSala
        Me.salaChat_Sesion.medicoSala = Me.usuario_Sesion
        Me.salaChat_Sesion.pacienteSala = sala.pacienteSala
        Me.salaChat_Sesion.prioridad = sala.prioridad

    End Sub

    Public Function obtenerSolicitudesChat() As List(Of SalaChat)
        Return controladorBD.ObtenerSolicitudesChat()
    End Function

End Class
