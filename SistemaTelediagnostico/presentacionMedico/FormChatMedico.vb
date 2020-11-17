Imports entidades
Imports logica
Imports System.Runtime.InteropServices

Public Class FormChatMedico

    Private Sub FormChatMedico_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Traductor.TraducirForm(Me)

            TimerNuevosMensajes.Start()
            ' cargamos datos del medico del chat en el label
            Dim paciente As Pacientes = ControladorMedico.instancia.salaChat_Sesion.pacienteSala

            lblInfoSesion.Text = "Sesion de Chat con el paciente: " & paciente.nombre1 & " " & paciente.apellido1
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Se produjo un error al intentar obtener datos del chat.")
            Me.Hide()
        End Try
    End Sub

    Private Sub TimerNuevosMensajes_Tick(sender As Object, e As EventArgs) Handles TimerNuevosMensajes.Tick
        Try
            If ControladorMedico.instancia.hayNuevosMensajes() Then
                ' solo haremos la acción en caso de haber nuevos mensajes.
                richTxtChat.Text = ""

                For Each mensaje As Mensaje In ControladorMedico.instancia.listaMensajes_Sesion()


                    richTxtChat.Text += ("" + mensaje.usuarioEmisor.nombreUsuario & " (" & mensaje.fecha_Hora_mensaje.ToShortTimeString & ") >> " & mensaje.textoMensaje & vbCrLf)
                Next
            End If
        Catch ex As Exception
            TimerNuevosMensajes.Stop()
            MsgBox(ex.ToString & vbCrLf & ex.StackTrace)
            MsgBox("Se produjo un error" & vbCrLf & "Se abandonarà el Chat", vbCritical, "Error al recibir mensajes")
            Me.Hide()
        End Try

    End Sub

    Private Sub btnEnviarMensaje_Click(sender As Object, e As EventArgs) Handles btnEnviarMensaje.Click
        Try
            If txtMensaje.Text.Length = 0 Then  ' si no ingresa texto no hay mensaje que enviar
                MsgBox("Debe escribir un mensaje", vbExclamation, "Mensaje sin redactar.")
            Else
                ControladorMedico.instancia.enviarMensaje(txtMensaje.Text)

                Dim fecha As Date = Date.Now
                richTxtChat.Text += ("Yo (" & fecha.ToShortTimeString & ") >> " & txtMensaje.Text & vbCrLf)
                txtMensaje.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Se produjo un error al enviar el mensaje")
        End Try
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelBarraT_MouseMove(sender As Object, e As MouseEventArgs) Handles panelBarraT.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnSal_Click(sender As Object, e As EventArgs) Handles btnSal.Click
        If MsgBox("¿Desea finalizar la Sala de chat?", vbQuestion +
                  vbYesNo, "Confirme su salida") = MsgBoxResult.Yes Then
            Me.Hide()
        End If
    End Sub

End Class
