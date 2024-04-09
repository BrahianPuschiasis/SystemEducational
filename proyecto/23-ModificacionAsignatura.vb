Public Class ModAsignatura

    Dim idasig As Integer = 0

    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAsignatura.Show()
        Me.Close()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAsignatura.Show()
        Me.Close()
    End Sub



    Private Sub Form24_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        conn()

        sql = "SELECT nombre FROM asignatura"
        Cmd.CommandText = sql
        dr = Cmd.ExecuteReader

        cmbnomasig.Items.Clear()
        While dr.Read
            cmbnomasig.Items.Add(dr("nombre"))
        End While


        conect.Close()
        
    End Sub

   
    Private Sub AltaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDirectorToolStripMenuItem.Click
        AltaAdministrativo.Show()
        Me.Close()

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
        BajaAdministrativo.Show()
        Me.Close()

    End Sub

  

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        ConsultaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub BajaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaAlumnoToolStripMenuItem.Click
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionInstitutoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionInstitutoToolStripMenuItem.Click
        ModInstituto.Show()
        Me.Close()

    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click

        If (txtnomasing.Text.Length = 0) Then
            MsgBox("Error, el campo/s a modificar estan vacios ", MsgBoxStyle.Critical, "Aviso")
            Return
        Else
            conn()


            Dim idasign As Integer = 0
            sql = "SELECT idasig FROM asignatura WHERE nombre='" & cmbnomasig.Text & "'"
            Cmd.CommandText = sql
            idasign = Cmd.ExecuteScalar


            If (idasign <> 0) Then

                sql = "UPDATE asignatura SET "
                sql += "nombre='" & txtnomasing.Text & "' "
                sql += "WHERE idasig= " & idasign

                Cmd.CommandText = sql

                Cmd.ExecuteNonQuery()
                MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                btnActivo.Visible = False
                sql = "SELECT nombre FROM asignatura"
                Cmd.CommandText = sql
                dr = Cmd.ExecuteReader

                cmbnomasig.Items.Clear()
                While dr.Read
                    cmbnomasig.Items.Add(dr("nombre"))
                End While

                lblnomasign.Visible = False
                btnconfirmar.Visible = False
                lbllinea.Visible = False
                txtnomasing.Visible = False
            Else
                MsgBox("El ID de asignatura no esta registrado", MsgBoxStyle.Exclamation, "Aviso")
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

    Private Sub cmbnomasig_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnomasig.SelectedIndexChanged

        If lbllinea.Visible = False Then
            lblnomasign.Visible = True
            btnconfirmar.Visible = True
            lbllinea.Visible = True
            txtnomasing.Visible = True


            conn()




            Try
                sql6 = "SELECT idasig FROM asignatura WHERE nombre='" & cmbnomasig.Text & "'"
                Cmd.CommandText = sql6

                idasig = Cmd.ExecuteScalar

            Catch


            End Try


            Try

                sql5 = "Select activo from asignatura where idasig = " & idasig & " "

                Cmd.CommandText = sql5
                Cmd.ExecuteScalar()
                nombre = Cmd.ExecuteScalar

                If nombre = "No activo" Then
                    btnActivo.Visible = True
                Else
                    btnActivo.Visible = False
                End If

            Catch



            End Try

         



            Dim idasign As Integer = 0
            sql = "SELECT idasig FROM asignatura WHERE nombre='" & cmbnomasig.Text & "'"
            Cmd.CommandText = sql
            idasign = Cmd.ExecuteScalar

            Dim nomasig As String = ""
            sql = "SELECT nombre FROM asignatura WHERE idasig=" & idasign
            Cmd.CommandText = sql
            nomasig = Cmd.ExecuteScalar

            txtnomasing.Text = nomasig
            conect.Close()

        Else
            lblnomasign.Visible = False
            btnconfirmar.Visible = False
            lbllinea.Visible = False
            txtnomasing.Visible = False

        End If



    End Sub

  

    Private Sub btnActivo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivo.Click
        conn()
        sql10 = "UPDATE asignatura SET activo= 'Activo' where idasig= " & idasig & " "
        Cmd.CommandText = sql10
        Cmd.ExecuteNonQuery()
        MsgBox("La asignatura ha sido activado", MsgBoxStyle.Information, "Aviso")
        conect.Close()
    End Sub
End Class