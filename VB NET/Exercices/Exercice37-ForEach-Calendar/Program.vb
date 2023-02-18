Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 37 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- ForeEach => Pour chaque mois... --- " & vbCrLf)


        ' # Déclaration des variables
        Dim moisAnnee As String() = {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"}


        ' # Enumeration du tableau avec foreach
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine(" Enumération du tableau de mois avec un foreach :")
        Console.ForegroundColor = ConsoleColor.White

        Dim chaine As String = ""

        For Each mois As String In moisAnnee
            Console.WriteLine(" " & chaine & mois)
            chaine &= "   "
        Next



        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.ForegroundColor = ConsoleColor.White
        Console.Read()
    End Sub
End Module
