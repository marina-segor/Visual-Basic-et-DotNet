Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine(vbCrLf & " --- Je compte jusqu'� 10 --- " & vbCrLf)

        Console.WriteLine(" Je commence � compter " & vbCrLf)
        Dim i As Integer
        For i = 1 To 10
            Console.WriteLine(vbTab & i.ToString())
        Next i


        Console.WriteLine(vbCrLf & "Super ! je sais compter jusqu'� 10 !")

        Console.WriteLine("Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module
