Public Class IngreseNotaActaFinal
    Dim varnueva As String
    Dim numerito As String
    Dim nactaf As String
    Dim grupo As String
    Dim nomgrupo As String
    Dim idgrupo As String
    Dim combinado As String
    Dim grado As String
    Dim orientacion As String
    Dim cedulas As Integer
    Dim idasig As String
    Dim horas As Integer
    Dim grados As Integer
    Dim datagrid As Integer
    Dim faltas As Integer

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Resp As String
        Resp = MsgBox("¿Desea salir?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalDocente.Show()
        Me.Close()

    End Sub

    Private Sub IngreseNotaActaFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
   

        conn()
        cedulas = cilogin
        sql13 = "SELECT grupo.idgrupo,grado,orientacion.orientacion,grupo.nombre from grupo,dictan,orientacion,instituto, actaf where dictan.ci = " & cedulas & " and orientacion.idori = grupo.orientacion and grupo.idgrupo = dictan.idgrupo and dictan.aniodictado = grupo.anio and actaf.idgrupo = grupo.idgrupo and actaf.estado='Abierta'and grupo.anio = " & Now.Year & "  group by grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion  order by grupo.idgrupo "
        Cmd.CommandText = sql13
        dr = Cmd.ExecuteReader()


      



      
        conect.Close()

    End Sub

    Private Sub IngresarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IngresarNotaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModificarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModificarNotaActaExamen.Show()
        Me.Close()
    End Sub


    Private Sub ModificarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModificarNotaActaFinal.Show()
        Me.Close()
    End Sub



    Private Sub NotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaNotaActaFinalDocente.Show()
        Me.Close()
    End Sub

    Private Sub DatosPersonalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaDatosPersonales.Show()
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ' DGVConsulta.Visible = False

        lblBuscar.Visible = False

        txtBuscar.Visible = False

        conn()

        Dim columna As Integer
        Dim atributo As String
        Dim ci As Integer
        Dim asignatura As String
        Dim codasig As Integer
        Dim nactaf As Integer
        Dim nota As String
        Dim inasistencia As Integer
        Dim fallo As String
        Dim filas As Integer
        Dim spam As Integer
        Dim conta As Integer




        spam = 1


        filas = 0
        conta = DGVConsulta.RowCount
        nactaf = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
        Try
            asignatura = DGVConsulta.Item(5, DGVConsulta.CurrentRow.Index).Value
        Catch
        End Try
        If datagrid = 2 Then
            While filas <= conta

                conta = DGVConsulta.RowCount
                conta = conta - 1


                Try
                    ci = DGVConsulta.Item(1, filas).Value
                    nota = DGVConsulta.Item(3, filas).Value
                    inasistencia = DGVConsulta.Item(4, filas).Value


                Catch
                End Try








                'Else






                sql = "SELECT grupo.grado from grupo,actaf where actaf.idgrupo = grupo.idgrupo and actaf.n_actaf = " & txtActaFinal.Text & " group by grupo.grado"
                Cmd.CommandText = sql
                grado = Cmd.ExecuteScalar

                sql = "SELECT idasig from asignatura where nombre= '" & asignatura & "'"
                Cmd.CommandText = sql
                codasig = Cmd.ExecuteScalar


                Try
                    If nota >= 1 And nota <= 12 Or nota = 0 Then
                        If grado < 3 Then
                            If nota >= 7 Then
                                fallo = "Aprobado"
                            ElseIf nota >= 4 And nota < 7 Then
                                fallo = "Diciembre"
                            ElseIf nota < 4 Then
                                fallo = "Febrero"
                            End If
                        End If

                        If grado = 3 Then
                            If nota >= 4 Then
                                fallo = "Diciembre"
                            ElseIf nota < 4 Then
                                fallo = "Febrero"
                            End If
                        End If

                        Dim resp As String

                        If faltas <= inasistencia Then
                            resp = MsgBox("El límite permitido de faltas ha sido superado para el alumno " & ci & " ¿Desea que repita por inasistencias?", MsgBoxStyle.YesNo, "DvS")
                            If resp = vbYes Then
                                fallo = "Repite por inasistencias"
                            End If
                        End If
                        sql = "UPDATE cursan set nota= " & nota & ", inasistencias= " & inasistencia & ", fallo='" & fallo & "' where ci= " & ci & " and idasig= " & txtAsignatura.Text & " and n_actaf = " & nactaf & " "
                        Cmd.CommandText = sql
                        Try

                            Cmd.ExecuteNonQuery()
                        Catch

                        End Try

                    Else
                        MsgBox("La nota ingresada debe estar comprendida entre 1 y 12")
                    End If





                    If filas = conta Then

                        datagrid = 2

                        Ds.Clear()
                        DGVConsulta.Visible = True
                        btnverificar.Visible = False
                        DGVConsulta.ReadOnly = False



                        Try

                            sql = "SELECT actaf.n_actaf,personas.ci,personas.apaterno,cursan.nota,cursan.inasistencias,asignatura.nombre from personas,cursan,asignatura,actaf where personas.ci = cursan.ci and cursan.idasig = asignatura.idasig and asignatura.idasig = " & txtAsignatura.Text & " and actaf.n_actaf = " & txtActaFinal.Text & " and cursan.n_actaf = actaf.n_actaf group by actaf.n_actaf,personas.ci,personas.apaterno,personas.nombre1,cursan.nota,cursan.inasistencias,asignatura.nombre order by personas.apaterno "

                            Cmd.CommandText = sql

                            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                            da.Fill(Ds, "personas")

                            DGVConsulta.DataSource = Ds.Tables("personas")
                        Catch
                            MsgBox(ErrorToString)
                        End Try
                    End If




                    'End If


                    If filas = conta Then
                        Dim resp As String
                       
                        resp = MsgBox("Modificaciones realizadas, ¿desea cerrar la planilla actual?", MsgBoxStyle.YesNo, "DvS")
                        If resp = vbYes Then
                            sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ",'" & txtActaFinal.Text & "','Update','Se modificaron las notas para la asignatura " & txtAsignatura.Text & "','actaf', " & fecha2 & ", '" & lblhora2.Text & "')"

                            Cmd.CommandText = sql

                            Cmd.ExecuteNonQuery()
                            DGVConsulta.Visible = False
                            lblBuscar.Visible = False
                            txtBuscar.Visible = False
                            lblRecordar.Visible = False
                            btnverificar.Visible = True
                        End If

                    End If
                    filas = filas + 1

                Catch
                    MsgBox("Recuerde que las inasistencias permitidas tienen que ser un número entero y la nota debe estar comprendida entre 1 y 12")
                End Try
            End While

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
        If docentev = 5 Then
            MenuPrincipalDocente.Show()
            Me.Close()
        Else



            MenuPrincipalAdministrativo.Show()
            Me.Close()
        End If
    End Sub

  


    Private Sub cmbAsignatura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        conn()
        ' sql14 = " SELECT idasig from asignatura where nombre= '" & cmbAsignatura.Text & "'"

        ' Cmd.CommandText = sql14

        ' idasig = Cmd.ExecuteScalar


        sql14 = " SELECT hs from programa where idasig= " & idasig & ""

        Cmd.CommandText = sql14

        horas = Cmd.ExecuteScalar


        sql14 = " SELECT grado from programa where idasig= " & idasig & ""

        Cmd.CommandText = sql14

        grados = Cmd.ExecuteScalar
        conect.Close()

    End Sub

    Private Sub btnActaFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActaFinal.Click
        conn()
        Ds.Clear()
        DGVConsulta.Visible = True
        lblRecordar.Visible = True
        lblBuscar.Visible = True
        txtBuscar.Visible = True
        btnverificar.Visible = False
        DGVConsulta.ReadOnly = True
        txtInstituto.Visible = True
        lblInstituto.Visible = True
        sql = "SELECT actaf.n_actaf,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,instituto.nombre from actaf,asignatura,cursan,grupo,orientacion,t_curso,instituto where  instituto.idinst = grupo.instituto and grupo.t_curso=t_curso.idcurso and actaf.anio = " & Now.Year & " and cursan.idasig = asignatura.idasig and asignatura.activo='Activo' and cursan.n_actaf = actaf.n_actaf and asignatura.activo='Activo' and actaf.estado='Abierta' and grupo.idgrupo = actaf.idgrupo and grupo.orientacion = orientacion.idori group by  actaf.n_actaf,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,instituto.nombre"
        Try
            Cmd.CommandText = sql
            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "actaf")

            DGVConsulta.DataSource = Ds.Tables("actaf")
            datagrid = 1
        Catch
            MsgBox(ErrorToString)
        End Try




        conect.Close()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress


        If e.KeyChar = Chr(13) Then
            conn()
            Ds.Clear()

            DGVConsulta.Visible = True
            Try
                sql = "SELECT actaf.n_actaf,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,instituto.nombre from actaf,asignatura,cursan,grupo,orientacion,t_curso,instituto where  instituto.idinst = grupo.instituto and actaf.n_actaf = " & txtBuscar.Text & " and grupo.t_curso=t_curso.idcurso and actaf.anio = " & Now.Year & " and cursan.idasig = asignatura.idasig and asignatura.activo='Activo' and cursan.n_actaf = actaf.n_actaf and actaf.estado='Abierta' and grupo.idgrupo = actaf.idgrupo and grupo.orientacion = orientacion.idori group by  actaf.n_actaf,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,instituto.nombre"

                Cmd.CommandText = sql

                Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                da.Fill(Ds, "actaf")

                DGVConsulta.DataSource = Ds.Tables("actaf")


            Catch

            End Try

            conect.Close()

        End If

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick
        conn()
        If datagrid = 1 Then

            Dim idasig As String
            Dim actaf As Integer
            Dim codigo As Integer
            Dim Variable As String = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
            actaf = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
            idasig = DGVConsulta.Item(4, DGVConsulta.CurrentRow.Index).Value

            sql = "SELECT idasig from asignatura where nombre= '" & idasig & "'"
            Cmd.CommandText = sql
            codigo = Cmd.ExecuteScalar

            txtActaFinal.Text = actaf
            txtAsignatura.Text = codigo

            DGVConsulta.Visible = False
            lblRecordar.Visible = False
            txtBuscar.Visible = False
            lblBuscar.Visible = False
            btnverificar.Visible = True
            txtInstituto.Visible = False
            lblInstituto.Visible = False

        End If

        conect.Close()

    End Sub

    Private Sub btnverificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverificar.Click
        conn()
        Ds.Clear()
        Dim verdad As Boolean
        Dim verdad2 As Boolean
        sql = "select n_actaf from actaf where n_actaf= " & txtActaFinal.Text & " and estado='Abierta'"
        Cmd.CommandText = sql
        Try
            If txtActaFinal.Text = Cmd.ExecuteScalar Then
                verdad = True
            Else
                MsgBox("El número de acta ingresado no existe o no se encuentra abierta")
                txtActaFinal.Enabled = True
            End If
        Catch
        End Try
        sql = "SELECT idasig from cursan where idasig = " & txtAsignatura.Text & " and n_actaf= " & txtActaFinal.Text & ""
        Cmd.CommandText = sql
        Try
            If txtAsignatura.Text = Cmd.ExecuteScalar Then
                verdad2 = True
            Else
                MsgBox("El código de asignatura ingresado no existe o no se encuentra en el acta final ingresada")
                txtAsignatura.Enabled = True
            End If
        Catch

        End Try

        If verdad And verdad2 = True Then



            sql14 = " SELECT hs from programa where idasig= " & txtAsignatura.Text & ""

            Cmd.CommandText = sql14

            horas = Cmd.ExecuteScalar


            sql14 = " SELECT grado from programa where idasig= " & txtAsignatura.Text & ""

            Cmd.CommandText = sql14

            grados = Cmd.ExecuteScalar


            If grados <= 3 And horas = 2 Then
                MsgBox("Recuerde que para esta materia se permiten hasta 14 faltas inclusive")
                faltas = 15
            End If

            If grados <= 3 And horas = 3 Then
                MsgBox("Recuerde que para esta materia se permiten hasta 20 faltas inclusive")
                faltas = 21
            End If

            If grados <= 3 And horas = 4 Then
                MsgBox("Recuerde que para esta materia se permiten hasta 26 faltas inclusive")
                faltas = 26
            End If




            datagrid = 2
            Ds.Clear()
            DGVConsulta.ReadOnly = False
            DGVConsulta.Visible = True
            lblRecordar.Visible = False
            lblBuscar.Visible = False
            txtBuscar.Visible = False
            btnverificar.Visible = False
            txtInstituto.Visible = False
            lblInstituto.Visible = False
            Try
                sql = "SELECT actaf.n_actaf,personas.ci,personas.apaterno,cursan.nota,cursan.inasistencias,cursan.fallo,asignatura.nombre from personas,cursan,asignatura,actaf where personas.ci = cursan.ci and cursan.idasig = asignatura.idasig and asignatura.idasig = " & txtAsignatura.Text & " and actaf.n_actaf = " & txtActaFinal.Text & " and cursan.n_actaf = actaf.n_actaf group by actaf.n_actaf,personas.ci,personas.apaterno,personas.nombre1,cursan.nota,cursan.inasistencias,asignatura.nombre,cursan.fallo order by personas.apaterno "

                Cmd.CommandText = sql

                Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                da.Fill(Ds, "personas")

                DGVConsulta.DataSource = Ds.Tables("personas")
            Catch
                MsgBox(ErrorToString)
            End Try
        End If

        conect.Close()
        Try
            DGVConsulta.Columns("apaterno").ReadOnly = True
            DGVConsulta.Columns("ci").ReadOnly = True
            DGVConsulta.Columns("nombre").ReadOnly = True
            DGVConsulta.Columns("n_actaf").ReadOnly = True
            DGVConsulta.Columns("fallo").ReadOnly = True
        Catch
        End Try
    End Sub

    Private Sub txtInstituto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInstituto.KeyPress

        If e.KeyChar = Chr(13) Then
            conn()
            Ds.Clear()

            DGVConsulta.Visible = True
            Try
                sql = "SELECT actaf.n_actaf,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,instituto.nombre from actaf,asignatura,cursan,grupo,orientacion,t_curso,instituto where  instituto.idinst = grupo.instituto and instituto.nombre like '%" & txtInstituto.Text & "%' and grupo.t_curso=t_curso.idcurso and actaf.anio = " & Now.Year & " and cursan.idasig = asignatura.idasig and asignatura.activo='Activo' and cursan.n_actaf = actaf.n_actaf and actaf.estado='Abierta' and grupo.idgrupo = actaf.idgrupo and grupo.orientacion = orientacion.idori group by  actaf.n_actaf,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,instituto.nombre"

                Cmd.CommandText = sql

                Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                da.Fill(Ds, "actaf")

                DGVConsulta.DataSource = Ds.Tables("actaf")


            Catch

            End Try

            conect.Close()

        End If

    End Sub



    Private Sub txtInstituto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInstituto.TextChanged

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