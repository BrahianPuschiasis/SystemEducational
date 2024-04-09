<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boletin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Boletin))
        Me.logo = New System.Windows.Forms.PictureBox
        Me.lblfecha2 = New System.Windows.Forms.Label
        Me.lblhora2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblhora1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.webbrowser = New System.Windows.Forms.WebBrowser
        Me.cmbGrupo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnBoletin = New System.Windows.Forms.Button
        Me.File = New System.Windows.Forms.SaveFileDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.btnimprimirpdf = New System.Windows.Forms.Button
        Me.DGVConsulta = New System.Windows.Forms.DataGridView
        Me.txtgrupo = New System.Windows.Forms.TextBox
        Me.btnGrupoL = New System.Windows.Forms.Button
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(142, 91)
        Me.logo.TabIndex = 147
        Me.logo.TabStop = False
        '
        'lblfecha2
        '
        Me.lblfecha2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(728, 48)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha2.TabIndex = 151
        '
        'lblhora2
        '
        Me.lblhora2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora2.AutoSize = True
        Me.lblhora2.Location = New System.Drawing.Point(728, 26)
        Me.lblhora2.Name = "lblhora2"
        Me.lblhora2.Size = New System.Drawing.Size(49, 13)
        Me.lblhora2.TabIndex = 150
        Me.lblhora2.Text = "00:00:00"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(679, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Fecha:"
        '
        'lblhora1
        '
        Me.lblhora1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora1.AutoSize = True
        Me.lblhora1.Location = New System.Drawing.Point(679, 26)
        Me.lblhora1.Name = "lblhora1"
        Me.lblhora1.Size = New System.Drawing.Size(33, 13)
        Me.lblhora1.TabIndex = 148
        Me.lblhora1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'webbrowser
        '
        Me.webbrowser.Location = New System.Drawing.Point(12, 151)
        Me.webbrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webbrowser.Name = "webbrowser"
        Me.webbrowser.Size = New System.Drawing.Size(765, 580)
        Me.webbrowser.TabIndex = 400
        Me.webbrowser.Visible = False
        '
        'cmbGrupo
        '
        Me.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGrupo.FormattingEnabled = True
        Me.cmbGrupo.Location = New System.Drawing.Point(279, 122)
        Me.cmbGrupo.Name = "cmbGrupo"
        Me.cmbGrupo.Size = New System.Drawing.Size(152, 21)
        Me.cmbGrupo.TabIndex = 401
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 402
        Me.Label2.Text = "Grupo:"
        '
        'btnBoletin
        '
        Me.btnBoletin.BackgroundImage = CType(resources.GetObject("btnBoletin.BackgroundImage"), System.Drawing.Image)
        Me.btnBoletin.FlatAppearance.BorderSize = 0
        Me.btnBoletin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBoletin.Location = New System.Drawing.Point(556, 116)
        Me.btnBoletin.Name = "btnBoletin"
        Me.btnBoletin.Size = New System.Drawing.Size(122, 31)
        Me.btnBoletin.TabIndex = 407
        Me.btnBoletin.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.PrintToFile = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnimprimirpdf
        '
        Me.btnimprimirpdf.BackgroundImage = CType(resources.GetObject("btnimprimirpdf.BackgroundImage"), System.Drawing.Image)
        Me.btnimprimirpdf.FlatAppearance.BorderSize = 0
        Me.btnimprimirpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimirpdf.Location = New System.Drawing.Point(556, 737)
        Me.btnimprimirpdf.Name = "btnimprimirpdf"
        Me.btnimprimirpdf.Size = New System.Drawing.Size(121, 37)
        Me.btnimprimirpdf.TabIndex = 408
        Me.btnimprimirpdf.UseVisualStyleBackColor = True
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
        Me.DGVConsulta.Location = New System.Drawing.Point(23, 170)
        Me.DGVConsulta.MultiSelect = False
        Me.DGVConsulta.Name = "DGVConsulta"
        Me.DGVConsulta.ReadOnly = True
        Me.DGVConsulta.Size = New System.Drawing.Size(737, 485)
        Me.DGVConsulta.TabIndex = 409
        Me.DGVConsulta.Visible = False
        '
        'txtgrupo
        '
        Me.txtgrupo.Location = New System.Drawing.Point(279, 101)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(152, 20)
        Me.txtgrupo.TabIndex = 410
        '
        'btnGrupoL
        '
        Me.btnGrupoL.Location = New System.Drawing.Point(457, 100)
        Me.btnGrupoL.Name = "btnGrupoL"
        Me.btnGrupoL.Size = New System.Drawing.Size(37, 20)
        Me.btnGrupoL.TabIndex = 411
        Me.btnGrupoL.Text = "?"
        Me.btnGrupoL.UseVisualStyleBackColor = True
        '
        'Boletin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(798, 784)
        Me.Controls.Add(Me.btnGrupoL)
        Me.Controls.Add(Me.txtgrupo)
        Me.Controls.Add(Me.DGVConsulta)
        Me.Controls.Add(Me.btnimprimirpdf)
        Me.Controls.Add(Me.btnBoletin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbGrupo)
        Me.Controls.Add(Me.webbrowser)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.lblhora2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblhora1)
        Me.Controls.Add(Me.logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Boletin"
        Me.Text = "Boletin"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents lblhora2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblhora1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents webbrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents cmbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBoletin As System.Windows.Forms.Button
    Friend WithEvents File As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnimprimirpdf As System.Windows.Forms.Button
    Friend WithEvents DGVConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents txtgrupo As System.Windows.Forms.TextBox
    Friend WithEvents btnGrupoL As System.Windows.Forms.Button
End Class
