Public Class modAdministrativo
    Dim datoscragados As Boolean

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub DocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaDocente.Show()
        Me.Close()
    End Sub


    Private Sub btnmodificarlinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificarlinea.Click

        If lbllinea.Visible = False Then
            conn()
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
                If (txtci.Text <> "") Then
                    sql = "SELECT ci FROM personas WHERE ci=" & txtci.Text
                    Cmd.CommandText = sql
                    ci = Cmd.ExecuteScalar

                    If (cedula = txtci.Text) Then

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

                        sql1 = "SELECT nombre1,nombre2,apaterno,amaterno,direccion,mail "
                        sql1 += "FROM personas "
                        sql1 += "WHERE ci = " & txtci.Text
                        MsgBox(sql1)
                        Cmd.CommandText = sql1
                        dr = Cmd.ExecuteReader

                        If dr.Read Then
                            txtnombre1.Text = dr("nombre1")
                            txtnombre2.Text = dr("nombre2")
                            txtapaterno.Text = dr("apaterno")
                            txtamaterno.Text = dr("amaterno")
                            txtdireccion.Text = dr("direccion")

                            dr.Close()
                            datoscragados = True
                        End If
                    Else
                        MsgBox("La cedula ingresada no esta registrada", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                Else
                    MsgBox("No ha Ingresado la C.I", MsgBoxStyle.Exclamation, "Aviso")
                End If

                conect.Close()
            Else
                MsgBox("CI Falsa", MsgBoxStyle.Exclamation, "Error")


            End If

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
            If (lblitem.Visible = False) Then

                conn()

                If (txtci.Text <> "") Then

                    verci()

                    If (cedula = txtci.Text) Then

                        btnconfirmar2.Visible = True
                        CheckBoxnombre1.Visible = True
                        CheckBoxnombre2.Visible = True
                        CheckBoxapaterno.Visible = True
                        CheckBoxamaterno.Visible = True
                        CheckBoxdireccion.Visible = True

                        lblitem.Visible = True


                        cargardatos()

                        If dr.Read Then
                            txtitemnombre.Text = dr("nombre1")
                            txtitemnombre2.Text = dr("nombre2")
                            txtitemapaterno.Text = dr("apaterno")
                            txtitemamaterno.Text = dr("amaterno")
                            txtitemdireccion.Text = dr("direccion")

                            dr.Close()
                            datoscragados = True
                        End If
                    Else
                        MsgBox("La cedula ingresada no esta registrada", MsgBoxStyle.Exclamation, "Aviso")

                    End If
                Else
                    MsgBox("No ha Ingresado la C.I", MsgBoxStyle.Exclamation, "Aviso")
                End If

                conect.Close()

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

                txtitemnombre.Visible = False
                txtitemnombre2.Visible = False
                txtitemapaterno.Visible = False
                txtitemamaterno.Visible = False
                txtitemdireccion.Visible = False

            End If
        Else
            MsgBox("CI Falsa", MsgBoxStyle.Exclamation, "Error")


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
        BajaAdministrativo.Show()
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
        CmbConsultaListado.Show()
        Me.Close()

    End Sub


    Private Sub BajaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDirectorToolStripMenuItem.Click
        BajaAdministrativo.Show()
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

    Private Sub AltaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDirectorToolStripMenuItem.Click
        AltaAdministrativo.Show()
        Me.Close()

    End Sub


    Private Sub btnconfirmar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar2.Click
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
            If (cedula = txtci.Text) Then
                If (CheckBoxnombre1.Checked = True) Then

                    If (txtitemnombre.Text.Length = 0) Then
                        MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                        Return
                    Else
                        conn()
                        sql = "UPDATE personas SET "
                        sql += "nombre1= '" & txtitemnombre.Text & "' "
                        sql += "WHERE ci= " & cedula
                        MsgBox(sql)
                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                        MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                        conect.Close()
                    End If
                End If

            End If
            If (CheckBoxnombre2.Checked = True) Then
                sql = "UPDATE personas SET "
                sql += "nombre2= '" & txtitemnombre2.Text & "' "
                sql += " WHERE ci= " & cedula
                MsgBox(sql)
                Cmd.CommandText = sql

                Cmd.ExecuteNonQuery()
                MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
            End If
            If (CheckBoxapaterno.Checked = True) Then

                If (txtitemapaterno.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql = "UPDATE personas SET "
                    sql += "apaterno= '" & txtitemapaterno.Text & "' "
                    sql += " WHERE ci= " & cedula
                    MsgBox(sql)
                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    conect.Close()
                End If

            End If
            If (CheckBoxamaterno.Checked = True) Then

                If (txtitemamaterno.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql = "UPDATE personas SET "
                    sql += "amaterno= '" & txtitemamaterno.Text & "' "
                    sql += " WHERE ci= " & cedula
                    MsgBox(sql)
                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    conect.Close()
                End If


            End If
            If (CheckBoxdireccion.Checked = True) Then

                If (txtitemdireccion.Text.Length = 0) Then
                    MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                    Return
                Else
                    conn()
                    sql = "UPDATE personas SET "
                    sql += "direccion= '" & txtitemdireccion.Text & "' "
                    sql += " WHERE ci= " & cedula
                    MsgBox(sql)
                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()
                    MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")
                    conect.Close()
                End If

            End If

        Else
            MsgBox("CI Falsa", MsgBoxStyle.Exclamation, "Error")


        End If
        conect.Close()

    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click

        nombre1 = txtnombre1.Text
        nombre2 = txtnombre2.Text
        apaterno = txtapaterno.Text
        amaterno = txtamaterno.Text
        direccion = txtdireccion.Text

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
            If ((txtnombre1.Text.Length = 0) Or (txtapaterno.Text.Length = 0) Or (txtamaterno.Text.Length = 0) Or (txtdireccion.Text.Length)) Then
                MsgBox("Error, el campo/s a modificar estan vacios", MsgBoxStyle.Critical, "Aviso")
                Return
            Else
                conn()
                modpersona()
                conect.Close()
            End If
        Else
            MsgBox("CI Falsa", MsgBoxStyle.Exclamation, "Error")


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
        MenuPrincipalAdministrativo.Show()
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
 

    Private Sub txtitemnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemnombre.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

 


    Private Sub txtitemnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemnombre.TextChanged
        Dim primer, texto, letra, letras As String
        If txtitemnombre.Text.Length = 0 Then

            txtitemnombre.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtitemnombre.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtitemnombre.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtitemnombre.Text = letra + letras
        txtitemnombre.SelectionStart = I

    End Sub
    Private Sub txtitemapaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemapaterno.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtitemnombre2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemnombre2.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtitemamaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemamaterno.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtitemnombre2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemnombre2.TextChanged
        Dim primer, texto, letra, letras As String
        If txtitemnombre.Text.Length = 0 Then

            txtitemnombre2.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtitemnombre2.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtitemnombre2.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtitemnombre2.Text = letra + letras
        txtitemnombre2.SelectionStart = I
    End Sub

    Private Sub txtitemapaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemapaterno.TextChanged
        Dim primer, texto, letra, letras As String
        If txtitemapaterno.Text.Length = 0 Then

            txtitemapaterno.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtitemapaterno.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtitemapaterno.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtitemapaterno.Text = letra + letras
        txtitemapaterno.SelectionStart = I

    End Sub

    Private Sub txtitemamaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemamaterno.TextChanged
        Dim primer, texto, letra, letras As String
        If txtitemamaterno.Text.Length = 0 Then

            txtitemamaterno.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtitemamaterno.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtitemamaterno.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtitemamaterno.Text = letra + letras
        txtitemamaterno.SelectionStart = I

    End Sub

    Private Sub txtnombre1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre1.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre1.TextChanged
        Dim primer, texto, letra, letras As String
        If txtnombre1.Text.Length = 0 Then

            txtnombre1.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtnombre1.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtnombre1.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtnombre1.Text = letra + letras
        txtnombre1.SelectionStart = I

    End Sub

    Private Sub txtnombre2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre2.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre2.TextChanged
        Dim primer, texto, letra, letras As String
        If txtnombre2.Text.Length = 0 Then

            txtnombre2.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtnombre2.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtnombre2.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtnombre2.Text = letra + letras
        txtnombre2.SelectionStart = I

    End Sub

    Private Sub txtapaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapaterno.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtapaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapaterno.TextChanged
        Dim primer, texto, letra, letras As String
        If txtapaterno.Text.Length = 0 Then

            txtapaterno.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtapaterno.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtapaterno.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtapaterno.Text = letra + letras
        txtapaterno.SelectionStart = I

    End Sub

    Private Sub txtamaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamaterno.KeyPress
        If e.KeyChar.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtamaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamaterno.TextChanged
        Dim primer, texto, letra, letras As String
        If txtamaterno.Text.Length = 0 Then

            txtamaterno.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtamaterno.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtamaterno.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtamaterno.Text = letra + letras
        txtamaterno.SelectionStart = I

    End Sub

    Private Sub txtitemdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtitemdireccion.TextChanged
        Dim primer, texto, letra, letras As String
        If txtitemdireccion.Text.Length = 0 Then

            txtitemdireccion.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtitemdireccion.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtitemdireccion.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtitemdireccion.Text = letra + letras
        txtitemdireccion.SelectionStart = I

    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.TextChanged
        Dim primer, texto, letra, letras As String
        If txtdireccion.Text.Length = 0 Then

            txtdireccion.Text = ""
            letras = ""
            letra = ""
            texto = ""
            primer = ""
            Return
        End If
        texto = ""
        primer = ""
        letra = ""
        letras = ""

        texto = txtdireccion.Text
        primer = texto(0)
        Dim I As Integer
        I = Len(txtdireccion.Text)
        letra = texto(0)

        If I <= 1 Then
            letra = UCase(primer)
        Else
            letras = Mid(texto, 2, 30)
            letras = LCase(letras)

        End If
        txtdireccion.Text = letra + letras
        txtdireccion.SelectionStart = I

    End Sub
End Class