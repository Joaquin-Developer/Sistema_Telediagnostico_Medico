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
        Me.pgrB = New CircularProgressBar.CircularProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmA = New System.Windows.Forms.Timer(Me.components)
        Me.tmD = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pgrB.Location = New System.Drawing.Point(396, 173)
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
        Me.pgrB.TabIndex = 10
        Me.pgrB.Text = "0"
        Me.pgrB.TextMargin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.pgrB.Value = 68
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 70)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.presentacionPaciente.My.Resources.Resources.Logo_OSLER
        Me.PictureBox3.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(88, 79)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 35)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "O S L E R - Sistema de Telediagnóstico"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Ebrima", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblnombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.lblnombre.Location = New System.Drawing.Point(441, 129)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(194, 35)
        Me.lblnombre.TabIndex = 14
        Me.lblnombre.Text = "nombre_paciente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(335, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 35)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Paciente: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(268, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 54)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Bienvenido!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.presentacionPaciente.My.Resources.Resources.fondo
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(317, 661)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'tmA
        '
        Me.tmA.Interval = 30
        '
        'tmD
        '
        Me.tmD.Interval = 30
        '
        'FormCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 347)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pgrB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCarga"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pgrB As CircularProgressBar.CircularProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblnombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmA As Timer
    Friend WithEvents tmD As Timer
End Class
