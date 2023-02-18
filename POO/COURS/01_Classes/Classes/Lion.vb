Public Class Lion
    Public Property Nom As String
    Public Property Couleur As String
    Public Property Age As Integer
    Public Property NombreDents As Integer

    ' Un constructeur est défini avec la méthode New()
    Public Sub New()
        Nom = "Inconnu"
        Couleur = "Transparent"
        Age = 0
        NombreDents = 4
    End Sub

    ' Il est possible de définir plusieurs constructeurs
    ' Cela est dû au Polymorphisme Ad Hoc
    Public Sub New(nom As String)
        Me.Nom = nom
    End Sub


    Public Sub New(nom As String, couleur As String, age As Integer, nombreDents As Integer)
        Me.Nom = nom
        Me.Couleur = couleur
        Me.Age = age
        Me.NombreDents = nombreDents
    End Sub

    Public Sub AfficherLion()
        Console.WriteLine("Nom " & Nom)
        Console.WriteLine("Couleur " & Couleur)
        Console.WriteLine("Age " & Age)
        Console.WriteLine("Nombre dents " & NombreDents)
    End Sub
End Class
