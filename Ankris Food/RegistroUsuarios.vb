Imports System.Data.Common
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class RegistroUsuarios
    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim conectar As New ConexionMySql
        Dim conexion As MySqlConnection = conectar.CrearConexion()
        Dim sqlQuery As String
        Dim sqlCommand As MySqlCommand
        Dim dataAdapter As MySqlDataAdapter
        Dim dataSet As DataSet
        Dim idEmpleado As String
        Dim usuario As String
        Dim contrasenia As String
        Dim resultado As String

        If (String.IsNullOrEmpty(IdEmpleadoText.Text) Or String.IsNullOrEmpty(IdEmpleadoText.Text) Or String.IsNullOrEmpty(IdEmpleadoText.Text)) Then
            MsgBox("Tienes que rellenar todos los campos")
        Else
            Try
                If (conexion.State = ConnectionState.Closed) Then
                    conexion.Open()
                End If
                idEmpleado = IdEmpleadoText.Text
                usuario = UsuarioText.Text
                contrasenia = ContraseniaText.Text
                sqlQuery = "SELECT Empleado_Id FROM Empleados WHERE Numero_Id = " & idEmpleado & ""
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                dataAdapter = New MySqlDataAdapter(sqlCommand)
                dataSet = New DataSet()
                dataAdapter.Fill(dataSet, "Empleados")
                If (dataSet.Tables("Empleados").Rows.Count > 0) Then
                    idEmpleado = dataSet.Tables("Empleados").Rows(0).Item(0)
                    resultado = Me.IngresarUsuario(idEmpleado, usuario, contrasenia)
                    conexion.Close()
                    MsgBox(resultado)
                Else
                    MsgBox("No se encontro el empleado. Intente de nuevo")
                End If
            Catch ex As Exception
                conexion.Close()
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Public Function IngresarUsuario(idEmpleado As String, usuario As String, contrasenia As String) As String
        Dim conectar As New ConexionMySql
        Dim conexion As MySqlConnection = conectar.CrearConexion()
        Dim sqlQuery As String
        Dim sqlCommand As MySqlCommand
        Dim resultado As String
        Dim idUsuario As Double

        Try
            idUsuario = Me.BuscarNumeroUsuarios() + 1
            sqlQuery = "INSERT INTO Usuarios(Usuario_Id,Nombre_Usuario,Clave_Usuario,Es_Activo,Empleado_Id) VALUES (" & idUsuario & ",'" & usuario & "'," & contrasenia & ",'S'," & idEmpleado & ")"
            sqlCommand = New MySqlCommand(sqlQuery, conexion)
            sqlCommand.ExecuteNonQuery()
            conexion.Close()
            resultado = "Se creo correctamente el usuario"
        Catch ex As Exception
            conexion.Close()
            resultado = "Error al crear el usuario: " + ex.Message
        End Try
        Return resultado
    End Function

    Public Function BuscarNumeroUsuarios() As Double
        Dim conectar As New ConexionMySql
        Dim conexion As MySqlConnection = conectar.CrearConexion()
        Dim sqlQuery As String
        Dim sqlCommand As MySqlCommand
        Dim dataAdapter As MySqlDataAdapter
        Dim dataSet As DataSet
        Dim resultado As Double

        Try
            sqlQuery = "SELECT * FROM Usuarios"
            sqlCommand = New MySqlCommand(sqlQuery, conexion)
            dataAdapter = New MySqlDataAdapter(sqlCommand)
            dataSet = New DataSet()
            dataAdapter.Fill(dataSet, "Usuarios")
            resultado = dataSet.Tables("Usuarios").Rows.Count
        Catch ex As Exception
            resultado = 0
        End Try
        Return resultado
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class