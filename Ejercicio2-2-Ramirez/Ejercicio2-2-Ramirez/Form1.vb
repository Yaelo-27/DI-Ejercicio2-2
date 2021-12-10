Public Class Inicio
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        If (txtTrabajador.Text = "") Then
            EP_SinNombre.SetError(Me.txtTrabajador, "Falta un nombre de trabajador")
        Else
            Me.Hide()

        End If
    End Sub
End Class
