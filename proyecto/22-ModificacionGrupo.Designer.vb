<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModGrupo))
        Me.btnconfirmar2 = New System.Windows.Forms.Button
        Me.CheckBoxturno = New System.Windows.Forms.CheckBox
        Me.CheckBoxNombre = New System.Windows.Forms.CheckBox
        Me.CheckBoxgrado = New System.Windows.Forms.CheckBox
        Me.CheckBoxorientacion = New System.Windows.Forms.CheckBox
        Me.CheckBoxaño = New System.Windows.Forms.CheckBox
        Me.lblitem = New System.Windows.Forms.Label
        Me.lbllinea = New System.Windows.Forms.Label
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.btnmodificarlinea = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.lblnum = New System.Windows.Forms.Label
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.txtgrado = New System.Windows.Forms.TextBox
        Me.txtaño = New System.Windows.Forms.TextBox
        Me.lblturno = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lblgrado = New System.Windows.Forms.Label
        Me.lblorientacion = New System.Windows.Forms.Label
        Me.lblaño = New System.Windows.Forms.Label
        Me.txtnombrei = New System.Windows.Forms.TextBox
        Me.txtgradoi = New System.Windows.Forms.TextBox
        Me.txtañoi = New System.Windows.Forms.TextBox
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
        Me.ModificacionAsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionInstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lbltcurso = New System.Windows.Forms.Label
        Me.CheckBoxTcurso = New System.Windows.Forms.CheckBox
        Me.cmbtcursoi = New System.Windows.Forms.ComboBox
        Me.cmborienti = New System.Windows.Forms.ComboBox
        Me.cmbturnoi = New System.Windows.Forms.ComboBox
        Me.cmborient = New System.Windows.Forms.ComboBox
        Me.cmbtcurso = New System.Windows.Forms.ComboBox
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.cmbnomgrup = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.btnconfirmar2.Location = New System.Drawing.Point(440, 393)
        Me.btnconfirmar2.Name = "btnconfirmar2"
        Me.btnconfirmar2.Size = New System.Drawing.Size(143, 65)
        Me.btnconfirmar2.TabIndex = 184
        Me.btnconfirmar2.UseVisualStyleBackColor = True
        Me.btnconfirmar2.Visible = False
        '
        'CheckBoxturno
        '
        Me.CheckBoxturno.AutoSize = True
        Me.CheckBoxturno.Location = New System.Drawing.Point(663, 200)
        Me.CheckBoxturno.Name = "CheckBoxturno"
        Me.CheckBoxturno.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxturno.TabIndex = 178
        Me.CheckBoxturno.Text = "Turno:"
        Me.CheckBoxturno.UseVisualStyleBackColor = True
        Me.CheckBoxturno.Visible = False
        '
        'CheckBoxNombre
        '
        Me.CheckBoxNombre.AutoSize = True
        Me.CheckBoxNombre.Location = New System.Drawing.Point(400, 200)
        Me.CheckBoxNombre.Name = "CheckBoxNombre"
        Me.CheckBoxNombre.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxNombre.TabIndex = 177
        Me.CheckBoxNombre.Text = "Nombre:"
        Me.CheckBoxNombre.UseVisualStyleBackColor = True
        Me.CheckBoxNombre.Visible = False
        '
        'CheckBoxgrado
        '
        Me.CheckBoxgrado.AutoSize = True
        Me.CheckBoxgrado.Location = New System.Drawing.Point(663, 164)
        Me.CheckBoxgrado.Name = "CheckBoxgrado"
        Me.CheckBoxgrado.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxgrado.TabIndex = 176
        Me.CheckBoxgrado.Text = "Grado:"
        Me.CheckBoxgrado.UseVisualStyleBackColor = True
        Me.CheckBoxgrado.Visible = False
        '
        'CheckBoxorientacion
        '
        Me.CheckBoxorientacion.AutoSize = True
        Me.CheckBoxorientacion.Location = New System.Drawing.Point(664, 128)
        Me.CheckBoxorientacion.Name = "CheckBoxorientacion"
        Me.CheckBoxorientacion.Size = New System.Drawing.Size(83, 17)
        Me.CheckBoxorientacion.TabIndex = 175
        Me.CheckBoxorientacion.Text = "Orientacion:"
        Me.CheckBoxorientacion.UseVisualStyleBackColor = True
        Me.CheckBoxorientacion.Visible = False
        '
        'CheckBoxaño
        '
        Me.CheckBoxaño.AutoSize = True
        Me.CheckBoxaño.Location = New System.Drawing.Point(401, 128)
        Me.CheckBoxaño.Name = "CheckBoxaño"
        Me.CheckBoxaño.Size = New System.Drawing.Size(48, 17)
        Me.CheckBoxaño.TabIndex = 174
        Me.CheckBoxaño.Text = "Año:"
        Me.CheckBoxaño.UseVisualStyleBackColor = True
        Me.CheckBoxaño.Visible = False
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Location = New System.Drawing.Point(371, 91)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(122, 13)
        Me.lblitem.TabIndex = 173
        Me.lblitem.Text = "Modificacion de un item:"
        Me.lblitem.Visible = False
        '
        'lbllinea
        '
        Me.lbllinea.AutoSize = True
        Me.lbllinea.Location = New System.Drawing.Point(371, 241)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(110, 13)
        Me.lbllinea.TabIndex = 172
        Me.lbllinea.Text = "Modificacion de linea:"
        Me.lbllinea.Visible = False
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(572, 393)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(134, 65)
        Me.btnconfirmar.TabIndex = 171
        Me.btnconfirmar.UseVisualStyleBackColor = True
        Me.btnconfirmar.Visible = False
        '
        'btnmodificarlinea
        '
        Me.btnmodificarlinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodificarlinea.FlatAppearance.BorderSize = 0
        Me.btnmodificarlinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarlinea.Image = CType(resources.GetObject("btnmodificarlinea.Image"), System.Drawing.Image)
        Me.btnmodificarlinea.Location = New System.Drawing.Point(241, 393)
        Me.btnmodificarlinea.Name = "btnmodificarlinea"
        Me.btnmodificarlinea.Size = New System.Drawing.Size(100, 65)
        Me.btnmodificarlinea.TabIndex = 160
        Me.btnmodificarlinea.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.Location = New System.Drawing.Point(120, 393)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(102, 65)
        Me.btnmodificar.TabIndex = 159
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(9, 196)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(191, 13)
        Me.lblnum.TabIndex = 157
        Me.lblnum.Text = "Eleja el Nombre del grupo ha modificar:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(506, 339)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(141, 20)
        Me.txtnombre.TabIndex = 194
        Me.txtnombre.Visible = False
        '
        'txtgrado
        '
        Me.txtgrado.Location = New System.Drawing.Point(768, 302)
        Me.txtgrado.Name = "txtgrado"
        Me.txtgrado.Size = New System.Drawing.Size(141, 20)
        Me.txtgrado.TabIndex = 193
        Me.txtgrado.Visible = False
        '
        'txtaño
        '
        Me.txtaño.Location = New System.Drawing.Point(505, 266)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(141, 20)
        Me.txtaño.TabIndex = 191
        Me.txtaño.Visible = False
        '
        'lblturno
        '
        Me.lblturno.AutoSize = True
        Me.lblturno.Location = New System.Drawing.Point(668, 342)
        Me.lblturno.Name = "lblturno"
        Me.lblturno.Size = New System.Drawing.Size(38, 13)
        Me.lblturno.TabIndex = 190
        Me.lblturno.Text = "Turno:"
        Me.lblturno.Visible = False
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(404, 342)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(47, 13)
        Me.lblnombre.TabIndex = 189
        Me.lblnombre.Text = "Nombre:"
        Me.lblnombre.Visible = False
        '
        'lblgrado
        '
        Me.lblgrado.AutoSize = True
        Me.lblgrado.Location = New System.Drawing.Point(667, 307)
        Me.lblgrado.Name = "lblgrado"
        Me.lblgrado.Size = New System.Drawing.Size(39, 13)
        Me.lblgrado.TabIndex = 188
        Me.lblgrado.Text = "Grado:"
        Me.lblgrado.Visible = False
        '
        'lblorientacion
        '
        Me.lblorientacion.AutoSize = True
        Me.lblorientacion.Location = New System.Drawing.Point(666, 269)
        Me.lblorientacion.Name = "lblorientacion"
        Me.lblorientacion.Size = New System.Drawing.Size(64, 13)
        Me.lblorientacion.TabIndex = 187
        Me.lblorientacion.Text = "Orientacion:"
        Me.lblorientacion.Visible = False
        '
        'lblaño
        '
        Me.lblaño.AutoSize = True
        Me.lblaño.Location = New System.Drawing.Point(404, 269)
        Me.lblaño.Name = "lblaño"
        Me.lblaño.Size = New System.Drawing.Size(29, 13)
        Me.lblaño.TabIndex = 186
        Me.lblaño.Text = "Año:"
        Me.lblaño.Visible = False
        '
        'txtnombrei
        '
        Me.txtnombrei.Location = New System.Drawing.Point(505, 198)
        Me.txtnombrei.Name = "txtnombrei"
        Me.txtnombrei.Size = New System.Drawing.Size(137, 20)
        Me.txtnombrei.TabIndex = 199
        Me.txtnombrei.Visible = False
        '
        'txtgradoi
        '
        Me.txtgradoi.Location = New System.Drawing.Point(768, 162)
        Me.txtgradoi.Name = "txtgradoi"
        Me.txtgradoi.Size = New System.Drawing.Size(137, 20)
        Me.txtgradoi.TabIndex = 198
        Me.txtgradoi.Visible = False
        '
        'txtañoi
        '
        Me.txtañoi.Location = New System.Drawing.Point(506, 126)
        Me.txtañoi.Name = "txtañoi"
        Me.txtañoi.Size = New System.Drawing.Size(137, 20)
        Me.txtañoi.TabIndex = 196
        Me.txtañoi.Visible = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(326, 30)
        Me.MenuStrip2.TabIndex = 201
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDirectorToolStripMenuItem, Me.AltaAlumnoToolStripMenuItem, Me.AltaDocenteToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 26)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaDirectorToolStripMenuItem
        '
        Me.AltaDirectorToolStripMenuItem.Name = "AltaDirectorToolStripMenuItem"
        Me.AltaDirectorToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AltaDirectorToolStripMenuItem.Text = "Grupo"
        '
        'AltaAlumnoToolStripMenuItem
        '
        Me.AltaAlumnoToolStripMenuItem.Name = "AltaAlumnoToolStripMenuItem"
        Me.AltaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AltaAlumnoToolStripMenuItem.Text = "Instituto"
        '
        'AltaDocenteToolStripMenuItem
        '
        Me.AltaDocenteToolStripMenuItem.Name = "AltaDocenteToolStripMenuItem"
        Me.AltaDocenteToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AltaDocenteToolStripMenuItem.Text = "Asignatura"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaDirectorToolStripMenuItem, Me.BajaDocenteToolStripMenuItem, Me.BajaAlumnoToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 26)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaDirectorToolStripMenuItem
        '
        Me.BajaDirectorToolStripMenuItem.Name = "BajaDirectorToolStripMenuItem"
        Me.BajaDirectorToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BajaDirectorToolStripMenuItem.Text = "Grupo"
        '
        'BajaDocenteToolStripMenuItem
        '
        Me.BajaDocenteToolStripMenuItem.Name = "BajaDocenteToolStripMenuItem"
        Me.BajaDocenteToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BajaDocenteToolStripMenuItem.Text = "Asignatura"
        '
        'BajaAlumnoToolStripMenuItem
        '
        Me.BajaAlumnoToolStripMenuItem.Name = "BajaAlumnoToolStripMenuItem"
        Me.BajaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BajaAlumnoToolStripMenuItem.Text = "Instituto"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionAsignaturaToolStripMenuItem, Me.ModificacionInstitutoToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(92, 26)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion "
        '
        'ModificacionAsignaturaToolStripMenuItem
        '
        Me.ModificacionAsignaturaToolStripMenuItem.Name = "ModificacionAsignaturaToolStripMenuItem"
        Me.ModificacionAsignaturaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ModificacionAsignaturaToolStripMenuItem.Text = "Asignatura"
        '
        'ModificacionInstitutoToolStripMenuItem
        '
        Me.ModificacionInstitutoToolStripMenuItem.Name = "ModificacionInstitutoToolStripMenuItem"
        Me.ModificacionInstitutoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ModificacionInstitutoToolStripMenuItem.Text = " Instituto"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 26)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'lbltcurso
        '
        Me.lbltcurso.AutoSize = True
        Me.lbltcurso.Location = New System.Drawing.Point(404, 305)
        Me.lbltcurso.Name = "lbltcurso"
        Me.lbltcurso.Size = New System.Drawing.Size(76, 13)
        Me.lbltcurso.TabIndex = 203
        Me.lbltcurso.Text = "Tipo de Curso:"
        Me.lbltcurso.Visible = False
        '
        'CheckBoxTcurso
        '
        Me.CheckBoxTcurso.AutoSize = True
        Me.CheckBoxTcurso.Location = New System.Drawing.Point(401, 164)
        Me.CheckBoxTcurso.Name = "CheckBoxTcurso"
        Me.CheckBoxTcurso.Size = New System.Drawing.Size(94, 17)
        Me.CheckBoxTcurso.TabIndex = 202
        Me.CheckBoxTcurso.Text = "Tipo de curso:"
        Me.CheckBoxTcurso.UseVisualStyleBackColor = True
        Me.CheckBoxTcurso.Visible = False
        '
        'cmbtcursoi
        '
        Me.cmbtcursoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtcursoi.FormattingEnabled = True
        Me.cmbtcursoi.Location = New System.Drawing.Point(505, 162)
        Me.cmbtcursoi.Name = "cmbtcursoi"
        Me.cmbtcursoi.Size = New System.Drawing.Size(138, 21)
        Me.cmbtcursoi.TabIndex = 208
        Me.cmbtcursoi.Visible = False
        '
        'cmborienti
        '
        Me.cmborienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmborienti.FormattingEnabled = True
        Me.cmborienti.Location = New System.Drawing.Point(768, 126)
        Me.cmborienti.Name = "cmborienti"
        Me.cmborienti.Size = New System.Drawing.Size(137, 21)
        Me.cmborienti.TabIndex = 207
        Me.cmborienti.Visible = False
        '
        'cmbturnoi
        '
        Me.cmbturnoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbturnoi.FormattingEnabled = True
        Me.cmbturnoi.Location = New System.Drawing.Point(767, 198)
        Me.cmbturnoi.Name = "cmbturnoi"
        Me.cmbturnoi.Size = New System.Drawing.Size(138, 21)
        Me.cmbturnoi.TabIndex = 206
        Me.cmbturnoi.Visible = False
        '
        'cmborient
        '
        Me.cmborient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmborient.FormattingEnabled = True
        Me.cmborient.Location = New System.Drawing.Point(767, 266)
        Me.cmborient.Name = "cmborient"
        Me.cmborient.Size = New System.Drawing.Size(141, 21)
        Me.cmborient.TabIndex = 209
        Me.cmborient.Visible = False
        '
        'cmbtcurso
        '
        Me.cmbtcurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtcurso.FormattingEnabled = True
        Me.cmbtcurso.Location = New System.Drawing.Point(505, 302)
        Me.cmbtcurso.Name = "cmbtcurso"
        Me.cmbtcurso.Size = New System.Drawing.Size(141, 21)
        Me.cmbtcurso.TabIndex = 210
        Me.cmbtcurso.Visible = False
        '
        'cmbturno
        '
        Me.cmbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Location = New System.Drawing.Point(768, 339)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(141, 21)
        Me.cmbturno.TabIndex = 211
        Me.cmbturno.Visible = False
        '
        'cmbnomgrup
        '
        Me.cmbnomgrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnomgrup.FormattingEnabled = True
        Me.cmbnomgrup.Location = New System.Drawing.Point(206, 192)
        Me.cmbnomgrup.Name = "cmbnomgrup"
        Me.cmbnomgrup.Size = New System.Drawing.Size(138, 21)
        Me.cmbnomgrup.TabIndex = 212
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 49)
        Me.GroupBox1.TabIndex = 213
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 292
        Me.Label2.Text = "Modificacion Grupo"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 291
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(848, 56)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 290
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(848, 34)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 289
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(799, 56)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 288
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(799, 34)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 287
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ModGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(921, 459)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbnomgrup)
        Me.Controls.Add(Me.cmbturno)
        Me.Controls.Add(Me.cmbtcurso)
        Me.Controls.Add(Me.cmborient)
        Me.Controls.Add(Me.cmbtcursoi)
        Me.Controls.Add(Me.cmborienti)
        Me.Controls.Add(Me.cmbturnoi)
        Me.Controls.Add(Me.lbltcurso)
        Me.Controls.Add(Me.CheckBoxTcurso)
        Me.Controls.Add(Me.txtnombrei)
        Me.Controls.Add(Me.txtgradoi)
        Me.Controls.Add(Me.txtañoi)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtgrado)
        Me.Controls.Add(Me.txtaño)
        Me.Controls.Add(Me.lblturno)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblgrado)
        Me.Controls.Add(Me.lblorientacion)
        Me.Controls.Add(Me.lblaño)
        Me.Controls.Add(Me.btnconfirmar2)
        Me.Controls.Add(Me.CheckBoxturno)
        Me.Controls.Add(Me.CheckBoxNombre)
        Me.Controls.Add(Me.CheckBoxgrado)
        Me.Controls.Add(Me.CheckBoxorientacion)
        Me.Controls.Add(Me.CheckBoxaño)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.lbllinea)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.btnmodificarlinea)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.lblnum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModGrupo"
        Me.Text = "Modificacion Grupo"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconfirmar2 As System.Windows.Forms.Button
    Friend WithEvents CheckBoxturno As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxNombre As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxgrado As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxorientacion As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxaño As System.Windows.Forms.CheckBox
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lbllinea As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents btnmodificarlinea As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents lblnum As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtgrado As System.Windows.Forms.TextBox
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents lblturno As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblgrado As System.Windows.Forms.Label
    Friend WithEvents lblorientacion As System.Windows.Forms.Label
    Friend WithEvents lblaño As System.Windows.Forms.Label
    Friend WithEvents txtnombrei As System.Windows.Forms.TextBox
    Friend WithEvents txtgradoi As System.Windows.Forms.TextBox
    Friend WithEvents txtañoi As System.Windows.Forms.TextBox
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
    Friend WithEvents ModificacionAsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionInstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbltcurso As System.Windows.Forms.Label
    Friend WithEvents CheckBoxTcurso As System.Windows.Forms.CheckBox
    Friend WithEvents cmbtcursoi As System.Windows.Forms.ComboBox
    Friend WithEvents cmborienti As System.Windows.Forms.ComboBox
    Friend WithEvents cmbturnoi As System.Windows.Forms.ComboBox
    Friend WithEvents cmborient As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtcurso As System.Windows.Forms.ComboBox
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbnomgrup As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
