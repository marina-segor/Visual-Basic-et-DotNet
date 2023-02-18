Imports System

Module Program
    Sub Main(args As String())

#Region "calcul périmètre et aire carré"



        Console.WriteLine("---Calcul du périmètre et de l'aire d'un carré---" & vbCrLf)

        Console.WriteLine("Entrez la longueur d'un côté d'un carré (en cm) : ")
        Dim longueurC As Integer = Console.ReadLine()
        Dim cmcarre As String = longueurC * 4
        Dim aire As String = longueurC * longueurC

        Console.WriteLine($"Le périmètre du carré est de {cmcarre} cm" & vbCrLf)

        Console.WriteLine($"L'aire du carré est de {aire} cm²" & vbCrLf)

#End Region

#Region "Calcul perimetre et aire rectangle"

        Console.WriteLine("---Calcul du périmètre et de l'aire d'un carré---" & vbCrLf)

        Console.WriteLine("Entrez la longueur du rectangle (en cm) : " & vbCrLf)
        Dim longueurRec As Integer = Console.ReadLine()
        Console.WriteLine("Entrez la largeur du rectangle (en cm) : " & vbCrLf)
        Dim LargeurRec As Integer = Console.ReadLine()
        Dim perimetre As String = longueurC * LargeurRec
        Dim aireRec As String = longueurC * LargeurRec * 2

        Console.WriteLine($"Le périmètre du carré est de {perimetre} cm" & vbCrLf)

        Console.WriteLine($"L'aire du carré est de {aireRec} cm²" & vbCrLf)

#End Region

        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
