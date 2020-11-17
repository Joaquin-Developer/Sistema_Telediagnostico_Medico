<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormChatMedico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblInfoSesion = New System.Windows.Forms.Label()
        Me.TimerNuevosMensajes = New System.Windows.Forms.Timer(Me.components)
        Me.btnEnviarMensaje = New System.Windows.Forms.Button()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.panelBarraT = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnSal = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.richTxtChat = New System.Windows.Forms.RichTextBox()
        Me.panelBarraT.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfoSesion
        '
        Me.lblInfoSesion.AutoSize = True
        Me.lblInfoSesion.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.lblInfoSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblInfoSesion.Location = New System.Drawing.Point(13, 59)
        Me.lblInfoSesion.Name = "lblInfoSesion"
        Me.lblInfoSesion.Size = New System.Drawing.Size(172, 24)
        Me.lblInfoSesion.TabIndex = 7
        Me.lblInfoSesion.Text = "Información de la sesión"
        '
        'TimerNuevosMensajes
        '
        '
        'btnEnviarMensaje
        '
        Me.btnEnviarMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEnviarMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarMensaje.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.btnEnviarMensaje.ForeColor = System.Drawing.Color.White
        Me.btnEnviarMensaje.Location = New System.Drawing.Point(665, 552)
        Me.btnEnviarMensaje.Name = "btnEnviarMensaje"
        Me.btnEnviarMensaje.Size = New System.Drawing.Size(173, 30)
        Me.btnEnviarMensaje.TabIndex = 27
        Me.btnEnviarMensaje.Text = "Enviar"
        Me.btnEnviarMensaje.UseVisualStyleBackColor = False
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtMensaje.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtMensaje.Location = New System.Drawing.Point(16, 555)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(643, 27)
        Me.txtMensaje.TabIndex = 28
        '
        'panelBarraT
        '
        Me.panelBarraT.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.panelBarraT.Controls.Add(Me.btnMin)
        Me.panelBarraT.Controls.Add(Me.btnSal)
        Me.panelBarraT.Controls.Add(Me.Label3)
        Me.panelBarraT.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBarraT.Location = New System.Drawing.Point(0, 0)
        Me.panelBarraT.Name = "panelBarraT"
        Me.panelBarraT.Size = New System.Drawing.Size(849, 40)
        Me.panelBarraT.TabIndex = 30
        '
        'btnMin
        '
        Me.btnMin.BackgroundImage = Global.presentacionMedico.My.Resources.Resources.Icono_Minimizar
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(766, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(33, 33)
        Me.btnMin.TabIndex = 33
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnSal
        '
        Me.btnSal.BackgroundImage = Global.presentacionMedico.My.Resources.Resources.volver
        Me.btnSal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSal.FlatAppearance.BorderSize = 0
        Me.btnSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSal.Location = New System.Drawing.Point(805, 9)
        Me.btnSal.Name = "btnSal"
        Me.btnSal.Size = New System.Drawing.Size(33, 21)
        Me.btnSal.TabIndex = 32
        Me.btnSal.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 31)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "C H A T"
        '
        'richTxtChat
        '
        Me.richTxtChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.richTxtChat.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.richTxtChat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.richTxtChat.Location = New System.Drawing.Point(17, 100)
        Me.richTxtChat.Name = "richTxtChat"
        Me.richTxtChat.Size = New System.Drawing.Size(822, 433)
        Me.richTxtChat.TabIndex = 31
        Me.richTxtChat.Text = ""
        '
        'FormChatMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(849, 616)
        Me.Controls.Add(Me.richTxtChat)
        Me.Controls.Add(Me.panelBarraT)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.btnEnviarMensaje)
        Me.Controls.Add(Me.lblInfoSesion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormChatMedico"
        Me.Text = "FormChatMedico"
        Me.panelBarraT.ResumeLayout(False)
        Me.panelBarraT.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfoSesion As Label
    Friend WithEvents TimerNuevosMensajes As Timer
    Friend WithEvents btnEnviarMensaje As Button
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents panelBarraT As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMin As Button
    Friend WithEvents btnSal As Button
    Friend WithEvents richTxtChat As RichTextBox
End Class
