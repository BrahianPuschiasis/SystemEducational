Public Class ModAlumno
    Dim datoscragados As Boolean

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub DirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaAdministrativo.Show()
        Me.Close()

    End Sub



    Private Sub DocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaDocente.Show()
        Me.Close()
    End Sub

    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarlinea.Click

        If lbllinea.Visible = False Then
            conn()

            If (txtci.Text <> "") Then
                sql = "SELECT ci FROM personas WHERE ci=" & txtci.Text
                Cmd.CommandText = sql
                ci = Cmd.ExecuteScalar

                If (cedula = txtci.Text) Then

                    lblnombre1.Visible = True
                    lblnombre2.Visible = True
                    lblapaterno.Visible = True
                    lblamaterno.Visible = True
                    lbldireccion.Visible = True

                    btnconfirmar.Visible = True
                    txtnombre1.Visible = True
                    txtnombre2.Visible = True
                    txtapaterno.Visible = True
                    txtamaterno.Visible = True
                    txtdireccion.Visible = True

                    btnconfirmar.Visible = True
                    lbllinea.Visible = True

                    sql1 = "SELECT nombre1,nombre2,apaterno,amaterno,direccion,mail "
                    sql1 += "FROM personas "
                    sql1 += "WHERE ci = " & txtci.Text
                    MsgBox(sql1)
                    Cmd.CommandText = sql1
                    dr = Cmd.ExecuteReader

                    If dr.Read Then
                        txtnombre1.Text = dr("nombre1")
                        txtnombre2.Text = dr("nombre2")
                        txtapaterno.Text = dr("apaterno")
                        txtamaterno.Text = dr("amaterno")
                        txtdireccion.Text = dr("direccion")

                        dr.Close()
                        datoscragados = True
                    End If
                Else
                    MsgBox("La cedula ingresada no esta registrada", MsgBoxStyle.Exclamation, "Aviso")
                End If
            Else
                MsgBox("No ha Ingresado la C.I", MsgBoxStyle.Exclamation, "Aviso")
            End If

            conect.Close()
        Else
            lblnombre1.Visible = False
            lblnombre2.Visible = False
            lblapaterno.Visible = False
            lblamaterno.Visible = False
            lbldireccion.Visible = False

            btnconfirmar.Visible = False
            txtnombre1.Visible = False
            txtnombre2.Visible = False
            txtapaterno.Visible = False
            txtamaterno.Visible = False
            txtdireccion.Visible = False
               btnconfirmar.Visible = False
            lbllinea.Visible = False

        End If


    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click

        ci = txtci.Text
        If (lblitem.Visible = False) Then

            conn()

            If (txtci.Text <> "") Then

                verci()

                If (cedula = txtci.Text) Then

                    btnconfirmar2.Visible = True
                    CheckBoxnombre1.Visible = True
                    CheckBoxnombre2.Visible = True
                    CheckBoxapaterno.Visible = True
                    CheckBoxamaterno.Visible = True
                    CheckBoxdireccion.Visible = True

                    lblitem.Visible = True


                    cargardatos()

                    If dr.Read Then
                        txtitemnombre.Text = dr("nombre1")
                        txtitemnombre2.Text = dr("nombre2")
                        txtitemapaterno.Text = dr("apaterno")
                        txtitemamaterno.Text = dr("amaterno")
                        txtitemdireccion.Text = dr("direccion")

                        dr.Close()
                        datoscragados = True
                    End If
                Else
                    MsgBox("La cedula ingresada no esta registrada", MsgBoxStyle.Exclamation, "Aviso")

                End If
            Else
                MsgBox("No ha Ingresado la C.I", MsgBoxStyle.Exclamation, "Aviso")
            End If

            conect.Close()

        Else
            btnconfirmar2.Visible = False
            CheckBoxnombre1.Visible = False
            CheckBoxnombre2.Visible = False
            CheckBoxapaterno.Visible = False
            CheckBoxamaterno.Visible = False
            CheckBoxdireccion.Visible = False
            lblitem.Visible = False
            CheckBoxnombre1.Checked = False
            CheckBoxnombre2.Checked = False
            CheckBoxapaterno.Checked = False
            CheckBoxamaterno.Checked = False
            CheckBoxdireccion.Checked = False

            txtitemnombre.Visible = False
            txtitemnombre2.Visible = False
            txtitemapaterno.Visible = False
            txtitemamaterno.Visible = False
            txtitemdireccion.Visible = False

        End If
    End Sub

    Private Sub CheckBoxnombre1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxnombre1.CheckedChanged
        If txtitemnombre.Visible = False Then
            txtitemnombre.Visible = True
        Else
            txtitemnombre.Visible = False
        End If
    End Sub

    Private Sub CheckBoxnombre2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxnombre2.CheckedChanged

        If txtitemnombre2.Visible = False Then
            txtitemnombre2.Visible = True
        Else
            txtitemnombre2.Visible = False
        End If
    End Sub

    Private Sub CheckBoxapaterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxapaterno.CheckedChanged

        If txtitemapaterno.Visible = False Then
            txtitemapaterno.Visible = True
        Else
            txtitemapaterno.Visible = False
        End If
    End Sub

    Private Sub CheckBoxamaterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxamaterno.CheckedChanged

        If txtitemamaterno.Visible = False Then
            txtitemamaterno.Visible = True
        Else
            txtitemamaterno.Visible = False
        End If
    End Sub

    Private Sub CheckBoxdireccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxdireccion.CheckedChanged
        If txtitemdireccion.Visible = False Then
            txtitemdireccion.Visible = True
        Else
            txtitemdireccion.Visible = False
        End If
    End Sub

    

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAlumno.Show()
        Me.Close()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAlumno.Show()
        Me.Close()
    End Sub




    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub BajaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaAlumnoToolStripMenuItem.Click
        BajaAlumno.Show()
        Me.Close()


    End Sub

    Private Sub AltaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDirectorToolStripMenuItem.Click
        AltaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub AltaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaAlumnoToolStripMenuItem.Click
        AltaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub AltaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDocenteToolStripMenuItem.Click
        AltaDocente.Show()
        Me.Close()

    End Sub

    Private Sub BajaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDirectorToolStripMenuItem.Click
        BajaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub BajaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDocenteToolStripMenuItem.Click
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        CmbConsultaListado.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem.Click

    End Sub


    Private Sub ModificacionDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDirectorToolStripMenuItem.Click
        modAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDocenteToolStripMenuItem.Click
        ModDocente.Show()
        Me.Close()

    End Sub

    Private Sub btnconfirmar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar2.Click
        If (cedula = txtci.Text) Then
            If (CheckBoxnombre1.Checked = True) Then

                If (txtitemnombre.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql = "UPDATE personas SET "
                    sql += "nombre1= '" & txtitemnombre.Text & "' "
                    sql += "WHERE ci= " & cedula
                    MsgBox(sql)
                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    conect.Close()
                End If


            End If
            If (CheckBoxnombre2.Checked = True) Then
                sql = "UPDATE personas SET "
                sql += "nombre2= '" & txtitemnombre2.Text & "' "
                sql += " WHERE ci= " & cedula
                MsgBox(sql)
                Cmd.CommandText = sql

                Cmd.ExecuteNonQuery()
                MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
            End If
            If (CheckBoxapaterno.Checked = True) Then

                If (txtitemapaterno.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql = "UPDATE personas SET "
                    sql += "apaterno= '" & txtitemapaterno.Text & "' "
                    sql += " WHERE ci= " & cedula
                    MsgBox(sql)
                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    conect.Close()
                End If

            End If
            If (CheckBoxamaterno.Checked = True) Then

                If (txtitemamaterno.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql = "UPDATE personas SET "
                    sql += "amaterno= '" & txtitemamaterno.Text & "' "
                    sql += " WHERE ci= " & cedula
                    MsgBox(sql)
                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    conect.Close()
                End If


            End If
            If (CheckBoxdireccion.Checked = True) Then

                If (txtitemdireccion.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql = "UPDATE personas SET "
                    sql += "direccion= '" & txtitemdireccion.Text & "' "
                    sql += " WHERE ci= " & cedula
                    MsgBox(sql)
                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    conect.Close()
                End If

            End If
        End If

        conect.Close()

    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click

        nombre1 = txtnombre1.Text
        nombre2 = txtnombre2.Text
        apaterno = txtapaterno.Text
        amaterno = txtamaterno.Text
        direccion = txtdireccion.Text


        If ((txtnombre1.Text.Length = 0) Or (txtapaterno.Text.Length = 0) Or (txtamaterno.Text.Length = 0) Or (txtdireccion.Text.Length)) Then
            MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
            Return
        Else
            conn()
            modpersona()
            conect.Close()
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