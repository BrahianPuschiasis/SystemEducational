Public Class MenuPrincipalDocente

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Dim Resp As String
        Resp = MsgBox("¿Desea salir?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
         
            Ingreso.Close()
        End If
    End Sub

    Private Sub MenuPrincipalDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim var As Form
        Dim numerol As Integer
        var = Me
        conect.Close()
        conn()
        var.Size = New Size(400, 250)
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Try
            sql1 = "SELECT idpreg from usuario where ci= " & cilogin & ""
            Cmd.CommandText = sql1

            numerol = Cmd.ExecuteScalar

            If numerol = 0 Then
                MsgBox("Todabia no tiene ninguna pregunta secreta, le recomendamos ingresarla en el botón Configuración")


            End If
        Catch
        End Try
        conect.Close()

    End Sub

    Private Sub IngresarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IngresarNotaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModificarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModificarNotaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub IngresarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IngreseNotaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ModificarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModificarNotaActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub GrupoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btndcerrarsesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndcerrarsesion.Click
        conect.Close()
        conect2.Close()
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

    Private Sub ConsultaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem3.Click

    End Sub

    Private Sub ActaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaToolStripMenuItem.Click

    End Sub

    Private Sub btnConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguracion.Click
        PrimerLogin.Show()
        Me.Close()

    End Sub

    Private Sub ActaDeExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaDeExamenToolStripMenuItem.Click
        AltaActaExamen.Show()
        docentev = 5
        Me.Close()

    End Sub

    Private Sub ActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaFinalToolStripMenuItem.Click
        Verificar_Acta_Examen.Show()
        docentev = 5
        Me.Close()

    End Sub

    Private Sub NotasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasToolStripMenuItem.Click
        IngresarNotaActaExamen.Show()
        docentev = 5
        Me.Close()

    End Sub

    Private Sub IngresarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarToolStripMenuItem.Click
        AltaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub VerificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarToolStripMenuItem.Click
        VerificarActaFinal.Show()
        docentev = 5
        Me.Close()

    End Sub

    Private Sub NotasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasToolStripMenuItem1.Click
        IngreseNotaActaFinal.Show()
        docentev = 5
        Me.Close()

    End Sub

    Private Sub ExamenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamenesToolStripMenuItem.Click

    End Sub
End Class