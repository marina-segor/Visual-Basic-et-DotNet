Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 36 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Tableaux => Tableau de notes --- " & vbCrLf)

        Dim notes() As Double = New Double() {}
        Dim moyenne As Double = 0.0, noteTmp = 0.0
        Dim tmp As Integer = 0

        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(" Combiens de notes comportera le tableaux : ")
        Console.ForegroundColor = ConsoleColor.White


        While Integer.TryParse(Console.ReadLine(), tmp) <> True
            Console.ForegroundColor = ConsoleColor.Red
            Console.Write(" Erreur de saisie, merci de saisir un chiffre/nombre : ")
            Console.ForegroundColor = ConsoleColor.White
        End While

        ReDim notes(tmp - 1)

        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine(" Merci de saisir les " & notes.Length & " notes" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White

        For i As Integer = 0 To notes.Length - 1

            Console.Write(vbTab & "=> Note " & (i + 1) & " : ")

            While Double.TryParse(Console.ReadLine(), noteTmp) <> True
                Console.ForegroundColor = ConsoleColor.Red
                Console.Write(" Erreur, merci de saisir un chiffre/nombre pour la note " & (i + 1) & " : ")
                Console.ForegroundColor = ConsoleColor.White
            End While
            notes(i) = noteTmp
        Next

        Console.ForegroundColor = ConsoleColor.DarkYellow
        Console.WriteLine("")
        Console.WriteLine(" --- Liste des notes ---")
        Console.ForegroundColor = ConsoleColor.White
        For i As Integer = 0 To notes.Length - 1
            Console.WriteLine(" La note " & (i + 1) & " est de : " & notes(i) & "/20")
            moyenne += notes(i)
        Next
        Console.WriteLine("")

        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(vbTab & "La note max est : " & notes.Max() & "/20")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbTab & "La note min est : " & notes.Min() & "/20")
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine(vbTab & "La moyenne est de : " & notes.Average() & "/20" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White



        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.ForegroundColor = ConsoleColor.White
        Console.Read()
    End Sub
End Module
