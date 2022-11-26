Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim Usuario As String
        Dim ID_Usuario As String
        Dim Contraseña As Integer

        Usuario = Perfil.Text
        ID_Usuario = ID_Usuario.text
        Contraseña = Contraseña.text

        If (Usuario = "administrador") And (ID_Usuario = "100") And (Contraseña = "1234") Then
            Form2.Show()

        Else
            MsgBox("Error, Verifique los Datos ")
        End If

        Perfil.Text = ""
        ID_Usuario.text = ""
        Contraseña.text = ""


    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub
End Class
