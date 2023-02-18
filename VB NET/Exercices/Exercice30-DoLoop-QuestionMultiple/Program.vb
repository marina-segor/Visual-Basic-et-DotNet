Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 30 #
        ' ###############


        ' # Déclaration des variables
        Dim choix As String = ""
        Dim poursuivre As String = "NON"



        ' # Demande de réponse utilisateur et traitement de sa réponse
        Do
            Console.Clear()
            ' # Affichage de la question
            Console.WriteLine(vbCrLf & " --- Question choix multiple --- " & vbCrLf)
            Console.ForegroundColor = ConsoleColor.DarkCyan
            Console.WriteLine(" Quelle instruction permet de sortir")
            Console.WriteLine(" d'une boucle For en VB.NET ?" & vbCrLf)
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine(vbTab & "a) Quit For")
            Console.WriteLine(vbTab & "b) Continue For")
            Console.WriteLine(vbTab & "c) Exit For")
            Console.WriteLine(vbTab & "d) Break For" & vbCrLf)

            Dim ok As Boolean = False
            While Not ok
                Dim chaine As String = "ABCD"
                Console.ForegroundColor = ConsoleColor.DarkCyan
                Console.Write(" Entrez votre réponse : ")
                Console.ForegroundColor = ConsoleColor.White
                choix = Console.ReadLine().ToUpper()
                ok = chaine.Contains(choix)
            End While

            If choix = "C" Then
                Console.WriteLine("")
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine(" Bravo!!! C'est la bonne réponse")
                Console.ForegroundColor = ConsoleColor.White
                poursuivre = "NON"
            Else
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine(" Incorrecte!")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(" Un nouvel essai ? Oui / Non : ")
                ok = False
                While Not ok
                    poursuivre = Console.ReadLine().ToUpper()
                    If poursuivre <> "OUI" And poursuivre <> "NON" Then
                        Console.WriteLine(" Erreur de saisie...")
                    Else
                        ok = True
                    End If
                End While
            End If
        Loop While poursuivre = "OUI"

        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
