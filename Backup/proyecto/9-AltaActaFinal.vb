Imports System.Data.Odbc

Public Class AltaActaFinal

    Inherits System.Windows.Forms.Form
    Dim idgrupo As Integer = 0
    Dim idinst As Integer = 0

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub ActaDeExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaExamen.Show()
        Me.Close()

    End Sub





    Private Sub AltaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub BajaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub BajaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        conn()


        Dim cmd2 As New Odbc.OdbcCommand

        cmd2.Connection = conect

        Dim juan As Integer
            Dim fecha As String
            Dim carac As String

        Dim año As Integer

        Try
            año = Now.Year
            sql2 = "Select count(*) from actaf "

            Cmd.CommandText = sql2
            Cmd.ExecuteScalar()
            contador = Cmd.ExecuteScalar
            autonumerico = contador + 1

            sql = "SELECT instituto from grupo where idgrupo =  " & cmbgrupo.Text & ""
            Cmd.CommandText = sql
            idinst = Cmd.ExecuteScalar


            sql2 = "SELECT idgrupo from actaf where idgrupo= " & cmbgrupo.Text & " and anio= " & Now.Year & " and estado='Abierta' or estado='Cerrada'"
            Cmd.CommandText = sql2

            juan = Cmd.ExecuteScalar
        Catch
        End Try
        If cmbgrupo.Text <> "" Then



            If cmbgrupo.Text = juan Then
                MsgBox("ERROR 24: Ya se abrió el acta para el grupo ingresado")
                conect.Close()
            Else

                carac = "%d/%m/%Y"
                fecha = "to_date('" & txtfechanacadmin.Text & "', '" & carac & "') "

                sql5 = "INSERT INTO actaf(n_Actaf,fecha,idgrupo,anio,semestre,ingreso_al_acta,verifico,secretario,director,instituto,estado) VALUES(" & autonumerico & "," & fecha & "," & cmbgrupo.Text & "," & año & "," & 2 & ",null,null,null,null," & idinst & ",'Abierta')"



                Cmd.CommandText = sql5
                Try
                    Cmd.ExecuteNonQuery()





                    sql = "SELECT concurren.ci,dictan.idasig from concurren,dictan,asignatura,grupo where concurren.idgrupo = " & cmbgrupo.Text & " and concurren.aniocursado = " & Now.Year & " and concurren.aniocursado=dictan.aniodictado and concurren.activo='Activo' and dictan.activo='Activo' and asignatura.idasig = dictan.idasig and grupo.idgrupo=dictan.idgrupo and grupo.idgrupo = " & cmbgrupo.Text & " and grupo.activo='Activo' group by concurren.ci,dictan.idasig"
                    cmd2.CommandText = sql

                    dr = cmd2.ExecuteReader()

                    Dim cedula As Integer
                    Dim materia As Integer



                    While dr.Read



                        materia = (dr("idasig"))
                        cedula = (dr("ci"))












                        sql = "INSERT INTO cursan(n_actaf,ci,idasig,nota,inasistencias,fallo) VALUES (" & autonumerico & ", " & cedula & ", " & materia & ",null,null,null)"
                        Cmd.CommandText = sql
                        Try

                            Cmd.ExecuteNonQuery()



                        Catch


                        End Try
                    End While












                    sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ",'" & autonumerico & "','Insertar','Se creó el acta final y las planillas de los alumnos','actaf', " & fecha2 & ", '" & lblhora2.Text & "')"

                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()

                    MsgBox("Los Datos han sido ingresados", MsgBoxStyle.Information, "Aviso")
                Catch

                    MsgBox("ERROR 28:No puede dejar la fecha en blanco")

                End Try
            End If

        Else
            MsgBox("ERROR 29:No se puede dejar el código de grupo en blanco")
        End If

        Try
            dr.Close()
        Catch
        End Try
        conect.Close()


    End Sub

    Private Sub AltaActaFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim var As Form
        var = Me
        var.Size = New Size(800, 500)
        If docentev = 5 Then
            GroupBox1.Visible = False

        Else
            GroupBox1.Visible = True
        End If
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        btnGrupo.Enabled = True
        lblidgrupo.Enabled = True

        conn()


        '-----------------------

    

      






        







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
        If docentev = 5 Then
            MenuPrincipalDocente.Show()
            Me.Close()
        Else



            MenuPrincipalAdministrativo.Show()
            Me.Close()
        End If
    End Sub

    Private Sub cmbinst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        conn()

        Dim nomgrupo As String
        Dim idgrupo As String
        Dim combinado As String
        Dim grado As String
        Dim orientacion As String




        sql13 = "SELECT idgrupo,grado,nombre,orientacion.orientacion  FROM grupo inner join orientacion on orientacion.idori = grupo.orientacion where  grupo.anio = " & Now.Year & ""
        Cmd.CommandText = sql13
        dr = Cmd.ExecuteReader()





        cmbgrupo.Enabled = True
        lblidgrupo.Enabled = True
        conect.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub btnGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupo.Click
        conn()

        GroupBox1.Visible = False
        Ds.Clear()
        DGVConsulta.Visible = True
        txtBuscar.Visible = True
        lblRecordar.Visible = True
        lblBuscar.Visible = True
        Label3.Visible = False
        txtfechanacadmin.Visible = False
    
        sql = "select grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,instituto.nombre from grupo,orientacion,turno,instituto where instituto.idinst = grupo.instituto and grupo.orientacion = orientacion.idori and  grupo.anio = " & Now.Year & " and grupo.activo = 'Activo' and grupo.turno=turno.idturno  group by  grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,instituto.nombre "
        Cmd.CommandText = sql
        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
        da.Fill(Ds, "grupo")
        DGVConsulta.DataSource = Ds.Tables("grupo")



        conect.Close()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress

        If e.KeyChar = Chr(13) Then



            conn()
            Ds.Clear()
            DGVConsulta.Visible = True
            sql = "select grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,instituto.nombre from grupo,orientacion,turno,instituto where instituto.nombre like '%" & txtBuscar.Text & "%'and instituto.idinst = grupo.instituto and grupo.orientacion = orientacion.idori and  grupo.anio = " & Now.Year & " and grupo.activo = 'Activo' and grupo.turno=turno.idturno group by  grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,instituto.nombre "
            Cmd.CommandText = sql

            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "grupo")

            DGVConsulta.DataSource = Ds.Tables("grupo")

            conect.Close()
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick
        conn()

        GroupBox1.Visible = True
        DGVConsulta.Visible = False
        txtBuscar.Visible = False
        lblRecordar.Visible = False
        lblBuscar.Visible = False
        Label3.Visible = True
        txtfechanacadmin.Visible = True

        Dim Variable As String = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
        cmbgrupo.Text = Variable
        conect.Close()

    End Sub

    Private Sub cmbgrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbgrupo.TextChanged

    End Sub

    Private Sub lblRecordar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRecordar.Click

    End Sub

    Private Sub lblBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBuscar.Click

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