Imports MySql.Data.MySqlClient

Public Class ConexionMySql
    Public Function CrearConexion() As MySqlConnection
        Dim conexion As New MySqlConnection("server = buk4gmrrl7up5uap92hr-mysql.services.clever-cloud.com; database = buk4gmrrl7up5uap92hr; user = ugcjc8u2vjjoz3vz; port = 3306; password = oMbTfFPN6xxhXvprHyzw;")
        conexion.Open()
        Return conexion
    End Function
End Class
