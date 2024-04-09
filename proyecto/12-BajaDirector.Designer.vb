<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BajaDirector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BajaDirector))
        Me.btnmenuprincipal = New System.Windows.Forms.Button
        Me.btnborrar = New System.Windows.Forms.Button
        Me.txtcibaja = New System.Windows.Forms.TextBox
        Me.lblci = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifacoinDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnmenuprincipal
        '
        Me.btnmenuprincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmenuprincipal.Location = New System.Drawing.Point(12, 243)
        Me.btnmenuprincipal.Name = "btnmenuprincipal"
        Me.btnmenuprincipal.Size = New System.Drawing.Size(105, 23)
        Me.btnmenuprincipal.TabIndex = 32
        Me.btnmenuprincipal.Text = "Menu Principal"
        Me.btnmenuprincipal.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnborrar.Location = New System.Drawing.Point(228, 243)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 23)
        Me.btnborrar.TabIndex = 33
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'txtcibaja
        '
        Me.txtcibaja.Location = New System.Drawing.Point(97, 70)
        Me.txtcibaja.Name = "txtcibaja"
        Me.txtcibaja.Size = New System.Drawing.Size(174, 20)
        Me.txtcibaja.TabIndex = 35
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(12, 73)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(58, 13)
        Me.lblci.TabIndex = 34
        Me.lblci.Text = "Ingrese CI:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ListadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(315, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDocenteToolStripMenuItem, Me.AltaAlumnoToolStripMenuItem, Me.AltaDirectorToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaDocenteToolStripMenuItem
        '
        Me.AltaDocenteToolStripMenuItem.Name = "AltaDocenteToolStripMenuItem"
        Me.AltaDocenteToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AltaDocenteToolStripMenuItem.Text = "Alta Docente"
        '
        'AltaAlumnoToolStripMenuItem
        '
        Me.AltaAlumnoToolStripMenuItem.Name = "AltaAlumnoToolStripMenuItem"
        Me.AltaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AltaAlumnoToolStripMenuItem.Text = "Alta Alumno"
        '
        'AltaDirectorToolStripMenuItem
        '
        Me.AltaDirectorToolStripMenuItem.Name = "AltaDirectorToolStripMenuItem"
        Me.AltaDirectorToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AltaDirectorToolStripMenuItem.Text = "Alta Director"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaDocenteToolStripMenuItem, Me.BajaAlumnoToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaDocenteToolStripMenuItem
        '
        Me.BajaDocenteToolStripMenuItem.Name = "BajaDocenteToolStripMenuItem"
        Me.BajaDocenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaDocenteToolStripMenuItem.Text = "Baja Docente"
        '
        'BajaAlumnoToolStripMenuItem
        '
        Me.BajaAlumnoToolStripMenuItem.Name = "BajaAlumnoToolStripMenuItem"
        Me.BajaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaAlumnoToolStripMenuItem.Text = "Baja Alumno"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifacoinDocenteToolStripMenuItem, Me.ModificacionAlumnoToolStripMenuItem, Me.ModificacionDirectorToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModifacoinDocenteToolStripMenuItem
        '
        Me.ModifacoinDocenteToolStripMenuItem.Name = "ModifacoinDocenteToolStripMenuItem"
        Me.ModifacoinDocenteToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ModifacoinDocenteToolStripMenuItem.Text = "Modifacoin Docente"
        '
        'ModificacionAlumnoToolStripMenuItem
        '
        Me.ModificacionAlumnoToolStripMenuItem.Name = "ModificacionAlumnoToolStripMenuItem"
        Me.ModificacionAlumnoToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ModificacionAlumnoToolStripMenuItem.Text = "Modificacion Alumno"
        '
        'ModificacionDirectorToolStripMenuItem
        '
        Me.ModificacionDirectorToolStripMenuItem.Name = "ModificacionDirectorToolStripMenuItem"
        Me.ModificacionDirectorToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ModificacionDirectorToolStripMenuItem.Text = "Modificacion Director"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ListadosToolStripMenuItem.Text = "&Listados"
        '
        'BajaDirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 278)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtcibaja)
        Me.Controls.Add(Me.lblci)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnmenuprincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BajaDirector"
        Me.Text = "Baja Director"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmenuprincipal As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents txtcibaja As System.Windows.Forms.TextBox
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifacoinDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
