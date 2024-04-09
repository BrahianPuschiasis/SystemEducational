<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoActaExamen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoActaExamen))
        Me.cmblistado = New System.Windows.Forms.ComboBox
        Me.DGVListado = New System.Windows.Forms.DataGridView
        Me.btnmenuprincipal = New System.Windows.Forms.Button
        Me.Ordenar = New System.Windows.Forms.GroupBox
        Me.btnAscendente = New System.Windows.Forms.Button
        Me.btndescendente = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaActaExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaActaExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionActaExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.DGVListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ordenar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmblistado
        '
        Me.cmblistado.FormattingEnabled = True
        Me.cmblistado.Items.AddRange(New Object() {"n_actaE", "año", "fallo", "nota", "idgrupo", "idasig", "examinado", "oral", "escrita", "verifico", "presidente", "secretario", "vocal"})
        Me.cmblistado.Location = New System.Drawing.Point(29, 50)
        Me.cmblistado.Name = "cmblistado"
        Me.cmblistado.Size = New System.Drawing.Size(121, 21)
        Me.cmblistado.TabIndex = 108
        '
        'DGVListado
        '
        Me.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListado.Location = New System.Drawing.Point(218, 40)
        Me.DGVListado.Name = "DGVListado"
        Me.DGVListado.Size = New System.Drawing.Size(237, 150)
        Me.DGVListado.TabIndex = 107
        '
        'btnmenuprincipal
        '
        Me.btnmenuprincipal.Location = New System.Drawing.Point(29, 250)
        Me.btnmenuprincipal.Name = "btnmenuprincipal"
        Me.btnmenuprincipal.Size = New System.Drawing.Size(105, 23)
        Me.btnmenuprincipal.TabIndex = 102
        Me.btnmenuprincipal.Text = "Menu Principal"
        Me.btnmenuprincipal.UseVisualStyleBackColor = True
        '
        'Ordenar
        '
        Me.Ordenar.Controls.Add(Me.btnAscendente)
        Me.Ordenar.Controls.Add(Me.btndescendente)
        Me.Ordenar.Location = New System.Drawing.Point(218, 196)
        Me.Ordenar.Name = "Ordenar"
        Me.Ordenar.Size = New System.Drawing.Size(237, 100)
        Me.Ordenar.TabIndex = 109
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
        Me.MenuStrip1.Size = New System.Drawing.Size(497, 24)
        Me.MenuStrip1.TabIndex = 110
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaActaExamenToolStripMenuItem, Me.AltaActaFinalToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaActaExamenToolStripMenuItem
        '
        Me.AltaActaExamenToolStripMenuItem.Name = "AltaActaExamenToolStripMenuItem"
        Me.AltaActaExamenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AltaActaExamenToolStripMenuItem.Text = "Alta Acta Examen"
        '
        'AltaActaFinalToolStripMenuItem
        '
        Me.AltaActaFinalToolStripMenuItem.Name = "AltaActaFinalToolStripMenuItem"
        Me.AltaActaFinalToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AltaActaFinalToolStripMenuItem.Text = "Alta Acta Final"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaActaExamenToolStripMenuItem, Me.BajaActaFinalToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaActaExamenToolStripMenuItem
        '
        Me.BajaActaExamenToolStripMenuItem.Name = "BajaActaExamenToolStripMenuItem"
        Me.BajaActaExamenToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.BajaActaExamenToolStripMenuItem.Text = "Baja Acta Examen"
        '
        'BajaActaFinalToolStripMenuItem
        '
        Me.BajaActaFinalToolStripMenuItem.Name = "BajaActaFinalToolStripMenuItem"
        Me.BajaActaFinalToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.BajaActaFinalToolStripMenuItem.Text = "Baja Acta Final"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionActaExamenToolStripMenuItem, Me.ModificacionActaFinalToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModificacionActaExamenToolStripMenuItem
        '
        Me.ModificacionActaExamenToolStripMenuItem.Name = "ModificacionActaExamenToolStripMenuItem"
        Me.ModificacionActaExamenToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ModificacionActaExamenToolStripMenuItem.Text = "Modificacion Acta Examen"
        '
        'ModificacionActaFinalToolStripMenuItem
        '
        Me.ModificacionActaFinalToolStripMenuItem.Name = "ModificacionActaFinalToolStripMenuItem"
        Me.ModificacionActaFinalToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ModificacionActaFinalToolStripMenuItem.Text = "Modificacion Acta Final"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'ListadoActaExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 315)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Ordenar)
        Me.Controls.Add(Me.cmblistado)
        Me.Controls.Add(Me.DGVListado)
        Me.Controls.Add(Me.btnmenuprincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListadoActaExamen"
        Me.Text = "Listado Acta de Examen"
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
    Friend WithEvents AltaActaExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaActaExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionActaExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
