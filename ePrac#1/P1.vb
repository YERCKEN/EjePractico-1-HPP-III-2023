Imports System.Runtime.InteropServices

Public Class P1

    Dim numeros(5), suma, resta, multiplicacion, division, exponentes, mods As Double
    Dim ciclo As Integer = 0
    Dim contadorDot As Integer = 0


    Private Sub P1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        suma = 0
        resta = 0
        multiplicacion = 0
        division = 0
        exponentes = 0
        mods = 0

        LabelNumero.Text = "Número " & (ciclo + 1)

        TextBoxNumero.ForeColor = Color.FromArgb(CByte(120), CByte(127), CByte(130))
    End Sub

    Private Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click

        If TextBoxNumero.Text <> "" Then

            If ciclo < 4 Then

                numeros(ciclo) = Double.Parse(TextBoxNumero.Text)

                'VALORES INICIALES
                If ciclo = 0 Then

                    suma = numeros(ciclo)
                    resta = numeros(ciclo)
                    multiplicacion = numeros(ciclo)
                    division = numeros(ciclo)
                    exponentes = numeros(ciclo)
                    mods = numeros(ciclo)

                    ciclo += 1
                    LabelNumero.Text = "Número " & (ciclo + 1)
                    TextBoxNumero.Clear()
                    'CALCULOS
                Else

                    If ((exponentes ^ numeros(ciclo)) > Double.MaxValue) Or ((multiplicacion * numeros(ciclo)) > Double.MaxValue) Or ((suma + numeros(ciclo)) > Double.MaxValue) Then
                        TextBoxNumero.BackColor = Color.FromArgb(255, 222, 222)

                        MessageBox.Show("EL VALOR INGRESADO PRODUCE UN DESBORDAMIENTO" & vbCrLf & vbCrLf & "MAX DOUBLE: " & Double.MaxValue, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                    ElseIf ((division / numeros(ciclo)) < Double.MinValue) Or ((resta - numeros(ciclo)) < Double.MinValue) Or ((mods Mod numeros(ciclo)) < Double.MinValue) Then
                        TextBoxNumero.BackColor = Color.FromArgb(255, 222, 222)
                        MessageBox.Show("EL VALOR INGRESADO PRODUCE UN DESBORDAMIENTO" & vbCrLf & vbCrLf & "MAX DOUBLE: " & Double.MaxValue, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Else
                        suma += numeros(ciclo)
                        resta -= numeros(ciclo)
                        multiplicacion *= numeros(ciclo)
                        division /= numeros(ciclo)
                        exponentes ^= numeros(ciclo)
                        mods = mods Mod numeros(ciclo)

                        ciclo += 1
                        LabelNumero.Text = "Número " & (ciclo + 1)
                        TextBoxNumero.Clear()
                    End If


                End If




            ElseIf ciclo = 4 Then

                numeros(ciclo) = Double.Parse(TextBoxNumero.Text)

                If ((exponentes ^ numeros(ciclo)) > Double.MaxValue) Or ((multiplicacion * numeros(ciclo)) > Double.MaxValue) Or ((suma + numeros(ciclo)) > Double.MaxValue) Then
                    TextBoxNumero.BackColor = Color.FromArgb(255, 222, 222)
                    MessageBox.Show("EL VALOR INGRESADO PRODUCE UN DESBORDAMIENTO" & vbCrLf & vbCrLf & "MAX DOUBLE: " & Double.MaxValue, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)



                ElseIf ((division / numeros(ciclo)) < Double.MinValue) Or ((resta - numeros(ciclo)) < Double.MinValue) Or ((mods Mod numeros(ciclo)) < Double.MinValue) Then
                    TextBoxNumero.BackColor = Color.FromArgb(255, 222, 222)
                    MessageBox.Show("EL VALOR INGRESADO PRODUCE UN DESBORDAMIENTO" & vbCrLf & vbCrLf & "MAX DOUBLE: " & Double.MaxValue, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                Else

                    suma += numeros(ciclo)
                    resta -= numeros(ciclo)
                    multiplicacion *= numeros(ciclo)
                    division /= numeros(ciclo)
                    exponentes ^= numeros(ciclo)
                    mods = mods Mod numeros(ciclo)

                    MsgBox("VALORES:   " & numeros(0) & " , " & numeros(1) & " , " & numeros(2) & " , " & numeros(3) & " , " & numeros(4) & vbCrLf & "_____________________________________________" & vbCrLf & vbCrLf & "SUMA: " & suma & vbCrLf & vbCrLf & "RESTA: " & resta & vbCrLf & vbCrLf & "MULTIPLICACIÓN: " & multiplicacion & vbCrLf & vbCrLf & "DIVISIÓN: " & division & vbCrLf & vbCrLf & "EXPONENTE: " & exponentes & vbCrLf & vbCrLf & "MOD: " & mods, MsgBoxStyle.Information, "Resultado")


                    TextBoxNumero.Clear()
                    ciclo = 0
                    LabelNumero.Text = "Número " & (ciclo + 1)
                End If

            End If

        End If
    End Sub

    Private Sub TextBoxNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNumero.KeyPress

        'CANCELACIÓN
        If contadorDot = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

                TextBoxNumero.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If e.KeyChar = "." Then
                    contadorDot += 1
                End If

                TextBoxNumero.BackColor = Color.White

            End If

        Else

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                TextBoxNumero.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                TextBoxNumero.BackColor = Color.White
            End If

        End If



    End Sub
    Private Sub TextBoxNumero_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumero.TextChanged
        If TextBoxNumero.Text.Count(Function(c) c = ".") = 0 And contadorDot = 1 Then
            contadorDot = 0

        End If
    End Sub


    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

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