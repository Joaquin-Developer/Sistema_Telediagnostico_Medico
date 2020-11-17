Imports entidades
Imports logica
Imports persistencia
Imports System.Runtime.InteropServices
Public Class AppPaci

    Private bd As New ControladorBD
    Private Property autoDiagnostico As New Autodiagnostico     ' autoDiagnostico que se genere

    Private Sub AppPaci_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Traductor.TraducirForm(Me)
            Traductor.TraducirPanel(panelMenu)
            Traductor.TraducirPanel(Panel1)
            Traductor.TraducirPanel(Panel2)
            Traductor.TraducirPanel(Panel3)
            ' obtenemos la lista de sintomas de la logica
            Dim listaSintomas As List(Of Sintoma) = ControladorPaciente.instancia.cargarSintomas()
            For Each sint As Sintoma In listaSintomas
                checkdiag.Items.Add(sint.nombre)
            Next
            Me.Panel3.Visible = False
            Me.btnchat.Visible = False
            Me.btnchat.Enabled = True

        Catch ex As Exception
            ' NOTA: mejorar el manejo de las exepciones aquí
            MsgBox(ex.Message & vbCrLf & "Se reiniciará la aplicación", vbCritical, "Se produjo un error.")
            'Me.
            Application.Restart()

        End Try
        'btnchat.Hide()
    End Sub



    Private Sub timerNotificarChatAceptado_Tick(sender As Object, e As EventArgs) Handles timerNotificarChatAceptado.Tick
        Try
            If ControladorPaciente.instancia.verificacionChatAceptado() Then

                timerNotificarChatAceptado.Stop()

                Dim nombreMedico As String = ControladorPaciente.instancia.salaChat_SesionPaciente.medicoSala.nombre1 &
                    " " & ControladorPaciente.instancia.salaChat_SesionPaciente.medicoSala.apellido1

                If MsgBox("El Médico " & nombreMedico & " aceptó tu solicitúd de chat" & vbCrLf & "¿Desea iniciar la sesión de chat ahora?",
                       vbInformation + vbYesNo, "Solicitud de chat aceptada") = MsgBoxResult.Yes Then

                    Dim form As FormChatPaciente = New FormChatPaciente()
                    form.ShowDialog()
                End If

            End If
        Catch ex As Exception
            timerNotificarChatAceptado.Stop()
            MsgBox(ex.Message & vbCrLf & ex.StackTrace & vbCrLf & ex.ToString, vbCritical, "Error al verificar si la solicitud fue aceptada")
        End Try
    End Sub



    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If panelMenu.Width = 220 Then
            tmOcultar.Enabled = True
        ElseIf panelMenu.Width = 80 Then
            tmMostrar.Enabled = True
        End If
    End Sub
    Private Sub tmOcultar_Tick(sender As Object, e As EventArgs) Handles tmOcultar.Tick
        If panelMenu.Width <= 80 Then
            Me.tmOcultar.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width - 5
        End If
    End Sub

    Private Sub tmMostrar_Tick(sender As Object, e As EventArgs) Handles tmMostrar.Tick
        If panelMenu.Width >= 220 Then
            Me.tmMostrar.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width + 5
        End If
    End Sub

    Private Sub btnCerrarS_Click(sender As Object, e As EventArgs) Handles btnCerrarS.Click
        If MsgBox("¿Esta seguro que desea cerrar su sesión?", vbQuestion + vbYesNo, "Cerrar Sesión") = MsgBoxResult.Yes Then
            ControladorPaciente.instancia.listaMensajes_Paciente.Clear()
            ControladorPaciente.instancia.salaChat_SesionPaciente = Nothing
            ControladorPaciente.instancia.usuario_SesionPaciente = Nothing
            Dim form As New LoginPaci()
            form.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub btnCerrarS_Paint(sender As Object, e As PaintEventArgs)
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnCerrarS.ClientRectangle
        myRectangle.Inflate(0, 0)
        buttonPath.AddEllipse(myRectangle)
        btnCerrarS.Region = New Region(buttonPath)
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        btnMax.Visible = False
        btnres.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub btnres_Click(sender As Object, e As EventArgs) Handles btnres.Click
        Me.WindowState = FormWindowState.Normal
        btnres.Visible = False
        btnMax.Visible = True
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

    Private Sub btndiag_Click(sender As Object, e As EventArgs) Handles btndiag.Click
        ListBox1.Items.Clear()
        'Dim r As String
        'Dim esa As List(Of String)
        Dim i As Integer
        Dim lista As New List(Of Sintoma)
        For i = 0 To Me.checkdiag.CheckedItems.Count - 1
            Dim sint As New Sintoma
            sint.nombre = checkdiag.CheckedItems(i)
            lista.Add(sint)

        Next
        Dim list As List(Of Patologia)
        list = ControladorPaciente.instancia.listaPat(lista)

        Dim a As List(Of String)
        a = ControladorPaciente.instancia.Diag(lista, list)
        For Each s As String In a
            Dim MiArry() As String

            ReDim MiArry(ListBox1.Items.Count - 1)

            ListBox1.Items.CopyTo(MiArry, 0)
            For Each t As String In MiArry
                If s = t Then
                    ListBox1.Items.Remove(s)
                End If
            Next
            ListBox1.Items.Add(s)

        Next

        btnchat.Show()
        Panel3.Show()

        'Desmarca a los items checkeados luego de utilizar el boton
        Dim n As Integer
        For n = 0 To checkdiag.Items.Count - 1
            checkdiag.SetItemChecked(n, False)
        Next
        Dim MiArray() As String

        ReDim MiArray(ListBox1.Items.Count - 1)

        ListBox1.Items.CopyTo(MiArray, 0)
        ControladorPaciente.instancia.enviarDiagnostico(MiArray, list)
        ControladorPaciente.instancia.GuardarAutoDiagnostico(list, lista)
    End Sub

    Private Sub btnchat_Click(sender As Object, e As EventArgs) Handles btnchat.Click
        If MsgBox("¿Desea soliciatr un Chat con algun mèdico disponible?", vbQuestion + vbYesNo, "Mensaje") = MsgBoxResult.Yes Then
            ' usuario acepta solicitar un chat:
            Try
                ControladorPaciente.instancia.solicitarChat()
                MsgBox("Se le notificará cuando un médico acepte su solicitúd de chat.", vbInformation, "Chat solicitado correctamente.")
                timerNotificarChatAceptado.Start()  ' se inicia el Timer una vez solicitado el Chat.
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error al solicitar un chat")
            End Try

        End If
    End Sub
End Class
