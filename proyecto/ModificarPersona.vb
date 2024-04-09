Public Class ModDocente
    Dim datoscragados As Boolean

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub DirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectorToolStripMenuItem.Click

        AltaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosToolStripMenuItem.Click
        AltaAlumno.Show()
        Me.Close()
    End Sub

    Private Sub DocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocenteToolStripMenuItem.Click

        AltaDocente.Show()
        Me.Close()
    End Sub

    Private Sub AsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignaturaToolStripMenuItem.Click

        AltaAsignatura.Show()
        Me.Close()
    End Sub

    Private Sub GrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoToolStripMenuItem.Click

        AltaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ActaDeExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaDeExamenToolStripMenuItem.Click
        AltaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub ActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaFinalToolStripMenuItem.Click
        AltaActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub







    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaDocente.Show()
        Me.Close()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaDocente.Show()
        Me.Close()
    End Sub

    Private Sub DirectorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub AlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAlumno.Show()
        Me.Close()
    End Sub

    Private Sub Form20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CmbConsultaListado.Show()
        Me.Close()

    End Sub

    Private Sub BajaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDirectorToolStripMenuItem.Click
        BajaAdministrativo.Show()
        Me.Close()

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

    Private Sub BajaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDocenteToolStripMenuItem.Click
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub BajaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaAlumnoToolStripMenuItem.Click
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()

    End Sub


    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        If ((txtnombre1.Text.Length) Or (txtapaterno.Text.Length) Or (txtamaterno.Text.Length) Or (txtdireccion.Text.Length)) = 0 Then

            Return
        Else
            conn()

            conect.Close()
        End If
        Dim ci = txtci.Text
        Dim cedula
        cedula = Mid(ci, 1, 8)
        Dim Digito As String = cedula
        Dim ultimonum As Integer

        Dim r1, r2, r3, r4, r5, r6, r7 As Integer
        Dim DV As Integer
        Dim final As Integer
        Dim cuenta As Integer
        Dim contador
        Dim numero As Integer



        If txtci.Text.Length = 0 Then Return


        contador = 0

        For contador = 1 To 8 Step 1


            Select Case contador

                Case 1
                    Digito = ci(0)
                    r1 = Digito * 2
                    ' MsgBox(r1)
                Case 2
                    Digito = ci(1)
                    r2 = Digito * 9
                    'MsgBox(r2)
                Case 3
                    Digito = ci(2)
                    r3 = Digito * 8
                    'MsgBox(r3)
                Case 4
                    Digito = ci(3)
                    r4 = Digito * 7
                    'MsgBox(r4)
                Case 5
                    Digito = ci(4)
                    r5 = Digito * 6
                    'MsgBox(r5)
                Case 6
                    Digito = ci(5)
                    r6 = Digito * 3
                    ' MsgBox(r6)
                Case 7
                    Digito = ci(6)
                    r7 = Digito * 4
                    'MsgBox(r7)

            End Select





        Next
        DV = r1 + r2 + r3 + r4 + r5 + r6 + r7
        cuenta = DV.ToString.Length

        numero = Mid(DV, cuenta, cuenta)
        ultimonum = Mid(ci, 8, 8)


        final = 10 - numero

        If final = 10 Then
            final = 0
        End If



        If final = ultimonum Then



            If (txtci.Text <> "") Then

                nombre1 = txtnombre1.Text
                nombre2 = txtnombre2.Text
                apaterno = txtapaterno.Text
                amaterno = txtamaterno.Text
                direccion = txtdireccion.Text
                conn()
                sql = "Update personas  set nombre1= '" & nombre1 & "',nombre2='" & nombre2 & "',apaterno='" & apaterno & "',amaterno='" & amaterno & "',direccion='" & direccion & "' where ci=" & txtci.Text & ""
                Cmd.CommandText = sql

                Cmd.ExecuteNonQuery()
                MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                conect.Close()
            Else
                MsgBox("La cedula ingresada no esta registrada", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("CI Falsa", MsgBoxStyle.Exclamation, "Error")


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

    Private Sub btnmodificarlinea_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarlinea.Click
        conn()

        Dim ci = txtci.Text
        Dim cedula
        cedula = Mid(ci, 1, 8)
        Dim Digito As String = cedula
        Dim ultimonum As Integer

        Dim r1, r2, r3, r4, r5, r6, r7 As Integer
        Dim DV As Integer
        Dim final As Integer
        Dim cuenta As Integer
        Dim contador
        Dim numero As Integer



        If txtci.Text.Length = 0 Then Return


        contador = 0

        For contador = 1 To 8 Step 1


            Select Case contador

                Case 1
                    Digito = ci(0)
                    r1 = Digito * 2
                    ' MsgBox(r1)
                Case 2
                    Digito = ci(1)
                    r2 = Digito * 9
                    'MsgBox(r2)
                Case 3
                    Digito = ci(2)
                    r3 = Digito * 8
                    'MsgBox(r3)
                Case 4
                    Digito = ci(3)
                    r4 = Digito * 7
                    'MsgBox(r4)
                Case 5
                    Digito = ci(4)
                    r5 = Digito * 6
                    'MsgBox(r5)
                Case 6
                    Digito = ci(5)
                    r6 = Digito * 3
                    ' MsgBox(r6)
                Case 7
                    Digito = ci(6)
                    r7 = Digito * 4
                    'MsgBox(r7)

            End Select





        Next
        DV = r1 + r2 + r3 + r4 + r5 + r6 + r7
        cuenta = DV.ToString.Length

        numero = Mid(DV, cuenta, cuenta)
        ultimonum = Mid(ci, 8, 8)


        final = 10 - numero

        If final = 10 Then
            final = 0
        End If



        If final = ultimonum Then
            btnconfirmar.Visible = True
            txtamaterno.Visible = True
            txtapaterno.Visible = True
            txtnombre1.Visible = True
            txtnombre2.Visible = True
            txtdireccion.Visible = True
            lblamaterno.Visible = True
            lbldireccion.Visible = True
            lbllinea.Visible = True
            lblnombre1.Visible = True
            lblnombre2.Visible = True
            lblapaterno.Visible = True




            If (txtci.Text <> "") Then
                sql = "SELECT ci FROM personas WHERE ci=" & txtci.Text
                Cmd.CommandText = sql
                ci = Cmd.ExecuteScalar



                sql1 = "SELECT nombre1,nombre2,apaterno,amaterno,direccion "
                sql1 += "FROM personas "
                sql1 += "WHERE ci = " & txtci.Text

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
            End If


        Else
            MsgBox("CI Falsa", MsgBoxStyle.Exclamation, "Error")


        End If

        conect.Close()

    End Sub

    Private Sub txtnombre1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre1.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre1.TextChanged

    End Sub

    Private Sub txtapaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapaterno.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtapaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapaterno.TextChanged

    End Sub

    Private Sub txtnombre2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre2.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre2.TextChanged

    End Sub

    Private Sub txtamaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamaterno.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtamaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamaterno.TextChanged

    End Sub

    Private Sub txtci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtci.KeyPress

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

    Private Sub txtci_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtci.MaskInputRejected

    End Sub
End Class