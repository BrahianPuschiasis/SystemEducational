Public Class ModDirector

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenuprincipal.Click
        MenuPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub DocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaDocente.Show()
        Me.Close()
    End Sub


    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarlinea.Click
        
        If lbllinea.Visible = False Then
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
        
        If lblitem.Visible = False Then
            btnconfirmar2.Visible = True
            CheckBoxnombre1.Visible = True
            CheckBoxnombre2.Visible = True
            CheckBoxapaterno.Visible = True
            CheckBoxamaterno.Visible = True
            CheckBoxdireccion.Visible = True
            lblitem.Visible = True
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
        BajaDirector.Show()
        Me.Close()
    End Sub

    Private Sub AlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAlumno.Show()
        Me.Close()
    End Sub


    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        ConsultaPersona.Show()
        Me.Close()

    End Sub

    Private Sub ListadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadosToolStripMenuItem.Click
        ListadoPersonas.Show()
        Me.Close()

    End Sub

    Private Sub BajaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDirectorToolStripMenuItem.Click
        BajaDirector.Show()
        Me.Close()

    End Sub

    Private Sub AltaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDirectorToolStripMenuItem.Click
        AltaDirector.Show()
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

    Private Sub ModificacionAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionAlumnoToolStripMenuItem.Click
        ModAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDocenteToolStripMenuItem.Click
        ModDocente.Show()
        Me.Close()

    End Sub

    Private Sub txtitemnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemnombre.TextChanged
        
    End Sub

    Private Sub txtitemnombre2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemnombre2.TextChanged
       
    End Sub

    Private Sub txtitemapaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemapaterno.TextChanged
       
    End Sub

    Private Sub txtitemamaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemamaterno.TextChanged
        
    End Sub

    Private Sub txtitemdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemdireccion.TextChanged
      
    End Sub
End Class