<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppPaci
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppPaci))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.checkdiag = New System.Windows.Forms.CheckedListBox()
        Me.timerNotificarChatAceptado = New System.Windows.Forms.Timer(Me.components)
        Me.panelBarraT = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnres = New System.Windows.Forms.Button()
        Me.tmMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.tmOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnchat = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarS = New System.Windows.Forms.Button()
        Me.btndiag = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.panelBarraT.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(563, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 26)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Enfermedades que puede padecer:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(285, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 26)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Sintomas que padece"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 26
        Me.ListBox1.Location = New System.Drawing.Point(545, 92)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(333, 446)
        Me.ListBox1.TabIndex = 12
        '
        'checkdiag
        '
        Me.checkdiag.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.checkdiag.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.checkdiag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.checkdiag.FormattingEnabled = True
        Me.checkdiag.Location = New System.Drawing.Point(228, 92)
        Me.checkdiag.Name = "checkdiag"
        Me.checkdiag.Size = New System.Drawing.Size(311, 436)
        Me.checkdiag.TabIndex = 10
        '
        'timerNotificarChatAceptado
        '
        Me.timerNotificarChatAceptado.Interval = 500
        '
        'panelBarraT
        '
        Me.panelBarraT.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.panelBarraT.Controls.Add(Me.btnMin)
        Me.panelBarraT.Controls.Add(Me.Label3)
        Me.panelBarraT.Controls.Add(Me.btnMax)
        Me.panelBarraT.Controls.Add(Me.btnres)
        Me.panelBarraT.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBarraT.Location = New System.Drawing.Point(0, 0)
        Me.panelBarraT.Name = "panelBarraT"
        Me.panelBarraT.Size = New System.Drawing.Size(885, 40)
        Me.panelBarraT.TabIndex = 16
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackgroundImage = CType(resources.GetObject("btnMin.BackgroundImage"), System.Drawing.Image)
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(801, 5)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(42, 29)
        Me.btnMin.TabIndex = 13
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "M E N U  D E  P A C I E N T E S"
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackgroundImage = Global.presentacionPaciente.My.Resources.Resources.Icono_Maximizar
        Me.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Location = New System.Drawing.Point(840, 5)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(42, 29)
        Me.btnMax.TabIndex = 12
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnres
        '
        Me.btnres.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnres.BackgroundImage = Global.presentacionPaciente.My.Resources.Resources.Icono_Restaurar
        Me.btnres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnres.FlatAppearance.BorderSize = 0
        Me.btnres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnres.Location = New System.Drawing.Point(840, 5)
        Me.btnres.Name = "btnres"
        Me.btnres.Size = New System.Drawing.Size(42, 29)
        Me.btnres.TabIndex = 11
        Me.btnres.UseVisualStyleBackColor = True
        '
        'tmMostrar
        '
        Me.tmMostrar.Interval = 15
        '
        'tmOcultar
        '
        Me.tmOcultar.Interval = 15
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(2, 469)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(4, 36)
        Me.Panel5.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-6, 222)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(4, 73)
        Me.Panel2.TabIndex = 21
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.Panel3)
        Me.panelMenu.Controls.Add(Me.btnchat)
        Me.panelMenu.Controls.Add(Me.Panel2)
        Me.panelMenu.Controls.Add(Me.Panel1)
        Me.panelMenu.Controls.Add(Me.btnCerrarS)
        Me.panelMenu.Controls.Add(Me.btndiag)
        Me.panelMenu.Controls.Add(Me.Panel5)
        Me.panelMenu.Controls.Add(Me.btnMenu)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 40)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 517)
        Me.panelMenu.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 146)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(4, 73)
        Me.Panel3.TabIndex = 23
        '
        'btnchat
        '
        Me.btnchat.FlatAppearance.BorderSize = 0
        Me.btnchat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnchat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchat.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnchat.ForeColor = System.Drawing.Color.White
        Me.btnchat.Image = Global.presentacionPaciente.My.Resources.Resources.chat
        Me.btnchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnchat.Location = New System.Drawing.Point(5, 146)
        Me.btnchat.Name = "btnchat"
        Me.btnchat.Size = New System.Drawing.Size(217, 73)
        Me.btnchat.TabIndex = 22
        Me.btnchat.Text = "           Chatear"
        Me.btnchat.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(4, 73)
        Me.Panel1.TabIndex = 19
        '
        'btnCerrarS
        '
        Me.btnCerrarS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarS.BackgroundImage = Global.presentacionPaciente.My.Resources.Resources.cerrarSesión
        Me.btnCerrarS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrarS.FlatAppearance.BorderSize = 0
        Me.btnCerrarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarS.Location = New System.Drawing.Point(12, 469)
        Me.btnCerrarS.Name = "btnCerrarS"
        Me.btnCerrarS.Size = New System.Drawing.Size(35, 36)
        Me.btnCerrarS.TabIndex = 10
        Me.btnCerrarS.UseVisualStyleBackColor = True
        '
        'btndiag
        '
        Me.btndiag.FlatAppearance.BorderSize = 0
        Me.btndiag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btndiag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btndiag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndiag.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btndiag.ForeColor = System.Drawing.Color.White
        Me.btndiag.Image = Global.presentacionPaciente.My.Resources.Resources.informe
        Me.btndiag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndiag.Location = New System.Drawing.Point(5, 67)
        Me.btndiag.Name = "btndiag"
        Me.btndiag.Size = New System.Drawing.Size(217, 73)
        Me.btndiag.TabIndex = 18
        Me.btndiag.Text = "           Diagnostico"
        Me.btndiag.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.presentacionPaciente.My.Resources.Resources.Menu_icon_icons_com_55865
        Me.btnMenu.Location = New System.Drawing.Point(185, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(32, 32)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.TabStop = False
        '
        'AppPaci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(885, 557)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelBarraT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.checkdiag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AppPaci"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppPaci"
        Me.panelBarraT.ResumeLayout(False)
        Me.panelBarraT.PerformLayout()
        Me.panelMenu.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents checkdiag As CheckedListBox
    Friend WithEvents timerNotificarChatAceptado As Timer
    Friend WithEvents panelBarraT As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tmMostrar As Timer
    Friend WithEvents tmOcultar As Timer
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnres As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btndiag As Button
    Friend WithEvents btnCerrarS As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelMenu As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnchat As Button
    Friend WithEvents Panel1 As Panel
End Class
