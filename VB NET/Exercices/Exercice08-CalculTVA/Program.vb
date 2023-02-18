Imports System

Module Program
    Sub Main(args As String())
        ' ##############
        ' # EXERCICE 8 #
        ' ##############


        Console.WriteLine(vbCrLf & " --------------- Calcul de la T.V.A ---------------" & vbCrLf)


        ' #  Déclaration des variables
        Dim prixObjetHt As Double, tauxTva, mtTva, prixObjetTtc



        ' #  Récupération des saisies utilisateur
        Console.Write(" Entrez le prix HT de l'objet (en Euros) : ")
        prixObjetHt = Convert.ToDouble(Console.ReadLine())

        Console.Write(vbCrLf & " Entrez le taux de TVA (en %) : ")
        tauxTva = Convert.ToDouble(Console.ReadLine())



        ' #  Calcul du montant de la T.V.A et du prix T.T.C
        mtTva = Math.Round(prixObjetHt * tauxTva / 100, 2)
        prixObjetTtc = Math.Round(prixObjetHt + mtTva, 2)



        ' #  Affichage des résultats
        Console.WriteLine(vbCrLf & " Le montant de la T.V.A est de " + mtTva.ToString + " Euros")
        Console.WriteLine(vbCrLf & " Le prix TTC de l'objet est de " + prixObjetTtc.ToString + " Euros" & vbCrLf)





        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
