Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 35 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Tableaux => Liste de Contact --- " & vbCrLf)

        'Declaration and Initialization of the Contact Array
        ' Dim persons() As String
        Dim choixMenu As String
        Dim nbContact As Integer

        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(" Merci de saisir le nombre de contact : ")
        Console.ForegroundColor = ConsoleColor.White
        nbContact = Convert.ToInt32(Console.ReadLine())
        Dim persons(nbContact - 1) As String


        Do
            Console.WriteLine(vbCrLf & " ----- Ma liste de contacts -----" & vbCrLf)
            Console.WriteLine(" 1-- Saisir des contacts")
            Console.WriteLine(" 2-- Afficher mes contacts")
            Console.WriteLine(" 0--- Quitter" & vbCrLf)
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.Write(" Faites votre choix : ")
            Console.ForegroundColor = ConsoleColor.White

            choixMenu = Console.ReadLine()
            Console.Clear()
            Select Case choixMenu
                Case "1"
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine(vbCrLf & " ------ Saisir les contacts ------" & vbCrLf)
                    Console.ForegroundColor = ConsoleColor.White
                    For i As Integer = 0 To persons.Length - 1
                        Console.Write(vbCrLf & " Nom et prénom du contact N° " & (i + 1) & " : ")
                        persons(i) = Console.ReadLine()
                    Next
                    Console.Clear()
                Case "2"
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine(vbCrLf & " ------ Affichage des contacts ------" & vbCrLf)
                    Console.ForegroundColor = ConsoleColor.White
                    For i As Integer = 0 To persons.Length - 1
                        Console.WriteLine(" - Contact N° " & (i + 1) & " : " & persons(i))
                    Next

                    Console.ForegroundColor = ConsoleColor.DarkCyan
                    Console.Write(vbCrLf & " Appuyez sur une touche pour retourner au menu principal...")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.ReadKey()
                    Console.Clear()
                Case "0"
                    Environment.Exit(0)
                Case Else
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.WriteLine(vbCrLf & " Erreur Menu " & vbCrLf)
                    Console.ForegroundColor = ConsoleColor.DarkCyan
                    Console.Write(vbCrLf & " Appuyez sur une touche pour retourner au menu principal...")
                    Console.ForegroundColor = ConsoleColor.White
                    Console.ReadKey()
                    Console.Clear()
            End Select
        Loop Until choixMenu = "0"


        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.ForegroundColor = ConsoleColor.White
        Console.Read()
    End Sub
End Module
