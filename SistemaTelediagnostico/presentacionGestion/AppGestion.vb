Imports logica
Imports entidades

Imports System.Runtime.InteropServices
Public Class AppGestion
    Private Sub AppGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmFecha.Enabled = True
        Traductor.TraducirForm(Me)
        Traductor.TraducirPanel(panelMenu)
        Traductor.TraducirPanel(panelBarraT)
    End Sub
    Private Sub btnpato_Click(sender As Object, e As EventArgs) Handles btnpato.Click
        'Muestra Patologías y hasta que no se cierre no se puede utilizar este
        AbrirFormEnPanel(Of Patologias)()
        btnpato.BackColor = Color.FromArgb(13, 93, 142)
    End Sub

    Private Sub btnsinto_Click(sender As Object, e As EventArgs) Handles btnsinto.Click
        'Muestra Sintomas y hasta que no se cierre no se puede utilizar este
        AbrirFormEnPanel(Of Sintomas)()
        btnsinto.BackColor = Color.FromArgb(13, 93, 142)
    End Sub
    Private Sub btnpaci_Click(sender As Object, e As EventArgs) Handles btnpaci.Click
        AbrirFormEnPanel(Of Paciente)()
        btnpaci.BackColor = Color.FromArgb(13, 93, 142)
    End Sub

    Private Sub btnmedi_Click(sender As Object, e As EventArgs) Handles btnmedi.Click
        AbrirFormEnPanel(Of Medico)()
        btnmedi.BackColor = Color.FromArgb(13, 93, 142)
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If panelMenu.Width = 220 Then
            tmOcultar.Enabled = True
        ElseIf panelMenu.Width = 80 Then
            tmMostrar.Enabled = True
        End If
    End Sub

    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = panelContenedor.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            panelContenedor.Controls.Add(Formulario)
            panelContenedor.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelBarraT_MouseMove(sender As Object, e As MouseEventArgs) Handles panelBarraT.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmOcultar_Tick(sender As Object, e As EventArgs) Handles tmOcultar.Tick
        If panelMenu.Width <= 80 Then
            Me.tmOcultar.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width - 5
        End If
    End Sub

    Private Sub tmMostrar_Tick(sender As Object, e As EventArgs) Handles tmMostrar.Tick
        If panelMenu.Width >= 220 Then
            Me.tmMostrar.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width + 5
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrarS_Paint(sender As Object, e As PaintEventArgs) Handles btnCerrarS.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnCerrarS.ClientRectangle
        myRectangle.Inflate(0, 0)
        buttonPath.AddEllipse(myRectangle)
        btnCerrarS.Region = New Region(buttonPath)
    End Sub

    Private Sub btnCerrarS_Click(sender As Object, e As EventArgs) Handles btnCerrarS.Click
        If MsgBox("¿Esta seguro que desea cerrar su sesión?", vbQuestion + vbYesNo, "Cerrar Sesión") = MsgBoxResult.Yes Then

            Dim form As New FormLogin
            form.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        btnMax.Visible = False
        btnres.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub btnres_Click(sender As Object, e As EventArgs) Handles btnres.Click
        Me.WindowState = FormWindowState.Normal
        btnres.Visible = False
        btnMax.Visible = True
    End Sub
    Private Sub tmFecha_Tick(sender As Object, e As EventArgs) Handles tmFecha.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()
    End Sub
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If (Application.OpenForms("Medico") Is Nothing) Then
            btnmedi.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Paciente") Is Nothing) Then
            btnpaci.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Patologias") Is Nothing) Then
            btnpato.BackColor = Color.FromArgb(37, 46, 59)
        End If
        If (Application.OpenForms("Sintomas") Is Nothing) Then
            btnsinto.BackColor = Color.FromArgb(37, 46, 59)
        End If
    End Sub
End Class
