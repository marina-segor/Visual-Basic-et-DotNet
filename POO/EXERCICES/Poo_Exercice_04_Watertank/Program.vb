Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine(WaterTank.PoidsAVide)
        Dim citerne1 As New Citerne("premiere citerne")


        Console.WriteLine("Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module
