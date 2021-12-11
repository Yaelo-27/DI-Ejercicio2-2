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
        Form5.Show()
    End Sub

    Private Sub btnAnimales_Click(sender As Object, e As EventArgs) Handles btnAnimales.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub btnArte_Click(sender As Object, e As EventArgs) Handles btnArte.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub btnTecnologia_Click(sender As Object, e As EventArgs) Handles btnTecnologia.Click
        Me.Hide()
        Form8.Show()
    End Sub
End Class