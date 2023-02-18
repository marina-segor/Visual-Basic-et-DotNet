Imports System

Module Program
    Sub Main(args As String())

        ' ##############
        ' # EXERCICE 9 #
        ' ##############

        Console.OutputEncoding = System.Text.Encoding.UTF8


        Console.WriteLine(vbCrLf & " ------------ Calcul des intérêts ------------" & vbCrLf)

        ' #  Déclaration des variables
        Dim capitalDepart As Double, tauxInteret, duree, capitalFinal, interets


        ' #  Récupération des saisies utilisateur
        Console.Write(" Entrez Capital de départ (en €) : ")
        capitalDepart = Convert.ToDouble(Console.ReadLine())

        Console.Write(vbCrLf & " Entrez le taux d'intérêt (en %) : ")
        tauxInteret = Convert.ToDouble(Console.ReadLine())

        Console.Write(vbCrLf & " Entrez la durée de l'épargne (en années) : ")
        duree = Convert.ToDouble(Console.ReadLine())


        ' #  Calcul des Intérêts et du Capital Final
        capitalFinal = Math.Round(capitalDepart * Math.Pow(1 + (tauxInteret / 100), duree), 2)
        interets = Math.Round(capitalFinal - capitalDepart, 2)



        ' #  Affichage des résultats
        ' Console.WriteLine(vbCrLf & " Le montant des intérêts sera de " + Math.Round(Math.Round(capitalDepart * Math.Pow(1 + (tauxInteret / 100), duree), 2) - capitalDepart, 2) + "euros après " + duree + " ans.\n" + "Le capital final sera de " + Math.Round(capitalDepart * Math.Pow(1 + (tauxInteret / 100), duree), 2) + "euros.\n")
        Console.WriteLine(vbCrLf & " Dans " + duree.ToString + " ans :")
        Console.WriteLine(" Le montant des intérêts sera de " + interets.ToString + " €.")
        Console.WriteLine(" Le capital final sera de " + capitalFinal.ToString + " €." & vbCrLf)


        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
