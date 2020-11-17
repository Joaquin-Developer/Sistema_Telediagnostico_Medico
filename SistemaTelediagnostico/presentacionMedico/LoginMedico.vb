Imports System.Runtime.InteropServices
Imports logica
Imports entidades
Public Class LoginMedico

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setearFormulario()
        CustomizeComponents()

        ' traducir el formulario:
        'txtus.Text = Traductor.Traducir("login_NombreUsuario")
        'txtcontra.Text = Traductor.Traducir("login_Password")

        ' se debe hacer lo mismo con los demas controles, y con todos los formularios

        ' seguir traduciendo . . . 


    End Sub

    Private Sub btning_Click(sender As Object, e As EventArgs) Handles btning.Click
        Try
            Dim s As New Medicos
            s.nombreus = txtus.Text
            ControladorMedico.instancia.LoginMedico(txtus.Text, txtcontra.Text)
            Dim form As FormCarga = New FormCarga
            Me.Hide()
            form.ShowDialog()
        Catch ex As Exception
            MsgBox(Traductor.Traducir("Error al iniciar sesion"))
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

    Private Sub checkMostrarPassw_CheckedChanged(sender As Object, e As EventArgs) Handles checkMostrarPassw.CheckedChanged
        If checkMostrarPassw.Checked Then
            ' en caso que se quiera mostrar la password
            txtcontra.UseSystemPasswordChar = False
        Else
            txtcontra.UseSystemPasswordChar = True
        End If
    End Sub

    Public Sub setearFormulario()
        checkMostrarPassw.Checked = False
        txtcontra.Text = "CONTRASEÑA"
        txtus.Text = "USUARIO"
        txtcontra.UseSystemPasswordChar = False
    End Sub

    Private Sub CustomizeComponents()
        txtus.AutoSize = False
        txtus.Size = New Size(350, 30)

        txtcontra.AutoSize = False
        txtcontra.Size = New Size(350, 30)
    End Sub

    Private Sub txtus_Enter(sender As Object, e As EventArgs) Handles txtus.Enter
        If txtus.Text = "USUARIO" Then
            txtus.Text = ""
        End If
        txtus.ForeColor = Color.FromArgb(11, 91, 144)
    End Sub

    Private Sub txtus_Leave(sender As Object, e As EventArgs) Handles txtus.Leave
        If txtus.Text = "" Then
            txtus.Text = "USUARIO"
        End If
        txtus.ForeColor = Color.FromArgb(9, 63, 99)
    End Sub

    Private Sub txtcontra_Enter(sender As Object, e As EventArgs) Handles txtcontra.Enter
        If txtcontra.Text = "CONTRASEÑA" Then
            txtcontra.Text = ""
        End If
        txtcontra.ForeColor = Color.FromArgb(11, 91, 144)
        txtcontra.UseSystemPasswordChar = True
    End Sub

    Private Sub txtcontra_Leave(sender As Object, e As EventArgs) Handles txtcontra.Leave
        If txtcontra.Text = "" Then
            txtcontra.Text = "CONTRASEÑA"
        End If
        txtcontra.ForeColor = Color.FromArgb(9, 63, 99)
        txtcontra.UseSystemPasswordChar = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim s As New Traductor
        s.idiomas = Me.ComboBox1.Text
        Traductor.TraducirForm(Me)
    End Sub
End Class
