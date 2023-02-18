Imports System

Module Program
    Sub Main(args As String())

        ' Le nombre de chiens est initialisé à 0
        ' Accès un un attribut de classe partagée
        ' <Classe>.<attribut>
        Console.WriteLine(Chien.nombreChiens)

        Dim rex As New Chien("Rex")
        Dim milou As New Chien("Milou")
        Dim lassie As New Chien("Lassie")
        Dim rantanplan As New Chien("rantanplan")

        Console.WriteLine($"Il y a {Chien.nombreChiens} chiens instanciés")

        ' Méthode de classe partagée
        ' <Classe>.<Methode>(<paramètres>)
        Console.WriteLine(Chien.AgeHumainVersChien(12))

        ' Accès à une propriété partagée de la classe
        ' <Classe>.<Propriété>
        Chien.NomLatin = "Canis"

        Console.WriteLine(Chien.NomLatin)



    End Sub
End Module
