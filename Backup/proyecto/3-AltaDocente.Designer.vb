<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaDocente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaDocente))
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.btnverificar = New System.Windows.Forms.Button
        Me.lblci = New System.Windows.Forms.Label
        Me.grpdicta = New System.Windows.Forms.GroupBox
        Me.btnAsignatura = New System.Windows.Forms.Button
        Me.txtidasig = New System.Windows.Forms.TextBox
        Me.btnGrupo = New System.Windows.Forms.Button
        Me.txtidgrupo = New System.Windows.Forms.TextBox
        Me.btnInstituto = New System.Windows.Forms.Button
        Me.cmbinst = New System.Windows.Forms.TextBox
        Me.lblidinst = New System.Windows.Forms.Label
        Me.lbnidasign = New System.Windows.Forms.Label
        Me.lbnidgrupo = New System.Windows.Forms.Label
        Me.DGVConsulta = New System.Windows.Forms.DataGridView
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DGAAlumnos = New System.Windows.Forms.DataGridView
        Me.DGADocente = New System.Windows.Forms.DataGridView
        Me.lblRecordar = New System.Windows.Forms.Label
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.lblCargo = New System.Windows.Forms.Label
        Me.cmbCargo = New System.Windows.Forms.ComboBox
        Me.txtci = New System.Windows.Forms.MaskedTextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
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
        Me.grpdicta.SuspendLayout()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGAAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGADocente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.Enabled = False
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(653, 500)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(146, 52)
        Me.btnconfirmar.TabIndex = 35
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'btnverificar
        '
        Me.btnverificar.Location = New System.Drawing.Point(345, 16)
        Me.btnverificar.Name = "btnverificar"
        Me.btnverificar.Size = New System.Drawing.Size(118, 23)
        Me.btnverificar.TabIndex = 114
        Me.btnverificar.Text = "Verificar Existencia"
        Me.btnverificar.UseVisualStyleBackColor = True
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(113, 20)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(26, 13)
        Me.lblci.TabIndex = 112
        Me.lblci.Text = "C.I :"
        '
        'grpdicta
        '
        Me.grpdicta.Controls.Add(Me.btnAsignatura)
        Me.grpdicta.Controls.Add(Me.txtidasig)
        Me.grpdicta.Controls.Add(Me.btnGrupo)
        Me.grpdicta.Controls.Add(Me.txtidgrupo)
        Me.grpdicta.Controls.Add(Me.btnInstituto)
        Me.grpdicta.Controls.Add(Me.cmbinst)
        Me.grpdicta.Controls.Add(Me.lblidinst)
        Me.grpdicta.Controls.Add(Me.lbnidasign)
        Me.grpdicta.Controls.Add(Me.lbnidgrupo)
        Me.grpdicta.Enabled = False
        Me.grpdicta.Location = New System.Drawing.Point(37, 112)
        Me.grpdicta.Name = "grpdicta"
        Me.grpdicta.Size = New System.Drawing.Size(321, 138)
        Me.grpdicta.TabIndex = 119
        Me.grpdicta.TabStop = False
        Me.grpdicta.Text = "Formulario Docente"
        Me.grpdicta.Visible = False
        '
        'btnAsignatura
        '
        Me.btnAsignatura.Enabled = False
        Me.btnAsignatura.Location = New System.Drawing.Point(228, 95)
        Me.btnAsignatura.Name = "btnAsignatura"
        Me.btnAsignatura.Size = New System.Drawing.Size(37, 20)
        Me.btnAsignatura.TabIndex = 294
        Me.btnAsignatura.Text = "?"
        Me.btnAsignatura.UseVisualStyleBackColor = True
        '
        'txtidasig
        '
        Me.txtidasig.Enabled = False
        Me.txtidasig.Location = New System.Drawing.Point(114, 99)
        Me.txtidasig.Name = "txtidasig"
        Me.txtidasig.Size = New System.Drawing.Size(95, 20)
        Me.txtidasig.TabIndex = 293
        '
        'btnGrupo
        '
        Me.btnGrupo.Enabled = False
        Me.btnGrupo.Location = New System.Drawing.Point(228, 64)
        Me.btnGrupo.Name = "btnGrupo"
        Me.btnGrupo.Size = New System.Drawing.Size(37, 20)
        Me.btnGrupo.TabIndex = 292
        Me.btnGrupo.Text = "?"
        Me.btnGrupo.UseVisualStyleBackColor = True
        '
        'txtidgrupo
        '
        Me.txtidgrupo.Enabled = False
        Me.txtidgrupo.Location = New System.Drawing.Point(114, 64)
        Me.txtidgrupo.Name = "txtidgrupo"
        Me.txtidgrupo.Size = New System.Drawing.Size(95, 20)
        Me.txtidgrupo.TabIndex = 291
        '
        'btnInstituto
        '
        Me.btnInstituto.Location = New System.Drawing.Point(228, 26)
        Me.btnInstituto.Name = "btnInstituto"
        Me.btnInstituto.Size = New System.Drawing.Size(37, 20)
        Me.btnInstituto.TabIndex = 290
        Me.btnInstituto.Text = "?"
        Me.btnInstituto.UseVisualStyleBackColor = True
        '
        'cmbinst
        '
        Me.cmbinst.Location = New System.Drawing.Point(114, 26)
        Me.cmbinst.Name = "cmbinst"
        Me.cmbinst.Size = New System.Drawing.Size(95, 20)
        Me.cmbinst.TabIndex = 123
        '
        'lblidinst
        '
        Me.lblidinst.AutoSize = True
        Me.lblidinst.Location = New System.Drawing.Point(11, 26)
        Me.lblidinst.Name = "lblidinst"
        Me.lblidinst.Size = New System.Drawing.Size(83, 13)
        Me.lblidinst.TabIndex = 122
        Me.lblidinst.Text = "Código Instituto:"
        '
        'lbnidasign
        '
        Me.lbnidasign.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.lbnidasign.AutoSize = True
        Me.lbnidasign.Location = New System.Drawing.Point(11, 102)
        Me.lbnidasign.Name = "lbnidasign"
        Me.lbnidasign.Size = New System.Drawing.Size(96, 13)
        Me.lbnidasign.TabIndex = 121
        Me.lbnidasign.Text = "Código Asignatura:"
        Me.lbnidasign.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbnidgrupo
        '
        Me.lbnidgrupo.AutoSize = True
        Me.lbnidgrupo.Enabled = False
        Me.lbnidgrupo.Location = New System.Drawing.Point(11, 67)
        Me.lbnidgrupo.Name = "lbnidgrupo"
        Me.lbnidgrupo.Size = New System.Drawing.Size(75, 13)
        Me.lbnidgrupo.TabIndex = 117
        Me.lbnidgrupo.Text = "Código Grupo:"
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
        Me.DGVConsulta.Location = New System.Drawing.Point(20, 77)
        Me.DGVConsulta.MultiSelect = False
        Me.DGVConsulta.Name = "DGVConsulta"
        Me.DGVConsulta.ReadOnly = True
        Me.DGVConsulta.Size = New System.Drawing.Size(716, 212)
        Me.DGVConsulta.TabIndex = 290
        Me.DGVConsulta.Visible = False
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(8, 9)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 126
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(707, 61)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 125
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(707, 39)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 124
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(661, 61)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 123
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(661, 39)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 122
        Me.lblhora1.Text = "Hora:"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DGAAlumnos)
        Me.Panel1.Controls.Add(Me.DGADocente)
        Me.Panel1.Controls.Add(Me.lblRecordar)
        Me.Panel1.Controls.Add(Me.lblBuscar)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.lblCargo)
        Me.Panel1.Controls.Add(Me.cmbCargo)
        Me.Panel1.Controls.Add(Me.txtci)
        Me.Panel1.Controls.Add(Me.lblci)
        Me.Panel1.Controls.Add(Me.btnverificar)
        Me.Panel1.Controls.Add(Me.grpdicta)
        Me.Panel1.Controls.Add(Me.DGVConsulta)
        Me.Panel1.Location = New System.Drawing.Point(20, 169)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 316)
        Me.Panel1.TabIndex = 127
        '
        'DGAAlumnos
        '
        Me.DGAAlumnos.AllowUserToAddRows = False
        Me.DGAAlumnos.AllowUserToDeleteRows = False
        Me.DGAAlumnos.AllowUserToResizeColumns = False
        Me.DGAAlumnos.AllowUserToResizeRows = False
        Me.DGAAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DGAAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGAAlumnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGAAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGAAlumnos.Location = New System.Drawing.Point(384, 53)
        Me.DGAAlumnos.MultiSelect = False
        Me.DGAAlumnos.Name = "DGAAlumnos"
        Me.DGAAlumnos.ReadOnly = True
        Me.DGAAlumnos.Size = New System.Drawing.Size(363, 263)
        Me.DGAAlumnos.TabIndex = 295
        Me.DGAAlumnos.Visible = False
        '
        'DGADocente
        '
        Me.DGADocente.AllowUserToAddRows = False
        Me.DGADocente.AllowUserToDeleteRows = False
        Me.DGADocente.AllowUserToResizeColumns = False
        Me.DGADocente.AllowUserToResizeRows = False
        Me.DGADocente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DGADocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGADocente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGADocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGADocente.Location = New System.Drawing.Point(384, 53)
        Me.DGADocente.MultiSelect = False
        Me.DGADocente.Name = "DGADocente"
        Me.DGADocente.ReadOnly = True
        Me.DGADocente.Size = New System.Drawing.Size(363, 263)
        Me.DGADocente.TabIndex = 294
        Me.DGADocente.Visible = False
        '
        'lblRecordar
        '
        Me.lblRecordar.AutoSize = True
        Me.lblRecordar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRecordar.Location = New System.Drawing.Point(589, 133)
        Me.lblRecordar.Name = "lblRecordar"
        Me.lblRecordar.Size = New System.Drawing.Size(133, 13)
        Me.lblRecordar.TabIndex = 293
        Me.lblRecordar.Text = "¡Recuerde presionar enter!"
        Me.lblRecordar.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblBuscar.Location = New System.Drawing.Point(543, 99)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 292
        Me.lblBuscar.Text = "Buscar:"
        Me.lblBuscar.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.CausesValidation = False
        Me.txtBuscar.Location = New System.Drawing.Point(592, 96)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(107, 20)
        Me.txtBuscar.TabIndex = 291
        Me.txtBuscar.Visible = False
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Enabled = False
        Me.lblCargo.Location = New System.Drawing.Point(113, 53)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(38, 13)
        Me.lblCargo.TabIndex = 289
        Me.lblCargo.Text = "Cargo:"
        '
        'cmbCargo
        '
        Me.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCargo.Enabled = False
        Me.cmbCargo.FormattingEnabled = True
        Me.cmbCargo.Items.AddRange(New Object() {"Administrador", "Docente", "Alumno"})
        Me.cmbCargo.Location = New System.Drawing.Point(192, 50)
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.Size = New System.Drawing.Size(139, 21)
        Me.cmbCargo.TabIndex = 288
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(192, 17)
        Me.txtci.Mask = "0.000.000-0"
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(73, 20)
        Me.txtci.TabIndex = 287
        Me.txtci.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(114, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 42)
        Me.GroupBox1.TabIndex = 128
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
        Me.PersonasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem5})
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
        'AltaDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(800, 552)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.btnconfirmar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaDocente"
        Me.Text = "Alta Docente"
        Me.grpdicta.ResumeLayout(False)
        Me.grpdicta.PerformLayout()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGAAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGADocente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents btnverificar As System.Windows.Forms.Button
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents grpdicta As System.Windows.Forms.GroupBox
    Friend WithEvents lbnidasign As System.Windows.Forms.Label
    Friend WithEvents lbnidgrupo As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtci As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblidinst As System.Windows.Forms.Label
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents cmbCargo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbinst As System.Windows.Forms.TextBox
    Friend WithEvents btnInstituto As System.Windows.Forms.Button
    Friend WithEvents DGVConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents btnGrupo As System.Windows.Forms.Button
    Friend WithEvents txtidgrupo As System.Windows.Forms.TextBox
    Friend WithEvents btnAsignatura As System.Windows.Forms.Button
    Friend WithEvents txtidasig As System.Windows.Forms.TextBox
    Friend WithEvents lblRecordar As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents DGADocente As System.Windows.Forms.DataGridView
    Friend WithEvents DGAAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
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
