Imports System
Imports System.IO
Imports System.IO.StreamWriter
Imports System.Data.Odbc
Imports System.Net
Imports System.Data

Public Class ConsultaActaExamen
    Public grupo2 As Integer
    Public nactae As Integer
    Public idasig As Integer
    Public idinst As Integer
    Public idgrupo As Integer
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

    Private Sub ConsultaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaFinal.Show()
        Me.Close()

    End Sub



    Private Sub ConsultaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaInstituto.Show()
        Me.Close()

    End Sub



    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ConsultaActaExamen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

  

    End Sub




    Private Sub AltaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaActaFinalToolStripMenuItem.Click
        AltaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub BajaActaDeExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaExamen.Show()
        Me.Close()

    End Sub


    Private Sub BajaActaFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BajaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub ModificacoinActaDeExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub ModifToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub AltaActaExamenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaActaExamenToolStripMenuItem.Click
        AltaActaExamen.Show()
        Me.Close()

    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub ActaFinalToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ConsultaActaFinal.Show()
        Me.Close()

    End Sub

    Private Sub CmbConsultaListado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAscendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btndescendente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


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

 


    Private Sub btnlistar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlistar.Click
        conn()

        Dim rep As String
        File.FileName = "ActaExamen.html"
        FileOpen(1, "ActaExamen.html", OpenMode.Output)
        Print(1, "")
        FileClose(1)
        FileOpen(1, "ActaExamen.html", OpenMode.Append)
        rep = "<html  lang='es'>" & _
                "<head>" & _
        "<meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>" & _
"<title>Acta Examen</title>" & _
"<style type='text/css'>" & _
"#apDiv2 {" & _
 "position: absolute;" & _
 "width: 200px;" & _
 "height: 137px;" & _
 "z-index: 2;" & _
 "left: 13px;" & _
 "top: 43px;" & _
"}" & _
"#apDiv1 {" & _
 "position: absolute;" & _
 "width: 385px;" & _
 "height: 27px;" & _
 "z-index: 1;" & _
 "left: 220px;" & _
 "top: 24px;" & _
"}" & _
"#apDiv3 {" & _
 "position: absolute;" & _
 "width: 233px;" & _
 "height: 30px;" & _
 "z-index: 3;" & _
 "left: 616px;" & _
 "top: 23px;" & _
"}" & _
"#apDiv4 {" & _
 "position: absolute;" & _
 "width: 626px;" & _
 "height: 144px;" & _
 "z-index: 4;" & _
 "left: 223px;" & _
 "top: 67px;" & _
"}" & _
"#apDiv5 {" & _
 "position: absolute;" & _
 "width: 200px;" & _
 "height: 115px;" & _
 "z-index: 5;" & _
 "left: 14px;" & _
 "top: 186px;" & _
"}" & _
"#apDiv6 {" & _
 "position: absolute;" & _
 "width: 626px;" & _
 "height: 88px;" & _
 "z-index: 6;" & _
 "left: 223px;" & _
 "top: 213px;" & _
"}" & _
"#apDiv7 {" & _
 "position: absolute;" & _
 "width: 837px;" & _
 "height: 23px;" & _
 "z-index: 7;" & _
 "left: 14px;" & _
 "top: 306px;" & _
"}" & _
"#apDiv8 {" & _
 "position: absolute;" & _
 "width: 837px;" & _
 "height: 99px;" & _
 "z-index: 8;" & _
 "left: 15px;" & _
 "top: 333px;" & _
"}" & _
"#apDiv9 {" & _
 "position: absolute;" & _
 "width: 835px;" & _
 "height: 21px;" & _
 "z-index: 9;" & _
 "left: 17px;" & _
 "top: 432px;" & _
"}" & _
"#apDiv10 {" & _
 "position: absolute;" & _
 "width: 836px;" & _
 "height: 115px;" & _
 "z-index: 10;" & _
 "left: 18px;" & _
 "top: 458px;" & _
"}" & _
"#apDiv11 {" & _
 "position: absolute;" & _
 "width: 836px;" & _
 "height: 115px;" & _
 "z-index: 11;" & _
 "left: 20px;" & _
 "top: 593px;" & _
"}" & _
"#apDiv12 {" & _
 "position: absolute;" & _
 "width: 382px;" & _
 "height: 21px;" & _
 "z-index: 40;" & _
 "left: 1500px;" & _
 "top: 800px;" & _
"}" & _
"#apDiv13 {" & _
 "position: absolute;" & _
 "width: 381px;" & _
 "height: 130px;" & _
 "z-index: 13;" & _
 "left: 1500px;" & _
 "top: 840px;" & _
"}" & _
"#apDiv14 {" & _
 "position: absolute;" & _
 "width: 835px;" & _
 "height: 21px;" & _
 "z-index: 14;" & _
 "left: 22px;" & _
 "top: 940px;" & _
"}" & _
"#apDiv15 {" & _
 "position: absolute;" & _
 "width: 200px;" & _
 "height: 115px;" & _
 "z-index: 15;" & _
 "left: 637px;" & _
 "top: 800px;" & _
"}" & _
"#apDiv16 {" & _
 "position: absolute;" & _
 "width: 200px;" & _
 "height: 110px;" & _
 "z-index: 16;" & _
 "left: 21px;" & _
 "top: 1000px;" & _
"}" & _
"#apDiv17 {" & _
 "position: absolute;" & _
 "width: 206px;" & _
 "height: 105px;" & _
 "z-index: 9;" & _
 "left: 446px;" & _
 "top: 1000px;" & _
"}" & _
"#apDiv18 {" & _
 "position: absolute;" & _
 "width: 206px;" & _
 "height: 105px;" & _
 "z-index: 9;" & _
 "left: 659px;" & _
 "top: 1000px;" & _
"}" & _
"#apDiv19 {" & _
 "position: absolute;" & _
 "width: 206px;" & _
 "height: 107px;" & _
 "z-index: 9;" & _
 "left: 230px;" & _
 "top: 1000px;" & _
"}" & _
"</style>" & _
"</head>" & _
"<body>" & _
"<div id='apDiv2'>" & _
  "<div align='center'><strong>ANEP </strong> </div>" & _
  "<p align='center'>CONSEJO DE EDUCACION  TECNICO PROFESIONAL  (Universidad del trabajo  del Uruguay)</p>" & _
"</div>" & _
"<div id='apDiv1'>" & _
                          "<div align='center'><strong>ACTA DE EXAMEN</strong></div>" & _
                        "</div>"
        'consultas


        sql = "SELECT fecha from actae where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim fechas As String
        fechas = Cmd.ExecuteScalar



        Dim dia As String = fechas
        Dim mes As String = fechas
        Dim años As String = fechas

        dia = fechas(0) + fechas(1)

        mes = fechas(3) + fechas(4)

        años = fechas(6) + fechas(7) + fechas(8) + fechas(9)
      



        sql = "SELECT idgrupo from actae where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        idgrupo = Cmd.ExecuteScalar

        sql = "SELECT instituto from actae  where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        idinst = Cmd.ExecuteScalar

        sql = "SELECT periodo.nombre from periodo,actae where periodo.idperiodo= actae.idperiodo and actae.n_actae= " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        mes = Cmd.ExecuteScalar

        Dim nacta As OdbcDataReader
        nacta = Cmd.ExecuteReader()
        While nacta.Read
            rep = rep & "<div id='apDiv3'>Acta Nº" & cmbgrupo.Text & "</div>"
        End While
        nacta.Close()

        'consultas
        sql = "SELECT asignatura.idasig,asignatura.nombre from asignatura,actae where actae.idasig = asignatura.idasig and actae.n_actae = " & cmbgrupo.Text & " group by asignatura.idasig,asignatura.nombre"
        Cmd.CommandText = sql
        Dim asignatura As OdbcDataReader
        asignatura = Cmd.ExecuteReader()
        While asignatura.Read
            rep = rep & "<div id='apDiv4'>" & _
                          "<table width='624' border='1'>" & _
                            "<tr>" & _
                              "<td width='153'>Asignatura:</td>" & _
                              "<td width='153'>" & asignatura("idasig") & "</td>" & _
                              "<td>" & asignatura("nombre") & "</td>" & _
                            "</tr>"
        End While
        asignatura.Close()

        rep = rep & "</table>" & _
                    "<table width='623' border='1'>"
        'consultas
        sql = "select anio from actae where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim año As OdbcDataReader
        año = Cmd.ExecuteReader()
        While año.Read
            rep = rep & "<tr>" & _
                          "<td>Año:</td>" & _
                          "<td>" & año("anio") & "</td>"
        End While
        año.Close()

        'consultas
        sql = "select fecha from actae where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim fecha As OdbcDataReader
        fecha = Cmd.ExecuteReader()
        While fecha.Read
            rep = rep & "<td>Fecha:</td>" & _
                          "<td>" & fecha("fecha") & "</td>" & _
                        "</tr>"
        End While
        fecha.Close()

        'consultas



        sql = "select t_curso.idcurso,t_curso.completo from t_curso,grupo,orientacion where grupo.idgrupo = " & idgrupo & " and orientacion.idori = grupo.orientacion and orientacion.idcurso = t_curso.idcurso group by t_curso.completo,t_curso.idcurso"
        Cmd.CommandText = sql
        Dim tc As OdbcDataReader
        tc = Cmd.ExecuteReader()
        While tc.Read
            rep = rep & "<tr>" & _
                          "<td>Tipo de Curso:</td>" & _
                          "<td>" & tc("idcurso") & "</td>" & _
                          "<td>" & tc("completo") & "</td>" & _
                        "</tr>"
        End While
        tc.Close()

        'consultas
        sql = "select orientacion.idori,orientacion.completo from orientacion,grupo where grupo.idgrupo = " & idgrupo & " and orientacion.idori = grupo.orientacion group by orientacion.completo,orientacion.idori"
        Cmd.CommandText = sql
        Dim curso As OdbcDataReader
        curso = Cmd.ExecuteReader()
        While curso.Read
            rep = rep & "<tr>" & _
                          "<td>Curso:</td>" & _
                          "<td>" & curso("idori") & "</td>" & _
                          "<td>" & curso("completo") & "</td>" & _
                        "</tr>"
        End While
        curso.Close()

        rep = rep & "</table>" & _
                    "<table width='623' border='1'>"
        'consultas
        sql = "select grupo.grado,orientacion.orientacion,grupo.nombre from grupo,orientacion where grupo.orientacion = orientacion.idori and grupo.idgrupo = " & idgrupo & " order by grupo.grado,grupo.nombre,orientacion.orientacion "
        Cmd.CommandText = sql
        Dim grupo As OdbcDataReader
        grupo = Cmd.ExecuteReader()
        While grupo.Read
            rep = rep & "<tr>" & _
                          "<td>Grupo:</td>" & _
                          "<td>" & grupo("grado") & "" & grupo("orientacion") & "" & grupo("nombre") & "</td>"
        End While
        grupo.Close()

        'consultas
        sql = "select anio from actae where n_actae=" & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim añolec As OdbcDataReader
        añolec = Cmd.ExecuteReader()
        While añolec.Read
            rep = rep & "<td>Año Lectivo:</td>" & _
                        "<td>" & añolec("anio") & "</td>" & _
                        "</tr>"
        End While
        añolec.Close()

        rep = rep & "</table>" & _
                    "</div>" & _
                    "<div id='apDiv5'>" & _
                    "<p>&nbsp;</p>" & _
                    "<p align='center'>Sello</p>" & _
                    "</div>"
        'consultas
        sql = "select instituto.idinst,instituto.nombre from instituto,actae where instituto.idinst= actae.instituto and actae.n_actae = " & cmbgrupo.Text & " "
        Cmd.CommandText = sql
        Dim escuela As OdbcDataReader
        escuela = Cmd.ExecuteReader()
        While escuela.Read
            rep = rep & "<div id='apDiv6'>" & _
            "<table width='626' height='88' border='1'>" & _
            "<tr>" & _
              "<td>Escuela:</td>" & _
              "<td>" & escuela("idinst") & "</td>" & _
              "<td>" & escuela("nombre") & "</td>" & _
            "</tr>"
        End While
        escuela.Close()

        'consultas
        sql = "select locacion.idloc,locacion.locacion from locacion,instituto where instituto.idinst = " & idinst & " and instituto.locacion = locacion.idloc group by locacion.idloc,locacion.locacion"
        Cmd.CommandText = sql
        Dim localidad As OdbcDataReader
        localidad = Cmd.ExecuteReader()
        While localidad.Read
            rep = rep & "<tr>" & _
                        "<td>Localidad:</td>" & _
                        "<td>" & localidad("idloc") & "</td>" & _
                        "<td>" & localidad("locacion") & "</td>" & _
                        "</tr>"
        End While
        localidad.Close()

        'consultas
        sql = "select periodo.sigla,periodo.nombre from periodo,actae where actae.idperiodo=periodo.idperiodo and actae.n_actae= " & cmbgrupo.Text & " order by periodo.sigla,periodo.nombre"
        Cmd.CommandText = sql
        Dim periodo As OdbcDataReader
        periodo = Cmd.ExecuteReader()
        While periodo.Read
            rep = rep & "<tr>" & _
                        "<td>Periodo:</td>" & _
                        "<td>" & periodo("sigla") & "</td>" & _
                        "<td>" & periodo("nombre") & "</td>" & _
                        "</tr>" & _
                        "</table>" & _
                        "</div>"
        End While
        periodo.Close()
        rep = rep & "<div id='apDiv7'>" & _
                        "<div align='center'>Tribunal Examinador:</div>" & _
                        "</div>" & _
                        "<div id='apDiv8'>" & _
                        "<table width='836' height='95' border='1'>"
        'consultas
        sql = "select personas.nombre1,personas.apaterno from actae,personas where actae.n_actae = " & cmbgrupo.Text & " and personas.ci=actae.presidente group by personas.nombre1,personas.apaterno"
        Cmd.CommandText = sql
        Dim presidente As OdbcDataReader
        presidente = Cmd.ExecuteReader()
        While presidente.Read
            rep = rep & "<tr>" & _
                          "<td width='124'>Presidente:</td>" & _
                          "<td width='600'>" & presidente("nombre1") & "  " & presidente("apaterno") & "</td>" & _
                        "</tr>"
        End While
        presidente.Close()
        'consultas
        sql = "select personas.nombre1,personas.apaterno from actae,personas where actae.n_actae = " & cmbgrupo.Text & " and personas.ci=actae.secretario group by personas.nombre1,personas.apaterno"
        Cmd.CommandText = sql
        Dim secretario As OdbcDataReader
        secretario = Cmd.ExecuteReader()
        While secretario.Read
            rep = rep & "<tr>" & _
                          "<td>Secretario:</td>" & _
                          "<td>" & secretario("nombre1") & "   " & secretario("apaterno") & "</td>" & _
                        "</tr>"
        End While
        secretario.Close()
        'consultas
        sql = "select personas.nombre1,personas.apaterno from actae,personas where actae.n_actae = " & cmbgrupo.Text & " and personas.ci=actae.vocal group by personas.nombre1,personas.apaterno"
        Cmd.CommandText = sql
        Dim vocal As OdbcDataReader
        vocal = Cmd.ExecuteReader()
        While vocal.Read
            rep = rep & "<tr>" & _
                          "<td>Vocal:</td>" & _
                          "<td>" & vocal("nombre1") & " " & vocal("apaterno") & "</td>" & _
                        "</tr>" & _
                        "</table>" & _
                        "</div>"
        End While
        vocal.Close()

        rep = rep & "<div id='apDiv9'>" & _
                        "<div align='center'>Examen Reglamentado</div>" & _
                        "</div>" & _
                        "<div id='apDiv10'>" & _
                        "<table width='836' height='119' border='1'>" & _
                        "<tr>" & _
                          "<td colspan='2' rowspan='2' bgcolor='#FFFFFF'><div align='center'>Pruebas</div></td>" & _
                          "<td width='114' rowspan='2' bgcolor='#FFFFFF'><div align='center'>Dia</div></td>" & _
                          "<td width='114' rowspan='2' bgcolor='#FFFFFF'><div align='center'>Mes</div></td>" & _
                          "<td width='114' rowspan='2' bgcolor='#FFFFFF'><div align='center'>Año</div></td>" & _
                          "<td colspan='2' bgcolor='#FFFFFF'><div align='center'>Horario</div></td>" & _
                        "</tr>" & _
                        "<tr>" & _
                          "<td width='114' bgcolor='#FFFFFF'><div align='center'>Comenzo</div></td>" & _
                          "<td width='116' bgcolor='#FFFFFF'><div align='center'>Finalizo</div></td>" & _
                        "</tr>"

        'consultas
        sql = "select nombre1 from personas where ci=53462599"
        Cmd.CommandText = sql
        Dim diaescrito As OdbcDataReader
        diaescrito = Cmd.ExecuteReader()
        While diaescrito.Read
            rep = rep & "<tr>" & _
                          "<td width='114' bgcolor='#FFFFFF'>1º</td>" & _
                          "<td width='114' bgcolor='#FFFFFF'>Escrito</td>" & _
                          "<td bgcolor='#FFFFFF'></td>"
        End While
        diaescrito.Close()

        'consultas
        sql = "select fecha from actae where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim mesescrito As OdbcDataReader
        mesescrito = Cmd.ExecuteReader()
        While mesescrito.Read
            rep = rep & "<td bgcolor='#FFFFFF'>1º</td>"
        End While
        mesescrito.Close()
        'consultas
        sql = "select nombre1 from personas where ci=53462599"
        Cmd.CommandText = sql
        Dim añoescrito As OdbcDataReader
        añoescrito = Cmd.ExecuteReader()
        While añoescrito.Read
            rep = rep & "<td bgcolor='#FFFFFF'></td>"
        End While
        añoescrito.Close()

        'consultas
        sql = "select inicioe from actae  where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim horariocomienzoescrito As OdbcDataReader
        horariocomienzoescrito = Cmd.ExecuteReader()
        While horariocomienzoescrito.Read
            rep = rep & "<td bgcolor='#FFFFFF'>Escrito</td>"
        End While
        horariocomienzoescrito.Close()

        'consultas
        sql = "select inicioe,fine from actae  where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim horariofinalizoescrito As OdbcDataReader
        horariofinalizoescrito = Cmd.ExecuteReader()
        While horariofinalizoescrito.Read
            rep = rep & "<td bgcolor='#FFFFFF'>" & dia & "</td>" & _
                        "<td bgcolor='#FFFFFF'>" & mes & "</td>" & _
                         "<td bgcolor='#FFFFFF'>" & años & "</td>" & _
                         "<td bgcolor='#FFFFFF'>" & horariofinalizoescrito("inicioe") & "</td>" & _
                         "<td bgcolor='#FFFFFF'>" & horariofinalizoescrito("fine") & "</td>" & _
                        "</tr>"
        End While
        horariofinalizoescrito.Close()

        'consultas
        sql = "select inicioo from actae where n_actae = " & nactae & ""
        Cmd.CommandText = sql
        Dim diaoral As OdbcDataReader
        diaoral = Cmd.ExecuteReader()
        While diaoral.Read
            rep = rep & "<tr>" & _
                          "<td bgcolor='#FFFFFF'>2º</td>" & _
                          "<td bgcolor='#FFFFFF'>Oral</td>" & _
                          "<td bgcolor='#FFFFFF'></td>"
        End While
        diaoral.Close()
        'consultas
        sql = "select inicioo from actae where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim mesoral As OdbcDataReader
        mesoral = Cmd.ExecuteReader()
        While mesoral.Read
            rep = rep & "<td bgcolor='#FFFFFF'>2º</td>"
        End While
        mesoral.Close()

        'consultas
        sql = "select nombre1 from personas where ci=53462599"
        Cmd.CommandText = sql
        Dim añooral As OdbcDataReader
        añooral = Cmd.ExecuteReader()
        While añooral.Read
            rep = rep & "<td bgcolor='#FFFFFF'>2º</td>"
        End While
        añooral.Close()

        'consultas
        sql = "select fino from actae where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim oralhorariocom As OdbcDataReader
        oralhorariocom = Cmd.ExecuteReader()
        While oralhorariocom.Read
            rep = rep & "<td bgcolor='#FFFFFF'>Oral</td>"
        End While
        oralhorariocom.Close()

        'consultas
        sql = "select inicioo,fino from actae where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim oralhorariofin As OdbcDataReader
        oralhorariofin = Cmd.ExecuteReader()
        While oralhorariofin.Read
            rep = rep & "<td bgcolor='#FFFFFF'>" & dia & "</td>" & _
                              "<td bgcolor='#FFFFFF'>" & mes & "</td>" & _
                         "<td bgcolor='#FFFFFF'>" & años & "</td>" & _
                         "<td bgcolor='#FFFFFF'>" & oralhorariofin("inicioo") & "</td>" & _
                         "<td bgcolor='#FFFFFF'>" & oralhorariofin("fino") & "</td>" & _
                        "</tr>"
        End While
        oralhorariofin.Close()

        rep = rep & "<tr>" & _
                      "<td colspan='7' bgcolor='#FFFFFF'>Obrvaciones:</td>" & _
                    "</tr>" & _
                    "</table>" & _
                    "</div>" & _
                    "<div id='apDiv11'>" & _
                    "<table width='835' height='121' border='1'>" & _
                    "<tr>" & _
                      "<td width='39' rowspan='2'><div align='center'>Nº</div></td>" & _
                      "<td width='238' rowspan='2'><div align='center'>Apellidos y Nombres del Examinado</div></td>" & _
                      "<td width='68' rowspan='2'><p align='center'>Cedula de</p>" & _
                      "<p align='center'>Identidad</p></td>" & _
                      "<td colspan='4'><div align='center'>Calificacion</div></td>" & _
                    "</tr>" & _
                    "<tr>" & _
                      "<td width='115'><div align='center'>Clase</div></td>" & _
                      "<td width='115'><div align='center'>Exa.<br />" & _
                      "Esc.</div></td>" & _
                      "<td width='115'><div align='center'>Exa.<br />" & _
                      "Oral</div></td>" & _
                      "<td width='115'><div align='center'>Fallo y Nota Final</div></td>" & _
                    "</tr>"
        'consultas (num examinado) (nombre y apellido examinado) (ci examinado) en ese orden
        sql = "select personas.nombre1,personas.apaterno,examinado.ci,examinado.notafinal,examinado.escrita,examinado.oral,examinado.fallo,examinado.nota from actae,examinado,personas where personas.ci= examinado.ci and actae.n_actae = " & cmbgrupo.Text & " and examinado.n_actae = actae.n_actae group by personas.nombre1,personas.apaterno,examinado.ci,examinado.notafinal,examinado.escrita,examinado.oral,examinado.fallo,examinado.nota order by examinado.ci"
        Cmd.CommandText = sql
        Dim examinado As OdbcDataReader
        examinado = Cmd.ExecuteReader()
        Dim contador As Integer = 0
        While examinado.Read

            contador = contador + 1
            rep = rep & "<tr>" & _
                        "<td>" & contador & "</td>" & _
                        "<td>" & examinado("nombre1") & " " & examinado("apaterno") & " </td>" & _
                        "<td>" & examinado("ci") & _
                        "<td>" & examinado("notafinal") & " </td>" & _
                        "<td>" & examinado("escrita") & _
                        "<td>" & examinado("oral") & _
                        "<td>" & examinado("fallo") & " " & examinado("nota") & "</td>"

        End While
        examinado.Close()



        'consultas
        sql = "select nombre1 from personas where ci=53462599"
        Cmd.CommandText = sql
        Dim ExamenEsc As OdbcDataReader
        ExamenEsc = Cmd.ExecuteReader()
        While ExamenEsc.Read
            rep = rep & "<td>oral</td>"
        End While
        ExamenEsc.Close()

        'consultas
        sql = "select nombre1 from personas where ci=53462599"
        Cmd.CommandText = sql
        Dim ExamenOral As OdbcDataReader
        ExamenOral = Cmd.ExecuteReader()
        While ExamenOral.Read
            rep = rep & "<td>escrito</td>"
        End While
        ExamenOral.Close()

        'consultas
        sql = "select nombre1 from personas where ci=53462599"
        Cmd.CommandText = sql
        Dim FalloNotaFinal As OdbcDataReader
        FalloNotaFinal = Cmd.ExecuteReader()
        While FalloNotaFinal.Read
            rep = rep & "<td>" & FalloNotaFinal("nombre1") & "</td>" & _
                        "</tr>" & _
                         "</table>" & _
                         "</div>"
        End While
        FalloNotaFinal.Close()

        rep = rep & "<div id='apDiv12'>" & _
                    "<div align='center'>ESTADISTICAS</div>" & _
                    "</div>"
        'consultas
        sql = "select ci from examinado where n_actae = " & cmbgrupo.Text & "  and oral = '-'"
        Cmd.CommandText = sql
        Dim Eliminados As OdbcDataReader

        Eliminados = Cmd.ExecuteReader()

        Dim eliminado As Integer = 0
        While Eliminados.Read
            eliminado = eliminado + 1
      
        End While
        rep = rep & "<div id='apDiv13'>" & _
                      "<table width='381' border='1'>" & _
                      "<tr>" & _
                        "<td width='120'>Eliminados:</td>" & _
                        "<td width='245'>" & eliminado & "</td>" & _
                      "</tr>"
        Eliminados.Close()

        'consultas
        Dim siete As Integer = 7
        sql = "select ci from examinado where n_actae = " & cmbgrupo.Text & " and fallo <> 'Aprobado' "
        Cmd.CommandText = sql
        Dim NoAprobados As OdbcDataReader
        NoAprobados = Cmd.ExecuteReader()
        Dim nop As Integer = 0
        While NoAprobados.Read
            nop = nop + 1
          
        End While
        rep = rep & "<tr>" & _
                        "<td>No Aprobados:</td>" & _
                        "<td>" & nop & "</td>" & _
                      "</tr>"
        NoAprobados.Close()

        'consultas
        sql = "select ci from examinado where n_actae = " & cmbgrupo.Text & " and fallo='Aprobado' "
        Cmd.CommandText = sql
        Dim Aprobados As OdbcDataReader
        Aprobados = Cmd.ExecuteReader()
        Dim aprobado As Integer = 0
        While Aprobados.Read
            aprobado = aprobado + 1
     
        End While
        rep = rep & "<tr>" & _
                   "<td>Aprobados:</td>" & _
                   "<td>" & aprobado & "</td>" & _
                 "</tr>"
        Aprobados.Close()

        'consultas
        sql = "select ci from examinado where n_actae = " & cmbgrupo.Text & " and escrita= '-' "
        Cmd.CommandText = sql
        Dim NoSePresentaron As OdbcDataReader
        NoSePresentaron = Cmd.ExecuteReader()
        Dim nopre As Integer = 0
        While NoSePresentaron.Read
            nopre = nopre + 1
  
        End While
        rep = rep & "<tr>" & _
                "<td>No se Presentaron:</td>" & _
                "<td>" & nopre & "</td>" & _
              "</tr>"
        NoSePresentaron.Close()

        'consultas
        sql = "select ci from examinado where n_actae = " & cmbgrupo.Text & ""
        Cmd.CommandText = sql
        Dim Total As OdbcDataReader
        Total = Cmd.ExecuteReader()
        Dim total2 As Integer = 0
        While Total.Read
            total2 = total2 + 1
       
        End While
        rep = rep & "<tr>" & _
                     "<td height='23'>Total:</td>" & _
                     "<td>" & total2 & "</td>" & _
                   "</tr>"
        Total.Close()

        rep = rep & "</table>" & _
                    "</div>" & _
                    "<div id='apDiv14'>" & _
                    "<div align='center'>Fin</div>" & _
                    "</div>" & _
                    "<div id='apDiv15'>" & _
                    "<p align='center'>________________________</p>" & _
                    "<p align='center'>Ing. el Acta</p>" & _
                    "</div>" & _
                    "<div id='apDiv16'>" & _
                    "<p>Verifico: _________________</p>" & _
                    "<p>&nbsp;</p>" & _
                    "</div>" & _
                    "<div id='apDiv17'>" & _
                    "<p>Secretario:  _________________</p>" & _
                    "<p>&nbsp;</p>" & _
                    "</div>" & _
                    "<div id='apDiv18'>" & _
                    "<p>Vocal:  _________________</p>" & _
                    "<p>&nbsp;</p>" & _
                    "</div>" & _
                    "<div id='apDiv19'>" & _
                    "<p>Presidente:  _________________</p>" & _
                    "<p>&nbsp;</p>" & _
                    "</div>"

        rep = rep & "</body>" & _
                   "</html>"
        Print(1, rep)
        FileClose()
        conect.Close()
        webbrowser.Visible = True
        webbrowser.Navigate("File:" & Application.StartupPath & "\ActaExamen.html")

    End Sub

    Private Sub btnimprimirpdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimirpdf.Click
        webbrowser.Print()
    End Sub

  
    Private Sub btnGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrupo.Click
        conn()
        DGVConsulta.Visible = True
        Ds.Clear()
        sql = "SELECT actae.n_actae,grupo.idgrupo,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,periodo.nombre,instituto.nombre from instituto,periodo,actae,grupo,actaf,asignatura,orientacion where grupo.orientacion = orientacion.idori and grupo.idgrupo = actae.idgrupo and asignatura.idasig = actae.idasig and actae.estado='Cerrada' and instituto.idinst= actae.instituto and periodo.idperiodo = actae.idperiodo and actae.n_actaf = actaf.n_actaf and actae.estado='Cerrada' group by actae.n_actae,grupo.idgrupo,grupo.grado,orientacion.orientacion,grupo.nombre,asignatura.nombre,periodo.nombre,instituto.nombre"
        Try
            Cmd.CommandText = sql
            Dim da As New Odbc.OdbcDataAdapter(sql, conect)
            da.Fill(Ds, "actae")

            DGVConsulta.DataSource = Ds.Tables("actae")

        Catch
            MsgBox(ErrorToString)
        End Try
        conect.Close()

    End Sub

    Private Sub DGVConsulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVConsulta.CellContentClick
        cmbgrupo.Text = DGVConsulta.Item(0, DGVConsulta.CurrentRow.Index).Value
        DGVConsulta.Visible = False

    End Sub
End Class