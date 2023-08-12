<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CW_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.P_Menu = New System.Windows.Forms.Panel()
        Me.P_Titulo = New System.Windows.Forms.Panel()
        Me.PT_Personaliza = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P_Trabajo = New System.Windows.Forms.Panel()
        Me.P_Titulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Menu
        '
        Me.P_Menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.P_Menu.Location = New System.Drawing.Point(0, 0)
        Me.P_Menu.Name = "P_Menu"
        Me.P_Menu.Size = New System.Drawing.Size(200, 821)
        Me.P_Menu.TabIndex = 0
        '
        'P_Titulo
        '
        Me.P_Titulo.Controls.Add(Me.PT_Personaliza)
        Me.P_Titulo.Controls.Add(Me.Label2)
        Me.P_Titulo.Controls.Add(Me.Label1)
        Me.P_Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Titulo.Location = New System.Drawing.Point(200, 0)
        Me.P_Titulo.Name = "P_Titulo"
        Me.P_Titulo.Size = New System.Drawing.Size(1276, 100)
        Me.P_Titulo.TabIndex = 1
        '
        'PT_Personaliza
        '
        Me.PT_Personaliza.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.PT_Personaliza.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PT_Personaliza.Location = New System.Drawing.Point(0, 95)
        Me.PT_Personaliza.Name = "PT_Personaliza"
        Me.PT_Personaliza.Size = New System.Drawing.Size(1276, 5)
        Me.PT_Personaliza.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(544, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Corporativo LUIN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(458, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CENTER WORK LUIN"
        '
        'P_Trabajo
        '
        Me.P_Trabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Trabajo.Location = New System.Drawing.Point(200, 100)
        Me.P_Trabajo.Name = "P_Trabajo"
        Me.P_Trabajo.Size = New System.Drawing.Size(1276, 721)
        Me.P_Trabajo.TabIndex = 2
        '
        'CW_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1476, 821)
        Me.Controls.Add(Me.P_Trabajo)
        Me.Controls.Add(Me.P_Titulo)
        Me.Controls.Add(Me.P_Menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CW_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CW_Principal"
        Me.P_Titulo.ResumeLayout(False)
        Me.P_Titulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_Menu As Panel
    Friend WithEvents P_Titulo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents P_Trabajo As Panel
    Friend WithEvents PT_Personaliza As Panel
End Class
