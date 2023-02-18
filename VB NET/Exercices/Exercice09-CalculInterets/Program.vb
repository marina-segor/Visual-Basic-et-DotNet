Imports System

Module Program
    Sub Main(args As String())

        ' ##############
        ' # EXERCICE 9 #
        ' ##############

        Console.OutputEncoding = System.Text.Encoding.UTF8


        Console.WriteLine(vbCrLf & " ------------ Calcul des int�r�ts ------------" & vbCrLf)

        ' #  D�claration des variables
        Dim capitalDepart As Double, tauxInteret, duree, capitalFinal, interets


        ' #  R�cup�ration des saisies utilisateur
        Console.Write(" Entrez Capital de d�part (en �) : ")
        capitalDepart = Convert.ToDouble(Console.ReadLine())

        Console.Write(vbCrLf & " Entrez le taux d'int�r�t (en %) : ")
        tauxInteret = Convert.ToDouble(Console.ReadLine())

        Console.Write(vbCrLf & " Entrez la dur�e de l'�pargne (en ann�es) : ")
        duree = Convert.ToDouble(Console.ReadLine())


        ' #  Calcul des Int�r�ts et du Capital Final
        capitalFinal = Math.Round(capitalDepart * Math.Pow(1 + (tauxInteret / 100), duree), 2)
        interets = Math.Round(capitalFinal - capitalDepart, 2)



        ' #  Affichage des r�sultats
        ' Console.WriteLine(vbCrLf & " Le montant des int�r�ts sera de " + Math.Round(Math.Round(capitalDepart * Math.Pow(1 + (tauxInteret / 100), duree), 2) - capitalDepart, 2) + "euros apr�s " + duree + " ans.\n" + "Le capital final sera de " + Math.Round(capitalDepart * Math.Pow(1 + (tauxInteret / 100), duree), 2) + "euros.\n")
        Console.WriteLine(vbCrLf & " Dans " + duree.ToString + " ans :")
        Console.WriteLine(" Le montant des int�r�ts sera de " + interets.ToString + " �.")
        Console.WriteLine(" Le capital final sera de " + capitalFinal.ToString + " �." & vbCrLf)


        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
