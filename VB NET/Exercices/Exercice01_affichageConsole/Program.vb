Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(vbCrLf & " *** Ma Liste de Todo ***" & vbCrLf)

        Console.WriteLine(" Aujourd'hui je dois faire : " & vbCrLf)
        Console.WriteLine(vbTab & "- Apprendre le VB")
        Console.WriteLine(vbTab & "- Apprendre � utiliser Visual Studio")
        Console.WriteLine(vbTab & "- Comprendre l'affichage Console")
        Console.WriteLine(vbTab & "- Cr�er mon r�pertoire ""c:\MesExercices\"" pour les ranger")
        Console.WriteLine(vbTab & "- Appr�cier les fonctionnalit�s .NET")






        Console.WriteLine(vbCrLf & vbCrLf & " Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module