Imports System
Module Program
    Sub Main(args As String())
        ' ################################
        ' # LES OPERATEURS ARYTHMETIQUES #
        ' ################################

        '       # Op�rateur #              # Op�ration r�alis�e par l'op�rateur #
        '           +                           Additionne deux nombres
        '           -                           Soustrait deux nombres
        '           *                           Multiplie deux nombres
        '           /                           Divise deux nombres et retourne un nombre � virgule flottante (d�cimal)
        '           \                           Divise deux nombres et retourne un nombre entier
        '           Mod (Modulo)                Divise deux nombres et retourne seulement le reste
        '           ^                           �l�ve � la puissance un nombre
        '           &                           Additionne(concat�ne) deux chaines

        ' ############
        ' # Addition #
        ' ############

        ' Op�rateur + avec des entiers
        Dim nb1 As Integer = 10, nb2 = 20
        Dim somme As Integer = nb1 + nb2 ' =30
        Console.WriteLine($"La somme de {nb1} et de {nb2} est �gal � {somme}")

        ' Op�rateur combin�
        somme += nb2 ' 50


        ' ################
        ' # Soustraction #
        ' ################

        ' Op�rateur - avec des entiers
        somme = nb2 - nb1 ' 10

        Console.WriteLine($"{nb2} moins {nb1} est �gal � {somme}")

        ' Op�rateur combin�
        somme -= nb1 ' 0


        ' ##################
        ' # Multiplication #
        ' ##################

        ' Op�rateur * avec des entiers
        somme = nb2 * nb1 ' 200

        Console.WriteLine($"{nb2} multipli� par {nb1} est �gal � {somme}")

        ' Op�rateur combin�
        somme *= nb1 ' 20


        ' ############
        ' # Division #
        ' ############

        ' Op�rateur / avec des entiers
        somme = nb2 / nb1 ' 200

        Console.WriteLine($"{nb2} divis� par {nb1} est �gal � {somme}")

        ' Op�rateur combin�
        somme *= nb1 ' 2000


        ' ##########
        ' # Modulo #
        ' ##########

        ' Op�rateur / avec des entiers
        somme = nb2 Mod nb1 ' 0

        Console.WriteLine($"{nb2} modulo {nb1} est �gal � {somme}")

        ' #############
        ' # PUISSANCE #
        ' #############

        ' ##
        ' # Syntaxe
        ' ##

        ' number ^ exponent

        ' ##
        ' # R�sultats
        ' ##

        ' Le r�sultat est number �lev� � la puissance de exponent, toujours en tant Double que valeur.

        ' ##
        ' # Types pris en charge
        ' ##

        ' Les op�randes de type diff�rent de Double sont convertis Double.

        ' ##
        ' # Notes
        ' ##

        ' Visual Basic effectue toujours une exponentiation dans le type de donn�es Double.
        ' La valeur de exponent peut �tre fractionnaire, n�gative ou les deux.
        ' Lorsque plusieurs exposants sont ex�cut�s dans une seule expression, l'op�rateur ^ est �valu� tel qu�il est rencontr� de gauche � droite.

        ' ##
        ' # Important
        ' ##

        ' L 'op�rateur ^ peut �tre surcharg�, ce qui signifie qu�une classe ou une structure peut red�finir son comportement lorsqu�un op�rande a le type de cette classe ou structure.
        ' Si votre code utilise cet op�rateur sur ce type de classe ou structure, veillez � comprendre son comportement une fois qu�il est red�fini.


        Dim nombre1 As Double, nombre2 As Double, nb1PowNb2 As Double

        ' Saisie de deux chiffres utilisateur
        Console.Write("Veuillez saisir un nombre => ")
        nombre1 = Convert.ToDouble(Console.ReadLine)
        Console.Write("Veuillez saisir la puissance => ")
        nombre2 = Convert.ToDouble(Console.ReadLine)

        ' Calcul de la puissance
        nb1PowNb2 = nombre1 ^ nombre2

        Console.WriteLine($"{nombre1} puissance {nombre2} est �gal � {nb1PowNb2}")

        ' #################
        ' # CONCATENATION #
        ' #################

        Dim Prenom, Nom, NomComplet As String
        Prenom = "Anthony"
        Nom = "Di Persio"
        NomComplet = Prenom & " " & Nom 'retourne "Anthony Di Persio"

        Console.WriteLine($"Mon nom complet est {NomComplet}")



        ' ###########################
        ' # LES OPERATEURS LOGIQUES #
        ' ###########################

        ' And (et)  Var_1 And Var_2  True si Var_1 et Var_2 sont vraies

        ' Or (ou)   Var_1 Or Var_2   True si une des deux est vraie

        ' Xor (ou exclusif)   Var_1 Xor Var_2    True si une et une seule est vraie

        ' Not (non)   Not Var_1  True si Var est faux et vice versa



        ' #################################
        ' # LES OPERATEURS DE COMPARAISON #
        ' #################################

        ' > => Strictement sup�rieur �

        ' < => Strictement inf�rieur �

        ' >= => Sup�rieur ou �gal �

        ' <= => Inf�rieur ou �gal �

        ' <> Diff�rent de

        ' = Egal �



        Console.WriteLine("Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module