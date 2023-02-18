Imports System

Module Program
    Sub Main(args As String())

        ' ################
        ' # LES TABLEAUX # de type valeur, tableau contient les r�fences m�moire
        ' ################

        ' ##
        ' # Syntaxe
        ' ##

        ' Dim <NomTableau>(<nbElements>) As <TypeTableau>

        ' ##
        ' # Exemple cr�ation tableau
        ' ##

        Dim Tableau(6) As Integer 'd�clare un tableau de 7 entiers

        ' ##
        ' # IMPORTANT
        ' ##

        ' Le premier �l�ment d'un tableau est toujours � l'indice 0. Le dernier �l�ment d'un tableau est toujours � l'indice Length - 1 (dans l'exemple 7 - 1 = 6)

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

        Console.WriteLine("It�ration de Tableau : " & vbCrLf)
        Dim Counter As Integer = 0
        For Each Item As Integer In Tableau
            Console.WriteLine("En index " & Counter & " : " & Item.ToString)
            Counter += 1
        Next Item


        ' ##
        ' # Exemple cr�ation tableau
        ' ##

        Console.WriteLine(vbCrLf & "Je cr�e un nouveau tableau nomm� Tableau2 = null " & vbCrLf)
        Dim Tableau2() As Integer 'd�clare un tableau de 7 entiers
        Console.WriteLine("Je donne � Tableau2 les r�f�rences de Tableau" & vbCrLf)
        Tableau2 = Tableau

        Console.WriteLine("Je modifie Tableau2(2) = 77 " & vbCrLf)
        Tableau2(2) = 77
        Console.WriteLine("Nouvelle It�ration de Tableau : " & vbCrLf)
        Counter = 0
        For Each Item As Integer In Tableau
            Console.WriteLine("En index " & Counter & " : " & Item.ToString)
            Counter += 1
        Next Item

        ' ##
        ' # Pour effacer un tableau et r�cup�rer la m�moire allou�e par le tableau
        ' ##

        Erase Tableau
        Tableau = Nothing
        ' Ces deux commandes sont �quivalentes.

        ' ##
        ' # Pour r�initialiser le tableau (remise � z�ro des �l�ments) 
        ' ##

        'R�initialisation du tableau de l'index 0 au dernier index du tableau
        Array.Clear(Tableau2, 0, Tableau2.Length)

        Console.WriteLine(vbCrLf & "Les tableaux sont des types objet et donc transmission de valeur par R�f�rence " & vbCrLf)


        ' ###################
        ' # METHODE COPY TO # R�cup�re uniquement les valeurs
        ' ###################

        Console.WriteLine(vbCrLf & "########## Copy TO ##########" & vbCrLf)

        ' # Cr�ation d'un tableau T1 de type int
        Console.WriteLine("Creation d'un tableau T1" & vbCrLf)
        Dim T1() As Integer = {1, 2, 3}


        ' # It�ration du tableau T1
        Console.WriteLine("Contenu de T1 : " & vbCrLf)
        For Each Item As Integer In T1
            Console.WriteLine(Item)
        Next Item

        ' # Cr�ation d'un tableau T2 de type int
        Console.WriteLine("Creation d'un tableau T2" & vbCrLf)
        Dim T2(10) As Integer


        ' # It�ration du tableau T2
        Console.WriteLine("Contenu de T2 : " & vbCrLf)
        For Each Item As Integer In T2
            Console.WriteLine(Item)
        Next Item


        ' # Copie de T1 dans T2 avec la m�thode CopyTo()
        Console.WriteLine("Copie de T1 dans T2" & vbCrLf)
        T1.CopyTo(T2, 0)


        ' # Modification de T1
        Console.WriteLine("Modification de T1 : T1[0] = 18" & vbCrLf)
        T1(0) = 18


        ' # Affichage des tableaux T1 et T2
        Console.WriteLine("Contenu de T1 apr�s copie et modification: " & vbCrLf)
        For Each Item As Integer In T1
            Console.WriteLine(Item)
        Next Item
        Console.WriteLine("Contenu de T2 apr�s copie et modification de T1: " & vbCrLf)
        For Each Item As Integer In T2
            Console.WriteLine(Item)
        Next Item



        ' ####################
        ' # METHODE CLONE TO # copie la structure & des valeurs
        ' ####################

        Console.WriteLine(vbCrLf & "########## CLONE TO ##########" & vbCrLf)

        ' #  Cr�ation d'un tableau T1 de type int
        Console.WriteLine("R�initialisation de T1")
        T1 = {1, 2, 3}


        ' #  It�ration du tableau T1
        Console.WriteLine("Contenu de T1 : ")
        For Each Item As Integer In T1
            Console.WriteLine(Item)
        Next Item


        ' #  Cr�ation d'un tableau T2 de type int
        Console.WriteLine("R�initialisation de T2")
        T2 = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


        ' #  It�ration du tableau T2
        Console.WriteLine("Contenu de T2 : ")
        For Each Item As Integer In T2
            Console.WriteLine(Item)
        Next Item


        ' #  Clonage de T1 dans T2
        Console.WriteLine("Clonage de T2 dans T1 avec la m�thode Clone()")
        T2 = T1.Clone()


        ' #  Modification de T1 
        Console.WriteLine("Modification de T1 : T1[0] = 18 ")
        T1(0) = 18


        ' # Affichage des tableaux T1 et T2
        Console.WriteLine("Contenu de T1 apr�s copie et modification: " & vbCrLf)
        For Each Item As Integer In T1
            Console.WriteLine(Item)
        Next Item
        Console.WriteLine("Contenu de T2 apr�s copie et modification de T1: " & vbCrLf)
        For Each Item As Integer In T2
            Console.WriteLine(Item)
        Next Item



        Console.WriteLine(vbCrLf & "Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module
