Public Class ModificarInstituto
    Public idinst As Integer
    Public telefono As String
    Private Sub ModificarInstituto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        conn()

        sql2 = "SELECT nombre FROM instituto,administra where instituto.activo ='Activo' group by nombre  "
        Cmd.CommandText = sql2
        dr = Cmd.ExecuteReader()

        cmbinst.Items.Clear()
        While dr.Read
            cmbinst.Items.Add(dr("nombre"))
        End While

        dr.Close()
        conect.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

    Private Sub cmbinst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbinst.SelectedIndexChanged
        conn()
        sql1 = "SELECT idinst from instituto where nombre= '" & cmbinst.Text & "'"
        Cmd.CommandText = sql1
        idinst = Cmd.ExecuteScalar

        sql1 = "SELECT telefono from telefonoi where idinst= " & idinst & ""
        Cmd.CommandText = sql1
        telefono = Cmd.ExecuteScalar

        lbltelefono.Text = telefono
        lbltelefono.Visible = True

        conect.Close()

    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        conn()
        sql10 = "UPDATE telefonoi set telefono=" & txttelefonoi.Text & " where idinst=" & idinst & ""
        Cmd.CommandText = sql10
        Cmd.ExecuteNonQuery()
        MsgBox("Telefono modificado con éxito")

        sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ",'" & idinst & "','Update','Teléfono cambiado a: " & txttelefonoi.Text & "','telefonoi', " & fecha2 & ", '" & lblhora2.Text & "')"

        Cmd.CommandText = sql

        Cmd.ExecuteNonQuery()
        conect.Close()
    End Sub

    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        MenuPrincipalAdministrativo.Show()
        Me.Close()

    End Sub
End Class