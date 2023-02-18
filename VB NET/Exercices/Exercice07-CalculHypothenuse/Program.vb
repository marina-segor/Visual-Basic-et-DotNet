Imports System

Module Program
    Sub Main(args As String())



        ' ##############
        ' # EXERCICE 7 #
        ' ##############



        Console.WriteLine(vbCrLf & " --- Calcul de la longueur de l'hypoténuse ---" & vbCrLf)

        ' #  Déclaration des variables
        Dim premierCote As Double,
        deuxiemeCote,
        sommeDesCarres,
        resultat



        ' #  Recupération des saisies utilisateur
        Console.Write(" Entrez la longueur du premier coté (en cm) : ")
        premierCote = Convert.ToDouble(Console.ReadLine())

        Console.Write(vbCrLf & " Entrez la longueur du deuxième coté (en cm) : ")
        deuxiemeCote = Convert.ToDouble(Console.ReadLine())

        ' sommeDesCarres = premierCote ^ 2 ' Préferer l'utilisation de la classe Math

        ' #  Calcul de l'hypothénuse
        sommeDesCarres = Math.Pow(premierCote, 2) + Math.Pow(deuxiemeCote, 2)
        resultat = Math.Round(Math.Sqrt(sommeDesCarres), 2)

        ' #  Affichage des résultats
        Console.WriteLine(vbCrLf & $" La longueur de l'hypothénuse est {resultat} cm")




        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
