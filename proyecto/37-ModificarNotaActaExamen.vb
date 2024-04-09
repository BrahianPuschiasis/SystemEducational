Public Class ModificarNotaActaExamen

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenuprincipal.Click
        MenuPrincipalDocente.Show()
        Me.Close()

    End Sub

    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarlinea.Click
        If (lblitem.Visible = False) Then

            conn()
            Dim ced As Integer = 9
            sql = "SELECT ci FROM examinado WHERE ci=" & txtci.Text
            Cmd.CommandText = sql
            ced = Cmd.ExecuteScalar
            If (txtci.Text <> "") Then

                If (ced <> 0) Then

                    lbllinea.Visible = True
                    lblnota.Visible = True
                    txtnota.Visible = True
                    lblnoral.Visible = True
                    txtnoral.Visible = True
                    lblnescrita.Visible = True
                    txtnescrita.Visible = True
                    lblfallo.Visible = True
                    txtfallo.Visible = True
                    btnconfirmar.Visible = True

                    sql = "SELECT nota,oral,escrita,fallo FROM examinado"
                    Cmd.CommandText = sql
                    dr = Cmd.ExecuteReader


                    If dr.Read Then
                        txtnota.Text = dr("nota")
                        txtci.Text = dr("oral")
                        txtci.Text = dr("escrita")
                        txtfallo.Text = dr("fallo")
                        dr.Close()

                    End If
                Else
                    MsgBox("La cedula ingresada no esta registrada", MsgBoxStyle.Exclamation, "Aviso")

                End If
            Else
                MsgBox("No ha Ingresado la C.I", MsgBoxStyle.Exclamation, "Aviso")
            End If

            conect.Close()

        Else
            lbllinea.Visible = False
            lblnota.Visible = False
            txtnota.Visible = False
            lblnoral.Visible = False
            txtnoral.Visible = False
            lblnescrita.Visible = False
            txtnescrita.Visible = False
            lblfallo.Visible = False
            txtfallo.Visible = False
            btnconfirmar.Visible = False
        End If



        If lbllinea.Visible = False Then
            lbllinea.Visible = True
            lblnota.Visible = True
            txtnota.Visible = True
            lblnoral.Visible = True
            txtnoral.Visible = True
            lblnescrita.Visible = True
            txtnescrita.Visible = True
            lblfallo.Visible = True
            txtfallo.Visible = True
            btnconfirmar.Visible = True

        Else
            lbllinea.Visible = False
            lblnota.Visible = False
            txtnota.Visible = False
            lblnoral.Visible = False
            txtnoral.Visible = False
            lblnescrita.Visible = False
            txtnescrita.Visible = False
            lblfallo.Visible = False
            txtfallo.Visible = False
            btnconfirmar.Visible = False

         


        End If
    End Sub

    

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click

        If (lblitem.Visible = False) Then

            conn()
            Dim ced As Integer = 9
            sql = "SELECT ci FROM examinado WHERE ci=" & txtci.Text
            Cmd.CommandText = sql
            ced = Cmd.ExecuteScalar
            If (txtci.Text <> "") Then

                If (ced <> 0) Then

                    CheckBoxNota.Visible = True
                    CheckBoxNotaEscrita.Visible = True
                    CheckBoxNotaOral.Visible = True
                    CheckBoxFallo.Visible = True
                    lblitem.Visible = True
                    btnconfirmar2.Visible = True

                    sql = "SELECT nota,oral,escrita,fallo FROM examinado"
                    Cmd.CommandText = sql
                    dr = Cmd.ExecuteReader


                    If dr.Read Then
                        txtModNota.Text = dr("nota")
                        txtModOral.Text = dr("oral")
                        txtModEscrita.Text = dr("escrita")
                        txtModFallo.Text = dr("fallo")
                        dr.Close()

                    End If
                Else
                    MsgBox("La cedula ingresada no esta registrada", MsgBoxStyle.Exclamation, "Aviso")

                End If
            Else
                MsgBox("No ha Ingresado la C.I", MsgBoxStyle.Exclamation, "Aviso")
            End If

            conect.Close()

        Else
            CheckBoxNota.Visible = False
            CheckBoxNotaEscrita.Visible = False
            CheckBoxNotaOral.Visible = False
            CheckBoxFallo.Visible = False
            lblitem.Visible = False
            CheckBoxNota.Checked = False
            CheckBoxNotaEscrita.Checked = False
            CheckBoxNotaOral.Checked = False
            CheckBoxFallo.Checked = False
            btnconfirmar2.Visible = False
        End If




        

    End Sub

    Private Sub CheckBoxNota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtModNota.Visible = False Then
            txtModNota.Visible = True
        Else
            txtModNota.Visible = False
        End If
    End Sub

    Private Sub CheckBoxNotaOral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtModOral.Visible = False Then
            txtModOral.Visible = True
        Else
            txtModOral.Visible = False
        End If
    End Sub

    Private Sub CheckBoxNotaEscrita_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtModEscrita.Visible = False Then
            txtModEscrita.Visible = True
        Else
            txtModEscrita.Visible = False
        End If
    End Sub

    Private Sub CheckBoxFallo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtModFallo.Visible = False Then
            txtModFallo.Visible = True
        Else
            txtModFallo.Visible = False
        End If
    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click

    End Sub




    Private Sub IngresarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarNotaToolStripMenuItem.Click
        IngreseNotaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ModificarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarNotaToolStripMenuItem.Click
        ModificarNotaActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub GrupoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoToolStripMenuItem1.Click
        ConsultaGrupoDocente.Show()
        Me.Close()
    End Sub

    Private Sub NotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaNotaActaFinalDocente.Show()
        Me.Close()
    End Sub

    Private Sub DatosPersonalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosPersonalesToolStripMenuItem.Click
        ConsultaDatosPersonales.Show()
        Me.Close()
    End Sub

    Private Sub ModificarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarNotaToolStripMenuItem1.Click
        IngresarNotaActaExamen.Show()
        Me.Close()

    End Sub
    Private Sub lblcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

   
    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        MenuPrincipalDocente.Show()
        Me.Close()
    End Sub

    Private Sub ActaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaToolStripMenuItem.Click

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

    Private Sub txtModNota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModNota.KeyPress
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

    Private Sub txtModNota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModNota.TextChanged

    End Sub

    Private Sub txtModOral_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModOral.KeyPress
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

    Private Sub txtModOral_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModOral.TextChanged

    End Sub

    Private Sub txtModEscrita_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModEscrita.KeyPress
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

    Private Sub txtModEscrita_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModEscrita.TextChanged

    End Sub

    Private Sub txtModFallo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModFallo.TextChanged

    End Sub

    Private Sub txtnota_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnota.KeyDown

    End Sub

    Private Sub txtnota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnota.KeyPress
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

    Private Sub txtnota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnota.TextChanged

    End Sub

    Private Sub txtnoral_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnoral.KeyPress
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

    Private Sub txtnoral_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnoral.TextChanged

    End Sub

    Private Sub txtnescrita_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnescrita.KeyPress
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

    Private Sub txtnescrita_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnescrita.TextChanged

    End Sub
End Class