Imports System
Imports System.Text

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 16 #
        ' ###############

        Console.OutputEncoding = Encoding.UTF8
        Console.WriteLine(vbCrLf & " --- Quelle sera le montant des mes impôts ? --- " & vbCrLf)

        ' ###
        ' #  Déclaration des variables
        ' ###
        Dim Tranche1 As Integer = 10778, Tranche2 = 27479, Tranche3 = 78571, Tranche4 = 168995
        Dim revenus As Double = 0, nbParts = 0, revenuImposable = 0, montantImpot = 0
        Dim nbAdulte As Integer = 0, nbEnfants = 0

        ' ###
        ' #  Récupération des saisies Utilisateur
        ' ###

        Console.Write(" Entrez le montant net imposable du foyer (en €) : ")
        revenus = Convert.ToDouble(Console.ReadLine())

        Console.Write(" Entrez le nombre d'adulte du foyer : ")
        nbAdulte = Convert.ToInt32(Console.ReadLine())

        Console.Write(" Entrez le nombre d'enfants du foyer : ")
        nbEnfants = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine(" " & vbCrLf)

        ' ###
        ' #  Calcul du nombre de parts du foyer
        ' ###

        If nbEnfants <= 2 Then
            nbParts = nbAdulte + nbEnfants * 0.5
        Else
            nbParts = nbAdulte + nbEnfants - 1
        End If

        ' ###
        ' #  Calcul du montant de l'impôt  
        ' ###

        ' # Calcul du Revenu imposable
        revenuImposable = revenus / nbParts

        ' # Etablissement Structure If() pour calculer le montant de l'impôt
        If revenuImposable >= Tranche1 And revenuImposable < Tranche2 Then
            montantImpot = (revenuImposable - (Tranche1 - 1)) * 0.11
        ElseIf (revenuImposable >= Tranche2 And revenuImposable < Tranche3) Then
            montantImpot = (revenuImposable - (Tranche2 - 1)) * 0.3 + ((Tranche2 - 1) - Tranche1) * 0.11
        ElseIf (revenuImposable >= Tranche3 And revenuImposable < Tranche4) Then
            montantImpot = (revenuImposable - (Tranche3 - 1)) * 0.41 + ((Tranche3 - 1) - Tranche2) * 0.3 + ((Tranche2 - 1) - Tranche1) * 0.11
        ElseIf (revenuImposable >= Tranche4) Then
            montantImpot = (revenuImposable - (Tranche4 - 1)) * 0.45 + ((Tranche4 - 1) - Tranche3) * 0.41 + ((Tranche3 - 1) - Tranche2) * 0.3 + ((Tranche2 - 1) - Tranche1) * 0.11
        End If

        ' # Calcul de l'impôt

        montantImpot = Math.Round(montantImpot * nbParts, 0)


        ' ###
        ' #  Affichage des résultats
        ' ###

        Console.WriteLine(" Vous allez payer " + montantImpot.ToString + " € d'impôts cette année." & vbCrLf)



        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
