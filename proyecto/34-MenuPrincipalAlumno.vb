Public Class MenuPrincipalAlumno


    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Dim Resp As String
        Resp = MsgBox("¿Desea salir?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
            Ingreso.Close()
        End If
    End Sub

    Private Sub MenuPrincipalAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim var As Form
        var = Me
        var.Size = New Size(400, 250)
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

    End Sub

    Private Sub DatosPersonalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosPersonalesToolStripMenuItem.Click
        ConsultaDatoPersonalAlumno.Show()

        Me.Close()

    End Sub

    Private Sub NotasPersonalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasPersonalesToolStripMenuItem.Click
        Boletin.Show()

        Me.Close()

    End Sub

    Private Sub btndcerrarsesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndcerrarsesion.Click
        Ingreso.Close()
        Ingreso.Show()

        Me.Close()
    End Sub
    Private Sub lblcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

    Private Sub btnConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub btnConfiguracion_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguracion.Click
        PrimerLogin.Show()
        Me.Close()
    End Sub

    Private Sub ConsultaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem3.Click

    End Sub
End Class