Imports logica
Imports entidades
Imports persistencia
Public Class Paciente
    Dim pac As Pacientes = New Pacientes
    Dim d As New ControladorBD
    Private Sub btningre_Click(sender As Object, e As EventArgs) Handles btningre.Click
        If txtnomb.Text <> "" Or txtsexo.Text <> "" Or txtpeso.Text <> "" Or txtpin.Text <> "" Or txtaltura.Text <> "" Or txtape1.Text <> "" Or txtname1.Text <> "" Or txtape2.Text <> "" Or txtCedula.Text <> "" Or txtCalle.Text <> "" Or txtcorreo.Text <> "" Or txtIdCiudad.Text <> "" Or txtfecha.Text <> "" Or txtNumero.Text <> "" Then
            pac.nombreUsuario = txtnomb.Text
            pac.nombre1 = txtname1.Text
            pac.nombre2 = txtname2.Text
            pac.apellido1 = txtape1.Text
            pac.apellido2 = txtape2.Text
            pac.apellido2 = txtCalle.Text
            pac.cedula = txtCedula.Text
            pac.ciudad = txtIdCiudad.Text
            pac.correo = txtcorreo.Text
            pac.fechaNacimiento = txtfecha.Text
            pac.numeroPuerta = txtNumero.Text
            pac.peso = txtpeso.Text
            pac.pin = txtpin.Text
            pac.sexo = txtsexo.Text
            ControladorAdministrador.instancia.IngresarPacientes(pac)
            MsgBox(Traductor.Traducir("A ingresado los datos correctamente"))
        Else
            MsgBox(Traductor.Traducir("Faltan Datos"))
        End If
        tmCarga.Start()
    End Sub

    Private Sub btnelim_Click(sender As Object, e As EventArgs) Handles btnelim.Click
        If txtnomb.Text <> "" Then
            ControladorAdministrador.instancia.EliminarPaciente(txtnomb.Text)
            MsgBox(Traductor.Traducir("Elimino los datos correctamente"))
        Else
            MsgBox(Traductor.Traducir("Faltan Datos"))
        End If
        tmCarga.Start()
    End Sub

    Private Sub btnmodif_Click(sender As Object, e As EventArgs) Handles btnmodif.Click
        If txtnomb.Text <> "" Then
            MsgBox(Traductor.Traducir("Se ha modificado correctamente"))
            tmCarga.Start()
            If txtape1.Text <> "" Then
                ControladorAdministrador.instancia.ModificarApellido(txtape1.Text, txtnomb.Text)
                If txtname1.Text <> "" Then
                    ControladorAdministrador.instancia.ModificarNombre(txtname1.Text, txtnomb.Text)
                    If txtape2.Text <> "" Then
                        ControladorAdministrador.instancia.ModificarApellido2(txtape2.Text, txtnomb.Text)
                        If txtCedula.Text <> "" Then
                            ControladorAdministrador.instancia.ModificarCedula(txtCedula.Text, txtnomb.Text)
                            If txtCalle.Text <> "" Then
                                ControladorAdministrador.instancia.ModificarCalle(txtCalle.Text, txtnomb.Text)
                                If txtcorreo.Text <> "" Then
                                    ControladorAdministrador.instancia.ModificarCorreo(txtcorreo.Text, txtnomb.Text)
                                    If txtIdCiudad.Text <> "" Then
                                        ControladorAdministrador.instancia.ModificarCiudad(txtIdCiudad.Text, txtnomb.Text)
                                        If txtfecha.Text <> "" Then
                                            ControladorAdministrador.instancia.ModificarFNacimiento(txtfecha.Text, txtnomb.Text)
                                            If txtaltura.Text <> "" Then
                                                ControladorAdministrador.instancia.ModificarAltura(txtaltura.Text, txtnomb.Text)
                                                If txtpeso.Text <> "" Then
                                                    ControladorAdministrador.instancia.ModificarPeso(txtpeso.Text, txtnomb.Text)
                                                    If txtpin.Text <> "" Then
                                                        ControladorAdministrador.instancia.ModificarPin(txtpin.Text, txtnomb.Text)
                                                        If txtsexo.Text <> "" Then
                                                            ControladorAdministrador.instancia.ModificarSexo(txtsexo.Text, txtnomb.Text)
                                                            If txtNumero.Text <> "" Then
                                                                ControladorAdministrador.instancia.ModificarNumero(txtNumero.Text, txtnomb.Text)
                                                            Else
                                                                MsgBox(Traductor.Traducir("Faltan Datos"))
                                                            End If


                                                        End If


                                                    End If

                                                End If

                                            End If


                                        End If

                                    End If


                                End If

                            End If
                        End If
                    End If
                End If
            End If
        Else
            MsgBox(Traductor.Traducir("Faltan Datos"))
        End If
    End Sub
    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Traductor.TraducirForm(Me)
        Traductor.TraducirPanel(Panel1)
        Dim lista As New List(Of Pacientes)
        lista = d.CargarPaciente()
        For Each s As Pacientes In lista
            cbxcargar.Items.Add(s.nombreUsuario)
        Next
    End Sub

    Private Sub cbxcargar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxcargar.SelectedIndexChanged
        Dim lista As New List(Of Pacientes)
        Dim p As New Pacientes
        Dim nombre As String
        nombre = cbxcargar.SelectedItem
        lista = d.obtenerPacientePorNombreUsuarios(nombre)
        For Each p In lista
            txtnomb.Text = p.nombreUsuario
            txtname1.Text = p.nombre1
            txtname2.Text = p.nombre2
            txtape1.Text = p.apellido1
            txtape2.Text = p.apellido2
            txtCedula.Text = p.cedula
            txtcorreo.Text = p.correo
            txtfecha.Text = p.fechaNacimiento.ToString
            txtpeso.Text = p.peso.ToString
            txtaltura.Text = p.altura.ToString
            txtpin.Text = p.pin.ToString
            txtsexo.Text = p.sexo
            txtCalle.Text = p.calle
            txtNumero.Text = p.numeroPuerta.ToString
        Next
    End Sub

    Private Sub tmCarga_Tick(sender As Object, e As EventArgs) Handles tmCarga.Tick
        txtnomb.Clear()
        txtname1.Clear()
        txtname2.Clear()
        txtape1.Clear()
        txtape2.Clear()
        txtCedula.Clear()
        txtcorreo.Clear()
        txtfecha.Clear()
        txtpeso.Clear()
        txtaltura.Clear()
        txtpin.Clear()
        txtsexo.Clear()
        txtCalle.Clear()
        txtNumero.Clear()
        cbxcargar.Text = Nothing
        tmCarga.Stop()
    End Sub
End Class