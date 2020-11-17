<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sintomas
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
        Me.btningre = New System.Windows.Forms.Button()
        Me.btnelim = New System.Windows.Forms.Button()
        Me.btnmodi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdescri = New System.Windows.Forms.TextBox()
        Me.chksin = New System.Windows.Forms.CheckedListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.cbxcargar = New System.Windows.Forms.ComboBox()
        Me.tmCarga = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btningre
        '
        Me.btningre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btningre.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btningre.FlatAppearance.BorderSize = 0
        Me.btningre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btningre.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btningre.ForeColor = System.Drawing.Color.White
        Me.btningre.Location = New System.Drawing.Point(30, 359)
        Me.btningre.Name = "btningre"
        Me.btningre.Size = New System.Drawing.Size(119, 30)
        Me.btningre.TabIndex = 0
        Me.btningre.Text = "Agregar"
        Me.btningre.UseVisualStyleBackColor = False
        '
        'btnelim
        '
        Me.btnelim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnelim.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnelim.FlatAppearance.BorderSize = 0
        Me.btnelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnelim.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnelim.ForeColor = System.Drawing.Color.White
        Me.btnelim.Location = New System.Drawing.Point(30, 407)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(119, 30)
        Me.btnelim.TabIndex = 1
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.UseVisualStyleBackColor = False
        '
        'btnmodi
        '
        Me.btnmodi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodi.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnmodi.FlatAppearance.BorderSize = 0
        Me.btnmodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodi.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnmodi.ForeColor = System.Drawing.Color.White
        Me.btnmodi.Location = New System.Drawing.Point(30, 454)
        Me.btnmodi.Name = "btnmodi"
        Me.btnmodi.Size = New System.Drawing.Size(119, 30)
        Me.btnmodi.TabIndex = 2
        Me.btnmodi.Text = "Modificar"
        Me.btnmodi.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtname.Location = New System.Drawing.Point(171, 60)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(244, 27)
        Me.txtname.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Descripción:"
        '
        'txtdescri
        '
        Me.txtdescri.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtdescri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescri.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtdescri.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtdescri.Location = New System.Drawing.Point(171, 93)
        Me.txtdescri.Multiline = True
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(244, 215)
        Me.txtdescri.TabIndex = 7
        '
        'chksin
        '
        Me.chksin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chksin.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.chksin.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.chksin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.chksin.FormattingEnabled = True
        Me.chksin.Location = New System.Drawing.Point(441, 44)
        Me.chksin.Name = "chksin"
        Me.chksin.Size = New System.Drawing.Size(270, 484)
        Me.chksin.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(34, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 282)
        Me.Panel1.TabIndex = 106
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
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'cbxcargar
        '
        Me.cbxcargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbxcargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxcargar.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.cbxcargar.ForeColor = System.Drawing.Color.White
        Me.cbxcargar.FormattingEnabled = True
        Me.cbxcargar.Location = New System.Drawing.Point(30, 500)
        Me.cbxcargar.Name = "cbxcargar"
        Me.cbxcargar.Size = New System.Drawing.Size(119, 28)
        Me.cbxcargar.TabIndex = 108
        '
        'tmCarga
        '
        Me.tmCarga.Interval = 1
        '
        'Sintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 563)
        Me.Controls.Add(Me.cbxcargar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.chksin)
        Me.Controls.Add(Me.txtdescri)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnmodi)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btningre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sintomas"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btningre As Button
    Friend WithEvents btnelim As Button
    Friend WithEvents btnmodi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdescri As TextBox
    Friend WithEvents chksin As CheckedListBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbxcargar As ComboBox
    Friend WithEvents tmCarga As Timer
End Class
