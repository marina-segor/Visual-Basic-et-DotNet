Imports System

Module Program
    Sub Main(args As String())



        ' ##############
        ' # EXERCICE 7 #
        ' ##############



        Console.WriteLine(vbCrLf & " --- Calcul de la longueur de l'hypot�nuse ---" & vbCrLf)

        ' #  D�claration des variables
        Dim premierCote As Double,
        deuxiemeCote,
        sommeDesCarres,
        resultat



        ' #  Recup�ration des saisies utilisateur
        Console.Write(" Entrez la longueur du premier cot� (en cm) : ")
        premierCote = Convert.ToDouble(Console.ReadLine())

        Console.Write(vbCrLf & " Entrez la longueur du deuxi�me cot� (en cm) : ")
        deuxiemeCote = Convert.ToDouble(Console.ReadLine())

        ' sommeDesCarres = premierCote ^ 2 ' Pr�ferer l'utilisation de la classe Math

        ' #  Calcul de l'hypoth�nuse
        sommeDesCarres = Math.Pow(premierCote, 2) + Math.Pow(deuxiemeCote, 2)
        resultat = Math.Round(Math.Sqrt(sommeDesCarres), 2)

        ' #  Affichage des r�sultats
        Console.WriteLine(vbCrLf & $" La longueur de l'hypoth�nuse est {resultat} cm")




        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
