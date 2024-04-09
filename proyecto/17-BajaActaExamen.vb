Public Class BajaActaExamen
    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub DirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaAdministrativo.Show()
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

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        conn()

        sql = "SELECT n_actae FROM actae"
        Cmd.CommandText = sql
        dr = Cmd.ExecuteReader

        cmbnunacta.Items.Clear()
        While dr.Read
            cmbnunacta.Items.Add(dr("n_actae"))
        End While

        conect.Close()
    End Sub

    Private Sub AltaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaActaExamenToolStripMenuItem.Click
        AltaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub AltaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaActaFinalToolStripMenuItem.Click
        AltaActaFinal.Show()
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

    Private Sub ConsultaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaActaExamenToolStripMenuItem.Click
        ConsultaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ConsultaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaActaFinalToolStripMenuItem.Click
        ConsultaActaFinal.Show()
        Me.Close()

    End Sub

  

    Private Sub txtbajanumacta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        conn()

        If cmbnunacta.Text <> "" Then
            sql = "UPDATE actae SET "
            sql += "estado= '" & "incorrecto" & "',"
            sql += " WHERE n_actae=" & cmbnunacta.Text

            Cmd.CommandText = sql
            Cmd.ExecuteNonQuery()
            sql = "SELECT n_actae FROM actae"
            Cmd.CommandText = sql
            dr = Cmd.ExecuteReader

            cmbnunacta.Items.Clear()
            While dr.Read
                cmbnunacta.Items.Add(dr("n_actae"))
            End While

            conect.Close()

            MsgBox("Los Datos han sido hactualizado", MsgBoxStyle.Information, "Aviso")

        Else
            MsgBox("No ha elegido ninguna asignatura", MsgBoxStyle.Information, "Aviso")
        End If

    End Sub
    Private Sub lblcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

   
    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub
End Class