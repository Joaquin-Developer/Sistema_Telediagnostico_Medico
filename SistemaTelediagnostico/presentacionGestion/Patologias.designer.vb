<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patologias
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chksin = New System.Windows.Forms.CheckedListBox()
        Me.txtn = New System.Windows.Forms.TextBox()
        Me.txtdescrip = New System.Windows.Forms.TextBox()
        Me.btnmodi = New System.Windows.Forms.Button()
        Me.btnelim = New System.Windows.Forms.Button()
        Me.btningre = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.cbxcargar = New System.Windows.Forms.ComboBox()
        Me.tmCarga = New System.Windows.Forms.Timer(Me.components)
        Me.chkmort = New System.Windows.Forms.CheckBox()
        Me.txtrecomen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 7.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(439, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 12)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Sintomas posibles con el cual relacionar a la Patologia:"
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
        Me.chksin.Size = New System.Drawing.Size(262, 484)
        Me.chksin.TabIndex = 4
        '
        'txtn
        '
        Me.txtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtn.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtn.Location = New System.Drawing.Point(159, 60)
        Me.txtn.Name = "txtn"
        Me.txtn.Size = New System.Drawing.Size(244, 27)
        Me.txtn.TabIndex = 0
        '
        'txtdescrip
        '
        Me.txtdescrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtdescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescrip.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtdescrip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtdescrip.Location = New System.Drawing.Point(159, 93)
        Me.txtdescrip.Multiline = True
        Me.txtdescrip.Name = "txtdescrip"
        Me.txtdescrip.Size = New System.Drawing.Size(244, 83)
        Me.txtdescrip.TabIndex = 1
        '
        'btnmodi
        '
        Me.btnmodi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodi.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnmodi.FlatAppearance.BorderSize = 0
        Me.btnmodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodi.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnmodi.ForeColor = System.Drawing.Color.White
        Me.btnmodi.Location = New System.Drawing.Point(34, 451)
        Me.btnmodi.Name = "btnmodi"
        Me.btnmodi.Size = New System.Drawing.Size(119, 30)
        Me.btnmodi.TabIndex = 7
        Me.btnmodi.Text = "Modificar"
        Me.btnmodi.UseVisualStyleBackColor = False
        '
        'btnelim
        '
        Me.btnelim.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnelim.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnelim.FlatAppearance.BorderSize = 0
        Me.btnelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnelim.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnelim.ForeColor = System.Drawing.Color.White
        Me.btnelim.Location = New System.Drawing.Point(34, 405)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(119, 30)
        Me.btnelim.TabIndex = 6
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.UseVisualStyleBackColor = False
        '
        'btningre
        '
        Me.btningre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btningre.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btningre.FlatAppearance.BorderSize = 0
        Me.btningre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btningre.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btningre.ForeColor = System.Drawing.Color.White
        Me.btningre.Location = New System.Drawing.Point(34, 360)
        Me.btningre.Name = "btningre"
        Me.btningre.Size = New System.Drawing.Size(119, 30)
        Me.btningre.TabIndex = 5
        Me.btningre.Text = "Agregar"
        Me.btningre.UseVisualStyleBackColor = False
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
        Me.btnCerrar.TabIndex = 104
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'cbxcargar
        '
        Me.cbxcargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.cbxcargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxcargar.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.cbxcargar.ForeColor = System.Drawing.Color.White
        Me.cbxcargar.FormattingEnabled = True
        Me.cbxcargar.Location = New System.Drawing.Point(34, 497)
        Me.cbxcargar.Name = "cbxcargar"
        Me.cbxcargar.Size = New System.Drawing.Size(119, 28)
        Me.cbxcargar.TabIndex = 109
        '
        'tmCarga
        '
        Me.tmCarga.Interval = 1
        '
        'chkmort
        '
        Me.chkmort.AutoSize = True
        Me.chkmort.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.chkmort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkmort.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.chkmort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.chkmort.Location = New System.Drawing.Point(135, 151)
        Me.chkmort.Name = "chkmort"
        Me.chkmort.Size = New System.Drawing.Size(37, 24)
        Me.chkmort.TabIndex = 2
        Me.chkmort.Text = "SI"
        Me.chkmort.UseVisualStyleBackColor = False
        '
        'txtrecomen
        '
        Me.txtrecomen.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtrecomen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrecomen.Font = New System.Drawing.Font("Ebrima", 11.0!)
        Me.txtrecomen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.txtrecomen.Location = New System.Drawing.Point(136, 190)
        Me.txtrecomen.Multiline = True
        Me.txtrecomen.Name = "txtrecomen"
        Me.txtrecomen.Size = New System.Drawing.Size(244, 88)
        Me.txtrecomen.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Mortalidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Recomendación:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtrecomen)
        Me.Panel1.Controls.Add(Me.chkmort)
        Me.Panel1.Location = New System.Drawing.Point(22, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 296)
        Me.Panel1.TabIndex = 105
        '
        'Patologias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(746, 563)
        Me.Controls.Add(Me.cbxcargar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chksin)
        Me.Controls.Add(Me.txtn)
        Me.Controls.Add(Me.btningre)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btnmodi)
        Me.Controls.Add(Me.txtdescrip)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Patologias"
        Me.Text = "Patologias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdescrip As TextBox
    Friend WithEvents btnmodi As Button
    Friend WithEvents btnelim As Button
    Friend WithEvents btningre As Button
    Friend WithEvents txtn As TextBox
    Friend WithEvents chksin As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents cbxcargar As ComboBox
    Friend WithEvents tmCarga As Timer
    Friend WithEvents chkmort As CheckBox
    Friend WithEvents txtrecomen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
