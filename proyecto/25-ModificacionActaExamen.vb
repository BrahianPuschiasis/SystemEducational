Public Class ModActaExamen

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click

        If (lblitem.Visible = False) Then

            conn()
            Dim numactae As Integer = 0
            sql = "SELECT n_actae FROM actae WHERE n_actae=" & cmbnunacta.Text
            Cmd.CommandText = sql
            numactae = Cmd.ExecuteScalar

            If (numactae <> 0) Then

                lblitem.Visible = True
                CheckBoxaño.Visible = True
                CheckBoxfallo.Visible = True
                CheckBoxidgrupo.Visible = True
                CheckBoxidasign.Visible = True
                CheckBoxverifico.Visible = True
                CheckBoxpresidente.Visible = True
                CheckBoxsecretario.Visible = True
                CheckBoxvocal.Visible = True
                btnconfirmar2.Visible = True

                


                sql1 = "SELECT anio,idgrupo,idasig,verifico,presidente,secretario,vocal "
                sql1 += "FROM actae "
                sql1 += "WHERE n_actae = " & cmbnunacta.Text

                Cmd.CommandText = sql1
                dr = Cmd.ExecuteReader

                Dim idgrup As Integer = 0
                Dim idasig As Integer = 0
                If dr.Read Then
                    txtaño2.Text = dr("anio")
                    idgrup = dr("idgrupo")
                    idasig = dr("idasig")
                    txtverifico2.Text = dr("verifico")
                    txtpresidente2.Text = dr("presidente")
                    txtsecretario2.Text = dr("secretario")
                    txtvocal2.Text = dr("vocal")

                End If
                dr.Close()

                sql2 = "SELECT nombre FROM grupo"
                Cmd.CommandText = sql2
                dr = Cmd.ExecuteReader

                cmbgrupo.Items.Clear()
                While dr.Read
                    cmbgrupo2.Items.Add(dr("nombre"))
                End While
                dr.Close()

                Dim nomgrup As String
                sql3 = "SELECT nombre FROM grupo"
                sql3 += " WHERE idgrupo=" & idgrup
                Cmd.CommandText = sql3
                nomgrup = Cmd.ExecuteScalar
                cmbgrupo2.Text = nomgrup

                '--------------------

                sql4 = "SELECT nombre FROM asignatura"
                Cmd.CommandText = sql4
                dr = Cmd.ExecuteReader

                cmbasig2.Items.Clear()
                While dr.Read
                    cmbasig2.Items.Add(dr("nombre"))
                End While
                dr.Close()

                Dim nomasig As String
                sql5 = "SELECT nombre FROM asignatura"
                sql5 += " WHERE idasig=" & idasig
                Cmd.CommandText = sql5
                nomasig = Cmd.ExecuteScalar
                cmbasig2.Text = nomasig

            Else
                MsgBox("No ha Elegido ningun numero de Acta de Examen", MsgBoxStyle.Exclamation, "Aviso")
            End If

            conect.Close()

        Else
            lblitem.Visible = False
            CheckBoxaño.Visible = False
            CheckBoxfallo.Visible = False
            CheckBoxidgrupo.Visible = False
            CheckBoxidasign.Visible = False
            CheckBoxverifico.Visible = False
            CheckBoxpresidente.Visible = False
            CheckBoxsecretario.Visible = False
            CheckBoxvocal.Visible = False
            btnconfirmar2.Visible = False
            CheckBoxaño.Checked = False
            CheckBoxfallo.Checked = False
            CheckBoxidgrupo.Checked = False
            CheckBoxidasign.Checked = False
            CheckBoxverifico.Checked = False
            CheckBoxpresidente.Checked = False
            CheckBoxsecretario.Checked = False
            CheckBoxvocal.Checked = False
        End If

    End Sub

    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarlinea.Click
        If (lblitem.Visible = False) Then

            conn()
            Dim numactae As Integer = 0
            sql = "SELECT n_actae FROM actae WHERE n_actae=" & cmbnunacta.Text
            Cmd.CommandText = sql
            numactae = Cmd.ExecuteScalar

            If (numactae <> 0) Then

                lbllinea.Visible = True
                btnconfirmar.Visible = True
                lblaño.Visible = True
                lblfallo.Visible = True
                lblidgrupo.Visible = True
                lblidasign.Visible = True
                lblverifico.Visible = True
                lblpresidente.Visible = True
                lblsecretario.Visible = True
                lblvocal.Visible = True
                txtaño.Visible = True
                cmbfallo.Visible = True
                cmbgrupo.Visible = True
                cmbasig.Visible = True
                txtverifico.Visible = True
                txtpresidente.Visible = True
                txtsecretario.Visible = True
                txtvocal.Visible = True




                sql1 = "SELECT fecha,anio,idgrupo,idasig,verifico,presidente,secretario,vocal,instituto "
                sql1 += "FROM actae "
                sql1 += "WHERE n_actae = " & cmbnunacta.Text
                Cmd.CommandText = sql1
                dr = Cmd.ExecuteReader

                Dim idgrup As Integer
                Dim idasig As Integer
                If dr.Read Then
                    txtaño.Text = dr("anio")
                    idgrup = dr("idgrupo")
                    idasig = dr("idasig")
                    txtverifico.Text = dr("verifico")
                    txtpresidente.Text = dr("presidente")
                    txtsecretario.Text = dr("secretario")
                    txtvocal.Text = dr("vocal")

                    dr.Close()
                End If


                sql2 = "SELECT nombre FROM grupo"
                Cmd.CommandText = sql2
                dr = Cmd.ExecuteReader

                cmbgrupo.Items.Clear()
                While dr.Read
                    cmbgrupo.Items.Add(dr("nombre"))
                End While
                dr.Close()

                Dim nomgrup As String
                sql3 = "SELECT nombre FROM grupo"
                sql3 += " WHERE idgrupo=" & idgrup
                Cmd.CommandText = sql3
                nomgrup = Cmd.ExecuteScalar
                cmbgrupo.Text = nomgrup
                '--------------------

                sql4 = "SELECT nombre FROM asignatura"
                Cmd.CommandText = sql4
                dr = Cmd.ExecuteReader

                cmbasig.Items.Clear()
                While dr.Read
                    cmbasig.Items.Add(dr("nombre"))
                End While
                dr.Close()

                Dim nomasig As String
                sql5 = "SELECT nombre FROM asignatura"
                sql5 += " WHERE idasig=" & idasig
                Cmd.CommandText = sql5
                nomasig = Cmd.ExecuteScalar
                cmbasig.Text = nomasig

            Else
                MsgBox("No ha Elegido ningun numero de Acta de Examen", MsgBoxStyle.Exclamation, "Aviso")
            End If

            conect.Close()

        Else
            lbllinea.Visible = False
            btnconfirmar.Visible = False
            lblaño.Visible = False
            lblfallo.Visible = False
            lblidgrupo.Visible = False
            lblidasign.Visible = False
            lblverifico.Visible = False
            lblpresidente.Visible = False
            lblsecretario.Visible = False
            lblvocal.Visible = False
            txtaño.Visible = False
            cmbfallo.Visible = False
            cmbgrupo.Visible = False
            cmbasig.Visible = False
            txtverifico.Visible = False
            txtpresidente.Visible = False
            txtsecretario.Visible = False
            txtvocal.Visible = False
        End If


    End Sub

    Private Sub CheckBoxaño_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtaño2.Visible = False Then
            txtaño2.Visible = True
        Else
            txtaño2.Visible = False
        End If

    End Sub

    Private Sub CheckBoxfallo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbfallo2.Visible = False Then
            cmbfallo2.Visible = True
        Else
            cmbfallo2.Visible = False
        End If
    End Sub

    Private Sub CheckBoxidgrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbgrupo2.Visible = False Then
            cmbgrupo2.Visible = True
        Else
            cmbgrupo2.Visible = False
        End If

    End Sub

    Private Sub CheckBoxidasign_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If cmbasig2.Visible = False Then
            cmbasig2.Visible = True
        Else
            cmbasig2.Visible = False
        End If
    End Sub

    Private Sub CheckBoxverifico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtverifico2.Visible = False Then
            txtverifico2.Visible = True
        Else
            txtverifico2.Visible = False
        End If

    End Sub

    Private Sub CheckBoxpresidente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtpresidente2.Visible = False Then
            txtpresidente2.Visible = True
        Else
            txtpresidente2.Visible = False
        End If

    End Sub

    Private Sub CheckBoxsecretario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtsecretario2.Visible = False Then
            txtsecretario2.Visible = True
        Else
            txtsecretario2.Visible = False
        End If

    End Sub

    Private Sub CheckBoxvocal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtvocal2.Visible = False Then
            txtvocal2.Visible = True
        Else
            txtvocal2.Visible = False
        End If

    End Sub

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaExamen.Show()
        Me.Close()

    End Sub



    Private Sub ActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        conn()

        sql = "SELECT n_actae FROM actae"
        Cmd.CommandText = sql
        dr = Cmd.ExecuteReader

        cmbnunacta.Items.Clear()
        While dr.Read
            cmbnunacta.Items.Add(dr("n_actae"))
        End While

        conect.Close()

    End Sub

    Private Sub AltaDeActaDeExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeActaDeExamenToolStripMenuItem.Click
        AltaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub AltaDeActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem1.Click
        BajaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub BajaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaFinal.Show()
        Me.Close()

    End Sub


    Private Sub ConsultaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaActaExamenToolStripMenuItem.Click
        ConsultaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ConsultaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ModifiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifiToolStripMenuItem.Click
        ModActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ActaFinalToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaFinalToolStripMenuItem2.Click
        ConsultaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ActaFinalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaFinalToolStripMenuItem1.Click
        BajaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ActaFinalToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaFinalToolStripMenuItem.Click
        AltaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub btnconfirmar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar2.Click

        conn()
        Dim numactae As Integer = 0
        sql = "SELECT n_actae FROM actae WHERE n_actae=" & cmbnunacta.Text
        Cmd.CommandText = sql
        numactae = Cmd.ExecuteScalar
        conect.Close()

        If (numactae <> 0) Then



            If (CheckBoxaño.Checked = True) Then

                If (txtaño2.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql = "UPDATE actae SET "
                    sql += "anio= " & txtaño2.Text & " "
                    sql += "WHERE n_actae= " & numactae
                    MsgBox(sql)
                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("El año ha sido modificados", MsgBoxStyle.Information, "Aviso")
                    conect.Close()
                End If

            End If

            'If (CheckBoxfallo.Checked = True) Then
            '    sql = "UPDATE actae SET "
            '    sql += "= " & txtaño2.Text & ""
            '    sql += "WHERE n_actae= " & numactae
            '    MsgBox(sql)
            '    Cmd.CommandText = sql

            '    Cmd.ExecuteNonQuery()
            '    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")

            'End If


            If (CheckBoxidgrupo.Checked = True) Then


                If (cmbgrupo2.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    Dim idgru As Integer = 0
                    sql3 = "SELECT idgrupo FROM grupo"
                    sql3 += " WHERE nombre='" & cmbgrupo2.Text & "' "
                    Cmd.CommandText = sql3
                    idgru = Cmd.ExecuteScalar
                    MsgBox(idgru)

                    If (idgru <> 0) Then
                        sql = "UPDATE actae SET "
                        sql += "idgrupo= " & idgru & " "
                        sql += "WHERE n_actae= " & numactae
                        MsgBox(sql)
                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                        MsgBox("El grupo ha sido modificados", MsgBoxStyle.Information, "Aviso")
                    End If
                    conect.Close()
                End If

            End If

            If (CheckBoxidasign.Checked = True) Then

                If (cmbasig2.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    Dim idasig As Integer
                    sql3 = "SELECT idasig FROM asignatura"
                    sql3 += " WHERE nombre='" & cmbasig2.Text & "' "
                    Cmd.CommandText = sql3
                    idasig = Cmd.ExecuteScalar

                    If (idasig <> 0) Then
                        sql = "UPDATE actae SET "
                        sql += "idasig= " & idasig & " "
                        sql += "WHERE n_actae= " & numactae
                        MsgBox(sql)
                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                        MsgBox("La aignatura ha sido modificados", MsgBoxStyle.Information, "Aviso")
                    End If
                    conect.Close()

                End If


                If (CheckBoxverifico.Checked = True) Then

                    If (txtverifico2.Text.Length = 0) Then
                        MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                        Return
                    Else
                        conn()
                        sql = "UPDATE actae SET "
                        sql += "verifico= " & txtverifico2.Text & " "
                        sql += "WHERE n_actae= " & numactae
                        MsgBox(sql)
                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                        MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                        conect.Close()
                    End If

                End If


                If (CheckBoxpresidente.Checked = True) Then

                    If (txtpresidente2.Text.Length = 0) Then
                        MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                        Return
                    Else
                        conn()
                        sql = "UPDATE actae SET "
                        sql += "precidente= " & txtpresidente2.Text & " "
                        sql += "WHERE n_actae= " & numactae
                        MsgBox(sql)
                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                        MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                        conect.Close()
                    End If



                End If


                If (CheckBoxsecretario.Checked = True) Then

                    If (txtsecretario2.Text.Length = 0) Then
                        MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                        Return
                    Else
                        conn()
                        sql = "UPDATE actae SET "
                        sql += "secretario= " & txtsecretario2.Text & " "
                        sql += "WHERE n_actae= " & numactae
                        MsgBox(sql)
                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                        MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                        conect.Close()
                    End If



                End If


                If (CheckBoxvocal.Checked = True) Then

                    If (txtvocal2.Text.Length = 0) Then
                        MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                        Return
                    Else
                        conn()
                        sql = "UPDATE actae SET "
                        sql += "vocal= " & txtvocal2.Text & " "
                        sql += "WHERE n_actae= " & numactae
                        MsgBox(sql)
                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                        MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                        conect.Close()
                    End If

                End If

            Else
                MsgBox("No ha Elegido ningun numero de Acta de Examen", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
        conect.Close()

    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        conn()
        Dim numactae As Integer = 0
        sql = "SELECT n_actae FROM actae WHERE n_actae=" & cmbnunacta.Text
        Cmd.CommandText = sql
        numactae = Cmd.ExecuteScalar
        conect.Close()

        If (numactae <> 0) Then


            If ((txtaño.Text.Length = 0) Or (cmbgrupo.Text.Length = 0) Or (cmbasig.Text.Length = 0) Or (txtverifico.Text.Length = 0) Or (txtpresidente.Text.Length) Or (txtsecretario.Text.Length = 0) Or (txtvocal.Text.Length = 0)) Then
                If (CheckBoxaño.Checked = True) Then

                    If (txtaño2.Text.Length = 0) Then
                        MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                        Return
                    Else
                        conn()

                        Dim idgru As String
                        sql3 = "SELECT idgrup FROM grupo"
                        sql3 += " WHERE nombre='" & cmbgrupo.Text & "' "
                        Cmd.CommandText = sql3
                        idgru = Cmd.ExecuteScalar

                        Dim idasig As String
                        sql3 = "SELECT idasig FROM asignatura"
                        sql3 += " WHERE nombre='" & cmbasig.Text & "' "
                        Cmd.CommandText = sql3
                        idasig = Cmd.ExecuteScalar

                        sql = "UPDATE actae SET "
                        sql += "anio= " & txtaño.Text & ", "
                        sql += "idgrupo= " & idgru & ", "
                        sql += "idasig= " & idasig & ", "
                        sql += "verifico= " & txtverifico.Text & ", "
                        sql += "precidente= " & txtpresidente.Text & ", "
                        sql += "secretario= " & txtsecretario.Text & ", "
                        sql += "vocal= " & txtvocal.Text & " "
                        sql += "WHERE n_actae= " & numactae
                        MsgBox(sql)
                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                        MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                        conect.Close()

                    End If
                Else

                    MsgBox("No ha Elegido ningun numero de Acta de Examen", MsgBoxStyle.Exclamation, "Aviso")
                End If
            End If


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