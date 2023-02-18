Imports System

Module Program
    Sub Main(args As String())

#Region "Fonctionnement Console"

        ' #####################
        ' # Méthode Affichage #
        ' #####################


        ' # Méthode Write de la Class console pour afficher une chaine sans retour à la ligne ensuite
        Console.Write("Bla")
        Console.Write("Bla")
        Console.Write("Bla")

        ' # Méthode WriteLine de la Class console pour afficher une chaine avec retour à la ligne ensuite
        Console.WriteLine("Prise en main de la console (ConsoleWriteline)...")

        ' ###################################
        ' # Récupération saisie Utilisateur #
        ' ###################################

        Dim prenom As String

        ' # Read() Récuper le flux entrant standard et le retourne
        ' prenom = Console.Read() ' A eviter

        ' # ReadLine() Récuper le flux entrant standard et le retourne une chaine de caractère (String)
        Console.Write("Veuillez saisir votre prénom : ")
        prenom = Console.ReadLine()
        Console.WriteLine(prenom)
        Console.Write("Saisis ton âge d'aujourd'hui et je te dis quel âge tu auras dans un an : ")

        Dim age As Integer

        age = Convert.ToInt32(Console.ReadLine())

        age += 1

        Console.Write("Votre age est de : ")
        Console.WriteLine(age)
        Console.Write("Type de la variable age : ")
        Console.WriteLine(age.GetType().ToString)

#End Region

#Region "Concaténation"
        Console.WriteLine(vbTab & "Mon prénom est " + prenom + " et mon age est de " + age.ToString + " ans." & vbCrLf) ' Concaténation avec opérateur + applique a un typre chaine
        Console.WriteLine(vbTab & "Mon prénom est " & prenom & " et mon age est de " & age & " ans." & vbCrLf) ' Concaténation avec opérateur & (issu du VB)
        Console.WriteLine(vbTab & "Mon prénom est {0} et mon age est de {1} ans." & vbCrLf, prenom, age) ' Sucharge de la méthode WRITELINE
        Console.WriteLine(vbTab & $"Mon prénom est {prenom} et mon age est de {age} ans." & vbCrLf) ' Litteraux de Gabarits


#End Region


#Region "coloration police d'affichage"
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.WriteLine("Je suis en bleu")
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("je suis red")
        Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine("je suis cyaan")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("je suis blanc")

#End Region

#Region "Les caractères spéciaux"

        Console.WriteLine("c:\repertoire\monFichier.vb")


#End Region

#Region "Mise en forme Console"
        ' vbTab pour faire une tabulation
        ' vbCrLf pour retourner à la ligne
#End Region

#Region "DateTime"
        Dim DateTime As Date = DateTime.Now

        Console.WriteLine(vbCrLf & "On est le {0:d} et il est {0:t}", DateTime)


#End Region


        Console.WriteLine("Appuyez sur une touche pour fermer le programme...")
        Console.ReadKey()
    End Sub
End Module

