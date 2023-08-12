<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRT_Menu
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRT_Menu))
        Me.P_Perfil = New System.Windows.Forms.Panel()
        Me.Stand_User = New System.Windows.Forms.Label()
        Me.Name_User = New System.Windows.Forms.Label()
        Me.PBX_Perfil = New System.Windows.Forms.PictureBox()
        Me.P_Personaliza = New System.Windows.Forms.Panel()
        Me.P_Menu = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BTN_Accesos = New System.Windows.Forms.Button()
        Me.BTN_Activos = New System.Windows.Forms.Button()
        Me.P_Perfil.SuspendLayout()
        CType(Me.PBX_Perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_Menu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Perfil
        '
        Me.P_Perfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.P_Perfil.Controls.Add(Me.Stand_User)
        Me.P_Perfil.Controls.Add(Me.Name_User)
        Me.P_Perfil.Controls.Add(Me.PBX_Perfil)
        Me.P_Perfil.Controls.Add(Me.P_Personaliza)
        Me.P_Perfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Perfil.Location = New System.Drawing.Point(0, 0)
        Me.P_Perfil.Name = "P_Perfil"
        Me.P_Perfil.Size = New System.Drawing.Size(200, 225)
        Me.P_Perfil.TabIndex = 0
        '
        'Stand_User
        '
        Me.Stand_User.AutoSize = True
        Me.Stand_User.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Stand_User.ForeColor = System.Drawing.Color.White
        Me.Stand_User.Location = New System.Drawing.Point(25, 194)
        Me.Stand_User.Name = "Stand_User"
        Me.Stand_User.Size = New System.Drawing.Size(107, 15)
        Me.Stand_User.TabIndex = 3
        Me.Stand_User.Text = "Puesto de Usuario"
        '
        'Name_User
        '
        Me.Name_User.AutoSize = True
        Me.Name_User.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name_User.ForeColor = System.Drawing.Color.White
        Me.Name_User.Location = New System.Drawing.Point(25, 179)
        Me.Name_User.Name = "Name_User"
        Me.Name_User.Size = New System.Drawing.Size(115, 15)
        Me.Name_User.TabIndex = 2
        Me.Name_User.Text = "Nombre de Usuario"
        '
        'PBX_Perfil
        '
        Me.PBX_Perfil.Image = CType(resources.GetObject("PBX_Perfil.Image"), System.Drawing.Image)
        Me.PBX_Perfil.Location = New System.Drawing.Point(7, 6)
        Me.PBX_Perfil.Name = "PBX_Perfil"
        Me.PBX_Perfil.Size = New System.Drawing.Size(180, 180)
        Me.PBX_Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBX_Perfil.TabIndex = 1
        Me.PBX_Perfil.TabStop = False
        '
        'P_Personaliza
        '
        Me.P_Personaliza.BackColor = System.Drawing.Color.White
        Me.P_Personaliza.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.P_Personaliza.Location = New System.Drawing.Point(0, 220)
        Me.P_Personaliza.Name = "P_Personaliza"
        Me.P_Personaliza.Size = New System.Drawing.Size(200, 5)
        Me.P_Personaliza.TabIndex = 0
        '
        'P_Menu
        '
        Me.P_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.P_Menu.Controls.Add(Me.Button7)
        Me.P_Menu.Controls.Add(Me.Panel1)
        Me.P_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Menu.Location = New System.Drawing.Point(0, 225)
        Me.P_Menu.Name = "P_Menu"
        Me.P_Menu.Size = New System.Drawing.Size(200, 596)
        Me.P_Menu.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(0, 543)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(200, 53)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Cerrar sesion"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.BTN_Accesos)
        Me.Panel1.Controls.Add(Me.BTN_Activos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 459)
        Me.Panel1.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(0, 265)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 53)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Empresa"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 212)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(200, 53)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Directorio"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 53)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Procesos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 53)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Soporte"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BTN_Accesos
        '
        Me.BTN_Accesos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_Accesos.FlatAppearance.BorderSize = 0
        Me.BTN_Accesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.BTN_Accesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Accesos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTN_Accesos.ForeColor = System.Drawing.Color.White
        Me.BTN_Accesos.Location = New System.Drawing.Point(0, 53)
        Me.BTN_Accesos.Name = "BTN_Accesos"
        Me.BTN_Accesos.Size = New System.Drawing.Size(200, 53)
        Me.BTN_Accesos.TabIndex = 1
        Me.BTN_Accesos.Text = "Accesos"
        Me.BTN_Accesos.UseVisualStyleBackColor = True
        '
        'BTN_Activos
        '
        Me.BTN_Activos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTN_Activos.FlatAppearance.BorderSize = 0
        Me.BTN_Activos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.BTN_Activos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Activos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BTN_Activos.ForeColor = System.Drawing.Color.White
        Me.BTN_Activos.Location = New System.Drawing.Point(0, 0)
        Me.BTN_Activos.Name = "BTN_Activos"
        Me.BTN_Activos.Size = New System.Drawing.Size(200, 53)
        Me.BTN_Activos.TabIndex = 0
        Me.BTN_Activos.Text = "Inventario"
        Me.BTN_Activos.UseVisualStyleBackColor = True
        '
        'CRT_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Controls.Add(Me.P_Menu)
        Me.Controls.Add(Me.P_Perfil)
        Me.Name = "CRT_Menu"
        Me.Size = New System.Drawing.Size(200, 821)
        Me.P_Perfil.ResumeLayout(False)
        Me.P_Perfil.PerformLayout()
        CType(Me.PBX_Perfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_Menu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_Perfil As Panel
    Friend WithEvents PBX_Perfil As PictureBox
    Friend WithEvents P_Personaliza As Panel
    Friend WithEvents P_Menu As Panel
    Friend WithEvents Stand_User As Label
    Friend WithEvents Name_User As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_Activos As Button
    Friend WithEvents BTN_Accesos As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
End Class
