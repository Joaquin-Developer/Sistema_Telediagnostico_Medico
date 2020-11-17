Imports logica
Imports entidades
Imports persistencia
Public Class Patologias
    'Crea una instancia de la clase Patologia
    Dim m As Patologia = New Patologia
    Dim result As Integer
    Dim bd As ControladorBD = New ControladorBD

    Private Sub Patologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaa As New List(Of Patologia)
        Traductor.TraducirForm(Me)
        Traductor.TraducirPanel(Panel1)
        listaa = ControladorAdministrador.instancia.CargarPatologia()
        For Each pat As Patologia In listaa

            cbxcargar.Items.Add(pat.nombre)
        Next

        Dim lista As New List(Of Sintoma)
        lista = ControladorPaciente.instancia.cargarSintomas()
        For Each sin As Sintoma In lista
            chksin.Items.Add(sin.nombre)
        Next
    End Sub

    Private Sub btnelim_Click(sender As Object, e As EventArgs) Handles btnelim.Click
        If txtn.Text <> "" Then
            ControladorAdministrador.instancia.EliminarPatologia(txtn.Text)
            MsgBox(Traductor.Traducir("Se ha eliminado correctamente"))
        Else
            MsgBox(Traductor.Traducir("Faltan datos"))
        End If
        tmCarga.Start()
    End Sub

    Private Sub btnmodi_Click(sender As Object, e As EventArgs) Handles btnmodi.Click
        'Si chkmort esta checkeado resultado va a ser 1 y si no lo esta va a ser 0
        If chkmort.Checked Then
            result = 1
        Else
            result = 0
        End If
        m.nombre = txtn.Text
        m.descripcion = txtdescrip.Text
        m.recomendaciones = txtrecomen.Text
        m.esMortal = result.ToString
        ControladorAdministrador.instancia.ModificarPatologia(m)

        'llama la funcion modificarMort

        tmCarga.Start()
    End Sub
    'Llama la funcion cargarDatos
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub cbxcargar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxcargar.SelectedIndexChanged
        Dim lista As New List(Of Patologia)
        Dim p As New Patologia
        Dim nombre As String
        nombre = cbxcargar.SelectedItem
        lista = bd.obtenerPatologiaPorNombre(nombre)
        For Each p In lista
            txtn.Text = p.nombre
            txtdescrip.Text = p.descripcion
            txtrecomen.Text = p.recomendaciones
            If p.esMortal = 1 Then
                chkmort.Checked = True
            Else
                chkmort.Checked = False
            End If

        Next
    End Sub

    Private Sub tmCarga_Tick(sender As Object, e As EventArgs) Handles tmCarga.Tick
        txtn.Clear()
        txtdescrip.Clear()
        txtrecomen.Clear()
        chkmort.Checked = False
        cbxcargar.Text = Nothing
        tmCarga.Stop()
    End Sub

    Private Sub btningre_Click(sender As Object, e As EventArgs) Handles btningre.Click
        Dim p As Patologia = New Patologia
        Dim i As Integer
        Dim Valor As String
        If chkmort.Checked Then
            result = 1
        Else
            result = 0
        End If
        p.esMortal = result.ToString
        'Si descripcion, nombre y recomendacion tienen algo escrito llama a la funcion guardarPatologia

        If txtdescrip.Text <> "" Then
            If txtn.Text <> "" Then
                If txtrecomen.Text <> "" Then
                    For i = 0 To Me.chksin.CheckedItems.Count - 1
                        Valor = chksin.CheckedItems(i)

                        ControladorAdministrador.instancia.RelacionSintomaPatologia(Valor, txtn.Text)
                    Next
                    p.nombre = txtn.Text
                    p.descripcion = txtdescrip.Text
                    p.recomendaciones = txtrecomen.Text
                    ControladorAdministrador.instancia.IngresarPatologia(p)
                    MsgBox(Traductor.Traducir("Se han ingresado los datos correctamente"))
                    tmCarga.Start()
                Else
                    MsgBox(Traductor.Traducir("Faltan Datos"))


                End If
            Else
                MsgBox(Traductor.Traducir("Faltan datos"))
            End If

        Else
            MsgBox(Traductor.Traducir("Faltan datos"))
        End If
    End Sub
End Class