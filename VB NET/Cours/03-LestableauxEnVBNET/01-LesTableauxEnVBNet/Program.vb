Imports System

Module Program
    Sub Main(args As String())

        ' ################
        ' # LES TABLEAUX # de type valeur, tableau contient les réfences mémoire
        ' ################

        ' ##
        ' # Syntaxe
        ' ##

        ' Dim <NomTableau>(<nbElements>) As <TypeTableau>

        ' ##
        ' # Exemple création tableau
        ' ##

        Dim Tableau(6) As Integer 'déclare un tableau de 7 entiers

        ' ##
        ' # IMPORTANT
        ' ##

        ' Le premier élément d'un tableau est toujours à l'indice 0. Le dernier élément d'un tableau est toujours à l'indice Length - 1 (dans l'exemple 7 - 1 = 6)

        'Exemple d'assignations
        Tableau(0) = 1
        Tableau(1) = 2
        Tableau(2) = 3
        Tableau(3) = 4
        Tableau(4) = 5
        Tableau(5) = 6
        Tableau(6) = 7

        ' ##
        ' # ITERATION D'UN TABLEAU
        ' ##

        Console.WriteLine("Itération de Tableau : " & vbCrLf)
        Dim Counter As Integer = 0
        For Each Item As Integer In Tableau
            Console.WriteLine("En index " & Counter & " : " & Item.ToString)
            Counter += 1
        Next Item


        ' ##
        ' # Exemple création tableau
        ' ##

        Console.WriteLine(vbCrLf & "Je crée un nouveau tableau nommé Tableau2 = null " & vbCrLf)
        Dim Tableau2() As Integer 'déclare un tableau de 7 entiers
        Console.WriteLine("Je donne à Tableau2 les références de Tableau" & vbCrLf)
        Tableau2 = Tableau

        Console.WriteLine("Je modifie Tableau2(2) = 77 " & vbCrLf)
        Tableau2(2) = 77
        Console.WriteLine("Nouvelle Itération de Tableau : " & vbCrLf)
        Counter = 0
        For Each Item As Integer In Tableau
            Console.WriteLine("En index " & Counter & " : " & Item.ToString)
            Counter += 1
        Next Item

        ' ##
        ' # Pour effacer un tableau et récupérer la mémoire allouée par le tableau
        ' ##

        Erase Tableau
        Tableau = Nothing
        ' Ces deux commandes sont équivalentes.

        ' ##
        ' # Pour réinitialiser le tableau (remise à zéro des éléments) 
        ' ##

        'Réinitialisation du tableau de l'index 0 au dernier index du tableau
        Array.Clear(Tableau2, 0, Tableau2.Length)

        Console.WriteLine(vbCrLf & "Les tableaux sont des types objet et donc transmission de valeur par Référence " & vbCrLf)


        ' ###################
        ' # METHODE COPY TO # Récupère uniquement les valeurs
        ' ###################

        Console.WriteLine(vbCrLf & "########## Copy TO ##########" & vbCrLf)

        ' # Création d'un tableau T1 de type int
        Console.WriteLine("Creation d'un tableau T1" & vbCrLf)
        Dim T1() As Integer = {1, 2, 3}


        ' # Itération du tableau T1
        Console.WriteLine("Contenu de T1 : " & vbCrLf)
        For Each Item As Integer In T1
            Console.WriteLine(Item)
        Next Item

        ' # Création d'un tableau T2 de type int
        Console.WriteLine("Creation d'un tableau T2" & vbCrLf)
        Dim T2(10) As Integer


        ' # Itération du tableau T2
        Console.WriteLine("Contenu de T2 : " & vbCrLf)
        For Each Item As Integer In T2
            Console.WriteLine(Item)
        Next Item


        ' # Copie de T1 dans T2 avec la méthode CopyTo()
        Console.WriteLine("Copie de T1 dans T2" & vbCrLf)
        T1.CopyTo(T2, 0)


        ' # Modification de T1
        Console.WriteLine("Modification de T1 : T1[0] = 18" & vbCrLf)
        T1(0) = 18


        ' # Affichage des tableaux T1 et T2
        Console.WriteLine("Contenu de T1 après copie et modification: " & vbCrLf)
        For Each Item As Integer In T1
            Console.WriteLine(Item)
        Next Item
        Console.WriteLine("Contenu de T2 après copie et modification de T1: " & vbCrLf)
        For Each Item As Integer In T2
            Console.WriteLine(Item)
        Next Item



        ' ####################
        ' # METHODE CLONE TO # copie la structure & des valeurs
        ' ####################

        Console.WriteLine(vbCrLf & "########## CLONE TO ##########" & vbCrLf)

        ' #  Création d'un tableau T1 de type int
        Console.WriteLine("Réinitialisation de T1")
        T1 = {1, 2, 3}


        ' #  Itération du tableau T1
        Console.WriteLine("Contenu de T1 : ")
        For Each Item As Integer In T1
            Console.WriteLine(Item)
        Next Item


        ' #  Création d'un tableau T2 de type int
        Console.WriteLine("Réinitialisation de T2")
        T2 = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


        ' #  Itération du tableau T2
        Console.WriteLine("Contenu de T2 : ")
        For Each Item As Integer In T2
            Console.WriteLine(Item)
        Next Item


        ' #  Clonage de T1 dans T2
        Console.WriteLine("Clonage de T2 dans T1 avec la méthode Clone()")
        T2 = T1.Clone()


        ' #  Modification de T1 
        Console.WriteLine("Modification de T1 : T1[0] = 18 ")
        T1(0) = 18


        ' # Affichage des tableaux T1 et T2
        Console.WriteLine("Contenu de T1 après copie et modification: " & vbCrLf)
        For Each Item As Integer In T1
            Console.WriteLine(Item)
        Next Item
        Console.WriteLine("Contenu de T2 après copie et modification de T1: " & vbCrLf)
        For Each Item As Integer In T2
            Console.WriteLine(Item)
        Next Item



        Console.WriteLine(vbCrLf & "Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module
