<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModActaFinal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModActaFinal))
        Me.btnconfirmar2 = New System.Windows.Forms.Button
        Me.lblitem = New System.Windows.Forms.Label
        Me.btnconfirmar = New System.Windows.Forms.Button
        Me.btnmodificarlinea = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.txtnum = New System.Windows.Forms.TextBox
        Me.lblnum = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BajaAUnaActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaExamenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificacionActaExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultasModActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaExamenToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBoxIdGrupo = New System.Windows.Forms.CheckBox
        Me.CheckBoxIdInst = New System.Windows.Forms.CheckBox
        Me.txtidinst2 = New System.Windows.Forms.TextBox
        Me.txtidgrupo2 = New System.Windows.Forms.TextBox
        Me.CheckBoxLocalidad = New System.Windows.Forms.CheckBox
        Me.txtlocalidad2 = New System.Windows.Forms.TextBox
        Me.txtlocalidad = New System.Windows.Forms.TextBox
        Me.lbllocalidad = New System.Windows.Forms.Label
        Me.txtidinst = New System.Windows.Forms.TextBox
        Me.txtidgrupo = New System.Windows.Forms.TextBox
        Me.lblidinst = New System.Windows.Forms.Label
        Me.lblidgrupo = New System.Windows.Forms.Label
        Me.txtdirector = New System.Windows.Forms.TextBox
        Me.txtsectretario = New System.Windows.Forms.TextBox
        Me.txtverifico = New System.Windows.Forms.TextBox
        Me.txtingresoalacta = New System.Windows.Forms.TextBox
        Me.txtsemestre = New System.Windows.Forms.TextBox
        Me.txtaño = New System.Windows.Forms.TextBox
        Me.lbldirector = New System.Windows.Forms.Label
        Me.lblsectretario = New System.Windows.Forms.Label
        Me.lblverifico = New System.Windows.Forms.Label
        Me.lblingresoalacta = New System.Windows.Forms.Label
        Me.lblsemestre = New System.Windows.Forms.Label
        Me.lblaño = New System.Windows.Forms.Label
        Me.txtingreso2 = New System.Windows.Forms.TextBox
        Me.CheckBoxingreso = New System.Windows.Forms.CheckBox
        Me.txtsemestre2 = New System.Windows.Forms.TextBox
        Me.CheckBoxsemestre = New System.Windows.Forms.CheckBox
        Me.CheckBoxdirector = New System.Windows.Forms.CheckBox
        Me.CheckBoxsecretario = New System.Windows.Forms.CheckBox
        Me.txtdir2 = New System.Windows.Forms.TextBox
        Me.txtsecretario2 = New System.Windows.Forms.TextBox
        Me.txtverifico2 = New System.Windows.Forms.TextBox
        Me.txtaño2 = New System.Windows.Forms.TextBox
        Me.CheckBoxverifico = New System.Windows.Forms.CheckBox
        Me.CheckBoxaño = New System.Windows.Forms.CheckBox
        Me.lbllinea = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnconfirmar2
        '
        Me.btnconfirmar2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnconfirmar2.FlatAppearance.BorderSize = 0
        Me.btnconfirmar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar2.Image = CType(resources.GetObject("btnconfirmar2.Image"), System.Drawing.Image)
        Me.btnconfirmar2.Location = New System.Drawing.Point(475, 482)
        Me.btnconfirmar2.Name = "btnconfirmar2"
        Me.btnconfirmar2.Size = New System.Drawing.Size(141, 38)
        Me.btnconfirmar2.TabIndex = 271
        Me.btnconfirmar2.UseVisualStyleBackColor = True
        Me.btnconfirmar2.Visible = False
        '
        'lblitem
        '
        Me.lblitem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblitem.AutoSize = True
        Me.lblitem.Location = New System.Drawing.Point(335, 77)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(122, 13)
        Me.lblitem.TabIndex = 265
        Me.lblitem.Text = "Modificacion de un item:"
        Me.lblitem.Visible = False
        '
        'btnconfirmar
        '
        Me.btnconfirmar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnconfirmar.FlatAppearance.BorderSize = 0
        Me.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconfirmar.Image = CType(resources.GetObject("btnconfirmar.Image"), System.Drawing.Image)
        Me.btnconfirmar.Location = New System.Drawing.Point(593, 482)
        Me.btnconfirmar.Name = "btnconfirmar"
        Me.btnconfirmar.Size = New System.Drawing.Size(143, 38)
        Me.btnconfirmar.TabIndex = 263
        Me.btnconfirmar.UseVisualStyleBackColor = True
        Me.btnconfirmar.Visible = False
        '
        'btnmodificarlinea
        '
        Me.btnmodificarlinea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnmodificarlinea.FlatAppearance.BorderSize = 0
        Me.btnmodificarlinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificarlinea.Image = CType(resources.GetObject("btnmodificarlinea.Image"), System.Drawing.Image)
        Me.btnmodificarlinea.Location = New System.Drawing.Point(227, 482)
        Me.btnmodificarlinea.Name = "btnmodificarlinea"
        Me.btnmodificarlinea.Size = New System.Drawing.Size(88, 38)
        Me.btnmodificarlinea.TabIndex = 262
        Me.btnmodificarlinea.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.Location = New System.Drawing.Point(122, 482)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(99, 38)
        Me.btnmodificar.TabIndex = 261
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'txtnum
        '
        Me.txtnum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtnum.Location = New System.Drawing.Point(141, 240)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(174, 20)
        Me.txtnum.TabIndex = 260
        '
        'lblnum
        '
        Me.lblnum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(12, 243)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(123, 13)
        Me.lblnum.TabIndex = 259
        Me.lblnum.Text = "Ingrese numero de Acta:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(294, 24)
        Me.MenuStrip1.TabIndex = 308
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaActaFinalToolStripMenuItem, Me.ActaExamenToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltaToolStripMenuItem.Text = "&Alta"
        '
        'AltaActaFinalToolStripMenuItem
        '
        Me.AltaActaFinalToolStripMenuItem.Name = "AltaActaFinalToolStripMenuItem"
        Me.AltaActaFinalToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AltaActaFinalToolStripMenuItem.Text = "Acta Final"
        '
        'ActaExamenToolStripMenuItem
        '
        Me.ActaExamenToolStripMenuItem.Name = "ActaExamenToolStripMenuItem"
        Me.ActaExamenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ActaExamenToolStripMenuItem.Text = "Acta Examen"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaAUnaActaFinalToolStripMenuItem, Me.ActaExamenToolStripMenuItem1})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.BajaToolStripMenuItem.Text = "&Baja"
        '
        'BajaAUnaActaFinalToolStripMenuItem
        '
        Me.BajaAUnaActaFinalToolStripMenuItem.Name = "BajaAUnaActaFinalToolStripMenuItem"
        Me.BajaAUnaActaFinalToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.BajaAUnaActaFinalToolStripMenuItem.Text = "Acta Final"
        '
        'ActaExamenToolStripMenuItem1
        '
        Me.ActaExamenToolStripMenuItem1.Name = "ActaExamenToolStripMenuItem1"
        Me.ActaExamenToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.ActaExamenToolStripMenuItem1.Text = "Acta Examen"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificacionActaExamenToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ModificacionToolStripMenuItem.Text = "&Modificacion"
        '
        'ModificacionActaExamenToolStripMenuItem
        '
        Me.ModificacionActaExamenToolStripMenuItem.Name = "ModificacionActaExamenToolStripMenuItem"
        Me.ModificacionActaExamenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ModificacionActaExamenToolStripMenuItem.Text = "Acta Examen"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasModActaFinalToolStripMenuItem, Me.ActaExamenToolStripMenuItem2})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'ConsultasModActaFinalToolStripMenuItem
        '
        Me.ConsultasModActaFinalToolStripMenuItem.Name = "ConsultasModActaFinalToolStripMenuItem"
        Me.ConsultasModActaFinalToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ConsultasModActaFinalToolStripMenuItem.Text = " Acta Final"
        '
        'ActaExamenToolStripMenuItem2
        '
        Me.ActaExamenToolStripMenuItem2.Name = "ActaExamenToolStripMenuItem2"
        Me.ActaExamenToolStripMenuItem2.Size = New System.Drawing.Size(142, 22)
        Me.ActaExamenToolStripMenuItem2.Text = "Acta Examen"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 43)
        Me.GroupBox1.TabIndex = 335
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificacion Acta Final"
        '
        'CheckBoxIdGrupo
        '
        Me.CheckBoxIdGrupo.AutoSize = True
        Me.CheckBoxIdGrupo.Location = New System.Drawing.Point(655, 113)
        Me.CheckBoxIdGrupo.Name = "CheckBoxIdGrupo"
        Me.CheckBoxIdGrupo.Size = New System.Drawing.Size(113, 17)
        Me.CheckBoxIdGrupo.TabIndex = 409
        Me.CheckBoxIdGrupo.Text = "Numero de Grupo:"
        Me.CheckBoxIdGrupo.UseVisualStyleBackColor = True
        Me.CheckBoxIdGrupo.Visible = False
        '
        'CheckBoxIdInst
        '
        Me.CheckBoxIdInst.AutoSize = True
        Me.CheckBoxIdInst.Location = New System.Drawing.Point(370, 111)
        Me.CheckBoxIdInst.Name = "CheckBoxIdInst"
        Me.CheckBoxIdInst.Size = New System.Drawing.Size(121, 17)
        Me.CheckBoxIdInst.TabIndex = 408
        Me.CheckBoxIdInst.Text = "Numero de Instituto:"
        Me.CheckBoxIdInst.UseVisualStyleBackColor = True
        Me.CheckBoxIdInst.Visible = False
        '
        'txtidinst2
        '
        Me.txtidinst2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtidinst2.Location = New System.Drawing.Point(498, 112)
        Me.txtidinst2.Name = "txtidinst2"
        Me.txtidinst2.Size = New System.Drawing.Size(135, 20)
        Me.txtidinst2.TabIndex = 407
        Me.txtidinst2.Visible = False
        '
        'txtidgrupo2
        '
        Me.txtidgrupo2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtidgrupo2.Location = New System.Drawing.Point(783, 112)
        Me.txtidgrupo2.Name = "txtidgrupo2"
        Me.txtidgrupo2.Size = New System.Drawing.Size(135, 20)
        Me.txtidgrupo2.TabIndex = 406
        Me.txtidgrupo2.Visible = False
        '
        'CheckBoxLocalidad
        '
        Me.CheckBoxLocalidad.AutoSize = True
        Me.CheckBoxLocalidad.Location = New System.Drawing.Point(370, 178)
        Me.CheckBoxLocalidad.Name = "CheckBoxLocalidad"
        Me.CheckBoxLocalidad.Size = New System.Drawing.Size(75, 17)
        Me.CheckBoxLocalidad.TabIndex = 405
        Me.CheckBoxLocalidad.Text = "Localidad:"
        Me.CheckBoxLocalidad.UseVisualStyleBackColor = True
        Me.CheckBoxLocalidad.Visible = False
        '
        'txtlocalidad2
        '
        Me.txtlocalidad2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtlocalidad2.Location = New System.Drawing.Point(498, 176)
        Me.txtlocalidad2.Name = "txtlocalidad2"
        Me.txtlocalidad2.Size = New System.Drawing.Size(135, 20)
        Me.txtlocalidad2.TabIndex = 404
        Me.txtlocalidad2.Visible = False
        '
        'txtlocalidad
        '
        Me.txtlocalidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtlocalidad.Location = New System.Drawing.Point(498, 379)
        Me.txtlocalidad.Name = "txtlocalidad"
        Me.txtlocalidad.Size = New System.Drawing.Size(134, 20)
        Me.txtlocalidad.TabIndex = 403
        Me.txtlocalidad.Visible = False
        '
        'lbllocalidad
        '
        Me.lbllocalidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbllocalidad.AutoSize = True
        Me.lbllocalidad.Location = New System.Drawing.Point(367, 382)
        Me.lbllocalidad.Name = "lbllocalidad"
        Me.lbllocalidad.Size = New System.Drawing.Size(56, 13)
        Me.lbllocalidad.TabIndex = 402
        Me.lbllocalidad.Text = "Localidad:"
        Me.lbllocalidad.Visible = False
        '
        'txtidinst
        '
        Me.txtidinst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtidinst.Location = New System.Drawing.Point(498, 319)
        Me.txtidinst.Name = "txtidinst"
        Me.txtidinst.Size = New System.Drawing.Size(135, 20)
        Me.txtidinst.TabIndex = 401
        Me.txtidinst.Visible = False
        '
        'txtidgrupo
        '
        Me.txtidgrupo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtidgrupo.Location = New System.Drawing.Point(783, 319)
        Me.txtidgrupo.Name = "txtidgrupo"
        Me.txtidgrupo.Size = New System.Drawing.Size(135, 20)
        Me.txtidgrupo.TabIndex = 400
        Me.txtidgrupo.Visible = False
        '
        'lblidinst
        '
        Me.lblidinst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblidinst.AutoSize = True
        Me.lblidinst.Location = New System.Drawing.Point(367, 322)
        Me.lblidinst.Name = "lblidinst"
        Me.lblidinst.Size = New System.Drawing.Size(102, 13)
        Me.lblidinst.TabIndex = 399
        Me.lblidinst.Text = "Numero de Instituto:"
        Me.lblidinst.Visible = False
        '
        'lblidgrupo
        '
        Me.lblidgrupo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblidgrupo.AutoSize = True
        Me.lblidgrupo.Location = New System.Drawing.Point(654, 322)
        Me.lblidgrupo.Name = "lblidgrupo"
        Me.lblidgrupo.Size = New System.Drawing.Size(94, 13)
        Me.lblidgrupo.TabIndex = 398
        Me.lblidgrupo.Text = "Numero de Grupo:"
        Me.lblidgrupo.Visible = False
        '
        'txtdirector
        '
        Me.txtdirector.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdirector.Location = New System.Drawing.Point(498, 441)
        Me.txtdirector.Name = "txtdirector"
        Me.txtdirector.Size = New System.Drawing.Size(135, 20)
        Me.txtdirector.TabIndex = 397
        Me.txtdirector.Visible = False
        '
        'txtsectretario
        '
        Me.txtsectretario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsectretario.Location = New System.Drawing.Point(783, 410)
        Me.txtsectretario.Name = "txtsectretario"
        Me.txtsectretario.Size = New System.Drawing.Size(137, 20)
        Me.txtsectretario.TabIndex = 396
        Me.txtsectretario.Visible = False
        '
        'txtverifico
        '
        Me.txtverifico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtverifico.Location = New System.Drawing.Point(498, 410)
        Me.txtverifico.Name = "txtverifico"
        Me.txtverifico.Size = New System.Drawing.Size(135, 20)
        Me.txtverifico.TabIndex = 395
        Me.txtverifico.Visible = False
        '
        'txtingresoalacta
        '
        Me.txtingresoalacta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtingresoalacta.Location = New System.Drawing.Point(783, 379)
        Me.txtingresoalacta.Name = "txtingresoalacta"
        Me.txtingresoalacta.Size = New System.Drawing.Size(137, 20)
        Me.txtingresoalacta.TabIndex = 394
        Me.txtingresoalacta.Visible = False
        '
        'txtsemestre
        '
        Me.txtsemestre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsemestre.Location = New System.Drawing.Point(783, 350)
        Me.txtsemestre.Name = "txtsemestre"
        Me.txtsemestre.Size = New System.Drawing.Size(137, 20)
        Me.txtsemestre.TabIndex = 393
        Me.txtsemestre.Visible = False
        '
        'txtaño
        '
        Me.txtaño.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtaño.Location = New System.Drawing.Point(498, 352)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(134, 20)
        Me.txtaño.TabIndex = 392
        Me.txtaño.Visible = False
        '
        'lbldirector
        '
        Me.lbldirector.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbldirector.AutoSize = True
        Me.lbldirector.Location = New System.Drawing.Point(368, 444)
        Me.lbldirector.Name = "lbldirector"
        Me.lbldirector.Size = New System.Drawing.Size(47, 13)
        Me.lbldirector.TabIndex = 391
        Me.lbldirector.Text = "Director:"
        Me.lbldirector.Visible = False
        '
        'lblsectretario
        '
        Me.lblsectretario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsectretario.AutoSize = True
        Me.lblsectretario.Location = New System.Drawing.Point(654, 413)
        Me.lblsectretario.Name = "lblsectretario"
        Me.lblsectretario.Size = New System.Drawing.Size(58, 13)
        Me.lblsectretario.TabIndex = 390
        Me.lblsectretario.Text = "Secretario:"
        Me.lblsectretario.Visible = False
        '
        'lblverifico
        '
        Me.lblverifico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblverifico.AutoSize = True
        Me.lblverifico.Location = New System.Drawing.Point(368, 413)
        Me.lblverifico.Name = "lblverifico"
        Me.lblverifico.Size = New System.Drawing.Size(45, 13)
        Me.lblverifico.TabIndex = 389
        Me.lblverifico.Text = "Verifico:"
        Me.lblverifico.Visible = False
        '
        'lblingresoalacta
        '
        Me.lblingresoalacta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblingresoalacta.AutoSize = True
        Me.lblingresoalacta.Location = New System.Drawing.Point(654, 382)
        Me.lblingresoalacta.Name = "lblingresoalacta"
        Me.lblingresoalacta.Size = New System.Drawing.Size(82, 13)
        Me.lblingresoalacta.TabIndex = 388
        Me.lblingresoalacta.Text = "Ingreso Al Acta:"
        Me.lblingresoalacta.Visible = False
        '
        'lblsemestre
        '
        Me.lblsemestre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblsemestre.AutoSize = True
        Me.lblsemestre.Location = New System.Drawing.Point(654, 353)
        Me.lblsemestre.Name = "lblsemestre"
        Me.lblsemestre.Size = New System.Drawing.Size(54, 13)
        Me.lblsemestre.TabIndex = 387
        Me.lblsemestre.Text = "Semestre:"
        Me.lblsemestre.Visible = False
        '
        'lblaño
        '
        Me.lblaño.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblaño.AutoSize = True
        Me.lblaño.Location = New System.Drawing.Point(367, 355)
        Me.lblaño.Name = "lblaño"
        Me.lblaño.Size = New System.Drawing.Size(29, 13)
        Me.lblaño.TabIndex = 386
        Me.lblaño.Text = "Año:"
        Me.lblaño.Visible = False
        '
        'txtingreso2
        '
        Me.txtingreso2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtingreso2.Location = New System.Drawing.Point(785, 177)
        Me.txtingreso2.Name = "txtingreso2"
        Me.txtingreso2.Size = New System.Drawing.Size(133, 20)
        Me.txtingreso2.TabIndex = 385
        Me.txtingreso2.Visible = False
        '
        'CheckBoxingreso
        '
        Me.CheckBoxingreso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxingreso.AutoSize = True
        Me.CheckBoxingreso.Location = New System.Drawing.Point(655, 176)
        Me.CheckBoxingreso.Name = "CheckBoxingreso"
        Me.CheckBoxingreso.Size = New System.Drawing.Size(101, 17)
        Me.CheckBoxingreso.TabIndex = 384
        Me.CheckBoxingreso.Text = "Ingreso Al Acta:"
        Me.CheckBoxingreso.UseVisualStyleBackColor = True
        Me.CheckBoxingreso.Visible = False
        '
        'txtsemestre2
        '
        Me.txtsemestre2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsemestre2.Location = New System.Drawing.Point(783, 146)
        Me.txtsemestre2.Name = "txtsemestre2"
        Me.txtsemestre2.Size = New System.Drawing.Size(135, 20)
        Me.txtsemestre2.TabIndex = 383
        Me.txtsemestre2.Visible = False
        '
        'CheckBoxsemestre
        '
        Me.CheckBoxsemestre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxsemestre.AutoSize = True
        Me.CheckBoxsemestre.Location = New System.Drawing.Point(655, 145)
        Me.CheckBoxsemestre.Name = "CheckBoxsemestre"
        Me.CheckBoxsemestre.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxsemestre.TabIndex = 382
        Me.CheckBoxsemestre.Text = "Semestre:"
        Me.CheckBoxsemestre.UseVisualStyleBackColor = True
        Me.CheckBoxsemestre.Visible = False
        '
        'CheckBoxdirector
        '
        Me.CheckBoxdirector.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxdirector.AutoSize = True
        Me.CheckBoxdirector.Location = New System.Drawing.Point(370, 243)
        Me.CheckBoxdirector.Name = "CheckBoxdirector"
        Me.CheckBoxdirector.Size = New System.Drawing.Size(66, 17)
        Me.CheckBoxdirector.TabIndex = 381
        Me.CheckBoxdirector.Text = "Director:"
        Me.CheckBoxdirector.UseVisualStyleBackColor = True
        Me.CheckBoxdirector.Visible = False
        '
        'CheckBoxsecretario
        '
        Me.CheckBoxsecretario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxsecretario.AutoSize = True
        Me.CheckBoxsecretario.Location = New System.Drawing.Point(657, 217)
        Me.CheckBoxsecretario.Name = "CheckBoxsecretario"
        Me.CheckBoxsecretario.Size = New System.Drawing.Size(77, 17)
        Me.CheckBoxsecretario.TabIndex = 380
        Me.CheckBoxsecretario.Text = "Secretario:"
        Me.CheckBoxsecretario.UseVisualStyleBackColor = True
        Me.CheckBoxsecretario.Visible = False
        '
        'txtdir2
        '
        Me.txtdir2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdir2.Location = New System.Drawing.Point(498, 244)
        Me.txtdir2.Name = "txtdir2"
        Me.txtdir2.Size = New System.Drawing.Size(135, 20)
        Me.txtdir2.TabIndex = 379
        Me.txtdir2.Visible = False
        '
        'txtsecretario2
        '
        Me.txtsecretario2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsecretario2.Location = New System.Drawing.Point(785, 215)
        Me.txtsecretario2.Name = "txtsecretario2"
        Me.txtsecretario2.Size = New System.Drawing.Size(135, 20)
        Me.txtsecretario2.TabIndex = 378
        Me.txtsecretario2.Visible = False
        '
        'txtverifico2
        '
        Me.txtverifico2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtverifico2.Location = New System.Drawing.Point(498, 213)
        Me.txtverifico2.Name = "txtverifico2"
        Me.txtverifico2.Size = New System.Drawing.Size(135, 20)
        Me.txtverifico2.TabIndex = 377
        Me.txtverifico2.Visible = False
        '
        'txtaño2
        '
        Me.txtaño2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtaño2.Location = New System.Drawing.Point(498, 146)
        Me.txtaño2.Name = "txtaño2"
        Me.txtaño2.Size = New System.Drawing.Size(135, 20)
        Me.txtaño2.TabIndex = 376
        Me.txtaño2.Visible = False
        '
        'CheckBoxverifico
        '
        Me.CheckBoxverifico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxverifico.AutoSize = True
        Me.CheckBoxverifico.Location = New System.Drawing.Point(370, 217)
        Me.CheckBoxverifico.Name = "CheckBoxverifico"
        Me.CheckBoxverifico.Size = New System.Drawing.Size(64, 17)
        Me.CheckBoxverifico.TabIndex = 375
        Me.CheckBoxverifico.Text = "Verifico:"
        Me.CheckBoxverifico.UseVisualStyleBackColor = True
        Me.CheckBoxverifico.Visible = False
        '
        'CheckBoxaño
        '
        Me.CheckBoxaño.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxaño.AutoSize = True
        Me.CheckBoxaño.Location = New System.Drawing.Point(370, 145)
        Me.CheckBoxaño.Name = "CheckBoxaño"
        Me.CheckBoxaño.Size = New System.Drawing.Size(48, 17)
        Me.CheckBoxaño.TabIndex = 374
        Me.CheckBoxaño.Text = "Año:"
        Me.CheckBoxaño.UseVisualStyleBackColor = True
        Me.CheckBoxaño.Visible = False
        '
        'lbllinea
        '
        Me.lbllinea.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbllinea.AutoSize = True
        Me.lbllinea.Location = New System.Drawing.Point(333, 294)
        Me.lbllinea.Name = "lbllinea"
        Me.lbllinea.Size = New System.Drawing.Size(110, 13)
        Me.lbllinea.TabIndex = 373
        Me.lbllinea.Text = "Modificacion de linea:"
        Me.lbllinea.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 91)
        Me.PictureBox1.TabIndex = 415
        Me.PictureBox1.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(844, 64)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 414
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(844, 42)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 413
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(798, 64)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 412
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora
        '
        Me.lblhora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora.AutoSize = True
        Me.lblhora.Location = New System.Drawing.Point(798, 42)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(33, 13)
        Me.lblhora.TabIndex = 411
        Me.lblhora.Text = "Hora:"
        '
        'ModActaFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(937, 542)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.CheckBoxIdGrupo)
        Me.Controls.Add(Me.CheckBoxIdInst)
        Me.Controls.Add(Me.txtidinst2)
        Me.Controls.Add(Me.txtidgrupo2)
        Me.Controls.Add(Me.CheckBoxLocalidad)
        Me.Controls.Add(Me.txtlocalidad2)
        Me.Controls.Add(Me.txtlocalidad)
        Me.Controls.Add(Me.lbllocalidad)
        Me.Controls.Add(Me.txtidinst)
        Me.Controls.Add(Me.txtidgrupo)
        Me.Controls.Add(Me.lblidinst)
        Me.Controls.Add(Me.lblidgrupo)
        Me.Controls.Add(Me.txtdirector)
        Me.Controls.Add(Me.txtsectretario)
        Me.Controls.Add(Me.txtverifico)
        Me.Controls.Add(Me.txtingresoalacta)
        Me.Controls.Add(Me.txtsemestre)
        Me.Controls.Add(Me.txtaño)
        Me.Controls.Add(Me.lbldirector)
        Me.Controls.Add(Me.lblsectretario)
        Me.Controls.Add(Me.lblverifico)
        Me.Controls.Add(Me.lblingresoalacta)
        Me.Controls.Add(Me.lblsemestre)
        Me.Controls.Add(Me.lblaño)
        Me.Controls.Add(Me.txtingreso2)
        Me.Controls.Add(Me.CheckBoxingreso)
        Me.Controls.Add(Me.txtsemestre2)
        Me.Controls.Add(Me.CheckBoxsemestre)
        Me.Controls.Add(Me.CheckBoxdirector)
        Me.Controls.Add(Me.CheckBoxsecretario)
        Me.Controls.Add(Me.txtdir2)
        Me.Controls.Add(Me.txtsecretario2)
        Me.Controls.Add(Me.txtverifico2)
        Me.Controls.Add(Me.txtaño2)
        Me.Controls.Add(Me.CheckBoxverifico)
        Me.Controls.Add(Me.CheckBoxaño)
        Me.Controls.Add(Me.lbllinea)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnconfirmar2)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.btnconfirmar)
        Me.Controls.Add(Me.btnmodificarlinea)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.lblnum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModActaFinal"
        Me.Text = "Modificaciones de Acta Final"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnconfirmar2 As System.Windows.Forms.Button
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents btnconfirmar As System.Windows.Forms.Button
    Friend WithEvents btnmodificarlinea As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents txtnum As System.Windows.Forms.TextBox
    Friend WithEvents lblnum As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AltaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaAUnaActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasModActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificacionActaExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaExamenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaExamenToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxIdGrupo As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxIdInst As System.Windows.Forms.CheckBox
    Friend WithEvents txtidinst2 As System.Windows.Forms.TextBox
    Friend WithEvents txtidgrupo2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxLocalidad As System.Windows.Forms.CheckBox
    Friend WithEvents txtlocalidad2 As System.Windows.Forms.TextBox
    Friend WithEvents txtlocalidad As System.Windows.Forms.TextBox
    Friend WithEvents lbllocalidad As System.Windows.Forms.Label
    Friend WithEvents txtidinst As System.Windows.Forms.TextBox
    Friend WithEvents txtidgrupo As System.Windows.Forms.TextBox
    Friend WithEvents lblidinst As System.Windows.Forms.Label
    Friend WithEvents lblidgrupo As System.Windows.Forms.Label
    Friend WithEvents txtdirector As System.Windows.Forms.TextBox
    Friend WithEvents txtsectretario As System.Windows.Forms.TextBox
    Friend WithEvents txtverifico As System.Windows.Forms.TextBox
    Friend WithEvents txtingresoalacta As System.Windows.Forms.TextBox
    Friend WithEvents txtsemestre As System.Windows.Forms.TextBox
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents lbldirector As System.Windows.Forms.Label
    Friend WithEvents lblsectretario As System.Windows.Forms.Label
    Friend WithEvents lblverifico As System.Windows.Forms.Label
    Friend WithEvents lblingresoalacta As System.Windows.Forms.Label
    Friend WithEvents lblsemestre As System.Windows.Forms.Label
    Friend WithEvents lblaño As System.Windows.Forms.Label
    Friend WithEvents txtingreso2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxingreso As System.Windows.Forms.CheckBox
    Friend WithEvents txtsemestre2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxsemestre As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxdirector As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxsecretario As System.Windows.Forms.CheckBox
    Friend WithEvents txtdir2 As System.Windows.Forms.TextBox
    Friend WithEvents txtsecretario2 As System.Windows.Forms.TextBox
    Friend WithEvents txtverifico2 As System.Windows.Forms.TextBox
    Friend WithEvents txtaño2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxverifico As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxaño As System.Windows.Forms.CheckBox
    Friend WithEvents lbllinea As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
End Class
