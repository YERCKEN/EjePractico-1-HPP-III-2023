Imports System.Runtime.InteropServices

Public Class Form1
    Private Sub BtnP1_Click(sender As Object, e As EventArgs) Handles BtnP1.Click
        P1.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub PanelBarra_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarra.MouseDown

        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub




    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub LabelTitulo_Click(sender As Object, e As EventArgs) Handles LabelTitulo.Click

    End Sub

    Private Sub BtnP2_Click(sender As Object, e As EventArgs) Handles BtnP2.Click
        P2.Show()
        Me.Hide()
    End Sub





    'Declaración de la función SendMessage
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    'Declaración de la función ReleaseCapture
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub BtnP3_Click(sender As Object, e As EventArgs) Handles BtnP3.Click
        Me.Hide()
        P3.Show()
    End Sub
End Class
