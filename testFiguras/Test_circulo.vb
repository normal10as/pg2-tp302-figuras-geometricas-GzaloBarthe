Imports figuras
Module Test_circulo
    Sub main()
        Dim circu1 As New circulo("", 0)
        circu1.Nombre = "redondito"
        circu1.Radio = 12
        Console.WriteLine(circu1.Nombre & " area= " & circu1.CalcularArea)
    End Sub
    

End Module
