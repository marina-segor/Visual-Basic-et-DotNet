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
        '       ex�cuter instructions
        ' Else
        '       ex�cuter autres intructions
        ' End If

        ' If => Mot-cl� signifiant � si � et qui ouvre la structure
        ' Then => Mot-cl� signifiant � alors �
        ' Else => Mot-cl� signifiant � sinon �
        ' End If => Mot-cl� permettant de fermer la structure

        ' En fran�ais : Si la condition 1 est vraie alors on ex�cute le bloc Then sinon on ex�cute le bloc Else

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
            Console.WriteLine("A est diff�rent de B") 'Si A et B sont diff�rents (Not A=B signifie NON �gaux) afficher "A est diff�rent de B".
        End If

        ' Il peut y avoir des op�rateurs logiques dans la condition:

        ' If A=B And C=D Then..    'Si A �gal B et si C �gal D


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
                Console.WriteLine("Vous �tes un enfant")
            Else
                If Age < 14 Then
                    Console.WriteLine("Vous �tes un pr�-adolescent")
                Else
                    Console.WriteLine("Vous �tes un adolescent")
                End If
            End If
        Else
            Console.WriteLine("Vous �tes un adulte")
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
            Console.WriteLine("Vous �tes un enfant")
        ElseIf Age < 14 Then 'sinon on teste la condition 2
            Console.WriteLine("Vous �tes un pr�-adolescent")
        ElseIf Age < 18 Then 'la condition 3
            Console.WriteLine("Vous �tes un adolescent")
        ElseIf Age >= 18 Then 'la condition 3
            Console.WriteLine("Vous �tes un adulte")
        End If

        Console.WriteLine("Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module
