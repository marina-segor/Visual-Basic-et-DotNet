Imports System
Imports System.ComponentModel.DataAnnotations.Schema

Module Program
    Sub Main(args As String())

        Dim nom As String, prenom
        Dim age As Integer


        Console.Write("------------Concaténation chaînes et entiers ------------" & vbCrLf & vbCrLf)
        Console.Write("Veuillez saisir votre nom : ")
        nom = Console.ReadLine()
        Console.Write("Veuillez saisir votre prenom : ")
        prenom = Console.ReadLine()
        Console.Write("Veuillez saisir votre age : ")
        age = Console.ReadLine()


        Console.WriteLine($"Bonjour {nom} {prenom}, vous avez {age} ans")

        Console.WriteLine("Appuie sur une touche pour fermer")
        Console.ReadKey()
    End Sub
End Module
