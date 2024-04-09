<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaAlumno))
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.grpdatosp = New System.Windows.Forms.GroupBox
        Me.txttelefonoa = New System.Windows.Forms.MaskedTextBox
        Me.txtfechanaca = New System.Windows.Forms.MaskedTextBox
        Me.cmblocalidad = New System.Windows.Forms.ComboBox
        Me.lbltelefonoa = New System.Windows.Forms.Label
        Me.lblfechanaca = New System.Windows.Forms.Label
        Me.lbnlocalidad = New System.Windows.Forms.Label
        Me.txtamaterno = New System.Windows.Forms.TextBox
        Me.txtapaterno = New System.Windows.Forms.TextBox
        Me.txtnombre2 = New System.Windows.Forms.TextBox
        Me.txtnombre1 = New System.Windows.Forms.TextBox
        Me.lbldireccion = New System.Windows.Forms.Label
        Me.lblamaterno = New System.Windows.Forms.Label
        Me.lblapaterno = New System.Windows.Forms.Label
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.lblnombre2 = New System.Windows.Forms.Label
        Me.lblnombre1 = New System.Windows.Forms.Label
        Me.grpconcurre = New System.Windows.Forms.GroupBox
        Me.lblidinst = New System.Windows.Forms.Label
        Me.txtidgrupo = New System.Windows.Forms.ComboBox
        Me.cmbinst = New System.Windows.Forms.ComboBox
        Me.lbnidgrupo = New System.Windows.Forms.Label
        Me.btnverificar = New System.Windows.Forms.Button
        Me.lblci = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtci = New System.Windows.Forms.MaskedTextBox
        Me.MenuStrip1.SuspendLayout()
        Me.grpdatosp.SuspendLayout()
        Me.grpconcurre.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(664, 504)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(121, 56)
        Me.btnconfirmar.TabIndex = 35
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(352, 24)
        Me.MenuStrip1.TabIndex = 96
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDocenteToolStripMenuItem, Me.AltaDirectorToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 19)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaDocenteToolStripMenuItem
        '
        Me.AltaDocenteToolStripMenuItem.Name = "AltaDocenteToolStripMenuItem"
        Me.AltaDocenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaDocenteToolStripMenuItem.Text = "Docente"
        '
        'AltaDirectorToolStripMenuItem
        '
        Me.AltaDirectorToolStripMenuItem.Name = "AltaDirectorToolStripMenuItem"
        Me.AltaDirectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaDirectorToolStripMenuItem.Text = "Administrativo"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaAlumnoToolStripMenuItem, Me.BajaDocenteToolStripMenuItem, Me.BajaDirectorToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 19)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaAlumnoToolStripMenuItem
        '
        Me.BajaAlumnoToolStripMenuItem.Name = "BajaAlumnoToolStripMenuItem"
        Me.BajaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaAlumnoToolStripMenuItem.Text = "Alumno"
        '
        'BajaDocenteToolStripMenuItem
        '
        Me.BajaDocenteToolStripMenuItem.Name = "BajaDocenteToolStripMenuItem"
        Me.BajaDocenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaDocenteToolStripMenuItem.Text = "Docente"
        '
        'BajaDirectorToolStripMenuItem
        '
        Me.BajaDirectorToolStripMenuItem.Name = "BajaDirectorToolStripMenuItem"
        Me.BajaDirectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaDirectorToolStripMenuItem.Text = "Administrativo"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionDocenteToolStripMenuItem, Me.ModificacionAlumnoToolStripMenuItem, Me.ModificacionDirectorToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 19)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModificacionDocenteToolStripMenuItem
        '
        Me.ModificacionDocenteToolStripMenuItem.Name = "ModificacionDocenteToolStripMenuItem"
        Me.ModificacionDocenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificacionDocenteToolStripMenuItem.Text = "Docente"
        '
        'ModificacionAlumnoToolStripMenuItem
        '
        Me.ModificacionAlumnoToolStripMenuItem.Name = "ModificacionAlumnoToolStripMenuItem"
        Me.ModificacionAlumnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificacionAlumnoToolStripMenuItem.Text = "Alumno"
        '
        'ModificacionDirectorToolStripMenuItem
        '
        Me.ModificacionDirectorToolStripMenuItem.Name = "ModificacionDirectorToolStripMenuItem"
        Me.ModificacionDirectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificacionDirectorToolStripMenuItem.Text = "Administrativo"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 19)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'grpdatosp
        '
        Me.grpdatosp.Controls.Add(Me.txttelefonoa)
        Me.grpdatosp.Controls.Add(Me.txtfechanaca)
        Me.grpdatosp.Controls.Add(Me.cmblocalidad)
        Me.grpdatosp.Controls.Add(Me.lbltelefonoa)
        Me.grpdatosp.Controls.Add(Me.lblfechanaca)
        Me.grpdatosp.Controls.Add(Me.lbnlocalidad)
        Me.grpdatosp.Controls.Add(Me.txtamaterno)
        Me.grpdatosp.Controls.Add(Me.txtapaterno)
        Me.grpdatosp.Controls.Add(Me.txtnombre2)
        Me.grpdatosp.Controls.Add(Me.txtnombre1)
        Me.grpdatosp.Controls.Add(Me.lbldireccion)
        Me.grpdatosp.Controls.Add(Me.lblamaterno)
        Me.grpdatosp.Controls.Add(Me.lblapaterno)
        Me.grpdatosp.Controls.Add(Me.txtdireccion)
        Me.grpdatosp.Controls.Add(Me.lblnombre2)
        Me.grpdatosp.Controls.Add(Me.lblnombre1)
        Me.grpdatosp.Enabled = False
        Me.grpdatosp.Location = New System.Drawing.Point(141, 166)
        Me.grpdatosp.Name = "grpdatosp"
        Me.grpdatosp.Size = New System.Drawing.Size(563, 279)
        Me.grpdatosp.TabIndex = 97
        Me.grpdatosp.TabStop = False
        Me.grpdatosp.Text = "Datos Personales"
        '
        'txttelefonoa
        '
        Me.txttelefonoa.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txttelefonoa.Location = New System.Drawing.Point(248, 237)
        Me.txttelefonoa.Mask = "0-0-00-00-00"
        Me.txttelefonoa.Name = "txttelefonoa"
        Me.txttelefonoa.Size = New System.Drawing.Size(73, 20)
        Me.txttelefonoa.TabIndex = 291
        Me.txttelefonoa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtfechanaca
        '
        Me.txtfechanaca.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtfechanaca.Location = New System.Drawing.Point(144, 159)
        Me.txtfechanaca.Mask = "00/00/0000"
        Me.txtfechanaca.Name = "txtfechanaca"
        Me.txtfechanaca.Size = New System.Drawing.Size(73, 20)
        Me.txtfechanaca.TabIndex = 290
        Me.txtfechanaca.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtfechanaca.ValidatingType = GetType(Date)
        '
        'cmblocalidad
        '
        Me.cmblocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblocalidad.FormattingEnabled = True
        Me.cmblocalidad.Location = New System.Drawing.Point(111, 196)
        Me.cmblocalidad.Name = "cmblocalidad"
        Me.cmblocalidad.Size = New System.Drawing.Size(128, 21)
        Me.cmblocalidad.TabIndex = 127
        '
        'lbltelefonoa
        '
        Me.lbltelefonoa.AutoSize = True
        Me.lbltelefonoa.Location = New System.Drawing.Point(158, 240)
        Me.lbltelefonoa.Name = "lbltelefonoa"
        Me.lbltelefonoa.Size = New System.Drawing.Size(55, 13)
        Me.lbltelefonoa.TabIndex = 120
        Me.lbltelefonoa.Text = "Telefono :"
        '
        'lblfechanaca
        '
        Me.lblfechanaca.AutoSize = True
        Me.lblfechanaca.Location = New System.Drawing.Point(14, 162)
        Me.lblfechanaca.Name = "lblfechanaca"
        Me.lblfechanaca.Size = New System.Drawing.Size(114, 13)
        Me.lblfechanaca.TabIndex = 119
        Me.lblfechanaca.Text = "Fecha de Nacimiento :"
        '
        'lbnlocalidad
        '
        Me.lbnlocalidad.AutoSize = True
        Me.lbnlocalidad.Location = New System.Drawing.Point(14, 199)
        Me.lbnlocalidad.Name = "lbnlocalidad"
        Me.lbnlocalidad.Size = New System.Drawing.Size(59, 13)
        Me.lbnlocalidad.TabIndex = 126
        Me.lbnlocalidad.Text = "Localidad :"
        '
        'txtamaterno
        '
        Me.txtamaterno.Location = New System.Drawing.Point(359, 122)
        Me.txtamaterno.Name = "txtamaterno"
        Me.txtamaterno.Size = New System.Drawing.Size(128, 20)
        Me.txtamaterno.TabIndex = 115
        '
        'txtapaterno
        '
        Me.txtapaterno.Location = New System.Drawing.Point(111, 122)
        Me.txtapaterno.Name = "txtapaterno"
        Me.txtapaterno.Size = New System.Drawing.Size(128, 20)
        Me.txtapaterno.TabIndex = 114
        '
        'txtnombre2
        '
        Me.txtnombre2.Location = New System.Drawing.Point(359, 88)
        Me.txtnombre2.Name = "txtnombre2"
        Me.txtnombre2.Size = New System.Drawing.Size(128, 20)
        Me.txtnombre2.TabIndex = 113
        '
        'txtnombre1
        '
        Me.txtnombre1.Location = New System.Drawing.Point(111, 88)
        Me.txtnombre1.Name = "txtnombre1"
        Me.txtnombre1.Size = New System.Drawing.Size(128, 20)
        Me.txtnombre1.TabIndex = 112
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(245, 162)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(58, 13)
        Me.lbldireccion.TabIndex = 110
        Me.lbldireccion.Text = "Direccion :"
        '
        'lblamaterno
        '
        Me.lblamaterno.AutoSize = True
        Me.lblamaterno.Location = New System.Drawing.Point(245, 125)
        Me.lblamaterno.Name = "lblamaterno"
        Me.lblamaterno.Size = New System.Drawing.Size(92, 13)
        Me.lblamaterno.TabIndex = 109
        Me.lblamaterno.Text = "Apellido Materno :"
        '
        'lblapaterno
        '
        Me.lblapaterno.AutoSize = True
        Me.lblapaterno.Location = New System.Drawing.Point(14, 125)
        Me.lblapaterno.Name = "lblapaterno"
        Me.lblapaterno.Size = New System.Drawing.Size(90, 13)
        Me.lblapaterno.TabIndex = 108
        Me.lblapaterno.Text = "Apellido Paterno :"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(359, 159)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(128, 20)
        Me.txtdireccion.TabIndex = 116
        '
        'lblnombre2
        '
        Me.lblnombre2.AutoSize = True
        Me.lblnombre2.Location = New System.Drawing.Point(245, 91)
        Me.lblnombre2.Name = "lblnombre2"
        Me.lblnombre2.Size = New System.Drawing.Size(94, 13)
        Me.lblnombre2.TabIndex = 107
        Me.lblnombre2.Text = "Segundo nombre :"
        '
        'lblnombre1
        '
        Me.lblnombre1.AutoSize = True
        Me.lblnombre1.Location = New System.Drawing.Point(14, 91)
        Me.lblnombre1.Name = "lblnombre1"
        Me.lblnombre1.Size = New System.Drawing.Size(80, 13)
        Me.lblnombre1.TabIndex = 106
        Me.lblnombre1.Text = "Primer nombre :"
        '
        'grpconcurre
        '
        Me.grpconcurre.Controls.Add(Me.lblidinst)
        Me.grpconcurre.Controls.Add(Me.txtidgrupo)
        Me.grpconcurre.Controls.Add(Me.cmbinst)
        Me.grpconcurre.Controls.Add(Me.lbnidgrupo)
        Me.grpconcurre.Enabled = False
        Me.grpconcurre.Location = New System.Drawing.Point(272, 451)
        Me.grpconcurre.Name = "grpconcurre"
        Me.grpconcurre.Size = New System.Drawing.Size(327, 99)
        Me.grpconcurre.TabIndex = 120
        Me.grpconcurre.TabStop = False
        Me.grpconcurre.Text = "Concurre"
        '
        'lblidinst
        '
        Me.lblidinst.AutoSize = True
        Me.lblidinst.Location = New System.Drawing.Point(9, 29)
        Me.lblidinst.Name = "lblidinst"
        Me.lblidinst.Size = New System.Drawing.Size(50, 13)
        Me.lblidinst.TabIndex = 292
        Me.lblidinst.Text = "Instituto :"
        '
        'txtidgrupo
        '
        Me.txtidgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtidgrupo.Enabled = False
        Me.txtidgrupo.FormattingEnabled = True
        Me.txtidgrupo.Location = New System.Drawing.Point(89, 53)
        Me.txtidgrupo.Name = "txtidgrupo"
        Me.txtidgrupo.Size = New System.Drawing.Size(117, 21)
        Me.txtidgrupo.TabIndex = 109
        '
        'cmbinst
        '
        Me.cmbinst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbinst.FormattingEnabled = True
        Me.cmbinst.Location = New System.Drawing.Point(89, 26)
        Me.cmbinst.Name = "cmbinst"
        Me.cmbinst.Size = New System.Drawing.Size(180, 21)
        Me.cmbinst.TabIndex = 293
        '
        'lbnidgrupo
        '
        Me.lbnidgrupo.AutoSize = True
        Me.lbnidgrupo.Enabled = False
        Me.lbnidgrupo.Location = New System.Drawing.Point(11, 56)
        Me.lbnidgrupo.Name = "lbnidgrupo"
        Me.lbnidgrupo.Size = New System.Drawing.Size(42, 13)
        Me.lbnidgrupo.TabIndex = 117
        Me.lbnidgrupo.Text = "Grupo :"
        '
        'btnverificar
        '
        Me.btnverificar.Location = New System.Drawing.Point(463, 137)
        Me.btnverificar.Name = "btnverificar"
        Me.btnverificar.Size = New System.Drawing.Size(118, 23)
        Me.btnverificar.TabIndex = 111
        Me.btnverificar.Text = "Verificar Existencia"
        Me.btnverificar.UseVisualStyleBackColor = True
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(220, 142)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(26, 13)
        Me.lblci.TabIndex = 109
        Me.lblci.Text = "C.I :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(223, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 43)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 138
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(704, 62)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 137
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(704, 40)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 136
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(658, 62)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 135
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(658, 40)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 134
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Alta Alumno"
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(315, 139)
        Me.txtci.Mask = "0.000.000-0"
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(73, 20)
        Me.txtci.TabIndex = 287
        Me.txtci.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'AltaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpconcurre)
        Me.Controls.Add(Me.btnverificar)
        Me.Controls.Add(Me.lblci)
        Me.Controls.Add(Me.grpdatosp)
        Me.Controls.Add(Me.btnconfirmar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaAlumno"
        Me.Text = "Alta Alumno"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpdatosp.ResumeLayout(False)
        Me.grpdatosp.PerformLayout()
        Me.grpconcurre.ResumeLayout(False)
        Me.grpconcurre.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpdatosp As System.Windows.Forms.GroupBox
    Friend WithEvents lbltelefonoa As System.Windows.Forms.Label
    Friend WithEvents lblfechanaca As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtamaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtapaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre1 As System.Windows.Forms.TextBox
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents lblamaterno As System.Windows.Forms.Label
    Friend WithEvents lblapaterno As System.Windows.Forms.Label
    Friend WithEvents lblnombre2 As System.Windows.Forms.Label
    Friend WithEvents lblnombre1 As System.Windows.Forms.Label
    Friend WithEvents btnverificar As System.Windows.Forms.Button
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents grpconcurre As System.Windows.Forms.GroupBox
    Friend WithEvents txtidgrupo As System.Windows.Forms.ComboBox
    Friend WithEvents lbnidgrupo As System.Windows.Forms.Label
    Friend WithEvents cmblocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents lbnlocalidad As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtci As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtfechanaca As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttelefonoa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblidinst As System.Windows.Forms.Label
    Friend WithEvents cmbinst As System.Windows.Forms.ComboBox
End Class
