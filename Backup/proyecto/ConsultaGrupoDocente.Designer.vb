<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaGrupoDocente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaGrupoDocente))
        Me.DGVConsulta = New System.Windows.Forms.DataGridView
        Me.lblpreferencias = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lblci = New System.Windows.Forms.Label
        Me.Ordenar = New System.Windows.Forms.GroupBox
        Me.lblgrupo = New System.Windows.Forms.Label
        Me.CmbListadoGrupo = New System.Windows.Forms.ComboBox
        Me.btnAscendente = New System.Windows.Forms.Button
        Me.btndescendente = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ActaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaDeExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarNotaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.DatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CmbConsulta = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.txtci = New System.Windows.Forms.MaskedTextBox
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ordenar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVConsulta
        '
        Me.DGVConsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVConsulta.Location = New System.Drawing.Point(293, 131)
        Me.DGVConsulta.Name = "DGVConsulta"
        Me.DGVConsulta.Size = New System.Drawing.Size(434, 199)
        Me.DGVConsulta.TabIndex = 90
        '
        'lblpreferencias
        '
        Me.lblpreferencias.AutoSize = True
        Me.lblpreferencias.Location = New System.Drawing.Point(29, 188)
        Me.lblpreferencias.Name = "lblpreferencias"
        Me.lblpreferencias.Size = New System.Drawing.Size(134, 13)
        Me.lblpreferencias.TabIndex = 98
        Me.lblpreferencias.Text = "Preferencias de busqueda:"
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(96, 289)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(105, 41)
        Me.btnBuscar.TabIndex = 97
        Me.btnBuscar.UseVisualStyleBackColor = True
        Me.btnBuscar.Visible = False
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(30, 266)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(58, 13)
        Me.lblci.TabIndex = 100
        Me.lblci.Text = "CI Alumno:"
        Me.lblci.Visible = False
        '
        'Ordenar
        '
        Me.Ordenar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ordenar.Controls.Add(Me.lblgrupo)
        Me.Ordenar.Controls.Add(Me.CmbListadoGrupo)
        Me.Ordenar.Controls.Add(Me.btnAscendente)
        Me.Ordenar.Controls.Add(Me.btndescendente)
        Me.Ordenar.Location = New System.Drawing.Point(33, 349)
        Me.Ordenar.Name = "Ordenar"
        Me.Ordenar.Size = New System.Drawing.Size(694, 97)
        Me.Ordenar.TabIndex = 102
        Me.Ordenar.TabStop = False
        Me.Ordenar.Text = "Ordenar en forma"
        Me.Ordenar.Visible = False
        '
        'lblgrupo
        '
        Me.lblgrupo.AutoSize = True
        Me.lblgrupo.Location = New System.Drawing.Point(14, 43)
        Me.lblgrupo.Name = "lblgrupo"
        Me.lblgrupo.Size = New System.Drawing.Size(39, 13)
        Me.lblgrupo.TabIndex = 105
        Me.lblgrupo.Text = "Grupo:"
        '
        'CmbListadoGrupo
        '
        Me.CmbListadoGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbListadoGrupo.FormattingEnabled = True
        Me.CmbListadoGrupo.Location = New System.Drawing.Point(104, 40)
        Me.CmbListadoGrupo.Name = "CmbListadoGrupo"
        Me.CmbListadoGrupo.Size = New System.Drawing.Size(123, 21)
        Me.CmbListadoGrupo.TabIndex = 104
        '
        'btnAscendente
        '
        Me.btnAscendente.FlatAppearance.BorderSize = 0
        Me.btnAscendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAscendente.Image = CType(resources.GetObject("btnAscendente.Image"), System.Drawing.Image)
        Me.btnAscendente.Location = New System.Drawing.Point(293, 31)
        Me.btnAscendente.Name = "btnAscendente"
        Me.btnAscendente.Size = New System.Drawing.Size(149, 36)
        Me.btnAscendente.TabIndex = 68
        Me.btnAscendente.UseVisualStyleBackColor = True
        '
        'btndescendente
        '
        Me.btndescendente.FlatAppearance.BorderSize = 0
        Me.btndescendente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndescendente.Image = CType(resources.GetObject("btndescendente.Image"), System.Drawing.Image)
        Me.btndescendente.Location = New System.Drawing.Point(494, 30)
        Me.btndescendente.Name = "btndescendente"
        Me.btndescendente.Size = New System.Drawing.Size(157, 38)
        Me.btndescendente.TabIndex = 69
        Me.btndescendente.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActaToolStripMenuItem, Me.ConsultaToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(221, 24)
        Me.MenuStrip1.TabIndex = 105
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.ActaDeExamenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarNotaToolStripMenuItem1})
        Me.ActaDeExamenToolStripMenuItem.Name = "ActaDeExamenToolStripMenuItem"
        Me.ActaDeExamenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ActaDeExamenToolStripMenuItem.Text = "Acta de Examen"
        '
        'IngresarNotaToolStripMenuItem1
        '
        Me.IngresarNotaToolStripMenuItem1.Name = "IngresarNotaToolStripMenuItem1"
        Me.IngresarNotaToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.IngresarNotaToolStripMenuItem1.Text = "Ingresar Nota"
        '
        'ActaFinalToolStripMenuItem
        '
        Me.ActaFinalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarNotaToolStripMenuItem})
        Me.ActaFinalToolStripMenuItem.Name = "ActaFinalToolStripMenuItem"
        Me.ActaFinalToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ActaFinalToolStripMenuItem.Text = "Acta Final"
        '
        'IngresarNotaToolStripMenuItem
        '
        Me.IngresarNotaToolStripMenuItem.Name = "IngresarNotaToolStripMenuItem"
        Me.IngresarNotaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.IngresarNotaToolStripMenuItem.Text = "Ingresar Nota"
        '
        'ConsultaToolStripMenuItem3
        '
        Me.ConsultaToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosPersonalesToolStripMenuItem})
        Me.ConsultaToolStripMenuItem3.Name = "ConsultaToolStripMenuItem3"
        Me.ConsultaToolStripMenuItem3.Size = New System.Drawing.Size(66, 20)
        Me.ConsultaToolStripMenuItem3.Text = "Consulta"
        '
        'DatosPersonalesToolStripMenuItem
        '
        Me.DatosPersonalesToolStripMenuItem.Name = "DatosPersonalesToolStripMenuItem"
        Me.DatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DatosPersonalesToolStripMenuItem.Text = "Datos Personales"
        '
        'CmbConsulta
        '
        Me.CmbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbConsulta.FormattingEnabled = True
        Me.CmbConsulta.Items.AddRange(New Object() {"Alumno", "Alumnos de Grupo"})
        Me.CmbConsulta.Location = New System.Drawing.Point(33, 217)
        Me.CmbConsulta.Name = "CmbConsulta"
        Me.CmbConsulta.Size = New System.Drawing.Size(202, 21)
        Me.CmbConsulta.TabIndex = 119
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 43)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta Grupo Docente"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 369
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(658, 64)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 368
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(658, 42)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 367
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(612, 64)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 366
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(612, 42)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 365
        Me.lblhora1.Text = "Hora:"
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(128, 263)
        Me.txtci.Mask = "0.000.000-0"
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(73, 20)
        Me.txtci.TabIndex = 370
        Me.txtci.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'ConsultaGrupoDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(751, 509)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbConsulta)
        Me.Controls.Add(Me.Ordenar)
        Me.Controls.Add(Me.lblci)
        Me.Controls.Add(Me.lblpreferencias)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DGVConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultaGrupoDocente"
        Me.Text = "ConsultaGrupoDocente"
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ordenar.ResumeLayout(False)
        Me.Ordenar.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents lblpreferencias As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents Ordenar As System.Windows.Forms.GroupBox
    Friend WithEvents btnAscendente As System.Windows.Forms.Button
    Friend WithEvents btndescendente As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaDeExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarNotaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarNotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosPersonalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblgrupo As System.Windows.Forms.Label
    Friend WithEvents CmbListadoGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents CmbConsulta As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents txtci As System.Windows.Forms.MaskedTextBox
End Class
