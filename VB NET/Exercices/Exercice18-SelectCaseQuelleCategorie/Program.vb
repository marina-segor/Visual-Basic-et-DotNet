Module Program
    Sub Main(args As String())

        Console.WriteLine(vbCrLf & " --- Quelle cat�gorie pour mon enfant ? --- " & vbCrLf)

        Console.Write(" Entrez l'�ge de votre enfant : ")

        Dim age As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine(" ")

        '  Avec If...Else If... Else... (borne haute / borne basse)
        'If age < 3 Then
        '    Console.WriteLine(vbCrLf & " Votre enfant est trop jeune")
        'ElseIf age <= 6 Then
        '    Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Baby")
        'ElseIf age <= 8 Then
        '    Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Poussin")
        'ElseIf age <= 10 Then
        '    Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Pupille")
        'ElseIf age <= 12 Then
        '    Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Minime")
        'ElseIf age < 18 Then
        '    Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Cadet")
        'ElseIf age >= 18 Then
        '    Console.WriteLine(" Ce n'est plus un enfant !")
        'End If


        ' # Avec le switch case
        Select Case age
            Case Is < 3
                Console.WriteLine(vbCrLf & " Votre enfant est trop jeune")
            Case Is <= 6
                Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Baby")
            Case Is <= 8
                Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Poussin")
            Case Is <= 10
                Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Pupille")
            Case Is <= 12
                Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Minime")
            Case Is < 18
                Console.WriteLine(vbCrLf & " Votre enfant est dans la cat�gorie Cadet")
            Case Is >= 18
                Console.WriteLine(vbCrLf & " Ce n'est plus un enfant !")
        End Select

        Console.WriteLine("Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module
