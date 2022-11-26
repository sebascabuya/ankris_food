Imports System.Data.Common
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class RegistrarPedidoProveedor
    Dim conectar As New ConexionMySql
    Dim conexion As MySqlConnection = conectar.CrearConexion()
    Dim sqlQuery As String
    Dim sqlCommand As MySqlCommand
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet
    Private Sub RegistrarPedidoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Akris_FoodDataSet.Pedido_Proveedores' Puede moverla o quitarla según sea necesario.
        DataGridView1.DataSource = BuscarPedidos().Tables("Pedido_Proveedores")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idPedido As Double
        Dim fechaPedido As Date = Date.Parse(DateTimePicker1.Value.ToShortDateString)
        Dim estado As String = ComboBoxEstado.SelectedItem.ToString()
        Dim valorPedido As Double = CDbl(Val(TextBoxValor.Text))
        Dim comentario As String = TextBoxComentario.Text

        If (String.IsNullOrWhiteSpace(fechaPedido) Or String.IsNullOrWhiteSpace(estado) Or String.IsNullOrWhiteSpace(valorPedido) Or String.IsNullOrWhiteSpace(comentario)) Then
            MsgBox("Debes ingresar toda la información")
        Else
            Try
                idPedido = DataGridView1.Rows.Count
                If (conexion.State = ConnectionState.Closed) Then
                    conexion.Open()
                End If
                sqlQuery = "INSERT INTO Pedido_Proveedores(Id_Pedido,Fecha_Pedido,Recibido,Valor_Total,Comentario_Pedido,Id_Proveedor) VALUES (@Id_Pedido,@Fecha_Pedido,@Recibido,@Valor_Total,@Comentario_Pedido,@Id_Proveedor)"
                sqlCommand = New MySqlCommand(sqlQuery, conexion)
                sqlCommand.Parameters.Add("@Id_Pedido", MySqlDbType.Int64).Value = idPedido
                sqlCommand.Parameters.Add("@Fecha_Pedido", MySqlDbType.Date).Value = fechaPedido
                sqlCommand.Parameters.Add("@Recibido", MySqlDbType.VarChar).Value = estado
                sqlCommand.Parameters.Add("@Valor_Total", MySqlDbType.Float).Value = valorPedido
                sqlCommand.Parameters.Add("@Comentario_Pedido", MySqlDbType.VarChar).Value = comentario
                sqlCommand.Parameters.Add("@Id_Proveedor", MySqlDbType.Int64).Value = 1
                sqlCommand.ExecuteNonQuery()
                conexion.Close()
                MsgBox("Pedido registrado exitosamente")
                DataGridView1.DataSource = BuscarPedidos().Tables("Pedido_Proveedores")
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
            sqlQuery = "SELECT Fecha_Pedido, Recibido, Valor_Total, Comentario_Pedido FROM Pedido_Proveedores"
            sqlCommand = New MySqlCommand(sqlQuery, conexion)
            DataAdapter = New MySqlDataAdapter(SqlCommand)
            dataSet = New DataSet()
            dataAdapter.Fill(dataSet, "Pedido_Proveedores")
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return dataSet
    End Function
End Class