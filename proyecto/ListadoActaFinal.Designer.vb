<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoActaFinal
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
        Me.Web = New System.Windows.Forms.WebBrowser
        Me.FILE = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'Web
        '
        Me.Web.Location = New System.Drawing.Point(25, 63)
        Me.Web.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web.Name = "Web"
        Me.Web.Size = New System.Drawing.Size(1052, 541)
        Me.Web.TabIndex = 0
        '
        'ListadoActaFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 650)
        Me.Controls.Add(Me.Web)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListadoActaFinal"
        Me.Text = "ListadoActaFinal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Web As System.Windows.Forms.WebBrowser
    Friend WithEvents FILE As System.Windows.Forms.SaveFileDialog
End Class
