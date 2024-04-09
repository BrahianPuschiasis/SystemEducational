Public Class ListadoPersonas




    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenuprincipal.Click
        MenuPrincipal.Show()
        Me.Close()
    End Sub





    Private Sub Form34_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DGVConsulta.Visible = True
        Ordenar.Visible = True

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        ConsultaPersona.Show()
        Me.Close()

    End Sub

    

    Private Sub AltaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDocenteToolStripMenuItem.Click
        AltaDocente.Show()
        Me.Close()

    End Sub

    Private Sub AltaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDirectorToolStripMenuItem.Click
        AltaDirector.Show()
        Me.Close()

    End Sub

    Private Sub AltaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaAlumnoToolStripMenuItem.Click
        AltaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub BajaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDirectorToolStripMenuItem.Click
        BajaDirector.Show()
        Me.Close()

    End Sub

    Private Sub BajaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaAlumnoToolStripMenuItem.Click
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub BajaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDocenteToolStripMenuItem.Click
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDocenteToolStripMenuItem.Click
        ModDocente.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionAlumnoToolStripMenuItem.Click
        ModAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDirectorToolStripMenuItem.Click
        ModDirector.Show()
        Me.Close()

    End Sub

   
End Class