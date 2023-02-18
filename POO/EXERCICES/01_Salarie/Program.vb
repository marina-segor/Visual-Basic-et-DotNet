Imports System

Module Program
    Sub Main(args As String())

        Dim monSalarie As New Salarie()

        ' Setter
        ' Affectation d'une valeur
        monSalarie.Salaire = 1300

        Console.WriteLine(monSalarie.Salaire) ' 1300

        monSalarie.Salaire = 1000 ' < Salaire actuel

        Console.WriteLine(monSalarie.Salaire) ' 1300

        ' utilisation d'une méthode pour le setter (même chose qu'une property)
        monSalarie.SetSalaire(1500)

        ' Getter
        ' Récupérer une valeur
        Console.WriteLine(monSalarie.Salaire) ' 1500

        ' utilisation d'une méthode pour le getter (même chose qu'une property)
        Console.WriteLine(monSalarie.GetSalaire()) ' 1500

        monSalarie.Age = 20
        monSalarie.Age = -2

        monSalarie.Prenom = "Arthur"
        monSalarie.Nom = "LeBoGoss"

        monSalarie.AfficherInformation()


        Console.WriteLine("Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module
