<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaGrupo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaGrupo))
        Me.lblorientacion = New System.Windows.Forms.Label
        Me.lblgrado = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lblturno = New System.Windows.Forms.Label
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.lbntipodecurso = New System.Windows.Forms.Label
        Me.cmbturno = New System.Windows.Forms.ComboBox
        Me.cmbori = New System.Windows.Forms.ComboBox
        Me.cmbtcurso = New System.Windows.Forms.ComboBox
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtgrado = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.cmbInstituto = New System.Windows.Forms.ComboBox
        Me.btnInstituto = New System.Windows.Forms.Button
        Me.lblRecordar = New System.Windows.Forms.Label
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.DGVConsulta = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProgramasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExamenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.NotasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReunionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.VerificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.PerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignaturaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GrupoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.InstitutoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrientacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TipoDeCursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblorientacion
        '
        Me.lblorientacion.AutoSize = True
        Me.lblorientacion.Location = New System.Drawing.Point(370, 210)
        Me.lblorientacion.Name = "lblorientacion"
        Me.lblorientacion.Size = New System.Drawing.Size(70, 13)
        Me.lblorientacion.TabIndex = 3
        Me.lblorientacion.Text = "Orientacion : "
        '
        'lblgrado
        '
        Me.lblgrado.AutoSize = True
        Me.lblgrado.Location = New System.Drawing.Point(105, 207)
        Me.lblgrado.Name = "lblgrado"
        Me.lblgrado.Size = New System.Drawing.Size(42, 13)
        Me.lblgrado.TabIndex = 4
        Me.lblgrado.Text = "Grado :"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(105, 247)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(50, 13)
        Me.lblnombre.TabIndex = 5
        Me.lblnombre.Text = "Nombre :"
        '
        'lblturno
        '
        Me.lblturno.AutoSize = True
        Me.lblturno.Location = New System.Drawing.Point(105, 297)
        Me.lblturno.Name = "lblturno"
        Me.lblturno.Size = New System.Drawing.Size(41, 13)
        Me.lblturno.TabIndex = 6
        Me.lblturno.Text = "Turno :"
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(584, 418)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(122, 53)
        Me.btnconfirmar.TabIndex = 35
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'lbntipodecurso
        '
        Me.lbntipodecurso.AutoSize = True
        Me.lbntipodecurso.Location = New System.Drawing.Point(370, 250)
        Me.lbntipodecurso.Name = "lbntipodecurso"
        Me.lbntipodecurso.Size = New System.Drawing.Size(79, 13)
        Me.lbntipodecurso.TabIndex = 97
        Me.lbntipodecurso.Text = "Tipo de Curso :"
        '
        'cmbturno
        '
        Me.cmbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno"})
        Me.cmbturno.Location = New System.Drawing.Point(184, 294)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(99, 21)
        Me.cmbturno.TabIndex = 99
        '
        'cmbori
        '
        Me.cmbori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbori.FormattingEnabled = True
        Me.cmbori.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno"})
        Me.cmbori.Location = New System.Drawing.Point(457, 207)
        Me.cmbori.Name = "cmbori"
        Me.cmbori.Size = New System.Drawing.Size(145, 21)
        Me.cmbori.TabIndex = 100
        '
        'cmbtcurso
        '
        Me.cmbtcurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbtcurso.Enabled = False
        Me.cmbtcurso.FormattingEnabled = True
        Me.cmbtcurso.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno"})
        Me.cmbtcurso.Location = New System.Drawing.Point(457, 247)
        Me.cmbtcurso.Name = "cmbtcurso"
        Me.cmbtcurso.Size = New System.Drawing.Size(145, 21)
        Me.cmbtcurso.TabIndex = 101
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 108
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(642, 71)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 107
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(642, 49)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 106
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(593, 71)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 105
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(593, 49)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 104
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Alta Grupo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(370, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Instituto:"
        '
        'txtgrado
        '
        Me.txtgrado.Location = New System.Drawing.Point(184, 204)
        Me.txtgrado.MaxLength = 1
        Me.txtgrado.Name = "txtgrado"
        Me.txtgrado.Size = New System.Drawing.Size(19, 20)
        Me.txtgrado.TabIndex = 123
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(184, 244)
        Me.txtNombre.MaxLength = 1
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(19, 20)
        Me.txtNombre.TabIndex = 124
        '
        'cmbInstituto
        '
        Me.cmbInstituto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbInstituto.FormattingEnabled = True
        Me.cmbInstituto.Items.AddRange(New Object() {"Matutino", "Vespertino", "Nocturno"})
        Me.cmbInstituto.Location = New System.Drawing.Point(457, 300)
        Me.cmbInstituto.Name = "cmbInstituto"
        Me.cmbInstituto.Size = New System.Drawing.Size(76, 21)
        Me.cmbInstituto.TabIndex = 125
        '
        'btnInstituto
        '
        Me.btnInstituto.Location = New System.Drawing.Point(565, 300)
        Me.btnInstituto.Name = "btnInstituto"
        Me.btnInstituto.Size = New System.Drawing.Size(37, 20)
        Me.btnInstituto.TabIndex = 291
        Me.btnInstituto.Text = "?"
        Me.btnInstituto.UseVisualStyleBackColor = True
        '
        'lblRecordar
        '
        Me.lblRecordar.AutoSize = True
        Me.lblRecordar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRecordar.Location = New System.Drawing.Point(470, 258)
        Me.lblRecordar.Name = "lblRecordar"
        Me.lblRecordar.Size = New System.Drawing.Size(133, 13)
        Me.lblRecordar.TabIndex = 295
        Me.lblRecordar.Text = "¡Recuerde presionar enter!"
        Me.lblRecordar.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblBuscar.Location = New System.Drawing.Point(424, 224)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 294
        Me.lblBuscar.Text = "Buscar:"
        Me.lblBuscar.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.CausesValidation = False
        Me.txtBuscar.Location = New System.Drawing.Point(473, 221)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(143, 20)
        Me.txtBuscar.TabIndex = 293
        Me.txtBuscar.Visible = False
        '
        'DGVConsulta
        '
        Me.DGVConsulta.AllowUserToAddRows = False
        Me.DGVConsulta.AllowUserToDeleteRows = False
        Me.DGVConsulta.AllowUserToResizeColumns = False
        Me.DGVConsulta.AllowUserToResizeRows = False
        Me.DGVConsulta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DGVConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVConsulta.Location = New System.Drawing.Point(99, 177)
        Me.DGVConsulta.MultiSelect = False
        Me.DGVConsulta.Name = "DGVConsulta"
        Me.DGVConsulta.ReadOnly = True
        Me.DGVConsulta.Size = New System.Drawing.Size(527, 244)
        Me.DGVConsulta.TabIndex = 292
        Me.DGVConsulta.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(78, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 42)
        Me.GroupBox1.TabIndex = 296
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Principal Administrativo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonasToolStripMenuItem, Me.AsignaturaToolStripMenuItem, Me.GrupoToolStripMenuItem, Me.ExamenToolStripMenuItem1, Me.ReunionesToolStripMenuItem, Me.InstitutoToolStripMenuItem, Me.ConsultaToolStripMenuItem3, Me.ListadosToolStripMenuItem, Me.AdministracionToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 23)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem5, Me.ModificacionToolStripMenuItem5})
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
        Me.PersonasToolStripMenuItem.Text = "Personas"
        '
        'AltaToolStripMenuItem5
        '
        Me.AltaToolStripMenuItem5.Name = "AltaToolStripMenuItem5"
        Me.AltaToolStripMenuItem5.Size = New System.Drawing.Size(117, 22)
        Me.AltaToolStripMenuItem5.Text = "Registro"
        '
        'ModificacionToolStripMenuItem5
        '
        Me.ModificacionToolStripMenuItem5.Name = "ModificacionToolStripMenuItem5"
        Me.ModificacionToolStripMenuItem5.Size = New System.Drawing.Size(117, 22)
        Me.ModificacionToolStripMenuItem5.Text = "Cargos"
        '
        'AsignaturaToolStripMenuItem
        '
        Me.AsignaturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ProgramasToolStripMenuItem})
        Me.AsignaturaToolStripMenuItem.Name = "AsignaturaToolStripMenuItem"
        Me.AsignaturaToolStripMenuItem.Size = New System.Drawing.Size(76, 19)
        Me.AsignaturaToolStripMenuItem.Text = "Asignatura"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BajaToolStripMenuItem.Text = "Activas"
        '
        'ProgramasToolStripMenuItem
        '
        Me.ProgramasToolStripMenuItem.Name = "ProgramasToolStripMenuItem"
        Me.ProgramasToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ProgramasToolStripMenuItem.Text = "Programas"
        '
        'GrupoToolStripMenuItem
        '
        Me.GrupoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaToolStripMenuItem1})
        Me.GrupoToolStripMenuItem.Name = "GrupoToolStripMenuItem"
        Me.GrupoToolStripMenuItem.Size = New System.Drawing.Size(52, 19)
        Me.GrupoToolStripMenuItem.Text = "Grupo"
        '
        'BajaToolStripMenuItem1
        '
        Me.BajaToolStripMenuItem1.Name = "BajaToolStripMenuItem1"
        Me.BajaToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.BajaToolStripMenuItem1.Text = "Activos"
        '
        'ExamenToolStripMenuItem1
        '
        Me.ExamenToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoToolStripMenuItem, Me.VerificarToolStripMenuItem1, Me.NotasToolStripMenuItem1})
        Me.ExamenToolStripMenuItem1.Name = "ExamenToolStripMenuItem1"
        Me.ExamenToolStripMenuItem1.Size = New System.Drawing.Size(71, 19)
        Me.ExamenToolStripMenuItem1.Text = "Examenes"
        '
        'IngresoToolStripMenuItem
        '
        Me.IngresoToolStripMenuItem.Name = "IngresoToolStripMenuItem"
        Me.IngresoToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.IngresoToolStripMenuItem.Text = "Ingreso"
        '
        'VerificarToolStripMenuItem1
        '
        Me.VerificarToolStripMenuItem1.Name = "VerificarToolStripMenuItem1"
        Me.VerificarToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.VerificarToolStripMenuItem1.Text = "Verificar"
        '
        'NotasToolStripMenuItem1
        '
        Me.NotasToolStripMenuItem1.Name = "NotasToolStripMenuItem1"
        Me.NotasToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.NotasToolStripMenuItem1.Text = "Notas"
        '
        'ReunionesToolStripMenuItem
        '
        Me.ReunionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoToolStripMenuItem1, Me.VerificarToolStripMenuItem, Me.NotasToolStripMenuItem})
        Me.ReunionesToolStripMenuItem.Name = "ReunionesToolStripMenuItem"
        Me.ReunionesToolStripMenuItem.Size = New System.Drawing.Size(74, 19)
        Me.ReunionesToolStripMenuItem.Text = "Reuniones"
        '
        'IngresoToolStripMenuItem1
        '
        Me.IngresoToolStripMenuItem1.Name = "IngresoToolStripMenuItem1"
        Me.IngresoToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.IngresoToolStripMenuItem1.Text = "Ingreso"
        '
        'VerificarToolStripMenuItem
        '
        Me.VerificarToolStripMenuItem.Name = "VerificarToolStripMenuItem"
        Me.VerificarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.VerificarToolStripMenuItem.Text = "Verificar"
        '
        'NotasToolStripMenuItem
        '
        Me.NotasToolStripMenuItem.Name = "NotasToolStripMenuItem"
        Me.NotasToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.NotasToolStripMenuItem.Text = "Notas"
        '
        'InstitutoToolStripMenuItem
        '
        Me.InstitutoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem4, Me.BajaToolStripMenuItem4, Me.ModificarToolStripMenuItem})
        Me.InstitutoToolStripMenuItem.Name = "InstitutoToolStripMenuItem"
        Me.InstitutoToolStripMenuItem.Size = New System.Drawing.Size(63, 19)
        Me.InstitutoToolStripMenuItem.Text = "Instituto"
        '
        'AltaToolStripMenuItem4
        '
        Me.AltaToolStripMenuItem4.Name = "AltaToolStripMenuItem4"
        Me.AltaToolStripMenuItem4.Size = New System.Drawing.Size(125, 22)
        Me.AltaToolStripMenuItem4.Text = "Alta"
        '
        'BajaToolStripMenuItem4
        '
        Me.BajaToolStripMenuItem4.Name = "BajaToolStripMenuItem4"
        Me.BajaToolStripMenuItem4.Size = New System.Drawing.Size(125, 22)
        Me.BajaToolStripMenuItem4.Text = "Activos"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ConsultaToolStripMenuItem3
        '
        Me.ConsultaToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerToolStripMenuItem, Me.AsignaturaToolStripMenuItem1, Me.GrupoToolStripMenuItem1, Me.InstitutoToolStripMenuItem1, Me.HistorialToolStripMenuItem})
        Me.ConsultaToolStripMenuItem3.Name = "ConsultaToolStripMenuItem3"
        Me.ConsultaToolStripMenuItem3.Size = New System.Drawing.Size(66, 19)
        Me.ConsultaToolStripMenuItem3.Text = "Consulta"
        '
        'PerToolStripMenuItem
        '
        Me.PerToolStripMenuItem.Name = "PerToolStripMenuItem"
        Me.PerToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.PerToolStripMenuItem.Text = "Personas"
        '
        'AsignaturaToolStripMenuItem1
        '
        Me.AsignaturaToolStripMenuItem1.Name = "AsignaturaToolStripMenuItem1"
        Me.AsignaturaToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.AsignaturaToolStripMenuItem1.Text = "Asignatura"
        '
        'GrupoToolStripMenuItem1
        '
        Me.GrupoToolStripMenuItem1.Name = "GrupoToolStripMenuItem1"
        Me.GrupoToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.GrupoToolStripMenuItem1.Text = "Grupo"
        '
        'InstitutoToolStripMenuItem1
        '
        Me.InstitutoToolStripMenuItem1.Name = "InstitutoToolStripMenuItem1"
        Me.InstitutoToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.InstitutoToolStripMenuItem1.Text = "Instituto"
        '
        'HistorialToolStripMenuItem
        '
        Me.HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem"
        Me.HistorialToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.HistorialToolStripMenuItem.Text = "Historial"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActaFinalToolStripMenuItem, Me.ActaExamenToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(62, 19)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'ActaFinalToolStripMenuItem
        '
        Me.ActaFinalToolStripMenuItem.Name = "ActaFinalToolStripMenuItem"
        Me.ActaFinalToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ActaFinalToolStripMenuItem.Text = "Acta Final"
        '
        'ActaExamenToolStripMenuItem
        '
        Me.ActaExamenToolStripMenuItem.Name = "ActaExamenToolStripMenuItem"
        Me.ActaExamenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ActaExamenToolStripMenuItem.Text = "Acta Examen"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrientacionToolStripMenuItem, Me.TipoDeCursoToolStripMenuItem, Me.LocalidadToolStripMenuItem})
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(100, 19)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'OrientacionToolStripMenuItem
        '
        Me.OrientacionToolStripMenuItem.Name = "OrientacionToolStripMenuItem"
        Me.OrientacionToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.OrientacionToolStripMenuItem.Text = "Orientacion"
        '
        'TipoDeCursoToolStripMenuItem
        '
        Me.TipoDeCursoToolStripMenuItem.Name = "TipoDeCursoToolStripMenuItem"
        Me.TipoDeCursoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.TipoDeCursoToolStripMenuItem.Text = "Tipo de Curso"
        '
        'LocalidadToolStripMenuItem
        '
        Me.LocalidadToolStripMenuItem.Name = "LocalidadToolStripMenuItem"
        Me.LocalidadToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.LocalidadToolStripMenuItem.Text = "Localidad"
        '
        'AltaGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(718, 483)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblRecordar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.DGVConsulta)
        Me.Controls.Add(Me.btnInstituto)
        Me.Controls.Add(Me.cmbInstituto)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtgrado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.cmbtcurso)
        Me.Controls.Add(Me.cmbori)
        Me.Controls.Add(Me.cmbturno)
        Me.Controls.Add(Me.lbntipodecurso)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.lblturno)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblgrado)
        Me.Controls.Add(Me.lblorientacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaGrupo"
        Me.Text = "Alta Grupo"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblorientacion As System.Windows.Forms.Label
    Friend WithEvents lblgrado As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblturno As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents lbntipodecurso As System.Windows.Forms.Label
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbori As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtcurso As System.Windows.Forms.ComboBox
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtgrado As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmbInstituto As System.Windows.Forms.ComboBox
    Friend WithEvents btnInstituto As System.Windows.Forms.Button
    Friend WithEvents lblRecordar As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents DGVConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReunionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignaturaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstitutoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrientacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeCursoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
