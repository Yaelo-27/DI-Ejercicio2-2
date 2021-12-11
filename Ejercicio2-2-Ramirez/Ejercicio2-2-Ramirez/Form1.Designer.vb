<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTrabajador = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoTrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.P_Botones = New System.Windows.Forms.Panel()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.EP_SinNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RD_Trabajador = New System.Windows.Forms.RadioButton()
        Me.RD_Trabajadora = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrALaWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.P_Botones.SuspendLayout()
        CType(Me.EP_SinNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del trabajador"
        '
        'txtTrabajador
        '
        Me.txtTrabajador.Location = New System.Drawing.Point(42, 159)
        Me.txtTrabajador.Name = "txtTrabajador"
        Me.txtTrabajador.Size = New System.Drawing.Size(230, 20)
        Me.txtTrabajador.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.WebToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(323, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoTrabajadorToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoTrabajadorToolStripMenuItem
        '
        Me.NuevoTrabajadorToolStripMenuItem.Name = "NuevoTrabajadorToolStripMenuItem"
        Me.NuevoTrabajadorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoTrabajadorToolStripMenuItem.Text = "Nuevo trabajador"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'P_Botones
        '
        Me.P_Botones.Controls.Add(Me.btn_exit)
        Me.P_Botones.Controls.Add(Me.btn_next)
        Me.P_Botones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.P_Botones.Location = New System.Drawing.Point(0, 284)
        Me.P_Botones.Name = "P_Botones"
        Me.P_Botones.Size = New System.Drawing.Size(323, 61)
        Me.P_Botones.TabIndex = 4
        '
        'btn_exit
        '
        Me.btn_exit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(166, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(157, 61)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(0, 0)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(166, 61)
        Me.btn_next.TabIndex = 0
        Me.btn_next.Text = "Entrar"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'EP_SinNombre
        '
        Me.EP_SinNombre.ContainerControl = Me
        '
        'RD_Trabajador
        '
        Me.RD_Trabajador.AutoSize = True
        Me.RD_Trabajador.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RD_Trabajador.Location = New System.Drawing.Point(42, 185)
        Me.RD_Trabajador.Name = "RD_Trabajador"
        Me.RD_Trabajador.Size = New System.Drawing.Size(110, 25)
        Me.RD_Trabajador.TabIndex = 5
        Me.RD_Trabajador.TabStop = True
        Me.RD_Trabajador.Text = "Trabajador"
        Me.RD_Trabajador.UseVisualStyleBackColor = True
        '
        'RD_Trabajadora
        '
        Me.RD_Trabajadora.AutoSize = True
        Me.RD_Trabajadora.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RD_Trabajadora.Location = New System.Drawing.Point(153, 185)
        Me.RD_Trabajadora.Name = "RD_Trabajadora"
        Me.RD_Trabajadora.Size = New System.Drawing.Size(119, 25)
        Me.RD_Trabajadora.TabIndex = 6
        Me.RD_Trabajadora.TabStop = True
        Me.RD_Trabajadora.Text = "Trabajadora"
        Me.RD_Trabajadora.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Ejercicio2_2_Ramirez.My.Resources.Resources.ugt
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(97, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 104)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
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
        Me.IrALaWebToolStripMenuItem.Text = "Ir a la Web"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(323, 345)
        Me.Controls.Add(Me.RD_Trabajadora)
        Me.Controls.Add(Me.RD_Trabajador)
        Me.Controls.Add(Me.P_Botones)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtTrabajador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.P_Botones.ResumeLayout(False)
        CType(Me.EP_SinNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTrabajador As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoTrabajadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents P_Botones As Panel
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents EP_SinNombre As ErrorProvider
    Friend WithEvents RD_Trabajadora As RadioButton
    Friend WithEvents RD_Trabajador As RadioButton
    Friend WithEvents WebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IrALaWebToolStripMenuItem As ToolStripMenuItem
End Class
