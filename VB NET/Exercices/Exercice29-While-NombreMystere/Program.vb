Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 29 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Trouver le nombre mystère --- " & vbCrLf)

        Dim aleatoire As New Random()
        Dim nbMystere As Integer = aleatoire.Next(1, 51)
        Dim nbCoups As Integer = 0
        Dim trouve As Boolean = False
        Dim nbTmp As Integer

        Console.ForegroundColor = ConsoleColor.DarkGray
        Console.WriteLine(" J'ai généré aléatoirement un nombre entre")
        Console.WriteLine("     1 et 50, à vous de le trouver !" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White



        While Not trouve
            nbTmp = 0
            Console.ForegroundColor = ConsoleColor.DarkCyan
            Console.Write(" Veuillez saisir un nombre : ")
            Console.ForegroundColor = ConsoleColor.White


            While Integer.TryParse(Console.ReadLine(), nbTmp) = False
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine(" Erreur de saisie, merci de saisir un chiffre/nombre! ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(" Veuillez saisir un nombre : ")
            End While

            If nbTmp = nbMystere Then
                trouve = True
            ElseIf nbTmp < nbMystere Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine(vbTab & "Le nombre mystère est plus grand")
                Console.ForegroundColor = ConsoleColor.White
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine(vbTab & "Le nombre mystère est plus petit")
                Console.ForegroundColor = ConsoleColor.White
            End If

            nbCoups += 1
        End While

        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(" Bravo !!!! Vous avez trouvé le nombre mystère !")
        Console.WriteLine(vbTab & " Vous avez trouvé en " & nbCoups & " coups.")
        Console.ForegroundColor = ConsoleColor.White


        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.ForegroundColor = ConsoleColor.White
        Console.Read()
    End Sub
End Module
