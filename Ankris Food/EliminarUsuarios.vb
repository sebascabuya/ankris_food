Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class EliminarUsuarios
    ReadOnly conectar As New ConexionMySql
    ReadOnly conexion As MySqlConnection = conectar.CrearConexion()
    Dim sqlQuery As String
    Dim sqlCommand As MySqlCommand
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet
    Public Property NombreEmpleado As String
    Public Property FkEmpleado As String
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Me.EliminarUsuario()
    End Sub

    Private Sub GetEmpleadoById()
        Dim idEmpleado As String = IdEmpleadoText.Text

        If (String.IsNullOrEmpty(idEmpleado)) Then
            MsgBox("Ingrese el número de identificación del empleado")
        Else
            Try
                sqlQuery = "SELECT Empleado_Id, Nombre_Empleado FROM Empleados WHERE Numero_Id = '" & idEmpleado & "'"
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                dataAdapter = New MySqlDataAdapter(sqlCommand)
                dataSet = New DataSet()
                dataAdapter.Fill(dataSet, "Empleados")
                If (dataSet.Tables("Empleados").Rows.Count > 0) Then
                    FkEmpleado = dataSet.Tables("Empleados").Rows(0).Item(0)
                    NombreEmpleado = dataSet.Tables("Empleados").Rows(0).Item(1)
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub EliminarUsuario()
        Me.GetEmpleadoById()

        If (String.IsNullOrEmpty(FkEmpleado)) Then
            MsgBox("No se encontro el registro del empleado")
        Else
            Try
                conexion.Open()
                sqlQuery = "UPDATE Usuarios SET Es_Activo = 'N' WHERE Empleado_Id = " & FkEmpleado & ""
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                sqlCommand.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Usuario eliminado correctamente")
            Catch ex As Exception
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class