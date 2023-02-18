Imports System

Module Program
    Sub Main(args As String())

        ' #####################
        ' # BOUCLE FOR...NEXT #
        ' #####################

        ' ##
        ' # Syntaxe
        ' ##

        ' For Variable = Debut To Fin
        '     Execute la boucle
        ' Next Variable

        ' For : Mot-cl� permettant d'ouvrir la boucle.
        ' To  Mot-cl� signifiant � jusqu'� �
        ' Next : Mot-cl� pour fermer la boucle.
        ' Variable: Variable qui va servir de compteur pour la boucle.
        ' Debut:  D�but du compteur.
        ' Fin:    Fin du compteur.


        ' ##
        ' # Exemples
        ' ##

        ' Exemple de boucle avec incr�mentation de 1
        Dim i As Integer
        For i = 3 To 10
            Console.WriteLine("i = " + i.ToString())
        Next i

        ' Exemple de boucle avec incr�mentation de 2
        For i = 3 To 10 Step 2
            Console.WriteLine(i.ToString) 'affiche 3 puis 5 puis 7 et enfin 9
        Next i

        ' Exemple de boucle avec d�cr�mentation de 2
        For i = 12 To 0 Step -2
            Console.WriteLine(i.ToString) 'affiche 12 puis 10 puis 8 puis 6 puis 4 puis 2 et enfin 0
        Next i

        'Exemple de d�claration de variable d'it�ration � la vol�e
        For Test As Integer = 0 To 43
            'boucle de 0 � 43
        Next


        ' ##
        ' # Exemples de Sortie de boucle volontaire (Then Exit For)
        ' ##
        For Test As Integer = 0 To 43
            If Test = 3 Then Exit For 'Quand Test sera �gale � 3 alors on sort...
        Next


        ' ######################
        ' # BOUCLES IMBRIQUEES #
        ' ######################

        Console.WriteLine("Les Boucles imbriquees")


        For a As Integer = 0 To 10
            Console.WriteLine("a vaut : " & a.ToString)
            For b As Integer = 0 To 5
                Console.WriteLine("b vaut : " & b.ToString)
            Next b
        Next a


        Console.WriteLine("Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module
