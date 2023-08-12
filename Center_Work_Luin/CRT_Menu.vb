Imports System.Drawing.Drawing2D

Public Class CRT_Menu
    Dim PanelPInicio As New CRT_Inicio
    Dim PanelInventarios As New CRT_Inventarios
    Dim PanelAccesos As New CRT_Credenciales


    '-----> LOAD PRINCIPAL
    Private Sub CRT_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Name_User.Text = "Geraldo Castillo E."
        Stand_User.Text = "Jefatura IT"
        PanelPInicio.Location = New Point(0, 0)
        CW_Principal.P_Trabajo.Controls.Add(PanelPInicio)
    End Sub



    '-----> FUNCION FOTO PERFIL
    Sub PerfilPhoto()
        'creamos un objeto de la clase GraphicsPath
        Dim figura As GraphicsPath = New GraphicsPath
        'manipulando las variables que se corresponden con los puntos x e y, el ancho y el alto de la figura, podemos variar su aspecto
        Dim x, y, ancho, alto As Integer
        'anchura y altura de la figura (círculo en este caso)
        ancho = 150
        alto = 150
        'posiciones x e y de la figura (centrada en el control PictureBox)
        x = (PBX_Perfil.Width - ancho) / 2
        y = (PBX_Perfil.Height - alto) / 2
        'usamos el método AddEllipse para conseguir la figura de un círculo,
        'que aplicaremos sobre el control PictureBox.
        figura.AddEllipse(New Rectangle(x, y, ancho, alto))
        'en el control PictureBox creamos una región que se corresponde
        'con la figura del objeto GraphicsPath
        PBX_Perfil.Region = New Region(figura)
    End Sub

    '-----> BOTON CERRAR SESION
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Application.Exit()
    End Sub

    '-----> BOTON INVENTARIOS
    Private Sub BTN_Activos_Click(sender As Object, e As EventArgs) Handles BTN_Activos.Click
        ClearBotones()
        CW_Principal.P_Trabajo.Controls.Clear()
        'BTN_Activos.BackColor = Color.Firebrick
        BTN_Activos.Font = New Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point)

        PanelInventarios.Location = New Point(0, 0)
        CW_Principal.P_Trabajo.Controls.Add(PanelInventarios)
    End Sub

    '-----> BOTON INVENTARIOS
    Private Sub BTN_Accesos_Click(sender As Object, e As EventArgs) Handles BTN_Accesos.Click
        ClearBotones()
        CW_Principal.P_Trabajo.Controls.Clear()
        'BTN_Activos.BackColor = Color.Firebrick
        BTN_Accesos.Font = New Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point)

        PanelAccesos.Location = New Point(0, 0)
        CW_Principal.P_Trabajo.Controls.Add(PanelAccesos)
    End Sub

    Sub ClearBotones()
        BTN_Activos.Font = New Font("Segoe UI", 8.25, FontStyle.Bold, GraphicsUnit.Point)
        BTN_Accesos.Font = New Font("Segoe UI", 8.25, FontStyle.Bold, GraphicsUnit.Point)
    End Sub




End Class
