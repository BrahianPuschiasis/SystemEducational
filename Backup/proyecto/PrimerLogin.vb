Public Class PrimerLogin

    Private Sub PrimerLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        conn()

        sql = "SELECT pregunta FROM preguntas"
        Cmd.CommandText = sql
        dr = Cmd.ExecuteReader


        While dr.Read
            cmbPregunta.Items.Add(dr("pregunta"))
        End While

        cmbPregunta.Items.Remove("No tiene pregunta")
        dr.Close()
        cmbPregunta.Items.Remove("No tiene pregunta definida")
        conect.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

    Private Sub btnlisto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlisto.Click
        conn()
        If txtConfirmarContraseña.Visible = True Then
            If txtConfirmarContraseña.Text = txtNuevaContraseña.Text Then
                If txtConfirmarContraseña.Text <> "" And txtNuevaContraseña.Text <> "" Then
                    If txtConfirmarContraseña.Visible = True Then
                        sql1 = "UPDATE usuario set contrasenia= '" & txtConfirmarContraseña.Text & "' where ci= " & cilogin & ""
                        Cmd.CommandText = sql1

                        Cmd.ExecuteNonQuery()
                        MsgBox("¡Contraseña modificada con exito!")
                    End If
                Else
                    MsgBox("ERROR 37:No se puede dejar la contraseña en blanco")

                End If
            Else
                MsgBox("ERROR 38:Las contraseñas no cohensiden")
            End If
        End If
        If cmbPregunta.Visible = True Then
            Dim idpreg As String
            If txtRespuesta.Text <> "" Then
                sql10 = "SELECT idpreg from preguntas where pregunta = '" & cmbPregunta.Text & "'"
                Cmd.CommandText = sql10
                idpreg = Cmd.ExecuteScalar


                sql2 = "UPDATE usuario set respuesta = '" & txtRespuesta.Text & "', idpreg = " & idpreg & " where ci= " & cilogin & " "
                Cmd.CommandText = sql2

                Cmd.ExecuteNonQuery()
                MsgBox("Respuesta y pregunta actualizadas con exito")
            Else
                MsgBox("ERROR 39:La respuesta secreta no puede estar en blanco")
            End If
        End If


        conect.Close()


    End Sub

    Private Sub btnCambiarPregunta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarPregunta.Click
        lblConfirmarContraseña.Visible = False
        lblNuevaContraseña.Visible = False
        txtConfirmarContraseña.Visible = False
        txtNuevaContraseña.Visible = False
        lblPregunta.Visible = True
        lblRespuesta.Visible = True
        cmbPregunta.Visible = True
        txtRespuesta.Visible = True

    End Sub

    Private Sub btnCambiarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarContraseña.Click
        lblConfirmarContraseña.Visible = True
        lblNuevaContraseña.Visible = True
        txtConfirmarContraseña.Visible = True
        txtNuevaContraseña.Visible = True
        lblPregunta.Visible = False
        lblRespuesta.Visible = False
        cmbPregunta.Visible = False
        txtRespuesta.Visible = False
    End Sub

    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click

        If rolelegido = "Docente" Then
            MenuPrincipalDocente.Show()
            Me.Close()
        End If
        If rolelegido = "Administrador" Then
            MenuPrincipalAdministrativo.Show()
            Me.Close()
        End If
        If rolelegido = "Alumno" Then
            MenuPrincipalAlumno.Show()
            Me.Close()
        End If
    End Sub
End Class