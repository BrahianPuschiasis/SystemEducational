<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarNotaActaFinal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarNotaActaFinal))
        Me.txtModInasistencias = New System.Windows.Forms.TextBox
        Me.txtModNota = New System.Windows.Forms.TextBox
        Me.CheckBoxInasistencias = New System.Windows.Forms.CheckBox
        Me.CheckBoxNota = New System.Windows.Forms.CheckBox
        Me.lblitem = New System.Windows.Forms.Label
        Me.btnconfirmar2 = New System.Windows.Forms.Button
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.lbllinea = New System.Windows.Forms.Label
        Me.txtInasistencias = New System.Windows.Forms.TextBox
        Me.txtnota = New System.Windows.Forms.TextBox
        Me.lblInasistencias = New System.Windows.Forms.Label
        Me.lblnota = New System.Windows.Forms.Label
        Me.btnmodificarlinea = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.lblci = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ActaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaDeExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarNotaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarNotaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.GrupoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.NotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtci = New System.Windows.Forms.MaskedTextBox
        Me.MenuStrip1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtModInasistencias
        '
        Me.txtModInasistencias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtModInasistencias.Location = New System.Drawing.Point(484, 181)
        Me.txtModInasistencias.Name = "txtModInasistencias"
        Me.txtModInasistencias.Size = New System.Drawing.Size(130, 20)
        Me.txtModInasistencias.TabIndex = 184
        Me.txtModInasistencias.Visible = False
        '
        'txtModNota
        '
        Me.txtModNota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtModNota.Location = New System.Drawing.Point(484, 153)
        Me.txtModNota.Name = "txtModNota"
        Me.txtModNota.Size = New System.Drawing.Size(130, 20)
        Me.txtModNota.TabIndex = 183
        Me.txtModNota.Visible = False
        '
        'CheckBoxInasistencias
        '
        Me.CheckBoxInasistencias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxInasistencias.AutoSize = True
        Me.CheckBoxInasistencias.Location = New System.Drawing.Point(372, 184)
        Me.CheckBoxInasistencias.Name = "CheckBoxInasistencias"
        Me.CheckBoxInasistencias.Size = New System.Drawing.Size(90, 17)
        Me.CheckBoxInasistencias.TabIndex = 180
        Me.CheckBoxInasistencias.Text = "Inasistencias:"
        Me.CheckBoxInasistencias.UseVisualStyleBackColor = True
        Me.CheckBoxInasistencias.Visible = False
        '
        'CheckBoxNota
        '
        Me.CheckBoxNota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxNota.AutoSize = True
        Me.CheckBoxNota.Location = New System.Drawing.Point(372, 155)
        Me.CheckBoxNota.Name = "CheckBoxNota"
        Me.CheckBoxNota.Size = New System.Drawing.Size(52, 17)
        Me.CheckBoxNota.TabIndex = 179
        Me.CheckBoxNota.Text = "Nota:"
        Me.CheckBoxNota.UseVisualStyleBackColor = True
        Me.CheckBoxNota.Visible = False
        '
        'lblitem
        '
        Me.lblitem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblitem.AutoSize = True
        Me.lblitem.Location = New System.Drawing.Point(339, 107)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(122, 13)
        Me.lblitem.TabIndex = 178
        Me.lblitem.Text = "Modificacion de un item:"
        Me.lblitem.Visible = False
        '
        'btnconfirmar2
        '
        Me.btnconfirmar2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnconfirmar2.FlatAppearance.BorderSize = 0
        Me.btnconfirmar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar2.Image = CType(resources.GetObject("btnconfirmar2.Image"), System.Drawing.Image)
        Me.btnconfirmar2.Location = New System.Drawing.Point(356, 347)
        Me.btnconfirmar2.Name = "btnconfirmar2"
        Me.btnconfirmar2.Size = New System.Drawing.Size(148, 43)
        Me.btnconfirmar2.TabIndex = 177
        Me.btnconfirmar2.UseVisualStyleBackColor = True
        Me.btnconfirmar2.Visible = False
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(488, 347)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(139, 43)
        Me.btnconfirmar.TabIndex = 176
        Me.btnconfirmar.UseVisualStyleBackColor = True
        Me.btnconfirmar.Visible = False
        '
        'lbllinea
        '
        Me.lbllinea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbllinea.AutoSize = True
        Me.lbllinea.Location = New System.Drawing.Point(339, 222)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(110, 13)
        Me.lbllinea.TabIndex = 175
        Me.lbllinea.Text = "Modificacion de linea:"
        Me.lbllinea.Visible = False
        '
        'txtInasistencias
        '
        Me.txtInasistencias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInasistencias.Location = New System.Drawing.Point(484, 301)
        Me.txtInasistencias.Name = "txtInasistencias"
        Me.txtInasistencias.Size = New System.Drawing.Size(130, 20)
        Me.txtInasistencias.TabIndex = 172
        Me.txtInasistencias.Visible = False
        '
        'txtnota
        '
        Me.txtnota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnota.Location = New System.Drawing.Point(484, 264)
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(130, 20)
        Me.txtnota.TabIndex = 171
        Me.txtnota.Visible = False
        '
        'lblInasistencias
        '
        Me.lblInasistencias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInasistencias.AutoSize = True
        Me.lblInasistencias.Location = New System.Drawing.Point(369, 304)
        Me.lblInasistencias.Name = "lblInasistencias"
        Me.lblInasistencias.Size = New System.Drawing.Size(71, 13)
        Me.lblInasistencias.TabIndex = 168
        Me.lblInasistencias.Text = "Inasistencias:"
        Me.lblInasistencias.Visible = False
        '
        'lblnota
        '
        Me.lblnota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnota.AutoSize = True
        Me.lblnota.Location = New System.Drawing.Point(369, 267)
        Me.lblnota.Name = "lblnota"
        Me.lblnota.Size = New System.Drawing.Size(33, 13)
        Me.lblnota.TabIndex = 167
        Me.lblnota.Text = "Nota:"
        Me.lblnota.Visible = False
        '
        'btnmodificarlinea
        '
        Me.btnmodificarlinea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnmodificarlinea.FlatAppearance.BorderSize = 0
        Me.btnmodificarlinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarlinea.Image = CType(resources.GetObject("btnmodificarlinea.Image"), System.Drawing.Image)
        Me.btnmodificarlinea.Location = New System.Drawing.Point(228, 347)
        Me.btnmodificarlinea.Name = "btnmodificarlinea"
        Me.btnmodificarlinea.Size = New System.Drawing.Size(96, 43)
        Me.btnmodificarlinea.TabIndex = 166
        Me.btnmodificarlinea.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.Location = New System.Drawing.Point(123, 347)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(99, 43)
        Me.btnmodificar.TabIndex = 165
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'lblci
        '
        Me.lblci.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblci.AutoSize = True
        Me.lblci.Location = New System.Drawing.Point(58, 228)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(58, 13)
        Me.lblci.TabIndex = 163
        Me.lblci.Text = "Ingrese CI:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActaToolStripMenuItem, Me.ConsultaToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(225, 29)
        Me.MenuStrip1.TabIndex = 185
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ActaToolStripMenuItem
        '
        Me.ActaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActaDeExamenToolStripMenuItem, Me.ActaFinalToolStripMenuItem})
        Me.ActaToolStripMenuItem.Name = "ActaToolStripMenuItem"
        Me.ActaToolStripMenuItem.Size = New System.Drawing.Size(43, 25)
        Me.ActaToolStripMenuItem.Text = "Acta"
        '
        'ActaDeExamenToolStripMenuItem
        '
        Me.ActaDeExamenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarNotaToolStripMenuItem1, Me.ModificarNotaToolStripMenuItem1})
        Me.ActaDeExamenToolStripMenuItem.Name = "ActaDeExamenToolStripMenuItem"
        Me.ActaDeExamenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ActaDeExamenToolStripMenuItem.Text = "Acta de Examen"
        '
        'IngresarNotaToolStripMenuItem1
        '
        Me.IngresarNotaToolStripMenuItem1.Name = "IngresarNotaToolStripMenuItem1"
        Me.IngresarNotaToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.IngresarNotaToolStripMenuItem1.Text = "Ingresar Nota"
        '
        'ModificarNotaToolStripMenuItem1
        '
        Me.ModificarNotaToolStripMenuItem1.Name = "ModificarNotaToolStripMenuItem1"
        Me.ModificarNotaToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.ModificarNotaToolStripMenuItem1.Text = "Modificar Nota"
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
        Me.ConsultaToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrupoToolStripMenuItem1, Me.NotasToolStripMenuItem, Me.DatosPersonalesToolStripMenuItem})
        Me.ConsultaToolStripMenuItem3.Name = "ConsultaToolStripMenuItem3"
        Me.ConsultaToolStripMenuItem3.Size = New System.Drawing.Size(66, 25)
        Me.ConsultaToolStripMenuItem3.Text = "Consulta"
        '
        'GrupoToolStripMenuItem1
        '
        Me.GrupoToolStripMenuItem1.Name = "GrupoToolStripMenuItem1"
        Me.GrupoToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.GrupoToolStripMenuItem1.Text = "Grupo"
        '
        'NotasToolStripMenuItem
        '
        Me.NotasToolStripMenuItem.Name = "NotasToolStripMenuItem"
        Me.NotasToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.NotasToolStripMenuItem.Text = "Acta Final"
        '
        'DatosPersonalesToolStripMenuItem
        '
        Me.DatosPersonalesToolStripMenuItem.Name = "DatosPersonalesToolStripMenuItem"
        Me.DatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DatosPersonalesToolStripMenuItem.Text = "Datos Personales"
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 388
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(627, 64)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 387
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(627, 42)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 386
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(581, 64)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 385
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(581, 42)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 384
        Me.lblhora1.Text = "Hora:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 48)
        Me.GroupBox1.TabIndex = 389
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificar Nota Acta Final"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(149, 225)
        Me.txtci.Mask = "0.000.000-0"
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(73, 20)
        Me.txtci.TabIndex = 390
        Me.txtci.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'ModificarNotaActaFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(720, 392)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.txtModInasistencias)
        Me.Controls.Add(Me.txtModNota)
        Me.Controls.Add(Me.CheckBoxInasistencias)
        Me.Controls.Add(Me.CheckBoxNota)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.btnconfirmar2)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.lbllinea)
        Me.Controls.Add(Me.txtInasistencias)
        Me.Controls.Add(Me.txtnota)
        Me.Controls.Add(Me.lblInasistencias)
        Me.Controls.Add(Me.lblnota)
        Me.Controls.Add(Me.btnmodificarlinea)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.lblci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarNotaActaFinal"
        Me.Text = "ModificarNotaActaFinal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtModInasistencias As System.Windows.Forms.TextBox
    Friend WithEvents txtModNota As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxInasistencias As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxNota As System.Windows.Forms.CheckBox
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar2 As System.Windows.Forms.Button
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents lbllinea As System.Windows.Forms.Label
    Friend WithEvents txtInasistencias As System.Windows.Forms.TextBox
    Friend WithEvents txtnota As System.Windows.Forms.TextBox
    Friend WithEvents lblInasistencias As System.Windows.Forms.Label
    Friend WithEvents lblnota As System.Windows.Forms.Label
    Friend WithEvents btnmodificarlinea As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents lblci As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ActaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaDeExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarNotaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarNotaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarNotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrupoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosPersonalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtci As System.Windows.Forms.MaskedTextBox
End Class
