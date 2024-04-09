Public Class ModGrupo

    Dim idgrupo As Integer = 0
    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarlinea.Click


        If (lbllinea.Visible = False) Then

            conn()

            If (cmbnomgrup.Text <> "") Then

                sql = "SELECT idgrupo FROM grupo WHERE nombre='" & cmbnomgrup.Text & "'"
                Cmd.CommandText = sql
                idgrupo = Cmd.ExecuteScalar

                
                sql1 = "SELECT orientacion FROM orientacion"
                Cmd.CommandText = sql1
                dr = Cmd.ExecuteReader

                cmborient.Items.Clear()

                While dr.Read
                    cmborient.Items.Add(dr("orientacion"))
                End While

                dr.Close()

                sql2 = "SELECT t_curso FROM t_curso"
                Cmd.CommandText = sql2
                dr = Cmd.ExecuteReader

                cmbtcurso.Items.Clear()

                While dr.Read
                    cmbtcurso.Items.Add(dr("t_curso"))
                End While
                dr.Close()

                If (idgrupo <> 0) Then

                    btnconfirmar.Visible = True
                    lblaño.Visible = True
                    lblorientacion.Visible = True
                    lblgrado.Visible = True
                    lblnombre.Visible = True
                    lblturno.Visible = True
                    lbltcurso.Visible = True
                    txtaño.Visible = True
                    cmborient.Visible = True
                    txtgrado.Visible = True
                    txtnombre.Visible = True
                    cmbturno.Visible = True
                    cmbtcurso.Visible = True
                    lbllinea.Visible = True


                    sql = "SELECT anio,orientacion,t_curso,grado,nombre,turno "
                    sql += "FROM grupo "
                    sql += "WHERE nombre ='" & cmbnomgrup.Text & "'"
                    MsgBox(sql)
                    Cmd.CommandText = sql
                    dr = Cmd.ExecuteReader
                    Dim idori As Integer
                    Dim idcurso As Integer
                    Dim idturno As Integer


                    If dr.Read Then
                        txtaño.Text = dr("anio")
                        idori = dr("orientacion")
                        idcurso = dr("t_curso")
                        txtgrado.Text = dr("grado")
                        txtnombre.Text = dr("nombre")
                        idturno = dr("turno")
                        dr.Close()
                        'datoscragados = True
                    End If


                    dr.Close()
                    sql3 = "SELECT orientacion FROM orientacion"
                    Cmd.CommandText = sql3
                    dr = Cmd.ExecuteReader

                    cmborient.Items.Clear()

                    While dr.Read
                        cmborient.Items.Add(dr("orientacion"))
                    End While

                    dr.Close()

                    Dim nomori As String
                    sql2 = "SELECT orientacion FROM orientacion "
                    sql2 += "WHERE idori=" & idori
                    Cmd.CommandText = sql2
                    nomori = Cmd.ExecuteScalar

                    cmborient.Text = nomori

                    '----------
                    sql4 = "SELECT t_curso FROM t_curso"
                    Cmd.CommandText = sql4
                    dr = Cmd.ExecuteReader

                    cmbtcurso.Items.Clear()

                    While dr.Read
                        cmbtcurso.Items.Add(dr("t_curso"))
                    End While

                    dr.Close()

                    Dim nomtcurso As String
                    sql5 = "SELECT t_curso FROM t_curso "
                    sql5 += "WHERE idcurso=" & idcurso
                    Cmd.CommandText = sql5
                    nomtcurso = Cmd.ExecuteScalar

                    cmbtcurso.Text = nomtcurso

                    '----------
                    sql6 = "SELECT turno FROM turno"
                    Cmd.CommandText = sql6
                    dr = Cmd.ExecuteReader

                    cmbturno.Items.Clear()

                    While dr.Read
                        cmbturno.Items.Add(dr("turno"))
                    End While

                    dr.Close()

                    Dim nomturno As String
                    sql7 = "SELECT turno FROM turno "
                    sql7 += "WHERE idturno=" & idturno
                    Cmd.CommandText = sql7
                    nomturno = Cmd.ExecuteScalar

                    cmbturno.Text = nomturno
                Else
                    MsgBox("El id grupo ingresado no esta registrado", MsgBoxStyle.Exclamation, "Aviso")

                End If
            Else
                MsgBox("No ha Ingresado el ID de grupo", MsgBoxStyle.Exclamation, "Aviso")
            End If

            conect.Close()

        Else
            btnconfirmar.Visible = False
            lblaño.Visible = False
            lblorientacion.Visible = False
            lblgrado.Visible = False
            lblnombre.Visible = False
            lblturno.Visible = False
            lbltcurso.Visible = False
            txtaño.Visible = False
            cmborient.Visible = False
            txtgrado.Visible = False
            txtnombre.Visible = False
            cmbturno.Visible = False
            cmbtcurso.Visible = False
            lbllinea.Visible = False
        End If



    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click


        If (lblitem.Visible = False) Then

            conn()

            If (cmbnomgrup.Text <> "") Then

                sql = "SELECT idgrupo FROM grupo WHERE nombre='" & cmbnomgrup.Text & "'"
                Cmd.CommandText = sql
                idgrupo = Cmd.ExecuteScalar

              

                sql2 = "SELECT t_curso FROM t_curso"
                Cmd.CommandText = sql2
                dr = Cmd.ExecuteReader

                cmbtcursoi.Items.Clear()

                While dr.Read
                    cmbtcursoi.Items.Add(dr("t_curso"))
                End While
                dr.Close()

                If (idgrupo <> 0) Then

                    lblitem.Visible = True
                    CheckBoxaño.Visible = True
                    CheckBoxorientacion.Visible = True
                    CheckBoxgrado.Visible = True
                    CheckBoxNombre.Visible = True
                    CheckBoxturno.Visible = True
                    CheckBoxTcurso.Visible = True
                    btnconfirmar2.Visible = True

                    sql = "SELECT anio,orientacion,t_curso,grado,nombre,turno "
                    sql += "FROM grupo "
                    sql += "WHERE nombre ='" & cmbnomgrup.Text & "'"
                    MsgBox(sql)
                    Cmd.CommandText = sql
                    dr = Cmd.ExecuteReader

                    Dim idori As Integer
                    Dim idcurso As Integer
                    Dim idturno As Integer


                    If dr.Read Then
                        txtañoi.Text = dr("anio")
                        idori = dr("orientacion")
                        idcurso = dr("t_curso")
                        txtgradoi.Text = dr("grado")
                        txtnombrei.Text = dr("nombre")
                        idturno = dr("turno")
                        dr.Close()
                        'datoscragados = True
                    End If


                    dr.Close()
                    sql3 = "SELECT orientacion FROM orientacion"
                    Cmd.CommandText = sql3
                    dr = Cmd.ExecuteReader

                    cmborienti.Items.Clear()

                    While dr.Read
                        cmborienti.Items.Add(dr("orientacion"))
                    End While

                    dr.Close()

                    Dim nomori As String
                    sql2 = "SELECT orientacion FROM orientacion "
                    sql2 += "WHERE idori=" & idori
                    Cmd.CommandText = sql2
                    nomori = Cmd.ExecuteScalar

                    cmborienti.Text = nomori

                    '----------
                    sql4 = "SELECT t_curso FROM t_curso"
                    Cmd.CommandText = sql4
                    dr = Cmd.ExecuteReader

                    cmbtcursoi.Items.Clear()

                    While dr.Read
                        cmbtcursoi.Items.Add(dr("t_curso"))
                    End While

                    dr.Close()

                    Dim nomtcurso As String
                    sql5 = "SELECT t_curso FROM t_curso "
                    sql5 += "WHERE idcurso=" & idcurso
                    Cmd.CommandText = sql5
                    nomtcurso = Cmd.ExecuteScalar

                    cmbtcursoi.Text = nomtcurso

                    '----------
                    sql6 = "SELECT turno FROM turno"
                    Cmd.CommandText = sql6
                    dr = Cmd.ExecuteReader

                    cmbturnoi.Items.Clear()

                    While dr.Read
                        cmbturnoi.Items.Add(dr("turno"))
                    End While

                    dr.Close()

                    Dim nomturno As String
                    sql7 = "SELECT turno FROM turno "
                    sql7 += "WHERE idturno=" & idturno
                    Cmd.CommandText = sql7
                    nomturno = Cmd.ExecuteScalar

                    cmbturnoi.Text = nomturno

                Else
                    MsgBox("El id grupo ingresado no esta registrado", MsgBoxStyle.Exclamation, "Aviso")
                End If
            Else
                MsgBox("No ha Ingresado el ID de grupo", MsgBoxStyle.Exclamation, "Aviso")
            End If

            conect.Close()

        Else
            lblitem.Visible = False
            CheckBoxaño.Visible = False
            CheckBoxorientacion.Visible = False
            CheckBoxgrado.Visible = False
            CheckBoxNombre.Visible = False
            CheckBoxturno.Visible = False
            CheckBoxTcurso.Visible = False
            btnconfirmar2.Visible = False
            CheckBoxaño.Checked = False
            CheckBoxorientacion.Checked = False
            CheckBoxgrado.Checked = False
            CheckBoxNombre.Checked = False
            CheckBoxturno.Checked = False
            CheckBoxTcurso.Checked = False
        End If

    End Sub

    Private Sub CheckBoxaño_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxaño.CheckedChanged

        If txtañoi.Visible = False Then
            txtañoi.Visible = True
        Else
            txtañoi.Visible = False
        End If

    End Sub

    Private Sub CheckBoxorientacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxorientacion.CheckedChanged
        If cmborienti.Visible = False Then
            cmborienti.Visible = True
        Else
            cmborienti.Visible = False
        End If
    End Sub

    Private Sub CheckBoxgrado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxgrado.CheckedChanged
        If txtgradoi.Visible = False Then
            txtgradoi.Visible = True
        Else
            txtgradoi.Visible = False
        End If
    End Sub

    Private Sub CheckBoxNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxNombre.CheckedChanged
        If txtnombrei.Visible = False Then
            txtnombrei.Visible = True
        Else
            txtnombrei.Visible = False
        End If

    End Sub

    Private Sub CheckBoxturno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxturno.CheckedChanged

        If cmbturnoi.Visible = False Then
            cmbturnoi.Visible = True
        Else
            cmbturnoi.Visible = False
        End If
    End Sub

    Private Sub CheckBoxTcurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxTcurso.CheckedChanged
        If cmbtcursoi.Visible = False Then
            cmbtcursoi.Visible = True
        Else
            cmbtcursoi.Visible = False
        End If
    End Sub

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()

    End Sub


    Private Sub AltaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaGrupo.Show()
        Me.Close()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaGrupo.Show()
        Me.Close()
    End Sub


    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        conn()

        nomgrup()


        While dr.Read
            cmbnomgrup.Items.Add(dr("nombre"))
        End While


        conect.Close()



    End Sub



    Private Sub AltaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaAlumnoToolStripMenuItem.Click
        AltaAlumno.Show()
        Me.Close()
    End Sub

    Private Sub AltaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDocenteToolStripMenuItem.Click
        AltaDocente.Show()
        Me.Close()

    End Sub

    Private Sub BajaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDirectorToolStripMenuItem.Click
        BajaGrupo.Show()
        Me.Close()
    End Sub

    Private Sub BajaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDocenteToolStripMenuItem.Click
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub BajaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaAlumnoToolStripMenuItem.Click
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        ConsultaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionAsignaturaToolStripMenuItem.Click
        ModAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionInstitutoToolStripMenuItem.Click
        ModInstituto.Show()
        Me.Close()

    End Sub

    Private Sub AltaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDirectorToolStripMenuItem.Click
        AltaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub btnconfirmar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar2.Click
        conn()

        sql = "SELECT idgrupo FROM grupo WHERE nombre='" & cmbnomgrup.Text & "'"
        Cmd.CommandText = sql
        idgrupo = Cmd.ExecuteScalar
        conect.Close()
        If (idgrupo <> 0) Then


            If (CheckBoxaño.Checked = True) Then
                If (txtañoi.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql = "UPDATE grupo SET "
                    sql += "anio= " & txtañoi.Text & ""
                    sql += "WHERE idgrupo= " & idgrupo
                    MsgBox(sql)
                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")

                    nomgrup()
                    cmbnomgrup.Items.Clear()

                    While dr.Read
                        cmbnomgrup.Items.Add(dr("nombre"))
                    End While

                    conect.Close()
                End If


            End If
            If (CheckBoxorientacion.Checked = True) Then

                If (cmborienti.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    Dim idori As Integer
                    sql = "SELECT idori FROM orientacion WHERE orientacion='" & cmborienti.Text & "'"
                    Cmd.CommandText = sql
                    idori = Cmd.ExecuteScalar

                    If (idori <> 0) Then

                        sql1 = "UPDATE grupo SET "
                        sql1 += "orientacion= " & idori & " "
                        sql1 += "WHERE idgrupo= " & idgrupo
                        MsgBox(sql1)
                        Cmd.CommandText = sql1

                        Cmd.ExecuteNonQuery()
                        MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")

                        nomgrup()
                        cmbnomgrup.Items.Clear()

                        While dr.Read
                            cmbnomgrup.Items.Add(dr("nombre"))
                        End While

                        conect.Close()
                    End If

                End If

            End If

            If (CheckBoxTcurso.Checked = True) Then

                If (cmbtcursoi.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    Dim idcurso As Integer
                    sql = "SELECT idcurso FROM t_curso WHERE t_curso='" & cmbtcursoi.Text & "'"
                    Cmd.CommandText = sql
                    idcurso = Cmd.ExecuteScalar

                    sql2 = "UPDATE grupo SET "
                    sql2 += "t_curso= " & idcurso & " "
                    sql2 += "WHERE idgrupo= " & idgrupo
                    MsgBox(sql2)
                    Cmd.CommandText = sql2

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")

                    nomgrup()
                    cmbnomgrup.Items.Clear()

                    While dr.Read
                        cmbnomgrup.Items.Add(dr("nombre"))
                    End While

                    conect.Close()
                End If

            End If
            If (CheckBoxgrado.Checked = True) Then

                If (txtgradoi.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql3 = "UPDATE grupo SET "
                    sql3 += "grado= " & txtgradoi.Text & " "
                    sql3 += "WHERE idgrupo= " & idgrupo
                    MsgBox(sql3)
                    Cmd.CommandText = sql3

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    nomgrup()

                    cmbnomgrup.Items.Clear()
                    While dr.Read
                        cmbnomgrup.Items.Add(dr("nombre"))
                    End While

                    conect.Close()
                End If

                
            End If
            If (CheckBoxNombre.Checked = True) Then

                If (txtnombrei.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql4 = "UPDATE grupo SET "
                    sql4 += "nombre= '" & txtnombrei.Text & "' "
                    sql4 += "WHERE idgrupo= " & idgrupo
                    MsgBox(sql4)
                    Cmd.CommandText = sql4

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    nomgrup()
                    cmbnomgrup.Items.Clear()

                    While dr.Read
                        cmbnomgrup.Items.Add(dr("nombre"))
                    End While

                    conect.Close()
                End If

                
            End If
            If (CheckBoxturno.Checked = True) Then

                If (cmbturnoi.Text.Length) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return

                Else
                    conn()
                    Dim idturno As Integer
                    sql = "SELECT idturno FROM turno WHERE turno='" & cmbturnoi.Text & "'"
                    Cmd.CommandText = sql
                    idturno = Cmd.ExecuteScalar

                    sql5 = "UPDATE grupo SET "
                    sql5 += "turno= " & idturno & " "
                    sql5 += "WHERE idgrupo= " & idgrupo
                    MsgBox(sql5)
                    Cmd.CommandText = sql5

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    nomgrup()
                    cmbnomgrup.Items.Clear()

                    While dr.Read
                        cmbnomgrup.Items.Add(dr("nombre"))
                    End While

                    conect.Close()
                End If

            End If

        Else
            MsgBox("El ID de grupo no esta registrado", MsgBoxStyle.Exclamation, "Aviso")
        End If

        conect.Close()
    End Sub


    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        conn()

        sql = "SELECT idgrupo FROM grupo WHERE nombre='" & cmbnomgrup.Text & "'"
        Cmd.CommandText = sql
        idgrupo = Cmd.ExecuteScalar
        conect.Close()

        If ((txtaño.Text.Length = 0) And (cmborient.Text.Length = 0) And (cmbtcurso.Text.Length = 0) And (txtgrado.Text.Length = 0) And (txtnombre.Text.Length = 0) And (cmbturno.Text.Length = 0)) Then
            MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
            Return
        Else
            If (idgrupo <> 0) Then
                conn()
                Dim idori As Integer
                sql = "SELECT idori FROM orientacion WHERE orientacion='" & cmborient.Text & "'"
                Cmd.CommandText = sql
                idori = Cmd.ExecuteScalar

                Dim idcurso As Integer
                sql = "SELECT idcurso FROM t_curso WHERE t_curso='" & cmbtcurso.Text & "'"
                Cmd.CommandText = sql
                idcurso = Cmd.ExecuteScalar

                Dim idturno As Integer
                sql = "SELECT idturno FROM turno WHERE turno='" & cmbturno.Text & "'"
                Cmd.CommandText = sql
                idturno = Cmd.ExecuteScalar





                sql = "UPDATE grupo SET "
                sql += "anio=" & txtaño.Text & ", "
                sql += "orientacion=" & idori & ", "
                sql += "t_curso=" & idcurso & ", "
                sql += "grado=" & txtgrado.Text & ", "
                sql += "nombre='" & txtnombre.Text & "', "
                sql += "turno=" & idturno & " "
                sql += "WHERE idgrupo= " & idgrupo
                MsgBox(sql)
                Cmd.CommandText = sql

                Cmd.ExecuteNonQuery()
                MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                nomgrup()
                cmbnomgrup.Items.Clear()

                While dr.Read
                    cmbnomgrup.Items.Add(dr("nombre"))
                End While


            Else
                MsgBox("El ID de grupo no esta registrado", MsgBoxStyle.Exclamation, "Aviso")
            End If

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
End Class