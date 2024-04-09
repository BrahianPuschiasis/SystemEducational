<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModInstituto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModInstituto))
        Me.txtnom2 = New System.Windows.Forms.TextBox
        Me.txtnom = New System.Windows.Forms.TextBox
        Me.lblnom = New System.Windows.Forms.Label
        Me.btnconfirmar2 = New System.Windows.Forms.Button
        Me.CheckBoxnom = New System.Windows.Forms.CheckBox
        Me.lblitem = New System.Windows.Forms.Label
        Me.lbllinea = New System.Windows.Forms.Label
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.btnmodificarlinea = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.lblninst = New System.Windows.Forms.Label
        Me.CheckBoxdireccion = New System.Windows.Forms.CheckBox
        Me.txtdir = New System.Windows.Forms.TextBox
        Me.txtdir2 = New System.Windows.Forms.TextBox
        Me.lbldir = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaInstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaAsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaInstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionAsignaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbnominst = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnActivo = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnom2
        '
        Me.txtnom2.Location = New System.Drawing.Point(492, 222)
        Me.txtnom2.Name = "txtnom2"
        Me.txtnom2.Size = New System.Drawing.Size(178, 20)
        Me.txtnom2.TabIndex = 249
        Me.txtnom2.Visible = False
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(492, 118)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(178, 20)
        Me.txtnom.TabIndex = 248
        Me.txtnom.Visible = False
        '
        'lblnom
        '
        Me.lblnom.AutoSize = True
        Me.lblnom.Location = New System.Drawing.Point(409, 228)
        Me.lblnom.Name = "lblnom"
        Me.lblnom.Size = New System.Drawing.Size(47, 13)
        Me.lblnom.TabIndex = 246
        Me.lblnom.Text = "Nombre:"
        Me.lblnom.Visible = False
        '
        'btnconfirmar2
        '
        Me.btnconfirmar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar2.FlatAppearance.BorderSize = 0
        Me.btnconfirmar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar2.Image = CType(resources.GetObject("btnconfirmar2.Image"), System.Drawing.Image)
        Me.btnconfirmar2.Location = New System.Drawing.Point(384, 306)
        Me.btnconfirmar2.Name = "btnconfirmar2"
        Me.btnconfirmar2.Size = New System.Drawing.Size(97, 67)
        Me.btnconfirmar2.TabIndex = 244
        Me.btnconfirmar2.UseVisualStyleBackColor = True
        Me.btnconfirmar2.Visible = False
        '
        'CheckBoxnom
        '
        Me.CheckBoxnom.AutoSize = True
        Me.CheckBoxnom.Location = New System.Drawing.Point(409, 123)
        Me.CheckBoxnom.Name = "CheckBoxnom"
        Me.CheckBoxnom.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxnom.TabIndex = 243
        Me.CheckBoxnom.Text = "Nombre:"
        Me.CheckBoxnom.UseVisualStyleBackColor = True
        Me.CheckBoxnom.Visible = False
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Location = New System.Drawing.Point(377, 90)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(122, 13)
        Me.lblitem.TabIndex = 242
        Me.lblitem.Text = "Modificacion de un item:"
        Me.lblitem.Visible = False
        '
        'lbllinea
        '
        Me.lbllinea.AutoSize = True
        Me.lbllinea.Location = New System.Drawing.Point(377, 197)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(110, 13)
        Me.lbllinea.TabIndex = 241
        Me.lbllinea.Text = "Modificacion de linea:"
        Me.lbllinea.Visible = False
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(476, 306)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(136, 67)
        Me.btnconfirmar.TabIndex = 240
        Me.btnconfirmar.UseVisualStyleBackColor = True
        Me.btnconfirmar.Visible = False
        '
        'btnmodificarlinea
        '
        Me.btnmodificarlinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodificarlinea.FlatAppearance.BorderSize = 0
        Me.btnmodificarlinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarlinea.Image = CType(resources.GetObject("btnmodificarlinea.Image"), System.Drawing.Image)
        Me.btnmodificarlinea.Location = New System.Drawing.Point(218, 306)
        Me.btnmodificarlinea.Name = "btnmodificarlinea"
        Me.btnmodificarlinea.Size = New System.Drawing.Size(97, 67)
        Me.btnmodificarlinea.TabIndex = 239
        Me.btnmodificarlinea.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.Location = New System.Drawing.Point(112, 306)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(100, 67)
        Me.btnmodificar.TabIndex = 238
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'lblninst
        '
        Me.lblninst.AutoSize = True
        Me.lblninst.Location = New System.Drawing.Point(9, 225)
        Me.lblninst.Name = "lblninst"
        Me.lblninst.Size = New System.Drawing.Size(135, 13)
        Me.lblninst.TabIndex = 237
        Me.lblninst.Text = "Elija el nombre del Instituto:"
        '
        'CheckBoxdireccion
        '
        Me.CheckBoxdireccion.AutoSize = True
        Me.CheckBoxdireccion.Location = New System.Drawing.Point(409, 147)
        Me.CheckBoxdireccion.Name = "CheckBoxdireccion"
        Me.CheckBoxdireccion.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxdireccion.TabIndex = 250
        Me.CheckBoxdireccion.Text = "Direccion:"
        Me.CheckBoxdireccion.UseVisualStyleBackColor = True
        Me.CheckBoxdireccion.Visible = False
        '
        'txtdir
        '
        Me.txtdir.Location = New System.Drawing.Point(492, 144)
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(178, 20)
        Me.txtdir.TabIndex = 251
        Me.txtdir.Visible = False
        '
        'txtdir2
        '
        Me.txtdir2.Location = New System.Drawing.Point(492, 248)
        Me.txtdir2.Name = "txtdir2"
        Me.txtdir2.Size = New System.Drawing.Size(178, 20)
        Me.txtdir2.TabIndex = 252
        Me.txtdir2.Visible = False
        '
        'lbldir
        '
        Me.lbldir.AutoSize = True
        Me.lbldir.Location = New System.Drawing.Point(409, 251)
        Me.lbldir.Name = "lbldir"
        Me.lbldir.Size = New System.Drawing.Size(55, 13)
        Me.lbldir.TabIndex = 253
        Me.lbldir.Text = "Direccion:"
        Me.lbldir.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(282, 33)
        Me.MenuStrip1.TabIndex = 254
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
        Me.AltaInstitutoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AltaInstitutoToolStripMenuItem.Text = "Instituto"
        '
        'AltaGrupoToolStripMenuItem
        '
        Me.AltaGrupoToolStripMenuItem.Name = "AltaGrupoToolStripMenuItem"
        Me.AltaGrupoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AltaGrupoToolStripMenuItem.Text = "Grupo"
        '
        'AltaAsignaturaToolStripMenuItem
        '
        Me.AltaAsignaturaToolStripMenuItem.Name = "AltaAsignaturaToolStripMenuItem"
        Me.AltaAsignaturaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AltaAsignaturaToolStripMenuItem.Text = "Asignatura"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaAsignaturaToolStripMenuItem, Me.BajaGrupoToolStripMenuItem, Me.BajaInstitutoToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 29)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaAsignaturaToolStripMenuItem
        '
        Me.BajaAsignaturaToolStripMenuItem.Name = "BajaAsignaturaToolStripMenuItem"
        Me.BajaAsignaturaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BajaAsignaturaToolStripMenuItem.Text = "Asignatura"
        '
        'BajaGrupoToolStripMenuItem
        '
        Me.BajaGrupoToolStripMenuItem.Name = "BajaGrupoToolStripMenuItem"
        Me.BajaGrupoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BajaGrupoToolStripMenuItem.Text = "Grupo"
        '
        'BajaInstitutoToolStripMenuItem
        '
        Me.BajaInstitutoToolStripMenuItem.Name = "BajaInstitutoToolStripMenuItem"
        Me.BajaInstitutoToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.BajaInstitutoToolStripMenuItem.Text = "Instituto"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionAsignaturaToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 29)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModificacionAsignaturaToolStripMenuItem
        '
        Me.ModificacionAsignaturaToolStripMenuItem.Name = "ModificacionAsignaturaToolStripMenuItem"
        Me.ModificacionAsignaturaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ModificacionAsignaturaToolStripMenuItem.Text = "Asignatura"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 29)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'cmbnominst
        '
        Me.cmbnominst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnominst.FormattingEnabled = True
        Me.cmbnominst.Location = New System.Drawing.Point(150, 222)
        Me.cmbnominst.Name = "cmbnominst"
        Me.cmbnominst.Size = New System.Drawing.Size(203, 21)
        Me.cmbnominst.TabIndex = 255
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 306
        Me.Label2.Text = "Modificacion Instituto"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 305
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(621, 59)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 304
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(621, 37)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 303
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(572, 59)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 302
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(572, 37)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 301
        Me.lblhora1.Text = "Hora:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 52)
        Me.GroupBox1.TabIndex = 307
        Me.GroupBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnActivo
        '
        Me.btnActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnActivo.FlatAppearance.BorderSize = 0
        Me.btnActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivo.Image = CType(resources.GetObject("btnActivo.Image"), System.Drawing.Image)
        Me.btnActivo.Location = New System.Drawing.Point(211, 248)
        Me.btnActivo.Name = "btnActivo"
        Me.btnActivo.Size = New System.Drawing.Size(97, 67)
        Me.btnActivo.TabIndex = 308
        Me.btnActivo.UseVisualStyleBackColor = True
        Me.btnActivo.Visible = False
        '
        'ModInstituto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(694, 374)
        Me.Controls.Add(Me.btnActivo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.cmbnominst)
        Me.Controls.Add(Me.lbldir)
        Me.Controls.Add(Me.txtdir2)
        Me.Controls.Add(Me.txtdir)
        Me.Controls.Add(Me.CheckBoxdireccion)
        Me.Controls.Add(Me.txtnom2)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.lblnom)
        Me.Controls.Add(Me.btnconfirmar2)
        Me.Controls.Add(Me.CheckBoxnom)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.lbllinea)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.btnmodificarlinea)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.lblninst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModInstituto"
        Me.Text = "Modificacion Instituto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnom2 As System.Windows.Forms.TextBox
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents lblnom As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar2 As System.Windows.Forms.Button
    Friend WithEvents CheckBoxnom As System.Windows.Forms.CheckBox
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lbllinea As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents btnmodificarlinea As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents lblninst As System.Windows.Forms.Label
    Friend WithEvents CheckBoxdireccion As System.Windows.Forms.CheckBox
    Friend WithEvents txtdir As System.Windows.Forms.TextBox
    Friend WithEvents txtdir2 As System.Windows.Forms.TextBox
    Friend WithEvents lbldir As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaInstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaAsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaAsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaInstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionAsignaturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbnominst As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnActivo As System.Windows.Forms.Button
End Class
