Imports System

Module Program
    Sub Main(args As String())

        Dim prenom As String

        Console.Write("------------Concaténation chaînes et entiers ------------" & vbCrLf & vbCrLf)
        Console.WriteLine("Veuillez saisir votre prénom : ")
        prenom = Console.ReadLine()
        Console.WriteLine($"Bonjour {prenom}")

        Console.WriteLine("Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()

    End Sub
End Module
