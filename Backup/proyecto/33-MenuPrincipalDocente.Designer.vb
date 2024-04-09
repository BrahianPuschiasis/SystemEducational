<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipalDocente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipalDocente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ActaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaDeExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActaFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExamenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.DatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btndcerrarsesion = New System.Windows.Forms.Button
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnConfiguracion = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActaToolStripMenuItem, Me.ExamenesToolStripMenuItem, Me.ConsultaToolStripMenuItem3})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(223, 25)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ActaToolStripMenuItem
        '
        Me.ActaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActaDeExamenToolStripMenuItem, Me.ActaFinalToolStripMenuItem, Me.NotasToolStripMenuItem})
        Me.ActaToolStripMenuItem.Name = "ActaToolStripMenuItem"
        Me.ActaToolStripMenuItem.Size = New System.Drawing.Size(74, 19)
        Me.ActaToolStripMenuItem.Text = "Reuniones"
        '
        'ActaDeExamenToolStripMenuItem
        '
        Me.ActaDeExamenToolStripMenuItem.Name = "ActaDeExamenToolStripMenuItem"
        Me.ActaDeExamenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActaDeExamenToolStripMenuItem.Text = "Ingresar"
        '
        'ActaFinalToolStripMenuItem
        '
        Me.ActaFinalToolStripMenuItem.Name = "ActaFinalToolStripMenuItem"
        Me.ActaFinalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActaFinalToolStripMenuItem.Text = "Verificar"
        '
        'NotasToolStripMenuItem
        '
        Me.NotasToolStripMenuItem.Name = "NotasToolStripMenuItem"
        Me.NotasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NotasToolStripMenuItem.Text = "Notas"
        '
        'ExamenesToolStripMenuItem
        '
        Me.ExamenesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem, Me.VerificarToolStripMenuItem, Me.NotasToolStripMenuItem1})
        Me.ExamenesToolStripMenuItem.Name = "ExamenesToolStripMenuItem"
        Me.ExamenesToolStripMenuItem.Size = New System.Drawing.Size(71, 19)
        Me.ExamenesToolStripMenuItem.Text = "Examenes"
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IngresarToolStripMenuItem.Text = "Ingresar"
        '
        'VerificarToolStripMenuItem
        '
        Me.VerificarToolStripMenuItem.Name = "VerificarToolStripMenuItem"
        Me.VerificarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerificarToolStripMenuItem.Text = "Verificar"
        '
        'NotasToolStripMenuItem1
        '
        Me.NotasToolStripMenuItem1.Name = "NotasToolStripMenuItem1"
        Me.NotasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NotasToolStripMenuItem1.Text = "Notas"
        '
        'ConsultaToolStripMenuItem3
        '
        Me.ConsultaToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosPersonalesToolStripMenuItem})
        Me.ConsultaToolStripMenuItem3.Name = "ConsultaToolStripMenuItem3"
        Me.ConsultaToolStripMenuItem3.Size = New System.Drawing.Size(66, 19)
        Me.ConsultaToolStripMenuItem3.Text = "Consulta"
        '
        'DatosPersonalesToolStripMenuItem
        '
        Me.DatosPersonalesToolStripMenuItem.Name = "DatosPersonalesToolStripMenuItem"
        Me.DatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.DatosPersonalesToolStripMenuItem.Text = "Datos Personales"
        '
        'btndcerrarsesion
        '
        Me.btndcerrarsesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btndcerrarsesion.FlatAppearance.BorderSize = 0
        Me.btndcerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndcerrarsesion.Image = CType(resources.GetObject("btndcerrarsesion.Image"), System.Drawing.Image)
        Me.btndcerrarsesion.Location = New System.Drawing.Point(12, 176)
        Me.btndcerrarsesion.Name = "btndcerrarsesion"
        Me.btndcerrarsesion.Size = New System.Drawing.Size(117, 41)
        Me.btndcerrarsesion.TabIndex = 9
        Me.btndcerrarsesion.UseVisualStyleBackColor = True
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 31
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(441, 71)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 30
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(441, 49)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 29
        Me.lblhora2.Text = "00:00:00"
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(395, 71)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(40, 13)
        Me.lblfecha.TabIndex = 28
        Me.lblfecha.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(395, 49)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 27
        Me.lblhora1.Text = "Hora:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Location = New System.Drawing.Point(109, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 44)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Principal Docente"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConfiguracion.FlatAppearance.BorderSize = 0
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.Image = CType(resources.GetObject("btnConfiguracion.Image"), System.Drawing.Image)
        Me.btnConfiguracion.Location = New System.Drawing.Point(206, 180)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(121, 32)
        Me.btnConfiguracion.TabIndex = 33
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.Location = New System.Drawing.Point(413, 176)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(95, 41)
        Me.btnsalir.TabIndex = 8
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'MenuPrincipalDocente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(520, 220)
        Me.Controls.Add(Me.btnConfiguracion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.btndcerrarsesion)
        Me.Controls.Add(Me.btnsalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "MenuPrincipalDocente"
        Me.Text = "MenuPrincipalDocente"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConsultaToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosPersonalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btndcerrarsesion As System.Windows.Forms.Button
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnConfiguracion As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents ActaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaDeExamenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActaFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
