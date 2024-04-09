<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaActaExamen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaActaExamen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaActaExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnimprimirpdf = New System.Windows.Forms.Button
        Me.btnlistar = New System.Windows.Forms.Button
        Me.webbrowser = New System.Windows.Forms.WebBrowser
        Me.File = New System.Windows.Forms.SaveFileDialog
        Me.DGVConsulta = New System.Windows.Forms.DataGridView
        Me.btnGrupo = New System.Windows.Forms.Button
        Me.cmbgrupo = New System.Windows.Forms.TextBox
        Me.lblgrupo = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(319, 34)
        Me.MenuStrip1.TabIndex = 95
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaActaFinalToolStripMenuItem, Me.AltaActaExamenToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 30)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaActaFinalToolStripMenuItem
        '
        Me.AltaActaFinalToolStripMenuItem.Name = "AltaActaFinalToolStripMenuItem"
        Me.AltaActaFinalToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AltaActaFinalToolStripMenuItem.Text = "Acta Final"
        '
        'AltaActaExamenToolStripMenuItem
        '
        Me.AltaActaExamenToolStripMenuItem.Name = "AltaActaExamenToolStripMenuItem"
        Me.AltaActaExamenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AltaActaExamenToolStripMenuItem.Text = " Acta Examen"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 53)
        Me.GroupBox1.TabIndex = 111
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta Acta de Examen"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 333
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(757, 64)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 332
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(757, 42)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 331
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(711, 64)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 330
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(711, 42)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 329
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnimprimirpdf
        '
        Me.btnimprimirpdf.BackgroundImage = CType(resources.GetObject("btnimprimirpdf.BackgroundImage"), System.Drawing.Image)
        Me.btnimprimirpdf.FlatAppearance.BorderSize = 0
        Me.btnimprimirpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimirpdf.Location = New System.Drawing.Point(662, 740)
        Me.btnimprimirpdf.Name = "btnimprimirpdf"
        Me.btnimprimirpdf.Size = New System.Drawing.Size(115, 32)
        Me.btnimprimirpdf.TabIndex = 447
        Me.btnimprimirpdf.UseVisualStyleBackColor = True
        '
        'btnlistar
        '
        Me.btnlistar.BackgroundImage = CType(resources.GetObject("btnlistar.BackgroundImage"), System.Drawing.Image)
        Me.btnlistar.FlatAppearance.BorderSize = 0
        Me.btnlistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlistar.Location = New System.Drawing.Point(467, 195)
        Me.btnlistar.Name = "btnlistar"
        Me.btnlistar.Size = New System.Drawing.Size(121, 32)
        Me.btnlistar.TabIndex = 444
        Me.btnlistar.UseVisualStyleBackColor = True
        '
        'webbrowser
        '
        Me.webbrowser.Location = New System.Drawing.Point(26, 233)
        Me.webbrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webbrowser.Name = "webbrowser"
        Me.webbrowser.Size = New System.Drawing.Size(812, 484)
        Me.webbrowser.TabIndex = 443
        Me.webbrowser.Visible = False
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
        Me.DGVConsulta.Location = New System.Drawing.Point(88, 233)
        Me.DGVConsulta.MultiSelect = False
        Me.DGVConsulta.Name = "DGVConsulta"
        Me.DGVConsulta.ReadOnly = True
        Me.DGVConsulta.Size = New System.Drawing.Size(611, 242)
        Me.DGVConsulta.TabIndex = 452
        Me.DGVConsulta.Visible = False
        '
        'btnGrupo
        '
        Me.btnGrupo.Location = New System.Drawing.Point(611, 138)
        Me.btnGrupo.Name = "btnGrupo"
        Me.btnGrupo.Size = New System.Drawing.Size(37, 20)
        Me.btnGrupo.TabIndex = 451
        Me.btnGrupo.Text = "?"
        Me.btnGrupo.UseVisualStyleBackColor = True
        '
        'cmbgrupo
        '
        Me.cmbgrupo.Location = New System.Drawing.Point(491, 139)
        Me.cmbgrupo.Name = "cmbgrupo"
        Me.cmbgrupo.Size = New System.Drawing.Size(100, 20)
        Me.cmbgrupo.TabIndex = 450
        '
        'lblgrupo
        '
        Me.lblgrupo.AutoSize = True
        Me.lblgrupo.Location = New System.Drawing.Point(415, 142)
        Me.lblgrupo.Name = "lblgrupo"
        Me.lblgrupo.Size = New System.Drawing.Size(75, 13)
        Me.lblgrupo.TabIndex = 449
        Me.lblgrupo.Text = "Código Grupo:"
        '
        'ConsultaActaExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(850, 784)
        Me.Controls.Add(Me.DGVConsulta)
        Me.Controls.Add(Me.btnGrupo)
        Me.Controls.Add(Me.cmbgrupo)
        Me.Controls.Add(Me.lblgrupo)
        Me.Controls.Add(Me.btnimprimirpdf)
        Me.Controls.Add(Me.btnlistar)
        Me.Controls.Add(Me.webbrowser)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaActaExamen"
        Me.Text = "Consulta de Acta de Examen"
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
    Friend WithEvents AltaActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaActaExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnimprimirpdf As System.Windows.Forms.Button
    Friend WithEvents btnlistar As System.Windows.Forms.Button
    Friend WithEvents webbrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents File As System.Windows.Forms.SaveFileDialog
    Friend WithEvents DGVConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents btnGrupo As System.Windows.Forms.Button
    Friend WithEvents cmbgrupo As System.Windows.Forms.TextBox
    Friend WithEvents lblgrupo As System.Windows.Forms.Label
End Class
