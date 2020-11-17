<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPaci
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCreditos = New System.Windows.Forms.Label()
        Me.titleBar = New System.Windows.Forms.Panel()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnSal = New System.Windows.Forms.Button()
        Me.btning = New System.Windows.Forms.Button()
        Me.checkMostrarPassw = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.txtusu = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.titleBar.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblCreditos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 323)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(764, 24)
        Me.Panel2.TabIndex = 8
        '
        'lblCreditos
        '
        Me.lblCreditos.AutoSize = True
        Me.lblCreditos.ForeColor = System.Drawing.Color.White
        Me.lblCreditos.Location = New System.Drawing.Point(14, 0)
        Me.lblCreditos.Name = "lblCreditos"
        Me.lblCreditos.Size = New System.Drawing.Size(136, 13)
        Me.lblCreditos.TabIndex = 6
        Me.lblCreditos.Text = "Desarrollado por Tech-Vibe"
        '
        'titleBar
        '
        Me.titleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.titleBar.Controls.Add(Me.lblLogin)
        Me.titleBar.Controls.Add(Me.btnMin)
        Me.titleBar.Controls.Add(Me.btnSal)
        Me.titleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleBar.Location = New System.Drawing.Point(0, 0)
        Me.titleBar.Name = "titleBar"
        Me.titleBar.Size = New System.Drawing.Size(764, 45)
        Me.titleBar.TabIndex = 9
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(12, 9)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(235, 31)
        Me.lblLogin.TabIndex = 12
        Me.lblLogin.Text = "L O G I N - P A C I E N T E"
        '
        'btnMin
        '
        Me.btnMin.BackgroundImage = Global.presentacionPaciente.My.Resources.Resources.Icono_Minimizar
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(689, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(33, 33)
        Me.btnMin.TabIndex = 5
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnSal
        '
        Me.btnSal.BackgroundImage = Global.presentacionPaciente.My.Resources.Resources.ICON_CERRARF
        Me.btnSal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSal.FlatAppearance.BorderSize = 0
        Me.btnSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSal.Location = New System.Drawing.Point(728, 3)
        Me.btnSal.Name = "btnSal"
        Me.btnSal.Size = New System.Drawing.Size(33, 33)
        Me.btnSal.TabIndex = 4
        Me.btnSal.UseVisualStyleBackColor = True
        '
        'btning
        '
        Me.btning.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btning.FlatAppearance.BorderSize = 0
        Me.btning.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btning.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btning.Location = New System.Drawing.Point(375, 248)
        Me.btning.Name = "btning"
        Me.btning.Size = New System.Drawing.Size(350, 50)
        Me.btning.TabIndex = 3
        Me.btning.Text = "INICIAR SESIÓN"
        Me.btning.UseVisualStyleBackColor = False
        '
        'checkMostrarPassw
        '
        Me.checkMostrarPassw.AutoSize = True
        Me.checkMostrarPassw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkMostrarPassw.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.checkMostrarPassw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.checkMostrarPassw.Location = New System.Drawing.Point(652, 182)
        Me.checkMostrarPassw.Name = "checkMostrarPassw"
        Me.checkMostrarPassw.Size = New System.Drawing.Size(76, 20)
        Me.checkMostrarPassw.TabIndex = 0
        Me.checkMostrarPassw.Text = "Mostrar PIN"
        Me.checkMostrarPassw.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(375, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 1)
        Me.Panel1.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(375, 124)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 1)
        Me.Panel3.TabIndex = 21
        '
        'txtpin
        '
        Me.txtpin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpin.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtpin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtpin.Location = New System.Drawing.Point(375, 154)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Size = New System.Drawing.Size(350, 22)
        Me.txtpin.TabIndex = 2
        Me.txtpin.Text = "PIN"
        '
        'txtusu
        '
        Me.txtusu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusu.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtusu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtusu.Location = New System.Drawing.Point(375, 103)
        Me.txtusu.Name = "txtusu"
        Me.txtusu.Size = New System.Drawing.Size(350, 22)
        Me.txtusu.TabIndex = 1
        Me.txtusu.Text = "USUARIO"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.presentacionPaciente.My.Resources.Resources.Logo_OSLER
        Me.PictureBox3.Location = New System.Drawing.Point(12, 51)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(313, 247)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Español", "English"})
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Español" & Global.Microsoft.VisualBasic.ChrW(9), "English"})
        Me.ComboBox1.Location = New System.Drawing.Point(604, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 34)
        Me.ComboBox1.TabIndex = 24
        Me.ComboBox1.Text = "Lenguaje"
        '
        'LoginPaci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 347)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.checkMostrarPassw)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtpin)
        Me.Controls.Add(Me.txtusu)
        Me.Controls.Add(Me.btning)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.titleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginPaci"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginPaci"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.titleBar.ResumeLayout(False)
        Me.titleBar.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCreditos As Label
    Friend WithEvents titleBar As Panel
    Friend WithEvents lblLogin As Label
    Friend WithEvents btnMin As Button
    Friend WithEvents btnSal As Button
    Friend WithEvents btning As Button
    Friend WithEvents checkMostrarPassw As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtpin As TextBox
    Friend WithEvents txtusu As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
