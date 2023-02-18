Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 21 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- Menu et Sous-Menu --- " & vbCrLf)


        Console.WriteLine(" Table des matières :" & vbCrLf)

        ' Permet de faire une boucle itérative allant de 1 à 3 pour les chapitres
        For i As Integer = 1 To 3
            Console.WriteLine(vbTab & "Chapitre " & i)
            ' Boucle imbriquée alant de 1 à 3 pour les sous-menus
            For j As Integer = 1 To 3
                Console.WriteLine(vbTab & vbTab & "-Partie " & i & "." & j)
            Next
        Next


        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
