<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso))
        Me.lblusuario = New System.Windows.Forms.Label
        Me.lblpwd = New System.Windows.Forms.Label
        Me.txtpwd = New System.Windows.Forms.TextBox
        Me.btnentrar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.CmbRol = New System.Windows.Forms.ComboBox
        Me.lblrol = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.logo = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.txtusuario = New System.Windows.Forms.MaskedTextBox
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Location = New System.Drawing.Point(41, 148)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(46, 13)
        Me.lblusuario.TabIndex = 0
        Me.lblusuario.Text = "Usuario:"
        '
        'lblpwd
        '
        Me.lblpwd.AutoSize = True
        Me.lblpwd.Location = New System.Drawing.Point(41, 174)
        Me.lblpwd.Name = "lblpwd"
        Me.lblpwd.Size = New System.Drawing.Size(64, 13)
        Me.lblpwd.TabIndex = 1
        Me.lblpwd.Text = "Contraseña:"
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(146, 171)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtpwd.Size = New System.Drawing.Size(174, 20)
        Me.txtpwd.TabIndex = 2
        '
        'btnentrar
        '
        Me.btnentrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnentrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnentrar.FlatAppearance.BorderSize = 0
        Me.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnentrar.Image = CType(resources.GetObject("btnentrar.Image"), System.Drawing.Image)
        Me.btnentrar.Location = New System.Drawing.Point(255, 270)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(85, 43)
        Me.btnentrar.TabIndex = 5
        Me.btnentrar.UseCompatibleTextRendering = True
        Me.btnentrar.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.Location = New System.Drawing.Point(25, 270)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(80, 43)
        Me.btnsalir.TabIndex = 6
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'CmbRol
        '
        Me.CmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbRol.Enabled = False
        Me.CmbRol.FormattingEnabled = True
        Me.CmbRol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbRol.Location = New System.Drawing.Point(146, 212)
        Me.CmbRol.Name = "CmbRol"
        Me.CmbRol.Size = New System.Drawing.Size(174, 21)
        Me.CmbRol.TabIndex = 3
        Me.CmbRol.Visible = False
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Location = New System.Drawing.Point(41, 215)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(93, 13)
        Me.lblrol.TabIndex = 7
        Me.lblrol.Text = "Seleccione el Rol:"
        Me.lblrol.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(232, 65)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 12
        Me.lblhora1.Text = "Hora:"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(232, 87)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 13
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(278, 65)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 14
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(278, 87)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 15
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 9)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 16
        Me.logo.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(159, 212)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(119, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿Olvido su contraseña?"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(146, 141)
        Me.txtusuario.Mask = "0.000.000-0"
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(73, 20)
        Me.txtusuario.TabIndex = 1
        Me.txtusuario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Ingreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(366, 325)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.lblrol)
        Me.Controls.Add(Me.CmbRol)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.lblpwd)
        Me.Controls.Add(Me.lblusuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Ingreso"
        Me.Text = "Ingreso"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents lblpwd As System.Windows.Forms.Label
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents btnentrar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents CmbRol As System.Windows.Forms.ComboBox
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtusuario As System.Windows.Forms.MaskedTextBox

End Class
