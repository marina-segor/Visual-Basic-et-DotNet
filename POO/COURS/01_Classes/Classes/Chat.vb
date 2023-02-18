Public Class Chat

    ' Les propriétés permettent de respecter le principe de l'encapsulation
    ' Cela permet de protéger la façon dont on utilise l'objet

    ' Propriété auto-implémentée
    ' Créé un membre privé automatiquement 
    ' https://learn.microsoft.com/fr-fr/dotnet/visual-basic/programming-guide/language-features/procedures/auto-implemented-properties
    Public Property Nom As String

    ' Propriété en WriteOnly (Ecriture seule)
    Private _Taille As String
    Public WriteOnly Property Taille() As String
        Set(ByVal value As String)
            _Taille = value
        End Set
    End Property

    ' Propriété en ReadOnly (Lecture seule)
    Private _CouleurYeux As String = "Vert"
    Public ReadOnly Property CouleurYeux() As String
        Get
            Return _CouleurYeux
        End Get
    End Property

    Public Property EstVaccine As Boolean

    Public Sub DetailChat()
        Console.WriteLine($"Nom: {Nom} Taille: {_Taille}cm {vbCrLf}Couleur des yeux: {CouleurYeux} Vacciné: {EstVaccine}")
    End Sub

End Class
