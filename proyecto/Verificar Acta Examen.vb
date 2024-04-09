Public Class Verificar_Acta_Examen
    Dim idperiodo As Integer
    Dim nomgrupo As String
    Dim idgrupo As String
    Dim combinado As String
    Dim grado As String
    Dim orientacion As String
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

    Dim idasig As Integer
    Private Sub Verificar_Acta_Examen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        If docentev = 5 Then
            GroupBox1.Visible = False

        Else
            GroupBox1.Visible = True
        End If

      
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

 

    Private Sub ActaFinalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VerificarActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub AltaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaExamen.Show()
        Me.Close()

    End Sub



    

    

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        conn()
        Dim ingrese As Integer = 0
        Dim civerifico As Integer = 0
        Dim cidirector As Integer = 0
        Dim cisecretario As Integer = 0
        Dim activo As String

        Try
            sql2 = "SELECT ci FROM dictan WHERE ci= " & txtverifico.Text
            Cmd.CommandText = sql2
            civerifico = Cmd.ExecuteScalar
        Catch
            MsgBox("No ingreso ninguna cedula en verifico")
        End Try
        Try

            sql3 = "SELECT ci FROM dictan WHERE ci=" & txtsecretario.Text
            Cmd.CommandText = sql3
            cisecretario = Cmd.ExecuteScalar
        Catch
            MsgBox("No ingreso ninguna cedula en secretario")
        End Try

        Try

            sql4 = "SELECT ci FROM dictan WHERE ci=" & txtVocal.Text
            Cmd.CommandText = sql4
            cidirector = Cmd.ExecuteScalar
        Catch
            MsgBox("No ingreso ninguna cedula en vocal")

        End Try

        Try

            sql10 = "SELECT ci FROM dictan WHERE ci=" & txtpresidente.Text
            Cmd.CommandText = sql10
            ingrese = Cmd.ExecuteScalar
        Catch
            MsgBox("No ingreso ninguna cedula en presidente")
        End Try

        Try
            If civerifico <> txtpresidente.Text Then
                MsgBox("La cedula ingresada en presidente no es correcta", MsgBoxStyle.Critical, "Aviso")
            Else
                txtpresidente.Enabled = False
            End If


            If cisecretario <> txtsecretario.Text Then
                MsgBox("La cedula ingresada en secretario no es correcta", MsgBoxStyle.Critical, "Aviso")
            Else
                txtsecretario.Enabled = False
            End If

            If cidirector <> txtVocal.Text Then
                MsgBox("La cedula ingresada en vocal no es correcta", MsgBoxStyle.Critical, "Aviso")
            Else
                txtVocal.Enabled = False
            End If



            If ingrese <> txtverifico.Text Then
                MsgBox("La cedula ingresada en verifico no  es correcta", MsgBoxStyle.Critical, "Aviso")
            Else
                txtverifico.Enabled = False
            End If
        Catch
            MsgBox("No puede dejar cedulas en blanco")
        End Try

        sql = "SELECT estado from actae where n_actae= " & txtActaExamen.Text & ""
        Cmd.CommandText = sql
        activo = Cmd.ExecuteScalar
        If activo = "Abierta" Then
            If txtVocal.Enabled = False And txtverifico.Enabled = False And txtverifico.Enabled = False And txtsecretario.Enabled = False Then
                sql = "UPDATE actae set verifico= " & txtverifico.Text & ", presidente= " & txtpresidente.Text & ", secretario=" & txtsecretario.Text & ", vocal=" & txtVocal.Text & ", inicioe= '" & txtEscritoInicio.Text & "', fine= '" & txtEscritoFinal.Text & "', inicioo= '" & txtOralInicio.Text & "', fino='" & txtOralFinal.Text & "', estado='Cerrada' where n_actae= " & txtActaExamen.Text & " and estado='Abierta'"
                Cmd.CommandText = sql
                Try
                    Cmd.ExecuteNonQuery()
                    sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ",'" & txtActaExamen.Text & "','Update','Se cerró el acta de exámen','actae', '" & fecha2 & "', '" & lblhora2.Text & "')"

                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("Acta cerrada con éxito")
                Catch
                    MsgBox("ERROR 26:No se encuentra abierta el acta que seleccionó")
                End Try
            Else
                MsgBox("Debe completar las cédulas de forma correcta")
            End If
        Else
            MsgBox("ERROR 27:El acta ingresada se encuentra cerrada")
        End If
        conect.Close()

    End Sub

    Private Sub lbnidgrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblAsignatura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbAsignatura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    

    Private Sub txtverifico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtverifico_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub txtdirector_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdirector_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub txtingresoalacta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtingresoalacta_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub txtsecretario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtsecretario_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub



    Private Sub btnActaExamen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActaExamen.Click
        conn()
        Ds.Clear()
        DGVConsulta.Visible = True
        lblRecordar.Visible = True
        lblBuscar.Visible = True
        txtBuscar.Visible = True
        lblOral.Visible = False
        lblEscrito.Visible = False
        txtEscritoFinal.Visible = False
        txtOralFinal.Visible = False
        txtEscritoInicio.Visible = False
        txtOralInicio.Visible = False


        DGVConsulta.ReadOnly = True
        txtGrupo.Visible = True
        lblGrupo.Visible = True
        sql = "SELECT actae.n_actae,grupo.idgrupo,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,periodo.nombre,instituto.nombre from instituto,periodo,actae,grupo,actaf,asignatura,orientacion where grupo.orientacion = orientacion.idori and grupo.idgrupo = actae.idgrupo and asignatura.idasig = actae.idasig and actae.estado='Abierta' and instituto.idinst= actae.instituto and periodo.idperiodo = actae.idperiodo and actae.n_actaf = actaf.n_actaf and actae.estado='Abierta' group by actae.n_actae,grupo.idgrupo,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,periodo.nombre,instituto.nombre"
        Try
            Cmd.CommandText = sql
            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "actae")

            DGVConsulta.DataSource = Ds.Tables("actae")

        Catch
            MsgBox(ErrorToString)
        End Try




        conect.Close()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress


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

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub txtGrupo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGrupo.KeyPress

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

    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick



        conn()
        DGVConsulta.Visible = False
        lblGrupo.Visible = False
        lblBuscar.Visible = False
        txtGrupo.Visible = False
        txtBuscar.Visible = False
        lblRecordar.Visible = False
        lblOral.Visible = True
        lblEscrito.Visible = True
        txtEscritoFinal.Visible = True
        txtOralFinal.Visible = True
        txtEscritoInicio.Visible = True
        txtOralInicio.Visible = True


        actae = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
        asig = DGVConsulta.Item(5, DGVConsulta.CurrentRow.Index).Value
        periodo = DGVConsulta.Item(6, DGVConsulta.CurrentRow.Index).Value




        sql = "SELECT idasig from asignatura where nombre= '" & asig & "'"
        Cmd.CommandText = sql
        idasig = Cmd.ExecuteScalar

        sql = "SELECT idperiodo from periodo where nombre= '" & periodo & "'"
        Cmd.CommandText = sql
        idperiodo = Cmd.ExecuteScalar



        txtActaExamen.Text = actae
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

    Private Sub NotasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasToolStripMenuItem1.Click
        IngresarNotaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialToolStripMenuItem.Click
        historial.Show()
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