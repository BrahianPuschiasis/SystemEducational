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
    Dim nomgrupo As String
    Dim idgrupo As String
    Dim combinado As String
    Dim grado As String
    Dim grupo5 As String


    Private Sub Boletin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        conn()

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


        conect.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

    Private Sub logo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logo.Click
        MenuPrincipalAlumno.Show()
        Me.Close()

    End Sub

    Private Sub btnBoletin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBoletin.Click
        cedulas = cilogin

        conn()


        'Dim sql As String


        'Dim selecc As Integer = txtSeleccion.Text

        File.FileName = "BoletinCalificaciones.html"
        FileOpen(1, "BoletinCalificaciones.html", OpenMode.Output)
        Print(1, "")
        FileClose(1)
        FileOpen(1, "BoletinCalificaciones.html", OpenMode.Append)
        rep = "<html  lang='es'>" & _
                "<head>" & _
                  "<meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>" & _
                  "<title>Boletin Calificaciones</title>" & _
                  "<style type='text/css'>" & _
    "#apDiv1 {" & _
    "position: absolute;" & _
    "width: 342px;" & _
    "height: 20px;" & _
    "z-index: 1;" & _
    "left: 209px;" & _
    "top: 38px;" & _
    "}" & _
    "#apDiv2 {" & _
    "position: absolute;" & _
    "width: 900px;" & _
    "height: 130px;" & _
    "z-index: 2;" & _
    "left: 9px;" & _
    "top: 145px;" & _
    "}" & _
    "#apDiv3 {" & _
    "position: absolute;" & _
    "width: 900px;" & _
    "height: 20px;" & _
    "z-index: 3;" & _
    "left: 7px;" & _
    "top: 322px;" & _
    "}" & _
    "#apDiv4 {" & _
    "position: absolute;" & _
    "width: 900px;" & _
    "height: 306px;" & _
    "z-index: 4;" & _
    "left: 8px;" & _
    "top: 342px;" & _
    "}" & _
    "#apDiv5 { " & _
    "position: absolute;" & _
    "width: 900px;" & _
    "height: 66px;" & _
    "z-index: 5;" & _
    "left: 8px;" & _
    "top: 654px;" & _
    "}" & _
    "#apDiv6 {" & _
    "position: absolute;" & _
    "width: 450px;" & _
    "height: 79px;" & _
    "z-index: 6;" & _
    "left: 11;" & _
    "top: 745px;" & _
    "}" & _
    "#apDiv7 {" & _
    "position: absolute;" & _
    "width: 450px;" & _
    "height: 80px;" & _
    "z-index: 5;" & _
    "left: 461px;" & _
    "top: 745px;" & _
    "}" & _
    "#apDiv8 {" & _
    "position: absolute;" & _
    "width: 200px;" & _
    "height: 137px;" & _
    "z-index: 2;" & _
    "left: 8px;" & _
    "top: 8px;" & _
    "}" & _
    "</style>" & _
    "</head>" & _
    "<body>" & _
    "<div id='apDiv1'>" & _
    "<div align='center'>BOLETIN DE CALIFICACIONES</div>" & _
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

            rep = rep & "<div id='apDiv2'>" & _
                  " <table width='900' height='120' border='1'>" & _
                    "<tr>" & _
                      "<td width='95' height='30'>Nombre:</td>" & _
                      "<td height='30' colspan='2'>" & completo & "  </td>" & _
                      "<td width='92' height='30'>Nº Lista:</td>" & _
                      "<td width='97' height='30'>" & contador & " </td>" & _
                      "<td width='167' height='30'>Anio Lectivo:</td>" & _
                      "<td width='96' height='30'>" & datosalumno("aniocursado") & "</td>" & _
                    "</tr>"
        End While
        datosalumno.Close()

        'consultas
        sql = "select instituto.idinst, instituto.nombre from grupo,concurren,instituto where concurren.ci = " & cedulas & " and instituto.idinst = grupo.instituto and grupo.idgrupo= " & idgrupo & " group by instituto.idinst,instituto.nombre"
        Cmd.CommandText = sql
        Dim escuela As OdbcDataReader
        escuela = Cmd.ExecuteReader()
        While escuela.Read
            rep = rep & "<tr>" & _
                      "<td width='95' height='30'>Escuela:</td>" & _
                      "<td width='112' height='30'>" & escuela("idinst") & "</td>" & _
                      " <td height='30' colspan='2'>" & escuela("nombre") & "</td>"
        End While
        escuela.Close()

        'consultas
        sql = "select ci from concurren where ci= " & cedulas & " group by ci"
        Cmd.CommandText = sql
        Dim numdoc As OdbcDataReader
        numdoc = Cmd.ExecuteReader()
        While numdoc.Read
            rep = rep & "<td width='97' height='30'>Doc:</td>" & _
                          "<td width='167' height='30'>" & numdoc("ci") & "</td>" & _
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
            rep = rep & "<tr>" & _
                          "<td width='95' height='30'>Grupo:</td>" & _
                          "<td height='30' colspan='2'>" & grupo2 & "</td>"

        End While
        grupo.Close()

        'consultas
        rep = rep & "<td width='92' height='30'>Anio:</td>" & _
                      " <td height='30'>" & grado & "</td>" & _
                    "</tr>"

        'consultas
        sql = "select t_curso.idcurso,t_curso.completo from t_curso,grupo,concurren where grupo.idgrupo = " & idgrupo & " and t_curso.idcurso = grupo.t_curso group by t_curso.idcurso, t_curso.completo,grupo.idgrupo"
        Cmd.CommandText = sql
        Dim tipocurso As OdbcDataReader
        tipocurso = Cmd.ExecuteReader()
        While tipocurso.Read
            rep = rep & "<tr>" & _
                          " <td width='95' height='30'>Tipo de Curso:</td>" & _
                          "<td height='30'>" & tipocurso("idcurso") & "</td>" & _
                          "<td width='195' height='30'>" & tipocurso("completo") & "</td>"
        End While
        tipocurso.Close()

        'consultas
        sql = "select idori,completo from orientacion,grupo where grupo.idgrupo = " & grupo5 & " and orientacion.idori = grupo.orientacion group by idori,completo"
        Cmd.CommandText = sql

        Dim curso As OdbcDataReader
        curso = Cmd.ExecuteReader()
        While curso.Read
            rep = rep & "<td height='30'>Curso:</td>" & _
                          "<td height='30'>" & curso("idori") & "</td>" & _
                          "<td height='30' colspan='2'>" & curso("completo") & "</td>" & _
                        "</tr>" & _
                      "</table>" & _
                    "</div>"
        End While
        curso.Close()


        rep = rep & "<div id='apDiv3'>" & _
                        "<div align='center'>Reunion final</div>" & _
                    "</div>" & _
    "<div id='apDiv4'>" & _
    "<table width='900' border='1'>" & _
    "<tr>" & _
      "<td width='162' height='20'><div align='center'>Asignatura</div></td>" & _
      "<td width='162' height='20'><div align='center'>Inasistencias</div></td>" & _
      "<td width='163' height='20'><div align='center'>Rendimiento</div></td>" & _
      "<td width='163' height='20'><div align='center'>Calidad</div></td>" & _
    "</tr>"
        'consultas
        sql = "select cursan.nota,cursan.inasistencias,asignatura.nombre,cursan.fallo from cursan,grupo,asignatura where cursan.ci=" & cilogin & " and cursan.idasig = asignatura.idasig group by cursan.nota,cursan.inasistencias,asignatura.nombre,cursan.fallo"
        Cmd.CommandText = sql
        Dim notas As OdbcDataReader
        notas = Cmd.ExecuteReader()
        While notas.Read
            rep = rep & "<tr>" & _
                          "<td width='162' height='20'>" & notas("nombre") & "</td>" & _
                          "<td width='162' height='20'>" & notas("inasistencias") & "</td>" & _
                          "<td width='163' height='20'>" & notas("nota") & "</td>" & _
                          "<td width='163' height='20'></td>" & _
                        "</tr>"
        End While
        notas.Close()
        rep = rep & "</table>" & _
                    "</div>"
        'consultas
        sql = "select nombre1 from personas where ci= " & cilogin & ""
        Cmd.CommandText = sql
        Dim falloglobal As OdbcDataReader
        falloglobal = Cmd.ExecuteReader()
        While falloglobal.Read
            rep = rep & "<div id='apDiv5'>" & _
                      "<table width='900' height='64' border='1'>" & _
                        "<tr>" & _
                          "<td width='98' height='30'>Fallo Global:</td>" & _
                          "<td width='97' height='30'></td>"
        End While
        falloglobal.Close()

        'consultas
        sql = "select nombre1 from personas where ci= " & cilogin & ""
        Cmd.CommandText = sql
        Dim calglobal As OdbcDataReader
        calglobal = Cmd.ExecuteReader()
        While calglobal.Read
            rep = rep & "<td width='128' height='30'>Calificacion Global:</td>" & _
                          "<td width='109' height='30'></td>"
        End While
        calglobal.Close()

        'consultas
        sql = "select nombre1 from personas where ci= " & cilogin & ""
        Cmd.CommandText = sql
        Dim conducta As OdbcDataReader
        conducta = Cmd.ExecuteReader()
        While conducta.Read
            rep = rep & " <td width='109' height='30'>Conducta:</td>" & _
                          "<td width='109' height='30'></td>" & _
                        "</tr>"
        End While
        conducta.Close()

        'consultas
        sql = "select nombre1 from personas where ci= " & cilogin & ""
        Cmd.CommandText = sql
        Dim juicioglobal As OdbcDataReader
        juicioglobal = Cmd.ExecuteReader()
        While juicioglobal.Read
            rep = rep & "<tr>" & _
                          "<td height='30'>Juicio Global:</td>" & _
                          "<td height='30'></td>" & _
                        "</tr>" & _
                        "</table>" & _
                    "</div>"
        End While
        juicioglobal.Close()


        rep = rep & "<div id='apDiv6'>" & _
                      "<p>Por el instituto: _____________________</p>" & _
                    "</div>" & _
                    "<div id='apDiv7'>" & _
                      "<p align='center'>	Sello</p>" & _
                    "</div>" & _
                    "<div id='apDiv8'>" & _
                      "<div align='center'><strong>ANEP </strong></div>" & _
                      "<p align='center'>CONSEJO DE EDUCACION  TECNICO PROFESIONAL  (Universidad del trabajo  del Uruguay)</p>" & _
                    "</div>"

        rep = rep & "</body>" & _
                    "</html>"
        Print(1, rep)

        FileClose()

        conect.Close()
    
        WebBrowser.Visible = True
        WebBrowser.Navigate("File:" & Application.StartupPath & "\BoletinCalificaciones.html")

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
End Class
