Public Class BajaAdministrativo
   



    Private Sub AlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaAlumno.Show()
        Me.Close()
    End Sub

    Private Sub DocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaDocente.Show()
        Me.Close()
    End Sub

    Private Sub AsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaAsignatura.Show()
        Me.Close()
    End Sub

    Private Sub GrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ActaDeExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub ActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaActaFinal.Show()
        Me.Close()
    End Sub



    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaDocente.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModDocente.Show()
        Me.Close()

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CmbConsultaListado.Show()
        Me.Close()

    End Sub




    Private Sub AltaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDocenteToolStripMenuItem.Click
        AltaDocente.Show()
        Me.Close()

    End Sub

    Private Sub AltaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaAlumnoToolStripMenuItem.Click
        AltaAlumno.Show()
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



    Private Sub ModifacoinDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifacoinDocenteToolStripMenuItem.Click
        ModDocente.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionAlumnoToolStripMenuItem.Click
        ModAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDirectorToolStripMenuItem.Click
        modAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub txtcibaja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ConsultasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        CmbConsultaListado.Show()
        Me.Close()

    End Sub

    Private Sub AltaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDirectorToolStripMenuItem.Click
        AltaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        If txtcibaja.Text.Length < 8 Then Return
        Dim ci = txtcibaja.Text
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



        If txtcibaja.Text.Length = 0 Then Return


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

            conn()
            If (txtcibaja.Text <> "") Then
                sql = "SELECT ci FROM personas WHERE ci=" & txtcibaja.Text
                Cmd.CommandText = sql
                cedula = Cmd.ExecuteScalar

                If (cedula <> 0) Then


                    sql1 = "UPDATE administra SET "
                    sql1 += " activo= '" & "No activo" & "'"
                    sql1 += " WHERE ci=" & txtcibaja.Text

                    Cmd.CommandText = sql1

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los Datos han sido actualizados", MsgBoxStyle.Information, "Aviso")
                    conect.Close()
                Else
                    MsgBox("La C.I ingresada no esta registrada", MsgBoxStyle.Exclamation, "Aviso")
                End If


            Else
                MsgBox("No ha ingresado ninguna C.I", MsgBoxStyle.Exclamation, "Aviso")
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

    Private Sub txtcibaja_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcibaja.MaskInputRejected

    End Sub
    Private Sub txtcibaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcibaja.KeyPress

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
End Class