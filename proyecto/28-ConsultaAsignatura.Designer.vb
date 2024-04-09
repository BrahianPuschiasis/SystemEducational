<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaAsignatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaAsignatura))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaInstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaAsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaInstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.txtBuscar = New System.Windows.Forms.TextBox
        Me.lblRecordar = New System.Windows.Forms.Label
        Me.lblBuscar = New System.Windows.Forms.Label
        Me.DGVConsulta = New System.Windows.Forms.DataGridView
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(252, 33)
        Me.MenuStrip1.TabIndex = 74
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaInstitutoToolStripMenuItem, Me.AltaGrupoToolStripMenuItem, Me.AltaAsignaturaToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 29)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaInstitutoToolStripMenuItem
        '
        Me.AltaInstitutoToolStripMenuItem.Name = "AltaInstitutoToolStripMenuItem"
        Me.AltaInstitutoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AltaInstitutoToolStripMenuItem.Text = " Instituto"
        '
        'AltaGrupoToolStripMenuItem
        '
        Me.AltaGrupoToolStripMenuItem.Name = "AltaGrupoToolStripMenuItem"
        Me.AltaGrupoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AltaGrupoToolStripMenuItem.Text = " Grupo"
        '
        'AltaAsignaturaToolStripMenuItem
        '
        Me.AltaAsignaturaToolStripMenuItem.Name = "AltaAsignaturaToolStripMenuItem"
        Me.AltaAsignaturaToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AltaAsignaturaToolStripMenuItem.Text = " Asignatura"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaInstitutoToolStripMenuItem, Me.BajaGrupoToolStripMenuItem, Me.BajaAsignaturaToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 29)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaInstitutoToolStripMenuItem
        '
        Me.BajaInstitutoToolStripMenuItem.Name = "BajaInstitutoToolStripMenuItem"
        Me.BajaInstitutoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.BajaInstitutoToolStripMenuItem.Text = " Instituto"
        '
        'BajaGrupoToolStripMenuItem
        '
        Me.BajaGrupoToolStripMenuItem.Name = "BajaGrupoToolStripMenuItem"
        Me.BajaGrupoToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.BajaGrupoToolStripMenuItem.Text = " Grupo"
        '
        'BajaAsignaturaToolStripMenuItem
        '
        Me.BajaAsignaturaToolStripMenuItem.Name = "BajaAsignaturaToolStripMenuItem"
        Me.BajaAsignaturaToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.BajaAsignaturaToolStripMenuItem.Text = " Asignatura"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(271, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 52)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta Asignatura"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 315
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(687, 63)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 314
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(687, 41)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 313
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(641, 63)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 312
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(641, 41)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 311
        Me.lblhora1.Text = "Hora:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(600, 203)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 325
        '
        'lblRecordar
        '
        Me.lblRecordar.AutoSize = True
        Me.lblRecordar.BackColor = System.Drawing.Color.LightGray
        Me.lblRecordar.Location = New System.Drawing.Point(586, 239)
        Me.lblRecordar.Name = "lblRecordar"
        Me.lblRecordar.Size = New System.Drawing.Size(133, 13)
        Me.lblRecordar.TabIndex = 324
        Me.lblRecordar.Text = "¡Recuerde presionar enter!"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.LightGray
        Me.lblBuscar.Location = New System.Drawing.Point(551, 206)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(43, 13)
        Me.lblBuscar.TabIndex = 323
        Me.lblBuscar.Text = "Buscar:"
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
        Me.DGVConsulta.Location = New System.Drawing.Point(23, 182)
        Me.DGVConsulta.MultiSelect = False
        Me.DGVConsulta.Name = "DGVConsulta"
        Me.DGVConsulta.ReadOnly = True
        Me.DGVConsulta.Size = New System.Drawing.Size(522, 327)
        Me.DGVConsulta.TabIndex = 326
        '
        'ConsultaAsignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(779, 521)
        Me.Controls.Add(Me.DGVConsulta)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblRecordar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaAsignatura"
        Me.Text = "Consulta Asignatura"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaInstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaAsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaAsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaInstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblRecordar As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents DGVConsulta As System.Windows.Forms.DataGridView
End Class
