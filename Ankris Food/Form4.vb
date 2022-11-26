Public Class Form4
    Private Sub Inventario_Click(sender As Object, e As EventArgs) Handles InventarioBoton.Click
        Inventario.Show()
        Me.Hide()
    End Sub

    Private Sub EditarProductosBoton_Click(sender As Object, e As EventArgs) Handles EditarProductosBoton.Click
        EditarProductos.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class