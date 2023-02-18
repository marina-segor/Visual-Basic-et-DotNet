Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 34 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Tableaux => Est Pair... Est Impair --- " & vbCrLf)


        ' Declaration of Variables
        Dim tab() As Integer
        Dim rnd As New Random()
        Dim nombre As Integer

        ' User Input Retrieval
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(" Combiens de valeurs contiendra le tableau ? : ")
        Console.ForegroundColor = ConsoleColor.White
        If Integer.TryParse(Console.ReadLine(), nombre) Then
            ReDim tab(nombre - 1)
        Else
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write(" Erreur de saisie, veuillez saisir un nombre: ")
            Console.ForegroundColor = ConsoleColor.White
        End If

        ' Assignment of Random Whole Numbers Between 1 and 10 to the Array
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine(vbTab & "Assignation automatique des valeurs..." & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White
        For i As Integer = 0 To tab.Length - 1
            tab(i) = rnd.Next(1, 51)
        Next

        ' Display of Results
        Console.WriteLine(" Affichage des valeurs du tableau : ")
        For i As Integer = 0 To tab.Length - 1
            If tab(i) Mod 2 = 0 Then
                Console.WriteLine(vbTab & "Le nombre " & tab(i) & " est Pair....")
            Else
                Console.WriteLine(vbTab & "Le nombre " & tab(i) & " est Impair...")
            End If
        Next


        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.ForegroundColor = ConsoleColor.White
        Console.Read()
    End Sub
End Module
