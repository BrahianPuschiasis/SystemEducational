Public Class IngresarNotaActaExamen
    Public cedulas As Integer
    Public oral As String
    Public escrita As String
    Public nota As String
    Public nactae As Integer
    Public nactaef As Integer
    Dim datagrid As Integer
    Dim actae As Integer
    Dim asig As String
    Dim periodo As String
    Dim idperiodo As Integer
    Dim idasig As Integer



    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Resp As String
        Resp = MsgBox("¿Desea salir?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

 

    Private Sub IngresarNotaActaExamen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        cedulas = cilogin
        If docentev = 5 Then
            GroupBox1.Visible = False

        Else
            GroupBox1.Visible = True
        End If
        conn()
     





        conect.Close()


    End Sub

    Private Sub IngresarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ModificarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModificarNotaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub IngresarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IngreseNotaActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub ModificarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModificarNotaActaFinal.Show()
        Me.Close()
    End Sub



    

    Private Sub DatosPersonalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaDatosPersonales.Show()
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ' DGVConsulta.Visible = False
        lblGrupo.Visible = False
        lblBuscar.Visible = False
        txtGrupo.Visible = False
        txtBuscar.Visible = False

        conn()

        Dim columna As Integer
        Dim atributo As String
        Dim ci As Integer
        Dim asignatura As String
        Dim codasig As Integer
        Dim nactaf As Integer
        Dim nota As String
        Dim escrita As String
        Dim inasistencia As Integer
        Dim fallo As String
        Dim filas As Integer
        Dim spam As Integer
        spam = 1


        filas = 0
        inasistencia = DGVConsulta.RowCount

 
      
        If datagrid = 2 Then
            While filas <= inasistencia
                Try


                    inasistencia = DGVConsulta.RowCount
                    inasistencia = inasistencia - 1
                    ci = DGVConsulta.Item(0, filas).Value
                    nota = DGVConsulta.Item(4, filas).Value
                    oral = DGVConsulta.Item(3, filas).Value
                    escrita = DGVConsulta.Item(2, filas).Value

          




                Catch
                End Try



                '     sql = "SELECT idperiodo from actae where n_actae= " & txtActaExamen.Text & " group by idperiodo"
                '  Cmd.CommandText = sql
                '  periodo = Cmd.ExecuteScalar
                periodo = idperiodo


                If periodo = 1 Then
                    Try
                        'If escrita >= 1 And escrita <= escrita Or escrita = 0 Or oral >= 1 And oral <= oral Or oral = 0 Or nota >= 1 And nota <= nota Or nota = 0 Then
                        If escrita = "-" Then
                            fallo = "Febrero"
                            oral = "-"
                            nota = "-"
                            escrita = "-"

                        Else


                            If escrita <= 6 Then
                                MsgBox(escrita)
                                oral = "-"
                                fallo = "Febrero"
                          
                            End If

                            If oral <= 6 Then
                                fallo = "Febrero"

                            End If

                            If nota < 7 Then
                                fallo = "Febrero"

                            End If

                            If oral >= 7 And escrita >= 7 And nota >= 7 Then
                                fallo = "Aprobado"

                            End If
                        End If
                    Catch
                    End Try

                    sql = "UPDATE examinado set escrita= '" & escrita & "', oral= '" & oral & "', nota='" & nota & "', fallo='" & fallo & "' where ci= " & ci & " and n_actae = " & txtActaExamen.Text & " "
                    Cmd.CommandText = sql
                    Try

                        Cmd.ExecuteNonQuery()
                    Catch
                        MsgBox(ErrorToString)
                    End Try

                    'Else
                    If filas = inasistencia Then

                        datagrid = 2

                        Ds.Clear()
                        DGVConsulta.Visible = True
                        btnverificar.Visible = False
                        DGVConsulta.ReadOnly = False





                        sql = "SELECT examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal from personas,examinado where examinado.n_actae = " & txtActaExamen.Text & " and examinado.ci = personas.ci group by examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal"
                        Try
                            Cmd.CommandText = sql
                            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                            da.Fill(Ds, "examinado")

                            DGVConsulta.DataSource = Ds.Tables("examinado")

                        Catch

                        End Try







                    End If


                End If


                If periodo = 2 Then

                    Try
                        'If escrita >= 1 And escrita <= escrita Or escrita = 0 Or oral >= 1 And oral <= oral Or oral = 0 Or nota >= 1 And nota <= nota Or nota = 0 Then
                        If escrita = "-" Then
                            fallo = "Marzo"
                            oral = "-"
                            nota = "-"

                        ElseIf escrita <= 6 Then
                            oral = "-"
                            fallo = "Marzo"


                        ElseIf oral <= 6 Then
                            fallo = "Marzo"
                        ElseIf oral >= 7 And escrita >= 7 And nota >= 7 Then
                            fallo = "Aprobado"
                        ElseIf nota < 7 Then
                            fallo = "Marzo"
                        End If
                    Catch
                    End Try

                    sql = "UPDATE examinado set escrita= '" & escrita & "', oral= '" & oral & "', nota='" & nota & "', fallo='" & fallo & "' where ci= " & ci & " and n_actae = " & txtActaExamen.Text & " "
                    Cmd.CommandText = sql
                    Try

                        Cmd.ExecuteNonQuery()
                    Catch
                        MsgBox(ErrorToString)
                    End Try

                    'Else
                    If filas = inasistencia Then

                        datagrid = 2

                        Ds.Clear()
                        DGVConsulta.Visible = True
                        btnverificar.Visible = False
                        DGVConsulta.ReadOnly = False





                        sql = "SELECT examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal from personas,examinado where examinado.n_actae = " & txtActaExamen.Text & " and examinado.ci = personas.ci group by examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal"
                        Try
                            Cmd.CommandText = sql
                            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                            da.Fill(Ds, "examinado")

                            DGVConsulta.DataSource = Ds.Tables("examinado")

                        Catch

                        End Try







                    End If
                End If




                If periodo = 3 Then

                    Try
                        'If escrita >= 1 And escrita <= escrita Or escrita = 0 Or oral >= 1 And oral <= oral Or oral = 0 Or nota >= 1 And nota <= nota Or nota = 0 Then
                        If escrita = "-" Then
                            fallo = "Junio"
                            oral = "-"
                            nota = "-"

                        ElseIf escrita <= 6 Then
                            oral = "-"
                            fallo = "Junio"


                        ElseIf oral <= 6 Then
                            fallo = "Junio"
                        ElseIf oral >= 7 And escrita >= 7 And nota >= 7 Then
                            fallo = "Aprobado"
                        ElseIf nota < 7 Then
                            fallo = "Junio"
                        End If
                    Catch
                    End Try

                    sql = "UPDATE examinado set escrita= '" & escrita & "', oral= '" & oral & "', nota='" & nota & "', fallo='" & fallo & "' where ci= " & ci & " and n_actae = " & txtActaExamen.Text & " "
                    Cmd.CommandText = sql
                    Try

                        Cmd.ExecuteNonQuery()
                    Catch
                        MsgBox(ErrorToString)
                    End Try

                    'Else
                    If filas = inasistencia Then

                        datagrid = 2

                        Ds.Clear()
                        DGVConsulta.Visible = True
                        btnverificar.Visible = False
                        DGVConsulta.ReadOnly = False





                        sql = "SELECT examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal from personas,examinado where examinado.n_actae = " & txtActaExamen.Text & " and examinado.ci = personas.ci group by examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal"
                        Try
                            Cmd.CommandText = sql
                            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                            da.Fill(Ds, "examinado")

                            DGVConsulta.DataSource = Ds.Tables("examinado")

                        Catch

                        End Try







                    End If
                End If





                If periodo = 4 Then

                    Try
                        'If escrita >= 1 And escrita <= escrita Or escrita = 0 Or oral >= 1 And oral <= oral Or oral = 0 Or nota >= 1 And nota <= nota Or nota = 0 Then
                        If escrita = "-" Then
                            fallo = "Setiembre"
                            oral = "-"
                            nota = "-"


                        ElseIf escrita <= 6 Then
                            oral = "-"
                            fallo = "Setiembre"


                        ElseIf oral <= 6 Then
                            fallo = "Setiembre"
                        ElseIf oral >= 7 And escrita >= 7 And nota >= 7 Then
                            fallo = "Aprobado"
                        ElseIf nota < 7 Then
                            fallo = "Setiembre"
                        End If
                    Catch
                    End Try

                    sql = "UPDATE examinado set escrita= '" & escrita & "', oral= '" & oral & "', nota='" & nota & "', fallo='" & fallo & "' where ci= " & ci & " and n_actae = " & txtActaExamen.Text & " "
                    Cmd.CommandText = sql
                    Try

                        Cmd.ExecuteNonQuery()
                    Catch
                        MsgBox(ErrorToString)
                    End Try

                    'Else
                    If filas = inasistencia Then

                        datagrid = 2

                        Ds.Clear()
                        DGVConsulta.Visible = True
                        btnverificar.Visible = False
                        DGVConsulta.ReadOnly = False





                        sql = "SELECT examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal from personas,examinado where examinado.n_actae = " & txtActaExamen.Text & " and examinado.ci = personas.ci group by examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal"
                        Try
                            Cmd.CommandText = sql
                            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                            da.Fill(Ds, "examinado")

                            DGVConsulta.DataSource = Ds.Tables("examinado")

                        Catch

                        End Try







                    End If
                End If



                If periodo = 5 Then

                    Try
                        'If escrita >= 1 And escrita <= escrita Or escrita = 0 Or oral >= 1 And oral <= oral Or oral = 0 Or nota >= 1 And nota <= nota Or nota = 0 Then
                        If escrita = "-" Then
                            fallo = "Noviembre"
                            oral = "-"
                            nota = "-"


                        ElseIf escrita <= 6 Then
                            oral = "-"
                            fallo = "Noviembre"


                        ElseIf oral <= 6 Then
                            fallo = "Noviembre"
                        ElseIf oral >= 7 And escrita >= 7 And nota >= 7 Then
                            fallo = "Aprobado"
                        ElseIf nota < 7 Then
                            fallo = "Noviembre"
                        End If
                    Catch
                    End Try

                    sql = "UPDATE examinado set escrita= '" & escrita & "', oral= '" & oral & "', nota='" & nota & "', fallo='" & fallo & "' where ci= " & ci & " and n_actae = " & txtActaExamen.Text & " "
                    Cmd.CommandText = sql
                    Try

                        Cmd.ExecuteNonQuery()
                    Catch
                        MsgBox(ErrorToString)
                    End Try

                    'Else
                    If filas = inasistencia Then

                        datagrid = 2

                        Ds.Clear()
                        DGVConsulta.Visible = True
                        btnverificar.Visible = False
                        DGVConsulta.ReadOnly = False





                        sql = "SELECT examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal from personas,examinado where examinado.n_actae = " & txtActaExamen.Text & " and examinado.ci = personas.ci group by examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal"
                        Try
                            Cmd.CommandText = sql
                            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                            da.Fill(Ds, "examinado")

                            DGVConsulta.DataSource = Ds.Tables("examinado")

                        Catch

                        End Try







                    End If
                End If


                If periodo = 6 Then

                    Try
                        'If escrita >= 1 And escrita <= escrita Or escrita = 0 Or oral >= 1 And oral <= oral Or oral = 0 Or nota >= 1 And nota <= nota Or nota = 0 Then
                        If escrita = "-" Then
                            fallo = "Diciembre"
                            oral = "-"
                            nota = "-"


                        ElseIf escrita <= 6 Then
                            oral = "-"
                            fallo = "Diciembre"


                        ElseIf oral <= 6 Then
                            fallo = "Diciembre"
                        ElseIf oral >= 7 And escrita >= 7 And nota >= 7 Then
                            fallo = "Aprobado"
                        ElseIf nota < 7 Then
                            fallo = "Diciembre"
                        End If
                    Catch
                    End Try

                    sql = "UPDATE examinado set escrita= '" & escrita & "', oral= '" & oral & "', nota='" & nota & "', fallo='" & fallo & "' where ci= " & ci & " and n_actae = " & txtActaExamen.Text & " "
                    Cmd.CommandText = sql
                    Try

                        Cmd.ExecuteNonQuery()
                    Catch
                        MsgBox(ErrorToString)
                    End Try

                    'Else
                    If filas = inasistencia Then

                        datagrid = 2

                        Ds.Clear()
                        DGVConsulta.Visible = True
                        btnverificar.Visible = False
                        DGVConsulta.ReadOnly = False





                        sql = "SELECT examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal from personas,examinado where examinado.n_actae = " & txtActaExamen.Text & " and examinado.ci = personas.ci group by examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal"
                        Try
                            Cmd.CommandText = sql
                            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                            da.Fill(Ds, "examinado")

                            DGVConsulta.DataSource = Ds.Tables("examinado")

                        Catch

                        End Try







                    End If
                End If



                'End If

                filas = filas + 1
                If filas > inasistencia Then
                    Dim resp As String

                    resp = MsgBox("Modificaciones realizadas, ¿desea cerrar la planilla actual?", MsgBoxStyle.YesNo, "DvS")
                    If resp = vbYes Then
                        sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ",'" & txtActaExamen.Text & "','Update','Se modificaron las notas para el acta de exámen','actae', '" & fecha2 & "', '" & lblhora2.Text & "')"

                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                        DGVConsulta.Visible = False
                        lblGrupo.Visible = False
                        lblBuscar.Visible = False
                        txtGrupo.Visible = False
                        txtBuscar.Visible = False
                        lblRecordar.Visible = False
                        btnverificar.Visible = True
                    End If
                End If

            End While



        End If

        conect.Close()



    End Sub
    Private Sub lblcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = DateString
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

    Private Sub ActaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ActaDeExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub btnActaExamen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActaExamen.Click
        conn()
        Ds.Clear()
        DGVConsulta.Visible = True
        lblRecordar.Visible = True
        lblBuscar.Visible = True
        txtBuscar.Visible = True
        btnverificar.Visible = False
        DGVConsulta.ReadOnly = True
        txtGrupo.Visible = True
        lblGrupo.Visible = True
        sql = "SELECT actae.n_actae,grupo.idgrupo,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,periodo.nombre,instituto.nombre from instituto,periodo,actae,grupo,actaf,asignatura,orientacion where grupo.orientacion = orientacion.idori and grupo.idgrupo = actae.idgrupo and asignatura.idasig = actae.idasig and actae.estado='Abierta' and instituto.idinst= actae.instituto and actae.estado='Abierta' and periodo.idperiodo = actae.idperiodo and actae.n_actaf = actaf.n_actaf group by actae.n_actae,grupo.idgrupo,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,periodo.nombre,instituto.nombre"
        Try
            Cmd.CommandText = sql
            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "actae")

            DGVConsulta.DataSource = Ds.Tables("actae")
            datagrid = 1
        Catch
            MsgBox(ErrorToString)
        End Try




        conect.Close()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress

        If datagrid = 1 Then
            If e.KeyChar = Chr(13) Then

                Try
                    Ds.Clear()

                    DGVConsulta.Visible = True
                    sql = "SELECT actae.n_actae,grupo.idgrupo,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,periodo.nombre,instituto.nombre from instituto,periodo,actae,grupo,actaf,asignatura,orientacion where grupo.orientacion = orientacion.idori and grupo.idgrupo = actae.idgrupo and asignatura.idasig = actae.idasig and instituto.nombre like '%" & txtBuscar.Text & "%' and actae.estado='Abierta' and instituto.idinst= actae.instituto and periodo.idperiodo = actae.idperiodo and actae.n_actaf = actaf.n_actaf group by actae.n_actae,grupo.idgrupo,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,periodo.nombre,instituto.nombre"

                    Cmd.CommandText = sql

                    Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                    da.Fill(Ds, "actae")

                    DGVConsulta.DataSource = Ds.Tables("actae")

                Catch
                End Try
            End If
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub txtGrupo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrupo.KeyPress
        If datagrid = 1 Then
            If e.KeyChar = Chr(13) Then

                Try
                    Ds.Clear()

                    DGVConsulta.Visible = True
                    sql = "SELECT actae.n_actae,grupo.idgrupo,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,periodo.nombre,instituto.nombre from instituto,periodo,actae,grupo,actaf,asignatura,orientacion where grupo.orientacion = orientacion.idori and grupo.idgrupo = actae.idgrupo and asignatura.idasig = actae.idasig and grupo.idgrupo = " & txtGrupo.Text & " and actae.estado='Abierta' and instituto.idinst= actae.instituto and periodo.idperiodo = actae.idperiodo and actae.n_actaf = actaf.n_actaf group by actae.n_actae,grupo.idgrupo,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,periodo.nombre,instituto.nombre"

                    Cmd.CommandText = sql

                    Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                    da.Fill(Ds, "actae")

                    DGVConsulta.DataSource = Ds.Tables("actae")

                Catch
                End Try
            End If
        End If
    End Sub

    Private Sub txtGrupo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrupo.TextChanged

    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick


        If datagrid = 1 Then
            conn()
            DGVConsulta.Visible = False
            lblGrupo.Visible = False
            lblBuscar.Visible = False
            txtGrupo.Visible = False
            txtBuscar.Visible = False
            lblRecordar.Visible = False



            actae = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
            asig = DGVConsulta.Item(5, DGVConsulta.CurrentRow.Index).Value
            periodo = DGVConsulta.Item(6, DGVConsulta.CurrentRow.Index).Value




            sql = "SELECT idasig from asignatura where nombre= '" & asig & "'"
            Cmd.CommandText = sql
            idasig = Cmd.ExecuteScalar

            sql = "SELECT idperiodo from periodo where nombre= '" & periodo & "'"
            Cmd.CommandText = sql
            idperiodo = Cmd.ExecuteScalar

            datagrid = 2
            btnverificar.Visible = True
            txtActaExamen.Text = actae
            conect.Close()
        End If



    End Sub

    Private Sub btnverificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverificar.Click
        conn()
        datagrid = 2

        Ds.Clear()
        DGVConsulta.Visible = True
        btnverificar.Visible = False
        DGVConsulta.ReadOnly = False





        sql = "SELECT examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal from personas,examinado,actae where examinado.n_actae = " & txtActaExamen.Text & " and examinado.ci = personas.ci and actae.estado='Abierta' group by examinado.ci,personas.apaterno,examinado.escrita,examinado.oral,examinado.nota,examinado.fallo,examinado.notafinal"
        Try
            Cmd.CommandText = sql
            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "examinado")

            DGVConsulta.DataSource = Ds.Tables("examinado")

        Catch
            MsgBox(ErrorToString)
        End Try
        Try

            DGVConsulta.Columns("fallo").ReadOnly = True
            DGVConsulta.Columns("ci").ReadOnly = True
            DGVConsulta.Columns("apaterno").ReadOnly = True
            DGVConsulta.Columns("notafinal").ReadOnly = True
        Catch
        End Try

        conect.Close()

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