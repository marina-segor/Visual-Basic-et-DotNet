Imports System

Module Program
    Sub Main(args As String())

        ' Le nombre de chiens est initialis� � 0
        ' Acc�s un un attribut de classe partag�e
        ' <Classe>.<attribut>
        Console.WriteLine(Chien.nombreChiens)

        Dim rex As New Chien("Rex")
        Dim milou As New Chien("Milou")
        Dim lassie As New Chien("Lassie")
        Dim rantanplan As New Chien("rantanplan")

        Console.WriteLine($"Il y a {Chien.nombreChiens} chiens instanci�s")

        ' M�thode de classe partag�e
        ' <Classe>.<Methode>(<param�tres>)
        Console.WriteLine(Chien.AgeHumainVersChien(12))

        ' Acc�s � une propri�t� partag�e de la classe
        ' <Classe>.<Propri�t�>
        Chien.NomLatin = "Canis"

        Console.WriteLine(Chien.NomLatin)



    End Sub
End Module
