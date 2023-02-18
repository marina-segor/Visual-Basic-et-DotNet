Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(vbCrLf & " *** Ma Liste de Todo ***" & vbCrLf)

        Console.WriteLine(" Aujourd'hui je dois faire : " & vbCrLf)
        Console.WriteLine(vbTab & "- Apprendre le VB")
        Console.WriteLine(vbTab & "- Apprendre à utiliser Visual Studio")
        Console.WriteLine(vbTab & "- Comprendre l'affichage Console")
        Console.WriteLine(vbTab & "- Créer mon répertoire ""c:\MesExercices\"" pour les ranger")
        Console.WriteLine(vbTab & "- Apprécier les fonctionnalités .NET")






        Console.WriteLine(vbCrLf & vbCrLf & " Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module