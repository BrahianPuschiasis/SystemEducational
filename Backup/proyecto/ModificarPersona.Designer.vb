<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModDocente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModDocente))
        Me.lblci = New System.Windows.Forms.Label
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
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.lbllinea = New System.Windows.Forms.Label
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaDeExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.txtci = New System.Windows.Forms.MaskedTextBox
        Me.btnmodificarlinea = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblci
        '
        Me.lblci.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(20, 203)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(58, 13)
        Me.lblci.TabIndex = 64
        Me.lblci.Text = "Ingrese CI:"
        '
        'txtdireccion
        '
        Me.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdireccion.Location = New System.Drawing.Point(448, 228)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(128, 20)
        Me.txtdireccion.TabIndex = 79
        '
        'txtamaterno
        '
        Me.txtamaterno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtamaterno.Location = New System.Drawing.Point(724, 196)
        Me.txtamaterno.Name = "txtamaterno"
        Me.txtamaterno.Size = New System.Drawing.Size(128, 20)
        Me.txtamaterno.TabIndex = 78
        '
        'txtapaterno
        '
        Me.txtapaterno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtapaterno.Location = New System.Drawing.Point(449, 196)
        Me.txtapaterno.Name = "txtapaterno"
        Me.txtapaterno.Size = New System.Drawing.Size(128, 20)
        Me.txtapaterno.TabIndex = 77
        '
        'txtnombre2
        '
        Me.txtnombre2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnombre2.Location = New System.Drawing.Point(724, 166)
        Me.txtnombre2.Name = "txtnombre2"
        Me.txtnombre2.Size = New System.Drawing.Size(128, 20)
        Me.txtnombre2.TabIndex = 76
        '
        'txtnombre1
        '
        Me.txtnombre1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnombre1.Location = New System.Drawing.Point(449, 166)
        Me.txtnombre1.Name = "txtnombre1"
        Me.txtnombre1.Size = New System.Drawing.Size(128, 20)
        Me.txtnombre1.TabIndex = 75
        '
        'lbldireccion
        '
        Me.lbldireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(331, 231)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(55, 13)
        Me.lbldireccion.TabIndex = 73
        Me.lbldireccion.Text = "Direccion:"
        '
        'lblamaterno
        '
        Me.lblamaterno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblamaterno.AutoSize = True
        Me.lblamaterno.Location = New System.Drawing.Point(607, 199)
        Me.lblamaterno.Name = "lblamaterno"
        Me.lblamaterno.Size = New System.Drawing.Size(89, 13)
        Me.lblamaterno.TabIndex = 72
        Me.lblamaterno.Text = "Apellido Materno:"
        '
        'lblapaterno
        '
        Me.lblapaterno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblapaterno.AutoSize = True
        Me.lblapaterno.Location = New System.Drawing.Point(331, 199)
        Me.lblapaterno.Name = "lblapaterno"
        Me.lblapaterno.Size = New System.Drawing.Size(87, 13)
        Me.lblapaterno.TabIndex = 71
        Me.lblapaterno.Text = "Apellido Paterno:"
        '
        'lblnombre2
        '
        Me.lblnombre2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnombre2.AutoSize = True
        Me.lblnombre2.Location = New System.Drawing.Point(607, 169)
        Me.lblnombre2.Name = "lblnombre2"
        Me.lblnombre2.Size = New System.Drawing.Size(91, 13)
        Me.lblnombre2.TabIndex = 70
        Me.lblnombre2.Text = "Segundo nombre:"
        '
        'lblnombre1
        '
        Me.lblnombre1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnombre1.AutoSize = True
        Me.lblnombre1.Location = New System.Drawing.Point(331, 169)
        Me.lblnombre1.Name = "lblnombre1"
        Me.lblnombre1.Size = New System.Drawing.Size(77, 13)
        Me.lblnombre1.TabIndex = 69
        Me.lblnombre1.Text = "Primer nombre:"
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(458, 343)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(128, 60)
        Me.btnconfirmar.TabIndex = 81
        Me.btnconfirmar.UseVisualStyleBackColor = True
        Me.btnconfirmar.Visible = False
        '
        'lbllinea
        '
        Me.lbllinea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbllinea.AutoSize = True
        Me.lbllinea.Location = New System.Drawing.Point(303, 139)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(110, 13)
        Me.lbllinea.TabIndex = 82
        Me.lbllinea.Text = "Modificacion de linea:"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirectorToolStripMenuItem, Me.AlumnosToolStripMenuItem, Me.DocenteToolStripMenuItem})
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PersonasToolStripMenuItem.Text = "Personas"
        '
        'DirectorToolStripMenuItem
        '
        Me.DirectorToolStripMenuItem.Name = "DirectorToolStripMenuItem"
        Me.DirectorToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DirectorToolStripMenuItem.Text = "Director"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AlumnosToolStripMenuItem.Text = "Alumnos"
        '
        'DocenteToolStripMenuItem
        '
        Me.DocenteToolStripMenuItem.Name = "DocenteToolStripMenuItem"
        Me.DocenteToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.DocenteToolStripMenuItem.Text = "Docente"
        '
        'AsignaturaToolStripMenuItem
        '
        Me.AsignaturaToolStripMenuItem.Name = "AsignaturaToolStripMenuItem"
        Me.AsignaturaToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.AsignaturaToolStripMenuItem.Text = "Asignatura"
        '
        'GrupoToolStripMenuItem
        '
        Me.GrupoToolStripMenuItem.Name = "GrupoToolStripMenuItem"
        Me.GrupoToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.GrupoToolStripMenuItem.Text = "Grupo"
        '
        'ActaToolStripMenuItem
        '
        Me.ActaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActaDeExamenToolStripMenuItem, Me.ActaFinalToolStripMenuItem})
        Me.ActaToolStripMenuItem.Name = "ActaToolStripMenuItem"
        Me.ActaToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ActaToolStripMenuItem.Text = "Acta"
        '
        'ActaDeExamenToolStripMenuItem
        '
        Me.ActaDeExamenToolStripMenuItem.Name = "ActaDeExamenToolStripMenuItem"
        Me.ActaDeExamenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ActaDeExamenToolStripMenuItem.Text = "Acta de Examen"
        '
        'ActaFinalToolStripMenuItem
        '
        Me.ActaFinalToolStripMenuItem.Name = "ActaFinalToolStripMenuItem"
        Me.ActaFinalToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ActaFinalToolStripMenuItem.Text = "Acta Final"
        '
        'InstitutoToolStripMenuItem
        '
        Me.InstitutoToolStripMenuItem.Name = "InstitutoToolStripMenuItem"
        Me.InstitutoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.InstitutoToolStripMenuItem.Text = "Instituto"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonasToolStripMenuItem, Me.AsignaturaToolStripMenuItem, Me.GrupoToolStripMenuItem, Me.ActaToolStripMenuItem, Me.InstitutoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 24)
        Me.MenuStrip1.TabIndex = 62
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(248, 29)
        Me.MenuStrip2.TabIndex = 95
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDirectorToolStripMenuItem, Me.AltaAlumnoToolStripMenuItem, Me.AltaDocenteToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 25)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaDirectorToolStripMenuItem
        '
        Me.AltaDirectorToolStripMenuItem.Name = "AltaDirectorToolStripMenuItem"
        Me.AltaDirectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaDirectorToolStripMenuItem.Text = "Administrativo"
        '
        'AltaAlumnoToolStripMenuItem
        '
        Me.AltaAlumnoToolStripMenuItem.Name = "AltaAlumnoToolStripMenuItem"
        Me.AltaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaAlumnoToolStripMenuItem.Text = "Alumno"
        '
        'AltaDocenteToolStripMenuItem
        '
        Me.AltaDocenteToolStripMenuItem.Name = "AltaDocenteToolStripMenuItem"
        Me.AltaDocenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AltaDocenteToolStripMenuItem.Text = "Docente"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaDirectorToolStripMenuItem, Me.BajaDocenteToolStripMenuItem, Me.BajaAlumnoToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 25)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaDirectorToolStripMenuItem
        '
        Me.BajaDirectorToolStripMenuItem.Name = "BajaDirectorToolStripMenuItem"
        Me.BajaDirectorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaDirectorToolStripMenuItem.Text = "Administrativo"
        '
        'BajaDocenteToolStripMenuItem
        '
        Me.BajaDocenteToolStripMenuItem.Name = "BajaDocenteToolStripMenuItem"
        Me.BajaDocenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaDocenteToolStripMenuItem.Text = " Docente"
        '
        'BajaAlumnoToolStripMenuItem
        '
        Me.BajaAlumnoToolStripMenuItem.Name = "BajaAlumnoToolStripMenuItem"
        Me.BajaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaAlumnoToolStripMenuItem.Text = " Alumno"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 48)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 278
        Me.Label2.Text = "Modificacion Docente"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 277
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(785, 57)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 276
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(785, 35)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 275
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(736, 57)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 274
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(736, 35)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 273
        Me.lblhora1.Text = "Hora:"
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(115, 200)
        Me.txtci.Mask = "0.000.000-0"
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(73, 20)
        Me.txtci.TabIndex = 279
        Me.txtci.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btnmodificarlinea
        '
        Me.btnmodificarlinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodificarlinea.FlatAppearance.BorderSize = 0
        Me.btnmodificarlinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarlinea.Image = CType(resources.GetObject("btnmodificarlinea.Image"), System.Drawing.Image)
        Me.btnmodificarlinea.Location = New System.Drawing.Point(101, 245)
        Me.btnmodificarlinea.Name = "btnmodificarlinea"
        Me.btnmodificarlinea.Size = New System.Drawing.Size(87, 67)
        Me.btnmodificarlinea.TabIndex = 280
        Me.btnmodificarlinea.UseVisualStyleBackColor = True
        '
        'ModDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(857, 439)
        Me.Controls.Add(Me.btnmodificarlinea)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Controls.Add(Me.lblci)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModDocente"
        Me.Text = "Modificacion Docente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblci As System.Windows.Forms.Label
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
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents lbllinea As System.Windows.Forms.Label
    Friend WithEvents PersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaDeExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaDocenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents txtci As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnmodificarlinea As System.Windows.Forms.Button
End Class
