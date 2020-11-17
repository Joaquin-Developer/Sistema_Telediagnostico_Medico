Imports System.Runtime.InteropServices
Imports entidades
Imports presentacionMedico
Imports presentacionPaciente
Imports logica

Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' no mostrar password al cargar form:
        txtPassword.UseSystemPasswordChar = True
        checkMostrarPassw.Checked = False
        CustomizeComponents()
        setearFormulario()
        Traductor.TraducirForm(Me)
        Traductor.TraducirPanel(titleBar)
        Traductor.TraducirPanel(Panel1)
        ' traducir el formulario:
        'txtNombreUsuario.Text = Traductor.Traducir("login_NombreUsuario")
        'txtPassword.Text = Traductor.Traducir("login_Password")

        ' se debe hacer lo mismo con los demas controles, y con todos los formularios

        ' seguir Traduciendo . . . 



    End Sub

    Private Sub checkMostrarPassw_CheckedChanged(sender As Object, e As EventArgs) Handles checkMostrarPassw.CheckedChanged
        If checkMostrarPassw.Checked Then
            ' en caso que se quiera mostrar la password
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim s As New Administrador
            s.nombreus = txtNombreUsuario.Text
            ControladorAdministrador.instancia.LoginAdmin(txtNombreUsuario.Text, txtPassword.Text)
            Me.Hide()
            Dim form As FormCarga = New FormCarga
            form.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error al iniciar sesion")
        End Try
    End Sub

    Private Sub btnSal_Click(sender As Object, e As EventArgs) Handles btnSal.Click
        If MsgBox("¿Desea cerrar la aplicación?", vbQuestion + vbYesNo, "Confirmar Cierre") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub setearFormulario()
        checkMostrarPassw.Checked = False
        txtPassword.Text = "CONTRASEÑA"
        txtNombreUsuario.Text = "USUARIO"
        txtPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub CustomizeComponents()
        txtNombreUsuario.AutoSize = False
        txtNombreUsuario.Size = New Size(350, 30)

        txtPassword.AutoSize = False
        txtPassword.Size = New Size(350, 30)
    End Sub

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.FromArgb(203, 207, 255)
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.FromArgb(149, 153, 232)
    End Sub

    Private Sub txtNombreUsuario_Enter(sender As Object, e As EventArgs) Handles txtNombreUsuario.Enter
        If txtNombreUsuario.Text = "USUARIO" Then
            txtNombreUsuario.Text = ""
        End If
        txtNombreUsuario.ForeColor = Color.FromArgb(11, 91, 144)
    End Sub

    Private Sub txtNombreUsuario_Leave(sender As Object, e As EventArgs) Handles txtNombreUsuario.Leave
        If txtNombreUsuario.Text = "" Then
            txtNombreUsuario.Text = "USUARIO"
        End If
        txtNombreUsuario.ForeColor = Color.FromArgb(9, 63, 99)
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "CONTRASEÑA" Then
            txtPassword.Text = ""
        End If
        txtPassword.ForeColor = Color.FromArgb(11, 91, 144)
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "CONTRASEÑA"
        End If
        txtPassword.ForeColor = Color.FromArgb(9, 63, 99)
        txtPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        '' MessageBox.Show(valor)
        Dim s As New Traductor
        s.idiomas = Me.ComboBox1.Text
        Traductor.TraducirForm(Me)
        Traductor.TraducirPanel(Panel1)
        Traductor.TraducirPanel(Panel2)
        Traductor.TraducirPanel(Panel3)
        Traductor.TraducirPanel(titleBar)

    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click

    End Sub
End Class
