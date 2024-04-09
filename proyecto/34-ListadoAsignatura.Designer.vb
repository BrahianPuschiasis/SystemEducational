<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoAsignatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoAsignatura))
        Me.cmblistado = New System.Windows.Forms.ComboBox
        Me.DGVListado = New System.Windows.Forms.DataGridView
        Me.btnmenuprincipal = New System.Windows.Forms.Button
        Me.Ordenar = New System.Windows.Forms.GroupBox
        Me.btnAscendente = New System.Windows.Forms.Button
        Me.btndescendente = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaAsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaInstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaInstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionAsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionInstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ordenar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmblistado
        '
        Me.cmblistado.FormattingEnabled = True
        Me.cmblistado.Items.AddRange(New Object() {"idasign", "nombre"})
        Me.cmblistado.Location = New System.Drawing.Point(58, 98)
        Me.cmblistado.Name = "cmblistado"
        Me.cmblistado.Size = New System.Drawing.Size(121, 21)
        Me.cmblistado.TabIndex = 101
        '
        'DGVListado
        '
        Me.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListado.Location = New System.Drawing.Point(236, 44)
        Me.DGVListado.Name = "DGVListado"
        Me.DGVListado.Size = New System.Drawing.Size(237, 150)
        Me.DGVListado.TabIndex = 100
        '
        'btnmenuprincipal
        '
        Me.btnmenuprincipal.Location = New System.Drawing.Point(58, 298)
        Me.btnmenuprincipal.Name = "btnmenuprincipal"
        Me.btnmenuprincipal.Size = New System.Drawing.Size(105, 23)
        Me.btnmenuprincipal.TabIndex = 95
        Me.btnmenuprincipal.Text = "Menu Principal"
        Me.btnmenuprincipal.UseVisualStyleBackColor = True
        '
        'Ordenar
        '
        Me.Ordenar.Controls.Add(Me.btnAscendente)
        Me.Ordenar.Controls.Add(Me.btndescendente)
        Me.Ordenar.Location = New System.Drawing.Point(236, 210)
        Me.Ordenar.Name = "Ordenar"
        Me.Ordenar.Size = New System.Drawing.Size(237, 100)
        Me.Ordenar.TabIndex = 102
        Me.Ordenar.TabStop = False
        Me.Ordenar.Text = "Ordenar en forma"
        '
        'btnAscendente
        '
        Me.btnAscendente.Location = New System.Drawing.Point(18, 44)
        Me.btnAscendente.Name = "btnAscendente"
        Me.btnAscendente.Size = New System.Drawing.Size(89, 23)
        Me.btnAscendente.TabIndex = 68
        Me.btnAscendente.Text = "Ascendente"
        Me.btnAscendente.UseVisualStyleBackColor = True
        '
        'btndescendente
        '
        Me.btndescendente.Location = New System.Drawing.Point(128, 44)
        Me.btndescendente.Name = "btndescendente"
        Me.btndescendente.Size = New System.Drawing.Size(97, 23)
        Me.btndescendente.TabIndex = 69
        Me.btndescendente.Text = "Descendente"
        Me.btndescendente.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(532, 24)
        Me.MenuStrip1.TabIndex = 103
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaAsignaturaToolStripMenuItem, Me.AltaGrupoToolStripMenuItem, Me.AltaInstitutoToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaAsignaturaToolStripMenuItem
        '
        Me.AltaAsignaturaToolStripMenuItem.Name = "AltaAsignaturaToolStripMenuItem"
        Me.AltaAsignaturaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AltaAsignaturaToolStripMenuItem.Text = "Alta Asignatura"
        '
        'AltaGrupoToolStripMenuItem
        '
        Me.AltaGrupoToolStripMenuItem.Name = "AltaGrupoToolStripMenuItem"
        Me.AltaGrupoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AltaGrupoToolStripMenuItem.Text = "Alta Grupo"
        '
        'AltaInstitutoToolStripMenuItem
        '
        Me.AltaInstitutoToolStripMenuItem.Name = "AltaInstitutoToolStripMenuItem"
        Me.AltaInstitutoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AltaInstitutoToolStripMenuItem.Text = "Alta Instituto"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaAsignaturaToolStripMenuItem, Me.BajaGrupoToolStripMenuItem, Me.BajaInstitutoToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaAsignaturaToolStripMenuItem
        '
        Me.BajaAsignaturaToolStripMenuItem.Name = "BajaAsignaturaToolStripMenuItem"
        Me.BajaAsignaturaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BajaAsignaturaToolStripMenuItem.Text = "Baja Asignatura"
        '
        'BajaGrupoToolStripMenuItem
        '
        Me.BajaGrupoToolStripMenuItem.Name = "BajaGrupoToolStripMenuItem"
        Me.BajaGrupoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BajaGrupoToolStripMenuItem.Text = "Baja Grupo"
        '
        'BajaInstitutoToolStripMenuItem
        '
        Me.BajaInstitutoToolStripMenuItem.Name = "BajaInstitutoToolStripMenuItem"
        Me.BajaInstitutoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.BajaInstitutoToolStripMenuItem.Text = "Baja Instituto"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionAsignaturaToolStripMenuItem, Me.ModificacionGrupoToolStripMenuItem, Me.ModificacionInstitutoToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModificacionAsignaturaToolStripMenuItem
        '
        Me.ModificacionAsignaturaToolStripMenuItem.Name = "ModificacionAsignaturaToolStripMenuItem"
        Me.ModificacionAsignaturaToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ModificacionAsignaturaToolStripMenuItem.Text = "Modificacion Asignatura"
        '
        'ModificacionGrupoToolStripMenuItem
        '
        Me.ModificacionGrupoToolStripMenuItem.Name = "ModificacionGrupoToolStripMenuItem"
        Me.ModificacionGrupoToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ModificacionGrupoToolStripMenuItem.Text = "Modificacion Grupo"
        '
        'ModificacionInstitutoToolStripMenuItem
        '
        Me.ModificacionInstitutoToolStripMenuItem.Name = "ModificacionInstitutoToolStripMenuItem"
        Me.ModificacionInstitutoToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ModificacionInstitutoToolStripMenuItem.Text = "Modificacion Instituto"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'ListadoAsignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 351)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Ordenar)
        Me.Controls.Add(Me.cmblistado)
        Me.Controls.Add(Me.DGVListado)
        Me.Controls.Add(Me.btnmenuprincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListadoAsignatura"
        Me.Text = "Listado Asignatura"
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ordenar.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmblistado As System.Windows.Forms.ComboBox
    Friend WithEvents DGVListado As System.Windows.Forms.DataGridView
    Friend WithEvents btnmenuprincipal As System.Windows.Forms.Button
    Friend WithEvents Ordenar As System.Windows.Forms.GroupBox
    Friend WithEvents btnAscendente As System.Windows.Forms.Button
    Friend WithEvents btndescendente As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaAsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaInstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaAsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaInstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionAsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionInstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
