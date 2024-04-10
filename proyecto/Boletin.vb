Imports System
Imports System.IO
Imports System.IO.StreamWriter
Imports System.Data.Odbc
Imports System.Net
Imports System.Data





Public Class Boletin
    Public cedulas As Integer
    Public rep As String
    Dim orientacion As String
    Dim contar As Integer
    Dim nomgrupo As String
    Dim idgrupo As String
    Dim combinado As String
    Dim grado As String
    Dim grupo5 As String


    Private Sub Boletin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        conn()
        contar = 0
        If juan = 5 Then
            juan = 0
            btnGrupoL.Visible = True
            txtgrupo.Visible = True
            cmbGrupo.Visible = False
            Label2.Visible = True
        Else
            Label2.Visible = True
            btnGrupoL.Visible = False
            txtgrupo.Visible = False
            btnBoletin.Visible = True
            cmbGrupo.Visible = True
            Label2.Visible = True
            sql13 = "SELECT grupo.idgrupo,grado,grupo.nombre,orientacion.orientacion from grupo,orientacion,concurren where  orientacion.idori = grupo.orientacion and concurren.ci= " & cilogin & " and grupo.idgrupo = concurren.idgrupo group by grupo.idgrupo,grupo.grado,grupo.orientacion,orientacion.orientacion,grupo.nombre "
            Cmd.CommandText = sql13
            dr = Cmd.ExecuteReader()


            cmbGrupo.Items.Clear()

            While dr.Read
                idgrupo = dr("idgrupo")
                nomgrupo = dr("nombre")
                grado = dr("grado")
                orientacion = dr("orientacion")
                combinado = idgrupo + " " + grado + " " + orientacion + nomgrupo
                cmbGrupo.Items.Add(combinado)

            End While

        End If

        conect.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        If juan = 5 Then
            MenuPrincipalAdministrativo.Show()
            Me.Close()
        Else
            MenuPrincipalAlumno.Show()
            Me.Close()
        End If

     

    End Sub

    Private Sub btnBoletin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoletin.Click
        cedulas = cilogin
        Try
            conn()
            If contar = 15 Then
                idgrupo = txtgrupo.Text
                grupo5 = txtgrupo.Text
            End If
            'Dim sql As String


            'Dim selecc As Integer = txtSeleccion.Text

            File.FileName = "BoletinCalificaciones.html"
            FileOpen(1, "BoletinCalificaciones.html", OpenMode.Output)
            Print(1, "")
            FileClose(1)
            FileOpen(1, "BoletinCalificaciones.html", OpenMode.Append)
            rep = "<html  lang='es'>" &
                    "<head>" &
                      "<meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>" &
                      "<title>Boletin Calificaciones</title>" &
                      "<style type='text/css'>" &
        "#apDiv1 {" &
        "position: absolute;" &
        "width: 342px;" &
        "height: 20px;" &
        "z-index: 1;" &
        "left: 209px;" &
        "top: 38px;" &
        "}" &
        "#apDiv2 {" &
        "position: absolute;" &
        "width: 900px;" &
        "height: 130px;" &
        "z-index: 2;" &
        "left: 9px;" &
        "top: 145px;" &
        "}" &
        "#apDiv3 {" &
        "position: absolute;" &
        "width: 900px;" &
        "height: 20px;" &
        "z-index: 3;" &
        "left: 7px;" &
        "top: 322px;" &
        "}" &
        "#apDiv4 {" &
        "position: absolute;" &
        "width: 900px;" &
        "height: 306px;" &
        "z-index: 4;" &
        "left: 8px;" &
        "top: 342px;" &
        "}" &
        "#apDiv5 { " &
        "position: absolute;" &
        "width: 900px;" &
        "height: 66px;" &
        "z-index: 5;" &
        "left: 8px;" &
        "top: 654px;" &
        "}" &
        "#apDiv6 {" &
        "position: absolute;" &
        "width: 450px;" &
        "height: 79px;" &
        "z-index: 6;" &
        "left: 11;" &
        "top: 745px;" &
        "}" &
        "#apDiv7 {" &
        "position: absolute;" &
        "width: 450px;" &
        "height: 80px;" &
        "z-index: 5;" &
        "left: 461px;" &
        "top: 745px;" &
        "}" &
        "#apDiv8 {" &
        "position: absolute;" &
        "width: 200px;" &
        "height: 137px;" &
        "z-index: 2;" &
        "left: 8px;" &
        "top: 8px;" &
        "}" &
        "</style>" &
        "</head>" &
        "<body>" &
        "<div id='apDiv1'>" &
        "<div align='center'>BOLETIN DE CALIFICACIONES</div>" &
        "</div>"
            'consultas

            Dim contador As Integer
            sql1 = "select count(*) from concurren where idgrupo=" & idgrupo & ""

            Cmd.CommandText = sql1
            contador = Cmd.ExecuteScalar

            sql = "select nombre1,apaterno,amaterno,nombre2,aniocursado,count(*) from personas,concurren where personas.ci=" & cedulas & " and concurren.ci=" & cedulas & " group by nombre1,apaterno,aniocursado,amaterno,nombre2 "
            Cmd.CommandText = sql

            Dim datosalumno As OdbcDataReader

            datosalumno = Cmd.ExecuteReader()


            While datosalumno.Read
                Dim completo As String
                completo = datosalumno("apaterno") + " " + datosalumno("amaterno") + " " + "," + datosalumno("nombre1") + " " + datosalumno("nombre2")

                rep = rep & "<div id='apDiv2'>" &
                      " <table width='900' height='120' border='1'>" &
                        "<tr>" &
                          "<td width='95' height='30'>Nombre:</td>" &
                          "<td height='30' colspan='2'>" & completo & "  </td>" &
                          "<td width='92' height='30'>Nº Lista:</td>" &
                          "<td width='97' height='30'>" & contador & " </td>" &
                          "<td width='167' height='30'>Anio Lectivo:</td>" &
                          "<td width='96' height='30'>" & datosalumno("aniocursado") & "</td>" &
                        "</tr>"
            End While
            datosalumno.Close()

            'consultas
            sql = "select instituto.idinst, instituto.nombre from grupo,concurren,instituto where concurren.ci = " & cedulas & " and instituto.idinst = grupo.instituto and grupo.idgrupo= " & idgrupo & " group by instituto.idinst,instituto.nombre"
            Cmd.CommandText = sql
            Dim escuela As OdbcDataReader
            escuela = Cmd.ExecuteReader()
            While escuela.Read
                rep = rep & "<tr>" &
                          "<td width='95' height='30'>Escuela:</td>" &
                          "<td width='112' height='30'>" & escuela("idinst") & "</td>" &
                          " <td height='30' colspan='2'>" & escuela("nombre") & "</td>"
            End While
            escuela.Close()

            'consultas
            sql = "select ci from concurren where ci= " & cedulas & " group by ci"
            Cmd.CommandText = sql
            Dim numdoc As OdbcDataReader
            numdoc = Cmd.ExecuteReader()
            While numdoc.Read
                rep = rep & "<td width='97' height='30'>Doc:</td>" &
                              "<td width='167' height='30'>" & numdoc("ci") & "</td>" &
                            "</tr>"
            End While
            numdoc.Close()

            'consultas
            sql = "select orientacion.orientacion,grupo.nombre,grado from grupo,orientacion where grupo.idgrupo = " & idgrupo & " and grupo.orientacion = orientacion.idori group by orientacion.orientacion,grupo.nombre,grupo.grado"
            Cmd.CommandText = sql
            Dim grupo As OdbcDataReader
            grupo = Cmd.ExecuteReader()
            While grupo.Read
                Dim nombre As String
                Dim orientacion As String
                Dim grupo2 As String

                grado = grupo("grado")
                nombre = grupo("nombre")
                orientacion = grupo("orientacion")
                grupo2 = orientacion + nombre
                rep = rep & "<tr>" &
                              "<td width='95' height='30'>Grupo:</td>" &
                              "<td height='30' colspan='2'>" & grupo2 & "</td>"

            End While
            grupo.Close()

            'consultas
            rep = rep & "<td width='92' height='30'>Anio:</td>" &
                          " <td height='30'>" & grado & "</td>" &
                        "</tr>"

            'consultas
            sql = "select t_curso.idcurso,t_curso.completo from t_curso,grupo,concurren where grupo.idgrupo = " & idgrupo & " and t_curso.idcurso = grupo.t_curso group by t_curso.idcurso, t_curso.completo,grupo.idgrupo"
            Cmd.CommandText = sql
            Dim tipocurso As OdbcDataReader
            tipocurso = Cmd.ExecuteReader()
            While tipocurso.Read
                rep = rep & "<tr>" &
                              " <td width='95' height='30'>Tipo de Curso:</td>" &
                              "<td height='30'>" & tipocurso("idcurso") & "</td>" &
                              "<td width='195' height='30'>" & tipocurso("completo") & "</td>"
            End While
            tipocurso.Close()

            'consultas

            sql = "select idori,completo from orientacion,grupo where grupo.idgrupo = " & grupo5 & " and orientacion.idori = grupo.orientacion group by idori,completo"
            Cmd.CommandText = sql

            Dim curso As OdbcDataReader
            curso = Cmd.ExecuteReader()
            While curso.Read
                rep = rep & "<td height='30'>Curso:</td>" &
                              "<td height='30'>" & curso("idori") & "</td>" &
                              "<td height='30' colspan='2'>" & curso("completo") & "</td>" &
                            "</tr>" &
                          "</table>" &
                        "</div>"
            End While
            curso.Close()


            rep = rep & "<div id='apDiv3'>" &
                            "<div align='center'>Reunion final</div>" &
                        "</div>" &
        "<div id='apDiv4'>" &
        "<table width='900' border='1'>" &
        "<tr>" &
          "<td width='162' height='20'><div align='center'>Asignatura</div></td>" &
          "<td width='162' height='20'><div align='center'>Inasistencias</div></td>" &
          "<td width='163' height='20'><div align='center'>Rendimiento</div></td>" &
          "<td width='163' height='20'><div align='center'>Calidad</div></td>" &
        "</tr>"
            'consultas
            sql = "select cursan.nota,cursan.inasistencias,asignatura.nombre,cursan.fallo from cursan,grupo,asignatura where cursan.ci=" & cilogin & " and cursan.idasig = asignatura.idasig group by cursan.nota,cursan.inasistencias,asignatura.nombre,cursan.fallo"
            Cmd.CommandText = sql
            Dim notas As OdbcDataReader
            notas = Cmd.ExecuteReader()
            While notas.Read
                rep = rep & "<tr>" &
                              "<td width='162' height='20'>" & notas("nombre") & "</td>" &
                              "<td width='162' height='20'>" & notas("inasistencias") & "</td>" &
                              "<td width='163' height='20'>" & notas("nota") & "</td>" &
                              "<td width='163' height='20'></td>" &
                            "</tr>"
            End While
            notas.Close()
            rep = rep & "</table>" &
                        "</div>"
            'consultas
            sql = "select nombre1 from personas where ci= " & cilogin & ""
            Cmd.CommandText = sql
            Dim falloglobal As OdbcDataReader
            falloglobal = Cmd.ExecuteReader()
            While falloglobal.Read
                rep = rep & "<div id='apDiv5'>" &
                          "<table width='900' height='64' border='1'>" &
                            "<tr>" &
                              "<td width='98' height='30'>Fallo Global:</td>" &
                              "<td width='97' height='30'></td>"
            End While
            falloglobal.Close()

            'consultas
            sql = "select nombre1 from personas where ci= " & cilogin & ""
            Cmd.CommandText = sql
            Dim calglobal As OdbcDataReader
            calglobal = Cmd.ExecuteReader()
            While calglobal.Read
                rep = rep & "<td width='128' height='30'>Calificacion Global:</td>" &
                              "<td width='109' height='30'></td>"
            End While
            calglobal.Close()

            'consultas
            sql = "select nombre1 from personas where ci= " & cilogin & ""
            Cmd.CommandText = sql
            Dim conducta As OdbcDataReader
            conducta = Cmd.ExecuteReader()
            While conducta.Read
                rep = rep & " <td width='109' height='30'>Conducta:</td>" &
                              "<td width='109' height='30'></td>" &
                            "</tr>"
            End While
            conducta.Close()

            'consultas
            sql = "select nombre1 from personas where ci= " & cilogin & ""
            Cmd.CommandText = sql
            Dim juicioglobal As OdbcDataReader
            juicioglobal = Cmd.ExecuteReader()
            While juicioglobal.Read
                rep = rep & "<tr>" &
                              "<td height='30'>Juicio Global:</td>" &
                              "<td height='30'></td>" &
                            "</tr>" &
                            "</table>" &
                        "</div>"
            End While
            juicioglobal.Close()


            rep = rep & "<div id='apDiv6'>" &
                          "<p>Por el instituto: _____________________</p>" &
                        "</div>" &
                        "<div id='apDiv7'>" &
                          "<p align='center'>	Sello</p>" &
                        "</div>" &
                        "<div id='apDiv8'>" &
                          "<div align='center'><strong>ANEP </strong></div>" &
                          "<p align='center'>CONSEJO DE EDUCACION  TECNICO PROFESIONAL  (Universidad del trabajo  del Uruguay)</p>" &
                        "</div>"

            rep = rep & "</body>" &
                        "</html>"
            Print(1, rep)

            FileClose()

            conect.Close()

            webbrowser.Visible = True
            webbrowser.Navigate("File:" & Application.StartupPath & "\BoletinCalificaciones.html")
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnimprimirpdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimirpdf.Click
        webbrowser.Print()
    End Sub

    Private Sub cmbGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrupo.SelectedIndexChanged

        nombre2 = cmbGrupo.Text

        varnueva = nombre2(0)
        varnueva2 = nombre2(1)

        grupo5 = varnueva + varnueva2
    End Sub

    Private Sub btnGrupoL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupoL.Click
        conn()
        Ds.Clear()

        If contar = 10 Then

            sql = "SELECT personas.ci,personas.apaterno from personas,concurren,asignatura,grupo where personas.ci = concurren.ci   and grupo.idgrupo = " & txtgrupo.Text & " and concurren.idgrupo = grupo.idgrupo group by personas.ci,personas.apaterno,personas.nombre1 order by personas.apaterno "

            Cmd.CommandText = sql

            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "personas")

            DGVConsulta.DataSource = Ds.Tables("personas")
            DGVConsulta.Visible = True
            contar = 15

        Else

            sql = "select grupo.idgrupo,grado,nombre,orientacion.orientacion,turno.turno from grupo,orientacion,turno where grupo.orientacion = orientacion.idori and  grupo.anio = " & Now.Year & " and grupo.activo = 'Activo' and grupo.turno=turno.idturno group by  grupo.idgrupo,grado,nombre,orientacion.orientacion,turno.turno "
            Cmd.CommandText = sql
            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "grupo")
            DGVConsulta.DataSource = Ds.Tables("grupo")

            DGVConsulta.Visible = True
            contar = 5

        End If
        conect.Close()
    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick

        If contar = 5 Then
            contar = 10
        

            Dim Variable As String = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
            txtgrupo.Text = Variable

            DGVConsulta.Visible = False
        End If

        If contar = 15 Then
            Dim cedula As String = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
            cilogin = cedula
            DGVConsulta.Visible = False
            MsgBox("Presione el botón 'Listar' para poder ver el boletin del alumno " & cilogin & " ")

        End If
    End Sub

    Private Sub txtgrupo_TextChanged(sender As Object, e As EventArgs) Handles txtgrupo.TextChanged

    End Sub
End Class
