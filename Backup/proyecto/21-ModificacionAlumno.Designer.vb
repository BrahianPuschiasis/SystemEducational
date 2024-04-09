<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModAlumno))
        Me.btnconfirmar2 = New System.Windows.Forms.Button
        Me.txtitemdireccion = New System.Windows.Forms.TextBox
        Me.txtitemamaterno = New System.Windows.Forms.TextBox
        Me.txtitemapaterno = New System.Windows.Forms.TextBox
        Me.txtitemnombre2 = New System.Windows.Forms.TextBox
        Me.txtitemnombre = New System.Windows.Forms.TextBox
        Me.CheckBoxdireccion = New System.Windows.Forms.CheckBox
        Me.CheckBoxamaterno = New System.Windows.Forms.CheckBox
        Me.CheckBoxapaterno = New System.Windows.Forms.CheckBox
        Me.CheckBoxnombre2 = New System.Windows.Forms.CheckBox
        Me.CheckBoxnombre1 = New System.Windows.Forms.CheckBox
        Me.lblitem = New System.Windows.Forms.Label
        Me.lbllinea = New System.Windows.Forms.Label
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.txtamaterno = New System.Windows.Forms.TextBox
        Me.txtapaterno = New System.Windows.Forms.TextBox
        Me.txtnombre2 = New System.Windows.Forms.TextBox
        Me.txtnombre1 = New System.Windows.Forms.TextBox
        Me.lbldireccion = New System.Windows.Forms.Label
        Me.lblamaterno = New System.Windows.Forms.Label
        Me.lblapaterno = New System.Windows.Forms.Label
        Me.lblnombre2 = New System.Windows.Forms.Label
        Me.lblnombre1 = New System.Windows.Forms.Label
        Me.btnmodificarlinea = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.lblci = New System.Windows.Forms.Label
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtci = New System.Windows.Forms.MaskedTextBox
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnconfirmar2
        '
        Me.btnconfirmar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar2.FlatAppearance.BorderSize = 0
        Me.btnconfirmar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar2.Image = CType(resources.GetObject("btnconfirmar2.Image"), System.Drawing.Image)
        Me.btnconfirmar2.Location = New System.Drawing.Point(458, 344)
        Me.btnconfirmar2.Name = "btnconfirmar2"
        Me.btnconfirmar2.Size = New System.Drawing.Size(135, 69)
        Me.btnconfirmar2.TabIndex = 154
        Me.btnconfirmar2.UseVisualStyleBackColor = True
        Me.btnconfirmar2.Visible = False
        '
        'txtitemdireccion
        '
        Me.txtitemdireccion.Location = New System.Drawing.Point(469, 177)
        Me.txtitemdireccion.Name = "txtitemdireccion"
        Me.txtitemdireccion.Size = New System.Drawing.Size(133, 20)
        Me.txtitemdireccion.TabIndex = 153
        Me.txtitemdireccion.Visible = False
        '
        'txtitemamaterno
        '
        Me.txtitemamaterno.Location = New System.Drawing.Point(730, 146)
        Me.txtitemamaterno.Name = "txtitemamaterno"
        Me.txtitemamaterno.Size = New System.Drawing.Size(133, 20)
        Me.txtitemamaterno.TabIndex = 152
        Me.txtitemamaterno.Visible = False
        '
        'txtitemapaterno
        '
        Me.txtitemapaterno.Location = New System.Drawing.Point(469, 146)
        Me.txtitemapaterno.Name = "txtitemapaterno"
        Me.txtitemapaterno.Size = New System.Drawing.Size(133, 20)
        Me.txtitemapaterno.TabIndex = 151
        Me.txtitemapaterno.Visible = False
        '
        'txtitemnombre2
        '
        Me.txtitemnombre2.Location = New System.Drawing.Point(730, 110)
        Me.txtitemnombre2.Name = "txtitemnombre2"
        Me.txtitemnombre2.Size = New System.Drawing.Size(133, 20)
        Me.txtitemnombre2.TabIndex = 150
        Me.txtitemnombre2.Visible = False
        '
        'txtitemnombre
        '
        Me.txtitemnombre.Location = New System.Drawing.Point(469, 110)
        Me.txtitemnombre.Name = "txtitemnombre"
        Me.txtitemnombre.Size = New System.Drawing.Size(133, 20)
        Me.txtitemnombre.TabIndex = 149
        Me.txtitemnombre.Visible = False
        '
        'CheckBoxdireccion
        '
        Me.CheckBoxdireccion.AutoSize = True
        Me.CheckBoxdireccion.Location = New System.Drawing.Point(357, 181)
        Me.CheckBoxdireccion.Name = "CheckBoxdireccion"
        Me.CheckBoxdireccion.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxdireccion.TabIndex = 148
        Me.CheckBoxdireccion.Text = "Direccion:"
        Me.CheckBoxdireccion.UseVisualStyleBackColor = True
        Me.CheckBoxdireccion.Visible = False
        '
        'CheckBoxamaterno
        '
        Me.CheckBoxamaterno.AutoSize = True
        Me.CheckBoxamaterno.Location = New System.Drawing.Point(618, 148)
        Me.CheckBoxamaterno.Name = "CheckBoxamaterno"
        Me.CheckBoxamaterno.Size = New System.Drawing.Size(108, 17)
        Me.CheckBoxamaterno.TabIndex = 147
        Me.CheckBoxamaterno.Text = "Apellido Materno:"
        Me.CheckBoxamaterno.UseVisualStyleBackColor = True
        Me.CheckBoxamaterno.Visible = False
        '
        'CheckBoxapaterno
        '
        Me.CheckBoxapaterno.AutoSize = True
        Me.CheckBoxapaterno.Location = New System.Drawing.Point(357, 148)
        Me.CheckBoxapaterno.Name = "CheckBoxapaterno"
        Me.CheckBoxapaterno.Size = New System.Drawing.Size(106, 17)
        Me.CheckBoxapaterno.TabIndex = 146
        Me.CheckBoxapaterno.Text = "Apellido Paterno:"
        Me.CheckBoxapaterno.UseVisualStyleBackColor = True
        Me.CheckBoxapaterno.Visible = False
        '
        'CheckBoxnombre2
        '
        Me.CheckBoxnombre2.AutoSize = True
        Me.CheckBoxnombre2.Location = New System.Drawing.Point(618, 113)
        Me.CheckBoxnombre2.Name = "CheckBoxnombre2"
        Me.CheckBoxnombre2.Size = New System.Drawing.Size(112, 17)
        Me.CheckBoxnombre2.TabIndex = 145
        Me.CheckBoxnombre2.Text = "Segundo Nombre:"
        Me.CheckBoxnombre2.UseVisualStyleBackColor = True
        Me.CheckBoxnombre2.Visible = False
        '
        'CheckBoxnombre1
        '
        Me.CheckBoxnombre1.AutoSize = True
        Me.CheckBoxnombre1.Location = New System.Drawing.Point(357, 112)
        Me.CheckBoxnombre1.Name = "CheckBoxnombre1"
        Me.CheckBoxnombre1.Size = New System.Drawing.Size(96, 17)
        Me.CheckBoxnombre1.TabIndex = 144
        Me.CheckBoxnombre1.Text = "Primer nombre:"
        Me.CheckBoxnombre1.UseVisualStyleBackColor = True
        Me.CheckBoxnombre1.Visible = False
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Location = New System.Drawing.Point(332, 80)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(122, 13)
        Me.lblitem.TabIndex = 143
        Me.lblitem.Text = "Modificacion de un item:"
        Me.lblitem.Visible = False
        '
        'lbllinea
        '
        Me.lbllinea.AutoSize = True
        Me.lbllinea.Location = New System.Drawing.Point(332, 215)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(110, 13)
        Me.lbllinea.TabIndex = 142
        Me.lbllinea.Text = "Modificacion de linea:"
        Me.lbllinea.Visible = False
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(571, 344)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(135, 69)
        Me.btnconfirmar.TabIndex = 141
        Me.btnconfirmar.UseVisualStyleBackColor = True
        Me.btnconfirmar.Visible = False
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(458, 313)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(135, 20)
        Me.txtdireccion.TabIndex = 140
        Me.txtdireccion.Visible = False
        '
        'txtamaterno
        '
        Me.txtamaterno.Location = New System.Drawing.Point(719, 278)
        Me.txtamaterno.Name = "txtamaterno"
        Me.txtamaterno.Size = New System.Drawing.Size(135, 20)
        Me.txtamaterno.TabIndex = 139
        Me.txtamaterno.Visible = False
        '
        'txtapaterno
        '
        Me.txtapaterno.Location = New System.Drawing.Point(458, 278)
        Me.txtapaterno.Name = "txtapaterno"
        Me.txtapaterno.Size = New System.Drawing.Size(135, 20)
        Me.txtapaterno.TabIndex = 138
        Me.txtapaterno.Visible = False
        '
        'txtnombre2
        '
        Me.txtnombre2.Location = New System.Drawing.Point(719, 245)
        Me.txtnombre2.Name = "txtnombre2"
        Me.txtnombre2.Size = New System.Drawing.Size(135, 20)
        Me.txtnombre2.TabIndex = 137
        Me.txtnombre2.Visible = False
        '
        'txtnombre1
        '
        Me.txtnombre1.Location = New System.Drawing.Point(458, 245)
        Me.txtnombre1.Name = "txtnombre1"
        Me.txtnombre1.Size = New System.Drawing.Size(135, 20)
        Me.txtnombre1.TabIndex = 136
        Me.txtnombre1.Visible = False
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(354, 316)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(55, 13)
        Me.lbldireccion.TabIndex = 135
        Me.lbldireccion.Text = "Direccion:"
        Me.lbldireccion.Visible = False
        '
        'lblamaterno
        '
        Me.lblamaterno.AutoSize = True
        Me.lblamaterno.Location = New System.Drawing.Point(615, 281)
        Me.lblamaterno.Name = "lblamaterno"
        Me.lblamaterno.Size = New System.Drawing.Size(89, 13)
        Me.lblamaterno.TabIndex = 134
        Me.lblamaterno.Text = "Apellido Materno:"
        Me.lblamaterno.Visible = False
        '
        'lblapaterno
        '
        Me.lblapaterno.AutoSize = True
        Me.lblapaterno.Location = New System.Drawing.Point(354, 278)
        Me.lblapaterno.Name = "lblapaterno"
        Me.lblapaterno.Size = New System.Drawing.Size(87, 13)
        Me.lblapaterno.TabIndex = 133
        Me.lblapaterno.Text = "Apellido Paterno:"
        Me.lblapaterno.Visible = False
        '
        'lblnombre2
        '
        Me.lblnombre2.AutoSize = True
        Me.lblnombre2.Location = New System.Drawing.Point(615, 245)
        Me.lblnombre2.Name = "lblnombre2"
        Me.lblnombre2.Size = New System.Drawing.Size(91, 13)
        Me.lblnombre2.TabIndex = 132
        Me.lblnombre2.Text = "Segundo nombre:"
        Me.lblnombre2.Visible = False
        '
        'lblnombre1
        '
        Me.lblnombre1.AutoSize = True
        Me.lblnombre1.Location = New System.Drawing.Point(354, 245)
        Me.lblnombre1.Name = "lblnombre1"
        Me.lblnombre1.Size = New System.Drawing.Size(77, 13)
        Me.lblnombre1.TabIndex = 131
        Me.lblnombre1.Text = "Primer nombre:"
        Me.lblnombre1.Visible = False
        '
        'btnmodificarlinea
        '
        Me.btnmodificarlinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodificarlinea.FlatAppearance.BorderSize = 0
        Me.btnmodificarlinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarlinea.Image = CType(resources.GetObject("btnmodificarlinea.Image"), System.Drawing.Image)
        Me.btnmodificarlinea.Location = New System.Drawing.Point(216, 344)
        Me.btnmodificarlinea.Name = "btnmodificarlinea"
        Me.btnmodificarlinea.Size = New System.Drawing.Size(97, 64)
        Me.btnmodificarlinea.TabIndex = 130
        Me.btnmodificarlinea.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.Location = New System.Drawing.Point(111, 344)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(99, 64)
        Me.btnmodificar.TabIndex = 129
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(22, 183)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(58, 13)
        Me.lblci.TabIndex = 127
        Me.lblci.Text = "Ingrese CI:"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(249, 26)
        Me.MenuStrip2.TabIndex = 155
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDirectorToolStripMenuItem, Me.AltaAlumnoToolStripMenuItem, Me.AltaDocenteToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 22)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaDirectorToolStripMenuItem
        '
        Me.AltaDirectorToolStripMenuItem.Name = "AltaDirectorToolStripMenuItem"
        Me.AltaDirectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaDirectorToolStripMenuItem.Text = "Administrativo"
        '
        'AltaAlumnoToolStripMenuItem
        '
        Me.AltaAlumnoToolStripMenuItem.Name = "AltaAlumnoToolStripMenuItem"
        Me.AltaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaAlumnoToolStripMenuItem.Text = " Alumno"
        '
        'AltaDocenteToolStripMenuItem
        '
        Me.AltaDocenteToolStripMenuItem.Name = "AltaDocenteToolStripMenuItem"
        Me.AltaDocenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaDocenteToolStripMenuItem.Text = " Docente"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaDirectorToolStripMenuItem, Me.BajaDocenteToolStripMenuItem, Me.BajaAlumnoToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 22)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaDirectorToolStripMenuItem
        '
        Me.BajaDirectorToolStripMenuItem.Name = "BajaDirectorToolStripMenuItem"
        Me.BajaDirectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaDirectorToolStripMenuItem.Text = "Administrativo"
        '
        'BajaDocenteToolStripMenuItem
        '
        Me.BajaDocenteToolStripMenuItem.Name = "BajaDocenteToolStripMenuItem"
        Me.BajaDocenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaDocenteToolStripMenuItem.Text = "Docente"
        '
        'BajaAlumnoToolStripMenuItem
        '
        Me.BajaAlumnoToolStripMenuItem.Name = "BajaAlumnoToolStripMenuItem"
        Me.BajaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaAlumnoToolStripMenuItem.Text = " Alumno"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionDocenteToolStripMenuItem, Me.ModificacionDirectorToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 22)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModificacionDocenteToolStripMenuItem
        '
        Me.ModificacionDocenteToolStripMenuItem.Name = "ModificacionDocenteToolStripMenuItem"
        Me.ModificacionDocenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModificacionDocenteToolStripMenuItem.Text = "Docente"
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
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 22)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip2)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 45)
        Me.GroupBox1.TabIndex = 160
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 285
        Me.Label2.Text = "Modificacion Alumno"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 284
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(809, 58)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 283
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(809, 36)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 282
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(760, 58)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 281
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(760, 36)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 280
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(111, 180)
        Me.txtci.Mask = "0.000.000-0"
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(73, 20)
        Me.txtci.TabIndex = 287
        Me.txtci.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'ModAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(874, 410)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnconfirmar2)
        Me.Controls.Add(Me.txtitemdireccion)
        Me.Controls.Add(Me.txtitemamaterno)
        Me.Controls.Add(Me.txtitemapaterno)
        Me.Controls.Add(Me.txtitemnombre2)
        Me.Controls.Add(Me.txtitemnombre)
        Me.Controls.Add(Me.CheckBoxdireccion)
        Me.Controls.Add(Me.CheckBoxamaterno)
        Me.Controls.Add(Me.CheckBoxapaterno)
        Me.Controls.Add(Me.CheckBoxnombre2)
        Me.Controls.Add(Me.CheckBoxnombre1)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.lbllinea)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtamaterno)
        Me.Controls.Add(Me.txtapaterno)
        Me.Controls.Add(Me.txtnombre2)
        Me.Controls.Add(Me.txtnombre1)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblamaterno)
        Me.Controls.Add(Me.lblapaterno)
        Me.Controls.Add(Me.lblnombre2)
        Me.Controls.Add(Me.lblnombre1)
        Me.Controls.Add(Me.btnmodificarlinea)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.lblci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModAlumno"
        Me.Text = "Modificacion Alumno"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconfirmar2 As System.Windows.Forms.Button
    Friend WithEvents txtitemdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtitemamaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtitemapaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtitemnombre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtitemnombre As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxdireccion As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxamaterno As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxapaterno As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxnombre2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxnombre1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lbllinea As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
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
    Friend WithEvents btnmodificarlinea As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtci As System.Windows.Forms.MaskedTextBox
End Class
