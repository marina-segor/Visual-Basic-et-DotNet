Public Class Chien

    ' Attributs d'instance
    Public nom As String
    Public age As Integer
    Private _couleur As String

    ' Méthode d'instance
    Public Sub Aboyer()
        Console.WriteLine("Woof woof")
    End Sub

    Public Sub SePresenter()
        Console.WriteLine($"Je m'apelle {nom} et j'ai {age} ans")
    End Sub

    Public Property Couleur() As String
        ' Accesseur ou Getter
        Get
            Console.WriteLine("Je suis dans le getter")
            Return _couleur.ToUpper()
        End Get
        ' Mutateur ou Setter
        Set(ByVal value As String)
            Console.WriteLine("Je suis dans le setter")
            _couleur = value
        End Set
    End Property

End Class
