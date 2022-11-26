Imports System.Data.SqlClient
Imports System.Net
Imports MySql.Data.MySqlClient

Public Class Inventario
    Dim conectar As New ConexionMySql
    Dim conexion As MySqlConnection = conectar.CrearConexion()
    Dim sqlQuery As String
    Dim sqlCommand As MySqlCommand
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Akris_FoodDataSet.Inventario' Puede moverla o quitarla según sea necesario.
        Me.DataGridView1.DataSource = BuscarProductos().Tables("Inventario")
    End Sub

    Public Function BuscarNumeroProductos() As Double
        Dim resultado As Double
        Try
            If (conexion.State = ConnectionState.Closed) Then
                conexion.Open()
            End If
            sqlQuery = "SELECT * FROM Inventario"
            sqlCommand = New MySqlCommand(sqlQuery, conexion)
            dataAdapter = New MySqlDataAdapter(sqlCommand)
            dataSet = New DataSet()
            dataAdapter.Fill(dataSet, "Inventario")
            resultado = dataSet.Tables("Inventario").Rows.Count
        Catch ex As Exception
            resultado = 0
        End Try
        Return resultado
    End Function

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim idProducto As Double
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
                idProducto = Me.BuscarNumeroProductos() + 1
                sqlQuery = "INSERT INTO Inventario(Producto,Nombre_Producto,Cantidad_Producto,Valor_Producto,Fecha_Vencimiento,Id_Proveedor) VALUES (" & idProducto & ",'" & nombreProducto & "'," & cantidadProducto & "," & valorProducto & ",STR_TO_DATE('03-04-2023','%d-%m-%Y'), 1)"
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                sqlCommand.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Se ingreso correctamente el producto")
                Me.DataGridView1.DataSource = BuscarProductos().Tables("Inventario")
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