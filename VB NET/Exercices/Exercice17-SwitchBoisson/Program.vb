Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("------- Quelle boisson souhaitez-vous ? -------" & vbCrLf)

        Console.WriteLine("------- Menu Select Case -------" & vbCrLf)
        Console.WriteLine(vbTab & "1) Eau Plate")
        Console.WriteLine(vbTab & "2) Eau Gazeuse")
        Console.WriteLine(vbTab & "3) Coca-Cola")
        Console.WriteLine(vbTab & "4) Fanta")
        Console.WriteLine(vbTab & "5) Sprite")
        Console.WriteLine(vbTab & "6) Orangina")
        Console.WriteLine(vbTab & "7) 7Up")
        Console.Write(vbCrLf & vbTab & "Faite votre choix (1 à 7) => ")

        Dim code As Byte = Convert.ToByte(Console.ReadLine())

        Select Case code
            Case 1
                Console.ForegroundColor = ConsoleColor.DarkBlue
                Console.WriteLine(vbCrLf & "Votre Eau Plate est servie..." & vbCrLf)
            Case 2
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine(vbCrLf & "Votre Eau Gazeuse est servie..." & vbCrLf)
            Case 3
                Console.ForegroundColor = ConsoleColor.DarkCyan
                Console.WriteLine(vbCrLf & "Votre Coca-Cola est servi..." & vbCrLf)
            Case 4
                Console.ForegroundColor = ConsoleColor.DarkMagenta
                Console.WriteLine(vbCrLf & "Votre Fanta est servi..." & vbCrLf)
            Case 5
                Console.ForegroundColor = ConsoleColor.DarkGreen
                Console.WriteLine(vbCrLf & "Votre Sprite est servi..." & vbCrLf)
            Case 6
                Console.ForegroundColor = ConsoleColor.DarkYellow
                Console.WriteLine(vbCrLf & "Votre Orangina est servi..." & vbCrLf)
            Case 7
                Console.ForegroundColor = ConsoleColor.Magenta
                Console.WriteLine(vbCrLf & "Votre 7Up est servi..." & vbCrLf)

                Console.ReadLine()
                Environment.Exit(0)
            Case Else
                Console.WriteLine(vbCrLf & "Erreur choix menu!")
        End Select

        Console.ForegroundColor = ConsoleColor.White
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
