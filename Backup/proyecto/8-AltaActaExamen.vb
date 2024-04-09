Imports System.Data.Odbc

Public Class AltaActaExamen
    Inherits System.Windows.Forms.Form
    Public idperiodo As Integer
    Public periodo2 As Integer
    Dim datagrid As Integer
    Dim año As Integer
    Dim estado As String
    Dim grado As Integer
    Dim mes As String
    Dim mes1 As Integer


    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub

 


  

    Private Sub CambiarAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub AltaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AltaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub BajaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Verificar_Acta_Examen.Show()
        Me.Close()


    End Sub

    Private Sub BajaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VerificarActaFinal.Show()

        Me.Close()
    End Sub

    Private Sub ModificacionActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModificacionActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub btnconfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfirmar.Click
        conn()


        Dim periodo As Integer





       



        Dim fecha As String
        Dim carac As String

        Dim año As Integer
        carac = "%d/%m/%Y"
        fecha = "to_date('" & txtfechanacadmin.Text & "', '" & carac & "') "
        año = Now.Year




        Dim cmd2 As New Odbc.OdbcCommand
        Dim cmd3 As New Odbc.OdbcCommand
        Dim cmd4 As New Odbc.OdbcCommand
        Dim conect3 As New Odbc.OdbcConnection
        Dim conect5 As New Odbc.OdbcConnection
        Dim conect4 As New Odbc.OdbcConnection
        Dim ds As Odbc.OdbcDataReader
        Dim conect2 As New Odbc.OdbcConnection
        Dim dz As Odbc.OdbcDataReader
        Dim cmd5 As New Odbc.OdbcCommand
        Dim haber As Boolean
        Dim actafp As Integer
        Dim idgrupop As Integer
        Dim fechap As String
        Dim instituto As Integer
        Dim materiap As Integer
        Dim cmd6 As New Odbc.OdbcCommand
        cmd2.Connection = conect
        cmd3.Connection = conect
        cmd4.Connection = conect
        cmd5.Connection = conect
        Dim actaf As Integer
        cmd6.Connection = conect
        Dim materia As Integer
        Try
            sql2 = "Select count(*) from actaf "

            Cmd.CommandText = sql2
            Cmd.ExecuteScalar()
            contador = Cmd.ExecuteScalar


            sql = "SELECT actaf.n_actaf,actaf.idgrupo from actaf,grupo where actaf.estado='Cerrada' and actaf.instituto = " & txtInstituto.Text & " and grupo.grado = " & grado & " and grupo.idgrupo = actaf.idgrupo group by actaf.n_actaf,actaf.idgrupo "

            Cmd.CommandText = sql

            dr = Cmd.ExecuteReader()


            haber = False
        Catch

        End Try

        sql = "SELECT nombre from instituto where idinst = " & txtInstituto.Text & ""
        cmd5.CommandText = sql
        Try

            If cmd5.ExecuteScalar <> "" Then
                sql = "SELECT nombre from asignatura where idasig = " & txtActaFinal.Text & ""
                cmd5.CommandText = sql
                If cmd5.ExecuteScalar <> "" Then


                    While dr.Read

                        materia = txtActaFinal.Text
                        sql2 = "Select count(*) from actae "

                        cmd3.CommandText = sql2
                        cmd3.ExecuteScalar()
                        contador = cmd3.ExecuteScalar





                        autonumerico = contador + 1

                        actaf = (dr("n_actaf"))
                        idgrupo = (dr("idgrupo"))






                        autonumerico = contador + 1




                        haber = True

                        ''''''''''''''DICIEMBRE''''''''''''''''''''
                        If txtPeriodo.Text = "1" Then

                            Try

                                sql = "SELECT n_actae from actae where n_actaf = " & actaf & " and idperiodo=6 group by n_actae"
                                cmd6.CommandText = sql
                                Dim actae As Integer
                                actae = cmd6.ExecuteScalar



                                sql = "SELECT fallo from examinado where  fallo='Diciembre' and n_actae = " & actae & " group by fallo"
                                cmd6.CommandText = sql
                                Dim fallop2 As String
                                fallop2 = cmd6.ExecuteScalar



                                sql = "SELECT fallo from cursan where n_actaf = " & actaf & " and fallo='Diciembre' group by fallo"
                                cmd6.CommandText = sql
                                Dim fallop As String
                                fallop = cmd6.ExecuteScalar


                                If fallop = "Diciembre" Then
                                    sql = "INSERT INTO actae(n_actaf,n_actae,fecha,anio,idgrupo,idasig,verifico,presidente,secretario,vocal,instituto,estado,inicioe,fine,idperiodo,inicioo,fino) VALUES( " & actaf & ", " & autonumerico & ", " & fecha & " , " & Now.Year & "," & idgrupo & ", " & materia & ",null,null,null,null," & txtInstituto.Text & ",'Abierta',null,null," & txtPeriodo.Text & ",null,null)"
                                    cmd4.CommandText = sql

                                    cmd4.ExecuteNonQuery()


                                    sql2 = "SELECT ci,nota from cursan where fallo='Diciembre' and idasig= " & materia & " and n_actaf= " & actaf & " group by ci,nota"
                                    cmd5.CommandText = sql2
                                    dz = cmd5.ExecuteReader
                                    Dim alumno As Integer
                                    Dim final As Integer
                                    While dz.Read
                                        alumno = (dz("ci"))
                                        final = (dz("nota"))
                                        sql = "INSERT INTO examinado(n_actae,ci,nota,oral,escrita,fallo,notafinal) VALUES(" & autonumerico & ", " & alumno & ",null,null,null,null, " & final & ")"
                                        cmd4.CommandText = sql

                                        Try
                                            cmd4.ExecuteNonQuery()


                                        Catch
                                            MsgBox("Ya se encuentra abierta el acta que esta ingresando")
                                            haber = False
                                        End Try

                                    End While
                                    dz.Close()

                                    ' sql2 = sql2 = "SELECT ci,nota from examinado where fallo='Diciembre' and  n_actae= " & actae & " group by ci,nota"
                                    'cmd5.CommandText = sql2
                                    'dz = cmd5.ExecuteReader
                                    'While dz.Read
                                    'alumno = (dz("ci"))
                                    'final = (dz("nota"))
                                    'sql = "INSERT INTO examinado(n_actae,ci,nota,oral,escrita,fallo,notafinal) VALUES(" & autonumerico & ", " & alumno & ",null,null,null,null, " & final & ")"
                                    'cmd4.CommandText = sql

                                    'Try
                                    'cmd4.ExecuteNonQuery()


                                    'Catch

                                    haber = False
                                    'End Try

                                    ' End While
                                    ' Else
                                    haber = False
                                    MsgBox("Actas creadas con éxito")
                                Else
                                    MsgBox("ERROR 22:No existen alumnos que se vayan a diciembre")
                                End If
                                     Catch
                            End Try




                            'DICIEMBRE'

                            '''''''''''''FEBRERO''''''''''''''
                        ElseIf txtPeriodo.Text = "2" Then
                            Try
                                sql = "SELECT fallo from cursan where n_actaf = " & actaf & " and fallo='Febrero' group by fallo"
                                cmd6.CommandText = sql
                                Dim fallop As String
                                fallop = cmd6.ExecuteScalar

                                sql = "SELECT n_actae from actae where n_actaf = " & actaf & "  group by n_actae"
                                cmd6.CommandText = sql
                                Dim actae As Integer
                                actae = cmd6.ExecuteScalar


                                sql = "SELECT fallo from examinado where  fallo='Febrero' and n_actae = " & actae & " group by fallo"
                                cmd6.CommandText = sql
                                Dim fallop2 As String
                                fallop2 = cmd6.ExecuteScalar
                                Dim alumno As Integer
                                Dim final As Integer
                                sql = "INSERT INTO actae(n_actaf,n_actae,fecha,anio,idgrupo,idasig,verifico,presidente,secretario,vocal,instituto,estado,inicioe,fine,idperiodo,inicioo,fino) VALUES( " & actaf & ", " & autonumerico & ", " & fecha & " , " & Now.Year & "," & idgrupo & ", " & materia & ",null,null,null,null," & txtInstituto.Text & ",'Abierta',null,null," & txtPeriodo.Text & ",null,null)"
                                cmd6.CommandText = sql

                                cmd6.ExecuteNonQuery()
                                If fallop = "Febrero" Then
                                   


                                    sql2 = "SELECT ci,nota from cursan where fallo='Febrero' and idasig= " & materia & " and n_actaf= " & actaf & " group by ci,nota"
                                    cmd5.CommandText = sql2
                                    dz = cmd5.ExecuteReader
                                 
                                    While dz.Read
                                        alumno = (dz("ci"))
                                        final = (dz("nota"))
                                        sql = "INSERT INTO examinado(n_actae,ci,nota,oral,escrita,fallo,notafinal) VALUES(" & autonumerico & ", " & alumno & ",null,null,null,null, " & final & ")"
                                        cmd4.CommandText = sql

                                        Try
                                            cmd4.ExecuteNonQuery()


                                        Catch
                                            MsgBox(sql)

                                        End Try


                                    End While
                                    dz.Close()
                                Else
                                    MsgBox("ERROR 23:No existen alumnos que se vayan a febrero")
                                End If
                                If fallop2 = "Febrero" Then
                                    sql2 = "SELECT ci,nota from examinado where fallo='Febrero' and  n_actae= " & actae & " group by ci,nota"
                                    cmd5.CommandText = sql2
                                    dz = cmd5.ExecuteReader

                                    While dz.Read
                                        alumno = (dz("ci"))
                                        final = (dz("nota"))
                                        sql = "INSERT INTO examinado(n_actae,ci,nota,oral,escrita,fallo,notafinal) VALUES(" & autonumerico & ", " & alumno & ",null,null,null,null, " & final & ")"
                                        cmd4.CommandText = sql

                                        Try
                                            cmd4.ExecuteNonQuery()


                                        Catch
                                            MsgBox(sql)

                                        End Try

                                    End While
                                End If

                            Catch
                                haber = False
                                MsgBox("ERROR 24:Ya se encuentra abierta/cerrada el acta que esta ingresando")
                            End Try


                            dz.Close()


                            'FEBRERO'








                            '''''''''''''MARZO''''''''''''''
                        ElseIf txtPeriodo.Text = "3" Then
                            Try

                               

                                sql = "SELECT n_actae from actae where n_actaf = " & actaf & " and idperiodo=2 group by n_actae"
                                cmd6.CommandText = sql
                                Dim actae As Integer
                                actae = cmd6.ExecuteScalar
                               
                          

                                sql = "SELECT fallo from examinado where  fallo='Marzo' and n_actae = " & actae & " group by fallo"
                                cmd6.CommandText = sql
                                Dim fallop2 As String
                                fallop2 = cmd6.ExecuteScalar
                                


                                If fallop2 = "Marzo" Then
                                    sql = "INSERT INTO actae(n_actaf,n_actae,fecha,anio,idgrupo,idasig,verifico,presidente,secretario,vocal,instituto,estado,inicioe,fine,idperiodo,inicioo,fino) VALUES( " & actaf & ", " & autonumerico & ", " & fecha & " , " & Now.Year & "," & idgrupo & ", " & materia & ",null,null,null,null," & txtInstituto.Text & ",'Abierta',null,null," & txtPeriodo.Text & ",null,null)"
                                    cmd6.CommandText = sql

                                    cmd6.ExecuteNonQuery()


                                    sql2 = "SELECT ci,nota from examinado where fallo='Marzo' and  n_actae= " & actae & " group by ci,nota"
                                    cmd5.CommandText = sql2
                                    dz = cmd5.ExecuteReader
                                    Dim alumno As Integer
                                    Dim final As Integer
                                    While dz.Read
                                        alumno = (dz("ci"))
                                        final = (dz("nota"))
                                        sql = "INSERT INTO examinado(n_actae,ci,nota,oral,escrita,fallo,notafinal) VALUES(" & autonumerico & ", " & alumno & ",null,null,null,null, " & final & ")"
                                        cmd4.CommandText = sql

                                        Try
                                            cmd4.ExecuteNonQuery()


                                        Catch

                                        End Try


                                    End While
                                    dz.Close()

                                    MsgBox("Acta creada con éxito")
                                End If
                            Catch
                                MsgBox(ErrorToString)


                            End Try


                            dz.Close()


                            'MARZO'




                            '''''''''''''JUNIO''''''''''''''
                        ElseIf txtPeriodo.Text = "4" Then
                            Try



                                sql = "SELECT n_actae from actae where n_actaf = " & actaf & " and idperiodo=3 group by n_actae"
                                cmd6.CommandText = sql
                                Dim actae As Integer
                                actae = cmd6.ExecuteScalar



                                sql = "SELECT fallo from examinado where  fallo='Junio' and n_actae = " & actae & " group by fallo"
                                cmd6.CommandText = sql
                                Dim fallop2 As String
                                fallop2 = cmd6.ExecuteScalar


                                If fallop2 = "Junio" Then
                                    sql = "INSERT INTO actae(n_actaf,n_actae,fecha,anio,idgrupo,idasig,verifico,presidente,secretario,vocal,instituto,estado,inicioe,fine,idperiodo,inicioo,fino) VALUES( " & actaf & ", " & autonumerico & ", " & fecha & " , " & Now.Year & "," & idgrupo & ", " & materia & ",null,null,null,null," & txtInstituto.Text & ",'Abierta',null,null," & txtPeriodo.Text & ",null,null)"
                                    cmd6.CommandText = sql

                                    cmd6.ExecuteNonQuery()


                                    sql2 = "SELECT ci,nota from examinado where fallo='Junio' and  n_actae= " & actae & " group by ci,nota"
                                    cmd5.CommandText = sql2
                                    dz = cmd5.ExecuteReader
                                    Dim alumno As Integer
                                    Dim final As Integer
                                    While dz.Read
                                        alumno = (dz("ci"))
                                        final = (dz("nota"))
                                        sql = "INSERT INTO examinado(n_actae,ci,nota,oral,escrita,fallo,notafinal) VALUES(" & autonumerico & ", " & alumno & ",null,null,null,null, " & final & ")"
                                        cmd4.CommandText = sql

                                        Try
                                            cmd4.ExecuteNonQuery()


                                        Catch

                                        End Try


                                    End While
                                    dz.Close()


                                End If
                            Catch
                                haber = False
                                MsgBox("ERROR 24:Ya se encuentra abierta/cerrada el acta que esta ingresando")
                            End Try


                            dz.Close()


                            'JUNIO'


                            '''''''''''''SETIEMBRE''''''''''''''
                        ElseIf txtPeriodo.Text = "5" Then
                            Try



                                sql = "SELECT n_actae from actae where n_actaf = " & actaf & " and idperiodo=4 group by n_actae"
                                cmd6.CommandText = sql
                                Dim actae As Integer
                                actae = cmd6.ExecuteScalar



                                sql = "SELECT fallo from examinado where  fallo='Setiembre' and n_actae = " & actae & " group by fallo"
                                cmd6.CommandText = sql
                                Dim fallop2 As String
                                fallop2 = cmd6.ExecuteScalar


                                If fallop2 = "Setiembre" Then
                                    sql = "INSERT INTO actae(n_actaf,n_actae,fecha,anio,idgrupo,idasig,verifico,presidente,secretario,vocal,instituto,estado,inicioe,fine,idperiodo,inicioo,fino) VALUES( " & actaf & ", " & autonumerico & ", " & fecha & " , " & Now.Year & "," & idgrupo & ", " & materia & ",null,null,null,null," & txtInstituto.Text & ",'Abierta',null,null," & txtPeriodo.Text & ",null,null)"
                                    cmd6.CommandText = sql

                                    cmd6.ExecuteNonQuery()


                                    sql2 = "SELECT ci,nota from examinado where fallo='Setiembre' and  n_actae= " & actae & " group by ci,nota"
                                    cmd5.CommandText = sql2
                                    dz = cmd5.ExecuteReader
                                    Dim alumno As Integer
                                    Dim final As Integer
                                    While dz.Read
                                        alumno = (dz("ci"))
                                        final = (dz("nota"))
                                        sql = "INSERT INTO examinado(n_actae,ci,nota,oral,escrita,fallo,notafinal) VALUES(" & autonumerico & ", " & alumno & ",null,null,null,null, " & final & ")"
                                        cmd4.CommandText = sql

                                        Try
                                            cmd4.ExecuteNonQuery()


                                        Catch

                                        End Try


                                    End While
                                    dz.Close()


                                End If
                            Catch
                                haber = False
                                MsgBox(ErrorToString)
                                MsgBox("ERROR 24:Ya se encuentra abierta/cerrada el acta que esta ingresando")
                            End Try


                            dz.Close()


                            'SETIEMBRE'





                            '''''''''''''NOVIEMBRE''''''''''''''
                        ElseIf txtPeriodo.Text = "6" Then
                            Try



                                sql = "SELECT n_actae from actae where n_actaf = " & actaf & " and idperiodo=5 group by n_actae"
                                cmd6.CommandText = sql
                                Dim actae As Integer
                                actae = cmd6.ExecuteScalar



                                sql = "SELECT fallo from examinado where  fallo='Noviembre' and n_actae = " & actae & " group by fallo"
                                cmd6.CommandText = sql
                                Dim fallop2 As String
                                fallop2 = cmd6.ExecuteScalar


                                If fallop2 = "Noviembre" Then
                                    sql = "INSERT INTO actae(n_actaf,n_actae,fecha,anio,idgrupo,idasig,verifico,presidente,secretario,vocal,instituto,estado,inicioe,fine,idperiodo,inicioo,fino) VALUES( " & actaf & ", " & autonumerico & ", " & fecha & " , " & Now.Year & "," & idgrupo & ", " & materia & ",null,null,null,null," & txtInstituto.Text & ",'Abierta',null,null," & txtPeriodo.Text & ",null,null)"
                                    cmd6.CommandText = sql

                                    cmd6.ExecuteNonQuery()


                                    sql2 = "SELECT ci,nota from examinado where fallo='Noviembre' and  n_actae= " & actae & " group by ci,nota"
                                    cmd5.CommandText = sql2
                                    dz = cmd5.ExecuteReader
                                    Dim alumno As Integer
                                    Dim final As Integer
                                    While dz.Read
                                        alumno = (dz("ci"))
                                        final = (dz("nota"))
                                        sql = "INSERT INTO examinado(n_actae,ci,nota,oral,escrita,fallo,notafinal) VALUES(" & autonumerico & ", " & alumno & ",null,null,null,null, " & final & ")"
                                        cmd4.CommandText = sql

                                        Try
                                            cmd4.ExecuteNonQuery()


                                        Catch

                                        End Try


                                    End While
                                    dz.Close()


                                End If
                            Catch
                                haber = False
                                MsgBox("ERROR 24:Ya se encuentra abierta/cerrada el acta que esta ingresando")
                            End Try


                            dz.Close()

                        End If
                        'NOVIEMBRE'











                    End While
                Else
                    MsgBox("ERROR 14:La asignatura ingresada no existe")

                End If
            Else
                MsgBox("ERROR 25:El instituto ingresado no existe")

            End If
        Catch

        End Try

        If haber = False Then


        Else
            dr.Close()
            sql = "INSERT INTO historia (ciautor,pk,accion,descripcion,tabla,fecha,hora) VALUES ( " & login2 & ",'" & txtAsignatura.Text & "','Insertar','Se crearon las planillas y actas de exámenes para la orientación " & orientacion & ", grado " & grado & "','actae', " & fecha2 & ", '" & lblhora2.Text & "')"

            Cmd.CommandText = sql

            Cmd.ExecuteNonQuery()
            MsgBox("Ya existe el acta ingresada")
        End If





     



























        conect.Close()


    End Sub

    Private Sub AltaActaExamen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If docentev = 5 Then
            GroupBox1.Visible = False

        Else
            GroupBox1.Visible = True
        End If
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


    Private Sub lblhora2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblhora2.Click

    End Sub

    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        If docentev = 5 Then
            MenuPrincipalDocente.Show()
            Me.Close()
        Else



            MenuPrincipalAdministrativo.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnActaFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActaFinal.Click
        conn()
      


        Ds.Clear()
        datagrid = 1
        lblBuscar.Text = "Nombre Asignatura:"
        DGVConsulta.Visible = True
        lblRecordar.Visible = True
        lblBuscar.Visible = True
        txtBuscar.Visible = True
        Label4.Visible = False
        txtfechanacadmin.Visible = False
        lblInstituto.Visible = False
        txtInstituto.Visible = False
        btnInstituto.Visible = False
        btnPeriodo.Visible = False
        txtPeriodo.Visible = False
        Label5.Visible = False
        lblAsignatura.Visible = True
        txtAsignatura.Visible = True

        sql = "SELECT asignatura.idasig,asignatura.nombre,programa.grado from asignatura,cursan,programa where asignatura.idasig = cursan.idasig and asignatura.idasig = programa.idasig group by asignatura.nombre,programa.grado,asignatura.idasig order by programa.grado"
        Try
            Cmd.CommandText = sql
            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "asignatura")

            DGVConsulta.DataSource = Ds.Tables("asignatura")

        Catch
            MsgBox(ErrorToString)
        End Try




        conect.Close()
    End Sub

    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress

        If e.KeyChar = Chr(13) Then
            conn()
            If datagrid = 1 Then



                Ds.Clear()
                DGVConsulta.Visible = True
                sql = "SELECT asignatura.idasig,asignatura.nombre,programa.grado from asignatura,cursan,programa where asignatura.idasig = cursan.idasig and asignatura.nombre like '%" & txtBuscar.Text & "%' and asignatura.idasig = programa.idasig group by asignatura.nombre,programa.grado,asignatura.idasig order by programa.grado"
                Cmd.CommandText = sql

                Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                da.Fill(Ds, "asignatura")

                DGVConsulta.DataSource = Ds.Tables("asignatura")



            End If
            If datagrid = 2 Then



                Ds.Clear()
                DGVConsulta.Visible = True
                sql = "SELECT nombre from instituto where nombre like '%" & txtBuscar.Text & "%' group by nombre"
                Cmd.CommandText = sql

                Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                da.Fill(Ds, "instituto")

                DGVConsulta.DataSource = Ds.Tables("instituto")



            End If
            conect.Close()

        End If

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick
        conn()

        If datagrid = 1 Then
        DGVConsulta.Visible = False
        lblRecordar.Visible = False
        lblBuscar.Visible = False
        txtBuscar.Visible = False
        Label4.Visible = True
            txtfechanacadmin.Visible = True
            lblInstituto.Visible = True
            txtInstituto.Visible = True
            btnInstituto.Visible = True
            btnPeriodo.Visible = True
            txtPeriodo.Visible = True
            Label5.Visible = True
            txtAsignatura.Visible = False
            lblAsignatura.Visible = False
            txtActaFinal.Text = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
            grado = DGVConsulta.Item(2, DGVConsulta.CurrentRow.Index).Value

        End If


        If datagrid = 2 Then
            DGVConsulta.Visible = False
            lblRecordar.Visible = False
            lblBuscar.Visible = False
            txtBuscar.Visible = False
            Label4.Visible = True
            txtfechanacadmin.Visible = True
            lblInstituto.Visible = True
            txtInstituto.Visible = True
            btnInstituto.Visible = True
            btnPeriodo.Visible = True
            txtPeriodo.Visible = True
            Label5.Visible = True
            lblAsignatura.Visible = False
            txtAsignatura.Visible = False
      
            txtInstituto.Text = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
            sql = "SELECT idinst from instituto where nombre = '" & txtInstituto.Text & "'"
            Cmd.CommandText = sql
            txtInstituto.Text = Cmd.ExecuteScalar
        End If

        If datagrid = 3 Then
            DGVConsulta.Visible = False
            lblRecordar.Visible = False
            lblBuscar.Visible = False
            txtBuscar.Visible = False
            Label4.Visible = True
            txtfechanacadmin.Visible = True
            lblInstituto.Visible = True
            txtInstituto.Visible = True
            btnInstituto.Visible = True
            btnPeriodo.Visible = True
            txtPeriodo.Visible = True
            Label5.Visible = True
        
            txtPeriodo.Text = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
   
        End If


        conect.Close()

    End Sub

   
    Private Sub txtPeriodo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnInstituto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstituto.Click
        conn()



        Ds.Clear()
        datagrid = 2
        lblBuscar.Text = "Instituto"
        DGVConsulta.Visible = True
        lblRecordar.Visible = True
        lblBuscar.Visible = True
        txtBuscar.Visible = True
        Label4.Visible = False
        txtfechanacadmin.Visible = False
        lblInstituto.Visible = False
        txtInstituto.Visible = False
        btnInstituto.Visible = False
        btnPeriodo.Visible = False
        txtPeriodo.Visible = False
        Label5.Visible = False


        sql = "SELECT nombre from instituto where activo='Activo' group by nombre"
        Try
            Cmd.CommandText = sql
            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "instituto")

            DGVConsulta.DataSource = Ds.Tables("instituto")

        Catch
            MsgBox(ErrorToString)
        End Try




        conect.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriodo.Click
        conn()



        Ds.Clear()
        datagrid = 3

        DGVConsulta.Visible = True
        lblRecordar.Visible = False
        lblBuscar.Visible = False
        txtBuscar.Visible = False
        Label4.Visible = False
        txtfechanacadmin.Visible = False
        lblInstituto.Visible = False
        txtInstituto.Visible = False
        btnInstituto.Visible = False
        btnPeriodo.Visible = False
        txtPeriodo.Visible = False
        Label5.Visible = False


        sql = "SELECT idperiodo,nombre from periodo group by idperiodo,nombre order by idperiodo"
        Try
            Cmd.CommandText = sql
            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "periodo")

            DGVConsulta.DataSource = Ds.Tables("periodo")

        Catch
            MsgBox(ErrorToString)
        End Try




        conect.Close()
    End Sub

    Private Sub txtAsignatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAsignatura.KeyPress
        If e.KeyChar = Chr(13) Then
            conn()



            Ds.Clear()
            DGVConsulta.Visible = True
            Try
                sql = "SELECT asignatura.idasig,asignatura.nombre,programa.grado from asignatura,cursan,programa where asignatura.idasig = cursan.idasig and asignatura.idasig = " & txtAsignatura.Text & " and asignatura.idasig = programa.idasig group by asignatura.nombre,programa.grado,asignatura.idasig order by programa.grado"
                Cmd.CommandText = sql

                Dim da As New Odbc.OdbcDataAdapter(sql, conect)
                da.Fill(Ds, "asignatura")

                DGVConsulta.DataSource = Ds.Tables("asignatura")
            Catch
                MsgBox("Código Asignatura no encontrada")
            End Try
            conect.Close()




        End If
    End Sub

    Private Sub txtAsignatura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAsignatura.TextChanged

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