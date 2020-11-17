<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChatPaciente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerNuevosMensajes = New System.Windows.Forms.Timer(Me.components)
        Me.btnEnviarMensaje = New System.Windows.Forms.Button()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.richTxtChat = New System.Windows.Forms.RichTextBox()
        Me.lblInfoSesion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSal = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnEnviarMensaje.Location = New System.Drawing.Point(664, 574)
        Me.btnEnviarMensaje.Name = "btnEnviarMensaje"
        Me.btnEnviarMensaje.Size = New System.Drawing.Size(173, 30)
        Me.btnEnviarMensaje.TabIndex = 28
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
        Me.txtMensaje.Location = New System.Drawing.Point(12, 574)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(643, 27)
        Me.txtMensaje.TabIndex = 29
        '
        'richTxtChat
        '
        Me.richTxtChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.richTxtChat.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.richTxtChat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.richTxtChat.Location = New System.Drawing.Point(15, 122)
        Me.richTxtChat.Name = "richTxtChat"
        Me.richTxtChat.Size = New System.Drawing.Size(822, 433)
        Me.richTxtChat.TabIndex = 32
        Me.richTxtChat.Text = ""
        '
        'lblInfoSesion
        '
        Me.lblInfoSesion.AutoSize = True
        Me.lblInfoSesion.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.lblInfoSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblInfoSesion.Location = New System.Drawing.Point(12, 78)
        Me.lblInfoSesion.Name = "lblInfoSesion"
        Me.lblInfoSesion.Size = New System.Drawing.Size(171, 20)
        Me.lblInfoSesion.TabIndex = 33
        Me.lblInfoSesion.Text = "Información de la sesión"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 40)
        Me.Panel1.TabIndex = 34
        '
        'btnMin
        '
        Me.btnMin.BackgroundImage = Global.presentacionPaciente.My.Resources.Resources.Icono_Minimizar
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMin.Location = New System.Drawing.Point(765, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(33, 33)
        Me.btnMin.TabIndex = 36
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 25)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "C H A T"
        '
        'btnSal
        '
        Me.btnSal.BackgroundImage = Global.presentacionPaciente.My.Resources.Resources.volver
        Me.btnSal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSal.FlatAppearance.BorderSize = 0
        Me.btnSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSal.Location = New System.Drawing.Point(804, 9)
        Me.btnSal.Name = "btnSal"
        Me.btnSal.Size = New System.Drawing.Size(33, 21)
        Me.btnSal.TabIndex = 35
        Me.btnSal.UseVisualStyleBackColor = True
        '
        'FormChatPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 616)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblInfoSesion)
        Me.Controls.Add(Me.richTxtChat)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.btnEnviarMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormChatPaciente"
        Me.Text = "Sesión de Chat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerNuevosMensajes As Timer
    Friend WithEvents btnEnviarMensaje As Button
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents richTxtChat As RichTextBox
    Friend WithEvents lblInfoSesion As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSal As Button
    Friend WithEvents btnMin As Button
End Class
