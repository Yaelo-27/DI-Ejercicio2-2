﻿Public Class Paises
    Private Sub NuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoTrabajadorToolStripMenuItem.Click
        Me.Close()
        Form3.Close()
        Form2.Close()
        Inicio.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Form3.Close()
        Form2.Close()
        Inicio.Close()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Test1_Paises.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Test2_Paises.Show()
    End Sub
End Class