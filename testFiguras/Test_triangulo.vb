Imports figuras

Module Test_triangulo
    Sub main()
        Dim tri1 As New triangulo("", 0, 0)
        tri1.Nombre = "puntas"
        tri1.Base = 20
        tri1.Altura = 10
        Console.WriteLine(tri1.Nombre & " area= " & tri1.CalcularArea)
    End Sub


End Module
