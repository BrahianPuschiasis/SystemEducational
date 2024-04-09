Public Class ConsultaAsignatura
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

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CmbConsultaListado.Show()
        Me.Close()

    End Sub

   




    Private Sub ConsultasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaGrupo.Show()
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


    Private Sub ConsultaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaInstituto.Show()
        Me.Close()

    End Sub

  
    

    Private Sub Form29_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        conn()
        Ds.Clear()
        sql = "SELECT idasig,nombre,activo from asignatura"
        Cmd.CommandText = sql
        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
        da.Fill(Ds, "asignatura")

        DGVConsulta.DataSource = Ds.Tables("asignatura")



        conect.Close()

    End Sub

    

    Private Sub ModificacionInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub BajaAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaAsignaturaToolStripMenuItem.Click
        BajaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub BajaGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaGrupoToolStripMenuItem.Click
        BajaGrupo.Show()
        Me.Close()

    End Sub

   

    Private Sub BajaInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaInstitutoToolStripMenuItem.Click
        BajaInstituto.Show()
        Me.Close()

    End Sub

    Private Sub AltaInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaInstitutoToolStripMenuItem.Click
        btnConsulta.Show()
        Me.Close()

    End Sub

    Private Sub AltaGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaGrupoToolStripMenuItem.Click
        AltaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub AltaAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaAsignaturaToolStripMenuItem.Click
        AltaAsignatura.Show()
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

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
      
        If e.KeyChar = Chr(13) Then
            conn()
            Ds.Clear()
            DGVConsulta.Visible = True
            sql = "SELECT idasig,nombre,activo from asignatura where nombre like '%" & txtBuscar.Text & "%' "
            Cmd.CommandText = sql

            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "asignatura")

            DGVConsulta.DataSource = Ds.Tables("asignatura")
            conect.Close()

        End If



    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub
End Class