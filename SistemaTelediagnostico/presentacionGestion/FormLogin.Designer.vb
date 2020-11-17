<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.checkMostrarPassw = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblCreditos = New System.Windows.Forms.Label()
        Me.titleBar = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnSal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.titleBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(12, 9)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(248, 25)
        Me.lblLogin.TabIndex = 7
        Me.lblLogin.Text = "LOGIN - ADMINISTRADOR"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtNombreUsuario.Location = New System.Drawing.Point(375, 103)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(350, 22)
        Me.txtNombreUsuario.TabIndex = 1
        Me.txtNombreUsuario.Text = "USUARIO"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(375, 154)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(350, 22)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "CONTRASEÑA"
        '
        'checkMostrarPassw
        '
        Me.checkMostrarPassw.AutoSize = True
        Me.checkMostrarPassw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkMostrarPassw.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.checkMostrarPassw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.checkMostrarPassw.Location = New System.Drawing.Point(620, 182)
        Me.checkMostrarPassw.Name = "checkMostrarPassw"
        Me.checkMostrarPassw.Size = New System.Drawing.Size(105, 16)
        Me.checkMostrarPassw.TabIndex = 4
        Me.checkMostrarPassw.Text = "Mostrar contraseña"
        Me.checkMostrarPassw.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(375, 248)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(350, 50)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "INICIAR SESIÓN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblCreditos
        '
        Me.lblCreditos.AutoSize = True
        Me.lblCreditos.ForeColor = System.Drawing.Color.White
        Me.lblCreditos.Location = New System.Drawing.Point(3, 2)
        Me.lblCreditos.Name = "lblCreditos"
        Me.lblCreditos.Size = New System.Drawing.Size(136, 13)
        Me.lblCreditos.TabIndex = 11
        Me.lblCreditos.Text = "Desarrollado por Tech Vibe"
        '
        'titleBar
        '
        Me.titleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.titleBar.Controls.Add(Me.btnMin)
        Me.titleBar.Controls.Add(Me.btnSal)
        Me.titleBar.Controls.Add(Me.lblLogin)
        Me.titleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleBar.Location = New System.Drawing.Point(0, 0)
        Me.titleBar.Name = "titleBar"
        Me.titleBar.Size = New System.Drawing.Size(764, 45)
        Me.titleBar.TabIndex = 12
        '
        'btnMin
        '
        Me.btnMin.BackgroundImage = Global.presentacionGestion.My.Resources.Resources.Icono_Minimizar
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(682, 8)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(33, 33)
        Me.btnMin.TabIndex = 9
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnSal
        '
        Me.btnSal.BackgroundImage = Global.presentacionGestion.My.Resources.Resources.ICON_CERRARF
        Me.btnSal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSal.FlatAppearance.BorderSize = 0
        Me.btnSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSal.Location = New System.Drawing.Point(721, 8)
        Me.btnSal.Name = "btnSal"
        Me.btnSal.Size = New System.Drawing.Size(33, 33)
        Me.btnSal.TabIndex = 8
        Me.btnSal.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblCreditos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 323)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 24)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(375, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(350, 1)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(375, 175)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 1)
        Me.Panel3.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.presentacionGestion.My.Resources.Resources.Logo_OSLER
        Me.PictureBox1.Location = New System.Drawing.Point(17, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 243)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Español", "English"})
        Me.ComboBox1.Location = New System.Drawing.Point(620, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 29)
        Me.ComboBox1.TabIndex = 17
        Me.ComboBox1.Text = "Lenguaje"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 347)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.titleBar)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.checkMostrarPassw)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Telediagnóstico"
        Me.titleBar.ResumeLayout(False)
        Me.titleBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents checkMostrarPassw As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblCreditos As Label
    Friend WithEvents titleBar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSal As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
