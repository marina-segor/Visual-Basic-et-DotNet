Module Program
    Sub Main(args As String())


        Dim lettre As String

        Console.Write("------La lettre est elle une voyelle ?-------" & vbCrLf & vbCrLf)
        Console.Write("Entrez une lettre : ")


        lettre = Console.ReadLine().ToLower()

        If (lettre = "a") Or (lettre = "e") Or (lettre = "i") Or (lettre = "o") Or (lettre = "u") Or (lettre = "y") Then
            Console.WriteLine("Cette lettre est une voyelle !")
        Else
            Console.WriteLine("Cette lettre est une consonne ! ")
        End If

        Console.WriteLine("Appuyez sur ENTER pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module
