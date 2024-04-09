

Public Class AltaDocente

    Dim cedula As Integer = 0
    Dim grupo As Integer = 0
    Dim asignatura As Integer = 0
    Dim añod As Integer = 0
    Dim ingre As Boolean
    Dim numero As Integer
    Dim nombre3 As String
    Dim varnueva As String
    Dim varnueva2 As String
    Dim idinst As Integer = 0
    Dim idasig As String
    Dim apellido As String = ""
    Dim instituto As Integer
    Dim data As Integer
    Dim grupos As Integer
    Dim dw As New Odbc.OdbcDataAdapter(sql, conect)
    Dim dz As New Odbc.OdbcDataAdapter(sql, conect)

  

    Private Sub DirectorToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAdministrativo.Show()
        Me.Close()
    End Sub





    Private Sub DirectorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAdministrativo.Show()
        Me.Close()
    End Sub

 

 

    Private Sub DirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()
    End Sub

  



    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub txtci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        'solo deja ingresar numeros
    End Sub

    Private Sub txtnombre1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '  If e.KeyChar.IsLetter(e.KeyChar) Then
        'e.Handled = False
        'ElseIf e.KeyChar.IsControl(e.KeyChar) Then
        'e.Handled = False
        'ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
        'e.Handled = False
        'Else
        'e.Handled = True
        'End If
        'solo deja ingresar letras
    End Sub

  


    Private Sub AltaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub AltaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub BajaDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAdministrativo.Show()
        Me.Close()

    End Sub

    Private Sub BajaDocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaDocente.Show()
        Me.Close()

    End Sub

    Private Sub BajaAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModAlumno.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionDirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        modAdministrativo.Show()
        Me.Close()

    End Sub

   

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        conn()
      

        If cmbCargo.Text = "Administrador" Then
            Dim activo As String
            activo = "Activo"


            sql7 = "INSERT INTO administra(ci,activo) "
            sql7 += "VALUES(" & txtci.Text & ",'" & activo & "')"

            Cmd.CommandText = sql7

            Try

                Cmd.ExecuteNonQuery()

                sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Insertar','Se registró como Administrador','administra', " & fecha2 & ", '" & lblhora2.Text & "')"

                Cmd.CommandText = sql

                Cmd.ExecuteNonQuery()


                MsgBox("Administrador creado con éxito")
                sql7 = "INSERT INTO usuario(ci,contrasenia,idpreg,respuesta) "
                sql7 += "VALUES(" & txtci.Text & ",'" & txtci.Text & "',0,' ')"

                Cmd.CommandText = sql7

                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("Cuenta creada con éxito, el nombre y contraseña de login es la cédula")


                    sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Insertar','Se creó la cuenta de usuario','usuario', " & fecha2 & ", '" & lblhora2.Text & "')"

                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()


                    conect.Close()
                Catch
                    conect.Close()
                End Try



                txtci.Text = ""
                btnverificar.Enabled = True
                txtci.Enabled = True

                cmbCargo.Enabled = False
                cmbCargo.Text = ""
            Catch
                Dim resp As String
                Dim activos As String
                sql2 = "SELECT activo from administra where ci= " & txtci.Text & ""
                Cmd.CommandText = sql2
                activos = Cmd.ExecuteScalar


                resp = MsgBox("El usuario ya es un administrador, su estado es " & activos & " ¿Desea cambiarlo?", MsgBoxStyle.YesNo, "DvS")
                If resp = vbYes Then

                    If activos = "Activo" Then
                        sql = "UPDATE administra set activo='No Activo' where ci= " & txtci.Text & ""
                        Cmd.CommandText = sql
                        Cmd.ExecuteNonQuery()
                        MsgBox("Estado cambiado a No Activo")


                        sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Update','Cambio de estado:No Activo','administra', " & fecha2 & ", '" & lblhora2.Text & "')"

                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()


                    Else
                        sql = "UPDATE administra set activo='Activo' where ci= " & txtci.Text & ""
                        Cmd.CommandText = sql
                        Cmd.ExecuteNonQuery()
                        MsgBox("Estado cambiado a Activo")
                        sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Update','Cambio de estado:Activo','administra', " & fecha2 & ", '" & lblhora2.Text & "')"

                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()
                    End If
                End If
            End Try

        End If



        If cmbCargo.Text = "Docente" Then
            Dim idgrupo As Integer
            sql8 = "SELECT idgrupo from concurren where ci= " & txtci.Text & " and aniocursado = " & Now.Year & " and activo='Activo'"
            Cmd.CommandText = sql8
            Cmd.ExecuteScalar()
            idgrupo = Cmd.ExecuteScalar

            If idgrupo = txtidgrupo.Text Then
                MsgBox("ERROR 19:Usted no puede ser docente de un grupo al que concurre")
            Else


                sql7 = "INSERT INTO dictan(ci,idgrupo,aniodictado,idasig,activo) "
                sql7 += "VALUES(" & txtci.Text & "," & txtidgrupo.Text & ", " & Now.Year & ", " & txtidasig.Text & ",'Activo')"

                Cmd.CommandText = sql7
                Try
                    Cmd.ExecuteNonQuery()

                    sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Insertar','Se registró como Docente idgrupo: " & txtidgrupo.Text & "','dictan', " & fecha2 & ", '" & lblhora2.Text & "')"

                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()

                    MsgBox("Docente creado con éxito")
                    sql7 = "INSERT INTO usuario(ci,contrasenia,idpreg,respuesta) "
                    sql7 += "VALUES(" & txtci.Text & ",'" & txtci.Text & "',0,' ')"

                    Cmd.CommandText = sql7
                    Try
                        Cmd.ExecuteNonQuery()
                        sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Insertar','Se creó la cuenta de usuario','usuario', " & fecha2 & ", '" & lblhora2.Text & "')"

                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()

                        MsgBox("Cuenta creada con éxito, el nombre y contraseña de login es la cédula")
                        conect.Close()
                    Catch
                        conect.Close()
                    End Try



                    txtci.Text = ""
                    btnverificar.Enabled = True
                    txtci.Enabled = True

                    cmbCargo.Enabled = False
                    cmbCargo.Text = ""
                    grpdicta.Visible = False
                Catch

                    MsgBox("ERROR 06: El usuario ya es un docente del grupo ingresado")

                End Try


            End If

        End If

        If cmbCargo.Text = "Alumno" Then
            Dim idgrupo As Integer
            sql8 = "SELECT idgrupo from dictan where ci= " & txtci.Text & " and aniodictado = " & Now.Year & " and activo='Activo'"
            Cmd.CommandText = sql8
            Cmd.ExecuteScalar()
            idgrupo = Cmd.ExecuteScalar

            If idgrupo = txtidgrupo.Text Then
                MsgBox("ERROR 20:Usted no puede concurrir a un grupo al que dicta clase")
            Else


                sql7 = "INSERT INTO concurren(ci,idgrupo,aniocursado,activo) "
                sql7 += "VALUES(" & txtci.Text & "," & txtidgrupo.Text & ", " & Now.Year & ",'Activo')"

                Cmd.CommandText = sql7
                Try
                    Cmd.ExecuteNonQuery()
                    sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Insertar','Se registro como Alumno, idgrupo: " & txtidgrupo.Text & "','concurren', " & fecha2 & ", '" & lblhora2.Text & "')"

                    Cmd.CommandText = sql

                    Cmd.ExecuteNonQuery()

                    MsgBox("Alumno creado con éxito")
                    sql7 = "INSERT INTO usuario(ci,contrasenia,idpreg,respuesta) "
                    sql7 += "VALUES(" & txtci.Text & ",'" & txtci.Text & "',0,' ')"

                    Cmd.CommandText = sql7
                    Try
                        Cmd.ExecuteNonQuery()
                        sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Insertar','Se creó la cuenta de usuario','usuario', " & fecha2 & ", '" & lblhora2.Text & "')"

                        Cmd.CommandText = sql

                        Cmd.ExecuteNonQuery()

                        MsgBox("Cuenta creada con éxito, el nombre y contraseña de login es la cédula")
                        conect.Close()
                    Catch
                        conect.Close()
                    End Try



                    txtci.Text = ""
                    btnverificar.Enabled = True
                    txtci.Enabled = True

                    cmbCargo.Enabled = False
                    cmbCargo.Text = ""
                    grpdicta.Visible = False
                Catch

                    MsgBox("El usuario ya es un alumno del grupo ingresado")

                End Try


            End If



        End If











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














        If (txtci.Text <> "") Then
            sql = "SELECT ci FROM personas WHERE ci=" & txtci.Text
            Cmd.CommandText = sql
            cedula = Cmd.ExecuteScalar
        Else
            MsgBox("ERROR 08: No ha ingresado ninguna C.I", MsgBoxStyle.Exclamation, "Aviso")
        End If

        If (txtidgrupo.Text <> "") Then























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

        conn()

        If final = ultimonum Then
            If (txtci.Text <> "") Then


                sql = "SELECT ci FROM personas WHERE ci=" & txtci.Text
                Cmd.CommandText = sql
                cedula = Cmd.ExecuteScalar
                If (cedula = txtci.Text) Then
                    cmbCargo.Enabled = True
                    lblCargo.Enabled = True

                    Dim administra As Integer
                    sql1 = "SELECT ci FROM administra WHERE ci=" & txtci.Text
                    Cmd.CommandText = sql1
                    administra = Cmd.ExecuteScalar
                    'If administra = txtci.Text Then
                    'cmbCargo.Items.Clear()
                    'cmbCargo.Items.Add("Docente")
                    ' cmbCargo.Items.Add("Alumno")

                    ' End If



                Else
                    Dim resp As String

                    resp = MsgBox("La cédula ingresada no se encuenta registrada, ¿desea registrarla?", MsgBoxStyle.YesNo, "DvS")
                    If resp = vbYes Then
                        conect.Close()
                        cedulas = txtci.Text
                        registro = 2
                        AltaAdministrativo.Show()



                        Me.Close()
                    End If








                End If



                '--------------------------











            Else
                MsgBox("ERROR 08: No ha Ingresado la C.I", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Else
            MsgBox("ERROR 02: La cedula ingresada no es valida")
        End If





        conect.Close()
    End Sub

    Private Sub AltaDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim var As Form
        carac = "%d/%m/%Y"
        fecha2 = "to_date('" & Now.Date & "', '" & carac & "') "


        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        If registro = 1 Then
            registro = 9
            txtci.Text = cedulas
            txtci.Enabled = False
            btnverificar.Enabled = False
            cmbCargo.Enabled = True
            lblCargo.Enabled = True

        End If

    End Sub

    Private Sub lblci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblci.Click

    End Sub

    Private Sub txtci_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub grpdicta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpdicta.Enter

    End Sub

    Private Sub grpdatosp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lblcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

   
    Private Sub txtidgrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' txtidasig.Items.Clear()


        nombre2 = txtidgrupo.Text

        varnueva = nombre2(0)
        varnueva2 = nombre2(1)

        grupo = varnueva + varnueva2

        conn()





        sql2 = "SELECT asignatura.nombre FROM asignatura,grupo,programa  where programa.idori = " & orientacion & " and programa.grado = " & grado & " and programa.idasig = asignatura.idasig group by asignatura.nombre"
        Cmd.CommandText = sql2

        dr = Cmd.ExecuteReader()

        'txtidasig.Items.Clear()
        While dr.Read
            'txtidasig.Items.Add(dr("nombre"))
        End While
        dr.Close()
        conect.Close()
        txtidasig.Enabled = True

    End Sub

    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub cmblocalidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cmbinst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub lblidinst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblidinst.Click

    End Sub

    Private Sub txtidasig_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtci_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtci.KeyPress
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

    Private Sub txtfechanacd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txtfechanacd_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub txttelefonoi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub txttelefonoi_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub txtnombre1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtnombre2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtapaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtamaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub cmbCargo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCargo.SelectedIndexChanged
        btnconfirmar.Enabled = True
        If cmbCargo.Text = "Docente" Then
            grpdicta.Visible = True
            grpdicta.Enabled = True
            grpdicta.Text = "Formulario Docente"
            lbnidasign.Visible = True
            txtidasig.Visible = True
            btnAsignatura.Visible = True
            txtidasig.Text = ""
            txtidgrupo.Text = ""
            cmbinst.Text = ""
            DGADocente.Visible = True
            DGAAlumnos.Visible = False
            Ds.Tables.Clear()
            grupos = 1



            sql2 = "SELECT dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo from grupo,asignatura,dictan,orientacion where dictan.ci= " & txtci.Text & " and dictan.idgrupo = grupo.idgrupo and dictan.idasig = asignatura.idasig and orientacion.idori = grupo.orientacion and dictan.aniodictado = " & Now.Year & " group by dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo"
            Cmd.CommandText = sql2
            Dim dw As New Odbc.OdbcDataAdapter(sql2, conect)
            dw.Fill(Ds, "dictan")

            DGADocente.DataSource = Ds.Tables("dictan")
            MsgBox("A la derecha podrá visualizar a que grupos dicta clases el docente en el presente año y controlar si esta activo o no")
        

        End If

        If cmbCargo.Text = "Administrador" Then
            grpdicta.Visible = False
            DGADocente.Visible = False
            DGAAlumnos.Visible = False

        End If

        If cmbCargo.Text = "Alumno" Then
            grpdicta.Visible = True
            grpdicta.Enabled = True
            grpdicta.Text = "Formulario Alumno"
            lbnidasign.Visible = False
            txtidasig.Visible = False
            btnAsignatura.Visible = False
            txtidasig.Text = ""
            txtidgrupo.Text = ""
            cmbinst.Text = ""
            DGADocente.Visible = False
            DGAAlumnos.Visible = True
            Ds.Tables.Clear()
            sql = "SELECT concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo from grupo,concurren,orientacion where concurren.ci= " & txtci.Text & " and concurren.idgrupo = grupo.idgrupo and  orientacion.idori = grupo.orientacion and concurren.aniocursado = " & Now.Year & " group by concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo"
            Cmd.CommandText = sql
            Dim dz As New Odbc.OdbcDataAdapter(sql, conect)
            dz.Fill(Ds, "concurren")
            grupos = 2
            DGAAlumnos.DataSource = Ds.Tables("concurren")
            MsgBox("A la derecha podrá visualizar a que grupos concurre el alumno en el presente año y controlar si esta activo o no")
        End If
    End Sub

    Private Sub btnInstituto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstituto.Click
        conn()
        data = 1
        grpdicta.Visible = False
        Ds.Clear()
        DGVConsulta.Visible = True
        DGAAlumnos.Visible = False
        DGADocente.Visible = False
        DGVConsulta.Visible = True
        sql = "SELECT nombre from instituto where activo='Activo'"
        Cmd.CommandText = sql
        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
        da.Fill(Ds, "instituto")

        DGVConsulta.DataSource = Ds.Tables("instituto")
        lblBuscar.Visible = True
        txtBuscar.Visible = True
        lblRecordar.Visible = True
        DGADocente.Visible = False
        DGAAlumnos.Visible = False
        If grupos = 1 Then
            DGADocente.Visible = False




        End If
        If grupos = 2 Then
            DGAAlumnos.Visible = False
        End If



        conect.Close()
    End Sub





    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick
        Dim celda As String
        conn()
        Dim da As New Odbc.OdbcDataAdapter(sql, conect)


        If data = 1 Then
            Try
                celda = Me.DGVConsulta.CurrentCell.Value.ToString

                sql = "SELECT idinst from instituto where nombre= '" & celda & "'"

                Cmd.CommandText = sql
                idinst = Cmd.ExecuteScalar

                Cmd.ExecuteScalar()
                instituto = Cmd.ExecuteScalar
                cmbinst.Text = instituto
                DGVConsulta.Visible = False

                grpdicta.Visible = True
                txtidgrupo.Enabled = True
                btnGrupo.Enabled = True
                lbnidgrupo.Enabled = True
                lblBuscar.Visible = False
                txtBuscar.Visible = False
                lblRecordar.Visible = False
                Ds.Clear()   

          



          


            Catch
            End Try
            If grupos = 1 Then

                DGADocente.Visible = True
                DGAAlumnos.Visible = False
                Ds.Tables.Clear()
                grupos = 1



                sql2 = "SELECT dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo from grupo,asignatura,dictan,orientacion where dictan.ci= " & txtci.Text & " and dictan.idgrupo = grupo.idgrupo and dictan.idasig = asignatura.idasig and orientacion.idori = grupo.orientacion and dictan.aniodictado = " & Now.Year & " group by dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo"
                Cmd.CommandText = sql2
                Dim dw As New Odbc.OdbcDataAdapter(sql2, conect)
                dw.Fill(Ds, "dictan")

                DGADocente.DataSource = Ds.Tables("dictan")
            End If
            If grupos = 2 Then
                DGAAlumnos.Visible = True
                Ds.Tables.Clear()
                sql = "SELECT concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo from grupo,concurren,orientacion where concurren.ci= " & txtci.Text & " and concurren.idgrupo = grupo.idgrupo and  orientacion.idori = grupo.orientacion and concurren.aniocursado = " & Now.Year & " group by concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo"
                Cmd.CommandText = sql
                Dim dz As New Odbc.OdbcDataAdapter(sql, conect)
                dz.Fill(Ds, "concurren")
                grupos = 2
                DGAAlumnos.DataSource = Ds.Tables("concurren")


            End If
        End If
        If data = 2 Then

            Try
                Dim Variable As String = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
                grado = DGVConsulta.Item(1, DGVConsulta.CurrentRow.Index).Value
                orientacion = DGVConsulta.Item(3, DGVConsulta.CurrentRow.Index).Value


                sql11 = "SELECT idori from orientacion where orientacion = '" & orientacion & "'"
                Cmd.CommandText = sql11
                orientacion = Cmd.ExecuteScalar()




                txtidgrupo.Text = Variable
                DGVConsulta.Visible = False

                grpdicta.Visible = True
                txtidgrupo.Enabled = True
                btnGrupo.Enabled = True
                lbnidgrupo.Enabled = True
                lbnidasign.Enabled = True
                txtidasig.Enabled = True
                btnAsignatura.Enabled = True
                lblBuscar.Visible = False
                txtBuscar.Visible = False
                lblRecordar.Visible = False
          
            Catch

            End Try

            If grupos = 1 Then


                DGADocente.Visible = True
                DGAAlumnos.Visible = False
                Ds.Tables.Clear()
                grupos = 1



                sql2 = "SELECT dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo from grupo,asignatura,dictan,orientacion where dictan.ci= " & txtci.Text & " and dictan.idgrupo = grupo.idgrupo and dictan.idasig = asignatura.idasig and orientacion.idori = grupo.orientacion and dictan.aniodictado = " & Now.Year & " group by dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo"
                Cmd.CommandText = sql2
                Dim dw As New Odbc.OdbcDataAdapter(sql2, conect)
                dw.Fill(Ds, "dictan")

                DGADocente.DataSource = Ds.Tables("dictan")

            End If
            If grupos = 2 Then
                DGAAlumnos.Visible = True
                Ds.Tables.Clear()
                sql = "SELECT concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo from grupo,concurren,orientacion where concurren.ci= " & txtci.Text & " and concurren.idgrupo = grupo.idgrupo and  orientacion.idori = grupo.orientacion and concurren.aniocursado = " & Now.Year & " group by concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo"
                Cmd.CommandText = sql
                Dim dz As New Odbc.OdbcDataAdapter(sql, conect)
                dz.Fill(Ds, "concurren")
                grupos = 2
                DGAAlumnos.DataSource = Ds.Tables("concurren")

            End If

        End If



        If data = 3 Then
            celda = Me.DGVConsulta.CurrentCell.Value.ToString
            sql = "SELECT idasig from asignatura where nombre= '" & celda & "'"
            Cmd.CommandText = sql
            Cmd.ExecuteScalar()
            idasig = Cmd.ExecuteScalar
            txtidasig.Text = idasig
            DGVConsulta.Visible = False

            grpdicta.Visible = True
            txtidgrupo.Enabled = True
            btnGrupo.Enabled = True
            lbnidgrupo.Enabled = True
            lblBuscar.Visible = False
            txtBuscar.Visible = False
            lblRecordar.Visible = False
            DGADocente.Visible = True
        
            If grupos = 1 Then
                DGADocente.Visible = True
                DGAAlumnos.Visible = False
                Ds.Tables.Clear()
                grupos = 1



                sql2 = "SELECT dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo from grupo,asignatura,dictan,orientacion where dictan.ci= " & txtci.Text & " and dictan.idgrupo = grupo.idgrupo and dictan.idasig = asignatura.idasig and orientacion.idori = grupo.orientacion and dictan.aniodictado = " & Now.Year & " group by dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo"
                Cmd.CommandText = sql2
                Dim dw As New Odbc.OdbcDataAdapter(sql2, conect)
                dw.Fill(Ds, "dictan")

                DGADocente.DataSource = Ds.Tables("dictan")
            End If
            If grupos = 2 Then
                DGAAlumnos.Visible = True
                Ds.Tables.Clear()
                sql = "SELECT concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo from grupo,concurren,orientacion where concurren.ci= " & txtci.Text & " and concurren.idgrupo = grupo.idgrupo and  orientacion.idori = grupo.orientacion and concurren.aniocursado = " & Now.Year & " group by concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo"
                Cmd.CommandText = sql
                Dim dz As New Odbc.OdbcDataAdapter(sql, conect)
                dz.Fill(Ds, "concurren")
                grupos = 2
                DGAAlumnos.DataSource = Ds.Tables("concurren")


            End If
        End If
     
        conect.Close()
    End Sub

    Private Sub cmbinst_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbinst.KeyPress
        If e.KeyChar = Chr(13) Then
            conn()
            txtidgrupo.Enabled = True
            btnGrupo.Enabled = True
            lbnidgrupo.Enabled = True
            conect.Close()
        End If
    End Sub

    Private Sub cmbinst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbinst.TextChanged

    End Sub

    Private Sub btnGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupo.Click
        conn()

        data = 2
        grpdicta.Visible = False
        Ds.Clear()
        DGVConsulta.Visible = True
        If grupos = 1 Then
            DGADocente.Visible = False
        
           
        End If
        If grupos = 2 Then
            DGAAlumnos.Visible = False
        End If
        DGAAlumnos.Visible = False
        DGVConsulta.Visible = True
        DGADocente.Visible = False
        Ds.Clear()
        sql = "select grupo.idgrupo,grado,nombre,orientacion.orientacion,turno.turno from grupo,orientacion,turno where grupo.orientacion = orientacion.idori and grupo.instituto= " & idinst & " and grupo.anio = " & Now.Year & " and grupo.activo = 'Activo' and grupo.turno=turno.idturno group by  grupo.idgrupo,grado,nombre,orientacion.orientacion,turno.turno "
        Cmd.CommandText = sql
        Dim da As New Odbc.OdbcDataAdapter(sql, conect)
        da.Fill(Ds, "grupo")
        DGVConsulta.DataSource = Ds.Tables("grupo")



        conect.Close()
    End Sub

    Private Sub btnAsignatura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignatura.Click
        conn()
        data = 3
        DGAAlumnos.Visible = False
        grpdicta.Visible = False
        Ds.Clear()
        DGVConsulta.Visible = True

        DGADocente.Visible = False
        DGVConsulta.Visible = True

        Try
            sql = "SELECT asignatura.nombre FROM asignatura,grupo,programa  where programa.idori = " & orientacion & " and programa.grado = " & grado & " and programa.idasig = asignatura.idasig and asignatura.activo='Activo' group by asignatura.nombre "
            Cmd.CommandText = sql

            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "asignatura")
            DGVConsulta.DataSource = Ds.Tables("asignatura")
        Catch
            Ds.Clear()
            MsgBox("ERROR 09: No se encuentran asignaturas activas")
            DGVConsulta.Visible = False
            grpdicta.Visible = True
            DGADocente.Visible = True
            DGADocente.Visible = True
            DGAAlumnos.Visible = False
            grupos = 1



            sql = "SELECT dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo from grupo,asignatura,dictan,orientacion where dictan.ci= " & txtci.Text & " and dictan.idgrupo = grupo.idgrupo and dictan.idasig = asignatura.idasig and orientacion.idori = grupo.orientacion and dictan.aniodictado = " & Now.Year & " group by dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo"
            Cmd.CommandText = sql
            Dim dw As New Odbc.OdbcDataAdapter(sql, conect)
            dw.Fill(Ds, "dictan")
        End Try
        conect.Close()

    End Sub



    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Chr(13) Then
            If data = 1 Then


                conn()
                Ds.Clear()
                DGVConsulta.Visible = True
                sql = "SELECT nombre,activo from instituto where nombre like '%" & txtBuscar.Text & "%' and activo='Activo'"
                Cmd.CommandText = sql

                Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                da.Fill(Ds, "instituto")

                DGVConsulta.DataSource = Ds.Tables("instituto")

                conect.Close()
            End If
         
            If data = 3 Then


                conn()
                Ds.Clear()
                DGVConsulta.Visible = True
                sql = "SELECT nombre,activo from asignatura where nombre like '%" & txtBuscar.Text & "%' and activo='Activo'"
                Cmd.CommandText = sql

                Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                da.Fill(Ds, "asignatura")

                DGVConsulta.DataSource = Ds.Tables("asignatura")

                conect.Close()
            End If
        End If

    End Sub


    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub DGADocente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGADocente.CellContentClick
        conn()
        Dim ci As Integer
        Dim idgrupo As Integer
        Dim idasig As Integer

        ci = DGADocente.Item(0, DGADocente.CurrentRow.Index).Value
        idgrupo = DGADocente.Item(1, DGADocente.CurrentRow.Index).Value
        idasig = DGADocente.Item(3, DGADocente.CurrentRow.Index).Value
        Dim activos As String
        Dim resp As String
        sql2 = "SELECT activo from dictan where ci= " & ci & " and idgrupo= " & idgrupo & " and idasig= " & idasig & " and aniodictado = " & Now.Year & ""
        Cmd.CommandText = sql2
        activos = Cmd.ExecuteScalar
   

        resp = MsgBox("Se cambiará el estado del grupo que dicta el docente actual, su estado es " & activos & " ¿Desea cambiarlo?", MsgBoxStyle.YesNo, "DvS")
        If resp = vbYes Then
            If activos = "Activo" Then
                sql = "UPDATE dictan set activo='No Activo' where ci= " & ci & " and idgrupo= " & idgrupo & " and idasig= " & idasig & " and aniodictado = " & Now.Year & ""
                Cmd.CommandText = sql
                Cmd.ExecuteNonQuery()

                Ds.Tables.Clear()
                MsgBox("Estado cambiado a No activo")
                sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Update','Cambio de estado:No Activo idgrupo: " & idgrupo & " asignatura: " & idasig & "','dictan', " & fecha2 & ", '" & lblhora2.Text & "')"

                Cmd.CommandText = sql

                Cmd.ExecuteNonQuery()

                sql = "SELECT dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo from grupo,asignatura,dictan,orientacion where dictan.ci= " & txtci.Text & " and dictan.idgrupo = grupo.idgrupo and dictan.idasig = asignatura.idasig and orientacion.idori = grupo.orientacion and dictan.aniodictado = " & Now.Year & " group by dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo"
                Cmd.CommandText = sql
                Dim dw As New Odbc.OdbcDataAdapter(sql, conect)
                dw.Fill(Ds, "dictan")

                DGADocente.DataSource = Ds.Tables("dictan")
            Else
                sql = "UPDATE dictan set activo='Activo' where ci= " & ci & " and idgrupo= " & idgrupo & " and idasig= " & idasig & " and aniodictado = " & Now.Year & ""
                Cmd.CommandText = sql
                Cmd.ExecuteNonQuery()
                MsgBox("Estado cambiado a Activo")
                sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Update','Cambio de estado:Activo, idgrupo: " & idgrupo & ", asignatura: " & idasig & "','dictan', " & fecha2 & ", '" & lblhora2.Text & "')"

                Cmd.CommandText = sql

                Cmd.ExecuteNonQuery()
                Ds.Tables.Clear()



                sql = "SELECT dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo from grupo,asignatura,dictan,orientacion where dictan.ci= " & txtci.Text & " and dictan.idgrupo = grupo.idgrupo and dictan.idasig = asignatura.idasig and orientacion.idori = grupo.orientacion and dictan.aniodictado = " & Now.Year & " group by dictan.ci,dictan.idgrupo,dictan.aniodictado,dictan.idasig,asignatura.nombre,grupo.grado,orientacion.orientacion,grupo.nombre,dictan.activo"
                Cmd.CommandText = sql
                Dim dw As New Odbc.OdbcDataAdapter(sql, conect)
                dw.Fill(Ds, "dictan")

                DGADocente.DataSource = Ds.Tables("dictan")
            End If
        End If
        conect.Close()
    End Sub

    Private Sub DGAAlumnos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGAAlumnos.CellContentClick
        conn()
        Dim ci As Integer
        Dim idgrupo As Integer


        ci = DGAAlumnos.Item(0, DGAAlumnos.CurrentRow.Index).Value
        idgrupo = DGAAlumnos.Item(1, DGAAlumnos.CurrentRow.Index).Value
       

        Dim activos As String
        Dim resp As String
        sql2 = "SELECT activo from concurren where ci= " & ci & " and idgrupo= " & idgrupo & "  and aniocursado = " & Now.Year & ""
        Cmd.CommandText = sql2
        activos = Cmd.ExecuteScalar
     

        resp = MsgBox("Se cambiará el estado del grupo que concurre el alumno actual, su estado es " & activos & " ¿Desea cambiarlo?", MsgBoxStyle.YesNo, "DvS")
        If resp = vbYes Then
            If activos = "Activo" Then
                sql = "UPDATE concurren set activo='No Activo' where ci= " & ci & " and idgrupo= " & idgrupo & "  and aniocursado = " & Now.Year & ""
                Cmd.CommandText = sql
                Cmd.ExecuteNonQuery()

                Ds.Tables.Clear()
                MsgBox("Estado cambiado a No activo")
                sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Update','Cambio de estado:No Activo, idgrupo: " & idgrupo & "','concurren', " & fecha2 & ", '" & lblhora2.Text & "')"

                Cmd.CommandText = sql

                Cmd.ExecuteNonQuery()
                DGAAlumnos.Visible = True
                Ds.Tables.Clear()
                sql = "SELECT concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo from grupo,concurren,orientacion where concurren.ci= " & txtci.Text & " and concurren.idgrupo = grupo.idgrupo and  orientacion.idori = grupo.orientacion and concurren.aniocursado = " & Now.Year & " group by concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo"
                Cmd.CommandText = sql
                Dim dz As New Odbc.OdbcDataAdapter(sql, conect)
                dz.Fill(Ds, "concurren")
                grupos = 2
                DGAAlumnos.DataSource = Ds.Tables("concurren")

        

            Else
                sql = "UPDATE concurren set activo='Activo' where ci= " & ci & " and idgrupo= " & idgrupo & "  and aniocursado = " & Now.Year & ""
                Cmd.CommandText = sql
                Cmd.ExecuteNonQuery()
                MsgBox("Estado cambiado a Activo")
                sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ", '" & txtci.Text & "','Update','Cambio de estado:Activo, idgrupo: " & idgrupo & "','concurren', " & fecha2 & ", '" & lblhora2.Text & "')"

                Cmd.CommandText = sql

                Cmd.ExecuteNonQuery()
                Ds.Tables.Clear()
                sql = "SELECT concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo from grupo,concurren,orientacion where concurren.ci= " & txtci.Text & " and concurren.idgrupo = grupo.idgrupo and  orientacion.idori = grupo.orientacion and concurren.aniocursado = " & Now.Year & " group by concurren.ci,concurren.idgrupo,concurren.aniocursado,grupo.grado,orientacion.orientacion,grupo.nombre,concurren.activo"
                Cmd.CommandText = sql
                Dim dz As New Odbc.OdbcDataAdapter(sql, conect)
                dz.Fill(Ds, "concurren")
                grupos = 2
                DGAAlumnos.DataSource = Ds.Tables("concurren")

            End If
        End If
        conect.Close()
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

    Private Sub AltaToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem5.Click
        AltaAdministrativo.Show()
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

    Private Sub AdministrativoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaAdministrativo.Show()
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
End Class