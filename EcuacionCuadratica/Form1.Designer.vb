<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM1CUADRATICA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PICBOX1_Imagen = New System.Windows.Forms.PictureBox()
        Me.LB2_CoeficienteA = New System.Windows.Forms.Label()
        Me.LB3_CoeficienteB = New System.Windows.Forms.Label()
        Me.LB4_CoeficienteC = New System.Windows.Forms.Label()
        Me.TBOX1_CoeficienteA = New System.Windows.Forms.TextBox()
        Me.TBOX2_CoeficienteB = New System.Windows.Forms.TextBox()
        Me.TBOX3_CoeficienteC = New System.Windows.Forms.TextBox()
        Me.LB1_Encabezado = New System.Windows.Forms.Label()
        Me.TBOX4_NoRaices = New System.Windows.Forms.TextBox()
        Me.LB5_NoRaices = New System.Windows.Forms.Label()
        Me.LB6_RaicesSon = New System.Windows.Forms.Label()
        Me.LB7_Yraiz = New System.Windows.Forms.Label()
        Me.TBOX5_RaizX1 = New System.Windows.Forms.TextBox()
        Me.TBOX6_RaizX2 = New System.Windows.Forms.TextBox()
        Me.BTN1_ResolverEcuacion = New System.Windows.Forms.Button()
        Me.BTN2_NuevaEcuacion = New System.Windows.Forms.Button()
        Me.BTN3_CerrarApp = New System.Windows.Forms.Button()
        CType(Me.PICBOX1_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PICBOX1_Imagen
        '
        Me.PICBOX1_Imagen.Image = Global.EcuacionCuadratica.My.Resources.Resources.Factorizacion_ecuacion_cuadratica
        Me.PICBOX1_Imagen.Location = New System.Drawing.Point(95, 12)
        Me.PICBOX1_Imagen.Name = "PICBOX1_Imagen"
        Me.PICBOX1_Imagen.Size = New System.Drawing.Size(654, 225)
        Me.PICBOX1_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PICBOX1_Imagen.TabIndex = 0
        Me.PICBOX1_Imagen.TabStop = False
        '
        'LB2_CoeficienteA
        '
        Me.LB2_CoeficienteA.AutoSize = True
        Me.LB2_CoeficienteA.Location = New System.Drawing.Point(81, 293)
        Me.LB2_CoeficienteA.Name = "LB2_CoeficienteA"
        Me.LB2_CoeficienteA.Size = New System.Drawing.Size(299, 31)
        Me.LB2_CoeficienteA.TabIndex = 1
        Me.LB2_CoeficienteA.Text = "Termino Cuadrádico (a)"
        '
        'LB3_CoeficienteB
        '
        Me.LB3_CoeficienteB.AutoSize = True
        Me.LB3_CoeficienteB.Location = New System.Drawing.Point(148, 337)
        Me.LB3_CoeficienteB.Name = "LB3_CoeficienteB"
        Me.LB3_CoeficienteB.Size = New System.Drawing.Size(232, 31)
        Me.LB3_CoeficienteB.TabIndex = 2
        Me.LB3_CoeficienteB.Text = "Termino Lineal (b)"
        '
        'LB4_CoeficienteC
        '
        Me.LB4_CoeficienteC.AutoSize = True
        Me.LB4_CoeficienteC.Location = New System.Drawing.Point(49, 381)
        Me.LB4_CoeficienteC.Name = "LB4_CoeficienteC"
        Me.LB4_CoeficienteC.Size = New System.Drawing.Size(331, 31)
        Me.LB4_CoeficienteC.TabIndex = 3
        Me.LB4_CoeficienteC.Text = "Termino Independiente (c)"
        '
        'TBOX1_CoeficienteA
        '
        Me.TBOX1_CoeficienteA.Location = New System.Drawing.Point(386, 290)
        Me.TBOX1_CoeficienteA.Name = "TBOX1_CoeficienteA"
        Me.TBOX1_CoeficienteA.Size = New System.Drawing.Size(180, 38)
        Me.TBOX1_CoeficienteA.TabIndex = 4
        '
        'TBOX2_CoeficienteB
        '
        Me.TBOX2_CoeficienteB.Location = New System.Drawing.Point(386, 334)
        Me.TBOX2_CoeficienteB.Name = "TBOX2_CoeficienteB"
        Me.TBOX2_CoeficienteB.Size = New System.Drawing.Size(180, 38)
        Me.TBOX2_CoeficienteB.TabIndex = 5
        '
        'TBOX3_CoeficienteC
        '
        Me.TBOX3_CoeficienteC.Location = New System.Drawing.Point(386, 378)
        Me.TBOX3_CoeficienteC.Name = "TBOX3_CoeficienteC"
        Me.TBOX3_CoeficienteC.Size = New System.Drawing.Size(180, 38)
        Me.TBOX3_CoeficienteC.TabIndex = 6
        '
        'LB1_Encabezado
        '
        Me.LB1_Encabezado.AutoSize = True
        Me.LB1_Encabezado.Location = New System.Drawing.Point(194, 240)
        Me.LB1_Encabezado.Name = "LB1_Encabezado"
        Me.LB1_Encabezado.Size = New System.Drawing.Size(380, 31)
        Me.LB1_Encabezado.TabIndex = 7
        Me.LB1_Encabezado.Text = "Digita los coeficientes a, b y c." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TBOX4_NoRaices
        '
        Me.TBOX4_NoRaices.Location = New System.Drawing.Point(386, 442)
        Me.TBOX4_NoRaices.Name = "TBOX4_NoRaices"
        Me.TBOX4_NoRaices.Size = New System.Drawing.Size(180, 38)
        Me.TBOX4_NoRaices.TabIndex = 8
        '
        'LB5_NoRaices
        '
        Me.LB5_NoRaices.AutoSize = True
        Me.LB5_NoRaices.Location = New System.Drawing.Point(142, 445)
        Me.LB5_NoRaices.Name = "LB5_NoRaices"
        Me.LB5_NoRaices.Size = New System.Drawing.Size(238, 31)
        Me.LB5_NoRaices.TabIndex = 9
        Me.LB5_NoRaices.Text = "Número de Raíces"
        '
        'LB6_RaicesSon
        '
        Me.LB6_RaicesSon.AutoSize = True
        Me.LB6_RaicesSon.Location = New System.Drawing.Point(182, 527)
        Me.LB6_RaicesSon.Name = "LB6_RaicesSon"
        Me.LB6_RaicesSon.Size = New System.Drawing.Size(197, 31)
        Me.LB6_RaicesSon.TabIndex = 10
        Me.LB6_RaicesSon.Text = "Las raíces son:"
        '
        'LB7_Yraiz
        '
        Me.LB7_Yraiz.AutoSize = True
        Me.LB7_Yraiz.Location = New System.Drawing.Point(495, 527)
        Me.LB7_Yraiz.Name = "LB7_Yraiz"
        Me.LB7_Yraiz.Size = New System.Drawing.Size(28, 31)
        Me.LB7_Yraiz.TabIndex = 11
        Me.LB7_Yraiz.Text = "y"
        '
        'TBOX5_RaizX1
        '
        Me.TBOX5_RaizX1.Location = New System.Drawing.Point(385, 524)
        Me.TBOX5_RaizX1.Name = "TBOX5_RaizX1"
        Me.TBOX5_RaizX1.Size = New System.Drawing.Size(100, 38)
        Me.TBOX5_RaizX1.TabIndex = 12
        '
        'TBOX6_RaizX2
        '
        Me.TBOX6_RaizX2.Location = New System.Drawing.Point(529, 524)
        Me.TBOX6_RaizX2.Name = "TBOX6_RaizX2"
        Me.TBOX6_RaizX2.Size = New System.Drawing.Size(100, 38)
        Me.TBOX6_RaizX2.TabIndex = 13
        '
        'BTN1_ResolverEcuacion
        '
        Me.BTN1_ResolverEcuacion.Location = New System.Drawing.Point(114, 598)
        Me.BTN1_ResolverEcuacion.Name = "BTN1_ResolverEcuacion"
        Me.BTN1_ResolverEcuacion.Size = New System.Drawing.Size(159, 71)
        Me.BTN1_ResolverEcuacion.TabIndex = 14
        Me.BTN1_ResolverEcuacion.Text = "Resolver"
        Me.BTN1_ResolverEcuacion.UseVisualStyleBackColor = True
        '
        'BTN2_NuevaEcuacion
        '
        Me.BTN2_NuevaEcuacion.Location = New System.Drawing.Point(325, 598)
        Me.BTN2_NuevaEcuacion.Name = "BTN2_NuevaEcuacion"
        Me.BTN2_NuevaEcuacion.Size = New System.Drawing.Size(147, 71)
        Me.BTN2_NuevaEcuacion.TabIndex = 15
        Me.BTN2_NuevaEcuacion.Text = "Nuevo Problema"
        Me.BTN2_NuevaEcuacion.UseVisualStyleBackColor = True
        '
        'BTN3_CerrarApp
        '
        Me.BTN3_CerrarApp.Location = New System.Drawing.Point(501, 595)
        Me.BTN3_CerrarApp.Name = "BTN3_CerrarApp"
        Me.BTN3_CerrarApp.Size = New System.Drawing.Size(173, 76)
        Me.BTN3_CerrarApp.TabIndex = 16
        Me.BTN3_CerrarApp.Text = "Salir"
        Me.BTN3_CerrarApp.UseVisualStyleBackColor = True
        '
        'FRM1CUADRATICA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 681)
        Me.Controls.Add(Me.BTN3_CerrarApp)
        Me.Controls.Add(Me.BTN2_NuevaEcuacion)
        Me.Controls.Add(Me.BTN1_ResolverEcuacion)
        Me.Controls.Add(Me.TBOX6_RaizX2)
        Me.Controls.Add(Me.TBOX5_RaizX1)
        Me.Controls.Add(Me.LB7_Yraiz)
        Me.Controls.Add(Me.LB6_RaicesSon)
        Me.Controls.Add(Me.LB5_NoRaices)
        Me.Controls.Add(Me.TBOX4_NoRaices)
        Me.Controls.Add(Me.LB1_Encabezado)
        Me.Controls.Add(Me.TBOX3_CoeficienteC)
        Me.Controls.Add(Me.TBOX2_CoeficienteB)
        Me.Controls.Add(Me.TBOX1_CoeficienteA)
        Me.Controls.Add(Me.LB4_CoeficienteC)
        Me.Controls.Add(Me.LB3_CoeficienteB)
        Me.Controls.Add(Me.LB2_CoeficienteA)
        Me.Controls.Add(Me.PICBOX1_Imagen)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.MaximumSize = New System.Drawing.Size(1280, 720)
        Me.MinimumSize = New System.Drawing.Size(854, 480)
        Me.Name = "FRM1CUADRATICA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ecuación Cuadática"
        CType(Me.PICBOX1_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PICBOX1_Imagen As PictureBox
    Friend WithEvents LB2_CoeficienteA As Label
    Friend WithEvents LB3_CoeficienteB As Label
    Friend WithEvents LB4_CoeficienteC As Label
    Friend WithEvents TBOX1_CoeficienteA As TextBox
    Friend WithEvents TBOX2_CoeficienteB As TextBox
    Friend WithEvents TBOX3_CoeficienteC As TextBox
    Friend WithEvents LB1_Encabezado As Label
    Friend WithEvents TBOX4_NoRaices As TextBox
    Friend WithEvents LB5_NoRaices As Label
    Friend WithEvents LB6_RaicesSon As Label
    Friend WithEvents LB7_Yraiz As Label
    Friend WithEvents TBOX5_RaizX1 As TextBox
    Friend WithEvents TBOX6_RaizX2 As TextBox
    Friend WithEvents BTN1_ResolverEcuacion As Button
    Friend WithEvents BTN2_NuevaEcuacion As Button
    Friend WithEvents BTN3_CerrarApp As Button
End Class
