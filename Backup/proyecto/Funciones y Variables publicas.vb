Module Funciones_y_Variables_publicas

    Public conect As New Odbc.OdbcConnection
    Public conect2 As New Odbc.OdbcConnection
    Public Cmd As New Odbc.OdbcCommand
    Public docentev As Integer
    Public dr As Odbc.OdbcDataReader
    Public rolelegido As String
    Public Ds As New DataSet
    Public cedulas As Integer
    Public contador As Integer
    Public autonumerico As Integer
    Public nombre As String
    Public nombre2 As String
    Public nombre3 As String
    Public varnueva As String
    Public varnueva2 As String
    Public grupo As Integer = 0
    Public nomgrupo As String
    Public idgrupo As String
    Public combinado As String
    Public grado As String
    Public orientacion As String
    Public cilogin As String
    Public idinst As Integer
    Public usuario As String
    Public registro As Integer
    Public login As Integer
    Public login2 As Integer
    Public fecha As String
    Public carac As String
    Public fecha2 As String
    Public juan As Integer
    Public msgerror As String
             
    'ci login es la cedula del logueado


    ' Public Da As New Odbc.OdbcDataAdapter(sql, conect)

   


    Public Sub conn()
        Try
            conect.ConnectionString = "FILEDSN=" & Application.StartupPath & "\conexionits.dsn;Uid=sbermudez;Pwd=proyectosopa1"
            Cmd.Connection = conect
            carac = "%d/%m/%Y"
            fecha2 = "to_date('" & Now.Date & "', '" & carac & "') "

            conect.Open()


        Catch
            MsgBox("ERROR 01: Conexion no lograda", MsgBoxStyle.Critical, "Aviso")

            Exit Try

        End Try
    End Sub
    'CREATE TABLE personas(
    'ci integer,
    'nombre1 char(20),
    'nombre2 char(20),
    'apaterno char(20),
    'amaterno char(20),
    'direccion varchar(20),
    'fechanac date,
    '        PRIMARY(KEY(ci))
    ');



    Public ci As Integer = 0
    Public nombre1 As String = ""
    Public apaterno As String = ""
    Public amaterno As String = ""
    Public direccion As String = ""
    Public fechanac As String = ""
    Public tel As String = ""
    Public localidad As Integer = 0



    Public Sub altapersona()

        '  create table personas   (
        '  ci integer not null ,
        '  nombre1 char(20) not null ,
        '  nombre2 char(20),
        '  apaterno char(20) not null ,
        '  amaterno char(20) not null ,
        '  direccion char(20) not null ,
        '  fechanac date,
        '  primary(key(ci))
        ')

        Try
            Cmd.CommandType = CommandType.Text
            Cmd.Connection = conect

            sql = "INSERT INTO personas(ci,nombre1,nombre2,apaterno,amaterno,direccion,fecha,localidad)"

            Cmd.CommandText = sql
            Cmd.ExecuteNonQuery()

            MsgBox("Los datos han sido ingresado correctamente", MsgBoxStyle.Information, "Aviso")

            sql1 = "INSERT INTO telefonop(ci,telefono) "
            sql1 += "VALUES(" & ci & "," & tel & ")"

            Cmd.CommandText = sql1
            Cmd.ExecuteNonQuery()

            MsgBox("Los Datos han sido ingresados", MsgBoxStyle.Information, "Aviso")

        
        Catch ex As Exception
            If ex.ToString.Contains("ERROR [23000]") Then

            Else
                MsgBox(ex.ToString)
            End If


        End Try
        conect.Close()
    End Sub

    Public n_actaf As Integer
    Public n_actae As Integer
    Public idgrupog As Integer
    Public aniog As Integer
    Public idinstg As Integer

    Public Sub genera()

        ' create table genera   (
        '  n_actaf integer not null ,
        '  n_actae integer not null ,
        '  idgrupo integer not null ,
        '  aniog integer not null ,
        '  idinst integer not null 
        ')

        sql8 = "INSERT INTO genera(n_actaf,n_Actae,idgrupo,aniog,idinst)"
        sql8 += "VALUES(" & n_actaf & "," & n_actae & "," & idgrupog & "," & aniog & "," & idinstg & ")"

        Cmd.CommandText = sql8
        Cmd.ExecuteNonQuery()
    End Sub

    Public sql As String = ""
    Public sql1 As String = ""
    Public sql2 As String = ""
    Public sql3 As String = ""
    Public sql4 As String = ""
    Public sql5 As String = ""
    Public sql6 As String = ""
    Public sql7 As String = ""
    Public sql8 As String = ""
    Public sql9 As String = ""
    Public sql10 As String = ""
    Public sql11 As String = ""
    Public sql12 As String = ""
    Public sql13 As String = ""
    Public sql14 As String = ""
    Public sql15 As String = ""

    Public sqlerror As String = ""
    Public sqlhist As String = ""

    Public conterror As Integer ' contador para el id del error
    Public err As Exception ' variable donde se guarda el error
    Public VarRol As String
    Public cedulausu As Integer ' se guarda la cedula cuando se loguea
    Public accion As String

    Public Sub merror()
        conterror = conterror + 1
        sqlerror = "INSERT INTO error(iderror,error)"
        sqlerror += "VALUES(" & conterror & "," & err.ToString & ")"
        Cmd.CommandText = sqlerror
        Cmd.ExecuteNonQuery()
    End Sub

    Public Sub historial()
        Dim diayhora As Date
        sqlhist = "INSERT INTO historia(ci,diayhora,accion)"
        sqlhist += "VALUES(" & cedulausu & "," & diayhora & "," & accion & ")"
        Cmd.CommandText = sqlerror
        Cmd.ExecuteNonQuery()
    End Sub

    Public Sub modpersona()
        If (ci <> 0) Then

            sql = "UPDATE personas SET "
            sql += "nombre1= '" & nombre1 & "', "
            sql += "nombre2= '" & nombre2 & "', "
            sql += "apaterno= '" & apaterno & "', "
            sql += "amaterno= '" & amaterno & "', "
            sql += "direccion= '" & direccion & "', "

            sql += " WHERE ci= " & ci

            Cmd.CommandText = sql

            Cmd.ExecuteNonQuery()
            MsgBox("Los datos han sido modificados", MsgBoxStyle.Information, "Aviso")


        Else
            MsgBox("La cedula ingresada no esta registrada", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Public cedula As Integer = 0

    Public Sub verci()
        sql = "SELECT ci FROM personas WHERE ci=" & ci
        Cmd.CommandText = sql
        cedula = Cmd.ExecuteScalar
    End Sub

    Public Sub cargardatos()
        sql = "SELECT nombre1,nombre2,apaterno,amaterno,direccion "
        sql += "FROM personas "
        sql += "WHERE ci = " & ci

        Cmd.CommandText = sql
        dr = Cmd.ExecuteReader
    End Sub

    Public Sub nomgrup()

        sql = "SELECT nombre FROM grupo"
        Cmd.CommandText = sql
        dr = Cmd.ExecuteReader

    End Sub

    Public Sub nominst()

        sql = "SELECT nombre FROM instituto where activo ='Activo' group by nombre "
        Cmd.CommandText = sql
        dr = Cmd.ExecuteReader

    End Sub
End Module
