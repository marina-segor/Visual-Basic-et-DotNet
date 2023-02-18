Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 26 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Accroissemnt population (While) --- " & vbCrLf)

        ' # Déclaration des variables
        Dim nbhabitant As Double = 96809
        Dim dateDebut As Integer = 2015
        Dim nbAnnee As Integer = 0

        ' # Boucle pour faire croitre la population 
        While nbhabitant < 120000
            nbhabitant *= 1.0089
            dateDebut += 1
            nbAnnee += 1
        End While

        Console.WriteLine(" Il faudra " & nbAnnee & " ans, nous serons en " & dateDebut)
        Console.WriteLine(" Il y aura " & Math.Round(nbhabitant, 0) & " habitants en " & dateDebut & vbCrLf)

        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
