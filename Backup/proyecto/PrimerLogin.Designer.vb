<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimerLogin
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrimerLogin))
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnlisto = New System.Windows.Forms.Button
        Me.txtNuevaContraseña = New System.Windows.Forms.TextBox
        Me.lblNuevaContraseña = New System.Windows.Forms.Label
        Me.lblConfirmarContraseña = New System.Windows.Forms.Label
        Me.txtConfirmarContraseña = New System.Windows.Forms.TextBox
        Me.btnCambiarPregunta = New System.Windows.Forms.Button
        Me.btnCambiarContraseña = New System.Windows.Forms.Button
        Me.cmbPregunta = New System.Windows.Forms.ComboBox
        Me.lblPregunta = New System.Windows.Forms.Label
        Me.txtRespuesta = New System.Windows.Forms.TextBox
        Me.lblRespuesta = New System.Windows.Forms.Label
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 21
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(488, 49)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 20
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(488, 27)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 19
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(442, 49)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 18
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(442, 27)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 17
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnlisto
        '
        Me.btnlisto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlisto.FlatAppearance.BorderSize = 0
        Me.btnlisto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlisto.Image = CType(resources.GetObject("btnlisto.Image"), System.Drawing.Image)
        Me.btnlisto.Location = New System.Drawing.Point(422, 273)
        Me.btnlisto.Name = "btnlisto"
        Me.btnlisto.Size = New System.Drawing.Size(115, 44)
        Me.btnlisto.TabIndex = 22
        Me.btnlisto.UseVisualStyleBackColor = True
        '
        'txtNuevaContraseña
        '
        Me.txtNuevaContraseña.Location = New System.Drawing.Point(231, 128)
        Me.txtNuevaContraseña.Name = "txtNuevaContraseña"
        Me.txtNuevaContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtNuevaContraseña.Size = New System.Drawing.Size(154, 20)
        Me.txtNuevaContraseña.TabIndex = 23
        Me.txtNuevaContraseña.Visible = False
        '
        'lblNuevaContraseña
        '
        Me.lblNuevaContraseña.AutoSize = True
        Me.lblNuevaContraseña.Location = New System.Drawing.Point(112, 131)
        Me.lblNuevaContraseña.Name = "lblNuevaContraseña"
        Me.lblNuevaContraseña.Size = New System.Drawing.Size(97, 13)
        Me.lblNuevaContraseña.TabIndex = 24
        Me.lblNuevaContraseña.Text = "Contraseña nueva:"
        Me.lblNuevaContraseña.Visible = False
        '
        'lblConfirmarContraseña
        '
        Me.lblConfirmarContraseña.AutoSize = True
        Me.lblConfirmarContraseña.Location = New System.Drawing.Point(112, 157)
        Me.lblConfirmarContraseña.Name = "lblConfirmarContraseña"
        Me.lblConfirmarContraseña.Size = New System.Drawing.Size(107, 13)
        Me.lblConfirmarContraseña.TabIndex = 26
        Me.lblConfirmarContraseña.Text = "Confirme contraseña:"
        Me.lblConfirmarContraseña.Visible = False
        '
        'txtConfirmarContraseña
        '
        Me.txtConfirmarContraseña.Location = New System.Drawing.Point(231, 154)
        Me.txtConfirmarContraseña.Name = "txtConfirmarContraseña"
        Me.txtConfirmarContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtConfirmarContraseña.Size = New System.Drawing.Size(154, 20)
        Me.txtConfirmarContraseña.TabIndex = 25
        Me.txtConfirmarContraseña.Visible = False
        '
        'btnCambiarPregunta
        '
        Me.btnCambiarPregunta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCambiarPregunta.FlatAppearance.BorderSize = 0
        Me.btnCambiarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarPregunta.Image = CType(resources.GetObject("btnCambiarPregunta.Image"), System.Drawing.Image)
        Me.btnCambiarPregunta.Location = New System.Drawing.Point(12, 273)
        Me.btnCambiarPregunta.Name = "btnCambiarPregunta"
        Me.btnCambiarPregunta.Size = New System.Drawing.Size(119, 44)
        Me.btnCambiarPregunta.TabIndex = 27
        Me.btnCambiarPregunta.UseVisualStyleBackColor = True
        '
        'btnCambiarContraseña
        '
        Me.btnCambiarContraseña.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCambiarContraseña.FlatAppearance.BorderSize = 0
        Me.btnCambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarContraseña.Image = CType(resources.GetObject("btnCambiarContraseña.Image"), System.Drawing.Image)
        Me.btnCambiarContraseña.Location = New System.Drawing.Point(137, 273)
        Me.btnCambiarContraseña.Name = "btnCambiarContraseña"
        Me.btnCambiarContraseña.Size = New System.Drawing.Size(124, 44)
        Me.btnCambiarContraseña.TabIndex = 28
        Me.btnCambiarContraseña.UseVisualStyleBackColor = True
        '
        'cmbPregunta
        '
        Me.cmbPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPregunta.FormattingEnabled = True
        Me.cmbPregunta.Location = New System.Drawing.Point(231, 127)
        Me.cmbPregunta.Name = "cmbPregunta"
        Me.cmbPregunta.Size = New System.Drawing.Size(198, 21)
        Me.cmbPregunta.TabIndex = 29
        Me.cmbPregunta.Visible = False
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Location = New System.Drawing.Point(112, 131)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(53, 13)
        Me.lblPregunta.TabIndex = 30
        Me.lblPregunta.Text = "Pregunta:"
        Me.lblPregunta.Visible = False
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(231, 154)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(198, 20)
        Me.txtRespuesta.TabIndex = 31
        Me.txtRespuesta.Visible = False
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(112, 157)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(61, 13)
        Me.lblRespuesta.TabIndex = 32
        Me.lblRespuesta.Text = "Respuesta:"
        Me.lblRespuesta.Visible = False
        '
        'PrimerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(559, 329)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.cmbPregunta)
        Me.Controls.Add(Me.btnCambiarContraseña)
        Me.Controls.Add(Me.btnCambiarPregunta)
        Me.Controls.Add(Me.lblConfirmarContraseña)
        Me.Controls.Add(Me.txtConfirmarContraseña)
        Me.Controls.Add(Me.lblNuevaContraseña)
        Me.Controls.Add(Me.txtNuevaContraseña)
        Me.Controls.Add(Me.btnlisto)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrimerLogin"
        Me.Text = "PrimerLogin"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnlisto As System.Windows.Forms.Button
    Friend WithEvents txtNuevaContraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblNuevaContraseña As System.Windows.Forms.Label
    Friend WithEvents lblConfirmarContraseña As System.Windows.Forms.Label
    Friend WithEvents txtConfirmarContraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiarPregunta As System.Windows.Forms.Button
    Friend WithEvents btnCambiarContraseña As System.Windows.Forms.Button
    Friend WithEvents cmbPregunta As System.Windows.Forms.ComboBox
    Friend WithEvents lblPregunta As System.Windows.Forms.Label
    Friend WithEvents txtRespuesta As System.Windows.Forms.TextBox
    Friend WithEvents lblRespuesta As System.Windows.Forms.Label
End Class
