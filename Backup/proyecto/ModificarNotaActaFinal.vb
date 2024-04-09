Public Class ModificarNotaActaFinal

    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarlinea.Click
        If lbllinea.Visible = False Then
            lbllinea.Visible = True
            lblnota.Visible = True
            txtnota.Visible = True
            lblInasistencias.Visible = True
            txtInasistencias.Visible = True
            btnconfirmar.Visible = True

        Else
            lbllinea.Visible = False
            lblnota.Visible = False
            txtnota.Visible = False
            lblInasistencias.Visible = False
            txtInasistencias.Visible = False
           
            btnconfirmar.Visible = False
        End If
    End Sub

    

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        If lblitem.Visible = False Then
            CheckBoxNota.Visible = True
            CheckBoxInasistencias.Visible = True
            lblitem.Visible = True
            btnconfirmar2.Visible = True

        Else
            CheckBoxNota.Visible = False
            CheckBoxInasistencias.Visible = False
            lblitem.Visible = False
            CheckBoxNota.Checked = False
            CheckBoxInasistencias.Checked = False
            btnconfirmar2.Visible = False
        End If
    End Sub

    Private Sub CheckBoxNota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxNota.CheckedChanged
        If txtModNota.Visible = False Then
            txtModNota.Visible = True
        Else
            txtModNota.Visible = False
        End If
    End Sub

    Private Sub CheckBoxInasistencias_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxInasistencias.CheckedChanged
        If txtModInasistencias.Visible = False Then
            txtModInasistencias.Visible = True
        Else
            txtModInasistencias.Visible = False
        End If
    End Sub
    Private Sub IngresarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarNotaToolStripMenuItem1.Click
        IngresarNotaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModificarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarNotaToolStripMenuItem1.Click
        ModificarNotaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub IngresarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarNotaToolStripMenuItem.Click
        IngreseNotaActaFinal.Show()
        Me.Close()

    End Sub

 

    Private Sub GrupoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoToolStripMenuItem1.Click
        ConsultaGrupoDocente.Show()
        Me.Close()
    End Sub

    Private Sub NotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasToolStripMenuItem.Click
        ConsultaNotaActaFinalDocente.Show()
        Me.Close()
    End Sub

    Private Sub DatosPersonalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosPersonalesToolStripMenuItem.Click
        ConsultaDatosPersonales.Show()
        Me.Close()
    End Sub

    Private Sub ModificarNotaActaFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

    End Sub
    Private Sub lblcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        MenuPrincipalDocente.Show()
        Me.Close()
    End Sub
End Class