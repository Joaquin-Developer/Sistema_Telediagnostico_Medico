Imports entidades
Imports persistencia
Imports logica
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
            Dim form As AppPaci = New AppPaci
            form.Show()
        End If
    End Sub

    Private Sub FormCarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As New Pacientes
        Traductor.TraducirForm(Me)
        Traductor.TraducirPanel(Panel1)
        Dim bd As New ControladorBD
        Dim lista As New List(Of Pacientes)
        lista = bd.obtenerPacientePorNombreUsuarios(s.nombreus)
        For Each s In lista
            lblnombre.Text = s.nombre1 + " " + s.apellido1
        Next
        pgrB.Value = 0
        Me.Opacity = 0
        tmA.Start()
    End Sub
End Class