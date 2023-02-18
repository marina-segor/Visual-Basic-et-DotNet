Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 33 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Tableaux => Table ASCII --- " & vbCrLf)


        ' # Declaration and Initialization of the Character Array
        Dim alphabet(25) As Char
        Dim chaine As String = " "

        ' # Assigning Values
        For i As Integer = 0 To alphabet.Length - 1
            alphabet(i) = Convert.ToChar(65 + i)
        Next

        ' # Displaying Values
        For i As Integer = 0 To alphabet.Length - 1
            Console.WriteLine(" " & chaine & alphabet(i))
            chaine += "  "
        Next

        chaine = " "
        For Each item In alphabet
            Console.WriteLine(chaine & item)
            chaine += "  "
        Next

        'For i As Integer = 65 To 90
        '    Console.WriteLine(chaine & Convert.ToChar(i))
        '    chaine += "  "
        'Next


        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.ForegroundColor = ConsoleColor.White
        Console.Read()
    End Sub
End Module
