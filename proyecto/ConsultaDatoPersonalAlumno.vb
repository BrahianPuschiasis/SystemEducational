Public Class ConsultaDatoPersonalAlumno

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAlumno.Show()
        Me.Close()
    End Sub



 
   


 

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub


    Private Sub NotasPersonalesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasPersonalesToolStripMenuItem.Click
        Boletin.Show()
        Me.Close()
    End Sub

    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        MenuPrincipalAlumno.Show()
        Me.Close()
    End Sub

    Private Sub ConsultaDatoPersonalAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        conn()
        Ds.Clear()
        sql = "SELECT personas.ci,nombre1,nombre2,apaterno,amaterno,direccion,fecha,locacion.locacion,telefono from personas,telefonop, locacion where personas.ci= " & cilogin & " and telefonop.ci = personas.ci and locacion.idloc = personas.localidad group by personas.ci,nombre1,nombre2,apaterno,amaterno,direccion,fecha,locacion.locacion,telefono"
        Cmd.CommandText = sql
        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
        da.Fill(Ds, "personas")
        DGVConsulta.DataSource = Ds.Tables("personas")


        conect.Close()
    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick

    End Sub
End Class