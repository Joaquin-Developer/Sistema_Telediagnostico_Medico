Imports entidades
Imports persistencia
Imports logica
Public Class Sintomas
    Dim s As Sintoma = New Sintoma()
    Dim bd As ControladorBD = New ControladorBD()

    Private Sub Sintomas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.TraducirForm(Me)
        Traductor.TraducirPanel(Panel1)
        Dim listaa As New List(Of Sintoma)
        listaa = ControladorPaciente.instancia.cargarSintomas()
        For Each sin As Sintoma In listaa
            cbxcargar.Items.Add(sin.nombre)
        Next

        Dim lista As New List(Of Patologia)
        lista = ControladorAdministrador.instancia.CargarPatologia()
        For Each pat As Patologia In lista

            chksin.Items.Add(pat.nombre)
        Next
    End Sub
    Private Sub btningre_Click(sender As Object, e As EventArgs) Handles btningre.Click
        'Si txtname y txtdescri tienen algo escrito llama a la funcion guardar sintomas
        If txtname.Text <> "" Then
            If txtdescri.Text <> "" Then
                s.nombre = txtname.Text
                s.descripcion = txtdescri.Text
                ControladorAdministrador.instancia.IngresarSintoma(s)
                MsgBox(Traductor.Traducir("Se han ingresado los datos correctamente"))
            Else

                MsgBox(Traductor.Traducir("Faltan datos"))
            End If
        Else
            MsgBox(Traductor.Traducir("Faltan datos"))
        End If
        Dim i As Integer
        Dim Valor As String
        If txtname.Text <> "" Then
            For i = 0 To Me.chksin.CheckedItems.Count - 1
                Valor = chksin.CheckedItems(i)
                ControladorAdministrador.instancia.RelacionSintomaPatologia(txtname.Text, Valor)
            Next

        Else
            MsgBox(Traductor.Traducir("Faltan Datos"))
        End If
        'pone en blanco a txtname y txtdescri
        tmCarga.Start()
    End Sub

    Private Sub btnelim_Click(sender As Object, e As EventArgs) Handles btnelim.Click
        'si txtname tiene algo escrito llama a la funcion eliminarSintomas
        If txtname.Text <> "" Then
            s.nombre = txtname.Text
            ControladorAdministrador.instancia.EliminarSintoma(txtname.Text)
            MsgBox(Traductor.Traducir("Se ha eliminado correctamente"))
        Else
            MsgBox(Traductor.Traducir("Faltan Datos"))

        End If
        tmCarga.Start()
    End Sub

    Private Sub btnmodi_Click(sender As Object, e As EventArgs) Handles btnmodi.Click
        'si txt descri y txtname tienen algo escrito llama la funcion modificarSintoma
        If txtdescri.Text <> "" Then
            If txtname.Text <> "" Then
                s.descripcion = txtdescri.Text
                ControladorAdministrador.instancia.ModificarSintoma(txtdescri.Text)
                MsgBox(Traductor.Traducir("Se ha modificado correctamente"))
                tmCarga.Start()
            Else
                MsgBox(Traductor.Traducir("Faltan datos"))
            End If
        Else
            MsgBox(Traductor.Traducir("Faltan datos"))
        End If
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub cbxcargar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxcargar.SelectedIndexChanged
        Dim lista As New List(Of Sintoma)
        Dim p As New Sintoma
        Dim nombre As String
        Dim bd As New ControladorBD
        nombre = cbxcargar.SelectedItem
        lista = bd.obtenerSintomaPorNombre(nombre)
        For Each p In lista
            txtname.Text = p.nombre
            txtdescri.Text = p.descripcion
        Next
    End Sub

    Private Sub tmCarga_Tick(sender As Object, e As EventArgs) Handles tmCarga.Tick
        txtname.Clear()
        txtdescri.Clear()
        cbxcargar.Text = Nothing
        tmCarga.Stop()
    End Sub
End Class