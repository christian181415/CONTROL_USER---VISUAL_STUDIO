<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRT_Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRT_Inicio))
        Me.P_Trabajo = New System.Windows.Forms.Panel()
        Me.P_Barra_Tareas = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.P_Barra_Tareas.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Trabajo
        '
        Me.P_Trabajo.BackgroundImage = CType(resources.GetObject("P_Trabajo.BackgroundImage"), System.Drawing.Image)
        Me.P_Trabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.P_Trabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Trabajo.Location = New System.Drawing.Point(0, 0)
        Me.P_Trabajo.Name = "P_Trabajo"
        Me.P_Trabajo.Size = New System.Drawing.Size(1276, 721)
        Me.P_Trabajo.TabIndex = 0
        '
        'P_Barra_Tareas
        '
        Me.P_Barra_Tareas.Controls.Add(Me.Panel1)
        Me.P_Barra_Tareas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.P_Barra_Tareas.Location = New System.Drawing.Point(0, 689)
        Me.P_Barra_Tareas.Name = "P_Barra_Tareas"
        Me.P_Barra_Tareas.Size = New System.Drawing.Size(1276, 32)
        Me.P_Barra_Tareas.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1276, 5)
        Me.Panel1.TabIndex = 0
        '
        'CRT_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.P_Barra_Tareas)
        Me.Controls.Add(Me.P_Trabajo)
        Me.Name = "CRT_Inicio"
        Me.Size = New System.Drawing.Size(1276, 721)
        Me.P_Barra_Tareas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_Trabajo As Panel
    Friend WithEvents P_Barra_Tareas As Panel
    Friend WithEvents Panel1 As Panel
End Class
