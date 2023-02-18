Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 23 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Accroissement Population --- " & vbCrLf)

#Region "Déclaration des variables"
        ' #  Déclaration des Variables
        Dim nbhabitant As Double = 96809
        Dim taux As Double = 0.89 / 100
        Dim dateDebut As Integer = 2015
        Dim nbAnnee As Integer = 0
#End Region


#Region "Boucle For pour faite croitre la population"
        '' #  Boucle For pour simuler l'accroissement de la population
        'For nbAnnee = 1 To 100
        '    ' nbhabitant = nbhabitant + nbhabitant * taux
        '    nbhabitant += nbhabitant * taux
        '    dateDebut += 1
        '    If nbhabitant >= 120000 Then
        '        Exit For
        '    End If
        'Next nbAnnee

        '####### BOUCLE DO LOOP UNTIL ###########
        Do
            nbAnnee += 1
            nbhabitant += nbhabitant * taux
            dateDebut += 1

        Loop Until nbhabitant >= 120000

        ' # Boucle pour faire croitre la population 
        While nbhabitant < 120000
            nbhabitant *= 1.0089
            dateDebut += 1
            nbAnnee += 1
        End While
#End Region

        ' #  Affichage des résultats
        Console.WriteLine(" Il faudra " & nbAnnee.ToString & " ans, nous serons en " & dateDebut.ToString & vbCrLf)
        Console.WriteLine(" Il y aura " & Math.Round(nbhabitant, 0).ToString & " habitants en " & dateDebut.ToString & vbCrLf)

        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()

    End Sub
End Module
