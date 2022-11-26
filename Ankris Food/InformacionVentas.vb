Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class InformacionVentas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conectar As New ConexionMySql
        Dim conexion As MySqlConnection = conectar.CrearConexion()
        Dim sqlQuery As String
        Dim sqlCommand As MySqlCommand
        Dim dataAdapter As MySqlDataAdapter
        Dim dataTable As DataTable
        Dim fechaInicio As String = DateTimePickerInicio.Value.ToShortDateString
        Dim fechaFin As String = DateTimePickerFin.Value.ToShortDateString
        Dim dateInicio As Date
        Dim dateFin As Date

        If (String.IsNullOrEmpty(fechaInicio) Or String.IsNullOrEmpty(fechaFin)) Then
            MsgBox("Ingresa fechas validas para la busqueda")
        Else
            Try
                If (conexion.State = ConnectionState.Closed) Then
                    conexion.Open()
                End If
                dateInicio = Date.Parse(fechaInicio)
                dateFin = Date.Parse(fechaFin)
                sqlQuery = "SELECT * FROM Pedidos WHERE Fecha_Pedido between @fechaInicio AND @fechaFin"
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                sqlCommand.Parameters.Add("@fechaInicio", MySqlDbType.Date).Value = dateInicio
                sqlCommand.Parameters.Add("@fechaFin", MySqlDbType.Date).Value = dateFin
                dataAdapter = New MySqlDataAdapter(sqlCommand)
                dataTable = New DataTable()
                dataAdapter.Fill(dataTable)
                If (dataTable.Rows.Count > 0) Then
                    DataGridView1.DataSource = dataTable
                Else
                    MsgBox("No se encontraron pedidos entre este rango de fechas. Intente de nuevo")
                End If
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class