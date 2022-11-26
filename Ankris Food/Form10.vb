Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form10
    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim conectar As New ConexionMySql
        Dim conexion As MySqlConnection = conectar.CrearConexion()
        Dim sqlQuery As String
        Dim sqlCommand As MySqlCommand
        Dim dataAdapter As MySqlDataAdapter
        Dim dataSet As DataSet
        Dim Usuario As String
        Dim Contrasenia As String

        Try
            If (conexion.State = ConnectionState.Closed) Then
                conexion.Open()
            End If
            Usuario = Perfil.Text
            Contrasenia = Contraseña_Text.Text
            sqlQuery = "SELECT * FROM Usuarios WHERE Nombre_Usuario = '" & Usuario & "' AND Clave_Usuario = " & Contrasenia & ""
            sqlCommand = New MySqlCommand(sqlQuery, conexion)
            dataAdapter = New MySqlDataAdapter(sqlCommand)
            dataSet = New DataSet()
            dataAdapter.Fill(dataSet, "Usuarios")
            If (dataSet.Tables("Usuarios").Rows.Count > 0) Then
                Form2.Show()
                Perfil.Text = ""
                Contraseña_Text.Text = ""
                Me.Hide()
            Else
                MsgBox("No se encontraron usuarios. Verifique los Datos e intentelo de nuevo")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub
End Class