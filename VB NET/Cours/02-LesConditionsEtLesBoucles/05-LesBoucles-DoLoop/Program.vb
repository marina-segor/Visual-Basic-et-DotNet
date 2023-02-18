Imports System

Module Program
    Sub Main(args As String())

        ' ############################
        ' # BOUCLE DO... LOOP WHILE #
        ' ############################

        ' ##
        ' # Syntaxe
        ' ##

        ' Do
        '     Instructions
        ' Loop Until Condition

        ' Do
        '     'Instructions
        ' Loop While Condition

        ' Do            Mot-cl� qui ouvre la boucle.
        ' Loop          Mot-cl� qui ferme la boucle.
        ' While         Mot-cl� qui signifie � Tant que �
        ' Until         Mot-cl� qui signifie � Jusqu'� ce que �
        ' Condition     La condition pour rester dans un Loop While ou pour sortir d'un Loop Until.

        ' !!! Il faut pr�ciser apr�s le � Loop � une condition pr�c�d�e de � While � ou � Until �. Dans le cas contraire, la boucle est sans fin !!!

        'Exemple avec Until
        Dim i As Integer = 10
        Do
            i += 1 'incr�mente i de 1
            Console.WriteLine("caca" & i.ToString) 'affiche la valeur de i
        Loop Until i = 10 'Quand i = 10 on sort de la boucle.

        'Exemple avec While
        Dim Fichier As String
        Do
            Console.WriteLine("Veuillez saisir : ""NomDeMonFichier""")
            Fichier = Console.ReadLine()
        Loop While Fichier <> "NomDeMonFichier" 'Tant que Fichier n'est pas �gal � NomDeMonFichier alors on boucle sinon on sort.

        Console.WriteLine(vbCrLf & "Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module
