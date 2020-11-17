Imports entidades
Imports logica

Public Class FormChatPaciente

    Private Sub FormChatPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TimerNuevosMensajes.Start()
            ' cargamos datos del medico del chat en el label
            Dim medico As Medicos = ControladorPaciente.instancia.salaChat_SesionPaciente.medicoSala
            lblInfoSesion.Text = "Sesion de chat con " & medico.especialidad & " " & medico.nombre1 & " " & medico.apellido1

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Se produjo un error")
        End Try
    End Sub

    Private Sub btnEnviarMensaje_Click(sender As Object, e As EventArgs)
        Try
            If txtMensaje.Text.Length = 0 Then  ' si no ingresa texto no hay mensaje que enviar
                MsgBox("Debe escribir un mensaje", vbExclamation, "Mensaje sin redactar.")
            Else
                ControladorPaciente.instancia.enviarMensaje(txtMensaje.Text)
                Dim fecha As Date = Date.Now
                richTxtChat.Text += ("Yo (" & fecha.ToShortTimeString & ") >> " & txtMensaje.Text & vbCrLf)

                txtMensaje.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Se saldrá de la sesión de chat.", vbCritical, "Se produjo un error.")
        End Try
    End Sub

    Private Sub TimerNuevosMensajes_Tick(sender As Object, e As EventArgs) Handles TimerNuevosMensajes.Tick
        ' evento del timer para agregar nuevos mensajes al richTxt en caso de haber nuevo mensajes

        Try
            If ControladorPaciente.instancia.hayNuevosMensajes() Then
                richTxtChat.Text = ""

                For Each mensaje As Mensaje In ControladorPaciente.instancia.listaMensajes_Paciente()

                    richTxtChat.Text += ("" & mensaje.usuarioEmisor.nombre1 & "(" & mensaje.fecha_Hora_mensaje.ToShortTimeString & ") >> " & mensaje.textoMensaje & vbCrLf)

                Next
            End If
        Catch ex As Exception
            MsgBox("Se produjo un error", vbCritical, "Error al recibir mensajes")
        End Try

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSal_Click(sender As Object, e As EventArgs) Handles btnSal.Click
        If MsgBox("¿Desea finalizar la Sala de chat?", vbQuestion +
                  vbYesNo, "Confirme su salida") = MsgBoxResult.Yes Then
            Me.Hide()
            Dim s As String
            s = richTxtChat.Text
            ControladorPaciente.instancia.enviarChat(s)
        End If
    End Sub

    Private Sub btnEnviarMensaje_Click_1(sender As Object, e As EventArgs) Handles btnEnviarMensaje.Click
        Try
            If txtMensaje.Text.Length = 0 Then  ' si no ingresa texto no hay mensaje que enviar
                MsgBox("Debe escribir un mensaje", vbExclamation, "Mensaje sin redactar.")
            Else
                ControladorPaciente.instancia.enviarMensaje(txtMensaje.Text)

                Dim fecha As Date = Date.Now
                richTxtChat.Text += ("Yo (" & fecha.ToShortTimeString & ") >> " & txtMensaje.Text & vbCrLf)
                txtMensaje.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Se produjo un error al enviar el mensaje")
        End Try
    End Sub
End Class
