Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 11 #
        ' ###############



        ' #  Version If...Else simple
        Console.WriteLine(vbCrLf & " --- Le nombre est-il divisible ? --- " & vbCrLf)
        Console.Write(vbCrLf & " Entrez un chiffre/nombre entier : ")
        Dim nombre As Integer = Convert.ToInt32(Console.ReadLine())

        Console.Write(vbCrLf & " Entrez le chiffre/nombre diviseur : ")
        Dim diviseur As Integer = Convert.ToInt32(Console.ReadLine())


        If nombre Mod diviseur = 0 Then
            Console.WriteLine(vbCrLf & " Le chiffre/nombre est divisible par " & diviseur.ToString & vbCrLf)
        Else
            Console.WriteLine(vbCrLf & " Le chiffre/nombre n'est pas divisible par " & diviseur.ToString & vbCrLf)
        End If


        ' #  Version If...Else imbriquée
        Console.WriteLine(vbCrLf & " --- Le nombre est-il divisible ? --- " & vbCrLf)
        Console.Write(vbCrLf & " Entrez un chiffre/nombre entier : ")
        Dim nombre1 As Integer = Convert.ToInt32(Console.ReadLine())


        Console.Write(vbCrLf & " Entrez le chiffre/nombre diviseur : ")
        Dim diviseur1 As Integer = Convert.ToInt32(Console.ReadLine())


        If nombre1 > 9 Then
            If nombre1 Mod diviseur1 = 0 Then
                Console.WriteLine(vbCrLf & " Le nombre est divisible par " & diviseur1 & vbCrLf)
            Else
                Console.WriteLine(vbCrLf & " Le nombre n'est pas divisible par " & diviseur1 & vbCrLf)
            End If
        Else
            If nombre1 Mod diviseur1 = 0 Then
                Console.WriteLine(vbCrLf & " Le chiffre est divisible par " & diviseur1 & vbCrLf)
            Else
                Console.WriteLine(vbCrLf & " Le chiffre n'est pas divisible par " & diviseur1 & vbCrLf)
            End If
        End If

        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
