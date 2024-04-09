Public Class CambioContraseña

    Private Sub btnir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

      

    End Sub

    Private Sub btnlisto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlisto.Click
        conect.Close()
        conn()
        If txtCI.Text.Length < 8 Then Return
        Dim pregunta As String
        Dim datos As String



        If txtCI.Enabled = False Then

            sql2 = "select  contrasenia from usuario where ci= " & txtCI.Text & " and respuesta= '" & txtRespuesta.Text & "' "
            Cmd.CommandText = sql2
            datos = Cmd.ExecuteScalar
            If datos = "" Then
                MsgBox("Respuesta incorrecta")
            Else



                MsgBox("Sus contraseña es: " & datos & ",le recomendamos cambiarla")
            End If
         

        Else

            Dim ci = txtCI.Text
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



            If txtCI.Text.Length = 0 Then Return


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


                sql1 = "SELECT pregunta from preguntas,usuario where usuario.ci = " & txtCI.Text & " and preguntas.idpreg = usuario.idpreg"
                Cmd.CommandText = sql1
                pregunta = Cmd.ExecuteScalar


                txtRespuesta.Visible = True
                txtPregunta.Visible = True
                lblRespuesta.Visible = True
                lblPregunta.Visible = True
                txtPregunta.Text = pregunta
                txtCI.Enabled = False
            Else
                MsgBox("CI Falsa", MsgBoxStyle.Exclamation, "Error")


            End If
        End If
        conect.Close()
    End Sub
    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        Ingreso.Show()
        Me.Close()
    End Sub


    Private Sub CambioContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

    
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRespuesta.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub



    Private Sub txtCI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCI.KeyPress
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

    Private Sub txtCI_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtCI.MaskInputRejected

    End Sub

    Private Sub logo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        Ingreso.Show()
        Me.Close()
    End Sub
End Class