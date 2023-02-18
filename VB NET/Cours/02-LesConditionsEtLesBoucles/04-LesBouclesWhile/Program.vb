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
        '     ' Instructions execut�es autant de fois que de tour de boucle
        ' End While

        ' While : Mot-cl� permettant d'ouvrir la boucle.(tant que...)
        ' End While : Mot-cl� qui ferme la boucle.
        ' Condition: La condition pour rester dans la boucle.


        ' ##
        ' # Exemple
        ' ##

        Dim Compteur As Integer = 0
        While Compteur < 20 'D�s que Compteur = 20, on sort de la boucle.
            Compteur += 1 'incr�mente le compteur de 1
            Console.WriteLine(Compteur.ToString) 'affiche le compteur
        End While

        Console.WriteLine("Appuyez sur ENTER pour fermer le programme...")
        Console.Read()
    End Sub
End Module
