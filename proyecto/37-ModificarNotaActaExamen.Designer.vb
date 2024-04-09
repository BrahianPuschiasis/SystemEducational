<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarNotaActaExamen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarNotaActaExamen))
        Me.btnmodificarlinea = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.lblci = New System.Windows.Forms.Label
        Me.btnmenuprincipal = New System.Windows.Forms.Button
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.btnconfirmar2 = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ActaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaDeExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarNotaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.GrupoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtModFallo = New System.Windows.Forms.TextBox
        Me.txtModEscrita = New System.Windows.Forms.TextBox
        Me.txtModOral = New System.Windows.Forms.TextBox
        Me.txtModNota = New System.Windows.Forms.TextBox
        Me.CheckBoxFallo = New System.Windows.Forms.CheckBox
        Me.CheckBoxNotaEscrita = New System.Windows.Forms.CheckBox
        Me.CheckBoxNotaOral = New System.Windows.Forms.CheckBox
        Me.CheckBoxNota = New System.Windows.Forms.CheckBox
        Me.lblitem = New System.Windows.Forms.Label
        Me.lbllinea = New System.Windows.Forms.Label
        Me.txtfallo = New System.Windows.Forms.TextBox
        Me.txtnescrita = New System.Windows.Forms.TextBox
        Me.txtnoral = New System.Windows.Forms.TextBox
        Me.txtnota = New System.Windows.Forms.TextBox
        Me.lblfallo = New System.Windows.Forms.Label
        Me.lblnescrita = New System.Windows.Forms.Label
        Me.lblnoral = New System.Windows.Forms.Label
        Me.lblnota = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.txtci = New System.Windows.Forms.MaskedTextBox
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnmodificarlinea
        '
        Me.btnmodificarlinea.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodificarlinea.FlatAppearance.BorderSize = 0
        Me.btnmodificarlinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarlinea.Image = CType(resources.GetObject("btnmodificarlinea.Image"), System.Drawing.Image)
        Me.btnmodificarlinea.Location = New System.Drawing.Point(237, 410)
        Me.btnmodificarlinea.Name = "btnmodificarlinea"
        Me.btnmodificarlinea.Size = New System.Drawing.Size(97, 44)
        Me.btnmodificarlinea.TabIndex = 135
        Me.btnmodificarlinea.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.Location = New System.Drawing.Point(123, 410)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(99, 44)
        Me.btnmodificar.TabIndex = 134
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'lblci
        '
        Me.lblci.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(53, 234)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(58, 13)
        Me.lblci.TabIndex = 132
        Me.lblci.Text = "Ingrese CI:"
        '
        'btnmenuprincipal
        '
        Me.btnmenuprincipal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnmenuprincipal.FlatAppearance.BorderSize = 0
        Me.btnmenuprincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmenuprincipal.Image = CType(resources.GetObject("btnmenuprincipal.Image"), System.Drawing.Image)
        Me.btnmenuprincipal.Location = New System.Drawing.Point(5, 410)
        Me.btnmenuprincipal.Name = "btnmenuprincipal"
        Me.btnmenuprincipal.Size = New System.Drawing.Size(112, 44)
        Me.btnmenuprincipal.TabIndex = 131
        Me.btnmenuprincipal.UseVisualStyleBackColor = True
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(567, 410)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(145, 44)
        Me.btnconfirmar.TabIndex = 150
        Me.btnconfirmar.UseVisualStyleBackColor = True
        Me.btnconfirmar.Visible = False
        '
        'btnconfirmar2
        '
        Me.btnconfirmar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconfirmar2.FlatAppearance.BorderSize = 0
        Me.btnconfirmar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar2.Image = CType(resources.GetObject("btnconfirmar2.Image"), System.Drawing.Image)
        Me.btnconfirmar2.Location = New System.Drawing.Point(443, 410)
        Me.btnconfirmar2.Name = "btnconfirmar2"
        Me.btnconfirmar2.Size = New System.Drawing.Size(140, 44)
        Me.btnconfirmar2.TabIndex = 151
        Me.btnconfirmar2.UseVisualStyleBackColor = True
        Me.btnconfirmar2.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActaToolStripMenuItem, Me.ConsultaToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(225, 31)
        Me.MenuStrip1.TabIndex = 162
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ActaToolStripMenuItem
        '
        Me.ActaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActaDeExamenToolStripMenuItem, Me.ActaFinalToolStripMenuItem})
        Me.ActaToolStripMenuItem.Name = "ActaToolStripMenuItem"
        Me.ActaToolStripMenuItem.Size = New System.Drawing.Size(43, 27)
        Me.ActaToolStripMenuItem.Text = "Acta"
        '
        'ActaDeExamenToolStripMenuItem
        '
        Me.ActaDeExamenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarNotaToolStripMenuItem1})
        Me.ActaDeExamenToolStripMenuItem.Name = "ActaDeExamenToolStripMenuItem"
        Me.ActaDeExamenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ActaDeExamenToolStripMenuItem.Text = "Acta de Examen"
        '
        'ModificarNotaToolStripMenuItem1
        '
        Me.ModificarNotaToolStripMenuItem1.Name = "ModificarNotaToolStripMenuItem1"
        Me.ModificarNotaToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ModificarNotaToolStripMenuItem1.Text = "Ingresar Nota"
        '
        'ActaFinalToolStripMenuItem
        '
        Me.ActaFinalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarNotaToolStripMenuItem, Me.ModificarNotaToolStripMenuItem})
        Me.ActaFinalToolStripMenuItem.Name = "ActaFinalToolStripMenuItem"
        Me.ActaFinalToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ActaFinalToolStripMenuItem.Text = "Acta Final"
        '
        'IngresarNotaToolStripMenuItem
        '
        Me.IngresarNotaToolStripMenuItem.Name = "IngresarNotaToolStripMenuItem"
        Me.IngresarNotaToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.IngresarNotaToolStripMenuItem.Text = "Ingresar Nota"
        '
        'ModificarNotaToolStripMenuItem
        '
        Me.ModificarNotaToolStripMenuItem.Name = "ModificarNotaToolStripMenuItem"
        Me.ModificarNotaToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ModificarNotaToolStripMenuItem.Text = "Modificar Nota"
        '
        'ConsultaToolStripMenuItem3
        '
        Me.ConsultaToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrupoToolStripMenuItem1, Me.DatosPersonalesToolStripMenuItem})
        Me.ConsultaToolStripMenuItem3.Name = "ConsultaToolStripMenuItem3"
        Me.ConsultaToolStripMenuItem3.Size = New System.Drawing.Size(66, 27)
        Me.ConsultaToolStripMenuItem3.Text = "Consulta"
        '
        'GrupoToolStripMenuItem1
        '
        Me.GrupoToolStripMenuItem1.Name = "GrupoToolStripMenuItem1"
        Me.GrupoToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.GrupoToolStripMenuItem1.Text = "Grupo"
        '
        'DatosPersonalesToolStripMenuItem
        '
        Me.DatosPersonalesToolStripMenuItem.Name = "DatosPersonalesToolStripMenuItem"
        Me.DatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DatosPersonalesToolStripMenuItem.Text = "Datos Personales"
        '
        'txtModFallo
        '
        Me.txtModFallo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtModFallo.Location = New System.Drawing.Point(691, 208)
        Me.txtModFallo.Name = "txtModFallo"
        Me.txtModFallo.Size = New System.Drawing.Size(130, 20)
        Me.txtModFallo.TabIndex = 180
        Me.txtModFallo.Visible = False
        '
        'txtModEscrita
        '
        Me.txtModEscrita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtModEscrita.Location = New System.Drawing.Point(473, 208)
        Me.txtModEscrita.Name = "txtModEscrita"
        Me.txtModEscrita.Size = New System.Drawing.Size(130, 20)
        Me.txtModEscrita.TabIndex = 179
        Me.txtModEscrita.Visible = False
        '
        'txtModOral
        '
        Me.txtModOral.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtModOral.Location = New System.Drawing.Point(691, 170)
        Me.txtModOral.Name = "txtModOral"
        Me.txtModOral.Size = New System.Drawing.Size(130, 20)
        Me.txtModOral.TabIndex = 178
        Me.txtModOral.Visible = False
        '
        'txtModNota
        '
        Me.txtModNota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtModNota.Location = New System.Drawing.Point(473, 174)
        Me.txtModNota.Name = "txtModNota"
        Me.txtModNota.Size = New System.Drawing.Size(130, 20)
        Me.txtModNota.TabIndex = 177
        Me.txtModNota.Visible = False
        '
        'CheckBoxFallo
        '
        Me.CheckBoxFallo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxFallo.AutoSize = True
        Me.CheckBoxFallo.Location = New System.Drawing.Point(609, 210)
        Me.CheckBoxFallo.Name = "CheckBoxFallo"
        Me.CheckBoxFallo.Size = New System.Drawing.Size(51, 17)
        Me.CheckBoxFallo.TabIndex = 176
        Me.CheckBoxFallo.Text = "Fallo:"
        Me.CheckBoxFallo.UseVisualStyleBackColor = True
        Me.CheckBoxFallo.Visible = False
        '
        'CheckBoxNotaEscrita
        '
        Me.CheckBoxNotaEscrita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxNotaEscrita.AutoSize = True
        Me.CheckBoxNotaEscrita.Location = New System.Drawing.Point(381, 210)
        Me.CheckBoxNotaEscrita.Name = "CheckBoxNotaEscrita"
        Me.CheckBoxNotaEscrita.Size = New System.Drawing.Size(86, 17)
        Me.CheckBoxNotaEscrita.TabIndex = 175
        Me.CheckBoxNotaEscrita.Text = "Nota escrita:"
        Me.CheckBoxNotaEscrita.UseVisualStyleBackColor = True
        Me.CheckBoxNotaEscrita.Visible = False
        '
        'CheckBoxNotaOral
        '
        Me.CheckBoxNotaOral.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxNotaOral.AutoSize = True
        Me.CheckBoxNotaOral.Location = New System.Drawing.Point(609, 173)
        Me.CheckBoxNotaOral.Name = "CheckBoxNotaOral"
        Me.CheckBoxNotaOral.Size = New System.Drawing.Size(72, 17)
        Me.CheckBoxNotaOral.TabIndex = 174
        Me.CheckBoxNotaOral.Text = "Nota oral:"
        Me.CheckBoxNotaOral.UseVisualStyleBackColor = True
        Me.CheckBoxNotaOral.Visible = False
        '
        'CheckBoxNota
        '
        Me.CheckBoxNota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxNota.AutoSize = True
        Me.CheckBoxNota.Location = New System.Drawing.Point(381, 176)
        Me.CheckBoxNota.Name = "CheckBoxNota"
        Me.CheckBoxNota.Size = New System.Drawing.Size(52, 17)
        Me.CheckBoxNota.TabIndex = 173
        Me.CheckBoxNota.Text = "Nota:"
        Me.CheckBoxNota.UseVisualStyleBackColor = True
        Me.CheckBoxNota.Visible = False
        '
        'lblitem
        '
        Me.lblitem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblitem.AutoSize = True
        Me.lblitem.Location = New System.Drawing.Point(345, 134)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(122, 13)
        Me.lblitem.TabIndex = 172
        Me.lblitem.Text = "Modificacion de un item:"
        Me.lblitem.Visible = False
        '
        'lbllinea
        '
        Me.lbllinea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbllinea.AutoSize = True
        Me.lbllinea.Location = New System.Drawing.Point(345, 253)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(110, 13)
        Me.lbllinea.TabIndex = 171
        Me.lbllinea.Text = "Modificacion de linea:"
        Me.lbllinea.Visible = False
        '
        'txtfallo
        '
        Me.txtfallo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtfallo.Location = New System.Drawing.Point(691, 324)
        Me.txtfallo.Name = "txtfallo"
        Me.txtfallo.Size = New System.Drawing.Size(130, 20)
        Me.txtfallo.TabIndex = 170
        Me.txtfallo.Visible = False
        '
        'txtnescrita
        '
        Me.txtnescrita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnescrita.Location = New System.Drawing.Point(473, 324)
        Me.txtnescrita.Name = "txtnescrita"
        Me.txtnescrita.Size = New System.Drawing.Size(130, 20)
        Me.txtnescrita.TabIndex = 169
        Me.txtnescrita.Visible = False
        '
        'txtnoral
        '
        Me.txtnoral.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnoral.Location = New System.Drawing.Point(691, 287)
        Me.txtnoral.Name = "txtnoral"
        Me.txtnoral.Size = New System.Drawing.Size(130, 20)
        Me.txtnoral.TabIndex = 168
        Me.txtnoral.Visible = False
        '
        'txtnota
        '
        Me.txtnota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnota.Location = New System.Drawing.Point(473, 287)
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(130, 20)
        Me.txtnota.TabIndex = 167
        Me.txtnota.Visible = False
        '
        'lblfallo
        '
        Me.lblfallo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblfallo.AutoSize = True
        Me.lblfallo.Location = New System.Drawing.Point(606, 327)
        Me.lblfallo.Name = "lblfallo"
        Me.lblfallo.Size = New System.Drawing.Size(32, 13)
        Me.lblfallo.TabIndex = 166
        Me.lblfallo.Text = "Fallo:"
        Me.lblfallo.Visible = False
        '
        'lblnescrita
        '
        Me.lblnescrita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnescrita.AutoSize = True
        Me.lblnescrita.Location = New System.Drawing.Point(378, 327)
        Me.lblnescrita.Name = "lblnescrita"
        Me.lblnescrita.Size = New System.Drawing.Size(68, 13)
        Me.lblnescrita.TabIndex = 165
        Me.lblnescrita.Text = "Nota Escrita:"
        Me.lblnescrita.Visible = False
        '
        'lblnoral
        '
        Me.lblnoral.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnoral.AutoSize = True
        Me.lblnoral.Location = New System.Drawing.Point(606, 290)
        Me.lblnoral.Name = "lblnoral"
        Me.lblnoral.Size = New System.Drawing.Size(55, 13)
        Me.lblnoral.TabIndex = 164
        Me.lblnoral.Text = "Nota Oral:"
        Me.lblnoral.Visible = False
        '
        'lblnota
        '
        Me.lblnota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnota.AutoSize = True
        Me.lblnota.Location = New System.Drawing.Point(378, 290)
        Me.lblnota.Name = "lblnota"
        Me.lblnota.Size = New System.Drawing.Size(33, 13)
        Me.lblnota.TabIndex = 163
        Me.lblnota.Text = "Nota:"
        Me.lblnota.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 50)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificacion Nota Acta Examen"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 357
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(744, 61)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 356
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(744, 39)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 355
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(698, 61)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 354
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(698, 39)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 353
        Me.lblhora1.Text = "Hora:"
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(149, 231)
        Me.txtci.Mask = "0.000.000-0"
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(73, 20)
        Me.txtci.TabIndex = 358
        Me.txtci.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'ModificarNotaActaExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(836, 456)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtModFallo)
        Me.Controls.Add(Me.txtModEscrita)
        Me.Controls.Add(Me.txtModOral)
        Me.Controls.Add(Me.txtModNota)
        Me.Controls.Add(Me.CheckBoxFallo)
        Me.Controls.Add(Me.CheckBoxNotaEscrita)
        Me.Controls.Add(Me.CheckBoxNotaOral)
        Me.Controls.Add(Me.CheckBoxNota)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.lbllinea)
        Me.Controls.Add(Me.txtfallo)
        Me.Controls.Add(Me.txtnescrita)
        Me.Controls.Add(Me.txtnoral)
        Me.Controls.Add(Me.txtnota)
        Me.Controls.Add(Me.lblfallo)
        Me.Controls.Add(Me.lblnescrita)
        Me.Controls.Add(Me.lblnoral)
        Me.Controls.Add(Me.lblnota)
        Me.Controls.Add(Me.btnconfirmar2)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.btnmodificarlinea)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.lblci)
        Me.Controls.Add(Me.btnmenuprincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarNotaActaExamen"
        Me.Text = "Modificar Nota"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnmodificarlinea As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents btnmenuprincipal As System.Windows.Forms.Button
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents btnconfirmar2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaDeExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarNotaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarNotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarNotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosPersonalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtModFallo As System.Windows.Forms.TextBox
    Friend WithEvents txtModEscrita As System.Windows.Forms.TextBox
    Friend WithEvents txtModOral As System.Windows.Forms.TextBox
    Friend WithEvents txtModNota As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxFallo As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxNotaEscrita As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxNotaOral As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxNota As System.Windows.Forms.CheckBox
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lbllinea As System.Windows.Forms.Label
    Friend WithEvents txtfallo As System.Windows.Forms.TextBox
    Friend WithEvents txtnescrita As System.Windows.Forms.TextBox
    Friend WithEvents txtnoral As System.Windows.Forms.TextBox
    Friend WithEvents txtnota As System.Windows.Forms.TextBox
    Friend WithEvents lblfallo As System.Windows.Forms.Label
    Friend WithEvents lblnescrita As System.Windows.Forms.Label
    Friend WithEvents lblnoral As System.Windows.Forms.Label
    Friend WithEvents lblnota As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents txtci As System.Windows.Forms.MaskedTextBox
End Class
