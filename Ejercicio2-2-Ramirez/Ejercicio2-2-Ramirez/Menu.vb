Public Class Form2
    Dim contador_ciudades As Integer
    Dim contador_paises As Integer
    Dim contador_arte As Integer
    Dim contador_tec As Integer
    Dim contador_animales As Integer
    Dim contador_general As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Inicio.RD_Trabajador.Checked = True) Then
            L_genero.Text = "Trabajador:"
            L_Nombre.Text = Inicio.txtTrabajador.Text
            L_Correo.Text = Inicio.txtTrabajador.Text + "@Empresa.com"
            pb_avatar.BackgroundImage = My.Resources.trabajador
        End If

        If (Inicio.RD_Trabajadora.Checked = True) Then
            L_genero.Text = "Trabajadora:"
            L_Nombre.Text = Inicio.txtTrabajador.Text
            L_Correo.Text = Inicio.txtTrabajador.Text + "@Empresa.com"
            pb_avatar.BackgroundImage = My.Resources.Trabajadora
        End If

    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
        cerrarsesiones()
        Inicio.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Inicio.Close()
    End Sub

    Private Sub NuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoTrabajadorToolStripMenuItem.Click
        Me.Close()
        cerrarsesiones()
        Inicio.Show()
    End Sub

    Private Sub btn_Test_Click(sender As Object, e As EventArgs) Handles btn_Test.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub IrALaWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IrALaWebToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.educa2.madrid.org/web/centro.ies.islasfilipinas.madrid")
    End Sub

    Private Sub Test1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem.Click
        Me.Hide()
        Test1_Ciudades.Show()
    End Sub

    Private Sub Test2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test2ToolStripMenuItem.Click
        Me.Hide()
        Test2_Ciudades.Show()
    End Sub

    Private Sub Test1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem1.Click
        Me.Hide()
        Test1_Paises.Show()
    End Sub

    Private Sub Test2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Test2ToolStripMenuItem1.Click
        Me.Hide()
        Test2_Paises.Show()
    End Sub

    Private Sub Test1ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem2.Click
        Me.Hide()
        Test1_Animales.Show()
    End Sub

    Private Sub Test2ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Test2ToolStripMenuItem2.Click
        Me.Hide()
        Test2_Animales.Show()
    End Sub

    Private Sub Test1ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem3.Click
        Me.Hide()
        Test1_Arte.Show()
    End Sub

    Private Sub Test2ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Test2ToolStripMenuItem3.Click
        Me.Hide()
        Test2_Arte.Show()
    End Sub

    Private Sub Test1ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem4.Click
        Me.Hide()
        Test1_Tec.Show()
    End Sub

    Private Sub Test2ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles Test2ToolStripMenuItem4.Click
        Me.Hide()
        Test2_Tec.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contador_ciudades = Test1_Ciudades.contador + Test2_Ciudades.contador
        contador_animales = Test1_Animales.contador + Test2_Animales.contador
        contador_paises = Test1_Paises.contador + Test2_Paises.contador
        contador_arte = Test1_Arte.contador + Test2_Arte.contador
        contador_tec = Test1_Tec.contador + Test2_Tec.contador
        contador_general = contador_animales + contador_arte + contador_ciudades + contador_paises + contador_tec
        L_puntos.Text = contador_general.ToString()
    End Sub

    Private Sub cerrarsesiones()
        Test1_Animales.Close()
        Test1_Arte.Close()
        Test1_Ciudades.Close()
        Test1_Paises.Close()
        Test1_Tec.Close()
        Test2_Animales.Close()
        Test2_Arte.Close()
        Test2_Ciudades.Close()
        Test2_Paises.Close()
        Test2_Tec.Close()
    End Sub


End Class