Imports System

Module Program
    Sub Main(args As String())
        ' D�claration
        ' Dim <nom> As <Type> = New <Type>()
        Dim toutou1 As Chien

        ' Nothing correspond � l'absence de valeur
        ' Un objet non allou� vaut Nothing
        If toutou1 Is Nothing Then
            Console.WriteLine("Toutou1 n'est pas affect�")
        End If

        toutou1 = New Chien()

        ' D�claration et instanciation
        ' toutou2 est un objet ou une instance de classe
        Dim toutou2 As New Chien()

        ' Acc�der aux attributs de classes
        ' <objet>.<attribut>
        toutou2.age = 3
        toutou2.nom = "Milou"

        ' appeler une m�thode d'instance
        ' <objet>.<m�thode>(<param�tres>)
        toutou2.Aboyer()

        toutou2.SePresenter()

        toutou2 = Nothing

        ' L'objet a �t� lib�r� de la m�moire
        ' Ses attributs et m�thodes ne sont donc plus accessibles
        'Try
        '    toutou2.Aboyer()
        'Catch ex As Exception
        '    Console.WriteLine(ex)
        'End Try

        toutou1.Couleur = "Rouge"
        Console.WriteLine(toutou1.Couleur)

        Dim monChat As New Chat()
        monChat.Nom = "F�lix"
        monChat.Taille = 12.2
        monChat.EstVaccine = True


        monChat.DetailChat()

        Dim evian As New Bouteille()

        evian.Volume = 1
        evian.Remplir(0.5)
        Console.WriteLine(evian.VolumeEnGramme())

        evian.contenu = "eau"

        Dim simba As Lion
        ' Utilisation du constructeur avec 4 param�tres : Sub New(<param�tres>)
        simba = New Lion("Simba", "Or", 7, 45)
        simba.Age -= 1
        simba.AfficherLion()

        ' Utilisation du constructeur vide : Sub New()
        Dim defaultLion As New Lion()
        defaultLion.AfficherLion()


        Console.WriteLine("Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module
