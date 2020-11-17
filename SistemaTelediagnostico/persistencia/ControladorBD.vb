Imports ADODB
Imports System.Data.Odbc
Imports entidades

' != en VB: <>

Public Class ControladorBD

    Public resultados As Integer
    Public resultado As Integer

    Public Sub New()    ' constr. vacío para crear instancias en la capa logica.-
    End Sub

    Private Function conectar() As Connection
        Dim connection As New Connection

        '"driver={MySql ODBC 8.0 Unicode Driver};" &
        '"server=192.168.5.50;" &
        ' "port=3306;" &
        '"database=maximiliano_lois;" &
        ' "uid=maximiliano.lois;" &
        ' "pwd=52541757;"

        connection.ConnectionString = "" &
        "driver={MySql ODBC 8.0 Unicode Driver};" &
        "server=192.168.5.50;" &
        "port=3306;" &
        "database=maximiliano_lois;" &
        "uid=maximiliano.lois;" &
        "pwd=52541757;"


        Try
            connection.Open()
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.ToString & vbCrLf & "Lugar: " & ex.StackTrace)
            Dim errorConexion As New Exception("Error al establecer la conexion con el servidor")
            'Throw errorConexion
        End Try

        Return connection
    End Function

    ' ##### funciones para login o obtener lista de usuarios ##########
    Public Function CargarPaciente() As List(Of Pacientes)
        Dim connection As Connection
        Dim lista As New List(Of Pacientes)
        Try
            connection = conectar()
            Dim recordset As Recordset = connection.Execute("SELECT nombrePaciente FROM Paciente")
            While (Not recordset.EOF)
                Dim paciente As New Pacientes
                paciente.nombreUsuario = CStr(recordset.Fields(0).Value)
                lista.Add(paciente)
                recordset.MoveNext()

            End While
        Catch ex As Exception
            Console.WriteLine(ex.ToString & vbCrLf & ex.StackTrace)
            'Throw ex
        Finally
            connection.Close()
        End Try

        Return lista

    End Function

    Public Function obtenerUsuariosAdmins() As List(Of Administrador)
        Dim conexion As Connection = conectar()
        Dim listaAdmins As New List(Of Administrador)
        Try
            Dim recordSet As Recordset = conexion.Execute("SELECT * FROM Administrador")
            While (Not recordSet.EOF)
                Dim admin As New Administrador()
                admin.nombreUsuario = TryCast(recordSet.Fields("nombreAdmin").Value, String)
                admin.id = TryCast(recordSet.Fields("ID").Value.ToString, String)
                listaAdmins.Add(admin)
                recordSet.MoveNext()
            End While
        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.obtenerUsuariosAdmins(): " & ex.Message)
        End Try
        Return listaAdmins
    End Function

    Public Function obtenerUsuariosPacientes() As List(Of Pacientes)
        Dim conexion As Connection = conectar()
        Dim listaPacientes As New List(Of Pacientes)
        Dim comando As New OdbcCommand
        Try

            comando.CommandText = ""
            comando.ExecuteNonQuery()

            Dim rs As Recordset = conexion.Execute("SELECT distinct * FROM Paciente p JOIN Usuario u ON(p.NombrePaciente = u.nombreUsuario)")
            While (Not rs.EOF)
                Dim paciente As New Pacientes()
                paciente.nombreUsuario = CType(rs.Fields("NombrePaciente").Value, String)
                paciente.cedula = CType(rs.Fields("Cédula").Value, String)
                paciente.nombre1 = CType(rs.Fields("Nombre1").Value, String)
                paciente.nombre2 = CType(rs.Fields("Nombre2").Value, String)
                paciente.apellido1 = CType(rs.Fields("Apellido1").Value, String)
                paciente.apellido2 = CType(rs.Fields("Apellido2").Value, String)
                paciente.correo = CType(rs.Fields("Correo").Value, String)
                paciente.calle = CType(rs.Fields("Calle").Value, String)
                paciente.numeroPuerta = CType(rs.Fields("Numero").Value, Integer)
                paciente.peso = CType(rs.Fields("Peso").Value, Double)
                paciente.sexo = CType(rs.Fields("Sexo").Value, String)
                paciente.altura = CType(rs.Fields("Altura").Value, Double)
                paciente.pin = CType(rs.Fields("Pin").Value, Integer)
                listaPacientes.Add(paciente)
                rs.MoveNext()
            End While

        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.obtenerUsuariosPacientes(): " & ex.Message)
        End Try
        Return listaPacientes
    End Function

    Public Function obtenerUsuariosMedicos() As List(Of Medicos)
        Dim conexion As Connection = conectar()
        Dim listaMedicos As New List(Of Medicos)
        Try
            Dim recordSet As Recordset = conexion.Execute("SELECT * FROM Medico")
            While (Not recordSet.EOF)
                Dim medico As New Medicos()
                medico.nombreUsuario = TryCast(recordSet.Fields("nombreMedico").Value, String)
                medico.especialidad = TryCast(recordSet.Fields("Especialidad").Value, String)
                medico.contraseña = TryCast(recordSet.Fields("Contraseña").Value, String)
                listaMedicos.Add(medico)
                recordSet.MoveNext()
            End While
        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.obtenerUsuariosMedicos(): " & ex.Message)
        End Try
        Return listaMedicos
    End Function

    Public Function obtenerPacientePorNombreUsuario(nombreUsuario As String) As Pacientes
        Dim conexion As Connection = conectar()

        Dim paciente As New Pacientes()
        Try
            Dim rs As Recordset
            rs = conexion.Execute("SELECT u.nombreUsuario, u.Nombre1, u.Nombre2, u.Apellido1, u.Apellido2, u.Cedula, u.Correo, u.fNacimiento, u.Calle, u.Numero, p.Pin, p.Peso, p.Sexo, p.Altura FROM Paciente p JOIN Usuario u ON(p.NombrePaciente = u.nombreUsuario) " &
                "WHERE u.nombreUsuario='" & nombreUsuario & "'")

            paciente.nombreUsuario = CStr(rs.Fields(0).Value)
            paciente.nombre1 = CType(rs.Fields(1).Value, String)
            If rs.Fields(2).Value <> Nothing Then
                paciente.nombre2 = CType(rs.Fields(2).Value, String)
            End If

            paciente.apellido1 = CType(rs.Fields(3).Value, String)

            If rs.Fields(4).Value <> Nothing Then
                paciente.apellido2 = CType(rs.Fields(4).Value, String)
            End If

            If rs.Fields(5).Value <> Nothing Then
                paciente.cedula = CType(rs.Fields(5).Value, String)
            End If

            If rs.Fields(6).Value <> Nothing Then
                paciente.correo = CType(rs.Fields(6).Value, String)
            End If

            If rs.Fields(7).Value <> Nothing Then
                paciente.fechaNacimiento = CType(rs.Fields(7).Value, Date)
            End If

            If rs.Fields(8).Value <> Nothing Then
                paciente.calle = CType(rs.Fields(8).Value, String)
            End If

            If rs.Fields(9).Value <> Nothing Then
                paciente.numeroPuerta = CType(rs.Fields(9).Value, Integer)
            End If

            paciente.pin = CType(rs.Fields(10).Value, Integer)

            If rs.Fields(11).Value <> Nothing Then
                paciente.peso = CType(rs.Fields(11).Value, Double)
            End If

            If rs.Fields(12).Value <> Nothing Then
                paciente.sexo = CType(rs.Fields(12).Value, String)
            End If

            If rs.Fields(13).Value <> Nothing Then
                paciente.altura = CType(rs.Fields(13).Value, Double)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try
        Return paciente
    End Function

    Public Function obtenerUsuarioPorNombreUsuarios(nombreUsuario As String) As Usuario
        Dim conexion As Connection = conectar()
        Dim usuario As New Usuario()
        Try
            Dim rs As Recordset
            rs = conexion.Execute("SELECT nombreUsuario, Nombre1, Nombre2, Apellido1, Apellido2, Cedula, Correo, fNacimiento, Calle, Numero FROM JOIN Usuario  " &
                "WHERE nombreUsuario='" & nombreUsuario & "'")

            usuario.nombreUsuario = CStr(rs.Fields(0).Value)
            usuario.nombre1 = CType(rs.Fields(1).Value, String)
            If rs.Fields(2).Value <> Nothing Then
                usuario.nombre2 = CType(rs.Fields(2).Value, String)
            End If

            usuario.apellido1 = CType(rs.Fields(3).Value, String)

            If rs.Fields(4).Value <> Nothing Then
                usuario.apellido2 = CType(rs.Fields(4).Value, String)
            End If

            If rs.Fields(5).Value <> Nothing Then
                usuario.cedula = CType(rs.Fields(5).Value, String)
            End If

            If rs.Fields(6).Value <> Nothing Then
                usuario.correo = CType(rs.Fields(6).Value, String)
            End If

            If rs.Fields(7).Value <> Nothing Then
                usuario.fechaNacimiento = CType(rs.Fields(7).Value, Date)
            End If

            If rs.Fields(8).Value <> Nothing Then
                usuario.calle = CType(rs.Fields(8).Value, String)
            End If

            If rs.Fields(9).Value <> Nothing Then
                usuario.numeroPuerta = CType(rs.Fields(9).Value, Integer)
            End If

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try
        Return usuario
    End Function

    Public Function obtenerPacientePorNombreUsuarios(nombreUsuario As String) As List(Of Pacientes)
        Dim conexion As Connection = conectar()
        Dim lista As New List(Of Pacientes)
        Dim paciente As New Pacientes()
        Try
            Dim rs As Recordset
            rs = conexion.Execute("SELECT u.nombreUsuario, u.Nombre1, u.Nombre2, u.Apellido1, u.Apellido2, u.Cedula, u.Correo, u.fNacimiento, u.Calle, u.Numero, p.Pin, p.Peso, p.Sexo, p.Altura FROM Paciente p JOIN Usuario u ON(p.NombrePaciente = u.nombreUsuario) " &
                "WHERE u.nombreUsuario='" & nombreUsuario & "'")

            paciente.nombreUsuario = CStr(rs.Fields(0).Value)
            paciente.nombre1 = CType(rs.Fields(1).Value, String)
            If rs.Fields(2).Value <> Nothing Then
                paciente.nombre2 = CType(rs.Fields(2).Value, String)
            End If

            paciente.apellido1 = CType(rs.Fields(3).Value, String)

            If rs.Fields(4).Value <> Nothing Then
                paciente.apellido2 = CType(rs.Fields(4).Value, String)
            End If

            If rs.Fields(5).Value <> Nothing Then
                paciente.cedula = CType(rs.Fields(5).Value, String)
            End If

            If rs.Fields(6).Value <> Nothing Then
                paciente.correo = CType(rs.Fields(6).Value, String)
            End If

            If rs.Fields(7).Value <> Nothing Then
                paciente.fechaNacimiento = CType(rs.Fields(7).Value, Date)
            End If

            If rs.Fields(8).Value <> Nothing Then
                paciente.calle = CType(rs.Fields(8).Value, String)
            End If

            If rs.Fields(9).Value <> Nothing Then
                paciente.numeroPuerta = CType(rs.Fields(9).Value, Integer)
            End If

            paciente.pin = CType(rs.Fields(10).Value, Integer)

            If rs.Fields(11).Value <> Nothing Then
                paciente.peso = CType(rs.Fields(11).Value, Double)
            End If

            If rs.Fields(12).Value <> Nothing Then
                paciente.sexo = CType(rs.Fields(12).Value, String)
            End If

            If rs.Fields(13).Value <> Nothing Then
                paciente.altura = CType(rs.Fields(13).Value, Double)
            End If
            lista.Add(paciente)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function



    Public Function obtenerMedicoPorNombreUsuario(nombreUsuario As String) As Medicos
        Dim conexion As Connection = conectar()
        Dim medico As New Medicos()
        Try
            Dim rs As Recordset
            rs = conexion.Execute("select u.NombreUsuario, m.Especialidad, m.Contraseña, u.Cedula, u.Nombre1, u.Nombre2, u.Apellido1, u.Apellido2, u.Correo, 
u.fNacimiento, u.Calle, u.Numero, u.idCiudad
  from Medico m JOIN usuario u ON(m.nombreMedico = u.NombreUsuario) WHERE u.NombreUsuario = '" & nombreUsuario & "'")

            medico.nombreUsuario = CStr(rs.Fields(0).Value)

            If rs.Fields(1).Value <> Nothing Then
                medico.nombre2 = CStr(rs.Fields(1).Value)
            End If

            medico.contraseña = CStr(rs.Fields(2).Value)

            If rs.Fields(2).Value <> Nothing Then
                medico.contraseña = CStr(rs.Fields(2).Value)
            End If

            If rs.Fields(3).Value <> Nothing Then
                medico.cedula = CType(rs.Fields(3).Value, String)
            End If

            medico.nombre1 = CStr(rs.Fields(4).Value)

            If rs.Fields(5).Value <> Nothing Then
                medico.nombre2 = CStr(rs.Fields(5).Value)
            End If

            medico.apellido1 = CStr(rs.Fields(6).Value)
            If rs.Fields(7).Value <> Nothing Then
                medico.apellido2 = CStr(rs.Fields(7).Value)
            End If

            If rs.Fields(8).Value <> Nothing Then
                medico.correo = CStr(rs.Fields(8).Value)
            End If

            If rs.Fields(9).Value <> Nothing Then
                medico.fechaNacimiento = CType(rs.Fields(9).Value, Date)
            End If
            If rs.Fields(10).Value <> Nothing Then
                medico.calle = CStr(rs.Fields(10).Value)
            End If

            If rs.Fields(11).Value <> Nothing Then
                medico.numeroPuerta = CInt(rs.Fields(11).Value)
            End If

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try
        Return medico
    End Function
    Public Function CargarMedico() As List(Of Medicos)
        Dim lista As New List(Of Medicos)
        Dim conexion As Connection = conectar()
        Try
            Dim recordset As Recordset = conexion.Execute("SELECT nombreMedico FROM Medico")

            While (Not recordset.EOF)
                Dim med As Medicos = New Medicos
                med.nombreUsuario = DirectCast(recordset.Fields("nombreMedico").Value, String)
                lista.Add(med)
                recordset.MoveNext()
            End While
        Catch ex As Exception
            Console.WriteLine(ex.ToString & vbCrLf & ex.StackTrace)
            Throw ex
        Finally
            conexion.Close()
        End Try
        Return lista

    End Function


    Public Function obtenerMedicoPorNombreUsuarios(nombreUsuario As String) As List(Of Medicos)
        Dim conexion As Connection = conectar()
        Dim medico As New Medicos()
        Dim lista As New List(Of Medicos)
        Try
            Dim rs As Recordset
            rs = conexion.Execute("select u.nombreUsuario, m.Especialidad, m.Contraseña, u.Cedula, u.Nombre1, u.Nombre2, u.Apellido1, u.Apellido2, u.Correo, 
u.fNacimiento, u.Calle, u.Numero, u.idCiudad
  from Medico m JOIN Usuario u ON(m.nombreMedico = u.nombreUsuario) WHERE u.nombreUsuario = '" & nombreUsuario & "'")

            While Not rs.EOF
                medico.nombreUsuario = CStr(rs.Fields(0).Value)

                If rs.Fields(1).Value <> Nothing Then
                    medico.nombre2 = CStr(rs.Fields(1).Value)
                End If
                If rs.Fields(1).Value <> Nothing Then
                    medico.especialidad = CStr(rs.Fields(1).Value)
                End If
                medico.contraseña = CStr(rs.Fields(2).Value)
                If rs.Fields(2).Value <> Nothing Then
                    medico.contraseña = CStr(rs.Fields(2).Value)
                End If
                If rs.Fields(3).Value <> Nothing Then
                    medico.cedula = CType(rs.Fields(3).Value, String)
                End If
                medico.nombre1 = CStr(rs.Fields(4).Value)

                If rs.Fields(5).Value <> Nothing Then
                    medico.nombre2 = CStr(rs.Fields(5).Value)
                End If

                medico.apellido1 = CStr(rs.Fields(6).Value)
                If rs.Fields(7).Value <> Nothing Then
                    medico.apellido2 = CStr(rs.Fields(7).Value)
                End If

                If rs.Fields(8).Value <> Nothing Then
                    medico.correo = CStr(rs.Fields(8).Value)
                End If

                If rs.Fields(9).Value <> Nothing Then
                    medico.fechaNacimiento = CType(rs.Fields(9).Value, Date)
                End If
                If rs.Fields(10).Value <> Nothing Then
                    medico.calle = CStr(rs.Fields(10).Value)
                End If

                If rs.Fields(11).Value <> Nothing Then
                    medico.numeroPuerta = CInt(rs.Fields(11).Value)
                End If
                lista.Add(medico)
                rs.MoveNext()
            End While


        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function

    Public Function ObtenerAdminPorNombreUsuario(nombreUsuario As String) As Administrador
        Dim conexion As Connection = conectar()
        Dim admin As New Administrador
        Try
            Dim rs As Recordset
            rs = conexion.Execute("select u.NombreUsuario, a.ID, u.Cedula, u.Nombre1, u.Nombre2, u.Apellido1, u.Apellido2, u.Correo,
u.fNacimiento, u.Calle, u.Numero, u.idCiudad
  From Administrador a Join Usuario u ON(a.nombreAdmin = u.NombreUsuario) WHERE u.NombreUsuario = '" & nombreUsuario & "'")

            admin.nombreUsuario = CStr(rs.Fields(0).Value)
            admin.id = CStr(rs.Fields(1).Value)

            If rs.Fields(2).Value <> Nothing Then
                admin.cedula = CStr(rs.Fields(2).Value)
            End If
            admin.nombre1 = CStr(rs.Fields(3).Value)
            If rs.Fields(4).Value <> Nothing Then
                admin.nombre2 = CStr(rs.Fields(4).Value)
            End If
            admin.apellido1 = CStr(rs.Fields(5).Value)

            If rs.Fields(6).Value <> Nothing Then
                admin.apellido2 = CStr(rs.Fields(6).Value)
            End If

            If rs.Fields(7).Value <> Nothing Then
                admin.correo = CStr(rs.Fields(7).Value)
            End If

            If rs.Fields(8).Value <> Nothing Then
                admin.fechaNacimiento = CType(rs.Fields(8).Value, Date)
            End If
            If rs.Fields(9).Value <> Nothing Then
                admin.calle = CStr(rs.Fields(9).Value)
            End If

            If rs.Fields(10).Value <> Nothing Then
                admin.numeroPuerta = CInt(rs.Fields(10).Value)
            End If

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try
        Return admin
    End Function
    Public Function ObtenerAdminPorNombreUsuarios(nombreUsuario As String) As List(Of Administrador)
        Dim conexion As Connection = conectar()
        Dim admin As New Administrador
        Dim lista As New List(Of Administrador)
        Try
            Dim rs As Recordset
            rs = conexion.Execute("select u.NombreUsuario, a.ID, u.Cedula, u.Nombre1, u.Nombre2, u.Apellido1, u.Apellido2, u.Correo,
u.fNacimiento, u.Calle, u.Numero, u.idCiudad
  From Administrador a Join Usuario u ON(a.nombreAdmin = u.NombreUsuario) WHERE u.NombreUsuario = '" & nombreUsuario & "'")

            admin.nombreUsuario = CStr(rs.Fields(0).Value)
            admin.id = CStr(rs.Fields(1).Value)

            If rs.Fields(2).Value <> Nothing Then
                admin.cedula = CStr(rs.Fields(2).Value)
            End If
            admin.nombre1 = CStr(rs.Fields(3).Value)
            If rs.Fields(4).Value <> Nothing Then
                admin.nombre2 = CStr(rs.Fields(4).Value)
            End If
            admin.apellido1 = CStr(rs.Fields(5).Value)

            If rs.Fields(6).Value <> Nothing Then
                admin.apellido2 = CStr(rs.Fields(6).Value)
            End If

            If rs.Fields(7).Value <> Nothing Then
                admin.correo = CStr(rs.Fields(7).Value)
            End If

            If rs.Fields(8).Value <> Nothing Then
                admin.fechaNacimiento = CType(rs.Fields(8).Value, Date)
            End If
            If rs.Fields(9).Value <> Nothing Then
                admin.calle = CStr(rs.Fields(9).Value)
            End If

            If rs.Fields(10).Value <> Nothing Then
                admin.numeroPuerta = CInt(rs.Fields(10).Value)
            End If
            lista.Add(admin)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function
    Public Function obtenerPatologiaPorNombre(nombreUsuario As String) As List(Of Patologia)
        Dim conexion As Connection = conectar()
        Dim lista As New List(Of Patologia)
        Dim patologia As New Patologia()
        Try
            Dim rs As Recordset
            rs = conexion.Execute("SELECT * FROM Patologia WHERE nombrePatologia='" & nombreUsuario & "'")

            patologia.nombre = CStr(rs.Fields(0).Value)
            patologia.descripcion = CType(rs.Fields(1).Value, String)
            If rs.Fields(2).Value <> Nothing Then
                patologia.recomendaciones = CType(rs.Fields(2).Value, String)
            End If
            patologia.esMortal = CType(rs.Fields(3).Value.ToString, String)
            lista.Add(patologia)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function
    Public Function obtenerSintomaPorNombre(nombreusuario As String) As List(Of Sintoma)
        Dim conexion As Connection = conectar()
        Dim lista As New List(Of Sintoma)
        Dim sintoma As New Sintoma()
        Try
            Dim rs As Recordset
            rs = conexion.Execute("SELECT * FROM Sintoma WHERE nombresSintoma='" & nombreusuario & "'")

            sintoma.nombre = CStr(rs.Fields(0).Value)
            sintoma.descripcion = CType(rs.Fields(1).Value, String)
            lista.Add(sintoma)
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function

    ' ############ end funciones para login o listas #######################################

    ' ######## Funciones para el ABM de Médicos:   #########################################

    Public Sub IngresarMedico(medico As Medicos)
        Dim conexion As Connection = conectar()
        Try
            conexion.BeginTrans()
            Dim recordSet As Recordset
            Dim stringFechaNac As String = medico.fechaNacimiento.Year & "-" & medico.fechaNacimiento.Month &
                "-" & medico.fechaNacimiento.Day
            ' ingresamos los datos a la tabla de Usuarios:
            recordSet.Open()
            recordSet = conexion.Execute("INSERT INTO Usuario VALUES('" + medico.nombreUsuario + "', '" + medico.cedula.ToString + "', " + "'" + medico.nombre1 + "', '" + medico.nombre2 + "', '" + medico.apellido1 + "', '" + medico.apellido2 + "', " + "'" + medico.correo + "', '" + medico.fechaNacimiento.ToString + "', '" + medico.calle.ToString + "', '" + medico.numeroPuerta.ToString + "', " + "'" + medico.ciudad.ToString + "' );")

            ' luego a la tabla de Medico (que representa una subEntidad)
            recordSet = conexion.Execute("INSERT INTO Medico VALUES('" + medico.nombreUsuario + "', '" + medico.especialidad + "', '" + medico.contraseña + "' );")
            conexion.CommitTrans()
            recordSet.Close()
        Catch ex As Exception
            conexion.RollbackTrans()
            Console.WriteLine("Error en ControladorBD.IngresarMedico(): " & ex.Message)
            ' Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub UpdatePaciente(paciente As Pacientes)



    End Sub

    Public Sub EliminarMedico(nombreUsuario As String)

        ' Nota: esta funcion se debería modificar (no debería usarse el DELETE)
        ' ya que las bajas de nuestra aplicación deberían ser bajas lógicas.

        Dim connection As Connection = conectar()
        Try
            Dim recordSet As Recordset
            recordSet = connection.Execute("DELETE FROM Medico WHERE nombreMedico=" + "'" + nombreUsuario + "';")
            recordSet = connection.Execute("DELETE FROM Usuario WHERE nombreUsuario=" + "'" + nombreUsuario + "';")

        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.EliminarMedico(): " & ex.Message)
            ' nota: las exepciónes atraviesan las capas (por eso llegará hasta la capa de presentacion)
            ' y mostraremos el error ahí de forma visual, con un MshBox


        Finally
            connection.Close()  ' hayan errores o no, cierro la conexion
        End Try
    End Sub

    Public Function obtenerIdCiudadDesdeNombre(nombreCiudad As String) As Integer
        ' esta funcion debería retornar un solo elemento
        Dim connection As Connection = conectar()
        Dim id As Integer = Nothing
        Try

            Dim rs As Recordset = connection.Execute("SELECT idCiudad FROM Ciudad WHERE nombreCiudad='" & nombreCiudad & "'")
            id = DirectCast(rs.Fields("idCiudad").Value, Integer)

        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.obtenerIdCiudadDesdeNombre(): " & ex.Message)
        Finally
            connection.Close()
        End Try

        Return id

    End Function

    Public Sub ModificarMedico(medico As Medicos)
        ' NOTA: Se supone que se debería poder modificar todos los campos excepto el nombreUsuario (pk)
        Dim connection As Connection = conectar()
        Try
            Dim rs As Recordset
            Dim stringFechaNac As String = medico.fechaNacimiento.Year & "-" & medico.fechaNacimiento.Month &
                "-" & medico.fechaNacimiento.Day

            Dim idCiudad As Integer = obtenerIdCiudadDesdeNombre(medico.ciudad)
            ' caso de que idCiudad sea nulo, generamos una exception:
            If IsNothing(idCiudad) Then Throw New Exception("Error: No se pudo obtener los datos de la ciudad del Medico " & medico.nombre1)

            rs = connection.Execute("UPDATE Usuario " + "', Nombre1='" + medico.nombre1 + "', Nombre2='" + medico.nombre2 + "'," +
                                    "Apellido1='" + medico.apellido1 + "', Apellido2='" + medico.apellido2 + "', Correo='" + medico.correo + "', fNacimiento='" + stringFechaNac + "', " +
                                    "Calle='" + medico.calle + "', Numero=" + medico.numeroPuerta + ", idCiudad=" + idCiudad + " " +
                                    "WHERE nombreUsuario='" + medico.nombreUsuario + "'")

            rs = connection.Execute("UPDATE Medico SET Especialidad='" & medico.especialidad & "', Contraseña='" & medico.contraseña & "'")

        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.ModificarMedico(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub MedicoModificarEsp(esp As String, nombre As String)
        Dim connection As Connection = conectar()
        Dim RecordSet As Recordset = connection.Execute("UPDATE Medico SET Especialidad=" + "'" + esp + "'" + "WHERE nombreMedico=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub MedicoModificarCedula(cedula As String, nombre As String)
        Dim connection As Connection = conectar()
        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Cedula=" + "'" + cedula + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub MedicoModificarNombre(name As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Nombre1=" + "'" + name + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub

    Public Sub MedicoModificarNombre2(name As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Nombre2=" + "'" + name + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub MedicoModificarApellido(ape As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Apellido1=" + "'" + ape + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub MedicoModificarApellido2(ape As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Apellido2=" + "'" + ape + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub MedicoModificarCorreo(correo As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Correo=" + "'" + correo + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub

    Public Sub MedicoModificarFNacimiento(fecha As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET fNacimiento=" + "'" + fecha + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub

    Public Sub MedicoModificarCalle(calle As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Calle=" + "'" + calle + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub MedicoModificarNumero(numero As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Tels_Usuario SET Telefono=" + "'" + numero + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub MedicoModificarCiudad(idCiuda As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET idCiudad=" + "'" + idCiuda + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub

    Public Sub MedicoModificarContra(contra As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Medico SET Especialidad=" + "'" + contra + "'" + "WHERE nombreMedico=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    '######## End Funciones para el ABM de Médicos   ######################################

    ' ######## Funciones para el ABM de Pacientes   ########################################
    Public Sub IngresarPaciente(paciente As Pacientes)
        Dim connection As Connection = conectar()
        Try
            Dim recordSet As Recordset
            Dim stringFechaNac As String = paciente.fechaNacimiento.Year & "-" & paciente.fechaNacimiento.Month &
                "-" & paciente.fechaNacimiento.Day
            ' ingresamos los datos a la tabla de Usuarios:
            recordSet = connection.Execute("INSERT INTO Usuario VALUES('" + paciente.nombreUsuario + "', " + paciente.cedula.ToString + ", " +
                                           "'" + paciente.nombre1 + "', '" + paciente.nombre2 + "', '" + paciente.apellido1 + "', '" + paciente.apellido2 + "', " +
                                           "'" + paciente.correo + "', '" + paciente.fechaNacimiento.ToString + "', '" + paciente.calle + "', " + paciente.numeroPuerta.ToString + ", " +
                                           "'" + paciente.ciudad.ToString + "' );")

            ' luego a la tabla de Medico (que representa una subEntidad)
            recordSet = connection.Execute("INSERT INTO Paciente VALUES('" + paciente.nombreUsuario + "', " + paciente.peso.ToString + ", '" & paciente.sexo & "', " +
                                            paciente.altura.ToString & ", " & paciente.pin.ToString & ")")

        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.IngresarPaciente(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub EliminarPaciente(nombreUsuario As String)
        ' Nota: esta funcion se debería modificar (no debería usarse el DELETE)
        ' ya que las bajas de nuestra aplicación deberían ser bajas lógicas.
        Dim connection As Connection = conectar()
        Try
            Dim recordSet As Recordset
            recordSet = connection.Execute("DELETE FROM Paciente WHERE nombrePaciente=" + "'" + nombreUsuario + "'")
            recordSet = connection.Execute("DELETE FROM Usuario WHERE nombreUsuario=" + "'" + nombreUsuario + "'")
        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.EliminarPaciente(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub ModificarPeso(peso As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Paciente SET Peso=" + "'" + peso + "'" + "WHERE nombrePaciente=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub ModificarSexo(sexo As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Paciente SET Sexo=" + "'" + sexo + "'" + "WHERE nombrePaciente=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub ModificarAltura(altura As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Paciente SET Altura=" + "'" + altura + "'" + "WHERE nombrePaciente=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub ModificarCedula(cedula As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Cedula=" + "'" + cedula + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub ModificarNombre(name As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Nombre1=" + "'" + name + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub

    Public Sub ModificarNombre2(name As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Nombre2=" + "'" + name + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub ModificarApellido(ape As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Apellido1=" + "'" + ape + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub ModificarApellido2(ape As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Apellido2=" + "'" + ape + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub ModificarCorreo(correo As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Correo=" + "'" + correo + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub

    Public Sub ModificarFNacimiento(fecha As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET fNacimiento=" + "'" + fecha + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub

    Public Sub ModificarCalle(calle As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Calle=" + "'" + calle + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub ModificarNumero(numero As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET Numero=" + "'" + numero + "'" + "WHERE nombreUsuario=" + "'" + nombre + "'")

        connection.Close()
    End Sub
    Public Sub ModificarCiudad(idCiuda As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Usuario SET idCiudad=" + "'" + idCiuda + "'" + "WHERE nombreUsuario =" + "'" + nombre + "'")

        connection.Close()
    End Sub

    Public Sub ModificarPin(contra As String, nombre As String)
        Dim connection As Connection = conectar()

        Dim RecordSet As Recordset = connection.Execute("UPDATE Paciente SET Pin=" + "'" + contra + "'" + "WHERE nombrePaciente=" + "'" + nombre + "'")

        connection.Close()
    End Sub



    Public Sub modificarPaciente(paciente As Pacientes)
        ' NOTA: Se supone que se debería poder modificar todos los campos excepto el nombreUsuario (pk)
        Dim connection As Connection = conectar()
        Try
            Dim rs As Recordset
            Dim stringFechaNac As String = paciente.fechaNacimiento.Year & "-" & paciente.fechaNacimiento.Month &
                "-" & paciente.fechaNacimiento.Day

            Dim idCiudad As Integer = obtenerIdCiudadDesdeNombre(paciente.ciudad)
            ' caso de que idCiudad sea nulo, generamos una exception:
            If IsNothing(idCiudad) Then Throw New Exception("Error: No se pudo obtener los datos de la ciudad del Paciente " & paciente.nombre1)

            rs = connection.Execute("UPDATE Usuario SET Cedula='" + paciente.cedula + "', Nombre1='" + paciente.nombre1 + "', Nombre2='" + paciente.nombre2 + "'," +
                                    "Apellido1='" + paciente.apellido1 + "', Apellido2='" + paciente.apellido2 + "', Correo='" + paciente.correo + "', fNacimiento='" + stringFechaNac + "', " +
                                    "Calle='" + paciente.calle + "', Numero=" + paciente.numeroPuerta + ", idCiudad=" + idCiudad + " " +
                                    "WHERE nombreUsuario='" + paciente.nombreUsuario + "'")

            rs = connection.Execute("UPDATE Paciente SET Peso=" & paciente.peso & ", Sexo='" & paciente.sexo & "', Altura=" & paciente.altura & ", Pin=" & paciente.pin)

        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.ModificarPaciente(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' ######## End Funciones para el ABM de Pacientes   ####################################

    ' ######## Funciones para el ABM de patologías   #######################################

    Public Sub IngresarPatologia(patologia As Patologia)
        Dim connection As Connection = conectar()
        Try
            Dim recordSet As Recordset
            ' el campo esMortal de la bd es un tinyint que representa un booleano



            recordSet = connection.Execute("INSERT INTO Patologia VALUES('" & patologia.nombre & "', '" & patologia.descripcion & "', '" & patologia.recomendaciones & "', '" & patologia.esMortal.ToString & "', '" + "')")

        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.IngresarPatologia(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub EliminarPatologia(nombrePat As String)
        ' Nota: esta funcion se debería modificar (no debería usarse el DELETE)
        ' ya que las bajas de nuestra aplicación deberían ser bajas lógicas.
        Dim connection As Connection = conectar()
        Try
            Dim rs As Recordset
            rs = connection.Execute("DELETE FROM Patologia WHERE nombrePatologia='" & nombrePat & "'")
        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.EliminarPatologia(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub ModificarPatologia(patologia As Patologia)
        Dim connection As Connection = conectar()
        Try
            Dim esMortal As Integer = 0     ' el campo esMortal de la bd es un tinyint que representa un booleano
            If patologia.esMortal Then esMortal = 1 Else esMortal = 0

            Dim rs As Recordset
            rs = connection.Execute("UPDATE Patologia SET nombrePatologia='" & patologia.nombre & "', DescripcionP='" & patologia.descripcion & "', " &
                                    "Recomendacion='" & patologia.recomendaciones & "', Mortal=" & patologia.esMortal)

        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.ModificarPatologia(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Function CargarPatologia() As List(Of Patologia)

        Dim connection As Connection = conectar()
        Dim recordset As New Recordset
        recordset = connection.Execute("SELECT nombrePatologia FROM Patologia")
        Dim lista As New List(Of Patologia)

        While (Not recordset.EOF)
            Dim pat As New Patologia
            pat.nombre = DirectCast(recordset.Fields("nombrePatologia").Value, String)
            lista.Add(pat)
            recordset.MoveNext()

        End While
        connection.Close()

        Return lista

    End Function
    ' ######## End Funciones para el ABM de Patologías   ###################################

    ' ######## Funciones para el ABM de Sintomas   #########################################

    Public Sub IngresarSintoma(sintoma As Sintoma)
        Dim connection As Connection = conectar()
        Try
            Dim rs As Recordset
            rs = connection.Execute("INSERT INTO Sintoma VALUES('" & sintoma.nombre & "', '" & sintoma.descripcion & "')")

        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.IngresarSintoma(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub EliminarSintoma(nombreSintoma As String)
        ' Nota: esta funcion se debería modificar (no debería usarse el DELETE)
        ' ya que las bajas de nuestra aplicación deberían ser bajas lógicas.
        Dim connection As Connection = conectar()
        Try
            Dim rs As Recordset
            rs = connection.Execute("DELETE FROM Sintoma WHERE nombresSintoma='" & nombreSintoma & "'")
        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.EliminarSintoma(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Sub ModificarSintoma(descripicion As String)
        Dim connection As Connection = conectar()
        Try
            Dim rs As Recordset
            rs = connection.Execute("UPDATE Sintoma SET DescripcionS='" & descripicion & "'")

        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.ModificarSintoma(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function cargarSintoma() As List(Of Sintoma)
        Dim connection As Connection = conectar()

        Dim list As New List(Of Sintoma)
        Dim recordset As New Recordset
        recordset = connection.Execute("SELECT nombresSintoma FROM Sintoma")

        While (Not recordset.EOF)
            Dim sint As New Sintoma
            sint.nombre = DirectCast(recordset.Fields("nombresSintoma").Value, String)
            list.Add(sint)
            recordset.MoveNext()
        End While
        connection.Close()

        Return list

    End Function

    ' ######## End Funciones para el ABM de Sintomas   #####################################

    ' ######## Funcion para relacionar sintoma con patología   ##############################
    Public Sub RelacionSintomaPatologia(nombreSintoma As String, nombrePat As String)
        Dim connection As Connection = conectar()
        Try
            Dim rs As Recordset
            rs = connection.Execute("INSERT INTO Contiene VALUES('" & nombrePat & "', '" & nombreSintoma & "')")
        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.RelacionSintomaPatologia(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' ######## End Funcion para relacionar sintoma con patología   #########################

    ' ######## Funciones para Autodiagnostigo (AppPaciente/Medicos)   ######################


    ''' <summary>
    ''' antes de seguir con esta funcion hay que arregnar la tabla Auto_Diagnostico en la BD física :
    ''' </summary>
    Public Sub GuardarAutoDiagnostico(list, lista)
        Dim connection As Connection = conectar()
        Dim autoDiag As Autodiagnostico
        Dim paci As New Pacientes
        Try
            Dim urgente As Integer = 0



            Dim fechaActual As Date = Date.Now
            Dim rs As Recordset
            For Each s As Sintoma In lista
                For Each p As Patologia In list
                    rs = connection.Execute("INSERT INTO Auto_Diagnostico VALUES(" + "'" + "'" & urgente.ToString & ", '" & fechaActual.ToString & "', '" + p.nombre + "', '" + paci.nombreus + "', '" + s.nombre + "', '" + "'")
                Next
            Next
        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.GuardarAutoDiagnostico(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function obtenerDiagnosticosDePaciente(nombrePaciente As String) As List(Of Autodiagnostico)

        Dim lista As New List(Of Autodiagnostico)
        Dim conexion As Connection = conectar()
        Try

            Dim rs As Recordset = conexion.Execute("SELECT * FROM Auto_Diagnostico WHERE nombrepaciente='" & nombrePaciente & "'")
            While (Not rs.EOF)
                Dim autoDiag As New Autodiagnostico()
                autoDiag.id = DirectCast(rs.Fields("idAutodiagnostico").Value, Integer)
                Dim urgente As Integer = rs.Fields("esUrgente").Value
                If urgente = 0 Then
                    autoDiag.esUrgente = False
                Else
                    autoDiag.esUrgente = True
                End If
                autoDiag.paciente.nombreUsuario = nombrePaciente
                ' completar con datos de sintomas, patologias
                ' despues de modificar la estructura de la BD ...
                lista.Add(autoDiag)
                rs.MoveNext()

            End While
        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.obtenerDiagnosticosDePaciente(): " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return lista
    End Function

    Public Sub ModificarAutoDiagnostico()
        Try
            ' antes de seguir con esta funcion hay que arregnar la tabla Auto_Diagnostico en la BD física 
        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.ModificarAutoDiagnostico(): " & ex.Message)
        Finally

        End Try
    End Sub

    Public Sub EliminarAutoDiagnostico(idAutoDiagnostico As Integer)
        ' Nota: esta funcion se debería modificar (no debería usarse el DELETE)
        ' ya que las bajas de nuestra aplicación deberían ser bajas lógicas.
        Dim connection As Connection = conectar()
        Try
            Dim rs As Recordset
            rs = connection.Execute("DELETE FROM Auto_Diagnostico WHERE idAutodiagnostico=" & idAutoDiagnostico)
        Catch ex As Exception
            Console.WriteLine("Error en ControladorBD.EliminarAutoDiagnostico(): " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    ' ######## End Funciones para Autodiagnostigo (AppPaciente/Medicos)   ##################
    ' ######## Funciones para Chat (AppPaciente/Medicos)   #################################


    Public Function obtenerMensajes(ultimoId As Integer, idSala As Integer) As List(Of Mensaje)
        Dim listaMensajes As New List(Of Mensaje)
        Dim conexion As Connection = conectar()
        Try
            Dim rs As Recordset
            rs = conexion.Execute("SELECT * FROM Mensaje WHERE idMensaje > " & ultimoId.ToString & " and idSala = " & idSala.ToString)

            While (Not rs.EOF)
                Dim mensaje As New Mensaje()
                mensaje.idMensaje = CInt(rs.Fields(0).Value)
                mensaje.usuarioEmisor = New Usuario()
                mensaje.usuarioEmisor.nombreUsuario = CStr(rs.Fields(2).Value)
                mensaje.textoMensaje = CStr(rs.Fields(3).Value)

                Dim fecha As String() = CStr(rs.Fields(4).Value).Split("/")
                Dim campoHora As String() = CStr(rs.Fields(5).Value).Split(" ")
                Dim hora As String() = campoHora(1).Split(":")

                Dim datetime As New Date(CInt(fecha(2)), CInt(fecha(1)), CInt(fecha(0)),
                                         CInt(hora(0)), CInt(hora(1)), CInt(hora(2)))

                mensaje.fecha_Hora_mensaje = datetime

                listaMensajes.Add(mensaje)
                rs.MoveNext()
            End While
        Catch ex As Exception
            MsgBox("error: " & ex.StackTrace)
            Console.WriteLine(ex.StackTrace)
            Throw ex
        Finally
            conexion.Close()
        End Try

        Return listaMensajes
    End Function

    Public Sub guardarMensaje(mensaje As Mensaje, idSala As Integer)
        Dim conexion As Connection = conectar()
        Try
            Dim rs As Recordset
            Dim stringFecha As String = mensaje.fecha_Hora_mensaje.Year & "/" & mensaje.fecha_Hora_mensaje.Month &
                "/" & mensaje.fecha_Hora_mensaje.Day
            Dim stringHora As String = DateTime.Now.ToString("hh:mm")

            Dim idMensaje As Integer = ObtenerUltimoIdMensajeGeneral() + 1


            rs = conexion.Execute("INSERT INTO Mensaje VALUES(" & idMensaje & ", " & idSala & ", '" & mensaje.usuarioEmisor.nombreUsuario & "', '" & mensaje.textoMensaje & "', " &
                                  "'" & stringFecha & "', '" & stringHora & "' )")

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function ObtenerSolicitudesChat() As List(Of SalaChat)
        ' esta funcion debe retornar todas las SalaChats creadas en la BD que no  tengan usuarios del tipo Medico
        ' asociados a la salaChat. Es decir, todas las "solicitudes" de parte de los pacientes para iniciar un chat.-
        Dim listaSalas As New List(Of SalaChat)
        Dim conexion As Connection = conectar()
        Try
            Dim rs As Recordset
            rs = conexion.Execute("Select sc.idSala, sc.Prioridad, e.nombreUsuario " &
                "FROM Sala_Chat sc JOIN Entra e On(sc.idSala=e.idSala) " &
                "WHERE sc.idSala Not In ( Select en.idSala from Entra en where en.nombreUsuario In" &
                "( Select nombreMedico from Medico)) group by sc.idSala")

            While (Not rs.EOF)
                Dim sala As New SalaChat()

                sala.idSala = CInt(rs.Fields("idSala").Value)
                sala.prioridad = TryCast(rs.Fields("Prioridad").Value, String)
                ' nombre de usuario del paciente:
                Dim nombreUsuario As String = TryCast(rs.Fields("nombreUsuario").Value, String)
                ' consulto todos los datos del paciente con este nombre, para construir el objeto de pacienteSala:
                sala.pacienteSala = obtenerPacientePorNombreUsuario(nombreUsuario)
                sala.medicoSala = Nothing   ' esto no es necesario (?    (no lo es xd)
                listaSalas.Add(sala)
                rs.MoveNext()
            End While

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        Finally
            conexion.Close()
        End Try
        Return listaSalas

    End Function

    Public Function aceptarSolicitudChat(idSalaChat As Integer, nombreMedico As String) As SalaChat
        ' funcion que solo usa ControladorMedico
        Dim conexion As Connection = conectar()
        Dim sala As New SalaChat
        Try
            sala.idSala = idSalaChat
            sala.prioridad = "Alta"  ' cambiar esto
            Dim rs1, rs2, rs3 As Recordset
            rs1 = conexion.Execute("INSERT INTO Entra VALUES(" & idSalaChat & ", '" & nombreMedico & "')")

            rs2 = conexion.Execute("select sc.idSala, e.nombreUsuario from Sala_Chat sc Join Entra e on(sc.idSala = e.idSala) where sc.idSala = " & idSalaChat.ToString & " and e.nombreUsuario In (Select nombrePaciente from Paciente)")

            rs3 = conexion.Execute("SELECT * from Sala_Chat where idSala = " & idSalaChat.ToString)
            sala.prioridad = CStr(rs3.Fields(1).Value)
            sala.medicoSala = obtenerMedicoPorNombreUsuario(nombreMedico)
            sala.pacienteSala = obtenerPacientePorNombreUsuario(CStr(rs2.Fields("nombreUsuario").Value))

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        Finally
            conexion.Close()
        End Try

        Return sala

    End Function

    Public Function solicitarChat(nombrePaciente As String, prioridad As String) As SalaChat
        ' funcion que solo usara ControladorPaciente

        Dim conexion As Connection = conectar()
        Dim sala As New SalaChat
        conexion.BeginTrans()
        Try
            Dim rs1, rs2, rs3 As Recordset
            ' se tendrá que modificar para que la prioridad sea según el duagnóstico
            rs1 = conexion.Execute("INSERT INTO Sala_Chat (Prioridad) VALUES('Alta')")

            ' debemos obtener el idSala autogenerado:
            rs2 = conexion.Execute("SELECT MAX(idSala) FROM Sala_Chat")
            Dim id As Integer = CInt(rs2.Fields(0).Value)
            sala.idSala = id
            sala.prioridad = "Alta"
            sala.pacienteSala = obtenerPacientePorNombreUsuario(nombrePaciente)
            rs3 = conexion.Execute("INSERT INTO Entra VALUES(" & id & ", '" & nombrePaciente & "')")
            conexion.CommitTrans()  ' caso de no haber errores en las 4 querys, hacemos commit
        Catch ex As Exception
            conexion.RollbackTrans()        ' caso de haber errores, hacemos un rollBack.-
            Console.WriteLine(ex.StackTrace)
            Throw ex
        Finally
            conexion.Close()
        End Try
        Return sala

    End Function

    Public Function verificarChatAceptado(idSala As Integer) As List(Of Medicos)
        Dim conexion As Connection = conectar()
        Dim medico As New Medicos()
        Dim list As New List(Of Medicos)
        Try
            Dim rs As Recordset
            rs = conexion.Execute("SELECT nombreUsuario, idSala FROM Entra " &
                "WHERE idSala=" & idSala & " AND nombreUsuario IN (select nombreMedico from Medico)")

            If rs.BOF And rs.EOF Then
                ' Si Ambas propiedades son true entonces la consulta no devolvió resultado 
                medico.nombreUsuario = ""
            Else
                ' En este punto el recordset tiene información y es seguro trabajar con el
                Dim nombreMedico As String = CStr(rs.Fields(0).Value)
                ' si se encontro un medico, debemos llenar el objeto:
                list = obtenerMedicoPorNombreUsuarios(nombreMedico)

            End If

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        Finally
            conexion.Close()
        End Try
        Return list

    End Function

    Public Function ObtenerUltimoIdMensajeGeneral() As Integer
        Dim conexion As Connection = conectar()
        Dim ultimoId As Integer = Nothing
        Try
            Dim rs As Recordset
            rs = conexion.Execute("select max(idMensaje) from Mensaje ")

            If rs.BOF And rs.EOF Then
                ' Si Ambas propiedades son true entonces la consulta no devolvió resultado 
                ultimoId = Nothing
            Else
                ' En este punto el recordset tiene información y es seguro trabajar con el
                If IsDBNull(rs.Fields(0).Value) Then
                    ultimoId = Nothing
                Else
                    ultimoId = CInt(rs.Fields(0).Value)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        Finally
            conexion.Close()
        End Try

        Return ultimoId

    End Function

    Public Function ObtenerUltimoIdMensajeDeChat(salaChat As Integer) As Integer
        Dim conexion As Connection = conectar()
        Dim ultimoId As Integer = Nothing
        Try
            Dim rs As Recordset
            rs = conexion.Execute("select max(idMensaje) from Mensaje where idSala = " & salaChat)

            If rs.BOF And rs.EOF Then
                ' Si Ambas propiedades son true entonces la consulta no devolvió resultado 
                ultimoId = Nothing
            Else
                ' En este punto el recordset tiene información y es seguro trabajar con el
                If IsDBNull(rs.Fields(0).Value) Then
                    ultimoId = Nothing
                Else
                    ultimoId = CInt(rs.Fields(0).Value)
                End If
            End If

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Throw ex
        Finally
            conexion.Close()
        End Try
        Return ultimoId

    End Function
    Public Function listaPat(sintomas) As List(Of Patologia)
        Dim conexion As Connection = conectar()
        Dim recordset As Recordset
        Dim list As New List(Of Patologia)
        For Each s As Sintoma In sintomas
            recordset = conexion.Execute("SELECT nombrePatologia FROM Contiene WHERE nombresSintoma=" + "'" + s.nombre + "'")


            While (Not recordset.EOF)
                Dim pat As New Patologia
                pat.nombre = DirectCast(recordset.Fields("nombrePatologia").Value, String)
                list.Add(pat)
                recordset.MoveNext()
            End While
        Next

        Return list
    End Function

    Public Function Diag(sintomas, patologias) As List(Of String)
        Dim conexion As Connection = conectar()
        Dim en As String
        Dim recordset As Recordset
        Dim listas As New List(Of String)
        Dim resultado As Integer
        Dim id As String
        For Each p As Patologia In patologias
            recordset = conexion.Execute("select s.nombresSintoma
from Sintoma s join Contiene c on(s.nombresSintoma=c.nombresSintoma)
join Patologia p on(c.nombrePatologia=p.nombrePatologia)
where p.nombrePatologia=" + "'" + p.nombre + "'")

            While (Not recordset.EOF)
                Dim pat As String = DirectCast(recordset.Fields("nombresSintoma").Value, String)
                For Each s As Sintoma In sintomas
                    If s.nombre = pat Then


                        resultado = resultado + 1


                    End If

                Next

                recordset.MoveNext()

            End While

            Dim op As Recordset = conexion.Execute("select count(s.nombresSintoma)
                From Sintoma s Join Contiene c on(s.nombresSintoma=c.nombresSintoma)
Join Patologia p on(c.nombrePatologia=p.nombrePatologia)
Where p.nombrePatologia =" + "'" + p.nombre + "'")
            en = DirectCast(op.Fields("count(s.nombresSintoma)").Value.ToString, String)

            id = p.nombre + ":" + resultado.ToString + " de " + en + " sintomas"

            listas.Add(id)
            resultado = 0

        Next
        Return listas
    End Function
    Public Function buscarmail()
        Dim conexion As Connection = conectar()
        Dim recordset As Recordset
        Dim s As New Pacientes

        recordset = conexion.Execute("SELECT Correo FROM Usuario where nombreUsuario=" + "'" + s.nombreus + "'")


        While (Not recordset.EOF)

            s.correo = DirectCast(recordset.Fields("Correo").Value, String)
            recordset.MoveNext()
        End While
        Return s.correo
    End Function
    Public Function buscarRecomendacion(list) As List(Of Patologia)

        Dim conexion As Connection = conectar()
        Dim recordset As Recordset
        Dim s As New Pacientes
        Dim lista As New List(Of Patologia)
        Dim p As New Patologia
        For Each p In list
            recordset = conexion.Execute("select Recomendacion from Patologia where nombrePatologia= '" + p.nombre + "';")


            While (Not recordset.EOF)

                p.recomendaciones = DirectCast(recordset.Fields("recomendacion").Value, String)
                lista.Add(p)
                recordset.MoveNext()
            End While
        Next
        Return lista
    End Function


End Class


