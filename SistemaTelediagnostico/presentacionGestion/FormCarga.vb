Imports logica
Imports entidades
Imports persistencia
Public Class FormCarga
    Private Sub tmA_Tick(sender As Object, e As EventArgs) Handles tmA.Tick
        pgrB.Text = pgrB.Value.ToString()
        pgrB.Value += 1
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If

        If pgrB.Value = 100 Then
            tmA.Stop()
            tmD.Start()
        End If
    End Sub

    Private Sub tmDTick(sender As Object, e As EventArgs) Handles tmD.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            tmD.Stop()
            Me.Hide()
            Dim form As AppGestion = New AppGestion
            form.Show()
        End If
    End Sub

    Private Sub FormCarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblUsuario.Text = "Administrador: " &
        Dim s As New Administrador
        Dim bd As New ControladorBD
        Dim l As New FormLogin
        Dim lista As New List(Of Administrador)
        lista = bd.ObtenerAdminPorNombreUsuarios(s.nombreus)
        For Each s In lista
            Label5.Text = s.nombre1 + " " + s.apellido1
        Next
        pgrB.Value = 0
        Me.Opacity = 0
        tmA.Start()
        Traductor.TraducirForm(Me)
        Traductor.TraducirPanel(Panel1)
    End Sub


End Class