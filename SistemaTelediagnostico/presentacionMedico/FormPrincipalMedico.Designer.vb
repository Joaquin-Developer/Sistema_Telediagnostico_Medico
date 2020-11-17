<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipalMedico
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipalMedico))
        Me.timerActualizarPeticiones = New System.Windows.Forms.Timer(Me.components)
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgViewPeticiones = New System.Windows.Forms.DataGridView()
        Me.panelBarraT = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnres = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnIniciarChat = New System.Windows.Forms.Button()
        Me.btnCerrarS = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.tmOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrar = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgViewPeticiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBarraT.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerActualizarPeticiones
        '
        Me.timerActualizarPeticiones.Interval = 1000
        '
        'txtID
        '
        Me.txtID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(415, 554)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(523, 29)
        Me.txtID.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(248, 556)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 26)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Elegir solicitud por ID: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(248, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 26)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Lista de solicitudes de Chat:"
        '
        'dgViewPeticiones
        '
        Me.dgViewPeticiones.AllowUserToResizeColumns = False
        Me.dgViewPeticiones.AllowUserToResizeRows = False
        Me.dgViewPeticiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgViewPeticiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgViewPeticiones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.dgViewPeticiones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgViewPeticiones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgViewPeticiones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgViewPeticiones.ColumnHeadersHeight = 40
        Me.dgViewPeticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgViewPeticiones.EnableHeadersVisualStyles = False
        Me.dgViewPeticiones.GridColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.dgViewPeticiones.Location = New System.Drawing.Point(252, 105)
        Me.dgViewPeticiones.Name = "dgViewPeticiones"
        Me.dgViewPeticiones.ReadOnly = True
        Me.dgViewPeticiones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(130, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgViewPeticiones.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgViewPeticiones.RowHeadersWidth = 30
        Me.dgViewPeticiones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgViewPeticiones.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgViewPeticiones.Size = New System.Drawing.Size(686, 416)
        Me.dgViewPeticiones.StandardTab = True
        Me.dgViewPeticiones.TabIndex = 21
        '
        'panelBarraT
        '
        Me.panelBarraT.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.panelBarraT.Controls.Add(Me.Label3)
        Me.panelBarraT.Controls.Add(Me.btnMin)
        Me.panelBarraT.Controls.Add(Me.btnMax)
        Me.panelBarraT.Controls.Add(Me.btnres)
        Me.panelBarraT.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBarraT.Location = New System.Drawing.Point(0, 0)
        Me.panelBarraT.Name = "panelBarraT"
        Me.panelBarraT.Size = New System.Drawing.Size(966, 40)
        Me.panelBarraT.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 31)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "M E N U  D E  M É D I C O S"
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackgroundImage = CType(resources.GetObject("btnMin.BackgroundImage"), System.Drawing.Image)
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(873, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(42, 29)
        Me.btnMin.TabIndex = 30
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackgroundImage = Global.presentacionMedico.My.Resources.Resources.Icono_Maximizar
        Me.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Location = New System.Drawing.Point(921, 3)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(42, 29)
        Me.btnMax.TabIndex = 29
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnres
        '
        Me.btnres.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnres.BackgroundImage = Global.presentacionMedico.My.Resources.Resources.Icono_Restaurar
        Me.btnres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnres.FlatAppearance.BorderSize = 0
        Me.btnres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnres.Location = New System.Drawing.Point(921, 3)
        Me.btnres.Name = "btnres"
        Me.btnres.Size = New System.Drawing.Size(42, 29)
        Me.btnres.TabIndex = 28
        Me.btnres.UseVisualStyleBackColor = True
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.Panel1)
        Me.panelMenu.Controls.Add(Me.btnIniciarChat)
        Me.panelMenu.Controls.Add(Me.btnCerrarS)
        Me.panelMenu.Controls.Add(Me.Panel5)
        Me.panelMenu.Controls.Add(Me.btnMenu)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 40)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 563)
        Me.panelMenu.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(4, 73)
        Me.Panel1.TabIndex = 28
        '
        'btnIniciarChat
        '
        Me.btnIniciarChat.FlatAppearance.BorderSize = 0
        Me.btnIniciarChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnIniciarChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnIniciarChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarChat.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnIniciarChat.ForeColor = System.Drawing.Color.White
        Me.btnIniciarChat.Image = Global.presentacionMedico.My.Resources.Resources.chat2
        Me.btnIniciarChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIniciarChat.Location = New System.Drawing.Point(3, 65)
        Me.btnIniciarChat.Name = "btnIniciarChat"
        Me.btnIniciarChat.Size = New System.Drawing.Size(217, 73)
        Me.btnIniciarChat.TabIndex = 27
        Me.btnIniciarChat.Text = "           Iniciar Chat"
        Me.btnIniciarChat.UseVisualStyleBackColor = True
        '
        'btnCerrarS
        '
        Me.btnCerrarS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarS.BackgroundImage = Global.presentacionMedico.My.Resources.Resources.cerrarSesión
        Me.btnCerrarS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrarS.FlatAppearance.BorderSize = 0
        Me.btnCerrarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarS.Location = New System.Drawing.Point(12, 518)
        Me.btnCerrarS.Name = "btnCerrarS"
        Me.btnCerrarS.Size = New System.Drawing.Size(35, 36)
        Me.btnCerrarS.TabIndex = 20
        Me.btnCerrarS.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(2, 518)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(4, 36)
        Me.Panel5.TabIndex = 19
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackgroundImage = Global.presentacionMedico.My.Resources.Resources.Menu_icon_icons_com_55865
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.ErrorImage = Nothing
        Me.btnMenu.Location = New System.Drawing.Point(185, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(32, 32)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 18
        Me.btnMenu.TabStop = False
        '
        'tmOcultar
        '
        Me.tmOcultar.Interval = 15
        '
        'tmMostrar
        '
        Me.tmMostrar.Interval = 15
        '
        'FormPrincipalMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(966, 603)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelBarraT)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgViewPeticiones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPrincipalMedico"
        Me.Text = "FormPrincipalMedico"
        CType(Me.dgViewPeticiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBarraT.ResumeLayout(False)
        Me.panelBarraT.PerformLayout()
        Me.panelMenu.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerActualizarPeticiones As Timer
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgViewPeticiones As DataGridView
    Friend WithEvents panelBarraT As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnres As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents panelMenu As Panel
    Friend WithEvents tmOcultar As Timer
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents tmMostrar As Timer
    Friend WithEvents btnCerrarS As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnIniciarChat As Button
End Class
