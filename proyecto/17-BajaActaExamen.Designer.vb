<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BajaActaExamen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BajaActaExamen))
        Me.lblnum = New System.Windows.Forms.Label
        Me.btnborrar = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaActaExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionActaExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaActaExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbnunacta = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblnum
        '
        Me.lblnum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(56, 206)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(122, 13)
        Me.lblnum.TabIndex = 59
        Me.lblnum.Text = "Ingrese numero de acta:"
        '
        'btnborrar
        '
        Me.btnborrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnborrar.FlatAppearance.BorderSize = 0
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrar.Image = CType(resources.GetObject("btnborrar.Image"), System.Drawing.Image)
        Me.btnborrar.Location = New System.Drawing.Point(278, 257)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(112, 55)
        Me.btnborrar.TabIndex = 58
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(257, 33)
        Me.MenuStrip1.TabIndex = 61
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaActaExamenToolStripMenuItem, Me.AltaActaFinalToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 29)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaActaExamenToolStripMenuItem
        '
        Me.AltaActaExamenToolStripMenuItem.Name = "AltaActaExamenToolStripMenuItem"
        Me.AltaActaExamenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AltaActaExamenToolStripMenuItem.Text = "Acta Examen"
        '
        'AltaActaFinalToolStripMenuItem
        '
        Me.AltaActaFinalToolStripMenuItem.Name = "AltaActaFinalToolStripMenuItem"
        Me.AltaActaFinalToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AltaActaFinalToolStripMenuItem.Text = "Acta Final"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaActaFinalToolStripMenuItem})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 29)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaActaFinalToolStripMenuItem
        '
        Me.BajaActaFinalToolStripMenuItem.Name = "BajaActaFinalToolStripMenuItem"
        Me.BajaActaFinalToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BajaActaFinalToolStripMenuItem.Text = "Acta Final"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionActaExamenToolStripMenuItem, Me.ModificacionActaFinalToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 29)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModificacionActaExamenToolStripMenuItem
        '
        Me.ModificacionActaExamenToolStripMenuItem.Name = "ModificacionActaExamenToolStripMenuItem"
        Me.ModificacionActaExamenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ModificacionActaExamenToolStripMenuItem.Text = "Acta Examen"
        '
        'ModificacionActaFinalToolStripMenuItem
        '
        Me.ModificacionActaFinalToolStripMenuItem.Name = "ModificacionActaFinalToolStripMenuItem"
        Me.ModificacionActaFinalToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ModificacionActaFinalToolStripMenuItem.Text = "Acta Final"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaActaExamenToolStripMenuItem, Me.ConsultaActaFinalToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 29)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'ConsultaActaExamenToolStripMenuItem
        '
        Me.ConsultaActaExamenToolStripMenuItem.Name = "ConsultaActaExamenToolStripMenuItem"
        Me.ConsultaActaExamenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ConsultaActaExamenToolStripMenuItem.Text = " Acta Examen"
        '
        'ConsultaActaFinalToolStripMenuItem
        '
        Me.ConsultaActaFinalToolStripMenuItem.Name = "ConsultaActaFinalToolStripMenuItem"
        Me.ConsultaActaFinalToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ConsultaActaFinalToolStripMenuItem.Text = " Acta Final"
        '
        'cmbnunacta
        '
        Me.cmbnunacta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnunacta.FormattingEnabled = True
        Me.cmbnunacta.Location = New System.Drawing.Point(186, 203)
        Me.cmbnunacta.Name = "cmbnunacta"
        Me.cmbnunacta.Size = New System.Drawing.Size(138, 21)
        Me.cmbnunacta.TabIndex = 260
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 52)
        Me.GroupBox1.TabIndex = 261
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 271
        Me.Label2.Text = "Baja Acta Examen"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 13)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 270
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(324, 57)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 269
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(324, 35)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 268
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(275, 57)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 267
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(275, 35)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 266
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BajaActaExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(391, 310)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbnunacta)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.btnborrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BajaActaExamen"
        Me.Text = "Baja de Acta de Examen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnum As System.Windows.Forms.Label
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaActaExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionActaExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaActaExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbnunacta As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
