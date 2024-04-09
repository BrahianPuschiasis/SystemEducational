
Public Class AltaAdministrativo
    Dim cedula As Integer
    Dim instituto As Integer
    Dim ingre As Boolean
    Dim locacion As Integer
    Dim modificar As Integer

    





    Private Sub DirectorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub DocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaDocente.Show()
        Me.Close()
    End Sub



    Private Sub DirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()
    End Sub




    Private Sub AltaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaDocente.Show()
        Me.Close()

    End Sub

    Private Sub AltaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub BajaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub BajaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub BajaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModDocente.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAlumno.Show()
        Me.Close()

    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        conn()
        msgerror = ""
        nombre1 = txtnombre1.Text
        nombre2 = txtnombre2.Text
        apaterno = txtapaterno.Text
        amaterno = txtamaterno.Text
        direccion = txtdireccion.Text
        fechanac = txtfechanacadmin.Text
        tel = txttelefonoadmin.Text
        Dim loc As Integer
        If (cmblocalidad.Text <> "") Then
            sql = "SELECT idloc FROM locacion WHERE locacion='" & cmblocalidad.Text & "'"
            Cmd.CommandText = sql
            loc = 5
            localidad = Cmd.ExecuteScalar
        Else
            loc = 10
            ' MsgBox("ERROR 03: No ha ingresado  elegido ninguna localidad", MsgBoxStyle.Exclamation, "Aviso")
            msgerror = "ERROR 03: No ha ingresado o elegido ninguna localidad" & vbNewLine
        End If

        If nombre1 = "" Or nombre2 = "" Or apaterno = "" Or amaterno = "" Or direccion = "" Or fechanac = "" Or loc = 10 Then
            'MsgBox("ERROR: No puede dejar campos en blanco")
            msgerror += "ERROR: No puede dejar campos en blanco" & vbNewLine
        Else



            carac = "%d/%m/%Y"
            fecha = "STR_TO_DATE('" & txtfechanacadmin.Text & "', '" & carac & "')"


            If txtci.Text.Length < 8 Then Return



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



            End If
            If (ingre = True) Then

                Try

                    sql10 = "Select idloc from locacion where locacion = ( '" & cmblocalidad.Text & "') "



                    Cmd.CommandText = sql10
                    Cmd.ExecuteScalar()
                    contador = Cmd.ExecuteScalar


                    If (txtci.Text <> "") Then
                        sql = "SELECT ci FROM personas WHERE ci=" & txtci.Text
                        Cmd.CommandText = sql
                        cedula = Cmd.ExecuteScalar

                    End If




                Catch
                    MsgBox(err.ToString)

                End Try


            End If
            If modificar = 1 Then
                sql = "UPDATE Personas set direccion='" & txtdireccion.Text & "',  localidad=" & cmblocalidad.Text & " where ci= " & txtci.Text & ""
                Cmd.CommandText = sql



                Try
                    Cmd.ExecuteNonQuery()

                    sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Update','Direccion:" & txtdireccion.Text & " Telefono:" & txttelefonoadmin.Text & " Localidad:" & cmblocalidad.Text & "','personas,telefonop', '" & fecha2 & "', '" & lblhora2.Text & "')"

                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()




                    sql1 = "UPDATE telefonop set telefono=" & txttelefonoadmin.Text & "  where ci= " & txtci.Text & ""
                    Cmd.CommandText = sql1

                    Cmd.ExecuteNonQuery()
                    MsgBox("Datos modificados")
                    btnconfirmar.Enabled = False
                    grpdatosp.Enabled = False
                    txtnombre1.Enabled = True
                    txtnombre2.Enabled = True
                    txtapaterno.Enabled = True
                    txtamaterno.Enabled = True
                    modificar = 0
                    txtfechanacadmin.Enabled = True
                    txtdireccion.Enabled = True
                    cmblocalidad.Enabled = True
                    txttelefonoadmin.Enabled = True
                    grpdatosp.Enabled = False
                    ingre = False
                    btnconfirmar.Enabled = False
                    txtamaterno.Text = ""
                    txtapaterno.Text = ""
                    txtci.Text = ""
                    txtdireccion.Text = ""
                    cmblocalidad.Text = ""
                    txtfechanacadmin.Text = ""
                    txtnombre1.Text = ""
                    txtnombre2.Text = ""
                    txtamaterno.Text = ""
                    txttelefonoadmin.Text = ""
                    txtci.Enabled = True

                Catch
                    'MsgBox("ERROR 04: No se pudieron modificar los datos")
                    msgerror += "ERROR 04: No se pudieron modificar los datos" & vbNewLine
                End Try


            Else
                Dim edad As String
                Dim control As String
                edad = txtfechanacadmin.Text
                edad = edad(6) + edad(7) + edad(8) + edad(9)

                control = Now.Year - edad

                If control >= 15 And control <= 110 Then



                    sql9 = "INSERT INTO personas (ci,nombre1,nombre2,apaterno,amaterno,direccion,fecha,localidad) VALUES ( " & txtci.Text & ", '" & txtnombre1.Text & "', '" & txtnombre2.Text & "', '" & txtapaterno.Text & "', '" & txtamaterno.Text & "', '" & txtdireccion.Text & "', " & fecha & ", " & cmblocalidad.Text & ")"
                    Cmd.CommandText = sql9
                    Try
                        Cmd.ExecuteNonQuery()
                    Catch

                        msgerror = "ERROR: Numero de locacion" & vbNewLine
                        Exit Try
                    End Try
                    Try

                        sql14 = "INSERT INTO telefonop (ci,telefono) VALUES ( " & txtci.Text & ", " & txttelefonoadmin.Text & ")"
                        Cmd.CommandText = sql14
                        Cmd.ExecuteNonQuery()
                    Catch
                        MsgBox("Debe completar todos los datos importantes, el telefono es opcional")
                    End Try
                    sql14 = "INSERT INTO telefonop (ci,telefono) VALUES ( " & txtci.Text & ",11111111)"
                        Cmd.CommandText = sql14
                        Try
                            Cmd.ExecuteNonQuery()
                        If registro = 2 Then
                            MsgBox("Registro completado, redireccionando a Cargos")
                            registro = 1
                            AltaDocente.Show()

                            Me.Close()

                        Else
                            MsgBox("¡Registro completado con éxito!")

                                grpdatosp.Enabled = False
                                ingre = False
                                btnconfirmar.Enabled = False
                                txtamaterno.Text = ""
                                txtapaterno.Text = ""
                                txtci.Text = ""
                                txtdireccion.Text = ""
                                cmblocalidad.Text = ""
                                txtfechanacadmin.Text = ""
                                txtnombre1.Text = ""
                                txtnombre2.Text = ""
                                txtamaterno.Text = ""
                                txttelefonoadmin.Text = ""
                                txtci.Enabled = True

                            End If
                        Catch ex As Exception
                            MsgBox("Error: " & ex.Message & vbCrLf & "StackTrace: " & ex.StackTrace)
                        End Try

                    sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Insertar','Se insertó al usuario del campo pk, incluyendo su teléfono','personas,telefonop', '" & fecha2 & "', '" & lblhora2.Text & "')"
                    Try
                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                    Catch
                        MsgBox(err.ToString)
                    End Try

                    
                Else
                    'MsgBox("No se puede registrar a una persona de " & control & " años")
                    msgerror += "No se puede registrar a una persona de " & control & " años" & vbNewLine

                End If

            End If

        End If


        If Not msgerror = "" Then
            MsgBox("Usted ha cometido los siguintes errores por favor corigalos para segir con el registro: " + vbLf + vbLf + msgerror, MsgBoxStyle.Critical)
        End If

        conect.Close()
    End Sub

    Private Sub btnverificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverificar.Click

        'grpdatosp.Text = ""
        If txtci.Text.Length < 8 Then Return
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
                conn()
                Try
                    btnconfirmar.Enabled = True
                    sql = "SELECT ci FROM personas WHERE ci=" & txtci.Text
                    Cmd.CommandText = sql
                    cedula = Cmd.ExecuteScalar
                    If (cedula = txtci.Text) Then

                        sql = "SELECT telefono FROM telefonop WHERE ci=" & txtci.Text
                        Cmd.CommandText = sql
                        txttelefonoadmin.Text = Cmd.ExecuteScalar

                        sql1 = "SELECT ci,nombre1,nombre2,apaterno,amaterno,direccion,fecha,localidad"
                        sql1 += " FROM personas "
                        sql1 += "WHERE ci = " & txtci.Text

                        Cmd.CommandText = sql1
                        dr = Cmd.ExecuteReader

                        Dim idloc As Integer
                        If dr.Read Then
                            txtci.Text = dr("ci")
                            txtnombre1.Text = dr("nombre1")
                            txtnombre2.Text = dr("nombre2")
                            txtapaterno.Text = dr("apaterno")
                            txtamaterno.Text = dr("amaterno")
                            txtfechanacadmin.Text = dr("fecha")
                            txtdireccion.Text = dr("direccion")


                            idloc = dr("localidad")




                            Try
                                dr.Close()
                                sql11 = "SELECT idloc FROM locacion WHERE idloc=" & idloc & " "
                                Cmd.CommandText = sql11
                                Cmd.ExecuteScalar()
                                nombre = Cmd.ExecuteScalar

                                cmblocalidad.Text = nombre

                                MsgBox("Persona ya registrada puede modificar los siguientes datos:")
                                btnconfirmar.Enabled = True
                                grpdatosp.Enabled = True
                                txtnombre1.Enabled = False
                                txtnombre2.Enabled = False
                                txtapaterno.Enabled = False
                                txtamaterno.Enabled = False
                                modificar = 1
                                txtfechanacadmin.Enabled = False
                                txtdireccion.Enabled = True
                                cmblocalidad.Enabled = True
                                txttelefonoadmin.Enabled = True
                                txtci.Enabled = False

                            Catch
                                MsgBox("Errror")



                                dr.Close()
                            End Try
                        End If



                        ingre = False


                        




                    Else
                        MsgBox("La cedula ingresada no esta registrada por favor proceda a ingresarla", MsgBoxStyle.Exclamation, "Aviso")
                        sql1 = "SELECT locacion FROM locacion"
                        Cmd.CommandText = sql1
                        dr = Cmd.ExecuteReader()
                        btnconfirmar.Enabled = True
                        grpdatosp.Enabled = True
                        txtnombre1.Enabled = True
                        txtnombre2.Enabled = True
                        txtapaterno.Enabled = True
                        txtamaterno.Enabled = True
                        txtfechanacadmin.Enabled = True
                        txtdireccion.Enabled = True
                        cmblocalidad.Enabled = True
                        txttelefonoadmin.Enabled = True
                        txtamaterno.Text = ""
                        txtapaterno.Text = ""
                        txtci.Enabled = False
                        txtdireccion.Text = ""
                        cmblocalidad.Text = ""
                        txtfechanacadmin.Text = ""
                        txtnombre1.Text = ""
                        txtnombre2.Text = ""
                        txtamaterno.Text = ""
                        txttelefonoadmin.Text = ""
                        modificar = 150


                        grpdatosp.Enabled = True

                        ingre = True

                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                conect.Close()
            Else
                MsgBox("No ha Ingresado la C.I", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("ERROR 02: La cedula ingresada no es válida")
            grpdatosp.Enabled = False
            ingre = False
            btnconfirmar.Enabled = False
            txtamaterno.Text = ""
            txtapaterno.Text = ""
            txtci.Text = ""
            txtdireccion.Text = ""
            cmblocalidad.Text = ""
            txtfechanacadmin.Text = ""
            txtnombre1.Text = ""
            txtnombre2.Text = ""
            txtamaterno.Text = ""
            txttelefonoadmin.Text = ""

        End If
        conect.Close()

    End Sub

    Private Sub AltaAdministrativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     


        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2


        If registro = 2 Then

            txtci.Text = cedulas

            grpdatosp.Enabled = True
            txtci.Enabled = False
            btnverificar.Enabled = False
            btnconfirmar.Enabled = True


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

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub txtfechanacadmin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfechanacadmin.KeyPress
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

    Private Sub txtfechanacadmin_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtfechanacadmin.MaskInputRejected

    End Sub

    Private Sub txttelefonoadmin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefonoadmin.KeyPress
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

    Private Sub txttelefonoadmin_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txttelefonoadmin.MaskInputRejected

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

    Private Sub txtinstituto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick
        Dim celda As String
        conn()
        celda = Me.DGVConsulta.CurrentCell.Value.ToString

        sql = "SELECT idloc from locacion where locacion= '" & celda & "'"

        Cmd.CommandText = sql

        Cmd.ExecuteScalar()
        locacion = Cmd.ExecuteScalar
        cmblocalidad.Text = locacion
        DGVConsulta.Visible = False
        lblBuscar.Visible = False
        txtBuscar.Visible = False
        btnLocalidad.Visible = True
        cmblocalidad.Visible = True
        lblRecordar.Visible = False
        btnLocalidad.Visible = True
        cmblocalidad.Visible = True
        lbnlocalidad.Visible = True
        lbltelefonoadmin.Visible = True
        txttelefonoadmin.Visible = True
        txtfechanacadmin.Visible = True

        conect.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocalidad.Click
        conn()
        Ds.Clear()
        lblRecordar.Visible = True
        btnLocalidad.Visible = False
        cmblocalidad.Visible = False
        lblBuscar.Visible = True
        txtBuscar.Visible = True
        DGVConsulta.Visible = True

        DGVConsulta.Visible = True
        sql = "SELECT locacion from locacion"
        Cmd.CommandText = sql
        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
        da.Fill(Ds, "locacion")

        DGVConsulta.DataSource = Ds.Tables("locacion")

        btnLocalidad.Visible = False
        cmblocalidad.Visible = False
        lbnlocalidad.Visible = False
        lbltelefonoadmin.Visible = False
        txttelefonoadmin.Visible = False
        txtfechanacadmin.Visible = False





        conect.Close()
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            conn()
            Ds.Clear()
            DGVConsulta.Visible = True
            sql = "SELECT locacion from locacion where locacion like '%" & txtBuscar.Text & "%'"
            Cmd.CommandText = sql

            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "locacion")

            DGVConsulta.DataSource = Ds.Tables("locacion")

            conect.Close()
        End If






    End Sub


    Private Sub EventLog1_EntryWritten(ByVal sender As System.Object, ByVal e As System.Diagnostics.EntryWrittenEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub ProgramasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramasToolStripMenuItem.Click
        programa.Show()
        Me.Close()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        ModificarInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaExamenToolStripMenuItem.Click
        ConsultaActaExamen.Show()
        Me.Close()

    End Sub



    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub OrientacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrientacionToolStripMenuItem.Click
        AltaOrientacion.Show()
        Me.Close()

    End Sub

    Private Sub TipoDeCursoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeCursoToolStripMenuItem.Click
        Altatcurso.Show()
        Me.Close()

    End Sub

    Private Sub LocalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalidadToolStripMenuItem.Click
        Altalocacion.Show()
        Me.Close()

    End Sub

    Private Sub NotasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasToolStripMenuItem.Click
        IngreseNotaActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub NotasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasToolStripMenuItem1.Click
        IngresarNotaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialToolStripMenuItem.Click
        historial.Show()
        Me.Close()

    End Sub




    Private Sub VerificarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarToolStripMenuItem1.Click
        Verificar_Acta_Examen.Show()
        Me.Close()

    End Sub




    Private Sub ActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActaFinalToolStripMenuItem.Click
        ConsultaActaFinal.Show()
        Me.Close()


    End Sub

    Private Sub VerificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarToolStripMenuItem.Click
        VerificarActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub IngresoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoToolStripMenuItem.Click
        AltaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub IngresoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoToolStripMenuItem1.Click
        AltaActaFinal.Show()
        Me.Close()
    End Sub
    Private Sub AsignaturaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignaturaToolStripMenuItem1.Click
        ConsultaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub GrupoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoToolStripMenuItem1.Click
        ConsultaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub FinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub InstitutoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstitutoToolStripMenuItem1.Click
        ConsultaInstituto.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem4.Click
        btnConsulta.Show()
        Me.Close()

    End Sub

    Private Sub BajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub AltasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub BajasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAlumno.Show()
        Me.Close()

    End Sub



    Private Sub BajasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub ModificacoinesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModDocente.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem.Click
        AltaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem.Click
        BajaAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAsignatura.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem1.Click
        AltaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem1.Click
        BajaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModGrupo.Show()
        Me.Close()

    End Sub

    Private Sub AltaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModActaExamen.Show()
        Me.Close()
    End Sub
    Private Sub AltaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub BajaToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaToolStripMenuItem4.Click
        BajaInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionesToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModDocente.Show()
        Me.Close()

    End Sub





    Private Sub AlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub AdministrativoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub DocenteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub AlumnoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub AdministrativoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub DocenteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModDocente.Show()

        Me.Close()

    End Sub

    Private Sub AlumnoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAlumno.Show()
        Me.Close()

    End Sub



    Private Sub PerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerToolStripMenuItem.Click
        CmbConsultaListado.Show()
        Me.Close()

    End Sub
    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CmbConsultaListado.Show()
        Me.Close()

    End Sub



    Private Sub ConsultasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaAsignatura.Show()
        Me.Close()

    End Sub


    Private Sub ConsultasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaGrupo.Show()
        Me.Close()

    End Sub


    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaExamen.Show()
        Me.Close()

    End Sub


    Private Sub ConsultaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaFinal.Show()
        Me.Close()

    End Sub


    Private Sub ConsultaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaInstituto.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionToolStripMenuItem5.Click
        AltaDocente.Show()
        Me.Close()

    End Sub
End Class
