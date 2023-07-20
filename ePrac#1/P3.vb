Imports System.Runtime.InteropServices

Public Class P3
    Dim contadorDot As Integer = 0
    Dim cantidadC, cantidadL, CantidadN, precioUC, precioUL, precioUN As Double

    'BOTON CERRAR---------------------------------------------
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    'CAMBIO EN LA DROP BOX
    Private Sub Lista1_SelectedValueChanged(sender As Object, e As EventArgs) Handles Lista1.SelectedValueChanged

        If Lista1.Text = "R. Cola" Then
            TextBoxCantidad.Text = cantidadC
            TextBoxPrecioU.Text = precioUC

            PictureBox1.BackgroundImage = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\3. LABORATORIOS PRÁCTICOS\EJERCICIO PRÁCTICO #1\EJERCICIO PRÁCTICO #1 V2\EJERCICIO PRÁCTICO #1\EjerPractico#1\ePrac#1\ePrac#1\Resources\cola1.png")

        ElseIf Lista1.Text = "R. Limón" Then

            TextBoxCantidad.Text = cantidadL
            TextBoxPrecioU.Text = precioUL
            PictureBox1.BackgroundImage = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\3. LABORATORIOS PRÁCTICOS\EJERCICIO PRÁCTICO #1\EJERCICIO PRÁCTICO #1 V2\EJERCICIO PRÁCTICO #1\EjerPractico#1\ePrac#1\ePrac#1\Resources\limon.png")

        ElseIf Lista1.Text = "R. Naranja" Then

            TextBoxCantidad.Text = CantidadN
            TextBoxPrecioU.Text = precioUN
            PictureBox1.BackgroundImage = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\3. LABORATORIOS PRÁCTICOS\EJERCICIO PRÁCTICO #1\EJERCICIO PRÁCTICO #1 V2\EJERCICIO PRÁCTICO #1\EjerPractico#1\ePrac#1\ePrac#1\Resources\NARANja.png")
        Else
            MessageBox.Show("OPCION NO DISPONIBLE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        TextBoxCantidad.Enabled = True
        TextBoxPrecioU.Enabled = True
        BtnIngresar.Enabled = True

        TextBoxPrecioU.BackColor = Color.White
        TextBoxCantidad.BackColor = Color.White
    End Sub

    'CARGA
    Private Sub P3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxCantidad.Enabled = False
        TextBoxPrecioU.Enabled = False
        BtnIngresar.Enabled = False

        cantidadC = 0
        cantidadL = 0
        CantidadN = 0
        precioUC = 0
        precioUL = 0
        precioUN = 0
        PanelResultado.Visible = False
        BtnCalcular.Visible = False

    End Sub

    'CONTROL CANTIDAD 
    Private Sub TextBoxCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCantidad.KeyPress
        'CANCELACIÓN


        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            TextBoxCantidad.BackColor = Color.FromArgb(255, 222, 222)
            e.Handled = True
            MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            If e.KeyChar = "." Then
                contadorDot += 1
            End If

            TextBoxCantidad.BackColor = Color.White

        End If

    End Sub

    Private Sub TextBoxPrecioU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPrecioU.KeyPress

        If contadorDot = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

                TextBoxPrecioU.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If e.KeyChar = "." Then
                    contadorDot += 1
                End If

                TextBoxPrecioU.BackColor = Color.White

            End If

        Else

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                TextBoxPrecioU.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                TextBoxPrecioU.BackColor = Color.White
            End If

        End If
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If TextBoxCantidad.Text <> "" Then

            If TextBoxPrecioU.Text <> "" Then

                If Integer.Parse(TextBoxCantidad.Text) >= 0 And Integer.Parse(TextBoxCantidad.Text) <= 5000000 Then

                    'COLA
                    If Lista1.Text = "R. Cola" Then

                        cantidadC = Integer.Parse(TextBoxCantidad.Text)
                        precioUC = Double.Parse(TextBoxPrecioU.Text)
                        TextBoxPrecioU.BackColor = Color.FromArgb(207, 255, 235)
                        TextBoxCantidad.BackColor = Color.FromArgb(207, 255, 235)
                        BtnCalcular.Visible = True

                        'LIMON
                    ElseIf Lista1.Text = "R. Limón" Then

                        cantidadL = Integer.Parse(TextBoxCantidad.Text)
                        precioUL = Double.Parse(TextBoxPrecioU.Text)
                        TextBoxPrecioU.BackColor = Color.FromArgb(207, 255, 235)
                        TextBoxCantidad.BackColor = Color.FromArgb(207, 255, 235)
                        BtnCalcular.Visible = True

                        'NARANJA
                    ElseIf Lista1.Text = "R. Naranja" Then

                        CantidadN = Integer.Parse(TextBoxCantidad.Text)
                        precioUN = Double.Parse(TextBoxPrecioU.Text)
                        TextBoxPrecioU.BackColor = Color.FromArgb(207, 255, 235)
                        TextBoxCantidad.BackColor = Color.FromArgb(207, 255, 235)
                        BtnCalcular.Visible = True

                    Else
                        MessageBox.Show("ERROR: Opcion( " & Lista1.Text & " ) No DHsponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                Else
                    TextBoxCantidad.BackColor = Color.FromArgb(255, 222, 222)
                    MessageBox.Show("ERROR: ( " & TextBoxCantidad.Text & " ) Sobrepasa el Límite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Else
                TextBoxPrecioU.BackColor = Color.FromArgb(255, 222, 222)
            End If
        Else
            TextBoxCantidad.BackColor = Color.FromArgb(255, 222, 222)
        End If
    End Sub


    'CÁLCULO
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        'DESABILITACIÓN
        PanelResultado.Visible = True
        PanelEntrada.Visible = False

        'MOSTRAR RESUSTADO
        LabelVentasC.Text = cantidadC
        LabelPrecioC.Text = Math.Round(precioUC, 2)
        LabelTotalC.Text = Math.Round((precioUC * cantidadC), 2)

        LabelVentasL.Text = cantidadL
        LabelPrecioL.Text = Math.Round(precioUL, 2)
        LabelTotalL.Text = Math.Round((precioUL * cantidadL), 2)


        LabelVentasN.Text = CantidadN
        LabelPrecioN.Text = Math.Round(precioUN, 2)
        LabelTotalN.Text = Math.Round((precioUN * CantidadN), 2)

        LabelTotal.Text = Math.Round(((precioUC * cantidadC) + (precioUL * cantidadL) + (precioUN * CantidadN)), 2)



    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        PanelResultado.Visible = False
        PanelEntrada.Visible = True

        'nuevos valores

        cantidadC = 0
        cantidadL = 0
        CantidadN = 0
        precioUC = 0
        precioUL = 0
        precioUN = 0
        Lista1.Text = ""
        TextBoxCantidad.Text = ""
        TextBoxPrecioU.Text = ""
        TextBoxCantidad.BackColor = Color.White
        TextBoxPrecioU.BackColor = Color.White

        BtnCalcular.Visible = False

        'MOSTRAR RESUSTADO
        LabelVentasC.Text = ""
        LabelPrecioC.Text = ""
        LabelTotalC.Text = ""

        LabelVentasL.Text = ""
        LabelPrecioL.Text = ""
        LabelTotalL.Text = ""


        LabelVentasN.Text = ""
        LabelPrecioN.Text = ""
        LabelTotalN.Text = ""
        LabelTotal.Text = ""


    End Sub

    Private Sub TextBoxPrecioU_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrecioU.TextChanged


        If TextBoxPrecioU.Text.Count(Function(c) c = ".") = 0 And contadorDot = 1 Then
            contadorDot = 0

        End If
    End Sub

    'MOVIMIENTO----------------------------------------------------------------------------------------------------------------------------------

    Private Sub PanelBarra_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarra.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub


    'Declaración de la función SendMessage
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    'Declaración de la función ReleaseCapture
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function


End Class