Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 25 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Meilleure, Moins Bonne et Moyenne des Notes --- " & vbCrLf)

        ' # Déclaration des variables
        Dim nbNotes As Integer
        Dim maxNote As Double = 0
        Dim minNote As Double = 20
        Dim moyNote As Double = 0

        ' # Récupération saisies utilisateur
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(" Combien de notes allez-vous saisir ? : ")
        Console.ForegroundColor = ConsoleColor.White
        nbNotes = Convert.ToInt32(Console.ReadLine())

        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine(vbCrLf & " Veuillez saisir les " & nbNotes & " notes :" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White

        For i As Integer = 1 To nbNotes
            Console.Write(vbTab & "- Merci de saisir la note " & i & " (sur /20) : ")
            Dim noteTmp As Double = Convert.ToDouble(Console.ReadLine())
            moyNote += noteTmp
            If noteTmp > maxNote Then
                maxNote = noteTmp
            End If
            If noteTmp < minNote Then
                minNote = noteTmp
            End If
        Next

        '# Calcul de la moyenne
        moyNote = Math.Round(moyNote / nbNotes, 2)

        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Résultats ")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(vbCrLf & vbTab & "La meilleure note est " & maxNote & "/20")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbTab & "La moins bonne note est " & minNote & "/20")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(vbTab & "La moyenne des notes est " & moyNote & "/20" & vbCrLf)

        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
