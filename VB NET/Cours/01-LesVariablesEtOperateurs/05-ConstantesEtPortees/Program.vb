Imports System
Imports System.Net

Module Program
    Sub Main(args As String())

        ' ########################
        ' # PORTEE DES VARIABLES #
        ' ########################


        ' # Mot-clé #           # Portée de la variable #
        '   Public              Partout dans le programme
        '   Private             Partout dans la classe ou le module où elle a été créée
        '   Dim                 Seulement dans la procédure ou la fonction créée
        '   Protected           Les membres Protected sont similaires aux Private, mais ils ont une particularité en cas d'héritage.
        '   Friend              Les membres Friend ne sont accessibles qu'à l'intérieur du projet, et pas par des éléments extérieurs au projet en cours
        '   Shared              Permet de partager une variable. N'est pas indispensable

        ' ##
        ' # EXEMPLES DE DECLACARTION
        ' ##

        ' Public Nom As String = "Anthony"

        ' Private Age As Integer = 25

        ' Dim Annee As Short = 2023

        ' Protected Celerite As Long = 299 792 458

        ' Friend VitesseSon As Short = 1234,8

        ' Shared Trouve As Bool = true



        ' ##################
        ' # LES CONSTANTES #
        ' ##################

        Console.WriteLine("------------ LES CONSTANTES ------------" & vbCrLf)


        ' Les constantes sont des variables qui ne peuvent pas être la cible d'une assignation.
        ' C'est-à-dire que leur valeur ne peut pas être modifiée.
        ' Pour déclarer une constante, on utilise le mot-clé « Const ».
        ' Un avantage majeur des constantes est qu'elles améliorent la lisibilité du code et son exécution.

        ' ##
        ' # Exemples de constantes
        ' ##

        ' Private Const Pi As Decimal = 3.14
        Const Pi As Decimal = 3.14

        ' Public Const Plat_Prefere As String = "Pates"
        Const Plat_Prefere As String = "Pates"
        Console.WriteLine(Plat_Prefere) 'Affiche mon plat préféré !!

        'Ensuite on peut les utiliser
        Dim Rayon As Decimal = 5 'Soit un cercle de rayon 5
        Dim AireCercle, PerimetreCercle As Decimal

        AireCercle = Pi * Rayon ^ 2
        PerimetreCercle = 2 * Pi * Rayon

        ' Affichage des r&ésultats
        Console.WriteLine($"L'aire du cercle de rayon {Rayon}cm est de {AireCercle}cm²")
        Console.WriteLine($"Le périmetre du cercle de rayon {Rayon}cm est de {PerimetreCercle}cm")
        Console.WriteLine(vbCrLf & "----------------------------------------" & vbCrLf)

        ' #############
        ' # LES ENUMS #
        ' #############

        Console.WriteLine("-------------- LES ENUMS ---------------")


        ' Private Enum Action
        '    Ajouter
        '    Supprimer
        '    Inserer
        '    Selectionner
        ' End Enum

        ' les constantes ainsi créées sont 
        ' Action.Ajouter
        ' Action.Supprimer
        ' Action.Inserer
        ' Action.Selectionner


        ' Dim EnumAction As Action = 2
        Dim EnumAction As Action = Action.Inserer


        Dim Actionstring As String = EnumAction.ToString()
        Dim ActionInt As Integer = EnumAction


        Console.WriteLine(Actionstring)
        Console.WriteLine(ActionInt.ToString())


        ' Private Enum Erreur
        '    Logique ' 0
        '    Execution ' 1
        '    Syntaxe ' 2
        '    Grammataire ' 3
        ' End Enum

        ' les constantes ainsi créées sont 
        ' Erreur.Logique
        ' Erreur.Execution
        ' Erreur.Syntaxe
        ' Erreur.Grammaire


        ' ##
        ' # ENUM ERREUR
        ' ##

        Console.WriteLine("------- Menu Erreur -------")
        Console.WriteLine("1-Logique")
        Console.WriteLine("2-Execution")
        Console.WriteLine("3-Syntaxe")
        Console.WriteLine("4-Grammaire")
        Console.Write("Faite votre choix => ")

        Dim EnumErreur As Erreur = Convert.ToByte(Console.ReadLine()) - 1

        Console.WriteLine(vbCrLf & "Vous avez fait le choix : " & EnumErreur + 1)
        Console.WriteLine("La valeur est : " & EnumErreur.ToString() & vbCrLf)

        Console.WriteLine("----------------------------------------" & vbCrLf)



        ' ##
        ' # ENUM SECURITYLEVEL
        ' ##

        Console.WriteLine("------- Menu Security Level -------")
        Console.WriteLine("IllegalEntry => type -1")
        Console.WriteLine("MinimumSecurity => type 0")
        Console.WriteLine("MaximumSecurity => type 1")
        Console.Write("Faite votre choix => ")

        Dim EnumSecurity As SecurityLevel = Convert.ToByte(Console.ReadLine())

        Console.WriteLine("Vous avez fait le choix : " & EnumSecurity)
        Console.WriteLine("Le niveau de sécurité est : " & EnumSecurity.ToString())

        Console.WriteLine("----------------------------------------" & vbCrLf)

        Console.WriteLine("Appuyez sur ENTER pour fermer le programme...")
        Console.Read()

        ' ##
        ' # ENUM INTERFACECOLORS
        ' ##

        ' Public Enum InterfaceColors
        '    MistyRose = &HE1E4FF&
        '    SlateGray = &H908070&
        '    DodgerBlue = &HFF901E&
        '    DeepSkyBlue = &HFFBF00&
        '    SpringGreen = &H7FFF00&
        '    ForestGreen = &H228B22&
        '    Goldenrod = &H20A5DA&
        '    Firebrick = &H2222B2&
        ' End Enum
    End Sub
    'Exemple
    Private Enum Erreur As Byte
        Logique ' 0
        Execution ' 1
        Syntaxe ' 2
        Grammaire ' 3
    End Enum
    Private Enum Action As Byte
        Ajouter ' 0
        Supprimer ' 1
        Inserer ' 2
        Selectionner ' 3
    End Enum
    Private Enum SecurityLevel
        IllegalEntry = -1 ' -1
        MinimumSecurity = 0 ' 0
        MaximumSecurity = 1 ' 1
    End Enum
    Public Enum InterfaceColors
        MistyRose = &HE1E4FF&
        SlateGray = &H908070&
        DodgerBlue = &HFF901E&
        DeepSkyBlue = &HFFBF00&
        SpringGreen = &H7FFF00&
        ForestGreen = &H228B22&
        Goldenrod = &H20A5DA&
        Firebrick = &H2222B2&
    End Enum

End Module
