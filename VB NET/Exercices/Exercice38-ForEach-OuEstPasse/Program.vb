Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 38 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- ForeEach => Où est passé...? --- " & vbCrLf)

        Dim tab(9) As Integer
        Dim aleatoire As New Random()
        Dim chaine As String = ""
        Dim nb As Integer = 0
        Dim index As Integer


        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine(" Affectation des valeures... " & vbCrLf)
        Console.ForegroundColor = ConsoleColor.White

        For i As Integer = 0 To tab.Length - 1
            tab(i) = aleatoire.Next(1, 51)
        Next

        Console.WriteLine(" Affichage avant triage : " & vbCrLf)
        For Each i As Integer In tab
            Console.WriteLine(" " & chaine & i)
            chaine &= "  "
        Next

        nb = tab(0)
        Array.Sort(tab)
        chaine = " "

        Console.WriteLine(" Après : " & vbCrLf)
        For Each i As Integer In tab
            Console.WriteLine(" " & chaine & i)
            chaine &= "  "
        Next

        index = Array.IndexOf(tab, nb) + 1

        Console.WriteLine(Environment.NewLine)
        Console.WriteLine(" Le nombre {0} se trouvait en 1ère position", nb)
        Console.WriteLine(" Il se retrouve à la position {0} après triage.", index)



        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.ForegroundColor = ConsoleColor.White
        Console.Read()
    End Sub
End Module
