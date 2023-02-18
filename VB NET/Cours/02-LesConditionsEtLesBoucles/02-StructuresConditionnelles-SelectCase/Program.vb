Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # SELECT CASE # 
        ' ###############

        ' ##
        ' # Syntaxe
        ' ##

        ' Select Case X
        '   Case 1 : 'faire Y
        '   Case 2 : 'faire Z
        '   Case Else : 'faire A
        ' End Select

        ' Select Case : Mot-clé permettant d'ouvrir la structure
        ' Case : Représente les différents cas (Case 1 = cas 1, Case 2 = cas 2, Case Else = autre cas…)
        ' End Select : Mot-clé permettant de fermer la structure
        ' X:      Expression à évaluer (nombre, chaine de caractères, booléen…)
        ' faire Y : Exécute le cas 1
        ' faire Z : Exécute le cas 2
        ' faire A : Exécute le cas « else »

        ' ##
        ' # Exemple
        ' ##

        Console.WriteLine("------- Menu Select Case -------" & vbCrLf)
        Console.WriteLine(vbTab & "1- Se Connecter")
        Console.WriteLine(vbTab & "2- Se Déconnecter")
        Console.WriteLine(vbTab & "0-- Quitter")
        Console.Write(vbCrLf & vbTab & "Faite votre choix => ")

        Dim code As Byte = Convert.ToByte(Console.ReadLine())

        Select Case code
            Case 1
                Console.WriteLine(vbCrLf & "Menu Connection" & vbCrLf)
            Case 2
                Console.WriteLine(vbCrLf & "Menu Déconnection" & vbCrLf)
            Case 0
                Console.WriteLine(vbCrLf & "A bientôt..." & vbCrLf)
                Console.ReadLine()
                Environment.Exit(0)
            Case Else
                Console.WriteLine(vbCrLf & "Erreur choix menu!")
        End Select

        Console.WriteLine(vbCrLf & "--------------------------------" & vbCrLf)

        ''Exemple avec les virgules
        'Select Case code
        '    Case 8, 9, 10
        '        'Effectuer le code si code=8 ou code=9 ou code=10
        'End Select

        ''Exemple avec une plage de valeurs
        'Select Case code
        '    Case 8 To 20
        '        'Effectuer le code si code est dans la plage 8 à 20
        'End Select

        'Exemple avec un opérateur de comparaison
        Select Case code
            Case Is >= 15
                'Effectuer le code si code supérieur ou égal à 15.
        End Select


        'Dim MaxNumber As Byte
        'Select Case code
        '    Case 3 To 6, 7 To 15, 200, Is > MaxNumber
        '        'Effectuer le code si N, compris entre 3 et 15, si N = 200 ou N = 1654, est supérieur à MaxNumber
        'End Select

        'Select Case code
        '    Case "ttt", "bbb" To "eee", MaxNumber
        '        'Effectuer le code si N ="ttt" ou si N est compris entre "bbb" et "eee" (ordre alphabétique) ou si code = Nombre
        'End Select





        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
