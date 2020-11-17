Imports logica
Imports entidades
Imports persistencia

Public Class Medico
    Dim med As Medicos = New Medicos
    Dim d As New ControladorBD

    Private Sub Medico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Traductor.TraducirForm(Me)
        Traductor.TraducirPanel(Panel1)
        Dim lista As New List(Of Medicos)
        lista = d.CargarMedico()
        For Each s As Medicos In lista
            cbxcargar.Items.Add(s.nombreUsuario)
        Next
    End Sub

    Private Sub btningre_Click(sender As Object, e As EventArgs) Handles btningre.Click
        Try
            If txtnomb.Text <> "" Or txtesp.Text <> "" Or txtcontra.Text <> "" Or txtape1.Text <> "" Or txtname1.Text <> "" Or txtape2.Text <> "" Or txtCedula.Text <> "" Or txtCalle.Text <> "" Or txtcorreo.Text <> "" Or txtIdCiudad.Text <> "" Or txtfecha.Text <> "" Or txtNumero.Text <> "" Then
                med.nombreUsuario = txtnomb.Text
                med.nombre1 = txtname1.Text
                med.nombre2 = txtname2.Text
                med.numeroPuerta = CInt(txtNumero.Text)
                med.fechaNacimiento = CDate(txtfecha.Text)
                med.apellido1 = txtape1.Text
                med.apellido2 = txtape2.Text
                med.calle = txtCalle.Text
                med.ciudad = txtIdCiudad.Text
                med.correo = txtcorreo.Text
                med.cedula = txtCedula.Text
                med.contraseña = txtcontra.Text
                med.especialidad = txtesp.Text

                ControladorAdministrador.instancia.IngresarMedico(med)
                MsgBox("Los datos se registraron correctamente", vbInformation, "Ingreso al sistema satisfactorio")
            Else
                MsgBox("Faltan datos para ingresar al sistema", vbCritical, "Error al ingresar un medico al sistema")
            End If
            tmCarga.Start()
        Catch ex As Exception
            MsgBox(ex.StackTrace & vbCrLf & ex.ToString)
            MsgBox(ex.Message, vbCritical, "Error al ingresar un medico al sistema")
        End Try

    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub btnelim_Click(sender As Object, e As EventArgs) Handles btnelim.Click
        If txtnomb.Text <> "" Then
            ControladorAdministrador.instancia.EliminarMedico(txtnomb.Text)
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

            If txtesp.Text <> "" Then
                ControladorAdministrador.instancia.MedicoModificarEsp(txtesp.Text, txtnomb.Text)
                If txtcontra.Text <> "" Then
                    ControladorAdministrador.instancia.MedicoModificarContra(txtcontra.Text, txtnomb.Text)
                    If txtesp.Text <> "" Then
                        ControladorAdministrador.instancia.MedicoModificarEsp(txtesp.Text, txtnomb.Text)
                        If txtcontra.Text <> "" Then
                            ControladorAdministrador.instancia.MedicoModificarContra(txtcontra.Text, txtnomb.Text)
                            If txtape1.Text <> "" Then
                                ControladorAdministrador.instancia.MedicoModificarApellido(txtape1.Text, txtnomb.Text)
                                If txtname1.Text <> "" Then
                                    ControladorAdministrador.instancia.MedicoModificarNombre(txtname1.Text, txtnomb.Text)
                                    If txtape2.Text <> "" Then
                                        ControladorAdministrador.instancia.MedicoModificarApellido2(txtape2.Text, txtnomb.Text)
                                        If txtCedula.Text <> "" Then
                                            ControladorAdministrador.instancia.MedicoModificarCedula(txtCedula.Text, txtnomb.Text)
                                            If txtCalle.Text <> "" Then
                                                ControladorAdministrador.instancia.MedicoModificarCalle(txtCalle.Text, txtnomb.Text)
                                                If txtcorreo.Text <> "" Then
                                                    ControladorAdministrador.instancia.MedicoModificarCorreo(txtcorreo.Text, txtnomb.Text)
                                                    If txtIdCiudad.Text <> "" Then
                                                        ControladorAdministrador.instancia.MedicoModificarCiudad(txtIdCiudad.Text, txtnomb.Text)
                                                        If txtfecha.Text <> "" Then
                                                            ControladorAdministrador.instancia.MedicoModificarFNacimiento(txtfecha.Text, txtnomb.Text)
                                                            If txtNumero.Text <> "" Then
                                                                ControladorAdministrador.instancia.MedicoModificarNumero(txtNumero.Text, txtnomb.Text)
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


    Private Sub tmCarga_Tick(sender As Object, e As EventArgs) Handles tmCarga.Tick
        txtnomb.Clear()
        txtname1.Clear()
        txtname2.Clear()
        txtape1.Clear()
        txtape2.Clear()
        txtCedula.Clear()
        txtcorreo.Clear()
        txtfecha.Clear()
        txtesp.Clear()
        txtCalle.Clear()
        txtNumero.Clear()
        cbxcargar.Text = Nothing
        tmCarga.Stop()
    End Sub
    Private Sub cbxcargar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxcargar.SelectedIndexChanged
        Dim lista As New List(Of Medicos)
        Dim p As New Medicos
        Dim nombre As String
        nombre = cbxcargar.SelectedItem
        lista = d.obtenerMedicoPorNombreUsuarios(nombre)
        For Each p In lista
            txtnomb.Text = p.nombreUsuario
            txtname1.Text = p.nombre1
            txtname2.Text = p.nombre2
            txtape1.Text = p.apellido1
            txtape2.Text = p.apellido2
            txtCedula.Text = p.cedula
            txtcontra.Text = p.contraseña
            txtcorreo.Text = p.correo
            txtfecha.Text = p.fechaNacimiento.ToString
            txtesp.Text = p.especialidad
            txtCalle.Text = p.calle
            txtNumero.Text = p.numeroPuerta.ToString
        Next
    End Sub
End Class