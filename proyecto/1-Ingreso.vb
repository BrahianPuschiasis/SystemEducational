Public Class Ingreso
    Public docente As String
    Public administrativo As String
    Public alumno As String
    Public contrasenia As String

    Public contador As Integer
    Public restante As Integer
    Public login As Integer
    Dim alumnos As Integer = 0
    Dim docentes As Integer = 0
    Dim administradores As Integer = 0

    Private Sub btnentrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnentrar.Click

        conn()


       







        CmbRol.Items.Clear()






        sql10 = "SELECT ci from usuario where ci= '" & txtusuario.Text & "'"

        Cmd.CommandText = sql10
        Try
            cilogin = Cmd.ExecuteScalar

        Catch
        End Try


        sql1 = "SELECT ci from dictan where ci= " & cilogin & " and activo='Activo' and anio= " & Now.Year & ""
        Cmd.CommandText = sql1
        Try
            docente = Cmd.ExecuteScalar

        Catch
        End Try


        If cilogin = docente Then
            CmbRol.Items.Add("Docente")
            docentes = 1
        End If

        sql2 = "SELECT ci from administra where ci= " & cilogin & " and activo='Activo' "
        Cmd.CommandText = sql2
        Try
            administrativo = Cmd.ExecuteScalar

        Catch
        End Try
        If cilogin = administrativo Then
            CmbRol.Items.Add("Administrativo")
            administradores = 1
        End If

        sql3 = "SELECT ci from  concurren where ci= " & cilogin & " and activo='Activo' and aniocursado= " & Now.Year & ""
        Cmd.CommandText = sql3
        Try
            alumno = Cmd.ExecuteScalar
        Catch
        End Try
        If cilogin = alumno Then
            CmbRol.Items.Add("Alumno")
            alumnos = 1
        End If








        sql14 = "SELECT contrasenia from usuario where ci= " & cilogin & ""
        Cmd.CommandText = sql14
        Try
            contrasenia = Cmd.ExecuteScalar

        Catch

        End Try


        sql12 = "SELECT ci from usuario where ci= " & txtusuario.Text & ""
        Cmd.CommandText = sql12

        Try
            usuario = Cmd.ExecuteScalar
            If usuario = txtusuario.Text Then
            Else
                MsgBox("ERROR 34:No existe el usuario " & txtusuario.Text & "")
                CmbRol.Enabled = False
            End If

        Catch

            CmbRol.Enabled = False
        End Try
        Dim nombre As String
        Dim apellido As String
        Dim compuesto As String
        Try
            sql = "SELECT nombre1 from personas where ci= " & txtusuario.Text & ""
            Cmd.CommandText = sql
            nombre = Cmd.ExecuteScalar

            sql = "SELECT apaterno from personas where ci= " & txtusuario.Text & ""
            Cmd.CommandText = sql
            apellido = Cmd.ExecuteScalar

            compuesto = nombre + " " + apellido
        Catch
        End Try

        If txtpwd.Text <> "" And txtusuario.Text <> "" Then
            If txtpwd.Text = contrasenia And txtusuario.Text = usuario And login = 0 Then


                txtpwd.Enabled = False
                txtusuario.Enabled = False
                login = 1
                If administradores = 1 Then
                    CmbRol.Text = "Administrador"

                    MsgBox("Bienvenido " & compuesto & ", conectado como: " & CmbRol.Text & " ")

                    MenuPrincipalAdministrativo.Show()
                    rolelegido = "Administrador"
                    login = txtusuario.Text
                    login2 = login
                 
                    conect.Close()
                    Me.Close()

                ElseIf docentes = 1 Then

                    CmbRol.Text = "Docente"

                    MsgBox("Bienvenido " & compuesto & ", conectado como: " & CmbRol.Text & " ")
                    MenuPrincipalDocente.Show()
                    rolelegido = "Docente"
                    login = txtusuario.Text

                    Me.Close()

                ElseIf alumnos = 1 Then
                    CmbRol.Text = "Alumno"

                    MsgBox("Bienvenido " & compuesto & ", conectado como: " & CmbRol.Text & " ")
                    MenuPrincipalAlumno.Show()
                    rolelegido = "Alumno"
                    login = txtusuario.Text
                    conect.Close()
                    Me.Close()

                End If



            Else
                If login = 1 Then

                Else

                    contador = contador + 1

                    restante = 3 - contador
                    MsgBox("ERROR 35:Datos incorrectos, le quedan " & restante & " oportunidades ")
                    CmbRol.Enabled = False
                    If contador = 3 Then
                        Me.Close()

                    End If
                End If
            End If

        Else
            MsgBox("ERROR 36:Faltan ingresar datos")
        End If


        conect.Close()

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Dim Resp As String
        Resp = MsgBox("¿Desea salir?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Advertencia")
        If Resp = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        contador = 0
    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblhora2.Text = TimeOfDay
        lblfecha2.Text = Now.Date
    End Sub

    Private Sub lblcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CambioContraseña.Show()
        Me.Close()

    End Sub

    Private Sub CmbRol_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbRol.Click
  
        
    End Sub

    Private Sub CmbRol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRol.SelectedIndexChanged




      
    End Sub

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtpwd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpwd.Click
        
    End Sub

    Private Sub txtpwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpwd.TextChanged
        
    End Sub
    Private Sub txtusuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


    End Sub
End Class
