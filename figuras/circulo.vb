Public Class circulo
    Inherits figura
    Private Const pi = 3.14159265
    Private _radio As UShort
    Sub New(nombre As String, radio As UShort)
        MyBase.New(nombre)
        radio = radio

    End Sub
    Public Property Radio As UShort
        Get
            Return _radio

        End Get
        Set(value As UShort)
            _radio = value
        End Set
    End Property
    Public Overrides Function CalcularArea() As Single

        Return pi * (Radio * Radio)

    End Function

End Class
