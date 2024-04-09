<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModDirector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModDirector))
        Me.btnconfirmar2 = New System.Windows.Forms.Button
        Me.txtitemdireccion = New System.Windows.Forms.TextBox
        Me.txtitemamaterno = New System.Windows.Forms.TextBox
        Me.txtitemapaterno = New System.Windows.Forms.TextBox
        Me.txtitemnombre2 = New System.Windows.Forms.TextBox
        Me.txtitemnombre = New System.Windows.Forms.TextBox
        Me.CheckBoxdireccion = New System.Windows.Forms.CheckBox
        Me.CheckBoxamaterno = New System.Windows.Forms.CheckBox
        Me.CheckBoxapaterno = New System.Windows.Forms.CheckBox
        Me.CheckBoxnombre2 = New System.Windows.Forms.CheckBox
        Me.CheckBoxnombre1 = New System.Windows.Forms.CheckBox
        Me.lblitem = New System.Windows.Forms.Label
        Me.lbllinea = New System.Windows.Forms.Label
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.txtamaterno = New System.Windows.Forms.TextBox
        Me.txtapaterno = New System.Windows.Forms.TextBox
        Me.txtnombre2 = New System.Windows.Forms.TextBox
        Me.txtnombre1 = New System.Windows.Forms.TextBox
        Me.lbldireccion = New System.Windows.Forms.Label
        Me.lblamaterno = New System.Windows.Forms.Label
        Me.lblapaterno = New System.Windows.Forms.Label
        Me.lblnombre2 = New System.Windows.Forms.Label
        Me.lblnombre1 = New System.Windows.Forms.Label
        Me.btnmodificarlinea = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.txtci = New System.Windows.Forms.TextBox
        Me.lblci = New System.Windows.Forms.Label
        Me.btnmenuprincipal = New System.Windows.Forms.Button
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnconfirmar2
        '
        Me.btnconfirmar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar2.Location = New System.Drawing.Point(490, 234)
        Me.btnconfirmar2.Name = "btnconfirmar2"
        Me.btnconfirmar2.Size = New System.Drawing.Size(130, 23)
        Me.btnconfirmar2.TabIndex = 124
        Me.btnconfirmar2.Text = "Confirmar modificacion"
        Me.btnconfirmar2.UseVisualStyleBackColor = True
        Me.btnconfirmar2.Visible = False
        '
        'txtitemdireccion
        '
        Me.txtitemdireccion.Location = New System.Drawing.Point(490, 193)
        Me.txtitemdireccion.Name = "txtitemdireccion"
        Me.txtitemdireccion.Size = New System.Drawing.Size(130, 20)
        Me.txtitemdireccion.TabIndex = 123
        Me.txtitemdireccion.Visible = False
        '
        'txtitemamaterno
        '
        Me.txtitemamaterno.Location = New System.Drawing.Point(490, 167)
        Me.txtitemamaterno.Name = "txtitemamaterno"
        Me.txtitemamaterno.Size = New System.Drawing.Size(130, 20)
        Me.txtitemamaterno.TabIndex = 122
        Me.txtitemamaterno.Visible = False
        '
        'txtitemapaterno
        '
        Me.txtitemapaterno.Location = New System.Drawing.Point(490, 136)
        Me.txtitemapaterno.Name = "txtitemapaterno"
        Me.txtitemapaterno.Size = New System.Drawing.Size(130, 20)
        Me.txtitemapaterno.TabIndex = 121
        Me.txtitemapaterno.Visible = False
        '
        'txtitemnombre2
        '
        Me.txtitemnombre2.Location = New System.Drawing.Point(490, 107)
        Me.txtitemnombre2.Name = "txtitemnombre2"
        Me.txtitemnombre2.Size = New System.Drawing.Size(130, 20)
        Me.txtitemnombre2.TabIndex = 120
        Me.txtitemnombre2.Visible = False
        '
        'txtitemnombre
        '
        Me.txtitemnombre.Location = New System.Drawing.Point(490, 79)
        Me.txtitemnombre.Name = "txtitemnombre"
        Me.txtitemnombre.Size = New System.Drawing.Size(130, 20)
        Me.txtitemnombre.TabIndex = 119
        Me.txtitemnombre.Visible = False
        '
        'CheckBoxdireccion
        '
        Me.CheckBoxdireccion.AutoSize = True
        Me.CheckBoxdireccion.Location = New System.Drawing.Point(378, 195)
        Me.CheckBoxdireccion.Name = "CheckBoxdireccion"
        Me.CheckBoxdireccion.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxdireccion.TabIndex = 118
        Me.CheckBoxdireccion.Text = "Direccion:"
        Me.CheckBoxdireccion.UseVisualStyleBackColor = True
        Me.CheckBoxdireccion.Visible = False
        '
        'CheckBoxamaterno
        '
        Me.CheckBoxamaterno.AutoSize = True
        Me.CheckBoxamaterno.Location = New System.Drawing.Point(378, 169)
        Me.CheckBoxamaterno.Name = "CheckBoxamaterno"
        Me.CheckBoxamaterno.Size = New System.Drawing.Size(108, 17)
        Me.CheckBoxamaterno.TabIndex = 117
        Me.CheckBoxamaterno.Text = "Apellido Materno:"
        Me.CheckBoxamaterno.UseVisualStyleBackColor = True
        Me.CheckBoxamaterno.Visible = False
        '
        'CheckBoxapaterno
        '
        Me.CheckBoxapaterno.AutoSize = True
        Me.CheckBoxapaterno.Location = New System.Drawing.Point(378, 138)
        Me.CheckBoxapaterno.Name = "CheckBoxapaterno"
        Me.CheckBoxapaterno.Size = New System.Drawing.Size(106, 17)
        Me.CheckBoxapaterno.TabIndex = 116
        Me.CheckBoxapaterno.Text = "Apellido Paterno:"
        Me.CheckBoxapaterno.UseVisualStyleBackColor = True
        Me.CheckBoxapaterno.Visible = False
        '
        'CheckBoxnombre2
        '
        Me.CheckBoxnombre2.AutoSize = True
        Me.CheckBoxnombre2.Location = New System.Drawing.Point(378, 110)
        Me.CheckBoxnombre2.Name = "CheckBoxnombre2"
        Me.CheckBoxnombre2.Size = New System.Drawing.Size(112, 17)
        Me.CheckBoxnombre2.TabIndex = 115
        Me.CheckBoxnombre2.Text = "Segundo Nombre:"
        Me.CheckBoxnombre2.UseVisualStyleBackColor = True
        Me.CheckBoxnombre2.Visible = False
        '
        'CheckBoxnombre1
        '
        Me.CheckBoxnombre1.AutoSize = True
        Me.CheckBoxnombre1.Location = New System.Drawing.Point(378, 81)
        Me.CheckBoxnombre1.Name = "CheckBoxnombre1"
        Me.CheckBoxnombre1.Size = New System.Drawing.Size(96, 17)
        Me.CheckBoxnombre1.TabIndex = 114
        Me.CheckBoxnombre1.Text = "Primer nombre:"
        Me.CheckBoxnombre1.UseVisualStyleBackColor = True
        Me.CheckBoxnombre1.Visible = False
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Location = New System.Drawing.Point(375, 50)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(122, 13)
        Me.lblitem.TabIndex = 113
        Me.lblitem.Text = "Modificacion de un item:"
        Me.lblitem.Visible = False
        '
        'lbllinea
        '
        Me.lbllinea.AutoSize = True
        Me.lbllinea.Location = New System.Drawing.Point(651, 52)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(110, 13)
        Me.lbllinea.TabIndex = 112
        Me.lbllinea.Text = "Modificacion de linea:"
        Me.lbllinea.Visible = False
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.Location = New System.Drawing.Point(755, 234)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(134, 23)
        Me.btnconfirmar.TabIndex = 111
        Me.btnconfirmar.Text = "Confirmar modificacion"
        Me.btnconfirmar.UseVisualStyleBackColor = True
        Me.btnconfirmar.Visible = False
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(755, 195)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(134, 20)
        Me.txtdireccion.TabIndex = 110
        Me.txtdireccion.Visible = False
        '
        'txtamaterno
        '
        Me.txtamaterno.Location = New System.Drawing.Point(755, 169)
        Me.txtamaterno.Name = "txtamaterno"
        Me.txtamaterno.Size = New System.Drawing.Size(134, 20)
        Me.txtamaterno.TabIndex = 109
        Me.txtamaterno.Visible = False
        '
        'txtapaterno
        '
        Me.txtapaterno.Location = New System.Drawing.Point(755, 138)
        Me.txtapaterno.Name = "txtapaterno"
        Me.txtapaterno.Size = New System.Drawing.Size(134, 20)
        Me.txtapaterno.TabIndex = 108
        Me.txtapaterno.Visible = False
        '
        'txtnombre2
        '
        Me.txtnombre2.Location = New System.Drawing.Point(755, 109)
        Me.txtnombre2.Name = "txtnombre2"
        Me.txtnombre2.Size = New System.Drawing.Size(134, 20)
        Me.txtnombre2.TabIndex = 107
        Me.txtnombre2.Visible = False
        '
        'txtnombre1
        '
        Me.txtnombre1.Location = New System.Drawing.Point(755, 79)
        Me.txtnombre1.Name = "txtnombre1"
        Me.txtnombre1.Size = New System.Drawing.Size(134, 20)
        Me.txtnombre1.TabIndex = 106
        Me.txtnombre1.Visible = False
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(651, 198)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(55, 13)
        Me.lbldireccion.TabIndex = 105
        Me.lbldireccion.Text = "Direccion:"
        Me.lbldireccion.Visible = False
        '
        'lblamaterno
        '
        Me.lblamaterno.AutoSize = True
        Me.lblamaterno.Location = New System.Drawing.Point(651, 172)
        Me.lblamaterno.Name = "lblamaterno"
        Me.lblamaterno.Size = New System.Drawing.Size(89, 13)
        Me.lblamaterno.TabIndex = 104
        Me.lblamaterno.Text = "Apellido Materno:"
        Me.lblamaterno.Visible = False
        '
        'lblapaterno
        '
        Me.lblapaterno.AutoSize = True
        Me.lblapaterno.Location = New System.Drawing.Point(653, 139)
        Me.lblapaterno.Name = "lblapaterno"
        Me.lblapaterno.Size = New System.Drawing.Size(87, 13)
        Me.lblapaterno.TabIndex = 103
        Me.lblapaterno.Text = "Apellido Paterno:"
        Me.lblapaterno.Visible = False
        '
        'lblnombre2
        '
        Me.lblnombre2.AutoSize = True
        Me.lblnombre2.Location = New System.Drawing.Point(651, 110)
        Me.lblnombre2.Name = "lblnombre2"
        Me.lblnombre2.Size = New System.Drawing.Size(91, 13)
        Me.lblnombre2.TabIndex = 102
        Me.lblnombre2.Text = "Segundo nombre:"
        Me.lblnombre2.Visible = False
        '
        'lblnombre1
        '
        Me.lblnombre1.AutoSize = True
        Me.lblnombre1.Location = New System.Drawing.Point(651, 81)
        Me.lblnombre1.Name = "lblnombre1"
        Me.lblnombre1.Size = New System.Drawing.Size(77, 13)
        Me.lblnombre1.TabIndex = 101
        Me.lblnombre1.Text = "Primer nombre:"
        Me.lblnombre1.Visible = False
        '
        'btnmodificarlinea
        '
        Me.btnmodificarlinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificarlinea.Location = New System.Drawing.Point(220, 234)
        Me.btnmodificarlinea.Name = "btnmodificarlinea"
        Me.btnmodificarlinea.Size = New System.Drawing.Size(87, 23)
        Me.btnmodificarlinea.TabIndex = 100
        Me.btnmodificarlinea.Text = "Modificar linea"
        Me.btnmodificarlinea.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.Location = New System.Drawing.Point(115, 234)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(99, 23)
        Me.btnmodificar.TabIndex = 99
        Me.btnmodificar.Text = "Modificar un item"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(114, 90)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(136, 20)
        Me.txtci.TabIndex = 98
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(34, 93)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(58, 13)
        Me.lblci.TabIndex = 97
        Me.lblci.Text = "Ingrese CI:"
        '
        'btnmenuprincipal
        '
        Me.btnmenuprincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenuprincipal.Location = New System.Drawing.Point(4, 234)
        Me.btnmenuprincipal.Name = "btnmenuprincipal"
        Me.btnmenuprincipal.Size = New System.Drawing.Size(105, 23)
        Me.btnmenuprincipal.TabIndex = 96
        Me.btnmenuprincipal.Text = "Menu Principal"
        Me.btnmenuprincipal.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ListadosToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(916, 24)
        Me.MenuStrip2.TabIndex = 125
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDirectorToolStripMenuItem, Me.AltaAlumnoToolStripMenuItem, Me.AltaDocenteToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaDirectorToolStripMenuItem
        '
        Me.AltaDirectorToolStripMenuItem.Name = "AltaDirectorToolStripMenuItem"
        Me.AltaDirectorToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AltaDirectorToolStripMenuItem.Text = "Alta Director"
        '
        'AltaAlumnoToolStripMenuItem
        '
        Me.AltaAlumnoToolStripMenuItem.Name = "AltaAlumnoToolStripMenuItem"
        Me.AltaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AltaAlumnoToolStripMenuItem.Text = "Alta Alumno"
        '
        'AltaDocenteToolStripMenuItem
        '
        Me.AltaDocenteToolStripMenuItem.Name = "AltaDocenteToolStripMenuItem"
        Me.AltaDocenteToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AltaDocenteToolStripMenuItem.Text = "Alta Docente"
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
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionAlumnoToolStripMenuItem, Me.ModificacionDocenteToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModificacionAlumnoToolStripMenuItem
        '
        Me.ModificacionAlumnoToolStripMenuItem.Name = "ModificacionAlumnoToolStripMenuItem"
        Me.ModificacionAlumnoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ModificacionAlumnoToolStripMenuItem.Text = "Modificacion Alumno"
        '
        'ModificacionDocenteToolStripMenuItem
        '
        Me.ModificacionDocenteToolStripMenuItem.Name = "ModificacionDocenteToolStripMenuItem"
        Me.ModificacionDocenteToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ModificacionDocenteToolStripMenuItem.Text = "Modificacion Docente"
        '
        'ModDirector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 269)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.btnconfirmar2)
        Me.Controls.Add(Me.txtitemdireccion)
        Me.Controls.Add(Me.txtitemamaterno)
        Me.Controls.Add(Me.txtitemapaterno)
        Me.Controls.Add(Me.txtitemnombre2)
        Me.Controls.Add(Me.txtitemnombre)
        Me.Controls.Add(Me.CheckBoxdireccion)
        Me.Controls.Add(Me.CheckBoxamaterno)
        Me.Controls.Add(Me.CheckBoxapaterno)
        Me.Controls.Add(Me.CheckBoxnombre2)
        Me.Controls.Add(Me.CheckBoxnombre1)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.lbllinea)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtamaterno)
        Me.Controls.Add(Me.txtapaterno)
        Me.Controls.Add(Me.txtnombre2)
        Me.Controls.Add(Me.txtnombre1)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblamaterno)
        Me.Controls.Add(Me.lblapaterno)
        Me.Controls.Add(Me.lblnombre2)
        Me.Controls.Add(Me.lblnombre1)
        Me.Controls.Add(Me.btnmodificarlinea)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.lblci)
        Me.Controls.Add(Me.btnmenuprincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModDirector"
        Me.Text = "Modificacion Director"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconfirmar2 As System.Windows.Forms.Button
    Friend WithEvents txtitemdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtitemamaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtitemapaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtitemnombre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtitemnombre As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxdireccion As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxamaterno As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxapaterno As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxnombre2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxnombre1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lbllinea As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
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
    Friend WithEvents btnmodificarlinea As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents txtci As System.Windows.Forms.TextBox
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents btnmenuprincipal As System.Windows.Forms.Button
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
    Friend WithEvents ListadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
