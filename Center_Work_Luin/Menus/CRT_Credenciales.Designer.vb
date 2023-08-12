<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRT_Credenciales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRT_Credenciales))
        Me.Panel_Principal = New System.Windows.Forms.Panel()
        Me.Panel_Trabajo = New System.Windows.Forms.Panel()
        Me.Panel_BarraTareas = New System.Windows.Forms.Panel()
        Me.P_Personaliza = New System.Windows.Forms.Panel()
        Me.Panel_Menus = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel_Correo = New System.Windows.Forms.Panel()
        Me.P2_Correo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.P1_Correo = New System.Windows.Forms.Panel()
        Me.P1C_Menu = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.P1C_Titulo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel_Principal.SuspendLayout()
        Me.Panel_BarraTareas.SuspendLayout()
        Me.Panel_Menus.SuspendLayout()
        Me.Panel_Correo.SuspendLayout()
        Me.P2_Correo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P1_Correo.SuspendLayout()
        Me.P1C_Menu.SuspendLayout()
        Me.P1C_Titulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Principal
        '
        Me.Panel_Principal.Controls.Add(Me.Panel_Trabajo)
        Me.Panel_Principal.Controls.Add(Me.Panel_BarraTareas)
        Me.Panel_Principal.Controls.Add(Me.Panel_Menus)
        Me.Panel_Principal.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Principal.Name = "Panel_Principal"
        Me.Panel_Principal.Size = New System.Drawing.Size(1276, 721)
        Me.Panel_Principal.TabIndex = 0
        '
        'Panel_Trabajo
        '
        Me.Panel_Trabajo.BackgroundImage = CType(resources.GetObject("Panel_Trabajo.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Trabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel_Trabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Trabajo.Location = New System.Drawing.Point(0, 45)
        Me.Panel_Trabajo.Name = "Panel_Trabajo"
        Me.Panel_Trabajo.Size = New System.Drawing.Size(1276, 644)
        Me.Panel_Trabajo.TabIndex = 2
        '
        'Panel_BarraTareas
        '
        Me.Panel_BarraTareas.Controls.Add(Me.P_Personaliza)
        Me.Panel_BarraTareas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_BarraTareas.Location = New System.Drawing.Point(0, 689)
        Me.Panel_BarraTareas.Name = "Panel_BarraTareas"
        Me.Panel_BarraTareas.Size = New System.Drawing.Size(1276, 32)
        Me.Panel_BarraTareas.TabIndex = 1
        '
        'P_Personaliza
        '
        Me.P_Personaliza.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.P_Personaliza.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Personaliza.Location = New System.Drawing.Point(0, 0)
        Me.P_Personaliza.Name = "P_Personaliza"
        Me.P_Personaliza.Size = New System.Drawing.Size(1276, 5)
        Me.P_Personaliza.TabIndex = 0
        '
        'Panel_Menus
        '
        Me.Panel_Menus.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel_Menus.Controls.Add(Me.Button6)
        Me.Panel_Menus.Controls.Add(Me.Button5)
        Me.Panel_Menus.Controls.Add(Me.Button4)
        Me.Panel_Menus.Controls.Add(Me.Button3)
        Me.Panel_Menus.Controls.Add(Me.Button2)
        Me.Panel_Menus.Controls.Add(Me.Button1)
        Me.Panel_Menus.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Menus.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Menus.Name = "Panel_Menus"
        Me.Panel_Menus.Size = New System.Drawing.Size(1276, 45)
        Me.Panel_Menus.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(615, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 45)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Otros"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(492, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 45)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Servicios"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(369, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 45)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Escritorio Remoto"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(246, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 45)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "NAS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(123, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "ERP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Correo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel_Correo
        '
        Me.Panel_Correo.Controls.Add(Me.P2_Correo)
        Me.Panel_Correo.Controls.Add(Me.P1_Correo)
        Me.Panel_Correo.Location = New System.Drawing.Point(0, 758)
        Me.Panel_Correo.Name = "Panel_Correo"
        Me.Panel_Correo.Size = New System.Drawing.Size(1276, 644)
        Me.Panel_Correo.TabIndex = 1
        '
        'P2_Correo
        '
        Me.P2_Correo.Controls.Add(Me.Label1)
        Me.P2_Correo.Controls.Add(Me.DataGridView1)
        Me.P2_Correo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P2_Correo.Location = New System.Drawing.Point(192, 0)
        Me.P2_Correo.Name = "P2_Correo"
        Me.P2_Correo.Size = New System.Drawing.Size(1084, 644)
        Me.P2_Correo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(418, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cuentas de Correo"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1018, 552)
        Me.DataGridView1.TabIndex = 0
        '
        'P1_Correo
        '
        Me.P1_Correo.Controls.Add(Me.P1C_Menu)
        Me.P1_Correo.Controls.Add(Me.P1C_Titulo)
        Me.P1_Correo.Dock = System.Windows.Forms.DockStyle.Left
        Me.P1_Correo.Location = New System.Drawing.Point(0, 0)
        Me.P1_Correo.Name = "P1_Correo"
        Me.P1_Correo.Size = New System.Drawing.Size(192, 644)
        Me.P1_Correo.TabIndex = 0
        '
        'P1C_Menu
        '
        Me.P1C_Menu.Controls.Add(Me.Button12)
        Me.P1C_Menu.Controls.Add(Me.Button11)
        Me.P1C_Menu.Controls.Add(Me.Button10)
        Me.P1C_Menu.Controls.Add(Me.Button9)
        Me.P1C_Menu.Controls.Add(Me.Button8)
        Me.P1C_Menu.Controls.Add(Me.Button7)
        Me.P1C_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P1C_Menu.Location = New System.Drawing.Point(0, 61)
        Me.P1C_Menu.Name = "P1C_Menu"
        Me.P1C_Menu.Size = New System.Drawing.Size(192, 583)
        Me.P1C_Menu.TabIndex = 4
        '
        'Button12
        '
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(0, 215)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(192, 43)
        Me.Button12.TabIndex = 5
        Me.Button12.Text = "Administrar Cuentas"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(0, 172)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(192, 43)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "outlook.com"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(0, 129)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(192, 43)
        Me.Button10.TabIndex = 3
        Me.Button10.Text = "gmail.com"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(0, 86)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(192, 43)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "plastikisimo.mx"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(0, 43)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(192, 43)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "luinfarmaceutica.com.mx"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(0, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(192, 43)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "luin.mx"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = True
        '
        'P1C_Titulo
        '
        Me.P1C_Titulo.Controls.Add(Me.Label2)
        Me.P1C_Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.P1C_Titulo.Location = New System.Drawing.Point(0, 0)
        Me.P1C_Titulo.Name = "P1C_Titulo"
        Me.P1C_Titulo.Size = New System.Drawing.Size(192, 61)
        Me.P1C_Titulo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(47, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Opciones"
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Width = 30
        '
        'Cuenta
        '
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Width = 300
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        '
        'CRT_Credenciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel_Correo)
        Me.Controls.Add(Me.Panel_Principal)
        Me.Name = "CRT_Credenciales"
        Me.Size = New System.Drawing.Size(1276, 3000)
        Me.Panel_Principal.ResumeLayout(False)
        Me.Panel_BarraTareas.ResumeLayout(False)
        Me.Panel_Menus.ResumeLayout(False)
        Me.Panel_Correo.ResumeLayout(False)
        Me.P2_Correo.ResumeLayout(False)
        Me.P2_Correo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P1_Correo.ResumeLayout(False)
        Me.P1C_Menu.ResumeLayout(False)
        Me.P1C_Titulo.ResumeLayout(False)
        Me.P1C_Titulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Principal As Panel
    Friend WithEvents Panel_Trabajo As Panel
    Friend WithEvents Panel_BarraTareas As Panel
    Friend WithEvents Panel_Menus As Panel
    Friend WithEvents P_Personaliza As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel_Correo As Panel
    Friend WithEvents P2_Correo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents P1_Correo As Panel
    Friend WithEvents P1C_Titulo As Panel
    Friend WithEvents P1C_Menu As Panel
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
End Class
