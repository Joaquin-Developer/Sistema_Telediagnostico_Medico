Imports System.Runtime.InteropServices
Imports entidades
Imports logica

Public Class FormPrincipalMedico

    Public Shared Property peticion As New FormPrincipalMedico()

    Private Sub FormPrincipalMedico_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            ' al cargar el formulario lenamos el dataGridView
            cargarDataGridView()
            timerActualizarPeticiones.Start()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error al cargar datos en el Formulario")
        End Try
    End Sub


    Private Sub cargarDataGridView()
        ' mostrar en DGV: idSala, nombre y apellido de paciente (concatenados), nombreUsuario de paciente, prioridad
        Try
            Dim dataSet As New DataSet()
            Dim dataTable As DataTable = dataSet.Tables.Add()
            dataTable.Columns.Add("ID")
            dataTable.Columns.Add("PACIENTE")
            dataTable.Columns.Add("USUARIO")
            dataTable.Columns.Add("PRIORIDAD")

            Dim lista As New List(Of SalaChat)
            lista = ControladorMedico.instancia.obtenerSolicitudesChat()

            For Each sala As SalaChat In lista
                dataTable.Rows.Add(sala.idSala.ToString, (sala.pacienteSala.nombre1 & " " & sala.pacienteSala.apellido1),
                                   sala.pacienteSala.nombreUsuario, sala.prioridad)
            Next
            dgViewPeticiones.DataSource = dataTable
            dgViewPeticiones.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Se produjo un error al intentar cargar las solicitudes en la tabla.")
        End Try
    End Sub

    Private Sub timerActualizarPeticiones_Tick(sender As Object, e As EventArgs) Handles timerActualizarPeticiones.Tick
        ' debemos ir actualizando la lista de peticiones, en caso de que cambie.
        cargarDataGridView()
    End Sub

    Private Sub btnIniciarChat_Click(sender As Object, e As EventArgs) Handles btnIniciarChat.Click
        Try
            ControladorMedico.instancia.aceptarSolicitudChat(txtID.Text)
            ' luego de "aceptar solicitud de chat, abrimos formulario de chat"
            Dim formChat As FormChatMedico = New FormChatMedico()
            formChat.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
            MsgBox(ex.StackTrace)

        End Try
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
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
            ControladorMedico.instancia.listaMensajes_Sesion.Clear()
            ControladorMedico.instancia.salaChat_Sesion = Nothing
            ControladorMedico.instancia.usuario_Sesion = Nothing
            Dim Form As New LoginMedico
            Form.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub btnCerrarS_Paint(sender As Object, e As PaintEventArgs) Handles btnCerrarS.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnCerrarS.ClientRectangle
        myRectangle.Inflate(0, 0)
        buttonPath.AddEllipse(myRectangle)
        btnCerrarS.Region = New Region(buttonPath)
    End Sub

    Private Sub panelBarraT_MouseMove(sender As Object, e As MouseEventArgs) Handles panelBarraT.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class
