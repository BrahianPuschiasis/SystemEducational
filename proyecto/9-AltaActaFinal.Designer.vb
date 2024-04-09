<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaActaFinal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaActaFinal))
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblidgrupo = New System.Windows.Forms.Label
        Me.cmbgrupo = New System.Windows.Forms.TextBox
        Me.btnGrupo = New System.Windows.Forms.Button
        Me.DGVConsulta = New System.Windows.Forms.DataGridView
        Me.lblRecordar = New System.Windows.Forms.Label
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.txtfechanacadmin = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.AltaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExamenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.NotasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReunionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
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
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(678, 447)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(122, 53)
        Me.btnconfirmar.TabIndex = 35
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Alta reunion final"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 135
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(724, 71)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 134
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(724, 49)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 133
        Me.lblhora2.Text = "00:00:00"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(675, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(675, 49)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 131
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblidgrupo
        '
        Me.lblidgrupo.AutoSize = True
        Me.lblidgrupo.Enabled = False
        Me.lblidgrupo.Location = New System.Drawing.Point(235, 226)
        Me.lblidgrupo.Name = "lblidgrupo"
        Me.lblidgrupo.Size = New System.Drawing.Size(75, 13)
        Me.lblidgrupo.TabIndex = 97
        Me.lblidgrupo.Text = "Código Grupo:"
        '
        'cmbgrupo
        '
        Me.cmbgrupo.Location = New System.Drawing.Point(337, 223)
        Me.cmbgrupo.Name = "cmbgrupo"
        Me.cmbgrupo.Size = New System.Drawing.Size(100, 20)
        Me.cmbgrupo.TabIndex = 98
        '
        'btnGrupo
        '
        Me.btnGrupo.Enabled = False
        Me.btnGrupo.Location = New System.Drawing.Point(458, 226)
        Me.btnGrupo.Name = "btnGrupo"
        Me.btnGrupo.Size = New System.Drawing.Size(37, 20)
        Me.btnGrupo.TabIndex = 293
        Me.btnGrupo.Text = "?"
        Me.btnGrupo.UseVisualStyleBackColor = True
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
        Me.DGVConsulta.Location = New System.Drawing.Point(12, 175)
        Me.DGVConsulta.MultiSelect = False
        Me.DGVConsulta.Name = "DGVConsulta"
        Me.DGVConsulta.ReadOnly = True
        Me.DGVConsulta.Size = New System.Drawing.Size(611, 212)
        Me.DGVConsulta.TabIndex = 294
        Me.DGVConsulta.Visible = False
        '
        'lblRecordar
        '
        Me.lblRecordar.AutoSize = True
        Me.lblRecordar.BackColor = System.Drawing.Color.LightGray
        Me.lblRecordar.Location = New System.Drawing.Point(655, 226)
        Me.lblRecordar.Name = "lblRecordar"
        Me.lblRecordar.Size = New System.Drawing.Size(133, 13)
        Me.lblRecordar.TabIndex = 299
        Me.lblRecordar.Text = "¡Recuerde presionar enter!"
        Me.lblRecordar.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.LightGray
        Me.lblBuscar.Location = New System.Drawing.Point(629, 192)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 298
        Me.lblBuscar.Text = "Buscar:"
        Me.lblBuscar.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.CausesValidation = False
        Me.txtBuscar.Location = New System.Drawing.Point(678, 189)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(107, 20)
        Me.txtBuscar.TabIndex = 297
        Me.txtBuscar.Visible = False
        '
        'txtfechanacadmin
        '
        Me.txtfechanacadmin.Location = New System.Drawing.Point(337, 258)
        Me.txtfechanacadmin.Mask = "00/00/0000"
        Me.txtfechanacadmin.Name = "txtfechanacadmin"
        Me.txtfechanacadmin.Size = New System.Drawing.Size(73, 20)
        Me.txtfechanacadmin.TabIndex = 300
        Me.txtfechanacadmin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtfechanacadmin.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 301
        Me.Label3.Text = "Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(73, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 42)
        Me.GroupBox1.TabIndex = 302
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
        Me.AltaToolStripMenuItem5.Text = "
"
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
        Me.GrupoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem1, Me.BajaToolStripMenuItem1})
        Me.GrupoToolStripMenuItem.Name = "GrupoToolStripMenuItem"
        Me.GrupoToolStripMenuItem.Size = New System.Drawing.Size(52, 19)
        Me.GrupoToolStripMenuItem.Text = "Grupo"
        '
        'AltaToolStripMenuItem1
        '
        Me.AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        Me.AltaToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.AltaToolStripMenuItem1.Text = "Alta"
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
        Me.IngresoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IngresoToolStripMenuItem.Text = "Ingreso"
        '
        'VerificarToolStripMenuItem1
        '
        Me.VerificarToolStripMenuItem1.Name = "VerificarToolStripMenuItem1"
        Me.VerificarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.VerificarToolStripMenuItem1.Text = "Verificar"
        '
        'NotasToolStripMenuItem1
        '
        Me.NotasToolStripMenuItem1.Name = "NotasToolStripMenuItem1"
        Me.NotasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NotasToolStripMenuItem1.Text = "Notas"
        '
        'ReunionesToolStripMenuItem
        '
        Me.ReunionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerificarToolStripMenuItem, Me.NotasToolStripMenuItem})
        Me.ReunionesToolStripMenuItem.Name = "ReunionesToolStripMenuItem"
        Me.ReunionesToolStripMenuItem.Size = New System.Drawing.Size(74, 19)
        Me.ReunionesToolStripMenuItem.Text = "Reuniones"
        '
        'VerificarToolStripMenuItem
        '
        Me.VerificarToolStripMenuItem.Name = "VerificarToolStripMenuItem"
        Me.VerificarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerificarToolStripMenuItem.Text = "Verificar"
        '
        'NotasToolStripMenuItem
        '
        Me.NotasToolStripMenuItem.Name = "NotasToolStripMenuItem"
        Me.NotasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'AltaActaFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtfechanacadmin)
        Me.Controls.Add(Me.lblRecordar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.DGVConsulta)
        Me.Controls.Add(Me.btnGrupo)
        Me.Controls.Add(Me.cmbgrupo)
        Me.Controls.Add(Me.lblidgrupo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.btnconfirmar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaActaFinal"
        Me.Text = "Alta Acta Final"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblidgrupo As System.Windows.Forms.Label
    Friend WithEvents cmbgrupo As System.Windows.Forms.TextBox
    Friend WithEvents btnGrupo As System.Windows.Forms.Button
    Friend WithEvents DGVConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents lblRecordar As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents txtfechanacadmin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents AltaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReunionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
