Public Class CRT_Credenciales
    Private Sub CRT_Credenciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel_Correo.Location = New Point(0, 0)
        Panel_Trabajo.Controls.Add(Panel_Correo)
    End Sub

End Class
