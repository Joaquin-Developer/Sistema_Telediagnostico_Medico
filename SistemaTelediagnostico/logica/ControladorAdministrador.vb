Imports entidades
Imports persistencia

Public Class ControladorAdministrador

    Dim controladorBD As ControladorBD = New ControladorBD()
    Public Shared Property instancia As New ControladorAdministrador     ' variable estática (patron de diseño singleton)
    Dim sin As New Sintoma

    Private Sub New()
        ' unicamente accedido por esta clase, para inicializar el objeto "instancia"
    End Sub

    Public Sub LoginAdmin(nombreUsuario As String, passw As String)
        Dim errores As String = ""

        If nombreUsuario.Length = 0 Or passw.Length = 0 Or nombreUsuario.Equals("USUARIO") Or passw.Equals("CONTRASEÑA") Then
            If nombreUsuario.Length = 0 Or nombreUsuario.Equals("USUARIO") Then errores += ("Debe ingresar un nombre de usuario" & vbCrLf)
            If passw.Length = 0 Or passw.Equals("CONTRASEÑA") Then errores += ("Debe ingresar una contraseña" & vbCrLf)
        End If
        If errores.Length <> 0 Then Throw New Exception(errores)

        Dim idAdmin As Integer
        If Not Integer.TryParse(passw, idAdmin) Then
            errores += ("La contraseña debe contener unicamente numeros" & vbCrLf)
        Else
            idAdmin = CInt(passw)
        End If
        If errores.Length <> 0 Then Throw New Exception(errores)

        Dim adminEncontrado As Administrador = controladorBD.ObtenerAdminPorNombreUsuario(nombreUsuario)
        If adminEncontrado.nombreUsuario <> nombreUsuario Or adminEncontrado.id <> idAdmin Then
            ' si no se enuentra usuario, hubo error de login
            Throw New Exception("Usuarios y/o claves incorrectas ")
        End If

        ' si la cadena errores tiene texto, entonces genero una exepcion
        If errores.Length <> 0 Then Throw New Exception(errores)

    End Sub

    Public Function CargarPatologiasDesdeCsv(rutaArchivo As String) As List(Of Patologia)
        If IsNothing(rutaArchivo) Then Throw New Exception("Ruta vacìa")

        Dim listaPatologias As New List(Of Patologia)

        Using archivo As New Microsoft.VisualBasic.FileIO.TextFieldParser(rutaArchivo)
            archivo.TextFieldType = FileIO.FieldType.Delimited
            archivo.SetDelimiters(":")
            Dim currentRow As String()

            While Not archivo.EndOfData
                Try
                    currentRow = archivo.ReadFields()
                    Dim linea As String() = currentRow.ToArray()
                    Dim patologia As New Patologia
                    If linea.Length >= 1 Then
                        patologia.nombre = linea(0)
                    End If

                    If linea.Length >= 2 Then
                        patologia.descripcion = linea(1)
                    End If

                    If linea.Length >= 3 Then
                        patologia.recomendaciones = linea(2)
                    End If

                    If linea.Length = 4 Then
                        If linea(3).Equals("1") Or linea(3).ToLower = ("si").ToLower Then
                            patologia.esMortal = True
                        Else
                            patologia.esMortal = False
                        End If
                    End If
                    listaPatologias.Add(patologia)

                    'If linea.Length < 4 Then
                    '    ' si faltan datos en la linea, no se deberà cargar la patologìa
                    '    ' pero se le debe notificar al usuario

                    '    'MsgBox("La linea con el dato " & linea(0) & " no se cargarà")
                    '    Dim patologiaError As New Patologia
                    '    patologiaError.nombre = linea(0)
                    '    listaPatologias.Add(patologiaError)

                    'Else
                    '    Dim patologia As New Patologia
                    '    patologia.nombre = linea(0)
                    '    patologia.descripcion = linea(1)
                    '    patologia.recomendaciones = linea(2)
                    '    If linea(3).Equals("1") Or linea(3).ToLower = ("si").ToLower Then
                    '        patologia.esMortal = True
                    '    Else
                    '        patologia.esMortal = False
                    '    End If
                    '    listaPatologias.Add("si", patologia)
                    'End If

                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf & ex.ToString & vbCrLf & ex.StackTrace, vbCritical, "Error")
                End Try

            End While

        End Using

        Return listaPatologias

    End Function

    Public Function CargarSintomasDesdeCsv(rutaArchivo As String) As List(Of Sintoma)
        If IsNothing(rutaArchivo) Then Throw New Exception("Ruta vacìa")

        Dim listaSintomas As New List(Of Sintoma)

        Using archivo As New Microsoft.VisualBasic.FileIO.TextFieldParser(rutaArchivo)
            archivo.TextFieldType = FileIO.FieldType.Delimited
            archivo.SetDelimiters(":")
            Dim currentRow As String()

            While Not archivo.EndOfData
                Try
                    currentRow = archivo.ReadFields()
                    Dim linea As String() = currentRow.ToArray()
                    Dim sintoma As New Sintoma
                    If linea.Length >= 1 Then
                        sintoma.nombre = linea(0)
                    End If

                    If linea.Length >= 2 Then
                        sintoma.descripcion = linea(1)
                    End If

                    listaSintomas.Add(sintoma)

                Catch ex As Exception
                    MsgBox(ex.Message & vbCrLf & ex.ToString & vbCrLf & ex.StackTrace, vbCritical, "Error")
                End Try
            End While
        End Using

        Return listaSintomas
    End Function


    Public Sub IngresarSintoma(Sintoma As Sintoma)
        Try
            controladorBD.IngresarSintoma(Sintoma)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        End Try
    End Sub

    'ABM Sintoma
    Public Sub EliminarSintoma(sintoma As String)
        Try
            controladorBD.EliminarSintoma(sintoma)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        End Try
    End Sub

    Public Function ModificarSintoma(sintoma As String)
        Try
            controladorBD.ModificarSintoma(sintoma)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        End Try
    End Function

    Public Sub IngresarPatologia(Patologia As Patologia)
        Try
            controladorBD.IngresarPatologia(Patologia)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        End Try
    End Sub

    Public Function RelacionSintomaPatologia(nombreSintoma As String, nombrePatologia As String)
        controladorBD.RelacionSintomaPatologia(nombreSintoma, nombrePatologia)
    End Function

    ' ABM Patologia
    Public Function EliminarPatologia(nombrePat As String)
        controladorBD.EliminarPatologia(nombrePat)
    End Function

    Public Function ModificarPatologia(patologia As Patologia) As List(Of Patologia)
        controladorBD.ModificarPatologia(patologia)
        MsgBox("se ha modificado correctamente")
        Return Nothing
    End Function

    Public Sub IngresarPacientes(Paciente As Pacientes)
        controladorBD.IngresarPaciente(Paciente)
    End Sub

    Public Function ModificarNombre(nombre As String, nombre1 As String)
        controladorBD.ModificarNombre(nombre1, nombre)
        Return Nothing
    End Function

    Public Function ModificarNombre2(nombre As String, nombre2 As String)
        controladorBD.ModificarNombre2(nombre, nombre2)
        Return Nothing
    End Function

    Public Function ModificarApellido(apellido As String, nombre As String)
        controladorBD.ModificarApellido(apellido, nombre)
        Return Nothing
    End Function

    Public Function ModificarApellido2(apellido2 As String, nombre As String)
        controladorBD.ModificarApellido2(apellido2, nombre)

        Return Nothing
    End Function

    Public Function ModificarCalle(calle As String, nombre As String)
        controladorBD.ModificarCalle(calle, nombre)

        Return Nothing
    End Function

    Public Function ModificarSexo(sexo As String, nombre As String)
        controladorBD.ModificarSexo(sexo, nombre)
        Return Nothing
    End Function

    Public Function ModificarPeso(peso As String, nombre As String)
        controladorBD.ModificarPeso(peso, nombre)
        Return Nothing
    End Function

    Public Function ModificarAltura(altura As String, nombre As String)
        controladorBD.ModificarAltura(altura, nombre)

    End Function

    Public Sub ModificarCiudad(ciudad As String, nombre As String)
        controladorBD.ModificarCiudad(ciudad, nombre)

    End Sub

    Public Sub ModificarCorreo(correo As String, nombre As String)
        controladorBD.ModificarCorreo(correo, nombre)
    End Sub

    Public Sub ModificarPin(pin As String, nombre As String)
        controladorBD.ModificarPin(pin, nombre)
    End Sub

    Public Sub ModificarFNacimiento(fecha As String, nombre As String)
        controladorBD.ModificarFNacimiento(fecha, nombre)
    End Sub

    Public Sub ModificarNumero(numero As String, nombre As String)
        controladorBD.ModificarNumero(numero, nombre)
    End Sub

    Public Sub ModificarCedula(ci As String, nombre As String)
        controladorBD.ModificarCedula(ci, nombre)
    End Sub

    Public Sub MedicoModificarEsp(esp As String, nombre As String)
        controladorBD.MedicoModificarEsp(esp, nombre)
    End Sub

    Public Sub MedicoModificarCedula(cedula As String, nombre As String)
        controladorBD.MedicoModificarCedula(cedula, nombre)
    End Sub

    Public Sub MedicoModificarNombre(name As String, nombre As String)
        controladorBD.MedicoModificarNombre(name, nombre)
    End Sub

    Public Sub MedicoModificarNombre2(name As String, nombre As String)
        controladorBD.MedicoModificarNombre2(name, nombre)
    End Sub

    Public Sub MedicoModificarApellido(ape As String, nombre As String)
        controladorBD.MedicoModificarApellido(ape, nombre)
    End Sub

    Public Sub MedicoModificarApellido2(ape As String, nombre As String)
        controladorBD.MedicoModificarApellido2(ape, nombre)
    End Sub

    Public Sub MedicoModificarCorreo(correo As String, nombre As String)
        controladorBD.MedicoModificarCorreo(correo, nombre)
    End Sub

    Public Sub MedicoModificarFNacimiento(fecha As String, nombre As String)
        controladorBD.MedicoModificarFNacimiento(fecha, nombre)
    End Sub

    Public Sub MedicoModificarCalle(calle As String, nombre As String)
        controladorBD.MedicoModificarCalle(calle, nombre)
    End Sub

    Public Sub MedicoModificarNumero(numero As String, nombre As String)
        controladorBD.MedicoModificarNumero(numero, nombre)
    End Sub

    Public Sub MedicoModificarCiudad(idCiuda As String, nombre As String)
        controladorBD.MedicoModificarCiudad(idCiuda, nombre)
    End Sub

    Public Sub MedicoModificarContra(contra As String, nombre As String)
        controladorBD.MedicoModificarContra(contra, nombre)
    End Sub

    Public Sub EliminarPaciente(nombre As String)
        Try
            controladorBD.EliminarPaciente(nombre)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        End Try
    End Sub

    Public Sub EliminarMedico(nombre As String)
        Try
            controladorBD.EliminarMedico(nombre)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        End Try
    End Sub

    Public Sub IngresarMedico(medico As Medicos)
        Try
            controladorBD.IngresarMedico(medico)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        End Try
    End Sub

    Public Function CargarPatologia() As List(Of Patologia)
        Dim lista As New List(Of Patologia)
        lista = controladorBD.CargarPatologia()

        Return lista
    End Function
    Public Function CargarMedicos() As List(Of Medicos)


    End Function
    Public Function CargarPacientes() As List(Of Pacientes)
        Dim lista As New List(Of Pacientes)

        lista = controladorBD.obtenerUsuariosPacientes()

        Return lista
    End Function
End Class
