Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class EditarProductos
    Dim conectar As New ConexionMySql
    Dim conexion As MySqlConnection = conectar.CrearConexion()
    Dim sqlQuery As String
    Dim sqlCommand As MySqlCommand
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet
    Public Property ProductoId As String
    Public Property NombreProducto As String
    Private Sub EditarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Akris_FoodDataSet.Inventario' Puede moverla o quitarla según sea necesario.
        Me.DataGridViewInventario.DataSource = BuscarProductos().Tables("Inventario")
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim nombreProducto As String = NombreProductoTetx.Text
        Dim cantidadProducto As String = CantidadTetx.Text
        Dim valorProducto As String = ValorTetx.Text

        If (String.IsNullOrEmpty(nombreProducto) Or String.IsNullOrEmpty(cantidadProducto) Or String.IsNullOrEmpty(valorProducto)) Then
            MsgBox("Ingresa por favor todos los datos del producto")
        Else
            Try
                If (conexion.State = ConnectionState.Closed) Then
                    conexion.Open()
                End If
                sqlQuery = "UPDATE Inventario SET Nombre_Producto = '" & nombreProducto & "', Cantidad_Producto = " & cantidadProducto & ", Valor_Producto = " & valorProducto & " WHERE Producto = " & ProductoId & ""
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                sqlCommand.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Se actualizo correctamente el producto")
                Me.DataGridViewInventario.DataSource = BuscarProductos().Tables("Inventario")
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridViewInventario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewInventario.CellClick
        Dim row As DataGridViewRow = DataGridViewInventario.Rows(e.RowIndex)
        ProductoId = row.Cells(0).Value
        NombreProductoTetx.Text = row.Cells(1).Value
        NombreProducto = row.Cells(1).Value
        CantidadTetx.Text = row.Cells(2).Value
        ValorTetx.Text = row.Cells(3).Value
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim ask As MsgBoxResult = MsgBox("¿Deseas eliminar el producto (" & NombreProducto & ")?", MsgBoxStyle.YesNo)

        If (ask = MsgBoxResult.Yes) Then
            Try
                If (conexion.State = ConnectionState.Closed) Then
                    conexion.Open()
                End If
                sqlQuery = "DELETE FROM Inventario WHERE Producto = " & ProductoId & ""
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                sqlCommand.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Se elimino correctamente el producto")
                NombreProductoTetx.Text = ""
                CantidadTetx.Text = ""
                ValorTetx.Text = ""
                Me.DataGridViewInventario.DataSource = BuscarProductos().Tables("Inventario")
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Function BuscarProductos() As DataSet
        dataSet = New DataSet()
        Try
            If (conexion.State = ConnectionState.Closed) Then
                conexion.Open()
            End If
            sqlQuery = "SELECT Producto, Nombre_Producto, Cantidad_Producto, Valor_Producto FROM Inventario"
            sqlCommand = New MySqlCommand(sqlQuery, conexion)
            dataAdapter = New MySqlDataAdapter(sqlCommand)
            dataSet = New DataSet()
            dataAdapter.Fill(dataSet, "Inventario")
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return dataSet
    End Function
End Class