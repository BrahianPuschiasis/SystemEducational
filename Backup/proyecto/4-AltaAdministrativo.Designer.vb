<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaAdministrativo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaAdministrativo))
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.grpdatosp = New System.Windows.Forms.GroupBox
        Me.lblRecordar = New System.Windows.Forms.Label
        Me.btnLocalidad = New System.Windows.Forms.Button
        Me.cmblocalidad = New System.Windows.Forms.TextBox
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.txttelefonoadmin = New System.Windows.Forms.MaskedTextBox
        Me.txtfechanacadmin = New System.Windows.Forms.MaskedTextBox
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.lbnlocalidad = New System.Windows.Forms.Label
        Me.lbltelefonoadmin = New System.Windows.Forms.Label
        Me.DGVConsulta = New System.Windows.Forms.DataGridView
        Me.lblfechanacadmin = New System.Windows.Forms.Label
        Me.txtnombre2 = New System.Windows.Forms.TextBox
        Me.lblnombre2 = New System.Windows.Forms.Label
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.txtamaterno = New System.Windows.Forms.TextBox
        Me.txtapaterno = New System.Windows.Forms.TextBox
        Me.txtnombre1 = New System.Windows.Forms.TextBox
        Me.lbldireccion = New System.Windows.Forms.Label
        Me.lblamaterno = New System.Windows.Forms.Label
        Me.lblapaterno = New System.Windows.Forms.Label
        Me.lblnombre1 = New System.Windows.Forms.Label
        Me.lblci = New System.Windows.Forms.Label
        Me.btnverificar = New System.Windows.Forms.Button
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtci = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
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
        Me.grpdatosp.SuspendLayout()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnconfirmar.Location = New System.Drawing.Point(736, 473)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(136, 53)
        Me.btnconfirmar.TabIndex = 35
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'grpdatosp
        '
        Me.grpdatosp.Controls.Add(Me.lblRecordar)
        Me.grpdatosp.Controls.Add(Me.btnLocalidad)
        Me.grpdatosp.Controls.Add(Me.cmblocalidad)
        Me.grpdatosp.Controls.Add(Me.lblBuscar)
        Me.grpdatosp.Controls.Add(Me.txttelefonoadmin)
        Me.grpdatosp.Controls.Add(Me.txtfechanacadmin)
        Me.grpdatosp.Controls.Add(Me.txtBuscar)
        Me.grpdatosp.Controls.Add(Me.lbnlocalidad)
        Me.grpdatosp.Controls.Add(Me.lbltelefonoadmin)
        Me.grpdatosp.Controls.Add(Me.DGVConsulta)
        Me.grpdatosp.Controls.Add(Me.lblfechanacadmin)
        Me.grpdatosp.Controls.Add(Me.txtnombre2)
        Me.grpdatosp.Controls.Add(Me.lblnombre2)
        Me.grpdatosp.Controls.Add(Me.txtdireccion)
        Me.grpdatosp.Controls.Add(Me.txtamaterno)
        Me.grpdatosp.Controls.Add(Me.txtapaterno)
        Me.grpdatosp.Controls.Add(Me.txtnombre1)
        Me.grpdatosp.Controls.Add(Me.lbldireccion)
        Me.grpdatosp.Controls.Add(Me.lblamaterno)
        Me.grpdatosp.Controls.Add(Me.lblapaterno)
        Me.grpdatosp.Controls.Add(Me.lblnombre1)
        Me.grpdatosp.Enabled = False
        Me.grpdatosp.Location = New System.Drawing.Point(136, 197)
        Me.grpdatosp.Name = "grpdatosp"
        Me.grpdatosp.Size = New System.Drawing.Size(548, 242)
        Me.grpdatosp.TabIndex = 101
        Me.grpdatosp.TabStop = False
        Me.grpdatosp.Text = "Datos Personales"
        '
        'lblRecordar
        '
        Me.lblRecordar.AutoSize = True
        Me.lblRecordar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRecordar.Location = New System.Drawing.Point(285, 63)
        Me.lblRecordar.Name = "lblRecordar"
        Me.lblRecordar.Size = New System.Drawing.Size(133, 13)
        Me.lblRecordar.TabIndex = 296
        Me.lblRecordar.Text = "¡Recuerde presionar enter!"
        Me.lblRecordar.Visible = False
        '
        'btnLocalidad
        '
        Me.btnLocalidad.Location = New System.Drawing.Point(232, 155)
        Me.btnLocalidad.Name = "btnLocalidad"
        Me.btnLocalidad.Size = New System.Drawing.Size(37, 20)
        Me.btnLocalidad.TabIndex = 292
        Me.btnLocalidad.Text = "?"
        Me.btnLocalidad.UseVisualStyleBackColor = True
        '
        'cmblocalidad
        '
        Me.cmblocalidad.Location = New System.Drawing.Point(143, 152)
        Me.cmblocalidad.Name = "cmblocalidad"
        Me.cmblocalidad.Size = New System.Drawing.Size(70, 20)
        Me.cmblocalidad.TabIndex = 291
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblBuscar.Location = New System.Drawing.Point(239, 29)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 295
        Me.lblBuscar.Text = "Buscar:"
        Me.lblBuscar.Visible = False
        '
        'txttelefonoadmin
        '
        Me.txttelefonoadmin.Location = New System.Drawing.Point(245, 192)
        Me.txttelefonoadmin.Mask = "0-0-00-00-00"
        Me.txttelefonoadmin.Name = "txttelefonoadmin"
        Me.txttelefonoadmin.Size = New System.Drawing.Size(73, 20)
        Me.txttelefonoadmin.TabIndex = 290
        Me.txttelefonoadmin.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtfechanacadmin
        '
        Me.txtfechanacadmin.Location = New System.Drawing.Point(143, 114)
        Me.txtfechanacadmin.Mask = "00/00/0000"
        Me.txtfechanacadmin.Name = "txtfechanacadmin"
        Me.txtfechanacadmin.Size = New System.Drawing.Size(73, 20)
        Me.txtfechanacadmin.TabIndex = 289
        Me.txtfechanacadmin.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtfechanacadmin.ValidatingType = GetType(Date)
        '
        'txtBuscar
        '
        Me.txtBuscar.CausesValidation = False
        Me.txtBuscar.Location = New System.Drawing.Point(288, 26)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(107, 20)
        Me.txtBuscar.TabIndex = 294
        Me.txtBuscar.Visible = False
        '
        'lbnlocalidad
        '
        Me.lbnlocalidad.AutoSize = True
        Me.lbnlocalidad.Location = New System.Drawing.Point(14, 155)
        Me.lbnlocalidad.Name = "lbnlocalidad"
        Me.lbnlocalidad.Size = New System.Drawing.Size(59, 13)
        Me.lbnlocalidad.TabIndex = 118
        Me.lbnlocalidad.Text = "Localidad :"
        '
        'lbltelefonoadmin
        '
        Me.lbltelefonoadmin.AutoSize = True
        Me.lbltelefonoadmin.Location = New System.Drawing.Point(143, 195)
        Me.lbltelefonoadmin.Name = "lbltelefonoadmin"
        Me.lbltelefonoadmin.Size = New System.Drawing.Size(55, 13)
        Me.lbltelefonoadmin.TabIndex = 116
        Me.lbltelefonoadmin.Text = "Telefono :"
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
        Me.DGVConsulta.Location = New System.Drawing.Point(16, 19)
        Me.DGVConsulta.MultiSelect = False
        Me.DGVConsulta.Name = "DGVConsulta"
        Me.DGVConsulta.ReadOnly = True
        Me.DGVConsulta.Size = New System.Drawing.Size(521, 212)
        Me.DGVConsulta.TabIndex = 293
        Me.DGVConsulta.Visible = False
        '
        'lblfechanacadmin
        '
        Me.lblfechanacadmin.AutoSize = True
        Me.lblfechanacadmin.Location = New System.Drawing.Point(14, 117)
        Me.lblfechanacadmin.Name = "lblfechanacadmin"
        Me.lblfechanacadmin.Size = New System.Drawing.Size(114, 13)
        Me.lblfechanacadmin.TabIndex = 115
        Me.lblfechanacadmin.Text = "Fecha de Nacimiento :"
        '
        'txtnombre2
        '
        Me.txtnombre2.Location = New System.Drawing.Point(370, 29)
        Me.txtnombre2.Name = "txtnombre2"
        Me.txtnombre2.Size = New System.Drawing.Size(157, 20)
        Me.txtnombre2.TabIndex = 109
        '
        'lblnombre2
        '
        Me.lblnombre2.AutoSize = True
        Me.lblnombre2.Location = New System.Drawing.Point(260, 29)
        Me.lblnombre2.Name = "lblnombre2"
        Me.lblnombre2.Size = New System.Drawing.Size(94, 13)
        Me.lblnombre2.TabIndex = 103
        Me.lblnombre2.Text = "Segundo nombre :"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(370, 114)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(157, 20)
        Me.txtdireccion.TabIndex = 112
        '
        'txtamaterno
        '
        Me.txtamaterno.Location = New System.Drawing.Point(370, 73)
        Me.txtamaterno.Name = "txtamaterno"
        Me.txtamaterno.Size = New System.Drawing.Size(157, 20)
        Me.txtamaterno.TabIndex = 111
        '
        'txtapaterno
        '
        Me.txtapaterno.Location = New System.Drawing.Point(109, 73)
        Me.txtapaterno.Name = "txtapaterno"
        Me.txtapaterno.Size = New System.Drawing.Size(137, 20)
        Me.txtapaterno.TabIndex = 110
        '
        'txtnombre1
        '
        Me.txtnombre1.Location = New System.Drawing.Point(109, 32)
        Me.txtnombre1.Name = "txtnombre1"
        Me.txtnombre1.Size = New System.Drawing.Size(137, 20)
        Me.txtnombre1.TabIndex = 108
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(260, 117)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(58, 13)
        Me.lbldireccion.TabIndex = 106
        Me.lbldireccion.Text = "Direccion :"
        '
        'lblamaterno
        '
        Me.lblamaterno.AutoSize = True
        Me.lblamaterno.Location = New System.Drawing.Point(259, 76)
        Me.lblamaterno.Name = "lblamaterno"
        Me.lblamaterno.Size = New System.Drawing.Size(92, 13)
        Me.lblamaterno.TabIndex = 105
        Me.lblamaterno.Text = "Apellido Materno :"
        '
        'lblapaterno
        '
        Me.lblapaterno.AutoSize = True
        Me.lblapaterno.Location = New System.Drawing.Point(13, 76)
        Me.lblapaterno.Name = "lblapaterno"
        Me.lblapaterno.Size = New System.Drawing.Size(90, 13)
        Me.lblapaterno.TabIndex = 104
        Me.lblapaterno.Text = "Apellido Paterno :"
        '
        'lblnombre1
        '
        Me.lblnombre1.AutoSize = True
        Me.lblnombre1.Location = New System.Drawing.Point(14, 32)
        Me.lblnombre1.Name = "lblnombre1"
        Me.lblnombre1.Size = New System.Drawing.Size(80, 13)
        Me.lblnombre1.TabIndex = 102
        Me.lblnombre1.Text = "Primer nombre :"
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(204, 166)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(26, 13)
        Me.lblci.TabIndex = 101
        Me.lblci.Text = "C.I :"
        '
        'btnverificar
        '
        Me.btnverificar.Location = New System.Drawing.Point(465, 161)
        Me.btnverificar.Name = "btnverificar"
        Me.btnverificar.Size = New System.Drawing.Size(118, 23)
        Me.btnverificar.TabIndex = 108
        Me.btnverificar.Text = "Verificar Existencia"
        Me.btnverificar.UseVisualStyleBackColor = True
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 132
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(791, 64)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 131
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(791, 42)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 130
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(745, 64)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 129
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(745, 42)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 128
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(396, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Registro"
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(284, 163)
        Me.txtci.Mask = "0.000.000-0"
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(73, 20)
        Me.txtci.TabIndex = 287
        Me.txtci.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(160, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 42)
        Me.GroupBox1.TabIndex = 288
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
        Me.PersonasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionToolStripMenuItem5})
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
        Me.PersonasToolStripMenuItem.Text = "Personas"
        '
        'ModificacionToolStripMenuItem5
        '
        Me.ModificacionToolStripMenuItem5.Name = "ModificacionToolStripMenuItem5"
        Me.ModificacionToolStripMenuItem5.Size = New System.Drawing.Size(152, 22)
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
        'AltaAdministrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(874, 524)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.btnverificar)
        Me.Controls.Add(Me.grpdatosp)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.lblci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaAdministrativo"
        Me.Text = "Alta Administrativo"
        Me.grpdatosp.ResumeLayout(False)
        Me.grpdatosp.PerformLayout()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents grpdatosp As System.Windows.Forms.GroupBox
    Friend WithEvents lbltelefonoadmin As System.Windows.Forms.Label
    Friend WithEvents lblfechanacadmin As System.Windows.Forms.Label
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
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents btnverificar As System.Windows.Forms.Button
    Friend WithEvents lbnlocalidad As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtci As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtfechanacadmin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txttelefonoadmin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmblocalidad As System.Windows.Forms.TextBox
    Friend WithEvents btnLocalidad As System.Windows.Forms.Button
    Friend WithEvents lblRecordar As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents DGVConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
