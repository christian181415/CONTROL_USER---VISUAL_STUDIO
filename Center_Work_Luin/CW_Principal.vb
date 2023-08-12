Public Class CW_Principal
    Dim PanelMenu As New CRT_Menu


    Private Sub CW_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.PerfilPhoto()
        P_Menu.Controls.Add(PanelMenu)
    End Sub

End Class