Imports System

Module Program
    Sub Main(args As String())

#Region "calcul p�rim�tre et aire carr�"



        Console.WriteLine("---Calcul du p�rim�tre et de l'aire d'un carr�---" & vbCrLf)

        Console.WriteLine("Entrez la longueur d'un c�t� d'un carr� (en cm) : ")
        Dim longueurC As Integer = Console.ReadLine()
        Dim cmcarre As String = longueurC * 4
        Dim aire As String = longueurC * longueurC

        Console.WriteLine($"Le p�rim�tre du carr� est de {cmcarre} cm" & vbCrLf)

        Console.WriteLine($"L'aire du carr� est de {aire} cm�" & vbCrLf)

#End Region

#Region "Calcul perimetre et aire rectangle"

        Console.WriteLine("---Calcul du p�rim�tre et de l'aire d'un carr�---" & vbCrLf)

        Console.WriteLine("Entrez la longueur du rectangle (en cm) : " & vbCrLf)
        Dim longueurRec As Integer = Console.ReadLine()
        Console.WriteLine("Entrez la largeur du rectangle (en cm) : " & vbCrLf)
        Dim LargeurRec As Integer = Console.ReadLine()
        Dim perimetre As String = longueurC * LargeurRec
        Dim aireRec As String = longueurC * LargeurRec * 2

        Console.WriteLine($"Le p�rim�tre du carr� est de {perimetre} cm" & vbCrLf)

        Console.WriteLine($"L'aire du carr� est de {aireRec} cm�" & vbCrLf)

#End Region

        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
