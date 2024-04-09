Public Class BajaGrupo
    Dim activo As String
   

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


    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        conn()


        Dim nomgrupo As String
        Dim idgrupo As String
        Dim combinado As String
        Dim grado As String
        Dim orientacion As String



        sql13 = "SELECT idgrupo,grado,nombre,orientacion.orientacion  FROM grupo inner join orientacion on orientacion.idori = grupo.orientacion"
        Cmd.CommandText = sql13
        dr = Cmd.ExecuteReader()


        'cmbnomgrup.Items.Clear()

        ' While dr.Read
        ' idgrupo = dr("idgrupo")
        'nomgrupo = dr("nombre")
        ' grado = dr("grado")
        ' orientacion = dr("orientacion")
        ' combinado = idgrupo + " " + grado + "º" + orientacion + nomgrupo
        ' cmbnomgrup.Items.Add(combinado)
        '  End While
        dr.Close()





        conect.Close()

    End Sub

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()

    End Sub




 



    Private Sub ModificacionInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ConsultasInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ConsultasAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub ConsultasGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaGrupo.Show()
        Me.Close()

    End Sub

  
   
    
    Private Sub AltaGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub AltaAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub AltaGrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub txtidbaja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click

        conn()

    
        Dim resp As String
        Try
            sql = "SELECT activo from grupo where idgrupo = " & cmbnomgrup.Text & ""
            Cmd.CommandText = sql
            activo = Cmd.ExecuteScalar

        Catch

        End Try

        If activo <> "" Then
            If cmbnomgrup.Text <> "" Then
                resp = MsgBox("Se cambiará el estado del grupo  actual, su estado es " & activo & " ¿Desea cambiarlo?", MsgBoxStyle.YesNo, "DvS")
                If resp = vbYes Then
                    If activo = "Activo" Then
                        sql1 = "UPDATE grupo SET "
                        sql1 += " activo= 'No Activo'"
                        sql1 += " WHERE idgrupo=" & cmbnomgrup.Text

                        Cmd.CommandText = sql1
                        Cmd.ExecuteNonQuery()
                        Ds.Clear()
                        sql = "select grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,grupo.activo,instituto.nombre from grupo,orientacion,turno,instituto where instituto.idinst = grupo.instituto and grupo.orientacion = orientacion.idori and  grupo.anio = " & Now.Year & "  and grupo.turno=turno.idturno group by grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,grupo.activo,instituto.nombre"
                        Cmd.CommandText = sql
                        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                        da.Fill(Ds, "grupo")
                        DGVConsulta.DataSource = Ds.Tables("grupo")
                        MsgBox("Estado cambiado a No Activo", MsgBoxStyle.Information, "Aviso")
                        sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ",'" & cmbnomgrup.Text & "','Update','Estado cambiado a: No Activo','grupo', '" & fecha2 & "', '" & lblhora2.Text & "')"

                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                    Else
                        sql1 = "UPDATE grupo SET "
                        sql1 += " activo= 'Activo'"
                        sql1 += " WHERE idgrupo=" & cmbnomgrup.Text

                        Cmd.CommandText = sql1
                        Cmd.ExecuteNonQuery()
                        Ds.Clear()
                        sql = "select grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,grupo.activo,instituto.nombre from grupo,orientacion,turno,instituto where instituto.idinst = grupo.instituto and grupo.orientacion = orientacion.idori and  grupo.anio = " & Now.Year & "  and grupo.turno=turno.idturno group by grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,grupo.activo,instituto.nombre"
                        Cmd.CommandText = sql
                        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                        da.Fill(Ds, "grupo")
                        DGVConsulta.DataSource = Ds.Tables("grupo")
                        MsgBox("Estado cambiado a Activo", MsgBoxStyle.Information, "Aviso")
                        sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ",'" & cmbnomgrup.Text & "','Update','Estado cambiado a: Activo','grupo', '" & fecha2 & "', '" & lblhora2.Text & "')"

                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                    End If
                End If
            Else
                MsgBox("ERROR 15:No puede dejar campos en blanco")
            End If
        Else
            MsgBox("ERROR 21: El grupo ingresado no existe")
        End If
        conect.Close()




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

    Private Sub GrupoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaGrupo.Show()
    End Sub

    Private Sub btnGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupo.Click
        conn()
        Ds.Clear()
        GroupBox1.Visible = False
        sql = "select grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,grupo.activo,instituto.nombre from grupo,orientacion,turno,instituto where instituto.idinst = grupo.instituto and grupo.orientacion = orientacion.idori and  grupo.anio = " & Now.Year & "  and grupo.turno=turno.idturno group by grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,grupo.activo,instituto.nombre"
        Cmd.CommandText = sql
        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
        da.Fill(Ds, "grupo")
        DGVConsulta.DataSource = Ds.Tables("grupo")

        DGVConsulta.Visible = True
        lblBuscar.Visible = True
        txtBuscar.Visible = True
        lblRecordar.Visible = True
        DGVConsulta.Visible = True

        conect.Close()
    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick
        conn()
        Try
            Dim Variable As String = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
            GroupBox1.Visible = True


            cmbnomgrup.Text = Variable
            DGVConsulta.Visible = False
            activo = DGVConsulta.Item(5, DGVConsulta.CurrentRow.Index).Value

        Catch
        End Try
        lblBuscar.Visible = False
        txtBuscar.Visible = False
        lblRecordar.Visible = False
        conect.Close()
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            conn()
            Ds.Clear()
            DGVConsulta.Visible = True
            sql = "select grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,grupo.activo,instituto.nombre from grupo,orientacion,turno,instituto where instituto.idinst = grupo.instituto and grupo.orientacion = orientacion.idori and  grupo.anio = " & Now.Year & "  and grupo.turno=turno.idturno and instituto.nombre like '%" & txtBuscar.Text & "%'group by grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,grupo.activo,instituto.nombre"
            Cmd.CommandText = sql

            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "instituto")

            DGVConsulta.DataSource = Ds.Tables("instituto")

            conect.Close()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

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




    Private Sub VerificarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarToolStripMenuItem1.Click
        Verificar_Acta_Examen.Show()
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

    Private Sub IngresoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoToolStripMenuItem.Click
        AltaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub IngresoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoToolStripMenuItem1.Click
        AltaActaFinal.Show()
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

    Private Sub AltaToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem4.Click
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
End Class
