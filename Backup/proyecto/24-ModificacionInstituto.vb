Public Class ModInstituto
    Dim idinsta As Integer = 0
    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Dim idinst As Integer
        If lblitem.Visible = False Then
            lblitem.Visible = True
            CheckBoxnom.Visible = True
            CheckBoxdireccion.Visible = True
            btnconfirmar2.Visible = True

            conn()


            sql = "SELECT idinst FROM instituto WHERE nombre='" & cmbnominst.Text & "'"
            Cmd.CommandText = sql
            idinst = Cmd.ExecuteScalar

            sql = "SELECT nombre FROM instituto WHERE idinst='" & idinst & "'"
            Cmd.CommandText = sql
            txtnom.Text = Cmd.ExecuteScalar

            sql = "SELECT direccion FROM instituto WHERE idinst='" & idinst & "'"
            Cmd.CommandText = sql
            txtdir.Text = Cmd.ExecuteScalar

            conect.Close()
            'If (CheckBoxnom.Checked = True) Then

            'End If

            'If (CheckBoxdireccion.Checked = True) Then

            'End If


        Else
            lblitem.Visible = False
            CheckBoxnom.Visible = False
            CheckBoxdireccion.Visible = False
            btnconfirmar2.Visible = False
            CheckBoxnom.Checked = False
            CheckBoxdireccion.Checked = False
        End If
    End Sub

    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarlinea.Click
        
        If lbllinea.Visible = False Then
            lbllinea.Visible = True
            lbldir.Visible = True
            lblnom.Visible = True
            btnconfirmar.Visible = True
            txtdir2.Visible = True
            txtnom2.Visible = True

            conn()

            Dim idinst As Integer
            sql = "SELECT idinst FROM instituto WHERE nombre='" & cmbnominst.Text & "'"
            Cmd.CommandText = sql
            idinst = Cmd.ExecuteScalar

            sql = "SELECT nombre FROM instituto WHERE idinst='" & idinst & "'"
            Cmd.CommandText = sql
            txtnom2.Text = Cmd.ExecuteScalar

            sql = "SELECT direccion FROM instituto WHERE idinst='" & idinst & "'"
            Cmd.CommandText = sql
            txtdir2.Text = Cmd.ExecuteScalar

            conect.Close()

        Else
            lbllinea.Visible = False
            lbldir.Visible = False
            lblnom.Visible = False
            btnconfirmar.Visible = False
            txtdir2.Visible = False
            txtnom2.Visible = False

        End If




    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnConsulta.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaInstituto.Show()
        Me.Close()

    End Sub


    Private Sub Form25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        conn()



        nominst()
        cmbnominst.Items.Clear()
        While dr.Read
            cmbnominst.Items.Add(dr("nombre"))
        End While


        conect.Close()
    End Sub

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub CheckBoxnom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxnom.CheckedChanged

        If txtnom.Visible = False Then
            txtnom.Visible = True
        Else
            txtnom.Visible = False
        End If

    End Sub

    Private Sub CheckBoxdireccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxdireccion.CheckedChanged

        If txtdir.Visible = False Then
            txtdir.Visible = True
        Else
            txtdir.Visible = False
        End If

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        ConsultaInstituto.Show()
        Me.Close()

    End Sub



    Private Sub ModificacionGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionAsignaturaToolStripMenuItem.Click
        ModAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AltaInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaInstitutoToolStripMenuItem.Click
        btnConsulta.Show()
        Me.Close()

    End Sub

    Private Sub AltaGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaGrupoToolStripMenuItem.Click
        AltaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub AltaAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaAsignaturaToolStripMenuItem.Click
        AltaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub BajaAsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaAsignaturaToolStripMenuItem.Click
        BajaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub BajaGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaGrupoToolStripMenuItem.Click
        BajaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub BajaInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaInstitutoToolStripMenuItem.Click
        BajaInstituto.Show()
        Me.Close()

    End Sub

   
    Private Sub btnconfirmar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar2.Click


        conn()

        Dim idinst As Integer = 0
        sql = "SELECT idinst FROM instituto WHERE nombre='" & cmbnominst.Text & "'"
        Cmd.CommandText = sql
        idinst = Cmd.ExecuteScalar

        conect.Close()

        If (idinst <> 0) Then

            If (CheckBoxnom.Checked = True) Then
                If (txtnom.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql = "UPDATE instituto SET "
                    sql += "nombre= '" & txtnom.Text & "' "
                    sql += "WHERE idinst= " & idinst

                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()

   


                    nominst()
                    cmbnominst.Items.Clear()
                    While dr.Read
                        cmbnominst.Items.Add(dr("nombre"))
                    End While


                    conect.Close()
                End If


            End If
            If (CheckBoxdireccion.Checked = True) Then


                If (txtdir.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios ", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql1 = "UPDATE instituto SET "
                    sql1 += "direccion= '" & txtdir.Text & "' "
                    sql1 += "WHERE idinst= " & idinst

                    Cmd.CommandText = sql1

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    lbllinea.Visible = False
                    lbldir.Visible = False
                    lblnom.Visible = False
                    btnconfirmar.Visible = False
                    txtdir2.Visible = False
                    txtnom2.Visible = False
                    lblitem.Visible = False
                    CheckBoxnom.Visible = False
                    CheckBoxdireccion.Visible = False
                    btnconfirmar2.Visible = False
                    txtnom.Visible = False
                    txtdir.Visible = False
                    CheckBoxnom.Checked = False
                    CheckBoxdireccion.Checked = False
                
                    nominst()
                    cmbnominst.Items.Clear()
                    While dr.Read
                        cmbnominst.Items.Add(dr("nombre"))
                    End While


                    conect.Close()
                End If
            End If

        Else
            MsgBox("El ID de Instituto ingresado no esta registrado", MsgBoxStyle.Exclamation, "Aviso")
        End If


        'End If
    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        

        If (((txtdir2.Text.Length = 0) Or (txtnom2.Text.Length = 0)) Or ((txtdir2.Text.Length = 0 And txtnom2.Text.Length = 0))) Then
            MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
            Return
        Else
            conn()
            Dim idinst As Integer = 0
            sql = "SELECT idinst FROM instituto WHERE nombre='" & cmbnominst.Text & "'"
            Cmd.CommandText = sql
            idinst = Cmd.ExecuteScalar

            If (idinst <> 0) Then



                sql = "UPDATE instituto SET "
                sql += "nombre= '" & txtnom2.Text & "', "
                sql += "direccion= '" & txtdir2.Text & "' "
                sql += "WHERE idinst= " & idinst

                Cmd.CommandText = sql
                Cmd.ExecuteNonQuery()

                MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                lbllinea.Visible = False
                lbldir.Visible = False
                lblnom.Visible = False
                btnconfirmar.Visible = False
                txtdir2.Visible = False
                txtnom2.Visible = False
                lblitem.Visible = False
                CheckBoxnom.Visible = False
                CheckBoxdireccion.Visible = False
                btnconfirmar2.Visible = False
                txtnom.Visible = False
                txtdir.Visible = False
                CheckBoxnom.Checked = False
                CheckBoxdireccion.Checked = False
                nominst()
                cmbnominst.Items.Clear()
                While dr.Read
                    cmbnominst.Items.Add(dr("nombre"))
                End While


                conect.Close()


            Else
                MsgBox("El ID de Instituto ingresado no esta registrado", MsgBoxStyle.Exclamation, "Aviso")
            End If

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

    Private Sub btnActivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     

    End Sub

    Private Sub cmbnominst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnominst.SelectedIndexChanged
        conn()




        Try
            sql6 = "SELECT idinst FROM instituto WHERE nombre='" & cmbnominst.Text & "'"
            Cmd.CommandText = sql6

            idinsta = Cmd.ExecuteScalar

        Catch


        End Try


        Try

            sql5 = "Select activo from instituto where idinst = " & idinsta & " "

            Cmd.CommandText = sql5
            Cmd.ExecuteScalar()

            nombre = Cmd.ExecuteScalar



        Catch

           

        End Try

        If nombre = "No activo" Then
            btnActivo.Visible = True
        Else
            btnActivo.Visible = False
        End If

        conect.Close()
    End Sub

    Private Sub btnActivo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivo.Click
        conn()
        sql10 = "UPDATE instituto SET activo= 'Activo' where idinst= " & idinsta & " "
        Cmd.CommandText = sql10
        Cmd.ExecuteNonQuery()


        sql11 = "UPDATE grupo SET activo= 'Activo' where instituto= " & idinsta & " "
        Cmd.CommandText = sql11
        Cmd.ExecuteNonQuery()
        MsgBox("El instituto ha sido activado y sus correspondientes grupos", MsgBoxStyle.Information, "Aviso")



        conect.Close()
    End Sub
End Class