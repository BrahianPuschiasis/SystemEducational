Public Class AltaGrupo
    Public idori As Integer = 0
    Dim contador2 As Integer
    Dim condicion As String
    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub

   




    Private Sub AsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAsignatura.Show()
        Me.Close()
    End Sub

    Private Sub InstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnConsulta.Show()
        Me.Close()
    End Sub




    Private Sub AltaDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAsignatura.Show()
        Me.Close()

    End Sub



    Private Sub BajaGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub BajaInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaInstituto.Show()
        Me.Close()

    End Sub

    Private Sub BajaAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAsignatura.Show()
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

    Private Sub ModificacionInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModInstituto.Show()
        Me.Close()

    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        conn()
        Cmd.CommandType = CommandType.Text
        Cmd.Connection = conect



        Dim dranio As String
        Dim drcurso As String
        Dim drgrado As String
        Dim drnombre As String
        Dim drturno As String
        Dim drinstituto As String
        Dim drorientacion As String

        Dim año As Integer
        año = Now.Year

        Dim idturno As Integer = 0

        Dim t_curso As Integer = 0
        Try
            sql1 = "SELECT idcurso FROM t_curso WHERE t_curso='" & cmbtcurso.Text & "'"
            Cmd.CommandText = sql1
            t_curso = Cmd.ExecuteScalar


            sql1 = "SELECT idturno FROM turno WHERE turno='" & cmbturno.Text & "'"
            Cmd.CommandText = sql1
            idturno = Cmd.ExecuteScalar



            sql2 = "Select count(*) from grupo "

            Cmd.CommandText = sql2
            Cmd.ExecuteScalar()
            contador = Cmd.ExecuteScalar





            autonumerico = contador + 1









            sql15 = "Select idinst from instituto where nombre = '" & cmbInstituto.Text & "' "



            Cmd.CommandText = sql15
            Cmd.ExecuteScalar()
            contador2 = Cmd.ExecuteScalar


            sql11 = "SELECT anio,t_curso,grado,nombre,turno,instituto,orientacion from grupo"
            Cmd.CommandText = sql11

            dr = Cmd.ExecuteReader

        Catch
            MsgBox("ERROR 15:No puede dejar campos en blanco")
        End Try

        Dim completo As String
        While dr.Read

            dranio = dr("anio")
            drcurso = dr("t_curso")
            drgrado = dr("grado")
            drnombre = dr("nombre")
            drturno = dr("turno")
            drinstituto = dr("instituto")
            drorientacion = dr("orientacion")
            completo = dranio + drcurso + drgrado + drnombre + drturno + drinstituto + drorientacion




            If dranio = año And drorientacion = idori And drturno = idturno And drgrado = txtgrado.Text And drinstituto = cmbInstituto.Text And drcurso = t_curso And drnombre = txtNombre.Text Then
                Me.Refresh()
                condicion = "0"
            Else
                condicion = "1"




            End If

        End While
        dr.Close()
        If txtgrado.Text = "1" Or txtgrado.Text = "2" Or txtgrado.Text = "3" Then
            If condicion = "0" Then
                MsgBox("Ya existe ese grupo")
            Else


                sql = "INSERT INTO grupo(idgrupo,anio,orientacion,t_curso,grado,nombre,turno,instituto,activo) "
                sql += "VALUES(" & autonumerico & "," & año & "," & idori & "," & t_curso & "," & txtgrado.Text & ",'" & txtNombre.Text & "'," & idturno & ",'" & cmbInstituto.Text & "'," & "'Activo'" & ")"

                Cmd.CommandText = sql
                Try
                    Cmd.ExecuteNonQuery()


                    sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ",'" & autonumerico & "','Insertar','Grupo creado','grupo', '" & fecha2 & "', '" & lblhora2.Text & "')"

                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los Datos han sido ingresados", MsgBoxStyle.Information, "Aviso")
                Catch
                    MsgBox("ERROR 15:Recuerde que no puede dejar ningun campo en blanco")
                End Try
            End If
        Else
            MsgBox("ERROR 17: El grado ingresado debe estar comprendido entre 1 y 3")
        End If




        conect.Close()
    End Sub

    Private Sub AltaGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        conn()

        sql11 = "SELECT nombre FROM instituto,administra where instituto.activo ='Activo' group by nombre "
        Cmd.CommandText = sql11

        dr = Cmd.ExecuteReader

        cmbInstituto.Items.Clear()

        While dr.Read
            cmbInstituto.Items.Add(dr("nombre"))
        End While
        dr.Close()






        sql = "SELECT completo FROM orientacion"
        Cmd.CommandText = sql
        dr = Cmd.ExecuteReader()

        cmbori.Items.Clear()
        While dr.Read
            cmbori.Items.Add(dr("completo"))
        End While

        dr.Close()


        sql = "SELECT turno FROM turno"
        Cmd.CommandText = sql
        dr = Cmd.ExecuteReader()

        cmbturno.Items.Clear()

        While dr.Read
            cmbturno.Items.Add(dr("turno"))
        End While

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

    Private Sub cmbori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbori.SelectedIndexChanged
        conn()
        Dim tcurso As String
        sql = "SELECT idori FROM orientacion WHERE completo='" & cmbori.Text & "'"
        Cmd.CommandText = sql
        idori = Cmd.ExecuteScalar



        sql = "SELECT t_curso.t_curso FROM t_curso,orientacion where orientacion.idori = " & idori & " and t_curso.idcurso = orientacion.idcurso  "
        Cmd.CommandText = sql
        tcurso = Cmd.ExecuteScalar()

        cmbtcurso.Items.Clear()
    
        cmbtcurso.Text = tcurso


        dr.Close()
        conect.Close()

    End Sub

    Private Sub txtgrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Dim primer, texto, letra, letras As String
        If txtNombre.Text.Length = 0 Then

            txtNombre.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtNombre.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtNombre.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtNombre.Text = letra + letras
        txtNombre.SelectionStart = I

    End Sub

    Private Sub cmbInstituto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnInstituto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstituto.Click
        conn()
        sql = "SELECT nombre from instituto where activo='Activo'"
        Cmd.CommandText = sql
        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
        da.Fill(Ds, "instituto")

        DGVConsulta.DataSource = Ds.Tables("instituto")
        lblBuscar.Visible = True
        txtBuscar.Visible = True
        lblRecordar.Visible = True
        DGVConsulta.Visible = True
        conect.Close()
    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick
        conn()
        Try
            Dim celda As String
            Dim instituto As Integer
            celda = Me.DGVConsulta.CurrentCell.Value.ToString

            sql = "SELECT idinst from instituto where nombre= '" & celda & "'"

            Cmd.CommandText = sql
            idinst = Cmd.ExecuteScalar

            Cmd.ExecuteScalar()
            instituto = Cmd.ExecuteScalar
            cmbInstituto.Text = instituto
            DGVConsulta.Visible = False
            lblBuscar.Visible = False
            txtBuscar.Visible = False
            lblRecordar.Visible = False
            Ds.Clear()








        Catch
        End Try
        conect.Close()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            conn()
            Ds.Clear()
            DGVConsulta.Visible = True
            sql = "SELECT nombre from instituto where nombre like '%" & txtBuscar.Text & "%' and activo='Activo'"
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