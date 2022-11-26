Imports System.Data.Common
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class RegistrarPedido
    Dim conectar As New ConexionMySql
    Dim conexion As MySqlConnection = conectar.CrearConexion()
    Dim sqlQuery As String
    Dim sqlCommand As MySqlCommand
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet
    Private Sub RegistrarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Akris_FoodDataSet.Pedidos' Puede moverla o quitarla según sea necesario.
        DataGridView1.DataSource = BuscarPedidos().Tables("Pedidos")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conectar As New ConexionMySql
        Dim conexion As MySqlConnection = conectar.CrearConexion()
        Dim sqlQuery As String
        Dim sqlCommand As MySqlCommand
        Dim idPedido As Double
        Dim fechaPedido As Date = Date.Parse(DateTimePicker1.Value.ToShortDateString)
        Dim estado As String = ComboBoxEstado.SelectedItem.ToString()
        Dim valorVenta As Double = CDbl(Val(TextBoxValor.Text))
        Dim comentario As String = TextBoxComentario.Text

        If (String.IsNullOrWhiteSpace(fechaPedido) Or String.IsNullOrWhiteSpace(estado) Or String.IsNullOrWhiteSpace(valorVenta) Or String.IsNullOrWhiteSpace(comentario)) Then
            MsgBox("Debes ingresar toda la información")
        Else
            Try
                If (conexion.State = ConnectionState.Closed) Then
                    conexion.Open()
                End If
                idPedido = DataGridView1.Rows.Count
                sqlQuery = "INSERT INTO Pedidos(Id_Pedido,Fecha_Pedido,Entregado,Valor_Total,Comentario_Pedido,Id_Cliente) VALUES (@Id_Pedido,@Fecha_Pedido,@Entregado,@Valor_Total,@Comentario_Pedido,@Id_Cliente)"
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                sqlCommand.Parameters.Add("@Id_Pedido", MySqlDbType.Int64).Value = idPedido
                sqlCommand.Parameters.Add("@Fecha_Pedido", MySqlDbType.Date).Value = fechaPedido
                sqlCommand.Parameters.Add("@Entregado", MySqlDbType.VarChar).Value = estado
                sqlCommand.Parameters.Add("@Valor_Total", MySqlDbType.Float).Value = valorVenta
                sqlCommand.Parameters.Add("@Comentario_Pedido", MySqlDbType.VarChar).Value = comentario
                sqlCommand.Parameters.Add("@Id_Cliente", MySqlDbType.Int64).Value = 1
                sqlCommand.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Venta registrada exitosamente")
                DataGridView1.DataSource = BuscarPedidos().Tables("Pedidos")
            Catch ex As Exception
                conexion.Close()
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Function BuscarPedidos() As DataSet
        dataSet = New DataSet()
        Try
            If (conexion.State = ConnectionState.Closed) Then
                conexion.Open()
            End If
            sqlQuery = "SELECT Fecha_Pedido, Entregado, Valor_Total, Comentario_Pedido FROM Pedidos"
            sqlCommand = New MySqlCommand(sqlQuery, conexion)
            DataAdapter = New MySqlDataAdapter(SqlCommand)
            dataSet = New DataSet()
            dataAdapter.Fill(dataSet, "Pedidos")
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return dataSet
    End Function
End Class