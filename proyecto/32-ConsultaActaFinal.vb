Imports System
Imports System.IO
Imports System.IO.StreamWriter
Imports System.Data.Odbc
Imports System.Net
Imports System.Data

Public Class ConsultaActaFinal

    Private Sub DirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaAdministrativo.Show()
        Me.Close()

    End Sub


    Private Sub AlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaAlumno.Show()
        Me.Close()
    End Sub

    Private Sub DocenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaDocente.Show()
        Me.Close()
    End Sub

    Private Sub AsignaturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaAsignatura.Show()
        Me.Close()
    End Sub

    Private Sub GrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaGrupo.Show()
        Me.Close()

    End Sub

    Private Sub ActaDeExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaActaExamen.Show()
        Me.Close()
    End Sub

    Private Sub ActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AltaActaFinal.Show()
        Me.Close()
    End Sub

    Private Sub btnmenuprincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuPrincipalAdministrativo.Show()
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




    Private Sub ConsultaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaInstituto.Show()
        Me.Close()

    End Sub


    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Form33_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2


        conn()
        sql2 = "SELECT nombre FROM instituto,administra where instituto.activo ='Activo' group by nombre  "
        Cmd.CommandText = sql2
        dr = Cmd.ExecuteReader()

      






        conect.Close()


    End Sub


    Private Sub AltaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaActaExamenToolStripMenuItem.Click
        AltaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub AltaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaActaFinalToolStripMenuItem.Click
        AltaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub BajaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub BajaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaExamen.Show()
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

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CmbConsultaListado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAscendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btndescendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
    Private Sub lblcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        MenuPrincipalAdministrativo.Show()
        Me.Close()
    End Sub

    Private Sub btnlistar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlistar.Click
        conn()
        Dim cmd2 As New Odbc.OdbcCommand

        sql = "SELECT instituto from grupo where idgrupo= " & grupo & ""
        Cmd.CommandText = sql
        idinst = Cmd.ExecuteScalar
        sql = "select instituto from actaf where n_actaf= " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        idinst = Cmd.ExecuteScalar

        sql = "SELECT idgrupo from actaf where n_actaf= " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        grupo = Cmd.ExecuteScalar

        idgrupo = grupo



        conect2.ConnectionString = "FILEDSN=" & Application.StartupPath & "\conexion.dsn;"
        cmd2.Connection = conect2
        conect2.open()

        Dim rep As String
        File.FileName = "ActaFinal.html"
        FileOpen(1, "ActaFinal.html", OpenMode.Output)
        Print(1, "")
        FileClose(1)
        FileOpen(1, "ActaFinal.html", OpenMode.Append)
        rep = "<html  lang='es'>" & _
        "<head>" & _
         "<meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>" & _
         "<title>ActaFinal</title>" & _
         "<style type='text/css'>" & _
"#apDiv1 {" & _
 "position: absolute;" & _
 "width: 286px;" & _
 "height: 27px;" & _
 "z-index: 1;" & _
 "left: 12px;" & _
 "top: 30px;" & _
"}" & _
"#apDiv2 {" & _
 "position: absolute;" & _
 "width: 200px;" & _
 "height: 115px;" & _
 "z-index: 2;" & _
 "left: 12px;" & _
 "top: 68px;" & _
"}" & _
"#apDiv3 {" & _
 "position: absolute;" & _
 "width: 774px;" & _
 "height: 145px;" & _
 "z-index: 3;" & _
 "left: 223px;" & _
 "top: 66px;" & _
"}" & _
"#apDiv4 {" & _
 "position: absolute;" & _
 "width: 940px;" & _
 "height: 103px;" & _
 "z-index: 4;" & _
 "left: 17px;" & _
 "top: 267px;" & _
"}" & _
"#apDiv5 {" & _
 "position: absolute;" & _
 "width: 940px;" & _
 "height: 27px;" & _
 "z-index: 5;" & _
 "left: 13px;" & _
 "top: 386px;" & _
"}" & _
"#apDiv6 {" & _
 "position: absolute;" & _
 "width: 714px;" & _
 "height: 6px;" & _
 "z-index: 6;" & _
 "left: 16px;" & _
 "top: 343px;" & _
"}" & _
"#apDiv7 {" & _
 "position: absolute;" & _
 "width: 940px;" & _
 "height: 104px;" & _
 "z-index: 7;" & _
 "left: 13px;" & _
 "top: 421px;" & _
"}" & _
"#apDiv8 {" & _
 "position: absolute;" & _
 "width: 940px;" & _
 "height: 5px;" & _
 "z-index: 8;" & _
 "left: 15px;" & _
 "top: 425px;" & _
"}" & _
"#apDiv9 {" & _
    "position: absolute;" & _
 "width: 714px;" & _
 "height: 6px;" & _
 "z-index: 6;" & _
 "left: 16px;" & _
 "top: 343px;" & _
"}" & _
"#apDiv10 {" & _
    "position: absolute;" & _
 "width: 714px;" & _
 "height: 6px;" & _
 "z-index: 6;" & _
 "left: 16px;" & _
 "top: 343px;" & _
"}" & _
"#apDiv11 {" & _
 "position: absolute;" & _
 "width: 940px;" & _
 "height: 5px;" & _
 "z-index: 6;" & _
 "left: 17px;" & _
 "top: 345px;" & _
"}" & _
"#apDiv12 {" & _
 "position: absolute;" & _
 "width: 206px;" & _
 "height: 97px;" & _
 "z-index: 9;" & _
 "left: 232px;" & _
 "top: 1053px;" & _
"}" & _
"#apDiv13 {" & _
 "position: absolute;" & _
 "width: 201px;" & _
 "height: 450px;" & _
 "z-index: 9;" & _
 "left: 24px;" & _
 "top: 586px;" & _
"}" & _
"#apDiv14 {" & _
"position: absolute;" & _
 "width: 0px;" & _
 "height: 450px;" & _
 "z-index: 10;" & _
 "left: 229px;" & _
 "top: 586px;" & _
"}" & _
"#apDiv15 {" & _
"position: absolute;" & _
 "width: 531px;" & _
 "height: 480px;" & _
 "z-index: 11;" & _
 "left: 225px;" & _
 "top: 560px;" & _
"}" & _
"#apDiv16 {" & _
 "position: absolute;" & _
 "width: 201px;" & _
 "height: 73px;" & _
 "z-index: 1;" & _
 "left: 24px;" & _
 "top: 1054px;" & _
"}" & _
"#apDiv17 {" & _
 "position: absolute;" & _
 "width: 201px;" & _
 "height: 73px;" & _
 "z-index: 1;" & _
 "left: 6px;" & _
 "top: 504px;" & _
"}" & _
"#apDiv18 {" & _
 "position: absolute;" & _
 "width: 200px;" & _
 "height: 99px;" & _
 "z-index: 12;" & _
 "left: 445px;" & _
 "top: 1052px;" & _
"}" & _
"#apDiv19 {" & _
 "position: absolute;" & _
 "width: 309px;" & _
 "height: 98px;" & _
 "z-index: 13;" & _
 "left: 654px;" & _
 "top: 1052px;" & _
"}" & _
"</style>" & _
"</head>" & _
"<body>" & _
"<div id='apDiv1'><u><strong>Acta de la Reunion Final de Profesores</strong></u></div>" & _
"<div id='apDiv2'> " & _
  "<div align='center'><strong>ANEP  </strong>" & _
  "</div>" & _
  "<p align='center'>CONSEJO DE EDUCACION  TECNICO PROFESIONAL  (Universidad del trabajo  del Uruguay)</p>" & _
"</div>" & _
"<div id='apDiv3'>" & _
"<table width='736' height='57' border='0'>" & _
                                "<tr>"
        'consultas varios datos
        'Escuela $nombreescuela Año $numaño Semestre $numsemestre Grupo $NombreGrupo Tipo de curso $tipodecurso Curso $Curso.
        'En $locacion siendo la hora $horaaltaacta el dia $fechaaltaacta bajo la presidencia del Prof. $nombreprof y con las asistencias de los Sres	Profesores
        sql = "select instituto.nombre, grupo.anio,grupo.nombre,grupo.grado,orientacion.orientacion from grupo,instituto,orientacion where grupo.idgrupo = " & idgrupo & " and grupo.orientacion = orientacion.idori and grupo.instituto = instituto.idinst group by instituto.nombre,grupo.anio,grupo.nombre,grupo.grado,orientacion.orientacion"
        Cmd.CommandText = sql
        Dim datos As OdbcDataReader
        datos = Cmd.ExecuteReader()
        While datos.Read
            rep = rep & "<td>Escuela</td>" & _
                        "<td>" & datos("nombre") & "</td>" & _
                        "<td>Año</td>" & _
                        "<td>" & datos("anio") & "</td>" & _
                        "<td>Semestre</td>" & _
                        "<td>2</td>" & _
                        "</tr>" & _
                        "<tr>" & _
                        "<td>Grupo</td>" & _
                        "<td>" & datos("grado") & "</td>"

        End While
        datos.Close()
        rep = rep & "</div>"




        sql = "select t_curso.completo from grupo,t_curso where grupo.t_curso = t_curso.idcurso and grupo.idgrupo = " & grupo & ""
        Cmd.CommandText = sql
        datos = Cmd.ExecuteReader()
        While datos.Read

            rep = rep & "<td>Tipo de curso</td>" & _
                                    "<td>" & datos("completo") & "</td>"

        End While
        datos.Close()
        rep = rep & "</div>"

        sql = "select orientacion.completo from grupo,orientacion where grupo.orientacion = orientacion.idori and grupo.idgrupo = " & grupo & ""
        Cmd.CommandText = sql
        datos = Cmd.ExecuteReader()
        While datos.Read
            rep = rep & "<td>Curso</td>" & _
                                        "<td>" & datos("completo") & "</td>"

        End While
        datos.Close()
        rep = rep & "</tr>" & _
                       "</table>" & _
                       "</div>" & _
                       "<div id='apDiv4'>" & _
                       "<table width='940' height='103' border='0'>" & _
                       "<div align='center'>Docentes que participaron de la reunion:</div>" & _
                       "<tr>"
        'consultas todos los nombres de los profesores presentes en el acta, apellido y nombre
        sql = "select personas.nombre1,personas.apaterno from dictan,grupo,personas where grupo.idgrupo = " & grupo & " and dictan.idgrupo = grupo.idgrupo and dictan.ci = personas.ci and dictan.activo='Activo' group by personas.nombre1,personas.apaterno "
        Cmd.CommandText = sql

        Dim datosprof As OdbcDataReader
        datosprof = Cmd.ExecuteReader()
        While datosprof.Read
            rep = rep & "<td width='235'>" & datosprof("nombre1") & " " & datosprof("apaterno") & "</td>"
        End While
        datosprof.Close()

        rep = rep & "</tr>" & _
                     "</table>" & _
                     "</div>" & _
                     "<div id='apDiv5'>" & _
                     "<div align='center'>Se consideran las actuaciones de los siguientes alumnos:</div>" & _
                    "</div>"

        rep = rep & "<div id='apDiv7'>" & _
                            "<table width='943' border='0'>" & _
                                "<tr>"
        'consultas, trae tantas materias como sea necesario, nombre de la materia
        Dim grado As Integer
        Dim orientacion As Integer
        sql15 = "SELECT grado from grupo where idgrupo= " & grupo & " "
        Cmd.CommandText = sql15
        grado = Cmd.ExecuteScalar()

        sql11 = "SELECT orientacion from grupo where idgrupo= " & grupo & ""
        Cmd.CommandText = sql11
        orientacion = Cmd.ExecuteScalar()

        sql2 = "SELECT asignatura.nombre,asignatura.idasig FROM asignatura,grupo,programa where programa.idori = " & orientacion & " and programa.grado = " & grado & " and programa.idasig = asignatura.idasig group by asignatura.nombre,asignatura.idasig order by asignatura.idasig "
        Cmd.CommandText = sql2

        Dim Contador As Integer
        Contador = 0
        Dim Materia As OdbcDataReader
        Materia = Cmd.ExecuteReader()
        While Materia.Read
            Contador = Contador + 1
            rep = rep & "<td width='35'>" & Contador & "</td>" & _
                        "<td width='200'>" & Materia("idasig") & " " & Materia("nombre") & "</td>"
        End While

        Materia.Close()
        rep = rep & "</tr>"


        rep = rep & "</table>" & _
                        "</div>" & _
                        "<div id='apDiv13'>" & _
                        "<table width='200' border='1'>" & _
                            "<caption>" & _
                              "APELLIDOS Y NOMBRES" & _
                            "</caption>"

        'consultas nombre y apellido alumno
        sql = "select personas.nombre1,personas.apaterno from personas,concurren where concurren.idgrupo = " & grupo & "  and concurren.ci = personas.ci group by personas.nombre1,personas.apaterno order by personas.apaterno "
        Cmd.CommandText = sql
        Dim datosAlumno As OdbcDataReader
        datosAlumno = Cmd.ExecuteReader()
        While datosAlumno.Read
            rep = rep & "<tr>" & _
                            "<td height='30'>" & datosAlumno("nombre1") & "</td>" & _
                            "<td height='30'>" & datosAlumno("apaterno") & "</td>" & _
                        "</tr>"
        End While
        datosAlumno.Close()

        rep = rep & "</table>" & _
                    "</div>"
        rep = rep & "<div id='apDiv14'>" & _
                        "<table width='0' border='0'>"


        'consultas materias previas y procedencia
        sql = "select nombre1,nombre2 from personas where ci=53462599"
        Cmd.CommandText = sql
        Dim previasAlumno As OdbcDataReader
        previasAlumno = Cmd.ExecuteReader()
        While previasAlumno.Read
            rep = rep & "<tr>" & _
                            "<td height='30'></td>" & _
                            "<td height='30'></td>" & _
                        "</tr>"
        End While
        previasAlumno.Close()
        rep = rep & "</table>" & _
                    "</div>"
        rep = rep & "<div id='apDiv15'>" & _
                        "<table width='531' height='86' border='1'>" & _
                        "<tr>" & _
                                  "<td height='24' colspan='2'>1</td>" & _
                                  "<td colspan='2'>2</td>" & _
                                  "<td colspan='2'>3</td>" & _
                                  "<td colspan='2'>4</td>" & _
                                  "<td colspan='2'>5</td>" & _
                                  "<td colspan='2'>6</td>" & _
                                  "<td colspan='2'>7</td>" & _
                                  "<td colspan='2'>8</td>" & _
                                  "<td colspan='2'>9</td>" & _
                                  "<td colspan='2'>10</td>" & _
                                  "<td colspan='2'>11</td>" & _
                                  "<td colspan='2'>12</td>" & _
                                  "<td colspan='2'>13</td>" & _
                                  "<td colspan='2'>14</td>" & _
                                  "<td colspan='2'>15</td>" & _
                                  "<td colspan='2'>16</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                                  "<td>R</td>" & _
                                  "<td>I</td>" & _
                              "</tr>" & _
                              "<tr>"

        'consultas 1ercampo(1er td) Rendimiento Materia 1 2do campo(2do td) Conducta Materia 1, y asi sucesivamente hasta 16
        sql = "select personas.nombre1,personas.apaterno,personas.ci from personas,concurren where concurren.idgrupo = " & grupo & "  and concurren.ci = personas.ci group by personas.nombre1,personas.apaterno,personas.ci order by personas.apaterno "
        cmd2.CommandText = sql




        datosAlumno = cmd2.ExecuteReader()

        While datosAlumno.Read
            Dim notasAlumno As OdbcDataReader
            Dim cel As Integer
            cel = Convert.ToInt32(datosAlumno("ci"))

            ' Construye la fila HTML para este alumno
            Dim filaHTML As String = "<tr>"
            ' Realiza la consulta para obtener las notas e inasistencias del alumno
            sql = "select cursan.inasistencias, cursan.nota, asignatura.idasig " &
        "from cursan " &
        "inner join asignatura on asignatura.idasig = cursan.idasig " &
        "inner join actaf on cursan.n_actaf = actaf.n_actaf " &
        "inner join grupo on actaf.idgrupo = grupo.idgrupo " &
        "inner join concurren on concurren.ci = cursan.ci " &
        "where grupo.idgrupo = " & grupo & " and concurren.ci = " & cel & " " &
        "group by cursan.nota, cursan.inasistencias, asignatura.idasig " &
        "order by asignatura.idasig"

            Cmd.CommandText = sql
            notasAlumno = Cmd.ExecuteReader()

            ' Concatena las notas e inasistencias a la fila HTML
            While notasAlumno.Read
                filaHTML &= "<td height='30'>" & notasAlumno("nota") & "</td>" &
                    "<td height='30'>" & notasAlumno("inasistencias") & "</td>"
            End While

            notasAlumno.Close()

            ' Cierra la fila HTML
            filaHTML &= "</tr>"

            ' Agrega la fila HTML a la variable "rep"
            rep &= filaHTML
        End While


        datosAlumno.Close()
        rep = rep & "</tr>" & _
                    "</table>" & _
                    "</div>"
        rep = rep & "<div id='apDiv12'>" & _
                        "<p>Secretario:  _________________</p>" & _
                    "</div>" & _
                    "<div id='apDiv18' > " & _
                      "<p align='center'>Sello</p>" & _
                    "</div>" & _
                    "<div id='apDiv19'>" & _
                      "<p align='center'>Director:  _________________</p>" & _
                    "</div>" & _
                    "<div id='apDiv16'>" & _
                        "<p>Verifico: _________________</p>" & _
                      "</div>" & _
                    "</body>" & _
                    "</html>"
        Print(1, rep)
        FileClose()
        webbrowser.Visible = True
        webbrowser.Navigate("File:" & Application.StartupPath & "\ActaFinal.html")
        conect.Close()

    End Sub

  

    Private Sub btnGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupo.Click
        conn()


        Ds.Clear()
        DGVConsulta.Visible = True
        txtBuscar.Visible = True
        lblRecordar.Visible = True
        'lblBuscar.Visible = True
        'sql = "select grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,grupo.anio,instituto.nombre from grupo,orientacion,turno,instituto where instituto.idinst = grupo.instituto and grupo.orientacion = orientacion.idori and  grupo.anio = " & Now.Year & " and grupo.activo = 'Activo' and grupo.turno=turno.idturno group by  grupo.idgrupo,grupo.grado,grupo.nombre,orientacion.orientacion,turno.turno,grupo.anio,instituto.nombre "
        'Cmd.CommandText = sql
        'Dim da As New Odbc.OdbcDataAdapter(sql, conect)
        'da.Fill(Ds, "grupo")
        'DGVConsulta.DataSource = Ds.Tables("grupo")


        sql = "SELECT actaf.n_actaf,grupo.grado,orientacion.orientacion,grupo.nombre,instituto.nombre from actaf,cursan,grupo,orientacion,t_curso,instituto where  instituto.idinst = grupo.instituto and grupo.t_curso=t_curso.idcurso and actaf.anio = " & Now.Year & " and cursan.n_actaf = actaf.n_actaf and actaf.estado='Cerrada' and grupo.idgrupo = actaf.idgrupo and grupo.orientacion = orientacion.idori group by  actaf.n_actaf,grupo.grado,orientacion.orientacion,grupo.nombre,instituto.nombre"
        Try
            Cmd.CommandText = sql
            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "actaf")

            DGVConsulta.DataSource = Ds.Tables("actaf")

        Catch
            MsgBox(ErrorToString)
        End Try



        conect.Close()
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress

        If e.KeyChar = Chr(13) Then


        End If
    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick
        conn()
        Dim instituto As String

        DGVConsulta.Visible = False
        txtBuscar.Visible = False
        lblRecordar.Visible = False
        lblBuscar.Visible = False


   


        Dim Variable As String = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
        cmbgrupo.Text = Variable
     

    
        conect.Close()
    End Sub

    Private Sub btnimprimirpdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimirpdf.Click
        webbrowser.Print()
    End Sub
End Class