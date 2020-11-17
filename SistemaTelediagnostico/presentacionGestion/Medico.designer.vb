<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Medico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medico))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnomb = New System.Windows.Forms.TextBox()
        Me.txtesp = New System.Windows.Forms.TextBox()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.btningre = New System.Windows.Forms.Button()
        Me.btnelim = New System.Windows.Forms.Button()
        Me.btnmodif = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtIdCiudad = New System.Windows.Forms.TextBox()
        Me.txtape2 = New System.Windows.Forms.TextBox()
        Me.txtname2 = New System.Windows.Forms.TextBox()
        Me.txtname1 = New System.Windows.Forms.TextBox()
        Me.txtape1 = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxcargar = New System.Windows.Forms.ComboBox()
        Me.tmCarga = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(290, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Usuario:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 429)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Especialidad:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(290, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'txtnomb
        '
        Me.txtnomb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnomb.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtnomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnomb.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtnomb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtnomb.Location = New System.Drawing.Point(433, 43)
        Me.txtnomb.Name = "txtnomb"
        Me.txtnomb.Size = New System.Drawing.Size(244, 29)
        Me.txtnomb.TabIndex = 0
        '
        'txtesp
        '
        Me.txtesp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtesp.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtesp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtesp.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtesp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtesp.Location = New System.Drawing.Point(154, 427)
        Me.txtesp.Name = "txtesp"
        Me.txtesp.Size = New System.Drawing.Size(244, 29)
        Me.txtesp.TabIndex = 13
        '
        'txtcontra
        '
        Me.txtcontra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcontra.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontra.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtcontra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtcontra.Location = New System.Drawing.Point(433, 78)
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.Size = New System.Drawing.Size(244, 29)
        Me.txtcontra.TabIndex = 1
        '
        'btningre
        '
        Me.btningre.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btningre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btningre.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.btningre.ForeColor = System.Drawing.Color.White
        Me.btningre.Location = New System.Drawing.Point(82, 212)
        Me.btningre.Name = "btningre"
        Me.btningre.Size = New System.Drawing.Size(119, 30)
        Me.btningre.TabIndex = 15
        Me.btningre.Text = "Agregar"
        Me.btningre.UseVisualStyleBackColor = False
        '
        'btnelim
        '
        Me.btnelim.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnelim.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.btnelim.ForeColor = System.Drawing.Color.White
        Me.btnelim.Location = New System.Drawing.Point(82, 251)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(119, 30)
        Me.btnelim.TabIndex = 16
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.UseVisualStyleBackColor = False
        '
        'btnmodif
        '
        Me.btnmodif.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnmodif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodif.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.btnmodif.ForeColor = System.Drawing.Color.White
        Me.btnmodif.Location = New System.Drawing.Point(82, 292)
        Me.btnmodif.Name = "btnmodif"
        Me.btnmodif.Size = New System.Drawing.Size(119, 30)
        Me.btnmodif.TabIndex = 17
        Me.btnmodif.Text = "Modificar"
        Me.btnmodif.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(290, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cédula:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(290, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Primer Nombre:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(290, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Segundo Nombre:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(290, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Primer Apellido:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(290, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Segundo Apellido:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(11, 395)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 21)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Correo:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(290, 292)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 21)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Fecha Nacimiento:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(11, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 21)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Calle:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(11, 359)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 21)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Numero Puerta:"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(11, 289)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 21)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Id Ciudad:"
        '
        'txtcorreo
        '
        Me.txtcorreo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcorreo.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtcorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtcorreo.Location = New System.Drawing.Point(154, 392)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(244, 29)
        Me.txtcorreo.TabIndex = 12
        '
        'txtfecha
        '
        Me.txtfecha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfecha.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtfecha.Location = New System.Drawing.Point(433, 288)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(244, 29)
        Me.txtfecha.TabIndex = 7
        '
        'txtCalle
        '
        Me.txtCalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalle.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtCalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtCalle.Location = New System.Drawing.Point(154, 322)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(244, 29)
        Me.txtCalle.TabIndex = 10
        '
        'txtNumero
        '
        Me.txtNumero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(154, 357)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(244, 29)
        Me.txtNumero.TabIndex = 11
        '
        'txtIdCiudad
        '
        Me.txtIdCiudad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtIdCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCiudad.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtIdCiudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtIdCiudad.Location = New System.Drawing.Point(154, 287)
        Me.txtIdCiudad.Name = "txtIdCiudad"
        Me.txtIdCiudad.Size = New System.Drawing.Size(244, 29)
        Me.txtIdCiudad.TabIndex = 9
        '
        'txtape2
        '
        Me.txtape2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtape2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtape2.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtape2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtape2.Location = New System.Drawing.Point(433, 218)
        Me.txtape2.Name = "txtape2"
        Me.txtape2.Size = New System.Drawing.Size(244, 29)
        Me.txtape2.TabIndex = 5
        '
        'txtname2
        '
        Me.txtname2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtname2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtname2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname2.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtname2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtname2.Location = New System.Drawing.Point(433, 148)
        Me.txtname2.Name = "txtname2"
        Me.txtname2.Size = New System.Drawing.Size(244, 29)
        Me.txtname2.TabIndex = 3
        '
        'txtname1
        '
        Me.txtname1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtname1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtname1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname1.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtname1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtname1.Location = New System.Drawing.Point(433, 113)
        Me.txtname1.Name = "txtname1"
        Me.txtname1.Size = New System.Drawing.Size(244, 29)
        Me.txtname1.TabIndex = 2
        '
        'txtape1
        '
        Me.txtape1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtape1.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtape1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtape1.Location = New System.Drawing.Point(433, 183)
        Me.txtape1.Name = "txtape1"
        Me.txtape1.Size = New System.Drawing.Size(244, 29)
        Me.txtape1.TabIndex = 4
        '
        'txtCedula
        '
        Me.txtCedula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.txtCedula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtCedula.Location = New System.Drawing.Point(433, 253)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(244, 29)
        Me.txtCedula.TabIndex = 6
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = Global.presentacionGestion.My.Resources.Resources.ICON_CERRARV
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(12, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(26, 24)
        Me.btnCerrar.TabIndex = 18
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(65, 34)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(175, 165)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 100
        Me.pictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtIdCiudad)
        Me.Panel1.Controls.Add(Me.txtCalle)
        Me.Panel1.Controls.Add(Me.txtNumero)
        Me.Panel1.Controls.Add(Me.txtcorreo)
        Me.Panel1.Controls.Add(Me.txtesp)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(277, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 483)
        Me.Panel1.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Ej: aaaa-mm-dd"
        '
        'cbxcargar
        '
        Me.cbxcargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbxcargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxcargar.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.cbxcargar.ForeColor = System.Drawing.Color.White
        Me.cbxcargar.FormattingEnabled = True
        Me.cbxcargar.Location = New System.Drawing.Point(82, 328)
        Me.cbxcargar.Name = "cbxcargar"
        Me.cbxcargar.Size = New System.Drawing.Size(119, 28)
        Me.cbxcargar.TabIndex = 107
        '
        'tmCarga
        '
        Me.tmCarga.Interval = 1
        '
        'Medico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(746, 563)
        Me.Controls.Add(Me.cbxcargar)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtape1)
        Me.Controls.Add(Me.txtname1)
        Me.Controls.Add(Me.txtname2)
        Me.Controls.Add(Me.txtape2)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnmodif)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btningre)
        Me.Controls.Add(Me.txtcontra)
        Me.Controls.Add(Me.txtnomb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Medico"
        Me.Opacity = 0.95R
        Me.Text = "Medico"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnomb As TextBox
    Friend WithEvents txtesp As TextBox
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents btningre As Button
    Friend WithEvents btnelim As Button
    Friend WithEvents btnmodif As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtIdCiudad As TextBox
    Friend WithEvents txtape2 As TextBox
    Friend WithEvents txtname2 As TextBox
    Friend WithEvents txtname1 As TextBox
    Friend WithEvents txtape1 As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnCerrar As Button
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbxcargar As ComboBox
    Friend WithEvents tmCarga As Timer
    Friend WithEvents Label4 As Label
End Class
