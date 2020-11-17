<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Paciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Paciente))
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.txtaltura = New System.Windows.Forms.TextBox()
        Me.txtsexo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtape1 = New System.Windows.Forms.TextBox()
        Me.txtname1 = New System.Windows.Forms.TextBox()
        Me.txtname2 = New System.Windows.Forms.TextBox()
        Me.txtape2 = New System.Windows.Forms.TextBox()
        Me.txtIdCiudad = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnmodif = New System.Windows.Forms.Button()
        Me.btnelim = New System.Windows.Forms.Button()
        Me.btningre = New System.Windows.Forms.Button()
        Me.txtpeso = New System.Windows.Forms.TextBox()
        Me.txtnomb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.cbxcargar = New System.Windows.Forms.ComboBox()
        Me.tmCarga = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpin
        '
        Me.txtpin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpin.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtpin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpin.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtpin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtpin.Location = New System.Drawing.Point(154, 42)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Size = New System.Drawing.Size(244, 27)
        Me.txtpin.TabIndex = 1
        '
        'txtaltura
        '
        Me.txtaltura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaltura.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtaltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtaltura.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtaltura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtaltura.Location = New System.Drawing.Point(154, 306)
        Me.txtaltura.Name = "txtaltura"
        Me.txtaltura.Size = New System.Drawing.Size(244, 27)
        Me.txtaltura.TabIndex = 9
        '
        'txtsexo
        '
        Me.txtsexo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtsexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsexo.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtsexo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtsexo.Location = New System.Drawing.Point(154, 273)
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.Size = New System.Drawing.Size(244, 27)
        Me.txtsexo.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(304, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 21)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "Pin:"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(304, 346)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 21)
        Me.Label15.TabIndex = 94
        Me.Label15.Text = "Altura:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(304, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 21)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Sexo:"
        '
        'txtCedula
        '
        Me.txtCedula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtCedula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtCedula.Location = New System.Drawing.Point(154, 207)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(244, 27)
        Me.txtCedula.TabIndex = 6
        '
        'txtape1
        '
        Me.txtape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtape1.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtape1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtape1.Location = New System.Drawing.Point(154, 141)
        Me.txtape1.Name = "txtape1"
        Me.txtape1.Size = New System.Drawing.Size(244, 27)
        Me.txtape1.TabIndex = 4
        '
        'txtname1
        '
        Me.txtname1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtname1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtname1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname1.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtname1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtname1.Location = New System.Drawing.Point(154, 75)
        Me.txtname1.Name = "txtname1"
        Me.txtname1.Size = New System.Drawing.Size(244, 27)
        Me.txtname1.TabIndex = 2
        '
        'txtname2
        '
        Me.txtname2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtname2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtname2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname2.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtname2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtname2.Location = New System.Drawing.Point(154, 108)
        Me.txtname2.Name = "txtname2"
        Me.txtname2.Size = New System.Drawing.Size(244, 27)
        Me.txtname2.TabIndex = 3
        '
        'txtape2
        '
        Me.txtape2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtape2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtape2.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtape2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtape2.Location = New System.Drawing.Point(154, 174)
        Me.txtape2.Name = "txtape2"
        Me.txtape2.Size = New System.Drawing.Size(244, 27)
        Me.txtape2.TabIndex = 5
        '
        'txtIdCiudad
        '
        Me.txtIdCiudad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtIdCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCiudad.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtIdCiudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtIdCiudad.Location = New System.Drawing.Point(154, 373)
        Me.txtIdCiudad.Name = "txtIdCiudad"
        Me.txtIdCiudad.Size = New System.Drawing.Size(244, 27)
        Me.txtIdCiudad.TabIndex = 11
        '
        'txtNumero
        '
        Me.txtNumero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtNumero.Location = New System.Drawing.Point(154, 439)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(244, 27)
        Me.txtNumero.TabIndex = 13
        '
        'txtCalle
        '
        Me.txtCalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalle.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtCalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtCalle.Location = New System.Drawing.Point(154, 406)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(244, 27)
        Me.txtCalle.TabIndex = 12
        '
        'txtfecha
        '
        Me.txtfecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfecha.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtfecha.Location = New System.Drawing.Point(154, 240)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(244, 27)
        Me.txtfecha.TabIndex = 7
        '
        'txtcorreo
        '
        Me.txtcorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcorreo.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtcorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtcorreo.Location = New System.Drawing.Point(154, 472)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(244, 27)
        Me.txtcorreo.TabIndex = 14
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
        Me.Label14.Location = New System.Drawing.Point(304, 413)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 21)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Id Ciudad:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(6, 440)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 21)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "Número Puerta:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(6, 407)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 21)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Calle:"
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
        Me.Label11.Location = New System.Drawing.Point(304, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 21)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Fecha Nacimiento:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 473)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 21)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Correo:"
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
        Me.Label9.Location = New System.Drawing.Point(304, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 21)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Segundo Apellido:"
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
        Me.Label8.Location = New System.Drawing.Point(304, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 21)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Primer Apellido:"
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
        Me.Label7.Location = New System.Drawing.Point(304, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 21)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Segundo Nombre:"
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
        Me.Label6.Location = New System.Drawing.Point(304, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 21)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Primer Nombre:"
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
        Me.Label5.Location = New System.Drawing.Point(4, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Cédula:"
        '
        'btnmodif
        '
        Me.btnmodif.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnmodif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodif.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.btnmodif.ForeColor = System.Drawing.Color.White
        Me.btnmodif.Location = New System.Drawing.Point(105, 260)
        Me.btnmodif.Name = "btnmodif"
        Me.btnmodif.Size = New System.Drawing.Size(119, 30)
        Me.btnmodif.TabIndex = 16
        Me.btnmodif.Text = "Modificar"
        Me.btnmodif.UseVisualStyleBackColor = False
        '
        'btnelim
        '
        Me.btnelim.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnelim.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.btnelim.ForeColor = System.Drawing.Color.White
        Me.btnelim.Location = New System.Drawing.Point(105, 304)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(119, 30)
        Me.btnelim.TabIndex = 17
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.UseVisualStyleBackColor = False
        '
        'btningre
        '
        Me.btningre.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btningre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btningre.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.btningre.ForeColor = System.Drawing.Color.White
        Me.btningre.Location = New System.Drawing.Point(105, 214)
        Me.btningre.Name = "btningre"
        Me.btningre.Size = New System.Drawing.Size(119, 30)
        Me.btningre.TabIndex = 15
        Me.btningre.Text = "Agregar"
        Me.btningre.UseVisualStyleBackColor = False
        '
        'txtpeso
        '
        Me.txtpeso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpeso.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtpeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpeso.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtpeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtpeso.Location = New System.Drawing.Point(154, 339)
        Me.txtpeso.Name = "txtpeso"
        Me.txtpeso.Size = New System.Drawing.Size(244, 27)
        Me.txtpeso.TabIndex = 10
        '
        'txtnomb
        '
        Me.txtnomb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnomb.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtnomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnomb.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtnomb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtnomb.Location = New System.Drawing.Point(154, 9)
        Me.txtnomb.Name = "txtnomb"
        Me.txtnomb.Size = New System.Drawing.Size(244, 27)
        Me.txtnomb.TabIndex = 0
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
        Me.Label2.Location = New System.Drawing.Point(304, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 21)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Peso:"
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
        Me.Label1.Location = New System.Drawing.Point(304, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 21)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Nombre Paciente:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtnomb)
        Me.Panel1.Controls.Add(Me.txtpeso)
        Me.Panel1.Controls.Add(Me.txtpin)
        Me.Panel1.Controls.Add(Me.txtcorreo)
        Me.Panel1.Controls.Add(Me.txtaltura)
        Me.Panel1.Controls.Add(Me.txtfecha)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtsexo)
        Me.Panel1.Controls.Add(Me.txtCalle)
        Me.Panel1.Controls.Add(Me.txtNumero)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtIdCiudad)
        Me.Panel1.Controls.Add(Me.txtape2)
        Me.Panel1.Controls.Add(Me.txtCedula)
        Me.Panel1.Controls.Add(Me.txtname2)
        Me.Panel1.Controls.Add(Me.txtape1)
        Me.Panel1.Controls.Add(Me.txtname1)
        Me.Panel1.Location = New System.Drawing.Point(298, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 510)
        Me.Panel1.TabIndex = 102
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(84, 38)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(175, 165)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 104
        Me.pictureBox1.TabStop = False
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
        'cbxcargar
        '
        Me.cbxcargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbxcargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxcargar.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.cbxcargar.ForeColor = System.Drawing.Color.White
        Me.cbxcargar.FormattingEnabled = True
        Me.cbxcargar.Location = New System.Drawing.Point(105, 347)
        Me.cbxcargar.Name = "cbxcargar"
        Me.cbxcargar.Size = New System.Drawing.Size(119, 28)
        Me.cbxcargar.TabIndex = 106
        '
        'tmCarga
        '
        Me.tmCarga.Interval = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 8.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Ej: aaaa-mm-dd"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Ebrima", 8.0!)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(7, 294)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "M o F"
        '
        'Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(746, 563)
        Me.Controls.Add(Me.cbxcargar)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnmodif)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btningre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Paciente"
        Me.Opacity = 0.95R
        Me.Text = "Paciente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpin As TextBox
    Friend WithEvents txtaltura As TextBox
    Friend WithEvents txtsexo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtape1 As TextBox
    Friend WithEvents txtname1 As TextBox
    Friend WithEvents txtname2 As TextBox
    Friend WithEvents txtape2 As TextBox
    Friend WithEvents txtIdCiudad As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnmodif As Button
    Friend WithEvents btnelim As Button
    Friend WithEvents btningre As Button
    Friend WithEvents txtpeso As TextBox
    Friend WithEvents txtnomb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents cbxcargar As ComboBox
    Friend WithEvents tmCarga As Timer
    Friend WithEvents Label17 As Label
    Friend WithEvents Label3 As Label
End Class
