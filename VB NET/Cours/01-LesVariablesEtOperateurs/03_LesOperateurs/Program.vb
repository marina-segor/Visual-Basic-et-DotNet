Imports System
Module Program
    Sub Main(args As String())
        ' ################################
        ' # LES OPERATEURS ARYTHMETIQUES #
        ' ################################

        '       # Opérateur #              # Opération réalisée par l'opérateur #
        '           +                           Additionne deux nombres
        '           -                           Soustrait deux nombres
        '           *                           Multiplie deux nombres
        '           /                           Divise deux nombres et retourne un nombre à virgule flottante (décimal)
        '           \                           Divise deux nombres et retourne un nombre entier
        '           Mod (Modulo)                Divise deux nombres et retourne seulement le reste
        '           ^                           Élève à la puissance un nombre
        '           &                           Additionne(concatène) deux chaines

        ' ############
        ' # Addition #
        ' ############

        ' Opérateur + avec des entiers
        Dim nb1 As Integer = 10, nb2 = 20
        Dim somme As Integer = nb1 + nb2 ' =30
        Console.WriteLine($"La somme de {nb1} et de {nb2} est égal à {somme}")

        ' Opérateur combiné
        somme += nb2 ' 50


        ' ################
        ' # Soustraction #
        ' ################

        ' Opérateur - avec des entiers
        somme = nb2 - nb1 ' 10

        Console.WriteLine($"{nb2} moins {nb1} est égal à {somme}")

        ' Opérateur combiné
        somme -= nb1 ' 0


        ' ##################
        ' # Multiplication #
        ' ##################

        ' Opérateur * avec des entiers
        somme = nb2 * nb1 ' 200

        Console.WriteLine($"{nb2} multiplié par {nb1} est égal à {somme}")

        ' Opérateur combiné
        somme *= nb1 ' 20


        ' ############
        ' # Division #
        ' ############

        ' Opérateur / avec des entiers
        somme = nb2 / nb1 ' 200

        Console.WriteLine($"{nb2} divisé par {nb1} est égal à {somme}")

        ' Opérateur combiné
        somme *= nb1 ' 2000


        ' ##########
        ' # Modulo #
        ' ##########

        ' Opérateur / avec des entiers
        somme = nb2 Mod nb1 ' 0

        Console.WriteLine($"{nb2} modulo {nb1} est égal à {somme}")

        ' #############
        ' # PUISSANCE #
        ' #############

        ' ##
        ' # Syntaxe
        ' ##

        ' number ^ exponent

        ' ##
        ' # Résultats
        ' ##

        ' Le résultat est number élevé à la puissance de exponent, toujours en tant Double que valeur.

        ' ##
        ' # Types pris en charge
        ' ##

        ' Les opérandes de type différent de Double sont convertis Double.

        ' ##
        ' # Notes
        ' ##

        ' Visual Basic effectue toujours une exponentiation dans le type de données Double.
        ' La valeur de exponent peut être fractionnaire, négative ou les deux.
        ' Lorsque plusieurs exposants sont exécutés dans une seule expression, l'opérateur ^ est évalué tel qu’il est rencontré de gauche à droite.

        ' ##
        ' # Important
        ' ##

        ' L 'opérateur ^ peut être surchargé, ce qui signifie qu’une classe ou une structure peut redéfinir son comportement lorsqu’un opérande a le type de cette classe ou structure.
        ' Si votre code utilise cet opérateur sur ce type de classe ou structure, veillez à comprendre son comportement une fois qu’il est redéfini.


        Dim nombre1 As Double, nombre2 As Double, nb1PowNb2 As Double

        ' Saisie de deux chiffres utilisateur
        Console.Write("Veuillez saisir un nombre => ")
        nombre1 = Convert.ToDouble(Console.ReadLine)
        Console.Write("Veuillez saisir la puissance => ")
        nombre2 = Convert.ToDouble(Console.ReadLine)

        ' Calcul de la puissance
        nb1PowNb2 = nombre1 ^ nombre2

        Console.WriteLine($"{nombre1} puissance {nombre2} est égal à {nb1PowNb2}")

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

        ' > => Strictement supérieur à

        ' < => Strictement inférieur à

        ' >= => Supérieur ou égal à

        ' <= => Inférieur ou égal à

        ' <> Différent de

        ' = Egal à



        Console.WriteLine("Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module