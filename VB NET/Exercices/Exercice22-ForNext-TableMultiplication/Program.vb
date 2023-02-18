Imports System
Imports System.Threading

Module Program
    Sub Main(args As String())

        Console.WriteLine(vbCrLf & " --- Tables de multiplication --- " & vbCrLf)


        Console.WriteLine(vbCrLf & " Table de 1 :")
        For table As Integer = 1 To 10
            Console.Write(vbTab & "1 x " & table.ToString & " = " & table.ToString * 1 & vbCrLf)
        Next table

        Console.WriteLine(vbCrLf & " Table de 2 :")
        For table As Integer = 1 To 10
            Console.Write(vbTab & "2 x " & table.ToString & " = " & table.ToString * 2 & vbCrLf)
        Next table

        Console.WriteLine(vbCrLf & " Table de 9 :")
        For table As Integer = 1 To 10
            Console.Write(vbTab & "9 x " & table.ToString & " = " & table.ToString * 9 & vbCrLf)
        Next table

        Console.WriteLine(vbCrLf & " Table de 10 :")
        For table As Integer = 1 To 10
            Console.Write(vbTab & "10 x " & table.ToString & " = " & table.ToString * 10 & vbCrLf)
        Next table

        Console.WriteLine(vbCrLf & " --- Deuxi�me m�thode--- " & vbCrLf)

        ' Boucle it�rative allant de 1 � 10 pour les num�ros de table
        For i As Integer = 1 To 10
            Console.WriteLine(vbCrLf & " Table de " & i & " : ")
            ' Boucle it�rative imbriqu�e allant de 1 � 10 pour la deuxi�me partie de la table
            For j As Integer = 1 To 10
                Console.WriteLine(vbTab & i & " x " & j & " = " & i * j)
            Next
        Next

        Console.WriteLine(vbCrLf & "Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module
