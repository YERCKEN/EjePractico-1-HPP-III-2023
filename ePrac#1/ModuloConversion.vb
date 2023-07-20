Module ModuloConversion

    Public Function fconversionM(ByVal valor As Double, ByVal moneda1 As String, ByVal moneda2 As String) As Double

        '1
        If moneda1 = "Euros" And moneda2 = "Dólares" Then

            Return Math.Round(valor * 1.1064, 2)
            '2
        ElseIf moneda1 = "Dólares" And moneda2 = "Euros" Then

            Return Math.Round(valor / 1.1064, 2)
            '3 
        ElseIf moneda1 = "Dólares" And moneda2 = "Yenes" Then

            Return Math.Round(valor * 134.3, 2)
            '4 
        ElseIf moneda1 = "Yenes" And moneda2 = "Dólares" Then

            Return Math.Round(valor / 134.3, 2)
            '5
        ElseIf moneda1 = "Dólares" And moneda2 = "Pesetas" Then

            Return Math.Round(valor * 150.4, 2)
            '6
        ElseIf moneda1 = "Pesetas" And moneda2 = "Dólares" Then

            Return Math.Round(valor / 150.4, 2)
            '7
        ElseIf moneda1 = "Dólares" And moneda2 = "Libras" Then

            Return Math.Round(valor * 0.7999, 2)

        ElseIf moneda1 = "Libras" And moneda2 = "Dólares" Then

            Return Math.Round(valor / 0.7999, 2)

        End If


    End Function

End Module
