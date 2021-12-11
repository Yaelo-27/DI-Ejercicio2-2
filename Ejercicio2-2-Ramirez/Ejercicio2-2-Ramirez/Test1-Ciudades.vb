Public Class Test1_Ciudades
    Public contador As Integer = 0
    Private Sub btn_Corregir_Click(sender As Object, e As EventArgs) Handles btn_Corregir.Click
        'Pregunta número 1'
        If (rd_preg1_Moscu.Checked = True) Then
            contador = contador + 1
            rd_preg1_Moscu.ForeColor = Color.Blue
            rd_preg1_estambul.ForeColor = Color.Red
            rd_preg1_sanpet.ForeColor = Color.Red
        Else
            rd_preg1_Moscu.ForeColor = Color.Blue
            rd_preg1_estambul.ForeColor = Color.Red
            rd_preg1_sanpet.ForeColor = Color.Red
        End If
        'Pregunta número 2'
        If (rd_preg2_cadiz.Checked = True) Then
            contador = contador + 1
            rd_preg2_cadiz.ForeColor = Color.Blue
            rd_preg2_Palermo.ForeColor = Color.Red
            rd_preg2_sofia.ForeColor = Color.Red
        Else
            rd_preg2_cadiz.ForeColor = Color.Blue
            rd_preg2_Palermo.ForeColor = Color.Red
            rd_preg2_sofia.ForeColor = Color.Red
        End If
        'Pregunta número 3'
        If (rd_preg3_CiudaddelVaticano.Checked = True) Then
            contador = contador + 1
            rd_preg3_CiudaddelVaticano.ForeColor = Color.Blue
            rd_preg3_interlaken.ForeColor = Color.Red
            rd_preg3_SanMarino.ForeColor = Color.Red
        Else
            rd_preg3_CiudaddelVaticano.ForeColor = Color.Blue
            rd_preg3_interlaken.ForeColor = Color.Red
            rd_preg3_SanMarino.ForeColor = Color.Red
        End If
        'Pregunta número 4'
        If (rd_preg4_paris.Checked = True) Then
            contador = contador + 1
            rd_preg4_paris.ForeColor = Color.Blue
            rd_preg4_madrid.ForeColor = Color.Red
            rd_preg4_SanPetersburgo.ForeColor = Color.Red
        Else
            rd_preg4_paris.ForeColor = Color.Blue
            rd_preg4_madrid.ForeColor = Color.Red
            rd_preg4_SanPetersburgo.ForeColor = Color.Red
        End If

        rd_preg1_Moscu.Enabled = False
        rd_preg1_estambul.Enabled = False
        rd_preg1_sanpet.Enabled = False
        rd_preg2_cadiz.Enabled = False
        rd_preg2_Palermo.Enabled = False
        rd_preg2_sofia.Enabled = False
        rd_preg3_CiudaddelVaticano.Enabled = False
        rd_preg3_interlaken.Enabled = False
        rd_preg4_paris.Enabled = False
        rd_preg4_madrid.Enabled = False
        rd_preg4_SanPetersburgo.Enabled = False

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
        Me.Hide()
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

    Private Sub VolverAMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAMenuToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class