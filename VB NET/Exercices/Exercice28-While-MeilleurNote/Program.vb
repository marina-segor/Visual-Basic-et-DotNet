Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 28 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Meilleure, Moins Bonne et Moyenne des Notes (While) --- " & vbCrLf)

        'Déclaration des variables
        Dim maxNote As Double = 0
        Dim minNote As Double = 20
        Dim moyNote As Double = 0
        Dim noteTmp As Double = 0
        Dim nbNote As Integer = 0

        'While pour les saisies des notes de l'utilisateur
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine(" Veuillez saisir les notes : ")
        Console.WriteLine(vbTab & "(999 pour calculer)" & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White
        While noteTmp <> 999
            noteTmp = 0
            Console.Write(" - Merci de saisir la note " & (nbNote + 1) & " (sur /20) : ")

            ' # Tant que la convertion de la saisie utilisateur n'est pas un success
            While Double.TryParse(Console.ReadLine(), noteTmp) = False
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine(" Erreur de saisie, merci de saisir un chiffre/nombre! ")
                Console.ForegroundColor = ConsoleColor.White
                Console.Write(" - Merci de saisir la note " & (nbNote + 1) & " (sur /20) : ")
            End While

            If noteTmp = 999 Then
                Exit While
            ElseIf noteTmp > 20 OrElse noteTmp < 0 Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine(vbTab & " Erreur de saisie, la note est sur 20 !")
                Console.ForegroundColor = ConsoleColor.White
                Continue While
            Else
                ' # Ajout de la nouvelle note à la moyenne des notes
                moyNote += noteTmp
                nbNote += 1
                ' # Vérification si la note est supérieure à maxNote
                If (noteTmp > maxNote) Then
                    maxNote = noteTmp
                End If
                ' # Vérification si la note est inférieure à minNote
                If (noteTmp < minNote) Then
                    minNote = noteTmp
                End If
            End If
        End While

        ' # Calcul de la moyenne
        moyNote = Math.Round(moyNote / nbNote, 1)


        ' # Affichage des résultats de l'utilisateur
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(" la meilleure note est " & maxNote & "/20")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(" la moins bonne note est " & minNote & "/20")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(" La moyenne des " & nbNote & " notes est " & moyNote & "/20" & vbCrLf)


        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.ForegroundColor = ConsoleColor.White
        Console.Read()
    End Sub
End Module
