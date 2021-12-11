Public Class Test2_Ciudades
    Dim contador As Integer = 0
    Private Sub btn_Corregir_Click(sender As Object, e As EventArgs) Handles btn_Corregir.Click
        'Pregunta número 1'
        If (rd_preg1_Bruselas.Checked = True) Then
            contador = contador + 1
            rd_preg1_Bruselas.ForeColor = Color.Blue
            rd_preg1_milan.ForeColor = Color.Red
            rd_preg1_paris.ForeColor = Color.Red
        Else
            rd_preg1_Bruselas.ForeColor = Color.Blue
            rd_preg1_milan.ForeColor = Color.Red
            rd_preg1_paris.ForeColor = Color.Red
        End If
        'Pregunta número 2'
        If (rd_preg2_Atenas.Checked = True) Then
            contador = contador + 1
            rd_preg2_Atenas.ForeColor = Color.Blue
            rd_preg2_Roma.ForeColor = Color.Red
            rd_preg2_Tebas.ForeColor = Color.Red
        Else
            rd_preg2_Atenas.ForeColor = Color.Blue
            rd_preg2_Roma.ForeColor = Color.Red
            rd_preg2_Tebas.ForeColor = Color.Red
        End If
        'Pregunta número 3'
        If (rd_preg3_berlin.Checked = True) Then
            contador = contador + 1
            rd_preg3_berlin.ForeColor = Color.Blue
            rd_preg3_Estambul.ForeColor = Color.Red
            rd_preg3_Salonica.ForeColor = Color.Red
        Else
            rd_preg3_berlin.ForeColor = Color.Blue
            rd_preg3_Estambul.ForeColor = Color.Red
            rd_preg3_Salonica.ForeColor = Color.Red
        End If
        'Pregunta número 4'
        If (rd_preg4_Londres.Checked = True) Then
            contador = contador + 1
            rd_preg4_Londres.ForeColor = Color.Blue
            rd_preg4_BuenosAires.ForeColor = Color.Red
            rd_preg4_NuevaYork.ForeColor = Color.Red
        Else
            rd_preg4_Londres.ForeColor = Color.Blue
            rd_preg4_BuenosAires.ForeColor = Color.Red
            rd_preg4_NuevaYork.ForeColor = Color.Red
        End If

        rd_preg1_Bruselas.Enabled = False
        rd_preg1_milan.Enabled = False
        rd_preg1_paris.Enabled = False
        rd_preg2_Atenas.Enabled = False
        rd_preg2_Roma.Enabled = False
        rd_preg2_Tebas.Enabled = False
        rd_preg3_berlin.Enabled = False
        rd_preg3_Estambul.Enabled = False
        rd_preg3_Salonica.Enabled = False
        rd_preg4_Londres.Enabled = False
        rd_preg4_BuenosAires.Enabled = False
        rd_preg4_NuevaYork.Enabled = False

        Dim resultado_test As String = "Usted a conseguido un total de " + contador.ToString() + " puntos"

        MessageBox.Show(resultado_test, "Test Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Form4.Close()
        Form3.Close()
        Form2.Close()
        Inicio.Close()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub NuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoTrabajadorToolStripMenuItem.Click
        Me.Close()
        Form4.Close()
        Form3.Close()
        Form2.Close()
        Inicio.Show()
    End Sub

    Private Sub IrALaWebToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IrALaWebToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.educa2.madrid.org/web/centro.ies.islasfilipinas.madrid")
    End Sub

    Private Sub Test1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem.Click
        Me.Hide()
        Test1_Ciudades.Show()
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

End Class