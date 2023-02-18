Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 27 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Suite Entiers Chaînés (While) --- " & vbCrLf)

        ' # Déclaration de variable
        Dim nombre As Integer

        ' # Récupération saisie utilisateur et affichage informations
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(" Merci de saisir un nombre : ")
        Console.ForegroundColor = ConsoleColor.White
        nombre = Convert.ToInt32(Console.ReadLine())

        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine(vbCrLf & " Les chaînes possible sont : ")
        Console.ForegroundColor = ConsoleColor.White

        ' # Instruction While pour rechercher les chaînes et les afficher
        Dim i As Integer = 1
        While (i <= nombre \ 2 + 1)
            Dim sommeTmp As Integer = i
            Dim chaineTmp As String = nombre & " = " & i
            Dim j As Integer = i + 1
            While (j <= nombre \ 2 + 1)
                sommeTmp += j
                chaineTmp &= "+" & j
                If (sommeTmp = nombre) Then
                    Console.WriteLine(vbTab & chaineTmp)
                    Exit While
                ElseIf (sommeTmp > nombre) Then
                    Exit While
                End If
                j += 1
            End While
            i += 1
        End While


        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.ForegroundColor = ConsoleColor.White
        Console.Read()
    End Sub
End Module
