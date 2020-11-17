<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCarga
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pgrB = New CircularProgressBar.CircularProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmA = New System.Windows.Forms.Timer(Me.components)
        Me.tmD = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 70)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.presentacionMedico.My.Resources.Resources.Logo_OSLER
        Me.PictureBox3.Location = New System.Drawing.Point(-34, -15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(166, 105)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'pgrB
        '
        Me.pgrB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.pgrB.AnimationSpeed = 500
        Me.pgrB.BackColor = System.Drawing.Color.Transparent
        Me.pgrB.Font = New System.Drawing.Font("Ebrima", 40.0!)
        Me.pgrB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.pgrB.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pgrB.InnerMargin = 2
        Me.pgrB.InnerWidth = -1
        Me.pgrB.Location = New System.Drawing.Point(424, 176)
        Me.pgrB.MarqueeAnimationSpeed = 2000
        Me.pgrB.Name = "pgrB"
        Me.pgrB.OuterColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.pgrB.OuterMargin = -25
        Me.pgrB.OuterWidth = 25
        Me.pgrB.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.pgrB.ProgressWidth = 20
        Me.pgrB.SecondaryFont = New System.Drawing.Font("Ebrima", 20.0!)
        Me.pgrB.Size = New System.Drawing.Size(150, 150)
        Me.pgrB.StartAngle = 270
        Me.pgrB.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pgrB.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.pgrB.SubscriptMargin = New System.Windows.Forms.Padding(0, -50, 0, 0)
        Me.pgrB.SubscriptText = "%"
        Me.pgrB.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.pgrB.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.pgrB.SuperscriptText = ""
        Me.pgrB.TabIndex = 9
        Me.pgrB.Text = "0"
        Me.pgrB.TextMargin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.pgrB.Value = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(358, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Doctor: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(281, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 46)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bienvenido!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "O S L E R - Sistema de Telediagnóstico"
        '
        'tmA
        '
        Me.tmA.Interval = 30
        '
        'tmD
        '
        Me.tmD.Interval = 30
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.presentacionMedico.My.Resources.Resources.fondo
        Me.PictureBox2.Location = New System.Drawing.Point(-79, 66)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(446, 283)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Ebrima", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblnombre.Location = New System.Drawing.Point(447, 133)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(179, 30)
        Me.lblnombre.TabIndex = 10
        Me.lblnombre.Text = "nombre_medico"
        '
        'FormCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(764, 347)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.pgrB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCarga"
        Me.Text = "FormCarga"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pgrB As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tmA As Timer
    Friend WithEvents tmD As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblnombre As Label
End Class
