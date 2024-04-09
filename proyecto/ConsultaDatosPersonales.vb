Public Class ConsultaDatosPersonales

  

    Private Sub IngresarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarNotaToolStripMenuItem1.Click
        IngresarNotaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModificarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModificarNotaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub IngresarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarNotaToolStripMenuItem.Click
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

    Private Sub ConsultaDatosPersonales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim var As Form
        var = Me
        var.Size = New Size(800, 548)
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2


        conn()
        Ds.Clear()

        sql = "SELECT personas.ci,nombre1,nombre2,apaterno,amaterno,direccion,fecha,locacion.locacion,telefono from personas,telefonop, locacion where personas.ci= " & cilogin & " and telefonop.ci=personas.ci and locacion.idloc = personas.localidad group by personas.ci,nombre1,nombre2,apaterno,amaterno,direccion,fecha,locacion.locacion,telefono"
        Cmd.CommandText = sql
        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
        da.Fill(Ds, "personas")
      
        DGVConsulta.DataSource = Ds.Tables("personas")


        conect.Close()
    End Sub


   

    
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



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

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DGVConsulta_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick

    End Sub
End Class