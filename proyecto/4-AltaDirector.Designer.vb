<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaDirector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaDirector))
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.txtamaterno = New System.Windows.Forms.TextBox
        Me.txtapaterno = New System.Windows.Forms.TextBox
        Me.txtnombre2 = New System.Windows.Forms.TextBox
        Me.txtnombre1 = New System.Windows.Forms.TextBox
        Me.txtci = New System.Windows.Forms.TextBox
        Me.lbldireccion = New System.Windows.Forms.Label
        Me.lblamaterno = New System.Windows.Forms.Label
        Me.lblapaterno = New System.Windows.Forms.Label
        Me.lblnombre2 = New System.Windows.Forms.Label
        Me.lblnombre1 = New System.Windows.Forms.Label
        Me.lblci = New System.Windows.Forms.Label
        Me.btnmenuprincipal = New System.Windows.Forms.Button
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(148, 240)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(157, 20)
        Me.txtdireccion.TabIndex = 28
        '
        'txtamaterno
        '
        Me.txtamaterno.Location = New System.Drawing.Point(148, 205)
        Me.txtamaterno.Name = "txtamaterno"
        Me.txtamaterno.Size = New System.Drawing.Size(156, 20)
        Me.txtamaterno.TabIndex = 27
        '
        'txtapaterno
        '
        Me.txtapaterno.Location = New System.Drawing.Point(148, 167)
        Me.txtapaterno.Name = "txtapaterno"
        Me.txtapaterno.Size = New System.Drawing.Size(157, 20)
        Me.txtapaterno.TabIndex = 26
        '
        'txtnombre2
        '
        Me.txtnombre2.Location = New System.Drawing.Point(148, 127)
        Me.txtnombre2.Name = "txtnombre2"
        Me.txtnombre2.Size = New System.Drawing.Size(157, 20)
        Me.txtnombre2.TabIndex = 25
        '
        'txtnombre1
        '
        Me.txtnombre1.Location = New System.Drawing.Point(148, 87)
        Me.txtnombre1.Name = "txtnombre1"
        Me.txtnombre1.Size = New System.Drawing.Size(157, 20)
        Me.txtnombre1.TabIndex = 24
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(148, 51)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(156, 20)
        Me.txtci.TabIndex = 22
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(41, 243)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(55, 13)
        Me.lbldireccion.TabIndex = 21
        Me.lbldireccion.Text = "Direccion:"
        '
        'lblamaterno
        '
        Me.lblamaterno.AutoSize = True
        Me.lblamaterno.Location = New System.Drawing.Point(41, 208)
        Me.lblamaterno.Name = "lblamaterno"
        Me.lblamaterno.Size = New System.Drawing.Size(86, 13)
        Me.lblamaterno.TabIndex = 20
        Me.lblamaterno.Text = "Apellido Materno"
        '
        'lblapaterno
        '
        Me.lblapaterno.AutoSize = True
        Me.lblapaterno.Location = New System.Drawing.Point(41, 170)
        Me.lblapaterno.Name = "lblapaterno"
        Me.lblapaterno.Size = New System.Drawing.Size(87, 13)
        Me.lblapaterno.TabIndex = 19
        Me.lblapaterno.Text = "Apellido Paterno:"
        '
        'lblnombre2
        '
        Me.lblnombre2.AutoSize = True
        Me.lblnombre2.Location = New System.Drawing.Point(41, 130)
        Me.lblnombre2.Name = "lblnombre2"
        Me.lblnombre2.Size = New System.Drawing.Size(91, 13)
        Me.lblnombre2.TabIndex = 18
        Me.lblnombre2.Text = "Segundo nombre:"
        '
        'lblnombre1
        '
        Me.lblnombre1.AutoSize = True
        Me.lblnombre1.Location = New System.Drawing.Point(41, 90)
        Me.lblnombre1.Name = "lblnombre1"
        Me.lblnombre1.Size = New System.Drawing.Size(77, 13)
        Me.lblnombre1.TabIndex = 17
        Me.lblnombre1.Text = "Primer nombre:"
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(41, 54)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(23, 13)
        Me.lblci.TabIndex = 15
        Me.lblci.Text = "C.I:"
        '
        'btnmenuprincipal
        '
        Me.btnmenuprincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmenuprincipal.Location = New System.Drawing.Point(12, 319)
        Me.btnmenuprincipal.Name = "btnmenuprincipal"
        Me.btnmenuprincipal.Size = New System.Drawing.Size(105, 23)
        Me.btnmenuprincipal.TabIndex = 30
        Me.btnmenuprincipal.Text = "Menu Principal"
        Me.btnmenuprincipal.UseVisualStyleBackColor = True
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.Location = New System.Drawing.Point(279, 319)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnconfirmar.TabIndex = 35
        Me.btnconfirmar.Text = "Confirmar"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ListadosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(366, 24)
        Me.MenuStrip1.TabIndex = 96
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDocenteToolStripMenuItem, Me.AltaAlumnoToolStripMenuItem})
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
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaDirectorToolStripMenuItem, Me.BajaDocenteToolStripMenuItem, Me.BajaAlumnoToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaDirectorToolStripMenuItem
        '
        Me.BajaDirectorToolStripMenuItem.Name = "BajaDirectorToolStripMenuItem"
        Me.BajaDirectorToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.BajaDirectorToolStripMenuItem.Text = "Baja Director"
        '
        'BajaDocenteToolStripMenuItem
        '
        Me.BajaDocenteToolStripMenuItem.Name = "BajaDocenteToolStripMenuItem"
        Me.BajaDocenteToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.BajaDocenteToolStripMenuItem.Text = "Baja Docente"
        '
        'BajaAlumnoToolStripMenuItem
        '
        Me.BajaAlumnoToolStripMenuItem.Name = "BajaAlumnoToolStripMenuItem"
        Me.BajaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.BajaAlumnoToolStripMenuItem.Text = "Baja Alumno"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionDirectorToolStripMenuItem, Me.ModificacionDocenteToolStripMenuItem, Me.ModificacionAlumnoToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModificacionDirectorToolStripMenuItem
        '
        Me.ModificacionDirectorToolStripMenuItem.Name = "ModificacionDirectorToolStripMenuItem"
        Me.ModificacionDirectorToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ModificacionDirectorToolStripMenuItem.Text = "Modificacion Director"
        '
        'ModificacionDocenteToolStripMenuItem
        '
        Me.ModificacionDocenteToolStripMenuItem.Name = "ModificacionDocenteToolStripMenuItem"
        Me.ModificacionDocenteToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ModificacionDocenteToolStripMenuItem.Text = "Modificacion Docente"
        '
        'ModificacionAlumnoToolStripMenuItem
        '
        Me.ModificacionAlumnoToolStripMenuItem.Name = "ModificacionAlumnoToolStripMenuItem"
        Me.ModificacionAlumnoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ModificacionAlumnoToolStripMenuItem.Text = "Modificacion Alumno"
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
        'AltaDirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 354)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.btnmenuprincipal)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtamaterno)
        Me.Controls.Add(Me.txtapaterno)
        Me.Controls.Add(Me.txtnombre2)
        Me.Controls.Add(Me.txtnombre1)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblamaterno)
        Me.Controls.Add(Me.lblapaterno)
        Me.Controls.Add(Me.lblnombre2)
        Me.Controls.Add(Me.lblnombre1)
        Me.Controls.Add(Me.lblci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaDirector"
        Me.Text = "Alta Director"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtamaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtapaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre1 As System.Windows.Forms.TextBox
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents lblamaterno As System.Windows.Forms.Label
    Friend WithEvents lblapaterno As System.Windows.Forms.Label
    Friend WithEvents lblnombre2 As System.Windows.Forms.Label
    Friend WithEvents lblnombre1 As System.Windows.Forms.Label
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents btnmenuprincipal As System.Windows.Forms.Button
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
