Public Class ModActaFinal

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        
        If lblitem.Visible = False Then
            CheckBoxIdInst.Visible = True
            CheckBoxIdGrupo.Visible = True
            CheckBoxaño.Visible = True
            CheckBoxsemestre.Visible = True
            CheckBoxLocalidad.Visible = True
            CheckBoxingreso.Visible = True
            CheckBoxverifico.Visible = True
            CheckBoxsecretario.Visible = True
            CheckBoxdirector.Visible = True
            txtidinst2.Visible = False
            txtidgrupo2.Visible = False
            txtaño2.Visible = False
            txtsemestre2.Visible = False
            txtlocalidad2.Visible = False
            txtingreso2.Visible = False
            txtverifico2.Visible = False
            txtsecretario2.Visible = False
            txtdir2.Visible = False
            btnconfirmar2.Visible = True
            lblitem.Visible = True

        Else
            CheckBoxIdInst.Visible = False
            CheckBoxIdGrupo.Visible = False
            CheckBoxaño.Visible = False
            CheckBoxsemestre.Visible = False
            CheckBoxLocalidad.Visible = False
            CheckBoxingreso.Visible = False
            CheckBoxverifico.Visible = False
            CheckBoxsecretario.Visible = False
            CheckBoxdirector.Visible = False
            txtidinst2.Visible = False
            txtidgrupo2.Visible = False
            txtaño2.Visible = False
            txtsemestre2.Visible = False
            txtlocalidad2.Visible = False
            txtingreso2.Visible = False
            txtverifico2.Visible = False
            txtsecretario2.Visible = False
            txtdir2.Visible = False
            btnconfirmar2.Visible = False
            lblitem.Visible = False
            


        End If
    End Sub

    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarlinea.Click
     
        If lbllinea.Visible = False Then
            lbllinea.Visible = True
            txtidinst.Visible = True
            txtidgrupo.Visible = True
            txtaño.Visible = True
            txtsemestre.Visible = True
            txtlocalidad.Visible = True
            txtingresoalacta.Visible = True
            txtverifico.Visible = True
            txtsectretario.Visible = True
            txtdirector.Visible = True
            lblidinst.Visible = True
            lblidgrupo.Visible = True
            lblaño.Visible = True
            lblsemestre.Visible = True
            lbllocalidad.Visible = True
            lblingresoalacta.Visible = True
            lblverifico.Visible = True
            lblsectretario.Visible = True
            lbldirector.Visible = True
            btnconfirmar.Visible = True
        Else
            lbllinea.Visible = False
            txtidinst.Visible = False
            txtidgrupo.Visible = False
            txtaño.Visible = False
            txtsemestre.Visible = False
            txtlocalidad.Visible = False
            txtingresoalacta.Visible = False
            txtverifico.Visible = False
            txtsectretario.Visible = False
            txtdirector.Visible = False
            lblidinst.Visible = False
            lblidgrupo.Visible = False
            lblaño.Visible = False
            lblsemestre.Visible = False
            lbllocalidad.Visible = False
            lblingresoalacta.Visible = False
            lblverifico.Visible = False
            lblsectretario.Visible = False
            lbldirector.Visible = False
            btnconfirmar.Visible = False


        End If


    End Sub

    Private Sub CheckBoxaño_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtaño2.Visible = False Then
            txtaño2.Visible = True
        Else
            txtaño2.Visible = False
        End If
    End Sub

    Private Sub CheckBoxsemestre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtsemestre2.Visible = False Then
            txtsemestre2.Visible = True
        Else
            txtsemestre2.Visible = False
        End If

    End Sub

    Private Sub CheckBoxingreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtingreso2.Visible = False Then
            txtingreso2.Visible = True
        Else
            txtingreso2.Visible = False
        End If

    End Sub

    Private Sub CheckBoxverifico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtverifico2.Visible = False Then
            txtverifico2.Visible = True
        Else
            txtverifico2.Visible = False
        End If

    End Sub

    Private Sub CheckBoxsecretario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtsecretario2.Visible = False Then
            txtsecretario2.Visible = True
        Else
            txtsecretario2.Visible = False
        End If

    End Sub

    Private Sub CheckBoxdirector_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtdir2.Visible = False Then
            txtdir2.Visible = True
        Else
            txtdir2.Visible = False
        End If

    End Sub

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaFinal.Show()
        Me.Close()
    End Sub



    Private Sub ActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub BajaAUnaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaAUnaActaFinalToolStripMenuItem.Click
        BajaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub AltaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaActaFinalToolStripMenuItem.Click
        BajaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionActaExamenToolStripMenuItem.Click
        ModActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub txtingreso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ActaExamenToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaExamenToolStripMenuItem2.Click
        ConsultaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ActaExamenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaExamenToolStripMenuItem1.Click
        BajaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ActaExamenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaExamenToolStripMenuItem.Click
        AltaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub CheckBoxLocalidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtlocalidad2.Visible = False Then
            txtlocalidad2.Visible = True
        Else
            txtlocalidad2.Visible = False
        End If
    End Sub

    Private Sub CheckBoxIdGrupo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtidgrupo2.Visible = False Then
            txtidgrupo2.Visible = True
        Else
            txtidgrupo2.Visible = False
        End If
    End Sub

    Private Sub CheckBoxIdInst_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtidinst2.Visible = False Then
            txtidinst2.Visible = True
        Else
            txtidinst2.Visible = False
        End If
    End Sub
    Private Sub lblcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub
End Class