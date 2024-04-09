Public Class ConsultaNotaActaFinalDocente

    Private Sub btnAscendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalDocente.Show()
        Me.Close()
    End Sub

    Private Sub IngresarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarNotaToolStripMenuItem1.Click
        IngresarNotaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModificarNotaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarNotaToolStripMenuItem1.Click
        ModificarNotaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub IngresarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarNotaToolStripMenuItem.Click
        IngreseNotaActaFinal.Show()
        Me.Close()

    End Sub



    Private Sub GrupoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoToolStripMenuItem1.Click
        ConsultaGrupoDocente.Show()
        Me.Close()
    End Sub


    Private Sub DatosPersonalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosPersonalesToolStripMenuItem.Click
        ConsultaDatosPersonales.Show()
        Me.Close()
    End Sub

    Private Sub ConsultaNotaActaFinalDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub CmbConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbConsulta.SelectedIndexChanged
        If (CmbConsulta.Text = "Alumno") Then
            lblci.Visible = True
            txtci.Visible = True
            btnBuscar.Visible = True
            Ordenar.Visible = False
        Else
            lblci.Visible = False
            txtci.Visible = False
            btnBuscar.Visible = False
            Ordenar.Visible = True

            conn()

            nomgrup()


            While dr.Read
                CmbListadoGrupo.Items.Add(dr("nombre"))
            End While


            conect.Close()
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

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
            conn()
            Ds.Clear()
            sql = "SELECT * FROM cursan WHERE ci= " & txtci.Text
            Dim Da As New Odbc.OdbcDataAdapter(sql, conect)
            Da.Fill(Ds, "cursan")
            DGVConsulta.DataSource = Ds.Tables("cursan")
            conect.Close()
        Else
            MsgBox("CI Falsa", MsgBoxStyle.Exclamation, "Error")


        End If

    End Sub

    Private Sub btnAscendente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAscendente.Click
        conn()
        Dim idgrupo As Integer
        sql = "SELECT idgrupo FROM grupo WHERE nombre='" & CmbListadoGrupo.Text & "'"
        Cmd.CommandText = sql
        idgrupo = Cmd.ExecuteScalar
        conect.Close()



        If (idgrupo <> 0) Then

            conn()


            sql1 = "SELECT ci FROM concurren WHERE idgrupo= '" & idgrupo
            Cmd.CommandText = sql
            dr = Cmd.ExecuteReader()

            Dim ced As Integer
           
            While dr.Read

                ced = dr("ci")
                sql = "SELECT * FROM cursan WHERE ci= " & ced
                Dim Da As New Odbc.OdbcDataAdapter(sql, conect)
                Da.Fill(Ds, "concurren")
                conect.Close()
            End While


        Else
            MsgBox("No ha elegido ninguna opcion", MsgBoxStyle.Exclamation, "Aviso")
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
        MenuPrincipalDocente.Show()
        Me.Close()
    End Sub

    Private Sub ActaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaToolStripMenuItem.Click

    End Sub

    Private Sub ModificarNotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarNotaToolStripMenuItem.Click
        ModificarNotaActaFinal.Show()
        Me.Close()
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