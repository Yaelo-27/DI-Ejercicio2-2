Public Class Form3
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Form2.Close()
        Inicio.Close()
    End Sub

    Private Sub NuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoTrabajadorToolStripMenuItem.Click
        Me.Close()
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
End Class