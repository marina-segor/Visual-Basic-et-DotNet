Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 24 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Suite d'entiers chaînés --- " & vbCrLf)

        ' # Récupération saisies utilisateur
        Console.Write(" Merci de saisir un nombre : ")
        Dim nombre As Integer = Convert.ToInt32(Console.ReadLine())


        Console.WriteLine(vbCrLf & " Les chaînes possible sont : " & vbCrLf)
        For i As Integer = 1 To nombre \ 2 + 1
            Dim somme As Integer = i
            Dim chaine As String = nombre & " = " & i
            For j As Integer = i + 1 To nombre \ 2 + 1
                somme += j
                chaine &= "+" & j
                If somme = nombre Then
                    Console.WriteLine(vbTab & chaine)
                    Exit For
                ElseIf somme > nombre Then
                    Exit For
                End If
            Next
        Next




        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
