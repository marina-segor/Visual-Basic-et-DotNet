Imports System

Module Program
    Sub Main(args As String())

        ' ####################################
        ' # LES INSTRUCTIONS CONDITIONNELLES #
        ' ####################################

        ' ################
        ' # IF...ELSE... #
        ' ################

        ' If condition 1 vraie Then
        '       exécuter instructions
        ' Else
        '       exécuter autres intructions
        ' End If

        ' If => Mot-clé signifiant « si » et qui ouvre la structure
        ' Then => Mot-clé signifiant « alors »
        ' Else => Mot-clé signifiant « sinon »
        ' End If => Mot-clé permettant de fermer la structure

        ' En français : Si la condition 1 est vraie alors on exécute le bloc Then sinon on exécute le bloc Else

        ' ##
        ' # Exemple 
        ' ##

        Dim code As Integer = 1738

        If code = 1739 Then
            Console.WriteLine("condition vraie")
        Else
            Console.WriteLine("condition fausse")
        End If


        ' On peut tester une condition fausse et dans ce cas utiliser Not.

        Dim A As Boolean = False
        Dim B As Boolean = True

        If B Then
            Console.WriteLine("B est a vrai")
        End If

        If Not A = B Then
            Console.WriteLine("A est différent de B") 'Si A et B sont différents (Not A=B signifie NON égaux) afficher "A est différent de B".
        End If

        ' Il peut y avoir des opérateurs logiques dans la condition:

        ' If A=B And C=D Then..    'Si A égal B et si C égal D


        ' ###########################
        ' # IF...ELSE... IMBRIQUEES #
        ' ###########################

        'Exemple
        ' If condition_1 vraie Then
        '      If condition_2 vraie Then
        '            Console.WriteLine("Condition_1 Vraie et Condition_2 Vraie")
        '      Else
        '          If condition_3 Vraie Then
        '               Console.WriteLine("Condition_1 Vraie et Condition_2 Fausse et Condition_3 Vraie")
        '          End If
        '      End If
        ' End If

        Dim Age As Byte = 18



        If Age < 18 Then
            If Age < 10 Then
                Console.WriteLine("Vous êtes un enfant")
            Else
                If Age < 14 Then
                    Console.WriteLine("Vous êtes un pré-adolescent")
                Else
                    Console.WriteLine("Vous êtes un adolescent")
                End If
            End If
        Else
            Console.WriteLine("Vous êtes un adulte")
        End If



        ' ###########################
        ' # IF...ELSE IF... ELSE... #
        ' ###########################

        ' If Condition1 vraie Then
        '   ..
        ' ElseIf condition2 Then 'sinon on teste la condition 2
        '   ..
        ' ElseIf condition3 Then 'la condition 3
        '   ..
        ' End If

        If Age < 10 Then
            Console.WriteLine("Vous êtes un enfant")
        ElseIf Age < 14 Then 'sinon on teste la condition 2
            Console.WriteLine("Vous êtes un pré-adolescent")
        ElseIf Age < 18 Then 'la condition 3
            Console.WriteLine("Vous êtes un adolescent")
        ElseIf Age >= 18 Then 'la condition 3
            Console.WriteLine("Vous êtes un adulte")
        End If

        Console.WriteLine("Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module
