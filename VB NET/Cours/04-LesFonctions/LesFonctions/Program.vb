Imports System
Imports System.Threading.Channels

Module Program
    Sub Main(args As String())

        ' ##################
        ' # LES PROCEDURES #
        ' ##################

        ' Une procédure est un ensemble d'instructions qui effectue une fonction précise.
        ' En Visual Basic.NET, il existe deux sortes de procédures : les 'sub' et les 'function' .
        ' Les 'sub' commencent par le mot-clé 'sub' puis finissent par 'end sub' et ne retournent aucune valeur.
        ' Les 'function' débutent par 'function' puis finissent par 'end function' et qui retournent une valeur précise.

        ' !!! Les 'sub' et 'fonctions' ne peuvent pas avoir les mêmes noms sauf si le nombre de paramètres est différent.!!!

        ' ##
        ' # Exemple d'appel de fonction ou sub
        ' ##

        ' Call DemarrerProgramme !!! déconseillé !!!
        ' CalculerPi() 'OK
        ' Ces deux appels sont identiques

        ' # Fonction sans Params et sans retour
        AffichageBienvenue()
        AffichageBienvenue()


        ' # Fonction sans Params et avec retour (int)
        Console.WriteLine(AfficherChiffre().ToString)
        ' # Fonction sans Params et avec retour (string)
        Console.WriteLine(AfficherMessage())


        ' # Fonction Avec Params et sans Retour
        AffichagePerso("Anthony", "C#")


        ' # Fonction Avec Prams et Avec Retour
        Console.WriteLine(Additionner(25, 14))

        ' # PARAMS PAR VALUE OU REF
        Dim Counter As Integer = 0
        IncreaseCounter(Counter)
        IncreaseCounter(Counter)
        IncreaseCounter(Counter)
        IncreaseCounterRef(Counter)
        IncreaseCounterRef(Counter)
        IncreaseCounterRef(Counter)
        Console.WriteLine("Le compteur affiche : " & Counter)

        Dim Liste() As String = New String() {"Maison", "Porte", "Fenetres"}
        Console.WriteLine("Ma liste à l'index 0 Affiche : " & Liste(0))
        ChangeString(Liste)
        Console.WriteLine("Ma liste à l'index 0 Affiche : " & Liste(0))
        ChangeStringRef(Liste)
        Console.WriteLine("Ma liste à l'index 0 Affiche : " & Liste(0))


        MyFunction.waitUser()
    End Sub

    ' #######################################
    ' # Fonction SANS Params et SANS retour #
    ' #######################################
    Sub AffichageBienvenue()

        Console.WriteLine("Bonjour" & vbCrLf & vbTab & $"Bienvenue sur le serveur!")
    End Sub

    ' #######################################
    ' # Fonction AVEC Params et SANS Retour #
    ' #######################################
    Sub AffichagePerso(prenom As String, langage As String)
        Console.WriteLine($"Bonjour {prenom} " & vbCrLf & vbTab & $" Vous apprennez le {langage}!")
    End Sub

    ' #######################################
    ' # Fonction SANS Params et AVEC retour #
    ' #######################################
    Function AfficherChiffre() As Integer
        Dim chiffre As Integer = 10
        Return chiffre
    End Function

    ' #######################################
    ' # Fonction SANS Params et AVEC retour #
    ' #######################################
    Function AfficherMessage() As String
        Dim chaine As String = "Salut!"
        Return chaine
    End Function

    ' #######################################
    ' # Fonction AVEC Params et AVEC retour #
    ' #######################################
    Function Additionner(nb1 As Integer, nb2 As Integer) As Double
        Dim resultat As Double = nb1 + nb2
        ' Return resultat
        Return nb1 + nb2
    End Function

    ' #####################
    ' # Params par VALEUR #
    ' #####################

    'Sub IncreaseCounter(ByVal Counter As Integer) => Comportement par défaut pour les Types Valeur
    Sub IncreaseCounter(Counter As Integer)
        Counter += 1
    End Sub

    ' ########################
    ' # Params par REFERENCE #
    ' ########################
    Sub IncreaseCounterRef(ByRef Counter As Integer)
        Counter += 1
    End Sub

    ' #####################
    ' # Object par VALEUR #
    ' #####################

    Sub ChangeString(ByVal ListeParams() As String) ' Un objet ne peut être passé par valeur
        ListeParams(0) = "Appartement"
    End Sub

    ' #########################
    ' # Object par REFERENCES #
    ' #########################

    'Sub ChangeStringRef( ByRef ListeParams() As String) => Comportement par défaut pour les Types Reference(OBJECT)
    Sub ChangeStringRef(ListeParams() As String)
        ListeParams(0) = "AppartementRef"
    End Sub

End Module
