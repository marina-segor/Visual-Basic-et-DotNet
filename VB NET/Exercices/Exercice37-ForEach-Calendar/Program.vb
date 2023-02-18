Imports System

Module Program
    Sub Main(args As String())

        ' ###############
        ' # EXERCICE 37 #
        ' ###############

        Console.WriteLine(vbCrLf & " --- ForeEach => Pour chaque mois... --- " & vbCrLf)


        ' # D�claration des variables
        Dim moisAnnee As String() = {"Janvier", "F�vrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Ao�t", "Septembre", "Octobre", "Novembre", "D�cembre"}


        ' # Enumeration du tableau avec foreach
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine(" Enum�ration du tableau de mois avec un foreach :")
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
