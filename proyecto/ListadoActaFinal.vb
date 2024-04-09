Public Class ListadoActaFinal

    Private Sub ListadoActaFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rep As String
        'Dim sql As String
        'Dim File As System.Windows.Forms.SaveFileDialog

        'Dim selecc As Integer = txtSeleccion.Text
        File.FileName = "ActaFinal.html"
        FileOpen(1, "ActaFinal.html", OpenMode.Output)
        Print(1, "")
        FileClose(1)
        FileOpen(1, "ActaFinal.html", OpenMode.Append)
        rep = "<html  lang='es'>" & _
                  "<head>" & _
                      "<meta http-equiv='Content-Type' content='text/html; charset=utf-8'/>" & _
                      "<title>Documento sin título</title>" & _
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
 "width: 736px;" & _
 "height: 115px;" & _
 "z-index: 3;" & _
 "left: 217px;" & _
 "top: 68px;" & _
"}" & _
"#apDiv4 {" & _
 "position: absolute;" & _
 "width: 940px;" & _
 "height: 103px;" & _
 "z-index: 4;" & _
 "left: 15px;" & _
 "top: 205px;" & _
"}" & _
"#apDiv5 {" & _
 "position: absolute;" & _
 "width: 940px;" & _
 "height: 27px;" & _
 "z-index: 5;" & _
 "left: 16px;" & _
 "top: 312px;" & _
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
 "height: 68px;" & _
 "z-index: 7;" & _
 "left: 11px;" & _
 "top: 358px;" & _
"}" & _
"#apDiv8 {" & _
 "position: absolute;" & _
 "width: 940px;" & _
 "height: 5px;" & _
 "z-index: 8;" & _
 "left: 15px;" & _
 "top: 425px;" & _
"}" & _
"#apDiv9 {	position: absolute;" & _
 "width: 714px;" & _
 "height: 6px;" & _
 "z-index: 6;" & _
 "left: 16px;" & _
 "top: 343px;" & _
"}" & _
"#apDiv10 {position: absolute;" & _
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
 "left: 229px;" & _
 "top: 978px;" & _
"}" & _
"#apDiv13 {" & _
 "position: absolute;" & _
 "width: 201px;" & _
 "height: 500px;" & _
 "z-index: 9;" & _
 "left: 17px;" & _
 "top: 474px;" & _
"}" & _
"#apDiv14 {" & _
 "position: absolute;" & _
 "width: 200px;" & _
 "height: 500px;" & _
 "z-index: 10;" & _
 "left: 224px;" & _
 "top: 473px;" & _
"}" & _
"#apDiv15 {" & _
 "position: absolute;" & _
 "width: 531px;" & _
 "height: 540px;" & _
 "z-index: 11;" & _
 "left: 424px;" & _
 "top: 432px;" & _
"}" & _
"#apDiv16 {" & _
 "position: absolute;" & _
 "width: 201px;" & _
 "height: 73px;" & _
 "z-index: 1;" & _
 "left: 6px;" & _
 "top: 504px;" & _
"}" & _
"#apDiv17 {	position: absolute;" & _
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
 "left: 440px;" & _
 "top: 977px;" & _
"}" & _
"#apDiv19 {" & _
 "position: absolute;" & _
 "width: 315px;" & _
 "height: 98px;" & _
 "z-index: 13;" & _
 "left: 642px;" & _
 "top: 978px;" & _
"}" & _
"</style>" & _
                  "</head>" & _
                  "<body>" & _
                      "<div id='apDiv1'><u><strong>Acta de la Reunion Final de Profesores</strong></u></div>" & _
                      "<div id='apDiv2'>" & _
                          "<div align='center'><strong>ANEP  </strong>" & _
                          "</div>" & _
                          "<p align='center'>CONSEJO DE EDUCACION  TECNICO PROFESIONAL  (Universidad del trabajo  del Uruguay)</p>" & _
                      "</div>" & _
                      "<div id='apDiv3'>" & _
                          "<p>Escuela $nombreescuela Año $numaño Semestre $numsemestre Grupo $NombreGrupo Tipo de curso $tipodecurso Curso $Curso.</p>" & _
                          "<p>En $locacion siendo la hora $horaaltaacta el dia $fechaaltaacta bajo la presidencia del Prof. $nombreprof y con las asistencias de los Sres	Profesores</p>" & _
                      "</div>" & _
                      "<div id='apDiv4'>$nombre de todos los profesores presentes de la reunion</div>" & _
                      "<div id='apDiv5'>" & _
                          "<div align='center'>Se consideran las actuaciones de los siguientes alumnos:</div>" & _
                      "</div>" & _
                      "<!--ANEP" & _
"CONSEJO DE EDUCACION" & _
        "TECNICO(PROFESIONAL)" & _
"(Universidad del trabajo" & _
"del Uruguay) -->" & _
                     "<div id='apDiv6'><img src='../Desktop/proyecto/imgdw/lineaseparadora.png' alt='' width='800' height='5'/></div>" & _
                      "<div id='apDiv7'>1 $NumMateria $NombreMateria 2 $NumMateria $NombreMateria 3 $NumMateria</div>" & _
                      "<div id='apDiv8'><img src='../Desktop/proyecto/imgdw/lineaseparadora.png' alt='' width='800' height='5'/></div>" & _
                      "<div id='apDiv9'><img src='../Desktop/proyecto/imgdw/lineaseparadora.png' alt='' width='800' height='5'/></div>" & _
                      "<div id='apDiv10'><img src='../Desktop/proyecto/imgdw/lineaseparadora.png' alt='' width='800' height='5'/></div>" & _
                      "<div id='apDiv11'><img src='../Desktop/proyecto/imgdw/lineaseparadora.png' alt="" width='800' height='5'/></div>" & _
                      "<div id='apDiv13'>" & _
                          "<table width='200' border='1'>" & _
                              "<caption>" & _
      "APELLIDOS Y NOMBRES" & _
    "</caption>" & _
                              "<tr>" & _
                                  "<td height='33'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='33'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='29'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='35'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='33'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='31'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='32'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='38'>&nbsp;</td>" & _
                              "</tr>" & _
                          "</table>" & _
                          "<div id='apDiv16'>" & _
                              "<p>Verifico: _________________</p>" & _
                              "<p>&nbsp;</p>" & _
                          "</div>" & _
                      "</div>" & _
                      "<div id='apDiv14'>" & _
                          "<table width='200' border='1'>" & _
                              "<caption>" & _
      "PROCEDENCIA Y PREVIAS" & _
    "</caption>" & _
                              "<tr>" & _
                                  "<td height='34'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='32'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='31'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='34'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='32'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='31'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='32'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td height='39'>&nbsp;</td>" & _
                              "</tr>" & _
                          "</table>" & _
                      "</div>" & _
                      "<div id='apDiv15'>" & _
                          "<table width='393' height='344' border='1'>" & _
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
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                                  "<td>R</td>" & _
                                  "<td>C</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                              "</tr>" & _
                              "<tr>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                                  "<td colspan='2'>&nbsp;</td>" & _
                              "</tr>" & _
                          "</table>" & _
                      "</div>" & _
                      "<div id='apDiv12'>" & _
                          "<p>Secretario:  _________________</p>" & _
                          "<p>&nbsp;</p>" & _
                      "</div>" & _
                      "<div id='apDiv18'>" & _
                          "<p align='center'>Sello</p>" & _
                          "<p>&nbsp;</p>" & _
                      "</div>" & _
                      "<div id='apDiv19'>" & _
                          "<p align='center'>Director:  _________________</p>" & _
                      "</div>" & _
                  "</body>" & _
              "</html>"
        Print(1, rep)
        FileClose()
        Web.Navigate("FILE:" & Application.StartupPath & "\ActaFinal.html")
    End Sub

    Private Sub Web_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles Web.DocumentCompleted

    End Sub
End Class