Imports System

Module Program
    Sub Main(args As String())

        ' ############################
        ' # BOUCLE WHILE...END WHILE #
        ' ############################

        ' ##
        ' # Syntaxe
        ' ##

        ' While Condition
        '     ' Instructions executées autant de fois que de tour de boucle
        ' End While

        ' While : Mot-clé permettant d'ouvrir la boucle.(tant que...)
        ' End While : Mot-clé qui ferme la boucle.
        ' Condition: La condition pour rester dans la boucle.


        ' ##
        ' # Exemple
        ' ##

        Dim Compteur As Integer = 0
        While Compteur < 20 'Dès que Compteur = 20, on sort de la boucle.
            Compteur += 1 'incrémente le compteur de 1
            Console.WriteLine(Compteur.ToString) 'affiche le compteur
        End While

        Console.WriteLine("Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module
