<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModAsignatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModAsignatura))
        Me.lbllinea = New System.Windows.Forms.Label
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.lblidasign = New System.Windows.Forms.Label
        Me.lblnomasign = New System.Windows.Forms.Label
        Me.txtnomasing = New System.Windows.Forms.TextBox
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaDocenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionInstitutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbnomasig = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnActivo = New System.Windows.Forms.Button
        Me.MenuStrip2.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbllinea
        '
        Me.lbllinea.AutoSize = True
        Me.lbllinea.Location = New System.Drawing.Point(366, 119)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(110, 13)
        Me.lbllinea.TabIndex = 207
        Me.lbllinea.Text = "Modificacion de linea:"
        Me.lbllinea.Visible = False
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(449, 284)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(147, 69)
        Me.btnconfirmar.TabIndex = 206
        Me.btnconfirmar.UseVisualStyleBackColor = True
        Me.btnconfirmar.Visible = False
        '
        'lblidasign
        '
        Me.lblidasign.AutoSize = True
        Me.lblidasign.Location = New System.Drawing.Point(17, 193)
        Me.lblidasign.Name = "lblidasign"
        Me.lblidasign.Size = New System.Drawing.Size(160, 13)
        Me.lblidasign.TabIndex = 202
        Me.lblidasign.Text = "Eleja el nombre de la asignatura:"
        '
        'lblnomasign
        '
        Me.lblnomasign.AutoSize = True
        Me.lblnomasign.Location = New System.Drawing.Point(366, 153)
        Me.lblnomasign.Name = "lblnomasign"
        Me.lblnomasign.Size = New System.Drawing.Size(47, 13)
        Me.lblnomasign.TabIndex = 232
        Me.lblnomasign.Text = "Nombre:"
        Me.lblnomasign.Visible = False
        '
        'txtnomasing
        '
        Me.txtnomasing.Location = New System.Drawing.Point(449, 147)
        Me.txtnomasing.Name = "txtnomasing"
        Me.txtnomasing.Size = New System.Drawing.Size(147, 20)
        Me.txtnomasing.TabIndex = 235
        Me.txtnomasing.Visible = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(308, 29)
        Me.MenuStrip2.TabIndex = 237
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
        Me.BajaDocenteToolStripMenuItem.Text = "Docente"
        '
        'BajaAlumnoToolStripMenuItem
        '
        Me.BajaAlumnoToolStripMenuItem.Name = "BajaAlumnoToolStripMenuItem"
        Me.BajaAlumnoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BajaAlumnoToolStripMenuItem.Text = "Alumno"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionInstitutoToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 25)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModificacionInstitutoToolStripMenuItem
        '
        Me.ModificacionInstitutoToolStripMenuItem.Name = "ModificacionInstitutoToolStripMenuItem"
        Me.ModificacionInstitutoToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ModificacionInstitutoToolStripMenuItem.Text = "Instituto"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 25)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'cmbnomasig
        '
        Me.cmbnomasig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnomasig.FormattingEnabled = True
        Me.cmbnomasig.Location = New System.Drawing.Point(196, 190)
        Me.cmbnomasig.Name = "cmbnomasig"
        Me.cmbnomasig.Size = New System.Drawing.Size(138, 21)
        Me.cmbnomasig.TabIndex = 238
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 299
        Me.Label2.Text = "Modificacion Asignatura"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 298
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(592, 56)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 297
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(592, 34)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 296
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(543, 56)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 295
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(543, 34)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 294
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip2)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 48)
        Me.GroupBox1.TabIndex = 300
        Me.GroupBox1.TabStop = False
        '
        'btnActivo
        '
        Me.btnActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnActivo.FlatAppearance.BorderSize = 0
        Me.btnActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivo.Image = CType(resources.GetObject("btnActivo.Image"), System.Drawing.Image)
        Me.btnActivo.Location = New System.Drawing.Point(217, 217)
        Me.btnActivo.Name = "btnActivo"
        Me.btnActivo.Size = New System.Drawing.Size(97, 67)
        Me.btnActivo.TabIndex = 309
        Me.btnActivo.UseVisualStyleBackColor = True
        Me.btnActivo.Visible = False
        '
        'ModAsignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(665, 355)
        Me.Controls.Add(Me.btnActivo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.cmbnomasig)
        Me.Controls.Add(Me.txtnomasing)
        Me.Controls.Add(Me.lblnomasign)
        Me.Controls.Add(Me.lbllinea)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.lblidasign)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModAsignatura"
        Me.Text = "Modificacion Asignatura"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbllinea As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents lblidasign As System.Windows.Forms.Label
    Friend WithEvents lblnomasign As System.Windows.Forms.Label
    Friend WithEvents txtnomasing As System.Windows.Forms.TextBox
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
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionInstitutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbnomasig As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnActivo As System.Windows.Forms.Button
End Class
