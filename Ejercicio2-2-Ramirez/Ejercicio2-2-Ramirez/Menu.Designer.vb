﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.P_Botones = New System.Windows.Forms.Panel()
        Me.P_Avatar = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoTrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntuacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IrALaWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.P_Bienvenida = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_Nombre = New System.Windows.Forms.Label()
        Me.L_genero = New System.Windows.Forms.Label()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.btn_Test = New System.Windows.Forms.Button()
        Me.pb_avatar = New System.Windows.Forms.PictureBox()
        Me.P_Botones.SuspendLayout()
        Me.P_Avatar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.P_Bienvenida.SuspendLayout()
        CType(Me.pb_avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_Botones
        '
        Me.P_Botones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P_Botones.Controls.Add(Me.btn_Salir)
        Me.P_Botones.Controls.Add(Me.btn_Volver)
        Me.P_Botones.Controls.Add(Me.btn_Test)
        Me.P_Botones.Controls.Add(Me.P_Avatar)
        Me.P_Botones.Dock = System.Windows.Forms.DockStyle.Left
        Me.P_Botones.Location = New System.Drawing.Point(0, 24)
        Me.P_Botones.Name = "P_Botones"
        Me.P_Botones.Size = New System.Drawing.Size(200, 426)
        Me.P_Botones.TabIndex = 0
        '
        'P_Avatar
        '
        Me.P_Avatar.Controls.Add(Me.pb_avatar)
        Me.P_Avatar.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Avatar.Location = New System.Drawing.Point(0, 0)
        Me.P_Avatar.Name = "P_Avatar"
        Me.P_Avatar.Size = New System.Drawing.Size(198, 127)
        Me.P_Avatar.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.TestToolStripMenuItem, Me.WebToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoTrabajadorToolStripMenuItem, Me.PuntuacionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoTrabajadorToolStripMenuItem
        '
        Me.NuevoTrabajadorToolStripMenuItem.Name = "NuevoTrabajadorToolStripMenuItem"
        Me.NuevoTrabajadorToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.NuevoTrabajadorToolStripMenuItem.Text = "Nuevo Trabajador"
        '
        'PuntuacionesToolStripMenuItem
        '
        Me.PuntuacionesToolStripMenuItem.Name = "PuntuacionesToolStripMenuItem"
        Me.PuntuacionesToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PuntuacionesToolStripMenuItem.Text = "Puntuaciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
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
        Me.IrALaWebToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.IrALaWebToolStripMenuItem.Text = "Ir a la web"
        '
        'P_Bienvenida
        '
        Me.P_Bienvenida.Controls.Add(Me.L_genero)
        Me.P_Bienvenida.Controls.Add(Me.L_Nombre)
        Me.P_Bienvenida.Controls.Add(Me.Label1)
        Me.P_Bienvenida.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Bienvenida.Location = New System.Drawing.Point(200, 24)
        Me.P_Bienvenida.Name = "P_Bienvenida"
        Me.P_Bienvenida.Size = New System.Drawing.Size(600, 134)
        Me.P_Bienvenida.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido!!! "
        '
        'L_Nombre
        '
        Me.L_Nombre.AutoSize = True
        Me.L_Nombre.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Nombre.Location = New System.Drawing.Point(330, 55)
        Me.L_Nombre.Name = "L_Nombre"
        Me.L_Nombre.Size = New System.Drawing.Size(123, 42)
        Me.L_Nombre.TabIndex = 1
        Me.L_Nombre.Text = "Label2"
        '
        'L_genero
        '
        Me.L_genero.AutoSize = True
        Me.L_genero.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_genero.Location = New System.Drawing.Point(103, 55)
        Me.L_genero.Name = "L_genero"
        Me.L_genero.Size = New System.Drawing.Size(123, 42)
        Me.L_genero.TabIndex = 2
        Me.L_genero.Text = "Label2"
        '
        'btn_Salir
        '
        Me.btn_Salir.BackgroundImage = Global.Ejercicio2_2_Ramirez.My.Resources.Resources.salir
        Me.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Salir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Salir.FlatAppearance.BorderSize = 0
        Me.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_Salir.Location = New System.Drawing.Point(0, 295)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(198, 84)
        Me.btn_Salir.TabIndex = 3
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'btn_Volver
        '
        Me.btn_Volver.BackgroundImage = Global.Ejercicio2_2_Ramirez.My.Resources.Resources.volver
        Me.btn_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Volver.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Volver.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Volver.FlatAppearance.BorderSize = 0
        Me.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Volver.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Volver.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_Volver.Location = New System.Drawing.Point(0, 211)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.Size = New System.Drawing.Size(198, 84)
        Me.btn_Volver.TabIndex = 2
        Me.btn_Volver.UseVisualStyleBackColor = True
        '
        'btn_Test
        '
        Me.btn_Test.BackgroundImage = Global.Ejercicio2_2_Ramirez.My.Resources.Resources.test
        Me.btn_Test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Test.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Test.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_Test.FlatAppearance.BorderSize = 0
        Me.btn_Test.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Test.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Test.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_Test.Location = New System.Drawing.Point(0, 127)
        Me.btn_Test.Name = "btn_Test"
        Me.btn_Test.Size = New System.Drawing.Size(198, 84)
        Me.btn_Test.TabIndex = 1
        Me.btn_Test.UseVisualStyleBackColor = True
        '
        'pb_avatar
        '
        Me.pb_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pb_avatar.Location = New System.Drawing.Point(4, 2)
        Me.pb_avatar.Name = "pb_avatar"
        Me.pb_avatar.Size = New System.Drawing.Size(191, 119)
        Me.pb_avatar.TabIndex = 0
        Me.pb_avatar.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.P_Bienvenida)
        Me.Controls.Add(Me.P_Botones)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Menu"
        Me.P_Botones.ResumeLayout(False)
        Me.P_Avatar.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.P_Bienvenida.ResumeLayout(False)
        Me.P_Bienvenida.PerformLayout()
        CType(Me.pb_avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents P_Botones As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoTrabajadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PuntuacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IrALaWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_Test As Button
    Friend WithEvents P_Avatar As Panel
    Friend WithEvents btn_Salir As Button
    Friend WithEvents btn_Volver As Button
    Friend WithEvents P_Bienvenida As Panel
    Friend WithEvents L_Nombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents L_genero As Label
    Friend WithEvents pb_avatar As PictureBox
End Class
