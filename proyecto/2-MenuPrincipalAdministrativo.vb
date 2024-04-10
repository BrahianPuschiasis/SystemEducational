Public Class MenuPrincipalAdministrativo








    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CmbConsultaListado.Show()
        Me.Close()

    End Sub



    Private Sub ConsultasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaAsignatura.Show()
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



    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Dim Resp As String
        Resp = MsgBox("¿Desea salir?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
            Ingreso.Close()

        End If
    End Sub

    Private Sub Form02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        docentev = 1
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

    End Sub

    Private Sub AltaToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnConsulta.Show()
        Me.Close()

    End Sub

    Private Sub BajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub AltasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub BajasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAlumno.Show()
        Me.Close()

    End Sub

    Private Sub AltasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaDocente.Show()
        Me.Close()

    End Sub

    Private Sub BajasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub ModificacoinesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModDocente.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem.Click
        AltaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem.Click
        BajaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem1.Click
        AltaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem1.Click
        BajaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModGrupo.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModActaExamen.Show()
        Me.Close()
    End Sub
    Private Sub AltaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem4.Click
        BajaInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModDocente.Show()
        Me.Close()

    End Sub



    Private Sub DocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaDocente.Show()
        Me.Close()

    End Sub

    Private Sub AlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub AdministrativoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub DocenteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub AlumnoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub AdministrativoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub DocenteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModDocente.Show()

        Me.Close()

    End Sub

    Private Sub AlumnoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAlumno.Show()
        Me.Close()

    End Sub

    Private Sub AdministrativoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub PerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerToolStripMenuItem.Click
        CmbConsultaListado.Show()
        Me.Close()

    End Sub

    Private Sub AsignaturaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignaturaToolStripMenuItem1.Click
        ConsultaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub GrupoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoToolStripMenuItem1.Click
        ConsultaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub FinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub InstitutoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstitutoToolStripMenuItem1.Click
        ConsultaInstituto.Show()
        Me.Close()

    End Sub

    Private Sub btndcerrarsesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndcerrarsesion.Click



        conect.Close()
        conect2.Close()

        Ingreso.Close()

        Ingreso.Show()

        Me.Close()
    End Sub

   
    Private Sub IngresoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoToolStripMenuItem.Click
        AltaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub IngresoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoToolStripMenuItem1.Click
        AltaActaFinal.Show()
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

    Private Sub lblcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

  

 
    Private Sub ActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaFinalToolStripMenuItem.Click
        ConsultaActaFinal.Show()
        Me.Close()


    End Sub

    Private Sub VerificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarToolStripMenuItem.Click
        VerificarActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click

    End Sub

    Private Sub VerificarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarToolStripMenuItem1.Click
        Verificar_Acta_Examen.Show()
        Me.Close()

    End Sub

    Private Sub btnConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    
    End Sub

    Private Sub btnConfiguracion_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguracion.Click
        PrimerLogin.Show()
        Me.Close()
    End Sub

    Private Sub ModificacionToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionToolStripMenuItem5.Click
        AltaDocente.Show()
        Me.Close()

    End Sub

    Private Sub ProgramasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramasToolStripMenuItem.Click
        programa.Show()
        Me.Close()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        ModificarInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaExamenToolStripMenuItem.Click
        ConsultaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem5.Click
        AltaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub OrientacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrientacionToolStripMenuItem.Click
        AltaOrientacion.Show()
        Me.Close()

    End Sub

    Private Sub TipoDeCursoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeCursoToolStripMenuItem.Click
        Altatcurso.Show()
        Me.Close()

    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Altalocacion.Show()
        Me.Close()

    End Sub

    Private Sub NotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasToolStripMenuItem.Click
        IngreseNotaActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub NotasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasToolStripMenuItem1.Click
        IngresarNotaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialToolStripMenuItem.Click
        historial.Show()
        Me.Close()

    End Sub

    Private Sub PersonasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonasToolStripMenuItem.Click

    End Sub


    Private Sub AltaToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem2.Click
        btnConsulta.Show()
        Me.Close()
    End Sub

    Private Sub BoletinesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletinesToolStripMenuItem.Click
        juan = 5
        Boletin.Show()
        juan = 5

        Me.Close()


    End Sub
End Class