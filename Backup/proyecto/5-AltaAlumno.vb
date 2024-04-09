
Public Class AltaAlumno
    Dim varnueva As String
    Dim cedula As Integer = 0
    Dim grupo As Integer = 0
    Dim añoc As Integer = 0
    Dim ingre As Boolean
    Dim numero As Integer
    Dim idinst As Integer = 0

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub


    Private Sub DirectorToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub DocenteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaDocente.Show()
        Me.Close()
    End Sub

    Private Sub AlumnoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAlumno.Show()
        Me.Close()
    End Sub

    Private Sub DirectorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub DocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaDocente.Show()
        Me.Close()
    End Sub

    Private Sub AlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAlumno.Show()
        Me.Close()
    End Sub

    Private Sub DirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub DocenteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModDocente.Show()
        Me.Close()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        CmbConsultaListado.Show()
        Me.Close()

    End Sub

    Private Sub AltaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDocenteToolStripMenuItem.Click
        AltaDocente.Show()
        Me.Close()

    End Sub

    Private Sub AltaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDirectorToolStripMenuItem.Click
        AltaAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub BajaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaAlumnoToolStripMenuItem.Click
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub BajaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDocenteToolStripMenuItem.Click
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub BajaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDirectorToolStripMenuItem.Click
        BajaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDocenteToolStripMenuItem.Click
        ModDocente.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionAlumnoToolStripMenuItem.Click
        ModAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificacionDirectorToolStripMenuItem.Click
        modAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnconfirmar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        cmblocalidad.DropDownStyle = ComboBoxStyle.DropDownList

        nombre1 = txtnombre1.Text
        nombre2 = txtnombre2.Text
        apaterno = txtapaterno.Text
        amaterno = txtamaterno.Text
        direccion = txtdireccion.Text
        fechanac = txtfechanaca.Text
        tel = txttelefonoa.Text

        direccion = txtdireccion.Text
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
            conn()
            If (cmblocalidad.Text <> "") Then
                sql = "SELECT idloc FROM locacion WHERE locacion='" & cmblocalidad.Text & "'"
                Cmd.CommandText = sql
                localidad = Cmd.ExecuteScalar
            Else
                MsgBox("No ha ingresado  elegido ninguna localidad", MsgBoxStyle.Exclamation, "Aviso")
            End If

            If ingre = True Then


                Try

                    sql10 = "Select idloc from locacion where locacion = ( '" & cmblocalidad.Text & "') "



                    Cmd.CommandText = sql10
                    Cmd.ExecuteScalar()
                    contador = Cmd.ExecuteScalar


                Catch


                End Try









                Dim fecha As String
                Dim carac As String
                carac = "%d/%m/%Y"
                fecha = "to_date('" & txtfechanaca.Text & "', '" & carac & "') "

                sql9 = "INSERT INTO personas (ci,nombre1,nombre2,apaterno,amaterno,direccion,fecha,localidad) VALUES ( " & txtci.Text & ", '" & txtnombre1.Text & "', '" & txtnombre2.Text & "', '" & txtapaterno.Text & "', '" & txtamaterno.Text & "', '" & txtdireccion.Text & "'," & fecha & ", " & contador & ")"
                Cmd.CommandText = sql9
                MsgBox(sql9)

                Cmd.ExecuteNonQuery()
                MsgBox("Registro completado con éxito persona")


            sql14 = "INSERT INTO telefonop (ci,telefono) VALUES ( " & txtci.Text & ", '" & txttelefonoa.Text & "')"
                Cmd.CommandText = sql14
                Cmd.ExecuteNonQuery()







            Else

                If (txtci.Text <> "") Then
                    sql = "SELECT ci FROM personas WHERE ci=" & txtci.Text
                    Cmd.CommandText = sql
                    cedula = Cmd.ExecuteScalar
                Else
                    MsgBox("No ha ingresado ninguna C.I", MsgBoxStyle.Exclamation, "Aviso")
                End If












                Dim nombre As String = ""
                sql1 = "SELECT nombre1 FROM personas WHERE ci=" & txtci.Text
                Cmd.CommandText = sql1
                nombre = Cmd.ExecuteScalar

                Dim apellido As String = ""
                sql1 = "SELECT apaterno FROM personas WHERE ci=" & txtci.Text
                Cmd.CommandText = sql1
                apellido = Cmd.ExecuteScalar





                Dim año As Integer

                nombre2 = txtidgrupo.Text

                varnueva = nombre2(0)
                varnueva2 = nombre2(1)

                grupo = varnueva + varnueva2

                sql15 = "SELECT idgrupo from dictan where ci= " & txtci.Text & ""
                Cmd.CommandText = sql15

                numero = Cmd.ExecuteScalar()

                año = Now.Year
                sql2 = "INSERT INTO concurren(ci,idgrupo,aniocursado,activo)"
                sql2 += "VALUES(" & txtci.Text & "," & grupo & "," & año & "," & "'Activo'" & ")"

                Cmd.CommandText = sql2
                If grupo = numero Then
                    MsgBox("Usted no puede ser alumno y docente del mismo grupo")
                Else
                    Try
                        Cmd.ExecuteNonQuery()
                        MsgBox("Los Datos han sido ingresados", MsgBoxStyle.Information, "Aviso")
                    Catch
                        MsgBox("Ya concurre a ese grupo", MsgBoxStyle.Information, "Informacion")
                    End Try
                End If







                Try

                    Dim usucont As String = nombre
                    usucont = usucont(0) + apellido

                    sql7 = "INSERT INTO usuario(ci,nombreuser,contrasenia) "
                    sql7 += "VALUES(" & cedula & ",'" & usucont & "','" & usucont & "')"

                    Cmd.CommandText = sql7
                    Cmd.ExecuteNonQuery()

                    MsgBox("Los Datos han sido ingresados", MsgBoxStyle.Information, "Aviso")

                Catch ex As Exception
                    If ex.ToString.Contains("ERROR [23000]") Then

                    Else
                        MsgBox(ex.ToString)
                    End If
                End Try






            End If
        Else
            MsgBox("CI Falsa", MsgBoxStyle.Exclamation, "Error")


        End If
        conect.Close()

    End Sub

    Private Sub btnverificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverificar.Click
        btnconfirmar.Enabled = True
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
                    sql = "SELECT ci FROM personas WHERE ci=" & txtci.Text
                    Cmd.CommandText = sql
                    cedula = Cmd.ExecuteScalar
                    If (cedula = txtci.Text) Then

                        sql = "SELECT telefono FROM telefonop WHERE ci=" & txtci.Text
                        Cmd.CommandText = sql
                        txttelefonoa.Text = Cmd.ExecuteScalar

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
                            txtfechanaca.Text = dr("fecha")
                            txtdireccion.Text = dr("direccion")


                            idloc = dr("localidad")




                            Try
                                dr.Close()
                                sql11 = "SELECT locacion FROM locacion WHERE idloc=" & idloc & " "
                                Cmd.CommandText = sql11
                                Cmd.ExecuteScalar()
                                nombre = Cmd.ExecuteScalar
                                cmblocalidad.DropDownStyle = ComboBoxStyle.Simple
                                cmblocalidad.Text = nombre




                            Catch
                                MsgBox("Errror")



                                dr.Close()
                            End Try
                        End If
                        grpdatosp.Enabled = False
                        grpconcurre.Enabled = True
                        ingre = False

                        '--------------------------



                    Else
                        MsgBox("La cedula ingresada no esta registrada por favor proceda a ingresarla", MsgBoxStyle.Exclamation, "Aviso")
                        grpdatosp.Enabled = True
                        grpconcurre.Enabled = False
                        'grpinstituto.Enabled = False
                        ingre = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Else
                MsgBox("No ha Ingresado la C.I", MsgBoxStyle.Exclamation, "Aviso")
            End If


        Else
            MsgBox("CI Falsa", MsgBoxStyle.Exclamation, "Error")


        End If










        conect.Close()

    End Sub

    Private Sub AltaAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim var As Form

        conn()
        sql2 = "SELECT nombre FROM instituto,administra where instituto.activo ='Activo' group by nombre  "
        Cmd.CommandText = sql2
        dr = Cmd.ExecuteReader()

        cmbinst.Items.Clear()
        While dr.Read
            cmbinst.Items.Add(dr("nombre"))
        End While

        dr.Close()



        




       




        sql8 = "SELECT locacion FROM locacion"
        Cmd.CommandText = sql8
        dr = Cmd.ExecuteReader

        cmblocalidad.Items.Clear()

        While dr.Read
            cmblocalidad.Items.Add(dr("locacion"))
        End While
        dr.Close()

        conect.Close()


        var = Me
        var.Size = New Size(794, 572)

        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

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




    Private Sub txtañoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub grpdatosp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpdatosp.Enter

    End Sub

    Private Sub txtidgrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtidgrupo.SelectedIndexChanged


    End Sub

    Private Sub cmbinst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbinst.SelectedIndexChanged
        Dim nomgrupo As String
        Dim idgrupo As String
        Dim combinado As String
        Dim grado As String
        Dim orientacion As String
        conn()
        sql8 = "SELECT idinst FROM instituto WHERE nombre='" & cmbinst.Text & "'"
        Cmd.CommandText = sql8
        idinst = Cmd.ExecuteScalar

        sql13 = "SELECT idgrupo,grado,nombre,orientacion.orientacion  FROM grupo inner join orientacion on orientacion.idori = grupo.orientacion where grupo.instituto = " & idinst & " and grupo.anio = " & Now.Year & ""
        Cmd.CommandText = sql13

        dr = Cmd.ExecuteReader()


        txtidgrupo.Items.Clear()

        While dr.Read
            idgrupo = dr("idgrupo")
            nomgrupo = dr("nombre")
            grado = dr("grado")
            orientacion = dr("orientacion")
            combinado = idgrupo + " " + grado + "º" + orientacion + nomgrupo
            txtidgrupo.Items.Add(combinado)
            txtidgrupo.Enabled = True
            lbnidgrupo.Enabled = True
        End While
        dr.Close()
        conect.Close()
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

    Private Sub txtfechanaca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfechanaca.KeyPress
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

    Private Sub txtfechanaca_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtfechanaca.MaskInputRejected

    End Sub

    Private Sub txttelefonoa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefonoa.KeyPress
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

    Private Sub txttelefonoa_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txttelefonoa.MaskInputRejected

    End Sub
End Class