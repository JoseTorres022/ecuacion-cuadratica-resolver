Public Class FRM1CUADRATICA
    Dim a, b, c, det As Integer
    Dim raizX1, raizX2 As Single
    Dim noRaices As Integer
    Public Sub FRM1CUADRATICA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Manipulación de controles para mostrar u ocultar al usuario'
        'Labels que al inicio del programa estan ocultos o desactivados'
        LB1_Encabezado.Visible = False
        LB2_CoeficienteA.Visible = False
        LB3_CoeficienteB.Visible = False
        LB4_CoeficienteC.Visible = False
        LB5_NoRaices.Visible = False
        LB6_RaicesSon.Visible = False
        LB7_Yraiz.Visible = False

        'Texboxes que al inicio del programa estan ocultos o desactivados'
        TBOX1_CoeficienteA.Enabled = False
        TBOX1_CoeficienteA.Visible = False

        TBOX2_CoeficienteB.Enabled = False
        TBOX2_CoeficienteB.Visible = False

        TBOX3_CoeficienteC.Enabled = False
        TBOX3_CoeficienteC.Visible = False

        TBOX4_NoRaices.Enabled = False
        TBOX4_NoRaices.Visible = False

        TBOX5_RaizX1.Enabled = False
        TBOX5_RaizX1.Visible = False

        TBOX6_RaizX2.Enabled = False
        TBOX6_RaizX2.Visible = False

    End Sub

    Private Sub BTN2_NuevaEcuacion_Click(sender As Object, e As EventArgs) Handles BTN2_NuevaEcuacion.Click
        'Ponemos todo a valores de cero'
        TBOX1_CoeficienteA.Text = ""
        TBOX2_CoeficienteB.Text = ""
        TBOX3_CoeficienteC.Text = ""
        TBOX4_NoRaices.Text = ""
        TBOX5_RaizX1.Text = ""
        TBOX6_RaizX2.Text = ""

        LB1_Encabezado.Visible = True
        LB2_CoeficienteA.Visible = True
        LB3_CoeficienteB.Visible = True
        LB4_CoeficienteC.Visible = True
        LB5_NoRaices.Visible = True
        LB6_RaicesSon.Visible = True
        LB7_Yraiz.Visible = True

        TBOX1_CoeficienteA.Enabled = True
        TBOX1_CoeficienteA.Visible = True

        TBOX2_CoeficienteB.Enabled = True
        TBOX2_CoeficienteB.Visible = True

        TBOX3_CoeficienteC.Enabled = True
        TBOX3_CoeficienteC.Visible = True

        TBOX4_NoRaices.Enabled = True
        TBOX4_NoRaices.Visible = True

        TBOX5_RaizX1.Enabled = True
        TBOX5_RaizX1.Visible = True

        TBOX6_RaizX2.Enabled = True
        TBOX6_RaizX2.Visible = True
    End Sub

    Private Sub BTN1_ResolverEcuacion_Click(sender As Object, e As EventArgs) Handles BTN1_ResolverEcuacion.Click
        'Asignamos los controles a las varibales correspondientes'
        a = Val(TBOX1_CoeficienteA.Text)
        b = Val(TBOX2_CoeficienteB.Text)
        c = Val(TBOX3_CoeficienteC.Text)

        'Calculamos los valores para las determinantes
        det = (b ^ 2) - (4 * a * c)
        If det > 0 Then
            LB5_NoRaices.Capture = 2
            raizX1 = (-b + Math.Sqrt(det)) / (2 * a)
            raizX2 = (-b - Math.Sqrt(det)) / (2 * a)
            TBOX5_RaizX1.Text = Math.Round(raizX1, 4)
            TBOX6_RaizX2.Text = Math.Round(raizX2, 4)
        ElseIf det = 0 Then
            raizX1 = (-b) / 2 * a
            LB5_NoRaices.Capture = 1
            TBOX5_RaizX1.Text = raizX1

        End If

    End Sub
End Class
