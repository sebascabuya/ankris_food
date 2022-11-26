Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class InformacionNomina
    Dim conectar As New ConexionMySql
    Dim conexion As MySqlConnection = conectar.CrearConexion()
    Dim sqlQuery As String
    Dim sqlCommand As MySqlCommand
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet
    Private Sub InformacionNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Akris_FoodDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        DataGridView1.DataSource = BuscarEmpleados().Tables("Empleados")

        TextBoxTotalEmpleados.Text = DataGridView1.Rows.Count - 1
        Me.TotalNomina()
        Me.SalarioPromedio()
        Me.SalarioMayor()
        Me.SalarioMenor()
    End Sub

    Private Sub TotalNomina()
        Try
            Dim query As IEnumerable(Of Object) =
                From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                Where (
                        (row.Cells(5).Value IsNot Nothing) AndAlso
                        (row.Cells(5).Value IsNot DBNull.Value)
                ) Select row.Cells(5).Value

            Dim resultado As Decimal =
                query.Sum(Function(row) Convert.ToDecimal(row))

            TextBoxTotalNomina.Text = String.Format("{0:N2}", resultado)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SalarioPromedio()
        Try
            Dim query As IEnumerable(Of Object) =
                From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                Where (
                        (row.Cells(5).Value IsNot Nothing) AndAlso
                        (row.Cells(5).Value IsNot DBNull.Value)
                ) Select row.Cells(5).Value

            Dim resultado As Decimal =
                query.Average(Function(row) Convert.ToDecimal(row))

            TextBoxSalarioPromedio.Text = String.Format("{0:N2}", resultado)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SalarioMayor()
        Try
            Dim query As IEnumerable(Of Object) =
                From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                Where (
                        (row.Cells(5).Value IsNot Nothing) AndAlso
                        (row.Cells(5).Value IsNot DBNull.Value)
                ) Select row.Cells(5).Value

            Dim resultado As Decimal =
                query.Max(Function(row) Convert.ToDecimal(row))

            TextBoxSalarioMayor.Text = String.Format("{0:N2}", resultado)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SalarioMenor()
        Try
            Dim query As IEnumerable(Of Object) =
                From row As DataGridViewRow In DataGridView1.Rows.Cast(Of DataGridViewRow)()
                Where (
                        (row.Cells(5).Value IsNot Nothing) AndAlso
                        (row.Cells(5).Value IsNot DBNull.Value)
                ) Select row.Cells(5).Value

            Dim resultado As Decimal =
                query.Min(Function(row) Convert.ToDecimal(row))

            TextBoxSalarioMenor.Text = String.Format("{0:N2}", resultado)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Function BuscarEmpleados() As DataSet
        dataSet = New DataSet()
        Try
            If (conexion.State = ConnectionState.Closed) Then
                conexion.Open()
            End If
            sqlQuery = "SELECT Nombre_Empleado, Tipo_Id, Numero_Id, Direccion, Telefono, Salario FROM Empleados"
            sqlCommand = New MySqlCommand(sqlQuery, conexion)
            dataAdapter = New MySqlDataAdapter(sqlCommand)
            dataSet = New DataSet()
            dataAdapter.Fill(dataSet, "Empleados")
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        Return dataSet
    End Function
End Class