Imports System

Module Program
    Sub Main(args As String())

        ' ##############
        ' # EXERCICE 5 #
        ' ##############

#Region "Déclaration des variable"
        Dim premierNombre As Integer = 0, deuxiemeNombre = 0, resultat = 0
#End Region


        Console.WriteLine(vbCrLf & " ------- Somme de deux entiers -------" & vbCrLf)

        ' #  Avec une variable type int (entier)
        Console.Write(" Veuillez saisir un nombre : ")
        premierNombre = Convert.ToInt32(Console.ReadLine())
        Console.Write(vbCrLf & " Veuillez saisir un autre nombre : ")
        deuxiemeNombre = Convert.ToInt32(Console.ReadLine())
        resultat = premierNombre + deuxiemeNombre
        Console.WriteLine(vbCrLf & " La somme de ces deux INTEGER est : " & resultat & vbCrLf)
        ' N'est pas équivalent au c#
        Console.WriteLine(vbCrLf & $" La somme de ces deux INTEGER est : " + {premierNombre + deuxiemeNombre}.ToString + vbCrLf)
        Console.WriteLine(Environment.NewLine + $" La somme de ces deux INTEGER est : {premierNombre + deuxiemeNombre}" + Environment.NewLine)



        Console.WriteLine(" ------- Somme de deux Réels -------" & vbCrLf)

        ' #  Avec une variable type Double (décimal)
        Console.Write(" Veuillez saisir un nombre : ")
        Dim premierDouble As Double = Convert.ToDouble(Console.ReadLine())
        Console.Write(vbCrLf & " Veuillez saisir un autre nombre : ")
        Dim deuxiemeDouble As Double = Convert.ToDouble(Console.ReadLine())
        Dim resultatDouble As Double = premierDouble + deuxiemeDouble
        Console.WriteLine(vbCrLf & " La somme de ces deux DOUBLE est : " & resultatDouble & vbCrLf)





        Console.Write(vbCrLf & " Appuyez sur Enter pour fermer le programme...")
        Console.Read()
    End Sub
End Module
