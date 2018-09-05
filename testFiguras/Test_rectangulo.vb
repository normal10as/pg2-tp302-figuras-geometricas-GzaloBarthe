Imports figuras

Module Test_rectangulo
    Sub main()
        Dim rect1 As New rectangulo("", 0, 0)
        rect1.Nombre = "rectangulillo"
        rect1.Base = 20
        rect1.Altura = 10
        Console.WriteLine(rect1.Nombre & " area= " & rect1.CalcularArea)
    End Sub

End Module
