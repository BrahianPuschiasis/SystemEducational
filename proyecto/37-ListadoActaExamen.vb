Public Class ListadoActaExamen
    Private Sub DirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaDirector.Show()
        Me.Close()

    End Sub


    Private Sub AlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaAlumno.Show()
        Me.Close()
    End Sub

    Private Sub DocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaDocente.Show()
        Me.Close()
    End Sub

    Private Sub AsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaAsignatura.Show()
        Me.Close()
    End Sub

    Private Sub GrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ActaDeExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub ActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenuprincipal.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaPersona.Show()
        Me.Close()

    End Sub

    Private Sub ListadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListadoPersonas.Show()
        Me.Close()

    End Sub

    Private Sub ConsultasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub ListadosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListadoAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub ConsultasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ListadosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListadoGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaExamen.Show()
        Me.Close()

    End Sub


    Private Sub ConsultaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ListadoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListadoActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ConsultaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ListadoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListadoInstituto.Show()
        Me.Close()

    End Sub

    Private Sub Form38_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        ConsultaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub AltaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaActaExamenToolStripMenuItem.Click
        AltaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub AltaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaActaFinalToolStripMenuItem.Click
        AltaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub BajaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaActaExamenToolStripMenuItem.Click
        BajaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub BajaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaActaFinalToolStripMenuItem.Click
        BajaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionActaExamenToolStripMenuItem.Click
        ModActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionActaFinalToolStripMenuItem.Click
        ModActaFinal.Show()
        Me.Close()

    End Sub
End Class