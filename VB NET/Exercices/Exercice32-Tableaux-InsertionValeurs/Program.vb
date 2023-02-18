Imports System

Module Program
    Sub Main(args As String())

        Dim Tableau(6) As Integer

        Tableau(0) = 1
        Tableau(1) = 2
        Tableau(2) = 3
        Tableau(3) = 4
        Tableau(4) = 5
        Tableau(5) = 6
        Tableau(6) = 7

        ' ##
        ' # ITERATION D'UN TABLEAU
        ' ##

        Console.WriteLine("Itération de Tableau : " & vbCrLf)
        Dim Counter As Integer = 0
        For Each Item As Integer In Tableau
            Console.WriteLine(vbTab & "En index " & Counter & " : " & Item.ToString)
            Counter += " "
        Next Item

        Console.WriteLine(vbCrLf & "Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module
