Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Reportes
    Dim conectar As New ConexionMySql
    Dim conexion As MySqlConnection = conectar.CrearConexion()
    Dim sqlQuery As String
    Dim sqlCommand As MySqlCommand
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet
    Dim dataTable As DataTable
    Dim fechaInicio As Date
    Dim fechaFin As Date

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FiltrarVentas()
        Me.FiltrarPedidos()
        Me.TotalVentas()
        Me.TotalPedidos()
    End Sub

    Private Sub FiltrarVentas()
        fechaInicio = Date.Parse(DateTimePickerInicio.Value.ToShortDateString)
        fechaFin = Date.Parse(DateTimePickerFin.Value.ToShortDateString)
        If (String.IsNullOrEmpty(fechaInicio) Or String.IsNullOrEmpty(fechaFin)) Then
            MsgBox("Ingresa fechas validas para la busqueda")
        Else
            Try
                If (conexion.State = ConnectionState.Closed) Then
                    conexion.Open()
                End If
                sqlQuery = "SELECT Fecha_Pedido, Entregado, Valor_Total, Comentario_Pedido FROM Pedidos WHERE Fecha_Pedido between @fechaInicio AND @fechaFin"
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                sqlCommand.Parameters.Add("@fechaInicio", MySqlDbType.Date).Value = fechaInicio
                sqlCommand.Parameters.Add("@fechaFin", MySqlDbType.Date).Value = fechaFin
                dataAdapter = New MySqlDataAdapter(sqlCommand)
                dataTable = New DataTable()
                dataAdapter.Fill(dataTable)
                TextBoxVentas.Text = ""
                If (dataTable.Rows.Count > 0) Then
                    DataGridView1.DataSource = dataTable
                Else
                    MsgBox("No se encontraron ventas entre este rango de fechas")
                End If
            Catch ex As Exception
                conexion.Close()
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub FiltrarPedidos()
        fechaInicio = Date.Parse(DateTimePickerInicio.Value.ToShortDateString)
        fechaFin = Date.Parse(DateTimePickerFin.Value.ToShortDateString)
        If (String.IsNullOrEmpty(fechaInicio) Or String.IsNullOrEmpty(fechaFin)) Then
            MsgBox("Ingresa fechas validas para la busqueda")
        Else
            Try
                If (conexion.State = ConnectionState.Closed) Then
                    conexion.Open()
                End If
                sqlQuery = "SELECT Fecha_Pedido, Recibido, Valor_Total, Comentario_Pedido FROM Pedido_Proveedores WHERE Fecha_Pedido between @fechaInicio AND @fechaFin"
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                sqlCommand.Parameters.Add("@fechaInicio", MySqlDbType.Date).Value = fechaInicio
                sqlCommand.Parameters.Add("@fechaFin", MySqlDbType.Date).Value = fechaFin
                dataAdapter = New MySqlDataAdapter(sqlCommand)
                dataTable = New DataTable()
                dataAdapter.Fill(dataTable)
                TextBoxPedidos.Text = ""
                If (dataTable.Rows.Count > 0) Then
                    DataGridView2.DataSource = dataTable
                Else
                    MsgBox("No se encontraron pedidos entre este rango de fechas")
                End If
            Catch ex As Exception
                conexion.Close()
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub TotalVentas()
        Try
            Dim query As IEnumerable(Of Object) =
                From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                Where (
                        (row.Cells(2).Value IsNot Nothing) AndAlso
                        (row.Cells(2).Value IsNot DBNull.Value)
                ) Select row.Cells(2).Value

            Dim resultado As Decimal =
                query.Sum(Function(row) Convert.ToDecimal(row))

            TextBoxVentas.Text = String.Format("{0:N2}", resultado)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub TotalPedidos()
        Try
            Dim query As IEnumerable(Of Object) =
                From row As DataGridViewRow In DataGridView2.Rows.Cast(Of DataGridViewRow)()
                Where (
                        (row.Cells(2).Value IsNot Nothing) AndAlso
                        (row.Cells(2).Value IsNot DBNull.Value)
                ) Select row.Cells(2).Value

            Dim resultado As Decimal =
                query.Sum(Function(row) Convert.ToDecimal(row))

            TextBoxPedidos.Text = String.Format("{0:N2}", resultado)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class