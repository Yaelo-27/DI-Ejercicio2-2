Public Class Test2_Animales
    Public contador As Integer = 0
    Private Sub btn_Corregir_Click(sender As Object, e As EventArgs) Handles btn_Corregir.Click
        'Pregunta número 1'
        If (rd_preg1_a.Checked = True) Then
            contador = contador + 1
            rd_preg1_a.ForeColor = Color.Blue
            rd_preg1_b.ForeColor = Color.Red
            rd_preg1_c.ForeColor = Color.Red
        Else
            rd_preg1_a.ForeColor = Color.Blue
            rd_preg1_b.ForeColor = Color.Red
            rd_preg1_c.ForeColor = Color.Red
        End If
        'Pregunta número 2'
        If (rd_preg2_a.Checked = True) Then
            contador = contador + 1
            rd_preg2_a.ForeColor = Color.Blue
            rd_preg2_b.ForeColor = Color.Red
            rd_preg2_c.ForeColor = Color.Red
        Else
            rd_preg2_a.ForeColor = Color.Blue
            rd_preg2_b.ForeColor = Color.Red
            rd_preg2_c.ForeColor = Color.Red
        End If
        'Pregunta número 3'
        If (rd_preg3_a.Checked = True) Then
            contador = contador + 1
            rd_preg3_a.ForeColor = Color.Blue
            rd_preg3_b.ForeColor = Color.Red
            rd_preg3_c.ForeColor = Color.Red
        Else
            rd_preg3_a.ForeColor = Color.Blue
            rd_preg3_b.ForeColor = Color.Red
            rd_preg3_c.ForeColor = Color.Red
        End If
        'Pregunta número 4'
        If (rd_perg4_c.Checked = True) Then
            contador = contador + 1
            rd_perg4_a.ForeColor = Color.Red
            rd_perg4_b.ForeColor = Color.Red
            rd_perg4_c.ForeColor = Color.Blue
        Else
            rd_perg4_a.ForeColor = Color.Red
            rd_perg4_b.ForeColor = Color.Red
            rd_perg4_c.ForeColor = Color.Blue
        End If

        rd_preg1_a.Enabled = False
        rd_preg1_b.Enabled = False
        rd_preg1_c.Enabled = False
        rd_preg2_a.Enabled = False
        rd_preg2_b.Enabled = False
        rd_preg2_c.Enabled = False
        rd_preg3_a.Enabled = False
        rd_preg3_b.Enabled = False
        rd_preg3_c.Enabled = False
        rd_perg4_a.Enabled = False
        rd_perg4_b.Enabled = False
        rd_perg4_c.Enabled = False

        Dim resultado_test As String = "Usted a conseguido un total de " + contador.ToString() + " puntos"

        MessageBox.Show(resultado_test, "Test Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        Animales.Close()
        Form3.Close()
        Form2.Close()
        Inicio.Close()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverToolStripMenuItem.Click
        Me.Hide()
        Animales.Show()
    End Sub

    Private Sub NuevoTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoTrabajadorToolStripMenuItem.Click
        Me.Close()
        Animales.Close()
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

    Private Sub VolverAMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAMenuToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class