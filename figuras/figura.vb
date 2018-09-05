Public Class figura
    Private _nombre As String
    Sub New(nombre As String)
        nombre = nombre
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Overridable Function CalcularArea() As Single
        Return 0
    End Function


End Class
