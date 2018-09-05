Imports figuras

Module Test_cuadrado
    Sub main()
        Dim cua1 As New cuadrado("", 0)
        cua1.Nombre = "cuadro"
        cua1.Lado = 20
        Console.WriteLine(cua1.Nombre & " area= " & cua1.CalcularArea)
    End Sub



End Module
