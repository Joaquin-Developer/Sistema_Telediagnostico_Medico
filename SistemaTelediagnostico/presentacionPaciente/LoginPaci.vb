Imports System.Runtime.InteropServices
Imports logica
Imports entidades

Public Class LoginPaci

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' no mostrar password al cargar form:
        CustomizeComponents()
        setearFormulario()

        ' traducir el formulario:
        'txtusu.Text = Traductor.Traducir("login_NombreUsuario")
        'txtpin.Text = Traductor.Traducir("login_Password")

        ' se debe hacer lo mismo con los demas controles, y con todos los formularios
    End Sub

    Public Sub setearFormulario()
        checkMostrarPassw.Checked = False
        txtpin.UseSystemPasswordChar = False
        txtpin.Text = "PIN"
        txtusu.Text = "USUARIO"
    End Sub

    Private Sub checkMostrarPassw_CheckedChanged(sender As Object, e As EventArgs) Handles checkMostrarPassw.CheckedChanged
        If checkMostrarPassw.Checked Then
            ' en caso que se quiera mostrar la password
            txtpin.UseSystemPasswordChar = True
        Else
            txtpin.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btning_Click(sender As Object, e As EventArgs) Handles btning.Click
        Try
            ControladorPaciente.instancia.LoginPaciente(txtusu.Text, txtpin.Text)
            Dim s As New Pacientes
            s.nombreus = txtusu.Text
            Me.Hide()
            Dim form As FormCarga = New FormCarga
            form.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error al iniciar sesion")
        End Try
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btning_Paint(sender As Object, e As PaintEventArgs) Handles btning.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btning.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btning.Region = New Region(buttonPath)
    End Sub

    Private Sub btning_MouseEnter(sender As Object, e As EventArgs) Handles btning.MouseEnter
        btning.BackColor = Color.FromArgb(203, 207, 255)
    End Sub

    Private Sub btning_MouseLeave(sender As Object, e As EventArgs) Handles btning.MouseLeave
        btning.BackColor = Color.FromArgb(149, 153, 232)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub CustomizeComponents()
        txtusu.AutoSize = False
        txtusu.Size = New Size(350, 30)

        txtpin.AutoSize = False
        txtpin.Size = New Size(350, 30)
    End Sub

    Private Sub txtus_Enter(sender As Object, e As EventArgs) Handles txtusu.Enter
        If txtusu.Text = "USUARIO" Then
            txtusu.Text = ""
        End If
        txtusu.ForeColor = Color.FromArgb(11, 91, 144)
    End Sub
    Private Sub txtus_Leave(sender As Object, e As EventArgs) Handles txtusu.Leave
        If txtusu.Text = "" Then
            txtusu.Text = "USUARIO"
        End If
        txtusu.ForeColor = Color.FromArgb(9, 63, 99)
    End Sub

    Private Sub txtcontra_Enter(sender As Object, e As EventArgs) Handles txtpin.Enter
        If txtpin.Text = "PIN" Then
            txtpin.Text = ""
        End If
        txtpin.ForeColor = Color.FromArgb(11, 91, 144)
        txtpin.UseSystemPasswordChar = False
    End Sub

    Private Sub txtcontra_Leave(sender As Object, e As EventArgs) Handles txtpin.Leave
        If txtpin.Text = "" Then
            txtpin.Text = "PIN"
        End If
        txtpin.ForeColor = Color.FromArgb(9, 63, 99)
        txtpin.UseSystemPasswordChar = True
    End Sub

    Private Sub btnSal_Click(sender As Object, e As EventArgs) Handles btnSal.Click
        If MsgBox("¿Desea cerrar la aplicación?", vbQuestion + vbYesNo, "Confirmar Cierre") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim s As New Traductor
        s.idiomas = Me.ComboBox1.Text
        Traductor.TraducirForm(Me)
        Traductor.TraducirPanel(Panel1)
        Traductor.TraducirPanel(Panel2)
        Traductor.TraducirPanel(Panel3)
        Traductor.TraducirPanel(titleBar)
    End Sub
End Class
