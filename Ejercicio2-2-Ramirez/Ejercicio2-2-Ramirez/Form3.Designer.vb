<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrALaWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoTrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntuacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.TestToolStripMenuItem, Me.WebToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(458, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoTrabajadorToolStripMenuItem, Me.PuntuacionesToolStripMenuItem, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'WebToolStripMenuItem
        '
        Me.WebToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IrALaWebToolStripMenuItem})
        Me.WebToolStripMenuItem.Name = "WebToolStripMenuItem"
        Me.WebToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.WebToolStripMenuItem.Text = "Web"
        '
        'IrALaWebToolStripMenuItem
        '
        Me.IrALaWebToolStripMenuItem.Name = "IrALaWebToolStripMenuItem"
        Me.IrALaWebToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IrALaWebToolStripMenuItem.Text = "Ir a la web"
        '
        'NuevoTrabajadorToolStripMenuItem
        '
        Me.NuevoTrabajadorToolStripMenuItem.Name = "NuevoTrabajadorToolStripMenuItem"
        Me.NuevoTrabajadorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoTrabajadorToolStripMenuItem.Text = "Nuevo Trabajador"
        '
        'PuntuacionesToolStripMenuItem
        '
        Me.PuntuacionesToolStripMenuItem.Name = "PuntuacionesToolStripMenuItem"
        Me.PuntuacionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PuntuacionesToolStripMenuItem.Text = "Puntuaciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VolverToolStripMenuItem.Text = "Volver"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 575)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Test"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoTrabajadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IrALaWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntuacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
End Class
