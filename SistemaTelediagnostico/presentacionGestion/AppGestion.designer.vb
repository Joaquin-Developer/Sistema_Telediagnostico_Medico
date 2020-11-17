<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppGestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppGestion))
        Me.panelBarraT = New System.Windows.Forms.Panel()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnres = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnCerrarS = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnpato = New System.Windows.Forms.Button()
        Me.btnpaci = New System.Windows.Forms.Button()
        Me.btnsinto = New System.Windows.Forms.Button()
        Me.btnmedi = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.tmMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.tmOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.tmFecha = New System.Windows.Forms.Timer(Me.components)
        Me.panelBarraT.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBarraT
        '
        Me.panelBarraT.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.panelBarraT.Controls.Add(Me.btnMin)
        Me.panelBarraT.Controls.Add(Me.btnMax)
        Me.panelBarraT.Controls.Add(Me.Label1)
        Me.panelBarraT.Controls.Add(Me.btnres)
        Me.panelBarraT.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBarraT.Location = New System.Drawing.Point(0, 0)
        Me.panelBarraT.Name = "panelBarraT"
        Me.panelBarraT.Size = New System.Drawing.Size(966, 40)
        Me.panelBarraT.TabIndex = 4
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackgroundImage = CType(resources.GetObject("btnMin.BackgroundImage"), System.Drawing.Image)
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(882, 5)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(42, 29)
        Me.btnMin.TabIndex = 2
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackgroundImage = Global.presentacionGestion.My.Resources.Resources.Icono_Maximizar
        Me.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Location = New System.Drawing.Point(921, 5)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(42, 29)
        Me.btnMax.TabIndex = 1
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "M E N U  D E  G E S T I Ó N"
        '
        'btnres
        '
        Me.btnres.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnres.BackgroundImage = Global.presentacionGestion.My.Resources.Resources.Icono_Restaurar
        Me.btnres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnres.FlatAppearance.BorderSize = 0
        Me.btnres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnres.Location = New System.Drawing.Point(921, 5)
        Me.btnres.Name = "btnres"
        Me.btnres.Size = New System.Drawing.Size(42, 29)
        Me.btnres.TabIndex = 0
        Me.btnres.UseVisualStyleBackColor = True
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnCerrarS)
        Me.panelMenu.Controls.Add(Me.Panel5)
        Me.panelMenu.Controls.Add(Me.Panel2)
        Me.panelMenu.Controls.Add(Me.Panel1)
        Me.panelMenu.Controls.Add(Me.btnpato)
        Me.panelMenu.Controls.Add(Me.btnpaci)
        Me.panelMenu.Controls.Add(Me.btnsinto)
        Me.panelMenu.Controls.Add(Me.btnmedi)
        Me.panelMenu.Controls.Add(Me.btnMenu)
        Me.panelMenu.Controls.Add(Me.Panel4)
        Me.panelMenu.Controls.Add(Me.Panel3)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 40)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 563)
        Me.panelMenu.TabIndex = 5
        '
        'btnCerrarS
        '
        Me.btnCerrarS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarS.BackgroundImage = Global.presentacionGestion.My.Resources.Resources.cerrarSesión
        Me.btnCerrarS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrarS.FlatAppearance.BorderSize = 0
        Me.btnCerrarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarS.Location = New System.Drawing.Point(10, 521)
        Me.btnCerrarS.Name = "btnCerrarS"
        Me.btnCerrarS.Size = New System.Drawing.Size(35, 36)
        Me.btnCerrarS.TabIndex = 8
        Me.btnCerrarS.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 521)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(4, 36)
        Me.Panel5.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(4, 73)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(4, 73)
        Me.Panel1.TabIndex = 5
        '
        'btnpato
        '
        Me.btnpato.FlatAppearance.BorderSize = 0
        Me.btnpato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnpato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnpato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpato.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnpato.ForeColor = System.Drawing.Color.White
        Me.btnpato.Image = Global.presentacionGestion.My.Resources.Resources.Patologia
        Me.btnpato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpato.Location = New System.Drawing.Point(3, 65)
        Me.btnpato.Name = "btnpato"
        Me.btnpato.Size = New System.Drawing.Size(217, 73)
        Me.btnpato.TabIndex = 0
        Me.btnpato.Text = "           Patologias"
        Me.btnpato.UseVisualStyleBackColor = True
        '
        'btnpaci
        '
        Me.btnpaci.FlatAppearance.BorderSize = 0
        Me.btnpaci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnpaci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnpaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpaci.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnpaci.ForeColor = System.Drawing.Color.White
        Me.btnpaci.Image = Global.presentacionGestion.My.Resources.Resources.doc21
        Me.btnpaci.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnpaci.Location = New System.Drawing.Point(3, 223)
        Me.btnpaci.Name = "btnpaci"
        Me.btnpaci.Size = New System.Drawing.Size(217, 73)
        Me.btnpaci.TabIndex = 2
        Me.btnpaci.Text = "           Pacientes"
        Me.btnpaci.UseVisualStyleBackColor = True
        '
        'btnsinto
        '
        Me.btnsinto.FlatAppearance.BorderSize = 0
        Me.btnsinto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnsinto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnsinto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsinto.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnsinto.ForeColor = System.Drawing.Color.White
        Me.btnsinto.Image = Global.presentacionGestion.My.Resources.Resources.sintomas
        Me.btnsinto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsinto.Location = New System.Drawing.Point(3, 144)
        Me.btnsinto.Name = "btnsinto"
        Me.btnsinto.Size = New System.Drawing.Size(217, 73)
        Me.btnsinto.TabIndex = 1
        Me.btnsinto.Text = "           Sintomas"
        Me.btnsinto.UseVisualStyleBackColor = True
        '
        'btnmedi
        '
        Me.btnmedi.FlatAppearance.BorderSize = 0
        Me.btnmedi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnmedi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnmedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmedi.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnmedi.ForeColor = System.Drawing.Color.White
        Me.btnmedi.Image = Global.presentacionGestion.My.Resources.Resources.doc2
        Me.btnmedi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmedi.Location = New System.Drawing.Point(3, 302)
        Me.btnmedi.Name = "btnmedi"
        Me.btnmedi.Size = New System.Drawing.Size(217, 73)
        Me.btnmedi.TabIndex = 3
        Me.btnmedi.Text = "           Medicos"
        Me.btnmedi.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.presentacionGestion.My.Resources.Resources.Menu_icon_icons_com_55865
        Me.btnMenu.Location = New System.Drawing.Point(182, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(32, 32)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 302)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(4, 73)
        Me.Panel4.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 223)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(4, 73)
        Me.Panel3.TabIndex = 6
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.panelContenedor.Controls.Add(Me.lblFecha)
        Me.panelContenedor.Controls.Add(Me.lblHora)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(220, 40)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(746, 563)
        Me.panelContenedor.TabIndex = 6
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Ebrima", 15.0!)
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(412, 523)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(74, 32)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "FECHA"
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Ebrima", 30.0!)
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblHora.Location = New System.Drawing.Point(408, 469)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(136, 64)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "HORA"
        '
        'tmMostrar
        '
        Me.tmMostrar.Interval = 15
        '
        'tmOcultar
        '
        Me.tmOcultar.Interval = 15
        '
        'tmFecha
        '
        Me.tmFecha.Interval = 1
        '
        'AppGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(966, 603)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelBarraT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AppGestion"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppGestion"
        Me.panelBarraT.ResumeLayout(False)
        Me.panelBarraT.PerformLayout()
        Me.panelMenu.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsinto As Button
    Friend WithEvents btnpaci As Button
    Friend WithEvents btnmedi As Button
    Friend WithEvents panelBarraT As Panel
    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents tmMostrar As Timer
    Friend WithEvents tmOcultar As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrarS As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMin As Button
    Friend WithEvents btnres As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents tmFecha As Timer
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Public WithEvents btnpato As Button
End Class
