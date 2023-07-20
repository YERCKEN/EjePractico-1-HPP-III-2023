Imports System.Runtime.InteropServices

Public Class P2

    Dim simbolo As String
    Dim contadorDot As Integer = 0
    Private Sub P2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'AGREGASMSO VALORES AL COMBO BOX
        Lista1.Items.AddRange({"Dólares", "Euros", "Yenes", "Pesetas", "Libras"})
        Lista2.Items.AddRange({"Dólares", "Euros", "Yenes", "Pesetas", "Libras"})
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    'LISTA #1 

    Private Sub Lista1_SelectedValueChanged(sender As Object, e As EventArgs) Handles Lista1.SelectedValueChanged



        Select Case (Lista1.Text)

            Case "Euros"
                Lista2.Items.Clear()
                Lista2.Items.AddRange({"Dólares", "Euros"})
            Case "Dólares"
                Lista2.Items.Clear()
                Lista2.Items.AddRange({"Euros", "Dólares", "Yenes", "Pesetas", "Libras"})
            Case "Yenes"
                Lista2.Items.Clear()
                Lista2.Items.AddRange({"Dólares", "Yenes"})
            Case "Pesetas"
                Lista2.Items.Clear()
                Lista2.Items.AddRange({"Dólares", "Pesetas"})
            Case "Libras"
                Lista2.Items.Clear()
                Lista2.Items.AddRange({"Dólares", "Libras"})
        End Select

        Fverificación()

    End Sub

    'LISTA #2
    Private Sub Lista2_SelectedValueChanged(sender As Object, e As EventArgs) Handles Lista2.SelectedValueChanged


        Select Case (Lista2.Text)

            Case "Euros"
                Lista1.Items.Clear()
                Lista1.Items.AddRange({"Dólares", "Euros"})
                simbolo = "€"
            Case "Dólares"

                Lista1.Items.Clear()
                Lista1.Items.AddRange({"Euros", "Dólares", "Yenes", "Pesetas", "Libras"})
                simbolo = "$"
            Case "Yenes"
                Lista1.Items.Clear()
                Lista1.Items.AddRange({"Dólares", "Yenes"})
                simbolo = "¥"
            Case "Pesetas"
                Lista1.Items.Clear()
                Lista1.Items.AddRange({"Dólares", "Pesetas"})
                simbolo = "Pst"
            Case "Libras"
                Lista1.Items.Clear()
                Lista1.Items.AddRange({"Dólares", "Libras"})
                simbolo = "£"
        End Select

        Fverificación()
    End Sub


    'Función verificacion----------------------------------------

    Sub Fverificación()

        If TextBoxValor.Text <> "" Then


            If Lista1.Text <> "" And Lista2.Text <> "" Then

                If (Lista1.Text = "Euros" Or Lista1.Text = "Dólares" Or Lista1.Text = "Yenes" Or Lista1.Text = "Pesetas" Or Lista1.Text = "Libras") Then

                    'MsgBox("ES POSIBLE lista 1")
                    Lista1.BackColor = Color.White

                    If (Lista2.Text = "Euros" Or Lista2.Text = "Dólares" Or Lista2.Text = "Yenes" Or Lista2.Text = "Pesetas" Or Lista2.Text = "Libras") Then
                        'MsgBox("ES POSIBLE lista 2")

                        Lista1.BackColor = Color.White
                        'CALCULO
                        If Lista1.Text = Lista2.Text Then

                            LabelResultado.Text = TextBoxValor.Text & "  " & simbolo
                        Else
                            LabelResultado.Text = fconversionM(Double.Parse(TextBoxValor.Text), Lista1.Text, Lista2.Text) & "  " & simbolo
                        End If



                    Else
                        MessageBox.Show("La opción: ' " & Lista2.Text & " ' No está Disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Lista2.BackColor = Color.FromArgb(255, 222, 222)
                    End If

                Else
                    MessageBox.Show("La opción: ' " & Lista1.Text & " ' No está Disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Lista1.BackColor = Color.FromArgb(255, 222, 222)

                End If

            End If

        Else

        End If
    End Sub

    'TEXBOX ------------------------------------------------------------------------------------
    Private Sub TextBoxValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxValor.KeyPress
        'CANCELACIÓN
        If contadorDot = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then

                TextBoxValor.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                If e.KeyChar = "." Then
                    contadorDot += 1
                End If

                TextBoxValor.BackColor = Color.White

            End If

        Else

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                TextBoxValor.BackColor = Color.FromArgb(255, 222, 222)
                e.Handled = True
                MessageBox.Show("ERROR: Caracter ( " & e.KeyChar & " ) No soportado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                TextBoxValor.BackColor = Color.White
            End If

        End If
    End Sub

    Private Sub TextBoxValor_TextChanged(sender As Object, e As EventArgs) Handles TextBoxValor.TextChanged

        If TextBoxValor.Text.Count(Function(c) c = ".") = 0 And contadorDot = 1 Then
            contadorDot = 0
        Else
            Fverificación()
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