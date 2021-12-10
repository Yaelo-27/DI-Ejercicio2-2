Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Inicio.RD_Trabajador.Checked = True) Then
            L_genero.Text = "Trabajador:"
            L_Nombre.Text = Inicio.txtTrabajador.Text
            pb_avatar.BackgroundImage = My.Resources.trabajador
        End If

        If (Inicio.RD_Trabajadora.Checked = True) Then
            L_genero.Text = "Trabajadora:"
            L_Nombre.Text = Inicio.txtTrabajador.Text
            pb_avatar.BackgroundImage = My.Resources.Trabajadora
        End If


    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Close()
        Inicio.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Inicio.Close()
    End Sub

    Private Sub NuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoTrabajadorToolStripMenuItem.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class