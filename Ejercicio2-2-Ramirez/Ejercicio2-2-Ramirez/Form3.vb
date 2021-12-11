Public Class Form3
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Form2.Close()
        Inicio.Close()
    End Sub

    Private Sub NuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoTrabajadorToolStripMenuItem.Click
        Me.Close()
        cerrarsesiones()
        Form2.Close()
        Inicio.Show()
    End Sub

    Private Sub btnCiudades_Click(sender As Object, e As EventArgs) Handles btnCiudades.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnPaises_Click(sender As Object, e As EventArgs) Handles btnPaises.Click
        Me.Hide()
        Paises.Show()
    End Sub

    Private Sub btnAnimales_Click(sender As Object, e As EventArgs) Handles btnAnimales.Click
        Me.Hide()
        Animales.Show()
    End Sub

    Private Sub btnArte_Click(sender As Object, e As EventArgs) Handles btnArte.Click
        Me.Hide()
        Arte.Show()
    End Sub

    Private Sub btnTecnologia_Click(sender As Object, e As EventArgs) Handles btnTecnologia.Click
        Me.Hide()
        Tecnologia.Show()
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

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
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